Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmDelivery
    Private productsPath = imgPath & "\products"
    Dim isOkQuantity As Boolean = False
    Dim isOkSupplierPrice As Boolean = False
    Dim isOkRetailPrice As Boolean = False
    Dim id As String = 1
    Dim result As String
    Dim currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Dim reference As String


    Private Sub frmDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Len(Dir(productsPath, vbDirectory)) = 0 Then
            MkDir(productsPath)
        End If

        OpenCon()
        Try
            Dim strQry As String = "SELECT id, branch_code, branch_name FROM branch "
            Dim myCommand As New MySqlCommand(strQry, dbCon)
            Dim myReader As MySqlDataReader = myCommand.ExecuteReader()
            If myReader.HasRows Then
                Dim cmbSource As New Dictionary(Of String, String)()
                cmbSource.Add("", "Select Branch")
                While myReader.Read()
                    cmbSource.Add(myReader("id").ToString, myReader("branch_code").ToString)
                End While
                cmbBranch.DataSource = New BindingSource(cmbSource, Nothing)
                cmbBranch.DisplayMember = "Value"
                cmbBranch.ValueMember = "Key"
                cmbBranch.SelectedIndex = 0
            End If
        Catch ex As MySqlException
            MessageBox.Show("This Branch is not found in the System. Please ask the Administrator", "ERROR MESSAGE")
        End Try
        CloseCon()

    End Sub


    Private Sub cmbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBranch.SelectedIndexChanged
        Dim branch_id As String = DirectCast(cmbBranch.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim branch_name As String = DirectCast(cmbBranch.SelectedItem, KeyValuePair(Of String, String)).Value
        OpenCon()
        Try
            Dim strQry As String = "SELECT id, branch_code, branch_name FROM branch WHERE id = " & branch_id
            Dim myCommand As New MySqlCommand(strQry, dbCon)
            Dim myReader As MySqlDataReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                myReader.Read()
                txtBranchCode.Text = myReader("branch_code").ToString()
            End If
            myReader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Retrieving Error")
        End Try
        CloseCon()
    End Sub


    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        If txtBarcode.TextLength = 10 Then
            OpenCon()
            Try
                'viewing of value
                Dim strQryTable As String = "SELECT * FROM product  WHERE barcode LIKE '%" & txtBarcode.Text & "%'"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                Dim myReader As MySqlDataReader = myCommand.ExecuteReader()
                If myReader.HasRows Then
                    myReader.Read()
                    txtId.Text = myReader("id").ToString
                    txtProductName.Text = myReader("prod_name").ToString
                    txtProductDescription.Text = myReader("prod_desc").ToString
                    txtProductClass.Text = myReader("prod_class").ToString
                    Dim filePath = frmProducts.productsPath & "\" & txtBarcode.Text & ".jpg"
                    If My.Computer.FileSystem.FileExists(filePath) Then
                        Dim img As Image = Image.FromFile(filePath)
                        modFormFuction.ResizePicture(Me.picProductImage, img)
                    End If
                Else
                    MessageBox.Show("This product is not found. Please ask your Administrator.", "ERROR MESSAGE")
                End If
                btnSearch.PerformClick()
            Catch ex As MySqlException
                MessageBox.Show("This Barcode is not found / use to your System. Please ask your Administrator", "ERROR MESSAGE")
                clearForm()
            End Try
            CloseCon()
        End If

    End Sub


    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            If (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
                e.Handled = True
                Return
            End If
        End If
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtBarcode.TextLength = 10 And txtId.Text <> "" Then
            frmProductRackLevel.PRODUCTID = txtId.Text
            frmProductRackLevel.Show()
        End If
    End Sub

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
        ElseIf btnAddProduct.Text = "&SAVE" Then
            Try
                OpenCon()
                For Each row As DataGridViewRow In dgvDelivery.Rows
                    If row.Cells(0).FormattedValue <> "" Or row.Cells(1).FormattedValue <> "" Then
                        Dim strQryTable As String = "INSERT INTO stock_out VALUES ('','" _
                                                                    & currentDate & "','" _
                                                                    & CStr(row.Cells(5).FormattedValue) & "','" _
                                                                    & CStr(row.Cells(0).FormattedValue) & "','" _
                                                                    & id & "', '" _
                                                                    & txtBranchCode.Text & "', '" _
                                                                    & "Delivered" & "')"
                        Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                        ' & refID & "', '" _
                        result = myCommand.ExecuteNonQuery()
                        ' MessageBox.Show("Stock Already Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Next
                'Dim strQuery As String = "INSERT INTO reference (ref_number) VALUES ('" & ref_number & "')"
                'Dim myCom As New MySqlCommand(strQuery, dbCon)
                'result = myCom.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No saved Record.")
                Else
                    MsgBox("All Stock Already Inserted.")
                    Me.dgvDelivery.Rows.Clear()
                End If
                exportFile()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message & "Database Error")
            End Try
            CloseCon()
            defaultSave()
        End If

    End Sub

    Public Sub defaultNew()
        clearForm()
        dgvDelivery.Rows.Clear()
        btnAddProduct.Text = "&Save"
        btnAddProduct.Image = My.Resources.Resources.cart_save
        pnlProductData.Enabled = True
        'btnInsert.Enabled = False
    End Sub

    Public Sub defaultSave()
        dgvDelivery.Rows.Clear()
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
        txtInStock.Text = "0"
        txtAvailable.Text = "0"
        txtSupplierPrice.Text = "0.00"
        txtRetailPrice.Text = "0.00"
        txtProductQuantity.Text = "1"
        picProductImage.Image = Nothing
        isOkQuantity = False
        isOkSupplierPrice = False
        'btnInsert.Enabled = False
    End Sub

    Public Sub clear()
        Me.txtBarcode.Text = ""
        Me.txtId.Text = ""
        Me.txtProductQuantity.Text = ""
        Me.txtProductName.Text = ""
        Me.txtProductDescription.Text = ""
        Me.txtProductClass.Text = ""
    End Sub




    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmCancelationDelivery.Show()
    End Sub


    Dim branch As String
    Private Sub txtBranchCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modSqlFunction.retrieveSingleData("branch", "branch_id", txtBranchCode.Text, "branch_code", branch)
        cmbBranch.Text = branch
    End Sub



    Public Sub exportFile()
        Dim sourceTable As DataTable = New DataTable()

        sourceTable.Columns.AddRange(New DataColumn() {
        New DataColumn("QUANTITY", GetType(Integer)),
        New DataColumn("PROD ID", GetType(Integer))
        })

        Try
            OpenCon()
            Dim strQry As String = "SELECT quantity, prod_id FROM stock_out WHERE date = '" & currentDate & "'"
            Dim myCommand As New MySqlCommand(strQry, dbCon)
            Dim myReader As MySqlDataReader = myCommand.ExecuteReader()

            While myReader.Read()
                sourceTable.Rows.Add(myReader("quantity"), myReader("prod_id"))
            End While

            Dim name = DateTime.Now.ToString("yyyyMMddHHmmss")
            Using writer As StreamWriter = New StreamWriter("C:\ProgramData\Madison\Delivery\" & name)
                Rfc4180Writer.WriteDataTable(sourceTable, writer, True)
            End Using
            myReader.Close()

            sfdSaveDelivery.ShowDialog()
            'Must be 64 bits, 8 bytes.
            Dim sSecretKey As String

            ' Get the key for the file to encrypt.
            ' You can distribute this key to the user who will decrypt the file.
            sSecretKey = GenerateKey()

            'modFormFuction.EncryptFile("C:\ProgramData\Madison\Delivery\" & name, sfdSaveDelivery.FileName, BranchCode)

        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Set Error")
        End Try

    End Sub



    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        If txtProductQuantity.Text = "" Or txtProductQuantity.Text = 0 Then
            MessageBox.Show("Required Quantity", "Information")
        Else
            Dim rownum As Integer = dgvDelivery.Rows.Add()
            dgvDelivery.Rows.Item(rownum).Cells(0).Value = txtId.Text
            dgvDelivery.Rows.Item(rownum).Cells(1).Value = txtBarcode.Text
            dgvDelivery.Rows.Item(rownum).Cells(2).Value = txtProductName.Text
            dgvDelivery.Rows.Item(rownum).Cells(3).Value = txtProductDescription.Text
            dgvDelivery.Rows.Item(rownum).Cells(4).Value = txtProductClass.Text
            dgvDelivery.Rows.Item(rownum).Cells(5).Value = txtProductQuantity.Text
            Me.clear()
            Me.dgvDelivery.Enabled = True
        End If
    End Sub

    Private Sub picProductImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picProductImage.Click

    End Sub
End Class