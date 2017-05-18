<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.queryDeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.madisonData = New Inventory_System.madisonData()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtReportName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rvReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnStocks = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnLogs = New System.Windows.Forms.Button()
        Me.pnlRecord = New System.Windows.Forms.Panel()
        Me.pnlGreen = New System.Windows.Forms.Panel()
        Me.btnRack = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnBranch = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.pnlDateFromTo = New System.Windows.Forms.Panel()
        Me.pnlCustomRange = New System.Windows.Forms.Panel()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.pnlDftGreen = New System.Windows.Forms.Panel()
        Me.cboViewBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.sales_reportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.queryStocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.supplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.branchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtStateGo = New System.Windows.Forms.TextBox()
        CType(Me.queryDeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.madisonData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlRecord.SuspendLayout()
        Me.pnlDateFromTo.SuspendLayout()
        Me.pnlCustomRange.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.sales_reportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryStocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.supplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.branchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'queryDeliveryBindingSource
        '
        Me.queryDeliveryBindingSource.DataMember = "queryDelivery"
        Me.queryDeliveryBindingSource.DataSource = Me.madisonData
        '
        'madisonData
        '
        Me.madisonData.DataSetName = "madisonData"
        Me.madisonData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 37)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Reports"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.txtStateGo)
        Me.Panel2.Controls.Add(Me.txtReportName)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.ForeColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(17, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 63)
        Me.Panel2.TabIndex = 62
        '
        'txtReportName
        '
        Me.txtReportName.Location = New System.Drawing.Point(188, 17)
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.Size = New System.Drawing.Size(100, 20)
        Me.txtReportName.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.rvReport)
        Me.Panel1.Location = New System.Drawing.Point(17, 194)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1140, 483)
        Me.Panel1.TabIndex = 64
        '
        'rvReport
        '
        Me.rvReport.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "deliveryDataSet"
        ReportDataSource1.Value = Me.queryDeliveryBindingSource
        Me.rvReport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvReport.LocalReport.ReportEmbeddedResource = "Inventory_System.rptDelivery.rdlc"
        Me.rvReport.Location = New System.Drawing.Point(0, 0)
        Me.rvReport.Name = "rvReport"
        Me.rvReport.Size = New System.Drawing.Size(1140, 483)
        Me.rvReport.TabIndex = 0
        '
        'btnDelivery
        '
        Me.btnDelivery.BackColor = System.Drawing.Color.Transparent
        Me.btnDelivery.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivery.ForeColor = System.Drawing.Color.White
        Me.btnDelivery.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelivery.Location = New System.Drawing.Point(220, 10)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(83, 91)
        Me.btnDelivery.TabIndex = 37
        Me.btnDelivery.Text = "Delivery"
        Me.btnDelivery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelivery.UseVisualStyleBackColor = False
        '
        'btnRecord
        '
        Me.btnRecord.BackColor = System.Drawing.Color.Transparent
        Me.btnRecord.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.ForeColor = System.Drawing.Color.White
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRecord.Location = New System.Drawing.Point(46, 10)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(79, 91)
        Me.btnRecord.TabIndex = 38
        Me.btnRecord.Text = "Record"
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRecord.UseVisualStyleBackColor = False
        '
        'btnStocks
        '
        Me.btnStocks.BackColor = System.Drawing.Color.Transparent
        Me.btnStocks.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStocks.ForeColor = System.Drawing.Color.White
        Me.btnStocks.Image = Global.Inventory_System.My.Resources.Resources.ic_stocks
        Me.btnStocks.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStocks.Location = New System.Drawing.Point(130, 10)
        Me.btnStocks.Name = "btnStocks"
        Me.btnStocks.Size = New System.Drawing.Size(83, 91)
        Me.btnStocks.TabIndex = 35
        Me.btnStocks.Text = "Stocks"
        Me.btnStocks.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStocks.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.Transparent
        Me.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSales.Location = New System.Drawing.Point(310, 10)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(83, 91)
        Me.btnSales.TabIndex = 36
        Me.btnSales.Text = "Sales"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnLogs
        '
        Me.btnLogs.BackColor = System.Drawing.Color.Transparent
        Me.btnLogs.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogs.ForeColor = System.Drawing.Color.White
        Me.btnLogs.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogs.Location = New System.Drawing.Point(400, 10)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(83, 91)
        Me.btnLogs.TabIndex = 39
        Me.btnLogs.Text = "Logs"
        Me.btnLogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogs.UseVisualStyleBackColor = False
        '
        'pnlRecord
        '
        Me.pnlRecord.BackColor = System.Drawing.Color.Transparent
        Me.pnlRecord.Controls.Add(Me.pnlGreen)
        Me.pnlRecord.Controls.Add(Me.btnRack)
        Me.pnlRecord.Controls.Add(Me.btnProduct)
        Me.pnlRecord.Controls.Add(Me.btnEmployee)
        Me.pnlRecord.Controls.Add(Me.btnBranch)
        Me.pnlRecord.Controls.Add(Me.btnSupplier)
        Me.pnlRecord.Location = New System.Drawing.Point(35, 0)
        Me.pnlRecord.Name = "pnlRecord"
        Me.pnlRecord.Size = New System.Drawing.Size(0, 107)
        Me.pnlRecord.TabIndex = 1
        '
        'pnlGreen
        '
        Me.pnlGreen.BackColor = System.Drawing.Color.Lime
        Me.pnlGreen.Location = New System.Drawing.Point(0, 0)
        Me.pnlGreen.Name = "pnlGreen"
        Me.pnlGreen.Size = New System.Drawing.Size(1100, 5)
        Me.pnlGreen.TabIndex = 41
        '
        'btnRack
        '
        Me.btnRack.BackColor = System.Drawing.Color.Transparent
        Me.btnRack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRack.ForeColor = System.Drawing.Color.White
        Me.btnRack.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRack.Location = New System.Drawing.Point(462, 10)
        Me.btnRack.Name = "btnRack"
        Me.btnRack.Size = New System.Drawing.Size(86, 91)
        Me.btnRack.TabIndex = 44
        Me.btnRack.Text = "Racks"
        Me.btnRack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRack.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.Transparent
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.Color.White
        Me.btnProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProduct.Location = New System.Drawing.Point(94, 11)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(86, 91)
        Me.btnProduct.TabIndex = 40
        Me.btnProduct.Text = "Products"
        Me.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'btnEmployee
        '
        Me.btnEmployee.BackColor = System.Drawing.Color.Transparent
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.ForeColor = System.Drawing.Color.White
        Me.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmployee.Location = New System.Drawing.Point(370, 10)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(86, 91)
        Me.btnEmployee.TabIndex = 43
        Me.btnEmployee.Text = "Users"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'btnBranch
        '
        Me.btnBranch.BackColor = System.Drawing.Color.Transparent
        Me.btnBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBranch.ForeColor = System.Drawing.Color.White
        Me.btnBranch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBranch.Location = New System.Drawing.Point(186, 10)
        Me.btnBranch.Name = "btnBranch"
        Me.btnBranch.Size = New System.Drawing.Size(86, 91)
        Me.btnBranch.TabIndex = 41
        Me.btnBranch.Text = "Branches"
        Me.btnBranch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBranch.UseVisualStyleBackColor = False
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.Transparent
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.ForeColor = System.Drawing.Color.White
        Me.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSupplier.Location = New System.Drawing.Point(278, 10)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(86, 91)
        Me.btnSupplier.TabIndex = 42
        Me.btnSupplier.Text = "Suppliers"
        Me.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'pnlDateFromTo
        '
        Me.pnlDateFromTo.Controls.Add(Me.pnlCustomRange)
        Me.pnlDateFromTo.Controls.Add(Me.pnlDftGreen)
        Me.pnlDateFromTo.Controls.Add(Me.cboViewBy)
        Me.pnlDateFromTo.Controls.Add(Me.Label1)
        Me.pnlDateFromTo.Location = New System.Drawing.Point(35, 0)
        Me.pnlDateFromTo.Name = "pnlDateFromTo"
        Me.pnlDateFromTo.Size = New System.Drawing.Size(0, 107)
        Me.pnlDateFromTo.TabIndex = 40
        '
        'pnlCustomRange
        '
        Me.pnlCustomRange.Controls.Add(Me.btnGo)
        Me.pnlCustomRange.Controls.Add(Me.dtpFrom)
        Me.pnlCustomRange.Controls.Add(Me.Label2)
        Me.pnlCustomRange.Controls.Add(Me.Label3)
        Me.pnlCustomRange.Controls.Add(Me.dtpTo)
        Me.pnlCustomRange.Location = New System.Drawing.Point(423, 27)
        Me.pnlCustomRange.Name = "pnlCustomRange"
        Me.pnlCustomRange.Size = New System.Drawing.Size(415, 34)
        Me.pnlCustomRange.TabIndex = 43
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.Lime
        Me.btnGo.FlatAppearance.BorderSize = 0
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.Color.Black
        Me.btnGo.Location = New System.Drawing.Point(341, 0)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(38, 34)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'dtpFrom
        '
        Me.dtpFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(60, 3)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(118, 26)
        Me.dtpFrom.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(183, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To"
        '
        'dtpTo
        '
        Me.dtpTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(218, 3)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(117, 26)
        Me.dtpTo.TabIndex = 5
        '
        'pnlDftGreen
        '
        Me.pnlDftGreen.BackColor = System.Drawing.Color.Lime
        Me.pnlDftGreen.Location = New System.Drawing.Point(0, 0)
        Me.pnlDftGreen.Name = "pnlDftGreen"
        Me.pnlDftGreen.Size = New System.Drawing.Size(1100, 5)
        Me.pnlDftGreen.TabIndex = 42
        '
        'cboViewBy
        '
        Me.cboViewBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboViewBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboViewBy.FormattingEnabled = True
        Me.cboViewBy.Items.AddRange(New Object() {"This Month-to-date", "Last Month", "Last 6 Months", "Custom Range"})
        Me.cboViewBy.Location = New System.Drawing.Point(165, 27)
        Me.cboViewBy.Name = "cboViewBy"
        Me.cboViewBy.Size = New System.Drawing.Size(235, 32)
        Me.cboViewBy.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dates"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.pnlDateFromTo)
        Me.Panel3.Controls.Add(Me.pnlRecord)
        Me.Panel3.Controls.Add(Me.btnLogs)
        Me.Panel3.Controls.Add(Me.btnSales)
        Me.Panel3.Controls.Add(Me.btnStocks)
        Me.Panel3.Controls.Add(Me.btnRecord)
        Me.Panel3.Controls.Add(Me.btnDelivery)
        Me.Panel3.ForeColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(17, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1140, 107)
        Me.Panel3.TabIndex = 63
        '
        'sales_reportBindingSource
        '
        Me.sales_reportBindingSource.DataMember = "sales_report"
        Me.sales_reportBindingSource.DataSource = Me.madisonData
        '
        'queryStocksBindingSource
        '
        Me.queryStocksBindingSource.DataMember = "queryStocks"
        Me.queryStocksBindingSource.DataSource = Me.madisonData
        '
        'rackBindingSource
        '
        Me.rackBindingSource.DataMember = "rack"
        Me.rackBindingSource.DataSource = Me.madisonData
        '
        'employeeBindingSource
        '
        Me.employeeBindingSource.DataMember = "employee"
        Me.employeeBindingSource.DataSource = Me.madisonData
        '
        'supplierBindingSource
        '
        Me.supplierBindingSource.DataMember = "supplier"
        Me.supplierBindingSource.DataSource = Me.madisonData
        '
        'productBindingSource
        '
        Me.productBindingSource.DataMember = "product"
        Me.productBindingSource.DataSource = Me.madisonData
        '
        'branchBindingSource
        '
        Me.branchBindingSource.DataMember = "branch"
        Me.branchBindingSource.DataSource = Me.madisonData
        '
        'txtStateGo
        '
        Me.txtStateGo.Location = New System.Drawing.Point(299, 17)
        Me.txtStateGo.Name = "txtStateGo"
        Me.txtStateGo.Size = New System.Drawing.Size(100, 20)
        Me.txtStateGo.TabIndex = 36
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        CType(Me.queryDeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.madisonData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlRecord.ResumeLayout(False)
        Me.pnlDateFromTo.ResumeLayout(False)
        Me.pnlDateFromTo.PerformLayout()
        Me.pnlCustomRange.ResumeLayout(False)
        Me.pnlCustomRange.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.sales_reportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryStocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.supplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.branchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents productBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents madisonData As Inventory_System.madisonData
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rvReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents branchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents supplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents employeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rackBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtReportName As System.Windows.Forms.TextBox
    Friend WithEvents queryStocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnDelivery As System.Windows.Forms.Button
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents btnStocks As System.Windows.Forms.Button
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnLogs As System.Windows.Forms.Button
    Friend WithEvents pnlRecord As System.Windows.Forms.Panel
    Friend WithEvents pnlGreen As System.Windows.Forms.Panel
    Friend WithEvents btnRack As System.Windows.Forms.Button
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnBranch As System.Windows.Forms.Button
    Friend WithEvents btnSupplier As System.Windows.Forms.Button
    Friend WithEvents pnlDateFromTo As System.Windows.Forms.Panel
    Friend WithEvents pnlCustomRange As System.Windows.Forms.Panel
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlDftGreen As System.Windows.Forms.Panel
    Friend WithEvents cboViewBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents sales_reportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents queryDeliveryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtStateGo As System.Windows.Forms.TextBox
End Class
