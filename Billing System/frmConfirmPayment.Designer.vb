<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfirmPayment
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtBrowse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.txtBrowse)
        Me.Guna2Panel1.Controls.Add(Me.btnBrowse)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.btnConfirm)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(626, 277)
        Me.Guna2Panel1.TabIndex = 1
        '
        'txtBrowse
        '
        Me.txtBrowse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBrowse.DefaultText = ""
        Me.txtBrowse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBrowse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBrowse.Enabled = False
        Me.txtBrowse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBrowse.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtBrowse.ForeColor = System.Drawing.Color.Black
        Me.txtBrowse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBrowse.Location = New System.Drawing.Point(156, 135)
        Me.txtBrowse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBrowse.Name = "txtBrowse"
        Me.txtBrowse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBrowse.PlaceholderText = ""
        Me.txtBrowse.SelectedText = ""
        Me.txtBrowse.Size = New System.Drawing.Size(388, 30)
        Me.txtBrowse.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.BorderRadius = 8
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBrowse.FillColor = System.Drawing.Color.OrangeRed
        Me.btnBrowse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBrowse.Location = New System.Drawing.Point(36, 132)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.PressedDepth = 20
        Me.btnBrowse.Size = New System.Drawing.Size(109, 36)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(196, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 18)
        Me.Label3.TabIndex = 10000003
        Me.Label3.Text = "Upload picture to confirm payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(247, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 10000002
        Me.Label1.Text = "Upload Picture"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.btnExit)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(626, 50)
        Me.Guna2Panel2.TabIndex = 42
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BorderColor = System.Drawing.Color.Empty
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FillColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(573, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.PressedColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnExit.PressedDepth = 50
        Me.btnExit.Size = New System.Drawing.Size(53, 50)
        Me.btnExit.TabIndex = 10000001
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "x"
        Me.btnExit.TextOffset = New System.Drawing.Point(2, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 22)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Confirm Payment"
        '
        'btnConfirm
        '
        Me.btnConfirm.BorderRadius = 8
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirm.FillColor = System.Drawing.Color.OrangeRed
        Me.btnConfirm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConfirm.Location = New System.Drawing.Point(215, 209)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.PressedDepth = 20
        Me.btnConfirm.Size = New System.Drawing.Size(188, 36)
        Me.btnConfirm.TabIndex = 41
        Me.btnConfirm.Text = "Confirm"
        '
        'frmConfirmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 277)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfirmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBrowse As Guna.UI2.WinForms.Guna2TextBox
End Class
