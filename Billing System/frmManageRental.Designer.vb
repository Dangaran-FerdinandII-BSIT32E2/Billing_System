<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageRental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageRental))
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnSearchRental = New Guna.UI2.WinForms.Guna2Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearchRental = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCreateNew = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAvailability = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.btnSearchRental)
        Me.Guna2GroupBox2.Controls.Add(Me.ListView1)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel4)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel1)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel3)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel2)
        Me.Guna2GroupBox2.Controls.Add(Me.txtSearchRental)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.BorderRadius = 5
        Me.Guna2GroupBox2.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1095, 304)
        Me.Guna2GroupBox2.TabIndex = 4
        '
        'btnSearchRental
        '
        Me.btnSearchRental.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchRental.BorderRadius = 8
        Me.btnSearchRental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchRental.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchRental.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchRental.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchRental.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchRental.FillColor = System.Drawing.Color.MediumBlue
        Me.btnSearchRental.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchRental.ForeColor = System.Drawing.Color.White
        Me.btnSearchRental.Image = CType(resources.GetObject("btnSearchRental.Image"), System.Drawing.Image)
        Me.btnSearchRental.Location = New System.Drawing.Point(727, 8)
        Me.btnSearchRental.Name = "btnSearchRental"
        Me.btnSearchRental.PressedDepth = 20
        Me.btnSearchRental.Size = New System.Drawing.Size(41, 36)
        Me.btnSearchRental.TabIndex = 45
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader9, Me.ColumnHeader2})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(10, 60)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1075, 234)
        Me.ListView1.TabIndex = 34
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Desription"
        Me.ColumnHeader1.Width = 350
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Rate"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Availability"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 294)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1075, 10)
        Me.Panel4.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 244)
        Me.Panel1.TabIndex = 32
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1085, 10)
        Me.Panel3.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 22)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "List of Rental"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1085, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 254)
        Me.Panel2.TabIndex = 33
        '
        'txtSearchRental
        '
        Me.txtSearchRental.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchRental.DefaultText = ""
        Me.txtSearchRental.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchRental.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchRental.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchRental.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchRental.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtSearchRental.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearchRental.ForeColor = System.Drawing.Color.Black
        Me.txtSearchRental.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtSearchRental.Location = New System.Drawing.Point(774, 10)
        Me.txtSearchRental.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchRental.Name = "txtSearchRental"
        Me.txtSearchRental.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchRental.PlaceholderText = "Search by availability"
        Me.txtSearchRental.SelectedText = ""
        Me.txtSearchRental.Size = New System.Drawing.Size(314, 30)
        Me.txtSearchRental.TabIndex = 12
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.btnDelete)
        Me.Guna2GroupBox1.Controls.Add(Me.btnCreateNew)
        Me.Guna2GroupBox1.Controls.Add(Me.btnCancel)
        Me.Guna2GroupBox1.Controls.Add(Me.btnEdit)
        Me.Guna2GroupBox1.Controls.Add(Me.btnSave)
        Me.Guna2GroupBox1.Controls.Add(Me.txtAvailability)
        Me.Guna2GroupBox1.Controls.Add(Me.txtRate)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtProductDescription)
        Me.Guna2GroupBox1.Controls.Add(Me.Label22)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(6, 317)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 5
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1095, 304)
        Me.Guna2GroupBox1.TabIndex = 12
        Me.Guna2GroupBox1.Text = "Manage Rental"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(423, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Rate"
        '
        'btnDelete
        '
        Me.btnDelete.BorderRadius = 8
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.Blue
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDelete.Location = New System.Drawing.Point(767, 257)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PressedDepth = 20
        Me.btnDelete.Size = New System.Drawing.Size(152, 36)
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
        Me.btnCreateNew.FillColor = System.Drawing.Color.MediumBlue
        Me.btnCreateNew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCreateNew.ForeColor = System.Drawing.Color.White
        Me.btnCreateNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCreateNew.Location = New System.Drawing.Point(9, 257)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.PressedDepth = 20
        Me.btnCreateNew.Size = New System.Drawing.Size(152, 36)
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
        Me.btnCancel.FillColor = System.Drawing.Color.Blue
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.Location = New System.Drawing.Point(932, 257)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedDepth = 20
        Me.btnCancel.Size = New System.Drawing.Size(152, 36)
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
        Me.btnEdit.FillColor = System.Drawing.Color.Blue
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEdit.Location = New System.Drawing.Point(173, 257)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PressedDepth = 20
        Me.btnEdit.Size = New System.Drawing.Size(152, 36)
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
        Me.btnSave.FillColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.Location = New System.Drawing.Point(337, 257)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PressedDepth = 20
        Me.btnSave.Size = New System.Drawing.Size(152, 36)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "Save"
        '
        'txtAvailability
        '
        Me.txtAvailability.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAvailability.DefaultText = ""
        Me.txtAvailability.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAvailability.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAvailability.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAvailability.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAvailability.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAvailability.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtAvailability.ForeColor = System.Drawing.Color.Black
        Me.txtAvailability.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAvailability.Location = New System.Drawing.Point(790, 78)
        Me.txtAvailability.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAvailability.Name = "txtAvailability"
        Me.txtAvailability.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAvailability.PlaceholderText = "Enter availability"
        Me.txtAvailability.SelectedText = ""
        Me.txtAvailability.Size = New System.Drawing.Size(295, 36)
        Me.txtAvailability.TabIndex = 42
        '
        'txtRate
        '
        Me.txtRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRate.DefaultText = ""
        Me.txtRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRate.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRate.ForeColor = System.Drawing.Color.Black
        Me.txtRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRate.Location = New System.Drawing.Point(427, 78)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRate.PlaceholderText = "Enter rate"
        Me.txtRate.SelectedText = ""
        Me.txtRate.Size = New System.Drawing.Size(339, 36)
        Me.txtRate.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(789, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Availability"
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductDescription.DefaultText = ""
        Me.txtProductDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductDescription.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtProductDescription.ForeColor = System.Drawing.Color.Black
        Me.txtProductDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductDescription.Location = New System.Drawing.Point(9, 78)
        Me.txtProductDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductDescription.PlaceholderText = "Enter product description"
        Me.txtProductDescription.SelectedText = ""
        Me.txtProductDescription.Size = New System.Drawing.Size(395, 126)
        Me.txtProductDescription.TabIndex = 27
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(8, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(156, 19)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "Product Desciption"
        '
        'frmManageRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 633)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageRental"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearchRental As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCreateNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAvailability As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents btnSearchRental As Guna.UI2.WinForms.Guna2Button
End Class
