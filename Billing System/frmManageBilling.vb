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
    Private Sub loadBilling(startDate As String, endDate As String)
        Try
            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
           DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT BillingID, CompanyName, DATE_FORMAT(DatePrinted, '%Y-%m-%d') AS DatePrinted, Terms, DatePaid FROM qrybilling WHERE Remarks <> 1  AND DatePrinted BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'"
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
                    x.SubItems.Add(If(IsDBNull(dr("DatePaid")), "Not Yet Paid", dr("DatePaid").ToString()))
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

    Private Sub DateFilter1_TextChanged(sender As Object, e As EventArgs) Handles DateFilter1.TextChanged
        startDate = DateFilter1.Text
        loadBilling(startDate, endDate)
    End Sub

    Private Sub DateFilter2_TextChanged(sender As Object, e As EventArgs) Handles DateFilter2.TextChanged
        endDate = DateFilter2.Text
        loadBilling(startDate, endDate)
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click, ListView1.DoubleClick
        frmManageCollection.ShowDialog()
    End Sub
End Class