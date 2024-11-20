﻿Imports System.Globalization
Imports System.IO.Ports
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class frmManageCollectionV3

    Dim startDate As String
    Dim endDate As String

    Dim startDateSMS As String
    Dim endDateSMS As String

    Public customerid As String
    Private gsmController As GSMController
    Private Sub frmManageCollectionV3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

        DateFilter1.Text = DateTime.Now.AddDays(-5)
        startDate = DateFilter1.Text

        DateFilter2.Text = DateTime.Now.AddDays(+5)
        endDate = DateFilter2.Text

        Call loadCollections(startDate, endDate)

        'SEND SMS TAB
        Call initializeSMS()
        DateFilter3.Text = DateTime.Now.AddDays(-5)
        startDateSMS = DateFilter1.Text

        DateFilter4.Text = DateTime.Now.AddDays(+5)
        endDateSMS = DateFilter2.Text

        Call loadPayments(startDateSMS, endDateSMS)
    End Sub

    Public Sub loadCollections(startDate As String, endDate As String)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
               DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                sql = "SELECT * FROM qrybilling WHERE DatePrinted BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "' AND DateDelivered IS NOT NULL"


                If cboFilter.SelectedIndex > 0 Then
                    sql += " AND Remarks = @Remarks"
                End If

                cmd = New MySqlCommand(sql, cn)

                If cboFilter.SelectedIndex > 0 Then
                    cmd.Parameters.AddWithValue("@Remarks", cboFilter.SelectedIndex - 1)
                End If

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem(dr("CompanyName").ToString())
                    x.SubItems.Add(dr("FinalPrice").ToString())
                    x.SubItems.Add(If(dr("Remarks"), "Paid", "In Debt"))
                    x.SubItems.Add(dr("BillingID").ToString()) '3
                    x.SubItems.Add(dr("CustomerID").ToString) '4
                    ListView1.Items.Add(x)
                Loop
                dr.Close()
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV3(loadCollections): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub DateFilter1_TextChanged(sender As Object, e As EventArgs) Handles DateFilter1.ValueChanged
        startDate = DateFilter1.Text
        loadCollections(startDate, endDate)
    End Sub

    Private Sub DateFilter2_TextChanged(sender As Object, e As EventArgs) Handles DateFilter2.ValueChanged
        endDate = DateFilter2.Text
        loadCollections(startDate, endDate)
    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click, ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            frmPaymentInformation.billingid = ListView1.SelectedItems(0).SubItems(3).Text
            frmPaymentInformation.customerid = ListView1.SelectedItems(0).SubItems(4).Text
            frmPaymentInformation.Show()
        End If
    End Sub

    Private Sub loadCustomer(startDate As String, endDate As String)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
               DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                sql = "SELECT * FROM qrybilling WHERE DatePrinted BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "' AND DateDelivered IS NOT NULL AND CustomerID = '" & customerid & "' "


                If cboFilter.SelectedIndex > 0 Then
                    sql += "AND Remarks = @Remarks "
                End If

                cmd = New MySqlCommand(sql, cn)

                If cboFilter.SelectedIndex > 0 Then
                    cmd.Parameters.AddWithValue("@Remarks", cboFilter.SelectedIndex - 1)
                End If

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem(dr("CompanyName").ToString())
                    x.SubItems.Add(dr("FinalPrice").ToString())
                    x.SubItems.Add(If(dr("Remarks"), "Paid", "In Debt"))
                    x.SubItems.Add(dr("BillingID").ToString()) '3
                    x.SubItems.Add(dr("CustomerID").ToString) '4
                    ListView1.Items.Add(x)
                Loop
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV3(loadCustomer): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            btnShow.Enabled = True
        End If
    End Sub

    Private Sub btnSearchCompany_Click(sender As Object, e As EventArgs) Handles btnSearchCompany.Click
        frmListofOrdersPending.manageCollection = True
        frmListofOrdersPending.ShowDialog()
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        Call loadCollections(startDate, endDate)
    End Sub

    'SEND SMS TAB
    Private Sub cboFilterSMS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterSMS.SelectedIndexChanged
        loadPayments(startDateSMS, endDateSMS)
    End Sub
    Private Sub loadPayments(startDate As String, endDate As String)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
               DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                sql = "SELECT tblbilling.BillingID, tblbilling.CompanyName, tblbilling.FinalPrice, tblcustomer.CustomerID, tblcustomer.PhoneNumber, tblbilling.SentSMS, CONCAT(tblcustomer.LastName, ', ', tblcustomer.FirstName) AS FullName, DATE_FORMAT(tblbilling.DueDate, '%M %d, %Y') AS DueDate FROM tblbilling INNER JOIN tblcustomer ON tblbilling.CustomerID = tblcustomer.CustomerID WHERE tblbilling.DateDelivered IS NOT NULL AND tblbilling.DueDate "

                If cboFilterSMS.SelectedIndex = 0 Then 'DEFAULT
                    sql += "BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"
                ElseIf cboFilterSMS.SelectedIndex = 1 Then 'UPTODATE
                    sql += "> CURDATE()"
                ElseIf cboFilterSMS.SelectedIndex = 2 Then 'OVERDUE
                    sql += "< CURDATE()"
                End If

                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim y As ListViewItem
                ListView2.Items.Clear()

                Do While dr.Read = True
                    y = New ListViewItem(dr("BillingID").ToString())
                    y.SubItems.Add(dr("CompanyName").ToString())
                    y.SubItems.Add(dr("FullName").ToString())
                    y.SubItems.Add(dr("FinalPrice").ToString())

                    y.SubItems.Add(dr("DueDate").ToString())

                    y.SubItems.Add(If(dr("SentSMS") = True, "Sent", "Not Yet").ToString())
                    y.SubItems.Add(dr("BillingID").ToString())
                    y.SubItems.Add(dr("CustomerID").ToString)
                    y.SubItems.Add(dr("PhoneNumber").ToString) '8
                    ListView2.Items.Add(y)
                Loop
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageCollectionV3(loadPayments): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub DateFilter3_ValueChanged(sender As Object, e As EventArgs) Handles DateFilter3.ValueChanged
        startDateSMS = DateFilter3.Text
        loadPayments(startDateSMS, endDateSMS)
    End Sub

    Private Sub DateFilter4_ValueChanged(sender As Object, e As EventArgs) Handles DateFilter4.ValueChanged
        endDateSMS = DateFilter4.Text
        loadPayments(startDateSMS, endDateSMS)
    End Sub


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        For Each number As ListViewItem In ListView2.Items
            Dim phoneNumber As String = number.SubItems(8).Text
            Dim dueDate As String = number.SubItems(4).Text
            Dim price As String = number.SubItems(3).Text

            Dim message As String = "Your billing statement worth " & price & " pesos is due on " & dueDate & "." & vbCrLf & "Please pay within the timeframe to avoid any possible problems!" & vbCrLf & vbCrLf & "From Rambic Corporation"
            gsmController.SendSMSWithRetry(phoneNumber, message)

            updateSMS(number.SubItems(1).Text)
        Next
    End Sub
    Private Sub initializeSMS()
        Dim initialized As Boolean = False

        For Each portName As String In SerialPort.GetPortNames
            gsmController = New GSMController(portName, 9600)
            If gsmController.Initialize Then
                initialized = True
                Exit For
            End If
        Next

        If Not initialized Then
            MsgBox("SMS texting is not initialized! System can not send SMS. Please contact support.")
        End If
    End Sub

    Private Sub updateSMS(billingid As String)
        Using cn As New MySqlConnection("server=localhost;user=root;password=;database=dbbilling")
            cn.Open()
            sql = "UPDATE tblbilling SET SentSMS=@SentSMS, SENTSMSDate=@SENTSMSDate WHERE BillingID = '" & billingid & "'"
            Using cmd As New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@SentSMS", True)
                    .Parameters.AddWithValue("@SENTSMSDate", DateTime.Now)
                    .ExecuteNonQuery()
                End With
            End Using
        End Using
    End Sub

    Private Sub reloadSMS()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblbilling SET SentSMS = 0, SENTSMSDate = NULL WHERE SentSMS = 1 AND DATE_FORMAT(DATE_ADD(SENTSMSDate, INTERVAL +1 DAY), '%M %d, %Y') = DATE_FORMAT(CURDATE(), '%M %d, %Y')"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("An error occured at frmManageCollectionV3(reloadSMS): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If GSMController IsNot Nothing Then
            GSMController.Close()
        End If
    End Sub
End Class