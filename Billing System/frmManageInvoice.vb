﻿Public Class frmManageInvoice
    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        frmConfirmPayment.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class