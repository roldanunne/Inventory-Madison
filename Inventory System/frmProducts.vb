Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmProducts
    Public productsPath = imgPath & "\products"
    Dim idx As Integer
    Dim currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
   
    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ilProductAlbum.Images.Clear()
        loadData()
        setFrmDefault()
        Me.dgvProducts.Font = New Font("Microsoft Sans Serif", 12)

    End Sub
    
    Private Sub createDirectory()
        Dim cmdLastID As New MySqlCommand("Select @@Identity", dbCon)
        Dim LastId As Integer = CInt(cmdLastID.ExecuteScalar())

        If Len(Dir(productsPath & "\" & LastId, vbDirectory)) = 0 Then
            MkDir(productsPath & "\" & LastId)
        End If
    End Sub
    Private Sub loadData()
        Dim columnName As String = " product.id, product.barcode, product.prod_name, product.prod_desc, product.prod_qty, product.prod_price, product.prod_class"
        modSqlFunction.loadData("product ", columnName, dgvProducts)
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
            If (IsImage(f)) Then
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
    Private Sub setFrmDefault()
        modFormFuction.setClearAll(Me)
        txtId.Text = ""
        lblStat.Text = "No Image"
        txtBarcode.Text = ""
        txtCriticalStock.Text = "10"
        txtProductPrice.Text = "0.00"
        lbLocation.Items.Clear()
        txtSearchProduct.Select()
        pnlImageNav.Enabled = False
        pnlProductData.Enabled = False
        pnlProductGrid.Enabled = True
        btnDelete.Image = My.Resources.cart_cancel
        btnDelete.BackColor = Color.Coral
        btnDelete.Text = "&Delete"
        btnAddProduct.Text = "&New"
        btnAddProduct.Image = My.Resources.Resources.cart_add

    End Sub

    Private Sub btnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProduct.Click

        If btnAddProduct.Text = "&New" Then
            lblStat.Text = "No Images"
            modFormFuction.setClearAll(Me)
            txtCriticalStock.Text = "10"
            txtProductQuantity.Text = "0"
            txtProductPrice.Text = "0.00"
            btnDelete.Image = My.Resources.cart_minus
            btnDelete.BackColor = Color.IndianRed
            btnDelete.Text = "&Cancel"
            generateBarcode()
            picBarcode.Image = Nothing
            pnlProductData.Enabled = True
            pnlProductGrid.Enabled = False
            
            btnAddProduct.Text = "&Save"
            btnAddProduct.Image = My.Resources.Resources.cart_check
        ElseIf btnAddProduct.Text = "&Save" Then
            If txtProductName.Text = "" Or txtProductDescription.Text = "" Or txtCriticalStock.Text = "" Then
                MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf modSqlFunction.searchData("product", "prod_name = '" & txtProductName.Text & "' and prod_class", txtProductClass.Text) = True Then
                MessageBox.Show("This Product is already exist...")
            Else
                Try
                    OpenCon()
                    If picProductImage.ImageLocation = Nothing Then picProductImage.Image = My.Resources.noImage

                    Dim strQryTable As String = "INSERT INTO product Values('', '" & txtBarcode.Text & "', '" & txtProductName.Text &
                        "', '" & txtProductDescription.Text & "', '" & txtProductClass.Text & "','" & txtProductPrice.Text &
                        "', '" & txtProductQuantity.Text & "','" & txtCriticalStock.Text & "','" & modLoginCtlr.user_id & "' ,'" & currentDate & "','')"
                    Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                    myCommand.ExecuteNonQuery()

                    Dim cmdLastID As New MySqlCommand("Select @@Identity", dbCon)
                    Dim LastId As Integer = CInt(cmdLastID.ExecuteScalar())

                    'create directory and copy files
                    createDirectory()

                    Dim count = 1
                    For Each filename In ofdProductImage.FileNames

                        Dim dateNow = DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss")
                        Dim imgName As String = dateNow & count
                        'move files
                        My.Computer.FileSystem.CopyFile(filename, productsPath & "\" & LastId & "\" & imgName & ".jpeg")
                        LoadImages(productsPath & "\" & LastId)
                        count += 1

                    Next
                    ofdProductImage.Reset()
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
                    txtProductDescription.Text & "', prod_class = '" & txtProductClass.Text & "',prod_price = '" & txtProductPrice.Text & "', prod_qty = '" &
                    txtProductQuantity.Text & "',  employee_id = '" & modLoginCtlr.user_id & "', date_updated = '" & currentDate & "' WHERE id = '" & txtId.Text & "'"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                myCommand.ExecuteNonQuery()
                Dim count = 1
                For Each filename In ofdProductImage.FileNames

                    Dim dateNow = DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss")
                    Dim imgName As String = dateNow & count
                    'move files
                    My.Computer.FileSystem.CopyFile(filename, productsPath & "\" & txtId.Text & "\" & imgName & ".jpeg")
                    LoadImages(productsPath & "\" & txtId.Text)
                    count += 1
                Next
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
            LoadImages(productsPath & "\" & txtId.Text)

            If ilProductAlbum.Images.Count <= 0 Then
                picProductImage.Image = My.Resources.noImage
            End If
            'resize image
            'Dim filePath = productsPath & "\" & txtId.Text & ".jpg"
            'If My.Computer.FileSystem.FileExists(filePath) Then
            '    Dim img As Image = Image.FromFile(filePath)
            '    modFormFuction.ResizePicture(Me.picProductImage, img)
            'End If
        End If

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
        If Not txtBarcode.Text = Nothing Then
            picBarcode.Image = Code128Rendering.MakeBarcodeImage(txtBarcode.Text, 1, False)
            pnlImageNav.Enabled = True
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
        Dim columnName As String = " product.id, product.barcode, product.prod_name, product.prod_desc, product.prod_qty, product.prod_price, product.prod_class"
        modSqlFunction.loadData("product WHERE barcode LIKE '%" & txtSearchProduct.Text & "%' or prod_name LIKE '%" & txtSearchProduct.Text & "%'", columnName, dgvProducts)
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


    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Me.picProductImage.Image = Nothing
        Me.ofdProductImage.FileName = Nothing
        Me.ofdProductImage.ShowDialog()
        
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

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        My.Computer.FileSystem.DeleteFile(productsPath & "\" & txtBarcode.Text & "\" & ilProductAlbum.Images.Keys(idx) & ".jpeg")

    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged
        lbLocation.Items.Clear()
        modSqlFunction.loadLocation(txtId.Text, lbLocation)
    End Sub

    Private Sub lblInventoryAdjustment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInventoryAdjustment.Click
        frmInventoryAdjustment.Show()
    End Sub
    Private Sub btnEmployee_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblInventoryAdjustment.MouseHover
        lblInventoryAdjustment.ForeColor = Color.RoyalBlue
    End Sub
    Private Sub lblInventoryAdjustment_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblInventoryAdjustment.MouseLeave
        lblInventoryAdjustment.ForeColor = Color.White
    End Sub

End Class