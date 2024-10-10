Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class frmManageCollectionV2

    Public billingid As String
    Public startDate As String
    Public endDate As String
    Dim d As OpenFileDialog = New OpenFileDialog

    Private Sub frmManageCollectionV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        TabControl2.SelectedTab = DeliveryDetails

        'DELIVERY TAB
        Call loadDeliveryImage()
        Call loadDeliveryDetails()

        'CONFIRMATION TAB
        Call loadPaymentImage()
        Call loadPaymentDetails()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            pbxDelivery.Image = Nothing
            PictureBox2.Visible = True
            btnBrowseDelivery.Visible = True

            pbxPayment.Image = Nothing
            PictureBox3.Visible = True
            btnBrowsePayment.Visible = True
        End If
    End Sub

    'DELIVERY DETAILS TAB
    Private Sub loadDeliveryDetails()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT DISTINCT DatePrinted, DueDate FROM tblBilling WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtDatePrinted.Text = dr("DatePrinted").ToString
                txtDueDate.Text = dr("DueDate").ToString
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV2(loadDeliveryDetails): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub loadDeliveryImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT imgDelivery FROM tblbilling WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                If dr("imgDelivery") IsNot DBNull.Value AndAlso dr("imgDelivery") IsNot Nothing Then
                    Try
                        Dim pic As Byte() = DirectCast(dr("imgDelivery"), Byte())
                        If pic.Length > 0 Then
                            'Dim ms As New MemoryStream(pic)
                            Using ms As New MemoryStream(pic)
                                pbxDelivery.Image = Image.FromStream(ms)
                            End Using

                            PictureBox2.Visible = False
                            btnBrowseDelivery.Visible = False

                        Else
                            pbxDelivery.Image = Nothing
                            PictureBox2.Visible = True
                            btnBrowseDelivery.Visible = True
                        End If

                    Catch ex As Exception
                        MsgBox("Error loading image: " & ex.Message)
                    End Try
                Else
                    pbxDelivery.Image = Nothing
                    PictureBox2.Visible = True
                    btnBrowseDelivery.Visible = True
                End If
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV2(loadDeliveryImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnBrowseDelivery_Click(sender As Object, e As EventArgs) Handles btnBrowseDelivery.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            d.Filter = "JPEG(*.jpg; *.jpeg)|*.jpg|PNG(*.png)|*.png"

            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pbxDelivery.Image = Image.FromFile(d.FileName)

                PictureBox2.Visible = False
                btnBrowseDelivery.Visible = False
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmConfirmPayment(btnBrowse): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancelDelivery.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
            pbxDelivery.Image = Nothing
            PictureBox2.Visible = True
            btnBrowseDelivery.Visible = True
        End If
    End Sub

    Private Sub btnConfirmDelivery_Click(sender As Object, e As EventArgs) Handles btnConfirmDelivery.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If MsgBox("Do you want to continue?", vbYesNo + vbQuestion) = vbYes Then
                Dim mstream As New System.IO.MemoryStream()
                pbxDelivery.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer
                mstream.Close()

                sql = "UPDATE tblbilling SET imgDelivery=@imgDelivery, DateDelivered=@DateDelivered, Remarks=@Remarks WHERE BillingID = '" & billingid & "'"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@DateDelivered", dtpDateDelivered.Value)
                    .Parameters.AddWithValue("@Remarks", "1")
                    .Parameters.AddWithValue("@imgDelivery", arrImage)
                    .ExecuteNonQuery()
                End With
                MsgBox("Successfully saved!", MsgBoxStyle.Information, "Image Uploading")

                Call saveDelivery()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV2(btnConfirmDelivery): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub saveDelivery()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblOrder SET Status=@Status WHERE OrderID IN (SELECT OrderID FROM tblbillinvoice WHERE billingid = '" & billingid & "')"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Status", 3)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV2(saveDelivery): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    'COLLECTION TAB


    'CONFIRMATION TAB
    Private Sub loadPaymentDetails()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT CompanyName, SalesMan FROM qrybilling WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtCompanyName.Text = dr("CompanyName").ToString()
                txtEmployee.Text = dr("SalesMan").ToString()
                txtInvoiceNo.Text = billingid
            End If
            dr.Close()

            sql = "SELECT SUM(Amount) FROM tblbillinvoice WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtTotalAmount.Text = dr(0).ToString()
            End If

            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV2(loadPaymentDetails): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub loadPaymentImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT imgPayment FROM tblbilling WHERE BillingID = '" & frmManageCollection.billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                If dr("imgPayment") IsNot DBNull.Value AndAlso dr("imgPayment") IsNot Nothing Then
                    Try
                        Dim pic As Byte() = DirectCast(dr("imgPayment"), Byte())
                        If pic.Length > 0 Then
                            Using ms As New MemoryStream(pic)
                                pbxPayment.Image = Image.FromStream(ms)
                            End Using

                            PictureBox3.Visible = False
                            btnBrowsePayment.Visible = False

                            btnPrintPayment.Enabled = True

                        Else
                            pbxPayment.Image = Nothing
                            btnPrintPayment.Enabled = False
                            PictureBox3.Visible = True
                            btnBrowsePayment.Visible = True
                        End If

                    Catch ex As Exception
                        MsgBox("Error loading image: " & ex.Message)
                    End Try
                Else
                    pbxPayment.Image = Nothing
                    btnPrintPayment.Enabled = False
                    PictureBox3.Visible = True
                    btnBrowsePayment.Visible = True
                End If
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV2(loadPaymentImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnBrowsePayment_Click(sender As Object, e As EventArgs) Handles btnBrowsePayment.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            d.Filter = "JPEG(*.jpg; *.jpeg)|*.jpg|PNG(*.png)|*.png"

            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pbxPayment.Image = Image.FromFile(d.FileName)

                PictureBox3.Visible = False
                btnBrowsePayment.Visible = False
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmConfirmPayment(btnBrowse): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnConfirmPayment_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If MsgBox("Do you want to continue?", vbYesNo + vbQuestion) = vbYes Then
                Dim mstream As New System.IO.MemoryStream()
                pbxPayment.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer
                mstream.Close()

                sql = "UPDATE tblbilling SET imgPayment=@imgPayment, DatePaid=@DatePaid, Remarks=@Remarks WHERE BillingID = '" & billingid & "'"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@DatePaid", dtpDateDelivered.Value)
                    .Parameters.AddWithValue("@Remarks", "2")
                    .Parameters.AddWithValue("@imgPayment", arrImage)
                    .ExecuteNonQuery()
                End With

                'Call savePayment()
                Call frmManageBilling.loadBilling(startDate, endDate)
                MsgBox("Successfully saved!", MsgBoxStyle.Information, "Image Uploading")
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV2(btnConfirmDelivery): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub savePayment()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblbilling SET Remarks=@Remarks WHERE OrderID IN (SELECT OrderID FROM tblbillinvoice WHERE billingid = '" & billingid & "')"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Remarks", "2")
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV2(savePayment): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub btnCancelPayment_Click(sender As Object, e As EventArgs) Handles btnCancelPayment.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
            pbxPayment.Image = Nothing
            PictureBox3.Visible = True
            btnBrowsePayment.Visible = True
        End If
    End Sub

    Private Sub btnPrintDelivery_Click(sender As Object, e As EventArgs) Handles btnPrintDelivery.Click

    End Sub

    Private Sub btnPrintPayment_Click(sender As Object, e As EventArgs) Handles btnPrintPayment.Click
        frmPrintBillingInvoice.billingid = billingid
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT DISTINCT CustomerID FROM tblbillinvoice JOIN tblorder ON tblorder.OrderID = tblbillinvoice.OrderID " &
                    "WHERE tblbillinvoice.BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                frmPrintBillingInvoice.custid = dr("CustomerID").ToString()
            End If

            frmPrintBillingInvoice.ShowDialog()
        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV2(btnPrintPayment): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class