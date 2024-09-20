Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmManageCollection
    Private Sub frmManageCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        TabControl2.SelectedTab = DeliveryDetails
    End Sub
    Private Sub btnShow_Click_2(sender As Object, e As EventArgs) Handles btnShow.Click
        frmManageInvoice.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        frmConfirmPayment.ShowDialog()
    End Sub
End Class