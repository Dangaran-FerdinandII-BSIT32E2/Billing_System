Imports System.ComponentModel
Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization
Imports System.IO.Ports
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.DataVisualization.Charting
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class frmAnalyticsData
    Dim debt As Double = 0.0
    Dim paid As Double = 0.0

    Dim c As New Chart()
    Private Sub frmAnalyticsData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call calculateData()
        Call newCustomers()
        Call newOrders()
        Call newPayments()
    End Sub

    Private Sub newCustomers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COUNT(*) AS NewCustomers FROM tblcustomer WHERE tblcustomer.AcctStatus = 0"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim count As Integer = Convert.ToInt32(dr("NewCustomers"))
                If count > 0 Then
                    btnViewCustomer.Visible = True
                    lblNewCustomers.Font = New Font("Arial", 20, FontStyle.Bold)
                    lblNewCustomers.Text = count.ToString()
                Else
                    btnViewCustomer.Visible = False
                    lblNewCustomers.Text = "No New Customer"
                End If
            End If

        Catch ex As Exception
            MsgBox("An error occurred in frmAnalyticsData(newCustomers): " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub newOrders()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COUNT(DISTINCT tblorder.OrderID) as newOrders FROM tblorder WHERE tblorder.Status = 0"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim count As Integer = Convert.ToInt32(dr("newOrders"))
                If count > 0 Then
                    btnViewOrder.Visible = True
                    lblNewOrders.Font = New Font("Arial", 20, FontStyle.Bold)
                    lblNewOrders.Text = count.ToString()
                Else
                    btnViewOrder.Visible = False
                    lblNewOrders.Text = "No New Order"
                End If
            End If

        Catch ex As Exception
            MsgBox("An error occurred in frmAnalyticsData(newOrders): " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub newPayments()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COUNT(DISTINCT CollectionID) as newPayments FROM tblcollection WHERE newInsert = 1"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim count As Integer = Convert.ToInt32(dr("newPayments"))
                If count > 0 Then
                    btnViewPayment.Visible = True
                    lblNewPayments.Font = New Font("Arial", 20, FontStyle.Bold)
                    lblNewPayments.Text = count.ToString()
                Else
                    btnViewPayment.Visible = False
                    lblNewPayments.Text = "No New Payments"
                End If
            End If

        Catch ex As Exception
            MsgBox("An error occurred in frmAnalyticsData(newPayments): " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


    Private Sub calculateData()
        'OVERDUE PAYMENTS
        Call getOverdue()

        'ORDER UPDATES
        Call getOrderUpdates()

        'QUOTATION UPDATES
        Call getQuotation() 'REMOVE QUOTATIONUPDATES NOT IN BILLINOICE

        'RAMBIC PO UPDATED
        Call getRambicPO()

        'CHART
        Call getPaidAndVisualize()
    End Sub

    Private Sub getOverdue()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblbilling WHERE DueDate < CURDATE()"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If Not dr.HasRows Then
                Exit Sub
            End If

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("BillingID").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())

                Dim dueDate As DateTime = Convert.ToDateTime(dr("DueDate"))
                Dim formattedDate As String = dueDate.ToString("MMMM dd, yyyy h:mm tt")

                x.SubItems.Add(formattedDate)
                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(getOverdue): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub getOrderUpdates()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT o.OrderID, b.CompanyName, b.DateDelivered, b.Remarks, o.Status, b.BillingID, b.CustomerID FROM tblbilling b INNER JOIN tblbillinvoice bi ON b.BillingID = bi.BillingID INNER JOIN tblorder o ON bi.OrderID = o.OrderID WHERE o.Status > 0 AND o.Status < 4 AND Remarks = 0 ORDER BY Status ASC"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If Not dr.HasRows Then
                Exit Sub
            End If

            Dim x As ListViewItem
            ListView2.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("OrderID").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(getOrderStatus(dr("Status")).ToString)
                x.SubItems.Add(dr("BillingID").ToString) '3
                x.SubItems.Add(dr("CustomerID").ToString) '4

                If x.SubItems(2).Text = "Delivered" Then
                    x.ForeColor = Color.Green
                ElseIf x.SubItems(2).Text = "In-Transit" Then
                    x.ForeColor = Color.Blue
                Else
                    x.ForeColor = Color.Yellow
                End If

                ListView2.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(getOrderUpdates): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Function getOrderStatus(status As String) As String
        Select Case status
            Case 3
                Return "Delivered"
            Case 2
                Return "In-Transit"
            Case Else
                Return "Ready for Shipment"
        End Select
    End Function

    Private Sub ListView2_DoubleClick(sender As Object, e As EventArgs) Handles ListView2.DoubleClick
        If ListView2.SelectedItems(0).SubItems(2).Text = "In-Transit" Then
            frmDeliveryInformation.billingid = ListView2.SelectedItems(0).SubItems(3).Text
            frmDeliveryInformation.lblCompanyName.Text = ListView2.SelectedItems(0).SubItems(1).Text

            frmDeliveryInformation.confirmdelivery = True
            frmDeliveryInformation.ShowDialog()
        ElseIf ListView2.SelectedItems(0).SubItems(2).Text = "Delivered" Then
            frmDeliveryInformation.btnPrint.Visible = False

            frmDeliveryInformation.billingid = ListView2.SelectedItems(0).SubItems(3).Text

            frmDeliveryInformation.createbilling = True
            frmDeliveryInformation.ShowDialog()
        End If
        Call getOrderUpdates()
    End Sub

    Private Sub getQuotation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT o.OrderID, c.CompanyName, o.QuotationStatus, o.isRental, o.CustomerID FROM tblorder o INNER JOIN tblcustomer c ON o.CustomerID = c.CustomerID WHERE NOT EXISTS ( SELECT 1 FROM tblbillinvoice bi WHERE bi.OrderID = o.OrderID )"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If Not dr.HasRows Then
                Exit Sub
            End If

            Dim x As ListViewItem
            ListView3.Items.Clear()

            Do While dr.Read = True

                Dim quotationStatus As String = getQuotationStatus(
                If(dr.IsDBNull(dr.GetOrdinal("QuotationStatus")),
                    CType(Nothing, Boolean?),
                    dr.GetBoolean(dr.GetOrdinal("QuotationStatus")))
                )

                x = New ListViewItem(dr("OrderID").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(quotationStatus) '2
                x.SubItems.Add(If(dr("isRental") = True, "Rental", "Order"))
                x.SubItems.Add(dr("OrderID").ToString) '4
                x.SubItems.Add(dr("CustomerID").ToString) '5

                If x.SubItems(2).Text = "Approved" Then
                    x.ForeColor = Color.Green
                ElseIf x.SubItems(2).Text = "Rejected" Then
                    x.ForeColor = Color.Red
                Else
                    x.ForeColor = Color.Orange
                End If

                ListView3.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An Error occured at frmAnalyticsData(getQuotation):  " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Function getQuotationStatus(status As Boolean?) As String
        If Not status.HasValue Then
            Return "Pending"
        End If

        Return If(status.Value, "Approved", "Rejected")
    End Function

    Private Sub ListView3_DoubleClick(sender As Object, e As EventArgs) Handles ListView3.DoubleClick
        Dim item As ListViewItem = ListView3.SelectedItems(0)
        If item.SubItems(2).Text = "Rejected" Or item.SubItems(2).Text = "Pending" Then

            frmListofCustomerOrder.lblCompanyName.Text = item.SubItems(1).Text
            frmListofCustomerOrder.orderid = item.SubItems(4).Text
            frmListofCustomerOrder.custid = item.SubItems(5).Text

            Dim order As Boolean = False

            If item.SubItems(3).Text = "Order" Then
                order = True
            End If

            frmListofCustomerOrder.order = order

            frmListofCustomerOrder.ShowDialog()
            Call getQuotation()

        ElseIf item.SubItems(2).Text = "Approved" Then
            frmManageSalesV2.orderid = item.SubItems(4).Text
            frmManageSalesV2.lblCustID.Text = item.SubItems(5).Text

            Dim order As Boolean = False

            If item.SubItems(3).Text = "Order" Then
                order = True
            End If

            frmManageSalesV2.order = order

            Me.Close()
            frmManageSalesV2.TopLevel = False
            frmAdminDashboard.panelDashboard.Controls.Add(frmManageSalesV2)
            frmManageSalesV2.BringToFront()
            frmManageSalesV2.Dock = DockStyle.Fill
            frmManageSalesV2.Show()
        End If
    End Sub

    Private Sub getRambicPO()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT q.PONumber, s.CompanyName, q.Amount, q.DateRequested, q.QuotationID FROM tblquotation q INNER JOIN tblsupplier s ON q.SupplierID = s.SupplierID"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If Not dr.HasRows Then
                Exit Sub
            End If

            Dim x As ListViewItem
            ListView4.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("PONumber").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(dr("Amount").ToString)
                x.SubItems.Add(dr("DateRequested").ToString)
                x.SubItems.Add(dr("QuotationID").ToString) '3

                ListView4.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(newOrders): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub getPaidAndVisualize()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT DATE_FORMAT(DatePaid, '%Y-%m') AS Month, " &
                  "SUM(AmtPaid) AS Paid " &
                  "FROM tblcollection " &
                  "WHERE DatePaid >= DATE_SUB(CURDATE(), INTERVAL 6 MONTH) " &
                  "GROUP BY DATE_FORMAT(DatePaid, '%Y-%m') " &
                  "ORDER BY Month"

            cmd = New MySqlCommand(sql, cn)
            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If Not dr.HasRows Then
                Exit Sub
            End If

            Chart1.Series("Sales").Points.Clear()
            Dim maxAmount As Double = 0
            While dr.Read()
                If IsDBNull(dr("Paid")) Then
                    Exit Sub
                Else
                    Dim month As String = Convert.ToDateTime(dr("Month") & "-01").ToString("MMM yyyy")
                    Dim amount As Double = Convert.ToDouble(dr("Paid"))


                    Chart1.Series("Sales").Points.AddXY(month, amount)


                    maxAmount = Math.Max(maxAmount, amount)

                    If maxAmount >= 100000 Then
                        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "₱#,##0"
                    ElseIf maxAmount >= 1000 Then
                        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "₱#,##0"
                    Else
                        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "₱0"
                    End If
                End If
            End While

            With Chart1
                .Titles.Clear()
                .Titles.Add("Monthly Payments")

                With .ChartAreas(0)
                    .AxisX.Title = "Month"
                    .AxisY.Title = "Amount Paid"
                    .AxisX.LabelStyle.Angle = -45
                End With
            End With

        Catch ex As Exception
            MsgBox("An error occurred while visualizing payment data(getPaidAndVisualize): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnViewCustomer_Click(sender As Object, e As EventArgs) Handles btnViewCustomer.Click
        Dim removeThickness As New Padding(0, 0, 0, 0) 'use to remove border left
        Dim addThickness As New Padding(5, 0, 0, 0) 'use to add border left
        Dim addColor As Color = Color.OrangeRed 'use to filled color border left
        Dim removeColor As Color = Color.Empty 'use to removed filled color border left

        frmManageCustomerV3.TopLevel = False
        frmAdminDashboard.panelDashboard.Controls.Add(frmManageCustomerV3)
        frmManageCustomerV3.BringToFront()
        frmManageCustomerV3.Dock = DockStyle.Fill
        frmManageCustomerV3.Show()

        frmAdminDashboard.btnCustomer.CustomBorderThickness = addThickness
        frmAdminDashboard.btnCustomer.CustomBorderColor = addColor

        'Dim buttons() As Guna2Button = {btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser}
        Dim buttons() As Guna2Button = {frmAdminDashboard.btnProduct, frmAdminDashboard.btnDashboard, frmAdminDashboard.btnSales, frmAdminDashboard.btnBilling, frmAdminDashboard.btnCollection, frmAdminDashboard.btnOrder, frmAdminDashboard.btnSupplier, frmAdminDashboard.btnRental, frmAdminDashboard.btnUser}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollectionV3.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageUsers.Close()
        frmManageRentalV2.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        Dim removeThickness As New Padding(0, 0, 0, 0) 'use to remove border left
        Dim addThickness As New Padding(5, 0, 0, 0) 'use to add border left
        Dim addColor As Color = Color.OrangeRed 'use to filled color border left
        Dim removeColor As Color = Color.Empty 'use to removed filled color border left

        frmManageOrder.TopLevel = False
        frmAdminDashboard.panelDashboard.Controls.Add(frmManageOrder)
        frmManageOrder.BringToFront()
        frmManageOrder.Dock = DockStyle.Fill
        frmManageOrder.Show()

        frmAdminDashboard.btnOrder.CustomBorderThickness = addThickness
        frmAdminDashboard.btnOrder.CustomBorderColor = addColor

        'btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser
        Dim buttons() As Guna2Button = {frmAdminDashboard.btnProduct, frmAdminDashboard.btnDashboard, frmAdminDashboard.btnSales, frmAdminDashboard.btnBilling, frmAdminDashboard.btnCollection, frmAdminDashboard.btnCustomer, frmAdminDashboard.btnSupplier, frmAdminDashboard.btnUser, frmAdminDashboard.btnRental}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollectionV3.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub
End Class