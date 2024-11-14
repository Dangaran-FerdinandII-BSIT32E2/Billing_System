<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendSMS
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.cboFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.DateFilter2 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateFilter1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel60 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel19.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(142, 128)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(383, 97)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 8
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Enabled = False
        Me.btnSave.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.Location = New System.Drawing.Point(162, 301)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PressedDepth = 20
        Me.btnSave.Size = New System.Drawing.Size(120, 41)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "Send"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 8
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Enabled = False
        Me.Guna2Button1.FillColor = System.Drawing.Color.OrangeRed
        Me.Guna2Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(373, 317)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedDepth = 20
        Me.Guna2Button1.Size = New System.Drawing.Size(120, 41)
        Me.Guna2Button1.TabIndex = 43
        Me.Guna2Button1.Text = "Cancel"
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.cboFilter)
        Me.Panel19.Controls.Add(Me.Panel27)
        Me.Panel19.Controls.Add(Me.Panel26)
        Me.Panel19.Controls.Add(Me.Panel11)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(800, 63)
        Me.Panel19.TabIndex = 44
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
        Me.cboFilter.Location = New System.Drawing.Point(375, 25)
        Me.cboFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(239, 36)
        Me.cboFilter.StartIndex = 0
        Me.cboFilter.TabIndex = 130
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel27.Location = New System.Drawing.Point(276, 25)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(99, 38)
        Me.Panel27.TabIndex = 70
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.White
        Me.Panel26.Controls.Add(Me.DateFilter2)
        Me.Panel26.Controls.Add(Me.Label10)
        Me.Panel26.Controls.Add(Me.DateFilter1)
        Me.Panel26.Controls.Add(Me.Panel60)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel26.Location = New System.Drawing.Point(0, 25)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(276, 38)
        Me.Panel26.TabIndex = 65
        '
        'DateFilter2
        '
        Me.DateFilter2.CustomFormat = "yyyy-MM-dd"
        Me.DateFilter2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateFilter2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.DateFilter2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFilter2.Location = New System.Drawing.Point(142, 5)
        Me.DateFilter2.Name = "DateFilter2"
        Me.DateFilter2.Size = New System.Drawing.Size(126, 26)
        Me.DateFilter2.TabIndex = 70
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
        Me.Label10.Text = "-"
        '
        'DateFilter1
        '
        Me.DateFilter1.CustomFormat = "yyyy-MM-dd"
        Me.DateFilter1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateFilter1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.DateFilter1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFilter1.Location = New System.Drawing.Point(0, 5)
        Me.DateFilter1.Name = "DateFilter1"
        Me.DateFilter1.Size = New System.Drawing.Size(126, 26)
        Me.DateFilter1.TabIndex = 68
        '
        'Panel60
        '
        Me.Panel60.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel60.Location = New System.Drawing.Point(0, 0)
        Me.Panel60.Name = "Panel60"
        Me.Panel60.Size = New System.Drawing.Size(276, 5)
        Me.Panel60.TabIndex = 67
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label1)
        Me.Panel11.Controls.Add(Me.Panel25)
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(800, 25)
        Me.Panel11.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(375, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Status Filter"
        '
        'Panel25
        '
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel25.Location = New System.Drawing.Point(86, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(289, 25)
        Me.Panel25.TabIndex = 69
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 19)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Date Filter"
        '
        'frmSendSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel19)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmSendSMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel19.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel19 As Panel
    Friend WithEvents cboFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents DateFilter2 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DateFilter1 As DateTimePicker
    Friend WithEvents Panel60 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Label13 As Label
End Class
