<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrintBillingStatement
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSoldTo = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPONo = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblSalesman = New System.Windows.Forms.Label()
        Me.lblTIN = New System.Windows.Forms.Label()
        Me.lblBusStyle = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.lblDRNo = New System.Windows.Forms.Label()
        Me.lblBilledCheckby = New System.Windows.Forms.Label()
        Me.lblCreditApprovedBy = New System.Windows.Forms.Label()
        Me.lblCustomerSignature = New System.Windows.Forms.Label()
        Me.lblCEO = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblCEO)
        Me.Panel1.Controls.Add(Me.lblCustomerSignature)
        Me.Panel1.Controls.Add(Me.lblCreditApprovedBy)
        Me.Panel1.Controls.Add(Me.lblBilledCheckby)
        Me.Panel1.Controls.Add(Me.lblDRNo)
        Me.Panel1.Controls.Add(Me.lblAmountDue)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.lblTIN)
        Me.Panel1.Controls.Add(Me.lblBusStyle)
        Me.Panel1.Controls.Add(Me.lblSalesman)
        Me.Panel1.Controls.Add(Me.lblTerms)
        Me.Panel1.Controls.Add(Me.lblDelivery)
        Me.Panel1.Controls.Add(Me.lblPONo)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblSoldTo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 645)
        Me.Panel1.TabIndex = 0
        '
        'lblSoldTo
        '
        Me.lblSoldTo.AutoSize = True
        Me.lblSoldTo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblSoldTo.Location = New System.Drawing.Point(49, 22)
        Me.lblSoldTo.Name = "lblSoldTo"
        Me.lblSoldTo.Size = New System.Drawing.Size(58, 15)
        Me.lblSoldTo.TabIndex = 54
        Me.lblSoldTo.Text = "lblSoldTo"
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
        'lblPONo
        '
        Me.lblPONo.AutoSize = True
        Me.lblPONo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblPONo.Location = New System.Drawing.Point(526, 41)
        Me.lblPONo.Name = "lblPONo"
        Me.lblPONo.Size = New System.Drawing.Size(53, 15)
        Me.lblPONo.TabIndex = 57
        Me.lblPONo.Text = "lblPONo"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAddress.Location = New System.Drawing.Point(49, 41)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(66, 15)
        Me.lblAddress.TabIndex = 56
        Me.lblAddress.Text = "lblAddress"
        '
        'lblTerms
        '
        Me.lblTerms.AutoSize = True
        Me.lblTerms.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTerms.Location = New System.Drawing.Point(526, 63)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(55, 15)
        Me.lblTerms.TabIndex = 59
        Me.lblTerms.Text = "lblTerms"
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDelivery.Location = New System.Drawing.Point(49, 63)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(63, 15)
        Me.lblDelivery.TabIndex = 58
        Me.lblDelivery.Text = "lblDelivery"
        '
        'lblSalesman
        '
        Me.lblSalesman.AutoSize = True
        Me.lblSalesman.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblSalesman.Location = New System.Drawing.Point(526, 85)
        Me.lblSalesman.Name = "lblSalesman"
        Me.lblSalesman.Size = New System.Drawing.Size(77, 15)
        Me.lblSalesman.TabIndex = 61
        Me.lblSalesman.Text = "lblSalesman"
        '
        'lblTIN
        '
        Me.lblTIN.AutoSize = True
        Me.lblTIN.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTIN.Location = New System.Drawing.Point(526, 108)
        Me.lblTIN.Name = "lblTIN"
        Me.lblTIN.Size = New System.Drawing.Size(39, 15)
        Me.lblTIN.TabIndex = 63
        Me.lblTIN.Text = "lblTIN"
        '
        'lblBusStyle
        '
        Me.lblBusStyle.AutoSize = True
        Me.lblBusStyle.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblBusStyle.Location = New System.Drawing.Point(49, 108)
        Me.lblBusStyle.Name = "lblBusStyle"
        Me.lblBusStyle.Size = New System.Drawing.Size(68, 15)
        Me.lblBusStyle.TabIndex = 62
        Me.lblBusStyle.Text = "lblBusStyle"
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(52, 151)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(605, 261)
        Me.ListView1.TabIndex = 64
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Quantity"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Unit"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit Price"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 146
        '
        'lblAmountDue
        '
        Me.lblAmountDue.AutoSize = True
        Me.lblAmountDue.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAmountDue.Location = New System.Drawing.Point(548, 435)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(85, 15)
        Me.lblAmountDue.TabIndex = 65
        Me.lblAmountDue.Text = "lblAmountDue"
        '
        'lblDRNo
        '
        Me.lblDRNo.AutoSize = True
        Me.lblDRNo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDRNo.Location = New System.Drawing.Point(74, 489)
        Me.lblDRNo.Name = "lblDRNo"
        Me.lblDRNo.Size = New System.Drawing.Size(54, 15)
        Me.lblDRNo.TabIndex = 66
        Me.lblDRNo.Text = "lblDRNo"
        '
        'lblBilledCheckby
        '
        Me.lblBilledCheckby.AutoSize = True
        Me.lblBilledCheckby.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblBilledCheckby.Location = New System.Drawing.Point(303, 489)
        Me.lblBilledCheckby.Name = "lblBilledCheckby"
        Me.lblBilledCheckby.Size = New System.Drawing.Size(98, 15)
        Me.lblBilledCheckby.TabIndex = 67
        Me.lblBilledCheckby.Text = "lblBilledCheckby"
        '
        'lblCreditApprovedBy
        '
        Me.lblCreditApprovedBy.AutoSize = True
        Me.lblCreditApprovedBy.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCreditApprovedBy.Location = New System.Drawing.Point(526, 489)
        Me.lblCreditApprovedBy.Name = "lblCreditApprovedBy"
        Me.lblCreditApprovedBy.Size = New System.Drawing.Size(117, 15)
        Me.lblCreditApprovedBy.TabIndex = 68
        Me.lblCreditApprovedBy.Text = "lblCreditApprovedBy"
        '
        'lblCustomerSignature
        '
        Me.lblCustomerSignature.AutoSize = True
        Me.lblCustomerSignature.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCustomerSignature.Location = New System.Drawing.Point(74, 549)
        Me.lblCustomerSignature.Name = "lblCustomerSignature"
        Me.lblCustomerSignature.Size = New System.Drawing.Size(128, 15)
        Me.lblCustomerSignature.TabIndex = 69
        Me.lblCustomerSignature.Text = "lblCustomerSignature"
        '
        'lblCEO
        '
        Me.lblCEO.AutoSize = True
        Me.lblCEO.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCEO.Location = New System.Drawing.Point(526, 549)
        Me.lblCEO.Name = "lblCEO"
        Me.lblCEO.Size = New System.Drawing.Size(46, 15)
        Me.lblCEO.TabIndex = 70
        Me.lblCEO.Text = "lblCEO"
        '
        'frmPrintBillingStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 645)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPrintBillingStatement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSoldTo As Label
    Friend WithEvents lblTIN As Label
    Friend WithEvents lblBusStyle As Label
    Friend WithEvents lblSalesman As Label
    Friend WithEvents lblTerms As Label
    Friend WithEvents lblDelivery As Label
    Friend WithEvents lblPONo As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents lblDRNo As Label
    Friend WithEvents lblCreditApprovedBy As Label
    Friend WithEvents lblBilledCheckby As Label
    Friend WithEvents lblCEO As Label
    Friend WithEvents lblCustomerSignature As Label
End Class
