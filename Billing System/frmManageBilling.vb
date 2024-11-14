Imports System.Data.OleDb
Imports System.Globalization
Imports System.Runtime.InteropServices.ComTypes
Imports MySql.Data.MySqlClient
Public Class frmManageBilling

    Dim startDate As String
    Dim endDate As String

    Private Sub frmManageBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        DateFilter1.Text = DateTime.Now.AddDays(-5)
        startDate = DateFilter1.Text

        DateFilter2.Text = DateTime.Now.AddDays(+5)
        endDate = DateFilter2.Text

        Call loadBilling(startDate, endDate)
    End Sub

    Private Sub AddButtonsToListView()
        For i As Integer = 0 To ListView1.Items.Count - 1
            Dim btn As New Button
            btn.Text = "Click Me"
            btn.Location = New Point(ListView1.Items(i).Bounds.Right + 5, ListView1.Items(i).Bounds.Top)
            AddHandler btn.Click, AddressOf Button_Click
            Me.Controls.Add(btn)
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        ' Get the corresponding list item based on the button clicked (logic needed)
        ' Then perform the desired action based on the list item data
    End Sub
    Public Sub loadBilling(startDate As String, endDate As String)
        Try
            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
           DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT BillingID, CompanyName, DATE_FORMAT(DatePrinted, '%Y-%m-%d') AS DatePrinted, Terms FROM qrybilling WHERE Remarks <> 1 AND DatePrinted BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem(dr("BillingID").ToString())
                    x.SubItems.Add(dr("CompanyName").ToString())
                    x.SubItems.Add(dr("DatePrinted").ToString())
                    x.SubItems.Add(dr("Terms").ToString())
                    ListView1.Items.Add(x)
                Loop
                dr.Close()
                Call AddButtonsToListView()
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(loadBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub DateFilter1_TextChanged(sender As Object, e As EventArgs) Handles DateFilter1.TextChanged
        startDate = DateFilter1.Text
        loadBilling(startDate, endDate)
    End Sub

    Private Sub DateFilter2_TextChanged(sender As Object, e As EventArgs) Handles DateFilter2.TextChanged
        endDate = DateFilter2.Text
        loadBilling(startDate, endDate)
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click, ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            frmDeliveryInformation.billingid = ListView1.SelectedItems(0).SubItems(0).Text
            frmDeliveryInformation.startDate = startDate
            frmDeliveryInformation.endDate = endDate
            frmDeliveryInformation.ShowDialog()
        Else
            MsgBox("Please select a billing invoice!", MsgBoxStyle.Information, "Selection Error")
        End If
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        If cboFilter.Text = "Not Delivered" Then
            ListView1.Columns.Clear()
            ListView1.Columns.Add("Invoice No.")
            ListView1.Columns.Add("Company Name")
            ListView1.Columns.Add("Date Printed")
            ListView1.Columns.Add("Terms")
            ListView1.Columns.Add("Status of Delivery")

            ListView1.Columns(0).Width = 200
            ListView1.Columns(1).Width = 200
            ListView1.Columns(2).Width = 200
            ListView1.Columns(3).Width = 200
            ListView1.Columns(4).Width = 200

            Call loadNotDelivered(startDate, endDate)

        ElseIf cboFilter.Text = "Delivered" Then
            ListView1.Columns.Clear()
            ListView1.Columns.Add("Invoice No.")
            ListView1.Columns.Add("Company Name")
            ListView1.Columns.Add("Date Printed")
            ListView1.Columns.Add("Terms")
            ListView1.Columns.Add("Date Delivered")

            ListView1.Columns(0).Width = 200
            ListView1.Columns(1).Width = 200
            ListView1.Columns(2).Width = 200
            ListView1.Columns(3).Width = 200
            ListView1.Columns(4).Width = 200

            Call loadDelivered(startDate, endDate)
        End If
    End Sub
    Private Sub loadDelivered(startDate As String, endDate As String)
        Try
            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
           DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT BillingID, CompanyName, DATE_FORMAT(DatePrinted, '%Y-%m-%d') AS DatePrinted, Terms, DateDelivered FROM qrybilling WHERE Remarks <> 1 AND DateDelivered ISNOT NULL AND DatePrinted BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem(dr("BillingID").ToString())
                    x.SubItems.Add(dr("CompanyName").ToString())
                    x.SubItems.Add(dr("DatePrinted").ToString())
                    x.SubItems.Add(dr("Terms").ToString())
                    x.SubItems.Add(dr("DateDelivered").ToString())
                    ListView1.Items.Add(x)
                Loop
                dr.Close()
                Call AddButtonsToListView()
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(loadBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub loadNotDelivered(startDate As String, endDate As String)
        Try
            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
           DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT BillingID, CompanyName, DATE_FORMAT(DatePrinted, '%Y-%m-%d') AS DatePrinted, Terms, DateDelivered FROM qrybilling WHERE Remarks = 0 AND DateDelivered IS NULL AND DatePrinted BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem(dr("BillingID").ToString())
                    x.SubItems.Add(dr("CompanyName").ToString())
                    x.SubItems.Add(dr("DatePrinted").ToString())
                    x.SubItems.Add(dr("Terms").ToString())
                    x.SubItems.Add(If(IsDBNull(dr("DateDelivered")), "Not Yet Delivered", dr("DateDelivered").ToString()))
                    ListView1.Items.Add(x)
                Loop
                dr.Close()
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(loadNotDelivered): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSearchCompanyName_Click(sender As Object, e As EventArgs) Handles btnSearchCompanyName.Click
        frmListofOrdersPending.manageBilling = True
        frmListofOrdersPending.ShowDialog()
    End Sub

    Public customerid As String
    Private Sub txtCompanyName_TextChanged(sender As Object, e As EventArgs) Handles txtCompanyName.TextChanged
        Call loadSpecific(startDate, endDate)
    End Sub

    Private Sub loadSpecific(startDate As String, endDate As String)
        Try
            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
           DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT BillingID, CompanyName, DATE_FORMAT(DatePrinted, '%Y-%m-%d') AS DatePrinted, Terms FROM qrybilling WHERE Remarks <> 1 AND DatePrinted BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "' AND CustomerID = '" & customerid & "'"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem(dr("BillingID").ToString())
                    x.SubItems.Add(dr("CompanyName").ToString())
                    x.SubItems.Add(dr("DatePrinted").ToString())
                    x.SubItems.Add(dr("Terms").ToString())
                    ListView1.Items.Add(x)
                Loop
                dr.Close()
                Call AddButtonsToListView()
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(loadBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class