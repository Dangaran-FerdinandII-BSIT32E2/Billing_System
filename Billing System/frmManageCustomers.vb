Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class frmManageCustomers
    Private Sub frmManageCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        loadCustomers()
        Call disableAll()
        btnCreateNew.Enabled = True

        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub loadCustomers()
        Try
            cn.Open()
            sql = "SELECT * FROM tblcustomer"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("CompanyName").ToString())
                x.SubItems.Add(dr("LastName").ToString())
                x.SubItems.Add(dr("FirstName").ToString())
                x.SubItems.Add(dr("PhoneNumber").ToString())
                x.SubItems.Add(dr("Email").ToString())
                x.SubItems.Add(dr("Status").ToString())
                x.SubItems.Add(dr("CustomerID").ToString())
                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmManageCustomer(ListViewLoading): " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True

        btnEdit.Enabled = False

        Call clearAll()
        Call enableAll()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnDelete.Enabled = True

        btnCreateNew.Enabled = False

        Call enableAll()
    End Sub

    Private Sub createCustomer()
        sql = "INSERT INTO tblcustomer(LastName,FirstName,PhoneNumber,Email,CompanyName,Status) VALUES (@LastName, @FirstName, @PhoneNumber, @Email, @CompanyName, @Status)"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
            .Parameters.AddWithValue("@Email", txtEmailAddress.Text)
            .Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
            .Parameters.AddWithValue("@Status", cboStatus.Text)

            .ExecuteNonQuery()
        End With
        MsgBox("Successfully created!", MsgBoxStyle.Information)
    End Sub

    Private Sub updateCustomer()
        sql = "UPDATE tblcustomer SET LastName=@LastName, FirstName=@FirstName, PhoneNumber=@PhoneNumber, Email=@Email, CompanyName=@CompanyName, Status=@Status where CustomerID='" & lblCustomerID.Text & "'"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@CustomerID", lblCustomerID.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
            .Parameters.AddWithValue("@Email", txtEmailAddress.Text)
            .Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
            .Parameters.AddWithValue("@Status", cboStatus.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Successfully updated the data!", MsgBoxStyle.Information)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Do you want to save?", vbYesNo) = vbYes Then
                cn.Open()
                If btnCreateNew.Enabled = True And btnEdit.Enabled = False Then 'IF CREATE NEW
                    Call createCustomer()
                ElseIf btnCreateNew.Enabled = False And btnEdit.Enabled = True Then 'IF EDIT
                    Call updateCustomer()
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageCustomer(btnSave): " & ex.Message)
        Finally
            cn.Close()
        End Try
        Call loadCustomers()
        Call clearAll()

        btnCreateNew.Enabled = True

        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If lblCustomerID.Text IsNot Nothing Then
                If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                    cn.Open()
                    sql = "DELETE from tblcustomer where CustomerID = @item"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@item", lblCustomerID.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Deleted!")
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageCustomer(btnDelete): " & ex.Message)
        Finally
            cn.Close()
        End Try
        Call loadCustomers()
        Call clearAll()
    End Sub

    Private Sub clearAll()
        cboStatus.SelectedIndex = -1
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhoneNumber.Clear()
        txtEmailAddress.Clear()
        txtCompanyName.Clear()
    End Sub

    Private Sub enableAll()
        cboStatus.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtPhoneNumber.Enabled = True
        txtEmailAddress.Enabled = True
        txtCompanyName.Enabled = True
    End Sub

    Private Sub disableAll()
        cboStatus.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtPhoneNumber.Enabled = False
        txtEmailAddress.Enabled = False
        txtCompanyName.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCreateNew.Enabled = True

        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False

        Call clearAll()
        Call disableAll()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            lblCustomerID.Text = ListView1.SelectedItems(0).SubItems(6).Text
        End If

        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
        btnCreateNew.Enabled = False
    End Sub

    Private Sub lblCustomerID_TextChanged(sender As Object, e As EventArgs) Handles lblCustomerID.TextChanged
        If String.IsNullOrWhiteSpace(lblCustomerID.Text) Then Return
        Try
            cn.Open()
            sql = "SELECT LastName, FirstName, PhoneNumber, Email, CompanyName, Status FROM tblcustomer WHERE CustomerID = @CustomerID"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@CustomerID", lblCustomerID.Text)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtLastName.Text = dr("LastName").ToString()
                txtFirstName.Text = dr("FirstName").ToString()
                txtPhoneNumber.Text = dr("PhoneNumber").ToString()
                txtEmailAddress.Text = dr("Email").ToString()
                txtCompanyName.Text = dr("CompanyName").ToString()
                cboStatus.Text = dr("Status").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmManageCustomer(lblCustomerIDTextChange): " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
        cn.Close()
        Dim dt As DataTable = SearchDatabase(txtSearchCustomer.Text)
        PopulateListView(dt)
    End Sub

    Private Sub PopulateListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select CompanyName,LastName,FirstName,PhoneNumber,Email,Status,CustomerID from tblcustomer where CompanyName LIKE ? OR LastName LIKE ?"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.Add(New MySqlParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New MySqlParameter("searchTerm2", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function
End Class
