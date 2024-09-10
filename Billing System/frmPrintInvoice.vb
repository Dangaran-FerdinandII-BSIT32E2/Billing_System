Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmPrintInvoice

    Private Sub frmPrintVoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call saveBilling()
        ListView1.Items.Clear()
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

            sql = "INSERT INTO tblbilling(CustomerID, SalesMan, Terms, ProductOrder, Date) VALUES(@CustomerID, @SalesMan, @Terms, @ProductOrder, @Date)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@CustomerID", lblCustID.Text)
                .Parameters.AddWithValue("@SalesMan", lblSalesman.Text)
                .Parameters.AddWithValue("@Terms", lblTerms.Text)
                .Parameters.AddWithValue("@ProductOrder", lblPuchaseNo.Text)
                .Parameters.AddWithValue("@Date", frmManageBilling.dtpDate.Value)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmPrintInvoice(saveBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class