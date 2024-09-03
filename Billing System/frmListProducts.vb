Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmListProducts
    Private Sub frmListProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadProducts()
    End Sub
    Private Sub loadProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
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
                x.SubItems.Add(dr("YearManufactured").ToString())
                x.SubItems.Add(dr("PurchasePrice").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString())
                x.SubItems.Add(dr("ProductID").ToString())
                x.SubItems.Add(dr("Stock").ToString())
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView1.SelectedItems.Count > 0 Then
                frmManageBilling.txtProductName.Text = ListView1.SelectedItems(0).SubItems(0).Text
                frmManageBilling.lblProductID.Text = ListView1.SelectedItems(0).SubItems(8).Text
                frmManageBilling.lblSuppID.Text = ListView1.SelectedItems(0).SubItems(10).Text
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmListProducts(SelectedIndexChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            Dim j As String = InputBox("Enter Quantity:", "Quantity")

            ' Handle the scenario when the user cancels or closes the input dialog
            If j = "" Then
                Return
            End If

            ' Check if input is valid
            If String.IsNullOrEmpty(j) OrElse Val(j) <= 0 Then
                MsgBox("Please enter a valid number of quantity!", MsgBoxStyle.Critical, "Error in Quantity")
                Return
            End If

            ' Check stock availability
            If Val(j) > Val(ListView1.SelectedItems(0).SubItems(9).Text) Then
                MsgBox("Inputted Quantity is greater than Stock", MsgBoxStyle.Information)
            Else
                If Val(ListView1.SelectedItems(0).SubItems(9).Text) < 10 Then
                    MsgBox("The stock for this product is running low.", MsgBoxStyle.Critical, "Critical Status!")
                End If

                ' Proceed to add to the cart if stock is sufficient
                If Val(ListView1.SelectedItems(0).SubItems(9).Text) > 0 Then
                    frmManageBilling.lblQty.Text = Val(j)
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                    Me.Close()
                Else
                    MsgBox("No stock available to add to the cart", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmListProducts(btnCOnfirm): " & ex.Message)
        End Try
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
        sql = "SELECT ProductName, CompanyName, Description, Category, Manufacturer, YearManufactured, PurchasePrice, SellingPrice FROM qryproducts WHERE ProductName LIKE ? OR CompanyName LIKE ?"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function
End Class