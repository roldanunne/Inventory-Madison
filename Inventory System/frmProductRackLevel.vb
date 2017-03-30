Public Class frmProductRackLevel
    Public PRODUCTID As Integer

    Private Sub frmProductRackLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strQry As String = "SELECT id, prod_id, (SELECT product.prod_name FROM product WHERE product.id = stocks.prod_id) AS prod_name, rack_id, rack_name, level_id, level_name, qty_in, qty_out, price_supplier, price_retail, reference, user_id, created_at,(qty_in-qty_out) AS qty_total  FROM stocks WHERE prod_id = " & PRODUCTID & " GROUP BY level_id;"
        modSqlFunction.loadDataGrid(strQry, dgvSearchProduct)
    End Sub
End Class