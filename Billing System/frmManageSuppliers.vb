Public Class frmManageSuppliers
    Private Sub frmManageSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        cn.Open()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True

        btnEdit.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCreateNew.Enabled = True
        btnEdit.Enabled = True

        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnDelete.Enabled = True

        btnCreateNew.Enabled = False
    End Sub
End Class