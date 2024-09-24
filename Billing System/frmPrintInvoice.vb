Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System.Net.Mime
Imports MySql.Data.MySqlClient
Public Class frmPrintInvoice

    Private Sub frmPrintVoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadUser()
    End Sub

    Private Sub loadUser()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call saveBilling()
        ListView1.Items.Clear()
        MsgBox("Sucessfully saved billing invoice!", MsgBoxStyle.Information, "Billing Invoice")
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ListView1.Items.Clear()
        Me.Close()
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
                .Parameters.AddWithValue("@CustomerID", lblCustID.Text)
                .Parameters.AddWithValue("@SalesMan", lblSalesman.Text)
                .Parameters.AddWithValue("@Terms", lblTerms.Text)
                .Parameters.AddWithValue("@ProductOrder", lblPuchaseNo.Text)
                .Parameters.AddWithValue("@DatePrinted", frmManageSalesV2.dtpDate.Value)
                .ExecuteNonQuery()
            End With

            Call updateOrder()
            Call saveBillInvoice()
            Call sendEmail()
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

            Using screenshot As New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
                Me.DrawToBitmap(screenshot, Me.ClientRectangle)

                Using memoryStream As New MemoryStream()
                    screenshot.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    memoryStream.Position = 0

                    Dim imageAttachment As New Attachment(memoryStream, "PrintedInvoice-SALESNO_" + frmManageSalesV2.lblBillingID.Text + "-.jpeg")
                    mail.Attachments.Add(imageAttachment)

                    smtpServer.Port = 587
                    smtpServer.Credentials = New System.Net.NetworkCredential("dangaranferds@gmail.com", "fhqo nbkg zryu psyx")
                    smtpServer.EnableSsl = True
                    smtpServer.Send(mail)
                End Using
            End Using

            MsgBox("Email sent with form screenshot!")


        Catch ex As Exception
            MsgBox("An error occurred frmConfirmPayment(btnEmail): " & ex.Message)
        End Try
    End Sub

End Class