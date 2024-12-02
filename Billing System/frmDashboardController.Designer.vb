<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboardController
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
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.TabControl2 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.RambicOrderUpdates = New System.Windows.Forms.TabPage()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.OrderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.ReOrderUpdates = New System.Windows.Forms.TabPage()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnViewRental = New Guna.UI2.WinForms.Guna2Button()
        Me.lblNewRentals = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnViewOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.lblNewOrders = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnViewPayment = New Guna.UI2.WinForms.Guna2Button()
        Me.lblNewPayments = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OverduePayments = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.panelBody.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.RambicOrderUpdates.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.ReOrderUpdates.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.OverduePayments.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.TabControl2)
        Me.panelBody.Controls.Add(Me.Panel9)
        Me.panelBody.Controls.Add(Me.Panel6)
        Me.panelBody.Controls.Add(Me.Panel4)
        Me.panelBody.Controls.Add(Me.Panel3)
        Me.panelBody.Controls.Add(Me.Panel2)
        Me.panelBody.Controls.Add(Me.Panel1)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 0)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1109, 633)
        Me.panelBody.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.RambicOrderUpdates)
        Me.TabControl2.Controls.Add(Me.ReOrderUpdates)
        Me.TabControl2.Controls.Add(Me.OverduePayments)
        Me.TabControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ItemSize = New System.Drawing.Size(361, 40)
        Me.TabControl2.Location = New System.Drawing.Point(10, 163)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.ShowToolTips = True
        Me.TabControl2.Size = New System.Drawing.Size(1089, 460)
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
        Me.TabControl2.TabButtonSize = New System.Drawing.Size(361, 40)
        Me.TabControl2.TabIndex = 23
        Me.TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'RambicOrderUpdates
        '
        Me.RambicOrderUpdates.Controls.Add(Me.Panel16)
        Me.RambicOrderUpdates.Location = New System.Drawing.Point(4, 44)
        Me.RambicOrderUpdates.Name = "RambicOrderUpdates"
        Me.RambicOrderUpdates.Padding = New System.Windows.Forms.Padding(3)
        Me.RambicOrderUpdates.Size = New System.Drawing.Size(1081, 412)
        Me.RambicOrderUpdates.TabIndex = 3
        Me.RambicOrderUpdates.Text = "Rambic Order Updates"
        Me.RambicOrderUpdates.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.ListView2)
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.Panel18)
        Me.Panel16.Controls.Add(Me.Panel19)
        Me.Panel16.Controls.Add(Me.Panel20)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(3, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1075, 406)
        Me.Panel16.TabIndex = 1
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OrderID, Me.CompName, Me.ColumnHeader11})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(10, 10)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1055, 386)
        Me.ListView2.TabIndex = 48
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'OrderID
        '
        Me.OrderID.Text = "Order #"
        Me.OrderID.Width = 100
        '
        'CompName
        '
        Me.CompName.Text = "Company Name"
        Me.CompName.Width = 250
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Status"
        Me.ColumnHeader11.Width = 250
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(10, 396)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1055, 10)
        Me.Panel17.TabIndex = 7
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(0, 10)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(10, 396)
        Me.Panel18.TabIndex = 8
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel19.Location = New System.Drawing.Point(1065, 10)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(10, 396)
        Me.Panel19.TabIndex = 9
        '
        'Panel20
        '
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(1075, 10)
        Me.Panel20.TabIndex = 6
        '
        'ReOrderUpdates
        '
        Me.ReOrderUpdates.Controls.Add(Me.Panel21)
        Me.ReOrderUpdates.Location = New System.Drawing.Point(4, 44)
        Me.ReOrderUpdates.Name = "ReOrderUpdates"
        Me.ReOrderUpdates.Padding = New System.Windows.Forms.Padding(3)
        Me.ReOrderUpdates.Size = New System.Drawing.Size(1081, 412)
        Me.ReOrderUpdates.TabIndex = 4
        Me.ReOrderUpdates.Text = "Re-Order Updates"
        Me.ReOrderUpdates.UseVisualStyleBackColor = True
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.ListView3)
        Me.Panel21.Controls.Add(Me.Panel22)
        Me.Panel21.Controls.Add(Me.Panel23)
        Me.Panel21.Controls.Add(Me.Panel24)
        Me.Panel21.Controls.Add(Me.Panel25)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(3, 3)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(1075, 406)
        Me.Panel21.TabIndex = 1
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
        Me.ListView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView3.ForeColor = System.Drawing.Color.Red
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(10, 10)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(1055, 386)
        Me.ListView3.TabIndex = 43
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Name"
        Me.ColumnHeader16.Width = 200
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Company Name"
        Me.ColumnHeader17.Width = 250
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Contact Number"
        Me.ColumnHeader18.Width = 250
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Email Address"
        Me.ColumnHeader19.Width = 250
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Ordered Date"
        Me.ColumnHeader20.Width = 200
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Status"
        Me.ColumnHeader21.Width = 200
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel22.Location = New System.Drawing.Point(10, 396)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1055, 10)
        Me.Panel22.TabIndex = 7
        '
        'Panel23
        '
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(0, 10)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(10, 396)
        Me.Panel23.TabIndex = 8
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel24.Location = New System.Drawing.Point(1065, 10)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(10, 396)
        Me.Panel24.TabIndex = 9
        '
        'Panel25
        '
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1075, 10)
        Me.Panel25.TabIndex = 6
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(10, 153)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1089, 10)
        Me.Panel9.TabIndex = 10
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Guna2Panel3)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Guna2Panel2)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Guna2Panel1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(10, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1089, 143)
        Me.Panel6.TabIndex = 9
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(698, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 143)
        Me.Panel8.TabIndex = 11
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.btnViewRental)
        Me.Guna2Panel2.Controls.Add(Me.lblNewRentals)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(354, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(344, 143)
        Me.Guna2Panel2.TabIndex = 10
        '
        'btnViewRental
        '
        Me.btnViewRental.BackColor = System.Drawing.Color.Transparent
        Me.btnViewRental.BorderRadius = 15
        Me.btnViewRental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewRental.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewRental.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewRental.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewRental.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewRental.FillColor = System.Drawing.Color.Empty
        Me.btnViewRental.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRental.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnViewRental.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewRental.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnViewRental.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnViewRental.Location = New System.Drawing.Point(196, 97)
        Me.btnViewRental.Name = "btnViewRental"
        Me.btnViewRental.Size = New System.Drawing.Size(130, 30)
        Me.btnViewRental.TabIndex = 12
        Me.btnViewRental.Text = "View Supplier"
        Me.btnViewRental.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblNewRentals
        '
        Me.lblNewRentals.AutoSize = True
        Me.lblNewRentals.BackColor = System.Drawing.Color.Transparent
        Me.lblNewRentals.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewRentals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblNewRentals.Location = New System.Drawing.Point(18, 49)
        Me.lblNewRentals.Name = "lblNewRentals"
        Me.lblNewRentals.Size = New System.Drawing.Size(29, 32)
        Me.lblNewRentals.TabIndex = 13
        Me.lblNewRentals.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total Suppliers"
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(344, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 143)
        Me.Panel7.TabIndex = 9
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.btnViewOrder)
        Me.Guna2Panel1.Controls.Add(Me.lblNewOrders)
        Me.Guna2Panel1.Controls.Add(Me.Label22)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(344, 143)
        Me.Guna2Panel1.TabIndex = 8
        '
        'btnViewOrder
        '
        Me.btnViewOrder.BackColor = System.Drawing.Color.Transparent
        Me.btnViewOrder.BorderRadius = 15
        Me.btnViewOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewOrder.FillColor = System.Drawing.Color.Empty
        Me.btnViewOrder.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnViewOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewOrder.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnViewOrder.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnViewOrder.Location = New System.Drawing.Point(183, 97)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.Size = New System.Drawing.Size(143, 30)
        Me.btnViewOrder.TabIndex = 13
        Me.btnViewOrder.Text = "View Customer"
        Me.btnViewOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblNewOrders
        '
        Me.lblNewOrders.AutoSize = True
        Me.lblNewOrders.BackColor = System.Drawing.Color.Transparent
        Me.lblNewOrders.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblNewOrders.Location = New System.Drawing.Point(16, 49)
        Me.lblNewOrders.Name = "lblNewOrders"
        Me.lblNewOrders.Size = New System.Drawing.Size(29, 32)
        Me.lblNewOrders.TabIndex = 12
        Me.lblNewOrders.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(18, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(156, 22)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "New Customers"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1099, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 613)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 613)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 623)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 10)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 10)
        Me.Panel1.TabIndex = 2
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel3.BorderRadius = 15
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.btnViewPayment)
        Me.Guna2Panel3.Controls.Add(Me.lblNewPayments)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(708, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(381, 143)
        Me.Guna2Panel3.TabIndex = 13
        '
        'btnViewPayment
        '
        Me.btnViewPayment.BackColor = System.Drawing.Color.Transparent
        Me.btnViewPayment.BorderRadius = 15
        Me.btnViewPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewPayment.FillColor = System.Drawing.Color.Empty
        Me.btnViewPayment.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnViewPayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewPayment.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnViewPayment.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnViewPayment.Location = New System.Drawing.Point(232, 97)
        Me.btnViewPayment.Name = "btnViewPayment"
        Me.btnViewPayment.Size = New System.Drawing.Size(135, 30)
        Me.btnViewPayment.TabIndex = 14
        Me.btnViewPayment.Text = "View Payment"
        Me.btnViewPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblNewPayments
        '
        Me.lblNewPayments.AutoSize = True
        Me.lblNewPayments.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPayments.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblNewPayments.Location = New System.Drawing.Point(21, 49)
        Me.lblNewPayments.Name = "lblNewPayments"
        Me.lblNewPayments.Size = New System.Drawing.Size(29, 32)
        Me.lblNewPayments.TabIndex = 100
        Me.lblNewPayments.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 22)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "New Payments"
        '
        'OverduePayments
        '
        Me.OverduePayments.Controls.Add(Me.Panel5)
        Me.OverduePayments.Location = New System.Drawing.Point(4, 44)
        Me.OverduePayments.Name = "OverduePayments"
        Me.OverduePayments.Padding = New System.Windows.Forms.Padding(3)
        Me.OverduePayments.Size = New System.Drawing.Size(1081, 412)
        Me.OverduePayments.TabIndex = 5
        Me.OverduePayments.Text = "Overdue Payments"
        Me.OverduePayments.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ListView1)
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Controls.Add(Me.Panel11)
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel13)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1075, 406)
        Me.Panel5.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(10, 10)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1055, 386)
        Me.ListView1.TabIndex = 48
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Order #"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Company Name"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.Width = 250
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(10, 396)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1055, 10)
        Me.Panel10.TabIndex = 7
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 10)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(10, 396)
        Me.Panel11.TabIndex = 8
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(1065, 10)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(10, 396)
        Me.Panel12.TabIndex = 9
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1075, 10)
        Me.Panel13.TabIndex = 6
        '
        'frmDashboardController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1109, 633)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboardController"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelBody.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.RambicOrderUpdates.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.ReOrderUpdates.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.OverduePayments.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelBody As Panel
    Friend WithEvents TabControl2 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents RambicOrderUpdates As TabPage
    Friend WithEvents Panel16 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents OrderID As ColumnHeader
    Friend WithEvents CompName As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents ReOrderUpdates As TabPage
    Friend WithEvents Panel21 As Panel
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnViewRental As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblNewRentals As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnViewOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblNewOrders As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnViewPayment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblNewPayments As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OverduePayments As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
End Class
