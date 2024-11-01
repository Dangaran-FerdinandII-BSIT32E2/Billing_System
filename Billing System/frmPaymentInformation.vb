Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports MySql.Data.MySqlClient

Public Class frmPaymentInformation

    Public billingid As String
    Public customerid As String
    Dim d As OpenFileDialog = New OpenFileDialog

    Dim totalPaid As Double = 0.0
    Dim totalDebt As Double = 0.0

    Private Sub frmPaymentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadPayment()
    End Sub
    Private Sub loadPayment()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            totalPaid = 0.0

            sql = "SELECT * FROM tblcollection WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("AmtPaid").ToString)
                x.SubItems.Add(dr("DatePaid").ToString)
                ListView1.Items.Add(x)
                totalPaid += Convert.ToDouble(dr("AmtPaid"))
            Loop

            dr.Close()
            Call loadInformation()
        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(loadPayment): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT CompanyName, FinalPrice FROM qrybilling WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtCompanyName.Text = dr(0).ToString
                txtUnpaidAmount.Text = (dr(1) - totalPaid).ToString
                totalDebt = dr(1)
            End If
            dr.Close()

            If totalDebt = totalPaid Then
                Call updateRemark()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(loadInformation): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub updateRemark()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblbilling SET Remarks=@Remarks WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Remarks", "1")
            cmd.ExecuteNonQuery()

            Dim startDate As String = frmManageCollectionV3.DateFilter1.Text

            Dim endDate As String = frmManageCollectionV3.DateFilter2.Text

            Call frmManageCollectionV3.loadCollections(startDate, endDate)
        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(updateRemark): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            d.Filter = "JPEG(*.jpg; *.jpeg)|*.jpg|PNG(*.png)|*.png"

            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pbxDelivery.Image = Image.FromFile(d.FileName)

                PictureBox2.Visible = False
                btnUpload.Visible = False

                btnCancel.Enabled = True
                txtPaidAmount.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(btnUpload_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtPaidAmount_TextChanged(sender As Object, e As EventArgs) Handles txtPaidAmount.TextChanged
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If IsNumeric(txtPaidAmount.Text) Then
                btnSave.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(txtPaidAmount_TextChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If txtPaidAmount.Text <= txtUnpaidAmount.Text Then
                If MsgBox("Do you want to save?", vbYesNo + vbQuestion) = vbYes Then
                    Dim mstream As New System.IO.MemoryStream()
                    pbxDelivery.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer
                    mstream.Close()

                    sql = "INSERT INTO tblcollection(BillingID, CustomerID, AmtPaid, DatePaid, imgPayment) VALUES(@BillingID, @CustomerID, @AmtPaid, @DatePaid, @imgPayment)"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@BillingID", billingid)
                        .Parameters.AddWithValue("@CustomerID", customerid)
                        .Parameters.AddWithValue("@AmtPaid", txtPaidAmount.Text)
                        .Parameters.AddWithValue("@DatePaid", DateTime.Now)
                        .Parameters.AddWithValue("@imgPayment", arrImage)
                        .ExecuteNonQuery()
                    End With

                    btnSave.Enabled = False
                    btnCancel.Enabled = False


                    pbxDelivery.Image = Nothing
                    PictureBox2.Visible = True
                    btnUpload.Visible = True


                    Call loadPayment()
                End If
            Else
                MsgBox("The total amount paid can not be bigger than the unpaid amount!", MsgBoxStyle.Critical, "Payment Error")
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(btnSave_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT imgPayment FROM tblcollection WHERE BillingID = '" & billingid & "'"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    Dim pic As Byte() = DirectCast(dr("imgPayment"), Byte())
                    If pic.Length > 0 Then
                        'Dim ms As New MemoryStream(pic)
                        Using ms As New MemoryStream(pic)
                            pbxDelivery.Image = Image.FromStream(ms)
                        End Using

                        PictureBox2.Visible = False
                        btnUpload.Visible = False

                        btnCancel.Enabled = True
                    End If
                End If
            Catch ex As Exception
                MsgBox("An error occurred frmPaymentInformation(ListView1_SelectedIndexChanged): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
            pbxDelivery.Image = Nothing
            btnUpload.Visible = True
            PictureBox2.Visible = True

            btnSave.Enabled = False
            txtPaidAmount.Clear()
            txtPaidAmount.Enabled = False
            btnUpload.Enabled = True

            btnCancel.Enabled = False
        End If
    End Sub

    Private Sub txtUnpaidAmount_TextChanged(sender As Object, e As EventArgs) Handles txtUnpaidAmount.TextChanged
        If Val(txtUnpaidAmount.Text) = 0 Then
            btnSave.Enabled = False
            btnUpload.Enabled = False
            txtPaidAmount.Text = "Billing Statement is paid!"
        Else
            btnSave.Enabled = True
            btnUpload.Enabled = True
            txtPaidAmount.Clear()
        End If
    End Sub

    Private Sub frmPaymentInformation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            pbxDelivery.Image = Nothing
            btnUpload.Visible = True
            PictureBox2.Visible = True

            btnSave.Enabled = False
            txtPaidAmount.Enabled = False
            btnUpload.Enabled = True
            btnCancel.Enabled = False

            txtCompanyName.Clear()
            txtUnpaidAmount.Clear()
            txtPaidAmount.Clear()
        End If
    End Sub
End Class