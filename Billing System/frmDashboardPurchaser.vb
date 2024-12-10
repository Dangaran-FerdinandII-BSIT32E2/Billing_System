Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class frmDashboardPurchaser
    Private Sub frmDashboardPurchaser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call calculateData()
        Call newCustomers()
        Call totalSuppliers()
    End Sub

    Private Sub calculateData()
        'PRODUCT STATUS
        Call getProducts()

        'ORDER UPDATES
        Call getRambicPO()
    End Sub

    Private Sub newCustomers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COUNT(*) AS NewCustomers FROM tblcustomer WHERE tblcustomer.AcctStatus = 0"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim count As Integer = Convert.ToInt32(dr("NewCustomers"))
                If count > 0 Then
                    btnViewCustomer.Visible = True
                    lblNewCustomers.Font = New Font("Arial", 20, FontStyle.Bold)
                    lblNewCustomers.Text = count.ToString()
                Else
                    btnViewCustomer.Visible = False
                    lblNewCustomers.Text = "No New Customer"
                End If
            End If

        Catch ex As Exception
            MsgBox("An error occurred in frmAnalyticsData(newCustomers): " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub totalSuppliers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COUNT(*) AS Suppliers FROM tblsupplier WHERE tblsupplier.AcctStatus = 1"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim count As Integer = Convert.ToInt32(dr("Suppliers"))
                If count > 0 Then
                    btnViewSupplier.Visible = True
                    lblNewSuppliers.Font = New Font("Arial", 20, FontStyle.Bold)
                    lblNewSuppliers.Text = count.ToString()
                Else
                    btnViewSupplier.Visible = False
                    lblNewSuppliers.Text = "No New Suppliers"
                End If
            End If

        Catch ex As Exception
            MsgBox("An error occurred in frmAnalyticsData(totalSuppliers): " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub totalProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COUNT(*) AS Products FROM tblproduct"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim count As Integer = Convert.ToInt32(dr("Products"))
                If count > 0 Then
                    btnViewProduct.Visible = True
                    lblOwnedProducts.Font = New Font("Arial", 20, FontStyle.Bold)
                    lblOwnedProducts.Text = count.ToString()
                Else
                    btnViewProduct.Visible = False
                    lblOwnedProducts.Text = "No New Products"
                End If
            End If

        Catch ex As Exception
            MsgBox("An error occurred in frmAnalyticsData(totalProducts): " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub getProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT ProductName, Manufacturer, Amount, ProductID FROM tblproduct ORDER BY Amount ASC"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If Not dr.HasRows Then
                Exit Sub
            End If

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString())
                x.SubItems.Add(dr("Manufacturer").ToString())
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(getAmountStatus(dr("Amount").ToString))
                x.SubItems.Add(dr("ProductID").ToString)
                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(getOverdue): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Function getAmountStatus(amount As String) As String
        Select Case amount
            Case Is > 10
                Return "Available"
            Case Is <= 10
                Return "Critical Level"
            Case Else
                Return "Out of Stock"
        End Select
    End Function
    Private Sub getRambicPO()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT q.PONumber, s.CompanyName, q.Amount, q.DateRequested, q.QuotationID FROM tblquotation q INNER JOIN tblsupplier s ON q.SupplierID = s.SupplierID"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If Not dr.HasRows Then
                Exit Sub
            End If

            Dim x As ListViewItem
            ListView2.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("PONumber").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(dr("Amount").ToString)
                x.SubItems.Add(dr("DateRequested").ToString)
                x.SubItems.Add(dr("QuotationID").ToString) '3

                ListView2.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occured at frmAnalyticsData(newOrders): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class