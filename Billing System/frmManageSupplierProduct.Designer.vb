﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageSupplierProduct
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
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.TabControl2 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.btnDeleteSupplier = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.btnEditSupplier = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.btnAddNewSupplier = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CompanyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BankDetails = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContactPerson = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PhoneNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeliveryTerms = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtSearchSupplierName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.btnDeleteProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.btnEditProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.btnAddNewProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel55 = New System.Windows.Forms.Panel()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SupplierName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PurchasePrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SellingPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel56 = New System.Windows.Forms.Panel()
        Me.Panel57 = New System.Windows.Forms.Panel()
        Me.txtSearchProduct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel58 = New System.Windows.Forms.Panel()
        Me.Panel59 = New System.Windows.Forms.Panel()
        Me.Panel60 = New System.Windows.Forms.Panel()
        Me.Panel61 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlBody.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel31.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel55.SuspendLayout()
        Me.Panel57.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBody
        '
        Me.pnlBody.Controls.Add(Me.TabControl2)
        Me.pnlBody.Controls.Add(Me.Panel3)
        Me.pnlBody.Controls.Add(Me.Panel2)
        Me.pnlBody.Controls.Add(Me.Panel4)
        Me.pnlBody.Controls.Add(Me.Panel1)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 0)
        Me.pnlBody.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1479, 779)
        Me.pnlBody.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ItemSize = New System.Drawing.Size(200, 40)
        Me.TabControl2.Location = New System.Drawing.Point(13, 12)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1453, 755)
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
        Me.TabControl2.TabIndex = 31
        Me.TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1445, 707)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List of Suppliers"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.Panel11)
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1445, 707)
        Me.Panel6.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Panel20)
        Me.Panel5.Controls.Add(Me.Panel19)
        Me.Panel5.Controls.Add(Me.Panel14)
        Me.Panel5.Controls.Add(Me.Panel15)
        Me.Panel5.Controls.Add(Me.Panel31)
        Me.Panel5.Controls.Add(Me.Panel33)
        Me.Panel5.Controls.Add(Me.Panel34)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(13, 621)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1419, 74)
        Me.Panel5.TabIndex = 19
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.White
        Me.Panel20.Controls.Add(Me.btnDeleteSupplier)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel20.Location = New System.Drawing.Point(400, 12)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(187, 50)
        Me.Panel20.TabIndex = 21
        '
        'btnDeleteSupplier
        '
        Me.btnDeleteSupplier.BorderRadius = 8
        Me.btnDeleteSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDeleteSupplier.Enabled = False
        Me.btnDeleteSupplier.FillColor = System.Drawing.Color.OrangeRed
        Me.btnDeleteSupplier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteSupplier.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDeleteSupplier.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteSupplier.Name = "btnDeleteSupplier"
        Me.btnDeleteSupplier.PressedDepth = 20
        Me.btnDeleteSupplier.Size = New System.Drawing.Size(187, 50)
        Me.btnDeleteSupplier.TabIndex = 58
        Me.btnDeleteSupplier.Text = "Delete"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.White
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel19.Location = New System.Drawing.Point(387, 12)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(13, 50)
        Me.Panel19.TabIndex = 20
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.Controls.Add(Me.btnEditSupplier)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(200, 12)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(187, 50)
        Me.Panel14.TabIndex = 18
        '
        'btnEditSupplier
        '
        Me.btnEditSupplier.BorderRadius = 8
        Me.btnEditSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEditSupplier.Enabled = False
        Me.btnEditSupplier.FillColor = System.Drawing.Color.OrangeRed
        Me.btnEditSupplier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditSupplier.ForeColor = System.Drawing.Color.White
        Me.btnEditSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEditSupplier.Location = New System.Drawing.Point(0, 0)
        Me.btnEditSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditSupplier.Name = "btnEditSupplier"
        Me.btnEditSupplier.PressedDepth = 20
        Me.btnEditSupplier.Size = New System.Drawing.Size(187, 50)
        Me.btnEditSupplier.TabIndex = 58
        Me.btnEditSupplier.Text = "Edit"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.White
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(187, 12)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(13, 50)
        Me.Panel15.TabIndex = 19
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.White
        Me.Panel31.Controls.Add(Me.btnAddNewSupplier)
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel31.Location = New System.Drawing.Point(0, 12)
        Me.Panel31.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(187, 50)
        Me.Panel31.TabIndex = 18
        '
        'btnAddNewSupplier
        '
        Me.btnAddNewSupplier.BorderRadius = 8
        Me.btnAddNewSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddNewSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddNewSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddNewSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddNewSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddNewSupplier.FillColor = System.Drawing.Color.OrangeRed
        Me.btnAddNewSupplier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddNewSupplier.ForeColor = System.Drawing.Color.White
        Me.btnAddNewSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAddNewSupplier.Location = New System.Drawing.Point(0, 0)
        Me.btnAddNewSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNewSupplier.Name = "btnAddNewSupplier"
        Me.btnAddNewSupplier.PressedDepth = 20
        Me.btnAddNewSupplier.Size = New System.Drawing.Size(187, 50)
        Me.btnAddNewSupplier.TabIndex = 57
        Me.btnAddNewSupplier.Text = "Add New"
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.White
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel33.Location = New System.Drawing.Point(0, 62)
        Me.Panel33.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(1419, 12)
        Me.Panel33.TabIndex = 18
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.White
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel34.Location = New System.Drawing.Point(0, 0)
        Me.Panel34.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(1419, 12)
        Me.Panel34.TabIndex = 18
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.ListView1)
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(13, 12)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1419, 683)
        Me.Panel11.TabIndex = 6
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CompanyName, Me.BankDetails, Me.ContactPerson, Me.PhoneNumber, Me.Address, Me.DeliveryTerms})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 51)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1419, 632)
        Me.ListView1.TabIndex = 36
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CompanyName
        '
        Me.CompanyName.Text = "Company Name"
        Me.CompanyName.Width = 250
        '
        'BankDetails
        '
        Me.BankDetails.Text = "Bank Details"
        Me.BankDetails.Width = 250
        '
        'ContactPerson
        '
        Me.ContactPerson.Text = "Contact Person"
        Me.ContactPerson.Width = 200
        '
        'PhoneNumber
        '
        Me.PhoneNumber.Text = "Phone Number"
        Me.PhoneNumber.Width = 220
        '
        'Address
        '
        Me.Address.Text = "Address"
        Me.Address.Width = 350
        '
        'DeliveryTerms
        '
        Me.DeliveryTerms.Text = "Delivery Terms"
        Me.DeliveryTerms.Width = 180
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 39)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1419, 12)
        Me.Panel13.TabIndex = 1
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.txtSearchSupplierName)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1419, 39)
        Me.Panel12.TabIndex = 0
        '
        'txtSearchSupplierName
        '
        Me.txtSearchSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchSupplierName.DefaultText = ""
        Me.txtSearchSupplierName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchSupplierName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchSupplierName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchSupplierName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchSupplierName.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSearchSupplierName.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.txtSearchSupplierName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearchSupplierName.ForeColor = System.Drawing.Color.Black
        Me.txtSearchSupplierName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSearchSupplierName.Location = New System.Drawing.Point(0, 0)
        Me.txtSearchSupplierName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearchSupplierName.Name = "txtSearchSupplierName"
        Me.txtSearchSupplierName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchSupplierName.PlaceholderText = "Search by company name"
        Me.txtSearchSupplierName.SelectedText = ""
        Me.txtSearchSupplierName.Size = New System.Drawing.Size(419, 39)
        Me.txtSearchSupplierName.TabIndex = 14
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 12)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(13, 683)
        Me.Panel10.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(1432, 12)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(13, 683)
        Me.Panel9.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 695)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1445, 12)
        Me.Panel8.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1445, 12)
        Me.Panel7.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel16)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1445, 707)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List of Products"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.Panel55)
        Me.Panel16.Controls.Add(Me.Panel58)
        Me.Panel16.Controls.Add(Me.Panel59)
        Me.Panel16.Controls.Add(Me.Panel60)
        Me.Panel16.Controls.Add(Me.Panel61)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1445, 707)
        Me.Panel16.TabIndex = 1
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.White
        Me.Panel17.Controls.Add(Me.Panel18)
        Me.Panel17.Controls.Add(Me.Panel21)
        Me.Panel17.Controls.Add(Me.Panel22)
        Me.Panel17.Controls.Add(Me.Panel23)
        Me.Panel17.Controls.Add(Me.Panel24)
        Me.Panel17.Controls.Add(Me.Panel25)
        Me.Panel17.Controls.Add(Me.Panel26)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(13, 621)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1419, 74)
        Me.Panel17.TabIndex = 20
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.White
        Me.Panel18.Controls.Add(Me.btnDeleteProduct)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(400, 12)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(187, 50)
        Me.Panel18.TabIndex = 21
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
        Me.btnDeleteProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.PressedDepth = 20
        Me.btnDeleteProduct.Size = New System.Drawing.Size(187, 50)
        Me.btnDeleteProduct.TabIndex = 58
        Me.btnDeleteProduct.Text = "Delete"
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.White
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel21.Location = New System.Drawing.Point(387, 12)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(13, 50)
        Me.Panel21.TabIndex = 20
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.White
        Me.Panel22.Controls.Add(Me.btnEditProduct)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(200, 12)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(187, 50)
        Me.Panel22.TabIndex = 18
        '
        'btnEditProduct
        '
        Me.btnEditProduct.BorderRadius = 8
        Me.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEditProduct.Enabled = False
        Me.btnEditProduct.FillColor = System.Drawing.Color.OrangeRed
        Me.btnEditProduct.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditProduct.ForeColor = System.Drawing.Color.White
        Me.btnEditProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEditProduct.Location = New System.Drawing.Point(0, 0)
        Me.btnEditProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditProduct.Name = "btnEditProduct"
        Me.btnEditProduct.PressedDepth = 20
        Me.btnEditProduct.Size = New System.Drawing.Size(187, 50)
        Me.btnEditProduct.TabIndex = 58
        Me.btnEditProduct.Text = "Edit"
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
        Me.btnAddNewProduct.Text = "Add New"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.White
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel25.Location = New System.Drawing.Point(0, 62)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1419, 12)
        Me.Panel25.TabIndex = 18
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.White
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(1419, 12)
        Me.Panel26.TabIndex = 18
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
        Me.Panel55.Size = New System.Drawing.Size(1419, 683)
        Me.Panel55.TabIndex = 6
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductName, Me.SupplierName, Me.Description, Me.Category, Me.Type, Me.PurchasePrice, Me.SellingPrice})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(0, 51)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1419, 632)
        Me.ListView2.TabIndex = 36
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
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
        'PurchasePrice
        '
        Me.PurchasePrice.Text = "Purchase Price"
        Me.PurchasePrice.Width = 180
        '
        'SellingPrice
        '
        Me.SellingPrice.Text = "Selling Price"
        Me.SellingPrice.Width = 180
        '
        'Panel56
        '
        Me.Panel56.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel56.Location = New System.Drawing.Point(0, 39)
        Me.Panel56.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel56.Name = "Panel56"
        Me.Panel56.Size = New System.Drawing.Size(1419, 12)
        Me.Panel56.TabIndex = 1
        '
        'Panel57
        '
        Me.Panel57.Controls.Add(Me.txtSearchProduct)
        Me.Panel57.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel57.Location = New System.Drawing.Point(0, 0)
        Me.Panel57.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel57.Name = "Panel57"
        Me.Panel57.Size = New System.Drawing.Size(1419, 39)
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
        'Panel58
        '
        Me.Panel58.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel58.Location = New System.Drawing.Point(0, 12)
        Me.Panel58.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel58.Name = "Panel58"
        Me.Panel58.Size = New System.Drawing.Size(13, 683)
        Me.Panel58.TabIndex = 5
        '
        'Panel59
        '
        Me.Panel59.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel59.Location = New System.Drawing.Point(1432, 12)
        Me.Panel59.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel59.Name = "Panel59"
        Me.Panel59.Size = New System.Drawing.Size(13, 683)
        Me.Panel59.TabIndex = 4
        '
        'Panel60
        '
        Me.Panel60.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel60.Location = New System.Drawing.Point(0, 695)
        Me.Panel60.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel60.Name = "Panel60"
        Me.Panel60.Size = New System.Drawing.Size(1445, 12)
        Me.Panel60.TabIndex = 3
        '
        'Panel61
        '
        Me.Panel61.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel61.Location = New System.Drawing.Point(0, 0)
        Me.Panel61.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel61.Name = "Panel61"
        Me.Panel61.Size = New System.Drawing.Size(1445, 12)
        Me.Panel61.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 12)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 755)
        Me.Panel3.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 767)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1466, 12)
        Me.Panel2.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1466, 12)
        Me.Panel4.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1466, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(13, 779)
        Me.Panel1.TabIndex = 27
        '
        'frmManageSupplierProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 779)
        Me.Controls.Add(Me.pnlBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmManageSupplierProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlBody.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel31.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel55.ResumeLayout(False)
        Me.Panel57.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBody As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl2 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents CompanyName As ColumnHeader
    Friend WithEvents BankDetails As ColumnHeader
    Friend WithEvents ContactPerson As ColumnHeader
    Friend WithEvents PhoneNumber As ColumnHeader
    Friend WithEvents Address As ColumnHeader
    Friend WithEvents DeliveryTerms As ColumnHeader
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txtSearchSupplierName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel55 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ProductName As ColumnHeader
    Friend WithEvents SupplierName As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents PurchasePrice As ColumnHeader
    Friend WithEvents SellingPrice As ColumnHeader
    Friend WithEvents Panel56 As Panel
    Friend WithEvents Panel57 As Panel
    Friend WithEvents txtSearchProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel58 As Panel
    Friend WithEvents Panel59 As Panel
    Friend WithEvents Panel60 As Panel
    Friend WithEvents Panel61 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents btnEditSupplier As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel31 As Panel
    Friend WithEvents btnAddNewSupplier As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents btnDeleteSupplier As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents btnDeleteProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents btnEditProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents btnAddNewProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel26 As Panel
End Class
