﻿Imports System.Data.OleDb
Imports System.Runtime.InteropServices.ComTypes
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class frmManageSalesV2

    Public orderid As String
    Dim adjustedValue As Double
    Dim trueadjustedvalue As String
    Private Sub frmManageBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadBilling()
        dtpDate.Text = Now.ToString()
        lblBillingID.Text = getBillingID()
    End Sub
    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        frmListCompany.ShowDialog()
    End Sub
    Public Sub loadBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM qryorder WHERE OrderID IN (SELECT OrderID FROM tblOrder WHERE CustomerID = '" & lblCustID.Text & "' AND OrderID = '" & orderid & "') And Availability = 1 And Status <> 3"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("Quantity").ToString())
                x.SubItems.Add(dr("Unit").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("SellingPrice").ToString())
                x.SubItems.Add("₱ " + dr("Amount").ToString())
                x.SubItems.Add(dr("OrderID").ToString())
                x.SubItems.Add(dr("OrderListID").ToString())
                x.SubItems.Add(dr("ProductID").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An Error occurred frmManageBilling(loadBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub lblCustID_TextChanged(sender As Object, e As EventArgs) Handles lblCustID.TextChanged, MyBase.Load
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblcustomer WHERE CustomerID = '" & lblCustID.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtCompanyName.Text = dr("CompanyName").ToString()
                txtAddress.Text = dr("Address").ToString()
                txtDeliveryAddress.Text = dr("Delivery").ToString()
                txtBusinessStyle.Text = dr("CompanyName").ToString()
                txtTIN.Text = dr("TIN").ToString()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(lblCustID_TextChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView1.SelectedItems.Count > 0 Then
                lblOrderID.Text = ListView1.SelectedItems(0).SubItems(5).Text
                lblOrderListID.Text = ListView1.SelectedItems(0).SubItems(6).Text
                lblProductID.Text = ListView1.SelectedItems(0).SubItems(7).Text
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(ListView1_SelectedIndexChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            If ListView1.SelectedItems.Count > 0 Then
                If MsgBox("Do you want to change total amount?", vbYesNo + vbQuestion) = vbYes Then
                    Dim price As String = InputBox("Enter Amount:", "Amount")

                    ' Handle the scenario when the user cancels or closes the input dialog
                    If price = "" Then
                        Return
                    End If

                    ' Check if input is valid
                    If String.IsNullOrEmpty(price) OrElse Val(price) <= 0 Then
                        MsgBox("Please enter a valid price!", MsgBoxStyle.Critical, "Error in Unit Price")
                        Return
                    End If

                    If Val(price) > 0 Then
                        sql = "UPDATE tblorder SET Amount=@Amount WHERE OrderID = '" & lblOrderID.Text & "'"
                        cmd = New MySqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@Amount", price)
                        cmd.ExecuteNonQuery()

                        If cn.State = ConnectionState.Open Then
                            cn.Close()
                        End If
                        MsgBox("Price updated successfully!")
                    End If
                End If
            Else
                MsgBox("Please select a billing invoice!", MsgBoxStyle.Information, "Updating Billing")
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(btnUpdate): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            Call loadBilling()
            lblOrderID.Text = 0
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then

        End If
    End Sub

    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
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
                    If txtAmount.TextLength > 0 Then
                        frmPrintSalesInvoiceV2.lblAdjustPrice.Visible = True
                        frmPrintSalesInvoiceV2.lblPriceAdjusted.Visible = True
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
                        frmPrintSalesInvoiceV2.lblPriceAdjusted.Visible = False
                        Call printBilling()
                    End If
                Else
                    frmPrintSalesInvoiceV2.lblAdjustPrice.Visible = False
                    frmPrintSalesInvoiceV2.lblPriceAdjusted.Visible = False
                    Call printBilling()
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(btnPrint): " & ex.Message)
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

            'left side
            frmPrintSalesInvoiceV2.lblSoldTo.Text = txtCompanyName.Text
            frmPrintSalesInvoiceV2.lblAddress.Text = txtAddress.Text
            frmPrintSalesInvoiceV2.lblDelivery.Text = txtDeliveryAddress.Text
            frmPrintSalesInvoiceV2.lblBusStyle.Text = txtCompanyName.Text

            frmPrintSalesInvoiceV2.custid = lblCustID.Text
            frmPrintSalesInvoiceV2.billid = lblBillingID.Text
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
            MsgBox("An error occurred frmManageBilling(printBilling): " & ex.Message)
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
            MsgBox("An error occurred frmManageBilling(getBillingID): " & ex.Message)
            Return 0
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

        End Try
    End Function

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

    Private Sub txtCompanyName_TextChanged(sender As Object, e As EventArgs) Handles txtCompanyName.TextChanged
        txtBusinessStyle.Text = txtCompanyName.Text
    End Sub
End Class