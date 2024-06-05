Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private isFormBeingDragged As Boolean = False
    Private mouseDownX As Integer
    Private mouseDownY As Integer

    Private Sub lblRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegister.LinkClicked
        frmRegister.Show()
        cn.Close()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

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

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            cn.Open()
            cmd.Parameters.Clear()
            cmd.Connection = cn
            cmd.CommandText = "Select Username,Role from tblusers where Username= @username and Password = @password and Status='Active'"
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                frmAdminDashboard.lblRole.Text = dr("Role").ToString()
                frmAdminDashboard.lblUsername.Text = dr("Username").ToString
                MsgBox("Logging In!", MsgBoxStyle.Information)
                frmAdminDashboard.ShowDialog()
                dr.Close()
            Else
                MsgBox("Account Still Inactive" & vbNewLine & "Please Contact your Admin for Account Activation", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmLogin(btnLogin): " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
End Class
