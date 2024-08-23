<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginV2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginV2))
        Me.pnl_frmLogin = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnCreateAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pnl_frmLogin.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_frmLogin
        '
        Me.pnl_frmLogin.BackColor = System.Drawing.Color.White
        Me.pnl_frmLogin.Controls.Add(Me.btnCreateAccount)
        Me.pnl_frmLogin.Controls.Add(Me.Label1)
        Me.pnl_frmLogin.Controls.Add(Me.Guna2Separator2)
        Me.pnl_frmLogin.Controls.Add(Me.Guna2Separator1)
        Me.pnl_frmLogin.Controls.Add(Me.btnLogin)
        Me.pnl_frmLogin.Controls.Add(Me.PictureBox3)
        Me.pnl_frmLogin.Controls.Add(Me.Guna2TextBox2)
        Me.pnl_frmLogin.Controls.Add(Me.Guna2TextBox1)
        Me.pnl_frmLogin.Controls.Add(Me.PictureBox2)
        Me.pnl_frmLogin.Controls.Add(Me.PictureBox1)
        Me.pnl_frmLogin.Controls.Add(Me.Panel2)
        Me.pnl_frmLogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_frmLogin.Location = New System.Drawing.Point(807, 0)
        Me.pnl_frmLogin.Name = "pnl_frmLogin"
        Me.pnl_frmLogin.Size = New System.Drawing.Size(559, 768)
        Me.pnl_frmLogin.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(559, 40)
        Me.Panel2.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FillColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExit.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(519, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 11
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "X"
        Me.btnExit.TextOffset = New System.Drawing.Point(1, 0)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(501, 267)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(30, 349)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(97, 358)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Enter your username"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(377, 43)
        Me.Guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(30, 442)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 67)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(97, 454)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = "Enter your password"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(377, 43)
        Me.Guna2TextBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox2.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.BorderRadius = 8
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(97, 572)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(377, 45)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log in"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(269, 631)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "OR"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(303, 634)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(165, 10)
        Me.Guna2Separator2.TabIndex = 15
        Me.Guna2Separator2.TabStop = False
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(98, 634)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(165, 10)
        Me.Guna2Separator1.TabIndex = 14
        Me.Guna2Separator1.TabStop = False
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.BorderRadius = 8
        Me.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreateAccount.FillColor = System.Drawing.Color.OrangeRed
        Me.btnCreateAccount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.White
        Me.btnCreateAccount.Location = New System.Drawing.Point(98, 661)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(377, 45)
        Me.btnCreateAccount.TabIndex = 3
        Me.btnCreateAccount.Text = "Create Account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(92, 718)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(658, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Blk. 62 Lot 2 General Bautista St., Soldier's Hill's, Putatan, Muntinlupa City, P" &
    "hilippines"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(47, 700)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(44, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'frmLoginV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.pnl_frmLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoginV2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnl_frmLogin.ResumeLayout(False)
        Me.pnl_frmLogin.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnl_frmLogin As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnCreateAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
