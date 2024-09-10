Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmManageCustomerV2
    Private Sub btnViewInfo_Click(sender As Object, e As EventArgs) Handles btnViewInfo.Click
        If ListView1.SelectedItems.Count > 0 Then
            frmListofCustomer.lblCustomerID.Text = ListView1.SelectedItems(0).SubItems(4).Text
            frmListofCustomer.Show()
        Else
            MsgBox("Please select a customer from the list!", MsgBoxStyle.Information, "View Info")
        End If
    End Sub
    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        If ListView1.SelectedItems.Count > 0 Then
            frmListofOrder.lblCustomerID.Text = ListView1.SelectedItems(0).SubItems(4).Text
            frmListofOrder.lblCompanyName.Text = ListView1.SelectedItems(0).SubItems(3).Text
            frmListofOrder.Show()
        Else
            MsgBox("Please select a customer from the list!", MsgBoxStyle.Information, "View Info")
        End If
    End Sub
    Private Sub frmManageCustomerV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadCustomers()
    End Sub
    Public Sub loadCustomers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM tblcustomer"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("LastName").ToString() + (", ").ToString() + dr("FirstName").ToString())
                x.SubItems.Add(dr("PhoneNumber").ToString())
                x.SubItems.Add(dr("Email").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(dr("CustomerID").ToString())
                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmManageCustomer(loadCustomers): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

<<<<<<< Updated upstream
    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        frmListofOrder.Show()
=======
    Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
        cn.Close()
        Dim dt As DataTable = SearchDatabase(txtSearchCustomer.Text)
        PopulateListView(dt)
    End Sub
    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "SELECT CONCAT(LastName, ', ',+ FirstName), PhoneNumber, Email, CompanyName, CustomerID FROM tblcustomer WHERE LastName LIKE ? Or CompanyName LIKE ?"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function
    Private Sub PopulateListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
>>>>>>> Stashed changes
    End Sub
End Class