<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSendPayment))
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSend = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelBody.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.White
        Me.panelBody.Controls.Add(Me.btnCancel)
        Me.panelBody.Controls.Add(Me.btnSend)
        Me.panelBody.Controls.Add(Me.Panel2)
        Me.panelBody.Controls.Add(Me.Label1)
        Me.panelBody.Controls.Add(Me.Panel1)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 0)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(624, 535)
        Me.panelBody.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 15
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.Location = New System.Drawing.Point(352, 458)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedDepth = 20
        Me.btnCancel.Size = New System.Drawing.Size(225, 40)
        Me.btnCancel.TabIndex = 10000007
        Me.btnCancel.Text = "Cancel"
        '
        'btnSend
        '
        Me.btnSend.BorderRadius = 15
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSend.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSend.Location = New System.Drawing.Point(61, 458)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.PressedDepth = 20
        Me.btnSend.Size = New System.Drawing.Size(225, 40)
        Me.btnSend.TabIndex = 10000006
        Me.btnSend.Text = "Send"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2Panel1)
        Me.Panel2.Location = New System.Drawing.Point(57, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(516, 310)
        Me.Panel2.TabIndex = 10000005
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2Panel1.BorderRadius = 8
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel1.BorderThickness = 3
        Me.Guna2Panel1.Controls.Add(Me.btnBrowse)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(516, 310)
        Me.Guna2Panel1.TabIndex = 10000004
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.BorderRadius = 15
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBrowse.FillColor = System.Drawing.Color.OrangeRed
        Me.btnBrowse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBrowse.Location = New System.Drawing.Point(211, 162)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.PressedDepth = 20
        Me.btnBrowse.ShadowDecoration.BorderRadius = 15
        Me.btnBrowse.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Size = New System.Drawing.Size(109, 36)
        Me.btnBrowse.TabIndex = 10000007
        Me.btnBrowse.Text = "Browse"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(221, 76)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10000011
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(5, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(505, 298)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(58, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 10000003
        Me.Label1.Text = "Upload Image"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 22)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Send Payment"
        '
        'frmSendPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 535)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmSendPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelBody As Panel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
