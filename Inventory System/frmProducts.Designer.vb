<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.txtProductQuantity = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbImage = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.picProductImage = New System.Windows.Forms.PictureBox()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_class = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlProductData = New System.Windows.Forms.Panel()
        Me.btnMoreDetails = New System.Windows.Forms.Button()
        Me.gbWarehouse = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbLocation = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbAmounts = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCriticalStock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.txtProductClass = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.pnlProductGrid = New System.Windows.Forms.Panel()
        Me.lblInventoryAdjustment = New System.Windows.Forms.Label()
        Me.ofdProductImage = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.fbdProductImages = New System.Windows.Forms.FolderBrowserDialog()
        Me.ilProductAlbum = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlImageNav = New System.Windows.Forms.Panel()
        Me.gbImage.SuspendLayout()
        CType(Me.picProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlProductData.SuspendLayout()
        Me.gbWarehouse.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gbAmounts.SuspendLayout()
        Me.gbDetails.SuspendLayout()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProductGrid.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlImageNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDescription.Location = New System.Drawing.Point(9, 105)
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProductDescription.Size = New System.Drawing.Size(414, 60)
        Me.txtProductDescription.TabIndex = 60
        '
        'txtProductQuantity
        '
        Me.txtProductQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductQuantity.Location = New System.Drawing.Point(20, 46)
        Me.txtProductQuantity.Name = "txtProductQuantity"
        Me.txtProductQuantity.ReadOnly = True
        Me.txtProductQuantity.Size = New System.Drawing.Size(89, 29)
        Me.txtProductQuantity.TabIndex = 59
        Me.txtProductQuantity.Text = "0"
        Me.txtProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(12, 47)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(307, 29)
        Me.txtProductName.TabIndex = 58
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Black
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.ForeColor = System.Drawing.Color.Lime
        Me.txtBarcode.Location = New System.Drawing.Point(133, 11)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(252, 44)
        Me.txtBarcode.TabIndex = 57
        Me.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Description :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Quantity :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 20)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Product Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 37)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Code :"
        '
        'gbImage
        '
        Me.gbImage.BackColor = System.Drawing.Color.DimGray
        Me.gbImage.Controls.Add(Me.btnRemove)
        Me.gbImage.Controls.Add(Me.btnBrowse)
        Me.gbImage.Controls.Add(Me.picProductImage)
        Me.gbImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbImage.ForeColor = System.Drawing.Color.White
        Me.gbImage.Location = New System.Drawing.Point(742, 3)
        Me.gbImage.Name = "gbImage"
        Me.gbImage.Size = New System.Drawing.Size(375, 324)
        Me.gbImage.TabIndex = 52
        Me.gbImage.TabStop = False
        Me.gbImage.Text = "Product Image"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Image = Global.Inventory_System.My.Resources.Resources.remove
        Me.btnRemove.Location = New System.Drawing.Point(330, 77)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(40, 40)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Image = Global.Inventory_System.My.Resources.Resources.folder
        Me.btnBrowse.Location = New System.Drawing.Point(330, 31)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(40, 40)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Search Product :"
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProduct.Location = New System.Drawing.Point(202, 6)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(326, 31)
        Me.txtSearchProduct.TabIndex = 50
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Coral
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.Inventory_System.My.Resources.Resources.cart_cancel
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(881, 11)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 47)
        Me.btnDelete.TabIndex = 48
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddProduct.Image = Global.Inventory_System.My.Resources.Resources.cart_add
        Me.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddProduct.Location = New System.Drawing.Point(747, 11)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(125, 47)
        Me.btnAddProduct.TabIndex = 47
        Me.btnAddProduct.Text = "New"
        Me.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.barcode, Me.prod_name, Me.prod_desc, Me.prod_qty, Me.prod_price, Me.prod_class})
        Me.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProducts.Location = New System.Drawing.Point(18, 45)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowTemplate.Height = 20
        Me.dgvProducts.Size = New System.Drawing.Size(1098, 239)
        Me.dgvProducts.TabIndex = 46
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'barcode
        '
        Me.barcode.DataPropertyName = "barcode"
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        Me.barcode.Width = 150
        '
        'prod_name
        '
        Me.prod_name.DataPropertyName = "prod_name"
        Me.prod_name.HeaderText = "Product Name"
        Me.prod_name.Name = "prod_name"
        Me.prod_name.ReadOnly = True
        Me.prod_name.Width = 300
        '
        'prod_desc
        '
        Me.prod_desc.DataPropertyName = "prod_desc"
        Me.prod_desc.HeaderText = "Description"
        Me.prod_desc.Name = "prod_desc"
        Me.prod_desc.ReadOnly = True
        Me.prod_desc.Width = 400
        '
        'prod_qty
        '
        Me.prod_qty.DataPropertyName = "prod_qty"
        Me.prod_qty.HeaderText = "Quantity"
        Me.prod_qty.Name = "prod_qty"
        Me.prod_qty.ReadOnly = True
        '
        'prod_price
        '
        Me.prod_price.DataPropertyName = "prod_price"
        Me.prod_price.HeaderText = "Price"
        Me.prod_price.Name = "prod_price"
        Me.prod_price.ReadOnly = True
        Me.prod_price.Width = 130
        '
        'prod_class
        '
        Me.prod_class.DataPropertyName = "prod_class"
        Me.prod_class.HeaderText = "Class"
        Me.prod_class.Name = "prod_class"
        Me.prod_class.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.txtId)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnAddProduct)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.ForeColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(17, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 64)
        Me.Panel2.TabIndex = 61
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(251, 18)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(152, 29)
        Me.txtId.TabIndex = 67
        Me.txtId.Visible = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Global.Inventory_System.My.Resources.Resources.close_icon
        Me.btnClose.Location = New System.Drawing.Point(1065, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(47, 47)
        Me.btnClose.TabIndex = 66
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(13, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(977, 73)
        Me.Panel1.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(38, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 37)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Products"
        '
        'pnlProductData
        '
        Me.pnlProductData.BackColor = System.Drawing.Color.DimGray
        Me.pnlProductData.Controls.Add(Me.btnMoreDetails)
        Me.pnlProductData.Controls.Add(Me.gbWarehouse)
        Me.pnlProductData.Controls.Add(Me.gbImage)
        Me.pnlProductData.Controls.Add(Me.gbAmounts)
        Me.pnlProductData.Controls.Add(Me.gbDetails)
        Me.pnlProductData.Location = New System.Drawing.Point(16, 82)
        Me.pnlProductData.Name = "pnlProductData"
        Me.pnlProductData.Size = New System.Drawing.Size(1141, 331)
        Me.pnlProductData.TabIndex = 62
        '
        'btnMoreDetails
        '
        Me.btnMoreDetails.BackColor = System.Drawing.Color.White
        Me.btnMoreDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoreDetails.FlatAppearance.BorderSize = 0
        Me.btnMoreDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoreDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoreDetails.ForeColor = System.Drawing.Color.Blue
        Me.btnMoreDetails.Location = New System.Drawing.Point(609, 293)
        Me.btnMoreDetails.Name = "btnMoreDetails"
        Me.btnMoreDetails.Size = New System.Drawing.Size(95, 32)
        Me.btnMoreDetails.TabIndex = 61
        Me.btnMoreDetails.Text = "More Details"
        Me.btnMoreDetails.UseVisualStyleBackColor = False
        '
        'gbWarehouse
        '
        Me.gbWarehouse.Controls.Add(Me.Panel4)
        Me.gbWarehouse.Controls.Add(Me.Label10)
        Me.gbWarehouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbWarehouse.ForeColor = System.Drawing.Color.White
        Me.gbWarehouse.Location = New System.Drawing.Point(466, 62)
        Me.gbWarehouse.Name = "gbWarehouse"
        Me.gbWarehouse.Size = New System.Drawing.Size(270, 222)
        Me.gbWarehouse.TabIndex = 66
        Me.gbWarehouse.TabStop = False
        Me.gbWarehouse.Text = "Location"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.lbLocation)
        Me.Panel4.Location = New System.Drawing.Point(5, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(259, 189)
        Me.Panel4.TabIndex = 68
        '
        'lbLocation
        '
        Me.lbLocation.BackColor = System.Drawing.Color.Gainsboro
        Me.lbLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbLocation.ForeColor = System.Drawing.Color.Black
        Me.lbLocation.FormattingEnabled = True
        Me.lbLocation.ItemHeight = 20
        Me.lbLocation.Location = New System.Drawing.Point(10, 4)
        Me.lbLocation.Margin = New System.Windows.Forms.Padding(20)
        Me.lbLocation.Name = "lbLocation"
        Me.lbLocation.Size = New System.Drawing.Size(238, 180)
        Me.lbLocation.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 20)
        Me.Label10.TabIndex = 66
        '
        'gbAmounts
        '
        Me.gbAmounts.Controls.Add(Me.Label9)
        Me.gbAmounts.Controls.Add(Me.txtCriticalStock)
        Me.gbAmounts.Controls.Add(Me.Label8)
        Me.gbAmounts.Controls.Add(Me.Label5)
        Me.gbAmounts.Controls.Add(Me.txtProductQuantity)
        Me.gbAmounts.Controls.Add(Me.txtProductPrice)
        Me.gbAmounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAmounts.ForeColor = System.Drawing.Color.White
        Me.gbAmounts.Location = New System.Drawing.Point(19, 235)
        Me.gbAmounts.Name = "gbAmounts"
        Me.gbAmounts.Size = New System.Drawing.Size(440, 86)
        Me.gbAmounts.TabIndex = 64
        Me.gbAmounts.TabStop = False
        Me.gbAmounts.Text = "Amounts"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(144, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 20)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Critical Stock :"
        '
        'txtCriticalStock
        '
        Me.txtCriticalStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriticalStock.Location = New System.Drawing.Point(148, 45)
        Me.txtCriticalStock.Name = "txtCriticalStock"
        Me.txtCriticalStock.Size = New System.Drawing.Size(121, 29)
        Me.txtCriticalStock.TabIndex = 66
        Me.txtCriticalStock.Text = "0"
        Me.txtCriticalStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(307, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Price :"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductPrice.Location = New System.Drawing.Point(311, 45)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(104, 29)
        Me.txtProductPrice.TabIndex = 64
        Me.txtProductPrice.Text = "0"
        Me.txtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbDetails
        '
        Me.gbDetails.Controls.Add(Me.txtProductClass)
        Me.gbDetails.Controls.Add(Me.Label12)
        Me.gbDetails.Controls.Add(Me.txtProductName)
        Me.gbDetails.Controls.Add(Me.Label4)
        Me.gbDetails.Controls.Add(Me.Label6)
        Me.gbDetails.Controls.Add(Me.txtProductDescription)
        Me.gbDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDetails.ForeColor = System.Drawing.Color.White
        Me.gbDetails.Location = New System.Drawing.Point(19, 63)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(441, 171)
        Me.gbDetails.TabIndex = 63
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "Details"
        '
        'txtProductClass
        '
        Me.txtProductClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductClass.Location = New System.Drawing.Point(337, 45)
        Me.txtProductClass.Name = "txtProductClass"
        Me.txtProductClass.Size = New System.Drawing.Size(86, 29)
        Me.txtProductClass.TabIndex = 67
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(333, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 20)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Class :"
        '
        'picBarcode
        '
        Me.picBarcode.BackColor = System.Drawing.Color.Transparent
        Me.picBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBarcode.Image = Global.Inventory_System.My.Resources.Resources.noImage
        Me.picBarcode.InitialImage = Global.Inventory_System.My.Resources.Resources.noImage
        Me.picBarcode.Location = New System.Drawing.Point(405, 3)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(216, 55)
        Me.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBarcode.TabIndex = 1
        Me.picBarcode.TabStop = False
        '
        'pnlProductGrid
        '
        Me.pnlProductGrid.BackColor = System.Drawing.Color.DimGray
        Me.pnlProductGrid.Controls.Add(Me.lblInventoryAdjustment)
        Me.pnlProductGrid.Controls.Add(Me.Label1)
        Me.pnlProductGrid.Controls.Add(Me.dgvProducts)
        Me.pnlProductGrid.Controls.Add(Me.txtSearchProduct)
        Me.pnlProductGrid.Location = New System.Drawing.Point(17, 419)
        Me.pnlProductGrid.Name = "pnlProductGrid"
        Me.pnlProductGrid.Size = New System.Drawing.Size(1140, 296)
        Me.pnlProductGrid.TabIndex = 63
        '
        'lblInventoryAdjustment
        '
        Me.lblInventoryAdjustment.AutoSize = True
        Me.lblInventoryAdjustment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInventoryAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInventoryAdjustment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventoryAdjustment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInventoryAdjustment.Location = New System.Drawing.Point(859, 10)
        Me.lblInventoryAdjustment.Name = "lblInventoryAdjustment"
        Me.lblInventoryAdjustment.Size = New System.Drawing.Size(257, 24)
        Me.lblInventoryAdjustment.TabIndex = 52
        Me.lblInventoryAdjustment.Text = "View Inventory Adjustment"
        '
        'ofdProductImage
        '
        Me.ofdProductImage.Multiselect = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtBarcode)
        Me.Panel3.Controls.Add(Me.picBarcode)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(20, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(705, 62)
        Me.Panel3.TabIndex = 64
        '
        'ilProductAlbum
        '
        Me.ilProductAlbum.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ilProductAlbum.ImageSize = New System.Drawing.Size(256, 200)
        Me.ilProductAlbum.TransparentColor = System.Drawing.Color.Transparent
        '
        'pnlImageNav
        '
        Me.pnlImageNav.Controls.Add(Me.btnFirst)
        Me.pnlImageNav.Controls.Add(Me.btnPrevious)
        Me.pnlImageNav.Controls.Add(Me.lblStat)
        Me.pnlImageNav.Controls.Add(Me.btnNext)
        Me.pnlImageNav.Controls.Add(Me.btnLast)
        Me.pnlImageNav.Location = New System.Drawing.Point(765, 354)
        Me.pnlImageNav.Name = "pnlImageNav"
        Me.pnlImageNav.Size = New System.Drawing.Size(321, 49)
        Me.pnlImageNav.TabIndex = 65
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1282, 727)
        Me.Controls.Add(Me.pnlImageNav)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlProductGrid)
        Me.Controls.Add(Me.pnlProductData)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProducts"
        Me.Text = "frmProducts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbImage.ResumeLayout(False)
        CType(Me.picProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlProductData.ResumeLayout(False)
        Me.gbWarehouse.ResumeLayout(False)
        Me.gbWarehouse.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.gbAmounts.ResumeLayout(False)
        Me.gbAmounts.PerformLayout()
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProductGrid.ResumeLayout(False)
        Me.pnlProductGrid.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlImageNav.ResumeLayout(False)
        Me.pnlImageNav.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtProductQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbImage As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchProduct As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnlProductData As System.Windows.Forms.Panel
    Friend WithEvents pnlProductGrid As System.Windows.Forms.Panel
    Friend WithEvents gbAmounts As System.Windows.Forms.GroupBox
    Friend WithEvents gbDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProductPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnMoreDetails As System.Windows.Forms.Button
    Friend WithEvents gbWarehouse As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtProductClass As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents picBarcode As System.Windows.Forms.PictureBox
    Friend WithEvents ofdProductImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents picProductImage As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCriticalStock As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents lblStat As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents fbdProductImages As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ilProductAlbum As System.Windows.Forms.ImageList
    Friend WithEvents pnlImageNav As System.Windows.Forms.Panel
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_class As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbLocation As System.Windows.Forms.ListBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblInventoryAdjustment As System.Windows.Forms.Label
End Class
