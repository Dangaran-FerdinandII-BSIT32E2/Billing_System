Imports System.IO
Imports System.Net.Mail
Imports System.Text
Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class frmRetrievalProducts

    Public orderid As String
    Dim email As String
    Private Sub frmRetrievalProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation()
        Call loadRented()
    End Sub

    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT c.CompanyName, c.Email FROM tblorder o INNER JOIN tblcustomer c ON c.CustomerID = o.CustomerID WHERE o.OrderID = '" & orderid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblCustomerName.Text = dr("CompanyName").ToString
                email = dr("Email").ToString
            End If
        Catch ex As Exception
            MsgBox("An error occured at frmRetrievalProducts(loadInformation): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadRented()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            'sql = "SELECT p.ProductName, o.RentDueDate, o.OrderID FROM tblorder o INNER JOIN tblproduct p ON o.ProductID = p.ProductID WHERE o.OrderID = 13 AND o.isRental = 1"
            sql = "SELECT p.ProductName, DATE_FORMAT(o.RentDueDate, '%M %d, %Y') AS RentDueDate, o.OrderID FROM tblorder o INNER JOIN tblproduct p ON o.ProductID = p.ProductID WHERE o.OrderID = 13 AND o.isRental = 1"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString)
                x.SubItems.Add(dr("RentDueDate").ToString)
                x.SubItems.Add(dr("OrderID").ToString)

                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occured at frmRetrievalProducts(loadRented): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If MsgBox("Is the order retrieved?", vbQuestion + vbYesNo) = vbYes Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "UPDATE tblorder SET isRetrieved = 1 WHERE OrderID = '" & orderid & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

                Call frmManageRentalV2.loadRetrieveRental()
                Me.Close()

            Catch ex As Exception
                MsgBox("An error occured at frmRetrievalProducts(btnConfirm_Click): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnSendReminder_Click(sender As Object, e As EventArgs) Handles btnSendReminder.Click
        If MsgBox("Do you want to remind?", vbQuestion + vbYesNo) = vbYes Then
            Try
                Dim mail As New MailMessage()
                Dim smtpServer As New SmtpClient("smtp.gmail.com")

                mail.From = New MailAddress("rambiccorpo@gmail.com") ' Replace with your email
                mail.To.Add(email)

                mail.Subject = "Sales Invoice for Order #" & orderid & " – Rambic Corporation"

                Using memoryStream As New MemoryStream()

                    Dim emailBody As New StringBuilder
                    emailBody.AppendLine("<!DOCTYPE html>")
                    emailBody.AppendLine("<html>")
                    emailBody.AppendLine("<body>")

                    emailBody.AppendLine("<p style='text-align: center;'><strong>Purchase Order Request</strong></p>")

                    emailBody.AppendLine("<p>Dear " & lblCustomerName.Text & ",</p>")

                    emailBody.AppendLine("<p>I hope this message finds you well. Please find attached the sales invoice receipt for your recent order with Rambic Corporation. Below are the key details of your transaction, including the payment options we accept:</p><br>")

                    emailBody.AppendLine("<table style='width: 100px; border-collapse: collapse;'>")
                    emailBody.AppendLine("<tr style='background-color: #f2f2f2;'>")
                    emailBody.AppendLine("<th style='border: 1px solid #dddddd; text-align: center; padding: 8px;'>Product Name</th>")
                    emailBody.AppendLine("<th style='border: 1px solid #dddddd; text-align: center; padding: 8px;'>Due Date</th>")
                    emailBody.AppendLine("</tr>")

                    For Each item As ListViewItem In ListView1.Items
                        emailBody.AppendLine("<tr style='width: 100px'>")
                        emailBody.AppendLine("<td style='border: 1px solid #dddddd; text-align: left; padding: 8px;'>" & item.SubItems(0).Text & "</td>")
                        emailBody.AppendLine("<td style='border: 1px solid #dddddd; text-align: left; padding: 8px;'>" & item.SubItems(1).Text & "</td>")
                        emailBody.AppendLine("</tr>")
                    Next

                    emailBody.AppendLine("</table>")
                    emailBody.AppendLine("<p class='signature'><strong>Best regards,</strong></p>")
                    emailBody.AppendLine("<p><em>This is an automated email. Please do not reply directly to this message.</em></p>")
                    emailBody.AppendLine("<p>The information contained in this email is intended for the recipient only. It may contain confidential or privileged material and should not be shared, reproduced, or distributed without permission. If you are not the intended recipient, please notify the sender immediately, and delete the email from your system. Rambic Corporation makes no representations or warranties regarding the accuracy or completeness of the information provided and disclaims any liability for any loss or damage arising from the use of this email.</p>")
                    emailBody.AppendLine("<p>Please consider the environment before printing this email.</p>")
                    emailBody.AppendLine("</body>")
                    emailBody.AppendLine("</html>")

                    mail.IsBodyHtml = True
                    mail.Body = emailBody.ToString


                    smtpServer.Port = 587
                    smtpServer.Credentials = New System.Net.NetworkCredential("rambiccorpo@gmail.com", "xcyu gtqv ctvk kzqa") ' Use secure methods
                    smtpServer.EnableSsl = True
                    smtpServer.Send(mail)

                End Using
                MsgBox("Email sent successfully!", MsgBoxStyle.Information, "Email Sent")

            Catch ex As Exception
                MsgBox("Sending email failed. Please connect to the Internet and try again.", MsgBoxStyle.Information, "Email Error")
            End Try
        End If
    End Sub
End Class