Imports MySql.Data.MySqlClient

Public Class frmQuotationComment
    Public orderid As String
    Private Sub frmQuotationComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
    Private Sub loadComment()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            sql = "SELECT * FROM qryorder WHERE OrderID = '" & orderid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtName.Text = (dr("LastName").ToString & ", " & dr("FirstName").ToString)
                txtCompanyName.Text = dr("CompanyName").ToString
                txtPhone.Text = dr("PhoneNumber").ToString
                txtEmail.Text = dr("Email").ToString
                txtComment.Text = dr("Comment").ToString
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmQuotationComment(loadComment): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub clearText()
        txtName.Clear()
        txtComment.Clear()
        txtCompanyName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Call clearText()
        Me.Close()
    End Sub

    Private Sub frmQuotationComment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.FormOwnerClosing Then
            Call clearText()
        End If
    End Sub
End Class