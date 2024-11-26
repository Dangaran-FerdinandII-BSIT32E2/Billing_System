<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestockProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.lblManageProduct = New System.Windows.Forms.Label()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPONo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.Panel40 = New System.Windows.Forms.Panel()
        Me.btnCancelSupp = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.Panel38 = New System.Windows.Forms.Panel()
        Me.btnSendRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.txtSupplier = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxProduct = New System.Windows.Forms.PictureBox()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.btnQuantity = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.Panel53 = New System.Windows.Forms.Panel()
        Me.Panel54 = New System.Windows.Forms.Panel()
        Me.Panel55 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel37.SuspendLayout()
        Me.Panel40.SuspendLayout()
        Me.Panel38.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.panelBody.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel34.SuspendLayout()
        Me.Panel35.SuspendLayout()
        Me.Panel43.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(953, 50)
        Me.Panel19.TabIndex = 4
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.lblManageProduct)
        Me.Panel20.Controls.Add(Me.Panel21)
        Me.Panel20.Controls.Add(Me.Panel28)
        Me.Panel20.Controls.Add(Me.Panel29)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(265, 50)
        Me.Panel20.TabIndex = 13
        '
        'lblManageProduct
        '
        Me.lblManageProduct.AutoSize = True
        Me.lblManageProduct.BackColor = System.Drawing.Color.Transparent
        Me.lblManageProduct.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblManageProduct.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblManageProduct.ForeColor = System.Drawing.Color.White
        Me.lblManageProduct.Location = New System.Drawing.Point(10, 15)
        Me.lblManageProduct.Name = "lblManageProduct"
        Me.lblManageProduct.Size = New System.Drawing.Size(181, 22)
        Me.lblManageProduct.TabIndex = 32
        Me.lblManageProduct.Text = "Replenish Product"
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel21.Location = New System.Drawing.Point(0, 15)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(10, 25)
        Me.Panel21.TabIndex = 13
        '
        'Panel28
        '
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel28.Location = New System.Drawing.Point(0, 40)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(265, 10)
        Me.Panel28.TabIndex = 13
        '
        'Panel29
        '
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel29.Location = New System.Drawing.Point(0, 0)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(265, 15)
        Me.Panel29.TabIndex = 13
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 50)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(953, 10)
        Me.Panel6.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 60)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 514)
        Me.Panel7.TabIndex = 15
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(943, 60)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 514)
        Me.Panel8.TabIndex = 16
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(10, 564)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(933, 10)
        Me.Panel9.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.Panel37)
        Me.GroupBox2.Controls.Add(Me.Panel27)
        Me.GroupBox2.Controls.Add(Me.Panel22)
        Me.GroupBox2.Controls.Add(Me.Panel23)
        Me.GroupBox2.Controls.Add(Me.Panel24)
        Me.GroupBox2.Controls.Add(Me.Panel12)
        Me.GroupBox2.Controls.Add(Me.Panel11)
        Me.GroupBox2.Controls.Add(Me.Panel10)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 504)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Restock Information"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductName, Me.Quantity})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 192)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(447, 249)
        Me.ListView1.TabIndex = 41
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ProductName
        '
        Me.ProductName.Text = "Product Name"
        Me.ProductName.Width = 150
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 150
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(13, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 10)
        Me.Panel1.TabIndex = 40
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtPONo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(13, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 35)
        Me.Panel2.TabIndex = 39
        '
        'txtPONo
        '
        Me.txtPONo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPONo.DefaultText = ""
        Me.txtPONo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPONo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPONo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPONo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPONo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPONo.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.txtPONo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtPONo.ForeColor = System.Drawing.Color.Black
        Me.txtPONo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPONo.Location = New System.Drawing.Point(0, 0)
        Me.txtPONo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPONo.PlaceholderText = "Enter purchase order number"
        Me.txtPONo.SelectedText = ""
        Me.txtPONo.Size = New System.Drawing.Size(447, 35)
        Me.txtPONo.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(13, 122)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(447, 25)
        Me.Panel3.TabIndex = 38
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
        Me.Label1.Size = New System.Drawing.Size(177, 18)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Purchase Order Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(13, 112)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(447, 10)
        Me.Panel4.TabIndex = 37
        '
        'Panel37
        '
        Me.Panel37.BackColor = System.Drawing.Color.White
        Me.Panel37.Controls.Add(Me.Panel40)
        Me.Panel37.Controls.Add(Me.Panel39)
        Me.Panel37.Controls.Add(Me.Panel38)
        Me.Panel37.Controls.Add(Me.Panel41)
        Me.Panel37.Controls.Add(Me.Panel42)
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel37.Location = New System.Drawing.Point(13, 441)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(447, 60)
        Me.Panel37.TabIndex = 36
        '
        'Panel40
        '
        Me.Panel40.BackColor = System.Drawing.Color.White
        Me.Panel40.Controls.Add(Me.btnCancelSupp)
        Me.Panel40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel40.Location = New System.Drawing.Point(227, 10)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(220, 40)
        Me.Panel40.TabIndex = 18
        '
        'btnCancelSupp
        '
        Me.btnCancelSupp.BorderRadius = 8
        Me.btnCancelSupp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSupp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelSupp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelSupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancelSupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancelSupp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelSupp.FillColor = System.Drawing.Color.OrangeRed
        Me.btnCancelSupp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelSupp.ForeColor = System.Drawing.Color.White
        Me.btnCancelSupp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancelSupp.Location = New System.Drawing.Point(0, 0)
        Me.btnCancelSupp.Name = "btnCancelSupp"
        Me.btnCancelSupp.PressedDepth = 20
        Me.btnCancelSupp.Size = New System.Drawing.Size(220, 40)
        Me.btnCancelSupp.TabIndex = 56
        Me.btnCancelSupp.TabStop = False
        Me.btnCancelSupp.Text = "Cancel"
        '
        'Panel39
        '
        Me.Panel39.BackColor = System.Drawing.Color.White
        Me.Panel39.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel39.Location = New System.Drawing.Point(217, 10)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(10, 40)
        Me.Panel39.TabIndex = 18
        '
        'Panel38
        '
        Me.Panel38.BackColor = System.Drawing.Color.White
        Me.Panel38.Controls.Add(Me.btnSendRequest)
        Me.Panel38.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel38.Location = New System.Drawing.Point(0, 10)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(217, 40)
        Me.Panel38.TabIndex = 19
        '
        'btnSendRequest
        '
        Me.btnSendRequest.BorderRadius = 8
        Me.btnSendRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSendRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSendRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSendRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSendRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSendRequest.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSendRequest.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSendRequest.ForeColor = System.Drawing.Color.White
        Me.btnSendRequest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSendRequest.Location = New System.Drawing.Point(0, 0)
        Me.btnSendRequest.Name = "btnSendRequest"
        Me.btnSendRequest.PressedDepth = 20
        Me.btnSendRequest.Size = New System.Drawing.Size(217, 40)
        Me.btnSendRequest.TabIndex = 56
        Me.btnSendRequest.TabStop = False
        Me.btnSendRequest.Text = "Send Request"
        '
        'Panel41
        '
        Me.Panel41.BackColor = System.Drawing.Color.White
        Me.Panel41.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel41.Location = New System.Drawing.Point(0, 50)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(447, 10)
        Me.Panel41.TabIndex = 18
        '
        'Panel42
        '
        Me.Panel42.BackColor = System.Drawing.Color.White
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel42.Location = New System.Drawing.Point(0, 0)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(447, 10)
        Me.Panel42.TabIndex = 18
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(13, 102)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(447, 10)
        Me.Panel27.TabIndex = 27
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.txtSupplier)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(13, 67)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(447, 35)
        Me.Panel22.TabIndex = 26
        '
        'txtSupplier
        '
        Me.txtSupplier.Cursor = System.Windows.Forms.Cursors.No
        Me.txtSupplier.DefaultText = ""
        Me.txtSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSupplier.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.txtSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSupplier.Enabled = False
        Me.txtSupplier.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.txtSupplier.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSupplier.ForeColor = System.Drawing.Color.Black
        Me.txtSupplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSupplier.Location = New System.Drawing.Point(0, 0)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupplier.PlaceholderText = "Enter supplier"
        Me.txtSupplier.SelectedText = ""
        Me.txtSupplier.Size = New System.Drawing.Size(447, 35)
        Me.txtSupplier.TabIndex = 4
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.Label3)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(13, 42)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(447, 25)
        Me.Panel23.TabIndex = 25
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
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Supplier"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(13, 32)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(447, 10)
        Me.Panel24.TabIndex = 24
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(460, 32)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(10, 469)
        Me.Panel12.TabIndex = 17
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(3, 32)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(10, 469)
        Me.Panel11.TabIndex = 16
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(3, 22)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(467, 10)
        Me.Panel10.TabIndex = 14
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.White
        Me.panelBody.Controls.Add(Me.GroupBox1)
        Me.panelBody.Controls.Add(Me.Panel5)
        Me.panelBody.Controls.Add(Me.GroupBox2)
        Me.panelBody.Controls.Add(Me.Panel9)
        Me.panelBody.Controls.Add(Me.Panel8)
        Me.panelBody.Controls.Add(Me.Panel7)
        Me.panelBody.Controls.Add(Me.Panel6)
        Me.panelBody.Controls.Add(Me.Panel19)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 0)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(953, 574)
        Me.panelBody.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbxProduct)
        Me.GroupBox1.Controls.Add(Me.Panel34)
        Me.GroupBox1.Controls.Add(Me.Panel53)
        Me.GroupBox1.Controls.Add(Me.Panel54)
        Me.GroupBox1.Controls.Add(Me.Panel55)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(493, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 504)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Image"
        '
        'pbxProduct
        '
        Me.pbxProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxProduct.Location = New System.Drawing.Point(13, 32)
        Me.pbxProduct.Name = "pbxProduct"
        Me.pbxProduct.Size = New System.Drawing.Size(424, 409)
        Me.pbxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxProduct.TabIndex = 37
        Me.pbxProduct.TabStop = False
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.White
        Me.Panel34.Controls.Add(Me.Panel35)
        Me.Panel34.Controls.Add(Me.Panel36)
        Me.Panel34.Controls.Add(Me.Panel43)
        Me.Panel34.Controls.Add(Me.Panel44)
        Me.Panel34.Controls.Add(Me.Panel45)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel34.Location = New System.Drawing.Point(13, 441)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(424, 60)
        Me.Panel34.TabIndex = 36
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.White
        Me.Panel35.Controls.Add(Me.btnRemove)
        Me.Panel35.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel35.Location = New System.Drawing.Point(227, 10)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(197, 40)
        Me.Panel35.TabIndex = 18
        '
        'btnRemove
        '
        Me.btnRemove.BorderRadius = 8
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRemove.FillColor = System.Drawing.Color.OrangeRed
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRemove.Location = New System.Drawing.Point(0, 0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.PressedDepth = 20
        Me.btnRemove.Size = New System.Drawing.Size(197, 40)
        Me.btnRemove.TabIndex = 56
        Me.btnRemove.TabStop = False
        Me.btnRemove.Text = "Remove Product"
        '
        'Panel36
        '
        Me.Panel36.BackColor = System.Drawing.Color.White
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel36.Location = New System.Drawing.Point(217, 10)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(10, 40)
        Me.Panel36.TabIndex = 18
        '
        'Panel43
        '
        Me.Panel43.BackColor = System.Drawing.Color.White
        Me.Panel43.Controls.Add(Me.btnQuantity)
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel43.Location = New System.Drawing.Point(0, 10)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(217, 40)
        Me.Panel43.TabIndex = 19
        '
        'btnQuantity
        '
        Me.btnQuantity.BorderRadius = 8
        Me.btnQuantity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuantity.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnQuantity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuantity.FillColor = System.Drawing.Color.OrangeRed
        Me.btnQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuantity.ForeColor = System.Drawing.Color.White
        Me.btnQuantity.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnQuantity.Location = New System.Drawing.Point(0, 0)
        Me.btnQuantity.Name = "btnQuantity"
        Me.btnQuantity.PressedDepth = 20
        Me.btnQuantity.Size = New System.Drawing.Size(217, 40)
        Me.btnQuantity.TabIndex = 56
        Me.btnQuantity.TabStop = False
        Me.btnQuantity.Text = "Enter Quantity"
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.White
        Me.Panel44.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel44.Location = New System.Drawing.Point(0, 50)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(424, 10)
        Me.Panel44.TabIndex = 18
        '
        'Panel45
        '
        Me.Panel45.BackColor = System.Drawing.Color.White
        Me.Panel45.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel45.Location = New System.Drawing.Point(0, 0)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(424, 10)
        Me.Panel45.TabIndex = 18
        '
        'Panel53
        '
        Me.Panel53.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel53.Location = New System.Drawing.Point(437, 32)
        Me.Panel53.Name = "Panel53"
        Me.Panel53.Size = New System.Drawing.Size(10, 469)
        Me.Panel53.TabIndex = 17
        '
        'Panel54
        '
        Me.Panel54.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel54.Location = New System.Drawing.Point(3, 32)
        Me.Panel54.Name = "Panel54"
        Me.Panel54.Size = New System.Drawing.Size(10, 469)
        Me.Panel54.TabIndex = 16
        '
        'Panel55
        '
        Me.Panel55.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel55.Location = New System.Drawing.Point(3, 22)
        Me.Panel55.Name = "Panel55"
        Me.Panel55.Size = New System.Drawing.Size(444, 10)
        Me.Panel55.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(483, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 504)
        Me.Panel5.TabIndex = 27
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmRestockProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 574)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRestockProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel19.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel37.ResumeLayout(False)
        Me.Panel40.ResumeLayout(False)
        Me.Panel38.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.panelBody.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbxProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel34.ResumeLayout(False)
        Me.Panel35.ResumeLayout(False)
        Me.Panel43.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents panelBody As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel37 As Panel
    Friend WithEvents Panel40 As Panel
    Friend WithEvents btnCancelSupp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel39 As Panel
    Friend WithEvents Panel38 As Panel
    Friend WithEvents btnSendRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Panel42 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents lblManageProduct As Label
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtPONo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSupplier As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ProductName As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel35 As Panel
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel36 As Panel
    Friend WithEvents Panel43 As Panel
    Friend WithEvents btnQuantity As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel44 As Panel
    Friend WithEvents Panel45 As Panel
    Friend WithEvents Panel53 As Panel
    Friend WithEvents Panel54 As Panel
    Friend WithEvents Panel55 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pbxProduct As PictureBox
End Class
