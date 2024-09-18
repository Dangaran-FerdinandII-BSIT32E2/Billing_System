Imports System.Data.OleDb
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class frmManageBilling
    Private Sub frmManageBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadBilling()
        dtpDate.Text = Now.ToString()
    End Sub
    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs)
        frmListCompany.ShowDialog()
    End Sub
    Public Sub loadBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM qryorder WHERE OrderID IN (SELECT OrderID FROM tblOrder WHERE CustomerID = '" & lblCustID.Text & "' AND OrderID = '" & lblOrderListID.Text & "') And Availability = 1 And Status = 1"
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
                x.SubItems.Add(dr("Amount").ToString())
                x.SubItems.Add(dr("OrderID").ToString())
                x.SubItems.Add(dr("OrderList").ToString())
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

    Private Sub lblCustID_TextChanged(sender As Object, e As EventArgs)
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView1.SelectedItems.Count > 0 Then
                lblOrderID.Text = ListView1.SelectedItems(0).SubItems(5).Text
                lblProductID.Text = ListView1.SelectedItems(0).SubItems(6).Text
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(ListView1_SelectedIndexChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
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
            zzzz.Text = 0
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If zzzz.Text IsNot Nothing Then
                If MsgBox("Do you want to delete the order?", vbYesNo) = vbYes Then
                    sql = "DELETE FROM tblorder WHERE OrderID = @orderid"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@orderid", lblOrderID.Text)
                    cmd.ExecuteNonQuery()

                    Call loadBilling()

                    MsgBox("Successfully deleted!", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(btnDelete): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub Printbtn_Click(sender As Object, e As EventArgs)
        Try
            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
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
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If
                sql = "INSERT INTO tblbilling(CustomerID, SalesMan, Terms, ProductOrder, DatePrinted, Remarks) VALUES(@CustomerID, @SalesMan, @Terms, @ProductOrder, @DatePrinted, @Remarks)"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@CustomerID", lblCustID.Text)
                    .Parameters.AddWithValue("@SalesMan", cboSalesman.Text)
                    .Parameters.AddWithValue("@Terms", txtTerms.Text)
                    .Parameters.AddWithValue("@ProductOrder", txtPONo.Text)
                    .Parameters.AddWithValue("@DatePrinted", dtpDate.Value)
                    .Parameters.AddWithValue("@Remarks", "0")
                    .ExecuteNonQuery()
                End With

                Call printBilling()

                MsgBox("Sucessfully saved billing invoice!", MsgBoxStyle.Information, "Billing Invoice")
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

            sql = "SELECT * FROM tblcustomer WHERE CustomerID = '" & lblCustID.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                'left side
                frmPrintInvoice.lblSoldTo.Text = dr("CompanyName").ToString
                frmPrintInvoice.lblAddress.Text = dr("Address").ToString
                frmPrintInvoice.lblDelivery.Text = dr("Delivery").ToString
                frmPrintInvoice.lblBusStyle.Text = dr("CompanyName").ToString ' business style
            End If

            frmPrintInvoice.lblCustID.Text = lblCustID.Text
            frmPrintInvoice.lblTerms.Text = txtTerms.Text
            frmPrintInvoice.lblTIN.Text = txtTIN.Text
            frmPrintInvoice.lblSalesman.Text = cboSalesman.Text
            frmPrintInvoice.lblPuchaseNo.Text = txtPONo.Text
            frmPrintInvoice.lblDate.Text = dtpDate.Value.ToString

            For Each listitem As ListViewItem In ListView1.Items 'includes OrderID on SubItem 5 OrderList sub item 6 productid sub item 7
                Dim X As ListViewItem = listitem.Clone()
                frmPrintInvoice.ListView1.Items.Add(X)
            Next

            frmPrintInvoice.ShowDialog()
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(printBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub saveBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each order As ListViewItem In ListView1.Items
                sql = "INSERT INTO tblbillinvoice(BillingID, OrderID, ProductID) VALUES(@BillingID, @OrderID, @ProductID)"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@BillingID", lblBillingID.Text)
                    .Parameters.AddWithValue("@OrderID", order.SubItems(5).Text)
                    .Parameters.AddWithValue("@ProductID", order.SubItems(7).Text)
                    .ExecuteNonQuery()
                End With
            Next
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(saveBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmManageCollection.Show()
    End Sub
End Class