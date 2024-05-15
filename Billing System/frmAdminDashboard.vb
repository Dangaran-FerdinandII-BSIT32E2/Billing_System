Public Class frmAdminDashboard
    Private isFormBeingDragged As Boolean = False
    Private mouseDownX As Integer
    Private mouseDownY As Integer

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
        Call connection()
        frmAnalyticsData.TopLevel = False
        panelDashboard.Controls.Add(frmAnalyticsData)
        frmAnalyticsData.BringToFront()
        frmAnalyticsData.Show()
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        frmManageSuppliers.TopLevel = False
        panelDashboard.Controls.Add(frmManageSuppliers)
        frmManageSuppliers.BringToFront()
        frmManageSuppliers.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        frmAnalyticsData.TopLevel = False
        panelDashboard.Controls.Add(frmAnalyticsData)
        frmAnalyticsData.BringToFront()
        frmAnalyticsData.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.ToShortTimeString
        lblDate.Text = Now.ToLongDateString
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmAdminSettings.TopLevel = False
        panelDashboard.Controls.Add(frmAdminSettings)
        frmAdminSettings.BringToFront()
        frmAdminSettings.Show()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        frmManageProducts.TopLevel = False
        panelDashboard.Controls.Add(frmManageProducts)
        frmManageProducts.BringToFront()
        frmManageProducts.Show()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        frmManageCustomers.TopLevel = False
        panelDashboard.Controls.Add(frmManageCustomers)
        frmManageCustomers.BringToFront()
        frmManageCustomers.Show()
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        frmManageUsers.TopLevel = False
        panelDashboard.Controls.Add(frmManageUsers)
        frmManageUsers.BringToFront()
        frmManageUsers.Show()
    End Sub
End Class