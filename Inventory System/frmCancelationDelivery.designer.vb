<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelationDelivery
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtStockQty = New System.Windows.Forms.TextBox()
        Me.txtStockId = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtRefNumber = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvCancelation = New System.Windows.Forms.DataGridView()
        Me.stock_out_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvCancelation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reference Number :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.txtStockQty)
        Me.Panel1.Controls.Add(Me.txtStockId)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtRefNumber)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(21, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 73)
        Me.Panel1.TabIndex = 1
        '
        'txtStockQty
        '
        Me.txtStockQty.Location = New System.Drawing.Point(136, 47)
        Me.txtStockQty.Name = "txtStockQty"
        Me.txtStockQty.Size = New System.Drawing.Size(100, 20)
        Me.txtStockQty.TabIndex = 8
        '
        'txtStockId
        '
        Me.txtStockId.Location = New System.Drawing.Point(19, 47)
        Me.txtStockId.Name = "txtStockId"
        Me.txtStockId.Size = New System.Drawing.Size(100, 20)
        Me.txtStockId.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(644, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(119, 45)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtRefNumber
        '
        Me.txtRefNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNumber.Location = New System.Drawing.Point(242, 16)
        Me.txtRefNumber.Name = "txtRefNumber"
        Me.txtRefNumber.Size = New System.Drawing.Size(379, 38)
        Me.txtRefNumber.TabIndex = 1
        Me.txtRefNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.dgvCancelation)
        Me.Panel2.Location = New System.Drawing.Point(21, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(779, 335)
        Me.Panel2.TabIndex = 2
        '
        'dgvCancelation
        '
        Me.dgvCancelation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCancelation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stock_out_id, Me.barcode, Me.prod_name, Me.branch_name})
        Me.dgvCancelation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCancelation.Location = New System.Drawing.Point(0, 0)
        Me.dgvCancelation.Name = "dgvCancelation"
        Me.dgvCancelation.Size = New System.Drawing.Size(779, 335)
        Me.dgvCancelation.TabIndex = 0
        '
        'stock_out_id
        '
        Me.stock_out_id.DataPropertyName = "stock_out_id"
        Me.stock_out_id.HeaderText = "ID"
        Me.stock_out_id.Name = "stock_out_id"
        '
        'barcode
        '
        Me.barcode.DataPropertyName = "barcode"
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        '
        'prod_name
        '
        Me.prod_name.DataPropertyName = "prod_name"
        Me.prod_name.HeaderText = "Product"
        Me.prod_name.Name = "prod_name"
        '
        'branch_name
        '
        Me.branch_name.DataPropertyName = "branch_name"
        Me.branch_name.HeaderText = "Branch"
        Me.branch_name.Name = "branch_name"
        '
        'frmCancelationDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 456)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCancelationDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCancelationDelivery"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvCancelation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtRefNumber As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgvCancelation As System.Windows.Forms.DataGridView
    Friend WithEvents txtStockId As System.Windows.Forms.TextBox
    Friend WithEvents txtStockQty As System.Windows.Forms.TextBox
    Friend WithEvents stock_out_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
