<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListofCustomerOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListofCustomerOrder))
        Me.pnlListOfCustomerBody = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Availability = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.lblNotifQuatation = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnComment = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.btnCancelOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSendQuotation = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.btnUpdateOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.pnlListOfCustomerBody.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.lblNotifQuatation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlListOfCustomerBody
        '
        Me.pnlListOfCustomerBody.BackColor = System.Drawing.Color.White
        Me.pnlListOfCustomerBody.Controls.Add(Me.ListView1)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel8)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel9)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel12)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel14)
        Me.pnlListOfCustomerBody.Controls.Add(Me.Panel30)
        Me.pnlListOfCustomerBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlListOfCustomerBody.Location = New System.Drawing.Point(0, 0)
        Me.pnlListOfCustomerBody.Name = "pnlListOfCustomerBody"
        Me.pnlListOfCustomerBody.Size = New System.Drawing.Size(1028, 609)
        Me.pnlListOfCustomerBody.TabIndex = 15
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Unit, Me.Description, Me.Quantity, Me.Amount, Me.Availability, Me.Status})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(10, 79)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1008, 470)
        Me.ListView1.TabIndex = 44
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Unit
        '
        Me.Unit.Text = "Unit"
        Me.Unit.Width = 150
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 250
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 100
        '
        'Amount
        '
        Me.Amount.Text = "Amount"
        Me.Amount.Width = 200
        '
        'Availability
        '
        Me.Availability.Text = "Availability"
        Me.Availability.Width = 150
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 150
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(10, 69)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1008, 10)
        Me.Panel8.TabIndex = 7
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 69)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 480)
        Me.Panel9.TabIndex = 8
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(1018, 69)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(10, 480)
        Me.Panel12.TabIndex = 6
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel14.Controls.Add(Me.lblNotifQuatation)
        Me.Panel14.Controls.Add(Me.btnComment)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1028, 69)
        Me.Panel14.TabIndex = 0
        '
        'lblNotifQuatation
        '
        Me.lblNotifQuatation.BackColor = System.Drawing.Color.Transparent
        Me.lblNotifQuatation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNotifQuatation.FillColor = System.Drawing.Color.Red
        Me.lblNotifQuatation.ImageRotate = 0!
        Me.lblNotifQuatation.Location = New System.Drawing.Point(985, 13)
        Me.lblNotifQuatation.Name = "lblNotifQuatation"
        Me.lblNotifQuatation.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.lblNotifQuatation.Size = New System.Drawing.Size(18, 18)
        Me.lblNotifQuatation.TabIndex = 59
        Me.lblNotifQuatation.TabStop = False
        Me.lblNotifQuatation.UseTransparentBackground = True
        Me.lblNotifQuatation.Visible = False
        '
        'btnComment
        '
        Me.btnComment.BorderRadius = 8
        Me.btnComment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnComment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnComment.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnComment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnComment.ForeColor = System.Drawing.Color.White
        Me.btnComment.Image = CType(resources.GetObject("btnComment.Image"), System.Drawing.Image)
        Me.btnComment.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnComment.Location = New System.Drawing.Point(947, 11)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.PressedDepth = 20
        Me.btnComment.Size = New System.Drawing.Size(68, 47)
        Me.btnComment.TabIndex = 58
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Label1)
        Me.Panel15.Controls.Add(Me.Panel5)
        Me.Panel15.Controls.Add(Me.lblCompanyName)
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Controls.Add(Me.Panel17)
        Me.Panel15.Controls.Add(Me.Panel22)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(608, 69)
        Me.Panel15.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(161, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 22)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Order"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(161, 25)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(0, 34)
        Me.Panel5.TabIndex = 33
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCompanyName.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompanyName.ForeColor = System.Drawing.Color.White
        Me.lblCompanyName.Location = New System.Drawing.Point(10, 25)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(151, 22)
        Me.lblCompanyName.TabIndex = 32
        Me.lblCompanyName.Text = "CompanyName"
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(0, 25)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(10, 34)
        Me.Panel16.TabIndex = 13
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 59)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(608, 10)
        Me.Panel17.TabIndex = 13
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(608, 25)
        Me.Panel22.TabIndex = 13
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.White
        Me.Panel30.Controls.Add(Me.Panel4)
        Me.Panel30.Controls.Add(Me.Panel28)
        Me.Panel30.Controls.Add(Me.Panel3)
        Me.Panel30.Controls.Add(Me.Panel2)
        Me.Panel30.Controls.Add(Me.Panel1)
        Me.Panel30.Controls.Add(Me.Panel34)
        Me.Panel30.Controls.Add(Me.Panel33)
        Me.Panel30.Controls.Add(Me.Panel32)
        Me.Panel30.Controls.Add(Me.Panel31)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel30.Location = New System.Drawing.Point(0, 549)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(1028, 60)
        Me.Panel30.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(316, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 40)
        Me.Panel4.TabIndex = 62
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.White
        Me.Panel28.Controls.Add(Me.btnCancelOrder)
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel28.Location = New System.Drawing.Point(878, 10)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(140, 40)
        Me.Panel28.TabIndex = 60
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.BorderRadius = 8
        Me.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancelOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancelOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelOrder.FillColor = System.Drawing.Color.OrangeRed
        Me.btnCancelOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelOrder.ForeColor = System.Drawing.Color.White
        Me.btnCancelOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancelOrder.Location = New System.Drawing.Point(0, 0)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.PressedDepth = 20
        Me.btnCancelOrder.Size = New System.Drawing.Size(140, 40)
        Me.btnCancelOrder.TabIndex = 57
        Me.btnCancelOrder.Text = "Cancel Order"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1018, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 40)
        Me.Panel3.TabIndex = 61
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnSendQuotation)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(168, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(148, 40)
        Me.Panel2.TabIndex = 20
        '
        'btnSendQuotation
        '
        Me.btnSendQuotation.BorderRadius = 8
        Me.btnSendQuotation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendQuotation.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSendQuotation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSendQuotation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSendQuotation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSendQuotation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSendQuotation.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSendQuotation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSendQuotation.ForeColor = System.Drawing.Color.White
        Me.btnSendQuotation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSendQuotation.Location = New System.Drawing.Point(0, 0)
        Me.btnSendQuotation.Name = "btnSendQuotation"
        Me.btnSendQuotation.PressedDepth = 20
        Me.btnSendQuotation.Size = New System.Drawing.Size(148, 40)
        Me.btnSendQuotation.TabIndex = 57
        Me.btnSendQuotation.Text = "Send Quotation"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(158, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 40)
        Me.Panel1.TabIndex = 19
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.White
        Me.Panel34.Controls.Add(Me.btnUpdateOrder)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel34.Location = New System.Drawing.Point(10, 10)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(148, 40)
        Me.Panel34.TabIndex = 18
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.BorderRadius = 8
        Me.btnUpdateOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpdateOrder.FillColor = System.Drawing.Color.OrangeRed
        Me.btnUpdateOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateOrder.ForeColor = System.Drawing.Color.White
        Me.btnUpdateOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpdateOrder.Location = New System.Drawing.Point(0, 0)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.PressedDepth = 20
        Me.btnUpdateOrder.Size = New System.Drawing.Size(148, 40)
        Me.btnUpdateOrder.TabIndex = 57
        Me.btnUpdateOrder.Text = "Update Order"
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.White
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel33.Location = New System.Drawing.Point(0, 10)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(10, 40)
        Me.Panel33.TabIndex = 18
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.White
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel32.Location = New System.Drawing.Point(0, 50)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(1028, 10)
        Me.Panel32.TabIndex = 18
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.White
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel31.Location = New System.Drawing.Point(0, 0)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(1028, 10)
        Me.Panel31.TabIndex = 18
        '
        'frmListofCustomerOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.pnlListOfCustomerBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmListofCustomerOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlListOfCustomerBody.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.lblNotifQuatation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel30.ResumeLayout(False)
        Me.Panel28.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel34.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlListOfCustomerBody As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSendQuotation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents btnUpdateOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents btnCancelOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnComment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblNotifQuatation As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Unit As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Amount As ColumnHeader
    Friend WithEvents Availability As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
End Class
