Public Class frmPrintInvoice
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ListView1.Items.Clear()
        Me.Close()
    End Sub
End Class