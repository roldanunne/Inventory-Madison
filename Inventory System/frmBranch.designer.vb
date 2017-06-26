<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBranch
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBranchContact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBranchName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBranchAddress = New System.Windows.Forms.TextBox()
        Me.pnlBranchData = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBranchCode = New System.Windows.Forms.TextBox()
        Me.pnlBrachGrid = New System.Windows.Forms.Panel()
        Me.dvgBranch = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearchBranch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.branch_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.branch_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.branch_contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddBranch = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.pnlBranchData.SuspendLayout()
        Me.pnlBrachGrid.SuspendLayout()
        CType(Me.dvgBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(566, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Contact Number :"
        '
        'txtBranchContact
        '
        Me.txtBranchContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchContact.Location = New System.Drawing.Point(749, 28)
        Me.txtBranchContact.Name = "txtBranchContact"
        Me.txtBranchContact.Size = New System.Drawing.Size(269, 29)
        Me.txtBranchContact.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Branch Name :"
        '
        'txtBranchName
        '
        Me.txtBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.Location = New System.Drawing.Point(198, 28)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(269, 29)
        Me.txtBranchName.TabIndex = 54
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnAddBranch)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.ForeColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(17, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 64)
        Me.Panel2.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Address :"
        '
        'txtBranchAddress
        '
        Me.txtBranchAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchAddress.Location = New System.Drawing.Point(198, 77)
        Me.txtBranchAddress.Multiline = True
        Me.txtBranchAddress.Name = "txtBranchAddress"
        Me.txtBranchAddress.Size = New System.Drawing.Size(269, 65)
        Me.txtBranchAddress.TabIndex = 58
        '
        'pnlBranchData
        '
        Me.pnlBranchData.BackColor = System.Drawing.Color.DimGray
        Me.pnlBranchData.Controls.Add(Me.GroupBox1)
        Me.pnlBranchData.Location = New System.Drawing.Point(17, 147)
        Me.pnlBranchData.Name = "pnlBranchData"
        Me.pnlBranchData.Size = New System.Drawing.Size(1140, 243)
        Me.pnlBranchData.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(27, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 25)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Branch Code :"
        '
        'txtBranchCode
        '
        Me.txtBranchCode.BackColor = System.Drawing.Color.Black
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.ForeColor = System.Drawing.Color.Lime
        Me.txtBranchCode.Location = New System.Drawing.Point(223, 11)
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.ReadOnly = True
        Me.txtBranchCode.Size = New System.Drawing.Size(280, 44)
        Me.txtBranchCode.TabIndex = 60
        Me.txtBranchCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlBrachGrid
        '
        Me.pnlBrachGrid.BackColor = System.Drawing.Color.DimGray
        Me.pnlBrachGrid.Controls.Add(Me.dvgBranch)
        Me.pnlBrachGrid.Controls.Add(Me.Label5)
        Me.pnlBrachGrid.Controls.Add(Me.txtSearchBranch)
        Me.pnlBrachGrid.Location = New System.Drawing.Point(17, 396)
        Me.pnlBrachGrid.Name = "pnlBrachGrid"
        Me.pnlBrachGrid.Size = New System.Drawing.Size(1140, 330)
        Me.pnlBrachGrid.TabIndex = 64
        '
        'dvgBranch
        '
        Me.dvgBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgBranch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.branch_code, Me.branch_name, Me.branch_address, Me.branch_contact})
        Me.dvgBranch.Location = New System.Drawing.Point(16, 66)
        Me.dvgBranch.Name = "dvgBranch"
        Me.dvgBranch.ReadOnly = True
        Me.dvgBranch.Size = New System.Drawing.Size(1096, 241)
        Me.dvgBranch.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 24)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Search Branch :"
        '
        'txtSearchBranch
        '
        Me.txtSearchBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBranch.Location = New System.Drawing.Point(223, 23)
        Me.txtSearchBranch.Name = "txtSearchBranch"
        Me.txtSearchBranch.Size = New System.Drawing.Size(357, 31)
        Me.txtSearchBranch.TabIndex = 60
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtBranchCode)
        Me.Panel1.Location = New System.Drawing.Point(17, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1140, 68)
        Me.Panel1.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(25, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 37)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Branch"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBranchContact)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBranchAddress)
        Me.GroupBox1.Controls.Add(Me.txtBranchName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(25, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1087, 157)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'branch_code
        '
        Me.branch_code.DataPropertyName = "branch_code"
        Me.branch_code.HeaderText = "Branch Code"
        Me.branch_code.Name = "branch_code"
        Me.branch_code.ReadOnly = True
        Me.branch_code.Width = 200
        '
        'branch_name
        '
        Me.branch_name.DataPropertyName = "branch_name"
        Me.branch_name.HeaderText = "Branch name"
        Me.branch_name.Name = "branch_name"
        Me.branch_name.ReadOnly = True
        Me.branch_name.Width = 220
        '
        'branch_address
        '
        Me.branch_address.DataPropertyName = "branch_address"
        Me.branch_address.FillWeight = 200.0!
        Me.branch_address.HeaderText = "Address"
        Me.branch_address.Name = "branch_address"
        Me.branch_address.ReadOnly = True
        Me.branch_address.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.branch_address.Width = 430
        '
        'branch_contact
        '
        Me.branch_contact.DataPropertyName = "branch_contact"
        Me.branch_contact.HeaderText = "Contact"
        Me.branch_contact.Name = "branch_contact"
        Me.branch_contact.ReadOnly = True
        Me.branch_contact.Width = 200
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Coral
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(910, 9)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 47)
        Me.btnDelete.TabIndex = 75
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAddBranch
        '
        Me.btnAddBranch.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddBranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBranch.ForeColor = System.Drawing.Color.White
        Me.btnAddBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBranch.Location = New System.Drawing.Point(769, 9)
        Me.btnAddBranch.Name = "btnAddBranch"
        Me.btnAddBranch.Size = New System.Drawing.Size(125, 47)
        Me.btnAddBranch.TabIndex = 74
        Me.btnAddBranch.Text = "New"
        Me.btnAddBranch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddBranch.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1080, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(47, 47)
        Me.btnClose.TabIndex = 77
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 780)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBrachGrid)
        Me.Controls.Add(Me.pnlBranchData)
        Me.Controls.Add(Me.Panel2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBranch"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlBranchData.ResumeLayout(False)
        Me.pnlBrachGrid.ResumeLayout(False)
        Me.pnlBrachGrid.PerformLayout()
        CType(Me.dvgBranch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBranchContact As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBranchName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBranchAddress As System.Windows.Forms.TextBox
    Friend WithEvents pnlBranchData As System.Windows.Forms.Panel
    Friend WithEvents pnlBrachGrid As System.Windows.Forms.Panel
    Friend WithEvents dvgBranch As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSearchBranch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents branch_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents branch_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents branch_contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAddBranch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
