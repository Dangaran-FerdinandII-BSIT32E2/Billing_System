Public Class frmListofCustomerOrder
    Private Sub btnSendQuotation_Click(sender As Object, e As EventArgs) Handles btnSendQuotation.Click
        frmQuotation.Show()
    End Sub

    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        frmQuotationComment.Show()
    End Sub
End Class