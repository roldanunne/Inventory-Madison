Imports System.Windows.Forms

Public Class MDIHome

    Private Declare Auto Function SetWindowLong Lib "User32.Dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Private Declare Auto Function GetWindowLong Lib "User32.Dll" (ByVal hWnd As System.IntPtr, ByVal nIndex As Integer) As Integer
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200
    Private profilePath = imgPath & "\profile"
    Private btn_location As New Point(0, 270)
    Private pnl_location As New Point(0, 312)
    Private btn_active As Integer = 0

    Private Sub MDIHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' SET BACKGROUND COLOR AND REMOVE BORDER FROM MDICLIENT CONTROL
        For Each c As Control In Me.Controls()
            If TypeOf (c) Is MdiClient Then
                c.BackColor = Color.White
                Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
                windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
                SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                c.Width = c.Width + 1
                Exit For
            End If
        Next

        If Len(Dir(profilePath, vbDirectory)) = 0 Then
            MkDir(profilePath)
        End If

        Dim filePath = profilePath & "\" & USER_ID & ".jpg"
        If My.Computer.FileSystem.FileExists(filePath) Then
            Dim img As Image = Image.FromFile(filePath)
            modFormFuction.ResizePicture(Me.picProfile, img)
        Else
            modFormFuction.ResizePicture(Me.picProfile, My.Resources.default_user)
        End If

        lblProfileName.Text = USER_FULLNAME
        lblUserName.Text = USER_NAME

        load_button_menu()
        loadButtonActive()
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MessageBox.Show("Do You Want to CLOSED the System?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            End
        End If
    End Sub


    Public Sub showChildForm(ByRef Cfrm As Form, ByRef Pfrm As Form, ByVal Stat As Boolean)
        If Stat = False Then
            Cfrm.MdiParent = Pfrm
            Cfrm.Dock = DockStyle.Fill
            Cfrm.Show()
        Else
            Cfrm.Activate()
        End If
    End Sub


    Public Function ActiveChildMDI(ByVal cfrm As Form, ByRef Pfrm As Form) As Boolean
        For Each f As Form In Pfrm.MdiChildren()
            If f.Name = cfrm.Name Then
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        showChildForm(frmEmployee, Me, ActiveChildMDI(frmEmployee, Me))
        btn_active = 1
        loadButtonActive()
    End Sub


    Private Sub btnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplier.Click
        showChildForm(frmSupplier, Me, ActiveChildMDI(frmSupplier, Me))
        btn_active = 2
        loadButtonActive()
    End Sub


    Private Sub load_button_menu()
        Dim access As String() = USER_ACCESS.Split(New Char() {","c})
        Dim item As String
        For Each item In access
            If item = "1" Then
                btnEmployee.Visible = True
                btnEmployee.Location = New Point(0, btn_location.Y)
                pnlEmployee.Visible = True
                pnlEmployee.Location = New Point(0, pnl_location.Y)
            ElseIf item = "2" Then
                btnSupplier.Visible = True
                btnSupplier.Location = New Point(0, btn_location.Y)
                pnlSupplier.Visible = True
                pnlSupplier.Location = New Point(0, pnl_location.Y)
            ElseIf item = "3" Then
                btnBranches.Visible = True
                btnBranches.Location = New Point(0, btn_location.Y)
                pnlBranches.Visible = True
                pnlBranches.Location = New Point(0, pnl_location.Y)
            ElseIf item = "4" Then
                btnRack.Visible = True
                btnRack.Location = New Point(0, btn_location.Y)
                pnlRack.Visible = True
                pnlRack.Location = New Point(0, pnl_location.Y)
            ElseIf item = "5" Then
                btnProducts.Visible = True
                btnProducts.Location = New Point(0, btn_location.Y)
                pnlProducts.Visible = True
                pnlProducts.Location = New Point(0, pnl_location.Y)
            ElseIf item = "6" Then
                btnStocks.Visible = True
                btnStocks.Location = New Point(0, btn_location.Y)
                pnlStocks.Visible = True
                pnlStocks.Location = New Point(0, pnl_location.Y)
            ElseIf item = "7" Then
                btnDelivery.Visible = True
                btnDelivery.Location = New Point(0, btn_location.Y)
                pnlDelivery.Visible = True
                pnlDelivery.Location = New Point(0, pnl_location.Y)
            ElseIf item = "8" Then
                btnReports.Visible = True
                btnReports.Location = New Point(0, btn_location.Y)
                pnlReports.Visible = True
                pnlReports.Location = New Point(0, pnl_location.Y)
            End If
            btn_location.Y += 47
            pnl_location.Y += 47
        Next
    End Sub

    Private Sub loadButtonActive()
        For Each ctrl As Control In pnlLeft.Controls()
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = Color.Transparent
                If btn_active = 0 Then
                    btnDashboard.BackColor = Color.RoyalBlue
                ElseIf btn_active = 1 Then
                    btnEmployee.BackColor = Color.RoyalBlue
                ElseIf btn_active = 2 Then
                    btnSupplier.BackColor = Color.RoyalBlue
                ElseIf btn_active = 3 Then
                    btnBranches.BackColor = Color.RoyalBlue
                ElseIf btn_active = 4 Then
                    btnRack.BackColor = Color.RoyalBlue
                ElseIf btn_active = 5 Then
                    btnProducts.BackColor = Color.RoyalBlue
                ElseIf btn_active = 6 Then
                    btnStocks.BackColor = Color.RoyalBlue
                ElseIf btn_active = 7 Then
                    btnDelivery.BackColor = Color.RoyalBlue
                ElseIf btn_active = 8 Then
                    btnReports.BackColor = Color.RoyalBlue
                End If
            End If
        Next
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("Logout your account. Are you sure?", "Logout System", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnBranches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBranches.Click
        showChildForm(frmBranch, Me, ActiveChildMDI(frmBranch, Me))
        btn_active = 3
        loadButtonActive()
    End Sub
End Class
