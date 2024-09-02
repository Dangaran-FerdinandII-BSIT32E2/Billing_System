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

                    sql = "INSERT INTO tblbilling(SupplierID, ProductID, Terms, ProductOrder, Date, SalesMan, TIN) VALUE(@SupplierID, @ProductID, @Terms, @ProductOrder, @Date, @SalesMan, @TIN)"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@SupplierID", lblSuppID.Text)
                        .Parameters.AddWithValue("@ProductID", lblProductID.Text)
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
        End Try
    End Sub
End Class