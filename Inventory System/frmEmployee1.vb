Public Class frmEmployee1
    Private profilePath = imgPath & "\profile"

    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Len(Dir(profilePath, vbDirectory)) = 0 Then
            MkDir(profilePath)
        End If

        loadDataEmployee()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Me.picProfile.Image = Nothing
        Me.ofdProfile.FileName = Nothing
        Me.ofdProfile.ShowDialog()
        If Me.ofdProfile.FileName() <> Nothing Then
            Dim img As Image = Image.FromFile(Me.ofdProfile.FileName())
            modFormFuction.ResizePicture(Me.picProfile, img)
        End If
    End Sub


    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        If btnEmployee.Text = "New" Then
            modFormFuction.setClearAll(Me)
            defaultSaveUpdate("Save")
        ElseIf btnEmployee.Text = "Save" Then
            If modFormFuction.setIsTextEmpty(Me.gbxDetails) = True Or modFormFuction.setIsTextEmpty(Me.gbxAccount) = True Or getSelectedMenus() = "" Then
                MessageBox.Show("Please Fill All Records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtPassword.Text <> txtRetype.Text Then
                MessageBox.Show("Password did not matched!", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim stat As Integer = If(cmbStatus.Text = "Active", 1, 0)
                Dim result As Integer = modEmployeeCtlr.saveEmployee(txtFName.Text, txtLName.Text, cmbGender.Text, txtAddress.Text, stat, getSelectedMenus(), txtUsername.Text, txtPassword.Text)
                If result <> 0 Then
                    picProfile.Image.Save(profilePath & "\" & result & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                    defaultAdd()
                    loadDataEmployee()
                Else
                    MessageBox.Show("Please try again." & result, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        ElseIf btnEmployee.Text = "Update" Then
            If modFormFuction.setIsTextEmpty(Me.gbxDetails) = True Or modFormFuction.setIsTextEmpty(Me.gbxAccount) = True Or getSelectedMenus() = "" Then
                MessageBox.Show("Please Fill All Records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtPassword.Text <> txtRetype.Text Then
                MessageBox.Show("Password did not matched!", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim stat As Integer = If(cmbStatus.Text = "Active", 1, 0)
                Dim result As Boolean = modEmployeeCtlr.updateEmployee(txtId.Text, txtFName.Text, txtLName.Text, cmbGender.Text, txtAddress.Text, stat, getSelectedMenus(), txtUsername.Text, txtPassword.Text)
                If result Then
                    picProfile.Image.Save(profilePath & "\" & txtId.Text & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                    defaultAdd()
                    loadDataEmployee()
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

    Public Sub defaultAdd()
        btnEmployee.BackColor = Color.ForestGreen
        btnEmployee.Image = My.Resources.Resources.add_user
        gbxDetails.Enabled = False
        gbxProfile.Enabled = False
        gbxAccount.Enabled = False
        gbxMenus.Enabled = False
        pnlEmployeeList.Enabled = True
        btnEmployee.Text = "New"
        btnCancelDelete.Text = "Delete"
        btnCancelDelete.BackColor = Color.Coral
    End Sub

    Public Sub defaultSaveUpdate(ByVal title As String)
        btnEmployee.BackColor = Color.FromArgb(51, 122, 183)
        btnEmployee.Image = My.Resources.Resources.save_user
        gbxDetails.Enabled = True
        gbxProfile.Enabled = True
        gbxAccount.Enabled = True
        gbxMenus.Enabled = True
        pnlEmployeeList.Enabled = False
        btnEmployee.Text = title
        btnCancelDelete.Text = "Cancel"
        btnCancelDelete.BackColor = Color.IndianRed
    End Sub


    Private Sub picProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picProfile.Click
        btnBrowse.PerformClick()
    End Sub

    Private Sub loadDataEmployee()
        modEmployeeCtlr.loadEmployee(dgvEmployee)
    End Sub

    Private Sub dgvEmployee_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmployee.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvEmployee.Rows(e.RowIndex)
            txtId.Text = row.Cells("id").Value.ToString
            txtFName.Text = row.Cells("fname").Value.ToString
            txtLName.Text = row.Cells("lname").Value.ToString
            cmbGender.Text = row.Cells("gender").Value.ToString
            txtAddress.Text = row.Cells("address").Value.ToString
            cmbStatus.Text = row.Cells("stat").Value.ToString
            txtUsername.Text = row.Cells("username").Value.ToString
            txtPassword.Text = row.Cells("password").Value.ToString
            txtRetype.Text = row.Cells("password").Value.ToString

            Dim filePath = profilePath & "\" & txtId.Text & ".jpg"
            If My.Computer.FileSystem.FileExists(filePath) Then
                Dim img As Image = Image.FromFile(filePath)
                modFormFuction.ResizePicture(Me.picProfile, img)
            End If

            Dim access As String() = row.Cells("user_access").Value.ToString.Split(New Char() {","c})
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

            If txtId.Text = "1" Then
                cmbStatus.Enabled = False
            Else
                cmbStatus.Enabled = True
            End If
        End If
    End Sub

    Private Sub dgvEmployee_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmployee.CellDoubleClick
        If Not dgvEmployee.SelectedCells.Count = 0 Then
            If MessageBox.Show("Do you want to change something is this record?", "Profile Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                defaultSaveUpdate("Update")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        mdiMain.btnProducts.PerformClick()
    End Sub

    Private Sub btnCancelDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelDelete.Click
        If btnCancelDelete.Text = "Delete" Then
            If txtId.Text = "1" Then
                MessageBox.Show("Sorry, you cannot delete this administrator account.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtId.Text <> "" Then
                If MessageBox.Show("You will delete " & txtFName.Text & " " & txtLName.Text & " on this record? Are you sure?", "Profile Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                    Dim result As Boolean = modEmployeeCtlr.deleteEmployee(txtId.Text)
                    If result Then
                        loadDataEmployee()
                    Else
                        MessageBox.Show("Please try again.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Please select a record to delete.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf btnCancelDelete.Text = "Cancel" Then
            modFormFuction.setClearAll(Me)
            defaultAdd()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim strQry As String = "SELECT id, fname, lname, gender, address, user_access, username, password, status, IF(status = 0, 'Inactive', 'Active') AS stat FROM employee WHERE delete_flag=0 AND fname LIKE '%" & txtSearch.Text & "%' OR lname LIKE '%" & txtSearch.Text & "%' OR gender LIKE '%" & txtSearch.Text & "%' OR address LIKE '%" & txtSearch.Text & "%' "
        modSqlFunction.loadDataGrid(strQry, dgvEmployee)
    End Sub
End Class