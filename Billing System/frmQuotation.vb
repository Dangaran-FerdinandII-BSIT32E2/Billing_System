Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmQuotation
    Public orderid As String
    Dim d As OpenFileDialog = New OpenFileDialog

    Private email As String
    Private Sub frmQuotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation()
        Call loadReport()
    End Sub

    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COALESCE(w.Email, c.Email) AS Email FROM tblorder o LEFT JOIN tblcustomer c ON o.CustomerID = c.CustomerID LEFT JOIN tblorderwalkin ow ON ow.OrderID = o.OrderID LEFT JOIN tblwalkin w ON ow.WalkinID = w.WalkinID WHERE o.OrderID = '" & orderid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                email = dr("Email").ToString
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmQuotation(loadInformation): " & ex.Message)
        Finally
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
                .ReportPath = "C:\Users\danga\OneDrive\Documents\GitHub\Billing_System\Billing System\printQuotation.rdlc"
                '.ReportPath = "C:\Users\Jayson Teleb\Documents\GitHub\Billing_System\Billing System\printQuotation.rdlc"

                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT CONCAT( COALESCE(w.LastName, o.LastName), ', ', COALESCE(w.FirstName, o.FirstName) ) AS FullName, COALESCE(w.Address, c.Address) AS Address, COALESCE(w.DeliveryAddress, o.DeliveryAddress) AS DeliveryAddress, DATE_FORMAT(CURDATE(), '%M %d, %Y') AS DateOrdered, DATE_FORMAT(CURDATE() + INTERVAL 7 DAY, '%M %d, %Y') AS QuotationDueDate, CONCAT('PO-', MONTH(NOW()), '-', YEAR(NOW()), '-', LPAD(o.OrderID, 4, '0')) AS OrderID, o.Unit AS ProductName, o.Description, o.Quantity, o.Amount, (o.Amount * o.Quantity) AS TotalAmount, SUM(o.Amount * o.Quantity) OVER() AS TotalPricing FROM qryorder o LEFT JOIN tblorderwalkin ow ON ow.OrderID = o.OrderID LEFT JOIN tblwalkin w ON ow.WalkinID = w.WalkinID LEFT JOIN tblcustomer c ON o.CustomerID = c.CustomerID WHERE o.OrderID = '" & orderid & "' GROUP BY o.ProductID", cn)
            da.Fill(ds.Tables("dtPrintQuotation"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtPrintQuotation", ds.Tables("dtPrintQuotation"))
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

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
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
                sql = "UPDATE tblorder SET QuotationImg=@QuotationImg, QuotationDueDate=@QuotationDueDate, QuotationStatus = NULL WHERE OrderID = '" & orderid & "'"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    Dim mstream As New MemoryStream()
                    sendImage.Save(mstream, ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.ToArray()
                    mstream.Close()

                    .Parameters.AddWithValue("@QuotationImg", arrImage)
                    .Parameters.AddWithValue("@QuotationDueDate", DateTime.Now.AddDays(7))
                    .ExecuteNonQuery()
                End With

                ' Notify the user
                MsgBox("Successfully saved!", MsgBoxStyle.Information, "Image Uploading")

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

            mail.Subject = "NOTICE ON QUOTATION OF ORDER NUMBER " & orderid

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

    Private Sub frmQuotation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            orderid = Nothing
        End If
    End Sub
End Class