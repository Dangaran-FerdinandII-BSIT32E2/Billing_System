Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmRestockProduct
    Public productid As String
    Public supplierid As String

    Private email As String
    Private Sub frmRestockProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation
    End Sub
    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT p.ProductName, p.Image, s.Email, s.CompanyName, p.Amount FROM tblproduct p INNER JOIN tblsupplier s ON p.SupplierID = s.SupplierID  WHERE p.Status < 2 AND p.SupplierID = '" & supplierid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            ListView1.Items.Clear()

            Do While dr.Read = True
                Dim x As ListViewItem

                Dim productimage() As Byte = DirectCast(dr("Image"), Byte())
                Dim ms As New MemoryStream(productimage)
                Dim image As Image = Image.FromStream(ms)

                x = New ListViewItem
                x.ImageIndex = ImageList1.Images.Add(image, Nothing)
                x.SubItems.Add(dr("ProductName").ToString)
                x.SubItems.Add(dr("Amount").ToString)

                ListView1.Items.Add(x)

                txtSupplier.Text = dr("CompanyName").ToString
                email = dr("Email").ToString
            Loop

        Catch ex As Exception
            MsgBox("An Error occurred frmRestockProduct(loadInformation): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancelSupp_Click(sender As Object, e As EventArgs) Handles btnCancelSupp.Click
        Me.Close()
    End Sub

    Private Sub frmRestockProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            txtSupplier.Clear()
            txtPONo.Clear()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "Send Request" Then
            sendRequest()
        End If
    End Sub

    Private Sub sendRequest()
        Try
            Dim mail As New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("dangaranferds@gmail.com")
            mail.To.Add(email)
            mail.Subject = "Restock Request for " & txtSupplier.Text & " - Purchase Order " & txtPONo.Text

            Using memoryStream As New MemoryStream()
                mail.Body = "Dear " & txtSupplier.Text & "," & vbCrLf & vbCrLf & "We hope this email finds you well. We are formally requesting a restock of the following item:"

                smtpServer.Port = 587
                smtpServer.Credentials = New System.Net.NetworkCredential("dangaranferds@gmail.com", "tpbu vbxk ampu iwua")
                smtpServer.EnableSsl = True
                smtpServer.Send(mail)
            End Using
        Catch ex As Exception
            MsgBox("An error occurred frmRestockProduct(sendRequest): " & ex.Message)
        End Try
    End Sub
End Class