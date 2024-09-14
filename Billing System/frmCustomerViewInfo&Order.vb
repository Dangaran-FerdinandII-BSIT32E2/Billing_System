Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmCustomerViewInfo_Order

    Private Sub frmCustomerViewInfo_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation()
        Call loadOrder()
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
                txtBusinessStyle.Text = dr("BusinessStyle").ToString()
                cboStatus.Text = dr("Status").ToString()

                txtFirstName.Text = (dr("LastName").ToString() + (", ") + dr("FirstName").ToString())
                txtPhoneNumber.Text = dr("PhoneNumber").ToString()
                txtEmailAddress.Text = dr("Email").ToString()
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

            sql = "SELECT * FROM qryorder WHERE CustomerID = '" & lblCustID.Text & "'"
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
                x.SubItems.Add(If(dr("Availability").ToString() = "True", "Yes", "No"))
                x.SubItems.Add(dr("Status").ToString())
                x.SubItems.Add(dr("OrderDate").ToString())
                x.SubItems.Add(dr("OrderID").ToString())
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView1.SelectedItems.Count > 0 Then
                lblOrderID.Text = ListView1.SelectedItems(0).SubItems(8).Text
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

            sql = "UPDATE tblorder SET Availability=@Availability WHERE OrderID = '" & lblOrderID.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If MsgBox("Is the product available?", vbYesNo + vbQuestion) = vbYes Then
                cmd.Parameters.AddWithValue("@Availability", "1")
            Else
                cmd.Parameters.AddWithValue("@Availability", "0")
            End If

            cmd.ExecuteNonQuery()
            Call loadOrder()
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(ListView1_SelectedIndexChanged): " & ex.Message)
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

            frmManageBilling.lblCustID.Text = lblCustID.Text

            Me.Close()
                frmManageBilling.TopLevel = False
                frmAdminDashboard.panelDashboard.Controls.Add(frmManageBilling)
                frmManageBilling.BringToFront()
                frmManageBilling.Dock = DockStyle.Fill
                frmManageBilling.Show()

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
End Class