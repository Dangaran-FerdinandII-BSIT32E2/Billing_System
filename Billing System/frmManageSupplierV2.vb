Imports MySql.Data.MySqlClient

Public Class frmManageSupplierV2
    Public supplierid As Integer = Nothing

    Private Sub frmManageSupplierV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation()
    End Sub

    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblsupplier WHERE SupplierID = '" & supplierid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then

            End If
        Catch ex As Exception
            MsgBox("An Error occurred frmManageSupplierV2(loadInformation): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class