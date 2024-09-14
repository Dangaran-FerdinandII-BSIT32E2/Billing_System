Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmManageCustomerV2
    Private Sub btnViewInfo_Click(sender As Object, e As EventArgs) Handles btnViewInfo.Click, ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            frmCustomerViewInfo_Order.lblCustID.Text = ListView1.SelectedItems(0).SubItems(5).Text
            frmCustomerViewInfo_Order.ShowDialog()
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

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("CompanyName").ToString())
                x.SubItems.Add(dr("LastName").ToString() + (", ").ToString() + dr("FirstName").ToString())
                x.SubItems.Add(dr("Address").ToString())
                x.SubItems.Add(dr("Email").ToString())
                x.SubItems.Add(dr("PhoneNumber").ToString())
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

    Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
        cn.Close()
        Dim dt As DataTable = SearchDatabase(txtSearchCustomer.Text)
        PopulateListView(dt)
    End Sub
    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "SELECT CompanyName, CONCAT(LastName, ', ',+ FirstName), Address, Email, PhoneNumber, CustomerID FROM tblcustomer WHERE LastName LIKE ? Or CompanyName LIKE ?"
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
    End Sub
End Class