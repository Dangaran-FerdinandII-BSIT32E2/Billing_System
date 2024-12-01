Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.Mail
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class frmPrintSalesInvoice

    Public billingid As String
    Public orderid As String

    Dim email As String

    Private Sub frmPrintSalesInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation
        Call loadReport()
    End Sub

    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT c.Email FROM tblcustomer c INNER JOIN tblbilling b on c.CustomerID = b.CustomerID WHERE BillingID = 6"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                email = dr("Email").ToString
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
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                '.ReportPath = "C:\Users\danga\OneDrive\Documents\GitHub\Billing_System\Billing System\printSalesInvoice.rdlc"
                .ReportPath = "C:\Users\Jayson Teleb\Documents\GitHub\Billing_System\Billing System\printSalesInvoice.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT c.CompanyName, c.Address, o.DeliveryAddress, b.DatePrinted, b.ProductOrder, b.Terms, b.Salesman, b.VATableSales, b.VAT, c.TIN, o.Quantity, p.ProductName, p.Description, p.SellingPrice, o.Amount, ( SELECT SUM(o2.Amount) FROM tblorder o2 INNER JOIN tblbillinvoice i2 ON i2.OrderID = o2.OrderID AND i2.ProductID = o2.ProductID WHERE i2.BillingID = b.BillingID ) AS FinalAmount FROM tblcustomer c INNER JOIN tblbilling b ON b.CustomerID = c.CustomerID INNER JOIN tblbillinvoice i ON i.BillingID = b.BillingID INNER JOIN tblorder o ON i.OrderID = o.OrderID AND i.ProductID = o.ProductID INNER JOIN tblproduct p ON i.ProductID = p.ProductID WHERE b.BillingID = 1", cn)
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

            MessageBox.Show("Report exported as an image to: " & outputImagePath)

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

            mail.From = New MailAddress("dangaranferds@gmail.com") ' Replace with your email
            mail.To.Add(email)

            mail.Subject = "SALES INVOICE FOR Order Number " & orderid

            Using memoryStream As New MemoryStream()

                Dim imagepath As String = Path.Combine(Application.StartupPath, "Image\ReportImage.png")
                Using image As Image = Image.FromFile(imagepath)
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    memoryStream.Position = 0

                    Dim imageAttachment As New Attachment(memoryStream, "QUOTATION-ORDER_NUMBER" & orderid & "-.jpeg")
                    mail.Attachments.Add(imageAttachment)

                    mail.Body = "There is now an available quotation for your Order Number " & orderid & "." & vbCrLf &
                        "You can now accept or reject the Order Quotation through the website." & vbCrLf & vbCrLf &
                        "The deadline for the Quotation is on " & DateTime.Now.AddDays(7).ToString("MMMM dd, yyyy") & "."

                    smtpServer.Port = 587
                    smtpServer.Credentials = New System.Net.NetworkCredential("dangaranferds@gmail.com", "tpbu vbxk ampu iwua") ' Use secure methods
                    smtpServer.EnableSsl = True
                    smtpServer.Send(mail)

                End Using
            End Using
            MsgBox("Email sent successfully!", MsgBoxStyle.Information, "Email Sent")

        Catch ex As Exception
            MsgBox("An error occurred in sendEmail: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class