Imports System.Data.OleDb
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient
Public Class frmManageUsers
    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadUsers()
    End Sub
    Private Sub loadUsers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM tblusers"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("UserID").ToString())
                x.SubItems.Add(dr("FirstName").ToString())
                x.SubItems.Add(dr("LastName").ToString())
                x.SubItems.Add(dr("Password").ToString())
                x.SubItems.Add(dr("Username").ToString())
                x.SubItems.Add(dr("Role").ToString())
                x.SubItems.Add(dr("Status").ToString())
                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(loadUsers): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtUserID.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If

        btnCreateNew.Enabled = False

        btnEdit.Enabled = True
        btnCancel.Enabled = True
        btnDelete.Enabled = True
    End Sub
    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM tblusers WHERE UserID = '" & txtUserID.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtFirstName.Text = dr("FirstName").ToString
                txtLastName.Text = dr("LastName").ToString
                txtUsername.Text = dr("Username").ToString
                cboRole.Text = dr("Role").ToString
                cboStatus.Text = dr("Status").ToString
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(txtUserID_TextChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub enableAlltxt()
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        cboRole.Enabled = True
        cboStatus.Enabled = True
    End Sub
    Private Sub disableAlltxt()
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        cboRole.Enabled = False
        cboStatus.Enabled = False
    End Sub

    Private Sub clearAll()
        txtUserID.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True

        txtUserID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()

        txtUserID.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False

        cboRole.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
    End Sub
    Private Sub btnOkay_Click_1(sender As Object, e As EventArgs) Handles btnOkay.Click
        TabControl2.SelectedTab = TabPage1
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        Call enableAlltxt()

        btnCancel.Enabled = True
        btnSave.Enabled = True
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call enableAlltxt()

        btnSave.Enabled = True
        btnDelete.Enabled = False
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearAll()
        Call disableAlltxt()
        btnCreateNew.Enabled = True

        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtFirstname", txtFirstName},
            {"txtLastname", txtLastName},
            {"txtPassword", txtPassword},
            {"txtUsername", txtUsername},
            {"cboRole", cboRole},
            {"cboStatus", cboStatus}
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

                    If btnCreateNew.Enabled = True And btnEdit.Enabled = False Then
                        Call createNew()
                    Else
                        Call edit()
                    End If

                Catch ex As Exception
                    MsgBox("An error occurred frmManageUsers(Saving Users): " & ex.Message)
                Finally
                    Call loadUsers()
                    Call clearAll()
                    Call disableAlltxt()
                    btnCreateNew.Enabled = True

                    btnEdit.Enabled = False
                    btnSave.Enabled = False
                    btnDelete.Enabled = False
                    btnCancel.Enabled = False

                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(btnSave): " & ex.Message)
        Finally
        End Try
    End Sub

    Private Sub createNew()
        sql = "INSERT INTO tblusers(FirstName, LastName, Password, Username, Role, Status) VALUES(@FirstName, @LastName, @Password, @Username, @Role, @Status)"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@Password", txtPassword.Text)
            .Parameters.AddWithValue("@Username", txtUsername.Text)
            .Parameters.AddWithValue("@Role", cboRole.Text)
            .Parameters.AddWithValue("@Status", "Inactive")
            .ExecuteNonQuery()
        End With
        MsgBox("Successfully added!", MsgBoxStyle.Information)
    End Sub

    Private Sub edit()
        sql = "UPDATE tblusers SET FirstName=@FirstName, LastName=@LastName, Password=@Password, Username=@Username, Role=@Role, Status=@Status WHERE UserID = '" & txtUserID.Text & "'"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@Password", txtPassword.Text)
            .Parameters.AddWithValue("@Username", txtUsername.Text)
            .Parameters.AddWithValue("@Role", cboRole.Text)
            .Parameters.AddWithValue("@Status", cboStatus.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Successfully updated the user!", MsgBoxStyle.Information)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If txtUserID.Text IsNot Nothing Then
                If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                    sql = "DELETE FROM tblusers WHERE UserID = @userid"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@userid", txtUserID.Text)
                    cmd.ExecuteNonQuery()

                    Call loadUsers()
                    Call clearAll()

                    MsgBox("Successfully deleted!", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(btnDelete): " & ex.Message)
        Finally

            Call disableAlltxt()
            btnCreateNew.Enabled = True

            btnEdit.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = False
            btnCancel.Enabled = False
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class