<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gbxList = New System.Windows.Forms.GroupBox()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.useraccess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.gbxProfile = New System.Windows.Forms.GroupBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.gbxDetails = New System.Windows.Forms.GroupBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbxMenus = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkRack = New System.Windows.Forms.CheckBox()
        Me.chkBranch = New System.Windows.Forms.CheckBox()
        Me.chkSupplier = New System.Windows.Forms.CheckBox()
        Me.chkReport = New System.Windows.Forms.CheckBox()
        Me.chkDelivery = New System.Windows.Forms.CheckBox()
        Me.chkStocks = New System.Windows.Forms.CheckBox()
        Me.chkProducts = New System.Windows.Forms.CheckBox()
        Me.chkEmployee = New System.Windows.Forms.CheckBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ofdProfile = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3.SuspendLayout()
        Me.gbxList.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxProfile.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetails.SuspendLayout()
        Me.gbxMenus.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.gbxList)
        Me.Panel3.Controls.Add(Me.gbxProfile)
        Me.Panel3.Controls.Add(Me.gbxDetails)
        Me.Panel3.Controls.Add(Me.gbxMenus)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Location = New System.Drawing.Point(3, 51)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(1135, 651)
        Me.Panel3.TabIndex = 55
        '
        'gbxList
        '
        Me.gbxList.BackColor = System.Drawing.Color.White
        Me.gbxList.Controls.Add(Me.dgvEmployee)
        Me.gbxList.Controls.Add(Me.Label3)
        Me.gbxList.Controls.Add(Me.txtSearch)
        Me.gbxList.ForeColor = System.Drawing.Color.RoyalBlue
        Me.gbxList.Location = New System.Drawing.Point(16, 179)
        Me.gbxList.Name = "gbxList"
        Me.gbxList.Size = New System.Drawing.Size(1079, 455)
        Me.gbxList.TabIndex = 57
        Me.gbxList.TabStop = False
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.CausesValidation = False
        Me.dgvEmployee.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.lname, Me.fname, Me.username, Me.password, Me.address, Me.gender, Me.stat, Me.status, Me.useraccess})
        Me.dgvEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEmployee.Location = New System.Drawing.Point(17, 55)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployee.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.dgvEmployee.RowTemplate.Height = 20
        Me.dgvEmployee.Size = New System.Drawing.Size(1045, 386)
        Me.dgvEmployee.TabIndex = 58
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.id.DefaultCellStyle = DataGridViewCellStyle14
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'lname
        '
        Me.lname.DataPropertyName = "lname"
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lname.DefaultCellStyle = DataGridViewCellStyle15
        Me.lname.HeaderText = "Last Name"
        Me.lname.Name = "lname"
        Me.lname.ReadOnly = True
        Me.lname.Width = 180
        '
        'fname
        '
        Me.fname.DataPropertyName = "fname"
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.fname.DefaultCellStyle = DataGridViewCellStyle16
        Me.fname.HeaderText = "First Name"
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        Me.fname.Width = 180
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.username.DefaultCellStyle = DataGridViewCellStyle17
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Width = 120
        '
        'password
        '
        Me.password.DataPropertyName = "password"
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.password.DefaultCellStyle = DataGridViewCellStyle18
        Me.password.HeaderText = "Password"
        Me.password.Name = "password"
        Me.password.ReadOnly = True
        Me.password.Visible = False
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.address.DefaultCellStyle = DataGridViewCellStyle19
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Width = 280
        '
        'gender
        '
        Me.gender.DataPropertyName = "gender"
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.gender.DefaultCellStyle = DataGridViewCellStyle20
        Me.gender.HeaderText = "Gender"
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        '
        'stat
        '
        Me.stat.DataPropertyName = "stat"
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.stat.DefaultCellStyle = DataGridViewCellStyle21
        Me.stat.HeaderText = "Status"
        Me.stat.Name = "stat"
        Me.stat.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.status.DefaultCellStyle = DataGridViewCellStyle22
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Visible = False
        '
        'useraccess
        '
        Me.useraccess.DataPropertyName = "useraccess"
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.useraccess.DefaultCellStyle = DataGridViewCellStyle23
        Me.useraccess.HeaderText = "User Access"
        Me.useraccess.Name = "useraccess"
        Me.useraccess.ReadOnly = True
        Me.useraccess.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(16, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtSearch.Location = New System.Drawing.Point(87, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(390, 26)
        Me.txtSearch.TabIndex = 55
        '
        'gbxProfile
        '
        Me.gbxProfile.Controls.Add(Me.picProfile)
        Me.gbxProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProfile.ForeColor = System.Drawing.Color.RoyalBlue
        Me.gbxProfile.Location = New System.Drawing.Point(952, 15)
        Me.gbxProfile.Name = "gbxProfile"
        Me.gbxProfile.Size = New System.Drawing.Size(142, 143)
        Me.gbxProfile.TabIndex = 39
        Me.gbxProfile.TabStop = False
        Me.gbxProfile.Text = "Profile"
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.White
        Me.picProfile.Location = New System.Drawing.Point(16, 21)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Padding = New System.Windows.Forms.Padding(5)
        Me.picProfile.Size = New System.Drawing.Size(110, 111)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 0
        Me.picProfile.TabStop = False
        '
        'gbxDetails
        '
        Me.gbxDetails.Controls.Add(Me.lblGender)
        Me.gbxDetails.Controls.Add(Me.lblStatus)
        Me.gbxDetails.Controls.Add(Me.lblAddress)
        Me.gbxDetails.Controls.Add(Me.lblLname)
        Me.gbxDetails.Controls.Add(Me.lblFname)
        Me.gbxDetails.Controls.Add(Me.Label10)
        Me.gbxDetails.Controls.Add(Me.Label8)
        Me.gbxDetails.Controls.Add(Me.Label2)
        Me.gbxDetails.Controls.Add(Me.Label1)
        Me.gbxDetails.Controls.Add(Me.Label4)
        Me.gbxDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetails.ForeColor = System.Drawing.Color.RoyalBlue
        Me.gbxDetails.Location = New System.Drawing.Point(18, 15)
        Me.gbxDetails.Name = "gbxDetails"
        Me.gbxDetails.Size = New System.Drawing.Size(619, 143)
        Me.gbxDetails.TabIndex = 40
        Me.gbxDetails.TabStop = False
        Me.gbxDetails.Text = "Details"
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.Color.White
        Me.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblGender.Location = New System.Drawing.Point(456, 48)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(141, 22)
        Me.lblGender.TabIndex = 55
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblStatus.Location = New System.Drawing.Point(455, 101)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(141, 22)
        Me.lblStatus.TabIndex = 58
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.White
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAddress.Location = New System.Drawing.Point(15, 103)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(415, 22)
        Me.lblAddress.TabIndex = 54
        '
        'lblLname
        '
        Me.lblLname.BackColor = System.Drawing.Color.White
        Me.lblLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLname.Location = New System.Drawing.Point(232, 48)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(198, 22)
        Me.lblLname.TabIndex = 53
        '
        'lblFname
        '
        Me.lblFname.BackColor = System.Drawing.Color.White
        Me.lblFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblFname.Location = New System.Drawing.Point(15, 48)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(198, 22)
        Me.lblFname.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(453, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(452, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(228, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(12, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Address"
        '
        'gbxMenus
        '
        Me.gbxMenus.Controls.Add(Me.Label11)
        Me.gbxMenus.Controls.Add(Me.Label9)
        Me.gbxMenus.Controls.Add(Me.Label7)
        Me.gbxMenus.Controls.Add(Me.Label15)
        Me.gbxMenus.Controls.Add(Me.Label14)
        Me.gbxMenus.Controls.Add(Me.Label13)
        Me.gbxMenus.Controls.Add(Me.Label12)
        Me.gbxMenus.Controls.Add(Me.Label6)
        Me.gbxMenus.Controls.Add(Me.chkRack)
        Me.gbxMenus.Controls.Add(Me.chkBranch)
        Me.gbxMenus.Controls.Add(Me.chkSupplier)
        Me.gbxMenus.Controls.Add(Me.chkReport)
        Me.gbxMenus.Controls.Add(Me.chkDelivery)
        Me.gbxMenus.Controls.Add(Me.chkStocks)
        Me.gbxMenus.Controls.Add(Me.chkProducts)
        Me.gbxMenus.Controls.Add(Me.chkEmployee)
        Me.gbxMenus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxMenus.ForeColor = System.Drawing.Color.RoyalBlue
        Me.gbxMenus.Location = New System.Drawing.Point(671, 15)
        Me.gbxMenus.Name = "gbxMenus"
        Me.gbxMenus.Size = New System.Drawing.Size(247, 143)
        Me.gbxMenus.TabIndex = 39
        Me.gbxMenus.TabStop = False
        Me.gbxMenus.Text = "Access Menus"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(39, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Rack"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(39, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Branch"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(39, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Supplier"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Location = New System.Drawing.Point(151, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 16)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Report"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Location = New System.Drawing.Point(151, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 16)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Delivery"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(151, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Stocks"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(151, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 16)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Products"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(39, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Employee"
        '
        'chkRack
        '
        Me.chkRack.AutoSize = True
        Me.chkRack.Enabled = False
        Me.chkRack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkRack.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkRack.Location = New System.Drawing.Point(26, 107)
        Me.chkRack.Name = "chkRack"
        Me.chkRack.Size = New System.Drawing.Size(12, 11)
        Me.chkRack.TabIndex = 7
        Me.chkRack.UseVisualStyleBackColor = True
        '
        'chkBranch
        '
        Me.chkBranch.AutoSize = True
        Me.chkBranch.Enabled = False
        Me.chkBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBranch.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkBranch.Location = New System.Drawing.Point(26, 80)
        Me.chkBranch.Name = "chkBranch"
        Me.chkBranch.Size = New System.Drawing.Size(12, 11)
        Me.chkBranch.TabIndex = 6
        Me.chkBranch.UseVisualStyleBackColor = True
        '
        'chkSupplier
        '
        Me.chkSupplier.AutoSize = True
        Me.chkSupplier.Enabled = False
        Me.chkSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSupplier.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkSupplier.Location = New System.Drawing.Point(26, 53)
        Me.chkSupplier.Name = "chkSupplier"
        Me.chkSupplier.Size = New System.Drawing.Size(12, 11)
        Me.chkSupplier.TabIndex = 5
        Me.chkSupplier.UseVisualStyleBackColor = True
        '
        'chkReport
        '
        Me.chkReport.AutoSize = True
        Me.chkReport.Enabled = False
        Me.chkReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkReport.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkReport.Location = New System.Drawing.Point(138, 107)
        Me.chkReport.Name = "chkReport"
        Me.chkReport.Size = New System.Drawing.Size(12, 11)
        Me.chkReport.TabIndex = 4
        Me.chkReport.UseVisualStyleBackColor = True
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Enabled = False
        Me.chkDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelivery.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkDelivery.Location = New System.Drawing.Point(138, 80)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(12, 11)
        Me.chkDelivery.TabIndex = 3
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'chkStocks
        '
        Me.chkStocks.AutoSize = True
        Me.chkStocks.Enabled = False
        Me.chkStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkStocks.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkStocks.Location = New System.Drawing.Point(138, 53)
        Me.chkStocks.Name = "chkStocks"
        Me.chkStocks.Size = New System.Drawing.Size(12, 11)
        Me.chkStocks.TabIndex = 2
        Me.chkStocks.UseVisualStyleBackColor = True
        '
        'chkProducts
        '
        Me.chkProducts.AutoSize = True
        Me.chkProducts.Enabled = False
        Me.chkProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkProducts.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkProducts.Location = New System.Drawing.Point(138, 26)
        Me.chkProducts.Name = "chkProducts"
        Me.chkProducts.Size = New System.Drawing.Size(12, 11)
        Me.chkProducts.TabIndex = 1
        Me.chkProducts.UseVisualStyleBackColor = True
        '
        'chkEmployee
        '
        Me.chkEmployee.AutoSize = True
        Me.chkEmployee.Enabled = False
        Me.chkEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEmployee.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkEmployee.Location = New System.Drawing.Point(26, 26)
        Me.chkEmployee.Name = "chkEmployee"
        Me.chkEmployee.Size = New System.Drawing.Size(12, 11)
        Me.chkEmployee.TabIndex = 0
        Me.chkEmployee.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.ForestGreen
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.Inventory_System.My.Resources.Resources.user_new
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(819, 7)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(99, 34)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.Coral
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.Inventory_System.My.Resources.Resources.user_delete
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(1029, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 34)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.btnEdit)
        Me.Panel6.Controls.Add(Me.picLogo)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.btnNew)
        Me.Panel6.Controls.Add(Me.btnDelete)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1135, 48)
        Me.Panel6.TabIndex = 64
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.Purple
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.Inventory_System.My.Resources.Resources.user_save
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(924, 7)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(99, 34)
        Me.btnEdit.TabIndex = 74
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.Inventory_System.My.Resources.Resources.frm_employee
        Me.picLogo.Location = New System.Drawing.Point(16, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Padding = New System.Windows.Forms.Padding(5)
        Me.picLogo.Size = New System.Drawing.Size(42, 42)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 73
        Me.picLogo.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(73, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 24)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Employee Settings"
        '
        'ofdProfile
        '
        Me.ofdProfile.FileName = "OpenPic"
        Me.ofdProfile.Filter = "File Images (*.jpg;*.jpeg;) | *.jpg;*.jpeg; |PNG Images | *.png |GIF Images | *.G" & _
            "IF"""
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1141, 705)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployee"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel3.ResumeLayout(False)
        Me.gbxList.ResumeLayout(False)
        Me.gbxList.PerformLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxProfile.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetails.ResumeLayout(False)
        Me.gbxDetails.PerformLayout()
        Me.gbxMenus.ResumeLayout(False)
        Me.gbxMenus.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents gbxMenus As System.Windows.Forms.GroupBox
    Friend WithEvents chkReport As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents chkStocks As System.Windows.Forms.CheckBox
    Friend WithEvents chkProducts As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmployee As System.Windows.Forms.CheckBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbxDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbxProfile As System.Windows.Forms.GroupBox
    Friend WithEvents picProfile As System.Windows.Forms.PictureBox
    Friend WithEvents ofdProfile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkRack As System.Windows.Forms.CheckBox
    Friend WithEvents chkBranch As System.Windows.Forms.CheckBox
    Friend WithEvents chkSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents gbxList As System.Windows.Forms.GroupBox
    Friend WithEvents dgvEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_access As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents useraccess As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
