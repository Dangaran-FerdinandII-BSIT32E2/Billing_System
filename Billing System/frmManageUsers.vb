Public Class frmManageUsers
    Private Sub btnOkay_Click_1(sender As Object, e As EventArgs) Handles btnOkay.Click
        TabControl.SelectedTab = TabPage1 ' Replace 'tabPage1' with the actual name of your TabPage1

    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      TabControl.TabPages.Remove(TabPage2)
    End Sub
End Class