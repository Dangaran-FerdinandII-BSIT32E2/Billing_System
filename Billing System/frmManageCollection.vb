Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmManageCollection

    Public billingid As String
    Private Sub frmManageCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        TabControl2.SelectedTab = DeliveryDetails
        Call loadConfirmation() 'confirmation tab
    End Sub
    Private Sub btnShow_Click_2(sender As Object, e As EventArgs) Handles btnShow.Click
        frmManageInvoice.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmConfirmDelivery.ShowDialog()
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        frmConfirmPayment.ShowDialog()
    End Sub

    'Confirmation Tab
    Private Sub loadConfirmation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

        Catch ex As Exception
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class