<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdjustment
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
        Me.btnAddSave = New System.Windows.Forms.Button()
        Me.btnCancelDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReferenceNo = New System.Windows.Forms.TextBox()
        Me.pnlDataGrid = New System.Windows.Forms.Panel()
        Me.dgvAdjustment = New System.Windows.Forms.DataGridView()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQtyAvail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSearchAdjuctment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reference_number = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.prod_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.pnlDataGrid.SuspendLayout()
        CType(Me.dgvAdjustment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlData.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.btnAddSave)
        Me.Panel1.Controls.Add(Me.btnCancelDelete)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtReferenceNo)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 73)
        Me.Panel1.TabIndex = 0
        '
        'btnAddSave
        '
        Me.btnAddSave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSave.ForeColor = System.Drawing.Color.White
        Me.btnAddSave.Image = Global.Inventory_System.My.Resources.Resources.cart_add
        Me.btnAddSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSave.Location = New System.Drawing.Point(593, 14)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(125, 47)
        Me.btnAddSave.TabIndex = 49
        Me.btnAddSave.Text = "New"
        Me.btnAddSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddSave.UseVisualStyleBackColor = False
        '
        'btnCancelDelete
        '
        Me.btnCancelDelete.BackColor = System.Drawing.Color.Coral
        Me.btnCancelDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDelete.ForeColor = System.Drawing.Color.White
        Me.btnCancelDelete.Image = Global.Inventory_System.My.Resources.Resources.cart_cancel
        Me.btnCancelDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelDelete.Location = New System.Drawing.Point(734, 14)
        Me.btnCancelDelete.Name = "btnCancelDelete"
        Me.btnCancelDelete.Size = New System.Drawing.Size(125, 47)
        Me.btnCancelDelete.TabIndex = 50
        Me.btnCancelDelete.Text = "Delete"
        Me.btnCancelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelDelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Reference Number :"
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.BackColor = System.Drawing.Color.Black
        Me.txtReferenceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenceNo.ForeColor = System.Drawing.Color.Lime
        Me.txtReferenceNo.Location = New System.Drawing.Point(218, 22)
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.ReadOnly = True
        Me.txtReferenceNo.Size = New System.Drawing.Size(281, 35)
        Me.txtReferenceNo.TabIndex = 3
        '
        'pnlDataGrid
        '
        Me.pnlDataGrid.BackColor = System.Drawing.Color.DimGray
        Me.pnlDataGrid.Controls.Add(Me.Label9)
        Me.pnlDataGrid.Controls.Add(Me.txtSearchAdjuctment)
        Me.pnlDataGrid.Controls.Add(Me.dgvAdjustment)
        Me.pnlDataGrid.Location = New System.Drawing.Point(12, 355)
        Me.pnlDataGrid.Name = "pnlDataGrid"
        Me.pnlDataGrid.Size = New System.Drawing.Size(875, 310)
        Me.pnlDataGrid.TabIndex = 1
        '
        'dgvAdjustment
        '
        Me.dgvAdjustment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdjustment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.reference_number, Me.prod_id, Me.reason, Me.quantity, Me.unit_cost, Me.total, Me.notes})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdjustment.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAdjustment.Location = New System.Drawing.Point(14, 53)
        Me.dgvAdjustment.Name = "dgvAdjustment"
        Me.dgvAdjustment.Size = New System.Drawing.Size(845, 225)
        Me.dgvAdjustment.TabIndex = 0
        '
        'pnlData
        '
        Me.pnlData.BackColor = System.Drawing.Color.DimGray
        Me.pnlData.Controls.Add(Me.GroupBox2)
        Me.pnlData.Controls.Add(Me.GroupBox1)
        Me.pnlData.Location = New System.Drawing.Point(12, 91)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(875, 258)
        Me.pnlData.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtQtyAvail)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtUnitCost)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtQuantity)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(478, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 242)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(29, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 20)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Quantity Available"
        '
        'txtQtyAvail
        '
        Me.txtQtyAvail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyAvail.Location = New System.Drawing.Point(263, 34)
        Me.txtQtyAvail.Name = "txtQtyAvail"
        Me.txtQtyAvail.ReadOnly = True
        Me.txtQtyAvail.Size = New System.Drawing.Size(79, 29)
        Me.txtQtyAvail.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(29, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Total :"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Black
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Lime
        Me.txtTotal.Location = New System.Drawing.Point(160, 188)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(182, 38)
        Me.txtTotal.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(29, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Quantity :"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.Black
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Lime
        Me.txtQuantity.Location = New System.Drawing.Point(160, 81)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(182, 31)
        Me.txtQuantity.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtBarcode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtReason)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(14, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 242)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Notes :"
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(119, 148)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(320, 69)
        Me.txtNotes.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Reason :"
        '
        'txtReason
        '
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(119, 84)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(320, 50)
        Me.txtReason.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 20)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Product Code :"
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Black
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.ForeColor = System.Drawing.Color.Lime
        Me.txtBarcode.Location = New System.Drawing.Point(145, 34)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(253, 31)
        Me.txtBarcode.TabIndex = 54
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.Inventory_System.My.Resources.Resources.cart_search
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(399, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 32)
        Me.btnSearch.TabIndex = 66
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(20, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Search :"
        '
        'txtSearchAdjuctment
        '
        Me.txtSearchAdjuctment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAdjuctment.Location = New System.Drawing.Point(133, 12)
        Me.txtSearchAdjuctment.Name = "txtSearchAdjuctment"
        Me.txtSearchAdjuctment.Size = New System.Drawing.Size(320, 31)
        Me.txtSearchAdjuctment.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(29, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Unit Cost :"
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitCost.Location = New System.Drawing.Point(160, 129)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.ReadOnly = True
        Me.txtUnitCost.Size = New System.Drawing.Size(182, 29)
        Me.txtUnitCost.TabIndex = 52
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'reference_number
        '
        Me.reference_number.ActiveLinkColor = System.Drawing.Color.Blue
        Me.reference_number.DataPropertyName = "reference_number"
        Me.reference_number.HeaderText = "Reference No."
        Me.reference_number.Name = "reference_number"
        Me.reference_number.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.reference_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.reference_number.Width = 250
        '
        'prod_id
        '
        Me.prod_id.DataPropertyName = "prod_id"
        Me.prod_id.HeaderText = "Item"
        Me.prod_id.Name = "prod_id"
        '
        'reason
        '
        Me.reason.DataPropertyName = "reason"
        Me.reason.HeaderText = "Reason"
        Me.reason.Name = "reason"
        Me.reason.Width = 300
        '
        'quantity
        '
        Me.quantity.DataPropertyName = "quantity"
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.Width = 50
        '
        'unit_cost
        '
        Me.unit_cost.DataPropertyName = "unit_cost"
        Me.unit_cost.HeaderText = "Unit Cost"
        Me.unit_cost.Name = "unit_cost"
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        '
        'notes
        '
        Me.notes.DataPropertyName = "notes"
        Me.notes.HeaderText = "Notes"
        Me.notes.Name = "notes"
        Me.notes.Width = 300
        '
        'frmAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 677)
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.pnlDataGrid)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAdjustment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Adjustment"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlDataGrid.ResumeLayout(False)
        Me.pnlDataGrid.PerformLayout()
        CType(Me.dgvAdjustment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlData.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReferenceNo As System.Windows.Forms.TextBox
    Friend WithEvents pnlDataGrid As System.Windows.Forms.Panel
    Friend WithEvents dgvAdjustment As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddSave As System.Windows.Forms.Button
    Friend WithEvents btnCancelDelete As System.Windows.Forms.Button
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQtyAvail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSearchAdjuctment As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reference_number As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents prod_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reason As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notes As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
