Imports System.Data.OleDb
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient
Public Class frmManageBilling
    Private Sub frmManageBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
    Private Sub btnPrint_Click_1(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmPrintInvoice.ShowDialog()
    End Sub

    Private Sub btnSearchProduct_Click_1(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        frmListProducts.ShowDialog()
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        frmListCompany.ShowDialog()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtCompanyName", txtCompanyName},
            {"txtTerms", txtTerms},
            {"txtPONo", txtPONo},
            {"cboSalesman", cboSalesman},
            {"txtProductName", txtProductName},
            {"txtPrice", txtPrice},
            {"dtpDate", dtpDate},
            {"txtTIN", txtTIN}
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
                Try
                    If cn.State <> ConnectionState.Open Then
                        cn.Open()
                    End If

                    sql = "INSERT INTO tblbilling(CustomerID, SupplierID, ProductID, Quantity, Amount, Terms, ProductOrder, Date, SalesMan, TIN) " &
                        "VALUE(@CustomerID, @SupplierID, @ProductID, @Quantity, @Amount,@Terms, @ProductOrder, @Date, @SalesMan, @TIN)"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@CustomerID", lblCustID.Text)
                        .Parameters.AddWithValue("@SupplierID", lblSuppID.Text)
                        .Parameters.AddWithValue("@ProductID", lblProductID.Text)
                        .Parameters.AddWithValue("@Quantity", lblQty.Text)
                        .Parameters.AddWithValue("@Amount", lblPrice.Text)
                        .Parameters.AddWithValue("@Terms", txtTerms.Text)
                        .Parameters.AddWithValue("@ProductOrder", txtPONo.Text)
                        .Parameters.AddWithValue("@Date", dtpDate.Text)
                        .Parameters.AddWithValue("@SalesMan", cboSalesman.Text)
                        .Parameters.AddWithValue("@TIN", txtTIN.Text)
                        .ExecuteNonQuery()
                    End With

                    MsgBox("Successfully added!", MsgBoxStyle.Information, "Billing")
                Catch ex As Exception
                Finally
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(btnUpdate): " & ex.Message)
        Finally
            Call loadBilling()
        End Try
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        If Val(txtPrice.Text) > 0 Then
            lblPrice.Text = Val(txtPrice.Text) * Val(lblQty.Text)
        End If
    End Sub
    Public Sub loadBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM qrybilling WHERE CustomerID = '" & lblCustID.Text & "'"
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
                x.SubItems.Add(dr("BillingID").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(loadBilling): " & ex.Message)
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
                lblBillID.Text = ListView1.SelectedItems(0).SubItems(5).Text
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(ListView1_SelectedIndexChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            If ListView1.SelectedItems.Count > 0 Then
                If MsgBox("Do you want to change unit price?", vbYesNo + vbQuestion) = vbYes Then
                    Dim price As String = InputBox("Enter Price:", "Unit Price")

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
                        sql = "UPDATE tblbilling SET Amount=@Amount WHERE BillingID = '" & lblBillID.Text & "'"
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
            lblBillID.Text = 0
        End Try
    End Sub
End Class