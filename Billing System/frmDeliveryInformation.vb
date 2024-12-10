﻿Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class frmDeliveryInformation

    Public billingid As String
    Dim d As OpenFileDialog = New OpenFileDialog

    Public confirmdelivery As Boolean? = False
    Public createbilling As Boolean? = False

    Private Sub frmManageCollectionV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

        dtpDateDelivered.Text = DateTime.Now

        If createbilling Then
            GroupBox1.Text = "Upload Signed Sales Invoice"
            btnPrint.Visible = True
        ElseIf confirmdelivery Then
            GroupBox1.Text = "Proof of Delivery"
            btnPrint.Visible = False
        End If

        Call loadDeliveryImage()
        Call loadDeliveryDetails()

        Call loadSignedInvoiceImage()
    End Sub

    Private Sub frmManageCollectionV2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            pbxDelivery.Image = Nothing
            PictureBox2.Visible = True
            btnBrowse.Visible = True
            confirmdelivery = False
            createbilling = False

            GroupBox1.Text = "Proof of Delivery"
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
                Dim datePrinted As DateTime = Convert.ToDateTime(dr("DatePrinted"))
                Dim duedate As DateTime = Convert.ToDateTime(dr("DueDate"))

                txtDatePrinted.Text = datePrinted.ToString("MMMM dd, yyyy")
                txtDueDate.Text = duedate.ToString("MMMM dd, yyyy")
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
                            btnBrowse.Visible = False

                            btnConfirm.Enabled = False

                        Else
                            pbxDelivery.Image = Nothing
                            PictureBox2.Visible = True
                            btnBrowse.Visible = True

                            btnConfirm.Enabled = True
                        End If

                    Catch ex As Exception
                        MsgBox("Error loading image: " & ex.Message)
                    End Try
                Else
                    pbxDelivery.Image = Nothing
                    PictureBox2.Visible = True
                    btnBrowse.Visible = True

                    btnConfirm.Enabled = True
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

    Private Sub btnBrowseDelivery_Click(sender As Object, e As EventArgs)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            d.Filter = "JPEG(*.jpg; *.jpeg)|*.jpg|PNG(*.png)|*.png"

            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pbxDelivery.Image = Image.FromFile(d.FileName)

                PictureBox2.Visible = False
                btnBrowse.Visible = False
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmConfirmPayment(btnBrowse): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
            pbxDelivery.Image = Nothing
            PictureBox2.Visible = True
            btnBrowse.Visible = True

            btnConfirm.Enabled = True
        End If
    End Sub

    Private Sub btnConfirmDelivery_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If MsgBox("Do you want to continue?", vbYesNo + vbQuestion) = vbYes Then
                If pbxDelivery.Image IsNot Nothing Then
                    Dim mstream As New System.IO.MemoryStream()
                    pbxDelivery.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer
                    mstream.Close()

                    sql = "UPDATE tblbilling SET imgDelivery=@imgDelivery, DateDelivered=@DateDelivered WHERE BillingID = '" & billingid & "'"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@DateDelivered", dtpDateDelivered.Value)
                        .Parameters.AddWithValue("@imgDelivery", arrImage)
                        .ExecuteNonQuery()
                    End With
                    Call loadActivity()
                    MsgBox("Successfully saved!", MsgBoxStyle.Information, "Image Uploading")

                    Call saveDelivery()


                    btnConfirm.Enabled = False
                    Me.Close()
                Else
                    MsgBox("Please upload an image!", MsgBoxStyle.Critical, "Upload Error")
                End If

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
                .Parameters.AddWithValue("@Action", "Confirm Delivery receipt for")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmAdminSettings(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmPrintBillingInvoiceV2.billingid = billingid
        frmPrintBillingInvoiceV2.ShowDialog()
        Me.Close()
    End Sub
    Private Sub loadPrint()
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
                .Parameters.AddWithValue("@Action", "Printed Delivery receipt for")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmAdminSettings(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadSignedInvoiceImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT imgSigned FROM tblbilling WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                If dr("imgSigned") IsNot DBNull.Value AndAlso dr("imgSigned") IsNot Nothing Then
                    Try
                        Dim pic As Byte() = DirectCast(dr("imgSigned"), Byte())
                        If pic.Length > 0 Then
                            'Dim ms As New MemoryStream(pic)
                            Using ms As New MemoryStream(pic)
                                pbxDelivery.Image = Image.FromStream(ms)
                            End Using

                            PictureBox2.Visible = False
                            btnBrowse.Visible = False

                            btnConfirm.Enabled = False

                        Else
                            pbxDelivery.Image = Nothing
                            PictureBox2.Visible = True
                            btnBrowse.Visible = True

                            btnConfirm.Enabled = True
                        End If

                    Catch ex As Exception
                        MsgBox("Error loading image: " & ex.Message)
                    End Try
                Else
                    pbxDelivery.Image = Nothing
                    PictureBox2.Visible = True
                    btnBrowse.Visible = True

                    btnConfirm.Enabled = True
                End If
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV2(loadSignedInvoiceImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class