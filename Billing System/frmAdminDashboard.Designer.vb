<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminDashboard))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnNotification = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnSettings = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCollection = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSales = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSupplier = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btnOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRental = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.panelDashboard = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 113)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.lblUsername)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(714, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(416, 72)
        Me.Panel4.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label22.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(117, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(151, 32)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Welcome, "
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblUsername.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblUsername.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(268, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(148, 32)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "Username"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(257, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(873, 41)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblCount)
        Me.Panel6.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel6.Controls.Add(Me.btnNotification)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1130, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(118, 113)
        Me.Panel6.TabIndex = 13
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Red
        Me.lblCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Location = New System.Drawing.Point(67, 28)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(18, 19)
        Me.lblCount.TabIndex = 11
        Me.lblCount.Text = "1"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Red
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(61, 22)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'btnNotification
        '
        Me.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotification.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNotification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNotification.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNotification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNotification.FillColor = System.Drawing.Color.Transparent
        Me.btnNotification.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNotification.ForeColor = System.Drawing.Color.White
        Me.btnNotification.Image = CType(resources.GetObject("btnNotification.Image"), System.Drawing.Image)
        Me.btnNotification.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnNotification.Location = New System.Drawing.Point(16, 12)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.PressedDepth = 20
        Me.btnNotification.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnNotification.Size = New System.Drawing.Size(90, 89)
        Me.btnNotification.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnSettings)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(1248, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(118, 113)
        Me.Panel7.TabIndex = 12
        '
        'btnSettings
        '
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSettings.FillColor = System.Drawing.Color.Transparent
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnSettings.Location = New System.Drawing.Point(21, 15)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.PressedDepth = 20
        Me.btnSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnSettings.Size = New System.Drawing.Size(90, 89)
        Me.btnSettings.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lblRole)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.lblTime)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.lblDate)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(257, 746)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1109, 22)
        Me.Panel5.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(740, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Role: "
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblRole.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(803, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(43, 22)
        Me.lblRole.TabIndex = 4
        Me.lblRole.Text = "xxx"
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(846, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "     Time:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTime.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(934, 0)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(43, 22)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "xxx"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(977, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "     Date: "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblDate.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1066, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 22)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "xxx"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 30000
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnUser)
        Me.Panel1.Controls.Add(Me.btnCollection)
        Me.Panel1.Controls.Add(Me.btnBilling)
        Me.Panel1.Controls.Add(Me.btnSales)
        Me.Panel1.Controls.Add(Me.btnSupplier)
        Me.Panel1.Controls.Add(Me.btnProduct)
        Me.Panel1.Controls.Add(Me.btnOrder)
        Me.Panel1.Controls.Add(Me.btnRental)
        Me.Panel1.Controls.Add(Me.btnCustomer)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 113)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 655)
        Me.Panel1.TabIndex = 4
        '
        'btnUser
        '
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FillColor = System.Drawing.Color.Empty
        Me.btnUser.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUser.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnUser.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnUser.Location = New System.Drawing.Point(0, 657)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnUser.Size = New System.Drawing.Size(240, 73)
        Me.btnUser.TabIndex = 26
        Me.btnUser.Text = "Admin"
        Me.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnCollection
        '
        Me.btnCollection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCollection.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCollection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCollection.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCollection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCollection.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCollection.FillColor = System.Drawing.Color.Empty
        Me.btnCollection.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnCollection.Image = CType(resources.GetObject("btnCollection.Image"), System.Drawing.Image)
        Me.btnCollection.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCollection.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnCollection.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnCollection.Location = New System.Drawing.Point(0, 584)
        Me.btnCollection.Name = "btnCollection"
        Me.btnCollection.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnCollection.Size = New System.Drawing.Size(240, 73)
        Me.btnCollection.TabIndex = 25
        Me.btnCollection.Text = "Collection"
        Me.btnCollection.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnBilling
        '
        Me.btnBilling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBilling.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBilling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBilling.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBilling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBilling.FillColor = System.Drawing.Color.Empty
        Me.btnBilling.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBilling.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnBilling.Image = CType(resources.GetObject("btnBilling.Image"), System.Drawing.Image)
        Me.btnBilling.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBilling.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnBilling.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnBilling.Location = New System.Drawing.Point(0, 511)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnBilling.Size = New System.Drawing.Size(240, 73)
        Me.btnBilling.TabIndex = 24
        Me.btnBilling.Text = "Billing"
        Me.btnBilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSales
        '
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FillColor = System.Drawing.Color.Empty
        Me.btnSales.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnSales.Image = CType(resources.GetObject("btnSales.Image"), System.Drawing.Image)
        Me.btnSales.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSales.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnSales.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnSales.Location = New System.Drawing.Point(0, 438)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnSales.Size = New System.Drawing.Size(240, 73)
        Me.btnSales.TabIndex = 23
        Me.btnSales.Text = "Sales"
        Me.btnSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSupplier
        '
        Me.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSupplier.FillColor = System.Drawing.Color.Empty
        Me.btnSupplier.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnSupplier.Image = CType(resources.GetObject("btnSupplier.Image"), System.Drawing.Image)
        Me.btnSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSupplier.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnSupplier.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnSupplier.Location = New System.Drawing.Point(0, 365)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnSupplier.Size = New System.Drawing.Size(240, 73)
        Me.btnSupplier.TabIndex = 22
        Me.btnSupplier.Text = "Suppliers"
        Me.btnSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnProduct
        '
        Me.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProduct.FillColor = System.Drawing.Color.Empty
        Me.btnProduct.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnProduct.Image = CType(resources.GetObject("btnProduct.Image"), System.Drawing.Image)
        Me.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnProduct.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnProduct.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnProduct.Location = New System.Drawing.Point(0, 292)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnProduct.Size = New System.Drawing.Size(240, 73)
        Me.btnProduct.TabIndex = 21
        Me.btnProduct.Text = "Product"
        Me.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnOrder
        '
        Me.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrder.FillColor = System.Drawing.Color.Empty
        Me.btnOrder.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnOrder.Image = CType(resources.GetObject("btnOrder.Image"), System.Drawing.Image)
        Me.btnOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOrder.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnOrder.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnOrder.Location = New System.Drawing.Point(0, 219)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnOrder.Size = New System.Drawing.Size(240, 73)
        Me.btnOrder.TabIndex = 20
        Me.btnOrder.Text = "Orders"
        Me.btnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnRental
        '
        Me.btnRental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRental.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRental.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRental.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRental.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRental.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRental.FillColor = System.Drawing.Color.Empty
        Me.btnRental.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRental.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnRental.Image = CType(resources.GetObject("btnRental.Image"), System.Drawing.Image)
        Me.btnRental.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRental.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnRental.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnRental.Location = New System.Drawing.Point(0, 146)
        Me.btnRental.Name = "btnRental"
        Me.btnRental.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnRental.Size = New System.Drawing.Size(240, 73)
        Me.btnRental.TabIndex = 19
        Me.btnRental.Text = "Rental"
        Me.btnRental.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnCustomer
        '
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomer.FillColor = System.Drawing.Color.Empty
        Me.btnCustomer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCustomer.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnCustomer.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnCustomer.Location = New System.Drawing.Point(0, 73)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnCustomer.Size = New System.Drawing.Size(240, 73)
        Me.btnCustomer.TabIndex = 16
        Me.btnCustomer.Text = "Customers"
        Me.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FillColor = System.Drawing.Color.Empty
        Me.btnDashboard.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(240, 73)
        Me.btnDashboard.TabIndex = 11
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel8
        '
        Me.Panel8.Location = New System.Drawing.Point(12, 753)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(35, 55)
        Me.Panel8.TabIndex = 0
        '
        'panelDashboard
        '
        Me.panelDashboard.BackColor = System.Drawing.SystemColors.Control
        Me.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDashboard.Location = New System.Drawing.Point(257, 113)
        Me.panelDashboard.Name = "panelDashboard"
        Me.panelDashboard.Size = New System.Drawing.Size(1109, 655)
        Me.panelDashboard.TabIndex = 5
        '
        'frmAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.panelDashboard)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnSettings As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnNotification As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblCount As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCollection As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSales As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSupplier As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRental As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents panelDashboard As Panel
End Class
