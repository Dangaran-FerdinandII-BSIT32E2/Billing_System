Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Public Class frmAnalyticsData

    Dim debt As Double = 0.0
    Dim paid As Double = 0.0

    Dim c As New Chart()
    Private Sub frmAnalyticsData_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Timer1.Tick
        Call connection()
        Call getDebt()
        Call getPaid()
        Dim totalDebt As Double = debt - paid
        lblReceivable.Text = If(totalDebt = 0, "No Account in Deb", "₱" + totalDebt.ToString)
        Call getOverdue()
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

            ' Get monthly payment data for the last 6 months
            sql = "SELECT DATE_FORMAT(PaymentDate, '%Y-%m') AS Month, " &
                  "SUM(AmtPaid) AS Paid " &
                  "FROM tblcollection " &
                  "WHERE PaymentDate >= DATE_SUB(CURDATE(), INTERVAL 6 MONTH) " &
                  "GROUP BY DATE_FORMAT(PaymentDate, '%Y-%m') " &
                  "ORDER BY Month"

            cmd = New MySqlCommand(sql, cn)
            If Not dr.IsClosed Then
                dr.Close()
            End If
            dr = cmd.ExecuteReader

            If Not dr.HasRows Then
                Exit Sub
            End If

            ' Clear existing data
            Chart1.Series("Sales").Points.Clear()

            ' Add data points to the chart
            While dr.Read()
                If IsDBNull(dr("Paid")) Then
                    Exit Sub
                Else
                    Dim month As String = Convert.ToDateTime(dr("Month") & "-01").ToString("MMM yyyy")
                    Dim amount As Double = Convert.ToDouble(dr("Paid"))

                    ' Add the data point
                    Chart1.Series("Payments").Points.AddXY(month, amount)
                End If
            End While

            ' Configure chart appearance
            With Chart1
                .Titles.Clear()
                .Titles.Add("Monthly Payments")

                With .ChartAreas(0)
                    .AxisX.Title = "Month"
                    .AxisY.Title = "Amount Paid"
                    .AxisX.LabelStyle.Angle = -45
                    .AxisY.LabelStyle.Format = "C" ' Currency format
                End With
            End With

        Catch ex As Exception
            MsgBox("An error occurred while visualizing payment data: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class