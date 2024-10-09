Imports System.Data.SqlClient
Public Class frmAdminDashboard
    Private isFormBeingDragged As Boolean = False
    Private mouseDownX As Integer
    Private mouseDownY As Integer
    'Private isButtonClicked As Boolean = False

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = MouseButtons.Left Then
            isFormBeingDragged = True
            mouseDownX = e.X
            mouseDownY = e.Y
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        If e.Button = MouseButtons.Left Then
            isFormBeingDragged = False
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If isFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - mouseDownX)
            temp.Y = Me.Location.Y + (e.Y - mouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call connection()
        frmAnalyticsData.Chart1.Series("Sales").Points.AddXY("May", 50000)
        frmAnalyticsData.Chart1.Series("Sales").Points.AddXY("June", 100000)
        frmAnalyticsData.Chart1.Series("Sales").Points.AddXY("July", 200000)
        frmAnalyticsData.Chart1.Series("Sales").Points.AddXY("August", 300000)
        frmAnalyticsData.Chart1.Series("Sales").Points.AddXY("September", 500000)
        frmAnalyticsData.Chart1.Series("Sales").Points.AddXY("October", 1000000)


        frmAnalyticsData.TopLevel = False
        panelDashboard.Controls.Add(frmAnalyticsData)
        frmAnalyticsData.BringToFront()
        frmAnalyticsData.Dock = DockStyle.Fill
        frmAnalyticsData.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        frmAnalyticsData.TopLevel = False
        panelDashboard.Controls.Add(frmAnalyticsData)
        frmAnalyticsData.BringToFront()
        frmAnalyticsData.Dock = DockStyle.Fill
        frmAnalyticsData.Show()

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollection.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRental.Close()
        frmAdminSettings.Close()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        'If isButtonClicked Then
        '    ' Button clicked before, set back to original color
        '    btnSales.BackColor = Color.White  ' Replace with your original color
        '    isButtonClicked = False
        'Else
        '    ' Button clicked first time, set new color
        '    btnSales.BackColor = Color.FromArgb(228, 228, 228)
        '    isButtonClicked = True
        'End If

        frmManageSalesV2.TopLevel = False
        panelDashboard.Controls.Add(frmManageSalesV2)
        frmManageSalesV2.BringToFront()
        frmManageSalesV2.Dock = DockStyle.Fill
        frmManageSalesV2.Show()

        frmManageBilling.Close()
        frmManageCollection.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRental.Close()
        frmAdminSettings.Close()
    End Sub

    Private Sub btnBilling_Click_1(sender As Object, e As EventArgs) Handles btnBilling.Click
        'If isButtonClicked Then
        '    ' Button clicked before, set back to original color
        '    btnBilling.BackColor = Color.White  ' Replace with your original color
        '    isButtonClicked = False
        'Else
        '    ' Button clicked first time, set new color
        '    btnBilling.BackColor = Color.FromArgb(228, 228, 228)
        '    btnSales.BackColor = Color.White
        '    isButtonClicked = True
        'End If

        frmManageBilling.TopLevel = False
        panelDashboard.Controls.Add(frmManageBilling)
        frmManageBilling.BringToFront()
        frmManageBilling.Dock = DockStyle.Fill
        frmManageBilling.Show()

        frmManageSalesV2.Close()
        frmManageCollection.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRental.Close()
        frmAdminSettings.Close()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.ToShortTimeString
        lblDate.Text = Now.ToLongDateString
    End Sub

    'Private Sub btnLogout_Click(sender As Object, e As EventArgs) 
    '    Me.Close()
    'End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmAdminSettings.TopLevel = False
        panelDashboard.Controls.Add(frmAdminSettings)
        frmAdminSettings.BringToFront()
        frmAdminSettings.Dock = DockStyle.Fill
        frmAdminSettings.Show()

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollection.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRental.Close()
    End Sub

    Private Sub btnCollection_Click(sender As Object, e As EventArgs)
        frmManageCollection.TopLevel = False
        panelDashboard.Controls.Add(frmManageCollection)
        frmManageCollection.BringToFront()
        frmManageCollection.Dock = DockStyle.Fill
        frmManageCollection.Show()

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRental.Close()
        frmAdminSettings.Close()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        frmManageSupplierProduct.TopLevel = False
        panelDashboard.Controls.Add(frmManageSupplierProduct)
        frmManageSupplierProduct.BringToFront()
        frmManageSupplierProduct.Dock = DockStyle.Fill
        frmManageSupplierProduct.Show()

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollection.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRental.Close()
        frmAdminSettings.Close()
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs)
        frmManageProducts.TopLevel = False
        panelDashboard.Controls.Add(frmManageProducts)
        frmManageProducts.BringToFront()
        frmManageProducts.Dock = DockStyle.Fill
        frmManageProducts.Show()

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollection.Close()
        frmManageSuppliers.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmManageRental.Close()
        frmAdminSettings.Close()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmManageCustomerV3.TopLevel = False
        panelDashboard.Controls.Add(frmManageCustomerV3)
        frmManageCustomerV3.BringToFront()
        frmManageCustomerV3.Dock = DockStyle.Fill
        frmManageCustomerV3.Show()

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollection.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageUsers.Close()
        frmManageRental.Close()
        frmAdminSettings.Close()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        frmManageUsers.TopLevel = False
        panelDashboard.Controls.Add(frmManageUsers)
        frmManageUsers.BringToFront()
        frmManageUsers.Dock = DockStyle.Fill
        frmManageUsers.Show()

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollection.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageRental.Close()
        frmAdminSettings.Close()
    End Sub

    Private Sub btnRental_Click(sender As Object, e As EventArgs) Handles btnRental.Click
        frmManageRentalV2.TopLevel = False
        panelDashboard.Controls.Add(frmManageRentalV2)
        frmManageRentalV2.BringToFront()
        frmManageRentalV2.Dock = DockStyle.Fill
        frmManageRentalV2.Show()

        frmManageSalesV2.Close()
        frmManageBilling.Close()
        frmManageCollection.Close()
        frmManageSuppliers.Close()
        frmManageProducts.Close()
        frmManageCustomerV3.Close()
        frmManageUsers.Close()
        frmAdminSettings.Close()
    End Sub

    Private Sub btnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        frmManageInquiry.ShowDialog()
    End Sub
End Class