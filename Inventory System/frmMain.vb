Public Class frmMain
    

    Sub side_menu_orig_form()
        'side menu will back to orig form when its open
        Panel2.Location = New Point(-178, 24)
    End Sub
    Sub hide_sidemenu()
        Panel2.Location = New Point(0, 24)
        Do Until Panel2.Location.X = -178
            Panel2.Location = New Point(Panel2.Location.X - 1, 24)
        Loop
        Do Until Panel2.Location.X = -178
            Panel2.Location = New Point(Panel2.Location.X - 1, 24)
            System.Threading.Thread.Sleep(20)
            Refresh()

        Loop
    End Sub
    Sub show_sidemenu()
        Panel2.Location = New Point(-178, 24)
        Do Until Panel2.Location.X = -10
            Panel2.Location = New Point(Panel2.Location.X + 1, 24)
        Loop

        Do Until Panel2.Location.X = 0
            Panel2.Location = New Point(Panel2.Location.X + 1, 24)

            System.Threading.Thread.Sleep(20)

        Loop
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        show_sidemenu()
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        hide_sidemenu()

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlViewForm.SendToBack()

    End Sub

    
    Private Sub btnAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccount.Click
        'call function to return in orig form
        side_menu_orig_form()

        'show form in pnlViewForm
        pnlViewForm.Controls.Clear()
        frmEmployee.TopLevel = False
        frmEmployee.TopMost = True
        Me.pnlViewForm.Controls.Add(frmEmployee)
        frmEmployee.Show()

    End Sub

    Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduct.Click
        'call function to return in orig form
        side_menu_orig_form()

        'show form in pnlViewForm
        pnlViewForm.Controls.Clear()
        frmProducts.TopLevel = False
        frmProducts.TopMost = True
        Me.pnlViewForm.Controls.Add(frmProducts)
        frmProducts.Show()

    End Sub

    Private Sub btnStockIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStockIn.Click
        'call function to return in orig form
        side_menu_orig_form()

        'show form in pnlViewForm
        pnlViewForm.Controls.Clear()
        frmStocks.TopLevel = False
        frmStocks.TopMost = True
        Me.pnlViewForm.Controls.Add(frmStocks)
        frmStocks.Show()
    End Sub

    Private Sub btnStockOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStockOut.Click
        'call function to return in orig form
        side_menu_orig_form()

        'show form in pnlViewForm
        pnlViewForm.Controls.Clear()
        frmDelivery.TopLevel = False
        frmDelivery.TopMost = True
        Me.pnlViewForm.Controls.Add(frmDelivery)
        frmDelivery.Show()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub pnlViewForm_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlViewForm.Paint

    End Sub
End Class