Imports System.Globalization
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class frmManageOrder

    Public orderid As String

    Dim startDate As String
    Dim endDate As String

    Private Sub frmManageOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

        DateFilter1.Text = DateTime.Now.AddDays(-5)
        startDate = DateFilter1.Text

        DateFilter2.Text = DateTime.Now.AddDays(+5)
        endDate = DateFilter2.Text

        Call loadFilteredOrders(startDate, endDate)
    End Sub

    Private Sub DateFilter1_TextChanged(sender As Object, e As EventArgs) Handles DateFilter1.ValueChanged
        startDate = DateFilter1.Text
        loadFilteredOrders(startDate, endDate)
    End Sub

    Private Sub DateFilter2_TextChanged(sender As Object, e As EventArgs) Handles DateFilter2.ValueChanged
        endDate = DateFilter2.Text
        loadFilteredOrders(startDate, endDate)
    End Sub
    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click, ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            frmListofCustomerOrder.lblCompanyName.Text = ListView1.SelectedItems(0).SubItems(1).Text
            frmListofCustomerOrder.orderid = ListView1.SelectedItems(0).SubItems(6).Text
            frmListofCustomerOrder.custid = ListView1.SelectedItems(0).SubItems(7).Text

            frmListofCustomerOrder.order = True

            frmListofCustomerOrder.ShowDialog()

            Call loadFilteredOrders(startDate, endDate)
        Else
            MsgBox("Please select an order!", MsgBoxStyle.Critical, "View Order Error")
        End If
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        Call loadFilteredOrders(startDate, endDate)
    End Sub

    Public Sub loadFilteredOrders(startDate As String, endDate As String)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
               DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                sql = "SELECT CASE WHEN COALESCE(ow.OrderID, o.OrderID) IS NOT NULL THEN CASE WHEN ow.OrderID IS NOT NULL THEN 'Walkin' WHEN o.OrderID IS NOT NULL THEN 'Order' END END AS TypeOfOrder, COALESCE(w.LastName, o.LastName) AS LastName, COALESCE(w.FirstName, o.FirstName) AS FirstName, COALESCE(w.CompanyName, o.CompanyName) AS CompanyName, COALESCE(w.PhoneNumber, o.PhoneNumber) AS PhoneNumber, COALESCE(w.Email, o.Email) AS Email, o.OrderID, o.CustomerID, o.Status, DATE_FORMAT(o.OrderDate, '%M %d, %Y') AS OrderDateF, o.QuotationStatus FROM qryorder o LEFT JOIN tblorderwalkin ow ON ow.OrderID = o.OrderID LEFT JOIN tblwalkin w ON ow.WalkinID = w.WalkinID WHERE o.isRental = 0 AND NOT EXISTS ( SELECT 1 FROM tblbillinvoice bi WHERE bi.OrderID = o.OrderID) AND OrderDate BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"


                If cboFilter.SelectedIndex > 0 Then
                    sql += " AND Status = @Status "
                End If

                sql += "GROUP BY OrderID"
                cmd = New MySqlCommand(sql, cn)

                If cboFilter.SelectedIndex > 0 Then
                    cmd.Parameters.AddWithValue("@Status", cboFilter.SelectedIndex - 1)
                End If

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem((dr("LastName").ToString) & ", " & (dr("FirstName").ToString()))
                    x.Font = New Font("Arial", 12, FontStyle.Regular)
                    x.SubItems.Add(dr("CompanyName").ToString())
                    x.SubItems.Add(dr("PhoneNumber").ToString())
                    x.SubItems.Add(dr("Email").ToString())
                    x.SubItems.Add(dr("OrderDateF").ToString()) ' 4
                    x.SubItems.Add(GetStatusText(dr("Status").ToString))
                    x.SubItems.Add(dr("OrderID").ToString) '6
                    x.SubItems.Add(dr("CustomerID").ToString)
                    x.SubItems.Add(dr("QuotationStatus").ToString)

                    If dr("TypeofOrder").ToString = "Walkin" Then
                        x.ForeColor = Color.Blue
                    Else
                        x.ForeColor = Color.Black
                    End If

                    ' Check if the status is "Urgent" and set the text color accordingly
                    If x.SubItems(5).Text = "Priority Order" Then
                        x.ForeColor = Color.Red
                        x.Font = New Font("Arial", 12, FontStyle.Bold)
                    End If

                    ListView1.Items.Add(x)
                Loop
                dr.Close()
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageOrder(loadFilteredOrders): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Function GetStatusText(status As String) As String
        Select Case status
            Case "5" : Return "Cancelled Order"
            Case "4" : Return "Priority Order"
            Case "3" : Return "Delivered"
            Case "2" : Return "Ready for Shipment"
            Case "1" : Return "On Hand"
            Case Else : Return "On Process"
        End Select
    End Function

    Private Sub btnSearchOrder_Click(sender As Object, e As EventArgs) Handles btnSearchOrder.Click
        frmListofOrdersPending.manageOrder = True

        frmListofOrdersPending.Label2.Text = "List of Pending Orders"
        frmListofOrdersPending.ShowDialog()
    End Sub

    Private Sub btnCreateInvoice_Click(sender As Object, e As EventArgs) Handles btnCreateInvoice.Click
        Dim removeThickness As New Padding(0, 0, 0, 0) 'use to remove border left
        Dim addThickness As New Padding(5, 0, 0, 0) 'use to add border left
        Dim addColor As Color = Color.OrangeRed 'use to filled color border left
        Dim removeColor As Color = Color.Empty 'use to removed filled color border left

        frmAdminDashboard.btnSales.CustomBorderThickness = addThickness
        frmAdminDashboard.btnSales.CustomBorderColor = addColor

        Dim buttons() As Guna2Button = {frmAdminDashboard.btnOrder}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        If ListView1.SelectedItems.Count > 0 Then

            frmManageSalesV2.lblCustID.Text = ListView1.SelectedItems(0).SubItems(7).Text
            frmManageSalesV2.orderid = ListView1.SelectedItems(0).SubItems(6).Text

            Me.Close()
            frmManageSalesV2.TopLevel = False
            frmAdminDashboard.panelDashboard.Controls.Add(frmManageSalesV2)
            frmManageSalesV2.BringToFront()
            frmManageSalesV2.Dock = DockStyle.Fill
            frmManageSalesV2.Show()
        Else
            MsgBox("Please update the order to be available and on-hand!", MsgBoxStyle.Critical, "Create Invoice Error")
        End If
    End Sub

    Private Sub btnAddWalkIn_Click(sender As Object, e As EventArgs) Handles btnAddWalkIn.Click
        frmAddCustomerWalkin.ActiveControl = frmAddCustomerWalkin.txtCompanyName
        frmAddCustomerWalkin.ShowDialog()
        Call loadFilteredOrders(startDate, endDate)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim quotationstatus As String = ListView1.SelectedItems(0).SubItems(8).Text
            btnViewOrder.Enabled = True
            btnCancel.Enabled = True
            If Not String.IsNullOrWhiteSpace(quotationstatus) AndAlso quotationstatus = "True" Then
                btnCreateInvoice.Enabled = True
            Else
                btnCreateInvoice.Enabled = False
            End If
        Else
            btnViewOrder.Enabled = False
            btnCancel.Enabled = False
            btnCreateInvoice.Enabled = False
        End If
    End Sub
End Class