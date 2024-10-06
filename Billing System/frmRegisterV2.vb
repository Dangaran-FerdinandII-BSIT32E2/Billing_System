Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmRegisterV2
    Private Sub frmRegisterV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Call callBack()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtFirstname", txtFirstname},
            {"txtLastname", txtLastname},
            {"txtPassword", txtPassword},
            {"txtConfirmPassword", txtConfirmPassword},
            {"txtUsername", txtUsername},
            {"cboRole", cboRole}
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
                sql = "INSERT INTO tblusers(FirstName, LastName, Password, Username, Role, Status) VALUES(@FirstName, @LastName, @Password, @Username, @Role, @Status)"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@FirstName", txtFirstname.Text)
                    .Parameters.AddWithValue("@LastName", txtLastname.Text)
                    .Parameters.AddWithValue("@Password", txtPassword.Text)
                    .Parameters.AddWithValue("@Username", txtUsername.Text)
                    .Parameters.AddWithValue("@Role", cboRole.Text)
                    .Parameters.AddWithValue("@Status", "Inactive")
                    .ExecuteNonQuery()
                End With
                MsgBox("Account Recorded!" & vbNewLine & "Please wait for admin approval.", MsgBoxStyle.Information)
                Call callBack()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmRegister(btnCreateAccount): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub callBack()
        frmLoginV2.Show()
        Me.Close()
        Call frmLoginV2.callConnection()
    End Sub
End Class