Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmListofOrder
    Private Sub frmListofOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblcustomer WHERE CustomerID = '" & lblCustomerID.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblContactPerson.Text = (dr("LastName") + (", ") + dr("FirstName")).ToString()
                lblEmailAddress.Text = dr("Email").ToString()
                lblPhoneNumber.Text = dr("PhoneNumber").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmListOfOrder(loadCustomer): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        Call loadOrder()
    End Sub
    Private Sub loadOrder()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM qryorder WHERE OrderID IN (SELECT OrderID FROM tblOrder WHERE CustomerID = '" & lblCustomerID.Text & "')"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("Unit").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Quantity").ToString())
                x.SubItems.Add(dr("Unit").ToString())
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(dr("OrderID").ToString())
                ListView1.Items.Add(x)
            Loop
            dr.Close()

        Catch ex As Exception
            MsgBox("An error occurred frmListOfOrder(loadOrder): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub
End Class