Public Class frmEnterQuantity
    Public restock As Boolean? = False
    Public reason As Boolean? = False
    Public payment As Boolean? = False
    Public walkin As Boolean? = False

    Public postdatedcheck As Boolean? = False

    Dim restockValue As Integer = 1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If restock Or payment Or walkin Or postdatedcheck Then
            If Not String.IsNullOrWhiteSpace(txtQuantiyProducts.Text) Then
                If restock Then
                    frmRestockProduct.newValue = txtQuantiyProducts.Text
                ElseIf payment Then
                    frmRestockQuotation.payment = txtQuantiyProducts.Text
                ElseIf walkin Then
                    frmAddCustomerWalkin.newValue = txtQuantiyProducts.Text
                ElseIf postdatedcheck Then
                    'frmPaymentInformation.amount = Convert.ToDouble(txtQuantiyProducts.Text)
                End If
            Else
                MsgBox("Please enter a valid amount.", MsgBoxStyle.Critical, "Input Error")
            End If
        ElseIf reason Then

            If Not String.IsNullOrWhiteSpace(txtRejection.Text) Then

                frmRestockQuotation.reasonMSG = txtRejection.Text
            Else
                MsgBox("Please enter a valid reason.", MsgBoxStyle.Critical, "Input Error")
            End If
        End If
        Me.Close()
    End Sub

    Private Sub frmEnterQuantity_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            restock = Nothing
            reason = Nothing
            walkin = Nothing
            payment = Nothing
            txtQuantiyProducts.Clear()


            txtRejection.Visible = False
            txtQuantiyProducts.Enabled = True
            btnAdd.Enabled = True
            btnMinus.Enabled = True
        End If
    End Sub

    Private Sub frmEnterQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If reason Then
            lblHeaderTitle.Text = "Reason for Rejection"
            Label1.Text = "Enter reason"
            txtRejection.Visible = True

            txtQuantiyProducts.Visible = False
            btnAdd.Visible = False
            btnMinus.Visible = False

            txtQuantiyProducts.Enabled = False
            btnAdd.Enabled = False
            btnMinus.Enabled = False

        ElseIf restock Then
            lblHeaderTitle.Text = "Restock Item"
            Label1.Text = "Input Quantity"
            txtQuantiyProducts.PlaceholderText = restockValue.ToString
        ElseIf payment Then
            lblHeaderTitle.Text = "Payment"
            Label1.Text = "Input Amount"
            txtRejection.PlaceholderText = "Enter amount of payment"

            txtRejection.Visible = True

            txtQuantiyProducts.Visible = False
            btnAdd.Visible = False
            btnMinus.Visible = False
            txtQuantiyProducts.Enabled = False
            btnAdd.Enabled = False
            btnMinus.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtQuantiyProducts.Text > 0 Then
            restockValue += 1
            txtQuantiyProducts.Text = restockValue
        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If txtQuantiyProducts.Text > 0 Then
            restockValue -= 1
            txtQuantiyProducts.Text = restockValue
        End If
    End Sub

    Private Sub txtQuantiyProducts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantiyProducts.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "."c) Then
            e.Handled = True
        End If
    End Sub
End Class