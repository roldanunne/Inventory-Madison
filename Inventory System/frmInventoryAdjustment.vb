Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmInventoryAdjustment
    Public productsPath = imgPath & "\products"
    Dim idx As Integer
    Dim currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

    Private Sub frmInventoryAdjustment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
        setFromDefault()
    End Sub
    Private Sub loadData()
        Dim tblName As String = "inventory_adjustment INNER JOIN product ON inventory_adjustment.prod_id=product.id"
        Dim columnName As String = "inventory_adjustment.id, barcode, reason, prod_name, quantity, unit_cost, total_cost, status, memo"
        modSqlFunction.loadData(tblName, columnName, dgvAdjustment)
    End Sub
    Private Sub setFromDefault()
        pnlData.Enabled = False
        txtUnitCost.Text = "0.00"
        txtTotal.Text = "0.00"
        btnSave.Text = "Save"
        btnSave.BackColor = Color.ForestGreen
        btnSave.Image = My.Resources.cart_add
    End Sub

    'image collection
    Private Sub RefrenchImages()
        picProductImage.Image = ilProductAlbum.Images(idx)
        lblStat.Text = idx + 1 & " of " & ilProductAlbum.Images.Count
    End Sub
    Private Sub LoadImages(ByVal path As String)
        ' clear old images first
        ilProductAlbum.Images.Clear()
        picProductImage.Image = Nothing
        picProductImage.Refresh()

        'display controls so that user cant click
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        btnFirst.Enabled = False
        btnLast.Enabled = False
        lblStat.Text = "Loading..."

        'loop through files in the directory
        Dim dir As DirectoryInfo = New DirectoryInfo(path)
        Dim files As FileInfo() = dir.GetFiles("*.*")

        For i As Integer = 0 To files.Count - 1
            Dim f As FileInfo = files(i)

            'add if f is image
            If (isImage(f)) Then
                Dim img As Image = Image.FromFile(f.FullName)
                ilProductAlbum.Images.Add(img)
            End If
        Next

        'check if at least one image has added
        If ilProductAlbum.Images.Count > 0 Then
            btnNext.Enabled = True
            btnPrevious.Enabled = True
            btnFirst.Enabled = True
            btnLast.Enabled = True

            idx = 0
            RefrenchImages()
        Else
            lblStat.Text = "No Images"
        End If

    End Sub
    Private Function isImage(ByVal f As FileInfo) As Boolean
        Dim ext As String = f.Extension.ToLower
        If ext = ".gif" Or ext = ".jpg" Or ext = ".jpeg" Or ext = ".png" Or ext = ".bmp" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtProdId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdId.TextChanged
        LoadImages(productsPath & "\" & txtProdId.Text)
        If txtProdId.Text <> "" Then
            OpenCon()
            Try
                Dim strQry As String = "SELECT id, rack_name FROM rack WHERE prod_id = " & txtProdId.Text & " "
                Dim myCommand As New MySqlCommand(strQry, dbCon)
                Dim myReader As MySqlDataReader = myCommand.ExecuteReader()
                If myReader.HasRows Then
                    Dim cmbSource As New Dictionary(Of String, String)()
                    cmbSource.Add("", "Select Rack")
                    While myReader.Read()
                        cmbSource.Add(myReader("id").ToString, myReader("rack_name").ToString)
                    End While
                    cmbRack.DataSource = New BindingSource(cmbSource, Nothing)
                    cmbRack.DisplayMember = "Value"
                    cmbRack.ValueMember = "Key"
                    cmbRack.SelectedIndex = 0
                End If
            Catch ex As MySqlException
                MessageBox.Show("This Rack is not found in the System. Please ask the Administrator", "ERROR MESSAGE")
            End Try
            CloseCon()
        End If
    End Sub
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        idx = 0
        RefrenchImages()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        idx = idx - 1
        If idx < 0 Then
            idx = ilProductAlbum.Images.Count - 1
        End If
        RefrenchImages()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        idx = idx + 1
        If idx = ilProductAlbum.Images.Count Then
            idx = 0
        End If
        RefrenchImages()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        idx = ilProductAlbum.Images.Count - 1
        RefrenchImages()
    End Sub
    Private Sub btnSearchProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchProd.Click
        modFormFuction.setClearAll(Me)
        frmSearchProduct.Show()
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

        If txtBarcode.TextLength = 10 Then

            OpenCon()
            Try
                txtQuantity.Focus()
                pnlData.Enabled = True
                'viewing of value
                Dim strQry As String = "SELECT * FROM product WHERE barcode LIKE '%" & txtBarcode.Text & "%'"
                Dim myCommand As New MySqlCommand(strQry, dbCon)
                Dim myReader As MySqlDataReader = myCommand.ExecuteReader
                If myReader.HasRows Then
                    myReader.Read()
                    txtProdId.Text = myReader("id").ToString
                    txtProductName.Text = myReader("prod_name").ToString
                    txtProductDescription.Text = myReader("prod_desc").ToString
                    txtProductClass.Text = myReader("prod_class").ToString
                    txtUnitCost.Text = myReader("prod_price").ToString
                End If
            Catch ex As MySqlException
            End Try
            CloseCon()
        End If
    End Sub
    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Not Char.IsDigit(e.KeyChar) Then
            If (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
                e.Handled = True
                Return
            End If
        End If

    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        If Not txtQuantity.Text = "" Then
            txtTotal.Text = txtQuantity.Text * txtUnitCost.Text
        Else
            txtTotal.Text = "0.00"
        End If
    End Sub

    Private Sub cmbRack_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRack.SelectedIndexChanged
        Dim key As String = DirectCast(cmbRack.SelectedItem, KeyValuePair(Of String, String)).Key
        If key <> "" And txtProdId.Text <> "" Then

            Try
                OpenCon()
                Dim strQry As String = "SELECT level_id, level_name, capacity FROM rack_level WHERE rack_id = '" & key & "' "
                Dim myCommand As New MySqlCommand(strQry, dbCon)
                Dim myReader As MySqlDataReader = myCommand.ExecuteReader()
                If myReader.HasRows Then
                    Dim cmbSource As New Dictionary(Of String, String)()
                    cmbSource.Add("", "Select Level")
                    While myReader.Read()
                        cmbSource.Add(myReader("level_id").ToString, myReader("level_name").ToString)
                    End While
                    cmbLevel.DataSource = New BindingSource(cmbSource, Nothing)
                    cmbLevel.DisplayMember = "Value"
                    cmbLevel.ValueMember = "Key"
                    cmbLevel.SelectedIndex = 0
                End If
            Catch ex As MySqlException
                MessageBox.Show("This Rack Level is not found in the System. Please ask the Administrator" & ex.Message, "ERROR MESSAGE")
            End Try
            CloseCon()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "Save" Then
            If cmbRack.Text = "" Or cmbLevel.Text = "" Or txtQuantity.Text = "" Or txtReason.Text = "" Then
                MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    OpenCon()
                    If picProductImage.ImageLocation = Nothing Then picProductImage.Image = My.Resources.noImage

                    Dim strQryTable As String = "INSERT INTO inventory_adjustment Values('', '" & txtQuantity.Text & "', '" & txtUnitCost.Text &
                        "', '" & txtTotal.Text & "','Pending', '" & txtReason.Text & "', '" & txtMemo.Text & "','" & txtProdId.Text &
                        "','" & modLoginCtlr.user_id & "' ,'" & currentDate & "','')"
                    Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                    myCommand.ExecuteNonQuery()

                    loadData()
                    MessageBox.Show("Data Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message & "Database Error")
                End Try
                CloseCon()
                modFormFuction.setClearAll(Me)
                setFromDefault()
            End If
        ElseIf btnSave.Text = "Update" Then
            Try
                OpenCon()
                Dim strQryTable As String = "UPDATE inventory_adjustment SET quantity = '" & txtQuantity.Text & "', unit_cost = '" & txtUnitCost.Text & "', total_cost = '" &
                    txtTotal.Text & "', reason = '" & txtReason.Text & "',memo = '" & txtMemo.Text & "', status = '',  employee_id = '" &
                    modLoginCtlr.user_id & "', date_updated = '" & currentDate & "' WHERE id = '" & txtAdjustmentId.Text & "'"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                myCommand.ExecuteNonQuery()
                loadData()
                MessageBox.Show("Data Updated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message & "Database Error")
            End Try
            CloseCon()
            modFormFuction.setClearAll(Me)
            setFromDefault()

            
        End If
    End Sub

    Private Sub dgvAdjustment_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAdjustment.CellClick
        If e.RowIndex >= 0 Then
            modFormFuction.setClearAll(Me)
            Dim row As DataGridViewRow
            row = Me.dgvAdjustment.Rows(e.RowIndex)
            txtAdjustmentId.Text = row.Cells("id").Value.ToString
            txtBarcode.Text = row.Cells("barcode").Value.ToString
            txtQuantity.Text = row.Cells("quantity").Value.ToString
            txtUnitCost.Text = row.Cells("unit_cost").Value.ToString
            txtTotal.Text = row.Cells("total_cost").Value.ToString
            txtReason.Text = row.Cells("reason").Value.ToString
            txtMemo.Text = row.Cells("memo").Value.ToString

            btnSave.Text = "Update"
            btnSave.BackColor = Color.RoyalBlue
            btnSave.Image = My.Resources.cart_check

        End If
    End Sub

    Private Sub txtSearchAdjustment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchAdjustment.TextChanged
        Dim tblName As String = "inventory_adjustment INNER JOIN product ON inventory_adjustment.prod_id=product.id WHERE prod_name LIKE '%" & txtSearchAdjustment.Text & "%' or reason LIKE '%" & txtSearchAdjustment.Text & "%' or status LIKE '%" & txtSearchAdjustment.Text & "%' or memo LIKE '%" & txtSearchAdjustment.Text & "%'"
        Dim columnName As String = "inventory_adjustment.id, barcode, reason, prod_name, quantity, unit_cost, total_cost, status, memo"
        modSqlFunction.loadData(tblName, columnName, dgvAdjustment)
    End Sub

    Private Sub btnCancelDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelDelete.Click
        If MessageBox.Show("Do You Want to DELETE this Record...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            modSqlFunction.deleteData("inventory_adjustment", "id", txtAdjustmentId.Text)
            modFormFuction.setClearAll(Me)
            setFromDefault()
            loadData()
        End If
    End Sub

End Class