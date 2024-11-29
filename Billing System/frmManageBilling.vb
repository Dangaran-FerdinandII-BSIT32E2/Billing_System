Imports System.Data.OleDb
Imports System.Globalization
Imports System.Runtime.InteropServices.ComTypes
Imports MySql.Data.MySqlClient
Public Class frmManageBilling

    Dim startDate As String
    Dim endDate As String

    Dim startDelivery As String
    Dim endDelivery As String

    Private Sub frmManageBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        DateFilter1.Text = DateTime.Now.AddDays(-5)
        startDate = DateFilter1.Value.ToString("yyyy-MM-dd")

        DateFilter2.Text = DateTime.Now.AddDays(+5)
        endDate = DateFilter2.Value.ToString("yyyy-MM-dd")

        Call loadBilling(startDate, endDate)

        'NOT DELIVERED

        DateTimePicker2.Text = DateTime.Now.AddDays(-5)
        startDelivery = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        DateTimePicker1.Text = DateTime.Now.AddDays(+5)
        endDelivery = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        Call loadDeliver(startDelivery, endDelivery)
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

                sql = "SELECT BillingID, CompanyName, DATE_FORMAT(DatePrinted, '%Y-%M-%d') AS DatePrinted, DATE_FORMAT(DateDelivered, '%Y-%M-%d') AS DateDelivered, Terms FROM tblbilling WHERE Remarks = 0 AND DateDelivered IS NOT NULL AND DatePrinted BETWEEN '" & startDateTime.ToString("yyyyy-MM-dd") & "' AND '" & endDateTime.ToString("yyyyy-MM-dd") & "'"
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
                    x.SubItems.Add(dr("DateDelivered").ToString())
                    x.SubItems.Add(dr("Terms").ToString())
                    ListView1.Items.Add(x)
                Loop
                dr.Close()

            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(loadBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub DateFilter1_ValueChanged(sender As Object, e As EventArgs) Handles DateFilter1.ValueChanged
        startDate = DateFilter1.Text
        loadBilling(startDate, endDate)
    End Sub
    Private Sub DateFilter2_ValueChanged(sender As Object, e As EventArgs) Handles DateFilter2.ValueChanged
        endDate = DateFilter2.Text
        loadBilling(startDate, endDate)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click, ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            frmDeliveryInformation.billingid = ListView1.SelectedItems(0).SubItems(0).Text
            frmDeliveryInformation.lblCompanyName.Text = ListView1.SelectedItems(0).SubItems(1).Text
            frmDeliveryInformation.ShowDialog()
        Else
            MsgBox("Please select a billing invoice!", MsgBoxStyle.Information, "Selection Error")
        End If
    End Sub

    Private Sub btnSearchCompanyName_Click(sender As Object, e As EventArgs) Handles btnSearchCompanyName.Click
        frmListofOrdersPending.manageBilling = True
        frmListofOrdersPending.Label2.Text = "List of Pending Billing Invoices"
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
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(loadSpecific): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    'LIST OF NOT DELIVERED

    Public Sub loadDeliver(startDate As String, endDate As String)
        Try
            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
           DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT BillingID, CompanyName, DATE_FORMAT(DatePrinted, '%Y-%M-%d') AS DatePrinted, Terms FROM tblbilling WHERE Remarks = 0 AND DateDelivered IS NULL AND DatePrinted BETWEEN '" & startDateTime.ToString("yyyyy-MM-dd") & "' AND '" & endDateTime.ToString("yyyyy-MM-dd") & "'"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView2.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem(dr("BillingID").ToString())
                    x.SubItems.Add(dr("CompanyName").ToString())
                    x.SubItems.Add(dr("DatePrinted").ToString())
                    x.SubItems.Add(dr("Terms").ToString())
                    ListView2.Items.Add(x)
                Loop
                dr.Close()

            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(loadDeliver): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnViewDelivery_Click(sender As Object, e As EventArgs) Handles btnViewDelivery.Click, ListView2.DoubleClick
        If ListView2.SelectedItems.Count > 0 Then
            frmDeliveryInformation.btnPrint.Visible = False
            frmDeliveryInformation.billingid = ListView2.SelectedItems(0).SubItems(0).Text
            frmDeliveryInformation.ShowDialog()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        startDelivery = DateTimePicker2.Text
        loadDeliver(startDelivery, endDelivery)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        endDelivery = DateTimePicker1.Text
        loadDeliver(startDelivery, endDelivery)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            frmDeliveryInformation.btnPrint.Visible = True
            frmDeliveryInformation.billingid = ListView1.SelectedItems(0).SubItems(0).Text
            frmDeliveryInformation.ShowDialog()
        End If
    End Sub
End Class