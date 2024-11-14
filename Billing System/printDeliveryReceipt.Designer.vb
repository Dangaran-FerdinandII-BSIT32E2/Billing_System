<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class printDeliveryReceipt
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.lblApprovedBy = New System.Windows.Forms.Label()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblIssuedBy = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTIN = New System.Windows.Forms.Label()
        Me.lblBusStyle = New System.Windows.Forms.Label()
        Me.lblREF = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblSoldTo = New System.Windows.Forms.Label()
        Me.lblIssuedTo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblIssuedTo)
        Me.Panel1.Controls.Add(Me.lblDate2)
        Me.Panel1.Controls.Add(Me.lblApprovedBy)
        Me.Panel1.Controls.Add(Me.lblBy)
        Me.Panel1.Controls.Add(Me.lblCustomer)
        Me.Panel1.Controls.Add(Me.lblIssuedBy)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.lblTIN)
        Me.Panel1.Controls.Add(Me.lblBusStyle)
        Me.Panel1.Controls.Add(Me.lblREF)
        Me.Panel1.Controls.Add(Me.lblDelivery)
        Me.Panel1.Controls.Add(Me.lblInvoiceNo)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblSoldTo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 749)
        Me.Panel1.TabIndex = 4
        '
        'lblDate2
        '
        Me.lblDate2.AutoSize = True
        Me.lblDate2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDate2.Location = New System.Drawing.Point(489, 646)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(33, 15)
        Me.lblDate2.TabIndex = 70
        Me.lblDate2.Text = "Date"
        '
        'lblApprovedBy
        '
        Me.lblApprovedBy.AutoSize = True
        Me.lblApprovedBy.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblApprovedBy.Location = New System.Drawing.Point(92, 646)
        Me.lblApprovedBy.Name = "lblApprovedBy"
        Me.lblApprovedBy.Size = New System.Drawing.Size(71, 15)
        Me.lblApprovedBy.TabIndex = 69
        Me.lblApprovedBy.Text = "ApprovedBy"
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblBy.Location = New System.Drawing.Point(489, 603)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(20, 15)
        Me.lblBy.TabIndex = 68
        Me.lblBy.Text = "By"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCustomer.Location = New System.Drawing.Point(489, 568)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(62, 15)
        Me.lblCustomer.TabIndex = 67
        Me.lblCustomer.Text = "Customer"
        '
        'lblIssuedBy
        '
        Me.lblIssuedBy.AutoSize = True
        Me.lblIssuedBy.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblIssuedBy.Location = New System.Drawing.Point(92, 568)
        Me.lblIssuedBy.Name = "lblIssuedBy"
        Me.lblIssuedBy.Size = New System.Drawing.Size(58, 15)
        Me.lblIssuedBy.TabIndex = 66
        Me.lblIssuedBy.Text = "IssuedBy"
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Quantity, Me.Unit, Me.Description})
        Me.ListView1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(52, 151)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(605, 379)
        Me.ListView1.TabIndex = 64
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 100
        '
        'Unit
        '
        Me.Unit.Text = "Unit"
        Me.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Unit.Width = 80
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Description.Width = 420
        '
        'lblTIN
        '
        Me.lblTIN.AutoSize = True
        Me.lblTIN.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTIN.Location = New System.Drawing.Point(526, 63)
        Me.lblTIN.Name = "lblTIN"
        Me.lblTIN.Size = New System.Drawing.Size(39, 15)
        Me.lblTIN.TabIndex = 63
        Me.lblTIN.Text = "lblTIN"
        '
        'lblBusStyle
        '
        Me.lblBusStyle.AutoSize = True
        Me.lblBusStyle.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblBusStyle.Location = New System.Drawing.Point(118, 63)
        Me.lblBusStyle.Name = "lblBusStyle"
        Me.lblBusStyle.Size = New System.Drawing.Size(68, 15)
        Me.lblBusStyle.TabIndex = 62
        Me.lblBusStyle.Text = "lblBusStyle"
        '
        'lblREF
        '
        Me.lblREF.AutoSize = True
        Me.lblREF.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblREF.Location = New System.Drawing.Point(526, 85)
        Me.lblREF.Name = "lblREF"
        Me.lblREF.Size = New System.Drawing.Size(44, 15)
        Me.lblREF.TabIndex = 61
        Me.lblREF.Text = "lblREF"
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDelivery.Location = New System.Drawing.Point(118, 83)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(63, 15)
        Me.lblDelivery.TabIndex = 58
        Me.lblDelivery.Text = "lblDelivery"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblInvoiceNo.Location = New System.Drawing.Point(526, 41)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(61, 15)
        Me.lblInvoiceNo.TabIndex = 57
        Me.lblInvoiceNo.Text = "InvoiceNo"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAddress.Location = New System.Drawing.Point(120, 41)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(66, 15)
        Me.lblAddress.TabIndex = 56
        Me.lblAddress.Text = "lblAddress"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDate.Location = New System.Drawing.Point(526, 22)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 15)
        Me.lblDate.TabIndex = 55
        Me.lblDate.Text = "lblDate"
        '
        'lblSoldTo
        '
        Me.lblSoldTo.AutoSize = True
        Me.lblSoldTo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblSoldTo.Location = New System.Drawing.Point(120, 22)
        Me.lblSoldTo.Name = "lblSoldTo"
        Me.lblSoldTo.Size = New System.Drawing.Size(58, 15)
        Me.lblSoldTo.TabIndex = 54
        Me.lblSoldTo.Text = "lblSoldTo"
        '
        'lblIssuedTo
        '
        Me.lblIssuedTo.AutoSize = True
        Me.lblIssuedTo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblIssuedTo.Location = New System.Drawing.Point(92, 603)
        Me.lblIssuedTo.Name = "lblIssuedTo"
        Me.lblIssuedTo.Size = New System.Drawing.Size(58, 15)
        Me.lblIssuedTo.TabIndex = 71
        Me.lblIssuedTo.Text = "IssuedTo"
        '
        'frmPrintBlankDeliveryReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPrintBlankDeliveryReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDate2 As Label
    Friend WithEvents lblApprovedBy As Label
    Friend WithEvents lblBy As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblIssuedBy As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Unit As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents lblTIN As Label
    Friend WithEvents lblBusStyle As Label
    Friend WithEvents lblREF As Label
    Friend WithEvents lblDelivery As Label
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblSoldTo As Label
    Friend WithEvents lblIssuedTo As Label
End Class
