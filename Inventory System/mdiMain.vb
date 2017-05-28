Imports System.Windows.Forms

Public Class mdiMain
    Private lastFrm As Form
    Private Location_control As New Point(0, 5)
    Private button_active As Integer

    Private Sub load_button_menu()
        Dim access As String() = user_access.Split(New Char() {","c})
        Dim item As String
        For Each item In access
            Location_control.Y += 56
            If item = "1" Then
                btnEmployee.Visible = True
                btnEmployee.Location = New Point(0, Location_control.Y)
            ElseIf item = "2" Then
                btnSupplier.Visible = True
                btnSupplier.Location = New Point(0, Location_control.Y)
            ElseIf item = "3" Then
                btnBranch.Visible = True
                btnBranch.Location = New Point(0, Location_control.Y)
            ElseIf item = "4" Then
                btnRack.Visible = True
                btnRack.Location = New Point(0, Location_control.Y)
            ElseIf item = "5" Then
                btnProducts.Visible = True
                btnProducts.Location = New Point(0, Location_control.Y)
            ElseIf item = "6" Then
                btnStocks.Visible = True
                btnStocks.Location = New Point(0, Location_control.Y)
            ElseIf item = "7" Then
                btnDelivery.Visible = True
                btnDelivery.Location = New Point(0, Location_control.Y)
            ElseIf item = "8" Then
                btnReport.Visible = True
                btnReport.Location = New Point(0, Location_control.Y)
            End If
        Next
    End Sub

    Private Sub button_hover()
        For Each ctrl As Control In pnlSideNav.Controls()
            If TypeOf ctrl Is Button Then
                ctrl.BackgroundImage = My.Resources.snav_btn
                If button_active = 0 Then
                    btnHome.BackgroundImage = My.Resources.snav_btn_active
                ElseIf button_active = 1 Then
                    btnEmployee.BackgroundImage = My.Resources.snav_btn_active
                ElseIf button_active = 2 Then
                    btnSupplier.BackgroundImage = My.Resources.snav_btn_active
                ElseIf button_active = 3 Then
                    btnBranch.BackgroundImage = My.Resources.snav_btn_active
                ElseIf button_active = 4 Then
                    btnRack.BackgroundImage = My.Resources.snav_btn_active
                ElseIf button_active = 5 Then
                    btnProducts.BackgroundImage = My.Resources.snav_btn_active
                ElseIf button_active = 6 Then
                    btnStocks.BackgroundImage = My.Resources.snav_btn_active
                ElseIf button_active = 7 Then
                    btnDelivery.BackgroundImage = My.Resources.snav_btn_active
                ElseIf button_active = 8 Then
                    btnReport.BackgroundImage = My.Resources.snav_btn_active
                End If
            End If
        Next
    End Sub

    Private Sub closeLastFrm(ByVal frm As Form)
        If (lastFrm IsNot Nothing) Then
            lastFrm.Close()
        End If
        lastFrm = frm
    End Sub

    Private Sub mdiMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_button_menu()
        btnHome.PerformClick()
    End Sub

    Private Sub mdiMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Do You Want to CLOSED the System?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            frmReports.rvReport.LocalReport.ReleaseSandboxAppDomain()
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        btnNavMin.PerformClick()
        button_active = 0
        button_hover()
        btnHome.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnHome_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHome.MouseHover
        button_hover()
        btnHome.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnHome_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHome.MouseLeave
        button_hover()
    End Sub

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        btnNavMin.PerformClick()
        closeLastFrm(frmEmployee)
        pnlMain.Controls.Clear()
        frmEmployee.TopLevel = False
        frmEmployee.TopMost = True
        pnlMain.Controls.Add(frmEmployee)
        frmEmployee.Show()
        button_active = 1
        button_hover()
        btnEmployee.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnEmployee_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmployee.MouseHover
        button_hover()
        btnEmployee.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnEmployee_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmployee.MouseLeave
        button_hover()
    End Sub
    Private Sub btnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplier.Click
        btnNavMin.PerformClick()
        closeLastFrm(frmSupplier)
        pnlMain.Controls.Clear()
        frmSupplier.TopLevel = False
        frmSupplier.TopMost = True
        pnlMain.Controls.Add(frmSupplier)
        frmSupplier.Show()
        button_active = 2
        button_hover()
        btnSupplier.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnSupplier_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSupplier.MouseHover
        button_hover()
        btnSupplier.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnSupplier_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSupplier.MouseLeave
        button_hover()
    End Sub
    Private Sub btnBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBranch.Click
        btnNavMin.PerformClick()
        closeLastFrm(frmBranch)
        pnlMain.Controls.Clear()
        frmBranch.TopLevel = False
        frmBranch.TopMost = True
        pnlMain.Controls.Add(frmBranch)
        frmBranch.Show()
        button_active = 3
        button_hover()
        btnBranch.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnBranch_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBranch.MouseHover
        button_hover()
        btnBranch.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnBranch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBranch.MouseLeave
        button_hover()
    End Sub

    Private Sub btnRack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRack.Click
        btnNavMin.PerformClick()
        closeLastFrm(frmRack)
        pnlMain.Controls.Clear()
        frmRack.TopLevel = False
        frmRack.TopMost = True
        pnlMain.Controls.Add(frmRack)
        frmRack.Show()
        button_active = 4
        button_hover()
        btnRack.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnRack_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRack.MouseHover
        button_hover()
        btnRack.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnRack_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRack.MouseLeave
        button_hover()
    End Sub
    Private Sub btnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        btnNavMin.PerformClick()
        closeLastFrm(frmProducts)
        pnlMain.Controls.Clear()
        frmProducts.TopLevel = False
        frmProducts.TopMost = True
        pnlMain.Controls.Add(frmProducts)
        frmProducts.Show()
        button_active = 5
        button_hover()
        btnProducts.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnProducts_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProducts.MouseHover
        button_hover()
        btnProducts.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnProducts_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProducts.MouseLeave
        button_hover()
    End Sub

    Private Sub btnStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStocks.Click
        btnNavMin.PerformClick()
        closeLastFrm(frmStocks)
        pnlMain.Controls.Clear()
        frmStocks.TopLevel = False
        frmStocks.TopMost = True
        pnlMain.Controls.Add(frmStocks)
        frmStocks.Show()
        button_active = 6
        button_hover()
        btnStocks.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnStocks_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStocks.MouseHover
        button_hover()
        btnStocks.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnStocks_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStocks.MouseLeave
        button_hover()
    End Sub

    Private Sub btnDelivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelivery.Click
        btnNavMin.PerformClick()
        closeLastFrm(frmDelivery)
        pnlMain.Controls.Clear()
        frmDelivery.TopLevel = False
        frmDelivery.TopMost = True
        pnlMain.Controls.Add(frmDelivery)
        frmDelivery.Show()
        button_active = 7
        button_hover()
        btnDelivery.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnDelivery_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelivery.MouseHover
        button_hover()
        btnDelivery.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnDelivery_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelivery.MouseLeave
        button_hover()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        btnNavMin.PerformClick()
        closeLastFrm(frmReports)
        frmReports.TopLevel = False
        frmReports.TopMost = True
        Me.pnlMain.Controls.Clear()
        Me.pnlMain.Controls.Add(frmReports)
        frmReports.Show()
        button_active = 8
        button_hover()
        btnReport.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnReport_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReport.MouseHover
        button_hover()
        btnReport.BackgroundImage = My.Resources.snav_btn_active
    End Sub

    Private Sub btnReport_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReport.MouseLeave
        button_hover()
    End Sub

    Private Sub btnNavMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavMax.Click
        pnlSideMenu.Width = 210
        lblMadison.Visible = True
        btnNavMax.Visible = False
        btnNavMin.Visible = True
    End Sub

    Private Sub btnNavMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavMin.Click
        pnlSideMenu.Width = 73
        lblMadison.Visible = False
        btnNavMax.Visible = True
        btnNavMin.Visible = False
    End Sub

    Private Sub pnlMain_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlMain.Paint

    End Sub
End Class
