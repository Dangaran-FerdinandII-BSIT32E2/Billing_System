Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmAddCustomerWalkin

    Public listofProductIds As New List(Of String)
    Public newValue As String = 0

    Public orderid As String = 0
    Public walkinid As String = 0

    Dim PONo As String = 0

    Private Sub frmAddCustomerWalkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadOrderID()
        Call loadWalkinID()
    End Sub

    Private Sub loadOrderID()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COALESCE(MAX(OrderID), 0) AS OrderID FROM tblorder"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                orderid = (dr("OrderID") + 1).ToString

                lblOrderNo.Text = orderid
            End If
        Catch ex As Exception
            MsgBox("An Error occurred frmAddCustomerWalkin(loadOrderID) :  " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadWalkinID()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COALESCE(MAX(WalkinID), 0) AS WalkinID FROM tblwalkin"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                walkinid = (dr("WalkinID") + 1).ToString
            End If
        Catch ex As Exception
            MsgBox("An Error occurred frmAddCustomerWalkin(loadWalkinID) :  " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


    Public Sub addtolist(productid As String)
        If Not listofProductIds.Contains(productid) Then
            listofProductIds.Add(productid)
        End If

        Call loadInformation()
    End Sub

    Public Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            ListView1.Items.Clear()

            For Each productid As String In listofProductIds
                sql = "SELECT p.ProductID, p.ProductName, p.Image, p.SellingPrice FROM tblproduct p WHERE p.ProductID = '" & productid & "'"
                Using cmd As New MySqlCommand(sql, cn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            ListView1.SmallImageList = ImageList1

                            Dim productimage() As Byte = DirectCast(dr("Image"), Byte())
                            Dim ms As New MemoryStream(productimage)

                            Using image As Image = Image.FromStream(ms)
                                Dim x As New ListViewItem

                                x.ImageIndex = ImageList1.Images.Add(image, Nothing)
                                x.SubItems.Add(dr("ProductName").ToString)
                                x.SubItems.Add(newValue)
                                x.SubItems.Add(dr("ProductID").ToString) '3
                                x.SubItems.Add(dr("SellingPrice").ToString) '4

                                ListView1.Items.Add(x)

                                newValue = 0
                            End Using
                        End While
                    End Using
                End Using
            Next

        Catch ex As Exception
            MsgBox("An Error occurred frmAddCustomerWalkin(loadInformation) :  " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub btnEnterQuantity_Click(sender As Object, e As EventArgs) Handles btnEnterQuantity.Click, ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            frmEnterQuantity.lblHeaderTitle.Text = "Place Order"
            frmEnterQuantity.ActiveControl = frmEnterQuantity.txtQuantiyProducts

            frmEnterQuantity.walkin = True
            frmEnterQuantity.ShowDialog()

            ListView1.SelectedItems(0).SubItems(2).Text = newValue

            btnEnterQuantity.Enabled = False
            btnRemoveProduct.Enabled = False
        End If

    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        frmListProducts.walkin = True
        frmListProducts.listofProductIds = listofProductIds
        frmListProducts.ShowDialog()
    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click
        If ListView1.SelectedItems.Count > 0 Then
            If MsgBox("Do you want to remove the item?", vbQuestion + vbYesNo) = vbYes Then
                listofProductIds.Remove(ListView1.SelectedItems(0).SubItems(3).Text)

                btnEnterQuantity.Enabled = False
                btnRemoveProduct.Enabled = False
                Call loadInformation()
            End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            btnEnterQuantity.Enabled = True
            btnRemoveProduct.Enabled = True
        End If
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If listofProductIds.Count > 0 Then
            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtCompanyName", txtCompanyName},
            {"txtAddress", txtAddress},
            {"txtDeliveryAddress", txtDeliveryAddress},
            {"txtBusinessStyle", txtBusinessStyle},
            {"txtCompanyPosition", txtCompanyPosition},
            {"txtFirstName", txtFirstName},
            {"txtLastName", txtLastName},
            {"txtPhoneNumber", txtPhoneNumber},
            {"txtEmailAddress", txtEmailAddress},
            {"txtTIN", txtTIN}
            }

            For Each fieldName_controlPair In requiredFields
                Dim control As Control = fieldName_controlPair.Value

                If control.Text.Trim = "" Then
                    ErrorProvider1.SetError(control, "This field is required.")
                    MsgBox("Please fill up all the required fields.", MsgBoxStyle.Critical, "Input Error")
                    filled = False
                    Exit For
                Else
                    ErrorProvider1.SetError(control, "")
                End If
            Next

            If filled AndAlso checkTIN() Then
                Call saveWalkinInformation()
                Call saveWalkinCart()
                Call savetoOrders()

                MsgBox("Order saved successfully!", MsgBoxStyle.Information, "Walkin Status")
                Me.Close()
            End If
        Else
            MsgBox("Please add products into the cart.", MsgBoxStyle.Critical, "Cart Error")
        End If
    End Sub

    Private Function checkTIN() As Boolean
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT TIN FROM tblcustomer WHERE TIN = '" & txtTIN.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                MsgBox("This TIN is already in use!", MsgBoxStyle.Critical, "TIN Error")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("An Error occurred frmAddCustomerWalkin(checkTIN) :  " & ex.Message)
            Return False
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Private Sub saveWalkinInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblwalkin(WalkinID, CompanyName, Address, DeliveryAddress, BusinessStyle, CompanyPosition, FirstName, LastName, PhoneNumber, Email, TIN) VALUES(@WalkinID, @CompanyName, @Address, @DeliveryAddress, @BusinessStyle, @CompanyPosition, @FirstName, @LastName, @PhoneNumber, @Email, @TIN)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@WalkinID", walkinid)
                .Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
                .Parameters.AddWithValue("@Address", txtAddress.Text)
                .Parameters.AddWithValue("@DeliveryAddress", txtDeliveryAddress.Text)
                .Parameters.AddWithValue("@BusinessStyle", txtBusinessStyle.Text)
                .Parameters.AddWithValue("@CompanyPosition", txtCompanyPosition.Text)
                .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                .Parameters.AddWithValue("@LastName", txtLastName.Text)
                .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                .Parameters.AddWithValue("@Email", txtEmailAddress.Text)
                .Parameters.AddWithValue("@TIN", txtTIN.Text)
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            MsgBox("An Error occurred frmAddCustomerWalkin(checkTIN) :  " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub saveWalkinCart()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each item As ListViewItem In ListView1.Items
                sql = "INSERT INTO tblorderwalkin(OrderID, WalkinID, ProductID, Quantity) VALUES(@OrderID, @WalkinID, @ProductID, @Quantity)"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@OrderID", orderid)
                    .Parameters.AddWithValue("@WalkinID", walkinid)
                    .Parameters.AddWithValue("@ProductID", item.SubItems(3).Text)
                    .Parameters.AddWithValue("@Quantity", item.SubItems(2).Text)
                    .ExecuteNonQuery()
                End With
            Next
        Catch ex As Exception
            MsgBox("An Error occurred frmAddCustomerWalkin(checkTIN) :  " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub savetoOrders()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each item As ListViewItem In ListView1.Items
                Dim amount As Double = Convert.ToDouble(item.SubItems(4).Text * item.SubItems(2).Text)
                sql = "INSERT INTO tblorder(OrderID, CustomerID, ProductID, Quantity, Amount, Status, DateOrdered, DeliveryAddress, PONo, isRental, RentDays, RentDueDate) " &
                        "VALUES(@OrderID, @CustomerID, @ProductID, @Quantity, @Amount, @Status, @DateOrdered, @DeliveryAddress, @PONo, @isRental, @RentDays, @RentDueDate)"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@OrderID", orderid)
                    .Parameters.AddWithValue("@CustomerID", 2)
                    .Parameters.AddWithValue("@ProductID", item.SubItems(3).Text)
                    .Parameters.AddWithValue("@Quantity", item.SubItems(2).Text)
                    .Parameters.AddWithValue("@Amount", amount)
                    .Parameters.AddWithValue("@Status", 0)
                    .Parameters.AddWithValue("@DateOrdered", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    .Parameters.AddWithValue("@DeliveryAddress", txtDeliveryAddress.Text)
                    .Parameters.AddWithValue("@PONo", 0)
                    .Parameters.AddWithValue("@isRental", 0)
                    .Parameters.AddWithValue("@RentDays", 0)
                    .Parameters.AddWithValue("@RentDueDate", Nothing)
                    .ExecuteNonQuery()
                End With
            Next

        Catch ex As Exception
            MsgBox("An Error occurred frmAddCustomerWalkin(savetoOrders) :  " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAddCustomerWalkin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            ListView1.Items.Clear()
            listofProductIds.Clear()

            txtCompanyName.Clear()
            txtAddress.Clear()
            txtDeliveryAddress.Clear()
            txtBusinessStyle.Clear()
            txtCompanyPosition.Clear()
            txtFirstName.Clear()
            txtLastName.Clear()
            txtPhoneNumber.Clear()
            txtEmailAddress.Clear()
            txtTIN.Clear()

        End If
    End Sub

    Private Sub chckRentOrder_CheckedChanged(sender As Object, e As EventArgs) Handles chckRentOrder.CheckedChanged
        If chckRentOrder.Checked = True Then
            chckPurchaseOrder.Checked = False
            Me.ActiveControl = Me.txtRentDays
            GroupBox5.Visible = True
        Else
            GroupBox5.Visible = False
        End If
    End Sub

    Private Sub chckPurchaseOrder_CheckedChanged(sender As Object, e As EventArgs) Handles chckPurchaseOrder.CheckedChanged
        If chckPurchaseOrder.Checked = True Then
            txtRentDays.Clear()
            chckRentOrder.Checked = False
            GroupBox5.Visible = False
        End If
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse
            e.KeyChar = ChrW(Keys.Back) OrElse
            (e.KeyChar = "+" AndAlso txtPhoneNumber.Text.Length = 0)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTIN.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRentDays_TextChanged(sender As Object, e As EventArgs) Handles txtRentDays.TextChanged

    End Sub
End Class