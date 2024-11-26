Imports MySql.Data.MySqlClient

Public Class frmProduct
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadProducts()

        'ACTIVE ORDERS
        Call loadOrders()
    End Sub

    Private Sub loadProducts()
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
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Category").ToString())
                x.SubItems.Add(dr("Type").ToString())
                x.SubItems.Add(dr("PurchasePrice").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString())
                x.SubItems.Add(checkStatus(dr("Status").ToString()))
                x.SubItems.Add(dr("ProductID").ToString()) '7
                x.SubItems.Add(dr("SupplierID").ToString()) '8

                If dr("Status") = 2 Then
                    x.ForeColor = Color.Black
                ElseIf dr("Status") = 1 Then
                    x.ForeColor = Color.Orange
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

    Private Function checkStatus(status As String) As String
        Select Case status
            Case 2
                Return "Available"
            Case 1
                Return "Critical Level"
            Case Else
                Return "Out of Stock"
        End Select
    End Function

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        frmManageProducts.ShowDialog()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            btnEdit.Enabled = True
            btnDeactivate.Enabled = True
        Else
            btnEdit.Enabled = False
            btnDeactivate.Enabled = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmManageProducts.productid = ListView1.SelectedItems(0).SubItems(7).Text
        frmManageProducts.supplierid = ListView1.SelectedItems(0).SubItems(8).Text
    End Sub

    Private Sub loadOrders()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT q.PONumber, q.QuotationID, COUNT(q.ProductID) AS TotalOrders, q.SupplierID, SUM(q.Amount) AS Amount, s.CompanyName, DATE_FORMAT(q.DateRequested, '%M %d %Y') AS DateRequested FROM tblquotation q INNER JOIN tblsupplier s ON q.SupplierID = s.SupplierID WHERE q.QuotationIMG IS NOT NULL GROUP BY q.QuotationID ORDER BY q.PONumber ASC"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView2.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("PONumber").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(dr("TotalOrders").ToString())
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(dr("DateRequested").ToString())
                x.SubItems.Add(dr("QuotationID").ToString()) '5
                x.SubItems.Add(dr("SupplierID").ToString()) '6

                ListView2.Items.Add(x)
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

    Private Sub btnAddNewProduct_Click(sender As Object, e As EventArgs) Handles btnAddNewProduct.Click, ListView2.DoubleClick
        If ListView2.SelectedItems.Count > 0 Then
            frmRestockQuotation.quotationid = ListView2.SelectedItems(0).SubItems(5).Text
            frmRestockQuotation.supplierid = ListView2.SelectedItems(0).SubItems(6).Text
            frmRestockQuotation.ShowDialog()
        End If
    End Sub
End Class