Public Class frmManageInvoice
    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnPayNow_Click_1(sender As Object, e As EventArgs)
        frmConfirmPayment.ShowDialog()
    End Sub
End Class