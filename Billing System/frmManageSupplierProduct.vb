Public Class frmManageSupplierProduct
    Private Sub btnAddNewSupplier_Click(sender As Object, e As EventArgs) Handles btnAddNewSupplier.Click
        frmManageSupplierV2.Show()
    End Sub

    Private Sub btnAddNewProduct_Click(sender As Object, e As EventArgs) Handles btnAddNewProduct.Click
        frmManageProducts.Show()
    End Sub
End Class