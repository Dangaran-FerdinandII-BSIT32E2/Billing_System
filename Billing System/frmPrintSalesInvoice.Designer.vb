<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintSalesInvoice
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnSend = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel18.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 12)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1151, 659)
        Me.ReportViewer1.TabIndex = 34
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.Panel6)
        Me.Panel18.Controls.Add(Me.Panel10)
        Me.Panel18.Controls.Add(Me.Panel7)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel18.Location = New System.Drawing.Point(13, 671)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1151, 78)
        Me.Panel18.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnSend)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 12)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(213, 54)
        Me.Panel6.TabIndex = 13
        '
        'btnSend
        '
        Me.btnSend.BorderRadius = 8
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSend.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSend.Location = New System.Drawing.Point(0, 0)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.PressedDepth = 20
        Me.btnSend.Size = New System.Drawing.Size(213, 54)
        Me.btnSend.TabIndex = 41
        Me.btnSend.Text = "Send"
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1151, 12)
        Me.Panel10.TabIndex = 13
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 66)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1151, 12)
        Me.Panel7.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(13, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1151, 12)
        Me.Panel4.TabIndex = 30
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 749)
        Me.Panel3.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1164, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 749)
        Me.Panel2.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 749)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1177, 12)
        Me.Panel1.TabIndex = 29
        '
        'frmPrintSalesInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 761)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPrintSalesInvoice"
        Me.Text = "frmPrintSalesInvoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel18.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
