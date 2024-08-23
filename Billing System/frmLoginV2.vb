Public Class frmLoginV2
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        frmRegisterV2.TopLevel = False
        pnl_frmLogin.Controls.Add(frmRegisterV2)
        frmRegisterV2.BringToFront()
        frmRegisterV2.Show()
    End Sub
End Class