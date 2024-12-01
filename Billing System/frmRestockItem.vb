Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmRestockItem

    Public restock As Boolean = False
    Public reason As Boolean = False
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmRestockItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If Not IsNumeric(String.IsNullOrWhiteSpace(txtQuantiyProducts.Text)) Then
            If MsgBox("Do you want to continue?", vbYesNo + vbQuestion) = vbYes Then
                If restock Then
                    frmRestockProduct.ListView1.SelectedItems(0).SubItems(2).Text = txtQuantiyProducts.Text
                ElseIf reason Then

                End If

                Me.Close()
            End If
        Else
            MsgBox("Please enter a valid input.", MsgBoxStyle.Critical, "Input Error")
        End If
    End Sub

    Private Sub frmRestockItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            restock = False
            reason = False
        End If
    End Sub
End Class