﻿Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmPrintInvoice

    Private Sub frmPrintVoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call saveBilling()
        ListView1.Items.Clear()
        MsgBox("Sucessfully saved billing invoice!", MsgBoxStyle.Information, "Billing Invoice")
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ListView1.Items.Clear()
        Me.Close()
    End Sub
    Private Sub saveBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblbilling(CustomerID, SalesMan, Terms, ProductOrder, DatePrinted) VALUES(@CustomerID, @SalesMan, @Terms, @ProductOrder, @DatePrinted)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@CustomerID", lblCustID.Text)
                .Parameters.AddWithValue("@SalesMan", lblSalesman.Text)
                .Parameters.AddWithValue("@Terms", lblTerms.Text)
                .Parameters.AddWithValue("@ProductOrder", lblPuchaseNo.Text)
                .Parameters.AddWithValue("@DatePrinted", frmManageSalesV2.dtpDate.Value)
                .ExecuteNonQuery()
            End With

            Call updateOrder()
        Catch ex As Exception
            MsgBox("An error occurred frmPrintInvoice(saveBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub updateOrder()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each orderlist As ListViewItem In ListView1.Items
                sql = "UPDATE tblorder SET DueDate=@DueDate WHERE OrderListID = '" & orderlist.SubItems(6).Text & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@DueDate", Date.Now.AddDays(5))
                cmd.ExecuteNonQuery()
            Next

            Call saveBillInvoice()
        Catch ex As Exception
            MsgBox("An error occurred frmPrintInvoice(updateOrder): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub saveBillInvoice()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each order As ListViewItem In ListView1.Items
                sql = "INSERT INTO tblbillinvoice(BillingID, OrderID, ProductID) VALUES(@BillingID, @OrderID, @ProductID)"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@BillingID", lblBillingID.Text)
                    .Parameters.AddWithValue("@OrderID", order.SubItems(5).Text)
                    .Parameters.AddWithValue("@ProductID", order.SubItems(7).Text)
                    .ExecuteNonQuery()
                End With

                sql = "UPDATE tblorder SET Status=@Status WHERE OrderID = '" & order.SubItems(5).Text & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@Status", "2")
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(saveBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class