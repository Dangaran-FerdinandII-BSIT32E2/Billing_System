Public Class frmManageCustomerV2
    Private Sub btnViewInfo_Click(sender As Object, e As EventArgs) Handles btnViewInfo.Click
        frmListofCustomer.Show()
    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        frmListofOrder.Show()
    End Sub
End Class