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
        btnSave.Enabled = False
        TabControl2.SelectedTab = TabPage1
        Call loadOrderListView()
    End Sub

    Private Sub frmClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'clear all
        End If
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
                        'Dim ms As New MemoryStream(pic)
                        Using ms As New MemoryStream(pic)
                            PictureBox1.Image = Image.FromStream(ms)
                        End Using

                    Else
                        PictureBox1.Image = Nothing
                    End If
                End If
            Else
                PictureBox1.Image = Nothing
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmQuotation(loadImage): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadOrderListView()

        orderid = "lblOrderID"
        ListView1.Columns.Clear()
        ListView1.Columns.Add("OrderID")
        ListView1.Columns.Add("Price")
        ListView1.Columns.Add("Availability")
        ListView1.Columns.Add("Status")
        ListView1.Columns.Add("Ordered Date")

        'widths
        ListView1.Columns(0).Width = 150
        ListView1.Columns(1).Width = 150
        ListView1.Columns(2).Width = 150
        ListView1.Columns(3).Width = 150
        ListView1.Columns(4).Width = 300

        btnViewOrder.Text = "View"

        DateFilter1.Text = DateTime.Now.AddDays(-5)
        startDate = DateFilter1.Text

        DateFilter2.Text = DateTime.Now.AddDays(+5)
        endDate = DateFilter2.Text


        Call loadOrder(startDate, endDate)
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

    'Order Tab
    Private Sub loadOrder(startDate As String, endDate As String)
        If btnViewOrder.Text = "View" Then
            Try

                Dim startDateTime As DateTime
                Dim endDateTime As DateTime

                If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
               DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                    If cn.State <> ConnectionState.Open Then
                        cn.Open()
                    End If

                    sql = "SELECT *, SUM(Amount) AS TotalPrice, MIN(Availability) AS Available FROM qryorder WHERE CustomerID = '" & lblCustID.Text & "' AND OrderDate BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "' GROUP BY OrderID"
                    cmd = New MySqlCommand(sql, cn)

                    If Not dr.IsClosed Then
                        dr.Close()
                    End If

                    dr = cmd.ExecuteReader
                    Dim x As ListViewItem
                    ListView1.Items.Clear()

                    Do While dr.Read = True
                        x = New ListViewItem(dr("OrderID").ToString())
                        x.SubItems.Add(dr("TotalPrice").ToString())
                        x.SubItems.Add(If(dr("Available"), "Yes", "No")) '2
                        x.SubItems.Add(GetStatusText(dr("Status").ToString)) '3
                        x.SubItems.Add(dr("OrderDate").ToString()) ' 4

                        ' Check if the status is "Urgent" and set the text color accordingly
                        If x.SubItems(3).Text = "Priority Order" Then
                            x.ForeColor = Color.Red
                        End If
                        ListView1.Items.Add(x)
                    Loop
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox("An error occurred frmCustomerViewInfo_Order(loadOrder): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Function GetStatusText(status As String) As String
        Select Case status
            Case "5" : Return "Cancelled Order"
            Case "4" : Return "Priority Order"
            Case "3" : Return "Delivered"
            Case "2" : Return "Ready for Shipment"
            Case "1" : Return "Item on Hand"
            Case Else : Return "Item on Process"
        End Select
    End Function

    Private Sub DateFilter1_TextChanged(sender As Object, e As EventArgs) Handles DateFilter1.ValueChanged
        startDate = DateFilter1.Text
        loadOrder(startDate, endDate)
    End Sub

    Private Sub DateFilter2_TextChanged(sender As Object, e As EventArgs) Handles DateFilter2.ValueChanged
        endDate = DateFilter2.Text
        loadOrder(startDate, endDate)
    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If ListView1.SelectedItems.Count > 0 Or orderid IsNot Nothing Then
                frmManageSalesV2.lblCustID.Text = lblCustID.Text
                frmManageSalesV2.orderid = ListView1.SelectedItems(0).SubItems(0).Text
                Call loadActivity()

                Me.Close()
                frmManageSalesV2.TopLevel = False
                frmAdminDashboard.panelDashboard.Controls.Add(frmManageSalesV2)
                frmManageSalesV2.BringToFront()
                frmManageSalesV2.Dock = DockStyle.Fill
                frmManageSalesV2.Show()
            Else
                MsgBox("Please select an order!", MsgBoxStyle.Critical, "Insert Error")
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(btnInsert): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

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
                        Call sendEmail()
                    End If
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
    Private Sub sendEmail()
        Try
            Dim mail As New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("dangaranferds@gmail.com")
            mail.To.Add(txtEmailAddress.Text)
            mail.Subject = "NOTICE ON UPDATE OF ACCOUNT STATUS"

            Using memoryStream As New MemoryStream()

                mail.Body = "Congratulations! Your account has been updated." & vbCrLf & "Your account is now ACTIVE. Please login to continue using our services."
                smtpServer.Port = 587
                smtpServer.Credentials = New System.Net.NetworkCredential("dangaranferds@gmail.com", "tpbu vbxk ampu iwua")
                smtpServer.EnableSsl = True
                smtpServer.Send(mail)
            End Using

            MsgBox("Email sent with form screenshot!")
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

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If btnViewOrder.Text = "View" Then
                Call viewOrders()
            Else
                ListView1.Columns.Clear()
                ListView1.Columns.Add("OrderID")
                ListView1.Columns.Add("Price")
                ListView1.Columns.Add("Availability")
                ListView1.Columns.Add("Status")
                ListView1.Columns.Add("Ordered Date")

                'widths
                ListView1.Columns(0).Width = 150
                ListView1.Columns(1).Width = 150
                ListView1.Columns(2).Width = 150
                ListView1.Columns(3).Width = 150
                ListView1.Columns(4).Width = 300

                btnViewOrder.Text = "View"

                Call loadOrder(startDate, endDate)
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(btnViewOrder): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub viewOrders()
        Try

            If ListView1.SelectedItems.Count > 0 Then

                ListView1.Columns.Clear()
                ListView1.Columns.Add("Unit")
                ListView1.Columns.Add("Description")
                ListView1.Columns.Add("Quantity")
                ListView1.Columns.Add("Amount")
                ListView1.Columns.Add("Availability")
                ListView1.Columns.Add("Status")

                'widths
                ListView1.Columns(0).Width = 200
                ListView1.Columns(1).Width = 200
                ListView1.Columns(2).Width = 200
                ListView1.Columns(3).Width = 200
                ListView1.Columns(4).Width = 200
                ListView1.Columns(5).Width = 200

                sql = "SELECT * FROM qryorder WHERE OrderID = '" & lblOrderID.Text & "'"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim x As ListViewItem
                ListView1.Items.Clear()

                Do While dr.Read = True
                    x = New ListViewItem(dr("Unit").ToString())
                    x.SubItems.Add(dr("Description").ToString())
                    x.SubItems.Add(dr("Quantity").ToString())
                    x.SubItems.Add(dr("Amount").ToString())
                    x.SubItems.Add(If(dr("Availability").ToString() = "True", "Yes", "No")) '2
                    x.SubItems.Add(GetStatusText(dr("Status").ToString))
                    x.SubItems.Add(dr("OrderListID").ToString())
                    ListView1.Items.Add(x)
                Loop

                btnViewOrder.Text = "Back"
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmCustomerViewInfo_Order(viewOrders): " & ex.Message)
        End Try
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
            MsgBox("An error occurred frmAdminSettings(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class