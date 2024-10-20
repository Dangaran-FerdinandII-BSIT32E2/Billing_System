Imports System.Globalization
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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
    Private Function GetStatusText(status As String) As String
        Select Case status
            Case "5" : Return "Cancelled Order"
            Case "4" : Return "Priority Order"
            Case "3" : Return "Delivered"
            Case "2" : Return "Ready for Shipment"
            Case "1" : Return "Item on Hand"
            Case Else : Return "Item on Process"
        End Select
    End Function

    Private Sub DateFilter1_TextChanged(sender As Object, e As EventArgs) Handles DateFilter1.ValueChanged
        startDate = DateFilter1.Text
        loadFilteredOrders(startDate, endDate)
    End Sub

    Private Sub DateFilter2_TextChanged(sender As Object, e As EventArgs) Handles DateFilter2.ValueChanged
        endDate = DateFilter2.Text
        loadFilteredOrders(startDate, endDate)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            If ListView1.SelectedItems(0).SubItems.Count <> 7 Then
                btnCreateInvoice.Enabled = True
                btnViewOrder.Enabled = True
                btnCancel.Enabled = True
                orderid = ListView1.SelectedItems(0).SubItems(0).Text
                ordersid.Text = orderid
                status = ListView1.SelectedItems(0).SubItems(3).Text
            End If
            If btnViewOrder.Text = "Back" And ListView1.SelectedItems(0).SubItems.Count = 7 Then
                lblOrder.Text = ListView1.SelectedItems(0).SubItems(6).Text
                avail = ListView1.SelectedItems(0).SubItems(4).Text
                status = ListView1.SelectedItems(0).SubItems(5).Text
            End If
        End If
    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            status = Nothing
            If btnViewOrder.Text = "View Items" Then

                ListView1.Columns.Clear()
                ListView1.Columns.Add("Unit")
                ListView1.Columns.Add("Description")
                ListView1.Columns.Add("Quantity")
                ListView1.Columns.Add("Amount")
                ListView1.Columns.Add("Availability")
                ListView1.Columns.Add("Status")

                'widths
                ListView1.Columns(0).Width = 200
                ListView1.Columns(1).Width = 200
                ListView1.Columns(2).Width = 200
                ListView1.Columns(3).Width = 200
                ListView1.Columns(4).Width = 200
                ListView1.Columns(5).Width = 200
                Call viewOrders()
            Else
                ListView1.Columns.Clear()
                ListView1.Columns.Add("OrderID")
                ListView1.Columns.Add("Price")
                ListView1.Columns.Add("Availability")
                ListView1.Columns.Add("Status")
                ListView1.Columns.Add("Ordered Date")

                'widths
                ListView1.Columns(0).Width = 150
                ListView1.Columns(1).Width = 150
                ListView1.Columns(2).Width = 150
                ListView1.Columns(3).Width = 150
                ListView1.Columns(4).Width = 300

                btnViewOrder.Text = "View Items"
                btnCreateInvoice.Text = "Create Invoice"

                btnViewOrder.Enabled = False
                btnCreateInvoice.Enabled = False

                Call loadFilteredOrders(startDate, endDate)
            End If


        Catch ex As Exception
            MsgBox("An error occurred frmManageOrder(btnViewOrder): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Sub viewOrders()
        Try
            sql = "SELECT * FROM qryorder WHERE OrderID = '" & orderid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("Unit").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Quantity").ToString())
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(If(dr("Availability").ToString(), "Yes", "No")) '2
                x.SubItems.Add(GetStatusText(dr("Status").ToString))
                x.SubItems.Add(dr("OrderListID").ToString())
                ListView1.Items.Add(x)
            Loop

            btnCreateInvoice.Text = "Update Item"
            btnViewOrder.Text = "Back"
        Catch ex As Exception
            MsgBox("An error occurred frmManageOrder(viewOrders): " & ex.Message)
        End Try
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        Call loadFilteredOrders(startDate, endDate)
    End Sub

    Private Sub loadFilteredOrders(startDate As String, endDate As String)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
               DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                sql = "SELECT OrderID, CustomerID, SUM(Amount) AS TotalPrice, MIN(Availability) AS Available, MIN(Status) AS Status, OrderDate FROM qryorder WHERE OrderDate BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"


                If cboFilter.SelectedIndex > 0 Then
                    sql += "AND Status = @Status "
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
                    x = New ListViewItem(dr("OrderID").ToString())
                    x.SubItems.Add(dr("TotalPrice").ToString())
                    x.SubItems.Add(If(dr("Available"), "Yes", "No")) '2
                    x.SubItems.Add(GetStatusText(dr("Status").ToString))
                    x.SubItems.Add(dr("OrderDate").ToString()) ' 4
                    x.SubItems.Add(dr("CustomerID").ToString)

                    ' Check if the status is "Urgent" and set the text color accordingly
                    If x.SubItems(3).Text = "Priority Order" Then
                        x.ForeColor = Color.Red
                    End If
                    ListView1.Items.Add(x)
                Loop
                dr.Close()
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageOrder(cboFilter_SelectedIndexChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSearchOrder_Click(sender As Object, e As EventArgs) Handles btnSearchOrder.Click
        frmListCompany.manageOrder = True
        frmListCompany.ShowDialog()
    End Sub

    Private Sub btnCreateInvoice_Click(sender As Object, e As EventArgs) Handles btnCreateInvoice.Click
        If ListView1.SelectedItems.Count > 0 Then
            If btnCreateInvoice.Text = "Create Invoice" And status = "Item on Hand" Then


                frmManageSalesV2.lblCustID.Text = ListView1.SelectedItems(0).SubItems(5).Text
                frmManageSalesV2.orderid = orderid

                Me.Close()
                frmManageSalesV2.TopLevel = False
                frmAdminDashboard.panelDashboard.Controls.Add(frmManageSalesV2)
                frmManageSalesV2.BringToFront()
                frmManageSalesV2.Dock = DockStyle.Fill
                frmManageSalesV2.Show()

                frmManageSales.Close()
                frmManageCollection.Close()
                frmManageSuppliers.Close()
                frmManageProducts.Close()
                frmManageCustomerV2.Close()
                frmManageUsers.Close()
                frmManageRental.Close()
                frmAdminSettings.Close()
            Else
                MsgBox("Please select an available and on-hand order!", MsgBoxStyle.Critical, "Order Error")
            End If
        End If

    End Sub

    Dim avail As String
    Dim status As String
    Private Sub updateInfo(sender As Object, e As EventArgs) Handles ListView1.DoubleClick, btnCreateInvoice.Click
        If ListView1.SelectedItems.Count > 0 Then
            If btnViewOrder.Text = "Back" And ListView1.SelectedItems(0).SubItems.Count = 7 Then
                Try
                    If cn.State <> ConnectionState.Open Then
                        cn.Open()
                    End If

                    sql = "UPDATE tblorder SET Availability=@Availability, Status=@Status WHERE OrderListID = '" & ListView1.SelectedItems(0).SubItems(6).Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    'for status 2 = delivered, 1 = on hold, 0 = process
                    If avail = "No" And status = "Item on Process" Then
                        If MsgBox("Is the item available?", vbYesNo + vbQuestion) = vbYes Then
                            cmd.Parameters.AddWithValue("@Availability", True)
                            cmd.Parameters.AddWithValue("@Status", "0")
                            cmd.ExecuteNonQuery()
                        End If
                    ElseIf avail = "No" And status = "Priority Order" Then
                        If MsgBox("Is the item available?", vbYesNo + vbQuestion) = vbYes Then
                            cmd.Parameters.AddWithValue("@Availability", True)
                            cmd.Parameters.AddWithValue("@Status", "4")
                            cmd.ExecuteNonQuery()
                        End If
                    ElseIf avail = "No" And status = "Item on Hand" Then
                        If MsgBox("Is the item available?", vbYesNo + vbQuestion) = vbYes Then
                            cmd.Parameters.AddWithValue("@Availability", True)
                            cmd.Parameters.AddWithValue("@Status", "1")
                            cmd.ExecuteNonQuery()
                        End If
                    ElseIf avail = "Yes" And status = "Item on Process" Then
                        If MsgBox("Is the item on hand?", vbYesNo + vbQuestion) = vbYes Then
                            cmd.Parameters.AddWithValue("@Availability", True)
                            cmd.Parameters.AddWithValue("@Status", "1")
                            cmd.ExecuteNonQuery()
                        End If
                    ElseIf avail = "Yes" And status = "Item on Hand" Then
                        MsgBox("The item is already on hand.", vbInformation, "Order Information")
                    End If

                    Call viewOrders()
                Catch ex As Exception
                    MsgBox("An error occurred frmManageOrder(updateInfo): " & ex.Message)
                Finally
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
            End If
        Else
            MsgBox("Please select an order item to update!", MsgBoxStyle.Critical, "Update Error")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If ListView1.SelectedItems.Count > 0 Then
            If MsgBox("Do you want to cancel the order?", vbQuestion + vbYesNo) = vbYes Then
                If status <> "Cancelled Order" Then
                    Try
                        If cn.State <> ConnectionState.Open Then
                            cn.Open()
                        End If

                        If btnViewOrder.Text = "View Items" Then 'whole order
                            sql = "UPDATE tblorder SET Availability=@Availability, Status=@Status WHERE OrderID = '" & orderid & "'"
                            cmd = New MySqlCommand(sql, cn)
                            cmd.Parameters.AddWithValue("@Availability", False)
                            cmd.Parameters.AddWithValue("@Status", 5)
                            cmd.ExecuteNonQuery()

                            Call loadFilteredOrders(startDate, endDate)
                        ElseIf btnViewOrder.Text = "Back" Then 'separate item
                            sql = "UPDATE tblorder SET Status=@Status WHERE OrderListID = '" & ListView1.SelectedItems(0).SubItems(6).Text & "'"
                            cmd = New MySqlCommand(sql, cn)
                            cmd.Parameters.AddWithValue("@Availability", False)
                            cmd.Parameters.AddWithValue("@Status", 5)
                            cmd.ExecuteNonQuery()

                            Call viewOrders()
                        End If

                        MsgBox("Order is successfully cancelled!", MsgBoxStyle.Information, "Cancel Order")
                    Catch ex As Exception
                        MsgBox("An error occurred frmManageOrder(btnCancel_Click): " & ex.Message)
                    Finally
                        If cn.State = ConnectionState.Open Then
                            cn.Close()
                        End If
                    End Try
                Else
                    MsgBox("Order is already cancelled!", MsgBoxStyle.Critical, "Cancel Order")
                End If
            End If
        End If
    End Sub
End Class