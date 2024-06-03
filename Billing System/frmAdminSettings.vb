Public Class frmAdminSettings
    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmAdminDashboard.Close()
        Environment.Exit(0)
    End Sub

End Class