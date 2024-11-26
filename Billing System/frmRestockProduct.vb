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
    Private Sub frmRestockProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation()
    End Sub
    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT p.ProductID, p.ProductName, p.Image, s.Email, s.CompanyName, p.Amount FROM tblproduct p INNER JOIN tblsupplier s ON p.SupplierID = s.SupplierID  WHERE p.Status < 2 AND p.ProductID = '" & productid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            ListView1.Items.Clear()

            Do While dr.Read = True
                ListView1.SmallImageList = ImageList1

                Dim productimage() As Byte = DirectCast(dr("Image"), Byte())
                Dim ms As New MemoryStream(productimage)

                Using image As Image = Image.FromStream(ms)
                    Dim x As New ListViewItem

                    x.ImageIndex = ImageList1.Images.Add(image, Nothing)
                    x.SubItems.Add(dr("ProductName").ToString)
                    x.SubItems.Add(dr("Amount").ToString)
                    x.SubItems.Add(dr("ProductID").ToString)

                    ListView1.Items.Add(x)
                End Using

                txtSupplier.Text = dr("CompanyName").ToString
                email = dr("Email").ToString
            Loop

        Catch ex As Exception
            MsgBox("An Error occurred frmRestockProduct(loadInformation): " & ex.Message)
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
        End If
    End Sub

    Private Sub btnSendRequest_Click(sender As Object, e As EventArgs) Handles btnSendRequest.Click
        If btnSendRequest.Text = "Send Request" Then
            sendRequest()
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
                emailBody.AppendLine("<th style='border: 1px solid #dddddd; text-align: left; padding: 8px;'>Product Image</th>")
                emailBody.AppendLine("<th style='border: 1px solid #dddddd; text-align: left; padding: 8px;'>Product Name</th>")
                emailBody.AppendLine("<th style='border: 1px solid #dddddd; text-align: left; padding: 8px;'>Amount</th>")
                emailBody.AppendLine("</tr>")

                For Each item As ListViewItem In ListView1.Items
                    emailBody.AppendLine("<tr>")
                    emailBody.AppendLine("<td style='border: 1px solid #dddddd; text-align: left; padding: 8px;'>" & item.SubItems(1).Text & "</td>")
                    emailBody.AppendLine("<td style='border: 1px solid #dddddd; text-align: left; padding: 8px;'>" & item.SubItems(2).Text & "</td>")
                    emailBody.AppendLine("</tr>")
                Next

                emailBody.AppendLine("</table>")

                emailBody.AppendLine("<p style='text-align: center;'>Purchase Order Number: " & txtPONo.Text & "</p>")

                emailBody.AppendLine("<p>Please process this restock request at your earliest convenience.</p>")

                emailBody.AppendLine("<p style='text-align: center;'>Best regards,</p>")
                emailBody.AppendLine("<p style='text-align: center;'>Rambic Corporation</p>")

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

            MsgBox("Request sent successfully!", MsgBoxStyle.Information, "Request Sending")
        Catch ex As Exception
            MsgBox("An error occurred frmRestockProduct(sendRequest): " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub
End Class