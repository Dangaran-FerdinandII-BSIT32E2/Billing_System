Imports System.IO
Imports System.Net.Mail
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frmRestockQuotation
    Public quotationid As String
    Public supplierid As String
    Public ponum As String

    Private email As String

    Private Sub frmRestockQuotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadQuotation()
        Call loadQuotationImage
    End Sub

    Private Sub loadQuotation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT q.PONumber, p.Image, p.ProductID, p.ProductName, q.Quantity, s.CompanyName, s.Email FROM tblquotation q INNER JOIN tblsupplier s ON q.SupplierID = s.SupplierID INNER JOIN tblproduct p ON q.ProductID = p.ProductID WHERE QuotationID = '" & quotationid & "'"
            Using cmd As New MySqlCommand(sql, cn)
                Using dr As MySqlDataReader = cmd.ExecuteReader
                    While dr.Read
                        ListView1.SmallImageList = ImageList1

                        Dim quotationImage() As Byte = DirectCast(dr("Image"), Byte())
                        Dim ms As New MemoryStream(quotationImage)

                        Using image As Image = Image.FromStream(ms)
                            Dim x As New ListViewItem

                            x.ImageIndex = ImageList1.Images.Add(image, Nothing)
                            x.SubItems.Add(dr("ProductName").ToString)
                            x.SubItems.Add(dr("Quantity").ToString)
                            x.SubItems.Add(dr("ProductID").ToString)

                            ListView1.Items.Add(x)
                        End Using

                        txtSupplier.Text = dr("CompanyName").ToString
                        email = dr("Email").ToString
                        lblPo.Text = (("PO #") & dr("PONumber").ToString)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An Error occurred frmRestockQuotation(loadQuotation): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadQuotationImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT QuotationIMG FROM tblquotation WHERE QuotationID = '" & quotationid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Dim pic As Byte() = DirectCast(dr("QuotationIMG"), Byte())
                If pic.Length > 0 Then
                    Using ms As New MemoryStream(pic)
                        pbxQuotation.Image = Image.FromStream(ms)
                    End Using

                    btnAccept.Enabled = True
                    btnReject.Enabled = True
                    btnPayment.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmRestockQuotation(loadQuotationImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Call sendEmail()
        Call insertPayment
    End Sub

    Private Sub sendEmail()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "UPDATE tblquotation SET Status = 1 WHERE QuotationID = '" & quotationid & "'"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteReader()

            Call sendAcceptEmail()
        Catch ex As Exception
            MsgBox("An error occurred frmRestockQuotation(sendEmail): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub insertPayment()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblpayment(QuotationID, SupplierID) VALUES(@QuotationID, @SupplierID)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@QuotationID", quotationid)
                .Parameters.AddWithValue("@SupplierID", supplierid)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmRestockQuotation(insertPayment): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblquotation SET Status = 0 WHERE QuotationID = '" & quotationid & "'"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteReader()

            Dim reason As String = InputBox("Enter reason for rejection: ", "Rejection Reason")
            Call sendRejectEmail(reason)
        Catch ex As Exception
            MsgBox("An error occurred frmRestockQuotation(btnReject_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub sendAcceptEmail()
        Try
            Dim mail As New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("dangaranferds@gmail.com")
            mail.To.Add(email)
            mail.Subject = "Update on Quotation Status for Rambic Corporation - " & lblPo.Text

            Using memoryStream As New MemoryStream()
                Dim emailBody As New StringBuilder
                emailBody.AppendLine("<!DOCTYPE html>")
                emailBody.AppendLine("<html>")
                emailBody.AppendLine("<body>")

                emailBody.AppendLine("<p style='text-align: center;'><strong>Purchase Order Request</strong></p>")

                emailBody.AppendLine("<p>Dear " & txtSupplier.Text & ",</p>")

                emailBody.AppendLine("<p>We hope this email finds you well. We are glad to accept the following conditions on the quotation for " & lblPo.Text & "</p>")

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

            MsgBox("Acceptance of quotation sent successfully!", MsgBoxStyle.Information, "Request Sending")
        Catch ex As Exception
            MsgBox("An error occurred frmRestockQuotation(sendAcceptEmail): " & ex.Message)
        End Try
    End Sub

    Private Sub sendRejectEmail(reason As String)
        Try
            Dim mail As New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("dangaranferds@gmail.com")
            mail.To.Add(email)
            mail.Subject = "Update on Quotation Status for Rambic Corporation - " & lblPo.Text

            Using memoryStream As New MemoryStream()
                Dim emailBody As New StringBuilder
                emailBody.AppendLine("<!DOCTYPE html>")
                emailBody.AppendLine("<html>")
                emailBody.AppendLine("<body>")

                emailBody.AppendLine("<p style='text-align: center;'><strong>Purchase Order Request</strong></p>")

                emailBody.AppendLine("<p>Dear " & txtSupplier.Text & ",</p>")

                emailBody.AppendLine("<p>We hope this email finds you well. Unfortunately, Rambic Corporation will not be proceeding with the quotation for " & lblPo.Text & " at this time.</p>")

                emailBody.AppendLine("<table style='border: 1px solid black; border-collapse: collapse; margin: 0 auto;'>")
                emailBody.AppendLine("<tr><th style='border: 1px solid black; padding: 8px;'>Reason for Rejection:</th></tr>")
                emailBody.AppendLine("<tr><td style='border: 1px solid black; padding: 8px;'>" & reason & "</td></tr>")
                emailBody.AppendLine("</table>")


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

            MsgBox("Rejection sent successfully!", MsgBoxStyle.Information, "Request Sending")
        Catch ex As Exception
            MsgBox("An error occurred frmRestockQuotation(sendRejectEmail): " & ex.Message)
        End Try
    End Sub

    Private Sub frmRestockQuotation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            quotationid = Nothing
            ponum = Nothing
            email = Nothing

            pbxQuotation.Image = Nothing
            ListView1.Items.Clear()

            btnAccept.Enabled = False
            btnReject.Enabled = False
            btnPayment.Enabled = False
        End If
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmSendPayment.quotationid = quotationid
        frmSendPayment.ShowDialog()
    End Sub
End Class