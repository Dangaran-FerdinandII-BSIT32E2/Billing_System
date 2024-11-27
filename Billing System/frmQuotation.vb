Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.Mail

Public Class frmQuotation
    Public orderid As String
    Dim d As OpenFileDialog = New OpenFileDialog

    Private email As String
    Public custid As String
    Private Sub frmQuotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadReport()
        'Call loadInformation
        'Call loadImage()
    End Sub

    Private Sub loadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = "C:\Users\Jayson Teleb\Documents\GitHub\Billing_System\Billing System\printQuotation.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT CONCAT(tblcustomer.FirstName, tblcustomer.LastName) AS FullName, tblcustomer.Address, tblcustomer.Delivery, tblorder.OrderID, tblorder.DateOrdered, tblorder.QuotationDueDate, tblproduct.ProductName, tblproduct.Description, tblorder.Quantity, tblorder.Amount, SUM(tblorder.Amount) OVER () AS TotalAmount FROM tblcustomer INNER JOIN tblorder ON tblorder.CustomerID = tblcustomer.CustomerID INNER JOIN tblproduct ON tblorder.ProductID = tblproduct.ProductID WHERE tblcustomer.CustomerID = '" & custid & "'", cn)
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

            MessageBox.Show("Report exported as an image to: " & outputImagePath)

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
                sql = "UPDATE tblorder SET QuotationImg=@QuotationImg, QuotationDueDate=@QuotationDueDate, Status = 1 WHERE OrderID = @OrderID"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    Dim mstream As New MemoryStream()
                    sendImage.Save(mstream, ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.ToArray()
                    mstream.Close()

                    .Parameters.AddWithValue("@QuotationImg", arrImage)
                    .Parameters.AddWithValue("@QuotationDueDate", DateTime.Now.AddDays(7))
                    .Parameters.AddWithValue("@OrderID", orderid)
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

            mail.From = New MailAddress("2718-21@itmlyceumalabang.onmicrosoft.com") ' Replace with your email
            mail.To.Add(email)
            mail.Subject = "NOTICE ON QUOTATION OF ORDER NUMBER " & orderid
            mail.Body = "There is now an available quotation for your Order Number " & orderid & "." & vbCrLf &
                        "You can now accept or reject the Order Quotation through the website." & vbCrLf & vbCrLf &
                        "The deadline for the Quotation is on " & DateTime.Now.AddDays(7).ToString("MMMM dd, yyyy") & "."

            smtpServer.Port = 587
            smtpServer.Credentials = New System.Net.NetworkCredential("dangaranferds@gmail.com", "tpbu vbxk ampu iwua") ' Use secure methods
            smtpServer.EnableSsl = True
            smtpServer.Send(mail)

            MsgBox("Email sent successfully!", MsgBoxStyle.Information, "Email Sent")

        Catch ex As Exception
            MsgBox("An error occurred in sendEmail: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    'Private Sub loadImage()
    '    Try
    '        If cn.State <> ConnectionState.Open Then
    '            cn.Open()
    '        End If

    '        sql = "SELECT QuotationImg FROM tblorder WHERE OrderID = '" & orderid & "'"
    '        cmd = New MySqlCommand(sql, cn)

    '        If Not dr.IsClosed Then
    '            dr.Close()
    '        End If

    '        dr = cmd.ExecuteReader
    '        If dr.Read = True Then
    '            If dr("QuotationImg") IsNot DBNull.Value AndAlso dr("QuotationImg") IsNot Nothing Then
    '                Dim pic As Byte() = DirectCast(dr("QuotationImg"), Byte())
    '                If pic.Length > 0 Then
    '                    'Dim ms As New MemoryStream(pic)
    '                    Using ms As New MemoryStream(pic)
    '                        PictureBox1.Image = Image.FromStream(ms)
    '                    End Using

    '                    PictureBox2.Visible = False
    '                    btnBrowse.Visible = False

    '                    btnCancel.Enabled = True
    '                    btnSend.Enabled = False
    '                Else
    '                    PictureBox1.Image = Nothing
    '                    PictureBox2.Visible = True
    '                    btnBrowse.Visible = True
    '                    btnCancel.Enabled = False
    '                    btnSend.Enabled = True
    '                End If
    '            End If
    '        Else
    '            PictureBox1.Image = Nothing
    '            PictureBox2.Visible = True
    '            btnBrowse.Visible = True
    '            btnCancel.Enabled = False
    '            btnSend.Enabled = True
    '        End If

    '    Catch ex As Exception
    '        MsgBox("An error occurred frmQuotation(loadImage): " & ex.Message)
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub

    'Private Sub btnBrowse_Click(sender As Object, e As EventArgs)
    '    Try
    '        d.Filter = "JPEG(*.jpg; *.jpeg)|*.jpg|PNG(*.png)|*.png"

    '        If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '            PictureBox1.Image = Image.FromFile(d.FileName)

    '            PictureBox2.Visible = False
    '            btnBrowse.Visible = False
    '        End If
    '    Catch ex As Exception
    '        MsgBox("An error occurred frmQuotation(btnBrowse_Click): " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub btnSend_Click(sender As Object, e As EventArgs)
    '    Try
    '        If cn.State <> ConnectionState.Open Then
    '            cn.Open()
    '        End If

    '        If PictureBox1.Image IsNot Nothing Then
    '            If MsgBox("Do you want to continue?", vbYesNo + vbQuestion) = vbYes Then
    '                sql = "UPDATE tblorder SET QuotationImg=@QuotationImg, QuotationDueDate=@QuotationDueDate, Status = 1 WHERE OrderID = '" & orderid & "'"
    '                cmd = New MySqlCommand(sql, cn)
    '                With cmd
    '                    Dim mstream As New System.IO.MemoryStream()
    '                    PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
    '                    Dim arrImage() As Byte = mstream.GetBuffer
    '                    mstream.Close()
    '                    .Parameters.AddWithValue("@QuotationImg", arrImage)
    '                    .Parameters.AddWithValue("@QuotationDueDate", DateTime.Now.AddDays(7))
    '                    .ExecuteNonQuery()
    '                End With

    '                MsgBox("Successfully saved!", MsgBoxStyle.Information, "Image Uploading")
    '                Call loadActivity()
    '                Call loadImage()
    '                Call sendEmail()
    '                Call frmListofCustomerOrder.loadOrder()
    '            End If
    '        Else
    '            MsgBox("Please upload a picture!", MsgBoxStyle.Critical, "Upload Error")
    '        End If
    '    Catch ex As Exception
    '        MsgBox("An error occurred frmQuotation(btnSend_Click): " & ex.Message)
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub

    'Private Sub sendEmail()
    '    Try
    '        Dim mail As New MailMessage()
    '        Dim smtpServer As New SmtpClient("smtp.gmail.com")
    '        mail.From = New MailAddress("dangaranferds@gmail.com")
    '        mail.To.Add(email)
    '        mail.Subject = "NOTICE ON QUOTATION OF ORDER NUMBER " & orderid

    '        Using memoryStream As New MemoryStream()

    '            mail.Body = "There is now available quotation for your Order Number " & orderid & "." & vbCrLf & "You can now accept or reject the Order Quotation through the website." & vbCrLf & vbCrLf & "The deadline for the Quotation is on " & DateTime.Now.AddDays(7).ToString("MMMM dd, yyyy") & "."
    '            smtpServer.Port = 587
    '            smtpServer.Credentials = New System.Net.NetworkCredential("dangaranferds@gmail.com", "tpbu vbxk ampu iwua")
    '            smtpServer.EnableSsl = True
    '            smtpServer.Send(mail)
    '        End Using

    '        MsgBox("Email sent with form screenshot!")
    '    Catch ex As Exception
    '        MsgBox("An error occurred frmPrintBillingInvoice(btnEmail): " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub btnCancel_Click(sender As Object, e As EventArgs)
    '    PictureBox1.Image = Nothing
    '    PictureBox2.Visible = True
    '    btnBrowse.Visible = True
    '    btnCancel.Enabled = False
    '    btnSend.Enabled = True
    'End Sub
    'Private Sub loadActivity()
    '    Try
    '        If cn.State <> ConnectionState.Open Then
    '            cn.Open()
    '        End If

    '        sql = "INSERT INTO tblactivity(UserID, Username, DateTime, Action) VALUES(@UserID, @Username, @DateTime, @Action)"
    '        cmd = New MySqlCommand(sql, cn)
    '        With cmd
    '            .Parameters.AddWithValue("@UserID", frmLoginV2.userid)
    '            .Parameters.AddWithValue("@Username", frmLoginV2.username)
    '            .Parameters.AddWithValue("@DateTime", DateTime.Now)
    '            .Parameters.AddWithValue("@Action", "Send Quotation for " & orderid)
    '            .ExecuteNonQuery()
    '        End With
    '    Catch ex As Exception
    '        MsgBox("An error occurred frmAdminSettings(loadActivity): " & ex.Message)
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub
End Class