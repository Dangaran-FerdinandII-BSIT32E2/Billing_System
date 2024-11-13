Imports System.Globalization
Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class frmAnalyticsData

    Dim debt As Double = 0.0
    Dim paid As Double = 0.0

    Dim c As New Chart()

    Private gsmController As GSMController
    Dim overdue As Boolean = False
    Private Sub frmAnalyticsData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call calculateData()
        Call reloadSMS()
        Call checkOverdue()
        If overdue Then
            Call overdueSMS()
        End If
        Call sendSMS()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call calculateData()
    End Sub
    Private Sub calculateData()
        Call getDebt()
        Call getPaid()
        Dim totalDebt As Double = debt - paid
        lblReceivable.Text = If(totalDebt = 0, "No Account in Deb", "₱" + totalDebt.ToString)
        Call getOverdue()
        Call getPaidAndVisualize()
    End Sub
    Private Sub getDebt()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT SUM(FinalPrice) AS Debt FROM qrybilling"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                If IsDBNull(dr("Debt")) Then
                    Exit Sub
                Else
                    debt = Convert.ToDouble(dr("Debt"))
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(getDebt): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub getPaid()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT DATE_FORMAT(DatePaid, '%Y-%m') AS Month, SUM(AmtPaid) AS Paid FROM tblcollection WHERE DatePaid >= DATE_SUB(CURDATE(), INTERVAL 6 MONTH) GROUP BY DATE_FORMAT(DatePaid, '%Y-%m') ORDER BY Month"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Chart1.Series("Sales").Points.Clear()
            While dr.Read()
                If IsDBNull(dr("Paid")) Then
                    Exit Sub
                Else
                    Dim month As String = Convert.ToDateTime(dr("Month") & "-01").ToString("MMM yyyy")
                    Dim amount As Double = Convert.ToDouble(dr("Paid"))

                    ' Add the data point
                    Chart1.Series("Sales").Points.AddXY(month, amount)
                    paid = Convert.ToDouble(dr("Paid"))
                End If
            End While

        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(getPaid): " & ex.Message)
        Finally
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
            MsgBox("An error occured at frmAnalyticsData(getPaid): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
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

                    Chart1.Series("Payments").Points.AddXY(month, amount)
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
    Private Sub sendSMS()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT tblbilling.BillingID AS BillingID, tblbilling.CustomerID AS CustomerID, tblcustomer.PhoneNumber AS PhoneNumber, tblbilling.SentSMS AS SentSMS, DATE_FORMAT(MIN(tblbilling.SENTSMSDate), '%M %d, %Y') AS SentSMSDate, DATE_FORMAT(MIN(DueDate), '%M %d, %Y') AS DueDate " &
                    "FROM tblbilling " &
                    "INNER JOIN tblcustomer " &
                    "ON tblbilling.CustomerID = tblcustomer.CustomerID " &
                    "WHERE (DATE(tblbilling.DueDate) - CURDATE() IN (1, -1)) AND tblbilling.SentSMS IS FALSE"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            While dr.Read = True
                'sendingSMS(dr("PhoneNumber").ToString, dr("DueDate".ToString))
                updateSMS(dr("BillingID").ToString)
            End While

        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(sendSMS): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


    Private Sub sendingSMS(phoneNumber As String, dateTime As String)
        Dim portNames() As String = SerialPort.GetPortNames
        For Each portName As String In portNames
            gsmController = New GSMController(portName, 9600)

            If gsmController.Initialize Then
                Dim message As String = "Your billing statement is due on " & dateTime & "." & vbCrLf & "Please pay within the timeframe to avoid any possible problems!" & vbCrLf & vbCrLf & "From Rambic Corporation"
                gsmController.SendSMS(phoneNumber, message)
            Else
                MsgBox("SMS texting is not initialized! System can not send SMS. Please contact support.")
            End If
        Next
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If gsmController IsNot Nothing Then
            gsmController.Close()
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
            MsgBox("An error occured at frmAnalyticsData(reloadSMS): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub checkOverdue()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblbilling SET SentSMS = 0, SentSMSDate = DATE_ADD(CURDATE(), INTERVAL 7 DAY) WHERE Remarks = 0 AND DATE_FORMAT(DueDate, '%M %d, %Y') < DATE_FORMAT(CURDATE(), '%M %d, %Y') AND DATE_FORMAT(SentSMSDate, '%M %d, %Y') = DATE_FORMAT(CURDATE(), '%M %d, %Y')"
            cmd = New MySqlCommand(sql, cn)

            Dim result As Integer = cmd.ExecuteNonQuery

            If result > 0 Then
                overdue = True
            Else
                overdue = False
            End If

        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(checkOverdue): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub overdueSMS()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT b.BillingID AS BillingID, b.CustomerID As CustomerID, c.PhoneNumber AS PhoneNumber, " &
                    "b.SentSMS As SentSMS, DATE_FORMAT((b.SENTSMSDate), '%M %d, %Y') AS SentSMSDate, DATE_FORMAT((b.DueDate), '%M %d, %Y') AS DueDate, b.FinalPrice AS Price " &
                    "FROM tblbilling b INNER Join tblcustomer c ON b.CustomerID = c.CustomerID " &
                    "WHERE (WEEK(b.DueDate) < WEEK(CURDATE()) " &
                    "AND DATE(b.SENTSMSDate) = DATE(CURDATE() + INTERVAL 7 DAY)) AND b.SentSMS = 0 AND b.Remarks = 0"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            While dr.Read = True
                sendingOverdue(dr("PhoneNumber").ToString, dr("DueDate").ToString, dr("Price").ToString)
                updateOverdue(dr("BillingID").ToString)
            End While

        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(overdueSMS): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub sendingOverdue(phoneNumber As String, month As String, price As String)
        Dim portNames() As String = SerialPort.GetPortNames
        For Each portName As String In portNames
            gsmController = New GSMController(portName, 9600)

            If gsmController.Initialize Then
                Dim message As String = "Your billing statement for " & month & " totalling ₱" & price & " is past due." & vbCrLf & "If the bill is not settled promptly, there will be a possible field visit to your main office to discuss the matter further." & vbCrLf & vbCrLf & "From Rambic Corporation, with loves <3 <3"
                gsmController.SendSMS(phoneNumber, message)
            Else
                MsgBox("SMS texting is not initialized! System can not send SMS. Please contact support.")
            End If
        Next
    End Sub

    Private Sub updateOverdue(billingid As String)
        Using cn As New MySqlConnection("server=localhost;user=root;password=;database=dbbilling")
            cn.Open()
            sql = "UPDATE tblbilling SET SentSMS = 1 WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class