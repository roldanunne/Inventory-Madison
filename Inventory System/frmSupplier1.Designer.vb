<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier1
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearchSupplier = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.sup_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sup_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sup_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sup_contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSupplierGrid = New System.Windows.Forms.Panel()
        Me.btnAddSupplier = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSupplierContact = New System.Windows.Forms.TextBox()
        Me.pnlSupplierData = New System.Windows.Forms.Panel()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.txtSupplierId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.txtSupplierAddress = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSupplierGrid.SuspendLayout()
        Me.pnlSupplierData.SuspendLayout()
        Me.gbDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 20)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Search Supplier"
        '
        'txtSearchSupplier
        '
        Me.txtSearchSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchSupplier.Location = New System.Drawing.Point(172, 35)
        Me.txtSearchSupplier.Name = "txtSearchSupplier"
        Me.txtSearchSupplier.Size = New System.Drawing.Size(357, 31)
        Me.txtSearchSupplier.TabIndex = 60
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Coral
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.Inventory_System.My.Resources.Resources.minus_house
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(910, 9)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 47)
        Me.btnDelete.TabIndex = 73
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dgvSupplier
        '
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sup_id, Me.sup_name, Me.sup_address, Me.sup_contact})
        Me.dgvSupplier.Location = New System.Drawing.Point(25, 78)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.Size = New System.Drawing.Size(1087, 276)
        Me.dgvSupplier.TabIndex = 62
        '
        'sup_id
        '
        Me.sup_id.DataPropertyName = "sup_id"
        Me.sup_id.HeaderText = "ID"
        Me.sup_id.Name = "sup_id"
        Me.sup_id.ReadOnly = True
        Me.sup_id.Visible = False
        Me.sup_id.Width = 50
        '
        'sup_name
        '
        Me.sup_name.DataPropertyName = "sup_name"
        Me.sup_name.HeaderText = "Supplier Name"
        Me.sup_name.Name = "sup_name"
        Me.sup_name.ReadOnly = True
        Me.sup_name.Width = 270
        '
        'sup_address
        '
        Me.sup_address.DataPropertyName = "sup_address"
        Me.sup_address.FillWeight = 200.0!
        Me.sup_address.HeaderText = "Address"
        Me.sup_address.Name = "sup_address"
        Me.sup_address.ReadOnly = True
        Me.sup_address.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sup_address.Width = 520
        '
        'sup_contact
        '
        Me.sup_contact.DataPropertyName = "sup_contact"
        Me.sup_contact.HeaderText = "Contact"
        Me.sup_contact.Name = "sup_contact"
        Me.sup_contact.ReadOnly = True
        Me.sup_contact.Width = 250
        '
        'pnlSupplierGrid
        '
        Me.pnlSupplierGrid.BackColor = System.Drawing.Color.DimGray
        Me.pnlSupplierGrid.Controls.Add(Me.dgvSupplier)
        Me.pnlSupplierGrid.Controls.Add(Me.Label5)
        Me.pnlSupplierGrid.Controls.Add(Me.txtSearchSupplier)
        Me.pnlSupplierGrid.Location = New System.Drawing.Point(17, 277)
        Me.pnlSupplierGrid.Name = "pnlSupplierGrid"
        Me.pnlSupplierGrid.Size = New System.Drawing.Size(1140, 375)
        Me.pnlSupplierGrid.TabIndex = 71
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSupplier.ForeColor = System.Drawing.Color.White
        Me.btnAddSupplier.Image = Global.Inventory_System.My.Resources.Resources.plus_house
        Me.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSupplier.Location = New System.Drawing.Point(769, 9)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(125, 47)
        Me.btnAddSupplier.TabIndex = 72
        Me.btnAddSupplier.Text = "New"
        Me.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddSupplier.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Supplier Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(539, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Contact Number :"
        '
        'txtSupplierContact
        '
        Me.txtSupplierContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierContact.Location = New System.Drawing.Point(728, 36)
        Me.txtSupplierContact.Name = "txtSupplierContact"
        Me.txtSupplierContact.Size = New System.Drawing.Size(228, 29)
        Me.txtSupplierContact.TabIndex = 56
        '
        'pnlSupplierData
        '
        Me.pnlSupplierData.BackColor = System.Drawing.Color.DimGray
        Me.pnlSupplierData.Controls.Add(Me.gbDetails)
        Me.pnlSupplierData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSupplierData.ForeColor = System.Drawing.Color.White
        Me.pnlSupplierData.Location = New System.Drawing.Point(17, 82)
        Me.pnlSupplierData.Name = "pnlSupplierData"
        Me.pnlSupplierData.Size = New System.Drawing.Size(1140, 189)
        Me.pnlSupplierData.TabIndex = 70
        '
        'gbDetails
        '
        Me.gbDetails.Controls.Add(Me.Label1)
        Me.gbDetails.Controls.Add(Me.txtSupplierId)
        Me.gbDetails.Controls.Add(Me.txtSupplierContact)
        Me.gbDetails.Controls.Add(Me.Label3)
        Me.gbDetails.Controls.Add(Me.Label4)
        Me.gbDetails.Controls.Add(Me.txtSupplierName)
        Me.gbDetails.Controls.Add(Me.txtSupplierAddress)
        Me.gbDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDetails.ForeColor = System.Drawing.Color.White
        Me.gbDetails.Location = New System.Drawing.Point(25, 18)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(1087, 157)
        Me.gbDetails.TabIndex = 76
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "Details"
        '
        'txtSupplierId
        '
        Me.txtSupplierId.BackColor = System.Drawing.SystemColors.Control
        Me.txtSupplierId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSupplierId.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtSupplierId.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtSupplierId.Location = New System.Drawing.Point(35, 122)
        Me.txtSupplierId.Name = "txtSupplierId"
        Me.txtSupplierId.Size = New System.Drawing.Size(39, 19)
        Me.txtSupplierId.TabIndex = 75
        Me.txtSupplierId.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Address :"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierName.Location = New System.Drawing.Point(201, 36)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(269, 29)
        Me.txtSupplierName.TabIndex = 54
        '
        'txtSupplierAddress
        '
        Me.txtSupplierAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierAddress.Location = New System.Drawing.Point(201, 81)
        Me.txtSupplierAddress.Multiline = True
        Me.txtSupplierAddress.Name = "txtSupplierAddress"
        Me.txtSupplierAddress.Size = New System.Drawing.Size(269, 60)
        Me.txtSupplierAddress.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnAddSupplier)
        Me.Panel2.ForeColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(17, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 64)
        Me.Panel2.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(25, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 37)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Supplier"
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
        Me.btnClose.TabIndex = 76
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 780)
        Me.Controls.Add(Me.pnlSupplierGrid)
        Me.Controls.Add(Me.pnlSupplierData)
        Me.Controls.Add(Me.Panel2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSupplier"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.Text = "frmSupplier"
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSupplierGrid.ResumeLayout(False)
        Me.pnlSupplierGrid.PerformLayout()
        Me.pnlSupplierData.ResumeLayout(False)
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSearchSupplier As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dgvSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents pnlSupplierGrid As System.Windows.Forms.Panel
    Friend WithEvents btnAddSupplier As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierContact As System.Windows.Forms.TextBox
    Friend WithEvents pnlSupplierData As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSupplierId As System.Windows.Forms.TextBox
    Friend WithEvents gbDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents sup_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sup_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sup_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sup_contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
