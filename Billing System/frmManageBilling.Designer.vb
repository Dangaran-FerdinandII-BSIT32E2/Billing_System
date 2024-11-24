<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageBilling))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.InvoiceNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompanyNameSMS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.cboMenu = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.cboOptions = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.Panel60 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.btnShow = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.DueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FinalPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BillingID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompanyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DatePrinted = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Terms = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnView = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.cboFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnSearchCompanyName = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.txtCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.DateFilter2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateFilter1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel47 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.panelBody.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel14.SuspendLayout()
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
        Me.Panel2.Location = New System.Drawing.Point(0, 630)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1040, 10)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 620)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1030, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 620)
        Me.Panel4.TabIndex = 1
        '
        'InvoiceNo
        '
        Me.InvoiceNo.Text = "Invoice No."
        Me.InvoiceNo.Width = 200
        '
        'CompanyNameSMS
        '
        Me.CompanyNameSMS.Text = "Company Name"
        Me.CompanyNameSMS.Width = 350
        '
        'CustomerName
        '
        Me.CustomerName.Text = "Customer Name"
        Me.CustomerName.Width = 350
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(658, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 19)
        Me.Label7.TabIndex = 76
        '
        'Panel20
        '
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(992, 73)
        Me.Panel20.TabIndex = 10
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(992, 37)
        Me.Panel22.TabIndex = 7
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(992, 10)
        Me.Panel17.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(0, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 19)
        Me.Label9.TabIndex = 72
        '
        'Panel28
        '
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel28.Location = New System.Drawing.Point(115, 10)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(205, 27)
        Me.Panel28.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(320, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 19)
        Me.Label8.TabIndex = 74
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel21.Location = New System.Drawing.Point(453, 10)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(205, 27)
        Me.Panel21.TabIndex = 75
        '
        'cboMenu
        '
        Me.cboMenu.BackColor = System.Drawing.Color.Transparent
        Me.cboMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.cboMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMenu.FocusedColor = System.Drawing.Color.OrangeRed
        Me.cboMenu.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.cboMenu.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboMenu.ForeColor = System.Drawing.Color.Black
        Me.cboMenu.ItemHeight = 30
        Me.cboMenu.Location = New System.Drawing.Point(0, 37)
        Me.cboMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMenu.Name = "cboMenu"
        Me.cboMenu.Size = New System.Drawing.Size(278, 36)
        Me.cboMenu.TabIndex = 130
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel27.Location = New System.Drawing.Point(278, 37)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(42, 36)
        Me.Panel27.TabIndex = 131
        '
        'cboOptions
        '
        Me.cboOptions.BackColor = System.Drawing.Color.Transparent
        Me.cboOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.cboOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOptions.FocusedColor = System.Drawing.Color.OrangeRed
        Me.cboOptions.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.cboOptions.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboOptions.ForeColor = System.Drawing.Color.Black
        Me.cboOptions.ItemHeight = 30
        Me.cboOptions.Location = New System.Drawing.Point(320, 37)
        Me.cboOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cboOptions.Name = "cboOptions"
        Me.cboOptions.Size = New System.Drawing.Size(278, 36)
        Me.cboOptions.TabIndex = 132
        '
        'Panel44
        '
        Me.Panel44.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel44.Location = New System.Drawing.Point(598, 37)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(60, 36)
        Me.Panel44.TabIndex = 133
        '
        'Panel45
        '
        Me.Panel45.BackColor = System.Drawing.Color.White
        Me.Panel45.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel45.Location = New System.Drawing.Point(658, 37)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(276, 36)
        Me.Panel45.TabIndex = 134
        '
        'Panel60
        '
        Me.Panel60.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel60.Location = New System.Drawing.Point(0, 0)
        Me.Panel60.Name = "Panel60"
        Me.Panel60.Size = New System.Drawing.Size(276, 5)
        Me.Panel60.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(126, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 22)
        Me.Label10.TabIndex = 69
        '
        'Panel43
        '
        Me.Panel43.BackColor = System.Drawing.Color.White
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel43.Location = New System.Drawing.Point(0, 0)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(992, 10)
        Me.Panel43.TabIndex = 18
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.White
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel29.Location = New System.Drawing.Point(0, 50)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(992, 10)
        Me.Panel29.TabIndex = 18
        '
        'btnShow
        '
        Me.btnShow.BorderRadius = 8
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnShow.Enabled = False
        Me.btnShow.FillColor = System.Drawing.Color.OrangeRed
        Me.btnShow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.PressedDepth = 20
        Me.btnShow.Size = New System.Drawing.Size(140, 40)
        Me.btnShow.TabIndex = 57
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.White
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel19.Location = New System.Drawing.Point(0, 10)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(140, 40)
        Me.Panel19.TabIndex = 18
        '
        'DueDate
        '
        Me.DueDate.Text = "Due Date"
        Me.DueDate.Width = 200
        '
        'FinalPrice
        '
        Me.FinalPrice.Text = "Final Price"
        Me.FinalPrice.Width = 200
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.White
        Me.panelBody.Controls.Add(Me.Panel5)
        Me.panelBody.Controls.Add(Me.Panel9)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(10, 10)
        Me.panelBody.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1020, 620)
        Me.panelBody.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.ListView1)
        Me.Panel5.Controls.Add(Me.Panel18)
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel13)
        Me.Panel5.Controls.Add(Me.Panel32)
        Me.Panel5.Controls.Add(Me.Panel33)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 54)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1020, 566)
        Me.Panel5.TabIndex = 15
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BillingID, Me.CompanyName, Me.DatePrinted, Me.Terms})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(10, 93)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1000, 410)
        Me.ListView1.TabIndex = 38
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'BillingID
        '
        Me.BillingID.Text = "ID"
        Me.BillingID.Width = 100
        '
        'CompanyName
        '
        Me.CompanyName.Text = "Company Name"
        Me.CompanyName.Width = 350
        '
        'DatePrinted
        '
        Me.DatePrinted.Text = "Date Printed"
        Me.DatePrinted.Width = 250
        '
        'Terms
        '
        Me.Terms.Text = "Terms"
        Me.Terms.Width = 150
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.Panel6)
        Me.Panel18.Controls.Add(Me.Panel10)
        Me.Panel18.Controls.Add(Me.Panel7)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel18.Location = New System.Drawing.Point(10, 503)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1000, 63)
        Me.Panel18.TabIndex = 26
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnView)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 10)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(160, 43)
        Me.Panel6.TabIndex = 13
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
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.PressedDepth = 20
        Me.btnView.Size = New System.Drawing.Size(160, 43)
        Me.btnView.TabIndex = 41
        Me.btnView.Text = "View"
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1000, 10)
        Me.Panel10.TabIndex = 13
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 53)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1000, 10)
        Me.Panel7.TabIndex = 13
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(10, 83)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1000, 10)
        Me.Panel12.TabIndex = 25
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.cboFilter)
        Me.Panel13.Controls.Add(Me.Panel8)
        Me.Panel13.Controls.Add(Me.btnSearchCompanyName)
        Me.Panel13.Controls.Add(Me.Panel31)
        Me.Panel13.Controls.Add(Me.txtCompanyName)
        Me.Panel13.Controls.Add(Me.Panel30)
        Me.Panel13.Controls.Add(Me.Panel23)
        Me.Panel13.Controls.Add(Me.Panel26)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(10, 0)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1000, 83)
        Me.Panel13.TabIndex = 24
        '
        'cboFilter
        '
        Me.cboFilter.BackColor = System.Drawing.Color.Transparent
        Me.cboFilter.Dock = System.Windows.Forms.DockStyle.Right
        Me.cboFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.FocusedColor = System.Drawing.Color.OrangeRed
        Me.cboFilter.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.cboFilter.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboFilter.ForeColor = System.Drawing.Color.Black
        Me.cboFilter.HoverState.BorderColor = System.Drawing.Color.OrangeRed
        Me.cboFilter.ItemHeight = 30
        Me.cboFilter.Items.AddRange(New Object() {"Default", "Not Delivered", "Delivered"})
        Me.cboFilter.Location = New System.Drawing.Point(381, 45)
        Me.cboFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(250, 36)
        Me.cboFilter.StartIndex = 0
        Me.cboFilter.TabIndex = 50
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(631, 45)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(53, 38)
        Me.Panel8.TabIndex = 48
        '
        'btnSearchCompanyName
        '
        Me.btnSearchCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchCompanyName.BorderRadius = 8
        Me.btnSearchCompanyName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchCompanyName.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchCompanyName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchCompanyName.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchCompanyName.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSearchCompanyName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchCompanyName.ForeColor = System.Drawing.Color.White
        Me.btnSearchCompanyName.Image = CType(resources.GetObject("btnSearchCompanyName.Image"), System.Drawing.Image)
        Me.btnSearchCompanyName.Location = New System.Drawing.Point(684, 45)
        Me.btnSearchCompanyName.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchCompanyName.Name = "btnSearchCompanyName"
        Me.btnSearchCompanyName.PressedDepth = 20
        Me.btnSearchCompanyName.Size = New System.Drawing.Size(41, 38)
        Me.btnSearchCompanyName.TabIndex = 46
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.White
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel31.Location = New System.Drawing.Point(725, 45)
        Me.Panel31.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(10, 38)
        Me.Panel31.TabIndex = 21
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
        Me.txtCompanyName.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.txtCompanyName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCompanyName.Location = New System.Drawing.Point(735, 45)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompanyName.PlaceholderText = "Look for company name?"
        Me.txtCompanyName.SelectedText = ""
        Me.txtCompanyName.Size = New System.Drawing.Size(265, 38)
        Me.txtCompanyName.TabIndex = 47
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.White
        Me.Panel30.Controls.Add(Me.DateFilter2)
        Me.Panel30.Controls.Add(Me.Label3)
        Me.Panel30.Controls.Add(Me.DateFilter1)
        Me.Panel30.Controls.Add(Me.Panel47)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel30.Location = New System.Drawing.Point(0, 45)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(1000, 38)
        Me.Panel30.TabIndex = 21
        '
        'DateFilter2
        '
        Me.DateFilter2.CustomFormat = "yyyy-MM-dd"
        Me.DateFilter2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateFilter2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.DateFilter2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFilter2.Location = New System.Drawing.Point(183, 5)
        Me.DateFilter2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateFilter2.Name = "DateFilter2"
        Me.DateFilter2.Size = New System.Drawing.Size(167, 26)
        Me.DateFilter2.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(167, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 22)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "-"
        '
        'DateFilter1
        '
        Me.DateFilter1.CustomFormat = "yyyy-MM-dd"
        Me.DateFilter1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateFilter1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.DateFilter1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFilter1.Location = New System.Drawing.Point(0, 5)
        Me.DateFilter1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateFilter1.Name = "DateFilter1"
        Me.DateFilter1.Size = New System.Drawing.Size(167, 26)
        Me.DateFilter1.TabIndex = 1
        '
        'Panel47
        '
        Me.Panel47.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel47.Location = New System.Drawing.Point(0, 0)
        Me.Panel47.Name = "Panel47"
        Me.Panel47.Size = New System.Drawing.Size(1000, 5)
        Me.Panel47.TabIndex = 40
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.White
        Me.Panel23.Controls.Add(Me.Label1)
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Controls.Add(Me.Label4)
        Me.Panel23.Controls.Add(Me.Panel25)
        Me.Panel23.Controls.Add(Me.Label5)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(0, 12)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(1000, 33)
        Me.Panel23.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(378, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Filter"
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.White
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(86, 0)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(292, 33)
        Me.Panel24.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(661, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Search"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.White
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel25.Location = New System.Drawing.Point(724, 0)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(276, 33)
        Me.Panel25.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Date Filter"
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.White
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(1000, 12)
        Me.Panel26.TabIndex = 19
        '
        'Panel32
        '
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel32.Location = New System.Drawing.Point(0, 0)
        Me.Panel32.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(10, 566)
        Me.Panel32.TabIndex = 21
        '
        'Panel33
        '
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel33.Location = New System.Drawing.Point(1010, 0)
        Me.Panel33.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(10, 566)
        Me.Panel33.TabIndex = 20
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1020, 54)
        Me.Panel9.TabIndex = 5
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Label2)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.Panel11)
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(321, 54)
        Me.Panel14.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 22)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Billing Invoice"
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 14)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(13, 28)
        Me.Panel15.TabIndex = 13
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 42)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(321, 12)
        Me.Panel11.TabIndex = 13
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(321, 14)
        Me.Panel16.TabIndex = 13
        '
        'frmManageBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageBilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelBody.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel30.ResumeLayout(False)
        Me.Panel30.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBillingID As Label
    Friend WithEvents lblProdID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents InvoiceNo As ColumnHeader
    Friend WithEvents CompanyNameSMS As ColumnHeader
    Friend WithEvents CustomerName As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel21 As Panel
    Friend WithEvents cboMenu As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel27 As Panel
    Friend WithEvents cboOptions As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel44 As Panel
    Friend WithEvents Panel45 As Panel
    Friend WithEvents Panel60 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel43 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel19 As Panel
    Friend WithEvents DueDate As ColumnHeader
    Friend WithEvents FinalPrice As ColumnHeader
    Friend WithEvents panelBody As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btnSearchCompanyName As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel31 As Panel
    Friend WithEvents txtCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents BillingID As ColumnHeader
    Friend WithEvents DatePrinted As ColumnHeader
    Friend WithEvents Terms As ColumnHeader
    Friend WithEvents CompanyName As ColumnHeader
    Friend WithEvents cboFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents DateFilter2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateFilter1 As DateTimePicker
    Friend WithEvents Panel47 As Panel
End Class
