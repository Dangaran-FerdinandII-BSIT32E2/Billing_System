<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageInquiry
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
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlListOfCustomerBody = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnShow = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.txtSearchCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlListOfCustomerBody.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Year Manufactured"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Manufacturer"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 220
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Name"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Category"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Selling Price"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 150
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
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Company Name"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 250
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Name"
        Me.ColumnHeader12.Width = 250
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader10})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(13, 74)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1426, 594)
        Me.ListView2.TabIndex = 35
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Date"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 200
        '
        'pnlListOfCustomerBody
        '
        Me.pnlListOfCustomerBody.BackColor = System.Drawing.Color.White
        Me.pnlListOfCustomerBody.Controls.Add(Me.ListView2)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel30)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel8)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel9)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel10)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel12)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel14)
        Me.pnlListOfCustomerBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlListOfCustomerBody.Location = New System.Drawing.Point(0, 0)
        Me.pnlListOfCustomerBody.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlListOfCustomerBody.Name = "pnlListOfCustomerBody"
        Me.pnlListOfCustomerBody.Size = New System.Drawing.Size(1452, 754)
        Me.pnlListOfCustomerBody.TabIndex = 15
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.White
        Me.Panel30.Controls.Add(Me.Panel3)
        Me.Panel30.Controls.Add(Me.Panel2)
        Me.Panel30.Controls.Add(Me.Panel34)
        Me.Panel30.Controls.Add(Me.Panel32)
        Me.Panel30.Controls.Add(Me.Panel31)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel30.Location = New System.Drawing.Point(13, 668)
        Me.Panel30.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(1426, 74)
        Me.Panel30.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnShow)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(200, 12)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(187, 50)
        Me.Panel3.TabIndex = 37
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
        Me.btnShow.FillColor = System.Drawing.Color.OrangeRed
        Me.btnShow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.PressedDepth = 20
        Me.btnShow.Size = New System.Drawing.Size(187, 50)
        Me.btnShow.TabIndex = 58
        Me.btnShow.Text = "Show"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(187, 12)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 50)
        Me.Panel2.TabIndex = 37
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.White
        Me.Panel34.Controls.Add(Me.btnConfirm)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel34.Location = New System.Drawing.Point(0, 12)
        Me.Panel34.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(187, 50)
        Me.Panel34.TabIndex = 18
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
        Me.btnConfirm.Size = New System.Drawing.Size(187, 50)
        Me.btnConfirm.TabIndex = 57
        Me.btnConfirm.Text = "Confirm"
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.White
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel32.Location = New System.Drawing.Point(0, 62)
        Me.Panel32.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(1426, 12)
        Me.Panel32.TabIndex = 18
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.White
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel31.Location = New System.Drawing.Point(0, 0)
        Me.Panel31.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(1426, 12)
        Me.Panel31.TabIndex = 18
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(13, 62)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1426, 12)
        Me.Panel8.TabIndex = 7
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 62)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(13, 680)
        Me.Panel9.TabIndex = 8
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 742)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1439, 12)
        Me.Panel10.TabIndex = 9
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(1439, 62)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(13, 692)
        Me.Panel12.TabIndex = 6
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.Panel23)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1452, 62)
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
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.Label2.Size = New System.Drawing.Size(159, 29)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Notifications"
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(0, 18)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(13, 32)
        Me.Panel16.TabIndex = 13
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 50)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(353, 12)
        Me.Panel17.TabIndex = 13
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(353, 18)
        Me.Panel22.TabIndex = 13
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.txtSearchCompanyName)
        Me.Panel23.Controls.Add(Me.Panel25)
        Me.Panel23.Controls.Add(Me.Panel26)
        Me.Panel23.Controls.Add(Me.Panel27)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel23.Location = New System.Drawing.Point(912, 0)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(540, 62)
        Me.Panel23.TabIndex = 10
        '
        'txtSearchCompanyName
        '
        Me.txtSearchCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchCompanyName.DefaultText = ""
        Me.txtSearchCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchCompanyName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtSearchCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchCompanyName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearchCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtSearchCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSearchCompanyName.Location = New System.Drawing.Point(108, 12)
        Me.txtSearchCompanyName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtSearchCompanyName.Name = "txtSearchCompanyName"
        Me.txtSearchCompanyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchCompanyName.PlaceholderText = "Search by company name"
        Me.txtSearchCompanyName.SelectedText = ""
        Me.txtSearchCompanyName.Size = New System.Drawing.Size(419, 38)
        Me.txtSearchCompanyName.TabIndex = 13
        '
        'Panel25
        '
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel25.Location = New System.Drawing.Point(527, 12)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(13, 38)
        Me.Panel25.TabIndex = 12
        '
        'Panel26
        '
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel26.Location = New System.Drawing.Point(0, 50)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(540, 12)
        Me.Panel26.TabIndex = 11
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(0, 0)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(540, 12)
        Me.Panel27.TabIndex = 10
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Model Number"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 345
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Purchase Price"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 180
        '
        'frmManageInquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1452, 754)
        Me.Controls.Add(Me.pnlListOfCustomerBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmManageInquiry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlListOfCustomerBody.ResumeLayout(False)
        Me.Panel30.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel34.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ListView2 As ListView
    Friend WithEvents pnlListOfCustomerBody As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents txtSearchCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2Button
End Class
