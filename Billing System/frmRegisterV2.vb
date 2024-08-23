Public Class frmRegisterV2
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmLoginV2.Show()
        Me.Close()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If cboRole.SelectedIndex = 0 Then
            MsgBox("Invalid Role! Please select your role", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class