Imports MySql.Data.MySqlClient
Public Class frmAddNewCustomer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
    'Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs)
    '    frmManagePOS.ShowDialog()
    'End Sub

    'Private Sub frmAddNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub btnInsert_Click(sender As Object, e As EventArgs)
    '    Try
    '        If cn.State <> ConnectionState.Open Then
    '            cn.Open()
    '        End If

    '        Dim filled As Boolean = True

    '        Dim requiredFields As New Dictionary(Of String, Control) From {
    '        {"txtCompanyName", txtName},
    '        {"txtAddressName", txtAddressName},
    '        {"txtDeliveryAddress", txtDeliveryAddress}
    '    }

    '        For Each fieldName_controlPair In requiredFields
    '            Dim control As Control = fieldName_controlPair.Value

    '            If control.Text.Trim = "" Then
    '                ErrorProvider1.SetError(control, "This field is required.")
    '                filled = False
    '                Exit For
    '            Else
    '                ErrorProvider1.SetError(control, "")
    '            End If
    '        Next

    '        If filled Then
    '            If ListView1.Items.Count > 0 Then
    '                frmManageSalesV2.txtCompanyName.Text = txtName.Text
    '                frmManageSalesV2.txtBusinessStyle.Text = txtName.Text
    '                frmManageSalesV2.txtAddress.Text = txtAddressName.Text
    '                frmManageSalesV2.txtDeliveryAddress.Text = txtDeliveryAddress.Text

    '                For Each listitem As ListViewItem In ListView1.Items
    '                    Dim X As ListViewItem = listitem.Clone()
    '                    frmManageSalesV2.ListView1.Items.Add(X)
    '                Next
    '                Me.Close()
    '            Else
    '                MsgBox("There are no items in cart. Please add items.", MsgBoxStyle.Information, "Cart Error")
    '            End If

    '        End If
    '    Catch ex As Exception
    '        MsgBox("An error occurred frmManagePOS(btnInsert_Click): " & ex.Message)
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub

    'Private Sub btnCancel_Click(sender As Object, e As EventArgs)
    '    If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
    '        ListView1.Items.Clear()
    '        txtName.Clear()
    '        txtDeliveryAddress.Clear()
    '        txtAddressName.Clear()

    '        btnCancel.Enabled = False
    '    End If
    'End Sub
End Class