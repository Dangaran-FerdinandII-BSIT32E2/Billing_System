Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmManageCustomerV3
    Private Sub frmManageCustomerV3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub btnViewInfo_Click(sender As Object, e As EventArgs) Handles btnViewInfo.Click, ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            If cboSalesman.Text = "View Master List" Or cboSalesman.Text = "Filter by" Then
                frmCustomerViewInfo_Order.lblCustID.Text = ListView1.SelectedItems(0).SubItems(5).Text
            ElseIf cboSalesman.Text = "View Inactive Users" Then
                frmCustomerViewInfo_Order.lblCustID.Text = ListView1.SelectedItems(0).SubItems(3).Text
            ElseIf cboSalesman.Text = "View Pending Orders" Then
                frmCustomerViewInfo_Order.lblCustID.Text = ListView1.SelectedItems(0).SubItems(10).Text
            End If
            frmCustomerViewInfo_Order.ShowDialog()
        Else
            MsgBox("Please select a customer from the list!", MsgBoxStyle.Information, "View Info")
        End If
    End Sub
    Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
        cn.Close()
        Dim dt As DataTable = SearchDatabase(txtSearchCustomer.Text)
        PopulateListView(dt)
    End Sub
    Public Function SearchDatabase(searchTerm As String) As DataTable
        'If cboSalesman.Text = "Filter by" Or cboSalesman.Text = "View Master List" Then
        '    sql = "SELECT CompanyName, CONCAT(LastName, ', ', + FirstName), Address, Email, PhoneNumber, CustomerID FROM tblcustomer WHERE LastName LIKE ? Or CompanyName LIKE ?"
        'ElseIf cboSalesman.Text = "View Inactive Users" Then
        '    sql = "SELECT CompanyName, CONCAT(LastName, ', ', + FirstName), Address, CustomerID FROM tblcustomer WHERE LastName LIKE ? Or CompanyName LIKE ? AND AcctStatus = 0"
        'ElseIf cboSalesman.Text = "View Pending Orders" Then
        '    sql = "SELECT c.*, o.* FROM tblcustomer c INNER JOIN(SELECT CustomerID, COUNT(OrderID) AS OrderCount, DateOrdered, OrderID FROM tblorder WHERE Status <> 2 AND  Status <> 3 AND DueDate IS NULL GROUP BY CustomerID) o ON c.CustomerID = o.CustomerID WHERE LastName LIKE ? Or CompanyName LIKE ?"
        'End If

        sql = "SELECT CompanyName, CONCAT(LastName, ', ', + FirstName), Address, Email, PhoneNumber, CustomerID FROM tblcustomer WHERE LastName LIKE ? Or CompanyName LIKE ?"
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

    Private Sub cboSalesman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSalesman.SelectedIndexChanged
        If cboSalesman.Text = "View Master List" Then
            ListView1.Columns.Clear()
            ListView1.Columns.Add("Company Name")
            ListView1.Columns.Add("Contact Person")
            ListView1.Columns.Add("Address")
            ListView1.Columns.Add("Email Address")
            ListView1.Columns.Add("Phone Number")

            'widths
            ListView1.Columns(0).Width = 250
            ListView1.Columns(1).Width = 200
            ListView1.Columns(2).Width = 400
            ListView1.Columns(3).Width = 250
            ListView1.Columns(4).Width = 200

            Call loadCustomers()
        ElseIf cboSalesman.Text = "View Pending Orders" Then
            ListView1.Columns.Clear()
            ListView1.Columns.Add("Company Name")
            ListView1.Columns.Add("Contact Person")
            ListView1.Columns.Add("Phone Number")
            ListView1.Columns.Add("Email Address")
            ListView1.Columns.Add("Orders Pending")
            ListView1.Columns.Add("Status")
            ListView1.Columns.Add("Address")
            ListView1.Columns.Add("Delivery Address")
            ListView1.Columns.Add("Business Style")
            ListView1.Columns.Add("Date Ordered")

            'widths
            ListView1.Columns(0).Width = 200
            ListView1.Columns(1).Width = 200
            ListView1.Columns(2).Width = 200
            ListView1.Columns(3).Width = 200
            ListView1.Columns(4).Width = 200
            ListView1.Columns(5).Width = 200
            ListView1.Columns(6).Width = 200
            ListView1.Columns(7).Width = 200
            ListView1.Columns(8).Width = 200
            ListView1.Columns(9).Width = 200

            Call loadOrder()
        ElseIf cboSalesman.Text = "View Inactive Users" Then
            ListView1.Columns.Clear()
            ListView1.Columns.Add("Company Name")
            ListView1.Columns.Add("Contact Person")
            ListView1.Columns.Add("Address")

            'widths
            ListView1.Columns(0).Width = 250
            ListView1.Columns(1).Width = 200
            ListView1.Columns(2).Width = 400

            Call loadInactiveUsers()
        End If
        txtSearchCustomer.Clear()
    End Sub

    Private Sub loadOrder()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT c.*, o.* FROM tblcustomer c INNER JOIN(SELECT CustomerID, COUNT(OrderID) AS OrderCount, DateOrdered, OrderID FROM tblorder WHERE Status <> 2 AND  Status <> 3 AND DueDate IS NULL GROUP BY CustomerID) o ON c.CustomerID = o.CustomerID"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("CompanyName").ToString())
                x.SubItems.Add(dr("LastName").ToString() + (", ") + dr("FirstName").ToString())
                x.SubItems.Add(dr("PhoneNumber").ToString())
                x.SubItems.Add(dr("Email").ToString())
                x.SubItems.Add(dr("OrderCount").ToString())
                x.SubItems.Add(If(dr("Status") = "1", "On hold", "On process").ToString())
                x.SubItems.Add(dr("Address").ToString())
                x.SubItems.Add(dr("Delivery").ToString())
                x.SubItems.Add(dr("CompanyName").ToString()) 'business style
                x.SubItems.Add(dr("DateOrdered").ToString())
                x.SubItems.Add(dr("CustomerID").ToString())
                x.SubItems.Add(dr("OrderID").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmListCompany(loadCustomers): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadInactiveUsers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM tblcustomer WHERE AcctStatus = 0"
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
                x.SubItems.Add(dr("CustomerID").ToString())
                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmListCompany(loadInactiveUsers): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If cboSalesman.Text = "View Master List" Or cboSalesman.Text = "Filter by" Then
            Call loadCustomers()
        ElseIf cboSalesman.Text = "View Pending Orders" Then
            Call loadOrder()
        ElseIf cboSalesman.Text = "View Inactive Users" Then
            Call loadInactiveUsers()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class