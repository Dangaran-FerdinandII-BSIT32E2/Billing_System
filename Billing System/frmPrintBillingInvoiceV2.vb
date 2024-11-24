Imports System.Drawing.Imaging
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frmPrintBillingInvoiceV2

    Public billingid As String
    Private Sub frmPrintBillingInvoiceV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadReport()
    End Sub

    Private Sub loadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = "C:\Users\danga\OneDrive\Documents\GitHub\Billing_System\Billing System\printBillingInvoiceV2.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT c.CompanyName, c.Address, o.DeliveryAddress, b.DatePrinted, b.ProductOrder, b.Terms, b.Salesman, c.TIN, o.Quantity, p.ProductName, p.Description, p.SellingPrice, o.Amount, SUM(o.Amount) AS FinalAmount FROM tblcustomer c INNER JOIN tblbilling b ON b.CustomerID = c.CustomerID INNER JOIN tblbillinvoice i ON i.BillingID = b.BillingID INNER JOIN tblorder o ON i.OrderID = o.OrderID AND o.ProductID = i.ProductID INNER JOIN tblproduct p ON i.ProductID = p.ProductID WHERE b.BillingID = '" & billingid & "'", cn)
            da.Fill(ds.Tables("dtPrintBillingStatement"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtPrintBillingStatement", ds.Tables("dtPrintBillingStatement"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

            'Convert the report to an image after viewing
            Call ConvertReportToImage()

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConvertReportToImage()
        Try
            ' Render the report to image format
            Dim mimeType As String = ""
            Dim encoding As String = ""
            Dim extension As String = ""
            Dim streamIds As String() = Nothing
            Dim warnings As Warning() = Nothing

            ' Render to an image
            Dim renderedBytes As Byte() = ReportViewer1.LocalReport.Render(
                "IMAGE", Nothing, mimeType, encoding, extension, streamIds, warnings)

            ' Save the rendered image
            Dim outputImagePath As String = Application.StartupPath & "\Image\ReportImage.png"
            Using ms As New MemoryStream(renderedBytes)
                Dim image As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                image.Save(outputImagePath, ImageFormat.Png)
            End Using

            MessageBox.Show("Report exported as an image to: " & outputImagePath)

        Catch ex As Exception
            MessageBox.Show("Error exporting report to image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class