<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIHome
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlStocks = New System.Windows.Forms.Panel()
        Me.pnlDelivery = New System.Windows.Forms.Panel()
        Me.pnlBranches = New System.Windows.Forms.Panel()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.pnlRack = New System.Windows.Forms.Panel()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.btnStocks = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.pnlEmployee = New System.Windows.Forms.Panel()
        Me.btnRack = New System.Windows.Forms.Button()
        Me.btnBranches = New System.Windows.Forms.Button()
        Me.pnlProducts = New System.Windows.Forms.Panel()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.pnlSupplier = New System.Windows.Forms.Panel()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblProfileName = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeft.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnlTop.Controls.Add(Me.Label3)
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(225, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(846, 33)
        Me.pnlTop.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 24)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Madison Inventory System"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.MediumBlue
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Inventory_System.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(809, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 25)
        Me.btnClose.TabIndex = 3
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Inventory_System.My.Resources.Resources.madison_logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnlLeft.Controls.Add(Me.Panel4)
        Me.pnlLeft.Controls.Add(Me.pnlStocks)
        Me.pnlLeft.Controls.Add(Me.PictureBox1)
        Me.pnlLeft.Controls.Add(Me.pnlDelivery)
        Me.pnlLeft.Controls.Add(Me.pnlBranches)
        Me.pnlLeft.Controls.Add(Me.btnDelivery)
        Me.pnlLeft.Controls.Add(Me.pnlRack)
        Me.pnlLeft.Controls.Add(Me.pnlReports)
        Me.pnlLeft.Controls.Add(Me.btnStocks)
        Me.pnlLeft.Controls.Add(Me.btnReports)
        Me.pnlLeft.Controls.Add(Me.pnlEmployee)
        Me.pnlLeft.Controls.Add(Me.btnRack)
        Me.pnlLeft.Controls.Add(Me.btnBranches)
        Me.pnlLeft.Controls.Add(Me.pnlProducts)
        Me.pnlLeft.Controls.Add(Me.btnEmployee)
        Me.pnlLeft.Controls.Add(Me.btnProducts)
        Me.pnlLeft.Controls.Add(Me.pnlSupplier)
        Me.pnlLeft.Controls.Add(Me.btnSupplier)
        Me.pnlLeft.Controls.Add(Me.pnlDashboard)
        Me.pnlLeft.Controls.Add(Me.btnDashboard)
        Me.pnlLeft.Controls.Add(Me.Panel5)
        Me.pnlLeft.Controls.Add(Me.lblProfileName)
        Me.pnlLeft.Controls.Add(Me.lblUserName)
        Me.pnlLeft.Controls.Add(Me.btnSettings)
        Me.pnlLeft.Controls.Add(Me.btnLogOut)
        Me.pnlLeft.Controls.Add(Me.picProfile)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(225, 679)
        Me.pnlLeft.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 108)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(225, 1)
        Me.Panel4.TabIndex = 2
        '
        'pnlStocks
        '
        Me.pnlStocks.BackColor = System.Drawing.Color.White
        Me.pnlStocks.Location = New System.Drawing.Point(0, 547)
        Me.pnlStocks.Name = "pnlStocks"
        Me.pnlStocks.Size = New System.Drawing.Size(225, 1)
        Me.pnlStocks.TabIndex = 19
        Me.pnlStocks.Visible = False
        '
        'pnlDelivery
        '
        Me.pnlDelivery.BackColor = System.Drawing.Color.White
        Me.pnlDelivery.Location = New System.Drawing.Point(0, 594)
        Me.pnlDelivery.Name = "pnlDelivery"
        Me.pnlDelivery.Size = New System.Drawing.Size(225, 1)
        Me.pnlDelivery.TabIndex = 21
        Me.pnlDelivery.Visible = False
        '
        'pnlBranches
        '
        Me.pnlBranches.BackColor = System.Drawing.Color.White
        Me.pnlBranches.Location = New System.Drawing.Point(0, 406)
        Me.pnlBranches.Name = "pnlBranches"
        Me.pnlBranches.Size = New System.Drawing.Size(225, 1)
        Me.pnlBranches.TabIndex = 13
        Me.pnlBranches.Visible = False
        '
        'btnDelivery
        '
        Me.btnDelivery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelivery.BackColor = System.Drawing.Color.Transparent
        Me.btnDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelivery.FlatAppearance.BorderSize = 0
        Me.btnDelivery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivery.ForeColor = System.Drawing.Color.White
        Me.btnDelivery.Image = Global.Inventory_System.My.Resources.Resources.ic_delivery
        Me.btnDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelivery.Location = New System.Drawing.Point(0, 552)
        Me.btnDelivery.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnDelivery.Size = New System.Drawing.Size(225, 38)
        Me.btnDelivery.TabIndex = 22
        Me.btnDelivery.Text = "    Delivery"
        Me.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelivery.UseVisualStyleBackColor = False
        Me.btnDelivery.Visible = False
        '
        'pnlRack
        '
        Me.pnlRack.BackColor = System.Drawing.Color.White
        Me.pnlRack.Location = New System.Drawing.Point(0, 453)
        Me.pnlRack.Name = "pnlRack"
        Me.pnlRack.Size = New System.Drawing.Size(225, 1)
        Me.pnlRack.TabIndex = 15
        Me.pnlRack.Visible = False
        '
        'pnlReports
        '
        Me.pnlReports.BackColor = System.Drawing.Color.White
        Me.pnlReports.Location = New System.Drawing.Point(0, 641)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(225, 1)
        Me.pnlReports.TabIndex = 23
        Me.pnlReports.Visible = False
        '
        'btnStocks
        '
        Me.btnStocks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStocks.BackColor = System.Drawing.Color.Transparent
        Me.btnStocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStocks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStocks.FlatAppearance.BorderSize = 0
        Me.btnStocks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnStocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStocks.ForeColor = System.Drawing.Color.White
        Me.btnStocks.Image = Global.Inventory_System.My.Resources.Resources.ic_stocks
        Me.btnStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStocks.Location = New System.Drawing.Point(0, 505)
        Me.btnStocks.Margin = New System.Windows.Forms.Padding(1)
        Me.btnStocks.Name = "btnStocks"
        Me.btnStocks.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnStocks.Size = New System.Drawing.Size(225, 38)
        Me.btnStocks.TabIndex = 20
        Me.btnStocks.Text = "    Stocks"
        Me.btnStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStocks.UseVisualStyleBackColor = False
        Me.btnStocks.Visible = False
        '
        'btnReports
        '
        Me.btnReports.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReports.BackColor = System.Drawing.Color.Transparent
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Image = Global.Inventory_System.My.Resources.Resources.ic_reports
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(0, 599)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(1)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnReports.Size = New System.Drawing.Size(225, 38)
        Me.btnReports.TabIndex = 24
        Me.btnReports.Text = "    Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReports.UseVisualStyleBackColor = False
        Me.btnReports.Visible = False
        '
        'pnlEmployee
        '
        Me.pnlEmployee.BackColor = System.Drawing.Color.White
        Me.pnlEmployee.Location = New System.Drawing.Point(0, 312)
        Me.pnlEmployee.Name = "pnlEmployee"
        Me.pnlEmployee.Size = New System.Drawing.Size(225, 1)
        Me.pnlEmployee.TabIndex = 9
        Me.pnlEmployee.Visible = False
        '
        'btnRack
        '
        Me.btnRack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRack.BackColor = System.Drawing.Color.Transparent
        Me.btnRack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRack.FlatAppearance.BorderSize = 0
        Me.btnRack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnRack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnRack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRack.ForeColor = System.Drawing.Color.White
        Me.btnRack.Image = Global.Inventory_System.My.Resources.Resources.ic_rack
        Me.btnRack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRack.Location = New System.Drawing.Point(0, 411)
        Me.btnRack.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRack.Name = "btnRack"
        Me.btnRack.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnRack.Size = New System.Drawing.Size(225, 38)
        Me.btnRack.TabIndex = 16
        Me.btnRack.Text = "    Rack / Level"
        Me.btnRack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRack.UseVisualStyleBackColor = False
        Me.btnRack.Visible = False
        '
        'btnBranches
        '
        Me.btnBranches.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBranches.BackColor = System.Drawing.Color.Transparent
        Me.btnBranches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBranches.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBranches.FlatAppearance.BorderSize = 0
        Me.btnBranches.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnBranches.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnBranches.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBranches.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBranches.ForeColor = System.Drawing.Color.White
        Me.btnBranches.Image = Global.Inventory_System.My.Resources.Resources.ic_branches
        Me.btnBranches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBranches.Location = New System.Drawing.Point(0, 364)
        Me.btnBranches.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBranches.Name = "btnBranches"
        Me.btnBranches.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnBranches.Size = New System.Drawing.Size(225, 38)
        Me.btnBranches.TabIndex = 14
        Me.btnBranches.Text = "    Branches"
        Me.btnBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBranches.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBranches.UseVisualStyleBackColor = False
        Me.btnBranches.Visible = False
        '
        'pnlProducts
        '
        Me.pnlProducts.BackColor = System.Drawing.Color.White
        Me.pnlProducts.Location = New System.Drawing.Point(0, 500)
        Me.pnlProducts.Name = "pnlProducts"
        Me.pnlProducts.Size = New System.Drawing.Size(225, 1)
        Me.pnlProducts.TabIndex = 17
        Me.pnlProducts.Visible = False
        '
        'btnEmployee
        '
        Me.btnEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEmployee.BackColor = System.Drawing.Color.Transparent
        Me.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployee.FlatAppearance.BorderSize = 0
        Me.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.ForeColor = System.Drawing.Color.White
        Me.btnEmployee.Image = Global.Inventory_System.My.Resources.Resources.ic_employee
        Me.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployee.Location = New System.Drawing.Point(0, 270)
        Me.btnEmployee.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnEmployee.Size = New System.Drawing.Size(225, 38)
        Me.btnEmployee.TabIndex = 10
        Me.btnEmployee.Text = "    Employee"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmployee.UseVisualStyleBackColor = False
        Me.btnEmployee.Visible = False
        '
        'btnProducts
        '
        Me.btnProducts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProducts.BackColor = System.Drawing.Color.Transparent
        Me.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.ForeColor = System.Drawing.Color.White
        Me.btnProducts.Image = Global.Inventory_System.My.Resources.Resources.ic_products
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(0, 458)
        Me.btnProducts.Margin = New System.Windows.Forms.Padding(1)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnProducts.Size = New System.Drawing.Size(225, 38)
        Me.btnProducts.TabIndex = 18
        Me.btnProducts.Text = "    Products"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = False
        Me.btnProducts.Visible = False
        '
        'pnlSupplier
        '
        Me.pnlSupplier.BackColor = System.Drawing.Color.White
        Me.pnlSupplier.Location = New System.Drawing.Point(0, 359)
        Me.pnlSupplier.Name = "pnlSupplier"
        Me.pnlSupplier.Size = New System.Drawing.Size(225, 1)
        Me.pnlSupplier.TabIndex = 11
        Me.pnlSupplier.Visible = False
        '
        'btnSupplier
        '
        Me.btnSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSupplier.BackColor = System.Drawing.Color.Transparent
        Me.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSupplier.FlatAppearance.BorderSize = 0
        Me.btnSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.ForeColor = System.Drawing.Color.White
        Me.btnSupplier.Image = Global.Inventory_System.My.Resources.Resources.ic_supplier
        Me.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupplier.Location = New System.Drawing.Point(0, 317)
        Me.btnSupplier.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnSupplier.Size = New System.Drawing.Size(225, 38)
        Me.btnSupplier.TabIndex = 12
        Me.btnSupplier.Text = "    Supplier"
        Me.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSupplier.UseVisualStyleBackColor = False
        Me.btnSupplier.Visible = False
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BackColor = System.Drawing.Color.White
        Me.pnlDashboard.Location = New System.Drawing.Point(0, 265)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(225, 1)
        Me.pnlDashboard.TabIndex = 2
        '
        'btnDashboard
        '
        Me.btnDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.Inventory_System.My.Resources.Resources.ic_home
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 223)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(225, 38)
        Me.btnDashboard.TabIndex = 8
        Me.btnDashboard.Text = "    Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(0, 220)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(225, 1)
        Me.Panel5.TabIndex = 1
        '
        'lblProfileName
        '
        Me.lblProfileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProfileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileName.ForeColor = System.Drawing.Color.White
        Me.lblProfileName.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblProfileName.Location = New System.Drawing.Point(12, 199)
        Me.lblProfileName.Name = "lblProfileName"
        Me.lblProfileName.Size = New System.Drawing.Size(202, 18)
        Me.lblProfileName.TabIndex = 7
        Me.lblProfileName.Text = "Sunny Ang"
        '
        'lblUserName
        '
        Me.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblUserName.Location = New System.Drawing.Point(98, 125)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(116, 18)
        Me.lblUserName.TabIndex = 6
        Me.lblUserName.Text = "Supervisor"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.AutoSize = True
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Image = Global.Inventory_System.My.Resources.Resources.settings
        Me.btnSettings.Location = New System.Drawing.Point(153, 153)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(50, 45)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.AutoSize = True
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Image = Global.Inventory_System.My.Resources.Resources.logout
        Me.btnLogOut.Location = New System.Drawing.Point(101, 153)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(50, 45)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.Image = Global.Inventory_System.My.Resources.Resources.default_user
        Me.picProfile.InitialImage = Global.Inventory_System.My.Resources.Resources.frm_user
        Me.picProfile.Location = New System.Drawing.Point(12, 116)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(80, 80)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 1
        Me.picProfile.TabStop = False
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 679)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1071, 30)
        Me.pnlBottom.TabIndex = 10
        '
        'MDIHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1071, 709)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlBottom)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MDIHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Madison Inventory System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblProfileName As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents picProfile As System.Windows.Forms.PictureBox
    Friend WithEvents pnlDashboard As System.Windows.Forms.Panel
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents pnlStocks As System.Windows.Forms.Panel
    Friend WithEvents pnlBranches As System.Windows.Forms.Panel
    Friend WithEvents pnlRack As System.Windows.Forms.Panel
    Friend WithEvents btnStocks As System.Windows.Forms.Button
    Friend WithEvents pnlEmployee As System.Windows.Forms.Panel
    Friend WithEvents btnRack As System.Windows.Forms.Button
    Friend WithEvents btnBranches As System.Windows.Forms.Button
    Friend WithEvents pnlProducts As System.Windows.Forms.Panel
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents pnlSupplier As System.Windows.Forms.Panel
    Friend WithEvents btnSupplier As System.Windows.Forms.Button
    Friend WithEvents pnlDelivery As System.Windows.Forms.Panel
    Friend WithEvents btnDelivery As System.Windows.Forms.Button
    Friend WithEvents pnlReports As System.Windows.Forms.Panel
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
