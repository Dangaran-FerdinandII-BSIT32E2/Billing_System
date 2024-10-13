Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Drawing.Printing
Imports System.Windows.Forms.Form
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.PowerPacks.Printing
Imports Mysqlx.Crud
Public Class frmPrintBillingInvoice

    Public billingid As String
    Public custid As String
    Private Sub frmPrintBillingInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadCustomerDetails()
        Call loadDeliveredOrders()
        Call calculateTotalAmt()
    End Sub
    Private Sub loadCustomerDetails()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            'left side
            sql = "SELECT * FROM tblcustomer WHERE CustomerID = '" & custid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblSoldTo.Text = dr("CompanyName").ToString
                lblAddress.Text = dr("Address").ToString
                lblDelivery.Text = dr("Delivery").ToString
                lblBusStyle.Text = dr("CompanyName").ToString ' business style
            End If
            dr.Close()

            'right side
            sql = "SELECT * FROM tblbilling WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblTerms.Text = dr("Terms").ToString()
                'lblTIN.Text = dr("TIN").ToString()
                lblSalesman.Text = dr("SalesMan").ToString()
                lblPONo.Text = dr("ProductOrder").ToString()
                lblDate.Text = Now.Date.ToString
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmPrintBillingInvoice(loadCustomerDetails): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub loadDeliveredOrders()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT DISTINCT tblorder.*, tblproduct.* FROM tblbillinvoice " &
                    "JOIN tblorder ON tblorder.OrderID = tblbillinvoice.OrderID " &
                    "JOIN tblproduct ON tblorder.ProductID = tblproduct.ProductID " &
                    "WHERE tblbillinvoice.BillingID = '" & billingid & "' And Status = 3"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("Quantity").ToString())
                x.SubItems.Add(dr("ProductName").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString())
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(dr("OrderID").ToString())
                x.SubItems.Add(dr("OrderListID").ToString())
                x.SubItems.Add(dr("ProductID").ToString())
                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmPrintBillingInvoice(loadDeliveredOrders): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub calculateTotalAmt()
        Try
            Dim totalAmount = 0

            For Each amount As ListViewItem In ListView1.Items
                totalAmount += amount.SubItems(4).Text
            Next
            lblTotalAmount.Text = totalAmount
        Catch ex As Exception
            MsgBox("An error occurred frmPrintBillingInvoice(calculateTotalAmt): " & ex.Message)
        End Try
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call printfile()
        Call sendEmail()
        Me.Close()
    End Sub

    Private Sub sendEmail()
        Try
            Dim mail As New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("dangaranferds@gmail.com")
            mail.To.Add("2091-22@itmlyceumalabang.onmicrosoft.com")
            mail.Subject = "Billing Statement"

            Using memoryStream As New MemoryStream()
                Using image As Image = Image.FromFile("PrintedBilling.jpeg")
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    memoryStream.Position = 0

                    Dim imageAttachment As New Attachment(memoryStream, "BILLING-INVOICENO_" + billingid + "-.jpeg")
                    mail.Attachments.Add(imageAttachment)

                    smtpServer.Port = 587
                    smtpServer.Credentials = New System.Net.NetworkCredential("dangaranferds@gmail.com", "tpbu vbxk ampu iwua")
                    smtpServer.EnableSsl = True
                    smtpServer.Send(mail)
                End Using
            End Using

            MsgBox("Email sent with form screenshot!")
        Catch ex As Exception
            MsgBox("An error occurred frmPrintBillingInvoice(btnEmail): " & ex.Message)
        End Try
    End Sub
    Private Sub printfile()

        Me.FormBorderStyle = FormBorderStyle.None

        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.PrinterSettings = PageSetupDialog1.PrinterSettings

        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeFullWindow)

        Using bitmap As New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
            btnPrint.Visible = False
            'btnCancel.Visible = False'
            Me.DrawToBitmap(bitmap, Me.ClientRectangle)
            bitmap.Save("PrintedBilling.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Me.PrintForm1.Print()
        End Using

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        ListView1.Items.Clear()
        Me.Close()
    End Sub
End Class