Imports System.Globalization
Imports System.Runtime.InteropServices.ComTypes
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frmTestOnly
    Private Sub frmTestOnly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadReport()
    End Sub

    '"C:\Users\Jayson Teleb\Documents\GitHub\Billing_System\Billing System

    Private Sub loadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportUserActivityLogs.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
            DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then

                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                da.SelectCommand = New MySqlCommand("SELECT Username, Action, DATE_FORMAT(DateTime, '%M %e, %Y    %l:%i %p') AS DateTime FROM tblactivity WHERE DateTime BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'", cn)
                da.Fill(ds.Tables("dtAdminReport"))

                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End If

            rptDS = New ReportDataSource("dtReportActivityLogs", ds.Tables("dtAdminReport"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class