Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmDelivery
    Private deliveryPath = imgPath & "\Delivery"
    Dim id As String = 1
    Dim result As String
    Dim currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Dim BranchCode = "12345678"
    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        If txtBarcode.TextLength = 10 Then
            Try
                'viewing of value
                OpenCon()
                Dim strQryTable As String = "SELECT * FROM product  WHERE barcode LIKE '%" & txtBarcode.Text & "%'"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                Dim myReader As MySqlDataReader
                myCommand.ExecuteNonQuery()
                myReader = myCommand.ExecuteReader
                myReader.Read()

                Me.txtID.Text = myReader("prod_id").ToString
                Me.txtProductName.Text = myReader("prod_name").ToString
                Me.txtProductDescription.Text = myReader("prod_desc").ToString
                Me.txtProductClass.Text = myReader("prod_class").ToString
                Dim filePath = frmProducts.productsPath & "\" & txtBarcode.Text & ".jpg"
                If My.Computer.FileSystem.FileExists(filePath) Then
                    Dim img As Image = Image.FromFile(filePath)
                    modFormFuction.ResizePicture(Me.picProductImage, img)
                End If
            Catch ex As MySqlException
                MessageBox.Show("This Barcode is not found / use to your System. Please ask your Administrator", "ERROR MESSAGE")
                Me.txtBarcode.Text = ""
            End Try
            CloseCon()
        End If

    End Sub
    Dim ref_number As String
    Dim refID As String
    Private Sub btnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProduct.Click
        If btnAddProduct.Text = "&NEW" Then
            txtBarcode.ReadOnly = False
            OpenCon()
            Dim strQryTable As String = "SELECT ref_id FROM reference ORDER BY ref_id DESC Limit 1"
            Dim myCommand As New MySqlCommand(strQryTable, dbCon)
            Dim myReader As MySqlDataReader
            Dim id As String

            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                myReader.Read()
                id = myReader("ref_id").ToString
                ref_number = id + 1000 & Now.Month & Now.Day & Now.Second
                refID = id + 1
            End If
            myReader.Close()
            CloseCon()
            btnAddProduct.Text = "&SAVE"
            btnAddProduct.Image = My.Resources.Resources._1487710265_floppy
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
                                                                    & refID & "', '" _
                                                                    & Me.txtBranch.Text & "', '" _
                                                                    & "Delivered" & "')"
                        Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                        result = myCommand.ExecuteNonQuery()
                        ' MessageBox.Show("Stock Already Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Next
                Dim strQuery As String = "INSERT INTO reference (ref_number) VALUES ('" & ref_number & "')"
                Dim myCom As New MySqlCommand(strQuery, dbCon)
                result = myCom.ExecuteNonQuery()
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
            Me.btnAddProduct.Image = My.Resources.Resources._1487714481_plus
            Me.btnAddProduct.Text = "&NEW"
        End If

    End Sub
    Private Sub frmStockOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Len(Dir(deliveryPath, vbDirectory)) = 0 Then
            MkDir(deliveryPath)
        End If

        txtBarcode.ReadOnly = True
        Me.btnAddProduct.Image = My.Resources.Resources._1487714481_plus
        Me.btnAddProduct.Text = "&NEW"
        cmbViewData("branch", 1, cbBranch)
        cboDup(cbBranch)
    End Sub

    Private Sub btnMoreDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtProductQuantity.Text = "" Or txtProductQuantity.Text = 0 Then
            MessageBox.Show("Required Quantity", "Information")
        Else
            Dim rownum As Integer = dgvDelivery.Rows.Add()
            dgvDelivery.Rows.Item(rownum).Cells(0).Value = txtID.Text
            dgvDelivery.Rows.Item(rownum).Cells(1).Value = txtBarcode.Text
            dgvDelivery.Rows.Item(rownum).Cells(2).Value = txtProductName.Text
            dgvDelivery.Rows.Item(rownum).Cells(3).Value = txtProductDescription.Text
            dgvDelivery.Rows.Item(rownum).Cells(4).Value = txtProductClass.Text
            dgvDelivery.Rows.Item(rownum).Cells(5).Value = txtProductQuantity.Text
            Me.clear()
            Me.dgvDelivery.Enabled = True
        End If
    End Sub
    Public Sub clear()
        Me.txtBarcode.Text = ""
        Me.txtID.Text = ""
        Me.txtProductQuantity.Text = ""
        Me.txtProductName.Text = ""
        Me.txtProductDescription.Text = ""
        Me.txtProductClass.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
        dgvDelivery.Rows.Clear()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmCancelationDelivery.Show()
    End Sub
    Dim branch As String
    Private Sub txtBranch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranch.TextChanged
        modSqlFunction.retrieveSingleData("branch", "branch_id", txtBranch.Text, "branch_code", branch)
        cbBranch.Text = branch
    End Sub
    Private Sub cbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBranch.SelectedIndexChanged
        modSqlFunction.retrieveSingleData("branch", "branch_name", cbBranch.Text, "branch_id", txtBranch.Text)
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

            modFormFuction.EncryptFile("C:\ProgramData\Madison\Delivery\" & name, sfdSaveDelivery.FileName, BranchCode)

        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Set Error")
        End Try

    End Sub

End Class