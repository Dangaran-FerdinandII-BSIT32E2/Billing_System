Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient

Public Class frmListofSuppliers
    Dim supplierid As Integer? = Nothing
    Private Sub frmListofSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSuppliers()
    End Sub

    Private Sub loadSuppliers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM tblsupplier"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("CompanyName").ToString())
                x.SubItems.Add(dr("BankDetails").ToString())
                x.SubItems.Add(dr("ContactPerson").ToString())
                x.SubItems.Add(dr("PhoneNumber").ToString())
                x.SubItems.Add(dr("Address").ToString())
                x.SubItems.Add(dr("DeliveryTerms").ToString())
                x.SubItems.Add(dr("SupplierID").ToString())

                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmListofSuppliers(loadSuppliers): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            supplierid = ListView1.SelectedItems(0).SubItems(6).Text
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "Select SupplierID, CompanyName from tblsupplier where SupplierID=@SupplierID"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("SupplierID", supplierid)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                'frmManageProducts.txtSupplier.Text = dr("CompanyName").ToString()
                frmManageProducts.supplierid = dr("SupplierID").ToString()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmListofSuppliers(lblSupplierIDTextChange): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class