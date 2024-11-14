Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class frmListofOrdersPending

    Public manageOrder As Boolean = False
    Public manageCollection As Boolean = False
    Public manageBilling As Boolean = False
    Private Sub frmListCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        btnAddNew.Visible = True
        If manageCollection Or manageBilling Then
            btnAddNew.Visible = False
            Call loadCollections()
        Else
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

            sql = "SELECT MIN(CompanyName) AS CompanyName, SUM(FinalPrice) AS FinalPrice, MIN(Remarks) As Remarks, CustomerID FROM qrybilling"
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
                    'ACall frmManageOrder.viewOrders()

                ElseIf manageCollection Then
                    frmManageCollectionV3.customerid = ListView1.SelectedItems(0).SubItems(3).Text
                    frmManageCollectionV3.txtCompanyName.Text = ListView1.SelectedItems(0).SubItems(0).Text

                ElseIf manageBilling Then
                    frmManageBilling.customerid = ListView1.SelectedItems(0).SubItems(3).Text
                    frmManageBilling.txtCompanyName.Text = ListView1.SelectedItems(0).SubItems(0).Text
                Else
                    frmManageSalesV2.lblCustID.Text = ListView1.SelectedItems(0).SubItems(10).Text
                    frmManageSalesV2.orderid = ListView1.SelectedItems(0).SubItems(11).Text
                    frmManageBilling.txtCompanyName.Text = ListView1.SelectedItems(0).SubItems(0).Text
                    Call frmManageSalesV2.loadBilling()
                End If
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
        If MsgBox("Do you want to add Customer walk-in Order?", vbYesNo + vbQuestion, "Add Order") = vbYes Then
            Me.Close()
            frmManageSalesV2.ListView1.Items.Clear()
            frmManageSalesV2.txtCompanyName.Clear()
            frmManageSalesV2.txtAddress.Clear()
            frmManageSalesV2.txtDeliveryAddress.Clear()
            frmManageSalesV2.txtBusinessStyle.Clear()
            frmManageSalesV2.txtTIN.Clear()
            frmManageSalesV2.txtPONo.Clear()
            frmManageSalesV2.txtTerms.Clear()
            frmManageSalesV2.cboSalesman.SelectedIndex = -1

            frmManagePOS.isRental = False
            frmManageSalesV2.btnAddOrder.Visible = True
            frmManageSalesV2.txtCompanyName.PlaceholderText = "Enter Company Name"
            frmManageSalesV2.txtCompanyName.Enabled = True
            frmManageSalesV2.txtAddress.Enabled = True
            frmManageSalesV2.txtDeliveryAddress.Enabled = True
        End If
    End Sub
End Class