﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageBilling))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.btnView = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSearchCompanyName = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.txtCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.DateFilter2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateFilter1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.PanelBody.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 623)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1089, 10)
        Me.Panel4.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(10, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1089, 10)
        Me.Panel3.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1099, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 633)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 633)
        Me.Panel1.TabIndex = 4
        '
        'PanelBody
        '
        Me.PanelBody.BackColor = System.Drawing.Color.White
        Me.PanelBody.Controls.Add(Me.ListView1)
        Me.PanelBody.Controls.Add(Me.Panel18)
        Me.PanelBody.Controls.Add(Me.Panel11)
        Me.PanelBody.Controls.Add(Me.Panel5)
        Me.PanelBody.Controls.Add(Me.Panel6)
        Me.PanelBody.Controls.Add(Me.Panel7)
        Me.PanelBody.Controls.Add(Me.Panel8)
        Me.PanelBody.Controls.Add(Me.Panel9)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(10, 10)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(1089, 613)
        Me.PanelBody.TabIndex = 8
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(10, 133)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1069, 409)
        Me.ListView1.TabIndex = 38
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Invoice No."
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Company Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 350
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Payment"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Payment Completed"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 250
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.Panel20)
        Me.Panel18.Controls.Add(Me.Panel21)
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel18.Location = New System.Drawing.Point(10, 542)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1069, 61)
        Me.Panel18.TabIndex = 26
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.btnView)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel20.Location = New System.Drawing.Point(0, 10)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(120, 41)
        Me.Panel20.TabIndex = 13
        '
        'btnView
        '
        Me.btnView.BorderRadius = 8
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnView.FillColor = System.Drawing.Color.OrangeRed
        Me.btnView.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnView.Location = New System.Drawing.Point(0, 0)
        Me.btnView.Name = "btnView"
        Me.btnView.PressedDepth = 20
        Me.btnView.Size = New System.Drawing.Size(120, 41)
        Me.btnView.TabIndex = 41
        Me.btnView.Text = "View"
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(0, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(1069, 10)
        Me.Panel21.TabIndex = 13
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel19.Location = New System.Drawing.Point(0, 51)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1069, 10)
        Me.Panel19.TabIndex = 13
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(10, 123)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1069, 10)
        Me.Panel11.TabIndex = 25
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnSearchCompanyName)
        Me.Panel5.Controls.Add(Me.Panel31)
        Me.Panel5.Controls.Add(Me.txtCompanyName)
        Me.Panel5.Controls.Add(Me.Panel30)
        Me.Panel5.Controls.Add(Me.Panel27)
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(10, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1069, 73)
        Me.Panel5.TabIndex = 24
        '
        'btnSearchCompanyName
        '
        Me.btnSearchCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchCompanyName.BorderRadius = 8
        Me.btnSearchCompanyName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchCompanyName.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchCompanyName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchCompanyName.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchCompanyName.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSearchCompanyName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchCompanyName.ForeColor = System.Drawing.Color.White
        Me.btnSearchCompanyName.Image = CType(resources.GetObject("btnSearchCompanyName.Image"), System.Drawing.Image)
        Me.btnSearchCompanyName.Location = New System.Drawing.Point(670, 37)
        Me.btnSearchCompanyName.Name = "btnSearchCompanyName"
        Me.btnSearchCompanyName.PressedDepth = 20
        Me.btnSearchCompanyName.Size = New System.Drawing.Size(41, 36)
        Me.btnSearchCompanyName.TabIndex = 46
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.White
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel31.Location = New System.Drawing.Point(711, 37)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(10, 36)
        Me.Panel31.TabIndex = 21
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompanyName.DefaultText = ""
        Me.txtCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCompanyName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCompanyName.Location = New System.Drawing.Point(721, 37)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompanyName.PlaceholderText = "Search by company name"
        Me.txtCompanyName.SelectedText = ""
        Me.txtCompanyName.Size = New System.Drawing.Size(348, 36)
        Me.txtCompanyName.TabIndex = 47
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.White
        Me.Panel30.Controls.Add(Me.DateFilter2)
        Me.Panel30.Controls.Add(Me.Label3)
        Me.Panel30.Controls.Add(Me.DateFilter1)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel30.Location = New System.Drawing.Point(0, 37)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(295, 36)
        Me.Panel30.TabIndex = 21
        '
        'DateFilter2
        '
        Me.DateFilter2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateFilter2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.DateFilter2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFilter2.Location = New System.Drawing.Point(142, 0)
        Me.DateFilter2.Name = "DateFilter2"
        Me.DateFilter2.Size = New System.Drawing.Size(126, 26)
        Me.DateFilter2.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(126, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 22)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "-"
        '
        'DateFilter1
        '
        Me.DateFilter1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateFilter1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.DateFilter1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFilter1.Location = New System.Drawing.Point(0, 0)
        Me.DateFilter1.Name = "DateFilter1"
        Me.DateFilter1.Size = New System.Drawing.Size(126, 26)
        Me.DateFilter1.TabIndex = 1
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.White
        Me.Panel27.Controls.Add(Me.Label4)
        Me.Panel27.Controls.Add(Me.Panel29)
        Me.Panel27.Controls.Add(Me.Label1)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(0, 10)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(1069, 27)
        Me.Panel27.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(719, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 19)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Company Name"
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.White
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel29.Location = New System.Drawing.Point(850, 0)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(219, 27)
        Me.Panel29.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Date Filter"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1069, 10)
        Me.Panel10.TabIndex = 19
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 50)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 553)
        Me.Panel6.TabIndex = 21
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 603)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1079, 10)
        Me.Panel7.TabIndex = 22
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(1079, 50)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 563)
        Me.Panel8.TabIndex = 20
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1089, 50)
        Me.Panel9.TabIndex = 1
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Label2)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.Panel17)
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(265, 50)
        Me.Panel14.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 22)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Billing Invoice"
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 15)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(10, 25)
        Me.Panel15.TabIndex = 13
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 40)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(265, 10)
        Me.Panel17.TabIndex = 13
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(265, 15)
        Me.Panel16.TabIndex = 13
        '
        'frmManageBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 633)
        Me.Controls.Add(Me.PanelBody)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageBilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelBody.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel30.ResumeLayout(False)
        Me.Panel30.PerformLayout()
        Me.Panel27.ResumeLayout(False)
        Me.Panel27.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBillingID As Label
    Friend WithEvents lblProdID As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelBody As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnSearchCompanyName As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel31 As Panel
    Friend WithEvents txtCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel30 As Panel
    Friend WithEvents DateFilter2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateFilter1 As DateTimePicker
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
