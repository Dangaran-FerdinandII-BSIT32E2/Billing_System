Imports System.Globalization
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class frmManageCollectionV3

    Dim startDate As String
    Dim endDate As String

    Public customerid As String
    Private Sub frmManageCollectionV3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

        DateFilter1.Text = DateTime.Now.AddDays(-5)
        startDate = DateFilter1.Text

        DateFilter2.Text = DateTime.Now.AddDays(+5)
        endDate = DateFilter2.Text

        Call loadCollections(startDate, endDate)
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
End Class