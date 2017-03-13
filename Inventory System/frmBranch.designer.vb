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
        Me.txtBranchCode = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddBranch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBranchAddress = New System.Windows.Forms.TextBox()
        Me.pnlBranchData = New System.Windows.Forms.Panel()
        Me.pnlBrachGrid = New System.Windows.Forms.Panel()
        Me.dvgBranch = New System.Windows.Forms.DataGridView()
        Me.branch_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.branch_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.branch_contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearchBranch = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.pnlBranchData.SuspendLayout()
        Me.pnlBrachGrid.SuspendLayout()
        CType(Me.dvgBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 37)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Branch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(665, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Contact Number :"
        '
        'txtBranchContact
        '
        Me.txtBranchContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchContact.Location = New System.Drawing.Point(816, 28)
        Me.txtBranchContact.Name = "txtBranchContact"
        Me.txtBranchContact.Size = New System.Drawing.Size(280, 26)
        Me.txtBranchContact.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Branch Name :"
        '
        'txtBranchName
        '
        Me.txtBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.Location = New System.Drawing.Point(160, 31)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(480, 26)
        Me.txtBranchName.TabIndex = 54
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtBranchCode)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnAddBranch)
        Me.Panel2.ForeColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(17, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 64)
        Me.Panel2.TabIndex = 62
        '
        'txtBranchCode
        '
        Me.txtBranchCode.BackColor = System.Drawing.Color.LightGray
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtBranchCode.Location = New System.Drawing.Point(190, 18)
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.ReadOnly = True
        Me.txtBranchCode.Size = New System.Drawing.Size(357, 29)
        Me.txtBranchCode.TabIndex = 60
        Me.txtBranchCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.Inventory_System.My.Resources.Resources.trash
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(964, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 42)
        Me.btnDelete.TabIndex = 67
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Inventory_System.My.Resources.Resources._1487714806_f_cross_256
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(838, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 39)
        Me.btnCancel.TabIndex = 68
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAddBranch
        '
        Me.btnAddBranch.BackColor = System.Drawing.Color.Lime
        Me.btnAddBranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBranch.FlatAppearance.BorderSize = 0
        Me.btnAddBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBranch.ForeColor = System.Drawing.Color.Black
        Me.btnAddBranch.Image = Global.Inventory_System.My.Resources.Resources._1487791161_sign_add
        Me.btnAddBranch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddBranch.Location = New System.Drawing.Point(728, 2)
        Me.btnAddBranch.Name = "btnAddBranch"
        Me.btnAddBranch.Size = New System.Drawing.Size(88, 39)
        Me.btnAddBranch.TabIndex = 66
        Me.btnAddBranch.Text = "New"
        Me.btnAddBranch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddBranch.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Address :"
        '
        'txtBranchAddress
        '
        Me.txtBranchAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchAddress.Location = New System.Drawing.Point(160, 80)
        Me.txtBranchAddress.Name = "txtBranchAddress"
        Me.txtBranchAddress.Size = New System.Drawing.Size(936, 26)
        Me.txtBranchAddress.TabIndex = 58
        '
        'pnlBranchData
        '
        Me.pnlBranchData.BackColor = System.Drawing.Color.DimGray
        Me.pnlBranchData.Controls.Add(Me.Label3)
        Me.pnlBranchData.Controls.Add(Me.Label1)
        Me.pnlBranchData.Controls.Add(Me.txtBranchAddress)
        Me.pnlBranchData.Controls.Add(Me.txtBranchName)
        Me.pnlBranchData.Controls.Add(Me.Label4)
        Me.pnlBranchData.Controls.Add(Me.txtBranchContact)
        Me.pnlBranchData.Location = New System.Drawing.Point(17, 85)
        Me.pnlBranchData.Name = "pnlBranchData"
        Me.pnlBranchData.Size = New System.Drawing.Size(1140, 147)
        Me.pnlBranchData.TabIndex = 63
        '
        'pnlBrachGrid
        '
        Me.pnlBrachGrid.BackColor = System.Drawing.Color.DimGray
        Me.pnlBrachGrid.Controls.Add(Me.dvgBranch)
        Me.pnlBrachGrid.Controls.Add(Me.Label5)
        Me.pnlBrachGrid.Controls.Add(Me.txtSearchBranch)
        Me.pnlBrachGrid.Location = New System.Drawing.Point(17, 239)
        Me.pnlBrachGrid.Name = "pnlBrachGrid"
        Me.pnlBrachGrid.Size = New System.Drawing.Size(1140, 468)
        Me.pnlBrachGrid.TabIndex = 64
        '
        'dvgBranch
        '
        Me.dvgBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgBranch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.branch_code, Me.branch_name, Me.branch_address, Me.branch_contact})
        Me.dvgBranch.Location = New System.Drawing.Point(16, 66)
        Me.dvgBranch.Name = "dvgBranch"
        Me.dvgBranch.ReadOnly = True
        Me.dvgBranch.Size = New System.Drawing.Size(1094, 385)
        Me.dvgBranch.TabIndex = 62
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
        Me.branch_address.Width = 450
        '
        'branch_contact
        '
        Me.branch_contact.DataPropertyName = "branch_contact"
        Me.branch_contact.HeaderText = "Contact"
        Me.branch_contact.Name = "branch_contact"
        Me.branch_contact.ReadOnly = True
        Me.branch_contact.Width = 180
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(31, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 20)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Search Branch :"
        '
        'txtSearchBranch
        '
        Me.txtSearchBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBranch.Location = New System.Drawing.Point(190, 17)
        Me.txtSearchBranch.Name = "txtSearchBranch"
        Me.txtSearchBranch.Size = New System.Drawing.Size(357, 31)
        Me.txtSearchBranch.TabIndex = 60
        Me.txtSearchBranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1207, 772)
        Me.Controls.Add(Me.pnlBrachGrid)
        Me.Controls.Add(Me.pnlBranchData)
        Me.Controls.Add(Me.Panel2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBranch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlBranchData.ResumeLayout(False)
        Me.pnlBranchData.PerformLayout()
        Me.pnlBrachGrid.ResumeLayout(False)
        Me.pnlBrachGrid.PerformLayout()
        CType(Me.dvgBranch, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAddBranch As System.Windows.Forms.Button
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents branch_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents branch_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents branch_contact As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
