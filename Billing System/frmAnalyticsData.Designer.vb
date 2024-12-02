<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnalyticsData
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TabControl2 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.OrderUpdates = New System.Windows.Forms.TabPage()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.OrderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.QuotationUpdates = New System.Windows.Forms.TabPage()
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
        Me.RambicPO = New System.Windows.Forms.TabPage()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnViewPayment = New Guna.UI2.WinForms.Guna2Button()
        Me.lblNewPayments = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnViewOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.lblNewOrders = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnViewCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.lblNewCustomers = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelGuider = New System.Windows.Forms.Panel()
        Me.ContactPerson = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompanyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContactNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EmailAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OrderedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Stat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OverduePayments = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.panelBody.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.OrderUpdates.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.QuotationUpdates.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.RambicPO.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.OverduePayments.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 623)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1099, 10)
        Me.Panel4.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 623)
        Me.Panel3.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 10)
        Me.Panel1.TabIndex = 6
        '
        'panelBody
        '
        Me.panelBody.AutoScroll = True
        Me.panelBody.Controls.Add(Me.Guna2GroupBox2)
        Me.panelBody.Controls.Add(Me.Panel31)
        Me.panelBody.Controls.Add(Me.Panel10)
        Me.panelBody.Controls.Add(Me.Panel9)
        Me.panelBody.Controls.Add(Me.Panel6)
        Me.panelBody.Controls.Add(Me.Panel2)
        Me.panelBody.Controls.Add(Me.panelGuider)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(10, 10)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1099, 613)
        Me.panelBody.TabIndex = 10
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.Chart1)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel5)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel32)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel33)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel34)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.Guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(0, 532)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.BorderRadius = 0
        Me.Guna2GroupBox2.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1072, 449)
        Me.Guna2GroupBox2.TabIndex = 15
        '
        'Chart1
        '
        Me.Chart1.BorderlineWidth = 5
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.Red
        ChartArea1.AxisX.Title = "Months"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        ChartArea1.AxisY.Title = "Revenue"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(10, 60)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.OrangeRed}
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.Name = "Sales"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1052, 379)
        Me.Chart1.TabIndex = 34
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(10, 439)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1052, 10)
        Me.Panel5.TabIndex = 33
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.White
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel32.Location = New System.Drawing.Point(0, 60)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(10, 389)
        Me.Panel32.TabIndex = 32
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.White
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel33.Location = New System.Drawing.Point(0, 50)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(1062, 10)
        Me.Panel33.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 19)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Preview 6 months"
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.White
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel34.Location = New System.Drawing.Point(1062, 50)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(10, 399)
        Me.Panel34.TabIndex = 33
        '
        'Panel31
        '
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel31.Location = New System.Drawing.Point(0, 522)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(1072, 10)
        Me.Panel31.TabIndex = 10
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.TabControl2)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 153)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1072, 369)
        Me.Panel10.TabIndex = 9
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.OverduePayments)
        Me.TabControl2.Controls.Add(Me.OrderUpdates)
        Me.TabControl2.Controls.Add(Me.QuotationUpdates)
        Me.TabControl2.Controls.Add(Me.RambicPO)
        Me.TabControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ItemSize = New System.Drawing.Size(266, 40)
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.ShowToolTips = True
        Me.TabControl2.Size = New System.Drawing.Size(1072, 369)
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
        Me.TabControl2.TabButtonSize = New System.Drawing.Size(266, 40)
        Me.TabControl2.TabIndex = 21
        Me.TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'OrderUpdates
        '
        Me.OrderUpdates.Controls.Add(Me.Panel16)
        Me.OrderUpdates.Location = New System.Drawing.Point(4, 44)
        Me.OrderUpdates.Name = "OrderUpdates"
        Me.OrderUpdates.Padding = New System.Windows.Forms.Padding(3)
        Me.OrderUpdates.Size = New System.Drawing.Size(1064, 321)
        Me.OrderUpdates.TabIndex = 3
        Me.OrderUpdates.Text = "Order Updates"
        Me.OrderUpdates.UseVisualStyleBackColor = True
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
        Me.Panel16.Size = New System.Drawing.Size(1058, 315)
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
        Me.ListView2.Size = New System.Drawing.Size(1038, 295)
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
        Me.Panel17.Location = New System.Drawing.Point(10, 305)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1038, 10)
        Me.Panel17.TabIndex = 7
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(0, 10)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(10, 305)
        Me.Panel18.TabIndex = 8
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel19.Location = New System.Drawing.Point(1048, 10)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(10, 305)
        Me.Panel19.TabIndex = 9
        '
        'Panel20
        '
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(1058, 10)
        Me.Panel20.TabIndex = 6
        '
        'QuotationUpdates
        '
        Me.QuotationUpdates.Controls.Add(Me.Panel21)
        Me.QuotationUpdates.Location = New System.Drawing.Point(4, 44)
        Me.QuotationUpdates.Name = "QuotationUpdates"
        Me.QuotationUpdates.Padding = New System.Windows.Forms.Padding(3)
        Me.QuotationUpdates.Size = New System.Drawing.Size(1064, 321)
        Me.QuotationUpdates.TabIndex = 4
        Me.QuotationUpdates.Text = "Quotation Updates"
        Me.QuotationUpdates.UseVisualStyleBackColor = True
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
        Me.Panel21.Size = New System.Drawing.Size(1058, 315)
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
        Me.ListView3.Size = New System.Drawing.Size(1038, 295)
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
        Me.Panel22.Location = New System.Drawing.Point(10, 305)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1038, 10)
        Me.Panel22.TabIndex = 7
        '
        'Panel23
        '
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(0, 10)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(10, 305)
        Me.Panel23.TabIndex = 8
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel24.Location = New System.Drawing.Point(1048, 10)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(10, 305)
        Me.Panel24.TabIndex = 9
        '
        'Panel25
        '
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1058, 10)
        Me.Panel25.TabIndex = 6
        '
        'RambicPO
        '
        Me.RambicPO.Controls.Add(Me.Panel26)
        Me.RambicPO.Location = New System.Drawing.Point(4, 44)
        Me.RambicPO.Name = "RambicPO"
        Me.RambicPO.Padding = New System.Windows.Forms.Padding(3)
        Me.RambicPO.Size = New System.Drawing.Size(1064, 321)
        Me.RambicPO.TabIndex = 5
        Me.RambicPO.Text = "Rambic P.O."
        Me.RambicPO.UseVisualStyleBackColor = True
        '
        'Panel26
        '
        Me.Panel26.Controls.Add(Me.ListView4)
        Me.Panel26.Controls.Add(Me.Panel27)
        Me.Panel26.Controls.Add(Me.Panel28)
        Me.Panel26.Controls.Add(Me.Panel29)
        Me.Panel26.Controls.Add(Me.Panel30)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel26.Location = New System.Drawing.Point(3, 3)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(1058, 315)
        Me.Panel26.TabIndex = 1
        '
        'ListView4
        '
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27})
        Me.ListView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView4.ForeColor = System.Drawing.Color.Red
        Me.ListView4.FullRowSelect = True
        Me.ListView4.GridLines = True
        Me.ListView4.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView4.HideSelection = False
        Me.ListView4.Location = New System.Drawing.Point(10, 10)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(1038, 295)
        Me.ListView4.TabIndex = 43
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Name"
        Me.ColumnHeader22.Width = 200
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Company Name"
        Me.ColumnHeader23.Width = 250
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Contact Number"
        Me.ColumnHeader24.Width = 250
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Email Address"
        Me.ColumnHeader25.Width = 250
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Ordered Date"
        Me.ColumnHeader26.Width = 200
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Status"
        Me.ColumnHeader27.Width = 200
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel27.Location = New System.Drawing.Point(10, 305)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(1038, 10)
        Me.Panel27.TabIndex = 7
        '
        'Panel28
        '
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel28.Location = New System.Drawing.Point(0, 10)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(10, 305)
        Me.Panel28.TabIndex = 8
        '
        'Panel29
        '
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel29.Location = New System.Drawing.Point(1048, 10)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(10, 305)
        Me.Panel29.TabIndex = 9
        '
        'Panel30
        '
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel30.Location = New System.Drawing.Point(0, 0)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(1058, 10)
        Me.Panel30.TabIndex = 6
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 143)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1072, 10)
        Me.Panel9.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Guna2Panel3)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Guna2Panel2)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Guna2Panel1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1072, 143)
        Me.Panel6.TabIndex = 7
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
        Me.Guna2Panel3.Size = New System.Drawing.Size(364, 143)
        Me.Guna2Panel3.TabIndex = 12
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
        Me.btnViewPayment.Location = New System.Drawing.Point(215, 97)
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
        Me.Guna2Panel2.Controls.Add(Me.btnViewOrder)
        Me.Guna2Panel2.Controls.Add(Me.lblNewOrders)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(354, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(344, 143)
        Me.Guna2Panel2.TabIndex = 10
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
        Me.btnViewOrder.Location = New System.Drawing.Point(217, 97)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.Size = New System.Drawing.Size(110, 30)
        Me.btnViewOrder.TabIndex = 13
        Me.btnViewOrder.Text = "View Order"
        Me.btnViewOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblNewOrders
        '
        Me.lblNewOrders.AutoSize = True
        Me.lblNewOrders.BackColor = System.Drawing.Color.Transparent
        Me.lblNewOrders.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblNewOrders.Location = New System.Drawing.Point(18, 49)
        Me.lblNewOrders.Name = "lblNewOrders"
        Me.lblNewOrders.Size = New System.Drawing.Size(29, 32)
        Me.lblNewOrders.TabIndex = 13
        Me.lblNewOrders.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "New Orders"
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
        Me.Guna2Panel1.Controls.Add(Me.btnViewCustomer)
        Me.Guna2Panel1.Controls.Add(Me.lblNewCustomers)
        Me.Guna2Panel1.Controls.Add(Me.Label22)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(344, 143)
        Me.Guna2Panel1.TabIndex = 8
        '
        'btnViewCustomer
        '
        Me.btnViewCustomer.BackColor = System.Drawing.Color.Transparent
        Me.btnViewCustomer.BorderRadius = 15
        Me.btnViewCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewCustomer.FillColor = System.Drawing.Color.Empty
        Me.btnViewCustomer.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnViewCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewCustomer.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnViewCustomer.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnViewCustomer.Location = New System.Drawing.Point(182, 97)
        Me.btnViewCustomer.Name = "btnViewCustomer"
        Me.btnViewCustomer.Size = New System.Drawing.Size(143, 30)
        Me.btnViewCustomer.TabIndex = 12
        Me.btnViewCustomer.Text = "View Customer"
        Me.btnViewCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblNewCustomers
        '
        Me.lblNewCustomers.AutoSize = True
        Me.lblNewCustomers.BackColor = System.Drawing.Color.Transparent
        Me.lblNewCustomers.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblNewCustomers.Location = New System.Drawing.Point(16, 49)
        Me.lblNewCustomers.Name = "lblNewCustomers"
        Me.lblNewCustomers.Size = New System.Drawing.Size(29, 32)
        Me.lblNewCustomers.TabIndex = 12
        Me.lblNewCustomers.Text = "0"
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
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1072, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 981)
        Me.Panel2.TabIndex = 6
        '
        'panelGuider
        '
        Me.panelGuider.Location = New System.Drawing.Point(17, 623)
        Me.panelGuider.Name = "panelGuider"
        Me.panelGuider.Size = New System.Drawing.Size(10, 358)
        Me.panelGuider.TabIndex = 0
        '
        'ContactPerson
        '
        Me.ContactPerson.DisplayIndex = 0
        Me.ContactPerson.Text = "Name"
        Me.ContactPerson.Width = 200
        '
        'CompanyName
        '
        Me.CompanyName.DisplayIndex = 1
        Me.CompanyName.Text = "Company Name"
        Me.CompanyName.Width = 250
        '
        'ContactNumber
        '
        Me.ContactNumber.DisplayIndex = 2
        Me.ContactNumber.Text = "Contact Number"
        Me.ContactNumber.Width = 250
        '
        'EmailAddress
        '
        Me.EmailAddress.DisplayIndex = 3
        Me.EmailAddress.Text = "Email Address"
        Me.EmailAddress.Width = 250
        '
        'OrderedDate
        '
        Me.OrderedDate.DisplayIndex = 4
        Me.OrderedDate.Text = "Ordered Date"
        Me.OrderedDate.Width = 200
        '
        'Stat
        '
        Me.Stat.DisplayIndex = 5
        Me.Stat.Text = "Status"
        Me.Stat.Width = 200
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.DisplayIndex = 0
        Me.ColumnHeader12.Text = "Order #"
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.DisplayIndex = 1
        Me.ColumnHeader13.Text = "CompanyName"
        Me.ColumnHeader13.Width = 250
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.DisplayIndex = 2
        Me.ColumnHeader14.Text = "Date Paid"
        Me.ColumnHeader14.Width = 250
        '
        'OverduePayments
        '
        Me.OverduePayments.Controls.Add(Me.Panel11)
        Me.OverduePayments.Location = New System.Drawing.Point(4, 44)
        Me.OverduePayments.Name = "OverduePayments"
        Me.OverduePayments.Padding = New System.Windows.Forms.Padding(3)
        Me.OverduePayments.Size = New System.Drawing.Size(1064, 321)
        Me.OverduePayments.TabIndex = 6
        Me.OverduePayments.Text = "Overdue Payments"
        Me.OverduePayments.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.ListView1)
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Controls.Add(Me.Panel14)
        Me.Panel11.Controls.Add(Me.Panel15)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(3, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1058, 315)
        Me.Panel11.TabIndex = 2
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
        Me.ListView1.Size = New System.Drawing.Size(1038, 295)
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
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(10, 305)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1038, 10)
        Me.Panel12.TabIndex = 7
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 10)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(10, 305)
        Me.Panel13.TabIndex = 8
        '
        'Panel14
        '
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(1048, 10)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(10, 305)
        Me.Panel14.TabIndex = 9
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1058, 10)
        Me.Panel15.TabIndex = 6
        '
        'frmAnalyticsData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1109, 633)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAnalyticsData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelBody.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.OrderUpdates.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.QuotationUpdates.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.RambicPO.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.OverduePayments.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelBody As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblNewCustomers As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblNewOrders As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNewPayments As Label
    Friend WithEvents btnViewCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewPayment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents ContactPerson As ColumnHeader
    Friend WithEvents CompanyName As ColumnHeader
    Friend WithEvents ContactNumber As ColumnHeader
    Friend WithEvents EmailAddress As ColumnHeader
    Friend WithEvents OrderedDate As ColumnHeader
    Friend WithEvents Stat As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TabControl2 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents OrderUpdates As TabPage
    Friend WithEvents QuotationUpdates As TabPage
    Friend WithEvents RambicPO As TabPage
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
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
    Friend WithEvents Panel26 As Panel
    Friend WithEvents ListView4 As ListView
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents ColumnHeader26 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents OrderID As ColumnHeader
    Friend WithEvents CompName As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Panel31 As Panel
    Friend WithEvents panelGuider As Panel
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel34 As Panel
    Friend WithEvents OverduePayments As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
End Class
