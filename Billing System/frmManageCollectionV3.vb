Imports System.Globalization
Imports System.IO.Ports
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class frmManageCollectionV3

    Dim startDate As String
    Dim endDate As String

    Dim startDateCollection As String
    Dim endDateCollection As String

    Dim startDatePaid As String
    Dim endDatePaid As String

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
                sql = "SELECT b.CompanyName, b.Remarks, b.BillingID, b.CustomerID, b.FinalPrice - COALESCE( SUM( CASE WHEN c.Status = 2 THEN c.AmtPaid ELSE 0 END ), 0 ) AS RemainingBalance, COALESCE(c.newInsert, 0) AS newInsert FROM tblbilling b LEFT JOIN tblcollection c ON b.BillingID = c.BillingID WHERE DateDelivered IS NOT NULL AND DatePrinted BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"


                If cboFilter.SelectedIndex > 0 Then
                    sql += "AND Remarks = @Remarks"
                End If

                sql += " GROUP BY b.BillingID"
                cmd = New MySqlCommand(sql, cn)

                If cboFilter.SelectedIndex > 0 Then
                    cmd.Parameters.AddWithValue("@Remarks", CBool(cboFilter.SelectedIndex = 1))
                End If

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem(dr("BillingID").ToString())
                    x.Font = New Font("Arial", 12, FontStyle.Regular)
                    x.SubItems.Add(dr("CompanyName").ToString)
                    x.SubItems.Add(dr("RemainingBalance").ToString())
                    x.SubItems.Add(checkStatus(dr("RemainingBalance"), dr("BillingID")).ToString)
                    x.SubItems.Add(dr("CustomerID").ToString) '4

                    If dr("newInsert") = 1 Then
                        x.ForeColor = Color.Red
                    End If

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

    Private Function checkStatus(amount As Integer, billingID As String) As String
        Using cn As New MySqlConnection("server=localhost;user=root;password=;database=dbbilling")
            cn.Open()
            sql = "UPDATE tblbilling SET Remarks=@Remarks WHERE BillingID = '" & billingID & "'"
            Using cmd As New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@Remarks", "0")

                    If amount = 0 Then
                        .Parameters("@Remarks").Value = "1"
                    Else
                        .Parameters("@Remarks").Value = "0"
                    End If
                    .ExecuteNonQuery()
                End With


                Select Case amount
                    Case 0
                        Return "Paid"
                    Case Else
                        Return "For Collection"
                End Select
            End Using
        End Using
    End Function

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
            frmPaymentInformation.billingid = ListView1.SelectedItems(0).SubItems(0).Text
            frmPaymentInformation.customerid = ListView1.SelectedItems(0).SubItems(4).Text
            frmPaymentInformation.ShowDialog()
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            btnShow.Enabled = True
        End If
    End Sub

    Private Sub btnSearchCompany_Click(sender As Object, e As EventArgs) Handles btnSearchCompany.Click
        frmListofOrdersPending.manageCollection = True
        frmListofOrdersPending.Label2.Text = "List of Pending Collection Statements"
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
                sql = "SELECT tblbilling.BillingID, tblbilling.CompanyName, COALESCE(tblbilling.FinalPrice - SUM(tblcollection.AmtPaid), 0) AS FinalPrice, tblcustomer.CustomerID, tblcustomer.PhoneNumber, COALESCE(tblbilling.SentSMS, 0) AS SentSMS, CONCAT( tblcustomer.LastName, ', ', tblcustomer.FirstName ) AS FullName, DATE_FORMAT(tblbilling.DueDate, '%M %d, %Y') AS DueDate FROM tblbilling INNER JOIN tblcustomer ON tblbilling.CustomerID = tblcustomer.CustomerID INNER JOIN tblcollection ON tblbilling.BillingID = tblcollection.BillingID WHERE tblbilling.DateDelivered IS NOT NULL AND tblbilling.DueDate "

                btnSend.Visible = True

                If cboFilterSMS.SelectedIndex = 0 Then 'DEFAULT
                    sql += "BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"
                ElseIf cboFilterSMS.SelectedIndex = 1 Then 'UPTODATE
                    sql += "> CURDATE()"
                    btnSend.Visible = False
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
                    y.Font = New Font("Arial", 12, FontStyle.Regular)
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
            gsmController.SendSMSWithRetry(phoneNumber, Message)

            updateSMS(number.SubItems(0).Text)
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
            MsgBox("SMS texting is not initialized! System can not send SMS." & vbCrLf & "Please contact support.")
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

    Public Sub loadForCollection()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT "
        Catch ex As Exception
            MsgBox("An error occured at frmManageCollectionV3(loadForCollection): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub loadPaid()
        Try

        Catch ex As Exception
            MsgBox("An error occured at frmManageCollectionV3(loadPaid): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class