
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

        Catch ex As Exception
            MsgBox("An error occurred frmListofCustomerOrder(btnUpdateOrder_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class