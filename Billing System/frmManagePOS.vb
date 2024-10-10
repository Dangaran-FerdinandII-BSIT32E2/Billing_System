Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports System.Data.SqlClient
Public Class frmManagePOS

    Public productid As String
    Dim totalamount As Integer
    Public isRental As Boolean? = False
    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs) Handles btnSearchSupplier.Click
        frmListProducts.ShowDialog()
        btnCancel.Enabled = True
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
                ElseIf Val(txtQty.text) > 100 Or Val(txtQty.text) < 0 Then
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

        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            If MsgBox("Do you want to save?", vbYesNo + vbQuestion) = vbYes Then
                For Each listitem As ListViewItem In ListView1.Items 'includes ProductID as ListView1.SubItems(4)
                    sql = "SELECT ProductName, Description, SellingPrice, ProductID FROM qryproducts WHERE ProductID = '" & listitem.SubItems(4).Text & "'"
                    cmd = New MySqlCommand(sql, cn)

                    If Not dr.IsClosed Then
                        dr.Close()
                    End If

                    dr = cmd.ExecuteReader
                    If isRental Then
                        While dr.Read
                            Dim X As ListViewItem = frmManageRentalV2.ListView1.Items.Add(listitem.SubItems(2).Text)
                            X.SubItems.Add(dr("ProductName").ToString())
                            X.SubItems.Add(dr("Description").ToString())
                            X.SubItems.Add(dr("SellingPrice").ToString())
                            X.SubItems.Add(listitem.SubItems(3).Text)
                            X.SubItems.Add("0") '5
                            X.SubItems.Add("0") '6
                            X.SubItems.Add(dr("ProductID").ToString()) '7
                        End While
                        frmManageRentalV2.txtCompanyName.Enabled = True
                        frmManageRentalV2.txtDeliveryAddress.Enabled = True
                        frmManageRentalV2.txtAddress.Enabled = True
                    Else
                        While dr.Read
                            Dim X As ListViewItem = frmManageSalesV2.ListView1.Items.Add(listitem.SubItems(2).Text)
                            X.SubItems.Add(dr("ProductName").ToString())
                            X.SubItems.Add(dr("Description").ToString())
                            X.SubItems.Add(dr("SellingPrice").ToString())
                            X.SubItems.Add(listitem.SubItems(3).Text)
                            X.SubItems.Add("0") '5
                            X.SubItems.Add("0") '6
                            X.SubItems.Add(dr("ProductID").ToString()) '7
                        End While
                        frmPrintSalesInvoiceV2.walkin = True
                        frmManageSalesV2.txtCompanyName.Enabled = True
                        frmManageSalesV2.txtDeliveryAddress.Enabled = True
                        frmManageSalesV2.txtAddress.Enabled = True
                    End If
                Next
                Call closeForm()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(printBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
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


End Class