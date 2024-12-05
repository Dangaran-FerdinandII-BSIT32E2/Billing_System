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
        'NEW ORDERS
        Call getNewOrders()

        'ORDER UPDATES
        Call getOrderUpdates()

        'OVERDUE PAYMENTS
        Call getOverdue()

        'NEW PAYMENTS
        Call getNewPayments()

        'CHART
        Call getPaidAndVisualize()
    End Sub

    Private Sub getNewOrders()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT o.OrderID, c.CompanyName, COUNT(o.ProductID) AS TotalProducts, DATE_FORMAT(o.DateOrdered, '%M %d %Y') AS DateOrdered FROM tblorder o INNER JOIN tblcustomer c ON o.CustomerID = c.CustomerID WHERE NOT EXISTS ( SELECT 1 FROM tblbillinvoice bi WHERE bi.OrderID = o.OrderID ) GROUP BY o.OrderID"
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
                x = New ListViewItem(dr("OrderID").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(dr("TotalProducts").ToString())
                x.SubItems.Add(dr("DateOrdered").ToString())

                ListView3.Items.Add(x)
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
    Private Sub ListView3_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ListView3.SelectedItems.Count > 0 Then
            frmListofCustomerOrder.orderid = ListView3.SelectedItems(0).SubItems(0).Text
            frmListofCustomerOrder.lblCompanyName.Text = ListView3.SelectedItems(0).SubItems(1).Text
            frmListofCustomerOrder.ShowDialog()
            Call getNewOrders()
        End If
    End Sub
    Private Sub getOrderUpdates()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT o.OrderID, b.CompanyName, b.DateDelivered, b.Remarks, c.Status, b.BillingID, b.CustomerID FROM tblbilling b INNER JOIN tblbillinvoice bi ON b.BillingID = bi.BillingID INNER JOIN tblorder o ON bi.OrderID = o.OrderID INNER JOIN tblcollection c ON c.BillingID = b.BillingID"
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
                x = New ListViewItem(dr("OrderID").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(getStatus(dr("DateDelivered").ToString, dr("Remarks").ToString, dr("Status").ToString))
                x.SubItems.Add(dr("BillingID").ToString) '3
                x.SubItems.Add(dr("CustomerID").ToString) '4

                If x.SubItems(2).Text = "Payment Accepted" Then
                    x.ForeColor = Color.Green
                ElseIf x.SubItems(2).Text = "Payment Rejected" Then

                End If

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

    Private Function getStatus(datedelivered As String, remarks As String, status As String) As String
        If datedelivered Is Nothing Then
            Return "Not Yet Delivered"
        ElseIf remarks = "0" Then
            Return "Delivered but not Paid"
        ElseIf remarks = "1" Then
            Return "Paid but not Approved"
        ElseIf status = "0" Then
            Return "Payment Rejected"
        Else
            Return "Payment Accepted"
        End If
        Return "Not Yet Delivered"
    End Function

    Private Sub ListView4_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim status As String = ListView4.SelectedItems(0).SubItems(2).Text
        If ListView4.SelectedItems.Count > 0 AndAlso status <> "Payment Accepted" Then
            If status = "Not Yet Delivered" Then
                frmDeliveryInformation.billingid = ListView4.SelectedItems(0).SubItems(3).Text
                frmDeliveryInformation.lblCompanyName.Text = ListView4.SelectedItems(0).SubItems(1).Text
                frmDeliveryInformation.ShowDialog()
                'ElseIf status = "Delivered but not Paid" Then
                ' NEEDS BILLING
            ElseIf status = "Paid but not Approved" Or status = "Payment Rejected" Then
                frmPaymentInformation.billingid = ListView4.SelectedItems(0).SubItems(3).Text
                frmPaymentInformation.customerid = ListView4.SelectedItems(0).SubItems(4).Text
                frmPaymentInformation.ShowDialog()
            End If
            Call getNewOrders()
        Else
            MsgBox("This order's payment is already accepted!", MsgBoxStyle.Information, "Order Status")
        End If
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

    Private Sub getNewPayments()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT bi.OrderID, c.CompanyName, DATE_FORMAT(cn.DatePaid, '%M %d %Y') AS DatePaid, bi.BillingID, c.CustomerID FROM tblcollection cn INNER JOIN tblcustomer c ON cn.CustomerID = c.CustomerID INNER JOIN tblbillinvoice bi ON bi.BillingID = cn.BillingID WHERE cn.newInsert = 1 GROUP BY bi.OrderID"
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
                x.SubItems.Add(dr("DatePaid").ToString)
                x.SubItems.Add(dr("BillingID").ToString()) '3
                x.SubItems.Add(dr("CustomerID").ToString) '4

                ListView2.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(getNewPayments): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.DoubleClick
        If ListView2.SelectedItems.Count > 0 Then
            frmPaymentInformation.billingid = ListView2.SelectedItems(0).SubItems(3).Text
            frmPaymentInformation.customerid = ListView2.SelectedItems(0).SubItems(4).Text
            frmPaymentInformation.ShowDialog()
        End If
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

            While dr.Read()
                If IsDBNull(dr("Paid")) Then
                    Exit Sub
                Else
                    Dim month As String = Convert.ToDateTime(dr("Month") & "-01").ToString("MMM yyyy")
                    Dim amount As Double = Convert.ToDouble(dr("Paid"))

                    Chart1.Series("Sales").Points.AddXY(month, amount)
                End If
            End While

            With Chart1
                .Titles.Clear()
                .Titles.Add("Monthly Payments")

                With .ChartAreas(0)
                    .AxisX.Title = "Month"
                    .AxisY.Title = "Amount Paid"
                    .AxisX.LabelStyle.Angle = -45
                    .AxisY.LabelStyle.Format = "₱"
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
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Call calculateData()
    'End Sub
End Class