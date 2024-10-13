Imports MySql.Data.MySqlClient
Public Class frmManageSupplierProduct
    Private Sub frmManageSupplierProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSuppliers()
        Call loadProducts()
    End Sub

    'LIST OF SUPPLIERS
    Public Sub loadSuppliers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblsupplier"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("CompanyName").ToString())
                x.SubItems.Add(dr("BankDetails").ToString())
                x.SubItems.Add(dr("ContactPerson").ToString())
                x.SubItems.Add(dr("PhoneNumber").ToString())
                x.SubItems.Add(dr("Address").ToString())
                x.SubItems.Add(dr("DeliveryTerms").ToString())
                x.SubItems.Add(dr("SupplierID").ToString())

                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSupplierProduct(loadSuppliers): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub btnAddNewSupplier_Click(sender As Object, e As EventArgs) Handles btnAddNewSupplier.Click
        frmManageSupplierV2.ShowDialog()
        btnEditSupplier.Enabled = False
        btnDeleteSupplier.Enabled = False
    End Sub
    Private Sub btnEditSupplier_Click(sender As Object, e As EventArgs) Handles btnEditSupplier.Click, ListView1.DoubleClick
        frmManageSupplierV2.supplierid = ListView1.SelectedItems(0).SubItems(6).Text
        frmManageSupplierV2.ShowDialog()
        btnEditSupplier.Enabled = False
        btnDeleteSupplier.Enabled = False
    End Sub
    Private Sub btnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles btnDeleteSupplier.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView1.SelectedItems.Count > 0 And checkForeignKey() = False Then
                If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then

                    sql = "DELETE FROM tblsupplier WHERE SupplierID = @item and ContactPerson = '" & ListView1.SelectedItems(0).SubItems(2).Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@item", ListView1.SelectedItems(0).SubItems(6).Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Deleted!", MsgBoxStyle.Information, "Delete Status")

                    Call loadSuppliers()

                End If
            Else
                MsgBox("The supplier has associated products!", MsgBoxStyle.Critical, "Delete Error")
            End If
            btnEditSupplier.Enabled = False
            btnDeleteSupplier.Enabled = False
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSuppliers(btnDelete): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Function checkForeignKey() As Boolean
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT SupplierID FROM tblproduct WHERE SupplierID = '" & ListView1.SelectedItems(0).SubItems(6).Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSuppliers(checkForeignKey): " & ex.Message)
            Return False
        End Try
    End Function
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        btnEditSupplier.Enabled = True
        btnDeleteSupplier.Enabled = True
    End Sub

    Private Sub txtSearchSupplierName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSupplierName.TextChanged
        Dim dt As DataTable = SearchSupplierDatabase(txtSearchSupplierName.Text)
        PopulateSupplierListView(dt)
    End Sub
    Public Function SearchSupplierDatabase(searchTerm As String) As DataTable
        sql = "Select CompanyName,BankDetails,ContactPerson,PhoneNumber,Address,DeliveryTerms,SupplierID from tblsupplier where CompanyName LIKE ? OR ContactPerson LIKE ?"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))

        If Not dr.IsClosed Then
            dr.Close()
        End If

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        dr.Close()
        Return dt
    End Function
    Private Sub PopulateSupplierListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    'LIST OF PRODUCTS
    Public Sub loadProducts()
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
            ListView2.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Category").ToString())
                x.SubItems.Add(dr("Type").ToString())
                x.SubItems.Add(dr("PurchasePrice").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString())
                x.SubItems.Add(dr("ProductID").ToString()) '7
                x.SubItems.Add(dr("SupplierID").ToString())

                ListView2.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSupplierProduct(loadProducts): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnAddNewProduct_Click(sender As Object, e As EventArgs) Handles btnAddNewProduct.Click
        'frmManageProducts.lblManageProduct.Text = "Add Product"
        'frmManageProducts.txtProductName.Clear()
        'frmManageProducts.txtDescription.Clear()
        'frmManageProducts.txtCategory.Clear()
        'frmManageProducts.txtType.Clear()
        'frmManageProducts.txtPurchasePrice.Clear()
        'frmManageProducts.txtSellingPrice.Clear()
        'frmManageProducts.pbxProduct.Image
        frmManageProducts.ShowDialog()
    End Sub

    Private Sub btnEditProduct_Click(sender As Object, e As EventArgs) Handles btnEditProduct.Click, ListView2.DoubleClick
        frmManageProducts.productid = ListView2.SelectedItems(0).SubItems(7).Text
        frmManageProducts.txtSupplier.Text = ListView2.SelectedItems(0).SubItems(1).Text
        frmManageProducts.supplierid = ListView2.SelectedItems(0).SubItems(8).Text
        frmManageProducts.ShowDialog()
        btnEditProduct.Enabled = False
        btnDeleteProduct.Enabled = False
    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView2.SelectedItems.Count > 0 Then
                If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                    sql = "DELETE FROM tblproduct WHERE ProductID = @item"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@item", ListView2.SelectedItems(0).SubItems(7).Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Product successfully deleted!", MsgBoxStyle.Information, "Delete Status")
                    Call loadProducts()
                End If
                btnEditProduct.Enabled = False
                btnDeleteProduct.Enabled = False
            Else
                MsgBox("Please select an item to delete!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSupplierProduct(btnDeleteProduct_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        Dim dt As DataTable = SearchProductDatabase(txtSearchProduct.Text)
        PopulateProductListView(dt)
    End Sub

    Public Function SearchProductDatabase(searchTerm As String) As DataTable
        sql = "Select ProductName,CompanyName,Description,Category,Type,PurchasePrice,SellingPrice, ProductID, SupplierID from qryproducts where ProductName LIKE ? OR CompanyName LIKE ? ORDER BY ProductName ASC"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))

        If Not dr.IsClosed Then
            dr.Close()
        End If

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        dr.Close()
        Return dt
    End Function
    Private Sub PopulateProductListView(dt As DataTable)
        ListView2.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView2.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        btnEditProduct.Enabled = True
        btnDeleteProduct.Enabled = True
    End Sub
End Class