<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnterQuantity
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
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnMinus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnOkay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.txtQuantiyProducts = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRejection = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.lblHeaderTitle)
        Me.Guna2Panel1.Controls.Add(Me.btnExit)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(555, 53)
        Me.Guna2Panel1.TabIndex = 0
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(16, 11)
        Me.lblHeaderTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(161, 29)
        Me.lblHeaderTitle.TabIndex = 36
        Me.lblHeaderTitle.Text = "Restock Item"
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.CustomBorderColor = System.Drawing.Color.Black
        Me.btnExit.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 1, 0)
        Me.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FillColor = System.Drawing.Color.Transparent
        Me.btnExit.FocusedColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(502, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.PressedColor = System.Drawing.Color.White
        Me.btnExit.PressedDepth = 0
        Me.btnExit.Size = New System.Drawing.Size(53, 53)
        Me.btnExit.TabIndex = 35
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "X"
        Me.btnExit.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.txtRejection)
        Me.Guna2Panel2.Controls.Add(Me.btnMinus)
        Me.Guna2Panel2.Controls.Add(Me.btnAdd)
        Me.Guna2Panel2.Controls.Add(Me.btnOkay)
        Me.Guna2Panel2.Controls.Add(Me.btnCancel)
        Me.Guna2Panel2.Controls.Add(Me.txtQuantiyProducts)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(555, 223)
        Me.Guna2Panel2.TabIndex = 1
        '
        'btnMinus
        '
        Me.btnMinus.BorderRadius = 8
        Me.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMinus.FillColor = System.Drawing.Color.OrangeRed
        Me.btnMinus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMinus.ForeColor = System.Drawing.Color.White
        Me.btnMinus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMinus.Location = New System.Drawing.Point(187, 80)
        Me.btnMinus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.PressedDepth = 20
        Me.btnMinus.Size = New System.Drawing.Size(45, 39)
        Me.btnMinus.TabIndex = 63
        Me.btnMinus.TabStop = False
        Me.btnMinus.Text = "-"
        '
        'btnAdd
        '
        Me.btnAdd.BorderRadius = 8
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.OrangeRed
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdd.Location = New System.Drawing.Point(334, 80)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PressedDepth = 20
        Me.btnAdd.Size = New System.Drawing.Size(45, 39)
        Me.btnAdd.TabIndex = 62
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "+"
        '
        'btnOkay
        '
        Me.btnOkay.BorderRadius = 8
        Me.btnOkay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOkay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOkay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOkay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOkay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOkay.FillColor = System.Drawing.Color.OrangeRed
        Me.btnOkay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnOkay.ForeColor = System.Drawing.Color.White
        Me.btnOkay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOkay.Location = New System.Drawing.Point(21, 160)
        Me.btnOkay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.PressedDepth = 20
        Me.btnOkay.Size = New System.Drawing.Size(149, 48)
        Me.btnOkay.TabIndex = 61
        Me.btnOkay.TabStop = False
        Me.btnOkay.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 8
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.Location = New System.Drawing.Point(389, 160)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedDepth = 20
        Me.btnCancel.Size = New System.Drawing.Size(149, 48)
        Me.btnCancel.TabIndex = 60
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        '
        'txtQuantiyProducts
        '
        Me.txtQuantiyProducts.Cursor = System.Windows.Forms.Cursors.No
        Me.txtQuantiyProducts.DefaultText = ""
        Me.txtQuantiyProducts.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantiyProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantiyProducts.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.txtQuantiyProducts.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantiyProducts.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.txtQuantiyProducts.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtQuantiyProducts.ForeColor = System.Drawing.Color.Black
        Me.txtQuantiyProducts.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtQuantiyProducts.Location = New System.Drawing.Point(241, 80)
        Me.txtQuantiyProducts.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtQuantiyProducts.Name = "txtQuantiyProducts"
        Me.txtQuantiyProducts.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantiyProducts.PlaceholderText = "1"
        Me.txtQuantiyProducts.SelectedText = ""
        Me.txtQuantiyProducts.Size = New System.Drawing.Size(84, 39)
        Me.txtQuantiyProducts.TabIndex = 0
        Me.txtQuantiyProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Input Quantity"
        '
        'txtRejection
        '
        Me.txtRejection.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRejection.DefaultText = ""
        Me.txtRejection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRejection.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRejection.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.txtRejection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRejection.FocusedState.BorderColor = System.Drawing.Color.OrangeRed
        Me.txtRejection.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRejection.ForeColor = System.Drawing.Color.Black
        Me.txtRejection.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtRejection.Location = New System.Drawing.Point(21, 80)
        Me.txtRejection.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRejection.Name = "txtRejection"
        Me.txtRejection.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRejection.PlaceholderText = "Enter reason for rejection"
        Me.txtRejection.SelectedText = ""
        Me.txtRejection.Size = New System.Drawing.Size(517, 39)
        Me.txtRejection.TabIndex = 64
        Me.txtRejection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRejection.Visible = False
        '
        'frmEnterQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 276)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEnterQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRestockItem"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantiyProducts As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnOkay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtRejection As Guna.UI2.WinForms.Guna2TextBox
End Class
