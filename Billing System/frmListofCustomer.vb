Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmListofCustomer
    Private Sub frmListofCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadCustomerInfo()
    End Sub
    Private Sub loadCustomerInfo()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblcustomer WHERE CustomerID = '" & lblCustomerID.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                'CompanyInfo
                txtCompanyName.Text = dr("CompanyName").ToString()
                txtAddress.Text = dr("Address").ToString()
                txtDeliveryAddress.Text = dr("Delivery").ToString()
                txtBusinessStyle.Text = dr("BusinessStyle").ToString()
                cboStatus.Text = dr("Status").ToString()
                'ContactInfo
                txtFirstName.Text = dr("FirstName").ToString()
                txtLastName.Text = dr("LastName").ToString()
                txtPhoneNumber.Text = dr("PhoneNumber").ToString()
                txtEmailAddress.Text = dr("Email").ToString()
                txtUsername.Text = dr("Username").ToString()
                txtPassword.Text = dr("Password").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmListOfCustomer(loadCustomerInfo): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
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
            {"txtFirstname", txtFirstName},
            {"txtLastname", txtLastName},
            {"txtPhoneNumber", txtPhoneNumber},
            {"txtEmailAddress", txtEmailAddress},
            {"txtUsername", txtUsername},
            {"txtPassword", txtPassword},
            {"txtConfPass", txtConfPass}
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
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                If txtPassword.Text = txtConfPass.Text Then
                    sql = "UPDATE tblcustomer SET CompanyName=@CompanyName, Address=@Address, Delivery=@Delivery, BusinessStyle=@BusinessStyle, Status=@Status" & 'CompanyInfo
                        " LastName=@LastName, FirstName=@FirstName, PhoneNumber=@PhoneNumber, Email=@Email, Username=@Username, Password=@Password" & 'ContactInfo
                        " WHERE CustomerID = '" & lblCustomerID.Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        'CompanyInfo
                        .Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
                        .Parameters.AddWithValue("@Address", txtAddress.Text)
                        .Parameters.AddWithValue("@Delivery", txtDeliveryAddress.Text)
                        .Parameters.AddWithValue("@BusinessStyle", txtBusinessStyle.Text)
                        .Parameters.AddWithValue("@Status", cboStatus.Text)
                        'ContactInfo
                        .Parameters.AddWithValue("@LastName", txtLastName.Text)
                        .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                        .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                        .Parameters.AddWithValue("@Email", txtEmailAddress.Text)
                        .Parameters.AddWithValue("@Username", txtUsername.Text)
                        .Parameters.AddWithValue("@Password", txtPassword.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Successfully updated!", MsgBoxStyle.Information, "Update Info")
                    Call frmManageCustomerV2.loadCustomers()
                    Me.Close()
                Else
                    MsgBox("Passwords do not match!", MsgBoxStyle.Critical, "Confirm Password")
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmListOfCustomer(btnSave): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True

        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            If lblCustomerID.Text IsNot Nothing Then
                If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                    sql = "DELETE FROM tblcustomer WHERE CustomerID = @customerid"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@customerid", lblCustomerID.Text)
                    cmd.ExecuteNonQuery()

                    Call frmManageCustomerV2.loadCustomers()

                    MsgBox("Successfully deleted!", MsgBoxStyle.Information, "Delete Info")
                End If
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmListOfCustomer(btnDelete): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class