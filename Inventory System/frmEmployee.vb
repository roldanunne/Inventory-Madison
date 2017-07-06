Public Class frmEmployee
    Private profilePath = imgPath & "\profile"
    Private empID = 0
    Private empRow As DataGridViewRow


    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Len(Dir(profilePath, vbDirectory)) = 0 Then
            MkDir(profilePath)
        End If
        loadDataEmployee()
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmEmployeeModal.empModalTask = "NEW"
        frmEmployeeModal.Show()
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If empID <> 0 Then
            frmEmployeeModal.empModalID = empID
            frmEmployeeModal.empModalRow = empRow
            frmEmployeeModal.empModalTask = "EDIT"
            frmEmployeeModal.Show()
        Else
            MessageBox.Show("Please select a record to change.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    Public Sub loadDataEmployee()
        modEmployeeCtlr.loadEmployee(dgvEmployee)
        empID = 0
    End Sub


    Private Sub dgvEmployee_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmployee.CellClick
        If e.RowIndex >= 0 Then
            empRow = dgvEmployee.Rows(e.RowIndex)
            empID = empRow.Cells("id").Value
            lblFname.Text = empRow.Cells("fname").Value.ToString
            lblLname.Text = empRow.Cells("lname").Value.ToString
            lblGender.Text = empRow.Cells("gender").Value.ToString
            lblAddress.Text = empRow.Cells("address").Value.ToString
            lblStatus.Text = empRow.Cells("stat").Value.ToString

            Dim filePath = profilePath & "\" & empID & ".jpg"
            If My.Computer.FileSystem.FileExists(filePath) Then
                Dim img As Image = Image.FromFile(filePath)
                modFormFuction.ResizePicture(Me.picProfile, img)
            Else
                modFormFuction.ResizePicture(Me.picProfile, My.Resources.default_user)
            End If

            Dim access As String() = empRow.Cells("useraccess").Value.ToString.Split(New Char() {","c})
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
        End If
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If empID = 1 Then
            MessageBox.Show("Sorry, you cannot delete the administrator account.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf empID <> 0 Then
            If MessageBox.Show("You will delete " & lblFname.Text & " " & lblLname.Text & " on this record. Are you sure?", "Profile Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Dim result As Boolean = modEmployeeCtlr.deleteEmployee(empID)
                If result Then
                    loadDataEmployee()
                Else
                    MessageBox.Show("Please try again.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please select a record to delete.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.TextChanged
        Dim strQry As String = "SELECT id, fname, lname, gender, address, useraccess, username, password, status, IF(status = 0, 'Inactive', 'Active') AS stat FROM employee WHERE delete_flag=0 AND fname LIKE '%" & txtSearch.Text & "%' OR lname LIKE '%" & txtSearch.Text & "%' OR gender LIKE '%" & txtSearch.Text & "%' OR address LIKE '%" & txtSearch.Text & "%' "
        modSqlFunction.loadDataGrid(strQry, dgvEmployee)
    End Sub

End Class