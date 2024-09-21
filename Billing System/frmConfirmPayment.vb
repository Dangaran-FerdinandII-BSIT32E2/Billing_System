Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.ComTypes
Public Class frmConfirmPayment

    Dim d As OpenFileDialog = New OpenFileDialog

    Private Sub frmConfirmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadImage()
    End Sub
    Private Sub loadImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM testdb WHERE ImageID = 1"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Dim pic As Byte() = DirectCast(dr("image"), Byte())
                Dim ms As New MemoryStream(pic)
                pbxPayment.Image = Image.FromStream(ms)

                btnBrowse.Visible = False
                btnConfirm.Visible = False
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmConfirmPayment(loadImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            d.Filter = "JPEG(*.jpg; *.jpeg)|*.jpg|PNG(*.png)|*.png"

            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pbxPayment.Image = Image.FromFile(d.FileName)
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmConfirmPayment(btnBrowse): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim mstream As New System.IO.MemoryStream()
            pbxPayment.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer
            mstream.Close()

            sql = "INSERT INTO testdb(image, ImageID) VALUES(@image, @ImageID)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@image", arrImage)
                .Parameters.AddWithValue("@ImageID", "1")
                .ExecuteNonQuery()
            End With

            MsgBox("Successfully saved!", MsgBoxStyle.Information, "Image Uploading")
        Catch ex As Exception
            MsgBox("An error occurred frmConfirmPayment(btnConfirm): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    'Private Sub btnEmail_Click(sender As Object, e As EventArgs)
    '    Try
    '        If cn.State <> ConnectionState.Open Then
    '            cn.Open()
    '        End If

    '        Dim mail As New MailMessage
    '        Dim smtpServer As New SmtpClient("smtp.gmail.com")
    '        mail.From = New MailAddress(txtFrom.Text)
    '        mail.To.Add(txtTo.Text)
    '        mail.Subject = ""
    '        mail.Body = ""

    '        smtpServer.Port = 587
    '        smtpServer.Credentials = New System.Net.NetworkCredential(txtFrom.Text, "app_password_Google")
    '        smtpServer.EnableSsl = True
    '        smtpServer.Send(mail)
    '        MsgBox("done!")

    '    Catch ex As Exception
    '        MsgBox("An error occurred frmConfirmPayment(btnEmail): " & ex.Message)
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub
End Class