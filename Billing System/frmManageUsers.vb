Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Globalization
Imports Mysqlx.Crud
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class frmManageUsers

    Dim startDateAct As String
    Dim endDateAct As String

    Dim startDate As String
    Dim endDate As String
    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadUsers()

        'ACTIVITY LOGS

        DateFilter3.Text = DateTime.Now.AddDays(-5)
        startDateAct = DateFilter3.Value.ToString("yyyy-MM-dd")

        DateFilter4.Text = DateTime.Now.AddDays(+5)
        endDateAct = DateFilter4.Value.ToString("yyyy-MM-dd")

        Call loadActivity(startDateAct, endDateAct)

        'REPORT GENERATION

        DateFilter1.Text = DateTime.Now.AddDays(-5)
        startDate = DateFilter1.Text

        DateFilter2.Text = DateTime.Now.AddDays(+5)
        endDate = DateFilter2.Text

        Call loadChoices()
        Call loadReport()
    End Sub

    Private Sub loadUsers()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM tblusers WHERE Role <> 'Admin'"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("FirstName").ToString())
                x.Font = New Font("Arial", 12, FontStyle.Regular)
                x.SubItems.Add(dr("LastName").ToString())
                x.SubItems.Add(dr("Username").ToString())
                x.SubItems.Add(dr("Role").ToString())
                x.SubItems.Add(dr("Status").ToString())
                x.SubItems.Add(dr("UserID").ToString())
                ListView1.Items.Add(x)
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(loadUsers): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtUserID.Text = ListView1.SelectedItems(0).SubItems(6).Text
        End If

        btnCreateNew.Enabled = False

        btnEdit.Enabled = True
        btnCancel.Enabled = True
        btnDelete.Enabled = True
    End Sub
    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            sql = "SELECT * FROM tblusers WHERE UserID = '" & txtUserID.Text & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtFirstName.Text = dr("FirstName").ToString
                txtLastName.Text = dr("LastName").ToString
                txtUsername.Text = dr("Username").ToString
                cboRole.Text = dr("Role").ToString
                cboStatus.Text = dr("Status").ToString
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(txtUserID_TextChanged): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub enableAlltxt()
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        cboRole.Enabled = True
        cboStatus.Enabled = True
    End Sub
    Private Sub disableAlltxt()
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        cboRole.Enabled = False
        cboStatus.Enabled = False
    End Sub

    Private Sub clearAll()
        txtUserID.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True

        txtUserID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()

        txtUserID.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False

        cboRole.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
    End Sub
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnView.Click
        TabControl2.SelectedTab = TabPage1
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        Call enableAlltxt()

        btnCancel.Enabled = True
        btnSave.Enabled = True
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call enableAlltxt()

        btnSave.Enabled = True
        btnDelete.Enabled = False
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearAll()
        Call disableAlltxt()
        btnCreateNew.Enabled = True

        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim filled As Boolean = True

            Dim requiredFields As New Dictionary(Of String, Control) From {
            {"txtFirstname", txtFirstName},
            {"txtLastname", txtLastName},
            {"txtPassword", txtPassword},
            {"txtUsername", txtUsername},
            {"cboRole", cboRole},
            {"cboStatus", cboStatus}
        }

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
                Try
                    If cn.State <> ConnectionState.Open Then
                        cn.Open()
                    End If

                    If btnCreateNew.Enabled = True And btnEdit.Enabled = False Then
                        Call createNew()
                    Else
                        Call edit()
                    End If

                Catch ex As Exception
                    MsgBox("An error occurred frmManageUsers(Saving Users): " & ex.Message)
                Finally
                    Call loadUsers()
                    Call clearAll()
                    Call disableAlltxt()
                    btnCreateNew.Enabled = True

                    btnEdit.Enabled = False
                    btnSave.Enabled = False
                    btnDelete.Enabled = False
                    btnCancel.Enabled = False
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(btnSave): " & ex.Message)
        Finally
        End Try
    End Sub

    Private Sub createNew()
        sql = "INSERT INTO tblusers(FirstName, LastName, Password, Username, Role, Status) VALUES(@FirstName, @LastName, @Password, @Username, @Role, @Status)"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@Password", txtPassword.Text)
            .Parameters.AddWithValue("@Username", txtUsername.Text)
            .Parameters.AddWithValue("@Role", cboRole.Text)
            .Parameters.AddWithValue("@Status", "Inactive")
            .ExecuteNonQuery()
        End With
        MsgBox("Successfully added!", MsgBoxStyle.Information, "Users")
        Call loadUserActivity()
    End Sub
    Private Sub loadUserActivity()
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
                .Parameters.AddWithValue("@Action", "ADDED NEW USER " + txtUsername.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(loadUserActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub edit()
        sql = "UPDATE tblusers SET FirstName=@FirstName, LastName=@LastName, Password=@Password, Username=@Username, Role=@Role, Status=@Status WHERE UserID = '" & txtUserID.Text & "'"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@Password", txtPassword.Text)
            .Parameters.AddWithValue("@Username", txtUsername.Text)
            .Parameters.AddWithValue("@Role", cboRole.Text)
            .Parameters.AddWithValue("@Status", cboStatus.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Successfully updated the user!", MsgBoxStyle.Information)
        Call loadEditActivity()
    End Sub

    Private Sub loadEditActivity()
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
                .Parameters.AddWithValue("@Action", "EDITED USER " + txtUsername.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(loadEditActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If txtUserID.Text IsNot Nothing Then
                If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                    sql = "DELETE FROM tblusers WHERE UserID = @userid"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@userid", txtUserID.Text)
                    cmd.ExecuteNonQuery()

                    Call loadUsers()
                    Call clearAll()

                    MsgBox("Successfully deleted!", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(btnDelete): " & ex.Message)
        Finally

            Call disableAlltxt()
            btnCreateNew.Enabled = True

            btnEdit.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = False
            btnCancel.Enabled = False
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    'ACTIVITY LOG
    Private Sub DateFilter3_ValueChanged(sender As Object, e As EventArgs) Handles DateFilter3.ValueChanged
        startDateAct = DateFilter3.Text
        loadActivity(startDateAct, endDateAct)
    End Sub

    Private Sub DateFilter4_ValueChanged(sender As Object, e As EventArgs) Handles DateFilter4.ValueChanged
        endDateAct = DateFilter4.Text
        loadActivity(startDateAct, endDateAct)
    End Sub

    Private Sub loadActivity(startDate As String, endDate As String)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim startDateTime As DateTime
            Dim endDateTime As DateTime

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
           DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then
                sql = "SELECT * FROM tblactivity WHERE DateTime BETWEEN '" & startDateTime.ToString("yyyy-MM-dd") & "' AND '" & endDateTime.ToString("yyyy-MM-dd") & "' GROUP BY Username"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                Dim y As ListViewItem
                ListView2.Items.Clear()

                Do While dr.Read = True
                    y = New ListViewItem(StrConv(dr("Username").ToString, VbStrConv.ProperCase))
                    y.Font = New Font("Arial", 12, FontStyle.Regular)
                    y.SubItems.Add(dr("Action").ToString)

                    Dim dateTimeValue As DateTime = Convert.ToDateTime(dr("DateTime"))

                    y.SubItems.Add(dateTimeValue.ToString("MMMM dd, yyyy"))
                    y.SubItems.Add(dateTimeValue.ToString("hh:mm:ss tt"))
                    ListView2.Items.Add(y)
                Loop
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmLogin(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    'REPORT GEN
    Private Sub loadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\Report1.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT UserID, FirstName, LastName, Password, Username, Role, Status FROM tblusers", cn)
            da.Fill(ds.Tables("dtUsers"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("DataSet1", ds.Tables("dtUsers"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub cboMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMenu.SelectedIndexChanged
        cboOptions.Items.Clear()

        Select Case cboMenu.SelectedIndex
            Case 0
                cboOptions.Items.AddRange(New String() {"Overview of Sales Performance", "Monthly Sales Trends", "Top Products Sold"})
            Case 1
                cboOptions.Items.AddRange(New String() {"Sales Report", "Account Receivable"})
            Case 2
                cboOptions.Items.AddRange(New String() {"Order Reports", "Pending Orders", "Order Trends"})
            Case 3
                cboOptions.Items.AddRange(New String() {"Customer Reports", "Purchase Behavior"})
            Case 4
                cboOptions.Items.AddRange(New String() {"Supplier Reports", "Purchase Orders"})
            Case 5
                cboOptions.Items.AddRange(New String() {"Rental Reports", "Rental Trends"})
            Case 6
                cboOptions.Items.AddRange(New String() {"Activity Reports"})
        End Select
    End Sub
    Private Sub loadChoices()
        cboMenu.Items.AddRange(New String() {"Dashboard", "Billing", "Orders", "Customers", "Suppliers", "Rental", "Admin"})
        cboMenu.SelectedIndex = 0

        updatecboOptions("Dashboard")
    End Sub
    Private Sub updatecboOptions(selectedOption As String)
        cboOptions.Items.Clear()

        Select Case selectedOption
            Case "Dashboard"
                cboOptions.Items.AddRange(New String() {"Overview of Sales Performance", "Monthly Sales Trends", "Top Products Sold"})
            Case "Billing"
                cboOptions.Items.AddRange(New String() {"Sales Report", "Account Receivable"})
            Case "Orders"
                cboOptions.Items.AddRange(New String() {"Order Reports", "Pending Orders", "Order Trends"})
            Case "Customers"
                cboOptions.Items.AddRange(New String() {"Customer Reports", "Purchase Behavior"})
            Case "Suppliers"
                cboOptions.Items.AddRange(New String() {"Supplier Reports", "Purchase Orders"})
            Case "Rental"
                cboOptions.Items.AddRange(New String() {"Rental Reports", "Rental Trends"})
            Case "Admin"
                cboOptions.Items.AddRange(New String() {"Activity Reports"})
        End Select
    End Sub

    'FUCK THIS SHIT
    Private Sub cboOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOptions.SelectedIndexChanged
        Select Case cboOptions.SelectedItem
            'dashboard
            Case "Overview of Sales Performance"
                generateOverviewSalesPerformance()
            Case "Monthly Sales Trends"
                generateMonthlySalesTrends()
            Case "Top Products Sold"
                generateTopSoldProducts()
                'billing
            Case "Sales Report"
                generateSalesReport()
            Case "Account Receivable"
                generatePaymentStatus()
                'orders
            Case "Order Reports"
                generateOrderReports()
            Case "Pending Orders"
                generateOrderFullfillmentReports()
            Case "Order Trends"
                generateOrderTrends()
                'customers
            Case "Customer Reports"
                generateCustomerReport()
            Case "Purchase Behavior"
                generatePurchaseBehavior()
                'suppliers
            Case "Supplier Reports"
                generateSupplierReports
            Case "Purchase Orders"
                generatePurchaseOrders()
            'Case "Supplier Trends"
            '    generateSupplierTrends()
                'rental
            Case "Rental Reports"
                generateRentalReports()
            Case "Rental Trends"
                generateRentalTrends()
                'admin
            Case "Activity Reports"
                generateUserActivityLogs(startDate, endDate)
        End Select
    End Sub

    Private Sub generateOverviewSalesPerformance()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportDashboardOverview.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT * FROM tblbilling", cn)
            da.Fill(ds.Tables("dtBilling"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtDashboardOverview", ds.Tables("dtBilling"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub generateMonthlySalesTrends()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportMonthlyTrends.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT * FROM tblbilling GROUP BY MONTH(DatePrinted)", cn)
            da.Fill(ds.Tables("dtBilling"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtSalesOverview", ds.Tables("dtBilling"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub generateTopSoldProducts()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportTopProductSold.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT tblProduct.ProductID, tblProduct.ProductName, SUM(tblOrder.Quantity) AS Quantity FROM tblorder INNER JOIN tblProduct ON tblOrder.ProductID = tblProduct.ProductID GROUP BY tblProduct.ProductID ORDER BY  Quantity DESC", cn)
            da.Fill(ds.Tables("dtProductOrder"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtTopProductsSold", ds.Tables("dtProductOrder"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub generateSalesReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportSalesReport.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT s.CompanyName, p.ProductName, SUM(o.Quantity) AS Quantity, SUM(o.Amount) AS TotalPrice FROM tblsupplier s INNER JOIN tblproduct p ON p.SupplierID = s.SupplierID INNER JOIN tblorder o ON o.ProductID = p.ProductID GROUP BY p.ProductName ORDER BY TotalPrice DESC", cn)
            da.Fill(ds.Tables("dtSalesReport"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtSalesReport", ds.Tables("dtSalesReport"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub generatePaymentStatus()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportPaymentStatus.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT CompanyName, Sum(FinalPrice) AS FinalPrice FROM tblbilling WHERE Remarks = 0 GROUP BY FinalPrice DESC", cn)
            da.Fill(ds.Tables("dtPaymentStatus"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtPaymentStatus", ds.Tables("dtPaymentStatus"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub generateOrderReports()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportOrderReports.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT tblorder.OrderListID, CONCAT(tblcustomer.FirstName, ', ', tblcustomer.LastName) AS FullName, tblproduct.ProductName, tblorder.Quantity, tblorder.Amount, CASE tblorder.Status WHEN 5 THEN 'CANCELLED ORDER' WHEN 4 THEN 'URGENT' WHEN 3 THEN 'DELIVERED' WHEN 2 THEN 'READY FOR SHIPMENT' WHEN 1 THEN 'ON HOLD' WHEN 0 THEN 'ON PROCESS' END AS Status, tblorder.DateOrdered FROM tblorder INNER JOIN tblcustomer ON tblcustomer.CustomerID = tblorder.CustomerID INNER JOIN tblproduct ON tblproduct.ProductID = tblorder.ProductID ORDER BY FullName ASC", cn)
            da.Fill(ds.Tables("dtOrderReports"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtOrderReports", ds.Tables("dtOrderReports"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub generateOrderFullfillmentReports()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportOrderFullfillment.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT tblorder.OrderListID, CONCAT(tblcustomer.FirstName, ', ', tblcustomer.LastName) AS FullName, tblproduct.ProductName, tblorder.Quantity, tblorder.Amount, CASE tblorder.Status WHEN 5 THEN 'CANCELLED ORDER' WHEN 4 THEN 'URGENT' WHEN 3 THEN 'DELIVERED' WHEN 2 THEN 'READY FOR SHIPMENT' WHEN 1 THEN 'ON HOLD' WHEN 0 THEN 'ON PROCESS' END AS Status, tblorder.DateOrdered FROM tblorder INNER JOIN tblcustomer ON tblcustomer.CustomerID = tblorder.CustomerID INNER JOIN tblproduct ON tblproduct.ProductID = tblorder.ProductID WHERE tblorder.Status = 'ON PROCESS'", cn)
            da.Fill(ds.Tables("dtOrderReports"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtOrderFullfillment", ds.Tables("dtOrderReports"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub generateOrderTrends()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportOrderTrends.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT tblorder.ProductID, tblproduct.ProductName, SUM(tblorder.Quantity) AS Quantity, DATE_FORMAT(tblorder.DateOrdered, '%M') AS Month, YEAR(tblorder.DateOrdered) AS Year FROM tblorder INNER JOIN tblproduct ON tblorder.ProductID = tblproduct.ProductID GROUP BY tblorder.ProductID, YEAR(tblorder.DateOrdered), MONTH(tblorder.DateOrdered) ORDER BY Year DESC, FIELD(DATE_FORMAT(tblorder.DateOrdered, '%M'), 'January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December') ASC, Quantity DESC", cn)
            da.Fill(ds.Tables("dtOrderReports"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtOrderTrends", ds.Tables("dtOrderReports"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub generateCustomerReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportCustomerReports.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT * FROM tblcustomer WHERE CustomerID > 2 ORDER BY AcctStatus ASC", cn)
            da.Fill(ds.Tables("dtCustomerReport"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtCustomerReport", ds.Tables("dtCustomerReport"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub generatePurchaseBehavior()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportPurchaseBehavior.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT tblcustomer.*, COUNT(tblorder.Quantity) AS Quantity, SUM(tblorder.Amount) AS AmtSpent FROM tblcustomer, tblorder, tblproduct WHERE tblorder.CustomerID = tblcustomer.CustomerID AND tblorder.ProductID = tblproduct.ProductID GROUP BY tblcustomer.CustomerID ORDER BY AmtSpent DESC", cn)
            da.Fill(ds.Tables("dtPurchaseBehavior"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtPurchaseBehavior", ds.Tables("dtPurchaseBehavior"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub generateSupplierReports()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportSupplierReports.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT * FROM tblsupplier", cn)
            da.Fill(ds.Tables("dtSupplier"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtSupplierReport", ds.Tables("dtSupplier"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub generatePurchaseOrders()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportPurchaseOrder.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT tblsupplier.SupplierID, tblsupplier.CompanyName, SUM(tblorder.Amount) AS Amount, SUM(tblorder.Quantity) AS Quantity FROM tblsupplier INNER JOIN tblproduct ON tblproduct.SupplierID = tblsupplier.SupplierID INNER JOIN tblorder ON tblproduct.ProductID = tblorder.ProductID GROUP BY tblsupplier.SupplierID", cn)
            da.Fill(ds.Tables("dtPurchaseOrder"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtPurchaseOrder", ds.Tables("dtPurchaseOrder"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub generateSupplierTrends()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportSupplierTrends.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT tblsupplier.SupplierID, tblsupplier.CompanyName, SUM(tblorder.Amount) AS Amount, SUM(tblorder.Quantity) AS Quantity, tblorder.DateOrdered FROM tblsupplier INNER JOIN tblproduct ON tblproduct.SupplierID = tblsupplier.SupplierID INNER JOIN tblorder ON tblproduct.ProductID = tblorder.ProductID GROUP BY tblsupplier.SupplierID, MONTH(tblorder.DateOrdered) ORDER BY MONTH(tblorder.DateOrdered) ASC", cn)
            da.Fill(ds.Tables("dtSupplierTrends"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtSupplierTrends", ds.Tables("dtSupplierTrends"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub generateRentalReports()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportRentalReports.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("SELECT tblbilling.CompanyName, DATE_FORMAT(tblbilling.DatePrinted, '%M %e, %Y') AS DateOrdered, tblproduct.ProductName, tblbillinvoice.Amount, total.TotalCompanies, COUNT(tblproduct.ProductName) OVER () AS TotalProducts, SUM(tblbillinvoice.Amount) OVER () AS TotalAmount FROM tblbilling INNER JOIN tblbillinvoice ON tblbilling.BillingID = tblbillinvoice.BillingID INNER JOIN tblproduct ON tblbillinvoice.ProductID = tblproduct.ProductID INNER JOIN (SELECT COUNT(DISTINCT BillingID) AS TotalCompanies FROM tblbilling WHERE CustomerID = 1) AS total ON 1 = 1 WHERE tblbilling.CustomerID = 1 ORDER BY tblbilling.DatePrinted ASC", cn)
            da.Fill(ds.Tables("dtRentalReport"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtRentalReports", ds.Tables("dtRentalReport"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub generateRentalTrends()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportRentalTrends.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            da.SelectCommand = New MySqlCommand("WITH MonthlyProductSales AS (SELECT tblproduct.ProductName, DATE_FORMAT(tblbilling.DatePrinted, '%M %Y') AS Month, SUM(tblbillinvoice.Amount) AS TotalAmount, ROW_NUMBER() OVER (PARTITION BY DATE_FORMAT(tblbilling.DatePrinted, '%M %Y') ORDER BY SUM(tblbillinvoice.Amount) DESC) AS Rank FROM tblbilling INNER JOIN tblbillinvoice ON tblbilling.BillingID = tblbillinvoice.BillingID INNER JOIN tblproduct ON tblbillinvoice.ProductID = tblproduct.ProductID WHERE tblbillinvoice.OrderID = 0 GROUP BY tblproduct.ProductName, DATE_FORMAT(tblbilling.DatePrinted, '%M %Y')) SELECT Month, ProductName, TotalAmount FROM MonthlyProductSales WHERE Rank = 1 ORDER BY STR_TO_DATE(Month, '%M %Y') ASC;", cn)
            da.Fill(ds.Tables("dtRentalReport"))

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            rptDS = New ReportDataSource("dtRentalTrends", ds.Tables("dtRentalReport"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub generateUserActivityLogs(startDate As String, endDate As String)
        Dim startDateTime As DateTime
        Dim endDateTime As DateTime
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\reportUserActivityLogs.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            If DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, startDateTime) AndAlso
            DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, endDateTime) Then

                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                da.SelectCommand = New MySqlCommand("SELECT Username, Action, DATE_FORMAT(DateTime, '%M %e, %Y    %l:%i %p') AS DateTime FROM tblactivity WHERE DateTime BETWEEN '" & startDate.ToString() & "' AND '" & endDate.ToString() & "'", cn)
                da.Fill(ds.Tables("dtAdminReport"))

                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End If

            rptDS = New ReportDataSource("dtReportActivityLogs", ds.Tables("dtAdminReport"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DateFilter1_TextChanged(sender As Object, e As EventArgs) Handles DateFilter1.TextChanged
        startDate = DateFilter1.Text
        generateUserActivityLogs(startDate, endDate)
    End Sub

    Private Sub DateFilter2_TextChanged(sender As Object, e As EventArgs) Handles DateFilter2.TextChanged
        endDate = DateFilter2.Text
        generateUserActivityLogs(startDate, endDate)
    End Sub
End Class