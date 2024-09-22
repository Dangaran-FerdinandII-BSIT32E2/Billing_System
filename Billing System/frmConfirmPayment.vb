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

            sql = "SELECT img_payment FROM tblbilling WHERE BillingID = '" & frmManageCollection.billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                If dr("img_payment") IsNot DBNull.Value AndAlso dr("img_payment") IsNot Nothing Then
                    Try
                        Dim pic As Byte() = DirectCast(dr("img_payment"), Byte())
                        If pic.Length > 0 Then
                            'Dim ms As New MemoryStream(pic)
                            Using ms As New MemoryStream(pic)
                                pbxPayment.Image = Image.FromStream(ms)
                            End Using

                            PictureBox2.Visible = False
                            Label5.Visible = False
                            Guna2Separator1.Visible = False
                            Guna2Separator2.Visible = False
                            Label4.Visible = False
                            btnBrowse.Visible = False
                        Else
                            pbxPayment.Image = Nothing
                        End If

                    Catch ex As Exception
                        MsgBox("Error loading image: " & ex.Message)
                    End Try
                Else
                    pbxPayment.Image = Nothing
                End If
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmConfirmPayment(loadImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
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
            PictureBox2.Visible = False
            Label5.Visible = False
            Guna2Separator1.Visible = False
            Guna2Separator2.Visible = False
            Label4.Visible = False
            btnBrowse.Visible = False
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

            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtAmountPaid", txtAmountPaid}
        }

            For Each fieldName_controlPair In requiredFields
                Dim control As Control = fieldName_controlPair.Value

                If control.Text.Trim = "" Then
                    ErrorProvider1.SetError(control, "This field is required.")
                    filled = False
                    Exit For
                Else
                    ErrorProvider1.SetError(control, "")
                End If
            Next

            If filled Then
                sql = "UPDATE tblbilling SET img_payment=@img_payment, AmtPaid=@AmtPaid WHERE BillingID = '" & frmManageCollection.billingid & "'"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@AmtPaid", txtAmountPaid.Text)
                    .Parameters.AddWithValue("@img_payment", arrImage)
                    .ExecuteNonQuery()
                End With

                MsgBox("Successfully saved!", MsgBoxStyle.Information, "Image Uploading")
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmConfirmPayment(btnConfirm): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
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