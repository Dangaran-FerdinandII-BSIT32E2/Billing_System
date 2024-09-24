Imports System.Data.OleDb
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmManageCollectionV2

    Public billingid As String
    Private Sub frmManageCollectionV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        TabControl2.SelectedTab = DeliveryDetails
        Call loadDeliveryImage()
        Call loadPaymentImage()
    End Sub

    'DELIVERY DETAILS TAB
    Private Sub loadDeliveryImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT imgDelivery FROM tblbilling WHERE BillingID = '" & frmManageCollection.billingid & "'"
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
                        End If

                    Catch ex As Exception
                        MsgBox("Error loading image: " & ex.Message)
                    End Try
                Else
                    pbxDelivery.Image = Nothing
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
    'COLLECTION TAB


    'CONFIRMATION TAB
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
                            'Dim ms As New MemoryStream(pic)
                            Using ms As New MemoryStream(pic)
                                pbxPayment.Image = Image.FromStream(ms)
                            End Using

                            PictureBox3.Visible = False
                            btnBrowsePayment.Visible = False

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
            MsgBox("An error occurred frmManageCollectionV2(loadPaymentImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class