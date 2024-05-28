Public Class frmManageBilling
    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs)
        frmListProducts.ShowDialog()
    End Sub

    Private Sub btnPrint_Click_1(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmPrintInvoice.ShowDialog()
    End Sub
End Class