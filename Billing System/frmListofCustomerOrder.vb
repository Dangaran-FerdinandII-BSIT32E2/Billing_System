
Imports Microsoft.ReportingServices.Diagnostics.Internal
Imports MySql.Data.MySqlClient

Public Class frmListofCustomerOrder

    Public orderid As String
    Public custid As String

    Public order As Boolean? = Nothing
    Private Sub frmListofCustomerOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadOrder()
        Call loadComment()
        Call loadQuotation()
    End Sub
    Private Sub btnSendQuotation_Click(sender As Object, e As EventArgs) Handles btnSendQuotation.Click
        frmQuotation.orderid = orderid
        frmQuotation.ShowDialog()
        Call loadQuotation()
    End Sub

    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        frmQuotationComment.orderid = orderid

        frmQuotationComment.ShowDialog()
    End Sub



    Public Sub loadOrder()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT Unit, Description, Quantity, Amount, Availability, Status, QuotationImg, OrderListID FROM qryorder WHERE OrderID = '" & orderid & "' "

            If order Then
                sql += "AND isRental = 0"
            Else
                sql += "AND isRental = 1"
            End If

            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("Unit").ToString)
                x.SubItems.Add(dr("Description")).ToString()
                x.SubItems.Add(dr("Quantity").ToString)
                x.SubItems.Add(dr("Amount").ToString)
                x.SubItems.Add(If(dr("Availability"), "Available", "Not Available").ToString)
                x.SubItems.Add(GetStatusText(dr("Status").ToString))
                x.SubItems.Add(dr("OrderListID").ToString) '6



                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmListofCustomerOrder(loadOrder): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Function GetStatusText(status As String) As String
        Select Case status
            Case "5" : Return "Cancelled Order"
            Case "4" : Return "Priority Order"
            Case "3" : Return "Delivered"
            Case "2" : Return "Ready for Shipment"
            Case "1" : Return "Item on Hand"
            Case Else : Return "Item on Process"
        End Select
    End Function
    Private Sub loadComment()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT MIN(Comment) AS Comment FROM qryorder where OrderID = '" & orderid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                If Not IsDBNull(dr("Comment")) Then
                    lblNotifQuatation.Visible = True
                Else
                    lblNotifQuatation.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmListofCustomerOrder(loadComment): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        Call loadActivityCancel()
    End Sub
    Private Sub loadActivityCancel()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblactivity(UserID, Username, DateTime, Action) VALUES(@UserID, @Username, @DateTime, @Action)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@UserID", frmLoginV2.userid)
                .Parameters.AddWithValue("@Username", frmLoginV2.username)
                .Parameters.AddWithValue("@DateTime", DateTime.Now)
                .Parameters.AddWithValue("@Action", "Order Canceled for " & orderid)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmAdminSettings(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadQuotation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT QuotationStatus, QuotationImg FROM tblorder WHERE OrderID = '" & orderid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                If (IsDBNull(dr("QuotationStatus")) OrElse dr("QuotationStatus") = 1) And Not IsDBNull(dr("QuotationImg")) Then
                    'accepted or pending, but there is already image present
                    btnSendQuotation.Enabled = False
                ElseIf IsDBNull(dr("QuotationImg")) OrElse dr("QuotationStatus") = 0 Then
                    'rejeected, can send again OR if there is still no image
                    btnSendQuotation.Enabled = True
                End If
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmListofCustomerOrder(loadQuotation): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class