<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryAdjustment
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAdjustment = New System.Windows.Forms.DataGridView()
        Me.btnSearchProd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtSearchAdjustment = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtProdId = New System.Windows.Forms.TextBox()
        Me.txtAdjustmentId = New System.Windows.Forms.TextBox()
        Me.btnCancelDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbImage = New System.Windows.Forms.GroupBox()
        Me.pnlImageNav = New System.Windows.Forms.Panel()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.picProductImage = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProductClass = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbRack = New System.Windows.Forms.ComboBox()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlProductData = New System.Windows.Forms.Panel()
        Me.pnlGridView = New System.Windows.Forms.Panel()
        Me.ilProductAlbum = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbComplete = New System.Windows.Forms.RadioButton()
        Me.rdbPending = New System.Windows.Forms.RadioButton()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.memo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvAdjustment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbImage.SuspendLayout()
        Me.pnlImageNav.SuspendLayout()
        CType(Me.picProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.pnlProductData.SuspendLayout()
        Me.pnlGridView.SuspendLayout()
        Me.pnlData.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAdjustment
        '
        Me.dgvAdjustment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdjustment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.barcode, Me.reason, Me.prod_name, Me.quantity, Me.unit_cost, Me.total_cost, Me.status, Me.memo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdjustment.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAdjustment.Location = New System.Drawing.Point(17, 46)
        Me.dgvAdjustment.Name = "dgvAdjustment"
        Me.dgvAdjustment.ReadOnly = True
        Me.dgvAdjustment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdjustment.Size = New System.Drawing.Size(1147, 224)
        Me.dgvAdjustment.StandardTab = True
        Me.dgvAdjustment.TabIndex = 0
        '
        'btnSearchProd
        '
        Me.btnSearchProd.BackColor = System.Drawing.Color.Blue
        Me.btnSearchProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchProd.ForeColor = System.Drawing.Color.White
        Me.btnSearchProd.Image = Global.Inventory_System.My.Resources.Resources.cart_search
        Me.btnSearchProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchProd.Location = New System.Drawing.Point(508, 9)
        Me.btnSearchProd.Name = "btnSearchProd"
        Me.btnSearchProd.Size = New System.Drawing.Size(125, 44)
        Me.btnSearchProd.TabIndex = 1
        Me.btnSearchProd.Text = "Search"
        Me.btnSearchProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchProd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Code"
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Black
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.ForeColor = System.Drawing.Color.Lime
        Me.txtBarcode.Location = New System.Drawing.Point(196, 12)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(299, 38)
        Me.txtBarcode.TabIndex = 3
        '
        'txtSearchAdjustment
        '
        Me.txtSearchAdjustment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAdjustment.Location = New System.Drawing.Point(148, 9)
        Me.txtSearchAdjustment.Name = "txtSearchAdjustment"
        Me.txtSearchAdjustment.Size = New System.Drawing.Size(264, 31)
        Me.txtSearchAdjustment.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Search"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.txtProdId)
        Me.Panel1.Controls.Add(Me.txtAdjustmentId)
        Me.Panel1.Controls.Add(Me.btnCancelDelete)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSearchProd)
        Me.Panel1.Controls.Add(Me.txtBarcode)
        Me.Panel1.Location = New System.Drawing.Point(7, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1180, 64)
        Me.Panel1.TabIndex = 13
        '
        'txtProdId
        '
        Me.txtProdId.Location = New System.Drawing.Point(670, 38)
        Me.txtProdId.Name = "txtProdId"
        Me.txtProdId.Size = New System.Drawing.Size(53, 20)
        Me.txtProdId.TabIndex = 17
        Me.txtProdId.Visible = False
        '
        'txtAdjustmentId
        '
        Me.txtAdjustmentId.Location = New System.Drawing.Point(670, 12)
        Me.txtAdjustmentId.Name = "txtAdjustmentId"
        Me.txtAdjustmentId.Size = New System.Drawing.Size(53, 20)
        Me.txtAdjustmentId.TabIndex = 16
        Me.txtAdjustmentId.Text = "adj id"
        Me.txtAdjustmentId.Visible = False
        '
        'btnCancelDelete
        '
        Me.btnCancelDelete.BackColor = System.Drawing.Color.Coral
        Me.btnCancelDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDelete.ForeColor = System.Drawing.Color.White
        Me.btnCancelDelete.Image = Global.Inventory_System.My.Resources.Resources.cart_cancel
        Me.btnCancelDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelDelete.Location = New System.Drawing.Point(1023, 9)
        Me.btnCancelDelete.Name = "btnCancelDelete"
        Me.btnCancelDelete.Size = New System.Drawing.Size(130, 46)
        Me.btnCancelDelete.TabIndex = 15
        Me.btnCancelDelete.Text = "Delete"
        Me.btnCancelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.Inventory_System.My.Resources.Resources.cart_check
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(878, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(138, 46)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'gbImage
        '
        Me.gbImage.BackColor = System.Drawing.Color.DimGray
        Me.gbImage.Controls.Add(Me.pnlImageNav)
        Me.gbImage.Controls.Add(Me.picProductImage)
        Me.gbImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbImage.ForeColor = System.Drawing.Color.White
        Me.gbImage.Location = New System.Drawing.Point(8, 7)
        Me.gbImage.Name = "gbImage"
        Me.gbImage.Size = New System.Drawing.Size(335, 315)
        Me.gbImage.TabIndex = 53
        Me.gbImage.TabStop = False
        Me.gbImage.Text = "Product Image"
        '
        'pnlImageNav
        '
        Me.pnlImageNav.Controls.Add(Me.btnFirst)
        Me.pnlImageNav.Controls.Add(Me.btnPrevious)
        Me.pnlImageNav.Controls.Add(Me.lblStat)
        Me.pnlImageNav.Controls.Add(Me.btnNext)
        Me.pnlImageNav.Controls.Add(Me.btnLast)
        Me.pnlImageNav.Location = New System.Drawing.Point(7, 263)
        Me.pnlImageNav.Name = "pnlImageNav"
        Me.pnlImageNav.Size = New System.Drawing.Size(321, 49)
        Me.pnlImageNav.TabIndex = 66
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Image = Global.Inventory_System.My.Resources.Resources._001_rewind
        Me.btnFirst.Location = New System.Drawing.Point(5, 4)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(51, 40)
        Me.btnFirst.TabIndex = 1
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Image = Global.Inventory_System.My.Resources.Resources.previous
        Me.btnPrevious.Location = New System.Drawing.Point(60, 4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(51, 40)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'lblStat
        '
        Me.lblStat.AutoSize = True
        Me.lblStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStat.Location = New System.Drawing.Point(118, 17)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(83, 16)
        Me.lblStat.TabIndex = 5
        Me.lblStat.Text = "No Images"
        Me.lblStat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Image = Global.Inventory_System.My.Resources.Resources.skip__1_
        Me.btnNext.Location = New System.Drawing.Point(208, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(51, 40)
        Me.btnNext.TabIndex = 3
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Image = Global.Inventory_System.My.Resources.Resources._002_fast_forward
        Me.btnLast.Location = New System.Drawing.Point(264, 4)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(51, 40)
        Me.btnLast.TabIndex = 4
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'picProductImage
        '
        Me.picProductImage.BackColor = System.Drawing.Color.White
        Me.picProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProductImage.Image = Global.Inventory_System.My.Resources.Resources.noImage
        Me.picProductImage.InitialImage = Global.Inventory_System.My.Resources.Resources.noImage
        Me.picProductImage.Location = New System.Drawing.Point(6, 25)
        Me.picProductImage.Name = "picProductImage"
        Me.picProductImage.Size = New System.Drawing.Size(320, 240)
        Me.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProductImage.TabIndex = 0
        Me.picProductImage.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtProductClass)
        Me.GroupBox2.Controls.Add(Me.txtProductName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtProductDescription)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(349, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 205)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Info"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(307, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Class"
        '
        'txtProductClass
        '
        Me.txtProductClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductClass.Location = New System.Drawing.Point(311, 53)
        Me.txtProductClass.Multiline = True
        Me.txtProductClass.Name = "txtProductClass"
        Me.txtProductClass.ReadOnly = True
        Me.txtProductClass.Size = New System.Drawing.Size(110, 35)
        Me.txtProductClass.TabIndex = 58
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(10, 53)
        Me.txtProductName.Multiline = True
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(282, 35)
        Me.txtProductName.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 20)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Description"
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDescription.Location = New System.Drawing.Point(10, 124)
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.ReadOnly = True
        Me.txtProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProductDescription.Size = New System.Drawing.Size(411, 67)
        Me.txtProductDescription.TabIndex = 60
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.cmbRack)
        Me.GroupBox5.Controls.Add(Me.cmbLevel)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(348, 218)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(434, 104)
        Me.GroupBox5.TabIndex = 68
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Product Location"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Rack"
        '
        'cmbRack
        '
        Me.cmbRack.BackColor = System.Drawing.SystemColors.Control
        Me.cmbRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbRack.FormattingEnabled = True
        Me.cmbRack.Location = New System.Drawing.Point(11, 50)
        Me.cmbRack.Name = "cmbRack"
        Me.cmbRack.Size = New System.Drawing.Size(189, 32)
        Me.cmbRack.TabIndex = 65
        '
        'cmbLevel
        '
        Me.cmbLevel.BackColor = System.Drawing.SystemColors.Control
        Me.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Location = New System.Drawing.Point(233, 50)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(189, 32)
        Me.cmbLevel.TabIndex = 67
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(229, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 20)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Level"
        '
        'pnlProductData
        '
        Me.pnlProductData.BackColor = System.Drawing.Color.DimGray
        Me.pnlProductData.Controls.Add(Me.gbImage)
        Me.pnlProductData.Controls.Add(Me.GroupBox5)
        Me.pnlProductData.Controls.Add(Me.GroupBox2)
        Me.pnlProductData.Location = New System.Drawing.Point(7, 75)
        Me.pnlProductData.Name = "pnlProductData"
        Me.pnlProductData.Size = New System.Drawing.Size(789, 333)
        Me.pnlProductData.TabIndex = 70
        '
        'pnlGridView
        '
        Me.pnlGridView.BackColor = System.Drawing.Color.DimGray
        Me.pnlGridView.Controls.Add(Me.Label5)
        Me.pnlGridView.Controls.Add(Me.txtSearchAdjustment)
        Me.pnlGridView.Controls.Add(Me.dgvAdjustment)
        Me.pnlGridView.Location = New System.Drawing.Point(7, 414)
        Me.pnlGridView.Name = "pnlGridView"
        Me.pnlGridView.Size = New System.Drawing.Size(1180, 276)
        Me.pnlGridView.TabIndex = 73
        '
        'ilProductAlbum
        '
        Me.ilProductAlbum.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ilProductAlbum.ImageSize = New System.Drawing.Size(256, 200)
        Me.ilProductAlbum.TransparentColor = System.Drawing.Color.Transparent
        '
        'pnlData
        '
        Me.pnlData.BackColor = System.Drawing.Color.DimGray
        Me.pnlData.Controls.Add(Me.GroupBox4)
        Me.pnlData.Controls.Add(Me.GroupBox3)
        Me.pnlData.Controls.Add(Me.GroupBox1)
        Me.pnlData.Location = New System.Drawing.Point(791, 75)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(396, 333)
        Me.pnlData.TabIndex = 71
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtTotal)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtUnitCost)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtQuantity)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(387, 100)
        Me.GroupBox4.TabIndex = 73
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Amounts"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(276, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(280, 54)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(99, 29)
        Me.txtTotal.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(145, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Unit Cost"
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitCost.Location = New System.Drawing.Point(149, 54)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(99, 29)
        Me.txtUnitCost.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(11, 54)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(99, 29)
        Me.txtQuantity.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtReason)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtMemo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(3, 113)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(387, 131)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Adjustment Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Reason"
        '
        'txtReason
        '
        Me.txtReason.BackColor = System.Drawing.Color.White
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(11, 52)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(178, 67)
        Me.txtReason.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(197, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Memo"
        '
        'txtMemo
        '
        Me.txtMemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemo.Location = New System.Drawing.Point(201, 52)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(178, 67)
        Me.txtMemo.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbComplete)
        Me.GroupBox1.Controls.Add(Me.rdbPending)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 67)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'rdbComplete
        '
        Me.rdbComplete.AutoSize = True
        Me.rdbComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbComplete.Location = New System.Drawing.Point(173, 28)
        Me.rdbComplete.Name = "rdbComplete"
        Me.rdbComplete.Size = New System.Drawing.Size(103, 24)
        Me.rdbComplete.TabIndex = 1
        Me.rdbComplete.TabStop = True
        Me.rdbComplete.Text = "Complete"
        Me.rdbComplete.UseVisualStyleBackColor = True
        '
        'rdbPending
        '
        Me.rdbPending.AutoSize = True
        Me.rdbPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPending.Location = New System.Drawing.Point(49, 28)
        Me.rdbPending.Name = "rdbPending"
        Me.rdbPending.Size = New System.Drawing.Size(92, 24)
        Me.rdbPending.TabIndex = 0
        Me.rdbPending.TabStop = True
        Me.rdbPending.Text = "Pending"
        Me.rdbPending.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'barcode
        '
        Me.barcode.DataPropertyName = "barcode"
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        '
        'reason
        '
        Me.reason.DataPropertyName = "reason"
        Me.reason.HeaderText = "Reason"
        Me.reason.Name = "reason"
        Me.reason.ReadOnly = True
        Me.reason.Width = 200
        '
        'prod_name
        '
        Me.prod_name.DataPropertyName = "prod_name"
        Me.prod_name.HeaderText = "Item Name"
        Me.prod_name.Name = "prod_name"
        Me.prod_name.ReadOnly = True
        Me.prod_name.Width = 200
        '
        'quantity
        '
        Me.quantity.DataPropertyName = "quantity"
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'unit_cost
        '
        Me.unit_cost.DataPropertyName = "unit_cost"
        Me.unit_cost.HeaderText = "Unit_Cost"
        Me.unit_cost.Name = "unit_cost"
        Me.unit_cost.ReadOnly = True
        '
        'total_cost
        '
        Me.total_cost.DataPropertyName = "total_cost"
        Me.total_cost.HeaderText = "Total"
        Me.total_cost.Name = "total_cost"
        Me.total_cost.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'memo
        '
        Me.memo.DataPropertyName = "memo"
        Me.memo.HeaderText = "Memo"
        Me.memo.Name = "memo"
        Me.memo.ReadOnly = True
        Me.memo.Width = 300
        '
        'frmInventoryAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 696)
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.pnlGridView)
        Me.Controls.Add(Me.pnlProductData)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInventoryAdjustment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Adjustment"
        Me.TopMost = True
        CType(Me.dgvAdjustment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbImage.ResumeLayout(False)
        Me.pnlImageNav.ResumeLayout(False)
        Me.pnlImageNav.PerformLayout()
        CType(Me.picProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.pnlProductData.ResumeLayout(False)
        Me.pnlGridView.ResumeLayout(False)
        Me.pnlGridView.PerformLayout()
        Me.pnlData.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAdjustment As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearchProd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbImage As System.Windows.Forms.GroupBox
    Friend WithEvents picProductImage As System.Windows.Forms.PictureBox
    Friend WithEvents pnlImageNav As System.Windows.Forms.Panel
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents lblStat As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtProductClass As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbRack As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pnlProductData As System.Windows.Forms.Panel
    Friend WithEvents pnlGridView As System.Windows.Forms.Panel
    Friend WithEvents txtAdjustmentId As System.Windows.Forms.TextBox
    Friend WithEvents txtProdId As System.Windows.Forms.TextBox
    Friend WithEvents ilProductAlbum As System.Windows.Forms.ImageList
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMemo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbComplete As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPending As System.Windows.Forms.RadioButton
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reason As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents memo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
