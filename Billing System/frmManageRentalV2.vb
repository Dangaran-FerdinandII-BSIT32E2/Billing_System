Imports MySql.Data.MySqlClient
Public Class frmManageRentalV2
    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        frmManagePOS.isRental = True
        frmManagePOS.ShowDialog()
    End Sub
End Class