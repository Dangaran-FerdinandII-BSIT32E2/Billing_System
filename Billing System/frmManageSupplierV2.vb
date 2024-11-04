Imports MySql.Data.MySqlClient

Public Class frmManageSupplierV2
    Public supplierid As Integer? = Nothing

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Do you want to save?", vbYesNo + vbQuestion) = vbYes Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                Dim filled As Boolean = True

                Dim requiredFields As New Dictionary(Of String, Control) From {
                {"txtCompanyNameSupp", txtCompanyNameSupp},
                {"txtBankDetailsSupp", txtBankDetailsSupp},
                {"txtContactPersonSupp", txtContactPersonSupp},
                {"txtPhoneNumberSupp", txtPhoneNumberSupp},
                {"txtAddress", txtAddress},
                {"txtDeliveryTermsSupp", txtDeliveryTermsSupp}
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
                    If supplierid Is Nothing Then
                        sql = "INSERT INTO tblsupplier(CompanyName, BankDetails, ContactPerson, PhoneNumber, Address, DeliveryTerms) VALUES(@CompanyName, @BankDetails, @ContactPerson, @PhoneNumber, @Address, @DeliveryTerms)"

                    Else
                        sql = "UPDATE tblsupplier SET CompanyName = @CompanyName, BankDetails = @BankDetails, ContactPerson = @ContactPerson, PhoneNumber = @PhoneNumber, Address = @Address, DeliveryTerms = @DeliveryTerms WHERE SupplierID = '" & supplierid & "'"

                    End If
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@CompanyName", txtCompanyNameSupp.Text)
                        .Parameters.AddWithValue("@BankDetails", txtBankDetailsSupp.Text)
                        .Parameters.AddWithValue("@ContactPerson", txtContactPersonSupp.Text)
                        .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumberSupp.Text)
                        .Parameters.AddWithValue("@Address", txtAddress.Text)
                        .Parameters.AddWithValue("@DeliveryTerms", txtDeliveryTermsSupp.Text)
                        .ExecuteNonQuery()
                    End With
                    Call loadActivity()
                    MsgBox("Supplier successfully saved!", MsgBoxStyle.Information, "Supplier Insert")
                    Call frmManageSupplierProduct.loadSuppliers()
                    supplierid = Nothing
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox("An error occurred frmManageSupplierV2(btnSave_Click): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnCancelSupp_Click(sender As Object, e As EventArgs) Handles btnCancelSupp.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
            txtCompanyNameSupp.Clear()
            txtBankDetailsSupp.Clear()
            txtContactPersonSupp.Clear()
            txtPhoneNumberSupp.Clear()
            txtAddress.Clear()
            txtDeliveryTermsSupp.Clear()
            supplierid = Nothing
            Me.Close()
        End If
    End Sub

    Private Sub frmManageSupplierV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        If supplierid IsNot Nothing Then
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
                    txtAddress.Text = dr("Address").ToString
                    txtCompanyNameSupp.Text = dr("CompanyName").ToString
                    txtBankDetailsSupp.Text = dr("BankDetails").ToString
                    txtContactPersonSupp.Text = dr("ContactPerson").ToString
                    txtDeliveryTermsSupp.Text = dr("DeliveryTerms").ToString
                    txtPhoneNumberSupp.Text = dr("PhoneNumber").ToString
                End If
            Catch ex As Exception
                MsgBox("An error occurred frmManageSupplierV2(frmManageSupplierV2_Load): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        Else
            txtCompanyNameSupp.Clear()
            txtBankDetailsSupp.Clear()
            txtContactPersonSupp.Clear()
            txtPhoneNumberSupp.Clear()
            txtAddress.Clear()
            txtDeliveryTermsSupp.Clear()
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
                .Parameters.AddWithValue("@Action", "SAVED SUPPLIER " + txtCompanyNameSupp.Text)
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
    Private Sub frmClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            txtCompanyNameSupp.Clear()
            txtBankDetailsSupp.Clear()
            txtContactPersonSupp.Clear()
            txtPhoneNumberSupp.Clear()
            txtAddress.Clear()
            txtDeliveryTermsSupp.Clear()
        End If
    End Sub
End Class