Imports MySql.Data.MySqlClient

Public Class frmManageSuppliers
    Dim supplierID As Integer
    Private Sub frmManageSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        cn.Open()
        Call loadSuppliers()
    End Sub

    Private Sub loadSuppliers()
        sql = "SELECT * FROM tblsupplier"
        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader

        Dim x As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read = True
            x = New ListViewItem(dr("CompanyName").ToString())
            x.SubItems.Add(dr("BankDetails").ToString())
            x.SubItems.Add(dr("ContactPerson").ToString())
            x.SubItems.Add(dr("PhoneNumber").ToString())
            x.SubItems.Add(dr("Address").ToString())
            x.SubItems.Add(dr("EquipmentType").ToString())
            x.SubItems.Add(dr("DeliveryTerms").ToString())
            x.SubItems.Add(dr("PaymentTerms").ToString())
            x.SubItems.Add(dr("SupplierID").ToString())

            ListView1.Items.Add(x)
        Loop
        cn.Close()

    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs)

        btnSave.Enabled = True
        btnCancel.Enabled = True

        btnEdit.Enabled = False

        Call clearAll()
        Call enableAll()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        btnCreateNew.Enabled = True

        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False

        Call clearAll()
        Call disableAll()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnDelete.Enabled = True

        btnCreateNew.Enabled = False

        Call enableAll()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Dim filled As Boolean = True

        Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtCompanyName", txtCompanyName},
            {"txtBankDetails", txtBankDetails},
            {"txtContactPerson", txtContactPerson},
            {"txtPhoneNumber", txtPhoneNumber},
            {"txtAddress", txtAddress},
            {"txtEquipmentType", txtEquipmentType},
            {"txtDeliveryTerms", txtDeliveryTerms},
            {"txtPaymentTerms", txtPaymentTerms}
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
            If MsgBox("Do you want to save?", vbYesNo) = vbYes Then
                cn.Close()
                Call getSupplierId()
                cn.Open()
                If btnCreateNew.Enabled = True And btnEdit.Enabled = False Then 'IF CREATE NEW
                    sql = "INSERT INTO tblsupplier(SupplierID, CompanyName, ContactPerson, PhoneNumber, Address, EquipmentType, DeliveryTerms, PaymentTerms, BankDetails) " &
                           "Values(@SupplierID, @CompanyName, @ContactPerson, @PhoneNumber, @Address, @EquipmentType, @DeliveryTerms, @PaymentTerms, @BankDetails)"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@SupplierID", supplierID)
                        .Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
                        .Parameters.AddWithValue("@ContactPerson", txtContactPerson.Text)
                        .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                        .Parameters.AddWithValue("@Address", txtAddress.Text)
                        .Parameters.AddWithValue("@EquipmentType", txtEquipmentType.Text)
                        .Parameters.AddWithValue("@DeliveryTerms", txtDeliveryTerms.Text)
                        .Parameters.AddWithValue("@PaymentTerms", txtPaymentTerms.Text)
                        .Parameters.AddWithValue("@BankDetails", txtBankDetails.Text)
                        .ExecuteNonQuery()
                    End With

                    MsgBox("Successfully created!", MsgBoxStyle.Information)
                ElseIf btnCreateNew.Enabled = False And btnEdit.Enabled = True Then 'IF EDIT
                    sql = "UPDATE tblsupplier SET CompanyName=@CompanyName, ContactPerson=@ContactPerson, " &
                        "PhoneNumber=@PhoneNumber, Address=@Address, EquipmentType=@EquipmentType, " &
                        "DeliveryTerms=@DeliveryTerms, PaymentTerms=@PaymentTerms, BankDetails=@BankDetails " &
                        "WHERE SupplierID = '" & lblSupplierID.Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@SupplierID", supplierID)
                        .Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
                        .Parameters.AddWithValue("@ContactPerson", txtContactPerson.Text)
                        .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                        .Parameters.AddWithValue("@Address", txtAddress.Text)
                        .Parameters.AddWithValue("@EquipmentType", txtEquipmentType.Text)
                        .Parameters.AddWithValue("@DeliveryTerms", txtDeliveryTerms.Text)
                        .Parameters.AddWithValue("@PaymentTerms", txtPaymentTerms.Text)
                        .Parameters.AddWithValue("@BankDetails", txtBankDetails.Text)
                        .ExecuteNonQuery()
                    End With

                    MsgBox("Successfully updated the data!", MsgBoxStyle.Information)
                End If
                Call loadSuppliers()
                Call clearAll()
                Call disableAll()

                btnCreateNew.Enabled = True

                btnEdit.Enabled = False
                btnSave.Enabled = False
                btnDelete.Enabled = False
                btnCancel.Enabled = False
            End If
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ListView1.SelectedItems.Count > 0 Then
            txtCompanyName.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtBankDetails.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtContactPerson.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtPhoneNumber.Text = ListView1.SelectedItems(0).SubItems(3).Text
            txtAddress.Text = ListView1.SelectedItems(0).SubItems(4).Text
            txtEquipmentType.Text = ListView1.SelectedItems(0).SubItems(5).Text
            txtDeliveryTerms.Text = ListView1.SelectedItems(0).SubItems(6).Text
            txtPaymentTerms.Text = ListView1.SelectedItems(0).SubItems(7).Text
            lblSupplierID.Text = ListView1.SelectedItems(0).SubItems(8).Text
        End If

        btnCreateNew.Enabled = False

        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True

        Call disableAll()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If ListView1.SelectedItems.Count > 0 Then
            If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                cn.Open()
                sql = "DELETE FROM tblsupplier WHERE SupplierID = @item and ContactPerson = '" & txtContactPerson.Text & "'"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@item", lblSupplierID.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Deleted!")
                Call loadSuppliers()
                Call clearAll()
            End If
        Else
            MsgBox("Please select an item to delete!", vbExclamation)
        End If
    End Sub
    Private Sub clearAll()
        txtAddress.Clear()
        txtCompanyName.Clear()
        txtContactPerson.Clear()
        txtDeliveryTerms.Clear()
        txtEquipmentType.Clear()
        txtPaymentTerms.Clear()
        txtPhoneNumber.Clear()
        txtBankDetails.Clear()
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select CompanyName,BankDetails,ContactPerson,PhoneNumber,Address,EquipmentType,DeliveryTerms,PaymentTerms,SupplierID from tblsupplier where CompanyName LIKE ? OR ContactPerson LIKE ?"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function

    Private Sub PopulateListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    Private Sub enableAll()
        txtAddress.Enabled = True
        txtCompanyName.Enabled = True
        txtContactPerson.Enabled = True
        txtDeliveryTerms.Enabled = True
        txtEquipmentType.Enabled = True
        txtPaymentTerms.Enabled = True
        txtPhoneNumber.Enabled = True
        txtBankDetails.Enabled = True
    End Sub

    Private Sub disableAll()
        txtAddress.Enabled = False
        txtCompanyName.Enabled = False
        txtContactPerson.Enabled = False
        txtDeliveryTerms.Enabled = False
        txtEquipmentType.Enabled = False
        txtPaymentTerms.Enabled = False
        txtPhoneNumber.Enabled = False
        txtBankDetails.Enabled = False
    End Sub
    Private Sub getSupplierId()
        cn.Open()
        sql = "SELECT SupplierID FROM tblsupplier WHERE CompanyName = '" & txtCompanyName.Text & "' and ContactPerson = '" & txtContactPerson.Text & "'"
        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            supplierID = dr(0).ToString()
            lblSupplierID.Text = dr(0).ToString()
            dr.Close()
            cn.Close()
        Else
            supplierID = getNextId()
            cn.Close()
        End If
    End Sub

    Private Function getNextId() As Integer
        dr.Close()
        Dim nextID As Integer = 1

        sql = "SELECT MAX(SupplierID) AS lastID FROM tblsupplier"
        cmd = New MySqlCommand(sql, cn)
        Dim result As Object = cmd.ExecuteScalar()

        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            nextID = CInt(result) + 1
        End If

        Return nextID
    End Function

    Private Sub txtSearchSupplierName_TextChanged(sender As Object, e As EventArgs)
        cn.Close()
        Dim dt As DataTable = SearchDatabase(txtSearchSupplierName.Text)
        PopulateListView(dt)
    End Sub
End Class