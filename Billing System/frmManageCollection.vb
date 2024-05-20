Public Class frmManageCollection
    Private Sub btnShow_Click_1(sender As Object, e As EventArgs) Handles btnShow.Click
        frmManageInvoice.TopLevel = False
        frmManageCollectionPanel.Controls.Add(frmManageInvoice)
        frmManageInvoice.BringToFront()
        frmManageInvoice.Show()
    End Sub
End Class