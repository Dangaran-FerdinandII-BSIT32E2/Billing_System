Imports MySql.Data.MySqlClient
Public Class frmManageRentalV2

    Dim trueadjustedvalue As String
    Dim adjustedValue As Double
    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        frmManagePOS.isRental = True
        frmManagePOS.ShowDialog()
    End Sub

    Private Sub txtCompanyName_TextChanged(sender As Object, e As EventArgs) Handles txtCompanyName.TextChanged
        txtBusinessStyle.Text = txtCompanyName.Text
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtCompanyName", txtCompanyName},
            {"txtAddress", txtAddress},
            {"txtDeliveryAddress", txtDeliveryAddress},
            {"txtBusinessStyle", txtBusinessStyle},
            {"txtPONo", txtPONo},
            {"txtTerms", txtTerms},
            {"cboSalesman", cboSalesman},
            {"dtpDate", dtpDate}
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
                If cboAdjust.SelectedIndex <> 0 Then
                    Dim adjustedValue As Double
                    If txtAmount.TextLength > 0 Then
                        frmPrintSalesInvoiceV2.lblAdjustPrice.Visible = True
                        frmPrintSalesInvoiceV2.lblAdjustPrice.Visible = True
                        If cboAdjust.Text = "Add Discount" Then
                            If Double.TryParse(txtAmount.Text.Replace("%", ""), adjustedValue) AndAlso adjustedValue > 0 AndAlso adjustedValue <= 100 Then
                                frmPrintSalesInvoiceV2.lblAdjustPrice.Text = "Discount:"
                                frmPrintSalesInvoiceV2.priceadjust = adjustedValue
                                Call printBilling()
                            Else
                                MsgBox("Invalid discount!", MsgBoxStyle.Critical)
                            End If
                        ElseIf cboAdjust.Text = "Add Mark Up" Then
                            If Double.TryParse(txtAmount.Text.Replace("%", ""), adjustedValue) AndAlso adjustedValue > 0 AndAlso adjustedValue <= 100 Then
                                frmPrintSalesInvoiceV2.lblAdjustPrice.Text = "Mark Up:"
                                frmPrintSalesInvoiceV2.priceadjust = adjustedValue
                                Call printBilling()
                            Else
                                MsgBox("Invalid markup!", MsgBoxStyle.Critical)
                            End If
                        End If
                    Else
                        frmPrintSalesInvoiceV2.lblAdjustPrice.Visible = False
                        Call printBilling()
                    End If
                Else
                    frmPrintSalesInvoiceV2.lblAdjustPrice.Visible = False
                    Call printBilling()
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageRentalV2(btnPrint): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub printBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If cboFormat.Text = "In Percent" Then
                frmPrintSalesInvoiceV2.format = True
                trueadjustedvalue = (adjustedValue / 100).ToString("P")
            Else
                frmPrintSalesInvoiceV2.format = False
                trueadjustedvalue = adjustedValue
            End If


            frmPrintSalesInvoiceV2.Label1.Text = "RENTAL SALES INVOICE"
            'left side
            frmPrintSalesInvoiceV2.lblSoldTo.Text = txtCompanyName.Text
            frmPrintSalesInvoiceV2.lblAddress.Text = txtAddress.Text
            frmPrintSalesInvoiceV2.lblDelivery.Text = txtDeliveryAddress.Text
            frmPrintSalesInvoiceV2.lblBusStyle.Text = txtCompanyName.Text

            frmPrintSalesInvoiceV2.custid = lblCustID.Text
            frmPrintSalesInvoiceV2.billid = getBillingID()
            frmPrintSalesInvoiceV2.lblTerms.Text = txtTerms.Text
            frmPrintSalesInvoiceV2.lblTIN.Text = txtTIN.Text
            frmPrintSalesInvoiceV2.lblSalesman.Text = cboSalesman.Text
            frmPrintSalesInvoiceV2.lblPONo.Text = txtPONo.Text
            frmPrintSalesInvoiceV2.lblDate.Text = dtpDate.Value.ToString

            frmPrintSalesInvoiceV2.textamount = trueadjustedvalue
            frmPrintSalesInvoiceV2.printdate = dtpDate.Value.ToString
            frmPrintSalesInvoiceV2.adjusteddate = dtpDate.Value.AddDays(5).ToString

            For Each listitem As ListViewItem In ListView1.Items 'includes OrderID on SubItem 5 OrderList sub item 6 productid sub item 7
                Dim X As ListViewItem = listitem.Clone()
                frmPrintSalesInvoiceV2.ListView1.Items.Add(X)
            Next

            frmPrintSalesInvoiceV2.ShowDialog()
        Catch ex As Exception
            MsgBox("An error occurred frmManageRentalV2(printBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Function getBillingID() As Integer
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim nextID As Integer = 0
            sql = "SELECT BillingID FROM tblbilling ORDER BY BillingID DESC LIMIT 1"
            cmd = New MySqlCommand(sql, cn)

            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Dim lastBillingID As String = result.ToString()
                Dim lastNumber As Integer
                If Integer.TryParse(lastBillingID, lastNumber) Then
                    nextID = (lastNumber + 1).ToString()
                End If
            Else
                nextID = "1"
            End If
            Return nextID
        Catch ex As Exception
            MsgBox("An error occurred frmManageRentalV2(getBillingID): " & ex.Message)
            Return 0
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

        End Try
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then

        End If
    End Sub

    Private Sub cboAdjust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAdjust.SelectedIndexChanged
        If cboAdjust.SelectedIndex <> 0 Then
            txtAmount.Enabled = True
            cboFormat.Visible = True
            cboFormat.Enabled = True
        Else
            txtAmount.Clear()
            txtAmount.Enabled = False
            cboFormat.Visible = False
            cboFormat.Enabled = False
        End If
    End Sub

    Private Sub cboFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFormat.SelectedIndexChanged
        If cboFormat.Text = "In Percent" Then
            frmPrintSalesInvoiceV2.format = True
        Else
            frmPrintSalesInvoiceV2.format = False
        End If
    End Sub
End Class