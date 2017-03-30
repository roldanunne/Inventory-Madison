Imports MySql.Data.MySqlClient

Public Class frmStocks
    
    Private productsPath = imgPath & "\products"
    Dim isOkQuantity As Boolean = False
    Dim isOkSupplierPrice As Boolean = False
    Dim isOkRetailPrice As Boolean = False
    Dim reference As String


    Private Sub btnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProduct.Click
        If btnAddProduct.Text = "&New" Then
            OpenCon()
            Dim strQryTable As String = "SELECT id FROM stocks ORDER BY id DESC Limit 1"
            Dim myCommand As New MySqlCommand(strQryTable, dbCon)
            Dim myReader As MySqlDataReader
            myReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                myReader.Read()
                Dim ref As Integer = myReader("id") + 1
                reference = Format(Now, "yyyyMMddHHmmss").ToString & ref.ToString
            Else
                reference = Format(Now, "yyyyMMddHHmmss").ToString & 1
            End If
            CloseCon()
            defaultNew()
        ElseIf btnAddProduct.Text = "&Save" Then
            If dgvStocks.Rows.Count > 0 Then
                Try
                    OpenCon()
                    For Each row As DataGridViewRow In dgvStocks.Rows
                        If row.Cells(0).FormattedValue <> "" Then
                            Dim strQryTable As String = "INSERT INTO stocks SET " _
                                                            & "prod_id = " & row.Cells(0).FormattedValue & ", " _
                                                            & "rack_id = " & row.Cells(7).FormattedValue & ", " _
                                                            & "rack_name = '" & row.Cells(8).FormattedValue & "', " _
                                                            & "level_id = " & row.Cells(9).FormattedValue & ", " _
                                                            & "level_name = '" & row.Cells(10).FormattedValue & "', " _
                                                            & "qty_in = " & row.Cells(3).FormattedValue & ", " _
                                                            & "price_supplier = " & row.Cells(4).FormattedValue & ", " _
                                                            & "price_retail = " & row.Cells(5).FormattedValue & ", " _
                                                            & "reference = '" & reference & "', " _
                                                            & "user_id = " & user_id & ", " _
                                                            & "created_at = NOW() "
                            Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                            myCommand.ExecuteNonQuery()
                            updateProductQty(row.Cells(0).FormattedValue)
                        End If
                    Next
                    MsgBox("New stock is added to our product.")
                    defaultSave()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message & "Database Error")
                End Try
                CloseCon()
            Else
                MessageBox.Show("Please insert products before saving.", "ERROR MESSAGE")
            End If
        End If
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearchProduct.Show()
    End Sub


    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            If (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
                e.Handled = True
                Return
            End If
        End If
    End Sub


    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        If txtBarcode.TextLength = 10 And btnAddProduct.Text = "&Save" Then
            OpenCon()
            Try
                'viewing of value
                Dim strQry As String = "SELECT * FROM product WHERE barcode LIKE '%" & txtBarcode.Text & "%'"
                Dim myCommand As New MySqlCommand(strQry, dbCon)
                Dim myReader As MySqlDataReader = myCommand.ExecuteReader
                If myReader.HasRows Then
                    myReader.Read()
                    txtId.Text = myReader("id").ToString
                    txtProductName.Text = myReader("prod_name").ToString
                    txtProductDescription.Text = myReader("prod_desc").ToString
                    txtProductClass.Text = myReader("prod_class").ToString
                    Dim filePath = productsPath & "\" & txtId.Text & ".jpg"
                    If My.Computer.FileSystem.FileExists(filePath) Then
                        Dim img As Image = Image.FromFile(filePath)
                        modFormFuction.ResizePicture(Me.picProductImage, img)
                    End If
                End If
            Catch ex As MySqlException
            End Try
            CloseCon()
        End If

    End Sub


    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged
        If txtId.Text <> "" Then
            OpenCon()
            Try
                Dim strQry As String = "SELECT id, rack_name FROM rack WHERE prod_id = " & txtId.Text & " "
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


    Private Sub cmbRack_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRack.SelectedIndexChanged
        Dim key As String = DirectCast(cmbRack.SelectedItem, KeyValuePair(Of String, String)).Key
        If key <> "" And txtId.Text <> "" Then
            OpenCon()
            Try
                Dim strQry As String = "SELECT id, level_name, capacity FROM rack_level WHERE rack_id = " & key & " "
                Dim myCommand As New MySqlCommand(strQry, dbCon)
                Dim myReader As MySqlDataReader = myCommand.ExecuteReader()
                If myReader.HasRows Then
                    Dim cmbSource As New Dictionary(Of String, String)()
                    cmbSource.Add("", "Select Level")
                    While myReader.Read()
                        txtCapacity.Text = myReader("capacity").ToString
                        cmbSource.Add(myReader("id").ToString, myReader("level_name").ToString)
                    End While
                    cmbLevel.DataSource = New BindingSource(cmbSource, Nothing)
                    cmbLevel.DisplayMember = "Value"
                    cmbLevel.ValueMember = "Key"
                    cmbLevel.SelectedIndex = 0
                End If
            Catch ex As MySqlException
                MessageBox.Show("This Rack Level is not found in the System. Please ask the Administrator", "ERROR MESSAGE")
            End Try
            CloseCon()
        End If
    End Sub


    Private Sub cmbLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLevel.SelectedIndexChanged
        Dim rack_id As String = DirectCast(cmbRack.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim level_id As String = DirectCast(cmbLevel.SelectedItem, KeyValuePair(Of String, String)).Key
        If rack_id <> "" And level_id <> "" And txtId.Text <> "" Then
            OpenCon()
            Try
                Dim strQry As String = "SELECT SUM(qty_in) AS qty_total FROM stocks WHERE prod_id=" & txtId.Text & " AND rack_id=" & rack_id & " AND level_id=" & level_id & " AND qty_in>qty_out  "
                Dim myCommand As New MySqlCommand(strQry, dbCon)
                Dim myReader As MySqlDataReader = myCommand.ExecuteReader()
                If myReader.HasRows Then
                    myReader.Read()
                    txtInStock.Text = If(myReader("qty_total").ToString <> "", myReader("qty_total"), 0)
                    txtAvailable.Text = Val(txtCapacity.Text) - Val(txtInStock.Text)
                Else
                    txtInStock.Text = txtCapacity.Text
                    txtAvailable.Text = "0"
                    MessageBox.Show("This rack level is full. Please select other rack level.", "ERROR MESSAGE")
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.ToString, "ERROR MESSAGE")
            End Try
            CloseCon()
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

    Private Sub txtProductQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductQuantity.TextChanged
        checkProductQuantity()
    End Sub


    Public Sub checkProductQuantity()
        Dim aNumber As Integer
        Dim qty_temp As Integer
        Dim qty_total As Integer
        Dim qty_avail As Integer
        Dim rack_id As String = If(cmbRack.Text = "", "0", DirectCast(cmbRack.SelectedItem, KeyValuePair(Of String, String)).Key)
        Dim level_id As String = If(cmbLevel.Text = "", "0", DirectCast(cmbLevel.SelectedItem, KeyValuePair(Of String, String)).Key)

        For Each row As DataGridViewRow In dgvStocks.Rows
            If row.Cells(0).FormattedValue <> "" And row.Cells(0).FormattedValue = txtId.Text And row.Cells(7).FormattedValue = rack_id And row.Cells(9).FormattedValue = level_id Then
                qty_temp = qty_temp + Val(row.Cells(3).FormattedValue)
            End If
        Next

        qty_total = Val(txtProductQuantity.Text) + qty_temp
        qty_avail = Val(txtAvailable.Text) - qty_temp

        If Not Integer.TryParse(txtProductQuantity.Text, aNumber) And txtId.Text <> "" Then
            MessageBox.Show("Please check your product quantity.", "ERROR MESSAGE")
            txtProductQuantity.Text = "1"
            btnInsert.Enabled = False
        ElseIf qty_total > Val(txtAvailable.Text) And txtId.Text <> "" Then
            MessageBox.Show("The rack level is insufficient for this quantity. Available is " & qty_avail, "ERROR MESSAGE")
            btnInsert.Enabled = False
        Else
            txtProductQuantity.Text = Val(txtProductQuantity.Text)
            btnInsert.Enabled = True
            isOkQuantity = True
        End If
    End Sub


    Private Sub txtSupplierPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSupplierPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            If (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
                e.Handled = True
                Return
            End If
        End If
    End Sub


    Private Sub txtSupplierPrice_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierPrice.TextChanged
        Dim aNumber As Double
        If Not Double.TryParse(txtSupplierPrice.Text, aNumber) And txtId.Text <> "" Then
            MessageBox.Show("Please check your supplier price.", "ERROR MESSAGE")
            btnInsert.Enabled = False
        Else
            txtSupplierPrice.Text = String.Format("{0:n2}", aNumber)
            btnInsert.Enabled = True
            isOkSupplierPrice = True
        End If
        checkProductQuantity()
    End Sub



    Private Sub txtRetailPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetailPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            If (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
                e.Handled = True
                Return
            End If
        End If
    End Sub


    Private Sub txtRetailPrice_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetailPrice.TextChanged
        Dim aNumber As Double
        If Not Double.TryParse(txtRetailPrice.Text, aNumber) And txtId.Text <> "" Then
            MessageBox.Show("Please check your retail price.", "ERROR MESSAGE")
            btnInsert.Enabled = False
        Else
            txtRetailPrice.Text = String.Format("{0:n2}", aNumber)
            btnInsert.Enabled = True
            isOkRetailPrice = True
        End If
        checkProductQuantity()
    End Sub



    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        If Not isOkQuantity Or Not isOkSupplierPrice Or Not isOkRetailPrice Or Val(txtProductQuantity.Text) <= 0 Or Val(txtSupplierPrice.Text) <= 0 Or Val(txtRetailPrice.Text) <= 0 Then
            MessageBox.Show("Please check your details on quantity or price.", "ERROR MESSAGE")
        Else
            Dim rack_id As String = DirectCast(cmbRack.SelectedItem, KeyValuePair(Of String, String)).Key
            Dim rack_name As String = DirectCast(cmbRack.SelectedItem, KeyValuePair(Of String, String)).Value
            Dim level_id As String = DirectCast(cmbLevel.SelectedItem, KeyValuePair(Of String, String)).Key
            Dim level_name As String = DirectCast(cmbLevel.SelectedItem, KeyValuePair(Of String, String)).Value
            Dim rownum As Integer = dgvStocks.Rows.Add()
            dgvStocks.Rows.Item(rownum).Cells(0).Value = txtId.Text
            dgvStocks.Rows.Item(rownum).Cells(1).Value = txtBarcode.Text
            dgvStocks.Rows.Item(rownum).Cells(2).Value = txtProductName.Text
            dgvStocks.Rows.Item(rownum).Cells(3).Value = txtProductQuantity.Text
            dgvStocks.Rows.Item(rownum).Cells(4).Value = txtSupplierPrice.Text
            dgvStocks.Rows.Item(rownum).Cells(5).Value = txtRetailPrice.Text
            dgvStocks.Rows.Item(rownum).Cells(7).Value = rack_id
            dgvStocks.Rows.Item(rownum).Cells(8).Value = rack_name
            dgvStocks.Rows.Item(rownum).Cells(9).Value = level_id
            dgvStocks.Rows.Item(rownum).Cells(10).Value = level_name
            dgvStocks.Enabled = True
            clearForm()
        End If
    End Sub

    Public Sub defaultNew()
        clearForm()
        dgvStocks.Rows.Clear()
        btnAddProduct.Text = "&Save"
        btnAddProduct.Image = My.Resources.Resources.cart_check
        pnlProductData.Enabled = True
        btnInsert.Enabled = False
    End Sub

    Public Sub defaultSave()
        dgvStocks.Rows.Clear()
        btnAddProduct.Text = "&New"
        btnAddProduct.Image = My.Resources.Resources.cart_add
        pnlProductData.Enabled = False
    End Sub

    Public Sub clearForm()
        txtId.Text = ""
        txtBarcode.Text = ""
        txtProductName.Text = ""
        txtProductClass.Text = ""
        txtProductDescription.Text = ""
        txtCapacity.Text = "0"
        txtInStock.Text = "0"
        txtAvailable.Text = "0"
        txtSupplierPrice.Text = "0.00"
        txtRetailPrice.Text = "0.00"
        txtProductQuantity.Text = "1"
        picProductImage.Image = Nothing
        cmbRack.DataSource = New BindingSource(Nothing, Nothing)
        cmbLevel.DataSource = New BindingSource(Nothing, Nothing)
        isOkQuantity = False
        isOkSupplierPrice = False
        btnInsert.Enabled = False
    End Sub


    Private Sub dgvStockIn_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStocks.CellClick
        If MessageBox.Show("Do you want to remove this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            For i As Integer = 0 To dgvStocks.Rows.Count - 1
                dgvStocks.Rows(i).Cells(0).ToString()
                dgvStocks.Rows.RemoveAt(i)
                Exit For
            Next
        End If
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.clearForm()
        defaultSave()
    End Sub


    Private Sub updateProductQty(ByVal prod_id As Integer)
        Try
            'viewing of value
            Dim qty_total As Integer
            Dim strQryTable As String = "SELECT SUM(qty_in-qty_out) AS qty_total FROM stocks WHERE prod_id = " & prod_id & " AND status = 1 "
            Dim myCommand As New MySqlCommand(strQryTable, dbCon)
            Dim myReader As MySqlDataReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                myReader.Read()
                qty_total = If(myReader("qty_total").ToString <> "", myReader("qty_total"), 0)
                myReader.Close()
            End If

            Dim strQryTable1 As String = "UPDATE product SET prod_qty = " & qty_total & " WHERE id = " & prod_id
            Dim myCommand1 As New MySqlCommand(strQryTable1, dbCon)
            myCommand1.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show("This product has a problem. Please ask your Administrator", "ERROR MESSAGE")
        End Try

    End Sub


    Private Sub frmStockIn_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmSearchProduct.Close()
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        mdiMain.btnProducts.PerformClick()
    End Sub

End Class