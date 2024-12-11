<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageOrder))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContactPerson = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CompanyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContactNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EmailAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OrderedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Stat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.cboFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel38 = New System.Windows.Forms.Panel()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.DateFilter2 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateFilter1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel60 = New System.Windows.Forms.Panel()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.btnAddWalkIn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.btnViewOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.btnCreateInvoice = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSearchOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtSearchOrder = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.panelBody.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel37.SuspendLayout()
        Me.Panel35.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(13, 809)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(13, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1453, 12)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1466, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 809)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 797)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1453, 12)
        Me.Panel4.TabIndex = 2
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.White
        Me.panelBody.Controls.Add(Me.ListView1)
        Me.panelBody.Controls.Add(Me.Panel39)
        Me.panelBody.Controls.Add(Me.Panel11)
        Me.panelBody.Controls.Add(Me.Panel21)
        Me.panelBody.Controls.Add(Me.Panel12)
        Me.panelBody.Controls.Add(Me.Panel13)
        Me.panelBody.Controls.Add(Me.Panel18)
        Me.panelBody.Controls.Add(Me.Panel9)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(13, 12)
        Me.panelBody.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1453, 785)
        Me.panelBody.TabIndex = 8
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ContactPerson, Me.CompanyName, Me.ContactNumber, Me.EmailAddress, Me.OrderedDate, Me.Stat})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 157)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1427, 554)
        Me.ListView1.TabIndex = 43
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Order No"
        Me.ColumnHeader1.Width = 100
        '
        'ContactPerson
        '
        Me.ContactPerson.Text = "Name"
        Me.ContactPerson.Width = 200
        '
        'CompanyName
        '
        Me.CompanyName.Text = "Company Name"
        Me.CompanyName.Width = 250
        '
        'ContactNumber
        '
        Me.ContactNumber.Text = "Contact Number"
        Me.ContactNumber.Width = 250
        '
        'EmailAddress
        '
        Me.EmailAddress.Text = "Email Address"
        Me.EmailAddress.Width = 250
        '
        'OrderedDate
        '
        Me.OrderedDate.Text = "Ordered Date"
        Me.OrderedDate.Width = 200
        '
        'Stat
        '
        Me.Stat.Text = "Status"
        Me.Stat.Width = 200
        '
        'Panel39
        '
        Me.Panel39.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel39.Location = New System.Drawing.Point(13, 145)
        Me.Panel39.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(1427, 12)
        Me.Panel39.TabIndex = 25
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.cboFilter)
        Me.Panel11.Controls.Add(Me.Panel38)
        Me.Panel11.Controls.Add(Me.Panel37)
        Me.Panel11.Controls.Add(Me.Panel35)
        Me.Panel11.Controls.Add(Me.Panel20)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(13, 74)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1427, 71)
        Me.Panel11.TabIndex = 24
        '
        'cboFilter
        '
        Me.cboFilter.BackColor = System.Drawing.Color.Transparent
        Me.cboFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.cboFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.FocusedColor = System.Drawing.Color.OrangeRed
        Me.cboFilter.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.cboFilter.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboFilter.ForeColor = System.Drawing.Color.Black
        Me.cboFilter.ItemHeight = 30
        Me.cboFilter.Items.AddRange(New Object() {"Default", "On Process", "On Hand", "Ready for Shipment", "Delivered", "Priority Orders", "Cancelled"})
        Me.cboFilter.Location = New System.Drawing.Point(500, 25)
        Me.cboFilter.Margin = New System.Windows.Forms.Padding(5)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(317, 36)
        Me.cboFilter.StartIndex = 0
        Me.cboFilter.TabIndex = 131
        '
        'Panel38
        '
        Me.Panel38.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel38.Location = New System.Drawing.Point(368, 25)
        Me.Panel38.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(132, 46)
        Me.Panel38.TabIndex = 71
        '
        'Panel37
        '
        Me.Panel37.BackColor = System.Drawing.Color.White
        Me.Panel37.Controls.Add(Me.DateFilter2)
        Me.Panel37.Controls.Add(Me.Label10)
        Me.Panel37.Controls.Add(Me.DateFilter1)
        Me.Panel37.Controls.Add(Me.Panel60)
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel37.Location = New System.Drawing.Point(0, 25)
        Me.Panel37.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(368, 46)
        Me.Panel37.TabIndex = 66
        '
        'DateFilter2
        '
        Me.DateFilter2.CustomFormat = "yyyy-MM-dd"
        Me.DateFilter2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateFilter2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.DateFilter2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFilter2.Location = New System.Drawing.Point(188, 6)
        Me.DateFilter2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateFilter2.Name = "DateFilter2"
        Me.DateFilter2.Size = New System.Drawing.Size(167, 30)
        Me.DateFilter2.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(167, 6)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 29)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "-"
        '
        'DateFilter1
        '
        Me.DateFilter1.CustomFormat = "yyyy-MM-dd"
        Me.DateFilter1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateFilter1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.DateFilter1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFilter1.Location = New System.Drawing.Point(0, 6)
        Me.DateFilter1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateFilter1.Name = "DateFilter1"
        Me.DateFilter1.Size = New System.Drawing.Size(167, 30)
        Me.DateFilter1.TabIndex = 68
        '
        'Panel60
        '
        Me.Panel60.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel60.Location = New System.Drawing.Point(0, 0)
        Me.Panel60.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel60.Name = "Panel60"
        Me.Panel60.Size = New System.Drawing.Size(368, 6)
        Me.Panel60.TabIndex = 67
        '
        'Panel35
        '
        Me.Panel35.Controls.Add(Me.Label5)
        Me.Panel35.Controls.Add(Me.Panel36)
        Me.Panel35.Controls.Add(Me.Label13)
        Me.Panel35.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel35.Location = New System.Drawing.Point(0, 0)
        Me.Panel35.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(1276, 25)
        Me.Panel35.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(492, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 24)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Status Filter"
        '
        'Panel36
        '
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel36.Location = New System.Drawing.Point(107, 0)
        Me.Panel36.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(385, 25)
        Me.Panel36.TabIndex = 71
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 24)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Date Filter"
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.Panel19)
        Me.Panel20.Controls.Add(Me.Panel32)
        Me.Panel20.Controls.Add(Me.Panel30)
        Me.Panel20.Controls.Add(Me.Panel27)
        Me.Panel20.Controls.Add(Me.Panel25)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel20.Location = New System.Drawing.Point(1276, 0)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(151, 71)
        Me.Panel20.TabIndex = 11
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.Label4)
        Me.Panel19.Controls.Add(Me.Panel33)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 48)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(151, 18)
        Me.Panel19.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Online Order"
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.Black
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel33.Location = New System.Drawing.Point(0, 0)
        Me.Panel33.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(33, 18)
        Me.Panel33.TabIndex = 9
        '
        'Panel32
        '
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel32.Location = New System.Drawing.Point(0, 42)
        Me.Panel32.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(151, 6)
        Me.Panel32.TabIndex = 13
        '
        'Panel30
        '
        Me.Panel30.Controls.Add(Me.Label1)
        Me.Panel30.Controls.Add(Me.Panel31)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel30.Location = New System.Drawing.Point(0, 24)
        Me.Panel30.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(151, 18)
        Me.Panel30.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(33, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Walk-In"
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.Blue
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel31.Location = New System.Drawing.Point(0, 0)
        Me.Panel31.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(33, 18)
        Me.Panel31.TabIndex = 9
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(0, 18)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(151, 6)
        Me.Panel27.TabIndex = 11
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.Label3)
        Me.Panel25.Controls.Add(Me.Panel26)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(151, 18)
        Me.Panel25.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(33, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Urgent"
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.Red
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(33, 18)
        Me.Panel26.TabIndex = 9
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.White
        Me.Panel21.Controls.Add(Me.Panel29)
        Me.Panel21.Controls.Add(Me.Guna2Panel2)
        Me.Panel21.Controls.Add(Me.Panel28)
        Me.Panel21.Controls.Add(Me.Panel22)
        Me.Panel21.Controls.Add(Me.Guna2Panel1)
        Me.Panel21.Controls.Add(Me.Panel34)
        Me.Panel21.Controls.Add(Me.Panel23)
        Me.Panel21.Controls.Add(Me.Panel24)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel21.Location = New System.Drawing.Point(13, 711)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(1427, 74)
        Me.Panel21.TabIndex = 23
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.White
        Me.Panel29.Controls.Add(Me.btnAddWalkIn)
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel29.Location = New System.Drawing.Point(400, 12)
        Me.Panel29.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(187, 50)
        Me.Panel29.TabIndex = 61
        '
        'btnAddWalkIn
        '
        Me.btnAddWalkIn.BorderRadius = 8
        Me.btnAddWalkIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddWalkIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddWalkIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddWalkIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddWalkIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddWalkIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddWalkIn.FillColor = System.Drawing.Color.OrangeRed
        Me.btnAddWalkIn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddWalkIn.ForeColor = System.Drawing.Color.White
        Me.btnAddWalkIn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAddWalkIn.Location = New System.Drawing.Point(0, 0)
        Me.btnAddWalkIn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddWalkIn.Name = "btnAddWalkIn"
        Me.btnAddWalkIn.PressedDepth = 20
        Me.btnAddWalkIn.Size = New System.Drawing.Size(187, 50)
        Me.btnAddWalkIn.TabIndex = 57
        Me.btnAddWalkIn.Text = "Add Walk-In"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(387, 12)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(13, 50)
        Me.Guna2Panel2.TabIndex = 60
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.White
        Me.Panel28.Controls.Add(Me.btnCancel)
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel28.Location = New System.Drawing.Point(1240, 12)
        Me.Panel28.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(187, 50)
        Me.Panel28.TabIndex = 59
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 8
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Enabled = False
        Me.btnCancel.FillColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.Location = New System.Drawing.Point(0, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedDepth = 20
        Me.btnCancel.Size = New System.Drawing.Size(187, 50)
        Me.btnCancel.TabIndex = 57
        Me.btnCancel.Text = "Cancel Order"
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.White
        Me.Panel22.Controls.Add(Me.btnViewOrder)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(200, 12)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(187, 50)
        Me.Panel22.TabIndex = 58
        '
        'btnViewOrder
        '
        Me.btnViewOrder.BorderRadius = 8
        Me.btnViewOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnViewOrder.Enabled = False
        Me.btnViewOrder.FillColor = System.Drawing.Color.OrangeRed
        Me.btnViewOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewOrder.ForeColor = System.Drawing.Color.White
        Me.btnViewOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewOrder.Location = New System.Drawing.Point(0, 0)
        Me.btnViewOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.PressedDepth = 20
        Me.btnViewOrder.Size = New System.Drawing.Size(187, 50)
        Me.btnViewOrder.TabIndex = 57
        Me.btnViewOrder.Text = "View Order"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(187, 12)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(13, 50)
        Me.Guna2Panel1.TabIndex = 43
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.White
        Me.Panel34.Controls.Add(Me.btnCreateInvoice)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel34.Location = New System.Drawing.Point(0, 12)
        Me.Panel34.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(187, 50)
        Me.Panel34.TabIndex = 18
        '
        'btnCreateInvoice
        '
        Me.btnCreateInvoice.BorderRadius = 8
        Me.btnCreateInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreateInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreateInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateInvoice.Enabled = False
        Me.btnCreateInvoice.FillColor = System.Drawing.Color.OrangeRed
        Me.btnCreateInvoice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCreateInvoice.ForeColor = System.Drawing.Color.White
        Me.btnCreateInvoice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCreateInvoice.Location = New System.Drawing.Point(0, 0)
        Me.btnCreateInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateInvoice.Name = "btnCreateInvoice"
        Me.btnCreateInvoice.PressedDepth = 20
        Me.btnCreateInvoice.Size = New System.Drawing.Size(187, 50)
        Me.btnCreateInvoice.TabIndex = 57
        Me.btnCreateInvoice.Text = "Create Invoice"
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.White
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel23.Location = New System.Drawing.Point(0, 62)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(1427, 12)
        Me.Panel23.TabIndex = 18
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.White
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(1427, 12)
        Me.Panel24.TabIndex = 18
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(13, 62)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1427, 12)
        Me.Panel12.TabIndex = 9
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel13.Location = New System.Drawing.Point(1440, 62)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(13, 723)
        Me.Panel13.TabIndex = 10
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(0, 62)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(13, 723)
        Me.Panel18.TabIndex = 8
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Panel5)
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1453, 62)
        Me.Panel9.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnSearchOrder)
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Controls.Add(Me.txtSearchOrder)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(816, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(637, 62)
        Me.Panel5.TabIndex = 2
        '
        'btnSearchOrder
        '
        Me.btnSearchOrder.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchOrder.BorderRadius = 8
        Me.btnSearchOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchOrder.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchOrder.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSearchOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchOrder.ForeColor = System.Drawing.Color.White
        Me.btnSearchOrder.Image = CType(resources.GetObject("btnSearchOrder.Image"), System.Drawing.Image)
        Me.btnSearchOrder.Location = New System.Drawing.Point(112, 12)
        Me.btnSearchOrder.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearchOrder.Name = "btnSearchOrder"
        Me.btnSearchOrder.PressedDepth = 20
        Me.btnSearchOrder.Size = New System.Drawing.Size(47, 38)
        Me.btnSearchOrder.TabIndex = 85
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
        'txtSearchOrder
        '
        Me.txtSearchOrder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchOrder.DefaultText = ""
        Me.txtSearchOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchOrder.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtSearchOrder.DisabledState.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearchOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchOrder.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtSearchOrder.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.txtSearchOrder.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearchOrder.ForeColor = System.Drawing.Color.Black
        Me.txtSearchOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSearchOrder.Location = New System.Drawing.Point(172, 12)
        Me.txtSearchOrder.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtSearchOrder.Name = "txtSearchOrder"
        Me.txtSearchOrder.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchOrder.PlaceholderText = "Search customer"
        Me.txtSearchOrder.SelectedText = ""
        Me.txtSearchOrder.Size = New System.Drawing.Size(452, 38)
        Me.txtSearchOrder.TabIndex = 46
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
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(624, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(13, 62)
        Me.Panel6.TabIndex = 2
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Label2)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.Panel17)
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(445, 62)
        Me.Panel14.TabIndex = 13
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
        Me.Label2.Size = New System.Drawing.Size(288, 29)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "List of Customer Orders"
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 18)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(13, 32)
        Me.Panel15.TabIndex = 13
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 50)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(445, 12)
        Me.Panel17.TabIndex = 13
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(445, 18)
        Me.Panel16.TabIndex = 13
        '
        'frmManageOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1479, 809)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmManageOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelBody.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel37.ResumeLayout(False)
        Me.Panel37.PerformLayout()
        Me.Panel35.ResumeLayout(False)
        Me.Panel35.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel30.ResumeLayout(False)
        Me.Panel30.PerformLayout()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel29.ResumeLayout(False)
        Me.Panel28.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel34.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelBody As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnSearchOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtSearchOrder As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents btnAddWalkIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel22 As Panel
    Friend WithEvents btnViewOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents btnCreateInvoice As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Panel36 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel37 As Panel
    Friend WithEvents DateFilter2 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DateFilter1 As DateTimePicker
    Friend WithEvents Panel60 As Panel
    Friend WithEvents Panel38 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel26 As Panel
    Friend WithEvents cboFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel39 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ContactPerson As ColumnHeader
    Friend WithEvents CompanyName As ColumnHeader
    Friend WithEvents ContactNumber As ColumnHeader
    Friend WithEvents EmailAddress As ColumnHeader
    Friend WithEvents OrderedDate As ColumnHeader
    Friend WithEvents Stat As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
