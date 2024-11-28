Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Public Class frmManagePOS

    Public productid As String
    Dim totalamount As Integer
    Public isRental As Boolean? = False

    Public nameofcompany As String
    Public nameofcontact As String
    Public phonenumber As String
    Public email As String
    Public deliveryaddress As String
    Public purchaseorder As String
    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs) Handles btnSearchSupplier.Click
        frmListProducts.ShowDialog()
        btnCancel.Enabled = True
    End Sub

    Private Sub frmManagePOS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            txtAmt.Clear()
            txtProduct.Clear()
            txtQty.Clear()
            ListView1.Items.Clear()
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtQty", txtQty}
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
                If Not IsNumeric(txtQty.Text) Then
                    MsgBox("Invalid number!", MsgBoxStyle.Critical)
                ElseIf Val(txtQty.Text) > 100 Or Val(txtQty.Text) < 0 Then
                    MsgBox("Amount is invalid!", MsgBoxStyle.Critical)
                ElseIf MsgBox("Do you want to add item?", vbYesNo + vbQuestion) = vbYes Then

                    If txtQty.Text = "0" Then
                        txtQty.Text = 1
                    End If

                    Dim x As ListViewItem

                    x = Me.ListView1.Items.Add(txtProduct.Text)
                    x.SubItems.Add(txtAmt.Text)
                    x.SubItems.Add(txtQty.Text)
                    x.SubItems.Add(txtQty.Text * txtAmt.Text) 'amount
                    x.SubItems.Add(productid) '4

                    lblTotalProductSold.Text += 1

                    Call getTotalAmount()
                    Call clearAll()

                    btnSave.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManagePOS(btnInsert_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub getTotalAmount()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim sellingprice As Integer = (txtQty.Text * txtAmt.Text)

            lblTotalSales.Text += sellingprice
            lblVATSales.Text += sellingprice - (sellingprice * 0.12)
            lblVAT.Text += sellingprice * 0.12
            lblGrandTotal.Text += sellingprice

        Catch ex As Exception
            MsgBox("An error occurred frmManagePOS(getTotalAmount): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub clearAll()
        txtProduct.Enabled = True
        txtAmt.Enabled = True

        txtProduct.Clear()
        txtAmt.Clear()
        txtQty.Clear()

        txtProduct.Enabled = False
        txtAmt.Enabled = False
        btnInsert.Enabled = False
        txtQty.Enabled = False
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If MsgBox("Remove Selected Item?", vbQuestion + vbYesNo) = vbYes Then
            If ListView1.Items.Count = 0 Then
                MsgBox("There are no products on the list.", MsgBoxStyle.Critical, "Delete Status")
            Else
                If ListView1.SelectedItems.Count > 0 Then
                    lblTotalProductSold.Text -= 1
                    Dim removedSellingPrice As Integer = Integer.Parse(ListView1.SelectedItems(0).SubItems(3).Text)
                    ListView1.Items.Remove(ListView1.FocusedItem)

                    lblTotalSales.Text -= removedSellingPrice
                    lblVATSales.Text -= removedSellingPrice - (removedSellingPrice * 0.12)
                    lblVAT.Text -= removedSellingPrice * 0.12
                    lblGrandTotal.Text -= removedSellingPrice

                    btnRemove.Enabled = False

                    Dim hasItems As Boolean = False

                    For Each item As ListViewItem In ListView1.Items
                        hasItems = True
                        Exit For
                    Next

                    If Not hasItems Then
                        btnSave.Enabled = False
                        btnCancel.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        btnInsert.Enabled = False
        btnRemove.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
            Call closeForm()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Do you want to save?", vbYesNo + vbQuestion) = vbYes Then

            walkin()
            Call closeForm()
            Me.Close()
        End If
    End Sub
    Private Sub closeForm()
        ListView1.Items.Clear()
        lblTotalProductSold.Text = "0"
        lblGrandTotal.Text = "0.00"
        lblTotalSales.Text = "0.00"
        lblVATSales.Text = "0.00"
        lblVAT.Text = "0.00"
        Call clearAll()
        btnCancel.Enabled = False
    End Sub
    Private Sub walkin()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each item As ListViewItem In ListView1.Items
                Dim insertSQL As String = "INSERT INTO tblwalkin(OrderID, CustomerID, CompanyName, ContactPerson, PhoneNumber, Email, ProductID, DateOrdered, DueDate, DeliveryAddress, Amount, PONo, Quantity) VALUES(@OrderID, @CustomerID, @CompanyName, @ContactPerson, @PhoneNumber, @Email, @ProductID, @DateOrdered, @DueDate, @DeliveryAddress, @Amount, @PONo, @Quantity)"
                Using insertCMD As New MySqlCommand(insertSQL, cn)
                    With insertCMD

                        Dim productid As String = item.SubItems(4).Text
                        Dim amount As String = item.SubItems(3).Text
                        Dim quantity As String = item.SubItems(2).Text

                        .Parameters.AddWithValue("@OrderID", "0")
                        .Parameters.AddWithValue("@CustomerID", "2") 'customerid 2 is walkin, 1 is rental
                        .Parameters.AddWithValue("@CompanyName", nameofcompany)
                        .Parameters.AddWithValue("@ContactPerson", nameofcontact)
                        .Parameters.AddWithValue("@PhoneNumber", phonenumber)
                        .Parameters.AddWithValue("@Email", email)
                        .Parameters.AddWithValue("@ProductID", productid)
                        .Parameters.AddWithValue("@DateOrdered", DateTime.Now)
                        .Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(7))
                        .Parameters.AddWithValue("@DeliveryAddress", deliveryaddress)
                        .Parameters.AddWithValue("@Amount", amount)
                        .Parameters.AddWithValue("@PONo", purchaseorder)
                        .Parameters.AddWithValue("@Quantity", quantity)
                        .ExecuteNonQuery()
                    End With
                End Using
            Next

        Catch ex As Exception
            MsgBox("An error occurred frmManagePOS(walkin): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class