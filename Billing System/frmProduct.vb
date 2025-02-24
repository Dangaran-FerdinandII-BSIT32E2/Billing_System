﻿Imports MySql.Data.MySqlClient

Public Class frmProduct
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadProducts()

        'ACTIVE ORDERS
        'Call loadOrders()

        'RAMBIC PRODUCTS
        Call availableProducts()
    End Sub

    'LIST OF PRODUCTS TAB
    Public Sub loadProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblproduct"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString())
                x.Font = New Font("Arial", 12, FontStyle.Regular)
                x.SubItems.Add(dr("Category").ToString())
                x.SubItems.Add(dr("Type").ToString())
                x.SubItems.Add("₱ " & Convert.ToDecimal(dr("PurchasePrice")).ToString("N2"))
                x.SubItems.Add("₱ " & Convert.ToDecimal(dr("SellingPrice")).ToString("N2"))
                x.SubItems.Add(checkStatus(dr("Amount"), dr("ProductID")).ToString())
                x.SubItems.Add(dr("ProductID").ToString()) '6
                x.SubItems.Add(dr("SupplierID").ToString())

                ' Adjust color and font
                If x.SubItems(5).Text = "Available" Then
                    x.ForeColor = Color.Black
                ElseIf x.SubItems(5).Text = "Critical Level" Then
                    x.ForeColor = Color.Black
                Else
                    x.ForeColor = Color.Red
                End If

                ListView1.Items.Add(x)
            Loop

            dr.Close()
        Catch ex As Exception
            MsgBox("An Error occurred frmProduct(loadProducts): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Function checkStatus(amount As Integer, productID As String) As String
        Using cn As New MySqlConnection("server=localhost;user=root;password=;database=dbbilling")
            cn.Open()
            sql = "UPDATE tblproduct SET Status=@Status WHERE ProductID = '" & productID & "'"
            Using cmd As New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@Status", "0")

                    If amount > 10 Then
                        .Parameters("@Status").Value = "2"
                    ElseIf amount <= 10 Then
                        .Parameters("@Status").Value = "1"
                    End If
                    .ExecuteNonQuery()
                End With


                Select Case amount
                    Case Is > 10
                        Return "Available"
                    Case 1 To 10
                        Return "Critical Level"
                    Case Else
                        Return "Out of Stock"
                End Select
            End Using
        End Using
    End Function

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        frmManageProducts.ShowDialog()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            btnEdit.Enabled = True
            btnDeactivate.Enabled = True
            btnRestock.Enabled = True
        Else
            btnEdit.Enabled = False
            btnDeactivate.Enabled = False
            btnRestock.Enabled = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click, ListView1.DoubleClick
        frmManageProducts.productid = ListView1.SelectedItems(0).SubItems(6).Text
        frmManageProducts.supplierid = ListView1.SelectedItems(0).SubItems(7).Text
        frmManageProducts.ShowDialog()
    End Sub

    'Private Sub loadOrders()
    '    Try
    '        If cn.State <> ConnectionState.Open Then
    '            cn.Open()
    '        End If

    '        sql = "SELECT q.PONumber, s.CompanyName, COUNT(q.ProductID) AS TotalOrders, SUM(q.Amount) AS Amount, DATE_FORMAT(q.DateRequested, '%M %d %Y') AS DateRequested, q.QuotationID, q.SupplierID FROM tblquotation q INNER JOIN tblsupplier s ON q.SupplierID = s.SupplierID WHERE q.QuotationIMG IS NOT NULL GROUP BY q.QuotationID ORDER BY q.PONumber ASC"
    '        cmd = New MySqlCommand(sql, cn)

    '        If Not dr.IsClosed Then
    '            dr.Close()
    '        End If

    '        dr = cmd.ExecuteReader

    '        Dim x As ListViewItem
    '        ListView2.Items.Clear()

    '        Do While dr.Read = True
    '            x = New ListViewItem(dr("PONumber").ToString())
    '            x.SubItems.Add(dr("CompanyName").ToString())
    '            x.SubItems.Add(dr("TotalOrders").ToString())
    '            x.SubItems.Add(dr("Amount").ToString())
    '            x.SubItems.Add(dr("DateRequested").ToString())
    '            x.SubItems.Add(dr("QuotationID").ToString()) '5
    '            x.SubItems.Add(dr("SupplierID").ToString()) '6

    '            ListView2.Items.Add(x)
    '        Loop
    '        dr.Close()
    '    Catch ex As Exception
    '        MsgBox("An Error occurred frmProduct(loadProducts): " & ex.Message)
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub

    'Private Sub btnAddNewProduct_Click(sender As Object, e As EventArgs)
    '    If ListView2.SelectedItems.Count > 0 Then
    '        frmRestockQuotation.quotationid = ListView2.SelectedItems(0).SubItems(5).Text
    '        frmRestockQuotation.supplierid = ListView2.SelectedItems(0).SubItems(6).Text
    '        frmRestockQuotation.ShowDialog()
    '    End If
    'End Sub


    'RAMBIC PRODUCTS
    Private Sub availableProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT ProductName, Description, Category, PurchasePrice, SellingPrice, Status, Amount, ProductID, SupplierID FROM tblproduct WHERE Amount > 0 ORDER BY ProductName ASC"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView3.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString())
                x.Font = New Font("Arial", 12, FontStyle.Regular)
                'x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Category").ToString())
                'x.SubItems.Add(dr("PurchasePrice").ToString())
                x.SubItems.Add("₱ " & Convert.ToDecimal(dr("PurchasePrice")).ToString("N2"))
                'x.SubItems.Add(dr("SellingPrice").ToString())
                x.SubItems.Add("₱ " & Convert.ToDecimal(dr("SellingPrice")).ToString("N2"))
                x.SubItems.Add(checkStatus(dr("Amount"), dr("ProductID")).ToString())
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(dr("ProductID").ToString()) '7
                x.SubItems.Add(dr("SupplierID").ToString()) '8
                'x.SubItems.Add("₱" & Convert.ToDecimal(dr("Amount")).ToString("N2"))

                ListView3.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An Error occurred frmProduct(availableProducts): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If ListView1.SelectedItems.Count > 0 Then
            frmManageProducts.productid = ListView3.SelectedItems(0).SubItems(6).Text
            frmManageProducts.supplierid = ListView3.SelectedItems(0).SubItems(7).Text
            frmManageProducts.ShowDialog()
        End If
    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        If ListView1.SelectedItems.Count > 0 Then
            frmRestockProduct.productid = ListView1.SelectedItems(0).SubItems(6).Text
            frmRestockProduct.supplierid = ListView1.SelectedItems(0).SubItems(7).Text
            frmRestockProduct.ShowDialog()
        End If
    End Sub
End Class