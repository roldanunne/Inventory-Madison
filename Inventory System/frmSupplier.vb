Public Class frmSupplier
    Private supID = 0
    Private supRow As DataGridViewRow


    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDataSupplier()
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmSupplierModal.supModalTask = "NEW"
        frmSupplierModal.Show()
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If supID <> 0 Then
            frmSupplierModal.supModalID = supID
            frmSupplierModal.supModalRow = supRow
            frmSupplierModal.supModalTask = "EDIT"
            frmSupplierModal.Show()
        Else
            MessageBox.Show("Please select a record to change.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Public Sub loadDataSupplier()
        modSupplierCtlr.loadSupplier(dgvSupplier)
        supID = 0
    End Sub


    Private Sub dgvSupplier_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
        If e.RowIndex >= 0 Then
            supRow = dgvSupplier.Rows(e.RowIndex)
            supID = supRow.Cells("id").Value
            lblName.Text = supRow.Cells("name").Value.ToString
            lblAddress.Text = supRow.Cells("address").Value.ToString
            lblContact.Text = supRow.Cells("contact").Value.ToString
            lblStatus.Text = supRow.Cells("stat").Value.ToString
        End If
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If supID <> 0 Then
            If MessageBox.Show("You will delete " & lblName.Text & " on this record. Are you sure?", "Supplier Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Dim result As Boolean = modSupplierCtlr.deleteSupplier(supID)
                If result Then
                    loadDataSupplier()
                Else
                    MessageBox.Show("Please try again.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please select a record to delete.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.TextChanged
        Dim strQry As String = "SELECT * FROM supplier WHERE name LIKE '%" & txtSearch.Text & "%' OR address LIKE '%" & txtSearch.Text & "%' OR contact LIKE '%" & txtSearch.Text & "%' "
        modSqlFunction.loadDataGrid(strQry, dgvSupplier)
    End Sub

End Class