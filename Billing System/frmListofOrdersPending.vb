Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class frmListofOrdersPending

    Public manageOrder As Boolean = False
    Public manageCollection As Boolean = False
    Public manageBilling As Boolean = False
    Private Sub frmListCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        btnAddNew.Visible = False

        If manageCollection Or manageBilling Then 'if searching on billing/collection module
            Call loadCollections()
        Else 'if search on order or sales module
            Call loadCustomers()
        End If
    End Sub
    Private Sub loadCollections()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            ListView1.Columns.Clear()
            ListView1.Columns.Add("Company Name")
            ListView1.Columns.Add("Total Amount Due")
            ListView1.Columns.Add("Remarks")

            'widths
            ListView1.Columns(0).Width = 150
            ListView1.Columns(1).Width = 150
            ListView1.Columns(2).Width = 150

            sql = "SELECT MIN(CompanyName) AS CompanyName, SUM(FinalPrice) AS FinalPrice, MIN(Remarks) As Remarks, CustomerID FROM qrybilling "

            If manageBilling Then
                sql += "WHERE DateDelivered IS NULL"
            ElseIf manageCollection Then
                sql += "WHERE DateDelivered IS NOT NULL"
            End If

            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("CompanyName").ToString())
                x.SubItems.Add(dr("FinalPrice").ToString())
                x.SubItems.Add(If(dr("Remarks"), "Paid", "Not Paid"))
                x.SubItems.Add(dr("CustomerID").ToString())
                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmListCompany(loadCollections): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub loadCustomers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT COALESCE(w.CompanyName, c.CompanyName) AS CompanyName, COALESCE(CONCAT(w.LastName, ', ', w.FirstName), CONCAT(c.LastName, ', ', c.FirstName)) AS ContactPerson, COALESCE(w.PhoneNumber, c.PhoneNumber) AS PhoneNumber, COALESCE(w.Email, c.Email) AS Email, COUNT(o.OrderID) AS PendingOrders, COALESCE(w.Address, c.Address) AS Address, COALESCE(w.DeliveryAddress, o.DeliveryAddress) AS DeliveryAddress, COALESCE(w.CompanyName, c.CompanyName) AS BusinessStyle, DATE_FORMAT(o.DateOrdered, '%M %d, %Y') AS DateOrdered, COALESCE(w.WalkinID, c.CustomerID) AS CustomerID, o.OrderID AS OrderID, o.OrderListID AS OrderListID, COALESCE(w.TIN, c.TIN) AS TIN FROM tblorder o LEFT JOIN tblcustomer c ON o.CustomerID = c.CustomerID LEFT JOIN tblorderwalkin ow ON o.OrderID = ow.OrderID LEFT JOIN tblwalkin w ON ow.WalkinID = w.WalkinID WHERE o.QuotationStatus = 1 AND o.OrderID NOT IN (SELECT OrderID FROM tblbillinvoice) GROUP BY o.OrderID"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("CompanyName").ToString())
                x.SubItems.Add(dr("ContactPerson").ToString())
                x.SubItems.Add(dr("PhoneNumber").ToString())
                x.SubItems.Add(dr("Email").ToString())
                x.SubItems.Add(dr("PendingOrders").ToString())
                x.SubItems.Add(dr("Address").ToString())
                x.SubItems.Add(dr("DeliveryAddress").ToString()) '6
                x.SubItems.Add(dr("BusinessStyle").ToString()) 'business style '7
                x.SubItems.Add(dr("DateOrdered").ToString()) '8
                x.SubItems.Add(dr("CustomerID").ToString()) '9
                x.SubItems.Add(dr("OrderID").ToString()) '10
                x.SubItems.Add(dr("OrderListID").ToString()) '11
                x.SubItems.Add(dr("TIN").ToString) '12
                ListView1.Items.Add(x)
            Loop
            dr.Close()
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

                If manageOrder Then
                    frmManageOrder.orderid = ListView1.SelectedItems(0).SubItems(11).Text
                    frmManageOrder.txtSearchOrder.Text = ListView1.SelectedItems(0).SubItems(0).Text

                ElseIf manageCollection Then
                    frmManageCollectionV3.customerid = ListView1.SelectedItems(0).SubItems(3).Text
                    frmManageCollectionV3.txtCompanyName.Text = ListView1.SelectedItems(0).SubItems(0).Text

                ElseIf manageBilling Then
                    frmManageBilling.customerid = ListView1.SelectedItems(0).SubItems(3).Text
                    frmManageBilling.txtCompanyName.Text = ListView1.SelectedItems(0).SubItems(0).Text

                Else

                    frmManageSalesV2.ListView1.Items.Clear()

                    frmManageSalesV2.lblCustID.Text = ListView1.SelectedItems(0).SubItems(9).Text
                    frmManageSalesV2.orderid = ListView1.SelectedItems(0).SubItems(10).Text
                    frmManageSalesV2.txtCompanyName.Text = ListView1.SelectedItems(0).SubItems(0).Text
                    frmManageSalesV2.txtAddress.Text = ListView1.SelectedItems(0).SubItems(5).Text
                    frmManageSalesV2.txtDeliveryAddress.Text = ListView1.SelectedItems(0).SubItems(6).Text
                    frmManageSalesV2.txtTIN.Text = ListView1.SelectedItems(0).SubItems(12).Text
                End If
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
        If manageOrder Then
            manageOrder = False
        End If
        frmManageSalesV2.btnPrint.Enabled = True
        frmManageSalesV2.lblPONu.Visible = False
        frmManageSalesV2.txtPONo.Visible = False
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
        sql = "SELECT c.CompanyName, CONCAT(c.LastName, ', ', c.FirstName) AS ContactPerson, c.PhoneNumber, c.Email, COUNT(o.OrderID) AS PendingOrders, c.Address, o.DeliveryAddress, c.CompanyName, o.DateOrdered FROM tblorder o INNER JOIN tblcustomer c ON o.CustomerID = c.CustomerID WHERE o.Status = 1 AND (c.CompanyName LIKE @searchTerm1 OR c.LastName LIKE @searchTerm2 OR c.FirstName LIKE @searchTerm3) GROUP BY o.OrderID"

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
        If MsgBox("Do you want to add Customer walk-in Order?", vbYesNo + vbQuestion, "Add Order") = vbYes Then
            Me.Close()
            frmManageSalesV2.ListView1.Items.Clear()
            frmManageSalesV2.txtCompanyName.Clear()
            frmManageSalesV2.txtAddress.Clear()
            frmManageSalesV2.txtDeliveryAddress.Clear()
            frmManageSalesV2.txtTIN.Clear()
            frmManageSalesV2.txtPONo.Clear()
            frmManageSalesV2.cboSalesman.SelectedIndex = -1

            frmAddNewCustomer.ShowDialog()
            frmManagePOS.isRental = False
            frmManageSalesV2.txtAddress.Enabled = True
            frmManageSalesV2.txtDeliveryAddress.Enabled = True
        End If
    End Sub

    Private Sub frmListofOrdersPending_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            manageCollection = False
            manageBilling = False
            manageOrder = False

            Label2.Text = "List of Orders Pending"
        End If
    End Sub
End Class