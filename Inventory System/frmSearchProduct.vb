Public Class frmSearchProduct

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim strQry As String = "SELECT id, barcode, prod_name, prod_desc, prod_class FROM product WHERE barcode LIKE '%" & txtSearch.Text & "%' OR prod_name LIKE '%" & txtSearch.Text & "%' OR prod_desc LIKE '%" & txtSearch.Text & "%' OR prod_class LIKE '%" & txtSearch.Text & "%' "
        modSqlFunction.loadDataGrid(strQry, dgvSearchProduct)
    End Sub


    Private Sub frmSearchProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.loadData()
    End Sub


    Private Sub loadData()
        Dim strQry As String = "SELECT id, barcode, prod_name, prod_desc, prod_class FROM product "
        modSqlFunction.loadDataGrid(strQry, dgvSearchProduct)
    End Sub
    

    Private Sub dgvSearchProduct_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearchProduct.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvSearchProduct.Rows(e.RowIndex)
            frmStocks.txtBarcode.Text = row.Cells("barcode").Value.ToString
            frmInventoryAdjustment.txtBarcode.Text = row.Cells("barcode").Value.ToString
        End If
        Me.Close()
    End Sub
End Class