<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageCollection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabControl2 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.panelCollectionBody = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.btnShow = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtSearchCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.btnOkay = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.panelCollectionBody.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1109, 10)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 10)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(10, 623)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(1099, 10)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(10, 623)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(10, 623)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1089, 10)
        Me.FlowLayoutPanel4.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabControl2.Location = New System.Drawing.Point(10, 10)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1089, 613)
        Me.TabControl2.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabButtonHoverState.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TabControl2.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControl2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl2.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabButtonIdleState.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TabControl2.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabControl2.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl2.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.TabControl2.TabButtonSelectedState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.Blue
        Me.TabControl2.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TabControl2.TabIndex = 16
        Me.TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.panelCollectionBody)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1081, 565)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Collection"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'panelCollectionBody
        '
        Me.panelCollectionBody.Controls.Add(Me.Panel19)
        Me.panelCollectionBody.Controls.Add(Me.Panel17)
        Me.panelCollectionBody.Controls.Add(Me.Panel11)
        Me.panelCollectionBody.Controls.Add(Me.Panel5)
        Me.panelCollectionBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCollectionBody.Location = New System.Drawing.Point(3, 3)
        Me.panelCollectionBody.Name = "panelCollectionBody"
        Me.panelCollectionBody.Size = New System.Drawing.Size(1075, 559)
        Me.panelCollectionBody.TabIndex = 0
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.White
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Controls.Add(Me.Panel21)
        Me.Panel19.Controls.Add(Me.Panel22)
        Me.Panel19.Controls.Add(Me.Panel27)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel19.Location = New System.Drawing.Point(0, 499)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1075, 60)
        Me.Panel19.TabIndex = 20
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.White
        Me.Panel20.Controls.Add(Me.btnShow)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel20.Location = New System.Drawing.Point(10, 10)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(140, 40)
        Me.Panel20.TabIndex = 18
        '
        'btnShow
        '
        Me.btnShow.BorderRadius = 8
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnShow.FillColor = System.Drawing.Color.OrangeRed
        Me.btnShow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.PressedDepth = 20
        Me.btnShow.Size = New System.Drawing.Size(140, 40)
        Me.btnShow.TabIndex = 57
        Me.btnShow.Text = "Show"
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.White
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel21.Location = New System.Drawing.Point(0, 10)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(10, 40)
        Me.Panel21.TabIndex = 18
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.White
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel22.Location = New System.Drawing.Point(0, 50)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1075, 10)
        Me.Panel22.TabIndex = 18
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.White
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(0, 0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(1075, 10)
        Me.Panel27.TabIndex = 18
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.ListView1)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel17.Location = New System.Drawing.Point(0, 68)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1075, 491)
        Me.Panel17.TabIndex = 2
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.txtSearchCompanyName)
        Me.Panel11.Controls.Add(Me.Panel14)
        Me.Panel11.Controls.Add(Me.Panel15)
        Me.Panel11.Controls.Add(Me.Panel16)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 10)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1075, 58)
        Me.Panel11.TabIndex = 3
        '
        'txtSearchCompanyName
        '
        Me.txtSearchCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchCompanyName.DefaultText = ""
        Me.txtSearchCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchCompanyName.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSearchCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchCompanyName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearchCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtSearchCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSearchCompanyName.Location = New System.Drawing.Point(10, 10)
        Me.txtSearchCompanyName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchCompanyName.Name = "txtSearchCompanyName"
        Me.txtSearchCompanyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchCompanyName.PlaceholderText = "Search by company name"
        Me.txtSearchCompanyName.SelectedText = ""
        Me.txtSearchCompanyName.Size = New System.Drawing.Size(295, 37)
        Me.txtSearchCompanyName.TabIndex = 47
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 10)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(10, 37)
        Me.Panel14.TabIndex = 20
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.White
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel15.Location = New System.Drawing.Point(0, 47)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1075, 11)
        Me.Panel15.TabIndex = 20
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.White
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1075, 10)
        Me.Panel16.TabIndex = 19
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1075, 10)
        Me.Panel5.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Controls.Add(Me.Panel8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1081, 565)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Confirmation"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.ListView2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 61)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1075, 420)
        Me.Panel6.TabIndex = 3
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader2})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.HoverSelection = True
        Me.ListView2.Location = New System.Drawing.Point(0, 0)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1075, 420)
        Me.ListView2.TabIndex = 39
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Invoice Number"
        Me.ColumnHeader8.Width = 200
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Company Name"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 250
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Total Amount"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Proof of Payment"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 250
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Guna2TextBox1)
        Me.Panel7.Controls.Add(Me.Panel13)
        Me.Panel7.Controls.Add(Me.Panel12)
        Me.Panel7.Controls.Add(Me.Panel18)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1075, 58)
        Me.Panel7.TabIndex = 2
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(10, 10)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Search by company name, invoice number"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(338, 37)
        Me.Guna2TextBox1.TabIndex = 47
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.White
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 10)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(10, 37)
        Me.Panel13.TabIndex = 20
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 47)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1075, 11)
        Me.Panel12.TabIndex = 20
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.White
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1075, 10)
        Me.Panel18.TabIndex = 19
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(3, 481)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1075, 81)
        Me.Panel8.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.Panel23)
        Me.Panel9.Controls.Add(Me.Panel24)
        Me.Panel9.Controls.Add(Me.Panel25)
        Me.Panel9.Controls.Add(Me.Panel26)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 21)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1075, 60)
        Me.Panel9.TabIndex = 19
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.White
        Me.Panel23.Controls.Add(Me.btnOkay)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(10, 10)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(140, 40)
        Me.Panel23.TabIndex = 18
        '
        'btnOkay
        '
        Me.btnOkay.BorderRadius = 8
        Me.btnOkay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOkay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOkay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOkay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOkay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOkay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOkay.FillColor = System.Drawing.Color.OrangeRed
        Me.btnOkay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnOkay.ForeColor = System.Drawing.Color.White
        Me.btnOkay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOkay.Location = New System.Drawing.Point(0, 0)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.PressedDepth = 20
        Me.btnOkay.Size = New System.Drawing.Size(140, 40)
        Me.btnOkay.TabIndex = 57
        Me.btnOkay.Text = "Confirm"
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.White
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(0, 10)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(10, 40)
        Me.Panel24.TabIndex = 18
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.White
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel25.Location = New System.Drawing.Point(0, 50)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1075, 10)
        Me.Panel25.TabIndex = 18
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.White
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(1075, 10)
        Me.Panel26.TabIndex = 18
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1075, 491)
        Me.ListView1.TabIndex = 37
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Company Name"
        Me.ColumnHeader1.Width = 300
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Employee"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'frmManageCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 633)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.panelCollectionBody.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents TabControl2 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents panelCollectionBody As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtSearchCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents btnOkay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
