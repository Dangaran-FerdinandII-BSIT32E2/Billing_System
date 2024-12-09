Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports Mysqlx.Crud

Public Class frmManageProducts
    Public supplierid As Integer? = Nothing
    Public productid As Integer? = Nothing

    Dim d As OpenFileDialog = New OpenFileDialog
    Private Sub frmManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        If productid IsNot Nothing Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT p.*, s.* FROM tblproduct p INNER JOIN tblsupplier s ON p.SupplierID = s.SupplierID WHERE ProductID = '" & productid & "'"
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

                                PictureBox2.Visible = False
                                btnBrowse.Visible = False

                            Else
                                pbxProduct.Image = Nothing
                                PictureBox2.Visible = True
                                btnBrowse.Visible = True
                            End If

                        Catch ex As Exception
                            MsgBox("Error loading image: " & ex.Message)
                        End Try
                    Else
                        pbxProduct.Image = Nothing
                        PictureBox2.Visible = True
                        btnBrowse.Visible = True
                    End If
                    txtProductName.Text = dr("ProductName").ToString
                    txtDescription.Text = dr("Description").ToString
                    txtCategory.Text = dr("Category").ToString
                    txtType.Text = dr("Type").ToString
                    txtPurchasePrice.Text = dr("PurchasePrice").ToString
                    txtSellingPrice.Text = dr("SellingPrice").ToString

                    txtSearchSupplierName.Text = dr("CompanyName").ToString

                End If

            Catch ex As Exception
                MsgBox("An error occurred frmManageSupplierV2(frmManageProducts_Load): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        Else
            Call clear()
        End If
        txtProductName.Focus()
        Call loadImage()
    End Sub
    Private Sub clear()
        productid = Nothing
        supplierid = Nothing

        txtSearchSupplierName.Enabled = True

        txtSearchSupplierName.Clear()

        txtSearchSupplierName.Enabled = False

        txtProductName.Clear()
        txtDescription.Clear()
        txtCategory.Clear()
        txtType.Clear()
        txtPurchasePrice.Clear()
        txtSellingPrice.Clear()

        pbxProduct.Image = Nothing
        btnBrowse.Visible = True
        PictureBox2.Visible = True
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If pbxProduct.Image IsNot Nothing Then
            If MsgBox("Do you want to save?", vbYesNo + vbQuestion) = vbYes Then

                Dim filled As Boolean = True

                Dim requiredFields As New Dictionary(Of String, Control) From {
                {"txtSearchSupplierName", txtSearchSupplierName},
                {"txtProductName", txtProductName},
                {"txtDescription", txtDescription},
                {"txtCategory", txtCategory},
                {"txtType", txtType},
                {"txtPurchasePrice", txtPurchasePrice},
                {"txtSellingPrice", txtSellingPrice}
            }

                For Each fieldName_controlPair In requiredFields
                    Dim control As Control = fieldName_controlPair.Value

                    If control.Text.Trim = "" Then
                        ErrorProvider1.SetIconAlignment(control, ErrorIconAlignment.MiddleLeft)
                        ErrorProvider1.SetError(control, "This field is required.")
                        MsgBox("Please fill out all fields!", MsgBoxStyle.Critical, "Empty Inputs")
                        filled = False
                        Exit For
                    Else
                        ErrorProvider1.SetError(control, "")
                    End If
                Next

                If filled Then
                    If productid Is Nothing Then
                        Call saveProduct()
                    Else
                        Call updateProduct()
                    End If

                    Call loadActivity()
                    Call frmProduct.loadProducts()
                    MsgBox("Product successfully saved!", MsgBoxStyle.Information, "Product Insert")
                    Me.Close()
                End If
            End If
        Else
            MsgBox("Please insert an image.", MsgBoxStyle.Critical, "Image Error")
        End If
    End Sub
    Private Sub saveProduct()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblproduct(ProductName, Description, Category, Type, Manufacturer, PurchasePrice, SellingPrice, SupplierID) " &
                    "VALUES(@ProductName, @Description, @Category, @Type, @Manufacturer, @PurchasePrice, @SellingPrice, @SupplierID)"

            Using mstream As New System.IO.MemoryStream
                pbxProduct.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer

                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@ProductName", txtProductName.Text)
                    .Parameters.AddWithValue("@Description", txtDescription.Text)
                    .Parameters.AddWithValue("@Category", txtCategory.Text)
                    .Parameters.AddWithValue("@Type", txtType.Text)
                    .Parameters.AddWithValue("@Manufacturer", txtSearchSupplierName.Text)
                    .Parameters.AddWithValue("@PurchasePrice", txtPurchasePrice.Text)
                    .Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text)
                    .Parameters.AddWithValue("@SupplierID", supplierid)
                    .Parameters.AddWithValue("@Image", arrImage)
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MsgBox("An error occurred frmManageProducts(saveProduct): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub updateProduct()

        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblproduct SET ProductName = @ProductName, Description = @Description, Category = @Category, Type = @Type, PurchasePrice = @PurchasePrice, SellingPrice = @SellingPrice, SupplierID=@SupplierID, Manufacturer=@Manufacturer, Image = @Image WHERE ProductID = '" & productid & "'"

            Using mstream As New System.IO.MemoryStream
                Using img As Image = New Bitmap(pbxProduct.Image)
                    img.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.ToArray

                    Using cmd As New MySqlCommand(sql, cn)
                        With cmd
                            .Parameters.AddWithValue("@ProductName", txtProductName.Text)
                            .Parameters.AddWithValue("@Description", txtDescription.Text)
                            .Parameters.AddWithValue("@Category", txtCategory.Text)
                            .Parameters.AddWithValue("@Type", txtType.Text)
                            .Parameters.AddWithValue("@Manufacturer", txtSearchSupplierName.Text)
                            .Parameters.AddWithValue("@PurchasePrice", txtPurchasePrice.Text)
                            .Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text)
                            .Parameters.AddWithValue("@SupplierID", supplierid)
                            .Parameters.AddWithValue("@Image", arrImage)
                            .ExecuteNonQuery()
                        End With
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("An error occurred frmManageProducts(updateProduct): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub loadActivity()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblactivity(UserID, Username, DateTime, Action) VALUES(@UserID, @Username, @DateTime, @Action)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@UserID", frmLoginV2.userid)
                .Parameters.AddWithValue("@Username", frmLoginV2.username)
                .Parameters.AddWithValue("@DateTime", DateTime.Now)
                .Parameters.AddWithValue("@Action", "SAVED PRODUCT " + txtProductName.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmManageProducts(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT Image FROM tblproduct WHERE ProductID = '" & productid & "'"
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
                            Using ms As New MemoryStream(pic)
                                pbxProduct.Image = Image.FromStream(ms)
                            End Using
                            btnBrowse.Visible = False
                            PictureBox2.Visible = False
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
            MsgBox("An error occurred frmManageProducts(loadImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            d.Filter = "JPEG(*.jpg; *.jpeg)|*.jpg|PNG(*.png)|*.png"

            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pbxProduct.Image = Image.FromFile(d.FileName)
                btnBrowse.Visible = False
                PictureBox2.Visible = False
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageSuppliers(btnUploadImage_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs)
        frmListofSuppliers.ShowDialog()
    End Sub

    Private Sub btnCancelSupp_Click(sender As Object, e As EventArgs) Handles btnCancelSupp.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
            Call clear()
            Me.Close()
        End If
    End Sub

    Private Sub frmManageProducts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Call clear()
            frmProduct.btnEdit.Enabled = False
            frmProduct.btnDeactivate.Enabled = False
            frmProduct.btnRestock.Enabled = False
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmListofSuppliers.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Do you want to remove the image?", vbYesNo + vbQuestion) = vbYes Then
            pbxProduct.Image = Nothing
            PictureBox2.Visible = True
            btnBrowse.Visible = True
        End If
    End Sub

    Private Sub txtPurchasePrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPurchasePrice.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "."c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSellingPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSellingPrice.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "."c) Then
            e.Handled = True
        End If
    End Sub
End Class