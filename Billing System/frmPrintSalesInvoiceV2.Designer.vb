<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrintSalesInvoiceV2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintSalesInvoiceV2))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel42 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel41 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel49 = New System.Windows.Forms.Panel()
        Me.Panel50 = New System.Windows.Forms.Panel()
        Me.Guna2Panel39 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Panel53 = New System.Windows.Forms.Panel()
        Me.Panel54 = New System.Windows.Forms.Panel()
        Me.Guna2Panel40 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.Panel46 = New System.Windows.Forms.Panel()
        Me.lblApprovedBy = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.lblCheckedBy = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label = New System.Windows.Forms.Label()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.Panel47 = New System.Windows.Forms.Panel()
        Me.lblDRNo = New System.Windows.Forms.Label()
        Me.Guna2Panel38 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Panel38 = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.panelBodyListView = New Guna.UI2.WinForms.Guna2Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2Panel37 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel36 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel35 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel34 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelBodyCriteria = New Guna.UI2.WinForms.Guna2Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.Guna2Panel33 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel32 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel31 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel29 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblPriceAdjusted = New System.Windows.Forms.Label()
        Me.lblAdjustPrice = New System.Windows.Forms.Label()
        Me.Guna2Panel30 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel27 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Guna2Panel28 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel25 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lblAddVAT = New System.Windows.Forms.Label()
        Me.Guna2Panel26 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel23 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Guna2Panel24 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel21 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblZeroRatedSales = New System.Windows.Forms.Label()
        Me.Guna2Panel22 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel19 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblVATExempt = New System.Windows.Forms.Label()
        Me.Guna2Panel20 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel16 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblVATSales = New System.Windows.Forms.Label()
        Me.Guna2Panel17 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel18 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.lblBusStyle = New System.Windows.Forms.Label()
        Me.Guna2Panel14 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.lblTIN = New System.Windows.Forms.Label()
        Me.Guna2Panel15 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Guna2Panel12 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.lblSalesman = New System.Windows.Forms.Label()
        Me.Guna2Panel13 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.Guna2Panel11 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPONo = New System.Windows.Forms.Label()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.lblSoldTo = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel40 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel3.SuspendLayout()
        Me.panelBody.SuspendLayout()
        Me.Panel49.SuspendLayout()
        Me.Panel50.SuspendLayout()
        Me.Panel54.SuspendLayout()
        Me.Panel42.SuspendLayout()
        Me.Panel46.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Panel43.SuspendLayout()
        Me.Panel47.SuspendLayout()
        Me.Panel39.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.panelBodyListView.SuspendLayout()
        Me.panelBodyCriteria.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2Panel29.SuspendLayout()
        Me.Guna2Panel27.SuspendLayout()
        Me.Guna2Panel25.SuspendLayout()
        Me.Guna2Panel23.SuspendLayout()
        Me.Guna2Panel21.SuspendLayout()
        Me.Guna2Panel19.SuspendLayout()
        Me.Guna2Panel16.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel33.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel40.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDocument1
        '
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1371, 12)
        Me.Panel4.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 738)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 12)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 12)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 726)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Controls.Add(Me.Guna2Panel42)
        Me.Panel3.Controls.Add(Me.Guna2Panel41)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1094, 12)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(277, 726)
        Me.Panel3.TabIndex = 6
        '
        'btnPrint
        '
        Me.btnPrint.BorderRadius = 8
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPrint.FillColor = System.Drawing.Color.OrangeRed
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPrint.ImageOffset = New System.Drawing.Point(50, 0)
        Me.btnPrint.Location = New System.Drawing.Point(13, 666)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.PressedDepth = 20
        Me.btnPrint.Size = New System.Drawing.Size(251, 60)
        Me.btnPrint.TabIndex = 58
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Guna2Panel42
        '
        Me.Guna2Panel42.BorderThickness = 1
        Me.Guna2Panel42.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel42.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel42.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel42.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel42.Name = "Guna2Panel42"
        Me.Guna2Panel42.Size = New System.Drawing.Size(13, 726)
        Me.Guna2Panel42.TabIndex = 7
        '
        'Guna2Panel41
        '
        Me.Guna2Panel41.BorderThickness = 1
        Me.Guna2Panel41.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel41.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel41.Location = New System.Drawing.Point(264, 0)
        Me.Guna2Panel41.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel41.Name = "Guna2Panel41"
        Me.Guna2Panel41.Size = New System.Drawing.Size(13, 726)
        Me.Guna2Panel41.TabIndex = 6
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.Label10)
        Me.panelBody.Controls.Add(Me.Panel49)
        Me.panelBody.Controls.Add(Me.Panel42)
        Me.panelBody.Controls.Add(Me.Panel41)
        Me.panelBody.Controls.Add(Me.Panel39)
        Me.panelBody.Controls.Add(Me.Panel38)
        Me.panelBody.Controls.Add(Me.Panel30)
        Me.panelBody.Controls.Add(Me.Guna2TextBox1)
        Me.panelBody.Controls.Add(Me.Panel28)
        Me.panelBody.Controls.Add(Me.Panel23)
        Me.panelBody.Controls.Add(Me.Panel9)
        Me.panelBody.Controls.Add(Me.Panel7)
        Me.panelBody.Controls.Add(Me.Panel11)
        Me.panelBody.Controls.Add(Me.Panel40)
        Me.panelBody.Controls.Add(Me.Guna2Panel3)
        Me.panelBody.Controls.Add(Me.Guna2Panel2)
        Me.panelBody.Controls.Add(Me.Guna2Panel1)
        Me.panelBody.Controls.Add(Me.pnlHeader)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(277, 12)
        Me.panelBody.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(817, 726)
        Me.panelBody.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(144, 783)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 18)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Customer's Signature"
        '
        'Panel49
        '
        Me.Panel49.Controls.Add(Me.Panel50)
        Me.Panel49.Controls.Add(Me.Label63)
        Me.Panel49.Controls.Add(Me.Panel53)
        Me.Panel49.Controls.Add(Me.Panel54)
        Me.Panel49.Controls.Add(Me.Label69)
        Me.Panel49.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel49.Location = New System.Drawing.Point(13, 764)
        Me.Panel49.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel49.Name = "Panel49"
        Me.Panel49.Size = New System.Drawing.Size(791, 34)
        Me.Panel49.TabIndex = 60
        '
        'Panel50
        '
        Me.Panel50.Controls.Add(Me.Guna2Panel39)
        Me.Panel50.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel50.Location = New System.Drawing.Point(739, 0)
        Me.Panel50.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel50.Name = "Panel50"
        Me.Panel50.Size = New System.Drawing.Size(497, 34)
        Me.Panel50.TabIndex = 57
        '
        'Guna2Panel39
        '
        Me.Guna2Panel39.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel39.BorderThickness = 2
        Me.Guna2Panel39.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel39.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel39.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel39.Location = New System.Drawing.Point(0, 16)
        Me.Guna2Panel39.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel39.Name = "Guna2Panel39"
        Me.Guna2Panel39.Size = New System.Drawing.Size(497, 18)
        Me.Guna2Panel39.TabIndex = 101
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label63.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label63.Location = New System.Drawing.Point(710, 0)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(29, 17)
        Me.Label63.TabIndex = 55
        Me.Label63.Text = "By:"
        '
        'Panel53
        '
        Me.Panel53.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel53.Location = New System.Drawing.Point(453, 0)
        Me.Panel53.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel53.Name = "Panel53"
        Me.Panel53.Size = New System.Drawing.Size(257, 34)
        Me.Panel53.TabIndex = 8
        '
        'Panel54
        '
        Me.Panel54.Controls.Add(Me.Guna2Panel40)
        Me.Panel54.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel54.Location = New System.Drawing.Point(29, 0)
        Me.Panel54.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel54.Name = "Panel54"
        Me.Panel54.Size = New System.Drawing.Size(424, 34)
        Me.Panel54.TabIndex = 51
        '
        'Guna2Panel40
        '
        Me.Guna2Panel40.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel40.BorderThickness = 2
        Me.Guna2Panel40.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel40.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel40.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel40.Location = New System.Drawing.Point(0, 16)
        Me.Guna2Panel40.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel40.Name = "Guna2Panel40"
        Me.Guna2Panel40.Size = New System.Drawing.Size(424, 18)
        Me.Guna2Panel40.TabIndex = 100
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label69.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label69.Location = New System.Drawing.Point(0, 0)
        Me.Label69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(29, 17)
        Me.Label69.TabIndex = 48
        Me.Label69.Text = "By:"
        '
        'Panel42
        '
        Me.Panel42.Controls.Add(Me.Panel46)
        Me.Panel42.Controls.Add(Me.Label57)
        Me.Panel42.Controls.Add(Me.Panel45)
        Me.Panel42.Controls.Add(Me.Panel43)
        Me.Panel42.Controls.Add(Me.Label)
        Me.Panel42.Controls.Add(Me.Panel44)
        Me.Panel42.Controls.Add(Me.Panel47)
        Me.Panel42.Controls.Add(Me.Label56)
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel42.Location = New System.Drawing.Point(13, 726)
        Me.Panel42.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(791, 38)
        Me.Panel42.TabIndex = 57
        '
        'Panel46
        '
        Me.Panel46.Controls.Add(Me.lblApprovedBy)
        Me.Panel46.Controls.Add(Me.Guna2Panel4)
        Me.Panel46.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel46.Location = New System.Drawing.Point(821, 0)
        Me.Panel46.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel46.Name = "Panel46"
        Me.Panel46.Size = New System.Drawing.Size(0, 38)
        Me.Panel46.TabIndex = 56
        '
        'lblApprovedBy
        '
        Me.lblApprovedBy.AutoSize = True
        Me.lblApprovedBy.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblApprovedBy.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblApprovedBy.Location = New System.Drawing.Point(0, 0)
        Me.lblApprovedBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApprovedBy.Name = "lblApprovedBy"
        Me.lblApprovedBy.Size = New System.Drawing.Size(53, 17)
        Me.lblApprovedBy.TabIndex = 53
        Me.lblApprovedBy.Text = "XXXXX"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderThickness = 2
        Me.Guna2Panel4.Controls.Add(Me.Label5)
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(0, 18)
        Me.Guna2Panel4.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(97, 1)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 18)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "RAMBIC CORPORATION"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label57.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label57.Location = New System.Drawing.Point(685, 0)
        Me.Label57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(136, 17)
        Me.Label57.TabIndex = 55
        Me.Label57.Text = "Credit Approved By:"
        '
        'Panel45
        '
        Me.Panel45.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel45.Location = New System.Drawing.Point(672, 0)
        Me.Panel45.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(13, 38)
        Me.Panel45.TabIndex = 54
        '
        'Panel43
        '
        Me.Panel43.Controls.Add(Me.lblCheckedBy)
        Me.Panel43.Controls.Add(Me.Guna2Panel5)
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel43.Location = New System.Drawing.Point(428, 0)
        Me.Panel43.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(244, 38)
        Me.Panel43.TabIndex = 53
        '
        'lblCheckedBy
        '
        Me.lblCheckedBy.AutoSize = True
        Me.lblCheckedBy.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCheckedBy.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCheckedBy.Location = New System.Drawing.Point(0, 0)
        Me.lblCheckedBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheckedBy.Name = "lblCheckedBy"
        Me.lblCheckedBy.Size = New System.Drawing.Size(53, 17)
        Me.lblCheckedBy.TabIndex = 53
        Me.lblCheckedBy.Text = "XXXXX"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderThickness = 2
        Me.Guna2Panel5.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel5.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(244, 18)
        Me.Guna2Panel5.TabIndex = 61
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label.Location = New System.Drawing.Point(272, 0)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(156, 17)
        Me.Label.TabIndex = 52
        Me.Label.Text = "Billed and Checked by:"
        '
        'Panel44
        '
        Me.Panel44.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel44.Location = New System.Drawing.Point(259, 0)
        Me.Panel44.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(13, 38)
        Me.Panel44.TabIndex = 8
        '
        'Panel47
        '
        Me.Panel47.Controls.Add(Me.lblDRNo)
        Me.Panel47.Controls.Add(Me.Guna2Panel38)
        Me.Panel47.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel47.Location = New System.Drawing.Point(64, 0)
        Me.Panel47.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel47.Name = "Panel47"
        Me.Panel47.Size = New System.Drawing.Size(195, 38)
        Me.Panel47.TabIndex = 51
        '
        'lblDRNo
        '
        Me.lblDRNo.AutoSize = True
        Me.lblDRNo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDRNo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDRNo.Location = New System.Drawing.Point(0, 0)
        Me.lblDRNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDRNo.Name = "lblDRNo"
        Me.lblDRNo.Size = New System.Drawing.Size(53, 17)
        Me.lblDRNo.TabIndex = 53
        Me.lblDRNo.Text = "XXXXX"
        '
        'Guna2Panel38
        '
        Me.Guna2Panel38.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel38.BorderThickness = 2
        Me.Guna2Panel38.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel38.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel38.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel38.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel38.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel38.Name = "Guna2Panel38"
        Me.Guna2Panel38.Size = New System.Drawing.Size(195, 18)
        Me.Guna2Panel38.TabIndex = 60
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label56.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label56.Location = New System.Drawing.Point(0, 0)
        Me.Label56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(64, 17)
        Me.Label56.TabIndex = 48
        Me.Label56.Text = "D.R. No:"
        '
        'Panel41
        '
        Me.Panel41.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel41.Location = New System.Drawing.Point(13, 714)
        Me.Panel41.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(791, 12)
        Me.Panel41.TabIndex = 56
        '
        'Panel39
        '
        Me.Panel39.Controls.Add(Me.Label50)
        Me.Panel39.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel39.Location = New System.Drawing.Point(13, 694)
        Me.Panel39.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(791, 20)
        Me.Panel39.TabIndex = 19
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label50.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label50.Location = New System.Drawing.Point(0, 0)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(492, 17)
        Me.Label50.TabIndex = 50
        Me.Label50.Text = "Received in good order and condition terms herein specified and accepted."
        '
        'Panel38
        '
        Me.Panel38.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel38.Location = New System.Drawing.Point(13, 682)
        Me.Panel38.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(791, 12)
        Me.Panel38.TabIndex = 18
        '
        'Panel30
        '
        Me.Panel30.Controls.Add(Me.panelBodyListView)
        Me.Panel30.Controls.Add(Me.panelBodyCriteria)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel30.Location = New System.Drawing.Point(13, 336)
        Me.Panel30.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(791, 346)
        Me.Panel30.TabIndex = 17
        '
        'panelBodyListView
        '
        Me.panelBodyListView.BorderThickness = 1
        Me.panelBodyListView.Controls.Add(Me.ListView1)
        Me.panelBodyListView.Controls.Add(Me.Guna2Panel37)
        Me.panelBodyListView.Controls.Add(Me.Guna2Panel36)
        Me.panelBodyListView.Controls.Add(Me.Guna2Panel35)
        Me.panelBodyListView.Controls.Add(Me.Guna2Panel34)
        Me.panelBodyListView.CustomBorderColor = System.Drawing.Color.Black
        Me.panelBodyListView.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 0, 2)
        Me.panelBodyListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBodyListView.Location = New System.Drawing.Point(0, 0)
        Me.panelBodyListView.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBodyListView.Name = "panelBodyListView"
        Me.panelBodyListView.Size = New System.Drawing.Size(408, 346)
        Me.panelBodyListView.TabIndex = 7
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(13, 12)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(382, 322)
        Me.ListView1.TabIndex = 39
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
        'Guna2Panel37
        '
        Me.Guna2Panel37.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel37.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel37.Location = New System.Drawing.Point(13, 0)
        Me.Guna2Panel37.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel37.Name = "Guna2Panel37"
        Me.Guna2Panel37.Size = New System.Drawing.Size(382, 12)
        Me.Guna2Panel37.TabIndex = 1
        '
        'Guna2Panel36
        '
        Me.Guna2Panel36.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel36.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel36.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel36.Location = New System.Drawing.Point(13, 334)
        Me.Guna2Panel36.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel36.Name = "Guna2Panel36"
        Me.Guna2Panel36.Size = New System.Drawing.Size(382, 12)
        Me.Guna2Panel36.TabIndex = 1
        '
        'Guna2Panel35
        '
        Me.Guna2Panel35.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel35.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel35.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel35.Location = New System.Drawing.Point(395, 0)
        Me.Guna2Panel35.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel35.Name = "Guna2Panel35"
        Me.Guna2Panel35.Size = New System.Drawing.Size(13, 346)
        Me.Guna2Panel35.TabIndex = 1
        '
        'Guna2Panel34
        '
        Me.Guna2Panel34.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel34.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 0, 2)
        Me.Guna2Panel34.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel34.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel34.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel34.Name = "Guna2Panel34"
        Me.Guna2Panel34.Size = New System.Drawing.Size(13, 346)
        Me.Guna2Panel34.TabIndex = 0
        '
        'panelBodyCriteria
        '
        Me.panelBodyCriteria.BorderThickness = 1
        Me.panelBodyCriteria.Controls.Add(Me.GroupBox1)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel33)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel32)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel31)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel29)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel27)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel25)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel23)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel21)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel19)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel16)
        Me.panelBodyCriteria.Controls.Add(Me.Guna2Panel18)
        Me.panelBodyCriteria.CustomBorderColor = System.Drawing.Color.Black
        Me.panelBodyCriteria.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.panelBodyCriteria.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelBodyCriteria.Location = New System.Drawing.Point(408, 0)
        Me.panelBodyCriteria.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBodyCriteria.Name = "panelBodyCriteria"
        Me.panelBodyCriteria.Size = New System.Drawing.Size(383, 346)
        Me.panelBodyCriteria.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalAmount)
        Me.GroupBox1.Controls.Add(Me.Panel35)
        Me.GroupBox1.Controls.Add(Me.Label49)
        Me.GroupBox1.Controls.Add(Me.Panel36)
        Me.GroupBox1.Controls.Add(Me.Panel37)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 243)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(357, 91)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Amount Due"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lblTotalAmount.Location = New System.Drawing.Point(84, 34)
        Me.lblTotalAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(83, 39)
        Me.lblTotalAmount.TabIndex = 98
        Me.lblTotalAmount.Text = "0.00"
        '
        'Panel35
        '
        Me.Panel35.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel35.Location = New System.Drawing.Point(71, 34)
        Me.Panel35.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(13, 53)
        Me.Panel35.TabIndex = 98
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label49.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.Label49.Location = New System.Drawing.Point(31, 34)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(40, 39)
        Me.Label49.TabIndex = 97
        Me.Label49.Text = "₱"
        '
        'Panel36
        '
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel36.Location = New System.Drawing.Point(4, 34)
        Me.Panel36.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(27, 53)
        Me.Panel36.TabIndex = 39
        '
        'Panel37
        '
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel37.Location = New System.Drawing.Point(4, 22)
        Me.Panel37.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(349, 12)
        Me.Panel37.TabIndex = 40
        '
        'Guna2Panel33
        '
        Me.Guna2Panel33.BorderThickness = 1
        Me.Guna2Panel33.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel33.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Guna2Panel33.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel33.Location = New System.Drawing.Point(0, 243)
        Me.Guna2Panel33.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel33.Name = "Guna2Panel33"
        Me.Guna2Panel33.Size = New System.Drawing.Size(13, 91)
        Me.Guna2Panel33.TabIndex = 17
        '
        'Guna2Panel32
        '
        Me.Guna2Panel32.BorderThickness = 1
        Me.Guna2Panel32.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel32.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Guna2Panel32.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel32.Location = New System.Drawing.Point(370, 243)
        Me.Guna2Panel32.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel32.Name = "Guna2Panel32"
        Me.Guna2Panel32.Size = New System.Drawing.Size(13, 91)
        Me.Guna2Panel32.TabIndex = 16
        '
        'Guna2Panel31
        '
        Me.Guna2Panel31.BorderThickness = 1
        Me.Guna2Panel31.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel31.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.Guna2Panel31.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel31.Location = New System.Drawing.Point(0, 334)
        Me.Guna2Panel31.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel31.Name = "Guna2Panel31"
        Me.Guna2Panel31.Size = New System.Drawing.Size(383, 12)
        Me.Guna2Panel31.TabIndex = 15
        '
        'Guna2Panel29
        '
        Me.Guna2Panel29.BorderThickness = 1
        Me.Guna2Panel29.Controls.Add(Me.lblPriceAdjusted)
        Me.Guna2Panel29.Controls.Add(Me.lblAdjustPrice)
        Me.Guna2Panel29.Controls.Add(Me.Guna2Panel30)
        Me.Guna2Panel29.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel29.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Guna2Panel29.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel29.Location = New System.Drawing.Point(0, 210)
        Me.Guna2Panel29.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel29.Name = "Guna2Panel29"
        Me.Guna2Panel29.Size = New System.Drawing.Size(383, 33)
        Me.Guna2Panel29.TabIndex = 14
        '
        'lblPriceAdjusted
        '
        Me.lblPriceAdjusted.AutoSize = True
        Me.lblPriceAdjusted.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPriceAdjusted.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblPriceAdjusted.Location = New System.Drawing.Point(124, 0)
        Me.lblPriceAdjusted.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceAdjusted.Name = "lblPriceAdjusted"
        Me.lblPriceAdjusted.Size = New System.Drawing.Size(70, 17)
        Me.lblPriceAdjusted.TabIndex = 55
        Me.lblPriceAdjusted.Text = "Discount:"
        Me.lblPriceAdjusted.Visible = False
        '
        'lblAdjustPrice
        '
        Me.lblAdjustPrice.AutoSize = True
        Me.lblAdjustPrice.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAdjustPrice.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAdjustPrice.Location = New System.Drawing.Point(194, 0)
        Me.lblAdjustPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdjustPrice.Name = "lblAdjustPrice"
        Me.lblAdjustPrice.Size = New System.Drawing.Size(36, 17)
        Me.lblAdjustPrice.TabIndex = 56
        Me.lblAdjustPrice.Text = "0.00"
        Me.lblAdjustPrice.Visible = False
        '
        'Guna2Panel30
        '
        Me.Guna2Panel30.BorderThickness = 1
        Me.Guna2Panel30.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel30.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Guna2Panel30.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel30.Location = New System.Drawing.Point(230, 0)
        Me.Guna2Panel30.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel30.Name = "Guna2Panel30"
        Me.Guna2Panel30.Size = New System.Drawing.Size(153, 33)
        Me.Guna2Panel30.TabIndex = 8
        '
        'Guna2Panel27
        '
        Me.Guna2Panel27.BorderThickness = 1
        Me.Guna2Panel27.Controls.Add(Me.Label46)
        Me.Guna2Panel27.Controls.Add(Me.lblTotal)
        Me.Guna2Panel27.Controls.Add(Me.Guna2Panel28)
        Me.Guna2Panel27.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel27.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Guna2Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel27.Location = New System.Drawing.Point(0, 177)
        Me.Guna2Panel27.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel27.Name = "Guna2Panel27"
        Me.Guna2Panel27.Size = New System.Drawing.Size(383, 33)
        Me.Guna2Panel27.TabIndex = 13
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label46.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label46.Location = New System.Drawing.Point(152, 0)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(42, 17)
        Me.Label46.TabIndex = 55
        Me.Label46.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTotal.Location = New System.Drawing.Point(194, 0)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(36, 17)
        Me.lblTotal.TabIndex = 56
        Me.lblTotal.Text = "0.00"
        '
        'Guna2Panel28
        '
        Me.Guna2Panel28.BorderThickness = 1
        Me.Guna2Panel28.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel28.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Guna2Panel28.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel28.Location = New System.Drawing.Point(230, 0)
        Me.Guna2Panel28.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel28.Name = "Guna2Panel28"
        Me.Guna2Panel28.Size = New System.Drawing.Size(153, 33)
        Me.Guna2Panel28.TabIndex = 8
        '
        'Guna2Panel25
        '
        Me.Guna2Panel25.BorderThickness = 1
        Me.Guna2Panel25.Controls.Add(Me.Label44)
        Me.Guna2Panel25.Controls.Add(Me.lblAddVAT)
        Me.Guna2Panel25.Controls.Add(Me.Guna2Panel26)
        Me.Guna2Panel25.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel25.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Guna2Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel25.Location = New System.Drawing.Point(0, 144)
        Me.Guna2Panel25.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel25.Name = "Guna2Panel25"
        Me.Guna2Panel25.Size = New System.Drawing.Size(383, 33)
        Me.Guna2Panel25.TabIndex = 12
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label44.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label44.Location = New System.Drawing.Point(97, 0)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(97, 17)
        Me.Label44.TabIndex = 55
        Me.Label44.Text = "Add 12% VAT:"
        '
        'lblAddVAT
        '
        Me.lblAddVAT.AutoSize = True
        Me.lblAddVAT.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAddVAT.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAddVAT.Location = New System.Drawing.Point(194, 0)
        Me.lblAddVAT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddVAT.Name = "lblAddVAT"
        Me.lblAddVAT.Size = New System.Drawing.Size(36, 17)
        Me.lblAddVAT.TabIndex = 56
        Me.lblAddVAT.Text = "0.00"
        '
        'Guna2Panel26
        '
        Me.Guna2Panel26.BorderThickness = 1
        Me.Guna2Panel26.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel26.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Guna2Panel26.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel26.Location = New System.Drawing.Point(230, 0)
        Me.Guna2Panel26.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel26.Name = "Guna2Panel26"
        Me.Guna2Panel26.Size = New System.Drawing.Size(153, 33)
        Me.Guna2Panel26.TabIndex = 8
        '
        'Guna2Panel23
        '
        Me.Guna2Panel23.BorderThickness = 1
        Me.Guna2Panel23.Controls.Add(Me.Label42)
        Me.Guna2Panel23.Controls.Add(Me.lblTotalSales)
        Me.Guna2Panel23.Controls.Add(Me.Guna2Panel24)
        Me.Guna2Panel23.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel23.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Guna2Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel23.Location = New System.Drawing.Point(0, 111)
        Me.Guna2Panel23.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel23.Name = "Guna2Panel23"
        Me.Guna2Panel23.Size = New System.Drawing.Size(383, 33)
        Me.Guna2Panel23.TabIndex = 11
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label42.Location = New System.Drawing.Point(111, 0)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(83, 17)
        Me.Label42.TabIndex = 55
        Me.Label42.Text = "Total Sales:"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTotalSales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTotalSales.Location = New System.Drawing.Point(194, 0)
        Me.lblTotalSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(36, 17)
        Me.lblTotalSales.TabIndex = 56
        Me.lblTotalSales.Text = "0.00"
        '
        'Guna2Panel24
        '
        Me.Guna2Panel24.BorderThickness = 1
        Me.Guna2Panel24.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel24.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Guna2Panel24.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel24.Location = New System.Drawing.Point(230, 0)
        Me.Guna2Panel24.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel24.Name = "Guna2Panel24"
        Me.Guna2Panel24.Size = New System.Drawing.Size(153, 33)
        Me.Guna2Panel24.TabIndex = 8
        '
        'Guna2Panel21
        '
        Me.Guna2Panel21.BorderThickness = 1
        Me.Guna2Panel21.Controls.Add(Me.Label40)
        Me.Guna2Panel21.Controls.Add(Me.lblZeroRatedSales)
        Me.Guna2Panel21.Controls.Add(Me.Guna2Panel22)
        Me.Guna2Panel21.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel21.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Guna2Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel21.Location = New System.Drawing.Point(0, 78)
        Me.Guna2Panel21.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel21.Name = "Guna2Panel21"
        Me.Guna2Panel21.Size = New System.Drawing.Size(383, 33)
        Me.Guna2Panel21.TabIndex = 10
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label40.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label40.Location = New System.Drawing.Point(69, 0)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(125, 17)
        Me.Label40.TabIndex = 55
        Me.Label40.Text = "Zero Rated Sales:"
        '
        'lblZeroRatedSales
        '
        Me.lblZeroRatedSales.AutoSize = True
        Me.lblZeroRatedSales.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblZeroRatedSales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblZeroRatedSales.Location = New System.Drawing.Point(194, 0)
        Me.lblZeroRatedSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblZeroRatedSales.Name = "lblZeroRatedSales"
        Me.lblZeroRatedSales.Size = New System.Drawing.Size(36, 17)
        Me.lblZeroRatedSales.TabIndex = 56
        Me.lblZeroRatedSales.Text = "0.00"
        '
        'Guna2Panel22
        '
        Me.Guna2Panel22.BorderThickness = 1
        Me.Guna2Panel22.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel22.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Guna2Panel22.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel22.Location = New System.Drawing.Point(230, 0)
        Me.Guna2Panel22.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel22.Name = "Guna2Panel22"
        Me.Guna2Panel22.Size = New System.Drawing.Size(153, 33)
        Me.Guna2Panel22.TabIndex = 8
        '
        'Guna2Panel19
        '
        Me.Guna2Panel19.BorderThickness = 1
        Me.Guna2Panel19.Controls.Add(Me.Label38)
        Me.Guna2Panel19.Controls.Add(Me.lblVATExempt)
        Me.Guna2Panel19.Controls.Add(Me.Guna2Panel20)
        Me.Guna2Panel19.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel19.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Guna2Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel19.Location = New System.Drawing.Point(0, 45)
        Me.Guna2Panel19.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel19.Name = "Guna2Panel19"
        Me.Guna2Panel19.Size = New System.Drawing.Size(383, 33)
        Me.Guna2Panel19.TabIndex = 9
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label38.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label38.Location = New System.Drawing.Point(62, 0)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(132, 17)
        Me.Label38.TabIndex = 55
        Me.Label38.Text = "VAT-Exempt Sales:"
        '
        'lblVATExempt
        '
        Me.lblVATExempt.AutoSize = True
        Me.lblVATExempt.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblVATExempt.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblVATExempt.Location = New System.Drawing.Point(194, 0)
        Me.lblVATExempt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVATExempt.Name = "lblVATExempt"
        Me.lblVATExempt.Size = New System.Drawing.Size(36, 17)
        Me.lblVATExempt.TabIndex = 56
        Me.lblVATExempt.Text = "0.00"
        '
        'Guna2Panel20
        '
        Me.Guna2Panel20.BorderThickness = 1
        Me.Guna2Panel20.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel20.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Guna2Panel20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel20.Location = New System.Drawing.Point(230, 0)
        Me.Guna2Panel20.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel20.Name = "Guna2Panel20"
        Me.Guna2Panel20.Size = New System.Drawing.Size(153, 33)
        Me.Guna2Panel20.TabIndex = 8
        '
        'Guna2Panel16
        '
        Me.Guna2Panel16.BorderThickness = 1
        Me.Guna2Panel16.Controls.Add(Me.Label35)
        Me.Guna2Panel16.Controls.Add(Me.lblVATSales)
        Me.Guna2Panel16.Controls.Add(Me.Guna2Panel17)
        Me.Guna2Panel16.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel16.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Guna2Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel16.Location = New System.Drawing.Point(0, 12)
        Me.Guna2Panel16.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel16.Name = "Guna2Panel16"
        Me.Guna2Panel16.Size = New System.Drawing.Size(383, 33)
        Me.Guna2Panel16.TabIndex = 7
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(91, 0)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(103, 17)
        Me.Label35.TabIndex = 55
        Me.Label35.Text = "VATable Sales:"
        '
        'lblVATSales
        '
        Me.lblVATSales.AutoSize = True
        Me.lblVATSales.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblVATSales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblVATSales.Location = New System.Drawing.Point(194, 0)
        Me.lblVATSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVATSales.Name = "lblVATSales"
        Me.lblVATSales.Size = New System.Drawing.Size(36, 17)
        Me.lblVATSales.TabIndex = 56
        Me.lblVATSales.Text = "0.00"
        '
        'Guna2Panel17
        '
        Me.Guna2Panel17.BorderThickness = 1
        Me.Guna2Panel17.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel17.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Guna2Panel17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel17.Location = New System.Drawing.Point(230, 0)
        Me.Guna2Panel17.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel17.Name = "Guna2Panel17"
        Me.Guna2Panel17.Size = New System.Drawing.Size(153, 33)
        Me.Guna2Panel17.TabIndex = 8
        '
        'Guna2Panel18
        '
        Me.Guna2Panel18.BorderThickness = 1
        Me.Guna2Panel18.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel18.CustomBorderThickness = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Guna2Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel18.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel18.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel18.Name = "Guna2Panel18"
        Me.Guna2Panel18.Size = New System.Drawing.Size(383, 12)
        Me.Guna2Panel18.TabIndex = 8
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.BorderThickness = 2
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = resources.GetString("Guna2TextBox1.DefaultText")
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.White
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2TextBox1.Enabled = False
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.Location = New System.Drawing.Point(13, 262)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2TextBox1.Multiline = True
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(791, 74)
        Me.Guna2TextBox1.TabIndex = 16
        '
        'Panel28
        '
        Me.Panel28.Controls.Add(Me.Panel29)
        Me.Panel28.Controls.Add(Me.Panel31)
        Me.Panel28.Controls.Add(Me.Panel32)
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel28.Location = New System.Drawing.Point(13, 224)
        Me.Panel28.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(791, 38)
        Me.Panel28.TabIndex = 15
        '
        'Panel29
        '
        Me.Panel29.Controls.Add(Me.Panel19)
        Me.Panel29.Controls.Add(Me.Label29)
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel29.Location = New System.Drawing.Point(0, 0)
        Me.Panel29.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(343, 38)
        Me.Panel29.TabIndex = 11
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.lblBusStyle)
        Me.Panel19.Controls.Add(Me.Guna2Panel14)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(92, 0)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(251, 38)
        Me.Panel19.TabIndex = 53
        '
        'lblBusStyle
        '
        Me.lblBusStyle.AutoSize = True
        Me.lblBusStyle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblBusStyle.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblBusStyle.Location = New System.Drawing.Point(0, 0)
        Me.lblBusStyle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBusStyle.Name = "lblBusStyle"
        Me.lblBusStyle.Size = New System.Drawing.Size(53, 17)
        Me.lblBusStyle.TabIndex = 53
        Me.lblBusStyle.Text = "XXXXX"
        '
        'Guna2Panel14
        '
        Me.Guna2Panel14.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel14.BorderThickness = 2
        Me.Guna2Panel14.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel14.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel14.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel14.Name = "Guna2Panel14"
        Me.Guna2Panel14.Size = New System.Drawing.Size(251, 18)
        Me.Guna2Panel14.TabIndex = 59
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label29.Location = New System.Drawing.Point(0, 0)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(92, 17)
        Me.Label29.TabIndex = 52
        Me.Label29.Text = "BUS STYLE:"
        '
        'Panel31
        '
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel31.Location = New System.Drawing.Point(343, 0)
        Me.Panel31.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(13, 38)
        Me.Panel31.TabIndex = 10
        '
        'Panel32
        '
        Me.Panel32.Controls.Add(Me.Label26)
        Me.Panel32.Controls.Add(Me.Panel34)
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel32.Location = New System.Drawing.Point(356, 0)
        Me.Panel32.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(435, 38)
        Me.Panel32.TabIndex = 9
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label26.Location = New System.Drawing.Point(96, 0)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 17)
        Me.Label26.TabIndex = 54
        Me.Label26.Text = "TIN:"
        '
        'Panel34
        '
        Me.Panel34.Controls.Add(Me.lblTIN)
        Me.Panel34.Controls.Add(Me.Guna2Panel15)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel34.Location = New System.Drawing.Point(130, 0)
        Me.Panel34.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(305, 38)
        Me.Panel34.TabIndex = 55
        '
        'lblTIN
        '
        Me.lblTIN.AutoSize = True
        Me.lblTIN.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTIN.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTIN.Location = New System.Drawing.Point(0, 0)
        Me.lblTIN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTIN.Name = "lblTIN"
        Me.lblTIN.Size = New System.Drawing.Size(53, 17)
        Me.lblTIN.TabIndex = 53
        Me.lblTIN.Text = "XXXXX"
        '
        'Guna2Panel15
        '
        Me.Guna2Panel15.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel15.BorderThickness = 2
        Me.Guna2Panel15.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel15.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel15.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel15.Name = "Guna2Panel15"
        Me.Guna2Panel15.Size = New System.Drawing.Size(305, 18)
        Me.Guna2Panel15.TabIndex = 59
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Controls.Add(Me.Panel26)
        Me.Panel23.Controls.Add(Me.Panel27)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(13, 186)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(791, 38)
        Me.Panel23.TabIndex = 14
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.Panel25)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(343, 38)
        Me.Panel24.TabIndex = 11
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.Guna2Panel12)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(343, 38)
        Me.Panel25.TabIndex = 54
        '
        'Guna2Panel12
        '
        Me.Guna2Panel12.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel12.BorderThickness = 2
        Me.Guna2Panel12.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel12.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel12.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel12.Name = "Guna2Panel12"
        Me.Guna2Panel12.Size = New System.Drawing.Size(343, 18)
        Me.Guna2Panel12.TabIndex = 59
        '
        'Panel26
        '
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel26.Location = New System.Drawing.Point(343, 0)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(13, 38)
        Me.Panel26.TabIndex = 10
        '
        'Panel27
        '
        Me.Panel27.Controls.Add(Me.Label21)
        Me.Panel27.Controls.Add(Me.Panel33)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel27.Location = New System.Drawing.Point(356, 0)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(435, 38)
        Me.Panel27.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label21.Location = New System.Drawing.Point(52, 0)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 17)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Salesman:"
        '
        'Panel33
        '
        Me.Panel33.Controls.Add(Me.lblSalesman)
        Me.Panel33.Controls.Add(Me.Guna2Panel13)
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel33.Location = New System.Drawing.Point(130, 0)
        Me.Panel33.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(305, 38)
        Me.Panel33.TabIndex = 55
        '
        'lblSalesman
        '
        Me.lblSalesman.AutoSize = True
        Me.lblSalesman.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblSalesman.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblSalesman.Location = New System.Drawing.Point(0, 0)
        Me.lblSalesman.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalesman.Name = "lblSalesman"
        Me.lblSalesman.Size = New System.Drawing.Size(53, 17)
        Me.lblSalesman.TabIndex = 53
        Me.lblSalesman.Text = "XXXXX"
        '
        'Guna2Panel13
        '
        Me.Guna2Panel13.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel13.BorderThickness = 2
        Me.Guna2Panel13.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel13.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel13.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel13.Name = "Guna2Panel13"
        Me.Guna2Panel13.Size = New System.Drawing.Size(305, 18)
        Me.Guna2Panel13.TabIndex = 59
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Controls.Add(Me.Label18)
        Me.Panel9.Controls.Add(Me.Panel20)
        Me.Panel9.Controls.Add(Me.Panel21)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(13, 148)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(791, 38)
        Me.Panel9.TabIndex = 13
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.lblDelivery)
        Me.Panel14.Controls.Add(Me.Guna2Panel10)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(82, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(261, 38)
        Me.Panel14.TabIndex = 53
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDelivery.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDelivery.Location = New System.Drawing.Point(0, 0)
        Me.lblDelivery.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(53, 17)
        Me.lblDelivery.TabIndex = 53
        Me.lblDelivery.Text = "XXXXX"
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel10.BorderThickness = 2
        Me.Guna2Panel10.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel10.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel10.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.Size = New System.Drawing.Size(261, 18)
        Me.Guna2Panel10.TabIndex = 57
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 17)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "DELIVERY:"
        '
        'Panel20
        '
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel20.Location = New System.Drawing.Point(343, 0)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(13, 38)
        Me.Panel20.TabIndex = 10
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.Label15)
        Me.Panel21.Controls.Add(Me.Panel22)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel21.Location = New System.Drawing.Point(356, 0)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(435, 38)
        Me.Panel21.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(67, 0)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 17)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "TERMS:"
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.lblTerms)
        Me.Panel22.Controls.Add(Me.Guna2Panel11)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel22.Location = New System.Drawing.Point(130, 0)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(305, 38)
        Me.Panel22.TabIndex = 55
        '
        'lblTerms
        '
        Me.lblTerms.AutoSize = True
        Me.lblTerms.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTerms.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTerms.Location = New System.Drawing.Point(0, 0)
        Me.lblTerms.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(53, 17)
        Me.lblTerms.TabIndex = 53
        Me.lblTerms.Text = "XXXXX"
        '
        'Guna2Panel11
        '
        Me.Guna2Panel11.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel11.BorderThickness = 2
        Me.Guna2Panel11.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel11.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel11.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel11.Name = "Guna2Panel11"
        Me.Guna2Panel11.Size = New System.Drawing.Size(305, 18)
        Me.Guna2Panel11.TabIndex = 57
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel12)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(13, 110)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(791, 38)
        Me.Panel7.TabIndex = 12
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel18)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(343, 38)
        Me.Panel8.TabIndex = 11
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.lblAddress)
        Me.Panel18.Controls.Add(Me.Guna2Panel8)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel18.Location = New System.Drawing.Point(146, 0)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(197, 38)
        Me.Panel18.TabIndex = 53
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAddress.Location = New System.Drawing.Point(0, 0)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(53, 17)
        Me.lblAddress.TabIndex = 53
        Me.lblAddress.Text = "XXXXX"
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel8.BorderThickness = 2
        Me.Guna2Panel8.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel8.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel8.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(197, 18)
        Me.Guna2Panel8.TabIndex = 56
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 17)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "ADDRESS/SHIP TO:"
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(343, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(13, 38)
        Me.Panel10.TabIndex = 10
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label9)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(356, 0)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(435, 38)
        Me.Panel12.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(64, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "P.O. NO:"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.lblPONo)
        Me.Panel13.Controls.Add(Me.Guna2Panel9)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel13.Location = New System.Drawing.Point(130, 0)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(305, 38)
        Me.Panel13.TabIndex = 55
        '
        'lblPONo
        '
        Me.lblPONo.AutoSize = True
        Me.lblPONo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPONo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblPONo.Location = New System.Drawing.Point(0, 0)
        Me.lblPONo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPONo.Name = "lblPONo"
        Me.lblPONo.Size = New System.Drawing.Size(53, 17)
        Me.lblPONo.TabIndex = 53
        Me.lblPONo.Text = "XXXXX"
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel9.BorderThickness = 2
        Me.Guna2Panel9.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel9.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel9.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(305, 18)
        Me.Guna2Panel9.TabIndex = 57
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel6)
        Me.Panel11.Controls.Add(Me.Panel5)
        Me.Panel11.Controls.Add(Me.Panel17)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(13, 72)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(791, 38)
        Me.Panel11.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel15)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(343, 38)
        Me.Panel6.TabIndex = 11
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.lblSoldTo)
        Me.Panel15.Controls.Add(Me.Guna2Panel6)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(78, 0)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(265, 38)
        Me.Panel15.TabIndex = 53
        '
        'lblSoldTo
        '
        Me.lblSoldTo.AutoSize = True
        Me.lblSoldTo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblSoldTo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblSoldTo.Location = New System.Drawing.Point(0, 0)
        Me.lblSoldTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSoldTo.Name = "lblSoldTo"
        Me.lblSoldTo.Size = New System.Drawing.Size(53, 17)
        Me.lblSoldTo.TabIndex = 53
        Me.lblSoldTo.Text = "XXXXX"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel6.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel6.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(265, 18)
        Me.Guna2Panel6.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "SOLD TO:"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(343, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(13, 38)
        Me.Panel5.TabIndex = 10
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Label4)
        Me.Panel17.Controls.Add(Me.Panel16)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel17.Location = New System.Drawing.Point(356, 0)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(435, 38)
        Me.Panel17.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(80, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "DATE:"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.lblDate)
        Me.Panel16.Controls.Add(Me.Guna2Panel7)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel16.Location = New System.Drawing.Point(130, 0)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(305, 38)
        Me.Panel16.TabIndex = 55
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDate.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDate.Location = New System.Drawing.Point(0, 0)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 17)
        Me.lblDate.TabIndex = 53
        Me.lblDate.Text = "XXXXX"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel7.BorderThickness = 2
        Me.Guna2Panel7.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel7.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel7.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(305, 18)
        Me.Guna2Panel7.TabIndex = 55
        '
        'Panel40
        '
        Me.Panel40.Controls.Add(Me.Label1)
        Me.Panel40.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel40.Location = New System.Drawing.Point(13, 12)
        Me.Panel40.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(791, 60)
        Me.Panel40.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(525, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SALES INVOICE"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel3.Location = New System.Drawing.Point(13, 714)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(791, 12)
        Me.Guna2Panel3.TabIndex = 6
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel2.Location = New System.Drawing.Point(804, 12)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(13, 714)
        Me.Guna2Panel2.TabIndex = 5
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(13, 714)
        Me.Guna2Panel1.TabIndex = 4
        '
        'pnlHeader
        '
        Me.pnlHeader.CustomBorderColor = System.Drawing.Color.Black
        Me.pnlHeader.CustomBorderThickness = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(817, 12)
        Me.pnlHeader.TabIndex = 3
        '
        'frmPrintSalesInvoiceV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1371, 750)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrintSalesInvoiceV2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        Me.Panel49.ResumeLayout(False)
        Me.Panel49.PerformLayout()
        Me.Panel50.ResumeLayout(False)
        Me.Panel54.ResumeLayout(False)
        Me.Panel42.ResumeLayout(False)
        Me.Panel42.PerformLayout()
        Me.Panel46.ResumeLayout(False)
        Me.Panel46.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Panel43.ResumeLayout(False)
        Me.Panel43.PerformLayout()
        Me.Panel47.ResumeLayout(False)
        Me.Panel47.PerformLayout()
        Me.Panel39.ResumeLayout(False)
        Me.Panel39.PerformLayout()
        Me.Panel30.ResumeLayout(False)
        Me.panelBodyListView.ResumeLayout(False)
        Me.panelBodyCriteria.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Guna2Panel29.ResumeLayout(False)
        Me.Guna2Panel29.PerformLayout()
        Me.Guna2Panel27.ResumeLayout(False)
        Me.Guna2Panel27.PerformLayout()
        Me.Guna2Panel25.ResumeLayout(False)
        Me.Guna2Panel25.PerformLayout()
        Me.Guna2Panel23.ResumeLayout(False)
        Me.Guna2Panel23.PerformLayout()
        Me.Guna2Panel21.ResumeLayout(False)
        Me.Guna2Panel21.PerformLayout()
        Me.Guna2Panel19.ResumeLayout(False)
        Me.Guna2Panel19.PerformLayout()
        Me.Guna2Panel16.ResumeLayout(False)
        Me.Guna2Panel16.PerformLayout()
        Me.Panel28.ResumeLayout(False)
        Me.Panel29.ResumeLayout(False)
        Me.Panel29.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel32.ResumeLayout(False)
        Me.Panel32.PerformLayout()
        Me.Panel34.ResumeLayout(False)
        Me.Panel34.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        Me.Panel27.PerformLayout()
        Me.Panel33.ResumeLayout(False)
        Me.Panel33.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel40.ResumeLayout(False)
        Me.Panel40.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel42 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel41 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelBody As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel49 As Panel
    Friend WithEvents Panel50 As Panel
    Friend WithEvents Guna2Panel39 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label63 As Label
    Friend WithEvents Panel53 As Panel
    Friend WithEvents Panel54 As Panel
    Friend WithEvents Guna2Panel40 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label69 As Label
    Friend WithEvents Panel42 As Panel
    Friend WithEvents Panel46 As Panel
    Friend WithEvents lblApprovedBy As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Panel45 As Panel
    Friend WithEvents Panel43 As Panel
    Friend WithEvents lblCheckedBy As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label As Label
    Friend WithEvents Panel44 As Panel
    Friend WithEvents Panel47 As Panel
    Friend WithEvents lblDRNo As Label
    Friend WithEvents Guna2Panel38 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label56 As Label
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Panel39 As Panel
    Friend WithEvents Label50 As Label
    Friend WithEvents Panel38 As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents panelBodyListView As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Guna2Panel37 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel36 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel35 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel34 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelBodyCriteria As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Label49 As Label
    Friend WithEvents Panel36 As Panel
    Friend WithEvents Panel37 As Panel
    Friend WithEvents Guna2Panel33 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel32 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel31 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel29 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPriceAdjusted As Label
    Friend WithEvents lblAdjustPrice As Label
    Friend WithEvents Guna2Panel30 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel27 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label46 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Guna2Panel28 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel25 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents lblAddVAT As Label
    Friend WithEvents Guna2Panel26 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel23 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label42 As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Guna2Panel24 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel21 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label40 As Label
    Friend WithEvents lblZeroRatedSales As Label
    Friend WithEvents Guna2Panel22 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel19 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label38 As Label
    Friend WithEvents lblVATExempt As Label
    Friend WithEvents Guna2Panel20 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel16 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label35 As Label
    Friend WithEvents lblVATSales As Label
    Friend WithEvents Guna2Panel17 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel18 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents lblBusStyle As Label
    Friend WithEvents Guna2Panel14 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Panel34 As Panel
    Friend WithEvents lblTIN As Label
    Friend WithEvents Guna2Panel15 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Guna2Panel12 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel33 As Panel
    Friend WithEvents lblSalesman As Label
    Friend WithEvents Guna2Panel13 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents lblDelivery As Label
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel22 As Panel
    Friend WithEvents lblTerms As Label
    Friend WithEvents Guna2Panel11 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents lblAddress As Label
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lblPONo As Label
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lblSoldTo As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel40 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
End Class
