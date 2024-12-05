<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduct
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabControl2 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.ListofProducts = New System.Windows.Forms.TabPage()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ProductName1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OriginalPrice1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SellingPrice1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.btnRestock = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeactivate = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnAddNew = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.RambicProducts = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PurchasePrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SellingPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.btnDeleteProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.btnView = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.TabControl2.SuspendLayout()
        Me.ListofProducts.SuspendLayout()
        Me.panelBody.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.RambicProducts.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 10)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(10, 623)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1020, 10)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 623)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1030, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 623)
        Me.Panel4.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.ListofProducts)
        Me.TabControl2.Controls.Add(Me.RambicProducts)
        Me.TabControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ItemSize = New System.Drawing.Size(200, 40)
        Me.TabControl2.Location = New System.Drawing.Point(10, 10)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1020, 613)
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
        Me.TabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.OrangeRed
        Me.TabControl2.TabButtonSize = New System.Drawing.Size(200, 40)
        Me.TabControl2.TabIndex = 32
        Me.TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'ListofProducts
        '
        Me.ListofProducts.Controls.Add(Me.panelBody)
        Me.ListofProducts.Location = New System.Drawing.Point(4, 44)
        Me.ListofProducts.Name = "ListofProducts"
        Me.ListofProducts.Size = New System.Drawing.Size(1012, 565)
        Me.ListofProducts.TabIndex = 0
        Me.ListofProducts.Text = "List of Products"
        Me.ListofProducts.UseVisualStyleBackColor = True
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.White
        Me.panelBody.Controls.Add(Me.ListView1)
        Me.panelBody.Controls.Add(Me.Panel22)
        Me.panelBody.Controls.Add(Me.Panel21)
        Me.panelBody.Controls.Add(Me.Panel20)
        Me.panelBody.Controls.Add(Me.Panel13)
        Me.panelBody.Controls.Add(Me.Panel8)
        Me.panelBody.Controls.Add(Me.Panel19)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 0)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1012, 565)
        Me.panelBody.TabIndex = 4
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductName1, Me.Category1, Me.Type1, Me.OriginalPrice1, Me.SellingPrice1, Me.Status1})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(10, 55)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(992, 450)
        Me.ListView1.TabIndex = 39
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ProductName1
        '
        Me.ProductName1.Text = "Product Name"
        Me.ProductName1.Width = 260
        '
        'Category1
        '
        Me.Category1.Text = "Category"
        Me.Category1.Width = 220
        '
        'Type1
        '
        Me.Type1.Text = "Type"
        Me.Type1.Width = 200
        '
        'OriginalPrice1
        '
        Me.OriginalPrice1.Text = "Original Price"
        Me.OriginalPrice1.Width = 150
        '
        'SellingPrice1
        '
        Me.SellingPrice1.Text = "Selling Price"
        Me.SellingPrice1.Width = 150
        '
        'Status1
        '
        Me.Status1.Text = "Status"
        Me.Status1.Width = 150
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.btnRestock)
        Me.Panel22.Controls.Add(Me.btnDeactivate)
        Me.Panel22.Controls.Add(Me.Panel5)
        Me.Panel22.Controls.Add(Me.btnEdit)
        Me.Panel22.Controls.Add(Me.Panel12)
        Me.Panel22.Controls.Add(Me.btnAddNew)
        Me.Panel22.Controls.Add(Me.Panel6)
        Me.Panel22.Controls.Add(Me.Panel7)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel22.Location = New System.Drawing.Point(10, 505)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(992, 60)
        Me.Panel22.TabIndex = 27
        '
        'btnRestock
        '
        Me.btnRestock.BorderRadius = 8
        Me.btnRestock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestock.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRestock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRestock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRestock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRestock.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRestock.FillColor = System.Drawing.Color.OrangeRed
        Me.btnRestock.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRestock.ForeColor = System.Drawing.Color.White
        Me.btnRestock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRestock.Location = New System.Drawing.Point(852, 10)
        Me.btnRestock.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.PressedDepth = 20
        Me.btnRestock.Size = New System.Drawing.Size(140, 40)
        Me.btnRestock.TabIndex = 46
        Me.btnRestock.Text = "Restock"
        '
        'btnDeactivate
        '
        Me.btnDeactivate.BorderRadius = 8
        Me.btnDeactivate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeactivate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeactivate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeactivate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeactivate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeactivate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeactivate.Enabled = False
        Me.btnDeactivate.FillColor = System.Drawing.Color.OrangeRed
        Me.btnDeactivate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeactivate.ForeColor = System.Drawing.Color.White
        Me.btnDeactivate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDeactivate.Location = New System.Drawing.Point(300, 10)
        Me.btnDeactivate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.PressedDepth = 20
        Me.btnDeactivate.Size = New System.Drawing.Size(140, 40)
        Me.btnDeactivate.TabIndex = 45
        Me.btnDeactivate.Text = "Deactivate"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(290, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 40)
        Me.Panel5.TabIndex = 44
        '
        'btnEdit
        '
        Me.btnEdit.BorderRadius = 8
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.Enabled = False
        Me.btnEdit.FillColor = System.Drawing.Color.OrangeRed
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEdit.Location = New System.Drawing.Point(150, 10)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PressedDepth = 20
        Me.btnEdit.Size = New System.Drawing.Size(140, 40)
        Me.btnEdit.TabIndex = 43
        Me.btnEdit.Text = "Edit"
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(140, 10)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(10, 40)
        Me.Panel12.TabIndex = 14
        '
        'btnAddNew
        '
        Me.btnAddNew.BorderRadius = 8
        Me.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddNew.FillColor = System.Drawing.Color.OrangeRed
        Me.btnAddNew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAddNew.Location = New System.Drawing.Point(0, 10)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.PressedDepth = 20
        Me.btnAddNew.Size = New System.Drawing.Size(140, 40)
        Me.btnAddNew.TabIndex = 42
        Me.btnAddNew.Text = "Add New"
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(992, 10)
        Me.Panel6.TabIndex = 13
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 50)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(992, 10)
        Me.Panel7.TabIndex = 13
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(10, 45)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(992, 10)
        Me.Panel21.TabIndex = 8
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.Guna2TextBox1)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(10, 10)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(992, 35)
        Me.Panel20.TabIndex = 7
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
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Search by product name"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(367, 35)
        Me.Guna2TextBox1.TabIndex = 48
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel13.Location = New System.Drawing.Point(1002, 10)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(10, 555)
        Me.Panel13.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 555)
        Me.Panel8.TabIndex = 6
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1012, 10)
        Me.Panel19.TabIndex = 3
        '
        'RambicProducts
        '
        Me.RambicProducts.Controls.Add(Me.Panel9)
        Me.RambicProducts.Location = New System.Drawing.Point(4, 44)
        Me.RambicProducts.Name = "RambicProducts"
        Me.RambicProducts.Padding = New System.Windows.Forms.Padding(3)
        Me.RambicProducts.Size = New System.Drawing.Size(1012, 565)
        Me.RambicProducts.TabIndex = 2
        Me.RambicProducts.Text = "Rambic Products"
        Me.RambicProducts.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Panel15)
        Me.Panel9.Controls.Add(Me.Panel18)
        Me.Panel9.Controls.Add(Me.Panel32)
        Me.Panel9.Controls.Add(Me.Panel33)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1006, 559)
        Me.Panel9.TabIndex = 3
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.ListView3)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.Panel14)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(10, 10)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(986, 489)
        Me.Panel10.TabIndex = 6
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductName, Me.Category, Me.PurchasePrice, Me.SellingPrice, Me.Status, Me.Amount})
        Me.ListView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(0, 45)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(986, 444)
        Me.ListView3.TabIndex = 36
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ProductName
        '
        Me.ProductName.Text = "Product Name"
        Me.ProductName.Width = 260
        '
        'Category
        '
        Me.Category.Text = "Category"
        Me.Category.Width = 220
        '
        'PurchasePrice
        '
        Me.PurchasePrice.Text = "Original Price"
        Me.PurchasePrice.Width = 180
        '
        'SellingPrice
        '
        Me.SellingPrice.Text = "Selling Price"
        Me.SellingPrice.Width = 180
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 150
        '
        'Amount
        '
        Me.Amount.Text = "Amount"
        Me.Amount.Width = 150
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 35)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(986, 10)
        Me.Panel11.TabIndex = 1
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Guna2TextBox2)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(986, 35)
        Me.Panel14.TabIndex = 0
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = "Search by product name"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(314, 35)
        Me.Guna2TextBox2.TabIndex = 14
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(10, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(986, 10)
        Me.Panel15.TabIndex = 2
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.White
        Me.Panel18.Controls.Add(Me.Panel27)
        Me.Panel18.Controls.Add(Me.Panel28)
        Me.Panel18.Controls.Add(Me.Panel29)
        Me.Panel18.Controls.Add(Me.Panel30)
        Me.Panel18.Controls.Add(Me.Panel31)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel18.Location = New System.Drawing.Point(10, 499)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(986, 60)
        Me.Panel18.TabIndex = 20
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.White
        Me.Panel27.Controls.Add(Me.btnDeleteProduct)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel27.Location = New System.Drawing.Point(150, 10)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(140, 40)
        Me.Panel27.TabIndex = 21
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.BorderRadius = 8
        Me.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDeleteProduct.Enabled = False
        Me.btnDeleteProduct.FillColor = System.Drawing.Color.OrangeRed
        Me.btnDeleteProduct.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteProduct.ForeColor = System.Drawing.Color.White
        Me.btnDeleteProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDeleteProduct.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.PressedDepth = 20
        Me.btnDeleteProduct.Size = New System.Drawing.Size(140, 40)
        Me.btnDeleteProduct.TabIndex = 58
        Me.btnDeleteProduct.Text = "Deactive"
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.White
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel28.Location = New System.Drawing.Point(140, 10)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(10, 40)
        Me.Panel28.TabIndex = 19
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.White
        Me.Panel29.Controls.Add(Me.btnView)
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel29.Location = New System.Drawing.Point(0, 10)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(140, 40)
        Me.Panel29.TabIndex = 18
        '
        'btnView
        '
        Me.btnView.BorderRadius = 8
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnView.FillColor = System.Drawing.Color.OrangeRed
        Me.btnView.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnView.Location = New System.Drawing.Point(0, 0)
        Me.btnView.Name = "btnView"
        Me.btnView.PressedDepth = 20
        Me.btnView.Size = New System.Drawing.Size(140, 40)
        Me.btnView.TabIndex = 57
        Me.btnView.Text = "View"
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.White
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel30.Location = New System.Drawing.Point(0, 50)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(986, 10)
        Me.Panel30.TabIndex = 18
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.White
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel31.Location = New System.Drawing.Point(0, 0)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(986, 10)
        Me.Panel31.TabIndex = 18
        '
        'Panel32
        '
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel32.Location = New System.Drawing.Point(0, 0)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(10, 559)
        Me.Panel32.TabIndex = 5
        '
        'Panel33
        '
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel33.Location = New System.Drawing.Point(996, 0)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(10, 559)
        Me.Panel33.TabIndex = 4
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1040, 633)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl2.ResumeLayout(False)
        Me.ListofProducts.ResumeLayout(False)
        Me.panelBody.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.RambicProducts.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        Me.Panel29.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TabControl2 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents ListofProducts As TabPage
    Friend WithEvents panelBody As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ProductName1 As ColumnHeader
    Friend WithEvents Category1 As ColumnHeader
    Friend WithEvents Type1 As ColumnHeader
    Friend WithEvents OriginalPrice1 As ColumnHeader
    Friend WithEvents SellingPrice1 As ColumnHeader
    Friend WithEvents Status1 As ColumnHeader
    Friend WithEvents Panel22 As Panel
    Friend WithEvents btnRestock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeactivate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnAddNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents RambicProducts As TabPage
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ProductName As ColumnHeader
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents PurchasePrice As ColumnHeader
    Friend WithEvents SellingPrice As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents Amount As ColumnHeader
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents btnDeleteProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel33 As Panel
End Class
