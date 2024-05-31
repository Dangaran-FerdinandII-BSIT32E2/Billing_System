Public Class frmManageBilling
    Private Sub btnPrint_Click_1(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmPrintInvoice.ShowDialog()
    End Sub

    Private Sub btnSearchProduct_Click_1(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        frmListProducts.ShowDialog()
    End Sub
End Class