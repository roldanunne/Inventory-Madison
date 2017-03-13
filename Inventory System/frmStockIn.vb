Imports MySql.Data.MySqlClient

Public Class frmStockIn
    Dim id As String = 1
    Dim result As String
    Dim currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Private productsPath = imgPath & "\products"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearchProduct.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtProductQuantity.Text.Trim = "" Or txtProductQuantity.Text = "0" Then
            MessageBox.Show("Required Quantity", "Information")
        Else
            Dim rownum As Integer = dgvStockIn.Rows.Add()
            dgvStockIn.Rows.Item(rownum).Cells(0).Value = txtID.Text
            dgvStockIn.Rows.Item(rownum).Cells(1).Value = txtBarcode.Text
            dgvStockIn.Rows.Item(rownum).Cells(2).Value = txtProductName.Text
            dgvStockIn.Rows.Item(rownum).Cells(3).Value = txtProductQuantity.Text
            dgvStockIn.Rows.Item(rownum).Cells(4).Value = txtProductPrice.Text
            Me.clearForm()
            Me.dgvStockIn.Enabled = True
        End If
    End Sub

    Public Sub defaultNew()
        btnAddProduct.Text = "New"
        btnAddProduct.Image = My.Resources.Resources.cart_add
        pnlProductData.Enabled = False
    End Sub

    Public Sub defaultSave()
        btnAddProduct.Text = "Save"
        btnAddProduct.Image = My.Resources.Resources.cart_check
        pnlProductData.Enabled = True
    End Sub

    Public Sub clearForm()
        Me.txtID.Text = ""
        Me.txtBarcode.Text = ""
        Me.txtProductClass.Text = ""
        Me.txtProductDescription.Text = ""
        Me.txtProductName.Text = ""
        Me.txtProductPrice.Text = "0"
        Me.txtProductQuantity.Text = "1"
        Me.picProductImage.Image = Nothing
    End Sub

    Dim reference As String
    Private Sub btnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProduct.Click
        If btnAddProduct.Text = "New" Then
            OpenCon()
            Dim strQryTable As String = "SELECT id FROM stock_in ORDER BY id DESC Limit 1"
            Dim myCommand As New MySqlCommand(strQryTable, dbCon)
            Dim myReader As MySqlDataReader
            Dim id As Integer = 0
            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                myReader.Read()
                id = myReader("id")
            End If
            myReader.Close()
            reference = id + 1000 & Now.Month & Now.Day & Now.Second
            CloseCon()
            Me.defaultSave()
            Me.clearForm()
            Me.dgvStockIn.Rows.Clear()
        ElseIf btnAddProduct.Text = "Save" Then
            Try
                OpenCon()
                For Each row As DataGridViewRow In dgvStockIn.Rows
                    If row.Cells(0).FormattedValue <> "" Or row.Cells(1).FormattedValue <> "" Then
                        Dim strQryTable As String = "INSERT INTO stock_in VALUES ('','" _
                                                                    & currentDate & "','" _
                                                                    & CStr(row.Cells(3).FormattedValue) & "','" _
                                                                    & CStr(row.Cells(0).FormattedValue) & "','" _
                                                                    & id & "', '" _
                                                                    & reference & "')"
                        Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                        myCommand.ExecuteNonQuery()
                        updateProductQty(row.Cells(0).FormattedValue)
                    End If
                Next
                MsgBox("Record inserted.")
                Me.dgvStockIn.Rows.Clear()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message & "Database Error")
            End Try
            CloseCon()
            defaultNew()
        End If

    End Sub

    Private Sub dgvStockIn_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStockIn.CellClick
        If MessageBox.Show("Do You Want to Remove this Record...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            For i As Integer = 0 To dgvStockIn.Rows.Count - 1
                dgvStockIn.Rows(i).Cells(0).ToString()
                dgvStockIn.Rows.RemoveAt(i)
                Exit For
            Next
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.clearForm()
        defaultNew()
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        If txtBarcode.TextLength = 10 And btnAddProduct.Text = "Save" Then
            Try
                'viewing of value
                OpenCon()
                Dim strQryTable As String = "SELECT * FROM product  WHERE barcode LIKE '%" & txtBarcode.Text & "%'"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                Dim myReader As MySqlDataReader
                myCommand.ExecuteNonQuery()
                myReader = myCommand.ExecuteReader
                myReader.Read()
                
                Me.txtId.Text = myReader("id").ToString
                Me.txtProductName.Text = myReader("prod_name").ToString
                Me.txtProductDescription.Text = myReader("prod_desc").ToString
                Me.txtProductClass.Text = myReader("prod_class").ToString

                Dim filePath = productsPath & "\" & txtId.Text & ".jpg"
                If My.Computer.FileSystem.FileExists(filePath) Then
                    Dim img As Image = Image.FromFile(filePath)
                    modFormFuction.ResizePicture(Me.picProductImage, img)
                End If

            Catch ex As MySqlException
                MessageBox.Show("This Barcode is not found / use to your System. Please ask your Administrator", "ERROR MESSAGE")
                Me.clearForm()
            End Try
            CloseCon()
        End If

    End Sub


    Private Sub updateProductQty(ByVal id As String)
        Try
            'viewing of value

            Dim qty_in As Integer
            Dim qty_out As Integer
            Dim strQryTable As String = "SELECT SUM(quantity) AS qty FROM stock_in WHERE prod_id = " & id
            Dim myCommand As New MySqlCommand(strQryTable, dbCon)
            Dim myReader As MySqlDataReader
            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                myReader.Read()
                qty_in = If(myReader("qty").ToString <> "", myReader("qty"), 0)
            End If
            myReader.Close()

            Dim strQryTable1 As String = "SELECT SUM(quantity) AS qty FROM stock_out WHERE prod_id = " & id
            Dim myCommand1 As New MySqlCommand(strQryTable1, dbCon)
            Dim myReader1 As MySqlDataReader
            myCommand1.ExecuteNonQuery()
            myReader1 = myCommand1.ExecuteReader
            If myReader1.HasRows Then
                myReader1.Read()
                qty_out = If(myReader1("qty").ToString <> "", myReader1("qty"), 0)
            End If
            myReader1.Close()
            
            Dim qty_total As Integer = qty_in - qty_out
            Dim strQryTable2 As String = "UPDATE  product SET prod_qty = " & qty_total & " WHERE id = " & id
            Dim myCommand2 As New MySqlCommand(strQryTable2, dbCon)
            Dim myReader2 As MySqlDataReader
            myCommand2.ExecuteNonQuery()
            myReader2 = myCommand1.ExecuteReader
            myReader2.Close()
        Catch ex As MySqlException
            MessageBox.Show("This Barcode is not found / use to your System. Please ask your Administrator", "ERROR MESSAGE")
            Me.clearForm()
        End Try

    End Sub

    Private Sub frmStockIn_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmSearchProduct.Close()
    End Sub

    Private Sub frmStockIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlProductData.Enabled = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        mdiMain.btnProducts.PerformClick()
    End Sub
End Class