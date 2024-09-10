Imports MySql.Data.MySqlClient

Public Class frmManageProducts
    Dim supplierID As Integer
    Private Sub frmManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadProducts()
    End Sub
    Private Sub loadProducts()
        cn.Open()
        sql = "SELECT * FROM qryproducts"
        cmd = New MySqlCommand(sql, cn)
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
            x.SubItems.Add(dr("SellingPrice").ToString())

            ListView1.Items.Add(x)
        Loop
        cn.Close()
    End Sub
    Private Sub clearAll()
        If txtProductName.Enabled = False Then
            txtProductName.PlaceholderText = "Enter name of product"
            txtDescription.PlaceholderText = "Enter description"
            txtCategory.PlaceholderText = "Enter category"
            txtManufacturer.PlaceholderText = "Enter manufacturer"
            txtPurchasePrice.PlaceholderText = "Enter purchase price"
            txtSellingPrice.PlaceholderText = "Enter selling price"
        Else
            txtProductName.Clear()
            txtDescription.Clear()
            txtCategory.Clear()
            txtPurchasePrice.Clear()
            txtManufacturer.Clear()
            txtSellingPrice.Clear()
        End If

        txtSupplier.PlaceholderText = "Search supplier"
        lblModelNo.Text = "XXXXX"
    End Sub
    Private Sub enableAll()
        txtProductName.Enabled = True
        txtDescription.Enabled = True
        txtDescription.Enabled = True
        txtCategory.Enabled = True
        txtPurchasePrice.Enabled = True
        txtSellingPrice.Enabled = True
        txtManufacturer.Enabled = True

        btnSearchSupplier.Enabled = True
    End Sub

    Private Sub disableAll()
        txtProductName.Enabled = False
        txtDescription.Enabled = False
        txtDescription.Enabled = False
        txtCategory.Enabled = False
        txtPurchasePrice.Enabled = False
        txtSellingPrice.Enabled = False
        txtManufacturer.Enabled = False

        btnSearchSupplier.Enabled = False
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True

        btnEdit.Enabled = False

        Call enableAll()
        Call clearAll()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCreateNew.Enabled = True

        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False

        Call disableAll()
        Call clearAll()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnDelete.Enabled = True

        btnCreateNew.Enabled = False

        Call enableAll()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cn.Close()
        Dim filled As Boolean = True

        Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtProductName", txtProductName},
            {"txtDescription", txtDescription},
            {"txtCategory", txtDescription},
            {"txtManufacturer", txtCategory},
            {"txtPurchasePrice", txtPurchasePrice},
            {"txtSellingPrice", txtSellingPrice}
        }

        For Each fieldName_controlPair In requiredFields
            Dim control As Control = fieldName_controlPair.Value

            If control.Text.Trim = "" Then
                ErrorProvider1.SetError(control, "This field is required.")
                filled = False
                Exit For
            Else
                ErrorProvider1.SetError(control, "")
            End If
        Next

        If filled Then
            If MsgBox("Do you want to save?", vbYesNo) = vbYes Then
                cn.Close()
                Call getSupplierId()
                cn.Open()
                If btnCreateNew.Enabled = True And btnEdit.Enabled = False Then 'IF CREATE NEW

                    sql = "INSERT INTO tblproduct(ProductName, Description, Stock, Category, Manufacturer, ModelNumber, PurchasePrice, SellingPrice, SupplierID) " &
                           "Values(@ProductName, @Description, @Stock, @Category, @Manufacturer, @ModelNumber, @PurchasePrice, @SellingPrice, @SupplierID)"
                    cmd = New MySqlCommand(sql, cn)

                    With cmd
                        .Parameters.AddWithValue("@ProductName", txtProductName.Text)
                        .Parameters.AddWithValue("@Description", txtDescription.Text)
                        .Parameters.AddWithValue("@Stock", "Pre-Order") 'UPDATE
                        .Parameters.AddWithValue("@SupplierID", supplierID)
                        .Parameters.AddWithValue("@Category", txtCategory.Text)
                        .Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text)
                        .Parameters.AddWithValue("@ModelNumber", lblModelNo.Text)
                        .Parameters.AddWithValue("@PurchasePrice", txtPurchasePrice.Text)
                        .Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text)
                        .ExecuteNonQuery()
                    End With

                    MsgBox("Successfully created!", MsgBoxStyle.Information)
                ElseIf btnCreateNew.Enabled = False And btnEdit.Enabled = True Then 'IF EDIT
                    sql = "UPDATE tblproduct SET ProductName=@ProductName, Description=@Description, " &
                        "Stock=@Stock, Category=@Category, Manufacturer=@Manufacturer, ModelNumber=@ModelNumber, " &
                        "PurchasePrice=@PurchasePrice, SellingPrice=@SellingPrice, SupplierID=@SupplierID " &
                        "WHERE ProductID = '" & txtProductId.Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@ProductName", txtProductName.Text)
                        .Parameters.AddWithValue("@Description", txtDescription.Text)
                        .Parameters.AddWithValue("@Stock", "Pre-Order") 'UPDATE
                        .Parameters.AddWithValue("@SupplierID", txtSupplierID.Text) 'NEEDS UPDATE
                        .Parameters.AddWithValue("@Category", txtCategory.Text)
                        .Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text)
                        .Parameters.AddWithValue("@ModelNumber", lblModelNo.Text)
                        .Parameters.AddWithValue("@PurchasePrice", txtPurchasePrice.Text)
                        .Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text)
                        .ExecuteNonQuery()
                    End With

                    sql = "UPDATE tblsupplier SET CompanyName=@CompanyName WHERE SupplierID = '" & txtSupplierID.Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@CompanyName", txtSupplier.Text)
                        .ExecuteNonQuery()
                    End With

                    MsgBox("Successfully updated the data!", MsgBoxStyle.Information)
                End If
                cn.Close()
                Call loadProducts()
                Call clearAll()
                Call disableAll()

                btnCreateNew.Enabled = True

                btnEdit.Enabled = False
                btnSave.Enabled = False
                btnDelete.Enabled = False
                btnCancel.Enabled = False
            End If
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtProductName.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtSupplier.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtDescription.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtCategory.Text = ListView1.SelectedItems(0).SubItems(3).Text
            txtManufacturer.Text = ListView1.SelectedItems(0).SubItems(4).Text
            lblModelNo.Text = ListView1.SelectedItems(0).SubItems(5).Text
            txtPurchasePrice.Text = ListView1.SelectedItems(0).SubItems(6).Text
            txtSellingPrice.Text = ListView1.SelectedItems(0).SubItems(7).Text
        End If

        cn.Open()
        sql = "SELECT tblproduct.ProductID from tblproduct WHERE ProductName = '" & txtProductName.Text & "' and Manufacturer = '" & txtManufacturer.Text & "'"
        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            txtProductId.Text = dr(0).ToString()
        End If

        dr.Close()
        cn.Close()

        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True

        btnCreateNew.Enabled = False
        btnSave.Enabled = False

        Call disableAll()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListView1.SelectedItems.Count > 0 Then
            If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                cn.Open()
                sql = "DELETE FROM tblproduct WHERE ProductName = @item and Manufacturer = '" & txtCategory.Text & "'"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@item", txtProductName.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Deleted!")
                cn.Close()
                Call loadProducts()
                Call clearAll()
                Call disableAll()
            End If
        Else
            MsgBox("Please select an item to delete!", vbExclamation)
        End If
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        cn.Close()
        Dim dt As DataTable = SearchDatabase(txtSearchProduct.Text)
        PopulateListView(dt)
    End Sub
    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select * from qryproducts where ProductName Like ? Or Manufacturer Like ?" 'CHANGE * TO SPECIFIC
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function
    Private Sub PopulateListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))

        Next
    End Sub

    Public Sub getSupplierId()
        cn.Open()
        sql = "SELECT SupplierID FROM tblsupplier WHERE CompanyName = '" & txtSupplier.Text & "'"
        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            supplierID = dr(0)
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs) Handles btnSearchSupplier.Click
        frmListofSuppliers.ShowDialog()
    End Sub
End Class