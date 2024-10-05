Imports MySql.Data.MySqlClient

Public Class frmListofSuppliers
    Private Sub frmListofSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        cn.Open()
        Call loadSuppliers()
    End Sub

    Private Sub loadSuppliers()
        sql = "SELECT * FROM tblsupplier"
        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader

        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            x = New ListViewItem(dr("CompanyName").ToString())
            x.SubItems.Add(dr("BankDetails").ToString())
            x.SubItems.Add(dr("ContactPerson").ToString())
            x.SubItems.Add(dr("PhoneNumber").ToString())
            x.SubItems.Add(dr("Address").ToString())
            x.SubItems.Add(dr("DeliveryTerms").ToString())
            x.SubItems.Add(dr("SupplierID").ToString())

            ListView1.Items.Add(x)
        Loop
        cn.Close()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            lblSupplierID.Text = ListView1.SelectedItems(0).SubItems(6).Text
        End If
    End Sub

    Private Sub lblSupplierID_TextChanged(sender As Object, e As EventArgs) Handles lblSupplierID.TextChanged
        Try
            cn.Open()
            sql = "Select SupplierID, CompanyName from tblsupplier where SupplierID=@SupplierID"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("SupplierID", lblSupplierID.Text)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                frmManageSuppliers.txtSupplier.Text = dr("CompanyName").ToString()
                frmManageSuppliers.txtSupplierID.Text = dr("SupplierID").ToString()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmListofSuppliers(lblSupplierIDTextChange): " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub
End Class