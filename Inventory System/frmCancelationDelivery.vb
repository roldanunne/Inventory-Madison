Imports MySql.Data.MySqlClient

Public Class frmCancelationDelivery
    Dim result As String
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        modSqlFunction.loadData("reference INNER JOIN stock_out ON reference.ref_id = stock_out.ref_id INNER JOIN product ON stock_out.prod_id = product.prod_id INNER JOIN branch ON stock_out.branch_id = branch.branch_id WHERE ref_number = '" & Me.txtRefNumber.Text & "' ", "stock_out.stock_out_id, product.barcode, product.prod_name, branch.branch_name", dgvCancelation)
        With dgvCancelation
            .Columns(0).DataPropertyName = "stock_out_id"
            .Columns(1).DataPropertyName = "barcode"
            .Columns(2).DataPropertyName = "prod_name"
            .Columns(3).DataPropertyName = "branch_name"
            .DataSource = dgvCancelation.DataSource
        End With
    End Sub
    Private Sub dgvCancelation_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCancelation.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvCancelation.Rows(e.RowIndex)
            Me.txtStockId.Text = row.Cells("stock_out_id").Value.ToString
        End If
        If MessageBox.Show("Do You Want to Cancel this Delivery Product...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            popLogFiles.Show()
        End If
    End Sub
    Public Sub hhh()
        Try
            OpenCon()
            Dim strQryTable As String = "UPDATE stock_out SET status = 'Canceled' WHERE stock_out_id = '" & txtStockId.Text & "'"
            Dim myCommand As New MySqlCommand(strQryTable, dbCon)

            myCommand.ExecuteNonQuery()
            MessageBox.Show("Data Canceled..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Error")
        End Try
        CloseCon()
    End Sub
End Class