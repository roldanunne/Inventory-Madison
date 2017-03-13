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
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.txtProductQuantity = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbImage = New System.Windows.Forms.GroupBox()
        Me.picProductImage = New System.Windows.Forms.PictureBox()
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
        Me.warehouse_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.warehouse_room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room_level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlProductData = New System.Windows.Forms.Panel()
        Me.gbWarehouse = New System.Windows.Forms.GroupBox()
        Me.txtRoomLevel = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtWarehouseRoom = New System.Windows.Forms.TextBox()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbAmounts = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCriticalStock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.txtProductClass = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlMoreDetails = New System.Windows.Forms.Panel()
        Me.btnMoreDetails = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.pnlProductGrid = New System.Windows.Forms.Panel()
        Me.ofdProductImage = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gbImage.SuspendLayout()
        CType(Me.picProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlProductData.SuspendLayout()
        Me.gbWarehouse.SuspendLayout()
        Me.gbAmounts.SuspendLayout()
        Me.gbDetails.SuspendLayout()
        Me.pnlMoreDetails.SuspendLayout()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProductGrid.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDescription.Location = New System.Drawing.Point(13, 126)
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(309, 44)
        Me.txtProductDescription.TabIndex = 60
        '
        'txtProductQuantity
        '
        Me.txtProductQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductQuantity.Location = New System.Drawing.Point(93, 29)
        Me.txtProductQuantity.Name = "txtProductQuantity"
        Me.txtProductQuantity.ReadOnly = True
        Me.txtProductQuantity.Size = New System.Drawing.Size(58, 26)
        Me.txtProductQuantity.TabIndex = 59
        Me.txtProductQuantity.Text = "0"
        Me.txtProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(13, 47)
        Me.txtProductName.Multiline = True
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(309, 45)
        Me.txtProductName.TabIndex = 58
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Black
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.ForeColor = System.Drawing.Color.Lime
        Me.txtBarcode.Location = New System.Drawing.Point(118, 9)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(227, 44)
        Me.txtBarcode.TabIndex = 57
        Me.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 103)
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
        Me.Label5.Location = New System.Drawing.Point(6, 30)
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
        Me.Label3.Location = New System.Drawing.Point(-1, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 37)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Code :"
        '
        'gbImage
        '
        Me.gbImage.BackColor = System.Drawing.Color.DimGray
        Me.gbImage.Controls.Add(Me.picProductImage)
        Me.gbImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbImage.ForeColor = System.Drawing.Color.White
        Me.gbImage.Location = New System.Drawing.Point(674, 14)
        Me.gbImage.Name = "gbImage"
        Me.gbImage.Size = New System.Drawing.Size(453, 283)
        Me.gbImage.TabIndex = 52
        Me.gbImage.TabStop = False
        Me.gbImage.Text = "Product Image"
        '
        'picProductImage
        '
        Me.picProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProductImage.Image = Global.Inventory_System.My.Resources.Resources.noImage
        Me.picProductImage.InitialImage = Global.Inventory_System.My.Resources.Resources.noImage
        Me.picProductImage.Location = New System.Drawing.Point(6, 25)
        Me.picProductImage.Name = "picProductImage"
        Me.picProductImage.Size = New System.Drawing.Size(440, 250)
        Me.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProductImage.TabIndex = 0
        Me.picProductImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Search Product :"
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProduct.Location = New System.Drawing.Point(202, 11)
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
        Me.btnDelete.Location = New System.Drawing.Point(910, 9)
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
        Me.btnAddProduct.Location = New System.Drawing.Point(769, 9)
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
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.barcode, Me.prod_name, Me.prod_desc, Me.prod_qty, Me.prod_price, Me.prod_class, Me.warehouse_name, Me.warehouse_room, Me.room_level})
        Me.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProducts.Location = New System.Drawing.Point(11, 53)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowTemplate.Height = 20
        Me.dgvProducts.Size = New System.Drawing.Size(1126, 265)
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
        Me.prod_name.Width = 200
        '
        'prod_desc
        '
        Me.prod_desc.DataPropertyName = "prod_desc"
        Me.prod_desc.HeaderText = "Description"
        Me.prod_desc.Name = "prod_desc"
        Me.prod_desc.ReadOnly = True
        Me.prod_desc.Width = 300
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
        'warehouse_name
        '
        Me.warehouse_name.DataPropertyName = "warehouse_name"
        Me.warehouse_name.HeaderText = "Warehouse "
        Me.warehouse_name.Name = "warehouse_name"
        Me.warehouse_name.ReadOnly = True
        Me.warehouse_name.Width = 200
        '
        'warehouse_room
        '
        Me.warehouse_room.DataPropertyName = "warehouse_room"
        Me.warehouse_room.HeaderText = "Room"
        Me.warehouse_room.Name = "warehouse_room"
        Me.warehouse_room.ReadOnly = True
        '
        'room_level
        '
        Me.room_level.DataPropertyName = "room_level"
        Me.room_level.HeaderText = "Rack"
        Me.room_level.Name = "room_level"
        Me.room_level.ReadOnly = True
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
        Me.btnClose.Location = New System.Drawing.Point(1080, 9)
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
        Me.pnlProductData.Controls.Add(Me.gbWarehouse)
        Me.pnlProductData.Controls.Add(Me.gbImage)
        Me.pnlProductData.Controls.Add(Me.gbAmounts)
        Me.pnlProductData.Controls.Add(Me.gbDetails)
        Me.pnlProductData.Location = New System.Drawing.Point(17, 82)
        Me.pnlProductData.Name = "pnlProductData"
        Me.pnlProductData.Size = New System.Drawing.Size(1140, 306)
        Me.pnlProductData.TabIndex = 62
        '
        'gbWarehouse
        '
        Me.gbWarehouse.Controls.Add(Me.txtRoomLevel)
        Me.gbWarehouse.Controls.Add(Me.Label11)
        Me.gbWarehouse.Controls.Add(Me.txtWarehouseRoom)
        Me.gbWarehouse.Controls.Add(Me.txtWarehouseName)
        Me.gbWarehouse.Controls.Add(Me.Label10)
        Me.gbWarehouse.Controls.Add(Me.Label2)
        Me.gbWarehouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbWarehouse.ForeColor = System.Drawing.Color.White
        Me.gbWarehouse.Location = New System.Drawing.Point(351, 173)
        Me.gbWarehouse.Name = "gbWarehouse"
        Me.gbWarehouse.Size = New System.Drawing.Size(317, 94)
        Me.gbWarehouse.TabIndex = 66
        Me.gbWarehouse.TabStop = False
        Me.gbWarehouse.Text = "Warehouse"
        '
        'txtRoomLevel
        '
        Me.txtRoomLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomLevel.Location = New System.Drawing.Point(225, 59)
        Me.txtRoomLevel.Name = "txtRoomLevel"
        Me.txtRoomLevel.Size = New System.Drawing.Size(86, 26)
        Me.txtRoomLevel.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(166, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 20)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Rack :"
        '
        'txtWarehouseRoom
        '
        Me.txtWarehouseRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarehouseRoom.Location = New System.Drawing.Point(70, 58)
        Me.txtWarehouseRoom.Name = "txtWarehouseRoom"
        Me.txtWarehouseRoom.Size = New System.Drawing.Size(84, 26)
        Me.txtWarehouseRoom.TabIndex = 67
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarehouseName.Location = New System.Drawing.Point(68, 26)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(242, 26)
        Me.txtWarehouseName.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Room :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Name :"
        '
        'gbAmounts
        '
        Me.gbAmounts.Controls.Add(Me.Label9)
        Me.gbAmounts.Controls.Add(Me.txtCriticalStock)
        Me.gbAmounts.Controls.Add(Me.Label8)
        Me.gbAmounts.Controls.Add(Me.txtProductPrice)
        Me.gbAmounts.Controls.Add(Me.Label5)
        Me.gbAmounts.Controls.Add(Me.txtProductQuantity)
        Me.gbAmounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAmounts.ForeColor = System.Drawing.Color.White
        Me.gbAmounts.Location = New System.Drawing.Point(350, 70)
        Me.gbAmounts.Name = "gbAmounts"
        Me.gbAmounts.Size = New System.Drawing.Size(317, 97)
        Me.gbAmounts.TabIndex = 64
        Me.gbAmounts.TabStop = False
        Me.gbAmounts.Text = "Amounts"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(7, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 20)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Critical Stock :"
        '
        'txtCriticalStock
        '
        Me.txtCriticalStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriticalStock.Location = New System.Drawing.Point(138, 65)
        Me.txtCriticalStock.Name = "txtCriticalStock"
        Me.txtCriticalStock.Size = New System.Drawing.Size(89, 26)
        Me.txtCriticalStock.TabIndex = 66
        Me.txtCriticalStock.Text = "0"
        Me.txtCriticalStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(156, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Price :"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductPrice.Location = New System.Drawing.Point(220, 28)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(91, 26)
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
        Me.gbDetails.Location = New System.Drawing.Point(12, 70)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(333, 227)
        Me.gbDetails.TabIndex = 63
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "Details"
        '
        'txtProductClass
        '
        Me.txtProductClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductClass.Location = New System.Drawing.Point(78, 181)
        Me.txtProductClass.Name = "txtProductClass"
        Me.txtProductClass.Size = New System.Drawing.Size(244, 26)
        Me.txtProductClass.TabIndex = 67
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(9, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 20)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Class :"
        '
        'pnlMoreDetails
        '
        Me.pnlMoreDetails.BackColor = System.Drawing.Color.White
        Me.pnlMoreDetails.Controls.Add(Me.btnMoreDetails)
        Me.pnlMoreDetails.Location = New System.Drawing.Point(587, 353)
        Me.pnlMoreDetails.Name = "pnlMoreDetails"
        Me.pnlMoreDetails.Size = New System.Drawing.Size(97, 29)
        Me.pnlMoreDetails.TabIndex = 66
        '
        'btnMoreDetails
        '
        Me.btnMoreDetails.BackColor = System.Drawing.Color.Transparent
        Me.btnMoreDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoreDetails.FlatAppearance.BorderSize = 0
        Me.btnMoreDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoreDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoreDetails.ForeColor = System.Drawing.Color.Blue
        Me.btnMoreDetails.Location = New System.Drawing.Point(3, -2)
        Me.btnMoreDetails.Name = "btnMoreDetails"
        Me.btnMoreDetails.Size = New System.Drawing.Size(95, 32)
        Me.btnMoreDetails.TabIndex = 61
        Me.btnMoreDetails.Text = "More Details"
        Me.btnMoreDetails.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Inventory_System.My.Resources.Resources._1487715790_BT_printer
        Me.Button2.Location = New System.Drawing.Point(600, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 44)
        Me.Button2.TabIndex = 49
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'picBarcode
        '
        Me.picBarcode.BackColor = System.Drawing.Color.Transparent
        Me.picBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBarcode.Image = Global.Inventory_System.My.Resources.Resources.noImage
        Me.picBarcode.InitialImage = Global.Inventory_System.My.Resources.Resources.noImage
        Me.picBarcode.Location = New System.Drawing.Point(360, 9)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(227, 44)
        Me.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBarcode.TabIndex = 1
        Me.picBarcode.TabStop = False
        '
        'pnlProductGrid
        '
        Me.pnlProductGrid.BackColor = System.Drawing.Color.DimGray
        Me.pnlProductGrid.Controls.Add(Me.Label1)
        Me.pnlProductGrid.Controls.Add(Me.dgvProducts)
        Me.pnlProductGrid.Controls.Add(Me.txtSearchProduct)
        Me.pnlProductGrid.Location = New System.Drawing.Point(17, 396)
        Me.pnlProductGrid.Name = "pnlProductGrid"
        Me.pnlProductGrid.Size = New System.Drawing.Size(1140, 331)
        Me.pnlProductGrid.TabIndex = 63
        '
        'ofdProductImage
        '
        Me.ofdProductImage.FileName = "ofdProductImage"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.picBarcode)
        Me.Panel3.Controls.Add(Me.txtBarcode)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(35, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(656, 62)
        Me.Panel3.TabIndex = 64
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 772)
        Me.Controls.Add(Me.pnlMoreDetails)
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
        Me.gbAmounts.ResumeLayout(False)
        Me.gbAmounts.PerformLayout()
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        Me.pnlMoreDetails.ResumeLayout(False)
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProductGrid.ResumeLayout(False)
        Me.pnlProductGrid.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents txtRoomLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtWarehouseRoom As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtWarehouseName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProductClass As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents picBarcode As System.Windows.Forms.PictureBox
    Friend WithEvents ofdProductImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents picProductImage As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMoreDetails As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCriticalStock As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_class As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents warehouse_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents warehouse_room As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_level As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
