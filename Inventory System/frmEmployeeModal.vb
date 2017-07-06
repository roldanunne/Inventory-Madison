Public Class frmEmployeeModal
    Private profilePath = imgPath & "\profile"
    Public empModalID = 0
    Public empModalTask = ""
    Public empModalRow As DataGridViewRow

    Private Sub frmEmployeeModal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setCenterModalForm(MDIHome, Me)

        If Len(Dir(profilePath, vbDirectory)) = 0 Then
            MkDir(profilePath)
        End If

        If empModalTask = "NEW" Then
            btnSave.Text = "Save"
            btnEditAccount.Visible = False
            gbxAccount.Visible = True
            Me.Height = 445
            modFormFuction.setClearAll(Me)
        ElseIf empModalTask = "EDIT" Then
            btnSave.Text = "Update"
            btnEditAccount.Visible = True
            gbxAccount.Visible = False
            Me.Height = 345
            empModalID = empModalRow.Cells("id").Value
            txtFName.Text = empModalRow.Cells("fname").Value.ToString
            txtLName.Text = empModalRow.Cells("lname").Value.ToString
            txtAddress.Text = empModalRow.Cells("address").Value.ToString
            cmbGender.Text = empModalRow.Cells("gender").Value.ToString
            cmbStatus.Text = empModalRow.Cells("stat").Value.ToString
            txtUsername.Text = empModalRow.Cells("username").Value.ToString
            txtPassword.Text = empModalRow.Cells("password").Value.ToString
            txtRetype.Text = empModalRow.Cells("password").Value.ToString

            Dim filePath = profilePath & "\" & empModalID & ".jpg"
            If My.Computer.FileSystem.FileExists(filePath) Then
                Dim tmpPic As New System.IO.FileStream(filePath, IO.FileMode.Open, IO.FileAccess.Read)
                Dim img As Image = Image.FromStream(tmpPic)
                tmpPic.Close()
                modFormFuction.ResizePicture(Me.picProfile, img)
            Else
                modFormFuction.ResizePicture(Me.picProfile, My.Resources.default_user)
            End If

            Dim access As String() = empModalRow.Cells("useraccess").Value.ToString.Split(New Char() {","c})
            Dim item As String

            For Each ctrl As Control In gbxMenus.Controls
                If TypeOf ctrl Is CheckBox Then
                    CType(ctrl, CheckBox).CheckState = CheckState.Unchecked
                End If
            Next

            For Each item In access
                If item = "1" Then
                    chkEmployee.Checked = True
                ElseIf item = "2" Then
                    chkSupplier.Checked = True
                ElseIf item = "3" Then
                    chkBranch.Checked = True
                ElseIf item = "4" Then
                    chkRack.Checked = True
                ElseIf item = "5" Then
                    chkProducts.Checked = True
                ElseIf item = "6" Then
                    chkStocks.Checked = True
                ElseIf item = "7" Then
                    chkDelivery.Checked = True
                ElseIf item = "8" Then
                    chkReport.Checked = True
                End If
            Next
        Else
            Me.Close()
        End If
    End Sub


    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Me.picProfile.Image = Nothing
        Me.ofdProfile.FileName = Nothing
        Me.ofdProfile.ShowDialog()
        If Me.ofdProfile.FileName() <> Nothing Then
            Dim tmpPic As New System.IO.FileStream(Me.ofdProfile.FileName(), IO.FileMode.Open, IO.FileAccess.Read)
            Dim img As Image = Image.FromStream(tmpPic)
            tmpPic.Close()
            'Dim img As Image = Image.FromFile(Me.ofdProfile.FileName())
            modFormFuction.ResizePicture(Me.picProfile, img)
        End If
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If empModalTask = "NEW" Then
            If modFormFuction.setIsTextEmpty(Me.gbxDetails) = True Or modFormFuction.setIsTextEmpty(Me.gbxAccount) = True Or getSelectedMenus() = "" Then
                MessageBox.Show("Please Fill All Records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtPassword.Text <> txtRetype.Text Then
                MessageBox.Show("Password did not matched!", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim stat As Integer = If(cmbStatus.Text = "Active", 1, 0)
                Dim result As Integer = modEmployeeCtlr.saveEmployee(txtFName.Text, txtLName.Text, cmbGender.Text, txtAddress.Text, stat, getSelectedMenus(), txtUsername.Text, txtPassword.Text)
                If result <> 0 Then
                    Dim tempPath As String = profilePath & "\" & result & ".jpg"
                    If (System.IO.File.Exists(tempPath)) = True Then
                        System.IO.File.Delete(tempPath)
                    End If
                    picProfile.Image.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg)
                    frmEmployee.picProfile.Image = picProfile.Image
                    frmEmployee.loadDataEmployee()
                    Me.Close()
                Else
                    MessageBox.Show("Please try again." & result, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        ElseIf empModalTask = "EDIT" Then
            If modFormFuction.setIsTextEmpty(Me.gbxDetails) = True Or modFormFuction.setIsTextEmpty(Me.gbxAccount) = True Or getSelectedMenus() = "" Then
                MessageBox.Show("Please Fill All Records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtPassword.Text <> txtRetype.Text Then
                MessageBox.Show("Password did not matched!", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim stat As Integer = If(cmbStatus.Text = "Active", 1, 0)
                Dim result As Boolean = modEmployeeCtlr.updateEmployee(empModalID, txtFName.Text, txtLName.Text, cmbGender.Text, txtAddress.Text, stat, getSelectedMenus(), txtUsername.Text, txtPassword.Text)
                If result Then
                    Dim tempPath As String = profilePath & "\" & empModalID & ".jpg"
                    If (System.IO.File.Exists(tempPath)) = True Then
                        System.IO.File.Delete(tempPath)
                    End If
                    picProfile.Image.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg)
                    frmEmployee.picProfile.Image = picProfile.Image
                    frmEmployee.loadDataEmployee()
                    Me.Close()
                Else
                    MessageBox.Show("Please try again.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub


    Public Function getSelectedMenus() As String
        Dim menus As String = ""
        If chkEmployee.Checked Then
            menus &= "1,"
        End If
        If chkSupplier.Checked Then
            menus &= "2,"
        End If
        If chkBranch.Checked Then
            menus &= "3,"
        End If
        If chkRack.Checked Then
            menus &= "4,"
        End If
        If chkProducts.Checked Then
            menus &= "5,"
        End If
        If chkStocks.Checked Then
            menus &= "6,"
        End If
        If chkDelivery.Checked Then
            menus &= "7,"
        End If
        If chkReport.Checked Then
            menus &= "8,"
        End If
        Return menus
    End Function


    Private Sub picProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picProfile.Click
        btnBrowse.PerformClick()
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub btnEditAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAccount.Click
        If gbxAccount.Visible Then
            btnEditAccount.Text = "Edit Account"
            gbxAccount.Visible = False
            Me.Height = 345
        Else
            btnEditAccount.Text = "Hide Account"
            gbxAccount.Visible = True
            Me.Height = 450
        End If
    End Sub

End Class