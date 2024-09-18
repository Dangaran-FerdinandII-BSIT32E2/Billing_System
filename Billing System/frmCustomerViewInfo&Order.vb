Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmCustomerViewInfo_Order

    Dim acctstatus As Boolean
    Dim status1 As Integer
    Private Sub frmCustomerViewInfo_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation()
        Call loadOrder()
        TabControl2.SelectedTab = TabPage1
    End Sub

    'Customer Tab
    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM tblcustomer WHERE CustomerID = '" & lblCustID.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtCompanyName.Text = dr("CompanyName").ToString()
                txtAddress.Text = dr("Address").ToString()
                txtDeliveryAddress.Text = dr("Delivery").ToString()
                txtBusinessStyle.Text = dr("CompanyName").ToString() 'bus style
                cboStatus.Text = (IIf(dr("Status") = "2", "Credit Positive", IIf(dr("Status") = "1", "Credit Negative", "Neutral")).ToString())

                txtLastName.Text = dr("LastName").ToString()
                txtFirstName.Text = dr("FirstName").ToString()
                txtPhoneNumber.Text = dr("PhoneNumber").ToString()
                txtEmailAddress.Text = dr("Email").ToString()
                cboAcctStatus.Text = (If(dr("AcctStatus") = "True", "Active", "Inactive").ToString())
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(loadInformation): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    'Order Tab
    Private Sub loadOrder()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM qryorder WHERE CustomerID = '" & lblCustID.Text & "' AND Status <> 3"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("Unit").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Quantity").ToString())
                x.SubItems.Add(dr("Unit").ToString())
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(If(dr("Availability").ToString() = "True", "Yes", "No")) 'subitem5
                x.SubItems.Add(IIf(dr("Status").ToString() = "2", "Ready for Shipment", IIf(dr("Status").ToString() = 1, "On hold", "On process")).ToString())
                x.SubItems.Add(dr("OrderDate").ToString())
                x.SubItems.Add(dr("OrderID").ToString()) ' 8
                x.SubItems.Add(dr("OrderList").ToString()) ' 9
                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(loadOrder): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Dim avail As String
    Dim status As String
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView1.SelectedItems.Count > 0 Then
                lblOrderID.Text = ListView1.SelectedItems(0).SubItems(9).Text
                avail = ListView1.SelectedItems(0).SubItems(5).Text
                status = ListView1.SelectedItems(0).SubItems(6).Text
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(ListView1_SelectedIndexChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub updateInfo(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblorder SET Availability=@Availability, Status=@Status WHERE OrderListID = '" & lblOrderID.Text & "'"
            cmd = New MySqlCommand(sql, cn)
            'for status 2 = delivered, 1 = on hold, 0 = process
            If avail = "No" And status = "On process" Then
                If MsgBox("Is the product available?", vbYesNo + vbQuestion) = vbYes Then
                    cmd.Parameters.AddWithValue("@Availability", True)
                    cmd.Parameters.AddWithValue("@Status", "0")
                    cmd.ExecuteNonQuery()
                End If
            ElseIf avail = "Yes" And status = "On process" Then
                If MsgBox("Is the product on hold?", vbYesNo + vbQuestion) = vbYes Then
                    cmd.Parameters.AddWithValue("@Availability", True)
                    cmd.Parameters.AddWithValue("@Status", "1")
                    cmd.ExecuteNonQuery()
                End If
            ElseIf avail = "Yes" And status = "On hold" Then
                MsgBox("The product is already on hold.", vbInformation, "Order Information")
            End If

            Call loadOrder()
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(updateInfo): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            frmManageSalesV2.lblCustID.Text = lblCustID.Text

            Me.Close()
            frmManageSalesV2.TopLevel = False
            frmAdminDashboard.panelDashboard.Controls.Add(frmManageSalesV2)
            frmManageSalesV2.BringToFront()
            frmManageSalesV2.Dock = DockStyle.Fill
            frmManageSalesV2.Show()

            frmManageSales.Close()
            frmManageCollection.Close()
            frmManageSuppliers.Close()
            frmManageProducts.Close()
            frmManageCustomerV2.Close()
            frmManageUsers.Close()
            frmManageRental.Close()
            frmAdminSettings.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(btnInsert): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True
        btnEdit.Enabled = False

        Call enableAll()
    End Sub

    Private Sub enableAll()
        txtCompanyName.Enabled = True
        txtAddress.Enabled = True
        txtDeliveryAddress.Enabled = True
        txtBusinessStyle.Enabled = True
        cboStatus.Enabled = True

        txtLastName.Enabled = True
        txtFirstName.Enabled = True
        txtPhoneNumber.Enabled = True
        txtEmailAddress.Enabled = True
        cboAcctStatus.Enabled = True
    End Sub
    Private Sub disableAll()
        txtCompanyName.Enabled = False
        txtAddress.Enabled = False
        txtDeliveryAddress.Enabled = False
        txtBusinessStyle.Enabled = False
        cboStatus.Enabled = False

        txtLastName.Enabled = False
        txtFirstName.Enabled = False
        txtPhoneNumber.Enabled = False
        txtEmailAddress.Enabled = False
        cboAcctStatus.Enabled = False
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtCompanyName", txtCompanyName},
            {"txtAddress", txtAddress},
            {"txtDeliveryAddress", txtDeliveryAddress},
            {"txtBusinessStyle", txtBusinessStyle},
            {"cboStatus", cboStatus},
            {"txtFirstName", txtFirstName},
            {"txtLastName", txtLastName},
            {"txtPhoneNumber", txtPhoneNumber},
            {"txtEmailAddress", txtEmailAddress},
            {"cboAcctStatus", cboAcctStatus}
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

                    If cboStatus.Text = "Credit Positive" Then
                        status1 = 2
                    ElseIf cboStatus.Text = "Credit Negative" Then
                        status1 = 1
                    Else
                        status1 = 0
                    End If

                    If cboAcctStatus.Text = "Active" Then
                        acctstatus = True
                    Else
                        acctstatus = False
                    End If

                    sql = "UPDATE tblcustomer SET LastName=@LastName, FirstName=@FirstName, PhoneNumber=@PhoneNumber, Email=@Email," &
                    "CompanyName=@CompanyName, Address=@Address, Delivery=@Delivery, BusinessStyle=@BusinessStyle," &
                    "Status=@Status, AcctStatus=@AcctStatus WHERE CustomerID = '" & lblCustID.Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@LastName", txtLastName.Text)
                        .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                        .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                        .Parameters.AddWithValue("@Email", txtEmailAddress.Text)
                        .Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
                        .Parameters.AddWithValue("@Address", txtAddress.Text)
                        .Parameters.AddWithValue("@Delivery", txtDeliveryAddress.Text)
                        .Parameters.AddWithValue("@BusinessStyle", txtBusinessStyle.Text)
                        .Parameters.AddWithValue("@Status", status1.ToString())
                        .Parameters.AddWithValue("@AcctStatus", acctstatus)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Successfully changed information!", MsgBoxStyle.Information, "Update Info")

                    btnEdit.Enabled = True

                    btnSave.Enabled = False
                    Call loadInformation()
                Catch ex As Exception
                    MsgBox("An error occurred frmCustomerViewInfo_Order(Saving Information): " & ex.Message)
                Finally
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(btnSave): " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnSave.Enabled = False

        btnEdit.Enabled = True

        Call disableAll()
        Call loadInformation()
    End Sub
End Class