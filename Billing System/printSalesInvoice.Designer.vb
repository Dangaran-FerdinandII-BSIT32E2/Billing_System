<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printSalesInvoice
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
        Me.lblTIN = New System.Windows.Forms.Label()
        Me.lblBusStyle = New System.Windows.Forms.Label()
        Me.lblSalesman = New System.Windows.Forms.Label()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblPONo = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSoldTo = New System.Windows.Forms.Label()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCEO = New System.Windows.Forms.Label()
        Me.lblCustomerSignature = New System.Windows.Forms.Label()
        Me.lblCreditApprovedBy = New System.Windows.Forms.Label()
        Me.lblBilledCheckby = New System.Windows.Forms.Label()
        Me.lblDRNo = New System.Windows.Forms.Label()
        Me.lblVATableSales = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblVATExemptSales = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblZeroRatedSales = New System.Windows.Forms.Label()
        Me.lblTotalAmountDue = New System.Windows.Forms.Label()
        Me.lblLessWithHoldingTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAdd12VAT = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 146
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit Price"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Unit"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Quantity"
        Me.ColumnHeader1.Width = 100
        '
        'lblCEO
        '
        Me.lblCEO.AutoSize = True
        Me.lblCEO.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCEO.Location = New System.Drawing.Point(519, 680)
        Me.lblCEO.Name = "lblCEO"
        Me.lblCEO.Size = New System.Drawing.Size(46, 15)
        Me.lblCEO.TabIndex = 70
        Me.lblCEO.Text = "lblCEO"
        '
        'lblCustomerSignature
        '
        Me.lblCustomerSignature.AutoSize = True
        Me.lblCustomerSignature.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCustomerSignature.Location = New System.Drawing.Point(67, 680)
        Me.lblCustomerSignature.Name = "lblCustomerSignature"
        Me.lblCustomerSignature.Size = New System.Drawing.Size(128, 15)
        Me.lblCustomerSignature.TabIndex = 69
        Me.lblCustomerSignature.Text = "lblCustomerSignature"
        '
        'lblCreditApprovedBy
        '
        Me.lblCreditApprovedBy.AutoSize = True
        Me.lblCreditApprovedBy.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCreditApprovedBy.Location = New System.Drawing.Point(519, 620)
        Me.lblCreditApprovedBy.Name = "lblCreditApprovedBy"
        Me.lblCreditApprovedBy.Size = New System.Drawing.Size(117, 15)
        Me.lblCreditApprovedBy.TabIndex = 68
        Me.lblCreditApprovedBy.Text = "lblCreditApprovedBy"
        '
        'lblBilledCheckby
        '
        Me.lblBilledCheckby.AutoSize = True
        Me.lblBilledCheckby.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblBilledCheckby.Location = New System.Drawing.Point(296, 620)
        Me.lblBilledCheckby.Name = "lblBilledCheckby"
        Me.lblBilledCheckby.Size = New System.Drawing.Size(98, 15)
        Me.lblBilledCheckby.TabIndex = 67
        Me.lblBilledCheckby.Text = "lblBilledCheckby"
        '
        'lblDRNo
        '
        Me.lblDRNo.AutoSize = True
        Me.lblDRNo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDRNo.Location = New System.Drawing.Point(67, 620)
        Me.lblDRNo.Name = "lblDRNo"
        Me.lblDRNo.Size = New System.Drawing.Size(54, 15)
        Me.lblDRNo.TabIndex = 66
        Me.lblDRNo.Text = "lblDRNo"
        '
        'lblVATableSales
        '
        Me.lblVATableSales.AutoSize = True
        Me.lblVATableSales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblVATableSales.Location = New System.Drawing.Point(526, 383)
        Me.lblVATableSales.Name = "lblVATableSales"
        Me.lblVATableSales.Size = New System.Drawing.Size(81, 15)
        Me.lblVATableSales.TabIndex = 65
        Me.lblVATableSales.Text = "VATableSales"
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
        Me.ListView1.Size = New System.Drawing.Size(605, 229)
        Me.ListView1.TabIndex = 64
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblTotalAmountDue)
        Me.Panel1.Controls.Add(Me.lblLessWithHoldingTax)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lblAdd12VAT)
        Me.Panel1.Controls.Add(Me.lblTotalSales)
        Me.Panel1.Controls.Add(Me.lblZeroRatedSales)
        Me.Panel1.Controls.Add(Me.lblVATExemptSales)
        Me.Panel1.Controls.Add(Me.lblCEO)
        Me.Panel1.Controls.Add(Me.lblCustomerSignature)
        Me.Panel1.Controls.Add(Me.lblCreditApprovedBy)
        Me.Panel1.Controls.Add(Me.lblBilledCheckby)
        Me.Panel1.Controls.Add(Me.lblDRNo)
        Me.Panel1.Controls.Add(Me.lblVATableSales)
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
        Me.Panel1.Size = New System.Drawing.Size(693, 749)
        Me.Panel1.TabIndex = 3
        '
        'lblVATExemptSales
        '
        Me.lblVATExemptSales.AutoSize = True
        Me.lblVATExemptSales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblVATExemptSales.Location = New System.Drawing.Point(526, 405)
        Me.lblVATExemptSales.Name = "lblVATExemptSales"
        Me.lblVATExemptSales.Size = New System.Drawing.Size(99, 15)
        Me.lblVATExemptSales.TabIndex = 71
        Me.lblVATExemptSales.Text = "VATExemptSales"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTotalSales.Location = New System.Drawing.Point(526, 446)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(65, 15)
        Me.lblTotalSales.TabIndex = 73
        Me.lblTotalSales.Text = "TotalSales"
        '
        'lblZeroRatedSales
        '
        Me.lblZeroRatedSales.AutoSize = True
        Me.lblZeroRatedSales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblZeroRatedSales.Location = New System.Drawing.Point(526, 425)
        Me.lblZeroRatedSales.Name = "lblZeroRatedSales"
        Me.lblZeroRatedSales.Size = New System.Drawing.Size(97, 15)
        Me.lblZeroRatedSales.TabIndex = 72
        Me.lblZeroRatedSales.Text = "ZeroRatedSales"
        '
        'lblTotalAmountDue
        '
        Me.lblTotalAmountDue.AutoSize = True
        Me.lblTotalAmountDue.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTotalAmountDue.Location = New System.Drawing.Point(526, 526)
        Me.lblTotalAmountDue.Name = "lblTotalAmountDue"
        Me.lblTotalAmountDue.Size = New System.Drawing.Size(98, 15)
        Me.lblTotalAmountDue.TabIndex = 77
        Me.lblTotalAmountDue.Text = "TotalAmountDue"
        '
        'lblLessWithHoldingTax
        '
        Me.lblLessWithHoldingTax.AutoSize = True
        Me.lblLessWithHoldingTax.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblLessWithHoldingTax.Location = New System.Drawing.Point(526, 506)
        Me.lblLessWithHoldingTax.Name = "lblLessWithHoldingTax"
        Me.lblLessWithHoldingTax.Size = New System.Drawing.Size(111, 15)
        Me.lblLessWithHoldingTax.TabIndex = 76
        Me.lblLessWithHoldingTax.Text = "LessWitholdingTax"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTotal.Location = New System.Drawing.Point(526, 485)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(33, 15)
        Me.lblTotal.TabIndex = 75
        Me.lblTotal.Text = "Total"
        '
        'lblAdd12VAT
        '
        Me.lblAdd12VAT.AutoSize = True
        Me.lblAdd12VAT.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAdd12VAT.Location = New System.Drawing.Point(526, 464)
        Me.lblAdd12VAT.Name = "lblAdd12VAT"
        Me.lblAdd12VAT.Size = New System.Drawing.Size(61, 15)
        Me.lblAdd12VAT.TabIndex = 74
        Me.lblAdd12VAT.Text = "Add12VAT"
        '
        'frmPrintBlankSalesInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPrintBlankSalesInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTIN As Label
    Friend WithEvents lblBusStyle As Label
    Friend WithEvents lblSalesman As Label
    Friend WithEvents lblTerms As Label
    Friend WithEvents lblDelivery As Label
    Friend WithEvents lblPONo As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSoldTo As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents lblCEO As Label
    Friend WithEvents lblCustomerSignature As Label
    Friend WithEvents lblCreditApprovedBy As Label
    Friend WithEvents lblBilledCheckby As Label
    Friend WithEvents lblDRNo As Label
    Friend WithEvents lblVATableSales As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents lblDate As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalAmountDue As Label
    Friend WithEvents lblLessWithHoldingTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAdd12VAT As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents lblZeroRatedSales As Label
    Friend WithEvents lblVATExemptSales As Label
End Class
