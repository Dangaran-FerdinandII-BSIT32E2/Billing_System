Imports MySql.Data.MySqlClient

Public Class frmRegister
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Call checkUsername()
        cn.Close()
    End Sub

    Private Sub checkUsername()
        Try
            cn.Open()
            cmd.Parameters.Clear()
            cmd.Connection = cn
            cmd.CommandText = "Select Username from tblusers where Username = @username"
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                MsgBox("Username Exist", MsgBoxStyle.Exclamation)
            Else
                dr.Close()
                Call checkPassword()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmRegister(checkUsername): " & ex.Message)
        Finally
        End Try
    End Sub


    Private Sub checkPassword()
        Try
            cmd.Parameters.Clear()
            If txtPassword.Text <> txtConfirmPass.Text Then
                MsgBox("The passwords do not match. Please try again.", MsgBoxStyle.Exclamation)
            Else
                cmd.Connection = cn
                cmd.CommandText = "Insert into tblusers (FirstName, LastName, Password, Username, Role, Status) values (@FirstName, @LastName, @Password, @Username, @Role, @Status)"
                With cmd
                    .Parameters.AddWithValue("@FirstName", txtFirstname.Text)
                    .Parameters.AddWithValue("@LastName", txtLastname.Text)
                    .Parameters.AddWithValue("@Password", txtPassword.Text)
                    .Parameters.AddWithValue("@Username", txtUsername.Text)
                    .Parameters.AddWithValue("@Role", cboRole.Text)
                    .Parameters.AddWithValue("@Status", "Inactive")
                    .ExecuteNonQuery()
                End With
                MsgBox("Account Recorded!" & vbNewLine & "Please wait for admin approval!", MsgBoxStyle.Information)
                frmLogin.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred in frmRegister(checkPassword): " & ex.Message)
        End Try
    End Sub


    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        frmLogin.Show()
        cn.Close()
        Me.Close()
    End Sub

    Private isFormBeingDragged As Boolean = False
    Private mouseDownX As Integer
    Private mouseDownY As Integer

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isFormBeingDragged = True
            mouseDownX = e.X
            mouseDownY = e.Y
        End If
    End Sub

    Private Sub frmLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isFormBeingDragged = False
        End If
    End Sub

    Private Sub frmLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - mouseDownX)
            temp.Y = Me.Location.Y + (e.Y - mouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        cn.Open()
    End Sub
End Class