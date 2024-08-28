Imports System.Data.OleDb
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient
Public Class frmLoginV2

    Private Sub frmLoginV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call callConnection()
    End Sub
    Public Sub callConnection()
        Call connection()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        frmRegisterV2.TopLevel = False
        pnl_frmLogin.Controls.Add(frmRegisterV2)
        frmRegisterV2.BringToFront()
        frmRegisterV2.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            cn.Open()

            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtUsername", txtUsername},
            {"txtPassword", txtPassword}
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
                sql = "SELECT Username, Role, Password FROM tblusers WHERE Username =  @username AND Password = @password AND Status = 'Active'"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@username", txtUsername.Text)
                    .Parameters.AddWithValue("@password", txtPassword.Text)
                    .ExecuteNonQuery()
                End With

                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    frmAdminDashboard.lblRole.Text = dr("Role").ToString()
                    frmAdminDashboard.lblUsername.Text = dr("Username").ToString
                    MsgBox("Logging In!", MsgBoxStyle.Information)
                    frmAdminDashboard.ShowDialog()
                    dr.Close()
                Else
                    MsgBox("Account does not exist! Please contact the administrator.", MsgBoxStyle.Critical, "Error in Login!")
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmLogin(btnLogin): " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
End Class