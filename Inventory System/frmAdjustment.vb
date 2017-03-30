Public Class frmAdjustment
   

    Private Sub frmAdjustment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
        setFromDefault()
    End Sub
    Private Sub loadData()
        modSqlFunction.loadData("product_adjustment", "*", dgvAdjustment)
    End Sub
    Private Sub setFromDefault()
        modFormFuction.setClearAll(Me)
        pnlData.Enabled = False
        pnlDataGrid.Enabled = True
        btnAddSave.Text = "&New"
        btnAddSave.Image = My.Resources.server_add
        btnAddSave.BackColor = Color.ForestGreen
        btnCancelDelete.Text = "&Delete"
        btnCancelDelete.BackColor = Color.Coral
        txtSearchAdjuctment.Select()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearchProduct.Show()
    End Sub
End Class