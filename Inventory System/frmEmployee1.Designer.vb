<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee1
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
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
        Me.user_access = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gbxProfile = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.gbxDetails = New System.Windows.Forms.GroupBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.gbxMenus = New System.Windows.Forms.GroupBox()
        Me.chkRack = New System.Windows.Forms.CheckBox()
        Me.chkBranch = New System.Windows.Forms.CheckBox()
        Me.chkSupplier = New System.Windows.Forms.CheckBox()
        Me.chkReport = New System.Windows.Forms.CheckBox()
        Me.chkDelivery = New System.Windows.Forms.CheckBox()
        Me.chkStocks = New System.Windows.Forms.CheckBox()
        Me.chkProducts = New System.Windows.Forms.CheckBox()
        Me.chkEmployee = New System.Windows.Forms.CheckBox()
        Me.gbxAccount = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRetype = New System.Windows.Forms.TextBox()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnCancelDelete = New System.Windows.Forms.Button()
        Me.pnlEmployeeList = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ofdProfile = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbxProfile.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetails.SuspendLayout()
        Me.gbxMenus.SuspendLayout()
        Me.gbxAccount.SuspendLayout()
        Me.pnlEmployeeList.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Username : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(18, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Password : "
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(22, 61)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(202, 29)
        Me.txtUsername.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(22, 131)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(202, 29)
        Me.txtPassword.TabIndex = 8
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.lname, Me.fname, Me.username, Me.password, Me.address, Me.gender, Me.stat, Me.status, Me.user_access})
        Me.dgvEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEmployee.Location = New System.Drawing.Point(28, 61)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.ReadOnly = True
        Me.dgvEmployee.RowTemplate.Height = 20
        Me.dgvEmployee.Size = New System.Drawing.Size(1090, 246)
        Me.dgvEmployee.TabIndex = 27
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'lname
        '
        Me.lname.DataPropertyName = "lname"
        Me.lname.HeaderText = "Last Name"
        Me.lname.Name = "lname"
        Me.lname.ReadOnly = True
        Me.lname.Width = 200
        '
        'fname
        '
        Me.fname.DataPropertyName = "fname"
        Me.fname.HeaderText = "First Name"
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        Me.fname.Width = 200
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Width = 150
        '
        'password
        '
        Me.password.DataPropertyName = "password"
        Me.password.HeaderText = "Password"
        Me.password.Name = "password"
        Me.password.ReadOnly = True
        Me.password.Visible = False
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Width = 250
        '
        'gender
        '
        Me.gender.DataPropertyName = "gender"
        Me.gender.HeaderText = "Gender"
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        '
        'stat
        '
        Me.stat.DataPropertyName = "stat"
        Me.stat.HeaderText = "Status"
        Me.stat.Name = "stat"
        Me.stat.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Visible = False
        '
        'user_access
        '
        Me.user_access.DataPropertyName = "user_access"
        Me.user_access.HeaderText = "User Access"
        Me.user_access.Name = "user_access"
        Me.user_access.ReadOnly = True
        Me.user_access.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 20)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Search Employee :"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(195, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(317, 31)
        Me.txtSearch.TabIndex = 52
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.gbxProfile)
        Me.Panel3.Controls.Add(Me.gbxDetails)
        Me.Panel3.Controls.Add(Me.gbxMenus)
        Me.Panel3.Controls.Add(Me.gbxAccount)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(17, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1140, 308)
        Me.Panel3.TabIndex = 55
        '
        'gbxProfile
        '
        Me.gbxProfile.Controls.Add(Me.btnBrowse)
        Me.gbxProfile.Controls.Add(Me.picProfile)
        Me.gbxProfile.Enabled = False
        Me.gbxProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProfile.ForeColor = System.Drawing.Color.White
        Me.gbxProfile.Location = New System.Drawing.Point(666, 22)
        Me.gbxProfile.Name = "gbxProfile"
        Me.gbxProfile.Size = New System.Drawing.Size(199, 262)
        Me.gbxProfile.TabIndex = 39
        Me.gbxProfile.TabStop = False
        Me.gbxProfile.Text = "Profile"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.SlateGray
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Image = Global.Inventory_System.My.Resources.Resources.open_folder
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.Location = New System.Drawing.Point(43, 217)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Padding = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Size = New System.Drawing.Size(110, 31)
        Me.btnBrowse.TabIndex = 36
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.White
        Me.picProfile.Image = Global.Inventory_System.My.Resources.Resources.default_user
        Me.picProfile.Location = New System.Drawing.Point(16, 28)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Padding = New System.Windows.Forms.Padding(5)
        Me.picProfile.Size = New System.Drawing.Size(166, 170)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 0
        Me.picProfile.TabStop = False
        '
        'gbxDetails
        '
        Me.gbxDetails.Controls.Add(Me.cmbStatus)
        Me.gbxDetails.Controls.Add(Me.Label10)
        Me.gbxDetails.Controls.Add(Me.Label8)
        Me.gbxDetails.Controls.Add(Me.cmbGender)
        Me.gbxDetails.Controls.Add(Me.Label2)
        Me.gbxDetails.Controls.Add(Me.txtLName)
        Me.gbxDetails.Controls.Add(Me.Label1)
        Me.gbxDetails.Controls.Add(Me.Label4)
        Me.gbxDetails.Controls.Add(Me.txtFName)
        Me.gbxDetails.Controls.Add(Me.txtAddress)
        Me.gbxDetails.Enabled = False
        Me.gbxDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetails.ForeColor = System.Drawing.Color.White
        Me.gbxDetails.Location = New System.Drawing.Point(28, 22)
        Me.gbxDetails.Name = "gbxDetails"
        Me.gbxDetails.Size = New System.Drawing.Size(620, 169)
        Me.gbxDetails.TabIndex = 40
        Me.gbxDetails.TabStop = False
        Me.gbxDetails.Text = "Details"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active, 1", "Inactive, 0"})
        Me.cmbStatus.Location = New System.Drawing.Point(458, 119)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(142, 28)
        Me.cmbStatus.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(454, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Status :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(454, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 20)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Gender :"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(458, 55)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(142, 28)
        Me.cmbGender.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(234, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Last Name :"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(238, 55)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(211, 29)
        Me.txtLName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "First Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Address :"
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(19, 55)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(211, 29)
        Me.txtFName.TabIndex = 2
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(18, 119)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(431, 29)
        Me.txtAddress.TabIndex = 5
        '
        'gbxMenus
        '
        Me.gbxMenus.Controls.Add(Me.chkRack)
        Me.gbxMenus.Controls.Add(Me.chkBranch)
        Me.gbxMenus.Controls.Add(Me.chkSupplier)
        Me.gbxMenus.Controls.Add(Me.chkReport)
        Me.gbxMenus.Controls.Add(Me.chkDelivery)
        Me.gbxMenus.Controls.Add(Me.chkStocks)
        Me.gbxMenus.Controls.Add(Me.chkProducts)
        Me.gbxMenus.Controls.Add(Me.chkEmployee)
        Me.gbxMenus.Enabled = False
        Me.gbxMenus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxMenus.ForeColor = System.Drawing.Color.White
        Me.gbxMenus.Location = New System.Drawing.Point(32, 200)
        Me.gbxMenus.Name = "gbxMenus"
        Me.gbxMenus.Size = New System.Drawing.Size(616, 84)
        Me.gbxMenus.TabIndex = 39
        Me.gbxMenus.TabStop = False
        Me.gbxMenus.Text = "Access Menus"
        '
        'chkRack
        '
        Me.chkRack.AutoSize = True
        Me.chkRack.Location = New System.Drawing.Point(191, 50)
        Me.chkRack.Name = "chkRack"
        Me.chkRack.Size = New System.Drawing.Size(103, 28)
        Me.chkRack.TabIndex = 7
        Me.chkRack.Text = "Products"
        Me.chkRack.UseVisualStyleBackColor = True
        '
        'chkBranch
        '
        Me.chkBranch.AutoSize = True
        Me.chkBranch.Location = New System.Drawing.Point(191, 25)
        Me.chkBranch.Name = "chkBranch"
        Me.chkBranch.Size = New System.Drawing.Size(103, 28)
        Me.chkBranch.TabIndex = 6
        Me.chkBranch.Text = "Products"
        Me.chkBranch.UseVisualStyleBackColor = True
        '
        'chkSupplier
        '
        Me.chkSupplier.AutoSize = True
        Me.chkSupplier.Location = New System.Drawing.Point(26, 50)
        Me.chkSupplier.Name = "chkSupplier"
        Me.chkSupplier.Size = New System.Drawing.Size(103, 28)
        Me.chkSupplier.TabIndex = 5
        Me.chkSupplier.Text = "Products"
        Me.chkSupplier.UseVisualStyleBackColor = True
        '
        'chkReport
        '
        Me.chkReport.AutoSize = True
        Me.chkReport.Location = New System.Drawing.Point(497, 50)
        Me.chkReport.Name = "chkReport"
        Me.chkReport.Size = New System.Drawing.Size(85, 28)
        Me.chkReport.TabIndex = 4
        Me.chkReport.Text = "Report"
        Me.chkReport.UseVisualStyleBackColor = True
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(497, 25)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(96, 28)
        Me.chkDelivery.TabIndex = 3
        Me.chkDelivery.Text = "Delivery"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'chkStocks
        '
        Me.chkStocks.AutoSize = True
        Me.chkStocks.Location = New System.Drawing.Point(344, 50)
        Me.chkStocks.Name = "chkStocks"
        Me.chkStocks.Size = New System.Drawing.Size(84, 28)
        Me.chkStocks.TabIndex = 2
        Me.chkStocks.Text = "Stocks"
        Me.chkStocks.UseVisualStyleBackColor = True
        '
        'chkProducts
        '
        Me.chkProducts.AutoSize = True
        Me.chkProducts.Location = New System.Drawing.Point(344, 25)
        Me.chkProducts.Name = "chkProducts"
        Me.chkProducts.Size = New System.Drawing.Size(103, 28)
        Me.chkProducts.TabIndex = 1
        Me.chkProducts.Text = "Products"
        Me.chkProducts.UseVisualStyleBackColor = True
        '
        'chkEmployee
        '
        Me.chkEmployee.AutoSize = True
        Me.chkEmployee.Location = New System.Drawing.Point(26, 25)
        Me.chkEmployee.Name = "chkEmployee"
        Me.chkEmployee.Size = New System.Drawing.Size(115, 28)
        Me.chkEmployee.TabIndex = 0
        Me.chkEmployee.Text = "Employee"
        Me.chkEmployee.UseVisualStyleBackColor = True
        '
        'gbxAccount
        '
        Me.gbxAccount.Controls.Add(Me.Label12)
        Me.gbxAccount.Controls.Add(Me.txtRetype)
        Me.gbxAccount.Controls.Add(Me.Label6)
        Me.gbxAccount.Controls.Add(Me.Label7)
        Me.gbxAccount.Controls.Add(Me.txtUsername)
        Me.gbxAccount.Controls.Add(Me.txtPassword)
        Me.gbxAccount.Enabled = False
        Me.gbxAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAccount.ForeColor = System.Drawing.Color.White
        Me.gbxAccount.Location = New System.Drawing.Point(882, 22)
        Me.gbxAccount.Name = "gbxAccount"
        Me.gbxAccount.Size = New System.Drawing.Size(245, 262)
        Me.gbxAccount.TabIndex = 38
        Me.gbxAccount.TabStop = False
        Me.gbxAccount.Text = "Account"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(18, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Re-Type : "
        '
        'txtRetype
        '
        Me.txtRetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetype.Location = New System.Drawing.Point(22, 201)
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRetype.Size = New System.Drawing.Size(202, 29)
        Me.txtRetype.TabIndex = 9
        '
        'btnEmployee
        '
        Me.btnEmployee.BackColor = System.Drawing.Color.ForestGreen
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.ForeColor = System.Drawing.Color.White
        Me.btnEmployee.Image = Global.Inventory_System.My.Resources.Resources.add_user
        Me.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployee.Location = New System.Drawing.Point(769, 9)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(125, 47)
        Me.btnEmployee.TabIndex = 1
        Me.btnEmployee.Text = "New"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'btnCancelDelete
        '
        Me.btnCancelDelete.BackColor = System.Drawing.Color.Coral
        Me.btnCancelDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDelete.ForeColor = System.Drawing.Color.White
        Me.btnCancelDelete.Image = Global.Inventory_System.My.Resources.Resources.remove_user
        Me.btnCancelDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelDelete.Location = New System.Drawing.Point(910, 9)
        Me.btnCancelDelete.Name = "btnCancelDelete"
        Me.btnCancelDelete.Size = New System.Drawing.Size(125, 47)
        Me.btnCancelDelete.TabIndex = 33
        Me.btnCancelDelete.Text = "Delete"
        Me.btnCancelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelDelete.UseVisualStyleBackColor = False
        '
        'pnlEmployeeList
        '
        Me.pnlEmployeeList.BackColor = System.Drawing.Color.DimGray
        Me.pnlEmployeeList.Controls.Add(Me.Label3)
        Me.pnlEmployeeList.Controls.Add(Me.dgvEmployee)
        Me.pnlEmployeeList.Controls.Add(Me.txtSearch)
        Me.pnlEmployeeList.ForeColor = System.Drawing.Color.DimGray
        Me.pnlEmployeeList.Location = New System.Drawing.Point(17, 396)
        Me.pnlEmployeeList.Name = "pnlEmployeeList"
        Me.pnlEmployeeList.Size = New System.Drawing.Size(1140, 330)
        Me.pnlEmployeeList.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(25, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 37)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Employee"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.txtId)
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.btnEmployee)
        Me.Panel6.Controls.Add(Me.btnCancelDelete)
        Me.Panel6.ForeColor = System.Drawing.Color.LightCyan
        Me.Panel6.Location = New System.Drawing.Point(17, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1140, 64)
        Me.Panel6.TabIndex = 64
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(215, 24)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(152, 29)
        Me.txtId.TabIndex = 42
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
        Me.btnClose.TabIndex = 36
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
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
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1207, 772)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.pnlEmployeeList)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployee"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.gbxProfile.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetails.ResumeLayout(False)
        Me.gbxDetails.PerformLayout()
        Me.gbxMenus.ResumeLayout(False)
        Me.gbxMenus.PerformLayout()
        Me.gbxAccount.ResumeLayout(False)
        Me.gbxAccount.PerformLayout()
        Me.pnlEmployeeList.ResumeLayout(False)
        Me.pnlEmployeeList.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents dgvEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlEmployeeList As System.Windows.Forms.Panel
    Friend WithEvents btnCancelDelete As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents gbxAccount As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRetype As System.Windows.Forms.TextBox
    Friend WithEvents gbxMenus As System.Windows.Forms.GroupBox
    Friend WithEvents chkReport As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents chkStocks As System.Windows.Forms.CheckBox
    Friend WithEvents chkProducts As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmployee As System.Windows.Forms.CheckBox
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents gbxDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents gbxProfile As System.Windows.Forms.GroupBox
    Friend WithEvents picProfile As System.Windows.Forms.PictureBox
    Friend WithEvents ofdProfile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
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
    Friend WithEvents chkRack As System.Windows.Forms.CheckBox
    Friend WithEvents chkBranch As System.Windows.Forms.CheckBox
    Friend WithEvents chkSupplier As System.Windows.Forms.CheckBox
End Class
