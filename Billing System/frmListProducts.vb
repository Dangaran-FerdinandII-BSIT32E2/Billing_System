Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmListProducts

    Public supplierid As String = Nothing

    Public walkin As Boolean? = False

    Public listofProductIds As New List(Of String)
    Private Sub frmListProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        If Not IsNothing(supplierid) Then
            Call rearrangeListView()
            Call loadReorders()
        ElseIf walkin Then
            Call loadWalkin()
        Else
            Call loadProducts()
        End If
    End Sub
    Private Sub loadProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM qryproducts ORDER BY ProductName ASC"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Category").ToString())
                x.SubItems.Add(dr("Manufacturer").ToString())
                x.SubItems.Add(dr("ModelNumber").ToString())
                x.SubItems.Add(dr("PurchasePrice").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString()) '7
                x.SubItems.Add(dr("ProductID").ToString())
                x.SubItems.Add(dr("SupplierID").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmListProducts(loadProducts): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadReorders()
        If listofProductIds.Count = 0 Then
            loadAllProducts()
        Else
            loadOnlyProducts()
        End If
    End Sub
    Private Sub loadAllProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblproduct WHERE SupplierID = '" & supplierid & "' ORDER BY ProductName ASC"
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
                x.SubItems.Add(dr("PurchasePrice").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString())
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(dr("ProductID").ToString()) '6 OR '7
                x.SubItems.Add(dr("SupplierID").ToString())

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmListProducts(loadProducts): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadOnlyProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each productid In listofProductIds
                sql = "SELECT * FROM tblproduct WHERE SupplierID = '" & supplierid & "' ORDER BY Amount ASC"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader

                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    If Not listofProductIds.Contains(dr("ProductID").ToString()) Then
                        x = New ListViewItem(dr("ProductName").ToString())
                        x.SubItems.Add(dr("Description").ToString())
                        x.SubItems.Add(dr("Category").ToString())
                        x.SubItems.Add(dr("PurchasePrice").ToString())
                        x.SubItems.Add(dr("SellingPrice").ToString())
                        x.SubItems.Add(dr("Amount").ToString())
                        x.SubItems.Add(dr("ProductID").ToString()) '6
                        x.SubItems.Add(dr("SupplierID").ToString())

                        ListView1.Items.Add(x)
                        ' End If
                    End If
                Loop
            Next
        Catch ex As Exception
            MsgBox("An error occurred frmListProducts(loadProducts): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub loadWalkin()
        If listofProductIds.Count = 0 Then
            loadWalkinProducts()
        Else
            loadOnlyWalkins()
        End If
    End Sub

    Private Sub loadWalkinProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM qryproducts ORDER BY ProductName ASC"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Category").ToString())
                x.SubItems.Add(dr("Manufacturer").ToString())
                x.SubItems.Add(dr("ModelNumber").ToString())
                x.SubItems.Add(dr("PurchasePrice").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString()) '7
                x.SubItems.Add(dr("ProductID").ToString())
                x.SubItems.Add(dr("SupplierID").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmListProducts(loadProducts): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadOnlyWalkins()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM qryproducts ORDER BY ProductName ASC"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                If Not listofProductIds.Contains(dr("ProductID").ToString()) Then
                    x = New ListViewItem(dr("ProductName").ToString())
                    x.SubItems.Add(dr("CompanyName").ToString())
                    x.SubItems.Add(dr("Description").ToString())
                    x.SubItems.Add(dr("Category").ToString())
                    x.SubItems.Add(dr("Manufacturer").ToString())
                    x.SubItems.Add(dr("ModelNumber").ToString())
                    x.SubItems.Add(dr("PurchasePrice").ToString())
                    x.SubItems.Add(dr("SellingPrice").ToString()) '7
                    x.SubItems.Add(dr("ProductID").ToString())
                    x.SubItems.Add(dr("SupplierID").ToString())
                    ListView1.Items.Add(x)
                End If
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmListProducts(loadProducts): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub rearrangeListView()
        ListView1.Columns.Clear()

        ListView1.Columns.Add("Product Name").Width = 250
        ListView1.Columns.Add("Description").Width = 250
        ListView1.Columns.Add("Category").Width = 150
        ListView1.Columns.Add("Original Price").Width = 150
        ListView1.Columns.Add("Selling Price").Width = 150
        ListView1.Columns.Add("Quantity").Width = 150
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If ListView1.SelectedItems.Count > 0 Then
            If Not IsNothing(supplierid) Then
                frmRestockProduct.addtolist(ListView1.SelectedItems(0).SubItems(6).Text)
            ElseIf walkin Then
                frmAddCustomerWalkin.addtolist(ListView1.SelectedItems(0).SubItems(8).Text)
            Else
                frmManagePOS.txtProduct.Text = ListView1.SelectedItems(0).SubItems(0).Text
                frmManagePOS.txtAmt.Text = ListView1.SelectedItems(0).SubItems(7).Text
                frmManagePOS.productid = ListView1.SelectedItems(0).SubItems(8).Text

                frmManagePOS.txtQty.Enabled = True
                frmManagePOS.btnInsert.Enabled = True
                frmManagePOS.txtQty.Text = "1"
            End If

            Me.Close()
        Else
            MsgBox("Please pick an item!", MsgBoxStyle.Critical, "Item Error")
        End If
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim dt As DataTable = SearchDatabase(txtSearchProduct.Text)
            PopulateListView(dt)

        Catch ex As Exception
            MsgBox("An error occurred frmListProducts(SearchProduct): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub PopulateListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "SELECT ProductName, CompanyName, Description, Category, Manufacturer, ModelNumber, PurchasePrice, SellingPrice, ProductID, SupplierID FROM qryproducts WHERE ProductName LIKE ? OR CompanyName LIKE ? ORDER BY ProductName ASC"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function

    Private Sub frmListProducts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then

            supplierid = Nothing
            walkin = False

        End If
    End Sub
End Class