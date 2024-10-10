<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageRentalV2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageRentalV2))
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.cboAdjust = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.txtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.cboFormat = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.cboSalesman = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPONo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBusinessStyle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTIN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTerms = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDeliveryAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblBillingID = New System.Windows.Forms.Label()
        Me.lblOrderListID = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnSearchCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panelBody.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.SystemColors.Control
        Me.panelBody.Controls.Add(Me.Panel5)
        Me.panelBody.Controls.Add(Me.Panel4)
        Me.panelBody.Controls.Add(Me.Panel3)
        Me.panelBody.Controls.Add(Me.Panel2)
        Me.panelBody.Controls.Add(Me.Panel1)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 0)
        Me.panelBody.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1479, 779)
        Me.panelBody.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Panel30)
        Me.Panel5.Controls.Add(Me.ListView1)
        Me.Panel5.Controls.Add(Me.Panel19)
        Me.Panel5.Controls.Add(Me.Panel18)
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel11)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(13, 12)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1453, 755)
        Me.Panel5.TabIndex = 5
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.White
        Me.Panel30.Controls.Add(Me.Panel22)
        Me.Panel30.Controls.Add(Me.Panel25)
        Me.Panel30.Controls.Add(Me.Panel20)
        Me.Panel30.Controls.Add(Me.Panel26)
        Me.Panel30.Controls.Add(Me.Panel27)
        Me.Panel30.Controls.Add(Me.Panel21)
        Me.Panel30.Controls.Add(Me.Panel23)
        Me.Panel30.Controls.Add(Me.Panel34)
        Me.Panel30.Controls.Add(Me.Panel32)
        Me.Panel30.Controls.Add(Me.Panel31)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel30.Location = New System.Drawing.Point(13, 681)
        Me.Panel30.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(1427, 74)
        Me.Panel30.TabIndex = 95
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.White
        Me.Panel22.Controls.Add(Me.cboAdjust)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel22.Location = New System.Drawing.Point(582, 12)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(275, 50)
        Me.Panel22.TabIndex = 20
        '
        'cboAdjust
        '
        Me.cboAdjust.BackColor = System.Drawing.Color.Transparent
        Me.cboAdjust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboAdjust.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAdjust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAdjust.FocusedColor = System.Drawing.Color.OrangeRed
        Me.cboAdjust.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.cboAdjust.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboAdjust.ForeColor = System.Drawing.Color.Black
        Me.cboAdjust.ItemHeight = 30
        Me.cboAdjust.Items.AddRange(New Object() {"Update Price", "Add Discount", "Add Mark Up"})
        Me.cboAdjust.Location = New System.Drawing.Point(0, 0)
        Me.cboAdjust.Margin = New System.Windows.Forms.Padding(5)
        Me.cboAdjust.Name = "cboAdjust"
        Me.cboAdjust.Size = New System.Drawing.Size(275, 36)
        Me.cboAdjust.StartIndex = 0
        Me.cboAdjust.TabIndex = 131
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.White
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel25.Location = New System.Drawing.Point(857, 12)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(13, 50)
        Me.Panel25.TabIndex = 23
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.White
        Me.Panel20.Controls.Add(Me.btnDelete)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel20.Location = New System.Drawing.Point(200, 12)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(187, 50)
        Me.Panel20.TabIndex = 22
        '
        'btnDelete
        '
        Me.btnDelete.BorderRadius = 8
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelete.FillColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDelete.Location = New System.Drawing.Point(0, 0)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PressedDepth = 20
        Me.btnDelete.Size = New System.Drawing.Size(187, 50)
        Me.btnDelete.TabIndex = 57
        Me.btnDelete.Text = "Cancel"
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.White
        Me.Panel26.Controls.Add(Me.txtAmount)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel26.Location = New System.Drawing.Point(870, 12)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(269, 50)
        Me.Panel26.TabIndex = 24
        '
        'txtAmount
        '
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmount.DefaultText = ""
        Me.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmount.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtAmount.DisabledState.ForeColor = System.Drawing.Color.DimGray
        Me.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAmount.Enabled = False
        Me.txtAmount.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.txtAmount.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtAmount.Location = New System.Drawing.Point(0, 0)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmount.PlaceholderText = "Enter amount"
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.Size = New System.Drawing.Size(269, 50)
        Me.txtAmount.TabIndex = 124
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.White
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel27.Location = New System.Drawing.Point(1139, 12)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(13, 50)
        Me.Panel27.TabIndex = 26
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.White
        Me.Panel21.Controls.Add(Me.cboFormat)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel21.Location = New System.Drawing.Point(1152, 12)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(275, 50)
        Me.Panel21.TabIndex = 25
        '
        'cboFormat
        '
        Me.cboFormat.BackColor = System.Drawing.Color.Transparent
        Me.cboFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormat.Enabled = False
        Me.cboFormat.FocusedColor = System.Drawing.Color.OrangeRed
        Me.cboFormat.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.cboFormat.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboFormat.ForeColor = System.Drawing.Color.Black
        Me.cboFormat.ItemHeight = 30
        Me.cboFormat.Items.AddRange(New Object() {"In Percent", "In Whole Number"})
        Me.cboFormat.Location = New System.Drawing.Point(0, 0)
        Me.cboFormat.Margin = New System.Windows.Forms.Padding(5)
        Me.cboFormat.Name = "cboFormat"
        Me.cboFormat.Size = New System.Drawing.Size(275, 36)
        Me.cboFormat.StartIndex = 0
        Me.cboFormat.TabIndex = 131
        Me.cboFormat.Visible = False
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.White
        Me.Panel23.Controls.Add(Me.Panel13)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(187, 12)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(13, 50)
        Me.Panel23.TabIndex = 19
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.White
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(13, 50)
        Me.Panel13.TabIndex = 20
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.White
        Me.Panel34.Controls.Add(Me.btnPrint)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel34.Location = New System.Drawing.Point(0, 12)
        Me.Panel34.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(187, 50)
        Me.Panel34.TabIndex = 18
        '
        'btnPrint
        '
        Me.btnPrint.BorderRadius = 8
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPrint.FillColor = System.Drawing.Color.OrangeRed
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPrint.Location = New System.Drawing.Point(0, 0)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.PressedDepth = 20
        Me.btnPrint.Size = New System.Drawing.Size(187, 50)
        Me.btnPrint.TabIndex = 57
        Me.btnPrint.Text = "Print"
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.White
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel32.Location = New System.Drawing.Point(0, 62)
        Me.Panel32.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(1427, 12)
        Me.Panel32.TabIndex = 18
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.White
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel31.Location = New System.Drawing.Point(0, 0)
        Me.Panel31.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(1427, 12)
        Me.Panel31.TabIndex = 18
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 330)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1427, 425)
        Me.ListView1.TabIndex = 94
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Quantity"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Unit"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 350
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit Price"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 200
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.White
        Me.Panel19.Controls.Add(Me.cboSalesman)
        Me.Panel19.Controls.Add(Me.Label7)
        Me.Panel19.Controls.Add(Me.txtPONo)
        Me.Panel19.Controls.Add(Me.Label5)
        Me.Panel19.Controls.Add(Me.dtpDate)
        Me.Panel19.Controls.Add(Me.Label9)
        Me.Panel19.Controls.Add(Me.txtBusinessStyle)
        Me.Panel19.Controls.Add(Me.Label6)
        Me.Panel19.Controls.Add(Me.txtTIN)
        Me.Panel19.Controls.Add(Me.Label8)
        Me.Panel19.Controls.Add(Me.txtTerms)
        Me.Panel19.Controls.Add(Me.Label1)
        Me.Panel19.Controls.Add(Me.txtDeliveryAddress)
        Me.Panel19.Controls.Add(Me.Label4)
        Me.Panel19.Controls.Add(Me.txtAddress)
        Me.Panel19.Controls.Add(Me.Label3)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(13, 74)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1427, 256)
        Me.Panel19.TabIndex = 92
        '
        'cboSalesman
        '
        Me.cboSalesman.BackColor = System.Drawing.Color.Transparent
        Me.cboSalesman.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSalesman.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSalesman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSalesman.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboSalesman.ForeColor = System.Drawing.Color.Black
        Me.cboSalesman.ItemHeight = 30
        Me.cboSalesman.Items.AddRange(New Object() {"Saavedra", "Blacer", "Almiranez"})
        Me.cboSalesman.Location = New System.Drawing.Point(655, 181)
        Me.cboSalesman.Margin = New System.Windows.Forms.Padding(5)
        Me.cboSalesman.Name = "cboSalesman"
        Me.cboSalesman.Size = New System.Drawing.Size(325, 36)
        Me.cboSalesman.TabIndex = 129
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(649, 151)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 24)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Salesman"
        '
        'txtPONo
        '
        Me.txtPONo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPONo.DefaultText = ""
        Me.txtPONo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPONo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPONo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPONo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPONo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPONo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtPONo.ForeColor = System.Drawing.Color.Black
        Me.txtPONo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPONo.Location = New System.Drawing.Point(1, 181)
        Me.txtPONo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPONo.PlaceholderText = "Enter purchase order number"
        Me.txtPONo.SelectedText = ""
        Me.txtPONo.Size = New System.Drawing.Size(313, 44)
        Me.txtPONo.TabIndex = 127
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(-4, 153)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 24)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "P.O. Number"
        '
        'dtpDate
        '
        Me.dtpDate.Checked = True
        Me.dtpDate.FillColor = System.Drawing.Color.White
        Me.dtpDate.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.dtpDate.ForeColor = System.Drawing.Color.Black
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDate.Location = New System.Drawing.Point(995, 181)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(320, 44)
        Me.dtpDate.TabIndex = 125
        Me.dtpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtpDate.Value = New Date(2024, 5, 29, 14, 58, 8, 655)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(989, 151)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 24)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "Date"
        '
        'txtBusinessStyle
        '
        Me.txtBusinessStyle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusinessStyle.DefaultText = ""
        Me.txtBusinessStyle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBusinessStyle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBusinessStyle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessStyle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessStyle.Enabled = False
        Me.txtBusinessStyle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBusinessStyle.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtBusinessStyle.ForeColor = System.Drawing.Color.Black
        Me.txtBusinessStyle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBusinessStyle.Location = New System.Drawing.Point(655, 38)
        Me.txtBusinessStyle.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBusinessStyle.Name = "txtBusinessStyle"
        Me.txtBusinessStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusinessStyle.PlaceholderText = "Enter business style"
        Me.txtBusinessStyle.SelectedText = ""
        Me.txtBusinessStyle.Size = New System.Drawing.Size(327, 44)
        Me.txtBusinessStyle.TabIndex = 123
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(649, 10)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 24)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Business Style"
        '
        'txtTIN
        '
        Me.txtTIN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTIN.DefaultText = ""
        Me.txtTIN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTIN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTIN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTIN.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTIN.ForeColor = System.Drawing.Color.Black
        Me.txtTIN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtTIN.Location = New System.Drawing.Point(995, 38)
        Me.txtTIN.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTIN.PlaceholderText = "Enter TIN"
        Me.txtTIN.SelectedText = ""
        Me.txtTIN.Size = New System.Drawing.Size(320, 44)
        Me.txtTIN.TabIndex = 121
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(991, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 24)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "TIN"
        '
        'txtTerms
        '
        Me.txtTerms.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTerms.DefaultText = ""
        Me.txtTerms.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTerms.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTerms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTerms.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTerms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTerms.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTerms.ForeColor = System.Drawing.Color.Black
        Me.txtTerms.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtTerms.Location = New System.Drawing.Point(328, 181)
        Me.txtTerms.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTerms.PlaceholderText = "Enter terms"
        Me.txtTerms.SelectedText = ""
        Me.txtTerms.Size = New System.Drawing.Size(313, 44)
        Me.txtTerms.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(323, 153)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 24)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Terms"
        '
        'txtDeliveryAddress
        '
        Me.txtDeliveryAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeliveryAddress.DefaultText = ""
        Me.txtDeliveryAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDeliveryAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDeliveryAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDeliveryAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDeliveryAddress.Enabled = False
        Me.txtDeliveryAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDeliveryAddress.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtDeliveryAddress.ForeColor = System.Drawing.Color.Black
        Me.txtDeliveryAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtDeliveryAddress.Location = New System.Drawing.Point(328, 38)
        Me.txtDeliveryAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDeliveryAddress.Multiline = True
        Me.txtDeliveryAddress.Name = "txtDeliveryAddress"
        Me.txtDeliveryAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeliveryAddress.PlaceholderText = "Enter delivery address"
        Me.txtDeliveryAddress.SelectedText = ""
        Me.txtDeliveryAddress.Size = New System.Drawing.Size(313, 100)
        Me.txtDeliveryAddress.TabIndex = 115
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(323, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 24)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Delivery Address"
        '
        'txtAddress
        '
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.Enabled = False
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(1, 38)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = "Enter company address"
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(313, 100)
        Me.txtAddress.TabIndex = 113
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(-4, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Address"
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(13, 62)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1427, 12)
        Me.Panel18.TabIndex = 4
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(1440, 62)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(13, 693)
        Me.Panel12.TabIndex = 3
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 62)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(13, 693)
        Me.Panel11.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel9.Controls.Add(Me.lblBillingID)
        Me.Panel9.Controls.Add(Me.lblOrderListID)
        Me.Panel9.Controls.Add(Me.Panel6)
        Me.Panel9.Controls.Add(Me.lblProductID)
        Me.Panel9.Controls.Add(Me.Panel15)
        Me.Panel9.Controls.Add(Me.lblOrderID)
        Me.Panel9.Controls.Add(Me.lblCustID)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1453, 62)
        Me.Panel9.TabIndex = 1
        '
        'lblBillingID
        '
        Me.lblBillingID.AutoSize = True
        Me.lblBillingID.BackColor = System.Drawing.Color.Transparent
        Me.lblBillingID.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingID.ForeColor = System.Drawing.Color.White
        Me.lblBillingID.Location = New System.Drawing.Point(717, 20)
        Me.lblBillingID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBillingID.Name = "lblBillingID"
        Me.lblBillingID.Size = New System.Drawing.Size(57, 16)
        Me.lblBillingID.TabIndex = 99
        Me.lblBillingID.Text = "Label10"
        Me.lblBillingID.Visible = False
        '
        'lblOrderListID
        '
        Me.lblOrderListID.AutoSize = True
        Me.lblOrderListID.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderListID.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderListID.ForeColor = System.Drawing.Color.White
        Me.lblOrderListID.Location = New System.Drawing.Point(601, 18)
        Me.lblOrderListID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderListID.Name = "lblOrderListID"
        Me.lblOrderListID.Size = New System.Drawing.Size(94, 16)
        Me.lblOrderListID.TabIndex = 98
        Me.lblOrderListID.Text = "lblOrderListID"
        Me.lblOrderListID.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnSearchCustomer)
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Controls.Add(Me.txtCompanyName)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Panel14)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(816, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(637, 62)
        Me.Panel6.TabIndex = 2
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
        Me.btnSearchCustomer.Location = New System.Drawing.Point(112, 12)
        Me.btnSearchCustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.PressedDepth = 20
        Me.btnSearchCustomer.Size = New System.Drawing.Size(47, 38)
        Me.btnSearchCustomer.TabIndex = 85
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(159, 12)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(13, 38)
        Me.Panel10.TabIndex = 2
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompanyName.DefaultText = ""
        Me.txtCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtCompanyName.Enabled = False
        Me.txtCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCompanyName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCompanyName.Location = New System.Drawing.Point(172, 12)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompanyName.PlaceholderText = "Search company name"
        Me.txtCompanyName.SelectedText = ""
        Me.txtCompanyName.Size = New System.Drawing.Size(452, 38)
        Me.txtCompanyName.TabIndex = 46
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 50)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(624, 12)
        Me.Panel8.TabIndex = 47
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(624, 12)
        Me.Panel7.TabIndex = 2
        '
        'Panel14
        '
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(624, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(13, 62)
        Me.Panel14.TabIndex = 2
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.BackColor = System.Drawing.Color.Transparent
        Me.lblProductID.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.ForeColor = System.Drawing.Color.White
        Me.lblProductID.Location = New System.Drawing.Point(496, 20)
        Me.lblProductID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(85, 16)
        Me.lblProductID.TabIndex = 97
        Me.lblProductID.Text = "lblProductID"
        Me.lblProductID.Visible = False
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Label2)
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Controls.Add(Me.Panel17)
        Me.Panel15.Controls.Add(Me.Panel24)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(227, 62)
        Me.Panel15.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 29)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Rent Products"
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(0, 18)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(13, 32)
        Me.Panel16.TabIndex = 13
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 50)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(227, 12)
        Me.Panel17.TabIndex = 13
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(227, 18)
        Me.Panel24.TabIndex = 13
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderID.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.ForeColor = System.Drawing.Color.White
        Me.lblOrderID.Location = New System.Drawing.Point(405, 20)
        Me.lblOrderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(72, 16)
        Me.lblOrderID.TabIndex = 96
        Me.lblOrderID.Text = "lblOrderID"
        Me.lblOrderID.Visible = False
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.BackColor = System.Drawing.Color.Transparent
        Me.lblCustID.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustID.ForeColor = System.Drawing.Color.White
        Me.lblCustID.Location = New System.Drawing.Point(305, 18)
        Me.lblCustID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(63, 16)
        Me.lblCustID.TabIndex = 95
        Me.lblCustID.Text = "lblCustID"
        Me.lblCustID.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(13, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1453, 12)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(13, 767)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1453, 12)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1466, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 779)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(13, 779)
        Me.Panel1.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmManageRentalV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 779)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmManageRentalV2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelBody.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel30.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel34.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelBody As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel19 As Panel
    Friend WithEvents cboSalesman As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPONo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBusinessStyle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTIN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTerms As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDeliveryAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblBillingID As Label
    Friend WithEvents lblOrderListID As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSearchCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents lblProductID As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblCustID As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents cboAdjust As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel26 As Panel
    Friend WithEvents txtAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents cboFormat As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel31 As Panel
End Class
