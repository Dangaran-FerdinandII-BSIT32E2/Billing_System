Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class frmCustomerViewInfo_Order

    Dim acctstatus As Boolean
    Dim status1 As Integer
    Dim orderid As String

    Dim startDate As String
    Dim endDate As String

    Private email As String
    Private Sub frmCustomerViewInfo_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation()
        Call loadImage()
        Call loadCompanyImage()
        btnSave.Enabled = False

        TabControl2.SelectedTab = TabPage1

        'ORDER TAB

        DateFilter1.Text = DateTime.Now.AddDays(-5)
        startDate = DateFilter1.Value.ToString("yyyy-MM-dd")

        DateFilter2.Text = DateTime.Now.AddDays(+5)
        endDate = DateFilter2.Value.ToString("yyyy-MM-dd")

        Call loadOrders(startDate, endDate)
    End Sub

    Private Sub frmClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'clear all
        End If
    End Sub

    Private Sub loadOrders(startDate As String, endDate As String)
        Try
            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
           DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT OrderID, SUM(Amount) AS Amount, Status, DATE_FORMAT(DateOrdered, '%M %d, %Y') AS OrderedDate, CustomerID FROM tblorder WHERE CustomerID = '" & lblCustID.Text & "' AND DateOrdered BETWEEN '" & startDateTime.ToString("yyyyy-MM-dd") & "' AND '" & endDateTime.ToString("yyyyy-MM-dd") & "' GROUP BY OrderID ORDER BY OrderID ASC"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem(dr("OrderID").ToString())
                    x.SubItems.Add(dr("Amount").ToString())
                    x.SubItems.Add(GetStatusText(dr("Status").ToString()))
                    x.SubItems.Add(dr("OrderedDate").ToString())
                    x.SubItems.Add(dr("CustomerID").ToString())

                    If dr("Status") = 3 Then
                        x.ForeColor = Color.Green
                    Else
                        x.ForeColor = Color.Black
                    End If


                    ListView1.Items.Add(x)
                Loop

                dr.Close()
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmManageBilling(loadOrders): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub DateFilter1_ValueChanged(sender As Object, e As EventArgs) Handles DateFilter1.ValueChanged
        startDate = DateFilter1.Text
        Call loadOrders(startDate, endDate)
    End Sub

    Private Sub DateFilter2_ValueChanged(sender As Object, e As EventArgs) Handles DateFilter2.ValueChanged
        endDate = DateFilter2.Text
        Call loadOrders(startDate, endDate)
    End Sub
    Private Sub loadImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT Image FROM tblcustomer WHERE CustomerID = '" & lblCustID.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                If dr("Image") IsNot DBNull.Value AndAlso dr("Image") IsNot Nothing Then
                    Dim pic As Byte() = DirectCast(dr("Image"), Byte())
                    If pic.Length > 0 Then
                        Using ms As New MemoryStream(pic)
                            pbxGovID.Image = Image.FromStream(ms)
                        End Using

                    Else
                        pbxGovID.Image = Nothing
                    End If
                End If
            Else
                pbxGovID.Image = Nothing
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(loadImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadCompanyImage()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT GovernmentID FROM tblcustomer WHERE CustomerID = '" & lblCustID.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                If dr("GovernmentID") IsNot DBNull.Value AndAlso dr("GovernmentID") IsNot Nothing Then
                    Dim pic As Byte() = DirectCast(dr("GovernmentID"), Byte())
                    If pic.Length > 0 Then
                        Using ms As New MemoryStream(pic)
                            pbxCompanyID.Image = Image.FromStream(ms)
                        End Using

                    Else
                        pbxCompanyID.Image = Nothing
                    End If
                End If
            Else
                pbxCompanyID.Image = Nothing
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(loadCompanyImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    'Customer Tab
    Private Sub loadInformation()
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
                txtBusinessStyle.Text = dr("CompanyName").ToString() 'bus style
                cboStatus.Text = (IIf(dr("Status") = "2", "Credit Positive", IIf(dr("Status") = "1", "Credit Negative", "Neutral")).ToString())

                txtLastName.Text = dr("LastName").ToString()
                txtFirstName.Text = dr("FirstName").ToString()
                txtPhoneNumber.Text = dr("PhoneNumber").ToString()
                txtEmailAddress.Text = dr("Email").ToString()
                txtRole.Text = dr("EmployeePosition").ToString()
                cboAcctStatus.Text = (If(dr("AcctStatus") = "True", "Active", "Inactive").ToString())
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(loadInformation): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Function GetStatusText(status As String) As String
        Select Case status
            Case "5" : Return "Cancelled Order"
            Case "4" : Return "Priority Order"
            Case "3" : Return "Delivered"
            Case "2" : Return "Ready for Shipment"
            Case "1" : Return "On Hand"
            Case Else : Return "On Process"
        End Select
    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True
        btnEdit.Enabled = False

        Call enableAll()
    End Sub

    Private Sub enableAll()
        txtCompanyName.Enabled = True
        txtAddress.Enabled = True
        txtDeliveryAddress.Enabled = True
        txtBusinessStyle.Enabled = True
        cboStatus.Enabled = True

        txtLastName.Enabled = True
        txtFirstName.Enabled = True
        txtPhoneNumber.Enabled = True
        txtEmailAddress.Enabled = True
        cboAcctStatus.Enabled = True
    End Sub
    Private Sub disableAll()
        txtCompanyName.Enabled = False
        txtAddress.Enabled = False
        txtDeliveryAddress.Enabled = False
        txtBusinessStyle.Enabled = False
        cboStatus.Enabled = False

        txtLastName.Enabled = False
        txtFirstName.Enabled = False
        txtPhoneNumber.Enabled = False
        txtEmailAddress.Enabled = False
        cboAcctStatus.Enabled = False
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtCompanyName", txtCompanyName},
            {"txtAddress", txtAddress},
            {"txtDeliveryAddress", txtDeliveryAddress},
            {"txtBusinessStyle", txtBusinessStyle},
            {"cboStatus", cboStatus},
            {"txtFirstName", txtFirstName},
            {"txtLastName", txtLastName},
            {"txtPhoneNumber", txtPhoneNumber},
            {"txtEmailAddress", txtEmailAddress},
            {"cboAcctStatus", cboAcctStatus}
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

                    If cboStatus.Text = "Credit Positive" Then
                        status1 = 2
                    ElseIf cboStatus.Text = "Credit Negative" Then
                        status1 = 1
                    Else
                        status1 = 0
                    End If

                    If cboAcctStatus.Text = "Active" Then
                        acctstatus = True
                    Else
                        acctstatus = False
                    End If

                    sql = "UPDATE tblcustomer SET LastName=@LastName, FirstName=@FirstName, PhoneNumber=@PhoneNumber, Email=@Email," &
                    "CompanyName=@CompanyName, Address=@Address, Delivery=@Delivery, BusinessStyle=@BusinessStyle," &
                    "Status=@Status, AcctStatus=@AcctStatus WHERE CustomerID = '" & lblCustID.Text & "'"
                    cmd = New MySqlCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@LastName", txtLastName.Text)
                        .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                        .Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                        .Parameters.AddWithValue("@Email", txtEmailAddress.Text)
                        .Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
                        .Parameters.AddWithValue("@Address", txtAddress.Text)
                        .Parameters.AddWithValue("@Delivery", txtDeliveryAddress.Text)
                        .Parameters.AddWithValue("@BusinessStyle", txtBusinessStyle.Text)
                        .Parameters.AddWithValue("@Status", status1.ToString())
                        .Parameters.AddWithValue("@AcctStatus", acctstatus)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Successfully changed information!", MsgBoxStyle.Information, "Update Info")

                    btnEdit.Enabled = True

                    btnSave.Enabled = False
                    Call disableAll()
                    Call loadInformation()

                    If acctstatus Then
                        Call sendActiveEmail()
                    End If

                    frmManageCustomerV3.cboSalesman.SelectedIndex = 0
                    Call frmManageCustomerV3.loadCustomers()
                Catch ex As Exception
                    MsgBox("An error occurred frmCustomerViewInfo_Order(Saving Information): " & ex.Message)
                Finally
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(btnSave): " & ex.Message)
        End Try
    End Sub
    Private Sub sendActiveEmail()
        Try
            Dim mail As New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("corporationrambic@gmail.com")
            mail.To.Add(txtEmailAddress.Text)
            mail.Subject = "NOTICE ON UPDATE OF ACCOUNT STATUS"

            Using memoryStream As New MemoryStream()

                mail.Body = "Dear customer," & vbCrLf & "Your account is now ACTIVE. Please login to continue using our services."
                smtpServer.Port = 587
                smtpServer.Credentials = New System.Net.NetworkCredential("corporationrambic@gmail.com", "rxyx ldrd ngxp twjl") ' Use secure methods
                smtpServer.EnableSsl = True
                smtpServer.Send(mail)
            End Using
        Catch ex As Exception
            MsgBox("An error occurred frmPrintBillingInvoice(btnEmail): " & ex.Message)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnSave.Enabled = False

        btnEdit.Enabled = True

        Call disableAll()
        Call loadInformation()
    End Sub
    Private Sub loadActivity()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblactivity(UserID, Username, DateTime, Action) VALUES(@UserID, @Username, @DateTime, @Action)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@UserID", frmLoginV2.userid)
                .Parameters.AddWithValue("@Username", frmLoginV2.username)
                .Parameters.AddWithValue("@DateTime", DateTime.Now)
                .Parameters.AddWithValue("@Action", "Created Invoice for ")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnActive_Click(sender As Object, e As EventArgs) Handles btnActive.Click
        If MsgBox("Do you want to activate account?", vbQuestion + vbYesNo, "Activate Status") = vbYes Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "UPDATE tblcustomer SET AcctStatus = 1 WHERE CustomerID = '" & lblCustID.Text & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

                Call sendActiveEmail()

                cboAcctStatus.Text = "Active"

                frmManageCustomerV3.cboSalesman.SelectedIndex = 0
                Call frmManageCustomerV3.loadCustomers()
            Catch ex As Exception
                MsgBox("An error occurred frmCustomerViewInfo_Order(btnActive_Click): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub


    Private Sub cboAcctStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAcctStatus.SelectedIndexChanged
        If cboAcctStatus.Text = "Active" Then

            btnActive.Enabled = False
            btnDeactive.Enabled = True

        ElseIf cboAcctStatus.Text = "Inactive" Then

            btnActive.Enabled = True
            btnDeactive.Enabled = False

        End If
    End Sub

    Private Sub btnDeactive_Click(sender As Object, e As EventArgs) Handles btnDeactive.Click
        If MsgBox("Do you want to deactivate account?", vbQuestion + vbYesNo, "Deactivate Status") = vbYes Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "UPDATE tblcustomer SET AcctStatus = 0 WHERE CustomerID = '" & lblCustID.Text & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

                Call sendDeactivateEmail()

                cboAcctStatus.Text = "Inactive"

                frmManageCustomerV3.cboSalesman.SelectedIndex = 0
                Call frmManageCustomerV3.loadCustomers()
            Catch ex As Exception
                MsgBox("An error occurred frmCustomerViewInfo_Order(btnDeactive_Click): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub sendDeactivateEmail()
        Try
            Dim mail As New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("rambiccorpo@gmail.com")
            mail.To.Add(txtEmailAddress.Text)
            mail.Subject = "NOTICE ON UPDATE OF ACCOUNT STATUS"

            Using memoryStream As New MemoryStream()

                mail.Body = "Your account has been DEACTIVATED. Please login to continue using our services."
                smtpServer.Port = 587
                smtpServer.Credentials = New System.Net.NetworkCredential("rambiccorpo@gmail.com", "xcyu gtqv ctvk kzqa") ' Use secure methods
                smtpServer.EnableSsl = True
                smtpServer.Send(mail)
            End Using
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(sendDeactivateEmail): " & ex.Message)
        End Try
    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click, ListView1.DoubleClick
        If btnViewOrder.Text = "View" Then

            Call productsListView()
            Call loadSpecificOrder()
            btnBack.Enabled = True
            btnViewOrder.Enabled = False

        End If
    End Sub

    Private Sub productsListView()
        ListView1.Clear()

        ListView1.Columns.Add("Product Name")
        ListView1.Columns.Add("Supplier Name")
        ListView1.Columns.Add("Selling Price")
        ListView1.Columns.Add("Quantity")
        ListView1.Columns.Add("Total Price")

        ListView1.Columns(0).Width = 150
        ListView1.Columns(1).Width = 150
        ListView1.Columns(2).Width = 150
        ListView1.Columns(3).Width = 150
        ListView1.Columns(4).Width = 150
    End Sub

    Private Sub ordersListView()
        ListView1.Clear()

        ListView1.Columns.Add("OrderID")
        ListView1.Columns.Add("Price")
        ListView1.Columns.Add("Status")
        ListView1.Columns.Add("Ordered Date")

        ListView1.Columns(0).Width = 150
        ListView1.Columns(1).Width = 150
        ListView1.Columns(2).Width = 300
        ListView1.Columns(3).Width = 300
    End Sub
    Private Sub loadSpecificOrder()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT s.CompanyName, p.ProductName, p.SellingPrice, o.Quantity, o.Amount FROM tblorder o INNER JOIN tblproduct p ON o.ProductID = p.ProductID INNER JOIN tblsupplier s on s.SupplierID = p.SupplierID WHERE o.OrderID = '" & orderid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("ProductName").ToString)
                x.SubItems.Add(dr("CompanyName").ToString)
                x.SubItems.Add(dr("SellingPrice").ToString)
                x.SubItems.Add(dr("Quantity").ToString)
                x.SubItems.Add(dr("Amount").ToString)

                ListView1.Items.Add(x)

            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(loadSpecificOrder): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 And btnViewOrder.Text = "View" Then
            orderid = ListView1.SelectedItems(0).SubItems(0).Text
            btnViewOrder.Enabled = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnViewOrder.Enabled = False Then

            orderid = Nothing
            Call ordersListView()
            Call loadOrders(startDate, endDate)

            btnViewOrder.Enabled = False
            btnBack.Enabled = False
        End If
    End Sub
End Class