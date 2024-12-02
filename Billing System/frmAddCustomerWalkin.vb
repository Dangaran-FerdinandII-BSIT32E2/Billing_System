Public Class frmAddCustomerWalkin
    Private Sub btnEnterQuantity_Click(sender As Object, e As EventArgs) Handles btnEnterQuantity.Click
        frmEnterQuantity.lblHeaderTitle.Text = "Place Order"
        frmEnterQuantity.ActiveControl = frmEnterQuantity.txtQuantiyProducts
        frmEnterQuantity.ShowDialog()
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        'frmListProducts.ShowDialog()
    End Sub
End Class