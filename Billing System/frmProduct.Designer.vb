<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnSearchCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnAddNew = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.btnDeactivate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRestock = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SupplierName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OriginalPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SellingPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 10)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(10, 623)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1089, 10)
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
        Me.Panel4.Location = New System.Drawing.Point(1099, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 623)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.ListView1)
        Me.Panel5.Controls.Add(Me.Panel22)
        Me.Panel5.Controls.Add(Me.Panel21)
        Me.Panel5.Controls.Add(Me.Panel20)
        Me.Panel5.Controls.Add(Me.Panel13)
        Me.Panel5.Controls.Add(Me.Panel18)
        Me.Panel5.Controls.Add(Me.Panel19)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(10, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1089, 613)
        Me.Panel5.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Panel6)
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1089, 50)
        Me.Panel9.TabIndex = 2
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
        Me.Panel14.Size = New System.Drawing.Size(237, 50)
        Me.Panel14.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 22)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "List of Products"
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 10)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(10, 30)
        Me.Panel15.TabIndex = 13
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 40)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(237, 10)
        Me.Panel17.TabIndex = 13
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(237, 10)
        Me.Panel16.TabIndex = 13
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(468, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(10, 50)
        Me.Panel11.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(468, 10)
        Me.Panel7.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 40)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(468, 10)
        Me.Panel8.TabIndex = 47
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompanyName.DefaultText = ""
        Me.txtCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCompanyName.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtCompanyName.DisabledState.ForeColor = System.Drawing.Color.DimGray
        Me.txtCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtCompanyName.Enabled = False
        Me.txtCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCompanyName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCompanyName.Location = New System.Drawing.Point(129, 10)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompanyName.PlaceholderText = "Search company name"
        Me.txtCompanyName.SelectedText = ""
        Me.txtCompanyName.Size = New System.Drawing.Size(339, 30)
        Me.txtCompanyName.TabIndex = 46
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(119, 10)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(10, 30)
        Me.Panel10.TabIndex = 2
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchCustomer.BorderRadius = 8
        Me.btnSearchCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchCustomer.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchCustomer.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSearchCustomer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchCustomer.ForeColor = System.Drawing.Color.White
        Me.btnSearchCustomer.Image = CType(resources.GetObject("btnSearchCustomer.Image"), System.Drawing.Image)
        Me.btnSearchCustomer.Location = New System.Drawing.Point(84, 10)
        Me.btnSearchCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.PressedDepth = 20
        Me.btnSearchCustomer.Size = New System.Drawing.Size(35, 30)
        Me.btnSearchCustomer.TabIndex = 85
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnSearchCustomer)
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Controls.Add(Me.txtCompanyName)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Panel11)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(611, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(478, 50)
        Me.Panel6.TabIndex = 2
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel13.Location = New System.Drawing.Point(1079, 60)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(10, 553)
        Me.Panel13.TabIndex = 5
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(0, 60)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(10, 553)
        Me.Panel18.TabIndex = 6
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 50)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1089, 10)
        Me.Panel19.TabIndex = 3
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.Guna2TextBox1)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(10, 60)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(1069, 40)
        Me.Panel20.TabIndex = 7
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(10, 100)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(1069, 10)
        Me.Panel21.TabIndex = 8
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.btnRestock)
        Me.Panel22.Controls.Add(Me.btnDeactivate)
        Me.Panel22.Controls.Add(Me.Panel23)
        Me.Panel22.Controls.Add(Me.btnEdit)
        Me.Panel22.Controls.Add(Me.Panel12)
        Me.Panel22.Controls.Add(Me.btnAddNew)
        Me.Panel22.Controls.Add(Me.Panel24)
        Me.Panel22.Controls.Add(Me.Panel25)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel22.Location = New System.Drawing.Point(10, 553)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1069, 60)
        Me.Panel22.TabIndex = 27
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(1069, 10)
        Me.Panel24.TabIndex = 13
        '
        'Panel25
        '
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel25.Location = New System.Drawing.Point(0, 50)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1069, 10)
        Me.Panel25.TabIndex = 13
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
        'btnEdit
        '
        Me.btnEdit.BorderRadius = 8
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
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
        'Panel23
        '
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(290, 10)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(10, 40)
        Me.Panel23.TabIndex = 44
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
        Me.btnRestock.Location = New System.Drawing.Point(929, 10)
        Me.btnRestock.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.PressedDepth = 20
        Me.btnRestock.Size = New System.Drawing.Size(140, 40)
        Me.btnRestock.TabIndex = 46
        Me.btnRestock.Text = "Restock"
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
        Me.Guna2TextBox1.Size = New System.Drawing.Size(265, 40)
        Me.Guna2TextBox1.TabIndex = 48
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductName, Me.SupplierName, Me.Description, Me.Category, Me.Type, Me.OriginalPrice, Me.SellingPrice, Me.Status})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(10, 110)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1069, 443)
        Me.ListView1.TabIndex = 39
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ProductName
        '
        Me.ProductName.Text = "Product Name"
        Me.ProductName.Width = 150
        '
        'SupplierName
        '
        Me.SupplierName.Text = "Supplier Name"
        Me.SupplierName.Width = 180
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 350
        '
        'Category
        '
        Me.Category.Text = "Category"
        Me.Category.Width = 200
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
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 633)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel5.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSearchCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents btnRestock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeactivate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel23 As Panel
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnAddNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ProductName As ColumnHeader
    Friend WithEvents SupplierName As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents OriginalPrice As ColumnHeader
    Friend WithEvents SellingPrice As ColumnHeader
    Friend WithEvents Status As ColumnHeader
End Class
