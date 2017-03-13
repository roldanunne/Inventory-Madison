<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductProperties
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPropId = New System.Windows.Forms.TextBox()
        Me.dgvProperties = New System.Windows.Forms.DataGridView()
        Me.prop_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prop_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prop_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlData.SuspendLayout()
        CType(Me.dgvProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Image = Global.Inventory_System.My.Resources.Resources._1487710265_floppy
        Me.btnAdd.Location = New System.Drawing.Point(352, 54)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(62, 72)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "SAVE"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'pnlData
        '
        Me.pnlData.BackColor = System.Drawing.Color.White
        Me.pnlData.Controls.Add(Me.btnDelete)
        Me.pnlData.Controls.Add(Me.Label2)
        Me.pnlData.Controls.Add(Me.Label1)
        Me.pnlData.Controls.Add(Me.txtValue)
        Me.pnlData.Controls.Add(Me.txtName)
        Me.pnlData.Controls.Add(Me.Label3)
        Me.pnlData.Controls.Add(Me.btnAdd)
        Me.pnlData.Location = New System.Drawing.Point(-1, 0)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(486, 135)
        Me.pnlData.TabIndex = 8
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.Inventory_System.My.Resources.Resources._1487715899_box_in

        Me.btnDelete.Location = New System.Drawing.Point(411, 47)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(61, 79)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "REMOVE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Value"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(73, 103)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(262, 26)
        Me.txtValue.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(73, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(262, 26)
        Me.txtName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Other Details"
        '
        'txtPropId
        '
        Me.txtPropId.BackColor = System.Drawing.Color.White
        Me.txtPropId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPropId.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtPropId.ForeColor = System.Drawing.Color.White
        Me.txtPropId.Location = New System.Drawing.Point(3, 141)
        Me.txtPropId.Name = "txtPropId"
        Me.txtPropId.Size = New System.Drawing.Size(10, 19)
        Me.txtPropId.TabIndex = 9
        '
        'dgvProperties
        '
        Me.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProperties.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prop_id, Me.prop_name, Me.prop_value})
        Me.dgvProperties.Location = New System.Drawing.Point(19, 141)
        Me.dgvProperties.Name = "dgvProperties"
        Me.dgvProperties.ReadOnly = True
        Me.dgvProperties.RowHeadersVisible = False
        Me.dgvProperties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProperties.Size = New System.Drawing.Size(444, 313)
        Me.dgvProperties.TabIndex = 0
        '
        'prop_id
        '
        Me.prop_id.DataPropertyName = "prop_id"
        Me.prop_id.HeaderText = "ID"
        Me.prop_id.Name = "prop_id"
        Me.prop_id.ReadOnly = True
        Me.prop_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.prop_id.Visible = False
        Me.prop_id.Width = 5
        '
        'prop_name
        '
        Me.prop_name.DataPropertyName = "prop_name"
        Me.prop_name.HeaderText = "Name"
        Me.prop_name.Name = "prop_name"
        Me.prop_name.ReadOnly = True
        Me.prop_name.Width = 220
        '
        'prop_value
        '
        Me.prop_value.DataPropertyName = "prop_value"
        Me.prop_value.HeaderText = "Value"
        Me.prop_value.Name = "prop_value"
        Me.prop_value.ReadOnly = True
        Me.prop_value.Width = 220
        '
        'frmProductProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 466)
        Me.Controls.Add(Me.txtPropId)
        Me.Controls.Add(Me.dgvProperties)
        Me.Controls.Add(Me.pnlData)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmProductProperties"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        CType(Me.dgvProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvProperties As System.Windows.Forms.DataGridView
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtPropId As System.Windows.Forms.TextBox
    Friend WithEvents prop_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prop_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prop_value As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
