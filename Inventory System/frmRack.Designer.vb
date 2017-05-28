<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRack
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxDetails = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRackDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRackName = New System.Windows.Forms.TextBox()
        Me.btnAddLevel = New System.Windows.Forms.Button()
        Me.dgvRack = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rack_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rack_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlRackData = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ofdProfile = New System.Windows.Forms.OpenFileDialog()
        Me.pnlLevelData = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLevelDesc = New System.Windows.Forms.TextBox()
        Me.txtLevelCapacity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLevelName = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtLevelId = New System.Windows.Forms.TextBox()
        Me.txtRackId = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAddSave = New System.Windows.Forms.Button()
        Me.btnCancelDelete = New System.Windows.Forms.Button()
        Me.dgvLevel = New System.Windows.Forms.DataGridView()
        Me.level_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.level_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.level_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlRackLevel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.txtProdId = New System.Windows.Forms.TextBox()
        Me.gbxDetails.SuspendLayout()
        CType(Me.dgvRack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRackData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlLevelData.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRackLevel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxDetails
        '
        Me.gbxDetails.Controls.Add(Me.cmbProduct)
        Me.gbxDetails.Controls.Add(Me.Label2)
        Me.gbxDetails.Controls.Add(Me.Label6)
        Me.gbxDetails.Controls.Add(Me.txtRackDesc)
        Me.gbxDetails.Controls.Add(Me.Label1)
        Me.gbxDetails.Controls.Add(Me.txtRackName)
        Me.gbxDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetails.ForeColor = System.Drawing.Color.White
        Me.gbxDetails.Location = New System.Drawing.Point(20, 11)
        Me.gbxDetails.Name = "gbxDetails"
        Me.gbxDetails.Size = New System.Drawing.Size(518, 187)
        Me.gbxDetails.TabIndex = 40
        Me.gbxDetails.TabStop = False
        Me.gbxDetails.Text = "Rack Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Description :"
        '
        'txtRackDesc
        '
        Me.txtRackDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRackDesc.Location = New System.Drawing.Point(144, 63)
        Me.txtRackDesc.Multiline = True
        Me.txtRackDesc.Name = "txtRackDesc"
        Me.txtRackDesc.Size = New System.Drawing.Size(235, 65)
        Me.txtRackDesc.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Name :"
        '
        'txtRackName
        '
        Me.txtRackName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRackName.Location = New System.Drawing.Point(144, 22)
        Me.txtRackName.Name = "txtRackName"
        Me.txtRackName.Size = New System.Drawing.Size(235, 29)
        Me.txtRackName.TabIndex = 2
        '
        'btnAddLevel
        '
        Me.btnAddLevel.BackColor = System.Drawing.Color.Transparent
        Me.btnAddLevel.FlatAppearance.BorderSize = 0
        Me.btnAddLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLevel.ForeColor = System.Drawing.Color.White
        Me.btnAddLevel.Image = Global.Inventory_System.My.Resources.Resources._1487791161_sign_add
        Me.btnAddLevel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddLevel.Location = New System.Drawing.Point(16, 6)
        Me.btnAddLevel.Name = "btnAddLevel"
        Me.btnAddLevel.Size = New System.Drawing.Size(91, 75)
        Me.btnAddLevel.TabIndex = 39
        Me.btnAddLevel.Text = "Add Level"
        Me.btnAddLevel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddLevel.UseVisualStyleBackColor = False
        '
        'dgvRack
        '
        Me.dgvRack.AllowUserToAddRows = False
        Me.dgvRack.AllowUserToDeleteRows = False
        Me.dgvRack.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvRack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRack.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.rack_name, Me.rack_desc})
        Me.dgvRack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRack.Location = New System.Drawing.Point(16, 29)
        Me.dgvRack.Name = "dgvRack"
        Me.dgvRack.ReadOnly = True
        Me.dgvRack.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRack.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRack.RowTemplate.Height = 20
        Me.dgvRack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRack.Size = New System.Drawing.Size(486, 246)
        Me.dgvRack.TabIndex = 27
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 50
        '
        'rack_name
        '
        Me.rack_name.DataPropertyName = "rack_name"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.rack_name.DefaultCellStyle = DataGridViewCellStyle1
        Me.rack_name.HeaderText = "Name"
        Me.rack_name.Name = "rack_name"
        Me.rack_name.ReadOnly = True
        Me.rack_name.Width = 200
        '
        'rack_desc
        '
        Me.rack_desc.DataPropertyName = "rack_desc"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.rack_desc.DefaultCellStyle = DataGridViewCellStyle2
        Me.rack_desc.HeaderText = "Description"
        Me.rack_desc.Name = "rack_desc"
        Me.rack_desc.ReadOnly = True
        Me.rack_desc.Width = 240
        '
        'pnlRackData
        '
        Me.pnlRackData.BackColor = System.Drawing.Color.DimGray
        Me.pnlRackData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlRackData.Controls.Add(Me.gbxDetails)
        Me.pnlRackData.ForeColor = System.Drawing.Color.Black
        Me.pnlRackData.Location = New System.Drawing.Point(12, 81)
        Me.pnlRackData.Name = "pnlRackData"
        Me.pnlRackData.Size = New System.Drawing.Size(542, 221)
        Me.pnlRackData.TabIndex = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgvRack)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(20, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 310)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rack"
        '
        'ofdProfile
        '
        Me.ofdProfile.FileName = "OpenPic"
        Me.ofdProfile.Filter = "File Images (*.jpg;*.jpeg;) | *.jpg;*.jpeg; |PNG Images | *.png |GIF Images | *.G" & _
            "IF"""
        '
        'pnlLevelData
        '
        Me.pnlLevelData.BackColor = System.Drawing.Color.DimGray
        Me.pnlLevelData.Controls.Add(Me.GroupBox3)
        Me.pnlLevelData.Location = New System.Drawing.Point(552, 81)
        Me.pnlLevelData.Name = "pnlLevelData"
        Me.pnlLevelData.Size = New System.Drawing.Size(600, 221)
        Me.pnlLevelData.TabIndex = 72
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtLevelDesc)
        Me.GroupBox3.Controls.Add(Me.txtLevelCapacity)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtLevelName)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(4, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(580, 187)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Level Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(66, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Description :"
        '
        'txtLevelDesc
        '
        Me.txtLevelDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelDesc.Location = New System.Drawing.Point(182, 69)
        Me.txtLevelDesc.Multiline = True
        Me.txtLevelDesc.Name = "txtLevelDesc"
        Me.txtLevelDesc.Size = New System.Drawing.Size(235, 65)
        Me.txtLevelDesc.TabIndex = 42
        '
        'txtLevelCapacity
        '
        Me.txtLevelCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelCapacity.Location = New System.Drawing.Point(182, 146)
        Me.txtLevelCapacity.Name = "txtLevelCapacity"
        Me.txtLevelCapacity.Size = New System.Drawing.Size(235, 29)
        Me.txtLevelCapacity.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(66, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Capacity :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(66, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Name :"
        '
        'txtLevelName
        '
        Me.txtLevelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelName.Location = New System.Drawing.Point(182, 28)
        Me.txtLevelName.Name = "txtLevelName"
        Me.txtLevelName.Size = New System.Drawing.Size(235, 29)
        Me.txtLevelName.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.txtProdId)
        Me.Panel6.Controls.Add(Me.txtLevelId)
        Me.Panel6.Controls.Add(Me.txtRackId)
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.btnAddSave)
        Me.Panel6.Controls.Add(Me.btnCancelDelete)
        Me.Panel6.ForeColor = System.Drawing.Color.LightCyan
        Me.Panel6.Location = New System.Drawing.Point(12, 11)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1140, 64)
        Me.Panel6.TabIndex = 71
        '
        'txtLevelId
        '
        Me.txtLevelId.Location = New System.Drawing.Point(470, 25)
        Me.txtLevelId.Name = "txtLevelId"
        Me.txtLevelId.Size = New System.Drawing.Size(100, 20)
        Me.txtLevelId.TabIndex = 38
        Me.txtLevelId.Text = "level id"
        '
        'txtRackId
        '
        Me.txtRackId.Location = New System.Drawing.Point(320, 25)
        Me.txtRackId.Name = "txtRackId"
        Me.txtRackId.Size = New System.Drawing.Size(100, 20)
        Me.txtRackId.TabIndex = 37
        Me.txtRackId.Text = "rack id"
        Me.txtRackId.Visible = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Global.Inventory_System.My.Resources.Resources.close_icon
        Me.btnClose.Location = New System.Drawing.Point(1072, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(47, 47)
        Me.btnClose.TabIndex = 36
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(17, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(249, 37)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Rack and Level"
        '
        'btnAddSave
        '
        Me.btnAddSave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSave.ForeColor = System.Drawing.Color.White
        Me.btnAddSave.Image = Global.Inventory_System.My.Resources.Resources.server_add
        Me.btnAddSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSave.Location = New System.Drawing.Point(761, 8)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(125, 47)
        Me.btnAddSave.TabIndex = 1
        Me.btnAddSave.Text = "New"
        Me.btnAddSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddSave.UseVisualStyleBackColor = False
        '
        'btnCancelDelete
        '
        Me.btnCancelDelete.BackColor = System.Drawing.Color.Coral
        Me.btnCancelDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDelete.ForeColor = System.Drawing.Color.White
        Me.btnCancelDelete.Image = Global.Inventory_System.My.Resources.Resources.server_cancel
        Me.btnCancelDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelDelete.Location = New System.Drawing.Point(902, 8)
        Me.btnCancelDelete.Name = "btnCancelDelete"
        Me.btnCancelDelete.Size = New System.Drawing.Size(125, 47)
        Me.btnCancelDelete.TabIndex = 33
        Me.btnCancelDelete.Text = "Delete"
        Me.btnCancelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelDelete.UseVisualStyleBackColor = False
        '
        'dgvLevel
        '
        Me.dgvLevel.AllowUserToAddRows = False
        Me.dgvLevel.AllowUserToDeleteRows = False
        Me.dgvLevel.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLevel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.level_id, Me.level_name, Me.level_desc, Me.capacity, Me.rack})
        Me.dgvLevel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLevel.Location = New System.Drawing.Point(9, 29)
        Me.dgvLevel.Name = "dgvLevel"
        Me.dgvLevel.ReadOnly = True
        Me.dgvLevel.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLevel.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvLevel.RowTemplate.Height = 20
        Me.dgvLevel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLevel.Size = New System.Drawing.Size(554, 246)
        Me.dgvLevel.TabIndex = 27
        '
        'level_id
        '
        Me.level_id.DataPropertyName = "level_id"
        Me.level_id.HeaderText = "Id"
        Me.level_id.Name = "level_id"
        Me.level_id.ReadOnly = True
        Me.level_id.Visible = False
        Me.level_id.Width = 50
        '
        'level_name
        '
        Me.level_name.DataPropertyName = "level_name"
        Me.level_name.HeaderText = "Name"
        Me.level_name.Name = "level_name"
        Me.level_name.ReadOnly = True
        Me.level_name.Width = 190
        '
        'level_desc
        '
        Me.level_desc.DataPropertyName = "level_desc"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.level_desc.DefaultCellStyle = DataGridViewCellStyle3
        Me.level_desc.HeaderText = "Descripton"
        Me.level_desc.Name = "level_desc"
        Me.level_desc.ReadOnly = True
        Me.level_desc.Width = 220
        '
        'capacity
        '
        Me.capacity.DataPropertyName = "capacity"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.capacity.DefaultCellStyle = DataGridViewCellStyle4
        Me.capacity.HeaderText = "Capacity"
        Me.capacity.Name = "capacity"
        Me.capacity.ReadOnly = True
        '
        'rack
        '
        Me.rack.DataPropertyName = "rack_name"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.rack.DefaultCellStyle = DataGridViewCellStyle5
        Me.rack.HeaderText = "Rack"
        Me.rack.Name = "rack"
        Me.rack.ReadOnly = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(109, 24)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(296, 31)
        Me.txtSearch.TabIndex = 52
        '
        'pnlRackLevel
        '
        Me.pnlRackLevel.BackColor = System.Drawing.Color.DimGray
        Me.pnlRackLevel.Controls.Add(Me.txtSearch)
        Me.pnlRackLevel.Controls.Add(Me.Label3)
        Me.pnlRackLevel.Controls.Add(Me.GroupBox2)
        Me.pnlRackLevel.Controls.Add(Me.GroupBox1)
        Me.pnlRackLevel.ForeColor = System.Drawing.Color.DimGray
        Me.pnlRackLevel.Location = New System.Drawing.Point(12, 308)
        Me.pnlRackLevel.Name = "pnlRackLevel"
        Me.pnlRackLevel.Size = New System.Drawing.Size(1140, 409)
        Me.pnlRackLevel.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Search :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dgvLevel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(544, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(575, 310)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Level"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.btnAddLevel)
        Me.Panel1.Location = New System.Drawing.Point(423, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 155)
        Me.Panel1.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Product :"
        '
        'cmbProduct
        '
        Me.cmbProduct.BackColor = System.Drawing.SystemColors.Control
        Me.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(144, 143)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(235, 28)
        Me.cmbProduct.TabIndex = 66
        '
        'txtProdId
        '
        Me.txtProdId.Location = New System.Drawing.Point(598, 23)
        Me.txtProdId.Name = "txtProdId"
        Me.txtProdId.Size = New System.Drawing.Size(100, 20)
        Me.txtProdId.TabIndex = 39
        Me.txtProdId.Text = "product id"
        '
        'frmRack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1312, 772)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlRackData)
        Me.Controls.Add(Me.pnlLevelData)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.pnlRackLevel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRack"
        Me.Text = "frmRack"
        Me.gbxDetails.ResumeLayout(False)
        Me.gbxDetails.PerformLayout()
        CType(Me.dgvRack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRackData.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlLevelData.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRackLevel.ResumeLayout(False)
        Me.pnlRackLevel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRackDesc As System.Windows.Forms.TextBox
    Friend WithEvents btnAddLevel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRackName As System.Windows.Forms.TextBox
    Friend WithEvents dgvRack As System.Windows.Forms.DataGridView
    Friend WithEvents pnlRackData As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ofdProfile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlLevelData As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLevelDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtLevelCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLevelName As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAddSave As System.Windows.Forms.Button
    Friend WithEvents btnCancelDelete As System.Windows.Forms.Button
    Friend WithEvents dgvLevel As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents pnlRackLevel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRackId As System.Windows.Forms.TextBox
    Friend WithEvents txtLevelId As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rack_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rack_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents level_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents level_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents level_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capacity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rack As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents txtProdId As System.Windows.Forms.TextBox
End Class
