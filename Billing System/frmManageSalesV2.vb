Imports System.Data.OleDb
Imports System.Runtime.InteropServices.ComTypes
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Net.Mime.MediaTypeNames
Imports System.Web.WebSockets
Public Class frmManageSalesV2

    Public orderid As String
    Dim adjustedValue As Double
    Dim trueadjustedvalue As String

    Public phoneNumber As String
    Public email As String
    Private Sub frmManageBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadBilling()
        Call loadSalesInvoice()
        dtpDate.Text = Now.ToString()
        lblBillingID.Text = getBillingID()
    End Sub

    Private Sub loadSalesInvoice()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT tblbilling.BillingID AS 'Invoice No', CONCAT(tblcustomer.FirstName, ' ', tblcustomer.LastName) AS FullName, tblbilling.CompanyName, tblbilling.FinalPrice, DATE_FORMAT(tblbilling.DatePrinted, '%M %d, %Y %h:%i %p') AS DatePrinted FROM tblbilling INNER JOIN tblcustomer ON tblcustomer.CustomerID = tblbilling.CustomerID"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView2.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("Invoice No").ToString())
                x.SubItems.Add(dr("FullName").ToString())
                x.SubItems.Add(dr("CompanyName").ToString())
                x.SubItems.Add(dr("FinalPrice").ToString())
                x.SubItems.Add(dr("DatePrinted").ToString())
                ListView2.Items.Add(x)
            Loop

        Catch ex As Exception
            MsgBox("An Error occurred frmManageBilling(loadSalesInvoice): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Sub loadBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM qryorder WHERE OrderID IN (SELECT OrderID FROM tblOrder WHERE CustomerID = '" & lblCustID.Text & "' AND OrderID = '" & orderid & "') And Availability = 1 And Status = 1"
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
                x.SubItems.Add(dr("OrderID").ToString()) '5
                x.SubItems.Add(dr("OrderListID").ToString()) '6
                x.SubItems.Add(dr("ProductID").ToString()) '7
                ListView1.Items.Add(x)

                totalamount += Convert.ToDouble(dr("Amount").ToString)
            Loop
        Catch ex As Exception
            MsgBox("An Error occurred frmManageBilling(loadBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub lblCustID_TextChanged(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you want to cancel?", vbYesNo + vbQuestion) = vbYes Then
            Call clearText()
            lblPONu.Visible = True
            txtPONo.Visible = True
        End If
    End Sub

    Dim totalamount As Double = 0
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtCompanyName", txtCompanyName},
            {"txtAddress", txtAddress},
            {"txtDeliveryAddress", txtDeliveryAddress},
            {"cboSalesman", cboSalesman},
            {"dtpDate", dtpDate}
        }

            '{"txtBusinessStyle", txtBusinessStyle},
            '{"txtTerms", txtTerms},

            For Each fieldName_controlPair In requiredFields
                Dim control As Control = fieldName_controlPair.Value

                If control.Text.Trim = "" Then
                    ErrorProvider1.SetIconAlignment(control, ErrorIconAlignment.MiddleLeft)
                    ErrorProvider1.SetError(control, "This field is required.")
                    MsgBox("Please fill out all fields!", MsgBoxStyle.Critical, "Empty Inputs")
                    filled = False
                    Exit For
                Else
                    ErrorProvider1.SetError(control, "")
                End If
            Next

            If filled Then
                Call printBilling()

                'btnAddOrder.Visible = False
                txtCompanyName.PlaceholderText = "Search Company"
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(btnPrint): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Dim changeAmount As Double = 0
    Private Sub printBilling()

        adjustedValue = totalamount
        trueadjustedvalue = totalamount

        If cboAdjust.Text = "Add Discount" Then
            If cboFormat.Text = "In Percent" Then

                changeAmount = totalamount * (Convert.ToDecimal(txtAmount.Text) / 100)

                adjustedValue -= changeAmount
                trueadjustedvalue = adjustedValue
            ElseIf cboFormat.Text = "In Whole Number" Then

                adjustedValue -= Convert.ToDecimal(txtAmount.Text)
                trueadjustedvalue = adjustedValue
            End If
        ElseIf cboAdjust.Text = "Add Mark Up" Then
            If cboFormat.Text = "In Percent" Then

                changeAmount = totalamount * (Convert.ToDecimal(txtAmount.Text) / 100)

                adjustedValue += changeAmount
                trueadjustedvalue = adjustedValue

            ElseIf cboFormat.Text = "In Whole Number" Then

                adjustedValue += Convert.ToDecimal(txtAmount.Text)
                trueadjustedvalue = adjustedValue
            End If
        End If

        If IsNothing(txtPONo.Text) Then
            txtPONo.Text = "1"
        End If


        'add date based on terms

        Call savetoBilling()
        Call savetoBillInvoice()

        Dim email As ListViewItem = ListView1.Items(0)
        frmPrintSalesInvoice.billingid = lblBillingID.Text
        frmPrintSalesInvoice.orderid = email.SubItems(5).Text
        frmPrintSalesInvoice.ShowDialog()

        Call clearText()
    End Sub
    Private Sub savetoBilling()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            Dim adjusteddate As DateTime

            For Each term In cboTerms.Text
                Select Case term
                    Case "day"
                        adjusteddate = DateTime.Now.AddDays(txtDays.Text).ToString
                    Case "month"
                        adjusteddate = DateTime.Now.AddMonths(txtDays.Text).ToString
                    Case "year"
                        adjusteddate = DateTime.Now.AddYears(txtDays.Text).ToString
                End Select
            Next
            Dim vat As Double = trueadjustedvalue * 0.12

            Dim vatablesales As Double = trueadjustedvalue - vat

            sql = "INSERT INTO tblbilling(BillingID, CustomerID, CompanyName, SalesMan, Terms, ProductOrder, DatePrinted, DueDate, Discount, Markup, FinalPrice, VATableSales, VAT) " &
                    "VALUES(@BillingID, @CustomerID, @CompanyName, @SalesMan, @Terms, @ProductOrder, @DatePrinted, @DueDate, @Discount, @Markup, @FinalPrice, @VATableSales, @VAT)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@BillingID", lblBillingID.Text)
                .Parameters.AddWithValue("@CustomerID", lblCustID.Text)
                .Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
                .Parameters.AddWithValue("@SalesMan", cboSalesman.Text)
                .Parameters.AddWithValue("@Terms", (txtDays.Text & " " & cboTerms.Text))
                .Parameters.AddWithValue("@ProductOrder", txtPONo.Text)
                .Parameters.AddWithValue("@DatePrinted", DateTime.Now)
                .Parameters.AddWithValue("@DueDate", adjusteddate)
                .Parameters.AddWithValue("@Discount", If(cboAdjust.Text = "Add Discount", changeAmount, DBNull.Value))
                .Parameters.AddWithValue("@Markup", If(cboAdjust.Text = "Add Mark Up", changeAmount, DBNull.Value))
                .Parameters.AddWithValue("@FinalPrice", trueadjustedvalue)
                .Parameters.AddWithValue("@VATableSales", vatablesales)
                .Parameters.AddWithValue("@VAT", vat)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmManageSalesV2(savetoBilling): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub savetoBillInvoice()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            For Each item As ListViewItem In ListView1.Items
                Dim productid As String = item.SubItems(7).Text
                Dim orderid As String = item.SubItems(5).Text

                sql = "INSERT INTO tblbillinvoice(BillingID, OrderID, ProductID, Amount) VALUES(@BillingID, @OrderID, @ProductID, @Amount)"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@BillingID", lblBillingID.Text)
                    .Parameters.AddWithValue("@OrderID", orderid)
                    .Parameters.AddWithValue("@ProductID", productid)
                    .Parameters.AddWithValue("@Amount", trueadjustedvalue)
                    .ExecuteNonQuery()
                End With
            Next
        Catch ex As Exception
            MsgBox("An error occurred frmManageSalesV2(savetoBillInvoice): " & ex.Message)
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

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs)
        If MsgBox("Do you want to add items?", vbYesNo + vbQuestion, "Walk-In Status") = vbYes Then
            frmManagePOS.ShowDialog()
        End If
    End Sub

    Public Sub clearText()
        txtCompanyName.Enabled = True
        txtAddress.Enabled = True
        txtDeliveryAddress.Enabled = True

        txtCompanyName.Clear()
        txtAddress.Clear()
        txtDeliveryAddress.Clear()
        'txtBusinessStyle.Clear()
        txtTIN.Clear()
        'txtTerms.Clear()
        txtPONo.Clear()
        txtAmount.Clear()

        txtCompanyName.Enabled = False
        txtAddress.Enabled = False
        txtDeliveryAddress.Enabled = False
        btnAddOrder.Visible = False

        cboSalesman.SelectedIndex = -1
        cboFormat.SelectedIndex = 0
        cboAdjust.SelectedIndex = 0

        ListView1.Items.Clear()
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        frmListofOrdersPending.ShowDialog()
    End Sub

    Private Sub btnViewSales_Click(sender As Object, e As EventArgs) Handles btnViewSales.Click
        frmViewTotalSales.ShowDialog()
    End Sub
End Class