Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class frmManageSuppliers
    Dim supplierID As Integer
    Private Sub frmManageSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSuppliers()
        Call loadProducts()
    End Sub

    'Supplier Tab
    Private Sub loadSuppliers()
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
            MsgBox("An Error occurred frmManageSuppliers(loadSuppliers): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try


    End Sub

    Private Sub btnCreateNewSupp_Click(sender As Object, e As EventArgs) Handles btnCreateNewSupp.Click

        btnSaveSupp.Enabled = True
        btnCancelSupp.Enabled = True

        btnEditSupp.Enabled = False

        Call clearAll()
        Call enableAll()
    End Sub

    Private Sub btnCancelSupp_Click(sender As Object, e As EventArgs) Handles btnCancelSupp.Click
        btnCreateNewSupp.Enabled = True

        btnEditSupp.Enabled = False
        btnSaveSupp.Enabled = False
        btnDeleteSupp.Enabled = False
        btnCancelSupp.Enabled = False

        Call clearAll()
        Call disableAll()

        txtSearchSupplierName.Clear()
    End Sub

    Private Sub btnEditSupp_Click(sender As Object, e As EventArgs) Handles btnEditSupp.Click
        btnSaveSupp.Enabled = True
        btnCancelSupp.Enabled = True
        btnDeleteSupp.Enabled = True

        btnCreateNewSupp.Enabled = False

        Call enableAll()
    End Sub

    Private Sub btnSaveSupp_Click(sender As Object, e As EventArgs) Handles btnSaveSupp.Click
        Dim filled As Boolean = True

        Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtCompanyNameSupp", txtCompanyNameSupp},
            {"txtBankDetailsSupp", txtBankDetailsSupp},
            {"txtContactPersonSupp", txtContactPersonSupp},
            {"txtPhoneNumberSupp", txtPhoneNumberSupp},
            {"txtAddressSupp", txtAddressSupp},
            {"txtDeliveryTermsSupp", txtDeliveryTermsSupp}
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
                Try
                    If cn.State <> ConnectionState.Open Then
                        cn.Open()
                    End If

                    Call getSupplierId()
                    If btnCreateNewSupp.Enabled = True And btnEditSupp.Enabled = False Then 'IF CREATE NEW
                        sql = "INSERT INTO tblsupplier(SupplierID, CompanyName, ContactPerson, PhoneNumber, Address, DeliveryTerms, BankDetails) " &
                               "Values(@SupplierID, @CompanyName, @ContactPerson, @PhoneNumber, @Address, @DeliveryTerms, @BankDetails)"
                        cmd = New MySqlCommand(sql, cn)
                        With cmd
                            .Parameters.AddWithValue("@SupplierID", supplierID)
                            .Parameters.AddWithValue("@CompanyName", txtCompanyNameSupp.Text)
                            .Parameters.AddWithValue("@ContactPerson", txtContactPersonSupp.Text)
                            .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumberSupp.Text)
                            .Parameters.AddWithValue("@Address", txtAddressSupp.Text)
                            .Parameters.AddWithValue("@DeliveryTerms", txtDeliveryTermsSupp.Text)
                            .Parameters.AddWithValue("@BankDetails", txtBankDetailsSupp.Text)
                            .ExecuteNonQuery()
                        End With

                        MsgBox("Successfully created!", MsgBoxStyle.Information)
                    ElseIf btnCreateNewSupp.Enabled = False And btnEditSupp.Enabled = True Then 'IF EDIT
                        sql = "UPDATE tblsupplier SET CompanyName=@CompanyName, ContactPerson=@ContactPerson, " &
                            "PhoneNumber=@PhoneNumber, Address=@Address, " &
                            "DeliveryTerms=@DeliveryTerms, BankDetails=@BankDetails " &
                            "WHERE SupplierID = '" & lblSupplierIDSupp.Text & "'"
                        cmd = New MySqlCommand(sql, cn)
                        With cmd
                            .Parameters.AddWithValue("@SupplierID", supplierID)
                            .Parameters.AddWithValue("@CompanyName", txtCompanyNameSupp.Text)
                            .Parameters.AddWithValue("@ContactPerson", txtContactPersonSupp.Text)
                            .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumberSupp.Text)
                            .Parameters.AddWithValue("@Address", txtAddressSupp.Text)
                            .Parameters.AddWithValue("@DeliveryTerms", txtDeliveryTermsSupp.Text)
                            .Parameters.AddWithValue("@BankDetails", txtBankDetailsSupp.Text)
                            .ExecuteNonQuery()
                        End With

                        MsgBox("Successfully updated the data!", MsgBoxStyle.Information)
                    End If
                    Call loadSuppliers()
                    Call clearAll()
                    Call disableAll()

                    btnCreateNewSupp.Enabled = True

                    btnEditSupp.Enabled = False
                    btnSaveSupp.Enabled = False
                    btnDeleteSupp.Enabled = False
                    btnCancelSupp.Enabled = False
                Catch ex As Exception
                    MsgBox("An Error occurred frmManageSuppliers(btnSave): " & ex.Message)
                Finally
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
            End If
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtCompanyNameSupp.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtBankDetailsSupp.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtContactPersonSupp.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtPhoneNumberSupp.Text = ListView1.SelectedItems(0).SubItems(3).Text
            txtAddressSupp.Text = ListView1.SelectedItems(0).SubItems(4).Text
            txtDeliveryTermsSupp.Text = ListView1.SelectedItems(0).SubItems(5).Text
            lblSupplierIDSupp.Text = ListView1.SelectedItems(0).SubItems(6).Text
        End If

        btnCreateNewSupp.Enabled = False

        btnEditSupp.Enabled = True
        btnDeleteSupp.Enabled = True
        btnCancelSupp.Enabled = True

        Call disableAll()
    End Sub
    Private Sub btnDeleteSupp_Click(sender As Object, e As EventArgs) Handles btnDeleteSupp.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView1.SelectedItems.Count > 0 And checkForeignKey() = False Then
                If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then

                    If Not dr.IsClosed Then
                        dr.Close()
                    End If

                    sql = "DELETE FROM tblsupplier WHERE SupplierID = @item and ContactPerson = '" & txtContactPersonSupp.Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@item", lblSupplierIDSupp.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Deleted!", MsgBoxStyle.Information, "Delete Status")

                    Call loadSuppliers()
                    Call clearAll()

                End If
            Else
                MsgBox("The supplier has associated products!", MsgBoxStyle.Critical, "Delete Error")
            End If
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

            sql = "SELECT SupplierID FROM tblproduct WHERE SupplierID = '" & lblSupplierIDSupp.Text & "'"
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
    Private Sub clearAll()
        txtAddressSupp.Clear()
        txtCompanyNameSupp.Clear()
        txtContactPersonSupp.Clear()
        txtDeliveryTermsSupp.Clear()
        txtPhoneNumberSupp.Clear()
        txtBankDetailsSupp.Clear()
    End Sub
    Private Sub txtSearchSupplierName_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearchSupplierName.TextChanged
        cn.Close()
        Dim dt As DataTable = SearchSupplierDatabase(txtSearchSupplierName.Text)
        PopulateListView(dt)
    End Sub
    Public Function SearchSupplierDatabase(searchTerm As String) As DataTable
        sql = "Select CompanyName,BankDetails,ContactPerson,PhoneNumber,Address,DeliveryTerms,SupplierID from tblsupplier where CompanyName LIKE ? OR ContactPerson LIKE ?"
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

    Private Sub enableAll()
        txtAddressSupp.Enabled = True
        txtCompanyNameSupp.Enabled = True
        txtContactPersonSupp.Enabled = True
        txtDeliveryTermsSupp.Enabled = True
        txtPhoneNumberSupp.Enabled = True
        txtBankDetailsSupp.Enabled = True
    End Sub

    Private Sub disableAll()
        txtAddressSupp.Enabled = False
        txtCompanyNameSupp.Enabled = False
        txtContactPersonSupp.Enabled = False
        txtDeliveryTermsSupp.Enabled = False
        txtPhoneNumberSupp.Enabled = False
        txtBankDetailsSupp.Enabled = False
    End Sub
    Private Sub getSupplierId()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT SupplierID FROM tblsupplier WHERE CompanyName = '" & txtCompanyNameSupp.Text & "' and ContactPerson = '" & txtContactPersonSupp.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                supplierID = dr(0).ToString()
                lblSupplierIDSupp.Text = dr(0).ToString()
            Else
                supplierID = getNextId()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSuppliers(getSupplierID): " & ex.Message)
        End Try
    End Sub

    Private Function getNextId() As Integer
        Dim nextID As Integer = 1
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If Not dr.IsClosed Then
                dr.Close()
            End If

            sql = "SELECT MAX(SupplierID) AS lastID FROM tblsupplier"
            cmd = New MySqlCommand(sql, cn)
            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                nextID = CInt(result) + 1
            End If
            Return nextID
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSuppliers(getNextId): " & ex.Message)
            Return nextID = 1
        End Try
    End Function

    'Product Tab
    Private Sub loadProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM qryproducts"
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
                x.SubItems.Add(dr("Manufacturer").ToString())
                x.SubItems.Add(dr("PurchasePrice").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString())
                x.SubItems.Add(dr("SupplierID").ToString())

                ListView2.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSuppliers(loadProducts): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub clearAllProduct()
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
    End Sub
    Private Sub enableAllProduct()
        txtProductName.Enabled = True
        txtDescription.Enabled = True
        txtDescription.Enabled = True
        txtCategory.Enabled = True
        txtPurchasePrice.Enabled = True
        txtSellingPrice.Enabled = True
        txtManufacturer.Enabled = True

        btnSearchSupplier.Enabled = True
        btnUploadImage.Enabled = True
    End Sub

    Private Sub disableAllProduct()
        txtProductName.Enabled = False
        txtDescription.Enabled = False
        txtDescription.Enabled = False
        txtCategory.Enabled = False
        txtPurchasePrice.Enabled = False
        txtSellingPrice.Enabled = False
        txtManufacturer.Enabled = False

        btnSearchSupplier.Enabled = False
        btnUploadImage.Enabled = False
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNewProduct.Click
        btnSaveProduct.Enabled = True
        btnCancelProduct.Enabled = True

        btnEditProduct.Enabled = False

        Call enableAllProduct()
        Call clearAllProduct()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancelProduct.Click
        btnCreateNewProduct.Enabled = True

        btnEditProduct.Enabled = False
        btnSaveProduct.Enabled = False
        btnDeleteProduct.Enabled = False
        btnCancelProduct.Enabled = False

        Call disableAllProduct()
        Call clearAllProduct()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEditProduct.Click
        btnSaveProduct.Enabled = True
        btnCancelProduct.Enabled = True
        btnDeleteProduct.Enabled = True

        btnCreateNewProduct.Enabled = False

        Call enableAllProduct()
    End Sub
    Private Sub btnSaveProduct_Click(sender As Object, e As EventArgs) Handles btnSaveProduct.Click
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
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If
                If MsgBox("Do you want to save?", vbYesNo) = vbYes Then
                    Call getSupplierId()
                    Dim mstream As New System.IO.MemoryStream()
                    pbxProduct.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer
                    mstream.Close()
                    If btnCreateNewProduct.Enabled = True And btnEditProduct.Enabled = False Then 'IF CREATE NEW

                        sql = "INSERT INTO tblproduct(ProductName, Description, Stock, Category, Manufacturer, PurchasePrice, SellingPrice, SupplierID, Image) " &
                               "Values(@ProductName, @Description, @Stock, @Category, @Manufacturer, @PurchasePrice, @SellingPrice, @SupplierID, @Image)"
                        cmd = New MySqlCommand(sql, cn)

                        With cmd
                            .Parameters.AddWithValue("@ProductName", txtProductName.Text)
                            .Parameters.AddWithValue("@Description", txtDescription.Text)
                            .Parameters.AddWithValue("@Stock", "Pre-Order") 'UPDATE
                            .Parameters.AddWithValue("@SupplierID", supplierID)
                            .Parameters.AddWithValue("@Category", txtCategory.Text)
                            .Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text)
                            .Parameters.AddWithValue("@PurchasePrice", txtPurchasePrice.Text)
                            .Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text)
                            .Parameters.AddWithValue("@Image", arrImage)
                            .ExecuteNonQuery()
                        End With

                        MsgBox("Successfully created!", MsgBoxStyle.Information)
                    ElseIf btnCreateNewProduct.Enabled = False And btnEditProduct.Enabled = True Then 'IF EDIT
                        sql = "UPDATE tblproduct SET ProductName=@ProductName, Description=@Description, " &
                            "Stock=@Stock, Category=@Category, Manufacturer=@Manufacturer, " &
                            "PurchasePrice=@PurchasePrice, SellingPrice=@SellingPrice, SupplierID=@SupplierID, Image=@Image " &
                            "WHERE ProductID = '" & txtProductId.Text & "'"
                        cmd = New MySqlCommand(sql, cn)
                        With cmd
                            .Parameters.AddWithValue("@ProductName", txtProductName.Text)
                            .Parameters.AddWithValue("@Description", txtDescription.Text)
                            .Parameters.AddWithValue("@Stock", "Pre-Order") 'UPDATE
                            .Parameters.AddWithValue("@SupplierID", txtSupplierID.Text) 'NEEDS UPDATE
                            .Parameters.AddWithValue("@Category", txtCategory.Text)
                            .Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text)
                            .Parameters.AddWithValue("@PurchasePrice", txtPurchasePrice.Text)
                            .Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text)
                            .Parameters.AddWithValue("@Image", arrImage)
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
                    Call loadProducts()
                    Call clearAllProduct()
                    Call disableAllProduct()

                    btnCreateNewProduct.Enabled = True

                    btnEditProduct.Enabled = False
                    btnSaveProduct.Enabled = False
                    btnDeleteProduct.Enabled = False
                    btnCancelProduct.Enabled = False

                    pbxProduct.Image = Nothing
                End If
            Catch ex As Exception
                MsgBox("An Error occurred frmManageSuppliers(btnSaveProduct_Click): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub
    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 0 Then
            txtProductName.Text = ListView2.SelectedItems(0).SubItems(0).Text
            txtSupplier.Text = ListView2.SelectedItems(0).SubItems(1).Text
            txtDescription.Text = ListView2.SelectedItems(0).SubItems(2).Text
            txtCategory.Text = ListView2.SelectedItems(0).SubItems(3).Text
            txtManufacturer.Text = ListView2.SelectedItems(0).SubItems(4).Text
            txtPurchasePrice.Text = ListView2.SelectedItems(0).SubItems(5).Text
            txtSellingPrice.Text = ListView2.SelectedItems(0).SubItems(6).Text
            txtSupplierID.Text = ListView2.SelectedItems(0).SubItems(7).Text
        End If

        Call loadImage()

        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT tblproduct.ProductID from tblproduct WHERE ProductName = '" & txtProductName.Text & "' and Manufacturer = '" & txtManufacturer.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtProductId.Text = dr(0).ToString()
            End If
            dr.Close()

            btnEditProduct.Enabled = True
            btnDeleteProduct.Enabled = True
            btnCancelProduct.Enabled = True

            btnCreateNewProduct.Enabled = False
            btnSaveProduct.Enabled = False

            Call disableAllProduct()
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSuppliers(ListView2_SelectedIndexChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub
    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView2.SelectedItems.Count > 0 Then
                If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                    sql = "DELETE FROM tblproduct WHERE ProductName = @item and Manufacturer = '" & txtCategory.Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@item", txtProductName.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Product successfully deleted!", MsgBoxStyle.Information, "Delete Status")
                    Call loadProducts()
                    Call clearAllProduct()
                    Call disableAllProduct()
                End If
            Else
                MsgBox("Please select an item to delete!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSuppliers(btnDeleteProduct_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        cn.Close()
        Dim dt As DataTable = SearchDatabase(txtSearchProduct.Text)
        PopulateListViewProduct(dt)
    End Sub
    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select ProductName, CompanyName, Description, Category, Manufacturer, PurchasePrice, SellingPrice from qryproducts where ProductName Like ? Or Manufacturer Like ?" 'CHANGE * TO SPECIFIC
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function
    Private Sub PopulateListViewProduct(dt As DataTable)
        ListView2.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView2.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))

        Next
    End Sub

    Dim d As OpenFileDialog = New OpenFileDialog

    Private Sub loadImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT Image FROM tblproduct WHERE ProductID = '" & txtProductId.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                If dr("Image") IsNot DBNull.Value AndAlso dr("Image") IsNot Nothing Then
                    Try
                        Dim pic As Byte() = DirectCast(dr("Image"), Byte())
                        If pic.Length > 0 Then
                            'Dim ms As New MemoryStream(pic)
                            Using ms As New MemoryStream(pic)
                                pbxProduct.Image = Image.FromStream(ms)
                            End Using

                        Else
                            pbxProduct.Image = Nothing
                        End If

                    Catch ex As Exception
                        MsgBox("Error loading image: " & ex.Message)
                    End Try
                Else
                    pbxProduct.Image = Nothing
                End If
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageSuppliers(loadImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs) Handles btnSearchSupplier.Click
        frmListofSuppliers.ShowDialog()
    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            d.Filter = "JPEG(*.jpg; *.jpeg)|*.jpg|PNG(*.png)|*.png"

            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pbxProduct.Image = Image.FromFile(d.FileName)
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageSuppliers(btnUploadImage_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class