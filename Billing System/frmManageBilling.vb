Public Class frmManageBilling
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) 
        frmPrintInvoice.ShowDialog()
    End Sub

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) 
        frmListProducts.ShowDialog()
    End Sub
End Class