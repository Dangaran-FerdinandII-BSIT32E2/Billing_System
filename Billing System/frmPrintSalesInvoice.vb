Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.Mail
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class frmPrintSalesInvoice

    Public billingid As String
    Public orderid As String

    Dim email As String
    Dim customername As String

    Dim accountNumber As String
    Dim accountName As String


    Public terms As String
    Public amountdue As String

    Private Sub frmPrintSalesInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation()
        Call loadReport()
    End Sub

    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COALESCE(w.Email, c.Email) AS Email, COALESCE(w.CompanyName, c.CompanyName) AS CustomerName FROM tblbillinvoice bi LEFT JOIN tblbilling b ON b.BillingID = bi.BillingID LEFT JOIN tblorder o ON o.OrderID = bi.OrderID LEFT JOIN tblproduct p ON p.ProductID = bi.ProductID LEFT JOIN tblcustomer c ON b.CustomerID = c.CustomerID LEFT JOIN tblorderwalkin ow ON ow.OrderID = bi.OrderID LEFT JOIN tblwalkin w ON w.WalkinID = ow.WalkinID WHERE b.BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                email = dr("Email").ToString
                customername = dr("CustomerName").ToString
            End If

        Catch ex As Exception
            MsgBox("An error occurred in loadInformation: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Ensure the database connection is closed
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                '.ReportPath = "C:\Users\danga\OneDrive\Documents\GitHub\Billing_System\Billing System\printSalesInvoice.rdlc"
                '.ReportPath = "C:\Users\Jayson Teleb\Documents\GitHub\Billing_System\Billing System\printSalesInvoice.rdlc"
                .ReportPath = Application.StartupPath & "\printSalesInvoice.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT COALESCE(w.CompanyName, c.CompanyName) AS CompanyName, COALESCE(w.Address, c.Address) AS Address, COALESCE(w.DeliveryAddress, o.DeliveryAddress) AS DeliveryAddress,  DATE_FORMAT(b.DatePrinted, '%M %d, %Y') AS DatePrinted, b.ProductOrder AS ProductOrder, b.Terms AS Terms, b.SalesMan AS Salesman, COALESCE(w.TIN, c.TIN) AS TIN, o.Quantity AS Quantity, p.ProductName AS ProductName, p.Description AS Description, CONCAT('₱ ', FORMAT(p.SellingPrice, 2)) AS SellingPrice, CONCAT('₱ ', FORMAT(o.Quantity * p.SellingPrice, 2)) AS Amount, CONCAT('₱ ', FORMAT(SUM(o.Quantity * p.SellingPrice), 2)) AS FinalAmount, CONCAT('₱ ', FORMAT(b.VATableSales, 2)) AS VATableSales, CONCAT('₱ ', FORMAT(b.VAT, 2)) AS VAT FROM tblbillinvoice bi LEFT JOIN tblbilling b ON b.BillingID = bi.BillingID LEFT JOIN tblorder o ON o.OrderID = bi.OrderID LEFT JOIN tblproduct p ON p.ProductID = bi.ProductID LEFT JOIN tblcustomer c ON b.CustomerID = c.CustomerID LEFT JOIN tblorderwalkin ow ON ow.OrderID = bi.OrderID LEFT JOIN tblwalkin w ON w.WalkinID = ow.WalkinID WHERE b.BillingID = '" & billingid & "'", cn)
            da.Fill(ds.Tables("dtPrintBillingStatement"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtPrintBillingStatement", ds.Tables("dtPrintBillingStatement"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

            'Convert the report to an image after viewing
            Call ConvertReportToImage()

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConvertReportToImage()
        Try
            ' Render the report to image format
            Dim mimeType As String = ""
            Dim encoding As String = ""
            Dim extension As String = ""
            Dim streamIds As String() = Nothing
            Dim warnings As Warning() = Nothing

            ' Render to an image
            Dim renderedBytes As Byte() = ReportViewer1.LocalReport.Render(
                "IMAGE", Nothing, mimeType, encoding, extension, streamIds, warnings)

            ' Save the rendered image
            Dim outputImagePath As String = Application.StartupPath & "\Image\ReportImage.png"
            Using ms As New MemoryStream(renderedBytes)
                Dim image As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                image.Save(outputImagePath, ImageFormat.Png)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error exporting report to image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs) Handles btnSendEmail.Click
        Try
            ' Path to the generated image
            Dim generatedImagePath As String = Application.StartupPath & "\Image\ReportImage.png"

            ' Check if the image file exists
            If Not File.Exists(generatedImagePath) Then
                MsgBox("Generated report image not found. Please generate the report first.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If

            ' Load the image
            Dim sendImage As Image
            Using fs As New FileStream(generatedImagePath, FileMode.Open, FileAccess.Read)
                sendImage = Image.FromStream(fs)
            End Using

            ' Ensure database connection is open
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            ' Update database with image and quotation due date
            If MsgBox("Do you want to continue?", vbYesNo + vbQuestion) = vbYes Then


                ' Send the email
                Call sendEmail()

                ' Clean up the image file
                If File.Exists(generatedImagePath) Then
                    File.Delete(generatedImagePath)
                End If

                ' Refresh order list

                Call frmListofCustomerOrder.loadOrder()
                Call frmManageOrder.loadFilteredOrders(frmManageOrder.DateFilter1.Text, frmManageOrder.DateFilter2.Text)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred in btnSend_Click: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Ensure the database connection is closed
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub sendEmail()
        Try
            Dim mail As New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")

            mail.From = New MailAddress("rambiccorpo@gmail.com") ' Replace with your email
            mail.To.Add(email)

            mail.Subject = "Sales Invoice for Order #" & orderid & " – Rambic Corporation"

            Using memoryStream As New MemoryStream()

                Dim imagepath As String = Path.Combine(Application.StartupPath, "Image\ReportImage.png")
                Using image As Image = Image.FromFile(imagepath)
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    memoryStream.Position = 0

                    Dim imageAttachment As New Attachment(memoryStream, "CustomerCopy-SalesInvoice_#" & billingid & "-.jpeg")

                    Dim emailBody As New StringBuilder
                    emailBody.AppendLine("<!DOCTYPE html>")
                    emailBody.AppendLine("<html>")
                    emailBody.AppendLine("<body>")

                    emailBody.AppendLine("<p style='text-align: center;'><strong>Purchase Order Request</strong></p>")

                    emailBody.AppendLine("<p>Dear " & customername & ",</p>")

                    emailBody.AppendLine("<p>I hope this message finds you well. Please find attached the sales invoice receipt for your recent order with Rambic Corporation. Below are the key details of your transaction, including the payment options we accept:</p><br>")

                    emailBody.AppendLine("<h3>Invoice Details:</h3>
                                            <ul>
                                                <li><strong>Order Number:</strong> #" & orderid & "</li>
                                                <li><strong>Billing Number:</strong> #" & billingid & "</li>
                                                <li><strong>Invoice Date:</strong> #" & Date.Today.ToString("MMM d, yyyy") & "</li>
                                                <li><strong>Terms:</strong> #" & terms & "</li>
                                                <li><strong>Total Amount Due:</strong> #" & amountdue & "</li>
                                            </ul>
                                        </div>")

                    emailBody.AppendLine("<h2>Payment Options:</h2>")
                    emailBody.AppendLine("<p>To ensure timely resolution of your account, you may choose one of the following payment options:</p>")
                    emailBody.AppendLine("<h3>1. Post-Dated Check</h3>")
                    emailBody.AppendLine("<h3>2. Bank Transfer <em>(Please upload cheque proof via website)</em></h3>")

                    emailBody.AppendLine("<p>Should you have any questions or need assistance, feel free to contact us at (632) 809-9874 / (632) 850-1763 / (632) 753-8139 / (632) 833-1160. We value your business and look forward to continuing our relationship.</p>")

                    emailBody.AppendLine("<p class='signature'><strong>Best regards,</strong></p>")
                    emailBody.AppendLine("<p><em>This is an automated email. Please do not reply directly to this message.</em></p>")
                    emailBody.AppendLine("<p>The information contained in this email is intended for the recipient only. It may contain confidential or privileged material and should not be shared, reproduced, or distributed without permission. If you are not the intended recipient, please notify the sender immediately, and delete the email from your system. Rambic Corporation makes no representations or warranties regarding the accuracy or completeness of the information provided and disclaims any liability for any loss or damage arising from the use of this email.</p>")
                    emailBody.AppendLine("<p>Please consider the environment before printing this email.</p>")
                    emailBody.AppendLine("</body>")
                    emailBody.AppendLine("</html>")

                    mail.IsBodyHtml = True
                    mail.Body = emailBody.ToString

                    mail.Attachments.Add(imageAttachment)

                    smtpServer.Port = 587
                    smtpServer.Credentials = New System.Net.NetworkCredential("rambiccorpo@gmail.com", "xcyu gtqv ctvk kzqa") ' Use secure methods
                    smtpServer.EnableSsl = True
                    smtpServer.Send(mail)

                End Using
            End Using
            MsgBox("Email sent successfully!", MsgBoxStyle.Information, "Email Sent")

        Catch ex As Exception
            MsgBox("Sending email failed. Please connect to the Internet and try again.", MsgBoxStyle.Information, "Email Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
            Call deleteinBilling()
            Call deleteinBillInvoice()
            Me.Close()
        End If
    End Sub

    Private Sub deleteinBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "DELETE FROM tblbilling WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("An error occurred in loadInformation(deleteinBilling): " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub deleteinBillInvoice()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "DELETE FROM tblbillinvoice WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("An error occurred in loadInformation(deleteinBillInvoice): " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub frmPrintSalesInvoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            billingid = Nothing
            orderid = Nothing
            email = Nothing
        End If
    End Sub
End Class