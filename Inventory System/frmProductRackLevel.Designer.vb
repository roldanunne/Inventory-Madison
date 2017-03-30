<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductRackLevel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProductQuantity = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSupplierPrice = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbRack = New System.Windows.Forms.ComboBox()
        Me.dgvSearchProduct = New System.Windows.Forms.DataGridView()
        Me.prod_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rack_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rack_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.level_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.level_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_retail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_at = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvSearchProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 241)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtProductQuantity)
        Me.GroupBox1.Controls.Add(Me.btnInsert)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(478, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 95)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Quantity"
        '
        'txtProductQuantity
        '
        Me.txtProductQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtProductQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtProductQuantity.Location = New System.Drawing.Point(16, 38)
        Me.txtProductQuantity.Name = "txtProductQuantity"
        Me.txtProductQuantity.Size = New System.Drawing.Size(109, 40)
        Me.txtProductQuantity.TabIndex = 59
        Me.txtProductQuantity.Text = "1"
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.Enabled = False
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Image = Global.Inventory_System.My.Resources.Resources.add_to_cart
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(139, 31)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(125, 47)
        Me.btnInsert.TabIndex = 61
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.UseMnemonic = False
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtRetailPrice)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtSupplierPrice)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(13, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(748, 101)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(308, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Stocks"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Lime
        Me.TextBox2.Location = New System.Drawing.Point(312, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(109, 40)
        Me.TextBox2.TabIndex = 70
        Me.TextBox2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(15, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(281, 40)
        Me.TextBox1.TabIndex = 68
        Me.TextBox1.Text = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(586, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 20)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Retail Price"
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.BackColor = System.Drawing.Color.Black
        Me.txtRetailPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetailPrice.ForeColor = System.Drawing.Color.Lime
        Me.txtRetailPrice.Location = New System.Drawing.Point(590, 45)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(139, 40)
        Me.txtRetailPrice.TabIndex = 66
        Me.txtRetailPrice.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(436, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 20)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Supplier Price"
        '
        'txtSupplierPrice
        '
        Me.txtSupplierPrice.BackColor = System.Drawing.Color.Black
        Me.txtSupplierPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierPrice.ForeColor = System.Drawing.Color.Lime
        Me.txtSupplierPrice.Location = New System.Drawing.Point(440, 45)
        Me.txtSupplierPrice.Name = "txtSupplierPrice"
        Me.txtSupplierPrice.Size = New System.Drawing.Size(139, 40)
        Me.txtSupplierPrice.TabIndex = 64
        Me.txtSupplierPrice.Text = "0.00"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.cmbLevel)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.cmbRack)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(13, 125)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(452, 95)
        Me.GroupBox5.TabIndex = 68
        Me.GroupBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Rack"
        '
        'cmbLevel
        '
        Me.cmbLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLevel.ForeColor = System.Drawing.Color.Lime
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Location = New System.Drawing.Point(229, 45)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(209, 28)
        Me.cmbLevel.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Level"
        '
        'cmbRack
        '
        Me.cmbRack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRack.ForeColor = System.Drawing.Color.Lime
        Me.cmbRack.FormattingEnabled = True
        Me.cmbRack.Location = New System.Drawing.Point(14, 44)
        Me.cmbRack.Name = "cmbRack"
        Me.cmbRack.Size = New System.Drawing.Size(209, 28)
        Me.cmbRack.TabIndex = 65
        '
        'dgvSearchProduct
        '
        Me.dgvSearchProduct.AllowUserToAddRows = False
        Me.dgvSearchProduct.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearchProduct.ColumnHeadersHeight = 40
        Me.dgvSearchProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod_id, Me.rack_id, Me.rack_name, Me.level_id, Me.level_name, Me.stocks, Me.price_supplier, Me.price_retail, Me.created_at})
        Me.dgvSearchProduct.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvSearchProduct.Location = New System.Drawing.Point(0, 272)
        Me.dgvSearchProduct.Name = "dgvSearchProduct"
        Me.dgvSearchProduct.ReadOnly = True
        Me.dgvSearchProduct.Size = New System.Drawing.Size(800, 256)
        Me.dgvSearchProduct.TabIndex = 3
        '
        'prod_id
        '
        Me.prod_id.DataPropertyName = "id"
        Me.prod_id.HeaderText = "ID"
        Me.prod_id.Name = "prod_id"
        Me.prod_id.ReadOnly = True
        '
        'rack_id
        '
        Me.rack_id.DataPropertyName = "rack_id"
        Me.rack_id.HeaderText = "Rack ID"
        Me.rack_id.Name = "rack_id"
        Me.rack_id.ReadOnly = True
        '
        'rack_name
        '
        Me.rack_name.DataPropertyName = "rack_name"
        Me.rack_name.HeaderText = "Rack Name"
        Me.rack_name.Name = "rack_name"
        Me.rack_name.ReadOnly = True
        '
        'level_id
        '
        Me.level_id.DataPropertyName = "level_id"
        Me.level_id.HeaderText = "Level ID"
        Me.level_id.Name = "level_id"
        Me.level_id.ReadOnly = True
        '
        'level_name
        '
        Me.level_name.DataPropertyName = "level_name"
        Me.level_name.HeaderText = "Level Name"
        Me.level_name.Name = "level_name"
        Me.level_name.ReadOnly = True
        '
        'stocks
        '
        Me.stocks.DataPropertyName = "qty_total"
        Me.stocks.HeaderText = "Stocks"
        Me.stocks.Name = "stocks"
        Me.stocks.ReadOnly = True
        '
        'price_supplier
        '
        Me.price_supplier.DataPropertyName = "price_supplier"
        Me.price_supplier.HeaderText = "Supplier Price"
        Me.price_supplier.Name = "price_supplier"
        Me.price_supplier.ReadOnly = True
        '
        'price_retail
        '
        Me.price_retail.DataPropertyName = "price_retail"
        Me.price_retail.HeaderText = "Retail Price"
        Me.price_retail.Name = "price_retail"
        Me.price_retail.ReadOnly = True
        '
        'created_at
        '
        Me.created_at.DataPropertyName = "created_at"
        Me.created_at.HeaderText = "Date Added"
        Me.created_at.Name = "created_at"
        Me.created_at.ReadOnly = True
        '
        'frmProductRackLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 528)
        Me.Controls.Add(Me.dgvSearchProduct)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductRackLevel"
        Me.Text = "Product on rack level"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvSearchProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvSearchProduct As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbRack As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProductQuantity As System.Windows.Forms.TextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierPrice As System.Windows.Forms.TextBox
    Friend WithEvents prod_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rack_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rack_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents level_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents level_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stocks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_retail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents created_at As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
