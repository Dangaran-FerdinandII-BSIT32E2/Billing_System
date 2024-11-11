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
    Public priceadjust As Double
    Public textamount As String
    Public format As Boolean? = False
    Public walkin As Boolean? = False
    Public printdate As DateTime
    Public adjusteddate As datetime

    Private Sub frmPrintSalesInvoiceV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call calculateReceipt()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        ListView1.Items.Clear()
        Me.Close()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call saveBilling()
        Call printfile()
        Call sendEmail()
        ListView1.Items.Clear()
        frmManageSalesV2.btnAddOrder.Visible = False
        Call loadActivity()
        Me.Close()
    End Sub
    Private Sub saveBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblbilling(BillingID, CustomerID, CompanyName, SalesMan, Terms, ProductOrder, DatePrinted, DueDate, Discount, Markup, FinalPrice) VALUES(@BillingID, @CustomerID, @CompanyName, @SalesMan, @Terms, @ProductOrder, @DatePrinted, @DueDate, @Discount, @Markup, @FinalPrice)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@BillingID", billid)
                .Parameters.AddWithValue("@CustomerID", If(walkin, "2", If(Label1.Text = "SALES INVOICE", custid, "1")))
                .Parameters.AddWithValue("@CompanyName", lblSoldTo.Text)
                .Parameters.AddWithValue("@SalesMan", lblSalesman.Text)
                .Parameters.AddWithValue("@Terms", lblTerms.Text)
                .Parameters.AddWithValue("@ProductOrder", lblPONo.Text)
                .Parameters.AddWithValue("@DatePrinted", printdate)
                .Parameters.AddWithValue("@DueDate", adjusteddate)
                .Parameters.AddWithValue("@Discount", If(lblAdjustPrice.Text = "Discount:", lblAdjustPrice.Text, DBNull.Value))
                .Parameters.AddWithValue("@Markup", If(lblAdjustPrice.Text = "Mark Up:", lblAdjustPrice.Text, DBNull.Value))
                .Parameters.AddWithValue("@FinalPrice", lblTotalAmount.Text.Replace(",", ""))
                .ExecuteNonQuery()
            End With

            If walkin = False Then
                Call updateOrder()
            End If
            Call saveBillInvoice()
        Catch ex As Exception
            MsgBox("An error occurred frmPrintSalesInvoiceV2(saveBilling): " & ex.Message)
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
            MsgBox("An error occurred frmPrintSalesInvoiceV2(updateOrder): " & ex.Message)
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
                    .Parameters.AddWithValue("@BillingID", billid)
                    .Parameters.AddWithValue("@OrderID", order.SubItems(5).Text)
                    .Parameters.AddWithValue("@Amount", order.SubItems(4).Text)
                    .Parameters.AddWithValue("@ProductID", order.SubItems(7).Text)
                    .ExecuteNonQuery()
                End With
            Next
        Catch ex As Exception
            MsgBox("An error occurred frmPrintSalesInvoiceV2(saveBillInvoice): " & ex.Message)
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
            'mail.To.Add("2718-21@itmlyceumalabang.onmicrosoft.com")
            mail.To.Add("2091-22@itmlyceumalabang.onmicrosoft.com")
            mail.Subject = "Service Invoice FOR" + DateTime.Now

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
            MsgBox("An error occurred frmPrintSalesInvoiceV2(sendEmail): " & ex.Message)
        End Try
    End Sub
    Private Sub printfile()

        Me.FormBorderStyle = FormBorderStyle.None

        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.PrinterSettings = PageSetupDialog1.PrinterSettings

        'PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        'PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeFullWindow)
        If PrintForm1.PrinterSettings.IsValid Then
            Using bitmap As New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
                btnPrint.Visible = False
                Me.DrawToBitmap(bitmap, Me.ClientRectangle)
                bitmap.Save("PrintedInvoice.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                PrintForm1.Print()
            End Using
        End If
        Me.FormBorderStyle = FormBorderStyle.Sizable
        btnPrint.Visible = True
    End Sub

    Private Sub calculateReceipt()
        Try
            Dim totalAmount = 0

            For Each amount As ListViewItem In ListView1.Items
                totalAmount += amount.SubItems(4).Text
            Next

            lblTotal.Text = totalAmount

            lblVATSales.Text = totalAmount - (totalAmount * 0.12)
            lblTotalSales.Text = lblVATSales.Text

            lblAddVAT.Text = (totalAmount * 0.12)

            If format Then
                priceadjust = totalAmount * (priceadjust / 100)
            End If

            lblAdjustPrice.Text = priceadjust

            If lblPriceAdjusted.Text = "Discount:" Then
                lblTotalAmount.Text = (totalAmount - priceadjust).ToString("N2")
            ElseIf lblPriceAdjusted.Text = "Mark Up:" Then
                lblTotalAmount.Text = (totalAmount + priceadjust).ToString("N2")
            Else
                lblTotalAmount.Text = totalAmount
            End If


        Catch ex As Exception
            MsgBox("An error occurred frmPrintSalesInvoiceV2(calculateReceipt): " & ex.Message)
        End Try
    End Sub

    Private Sub frmClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            ListView1.Items.Clear()
            lblAdjustPrice.Text = ""
            If walkin Then
                frmManageSalesV2.btnAddOrder.Visible = True
            End If
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printableArea As Rectangle = e.MarginBounds
        Dim desiredWidth As Integer = 300
        Dim desiredHeight As Integer = 200

        Dim scaleX As Single = desiredWidth / printableArea.Width
        Dim scaleY As Single = desiredHeight / printableArea.Height

        e.Graphics.ScaleTransform(scaleX, scaleY)

        e.HasMorePages = False
    End Sub
    Private Sub loadActivity()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblactivity(UserID, Username, DateTime, Action) VALUES(@UserID, @Username, @DateTime, @Action)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@UserID", frmLoginV2.userid)
                .Parameters.AddWithValue("@Username", frmLoginV2.username)
                .Parameters.AddWithValue("@DateTime", DateTime.Now)
                .Parameters.AddWithValue("@Action", "PRINT SALES INVOICE")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmPrintSalesInvoiceV2(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class