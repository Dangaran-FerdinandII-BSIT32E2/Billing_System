﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageProducts))
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnSearchProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearchProduct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblModelNo = New System.Windows.Forms.Label()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCreateNew = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSellingPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPurchasePrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtYearManufactured = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCategory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSupplier = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtManufacturer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProductName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.btnSearchProduct)
        Me.Guna2GroupBox2.Controls.Add(Me.ListView1)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel4)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel1)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel3)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel2)
        Me.Guna2GroupBox2.Controls.Add(Me.txtSearchProduct)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(8, 7)
        Me.Guna2GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.BorderRadius = 5
        Me.Guna2GroupBox2.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1460, 374)
        Me.Guna2GroupBox2.TabIndex = 3
        '
        'btnSearchProduct
        '
        Me.btnSearchProduct.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchProduct.BorderRadius = 8
        Me.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchProduct.FillColor = System.Drawing.Color.Blue
        Me.btnSearchProduct.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchProduct.ForeColor = System.Drawing.Color.White
        Me.btnSearchProduct.Image = CType(resources.GetObject("btnSearchProduct.Image"), System.Drawing.Image)
        Me.btnSearchProduct.Location = New System.Drawing.Point(971, 10)
        Me.btnSearchProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.PressedDepth = 20
        Me.btnSearchProduct.Size = New System.Drawing.Size(55, 44)
        Me.btnSearchProduct.TabIndex = 45
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader9, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 62)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1434, 300)
        Me.ListView1.TabIndex = 34
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Name"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Supplier Name"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 350
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Category"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Manufacturer"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 220
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Model Number"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 345
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Year Manufactured"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Purchase Price"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 180
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Selling Price"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 150
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 362)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1434, 12)
        Me.Panel4.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(13, 312)
        Me.Panel1.TabIndex = 32
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1447, 12)
        Me.Panel3.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 29)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "List of Products"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1447, 50)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 324)
        Me.Panel2.TabIndex = 33
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchProduct.DefaultText = ""
        Me.txtSearchProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchProduct.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtSearchProduct.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearchProduct.ForeColor = System.Drawing.Color.Black
        Me.txtSearchProduct.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtSearchProduct.Location = New System.Drawing.Point(1032, 12)
        Me.txtSearchProduct.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchProduct.PlaceholderText = "Search by product name"
        Me.txtSearchProduct.SelectedText = ""
        Me.txtSearchProduct.Size = New System.Drawing.Size(419, 37)
        Me.txtSearchProduct.TabIndex = 12
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.Panel5)
        Me.Guna2GroupBox1.Controls.Add(Me.btnDelete)
        Me.Guna2GroupBox1.Controls.Add(Me.btnCreateNew)
        Me.Guna2GroupBox1.Controls.Add(Me.btnCancel)
        Me.Guna2GroupBox1.Controls.Add(Me.btnEdit)
        Me.Guna2GroupBox1.Controls.Add(Me.btnSave)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSellingPrice)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.txtPurchasePrice)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.txtYearManufactured)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.txtCategory)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.txtDescription)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSupplier)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtManufacturer)
        Me.Guna2GroupBox1.Controls.Add(Me.txtProductName)
        Me.Guna2GroupBox1.Controls.Add(Me.Label22)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(8, 390)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 5
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1460, 374)
        Me.Guna2GroupBox1.TabIndex = 11
        Me.Guna2GroupBox1.Text = "Manage Product"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(303, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 24)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Supplier Name"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.lblModelNo)
        Me.Panel5.Location = New System.Drawing.Point(801, 12)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(644, 28)
        Me.Panel5.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(409, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 24)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Model Number: "
        '
        'lblModelNo
        '
        Me.lblModelNo.AutoSize = True
        Me.lblModelNo.BackColor = System.Drawing.Color.Transparent
        Me.lblModelNo.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblModelNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelNo.ForeColor = System.Drawing.Color.White
        Me.lblModelNo.Location = New System.Drawing.Point(569, 0)
        Me.lblModelNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelNo.Name = "lblModelNo"
        Me.lblModelNo.Size = New System.Drawing.Size(75, 24)
        Me.lblModelNo.TabIndex = 28
        Me.lblModelNo.Text = "XXXXX"
        '
        'btnDelete
        '
        Me.btnDelete.BorderRadius = 8
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.Enabled = False
        Me.btnDelete.FillColor = System.Drawing.Color.Blue
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDelete.Location = New System.Drawing.Point(1023, 316)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PressedDepth = 20
        Me.btnDelete.Size = New System.Drawing.Size(203, 44)
        Me.btnDelete.TabIndex = 62
        Me.btnDelete.Text = "Delete"
        '
        'btnCreateNew
        '
        Me.btnCreateNew.BorderRadius = 8
        Me.btnCreateNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreateNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreateNew.FillColor = System.Drawing.Color.Blue
        Me.btnCreateNew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCreateNew.ForeColor = System.Drawing.Color.White
        Me.btnCreateNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCreateNew.Location = New System.Drawing.Point(12, 316)
        Me.btnCreateNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.PressedDepth = 20
        Me.btnCreateNew.Size = New System.Drawing.Size(203, 44)
        Me.btnCreateNew.TabIndex = 61
        Me.btnCreateNew.Text = "Create New"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 8
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.Enabled = False
        Me.btnCancel.FillColor = System.Drawing.Color.Blue
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.Location = New System.Drawing.Point(1243, 316)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedDepth = 20
        Me.btnCancel.Size = New System.Drawing.Size(203, 44)
        Me.btnCancel.TabIndex = 60
        Me.btnCancel.Text = "Cancel"
        '
        'btnEdit
        '
        Me.btnEdit.BorderRadius = 8
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.Enabled = False
        Me.btnEdit.FillColor = System.Drawing.Color.Blue
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEdit.Location = New System.Drawing.Point(231, 316)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PressedDepth = 20
        Me.btnEdit.Size = New System.Drawing.Size(203, 44)
        Me.btnEdit.TabIndex = 59
        Me.btnEdit.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 8
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Enabled = False
        Me.btnSave.FillColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.Location = New System.Drawing.Point(449, 316)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PressedDepth = 20
        Me.btnSave.Size = New System.Drawing.Size(203, 44)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "Save"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSellingPrice.DefaultText = ""
        Me.txtSellingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSellingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSellingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSellingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSellingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSellingPrice.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSellingPrice.ForeColor = System.Drawing.Color.Black
        Me.txtSellingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSellingPrice.Location = New System.Drawing.Point(1105, 206)
        Me.txtSellingPrice.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSellingPrice.PlaceholderText = "Enter selling price"
        Me.txtSellingPrice.SelectedText = ""
        Me.txtSellingPrice.Size = New System.Drawing.Size(341, 44)
        Me.txtSellingPrice.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1101, 177)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 24)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Selling Price"
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPurchasePrice.DefaultText = ""
        Me.txtPurchasePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPurchasePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPurchasePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPurchasePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPurchasePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPurchasePrice.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtPurchasePrice.ForeColor = System.Drawing.Color.Black
        Me.txtPurchasePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPurchasePrice.Location = New System.Drawing.Point(749, 206)
        Me.txtPurchasePrice.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPurchasePrice.PlaceholderText = "Enter purchase price"
        Me.txtPurchasePrice.SelectedText = ""
        Me.txtPurchasePrice.Size = New System.Drawing.Size(340, 44)
        Me.txtPurchasePrice.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(748, 177)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 24)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Purchase Price"
        '
        'txtYearManufactured
        '
        Me.txtYearManufactured.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYearManufactured.DefaultText = ""
        Me.txtYearManufactured.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtYearManufactured.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtYearManufactured.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYearManufactured.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYearManufactured.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYearManufactured.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtYearManufactured.ForeColor = System.Drawing.Color.Black
        Me.txtYearManufactured.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYearManufactured.Location = New System.Drawing.Point(308, 206)
        Me.txtYearManufactured.Margin = New System.Windows.Forms.Padding(5)
        Me.txtYearManufactured.Name = "txtYearManufactured"
        Me.txtYearManufactured.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYearManufactured.PlaceholderText = "Enter year manufactured"
        Me.txtYearManufactured.SelectedText = ""
        Me.txtYearManufactured.Size = New System.Drawing.Size(425, 44)
        Me.txtYearManufactured.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(301, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 24)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Year Manufactured"
        '
        'txtCategory
        '
        Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategory.DefaultText = ""
        Me.txtCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCategory.ForeColor = System.Drawing.Color.Black
        Me.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.Location = New System.Drawing.Point(1105, 96)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCategory.PlaceholderText = "Enter category"
        Me.txtCategory.SelectedText = ""
        Me.txtCategory.Size = New System.Drawing.Size(341, 44)
        Me.txtCategory.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(11, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 24)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Manufacturer"
        '
        'txtDescription
        '
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(749, 96)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = "Enter description"
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(340, 44)
        Me.txtDescription.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1101, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Category"
        '
        'txtSupplier
        '
        Me.txtSupplier.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupplier.DefaultText = ""
        Me.txtSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupplier.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSupplier.ForeColor = System.Drawing.Color.Black
        Me.txtSupplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupplier.Location = New System.Drawing.Point(308, 96)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupplier.PlaceholderText = "Enter supplier name"
        Me.txtSupplier.SelectedText = ""
        Me.txtSupplier.Size = New System.Drawing.Size(425, 44)
        Me.txtSupplier.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(748, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Description"
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtManufacturer.DefaultText = ""
        Me.txtManufacturer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtManufacturer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtManufacturer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtManufacturer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtManufacturer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtManufacturer.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtManufacturer.ForeColor = System.Drawing.Color.Black
        Me.txtManufacturer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtManufacturer.Location = New System.Drawing.Point(12, 206)
        Me.txtManufacturer.Margin = New System.Windows.Forms.Padding(5)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtManufacturer.PlaceholderText = "Enter manufacturer"
        Me.txtManufacturer.SelectedText = ""
        Me.txtManufacturer.Size = New System.Drawing.Size(281, 44)
        Me.txtManufacturer.TabIndex = 29
        '
        'txtProductName
        '
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.DefaultText = ""
        Me.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.Location = New System.Drawing.Point(12, 96)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductName.PlaceholderText = "Enter name of product"
        Me.txtProductName.SelectedText = ""
        Me.txtProductName.Size = New System.Drawing.Size(281, 44)
        Me.txtProductName.TabIndex = 27
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(11, 68)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(144, 24)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "Product Name"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmManageProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 779)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmManageProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearchProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtSupplier As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtManufacturer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblModelNo As Label
    Friend WithEvents txtProductName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents txtCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSellingPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPurchasePrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtYearManufactured As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCreateNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents btnSearchProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
