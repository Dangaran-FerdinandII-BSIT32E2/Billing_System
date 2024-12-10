Imports MySql.Data.MySqlClient

Public Class frmDashboardSales
    Private Sub frmDashboardSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call calculateData()
        Call newOrders()
        Call newRentals()
        Call newPayments()
    End Sub
    Private Sub calculateData()
        'OVERDUE PAYMENTS
        Call getOverdue()

        'ORDER UPDATES
        Call getOrderUpdates()

        'QUOTATION UPDATES
        Call getQuotation()

        'RENTAL UPDATES
        Call getRentals()
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
    Private Sub newRentals()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COUNT(DISTINCT tblorder.OrderID) as newOrders FROM tblorder WHERE tblorder.Status = 1"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim count As Integer = Convert.ToInt32(dr("newOrders"))
                If count > 0 Then
                    btnViewRental.Visible = True
                    lblNewRentals.Font = New Font("Arial", 20, FontStyle.Bold)
                    lblNewRentals.Text = count.ToString()
                Else
                    btnViewRental.Visible = False
                    lblNewRentals.Text = "No New Rentals"
                End If
            End If

        Catch ex As Exception
            MsgBox("An error occurred in frmAnalyticsData(newRentals): " & ex.Message)
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

            sql = "SELECT o.OrderID, b.CompanyName, b.DateDelivered, b.Remarks, o.Status, b.BillingID, b.CustomerID FROM tblbilling b INNER JOIN tblbillinvoice bi ON b.BillingID = bi.BillingID INNER JOIN tblorder o ON bi.OrderID = o.OrderID WHERE o.Status > 0 AND o.Status < 4 AND Remarks = 0 AND o.isRental = 0 ORDER BY Status ASC"
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

    Private Sub getRentals()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT o.OrderID, b.CompanyName, b.DateDelivered, b.Remarks, o.Status, b.BillingID, b.CustomerID FROM tblbilling b INNER JOIN tblbillinvoice bi ON b.BillingID = bi.BillingID INNER JOIN tblorder o ON bi.OrderID = o.OrderID WHERE o.Status > 0 AND o.Status < 4 AND Remarks = 0 AND o.isRental = 1 ORDER BY Status ASC"
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
End Class