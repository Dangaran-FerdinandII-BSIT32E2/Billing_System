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
    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click, ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            frmListofCustomerOrder.ShowDialog()
        Else
            MsgBox("Please select an order!", MsgBoxStyle.Critical, "View Order Error")
        End If
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
                sql = "SELECT *, SUM(Amount) AS TotalPrice, MIN(Availability) AS Available, MIN(Status) AS Status FROM qryorder WHERE OrderDate BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"


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
                    x = New ListViewItem((dr("LastName").ToString) & ", " & (dr("FirstName").ToString()))
                    x.SubItems.Add(dr("CompanyName").ToString())
                    x.SubItems.Add(dr("PhoneNumber").ToString())
                    x.SubItems.Add(dr("Email").ToString())
                    x.SubItems.Add(dr("OrderDate").ToString()) ' 4
                    x.SubItems.Add(GetStatusText(dr("Status").ToString))
                    x.SubItems.Add(dr("OrderID").ToString) '6
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
            If btnCreateInvoice.Text = "Create Invoice" Then


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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            frmListofCustomerOrder.orderid = ListView1.SelectedItems(0).SubItems(6).Text
        End If
    End Sub
End Class