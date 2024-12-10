Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Guna.UI2.AnimatorNS
Imports System.Web.UI.Design
Imports System.ComponentModel
Imports System.Diagnostics

Public Class frmAdminDashboard
    Dim removeThickness As New Padding(0, 0, 0, 0) 'use to remove border left
    Dim addThickness As New Padding(5, 0, 0, 0) 'use to add border left
    Dim addColor As Color = Color.OrangeRed 'use to filled color border left
    Dim removeColor As Color = Color.Empty 'use to removed filled color border left

    Private isFormBeingDragged As Boolean = False
    Private mouseDownX As Integer
    Private mouseDownY As Integer
    'Private isButtonClicked As Boolean = False

    'load form
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Me.btnDashboard
        Call loadNotification()
        Call loadRoles()
        'frmNotifNewOrder.Show()
        btnDashboard.CustomBorderThickness = addThickness
        btnDashboard.CustomBorderColor = addColor

        'LEVEL OF ACCESS IN DASHBOARD
        If lblRole.Text = "Sales" Then
            frmDashboardSales.TopLevel = False
            panelDashboard.Controls.Add(frmDashboardSales)
            frmDashboardSales.BringToFront()
            frmDashboardSales.Dock = DockStyle.Fill
            frmDashboardSales.Show()
        ElseIf lblRole.Text = "Purchaser" Then
            frmDashboardPurchaser.TopLevel = False
            panelDashboard.Controls.Add(frmDashboardPurchaser)
            frmDashboardPurchaser.BringToFront()
            frmDashboardPurchaser.Dock = DockStyle.Fill
            frmDashboardPurchaser.Show()
        ElseIf lblRole.Text = "Controller" Then
            frmDashboardController.TopLevel = False
            panelDashboard.Controls.Add(frmDashboardController)
            frmDashboardController.BringToFront()
            frmDashboardController.Dock = DockStyle.Fill
            frmDashboardController.Show()
        Else
            'ADMIN ROLE
            frmAnalyticsData.TopLevel = False
            panelDashboard.Controls.Add(frmAnalyticsData)
            frmAnalyticsData.BringToFront()
            frmAnalyticsData.Dock = DockStyle.Fill
            frmAnalyticsData.Show()
        End If

        'color button indicator
        btnDashboard.CustomBorderThickness = addThickness
        btnDashboard.CustomBorderColor = addColor

        'remove color indicator
        Dim buttons() As Guna2Button = {btnProduct, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next
    End Sub

    Public Sub loadNotification() Handles Timer2.Tick
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT COUNT(InquiryID) AS TotalInquiries FROM tblinquiry"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblCount.Text = dr("TotalInquiries").ToString()
            End If
            dr.Close()

            If lblCount.Text = "0" Then
                lblCount.Visible = False
                Guna2CirclePictureBox1.Visible = False
            Else
                lblCount.Visible = True
                Guna2CirclePictureBox1.Visible = True
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmAdminDashboard(loadNotification): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub loadRoles()
        btnSales.Visible = True
        btnOrder.Visible = True
        btnRental.Visible = True

        btnBilling.Visible = True
        btnCollection.Visible = True
        btnCustomer.Visible = True
        btnSupplier.Visible = True
        btnUser.Visible = True

        Select Case lblRole.Text
            'SALES, BILLING, COLLECTION, ORDER, RENTAL MODULE
            Case "Sales"
                btnSales.Visible = True
                btnBilling.Visible = True
                btnCollection.Visible = True
                btnOrder.Visible = True
                btnRental.Visible = True

                btnCustomer.Visible = False
                btnSupplier.Visible = False
                btnProduct.Visible = False
                btnUser.Visible = False

                panelBody.AutoScroll = False

            'COLLECTION, CUSTOMER, SUPPLIER MODULE
            Case "Controller"
                btnCollection.Visible = True
                btnCustomer.Visible = True
                btnSupplier.Visible = True

                btnSales.Visible = False
                btnProduct.Visible = False
                btnOrder.Visible = False
                btnBilling.Visible = False
                btnRental.Visible = False
                btnUser.Visible = False

                panelBody.AutoScroll = False

            'CUSTOMER, SUPPLIER, PRODUCT MODULE
            Case "Purchaser"
                btnCustomer.Visible = True
                btnSupplier.Visible = True
                btnProduct.Visible = True

                btnBilling.Visible = False
                btnSales.Visible = False
                btnOrder.Visible = False
                btnRental.Visible = False
                btnCollection.Visible = False
                btnUser.Visible = False

                panelBody.AutoScroll = False
            Case Else
                'ADMIN ROLE
                btnSales.Visible = True
                btnOrder.Visible = True
                btnRental.Visible = True
                btnBilling.Visible = True
                btnCollection.Visible = True
                btnCustomer.Visible = True
                btnSupplier.Visible = True
                btnProduct.Visible = True
                btnUser.Visible = True
        End Select
    End Sub

    'DASHBOARD MODULE
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        If lblRole.Text = "Sales" Then
            frmDashboardSales.TopLevel = False
            panelDashboard.Controls.Add(frmDashboardSales)
            frmDashboardSales.BringToFront()
            frmDashboardSales.Dock = DockStyle.Fill
            frmDashboardSales.Show()
        ElseIf lblRole.Text = "Purchaser" Then
            frmDashboardPurchaser.TopLevel = False
            panelDashboard.Controls.Add(frmDashboardPurchaser)
            frmDashboardPurchaser.BringToFront()
            frmDashboardPurchaser.Dock = DockStyle.Fill
            frmDashboardPurchaser.Show()
        ElseIf lblRole.Text = "Controller" Then
            frmDashboardController.TopLevel = False
            panelDashboard.Controls.Add(frmDashboardController)
            frmDashboardController.BringToFront()
            frmDashboardController.Dock = DockStyle.Fill
            frmDashboardController.Show()
        Else
            'ADMIN ROLE
            frmAnalyticsData.TopLevel = False
            panelDashboard.Controls.Add(frmAnalyticsData)
            frmAnalyticsData.BringToFront()
            frmAnalyticsData.Dock = DockStyle.Fill
            frmAnalyticsData.Show()
        End If

        'color button indicator
        btnDashboard.CustomBorderThickness = addThickness
        btnDashboard.CustomBorderColor = addColor

        'remove color indicator
        Dim buttons() As Guna2Button = {btnProduct, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollectionV3.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRentalV2.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub

    'CUSTOMER MODULE
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmManageCustomerV3.TopLevel = False
        panelDashboard.Controls.Add(frmManageCustomerV3)
        frmManageCustomerV3.BringToFront()
        frmManageCustomerV3.Dock = DockStyle.Fill
        frmManageCustomerV3.Show()

        btnCustomer.CustomBorderThickness = addThickness
        btnCustomer.CustomBorderColor = addColor

        'Dim buttons() As Guna2Button = {btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser}
        Dim buttons() As Guna2Button = {btnProduct, btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnSupplier, btnRental, btnUser}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollectionV3.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageUsers.Close()
        frmManageRentalV2.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub

    'RENTAL MODULE
    Private Sub btnRental_Click(sender As Object, e As EventArgs) Handles btnRental.Click
        frmManageRentalV2.TopLevel = False
        panelDashboard.Controls.Add(frmManageRentalV2)
        frmManageRentalV2.BringToFront()
        frmManageRentalV2.Dock = DockStyle.Fill
        frmManageRentalV2.Show()

        btnRental.CustomBorderThickness = addThickness
        btnRental.CustomBorderColor = addColor

        'btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser
        Dim buttons() As Guna2Button = {btnProduct, btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnUser}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollectionV3.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub

    'ORDER MODULE
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        frmManageOrder.TopLevel = False
        panelDashboard.Controls.Add(frmManageOrder)
        frmManageOrder.BringToFront()
        frmManageOrder.Dock = DockStyle.Fill
        frmManageOrder.Show()

        btnOrder.CustomBorderThickness = addThickness
        btnOrder.CustomBorderColor = addColor

        'btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser
        Dim buttons() As Guna2Button = {btnProduct, btnDashboard, btnSales, btnBilling, btnCollection, btnCustomer, btnSupplier, btnUser, btnRental}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollectionV3.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub

    'PRODUCT MODULE
    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        frmProduct.TopLevel = False
        panelDashboard.Controls.Add(frmProduct)
        frmProduct.BringToFront()
        frmProduct.Dock = DockStyle.Fill
        frmProduct.Show()

        btnProduct.CustomBorderThickness = addThickness
        btnProduct.CustomBorderColor = addColor

        Dim buttons() As Guna2Button = {btnDashboard, btnCustomer, btnBilling, btnCollection, btnOrder, btnSupplier, btnRental, btnUser, btnSales}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageBilling.Close()
        frmManageCollectionV3.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRentalV2.Close()
        frmAdminSettings.Close()
        frmManageSalesV2.Close()
    End Sub

    'SALES MODULE
    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        frmManageSalesV2.TopLevel = False
        panelDashboard.Controls.Add(frmManageSalesV2)
        frmManageSalesV2.BringToFront()
        frmManageSalesV2.Dock = DockStyle.Fill
        frmManageSalesV2.Show()

        btnSales.CustomBorderThickness = addThickness
        btnSales.CustomBorderColor = addColor

        Dim buttons() As Guna2Button = {btnProduct, btnDashboard, btnCustomer, btnBilling, btnCollection, btnOrder, btnSupplier, btnRental, btnUser, btnProduct}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageBilling.Close()
        frmManageCollectionV3.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRentalV2.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub

    'BILLING MODULE
    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        frmManageBilling.TopLevel = False
        panelDashboard.Controls.Add(frmManageBilling)
        frmManageBilling.BringToFront()
        frmManageBilling.Dock = DockStyle.Fill
        frmManageBilling.Show()

        btnBilling.CustomBorderThickness = addThickness
        btnBilling.CustomBorderColor = addColor

        Dim buttons() As Guna2Button = {btnProduct, btnDashboard, btnSales, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageSalesV2.Close()
        frmManageCollectionV3.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRentalV2.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub

    'COLLECTION MODULE
    Private Sub btnCollection_Click(sender As Object, e As EventArgs) Handles btnCollection.Click
        frmManageCollectionV3.TopLevel = False
        panelDashboard.Controls.Add(frmManageCollectionV3)
        frmManageCollectionV3.BringToFront()
        frmManageCollectionV3.Dock = DockStyle.Fill
        frmManageCollectionV3.Show()

        btnCollection.CustomBorderThickness = addThickness
        btnCollection.CustomBorderColor = addColor

        Dim buttons() As Guna2Button = {btnProduct, btnDashboard, btnSales, btnBilling, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRentalV2.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub

    'SUPPLIER MODULE
    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        frmManageSuppliers.TopLevel = False
        panelDashboard.Controls.Add(frmManageSuppliers)
        frmManageSuppliers.BringToFront()
        frmManageSuppliers.Dock = DockStyle.Fill
        frmManageSuppliers.Show()

        btnSupplier.CustomBorderThickness = addThickness
        btnSupplier.CustomBorderColor = addColor

        Dim buttons() As Guna2Button = {btnProduct, btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnRental, btnUser}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollectionV3.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRentalV2.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub

    'ADMIN MODULE
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        frmManageUsers.TopLevel = False
        panelDashboard.Controls.Add(frmManageUsers)
        frmManageUsers.BringToFront()
        frmManageUsers.Dock = DockStyle.Fill
        frmManageUsers.Show()

        btnUser.CustomBorderThickness = addThickness
        btnUser.CustomBorderColor = addColor

        'btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser
        Dim buttons() As Guna2Button = {btnProduct, btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental}

        For Each btn In buttons
            btn.CustomBorderThickness = removeThickness
            btn.CustomBorderColor = removeColor
        Next

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollectionV3.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageRentalV2.Close()
        frmAdminSettings.Close()
        frmProduct.Close()
    End Sub

    ''SETTINGS MODULE
    'Private Sub btnSettings_Click(sender As Object, e As EventArgs)
    '    frmAdminSettings.TopLevel = False
    '    panelDashboard.Controls.Add(frmAdminSettings)
    '    frmAdminSettings.BringToFront()
    '    frmAdminSettings.Dock = DockStyle.Fill
    '    frmAdminSettings.Show()

    '    'btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser
    '    Dim buttons() As Guna2Button = {btnProduct, btnDashboard, btnSales, btnBilling, btnCollection, btnOrder, btnCustomer, btnSupplier, btnRental, btnUser}

    '    For Each btn In buttons
    '        btn.CustomBorderThickness = removeThickness
    '        btn.CustomBorderColor = removeColor
    '    Next

    '    frmManageSalesV2.Close()
    '    frmManageBilling.Close()
    '    frmManageCollectionV3.Close()
    '    frmManageSuppliers.Close()
    '    frmManageProducts.Close()
    '    frmManageCustomerV3.Close()
    '    frmManageUsers.Close()
    '    frmManageRentalV2.Close()
    '    frmProduct.Close()
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.ToShortTimeString
        lblDate.Text = Now.ToLongDateString
    End Sub

    Private Sub btnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        frmManageInquiry.ShowDialog()
        'frmManageNotifications.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmNotifNewOrder.Show()
    End Sub

    Private Sub panelBody_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isFormBeingDragged = True
            mouseDownX = e.X
            mouseDownY = e.Y
        End If
    End Sub

    Private Sub panelBody_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isFormBeingDragged = False
        End If
    End Sub

    'USE TO MOVE DASHBOARD
    Private Sub panelBody_MouseMove(sender As Object, e As MouseEventArgs)
        If isFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - mouseDownX)
            temp.Y = Me.Location.Y + (e.Y - mouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    'logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Call connection()
        Call loadActivity()
        Me.Close()
        'Environment.Exit(0)

        frmLoginV2.txtUsername.Clear()
        frmLoginV2.txtPassword.Clear()

        frmLoginV2.ActiveControl = frmLoginV2.txtUsername
        frmLoginV2.Show()
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
                .Parameters.AddWithValue("@Action", "LOGOUT")
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'frmPrintSalesInvoice.ShowDialog()
        frmPrintBillingInvoiceV2.ShowDialog()
    End Sub

    Private Sub btnShowWebsite_Click(sender As Object, e As EventArgs) Handles btnShowWebsite.Click
        Dim url As String = "http://localhost/CapstoneWebsite/login-admin.php"
        Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})

    End Sub
End Class