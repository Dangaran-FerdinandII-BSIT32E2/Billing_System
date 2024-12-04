Public Class frmEnterQuantity
    Public restock As Boolean? = False
    Public reason As Boolean? = False
    Public payment As Boolean? = False
    Public walkin As Boolean? = False

    Public postdatedcheck As Boolean? = False
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If restock Or payment Or walkin Or postdatedcheck Then
            If String.IsNullOrWhiteSpace(txtQuantiyProducts.Text) AndAlso IsNumeric(txtQuantiyProducts.Text) Then
                If restock Then
                    frmRestockProduct.newValue = txtQuantiyProducts.Text
                ElseIf payment Then
                    frmRestockQuotation.payment = txtQuantiyProducts.Text
                ElseIf walkin Then
                    frmAddCustomerWalkin.newValue = txtQuantiyProducts.Text
                ElseIf postdatedcheck Then
                    frmPaymentInformation.amount = Convert.ToDouble(txtQuantiyProducts.Text)
                End If
            Else
                MsgBox("Please enter a valid amount.", MsgBoxStyle.Critical, "Input Error")
            End If
        ElseIf reason Then

            If Not String.IsNullOrWhiteSpace(txtQuantiyProducts.Text) Then

                frmRestockQuotation.reasonMSG = txtQuantiyProducts.Text
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
        End If
    End Sub

    Private Sub frmEnterQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If reason Then
            lblHeaderTitle.Text = "Reason for Rejection"
            Label1.Text = "Enter reason"
            txtQuantiyProducts.PlaceholderText = "Enter reason for rejecting quotation"

        ElseIf restock Then
            lblHeaderTitle.Text = "Restock Item"
            Label1.Text = "Input Quantity"
            txtQuantiyProducts.PlaceholderText = "Enter quantity of product"
        ElseIf payment Then
            lblHeaderTitle.Text = "Payment"
            Label1.Text = "Input Amount"
            txtQuantiyProducts.PlaceholderText = "Enter amount of payment"
        End If
    End Sub
End Class