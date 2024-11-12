
Imports Microsoft.ReportingServices.Diagnostics.Internal
Imports MySql.Data.MySqlClient

Public Class frmListofCustomerOrder

    Public orderid As String
    Private Sub btnSendQuotation_Click(sender As Object, e As EventArgs) Handles btnSendQuotation.Click
        frmQuotation.orderid = orderid
        frmQuotation.ShowDialog()
    End Sub

    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        frmQuotationComment.orderid = orderid
        frmQuotationComment.ShowDialog()
    End Sub

    Private Sub frmListofCustomerOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadOrder()
        Call loadComment()
    End Sub

    Private Sub loadOrder()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT Unit, Description, Quantity, Amount, Availability, Status, OrderListID FROM qryorder WHERE OrderID = '" & orderid & "'"
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
    Private Sub btnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        If ListView1.SelectedItems.Count > 0 Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                If MsgBox("Do you want to update the order?", vbQuestion + vbYesNo) = vbYes Then
                    For Each item As ListViewItem In ListView1.SelectedItems

                        Dim Availability As String = item.SubItems(4).Text
                        Dim Status As String = item.SubItems(5).Text

                        If Status = "Item on Hand" Then
                            MsgBox("The item is already available and on hand!", MsgBoxStyle.Critical, "Order Status")
                            Exit Sub
                        End If

                        sql = "UPDATE tblorder SET Availability=@Availability, Status=@Status WHERE OrderListID = '" & item.SubItems(6).Text & "'"
                        cmd = New MySqlCommand(sql, cn)

                        With cmd
                            .Parameters.AddWithValue("@Availability", False)
                            .Parameters.AddWithValue("@Status", 0)

                            If Availability = "Available" Then
                                .Parameters("@Availability").Value = True
                                If (Status = "Item on Process" Or Status = "Priority Order") And Availability = "Available" Then
                                    .Parameters("@Status").Value = 1
                                End If
                            ElseIf Availability = "Not Available" Then
                                .Parameters("@Availability").Value = True
                            End If

                            .ExecuteNonQuery()

                        End With
                    Next
                    Call loadOrder()
                End If
            Catch ex As Exception
                MsgBox("An error occurred frmListofCustomerOrder(btnUpdateOrder_Click): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        Else
            MsgBox("Please select an order!", MsgBoxStyle.Critical, "Update Error")
        End If
    End Sub
End Class