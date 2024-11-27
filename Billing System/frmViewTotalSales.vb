Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frmViewTotalSales
    Private Sub frmViewTotalSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadReport()
    End Sub

    Private Sub loadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = "C:\Users\Jayson Teleb\Documents\GitHub\Billing_System\Billing System\reportViewTotalSales.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT tblbilling.BillingID AS InvoiceNo, CONCAT(tblcustomer.FirstName, ' ', tblcustomer.LastName) AS FullName, tblbilling.CompanyName, tblbilling.FinalPrice, DATE_FORMAT(tblbilling.DatePrinted, '%M %d, %Y %h:%i %p') AS DatePrinted, SUM(tblbilling.FinalPrice) OVER () AS TotalSales FROM tblbilling INNER JOIN tblcustomer ON tblcustomer.CustomerID = tblbilling.CustomerID", cn)
            da.Fill(ds.Tables("dtViewTotalSales"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtViewTotalSales", ds.Tables("dtViewTotalSales"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

            'Convert the report to an image after viewing
            'Call ConvertReportToImage()

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub
End Class