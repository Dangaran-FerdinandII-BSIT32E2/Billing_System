Public Class frmManageUsers
    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl2.TabPages.Remove(TabPage3)
    End Sub

    Private Sub btnOkay_Click_1(sender As Object, e As EventArgs) Handles btnOkay.Click
        TabControl2.SelectedTab = TabPage1 ' Replace 'tabPage1' with the actual name of your TabPage1
    End Sub
End Class