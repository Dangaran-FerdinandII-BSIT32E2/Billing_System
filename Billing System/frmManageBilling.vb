Public Class frmManageBilling
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmPrintInvoice.ShowDialog()
    End Sub
End Class