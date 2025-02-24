﻿Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class frmManageRentalV2

    Dim startDate As String
    Dim endDate As String
    Private Sub frmManageRentalV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

        DateFilter1.Text = DateTime.Now.AddDays(-5)
        startDate = DateFilter1.Text

        DateFilter2.Text = DateTime.Now.AddDays(+5)
        endDate = DateFilter2.Text

        Call loadRentals(startDate, endDate)

        Call loadRetrieveRental()
    End Sub
    Private Sub DateFilter1_ValueChanged(sender As Object, e As EventArgs) Handles DateFilter1.ValueChanged
        startDate = DateFilter1.Text
        loadRentals(startDate, endDate)
    End Sub

    Private Sub DateFilter2_ValueChanged(sender As Object, e As EventArgs) Handles DateFilter2.ValueChanged
        endDate = DateFilter2.Text
        loadRentals(startDate, endDate)
    End Sub
    Private Sub loadRentals(startDate As String, endDate As String)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
               DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then

                sql = "SELECT COALESCE(w.LastName, o.LastName) AS LastName, COALESCE(w.FirstName, o.FirstName) AS FirstName, COALESCE(w.CompanyName, o.CompanyName) AS CompanyName, COALESCE(w.PhoneNumber, o.PhoneNumber) AS PhoneNumber, COALESCE(w.Email, o.Email) AS Email, o.OrderID, o.CustomerID, o.Status, DATE_FORMAT(o.OrderDate, '%M %d, %Y') AS OrderDateF FROM qryorder o LEFT JOIN tblorderwalkin ow ON ow.OrderID = o.OrderID LEFT JOIN tblwalkin w ON ow.WalkinID = w.WalkinID WHERE o.isRental = 1 AND OrderDate BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"


                If cboFilter.SelectedIndex > 0 Then
                    sql += " AND Status = @Status "
                End If

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
                    x = New ListViewItem(dr("LastName").ToString & ", " & dr("FirstName").ToString)
                    x.Font = New Font("Arial", 12, FontStyle.Regular)
                    x.SubItems.Add(dr("CompanyName").ToString)
                    x.SubItems.Add(dr("PhoneNumber").ToString)
                    x.SubItems.Add(dr("Email").ToString)
                    x.SubItems.Add(dr("OrderDateF").ToString)
                    x.SubItems.Add(GetStatusText(dr("Status").ToString))
                    x.SubItems.Add(dr("OrderID").ToString) '6
                    x.SubItems.Add(dr("CustomerID").ToString)

                    If x.SubItems(5).Text = "Priority Order" Then
                        x.ForeColor = Color.Red
                        x.Font = New Font("Arial", 12, FontStyle.Bold)
                    End If

                    ListView1.Items.Add(x)
                Loop
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occured at frmManageRentalV2(loadRentals): " & ex.Message)
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

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click, ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            frmListofCustomerOrder.lblCompanyName.Text = ListView1.SelectedItems(0).SubItems(1).Text
            frmListofCustomerOrder.orderid = ListView1.SelectedItems(0).SubItems(6).Text
            frmListofCustomerOrder.custid = ListView1.SelectedItems(0).SubItems(7).Text

            frmListofCustomerOrder.order = False

            frmListofCustomerOrder.ShowDialog()
        Else
            MsgBox("Please select an order!", MsgBoxStyle.Critical, "View Order Error")
        End If
    End Sub

    'RETRIEVAL OF PRODUCTS
    Public Sub loadRetrieveRental()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT o.OrderID, COALESCE(w.CompanyName, o.CompanyName) AS CompanyName, COUNT(o.ProductID) AS RentedProducts, DATE_FORMAT(o.RentDueDate, '%M %d, %Y') AS RentDueDate FROM qryorder o LEFT JOIN tblorderwalkin ow ON ow.OrderID = o.OrderID LEFT JOIN tblwalkin w ON ow.WalkinID = w.WalkinID WHERE o.isRental = 1 AND o.isRetrieved = 0 AND RentDueDate <= CURDATE() GROUP BY o.OrderID"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView2.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("OrderID").ToString)
                x.SubItems.Add(dr("CompanyName").ToString)
                x.SubItems.Add(dr("RentedProducts").ToString)
                x.SubItems.Add(dr("RentDueDate").ToString)

                ListView2.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occured at frmManageRentalV2(loadRental): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnViewRetrieval_Click(sender As Object, e As EventArgs) Handles btnViewRetrieval.Click, ListView2.DoubleClick
        frmRetrievalProducts.orderid = ListView2.SelectedItems(0).SubItems(0).Text
        frmRetrievalProducts.ShowDialog()
    End Sub
End Class