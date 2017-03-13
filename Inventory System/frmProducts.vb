Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmProducts
    Public productsPath = imgPath & "\products"
    Dim currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Len(Dir(productsPath, vbDirectory)) = 0 Then
            MkDir(productsPath)
        End If

        loadData()
        setFrmDefault()
        Me.dgvProducts.Font = New Font("Microsoft Sans Serif", 12)

    End Sub

    Private Sub loadData()

        modSqlFunction.loadData("product ", " product.id, product.barcode, product.prod_name, product.prod_desc, product.prod_qty, product.prod_price, product.prod_class,product.warehouse_name, product.warehouse_room, product.room_level", dgvProducts)
    End Sub

    Private Sub generateBarcode()
        Dim barCode = ""
        Dim pool = "0123456789"
        Dim count = 1
        Dim cc As New Random
        Dim strpos = ""
        Try
            OpenCon()
            While count <= 10
                strpos = cc.Next(0, pool.Length)
                barCode = barCode & pool(strpos)
                count = count + 1
            End While

            Dim strTable As String = "SELECT barcode FROM product WHERE barcode = " & barCode & ""
            Dim myCommand As New MySqlCommand(strTable, dbCon)
            Dim myReader As MySqlDataReader

            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader

            If myReader.HasRows Then
                ' barcode already exists
                generateBarcode()
            Else
                txtBarcode.Text = barCode
            End If
            CloseCon()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Database Update Error")
        End Try

    End Sub


    Private Sub setFrmDefault()
        modFormFuction.setClearAll(Me)
        txtId.Text = ""
        txtBarcode.Text = ""
        txtCriticalStock.Text = "10"
        txtSearchProduct.Select()
        pnlProductData.Enabled = False
        pnlMoreDetails.Enabled = False
        pnlProductGrid.Enabled = True
        btnDelete.Image = My.Resources.cart_cancel
        btnDelete.BackColor = Color.Coral
        btnDelete.Text = "&Delete"
        btnAddProduct.Text = "&New"
        btnAddProduct.Image = My.Resources.Resources.cart_add

    End Sub

    Private Sub btnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProduct.Click

        If btnAddProduct.Text = "&New" Then
            modFormFuction.setClearAll(Me)
            txtCriticalStock.Text = "10"
            btnDelete.Image = My.Resources.cart_minus
            btnDelete.BackColor = Color.IndianRed
            btnDelete.Text = "&Cancel"
            generateBarcode()
            picBarcode.Image = Nothing
            pnlProductData.Enabled = True
            pnlMoreDetails.Enabled = True
            pnlProductGrid.Enabled = False
            txtProductQuantity.Text = 0
            txtProductPrice.Text = 0
            btnAddProduct.Text = "&Save"
            btnAddProduct.Image = My.Resources.Resources.cart_check
        ElseIf btnAddProduct.Text = "&Save" Then
            If txtProductName.Text = "" Or txtProductDescription.Text = "" Or txtProductClass.Text = "" Or txtWarehouseName.Text = "" Or txtWarehouseRoom.Text = "" Or txtRoomLevel.Text = "" Or ofdProductImage.FileName() = Nothing Then
                MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf modSqlFunction.searchData("product", "prod_name = '" & txtProductName.Text & "' and prod_class", txtProductClass.Text) = True Then
                MessageBox.Show("This Product is already exist...")
            Else
                Try
                    OpenCon()
                    If picProductImage.ImageLocation = Nothing Then picProductImage.Image = My.Resources.noImage

                    Dim strQryTable As String = "INSERT INTO product Values('', '" & txtBarcode.Text & "', '" & txtProductName.Text &
                        "', '" & txtProductDescription.Text & "', '" & txtProductClass.Text & "', '" & txtProductPrice.Text &
                        "', '" & txtProductQuantity.Text & "','" & txtCriticalStock.Text & "', '" & txtWarehouseName.Text & "', '" & txtWarehouseRoom.Text &
                        "', '" & txtRoomLevel.Text & "','" & modLoginCtlr.user_id & "' ,'" & currentDate & "','')"
                    Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                    myCommand.ExecuteNonQuery()

                    Dim cmdLastID As New MySqlCommand("Select @@Identity", dbCon)
                    Dim LastId As Integer = CInt(cmdLastID.ExecuteScalar())
                    picProductImage.Image.Save(productsPath & "\" & LastId & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                    loadData()
                    MessageBox.Show("Data Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message & "Database Error")
                End Try
                CloseCon()
                Me.setFrmDefault()

            End If
        ElseIf btnAddProduct.Text = "&Update" Then
            Try
                OpenCon()
                Dim strQryTable As String = "UPDATE product SET barcode = '" & txtBarcode.Text & "', prod_name = '" & txtProductName.Text & "', prod_desc = '" &
                    txtProductDescription.Text & "', prod_class = '" & txtProductClass.Text & "', prod_price = '" & txtProductPrice.Text & "', prod_qty = '" &
                    txtProductQuantity.Text & "', warehouse_name = '" & txtWarehouseName.Text & "', warehouse_room = '" & txtWarehouseRoom.Text & "', room_level = '" &
                    txtRoomLevel.Text & "', date_updated = '" & currentDate & "' WHERE id = '" & txtId.Text & "'"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                myCommand.ExecuteNonQuery()
                picProductImage.Image.Save(productsPath & "\" & txtId.Text & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                loadData()
                MessageBox.Show("Data Updated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message & "Database Error")
            End Try
            CloseCon()
            Me.setFrmDefault()
        End If
    End Sub


    Private Sub dgvProducts_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvProducts.Rows(e.RowIndex)

            txtId.Text = row.Cells("id").Value.ToString
            txtBarcode.Text = row.Cells("barcode").Value.ToString
            txtProductName.Text = row.Cells("prod_name").Value.ToString
            txtProductDescription.Text = row.Cells("prod_desc").Value.ToString
            txtProductClass.Text = row.Cells("prod_class").Value.ToString
            txtProductQuantity.Text = row.Cells("prod_qty").Value.ToString
            txtProductPrice.Text = row.Cells("prod_price").Value.ToString
            txtWarehouseName.Text = row.Cells("warehouse_name").Value.ToString
            txtWarehouseRoom.Text = row.Cells("warehouse_room").Value.ToString
            txtRoomLevel.Text = row.Cells("room_level").Value.ToString
            Dim filePath = productsPath & "\" & txtId.Text & ".jpg"
            If My.Computer.FileSystem.FileExists(filePath) Then
                Dim img As Image = Image.FromFile(filePath)
                modFormFuction.ResizePicture(Me.picProductImage, img)
            End If
        End If
        pnlMoreDetails.Enabled = True
    End Sub
    Private Sub dgvProducts_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducts.CellDoubleClick
        If Not dgvProducts.SelectedCells.Count = 0 Then
            If MessageBox.Show("Do you want to change something is this record?", "Product Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                pnlProductData.Enabled = True
                btnAddProduct.Text = "&Update"
                btnAddProduct.Image = My.Resources.Resources.cart_check
                btnDelete.Image = My.Resources.cart_minus
                btnDelete.BackColor = Color.IndianRed
                btnDelete.Text = "&Cancel"
            End If
        Else
            Me.setFrmDefault()
        End If
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        If Not txtBarcode.Text = "" Then
            picBarcode.Image = Code128Rendering.MakeBarcodeImage(txtBarcode.Text, 1, False)
        End If
    End Sub



    Private Sub picProductImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picProductImage.Click
        Me.picProductImage.Image = Nothing
        Me.ofdProductImage.FileName = Nothing
        Me.ofdProductImage.ShowDialog()
        If Me.ofdProductImage.FileName() = Nothing Then
            Me.picProductImage.Image = My.Resources.noImage
        Else
            Me.picProductImage.ImageLocation = Me.ofdProductImage.FileName()
        End If
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Delete" Then
            If MessageBox.Show("Do You Want to DELETE this Record...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                modSqlFunction.deleteData("product", "barcode", txtBarcode.Text)
                Me.setFrmDefault()
                loadData()
            End If
        ElseIf btnDelete.Text = "&Cancel" Then
            Me.setFrmDefault()
        End If

    End Sub

    Private Sub txtSearchProduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchProduct.TextChanged
        modSqlFunction.loadData("product WHERE barcode LIKE '%" & txtSearchProduct.Text & "%' or prod_name LIKE '%" & txtSearchProduct.Text & "%'", " id, barcode, prod_name, prod_desc, prod_qty, prod_price, prod_class, warehouse_name, warehouse_room, room_level", dgvProducts)
    End Sub

    Private Sub txtProductPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProductPrice.KeyPress
        Dim FullStop As Char
        FullStop = "."
        If e.KeyChar = FullStop And txtProductPrice.Text.IndexOf(FullStop) <> -1 Then
            e.Handled = True
            Return
        End If
        If Not Char.IsDigit(e.KeyChar) Then
            If (e.KeyChar <> FullStop) And (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
                e.Handled = True
                Return
            End If
        End If
    End Sub

    Private Sub txtProductQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProductQuantity.KeyPress

        If Not Char.IsDigit(e.KeyChar) Then
            If (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
                e.Handled = True
                Return
            End If
        End If
    End Sub


    Private Sub btnMoreDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoreDetails.Click
        Dim fpp As New frmProductProperties
        fpp.BarCode = txtBarcode.Text
        fpp.Show()
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        mdiMain.btnProducts.PerformClick()
    End Sub
End Class