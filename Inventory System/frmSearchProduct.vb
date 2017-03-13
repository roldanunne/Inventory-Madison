Public Class frmSearchProduct

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        modSqlFunction.loadData("product WHERE barcode LIKE '%" & txtSearch.Text & "%' or prod_name LIKE '%" & txtSearch.Text & "%' or prod_desc LIKE '%" & txtSearch.Text & "%' or prod_class LIKE '%" & txtSearch.Text & "%'", " id, barcode, prod_name, prod_desc, prod_class", dgvSearchProduct)
    End Sub

    Private Sub frmSearchProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.loadData()
    End Sub
    Private Sub loadData()
        modSqlFunction.loadData("product ", " product.id,product.barcode, product.prod_name, product.prod_desc, product.prod_class", dgvSearchProduct)
    End Sub
    Private Sub dgvSearchProduct_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearchProduct.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvSearchProduct.Rows(e.RowIndex)
            frmStockIn.txtBarcode.Text = row.Cells("barcode").Value.ToString
        End If
        Me.Close()
    End Sub

   
End Class