﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.panelDashboard = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnNotification = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panelBody.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.panelDashboard)
        Me.panelBody.Controls.Add(Me.Panel9)
        Me.panelBody.Controls.Add(Me.Panel3)
        Me.panelBody.Controls.Add(Me.Panel1)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 0)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1366, 768)
        Me.panelBody.TabIndex = 0
        '
        'panelDashboard
        '
        Me.panelDashboard.BackColor = System.Drawing.SystemColors.Control
        Me.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDashboard.Location = New System.Drawing.Point(257, 89)
        Me.panelDashboard.Name = "panelDashboard"
        Me.panelDashboard.Size = New System.Drawing.Size(1109, 657)
        Me.panelDashboard.TabIndex = 11
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel9.Controls.Add(Me.lblStatus)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.lblRole)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Controls.Add(Me.lblTime)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.lblDate)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(257, 746)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1109, 22)
        Me.Panel9.TabIndex = 8
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(53, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 22)
        Me.lblStatus.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Log:"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(257, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1109, 89)
        Me.Panel3.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "click me to show notif"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.lblUsername)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(575, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(416, 62)
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
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(991, 27)
        Me.Panel5.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblCount)
        Me.Panel6.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel6.Controls.Add(Me.btnNotification)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(991, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(118, 89)
        Me.Panel6.TabIndex = 13
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Red
        Me.lblCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblCount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Location = New System.Drawing.Point(66, 19)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(14, 15)
        Me.lblCount.TabIndex = 11
        Me.lblCount.Text = "1"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Red
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(60, 15)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(25, 25)
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
        Me.btnNotification.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnNotification.Location = New System.Drawing.Point(26, 12)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.PressedDepth = 20
        Me.btnNotification.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnNotification.Size = New System.Drawing.Size(68, 61)
        Me.btnNotification.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 768)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnUser)
        Me.Panel2.Controls.Add(Me.btnCollection)
        Me.Panel2.Controls.Add(Me.btnBilling)
        Me.Panel2.Controls.Add(Me.btnSales)
        Me.Panel2.Controls.Add(Me.btnSupplier)
        Me.Panel2.Controls.Add(Me.btnProduct)
        Me.Panel2.Controls.Add(Me.btnOrder)
        Me.Panel2.Controls.Add(Me.btnRental)
        Me.Panel2.Controls.Add(Me.btnCustomer)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 113)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 655)
        Me.Panel2.TabIndex = 17
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 730)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(240, 93)
        Me.Panel7.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.Empty
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnLogout.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnLogout.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnLogout.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnLogout.Location = New System.Drawing.Point(0, 823)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(240, 73)
        Me.btnLogout.TabIndex = 27
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnProduct.Text = "Products"
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
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
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
        'frmAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelBody.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelBody As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblCount As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents panelDashboard As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnNotification As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus As Label
End Class
