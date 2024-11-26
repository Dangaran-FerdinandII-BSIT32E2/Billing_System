Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmSendPayment
    Public quotationid As String

    Dim d As OpenFileDialog = New OpenFileDialog
    Private Sub frmSendPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadPayment()
    End Sub
    Private Sub loadPayment()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT PaymentIMG FROM tblpayment WHERE QuotationID = '" & quotationid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                If dr("PaymentIMG") IsNot DBNull.Value AndAlso dr("PaymentIMG") IsNot Nothing Then
                    Try
                        Dim pic As Byte() = DirectCast(dr("PaymentIMG"), Byte())
                        If pic.Length > 0 Then
                            'Dim ms As New MemoryStream(pic)
                            Using ms As New MemoryStream(pic)
                                pbxPayment.Image = Image.FromStream(ms)
                            End Using

                            PictureBox2.Visible = False
                            btnBrowse.Visible = False
                            txtAmount.Enabled = True

                        Else
                            pbxPayment.Image = Nothing
                            PictureBox2.Visible = True
                            btnBrowse.Visible = True
                            txtAmount.Enabled = False
                        End If

                    Catch ex As Exception
                        MsgBox("Error loading image: " & ex.Message)
                    End Try
                Else
                    pbxPayment.Image = Nothing
                    PictureBox2.Visible = True
                    btnBrowse.Visible = True
                    txtAmount.Enabled = False
                End If
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmSendPayment(loadPayment): " & ex.Message)
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

                PictureBox2.Visible = False
                btnBrowse.Visible = False

                txtAmount.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmSendPayment(btnBrowse): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If pbxPayment.Image IsNot Nothing AndAlso txtAmount.Text IsNot Nothing Then
            If MsgBox("Do you want to send payment?", vbYesNo + vbQuestion) = vbYes Then
                Try
                    If cn.State <> ConnectionState.Open Then
                        cn.Open()
                    End If
                    Dim mstream As New System.IO.MemoryStream()
                    pbxPayment.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer
                    mstream.Close()

                    sql = "UPDATE tblpayment SET PaymentImg=@PaymentImg, DateSubmitted=@DateSubmitted, AmountPaid=@AmountPaid WHERE QuotationID = '" & quotationid & "'"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@PaymentImg", arrImage)
                        .Parameters.AddWithValue("@DateSubmitted", DateTime.Now)
                        .Parameters.AddWithValue("@AmountPaid", Double.Parse(txtAmount.Text))
                        .ExecuteNonQuery()
                    End With

                Catch ex As Exception
                    MsgBox("An error occurred frmSendPayment(btnSend_Click): " & ex.Message)
                Finally
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
                MsgBox("Payment sent successfully!", MsgBoxStyle.Information, "Payment Status")
            End If
        Else
            MsgBox("Please enter all required fields!", MsgBoxStyle.Critical, "Sending Error")
        End If

    End Sub

    Private Sub frmSendPayment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            pbxPayment.Image = Nothing
            txtAmount.Enabled = True
            txtAmount.Clear()
            txtAmount.Enabled = False

            btnBrowse.Visible = True
            PictureBox2.Visible = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you want to cancel?", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub
End Class