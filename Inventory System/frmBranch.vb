Public Class frmBranch
    Private branchID = 0
    Private branchRow As DataGridViewRow


    Private Sub frmBranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDataBranch()
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmBranchModal.branchModalTask = "NEW"
        frmBranchModal.Show()
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If branchID <> 0 Then
            frmBranchModal.branchModalID = branchID
            frmBranchModal.branchModalRow = branchRow
            frmBranchModal.branchModalTask = "EDIT"
            frmBranchModal.Show()
        Else
            MessageBox.Show("Please select a record to change.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Public Sub loadDataBranch()
        modBranchCtlr.loadBranch(dgvBranch)
        branchID = 0
    End Sub


    Private Sub dgvBranch_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBranch.CellClick
        If e.RowIndex >= 0 Then
            branchRow = dgvBranch.Rows(e.RowIndex)
            branchID = branchRow.Cells("id").Value
            lblName.Text = branchRow.Cells("name").Value.ToString
            lblAddress.Text = branchRow.Cells("address").Value.ToString
            lblContact.Text = branchRow.Cells("contact").Value.ToString
            lblStatus.Text = branchRow.Cells("stat").Value.ToString
        End If
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If branchID <> 0 Then
            If MessageBox.Show("You will delete " & lblName.Text & " on this record. Are you sure?", "Branch Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Dim result As Boolean = modBranchCtlr.deleteBranch(branchID)
                If result Then
                    loadDataBranch()
                Else
                    MessageBox.Show("Please try again.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please select a record to delete.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.TextChanged
        Dim strQry As String = "SELECT * FROM branch WHERE name LIKE '%" & txtSearch.Text & "%' OR address LIKE '%" & txtSearch.Text & "%' OR contact LIKE '%" & txtSearch.Text & "%' "
        modSqlFunction.loadDataGrid(strQry, dgvBranch)
    End Sub

End Class