Imports MySql.Data.MySqlClient

Public Class frmRack
    Dim currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

    Private Sub frmRack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadRack()
        loadLevel()
        loadProducts()
        setFromDefault()
    End Sub
    Private Sub loadProducts()
        cmbProduct.Items.Add("Select Product")
        cmbViewData("product", 2, cmbProduct)
        cmbProduct.SelectedIndex = 0
    End Sub
    Private Sub loadRack()
        Dim query As String = "rack.id,rack_name,rack_desc,prod_id"
        modSqlFunction.loadData("rack", query, dgvRack)
    End Sub
    Private Sub loadLevel()
        Dim table As String = "rack_level INNER JOIN rack ON rack.id=rack_level.rack_id"
        Dim query As String = "rack_level.id,level_name,level_desc,capacity,rack_name"
        modSqlFunction.loadData(table, query, dgvLevel)
    End Sub
    Private Sub setFromDefault()
        btnAddLevel.Enabled = False
        txtSearch.Select()
        pnlRackData.Enabled = False
        pnlLevelData.Enabled = False
        pnlRackLevel.Enabled = True
        cmbProduct.SelectedIndex = 0
        btnAddSave.Text = "&New"
        btnAddSave.Image = My.Resources.server_add
        btnAddSave.BackColor = Color.ForestGreen
        btnCancelDelete.Text = "&Delete"
        btnCancelDelete.BackColor = Color.Coral
        modFormFuction.setClearAll(Me)
    End Sub
    Private Sub setBtnSaveUpdate()
        btnAddLevel.Enabled = True
        pnlRackData.Enabled = True
        pnlRackLevel.Enabled = False
        btnAddSave.Image = My.Resources.server_check
        btnAddSave.BackColor = Color.RoyalBlue
        btnCancelDelete.Text = "&Cancel"
        btnCancelDelete.BackColor = Color.IndianRed
    End Sub
    Private Sub saveRack()
        If txtRackName.Text = "" Or txtRackDesc.Text = "" Then
            MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf modSqlFunction.searchData("rack", "rack_name", txtRackName.Text) = True Then
            MessageBox.Show("This Rack is already exist...")
        Else
            Try
                OpenCon()
                Dim strQryTable As String = "INSERT INTO rack Values('','" & txtRackName.Text & "','" & txtRackDesc.Text & "','" & currentDate & "','','" & modLoginCtlr.user_id & "' ,'" & txtProdId.Text & "')"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                myCommand.ExecuteNonQuery()

                MessageBox.Show("Data Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadRack()
                setFromDefault()
                modFormFuction.setClearAll(Me)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message & "Database Error")
            End Try
            CloseCon()
        End If
    End Sub
    Private Sub saveLevel(ByVal rack_id As Integer)
        If txtLevelName.Text = "" Or txtLevelDesc.Text = "" Or txtLevelCapacity.Text = "" Then
            MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                OpenCon()
                Dim strQryTable As String = "INSERT INTO rack_level Values('','" & txtLevelName.Text & "','" & txtLevelDesc.Text & "','" & txtLevelCapacity.Text & "','" & currentDate & "','','" & modLoginCtlr.user_id & "','" & rack_id & "')"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                myCommand.ExecuteNonQuery()

                MessageBox.Show("Data Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadLevel()
                setFromDefault()
                modFormFuction.setClearAll(Me)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message & "Database Error")
            End Try
            CloseCon()
        End If
    End Sub
    Private Sub btnAddSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSave.Click
        If btnAddSave.Text = "&New" Then
            setBtnSaveUpdate()
            cmbProduct.SelectedIndex = 0
            btnAddSave.Text = "&Save"
            modFormFuction.setClearAll(Me)
        ElseIf btnAddSave.Text = "&Save" Then
            If txtRackId.Text = "" And pnlLevelData.Enabled = False Then
                'new and no level included
                saveRack()
            ElseIf txtRackId.Text = "" And pnlLevelData.Enabled = True Then
                'new and theres level included
                If txtRackName.Text = "" Or txtRackDesc.Text = "" Then
                    MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf modSqlFunction.searchData("rack", "rack_name", txtRackName.Text) = True Then
                    MessageBox.Show("This Rack is already exist...")
                Else
                    If txtLevelName.Text = "" Or txtLevelDesc.Text = "" Or txtLevelCapacity.Text = "" Then
                        MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Try
                            OpenCon()
                            Dim strQryTable As String = "INSERT INTO rack Values('','" & txtRackName.Text & "','" & txtRackDesc.Text & "','" & currentDate & "','','" & modLoginCtlr.user_id & "' ,'" & txtProdId.Text & "')"
                            Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                            myCommand.ExecuteNonQuery()

                            Dim cmdLastID As New MySqlCommand("Select @@Identity", dbCon)
                            Dim rack_id As Integer = CInt(cmdLastID.ExecuteScalar())

                            Dim QryTable As String = "INSERT INTO rack_level Values('','" & txtLevelName.Text & "','" & txtLevelDesc.Text & "','" & txtLevelCapacity.Text & "','" & currentDate & "','','" & modLoginCtlr.user_id & "','" & rack_id & "')"
                            Dim command As New MySqlCommand(QryTable, dbCon)
                            command.ExecuteNonQuery()

                            MessageBox.Show("Data Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            loadRack()
                            loadLevel()
                            setFromDefault()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message & "Database Error")
                        End Try
                        CloseCon()
                    End If
                End If
            ElseIf Not txtRackId.Text = "" And pnlRackData.Enabled = False Then
                saveLevel(Convert.ToInt32(txtRackId.Text))

            End If
        ElseIf btnAddSave.Text = "&Update" Then
            If Not txtRackId.Text = "" And pnlLevelData.Enabled = False Then
                If txtRackName.Text = "" Or txtRackDesc.Text = "" Then
                    MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Try
                        OpenCon()
                        Dim strQryTable As String = "UPDATE rack SET rack_name = '" & txtRackName.Text & "', rack_desc = '" & txtRackDesc.Text &
                            "', employee_id = '" & modLoginCtlr.user_id & "', date_updated = '" & currentDate & "', prod_id = '" & txtProdId.Text & "' WHERE id = '" & txtRackId.Text & "'"
                        Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                        myCommand.ExecuteNonQuery()
                        MessageBox.Show("Record Updated", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        loadRack()
                        setFromDefault()
                        modFormFuction.setClearAll(Me)
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message & "Database Error")
                    End Try
                    CloseCon()
                End If
            ElseIf Not txtLevelId.Text = "" And pnlRackData.Enabled = False Then
                If txtLevelName.Text = "" Or txtLevelDesc.Text = "" Or txtLevelCapacity.Text = "" Then
                    MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Try
                        OpenCon()
                        Dim strQryTable As String = "UPDATE rack_level SET level_name = '" & txtLevelName.Text & "', level_desc = '" & txtLevelDesc.Text &
                            "', capacity = '" & txtLevelCapacity.Text & "', employee_id = '" & modLoginCtlr.user_id & "', date_updated = '" & currentDate & "' WHERE rack_level.id = '" & txtLevelId.Text & "'"
                        Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                        myCommand.ExecuteNonQuery()
                        MessageBox.Show("Record Updated", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        loadLevel()
                        setFromDefault()
                        modFormFuction.setClearAll(Me)
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message & "Database Error")
                    End Try
                    CloseCon()
                End If
            End If
        End If
    End Sub
    Private Sub dgvRack_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRack.CellClick
        clearLevel()
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvRack.Rows(e.RowIndex)
            txtRackId.Text = row.Cells("id").Value.ToString
            txtRackName.Text = row.Cells("rack_name").Value.ToString
            txtRackDesc.Text = row.Cells("rack_desc").Value.ToString
            txtProdId.Text = row.Cells("prod_id").Value.ToString
            btnAddLevel.Enabled = True
        End If

    End Sub
    Private Sub dgvRack_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRack.CellDoubleClick
        If Not dgvRack.SelectedCells.Count = 0 Then

            If MessageBox.Show("Do you want to change something is this record?", "Product Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                btnAddSave.Text = "&Update"
                setBtnSaveUpdate()
            End If
        Else
            setFromDefault()
        End If

    End Sub
    Private Sub dgvLevel_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLevel.CellClick
        clearRack()
        cmbProduct.SelectedIndex = 0
        txtProdId.Text = ""
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvLevel.Rows(e.RowIndex)
            txtLevelId.Text = row.Cells("level_id").Value.ToString
            txtLevelName.Text = row.Cells("level_name").Value.ToString
            txtLevelDesc.Text = row.Cells("level_desc").Value.ToString
            txtLevelCapacity.Text = row.Cells("capacity").Value.ToString
        End If
    End Sub
    Private Sub dgvLevel_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLevel.CellDoubleClick
        If Not dgvLevel.SelectedCells.Count = 0 Then

            If MessageBox.Show("Do you want to change something is this record?", "Product Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                btnAddSave.Text = "&Update"
                setBtnSaveUpdate()
                pnlLevelData.Enabled = True
                pnlRackData.Enabled = False
                btnAddLevel.Enabled = False
            End If
        Else
            setFromDefault()
        End If

    End Sub
    Private Sub btnCancelDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelDelete.Click
        If btnCancelDelete.Text = "&Delete" Then
            If Not txtRackId.Text = "" Then
                If MessageBox.Show("Do You Want to DELETE this Record...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                    Dim strTable As String = "SELECT rack_id FROM rack_level WHERE rack_id = " & txtRackId.Text & ""
                    Dim myCommand As New MySqlCommand(strTable, dbCon)
                    Dim myReader As MySqlDataReader

                    myCommand.ExecuteNonQuery()
                    myReader = myCommand.ExecuteReader

                    If myReader.HasRows Then
                        Try
                            OpenCon()
                            Dim strQryTable As String = "Delete From rack Where rack.id = '" & txtRackId.Text & "'"
                            Dim command As New MySqlCommand(strQryTable, dbCon)
                            command.ExecuteNonQuery()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message & "Database Deletion Error")
                        End Try
                        CloseCon()
                        modSqlFunction.deleteData("rack_level", "rack_id", txtRackId.Text)
                    Else
                        modSqlFunction.deleteData("rack", "rack.id", txtRackId.Text)
                    End If
                    setFromDefault()
                    loadRack()
                End If
            ElseIf Not txtLevelId.Text = "" Then
                If MessageBox.Show("Do You Want to DELETE this Record...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                    modSqlFunction.deleteData("rack_level", "id", txtLevelId.Text)
                End If
                loadLevel()
            Else
                MessageBox.Show("Please select a record first.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf btnCancelDelete.Text = "&Cancel" Then
            setFromDefault()
        End If
    End Sub

    Private Sub btnAddLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLevel.Click
        If Not txtRackId.Text = "" Then
            btnAddSave.Text = "&Save"
            btnAddSave.Image = My.Resources.server_check
            btnAddSave.BackColor = Color.RoyalBlue
            pnlLevelData.Enabled = True
            btnCancelDelete.Text = "&Cancel"
            btnCancelDelete.BackColor = Color.IndianRed
            pnlRackData.Enabled = False
            clearLevel()
        Else
            pnlLevelData.Enabled = True
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim tblRack As String = "rack WHERE rack_name LIKE '%" & txtSearch.Text & "%' or rack_desc LIKE '%" & txtSearch.Text & "%'"
        Dim tblLevel As String = "rack_level INNER JOIN rack ON rack.id=rack_level.rack_id WHERE level_name LIKE '%" & txtSearch.Text & "%' or rack_name LIKE '%" & txtSearch.Text & "%'"
        modSqlFunction.loadData(tblRack, "id,rack_name,rack_desc,prod_id", dgvRack)
        modSqlFunction.loadData(tblLevel, "rack_level.id,level_name, level_desc, capacity, rack_name", dgvLevel)
    End Sub
    Private Sub clearLevel()
        txtLevelId.Text = vbNullString
        txtLevelName.Text = vbNullString
        txtLevelDesc.Text = vbNullString
        txtLevelCapacity.Text = vbNullString
    End Sub
    Private Sub clearRack()
        txtRackId.Text = vbNullString
        txtRackName.Text = vbNullString
        txtRackDesc.Text = vbNullString
    End Sub
    Private Sub cmbProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProduct.SelectedIndexChanged
        If Not cmbProduct.Text = "Select Product" Then
            retrieveSingleData("product", "prod_name", cmbProduct.Text, "id", txtProdId.Text)
        End If
    End Sub

    Private Sub txtProdId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdId.TextChanged
        retrieveSingleData("product", "id", txtProdId.Text, "prod_name", cmbProduct.Text)
    End Sub
End Class