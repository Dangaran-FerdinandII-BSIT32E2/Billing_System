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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnRental = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnCollection = New System.Windows.Forms.Button()
        Me.btnBilling = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
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
        Me.panelDashboard = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnUser)
        Me.Panel1.Controls.Add(Me.btnRental)
        Me.Panel1.Controls.Add(Me.btnCustomer)
        Me.Panel1.Controls.Add(Me.btnProduct)
        Me.Panel1.Controls.Add(Me.btnSupplier)
        Me.Panel1.Controls.Add(Me.btnCollection)
        Me.Panel1.Controls.Add(Me.btnBilling)
        Me.Panel1.Controls.Add(Me.btnSales)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 945)
        Me.Panel1.TabIndex = 0
        '
        'btnUser
        '
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(0, 859)
        Me.btnUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(343, 90)
        Me.btnUser.TabIndex = 11
        Me.btnUser.Text = "     Admin"
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnRental
        '
        Me.btnRental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRental.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRental.FlatAppearance.BorderSize = 0
        Me.btnRental.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRental.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRental.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnRental.Image = CType(resources.GetObject("btnRental.Image"), System.Drawing.Image)
        Me.btnRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRental.Location = New System.Drawing.Point(0, 769)
        Me.btnRental.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRental.Name = "btnRental"
        Me.btnRental.Size = New System.Drawing.Size(343, 90)
        Me.btnRental.TabIndex = 10
        Me.btnRental.Text = "     Rental"
        Me.btnRental.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRental.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.Location = New System.Drawing.Point(0, 679)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(343, 90)
        Me.btnCustomer.TabIndex = 9
        Me.btnCustomer.Text = "     Customers"
        Me.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnProduct.Image = CType(resources.GetObject("btnProduct.Image"), System.Drawing.Image)
        Me.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduct.Location = New System.Drawing.Point(0, 589)
        Me.btnProduct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(343, 90)
        Me.btnProduct.TabIndex = 8
        Me.btnProduct.Text = "     Products"
        Me.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSupplier.FlatAppearance.BorderSize = 0
        Me.btnSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnSupplier.Image = CType(resources.GetObject("btnSupplier.Image"), System.Drawing.Image)
        Me.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupplier.Location = New System.Drawing.Point(0, 499)
        Me.btnSupplier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(343, 90)
        Me.btnSupplier.TabIndex = 5
        Me.btnSupplier.Text = "     Suppliers"
        Me.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'btnCollection
        '
        Me.btnCollection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCollection.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCollection.FlatAppearance.BorderSize = 0
        Me.btnCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCollection.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnCollection.Image = CType(resources.GetObject("btnCollection.Image"), System.Drawing.Image)
        Me.btnCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCollection.Location = New System.Drawing.Point(0, 409)
        Me.btnCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCollection.Name = "btnCollection"
        Me.btnCollection.Size = New System.Drawing.Size(343, 90)
        Me.btnCollection.TabIndex = 4
        Me.btnCollection.Text = "     Collection"
        Me.btnCollection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCollection.UseVisualStyleBackColor = True
        '
        'btnBilling
        '
        Me.btnBilling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBilling.FlatAppearance.BorderSize = 0
        Me.btnBilling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilling.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBilling.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnBilling.Image = CType(resources.GetObject("btnBilling.Image"), System.Drawing.Image)
        Me.btnBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBilling.Location = New System.Drawing.Point(0, 319)
        Me.btnBilling.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(343, 90)
        Me.btnBilling.TabIndex = 3
        Me.btnBilling.Text = "     Billing"
        Me.btnBilling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBilling.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnSales.Image = CType(resources.GetObject("btnSales.Image"), System.Drawing.Image)
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.Location = New System.Drawing.Point(0, 229)
        Me.btnSales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(343, 90)
        Me.btnSales.TabIndex = 2
        Me.btnSales.Text = "     Sales"
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 139)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(343, 90)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "     Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(343, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(343, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1478, 139)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.lblUsername)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(609, 47)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(555, 50)
        Me.Panel3.TabIndex = 11
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label22.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(189, 0)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(183, 40)
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
        Me.lblUsername.Location = New System.Drawing.Point(372, 0)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(183, 40)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "Username"
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 97)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1164, 42)
        Me.Panel9.TabIndex = 15
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1164, 47)
        Me.Panel8.TabIndex = 14
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblCount)
        Me.Panel6.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel6.Controls.Add(Me.btnNotification)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1164, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(157, 139)
        Me.Panel6.TabIndex = 13
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Red
        Me.lblCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Location = New System.Drawing.Point(89, 34)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(21, 24)
        Me.lblCount.TabIndex = 11
        Me.lblCount.Text = "1"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Red
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(81, 27)
        Me.Guna2CirclePictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(40, 37)
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
        Me.btnNotification.Location = New System.Drawing.Point(21, 15)
        Me.btnNotification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.PressedDepth = 20
        Me.btnNotification.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnNotification.Size = New System.Drawing.Size(120, 110)
        Me.btnNotification.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnSettings)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(1321, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(157, 139)
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
        Me.btnSettings.Location = New System.Drawing.Point(28, 18)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.PressedDepth = 20
        Me.btnSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnSettings.Size = New System.Drawing.Size(120, 110)
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
        Me.Panel5.Location = New System.Drawing.Point(343, 918)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1478, 27)
        Me.Panel5.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1019, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Role: "
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblRole.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(1098, 0)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(52, 29)
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
        Me.Label4.Location = New System.Drawing.Point(1150, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "     Time:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTime.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1261, 0)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(52, 29)
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
        Me.Label3.Location = New System.Drawing.Point(1313, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "     Date: "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblDate.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1426, 0)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(52, 29)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "xxx"
        '
        'panelDashboard
        '
        Me.panelDashboard.BackColor = System.Drawing.SystemColors.Control
        Me.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDashboard.Location = New System.Drawing.Point(343, 139)
        Me.panelDashboard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelDashboard.Name = "panelDashboard"
        Me.panelDashboard.Size = New System.Drawing.Size(1478, 779)
        Me.panelDashboard.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1821, 945)
        Me.Controls.Add(Me.panelDashboard)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnCollection As Button
    Friend WithEvents btnBilling As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents panelDashboard As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnSettings As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label22 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents btnRental As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnNotification As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblCount As Label
End Class
