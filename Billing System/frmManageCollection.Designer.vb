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
        Me.frmManageCollectionPanel = New System.Windows.Forms.Panel()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnShow = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearchCompany = New Guna.UI2.WinForms.Guna2TextBox()
        Me.frmManageCollectionPanel.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmManageCollectionPanel
        '
        Me.frmManageCollectionPanel.Controls.Add(Me.Guna2GroupBox2)
        Me.frmManageCollectionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmManageCollectionPanel.Location = New System.Drawing.Point(0, 0)
        Me.frmManageCollectionPanel.Name = "frmManageCollectionPanel"
        Me.frmManageCollectionPanel.Size = New System.Drawing.Size(1109, 633)
        Me.frmManageCollectionPanel.TabIndex = 0
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.ListView1)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel5)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel4)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel1)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel3)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel2)
        Me.Guna2GroupBox2.Controls.Add(Me.txtSearchCompany)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.BorderRadius = 5
        Me.Guna2GroupBox2.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1095, 620)
        Me.Guna2GroupBox2.TabIndex = 7
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(10, 60)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1075, 495)
        Me.ListView1.TabIndex = 34
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Company Name"
        Me.ColumnHeader8.Width = 300
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.btnShow)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(10, 555)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1075, 55)
        Me.Panel5.TabIndex = 35
        '
        'btnShow
        '
        Me.btnShow.BorderRadius = 8
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnShow.FillColor = System.Drawing.Color.MediumBlue
        Me.btnShow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnShow.Location = New System.Drawing.Point(6, 10)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.PressedDepth = 20
        Me.btnShow.Size = New System.Drawing.Size(149, 36)
        Me.btnShow.TabIndex = 40
        Me.btnShow.Text = "Show"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 610)
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
        Me.Panel1.Size = New System.Drawing.Size(10, 560)
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
        Me.Label2.Size = New System.Drawing.Size(103, 22)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Collection"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1085, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 570)
        Me.Panel2.TabIndex = 33
        '
        'txtSearchCompany
        '
        Me.txtSearchCompany.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchCompany.DefaultText = ""
        Me.txtSearchCompany.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchCompany.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchCompany.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchCompany.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchCompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchCompany.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearchCompany.ForeColor = System.Drawing.Color.Black
        Me.txtSearchCompany.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSearchCompany.Location = New System.Drawing.Point(774, 10)
        Me.txtSearchCompany.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchCompany.Name = "txtSearchCompany"
        Me.txtSearchCompany.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchCompany.PlaceholderText = "Search company name"
        Me.txtSearchCompany.SelectedText = ""
        Me.txtSearchCompany.Size = New System.Drawing.Size(314, 30)
        Me.txtSearchCompany.TabIndex = 12
        '
        'frmManageCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 633)
        Me.Controls.Add(Me.frmManageCollectionPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.frmManageCollectionPanel.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents frmManageCollectionPanel As Panel
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearchCompany As Guna.UI2.WinForms.Guna2TextBox
End Class
