﻿Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Public Class frmManageSuppliers
    Private Sub frmManageSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSuppliers()
        Call loadProducts()
        Call loadReorders()
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
                x.SubItems.Add(dr("AccountNumber").ToString())
                x.SubItems.Add(dr("LastName").ToString() & ", " & dr("FirstName").ToString)
                x.SubItems.Add(dr("PhoneNumber").ToString())
                x.SubItems.Add(dr("Address").ToString())
                x.SubItems.Add(dr("DeliveryTerms").ToString())
                x.SubItems.Add(dr("SupplierID").ToString()) '6

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

                    sql = "UPDATE tblsupplier SET AcctStatus = False WHERE SupplierID = '" & ListView1.SelectedItems(0).SubItems(6).Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Supplier Deactivated!", MsgBoxStyle.Information, "Deactivate Status")

                    Call loadSuppliers()
                End If
            Else
                MsgBox("The supplier has available associated products." & vbCrLf & "Please make sure there are no products.", MsgBoxStyle.Critical, "Deactivate Error")
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
        sql = "Select CompanyName,AccountNumber,CONCAT(LastName, ', ', FirstName),PhoneNumber,Address,DeliveryTerms,SupplierID from tblsupplier where CompanyName LIKE ? OR FirstName LIKE ? OR LastName LIKE ?"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm3", "%" & searchTerm & "%"))

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

    'LIST OF RAMBIC PRODUCTS
    Public Sub loadProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM qryproducts WHERE Amount > 0 AND Status <> 3 ORDER BY ProductName ASC"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView2.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Category").ToString())
                x.SubItems.Add(dr("PurchasePrice").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString())
                x.SubItems.Add(checkStatus(dr("Amount"), dr("ProductID")))
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(dr("ProductID").ToString()) '7
                x.SubItems.Add(dr("SupplierID").ToString())

                If dr("Status") = 2 Then
                    x.ForeColor = Color.Black
                ElseIf dr("Status") = 1 Then
                    x.ForeColor = Color.Orange
                Else
                    x.ForeColor = Color.Red
                End If

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

    Private Function checkStatus(amount As Integer, productid As String) As String
        Using cn As New MySqlConnection("server=localhost;user=root;password=;database=dbbilling")
            cn.Open()
            sql = "UPDATE tblproduct SET Status=@Status WHERE ProductID = '" & productid & "'"
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

    Private Sub btnAddNewProduct_Click(sender As Object, e As EventArgs) Handles ListView2.DoubleClick, btnAddNewProduct.Click
        If ListView2.SelectedItems.Count > 0 Then
            frmManageProducts.productid = ListView2.SelectedItems(0).SubItems(7).Text
            frmManageProducts.supplierid = ListView2.SelectedItems(0).SubItems(8).Text
            frmManageProducts.ShowDialog()

            btnDeleteProduct.Enabled = False
        End If
    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView2.SelectedItems.Count > 0 Then
                If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                    sql = "UPDATE tblproduct SET Status = 3 WHERE ProductID = '" & ListView2.SelectedItems(0).SubItems(7).Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.ExecuteNonQuery()

                    MsgBox("Product deactivated.", MsgBoxStyle.Information, "Deactivate Status")
                    Call loadProducts()
                End If
                btnDeleteProduct.Enabled = False
            Else
                MsgBox("Please select an item to deactivate!", vbExclamation)
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
        sql = "Select ProductName,CompanyName,Description,Category,Type,PurchasePrice,SellingPrice,Availability, Status ProductID, SupplierID from qryproducts where ProductName LIKE ? OR CompanyName LIKE ? ORDER BY ProductName ASC"
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
        btnDeleteProduct.Enabled = True
    End Sub

    'REORDERS
    Public Sub loadReorders()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM qryproducts WHERE Status < 2 AND NOT EXISTS ( SELECT 1 FROM tblquotation WHERE qryproducts.ProductID = tblquotation.ProductID ) ORDER BY Status ASC"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView3.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Category").ToString())
                x.SubItems.Add(dr("PurchasePrice").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString())
                x.SubItems.Add(checkStatus(dr("Amount"), dr("ProductID")))
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(dr("ProductID").ToString()) '7
                x.SubItems.Add(dr("SupplierID").ToString())

                If dr("Status") = 1 Then
                    x.ForeColor = Color.Orange
                Else
                    x.ForeColor = Color.Red
                End If

                ListView3.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSupplierProduct(loadReorders): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click, ListView3.DoubleClick
        If ListView3.SelectedItems.Count > 0 Then
            frmRestockProduct.productid = ListView3.SelectedItems(0).SubItems(7).Text
            frmRestockProduct.supplierid = ListView3.SelectedItems(0).SubItems(8).Text

            frmRestockProduct.ShowDialog()
        End If
    End Sub

    Private Sub ListView3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView3.SelectedIndexChanged
        If ListView3.SelectedItems.Count > 0 Then
            btnRestock.Enabled = True
        End If
    End Sub
End Class