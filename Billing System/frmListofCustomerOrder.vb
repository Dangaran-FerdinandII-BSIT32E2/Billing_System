
Imports Microsoft.ReportingServices.Diagnostics.Internal
Imports MySql.Data.MySqlClient

Public Class frmListofCustomerOrder

    Public orderid As String
    Private Sub btnSendQuotation_Click(sender As Object, e As EventArgs) Handles btnSendQuotation.Click
        frmQuotation.Show()
    End Sub

    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        frmQuotationComment.Show()
    End Sub

    Private Sub frmListofCustomerOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadOrder()
    End Sub

    Private Sub loadOrder()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT Unit, Description, Quantity, Amount, " &
                    "CASE Availability WHEN TRUE THEN 'Available' WHEN FALSE THEN 'Not Available' END AS Availability, " &
                    "CASE Status WHEN '5' THEN 'Cancelled Order' WHEN '4' THEN 'Priority Order' WHEN '3' THEN 'Delivered' WHEN '2' THEN 'Ready for Shipment' WHEN '1' THEN 'Item on Hand' ELSE 'Item on Process' END AS Status " &
                    "OrderListID FROM qryorder WHERE OrderID = '" & orderid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            DataGridView1.DataSource = dt
            DataGridView1.Columns("OrderListID").Visible = False

            For i As Integer = 0 To DataGridView1.Columns.Count - 1
                If i = 0 Then
                    DataGridView1.Columns(0).Width = 30
                Else
                    DataGridView1.Columns(i).Width = 150
                End If
            Next

        Catch ex As Exception
            MsgBox("An error occurred frmListofCustomerOrder(loadOrder): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim updatedCount = 0

            sql = "UPDATE tblorder"
        Catch ex As Exception
            MsgBox("An error occurred frmListofCustomerOrder(btnUpdateOrder_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class