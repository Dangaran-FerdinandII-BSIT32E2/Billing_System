Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmRestockProduct
    Public productid As String
    Public supplierid As String

    Private email As String

    Public listofProductIds As New List(Of String)

    Dim newValue As String = 0
    Private Sub frmRestockProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call addtolist(productid)
        Call loadInformation()
    End Sub

    Public Sub addtolist(productid As String)
        If Not listofProductIds.Contains(productid) Then
            listofProductIds.Add(productid)
        End If

        Call loadInformation()
    End Sub
    Public Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            ListView1.Items.Clear()

            For Each productid As String In listofProductIds
                sql = "SELECT p.ProductID, p.ProductName, p.Image, s.Email, s.CompanyName FROM tblproduct p INNER JOIN tblsupplier s ON p.SupplierID = s.SupplierID  WHERE p.Status < 2 AND p.ProductID = @ProductID"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@ProductID", productid)

                    Using dr As MySqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            ListView1.SmallImageList = ImageList1

                            Dim productimage() As Byte = DirectCast(dr("Image"), Byte())
                            Dim ms As New MemoryStream(productimage)

                            Using image As Image = Image.FromStream(ms)
                                Dim x As New ListViewItem

                                x.ImageIndex = ImageList1.Images.Add(image, Nothing)
                                x.SubItems.Add(dr("ProductName").ToString)
                                x.SubItems.Add(newValue)
                                x.SubItems.Add(dr("ProductID").ToString) '3

                                ListView1.Items.Add(x)

                                newValue = 0
                            End Using

                            txtSupplier.Text = dr("CompanyName").ToString
                            email = dr("Email").ToString
                        End While
                    End Using
                End Using
            Next

        Catch ex As Exception
            MsgBox("An Error occurred frmRestockProduct(loadInformation) :  " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub frmRestockProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            txtSupplier.Clear()
            txtPONo.Clear()

            ListView1.Items.Clear()
            listofProductIds.Clear()

            productid = Nothing
            supplierid = Nothing
        End If
    End Sub

    Private Sub btnSendRequest_Click(sender As Object, e As EventArgs) Handles btnSendRequest.Click
        If Not IsNumeric(String.IsNullOrWhiteSpace(txtPONo.Text)) AndAlso listofProductIds.Count > 0 Then
            Dim itemsWithoutAmount As New List(Of String)
            For Each item As ListViewItem In ListView1.Items
                If item.SubItems(2).Text <= 0 Then
                    itemsWithoutAmount.Add(item.SubItems(1).Text)
                End If
            Next

            If itemsWithoutAmount.Count > 0 Then
                Dim errorMessage As String = "Please enter an amount for the following product(s):" & Environment.NewLine & Environment.NewLine & String.Join(Environment.NewLine, itemsWithoutAmount)
                MsgBox(errorMessage, MsgBoxStyle.Critical, "Send Request Error")
            Else
                sendRequest()
            End If
        Else
            If Not listofProductIds.Count = 0 Then
                MsgBox("Please enter a valid Purchase Order Number.", MsgBoxStyle.Critical, "Invalid Input")
            Else
                MsgBox("Please add a product to send a restock request.", MsgBoxStyle.Critical, "Invalid Product")
            End If
        End If
    End Sub

    Private Sub sendRequest()
        Try
            Dim mail As New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("dangaranferds@gmail.com")
            mail.To.Add(email)
            mail.Subject = "Restock Request for " & txtSupplier.Text & " - Purchase Order " & txtPONo.Text

            Using memoryStream As New MemoryStream()
                Dim emailBody As New StringBuilder
                emailBody.AppendLine("<!DOCTYPE html>")
                emailBody.AppendLine("<html>")
                emailBody.AppendLine("<body>")

                emailBody.AppendLine("<p style='text-align: center;'><strong>Purchase Order Request</strong></p>")

                emailBody.AppendLine("<p>Dear " & txtSupplier.Text & ",</p>")

                emailBody.AppendLine("<p>We hope this email finds you well. We are formally requesting a restock of the following item(s):</p>")

                emailBody.AppendLine("<table style='width: 100px; border-collapse: collapse;'>")
                emailBody.AppendLine("<tr style='background-color: #f2f2f2;'>")
                emailBody.AppendLine("<th style='border: 1px solid #dddddd; text-align: center; padding: 8px;'>Product Name</th>")
                emailBody.AppendLine("<th style='border: 1px solid #dddddd; text-align: center; padding: 8px;'>Amount</th>")
                emailBody.AppendLine("</tr>")

                For Each item As ListViewItem In ListView1.Items
                    emailBody.AppendLine("<tr style='width: 100px'>")
                    emailBody.AppendLine("<td style='border: 1px solid #dddddd; text-align: left; padding: 8px;'>" & item.SubItems(1).Text & "</td>")
                    emailBody.AppendLine("<td style='border: 1px solid #dddddd; text-align: left; padding: 8px;'>" & item.SubItems(2).Text & "</td>")
                    emailBody.AppendLine("</tr>")
                Next

                emailBody.AppendLine("</table>")

                emailBody.AppendLine("<p style='text-align: center;'>Purchase Order Number: " & txtPONo.Text & "</p>")

                emailBody.AppendLine("<p>Please process this restock request at your earliest convenience.</p>")

                emailBody.AppendLine("<p style='text-align: left;'>Best regards,</p>")
                emailBody.AppendLine("<p style='text-align: left;'>Rambic Corporation</p>")

                emailBody.AppendLine("<p style='text-align: center;'>Contact Information:  (123) 456-7890</p>")
                emailBody.AppendLine("<p style='text-align: center;'>Address: Blk. 62 Lot 2 General Bautista St., Soldier's Hill's, Putatan, Muntinlupa City, Philippines</p>")
                emailBody.AppendLine("</body>")
                emailBody.AppendLine("</html>")

                mail.IsBodyHtml = True
                mail.Body = emailBody.ToString

                smtpServer.Port = 587
                smtpServer.Credentials = New System.Net.NetworkCredential("dangaranferds@gmail.com", "tpbu vbxk ampu iwua")
                smtpServer.EnableSsl = True
                smtpServer.Send(mail)
            End Using

            Call getMaxQuotationID()
            Call updateQuotation()
            Call frmManageSuppliers.loadReorders()
            Me.Close()
            MsgBox("Request sent successfully!", MsgBoxStyle.Information, "Request Sending")
        Catch ex As Exception
            MsgBox("An error occurred frmRestockProduct(sendRequest): " & ex.Message)
        End Try
    End Sub

    Dim quotationid As String
    Private Sub getMaxQuotationID()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT MAX(QuotationID) AS QuotationID FROM tblquotationproducts"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                If Not IsDBNull(dr("QuotationID")) Then 'IF QUOTATIONID IS NOT NULL
                    quotationid = (dr("QuotationID") + 1).ToString
                Else 'IF THERE IS NO QUOTATIONID
                    quotationid = "1"
                End If
            Else
                quotationid = "0"
            End If
        Catch ex As Exception
            MsgBox("An Error occurred frmRestockProduct(getMaxQuotationID): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub updateQuotation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each item As ListViewItem In ListView1.Items
                sql = "INSERT INTO tblquotationproducts(QuotationID, SupplierID, PONumber, ProductID, Amount) VALUES(@QuotationID, @SupplierID, @PONumber, @ProductID, @Amount)"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@QuotationID", quotationid)
                    .Parameters.AddWithValue("@SupplierID", supplierid)
                    .Parameters.AddWithValue("@PONumber", txtPONo.Text)
                    .Parameters.AddWithValue("@ProductID", item.SubItems(3).Text)
                    .Parameters.AddWithValue("@Amount", item.SubItems(2).Text)
                    .ExecuteNonQuery()
                End With
            Next

        Catch ex As Exception
            MsgBox("An Error occurred frmRestockProduct(updateQuotation): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmListProducts.supplierid = supplierid
        frmListProducts.listofProductIds = listofProductIds
        frmListProducts.ShowDialog()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            btnQuantity.Enabled = True
            btnRemove.Enabled = True
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If ListView1.SelectedItems.Count > 0 Then
            If MsgBox("Do you want to remove the item?", vbQuestion + vbYesNo) = vbYes Then
                listofProductIds.Remove(ListView1.SelectedItems(0).SubItems(3).Text)

                btnQuantity.Enabled = False
                btnRemove.Enabled = False
                Call loadInformation()
            End If
        End If
    End Sub

    Private Sub btnQuantity_Click(sender As Object, e As EventArgs) Handles btnQuantity.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim currentValue As String = ListView1.SelectedItems(0).SubItems(2).Text

            frmRestockItem.restock = True
            frmRestockItem.ShowDialog()

        End If
    End Sub
End Class