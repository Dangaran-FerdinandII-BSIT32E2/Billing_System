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
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OriginalPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.ActiveOrders = New System.Windows.Forms.TabPage()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel55 = New System.Windows.Forms.Panel()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.RestockID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Supplier = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel56 = New System.Windows.Forms.Panel()
        Me.Panel57 = New System.Windows.Forms.Panel()
        Me.txtSearchProduct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel61 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.btnAddNewProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel58 = New System.Windows.Forms.Panel()
        Me.Panel59 = New System.Windows.Forms.Panel()
        Me.Products = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateRequested = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl2.SuspendLayout()
        Me.ListofProducts.SuspendLayout()
        Me.panelBody.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.ActiveOrders.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel55.SuspendLayout()
        Me.Panel57.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1387, 12)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(13, 767)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1361, 12)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 12)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 767)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1374, 12)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(13, 767)
        Me.Panel4.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.ListofProducts)
        Me.TabControl2.Controls.Add(Me.ActiveOrders)
        Me.TabControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ItemSize = New System.Drawing.Size(200, 40)
        Me.TabControl2.Location = New System.Drawing.Point(13, 12)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1361, 755)
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
        Me.ListofProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.ListofProducts.Name = "ListofProducts"
        Me.ListofProducts.Size = New System.Drawing.Size(1353, 707)
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
        Me.panelBody.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1353, 707)
        Me.panelBody.TabIndex = 4
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.Type, Me.OriginalPrice, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 73)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1327, 560)
        Me.ListView1.TabIndex = 39
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Name"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 350
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Category"
        Me.ColumnHeader3.Width = 200
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 220
        '
        'OriginalPrice
        '
        Me.OriginalPrice.Text = "Original Price"
        Me.OriginalPrice.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Selling Price"
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 150
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
        Me.Panel22.Location = New System.Drawing.Point(13, 633)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1327, 74)
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
        Me.btnRestock.Location = New System.Drawing.Point(1140, 12)
        Me.btnRestock.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.PressedDepth = 20
        Me.btnRestock.Size = New System.Drawing.Size(187, 50)
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
        Me.btnDeactivate.Location = New System.Drawing.Point(400, 12)
        Me.btnDeactivate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.PressedDepth = 20
        Me.btnDeactivate.Size = New System.Drawing.Size(187, 50)
        Me.btnDeactivate.TabIndex = 45
        Me.btnDeactivate.Text = "Deactivate"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(387, 12)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(13, 50)
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
        Me.btnEdit.Location = New System.Drawing.Point(200, 12)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PressedDepth = 20
        Me.btnEdit.Size = New System.Drawing.Size(187, 50)
        Me.btnEdit.TabIndex = 43
        Me.btnEdit.Text = "Edit"
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(187, 12)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(13, 50)
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
        Me.btnAddNew.Location = New System.Drawing.Point(0, 12)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.PressedDepth = 20
        Me.btnAddNew.Size = New System.Drawing.Size(187, 50)
        Me.btnAddNew.TabIndex = 42
        Me.btnAddNew.Text = "Add New"
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1327, 12)
        Me.Panel6.TabIndex = 13
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 62)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1327, 12)
        Me.Panel7.TabIndex = 13
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(13, 61)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(1327, 12)
        Me.Panel21.TabIndex = 8
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.Guna2TextBox1)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(13, 12)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(1327, 49)
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
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Search by product name and supplier name"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(489, 49)
        Me.Guna2TextBox1.TabIndex = 48
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel13.Location = New System.Drawing.Point(1340, 12)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(13, 695)
        Me.Panel13.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 12)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(13, 695)
        Me.Panel8.TabIndex = 6
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1353, 12)
        Me.Panel19.TabIndex = 3
        '
        'ActiveOrders
        '
        Me.ActiveOrders.Controls.Add(Me.Panel16)
        Me.ActiveOrders.Location = New System.Drawing.Point(4, 44)
        Me.ActiveOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.ActiveOrders.Name = "ActiveOrders"
        Me.ActiveOrders.Size = New System.Drawing.Size(1353, 707)
        Me.ActiveOrders.TabIndex = 1
        Me.ActiveOrders.Text = "Active Orders"
        Me.ActiveOrders.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Panel55)
        Me.Panel16.Controls.Add(Me.Panel61)
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.Panel58)
        Me.Panel16.Controls.Add(Me.Panel59)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1353, 707)
        Me.Panel16.TabIndex = 1
        '
        'Panel55
        '
        Me.Panel55.Controls.Add(Me.ListView2)
        Me.Panel55.Controls.Add(Me.Panel56)
        Me.Panel55.Controls.Add(Me.Panel57)
        Me.Panel55.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel55.Location = New System.Drawing.Point(13, 12)
        Me.Panel55.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel55.Name = "Panel55"
        Me.Panel55.Size = New System.Drawing.Size(1327, 621)
        Me.Panel55.TabIndex = 6
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RestockID, Me.Supplier, Me.Products, Me.Amount, Me.DateRequested})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(0, 51)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1327, 570)
        Me.ListView2.TabIndex = 36
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'RestockID
        '
        Me.RestockID.Text = "Restock ID"
        Me.RestockID.Width = 150
        '
        'Supplier
        '
        Me.Supplier.Text = "Supplier"
        Me.Supplier.Width = 200
        '
        'Amount
        '
        Me.Amount.Text = "Amount"
        Me.Amount.Width = 250
        '
        'Panel56
        '
        Me.Panel56.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel56.Location = New System.Drawing.Point(0, 39)
        Me.Panel56.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel56.Name = "Panel56"
        Me.Panel56.Size = New System.Drawing.Size(1327, 12)
        Me.Panel56.TabIndex = 1
        '
        'Panel57
        '
        Me.Panel57.Controls.Add(Me.txtSearchProduct)
        Me.Panel57.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel57.Location = New System.Drawing.Point(0, 0)
        Me.Panel57.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel57.Name = "Panel57"
        Me.Panel57.Size = New System.Drawing.Size(1327, 39)
        Me.Panel57.TabIndex = 0
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchProduct.DefaultText = ""
        Me.txtSearchProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchProduct.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSearchProduct.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.txtSearchProduct.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearchProduct.ForeColor = System.Drawing.Color.Black
        Me.txtSearchProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSearchProduct.Location = New System.Drawing.Point(0, 0)
        Me.txtSearchProduct.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchProduct.PlaceholderText = "Search by product name"
        Me.txtSearchProduct.SelectedText = ""
        Me.txtSearchProduct.Size = New System.Drawing.Size(419, 39)
        Me.txtSearchProduct.TabIndex = 14
        '
        'Panel61
        '
        Me.Panel61.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel61.Location = New System.Drawing.Point(13, 0)
        Me.Panel61.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel61.Name = "Panel61"
        Me.Panel61.Size = New System.Drawing.Size(1327, 12)
        Me.Panel61.TabIndex = 2
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.White
        Me.Panel17.Controls.Add(Me.Panel23)
        Me.Panel17.Controls.Add(Me.Panel24)
        Me.Panel17.Controls.Add(Me.Panel25)
        Me.Panel17.Controls.Add(Me.Panel26)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(13, 633)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1327, 74)
        Me.Panel17.TabIndex = 20
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.White
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(187, 12)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(13, 50)
        Me.Panel23.TabIndex = 19
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.White
        Me.Panel24.Controls.Add(Me.btnAddNewProduct)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(0, 12)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(187, 50)
        Me.Panel24.TabIndex = 18
        '
        'btnAddNewProduct
        '
        Me.btnAddNewProduct.BorderRadius = 8
        Me.btnAddNewProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddNewProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddNewProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddNewProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddNewProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddNewProduct.FillColor = System.Drawing.Color.OrangeRed
        Me.btnAddNewProduct.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddNewProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAddNewProduct.Location = New System.Drawing.Point(0, 0)
        Me.btnAddNewProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNewProduct.Name = "btnAddNewProduct"
        Me.btnAddNewProduct.PressedDepth = 20
        Me.btnAddNewProduct.Size = New System.Drawing.Size(187, 50)
        Me.btnAddNewProduct.TabIndex = 57
        Me.btnAddNewProduct.Text = "View"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.White
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel25.Location = New System.Drawing.Point(0, 62)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1327, 12)
        Me.Panel25.TabIndex = 18
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.White
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(1327, 12)
        Me.Panel26.TabIndex = 18
        '
        'Panel58
        '
        Me.Panel58.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel58.Location = New System.Drawing.Point(0, 0)
        Me.Panel58.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel58.Name = "Panel58"
        Me.Panel58.Size = New System.Drawing.Size(13, 707)
        Me.Panel58.TabIndex = 5
        '
        'Panel59
        '
        Me.Panel59.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel59.Location = New System.Drawing.Point(1340, 0)
        Me.Panel59.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel59.Name = "Panel59"
        Me.Panel59.Size = New System.Drawing.Size(13, 707)
        Me.Panel59.TabIndex = 4
        '
        'Products
        '
        Me.Products.Text = "Total Products"
        Me.Products.Width = 250
        '
        'DateRequested
        '
        Me.DateRequested.Text = "Date Requested"
        Me.DateRequested.Width = 250
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1387, 779)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl2.ResumeLayout(False)
        Me.ListofProducts.ResumeLayout(False)
        Me.panelBody.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.ActiveOrders.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel55.ResumeLayout(False)
        Me.Panel57.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TabControl2 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents ListofProducts As TabPage
    Friend WithEvents ActiveOrders As TabPage
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel55 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents RestockID As ColumnHeader
    Friend WithEvents Supplier As ColumnHeader
    Friend WithEvents Amount As ColumnHeader
    Friend WithEvents Panel56 As Panel
    Friend WithEvents Panel57 As Panel
    Friend WithEvents txtSearchProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel61 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents btnAddNewProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel58 As Panel
    Friend WithEvents Panel59 As Panel
    Friend WithEvents panelBody As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents OriginalPrice As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
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
    Friend WithEvents Products As ColumnHeader
    Friend WithEvents DateRequested As ColumnHeader
End Class
