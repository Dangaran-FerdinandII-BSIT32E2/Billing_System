Imports MySql.Data.MySqlClient
Public Class frmAddNewCustomer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        MsgBox(isEmail(txtEmail.Text))
        MsgBox(isNumber(txtPhoneNumber.Text))

        If Not isEmail(txtEmail.Text.Trim) Then
            MsgBox("Please enter a valid email address.", MsgBoxStyle.Critical, "Email Error")
            Exit Sub
        End If

        If Not isNumber(txtPhoneNumber.Text).ToString.Length = 12 Then
            MsgBox("Please enter a valid phone number.", MsgBoxStyle.Critical, "Number Error")
            Exit Sub
        End If


        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
        {"txtCompanyName", txtName},
        {"txtAddressName", txtPhoneNumber},
        {"txtDeliveryAddress", txtEmail},
        {"txtContactPerson", txtContactPerson}
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
                If MsgBox("Do you want to save?", vbQuestion + vbYesNo) = vbYes Then
                    frmManageSalesV2.txtCompanyName.Text = txtName.Text
                    frmManageSalesV2.phoneNumber = txtPhoneNumber.Text
                    frmManageSalesV2.email = txtEmail.Text
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManagePOS(btnInsert_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Function isEmail(email As String) As Boolean
        Try
            If String.IsNullOrWhiteSpace(email) Then
                Return False
            End If

            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function isNumber(phoneNumber As String) As String
        Try
            Dim cleanNumber As String = System.Text.RegularExpressions.Regex.Replace(phoneNumber, "[\s\-\(\)]", "")
            cleanNumber = String.Join("", cleanNumber.Where(Function(c) Char.IsDigit(c)))

            If cleanNumber.StartsWith("0") Then
                cleanNumber = "63" & cleanNumber.Substring(1)
            ElseIf cleanNumber.StartsWith("+63") Then
                cleanNumber = "63" & cleanNumber.Substring(3)
            End If

            If String.IsNullOrWhiteSpace(phoneNumber) Then
                Return False
            End If

            Return cleanNumber

            'Return System.Text.RegularExpressions.Regex.IsMatch(cleanNumber, "^(\+63|0)9\d{9}$")
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub frmAddNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub frmAddNewCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            txtPhoneNumber.Clear()
            txtContactPerson.Clear()
            txtEmail.Clear()
            txtName.Clear()
        End If
    End Sub
End Class