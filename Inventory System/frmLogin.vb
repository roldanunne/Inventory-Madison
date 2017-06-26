Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modFormFuction.setCenterPanel(Me, pnlLogin)
        txtUsername.Focus()
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        txtPassword.Text = ""
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If modFormFuction.setIsTextEmpty(Me) = True Then
            MessageBox.Show("Please Enter Username or Password.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf modLoginCtlr.getLogin(txtUsername.Text, txtPassword.Text) = True Then
            MDIHome.Show()
            Me.Close()
        Else
            MessageBox.Show("Please Check User Name or Password if correct...", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub bntClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntClose.Click
        End
    End Sub
End Class