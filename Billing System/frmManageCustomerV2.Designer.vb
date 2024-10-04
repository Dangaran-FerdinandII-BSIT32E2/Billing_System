Partial Class frmManageCustomerV2
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.MainBody = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.btnViewInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CompanyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContactPerson = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EmailAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PhoneNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.txtSearchCustomer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MainBody.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 767)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1387, 12)
        Me.Panel2.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1374, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(13, 755)
        Me.Panel1.TabIndex = 32
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(1348, 62)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(13, 693)
        Me.Panel12.TabIndex = 6
        '
        'MainBody
        '
        Me.MainBody.BackColor = System.Drawing.Color.White
        Me.MainBody.Controls.Add(Me.Panel30)
        Me.MainBody.Controls.Add(Me.Panel11)
        Me.MainBody.Controls.Add(Me.Panel8)
        Me.MainBody.Controls.Add(Me.Panel9)
        Me.MainBody.Controls.Add(Me.Panel10)
        Me.MainBody.Controls.Add(Me.Panel12)
        Me.MainBody.Controls.Add(Me.Panel14)
        Me.MainBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainBody.Location = New System.Drawing.Point(13, 12)
        Me.MainBody.Margin = New System.Windows.Forms.Padding(4)
        Me.MainBody.Name = "MainBody"
        Me.MainBody.Size = New System.Drawing.Size(1361, 755)
        Me.MainBody.TabIndex = 33
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.White
        Me.Panel30.Controls.Add(Me.Panel34)
        Me.Panel30.Controls.Add(Me.Panel33)
        Me.Panel30.Controls.Add(Me.Panel32)
        Me.Panel30.Controls.Add(Me.Panel31)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel30.Location = New System.Drawing.Point(13, 669)
        Me.Panel30.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(1335, 74)
        Me.Panel30.TabIndex = 19
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.White
        Me.Panel34.Controls.Add(Me.btnViewInfo)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel34.Location = New System.Drawing.Point(13, 12)
        Me.Panel34.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(187, 50)
        Me.Panel34.TabIndex = 18
        '
        'btnViewInfo
        '
        Me.btnViewInfo.BorderRadius = 8
        Me.btnViewInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnViewInfo.FillColor = System.Drawing.Color.OrangeRed
        Me.btnViewInfo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewInfo.ForeColor = System.Drawing.Color.White
        Me.btnViewInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewInfo.Location = New System.Drawing.Point(0, 0)
        Me.btnViewInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewInfo.Name = "btnViewInfo"
        Me.btnViewInfo.PressedDepth = 20
        Me.btnViewInfo.Size = New System.Drawing.Size(187, 50)
        Me.btnViewInfo.TabIndex = 57
        Me.btnViewInfo.Text = "View Info"
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.White
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel33.Location = New System.Drawing.Point(0, 12)
        Me.Panel33.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(13, 50)
        Me.Panel33.TabIndex = 18
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.White
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel32.Location = New System.Drawing.Point(0, 62)
        Me.Panel32.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(1335, 12)
        Me.Panel32.TabIndex = 18
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.White
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel31.Location = New System.Drawing.Point(0, 0)
        Me.Panel31.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(1335, 12)
        Me.Panel31.TabIndex = 18
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.ListView1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(13, 74)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1335, 669)
        Me.Panel11.TabIndex = 14
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CompanyName, Me.ContactPerson, Me.Address, Me.EmailAddress, Me.PhoneNumber})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1335, 669)
        Me.ListView1.TabIndex = 37
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CompanyName
        '
        Me.CompanyName.Text = "Company Name"
        Me.CompanyName.Width = 250
        '
        'ContactPerson
        '
        Me.ContactPerson.Text = "Contact Person"
        Me.ContactPerson.Width = 200
        '
        'Address
        '
        Me.Address.Text = "Address"
        Me.Address.Width = 400
        '
        'EmailAddress
        '
        Me.EmailAddress.Text = "Email Address"
        Me.EmailAddress.Width = 250
        '
        'PhoneNumber
        '
        Me.PhoneNumber.Text = "Phone Number"
        Me.PhoneNumber.Width = 200
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(13, 62)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1335, 12)
        Me.Panel8.TabIndex = 7
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 62)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(13, 681)
        Me.Panel9.TabIndex = 8
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 743)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1348, 12)
        Me.Panel10.TabIndex = 9
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.Panel23)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1361, 62)
        Me.Panel14.TabIndex = 0
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Label2)
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Controls.Add(Me.Panel17)
        Me.Panel15.Controls.Add(Me.Panel22)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(353, 62)
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
        Me.Label2.Size = New System.Drawing.Size(217, 29)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "List of Customers"
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
        Me.Panel17.Size = New System.Drawing.Size(353, 12)
        Me.Panel17.TabIndex = 13
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(353, 18)
        Me.Panel22.TabIndex = 13
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.txtSearchCustomer)
        Me.Panel23.Controls.Add(Me.Panel25)
        Me.Panel23.Controls.Add(Me.Panel26)
        Me.Panel23.Controls.Add(Me.Panel27)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel23.Location = New System.Drawing.Point(821, 0)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(540, 62)
        Me.Panel23.TabIndex = 10
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchCustomer.DefaultText = ""
        Me.txtSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchCustomer.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchCustomer.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearchCustomer.ForeColor = System.Drawing.Color.Black
        Me.txtSearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSearchCustomer.Location = New System.Drawing.Point(108, 12)
        Me.txtSearchCustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchCustomer.PlaceholderText = "Search by customer name or company name"
        Me.txtSearchCustomer.SelectedText = ""
        Me.txtSearchCustomer.Size = New System.Drawing.Size(419, 38)
        Me.txtSearchCustomer.TabIndex = 13
        '
        'Panel25
        '
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel25.Location = New System.Drawing.Point(527, 12)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(13, 38)
        Me.Panel25.TabIndex = 12
        '
        'Panel26
        '
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel26.Location = New System.Drawing.Point(0, 50)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(540, 12)
        Me.Panel26.TabIndex = 11
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(0, 0)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(540, 12)
        Me.Panel27.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 12)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 755)
        Me.Panel3.TabIndex = 31
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1387, 12)
        Me.Panel4.TabIndex = 29
        '
        'frmManageCustomerV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 779)
        Me.Controls.Add(Me.MainBody)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmManageCustomerV2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainBody.ResumeLayout(False)
        Me.Panel30.ResumeLayout(False)
        Me.Panel34.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents MainBody As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents btnViewInfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents CompanyName As ColumnHeader
    Friend WithEvents ContactPerson As ColumnHeader
    Friend WithEvents Address As ColumnHeader
    Friend WithEvents EmailAddress As ColumnHeader
    Friend WithEvents PhoneNumber As ColumnHeader
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents txtSearchCustomer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class