﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaymentInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentInformation))
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpload = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbxDelivery = New System.Windows.Forms.PictureBox()
        Me.Panel63 = New System.Windows.Forms.Panel()
        Me.Panel62 = New System.Windows.Forms.Panel()
        Me.Panel61 = New System.Windows.Forms.Panel()
        Me.Panel60 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.txtCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtUnpaidAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtPaidAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.btnCancelDelivery = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.AmountPaid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DatePaid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.panelBody.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel31.SuspendLayout()
        Me.Panel33.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.White
        Me.panelBody.Controls.Add(Me.Panel1)
        Me.panelBody.Controls.Add(Me.Panel9)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 0)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1028, 609)
        Me.panelBody.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel42)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel25)
        Me.Panel1.Controls.Add(Me.Panel22)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 559)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.Panel18)
        Me.Panel2.Controls.Add(Me.Panel23)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel33)
        Me.Panel2.Controls.Add(Me.Panel32)
        Me.Panel2.Controls.Add(Me.Panel31)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(661, 539)
        Me.Panel2.TabIndex = 125
        '
        'Panel42
        '
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel42.Location = New System.Drawing.Point(671, 10)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(10, 539)
        Me.Panel42.TabIndex = 123
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpload)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.pbxDelivery)
        Me.GroupBox1.Controls.Add(Me.Panel63)
        Me.GroupBox1.Controls.Add(Me.Panel62)
        Me.GroupBox1.Controls.Add(Me.Panel61)
        Me.GroupBox1.Controls.Add(Me.Panel60)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(681, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 539)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proof of Payment"
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Transparent
        Me.btnUpload.BorderRadius = 15
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpload.FillColor = System.Drawing.Color.OrangeRed
        Me.btnUpload.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpload.Location = New System.Drawing.Point(125, 260)
        Me.btnUpload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.PressedDepth = 20
        Me.btnUpload.ShadowDecoration.BorderRadius = 15
        Me.btnUpload.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.btnUpload.Size = New System.Drawing.Size(109, 36)
        Me.btnUpload.TabIndex = 10000013
        Me.btnUpload.Text = "Upload"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(134, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10000012
        Me.PictureBox2.TabStop = False
        '
        'pbxDelivery
        '
        Me.pbxDelivery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxDelivery.Location = New System.Drawing.Point(13, 32)
        Me.pbxDelivery.Name = "pbxDelivery"
        Me.pbxDelivery.Size = New System.Drawing.Size(311, 494)
        Me.pbxDelivery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDelivery.TabIndex = 3
        Me.pbxDelivery.TabStop = False
        '
        'Panel63
        '
        Me.Panel63.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel63.Location = New System.Drawing.Point(13, 526)
        Me.Panel63.Name = "Panel63"
        Me.Panel63.Size = New System.Drawing.Size(311, 10)
        Me.Panel63.TabIndex = 2
        '
        'Panel62
        '
        Me.Panel62.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel62.Location = New System.Drawing.Point(324, 32)
        Me.Panel62.Name = "Panel62"
        Me.Panel62.Size = New System.Drawing.Size(10, 504)
        Me.Panel62.TabIndex = 1
        '
        'Panel61
        '
        Me.Panel61.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel61.Location = New System.Drawing.Point(3, 32)
        Me.Panel61.Name = "Panel61"
        Me.Panel61.Size = New System.Drawing.Size(10, 504)
        Me.Panel61.TabIndex = 1
        '
        'Panel60
        '
        Me.Panel60.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel60.Location = New System.Drawing.Point(3, 22)
        Me.Panel60.Name = "Panel60"
        Me.Panel60.Size = New System.Drawing.Size(331, 10)
        Me.Panel60.TabIndex = 0
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(10, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1008, 10)
        Me.Panel22.TabIndex = 30
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 559)
        Me.Panel5.TabIndex = 29
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1018, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 559)
        Me.Panel6.TabIndex = 28
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Label2)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.Panel17)
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(241, 50)
        Me.Panel14.TabIndex = 13
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(241, 15)
        Me.Panel16.TabIndex = 13
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 40)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(241, 10)
        Me.Panel17.TabIndex = 13
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 15)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(10, 25)
        Me.Panel15.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 22)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Payment Information"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1028, 50)
        Me.Panel9.TabIndex = 5
        '
        'Panel31
        '
        Me.Panel31.Controls.Add(Me.Label8)
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel31.Location = New System.Drawing.Point(0, 0)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(661, 18)
        Me.Panel31.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 18)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Company Name"
        '
        'Panel33
        '
        Me.Panel33.Controls.Add(Me.txtCompanyName)
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel33.Location = New System.Drawing.Point(0, 28)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(661, 35)
        Me.Panel33.TabIndex = 7
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompanyName.DefaultText = ""
        Me.txtCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCompanyName.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtCompanyName.DisabledState.ForeColor = System.Drawing.Color.DimGray
        Me.txtCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCompanyName.Enabled = False
        Me.txtCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCompanyName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCompanyName.Location = New System.Drawing.Point(0, 0)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompanyName.PlaceholderText = ""
        Me.txtCompanyName.SelectedText = ""
        Me.txtCompanyName.Size = New System.Drawing.Size(661, 35)
        Me.txtCompanyName.TabIndex = 108
        '
        'Panel32
        '
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel32.Location = New System.Drawing.Point(0, 18)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(661, 10)
        Me.Panel32.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtUnpaidAmount)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(661, 35)
        Me.Panel3.TabIndex = 10
        '
        'txtUnpaidAmount
        '
        Me.txtUnpaidAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnpaidAmount.DefaultText = ""
        Me.txtUnpaidAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUnpaidAmount.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtUnpaidAmount.DisabledState.ForeColor = System.Drawing.Color.DimGray
        Me.txtUnpaidAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnpaidAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUnpaidAmount.Enabled = False
        Me.txtUnpaidAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnpaidAmount.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtUnpaidAmount.ForeColor = System.Drawing.Color.Black
        Me.txtUnpaidAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtUnpaidAmount.Location = New System.Drawing.Point(0, 0)
        Me.txtUnpaidAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnpaidAmount.Name = "txtUnpaidAmount"
        Me.txtUnpaidAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUnpaidAmount.PlaceholderText = ""
        Me.txtUnpaidAmount.SelectedText = ""
        Me.txtUnpaidAmount.Size = New System.Drawing.Size(661, 35)
        Me.txtUnpaidAmount.TabIndex = 108
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 81)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(661, 10)
        Me.Panel4.TabIndex = 9
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 63)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(661, 18)
        Me.Panel7.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Unpaid Amount"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtPaidAmount)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 154)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(661, 35)
        Me.Panel8.TabIndex = 13
        '
        'txtPaidAmount
        '
        Me.txtPaidAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPaidAmount.DefaultText = ""
        Me.txtPaidAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPaidAmount.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtPaidAmount.DisabledState.ForeColor = System.Drawing.Color.DimGray
        Me.txtPaidAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPaidAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPaidAmount.Enabled = False
        Me.txtPaidAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaidAmount.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtPaidAmount.ForeColor = System.Drawing.Color.Black
        Me.txtPaidAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPaidAmount.Location = New System.Drawing.Point(0, 0)
        Me.txtPaidAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPaidAmount.Name = "txtPaidAmount"
        Me.txtPaidAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaidAmount.PlaceholderText = ""
        Me.txtPaidAmount.SelectedText = ""
        Me.txtPaidAmount.Size = New System.Drawing.Size(661, 35)
        Me.txtPaidAmount.TabIndex = 108
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 144)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(661, 10)
        Me.Panel10.TabIndex = 12
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label3)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 126)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(661, 18)
        Me.Panel11.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Paid Amount"
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.btnCancelDelivery)
        Me.Panel23.Controls.Add(Me.Panel13)
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Controls.Add(Me.Panel68)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel23.Location = New System.Drawing.Point(0, 488)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(661, 51)
        Me.Panel23.TabIndex = 30
        '
        'btnCancelDelivery
        '
        Me.btnCancelDelivery.BorderRadius = 8
        Me.btnCancelDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancelDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancelDelivery.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancelDelivery.FillColor = System.Drawing.Color.OrangeRed
        Me.btnCancelDelivery.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelDelivery.ForeColor = System.Drawing.Color.White
        Me.btnCancelDelivery.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancelDelivery.Location = New System.Drawing.Point(130, 10)
        Me.btnCancelDelivery.Name = "btnCancelDelivery"
        Me.btnCancelDelivery.PressedDepth = 20
        Me.btnCancelDelivery.Size = New System.Drawing.Size(120, 41)
        Me.btnCancelDelivery.TabIndex = 42
        Me.btnCancelDelivery.Text = "Cancel"
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.btnSave)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(0, 10)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(120, 41)
        Me.Panel24.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 8
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PressedDepth = 20
        Me.btnSave.Size = New System.Drawing.Size(120, 41)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "Save"
        '
        'Panel68
        '
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(661, 10)
        Me.Panel68.TabIndex = 13
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.White
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel25.Location = New System.Drawing.Point(10, 549)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1008, 10)
        Me.Panel25.TabIndex = 31
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 189)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(661, 10)
        Me.Panel18.TabIndex = 31
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AmountPaid, Me.DatePaid})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 199)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(661, 289)
        Me.ListView1.TabIndex = 42
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'AmountPaid
        '
        Me.AmountPaid.Text = "Amount Paid"
        Me.AmountPaid.Width = 200
        '
        'DatePaid
        '
        Me.DatePaid.Text = "Date Paid"
        Me.DatePaid.Width = 300
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(120, 10)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(10, 41)
        Me.Panel13.TabIndex = 30
        '
        'frmPaymentInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPaymentInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelBody.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel31.ResumeLayout(False)
        Me.Panel31.PerformLayout()
        Me.Panel33.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelBody As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUpload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbxDelivery As PictureBox
    Friend WithEvents Panel63 As Panel
    Friend WithEvents Panel62 As Panel
    Friend WithEvents Panel61 As Panel
    Friend WithEvents Panel60 As Panel
    Friend WithEvents Panel42 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel33 As Panel
    Friend WithEvents txtCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtPaidAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtUnpaidAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel23 As Panel
    Friend WithEvents btnCancelDelivery As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel24 As Panel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel68 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents AmountPaid As ColumnHeader
    Friend WithEvents DatePaid As ColumnHeader
    Friend WithEvents Panel13 As Panel
End Class
