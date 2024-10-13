Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class frmListCompany
    Private Sub frmListCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadCustomers()
    End Sub

    Private Sub loadCustomers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT c.*, o.* FROM tblcustomer c INNER JOIN(SELECT CustomerID, COUNT(OrderID) AS OrderCount, DateOrdered, OrderID, OrderListID FROM tblorder WHERE Availability = 1 AND Status = 1 GROUP BY OrderID) o ON c.CustomerID = o.CustomerID"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("CompanyName").ToString())
                x.SubItems.Add(dr("LastName").ToString() + (", ") + dr("FirstName").ToString())
                x.SubItems.Add(dr("PhoneNumber").ToString())
                x.SubItems.Add(dr("Email").ToString())
                x.SubItems.Add(dr("OrderCount").ToString())
                x.SubItems.Add(dr("Address").ToString())
                x.SubItems.Add(dr("Delivery").ToString())
                x.SubItems.Add(dr("CompanyName").ToString()) 'business style
                x.SubItems.Add(dr("Status").ToString())
                x.SubItems.Add(dr("DateOrdered").ToString())
                x.SubItems.Add(dr("CustomerID").ToString())
                x.SubItems.Add(dr("OrderID").ToString())
                x.SubItems.Add(dr("OrderListID").ToString())
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView1.SelectedItems.Count > 0 Then
                frmManageBilling.txtCompanyName.Text = ListView1.SelectedItems(0).SubItems(0).Text
                frmManageSalesV2.lblCustID.Text = ListView1.SelectedItems(0).SubItems(10).Text
                frmManageSalesV2.orderid = ListView1.SelectedItems(0).SubItems(11).Text
                Call frmManageSalesV2.loadBilling()
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmListCompany(SelectedIndexChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Me.Close()
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim dt As DataTable = SearchDatabase(txtSearchProduct.Text)
            PopulateListView(dt)

        Catch ex As Exception
            MsgBox("An error occurred frmListCompany(SearchCompany): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub PopulateListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "SELECT CompanyName, LastName, FirstName, PhoneNumber, Email, Status FROM tblcustomer WHERE CompanyName LIKE ? OR LastName LIKE ? OR FirstName LIKE ?"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm3", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If MsgBox("Add walk-in orders?", vbYesNo + vbQuestion) = vbYes Then
            Me.Close()
            frmManagePOS.isRental = False
            frmAddNewCustomer.ShowDialog()
            'frmManagePOS.ShowDialog()
        End If
    End Sub
End Class