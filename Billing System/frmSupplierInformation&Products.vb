Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmManageSupplierV2
    Public supplierid As Integer = Nothing

    Private Sub frmManageSupplierV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

        TabControl2.SelectedTab = TabPage1
        Call loadInformation()
        Call loadImage()

        'SUPPLIER PRODUCTS
        Call supplierProducts()
    End Sub

    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblsupplier WHERE SupplierID = '" & supplierid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtCompanyName.Text = dr("CompanyName").ToString
                txtAddress.Text = dr("Address").ToString
                txtDeliveryTerms.Text = dr("DeliveryTerms").ToString
                txtCompanyPosition.Text = dr("Position").ToString
                txtCompanyEmail.Text = dr("Email").ToString
                txtAccountName.Text = dr("AccountName").ToString
                txtAccountNumber.Text = dr("AccountNumber").ToString
                txtPhoneNumber.Text = dr("PhoneNumber").ToString

                txtFirstName.Text = dr("FirstName").ToString
                txtLastName.Text = dr("LastName").ToString
                txtUsername.Text = dr("Username").ToString
                'txtPassword.Text = dr("Password").ToString

                cboAcctStatus.Text = (If(dr("AcctStatus") = True, "Active", "Inactive"))

                grpbxSupplierName.Text = dr("CompanyName").ToString & " Products"
            End If
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSupplierV2(loadInformation): " & ex.Message)
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

            sql = "SELECT CompanyID, GovernmentID FROM tblsupplier WHERE SupplierID = '" & supplierid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                If dr("CompanyID") IsNot DBNull.Value AndAlso dr("CompanyID") IsNot Nothing AndAlso dr("GovernmentID") IsNot DBNull.Value AndAlso dr("GovernmentID") IsNot Nothing Then
                    Dim companyid As Byte() = DirectCast(dr("CompanyID"), Byte())
                    Dim governmentid As Byte() = DirectCast(dr("GovernmentID"), Byte())
                    If companyid.Length > 0 AndAlso governmentid.Length > 0 Then
                        Using ms As New MemoryStream(companyid)
                            pbxCompanyID.Image = Image.FromStream(ms)
                        End Using
                        Using memorystream As New MemoryStream(governmentid)
                            pbxGovID.Image = Image.FromStream(memorystream)
                        End Using

                    Else
                        pbxGovID.Image = Nothing
                        pbxCompanyID.Image = Nothing
                    End If
                Else
                    pbxGovID.Image = Nothing
                    pbxCompanyID.Image = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSupplierV2(loadImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you want to cancel all edits?", vbYesNo + vbQuestion) = vbYes Then
            btnSave.Enabled = False
            btnEdit.Enabled = False

            btnActive.Enabled = False
            btnDeactive.Enabled = False
            btnCancel.Enabled = False
            Call loadInformation()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Do you want to save?", vbYesNo + vbQuestion) = vbYes Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "UPDATE tblsupplier SET CompanyName=@CompanyName, Address=@Address, DeliveryTerms=@DeliveryTerms, Position=@Position, Email=@Email " &
                    "AccountName=@AccountName, AccountNumber=@AccountNumber, PhoneNumber=@PhoneNumber, FirstName=@FirstName, LastName=@LastName, Username=@Username, AcctStatus=@AcctStatus " &
                    "WHERE SupplierID = '" & supplierid & "'"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
                    .Parameters.AddWithValue("@Address", txtCompanyName.Text)
                    .Parameters.AddWithValue("@DeliveryTerms", txtCompanyName.Text)
                    .Parameters.AddWithValue("@Position", txtCompanyName.Text)
                    .Parameters.AddWithValue("@Email", txtCompanyName.Text)
                    .Parameters.AddWithValue("@AccountName", txtCompanyName.Text)
                    .Parameters.AddWithValue("@AccountNumber", txtCompanyName.Text)
                    .Parameters.AddWithValue("@PhoneNumber", txtCompanyName.Text)
                    .Parameters.AddWithValue("@FirstName", txtCompanyName.Text)
                    .Parameters.AddWithValue("@LastName", txtCompanyName.Text)
                    .Parameters.AddWithValue("@Username", txtCompanyName.Text)
                    .Parameters.AddWithValue("@AcctStatus", txtCompanyName.Text)
                    .ExecuteNonQuery()
                End With

                MsgBox("Saved successfully!", MsgBoxStyle.Information, "Save Supplier Account")
                btnSave.Enabled = False
                btnEdit.Enabled = False

                btnActive.Enabled = False
                btnDeactive.Enabled = False
                btnCancel.Enabled = False
                Call loadInformation()
            Catch ex As Exception
                MsgBox("An Error occurred frmManageSupplierV2(btnSave_Click): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call enableAll()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        btnActive.Enabled = True
        btnDeactive.Enabled = True
    End Sub

    Private Sub enableAll()
        txtCompanyName.Enabled = True
        txtAddress.Enabled = True
        txtDeliveryTerms.Enabled = True
        txtCompanyPosition.Enabled = True
        txtCompanyEmail.Enabled = True
        txtAccountName.Enabled = True
        txtAccountNumber.Enabled = True
        txtPhoneNumber.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        cboAcctStatus.Enabled = True
    End Sub

    Private Sub disableAll()
        txtCompanyName.Enabled = False
        txtAddress.Enabled = False
        txtDeliveryTerms.Enabled = False
        txtCompanyPosition.Enabled = False
        txtCompanyEmail.Enabled = False
        txtAccountName.Enabled = False
        txtAccountNumber.Enabled = False
        txtPhoneNumber.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        cboAcctStatus.Enabled = False
    End Sub
    Private Sub clearAll()
        txtCompanyName.Clear()
        txtAddress.Clear()
        txtDeliveryTerms.Clear()
        txtCompanyPosition.Clear()
        txtCompanyEmail.Clear()
        txtAccountName.Clear()
        txtAccountNumber.Clear()
        txtPhoneNumber.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cboAcctStatus.SelectedIndex = -1
    End Sub
    Private Sub frmManageSupplierV2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Call disableAll()
            Call clearAll()

            pbxProduct.Image = Nothing
        End If
    End Sub

    Private Sub btnActive_Click(sender As Object, e As EventArgs)
        If MsgBox("Do you want to activate?", vbYesNo + vbQuestion) = vbYes Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "UPDATE tblsupplier SET AcctStatus = 1 WHERE SupplierID = '" & supplierid & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

                MsgBox("Account activated!", MsgBoxStyle.Information, "Activate Supplier Account")
                Call loadInformation()
            Catch ex As Exception
                MsgBox("An Error occurred frmManageSupplierV2(btnActive_Click): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnDeactive_Click(sender As Object, e As EventArgs)
        If MsgBox("Do you want to deactivate?", vbYesNo + vbQuestion) = vbYes Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "UPDATE tblsupplier SET AcctStatus = 0 WHERE SupplierID = '" & supplierid & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

                MsgBox("Account deactivated!", MsgBoxStyle.Information, "Deactivate Supplier Account")
                Call loadInformation()
            Catch ex As Exception
                MsgBox("An Error occurred frmManageSupplierV2(btnDeactive_Click): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub cboAcctStatus_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cboAcctStatus.Text = "Active" Then
            btnDeactive.Enabled = True
            btnActive.Enabled = False
        ElseIf cboAcctStatus.Text = "Inactive" Then
            btnDeactive.Enabled = False
            btnActive.Enabled = True
        End If
    End Sub

    'SUPPLIER PRODUCTS
    Private Sub supplierProducts()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT p.* FROM tblproduct p INNER JOIN tblsupplier s ON p.SupplierID = s.SupplierID WHERE p.SupplierID = '" & supplierid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Category").ToString)
                x.SubItems.Add(dr("Type").ToString)
                x.SubItems.Add(dr("PurchasePrice").ToString)
                x.SubItems.Add(dr("SellingPrice").ToString)
                x.SubItems.Add(dr("Amount").ToString)
                x.SubItems.Add(dr("ProductID").ToString) '7

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSupplierV2(supplierProducts): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT Image FROM tblproduct WHERE ProductID = '" & ListView1.SelectedItems(0).SubItems(7).Text & "'"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    Dim pic As Byte() = DirectCast(dr("Image"), Byte())
                    If pic.Length > 0 Then
                        Using ms As New MemoryStream(pic)
                            pbxProduct.Image = Image.FromStream(ms)
                        End Using

                        btnDelete.Enabled = True
                    End If
                Else
                    pbxProduct.Image = Nothing
                    btnDelete.Enabled = False
                End If
            Catch ex As Exception
                MsgBox("An error occurred frmRestockQuotation(loadQuotationImage): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

    End Sub
End Class