Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class frmAdminSettings
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Call connection()
        Call loadActivity()
        frmAdminDashboard.Close()
        'Environment.Exit(0)

        frmLoginV2.txtUsername.Clear()
        frmLoginV2.txtPassword.Clear()

        frmLoginV2.ActiveControl = frmLoginV2.txtUsername
        frmLoginV2.Show()
    End Sub
    Private Sub loadActivity()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblactivity(UserID, Username, DateTime, Action) VALUES(@UserID, @Username, @DateTime, @Action)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@UserID", frmLoginV2.userid)
                .Parameters.AddWithValue("@Username", frmLoginV2.username)
                .Parameters.AddWithValue("@DateTime", DateTime.Now)
                .Parameters.AddWithValue("@Action", "LOGOUT")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmAdminSettings(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) 
        'frmPrintBillingInvoiceV2.ShowDialog()
        'frmQuotation.ShowDialog()
        frmPrintSalesInvoice.ShowDialog()
    End Sub
End Class