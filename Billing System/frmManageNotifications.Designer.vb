<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageNotifications
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
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl2 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Inquiry = New System.Windows.Forms.TabPage()
        Me.Orders = New System.Windows.Forms.TabPage()
        Me.Overdue = New System.Windows.Forms.TabPage()
        Me.Payment = New System.Windows.Forms.TabPage()
        Me.panelBody.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.SystemColors.Control
        Me.panelBody.Controls.Add(Me.TabControl2)
        Me.panelBody.Controls.Add(Me.Panel4)
        Me.panelBody.Controls.Add(Me.Panel3)
        Me.panelBody.Controls.Add(Me.Panel2)
        Me.panelBody.Controls.Add(Me.Panel1)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 0)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1028, 609)
        Me.panelBody.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 599)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1008, 10)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1018, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 599)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 599)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 10)
        Me.Panel1.TabIndex = 2
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.Inquiry)
        Me.TabControl2.Controls.Add(Me.Orders)
        Me.TabControl2.Controls.Add(Me.Overdue)
        Me.TabControl2.Controls.Add(Me.Payment)
        Me.TabControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ItemSize = New System.Drawing.Size(200, 40)
        Me.TabControl2.Location = New System.Drawing.Point(10, 10)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.ShowToolTips = True
        Me.TabControl2.Size = New System.Drawing.Size(1008, 589)
        Me.TabControl2.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabButtonHoverState.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TabControl2.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControl2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl2.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabButtonIdleState.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TabControl2.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabControl2.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl2.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.TabControl2.TabButtonSelectedState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.OrangeRed
        Me.TabControl2.TabButtonSize = New System.Drawing.Size(200, 40)
        Me.TabControl2.TabIndex = 18
        Me.TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Inquiry
        '
        Me.Inquiry.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inquiry.Location = New System.Drawing.Point(4, 44)
        Me.Inquiry.Name = "Inquiry"
        Me.Inquiry.Size = New System.Drawing.Size(1000, 541)
        Me.Inquiry.TabIndex = 2
        Me.Inquiry.Text = "Inquiry"
        Me.Inquiry.ToolTipText = "Notification for inquiry"
        Me.Inquiry.UseVisualStyleBackColor = True
        '
        'Orders
        '
        Me.Orders.Location = New System.Drawing.Point(4, 44)
        Me.Orders.Name = "Orders"
        Me.Orders.Size = New System.Drawing.Size(1000, 541)
        Me.Orders.TabIndex = 3
        Me.Orders.Text = "Orders"
        Me.Orders.ToolTipText = "Notification for orders"
        Me.Orders.UseVisualStyleBackColor = True
        '
        'Overdue
        '
        Me.Overdue.Location = New System.Drawing.Point(4, 44)
        Me.Overdue.Name = "Overdue"
        Me.Overdue.Size = New System.Drawing.Size(1000, 541)
        Me.Overdue.TabIndex = 4
        Me.Overdue.Text = "Overdue"
        Me.Overdue.ToolTipText = "Notification for overdue payments"
        Me.Overdue.UseVisualStyleBackColor = True
        '
        'Payment
        '
        Me.Payment.Location = New System.Drawing.Point(4, 44)
        Me.Payment.Name = "Payment"
        Me.Payment.Size = New System.Drawing.Size(1000, 541)
        Me.Payment.TabIndex = 5
        Me.Payment.Text = "Payment"
        Me.Payment.ToolTipText = "Notification for payments"
        Me.Payment.UseVisualStyleBackColor = True
        '
        'frmManageNotifications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmManageNotifications"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelBody.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelBody As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl2 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Inquiry As TabPage
    Friend WithEvents Orders As TabPage
    Friend WithEvents Overdue As TabPage
    Friend WithEvents Payment As TabPage
End Class
