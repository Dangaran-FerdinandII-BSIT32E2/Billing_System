Imports MySql.Data.MySqlClient

Public Class frmQuotationComment
    Public orderid As String
    Private Sub frmQuotationComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadComment()
    End Sub
    Private Sub loadComment()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT Lastname, FirstName,CompanyName, PhoneNumber, Email, MIN(Comment) AS Comment FROM qryorder WHERE OrderID = '" & orderid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                txtName.Text = (dr("LastName").ToString & ", " & dr("FirstName").ToString)
                txtCompanyName.Text = dr("CompanyName").ToString
                txtPhone.Text = dr("PhoneNumber").ToString
                txtEmail.Text = dr("Email").ToString
                txtComment.Text = If(IsDBNull(dr("Comment")), "*NO COMMENT AVAILABLE*", dr("Comment").ToString)

                If IsDBNull(dr("Comment")) Then
                    txtComment.DisabledState.ForeColor = Color.Red
                Else
                    txtComment.DisabledState.ForeColor = Color.DimGray
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmQuotationComment(loadComment): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

    Private Sub frmQuotationComment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.FormOwnerClosing Then
            txtName.Clear()
            txtComment.Clear()
            txtCompanyName.Clear()
            txtPhone.Clear()
            txtEmail.Clear()
        End If
    End Sub
End Class