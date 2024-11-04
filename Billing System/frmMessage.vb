Imports MySql.Data.MySqlClient
Public Class frmMessage
    Public inquiry As String
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Call loadActivity()
        Me.Close()
    End Sub

    Private Sub frmMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblinquiry WHERE InquiryID = '" & inquiry & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtName.Text = dr("ContactName").ToString
                txtCompanyName.Text = dr("CompanyName").ToString
                txtEmailorPhone.Text = dr("ContactEmail").ToString
                txtMessage.Text = dr("ContactMessage").ToString
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmMessage(frmMessage_Load): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub frmMessage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            txtName.Clear()
            txtCompanyName.Clear()
            txtEmailorPhone.Clear()
            txtMessage.Clear()
            inquiry = Nothing
            frmManageInquiry.btnConfirm.Enabled = False
            frmManageInquiry.btnShow.Enabled = False
            frmManageInquiry.btnDelete.Enabled = False
        End If
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
                .Parameters.AddWithValue("@Action", "CHECK MESSAGE INQUIRY")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmMessage(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class