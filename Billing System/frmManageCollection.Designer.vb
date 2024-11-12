<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageCollection
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
        Me.TabControl2 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.DeliveryDetails = New System.Windows.Forms.TabPage()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.btnView = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.cboFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Confirmation = New System.Windows.Forms.TabPage()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtFilter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabControl2.SuspendLayout()
        Me.DeliveryDetails.SuspendLayout()
        Me.panelBody.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Confirmation.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.DeliveryDetails)
        Me.TabControl2.Controls.Add(Me.Confirmation)
        Me.TabControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ItemSize = New System.Drawing.Size(200, 40)
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1371, 750)
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
        Me.TabControl2.TabIndex = 17
        Me.TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'DeliveryDetails
        '
        Me.DeliveryDetails.Controls.Add(Me.panelBody)
        Me.DeliveryDetails.Location = New System.Drawing.Point(4, 44)
        Me.DeliveryDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeliveryDetails.Name = "DeliveryDetails"
        Me.DeliveryDetails.Size = New System.Drawing.Size(1363, 702)
        Me.DeliveryDetails.TabIndex = 2
        Me.DeliveryDetails.Text = "Delivery Details"
        Me.DeliveryDetails.UseVisualStyleBackColor = True
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.ListView3)
        Me.panelBody.Controls.Add(Me.Panel25)
        Me.panelBody.Controls.Add(Me.Panel22)
        Me.panelBody.Controls.Add(Me.Panel16)
        Me.panelBody.Controls.Add(Me.Panel17)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 0)
        Me.panelBody.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1363, 702)
        Me.panelBody.TabIndex = 0
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView3.GridLines = True
        Me.ListView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView3.HideSelection = False
        Me.ListView3.HoverSelection = True
        Me.ListView3.Location = New System.Drawing.Point(13, 71)
        Me.ListView3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(1337, 556)
        Me.ListView3.TabIndex = 42
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date Ordered"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Due Date"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date Delivered"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 200
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.Panel26)
        Me.Panel25.Controls.Add(Me.Panel27)
        Me.Panel25.Controls.Add(Me.Panel28)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel25.Location = New System.Drawing.Point(13, 627)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1337, 75)
        Me.Panel25.TabIndex = 41
        '
        'Panel26
        '
        Me.Panel26.Controls.Add(Me.btnView)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel26.Location = New System.Drawing.Point(0, 12)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(160, 51)
        Me.Panel26.TabIndex = 13
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
        Me.btnView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnView.Name = "btnView"
        Me.btnView.PressedDepth = 20
        Me.btnView.Size = New System.Drawing.Size(160, 51)
        Me.btnView.TabIndex = 41
        Me.btnView.Text = "View"
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(0, 0)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(1337, 12)
        Me.Panel27.TabIndex = 13
        '
        'Panel28
        '
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel28.Location = New System.Drawing.Point(0, 63)
        Me.Panel28.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(1337, 12)
        Me.Panel28.TabIndex = 13
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.cboFilter)
        Me.Panel22.Controls.Add(Me.Panel23)
        Me.Panel22.Controls.Add(Me.Panel24)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(13, 0)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1337, 71)
        Me.Panel22.TabIndex = 30
        '
        'cboFilter
        '
        Me.cboFilter.BackColor = System.Drawing.Color.Transparent
        Me.cboFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.cboFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboFilter.ItemHeight = 30
        Me.cboFilter.Location = New System.Drawing.Point(0, 12)
        Me.cboFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(351, 36)
        Me.cboFilter.TabIndex = 21
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.White
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel23.Location = New System.Drawing.Point(0, 59)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(1337, 12)
        Me.Panel23.TabIndex = 20
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.White
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(1337, 12)
        Me.Panel24.TabIndex = 19
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(13, 702)
        Me.Panel16.TabIndex = 29
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel17.Location = New System.Drawing.Point(1350, 0)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(13, 702)
        Me.Panel17.TabIndex = 28
        '
        'Confirmation
        '
        Me.Confirmation.Controls.Add(Me.ListView2)
        Me.Confirmation.Controls.Add(Me.Panel11)
        Me.Confirmation.Controls.Add(Me.Panel9)
        Me.Confirmation.Controls.Add(Me.Panel4)
        Me.Confirmation.Controls.Add(Me.Panel5)
        Me.Confirmation.Location = New System.Drawing.Point(4, 44)
        Me.Confirmation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Confirmation.Name = "Confirmation"
        Me.Confirmation.Size = New System.Drawing.Size(1363, 702)
        Me.Confirmation.TabIndex = 1
        Me.Confirmation.Text = "Confirmation"
        Me.Confirmation.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader2})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.HoverSelection = True
        Me.ListView2.Location = New System.Drawing.Point(13, 71)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1337, 556)
        Me.ListView2.TabIndex = 40
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Invoice Number"
        Me.ColumnHeader8.Width = 180
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Company Name"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 250
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Total Amount"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Proof of Payment"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Employee"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Controls.Add(Me.Panel14)
        Me.Panel11.Controls.Add(Me.Panel15)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(13, 627)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1337, 75)
        Me.Panel11.TabIndex = 29
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.btnConfirm)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 12)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(160, 51)
        Me.Panel13.TabIndex = 13
        '
        'btnConfirm
        '
        Me.btnConfirm.BorderRadius = 8
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirm.FillColor = System.Drawing.Color.OrangeRed
        Me.btnConfirm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConfirm.Location = New System.Drawing.Point(0, 0)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.PressedDepth = 20
        Me.btnConfirm.Size = New System.Drawing.Size(160, 51)
        Me.btnConfirm.TabIndex = 41
        Me.btnConfirm.Text = "Confirm"
        '
        'Panel14
        '
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1337, 12)
        Me.Panel14.TabIndex = 13
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel15.Location = New System.Drawing.Point(0, 63)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1337, 12)
        Me.Panel15.TabIndex = 13
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtFilter)
        Me.Panel9.Controls.Add(Me.Panel12)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(13, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1337, 71)
        Me.Panel9.TabIndex = 28
        '
        'txtFilter
        '
        Me.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilter.DefaultText = ""
        Me.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilter.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtFilter.ForeColor = System.Drawing.Color.Black
        Me.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtFilter.Location = New System.Drawing.Point(0, 12)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilter.PlaceholderText = "Search by company name, invoice number"
        Me.txtFilter.SelectedText = ""
        Me.txtFilter.Size = New System.Drawing.Size(451, 47)
        Me.txtFilter.TabIndex = 47
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 59)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1337, 12)
        Me.Panel12.TabIndex = 20
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1337, 12)
        Me.Panel10.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(13, 702)
        Me.Panel4.TabIndex = 27
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1350, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(13, 702)
        Me.Panel5.TabIndex = 26
        '
        'frmManageCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 750)
        Me.Controls.Add(Me.TabControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmManageCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl2.ResumeLayout(False)
        Me.DeliveryDetails.ResumeLayout(False)
        Me.panelBody.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Confirmation.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl2 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Confirmation As TabPage
    Friend WithEvents DeliveryDetails As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtFilter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents panelBody As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents cboFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel28 As Panel
End Class
