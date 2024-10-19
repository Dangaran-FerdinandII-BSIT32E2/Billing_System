Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class frmManageInquiry
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click, ListView1.DoubleClick
        frmMessage.inquiry = ListView1.SelectedItems(0).SubItems(4).Text
        frmMessage.ShowDialog()
    End Sub

    Private Sub frmManageInquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInquiries()
    End Sub

    Private Sub loadInquiries()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblinquiry"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ContactName").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(dr("Date").ToString())
                x.SubItems.Add(dr("Status").ToString())
                x.SubItems.Add(dr("InquiryID").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmManageInquiry(loadInquiries): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblinquiry SET Status=@Status WHERE InquiryID = '" & ListView1.SelectedItems(0).SubItems(4).Text & "'"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Status", True)
            MsgBox("Done!", MsgBoxStyle.Information, "Confirm Status")
            cmd.ExecuteNonQuery()
            Call loadInquiries()
        Catch ex As Exception
            MsgBox("An error occurred frmManageInquiry(btnConfirm_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            btnConfirm.Enabled = True
            btnShow.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Do you want to delete?", vbYesNo + vbQuestion) = vbYes Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "DELETE FROM tblinquiry WHERE InquiryID = @item"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@item", ListView1.SelectedItems(0).SubItems(4).Text)
                cmd.ExecuteNonQuery()
                MsgBox("Deleted!", MsgBoxStyle.Information, "Delete Status")
                Call loadInquiries()
                Call frmAdminDashboard.loadNotification()
            Catch ex As Exception
                MsgBox("An error occurred frmManageInquiry(btnConfirm_Click): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub
End Class