<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlViewForm = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlViewForm
        '
        Me.pnlViewForm.BackColor = System.Drawing.Color.White
        Me.pnlViewForm.Location = New System.Drawing.Point(105, 0)
        Me.pnlViewForm.Name = "pnlViewForm"
        Me.pnlViewForm.Size = New System.Drawing.Size(1278, 704)
        Me.pnlViewForm.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnStockOut)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnMenu)
        Me.Panel2.Controls.Add(Me.btnReport)
        Me.Panel2.Controls.Add(Me.btnStockIn)
        Me.Panel2.Controls.Add(Me.btnAccount)
        Me.Panel2.Controls.Add(Me.btnProduct)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(271, 704)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Inventory_System.My.Resources.Resources.snav_btn_active
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(11, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 57)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnStockOut
        '
        Me.btnStockOut.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnStockOut.BackgroundImage = CType(resources.GetObject("btnStockOut.BackgroundImage"), System.Drawing.Image)
        Me.btnStockOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStockOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockOut.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnStockOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnStockOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnStockOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockOut.Location = New System.Drawing.Point(1, 290)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(231, 60)
        Me.btnStockOut.TabIndex = 9
        Me.btnStockOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockOut.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Auto Performance Center"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(81, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Madison"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.BackgroundImage = CType(resources.GetObject("btnMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Location = New System.Drawing.Point(193, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(39, 41)
        Me.btnMenu.TabIndex = 5
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnReport.BackgroundImage = CType(resources.GetObject("btnReport.BackgroundImage"), System.Drawing.Image)
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(0, 348)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(231, 60)
        Me.btnReport.TabIndex = 4
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnStockIn
        '
        Me.btnStockIn.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnStockIn.BackgroundImage = CType(resources.GetObject("btnStockIn.BackgroundImage"), System.Drawing.Image)
        Me.btnStockIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStockIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockIn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnStockIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnStockIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnStockIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockIn.Location = New System.Drawing.Point(0, 232)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(231, 60)
        Me.btnStockIn.TabIndex = 3
        Me.btnStockIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockIn.UseVisualStyleBackColor = False
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnAccount.BackgroundImage = CType(resources.GetObject("btnAccount.BackgroundImage"), System.Drawing.Image)
        Me.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.Location = New System.Drawing.Point(0, 116)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(231, 60)
        Me.btnAccount.TabIndex = 2
        Me.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnProduct.BackgroundImage = CType(resources.GetObject("btnProduct.BackgroundImage"), System.Drawing.Image)
        Me.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.Location = New System.Drawing.Point(0, 174)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(231, 60)
        Me.btnProduct.TabIndex = 2
        Me.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduct.UseVisualStyleBackColor = False
        Me.btnProduct.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(0, 974)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1383, 41)
        Me.Panel3.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1120, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "February 2, 2017 12:27:45 AM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(172, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Administrator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "You are Logged In As : "
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1264, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlViewForm)
        Me.Name = "frmMain"
        Me.Text = "Madison Auto Accessories Inventory System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlViewForm As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents btnAccount As System.Windows.Forms.Button
    Friend WithEvents btnStockIn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnStockOut As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
