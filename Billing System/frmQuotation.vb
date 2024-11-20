﻿Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmQuotation
    Public orderid As String
    Dim d As OpenFileDialog = New OpenFileDialog
    Private Sub frmQuotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadImage()
    End Sub
    Private Sub loadImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT QuotationImg FROM tblorder WHERE OrderID = '" & orderid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                If dr("QuotationImg") IsNot DBNull.Value AndAlso dr("QuotationImg") IsNot Nothing Then
                    Dim pic As Byte() = DirectCast(dr("QuotationImg"), Byte())
                    If pic.Length > 0 Then
                        'Dim ms As New MemoryStream(pic)
                        Using ms As New MemoryStream(pic)
                            PictureBox1.Image = Image.FromStream(ms)
                        End Using

                        PictureBox2.Visible = False
                        btnBrowse.Visible = False

                        btnCancel.Enabled = True
                        btnSend.Enabled = False
                    Else
                        PictureBox1.Image = Nothing
                        PictureBox2.Visible = True
                        btnBrowse.Visible = True
                        btnCancel.Enabled = False
                        btnSend.Enabled = True
                    End If
                End If
            Else
                PictureBox1.Image = Nothing
                PictureBox2.Visible = True
                btnBrowse.Visible = True
                btnCancel.Enabled = False
                btnSend.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmQuotation(loadImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            d.Filter = "JPEG(*.jpg; *.jpeg)|*.jpg|PNG(*.png)|*.png"

            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(d.FileName)

                PictureBox2.Visible = False
                btnBrowse.Visible = False
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmQuotation(btnBrowse_Click): " & ex.Message)
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If PictureBox1.Image IsNot Nothing Then
                If MsgBox("Do you want to continue?", vbYesNo + vbQuestion) = vbYes Then
                    sql = "UPDATE tblorder SET QuotationImg=@QuotationImg WHERE OrderID = '" & orderid & "'"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        Dim mstream As New System.IO.MemoryStream()
                        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Dim arrImage() As Byte = mstream.GetBuffer
                        mstream.Close()
                        .Parameters.AddWithValue("@QuotationImg", arrImage)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Successfully saved!", MsgBoxStyle.Information, "Image Uploading")
                    Call loadImage()
                End If
            Else
                MsgBox("Please upload a picture!", MsgBoxStyle.Critical, "Upload Error")
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmQuotation(btnSend_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        PictureBox1.Image = Nothing
        PictureBox2.Visible = True
        btnBrowse.Visible = True
        btnCancel.Enabled = False
        btnSend.Enabled = True
    End Sub
End Class