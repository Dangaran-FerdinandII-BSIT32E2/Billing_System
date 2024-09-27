Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Drawing.Printing
Imports System.Windows.Forms.Form
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.PowerPacks.Printing
Public Class frmPrintSalesInvoiceV2
    Public custid As String
    Public billid As String

    Private Sub frmPrintSalesInvoiceV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ListView1.Items.Clear()
        Me.Close()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
    Private Sub saveBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblbilling(BillingID, CustomerID, SalesMan, Terms, ProductOrder, DatePrinted) VALUES(@BillingID, @CustomerID, @SalesMan, @Terms, @ProductOrder, @DatePrinted)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@BillingID", frmManageSalesV2.lblBillingID.Text)
                .Parameters.AddWithValue("@CustomerID", custid)
                .Parameters.AddWithValue("@SalesMan", lblSalesman.Text)
                .Parameters.AddWithValue("@Terms", lblTerms.Text)
                .Parameters.AddWithValue("@ProductOrder", lblPONo.Text)
                .Parameters.AddWithValue("@DatePrinted", frmManageSalesV2.dtpDate.Value)
                .ExecuteNonQuery()
            End With

            Call updateOrder()
            Call saveBillInvoice()
        Catch ex As Exception
            MsgBox("An error occurred frmPrintInvoice(saveBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub updateOrder()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each orderlist As ListViewItem In ListView1.Items
                sql = "UPDATE tblorder SET DueDate=@DueDate, Status=@Status WHERE OrderListID = '" & orderlist.SubItems(6).Text & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@DueDate", Date.Now.AddDays(5))
                cmd.Parameters.AddWithValue("@Status", "2")
                cmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox("An error occurred frmPrintInvoice(updateOrder): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub saveBillInvoice()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each order As ListViewItem In ListView1.Items
                sql = "INSERT INTO tblbillinvoice(BillingID, OrderID, Amount, ProductID) VALUES(@BillingID, @OrderID, @Amount, @ProductID)"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@BillingID", frmManageSalesV2.lblBillingID.Text)
                    .Parameters.AddWithValue("@OrderID", order.SubItems(5).Text)
                    .Parameters.AddWithValue("@Amount", order.SubItems(4).Text)
                    .Parameters.AddWithValue("@ProductID", order.SubItems(7).Text)
                    .ExecuteNonQuery()
                End With
            Next
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(saveBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub sendEmail()
        Try
            Dim mail As New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("dangaranferds@gmail.com")
            mail.To.Add("2091-22@itmlyceumalabang.onmicrosoft.com")
            mail.Subject = "Sales Invoice"

            Using memoryStream As New MemoryStream()
                Using image As Image = Image.FromFile("PrintedInvoice.jpeg")
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    memoryStream.Position = 0

                    Dim imageAttachment As New Attachment(memoryStream, "PrintedInvoice-SALESNO_" + frmManageSalesV2.lblBillingID.Text + "-.jpeg")
                    mail.Attachments.Add(imageAttachment)

                    smtpServer.Port = 587
                    smtpServer.Credentials = New System.Net.NetworkCredential("dangaranferds@gmail.com", "tpbu vbxk ampu iwua")
                    smtpServer.EnableSsl = True
                    smtpServer.Send(mail)
                End Using
            End Using

            MsgBox("Email sent with form screenshot!")


        Catch ex As Exception
            MsgBox("An error occurred frmConfirmPayment(btnEmail): " & ex.Message)
        End Try
    End Sub
    Private Sub printfile()

        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.PrinterSettings = PageSetupDialog1.PrinterSettings

        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeFullWindow)
        Me.PrintForm1.Print()

        Using bitmap As New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
            Me.DrawToBitmap(bitmap, Me.ClientRectangle)
            bitmap.Save("PrintedInvoice.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End Using

    End Sub

End Class