Imports MySql.Data.MySqlClient

Public Class frmSupplier1

    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
        setFrmDefault()
        Me.dgvSupplier.Font = New Font("Microsoft Sans Serif", 12)
    End Sub
    Private Sub loadData()

        modSqlFunction.loadData("supplier", "*", dgvSupplier)
    End Sub
    Private Sub setFrmDefault()
        modFormFuction.setClearAll(Me)
        pnlSupplierData.Enabled = False
        pnlSupplierGrid.Enabled = True
        btnDelete.Text = "&Delete"
        btnDelete.BackColor = Color.Coral
        btnAddSupplier.Text = "&New"
        btnAddSupplier.Image = My.Resources.Resources.plus_house
        btnAddSupplier.BackColor = Color.ForestGreen

    End Sub

    Private Sub btnAddSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSupplier.Click
        If btnAddSupplier.Text = "&New" Then
            btnDelete.Text = "&Cancel"
            btnDelete.BackColor = Color.IndianRed
            modFormFuction.setClearAll(Me)
            pnlSupplierData.Enabled = True
            pnlSupplierGrid.Enabled = False
            btnAddSupplier.Text = "&Save"
            btnAddSupplier.BackColor = Color.FromArgb(51, 122, 183)
            btnAddSupplier.Image = My.Resources.Resources.check_house
        ElseIf btnAddSupplier.Text = "&Save" Then
            btnAddSupplier.BackColor = Color.RoyalBlue
            If modFormFuction.setIsTextEmpty(Me.pnlSupplierData) = True Then
                MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf modSqlFunction.searchData("supplier", "sup_id", txtSupplierId.Text) = True Then
                MessageBox.Show("This Supplier already exist...")
            Else
                Try
                    OpenCon()
                    Dim strQryTable As String = "INSERT INTO supplier Values('','" & txtSupplierName.Text & "', '" & txtSupplierAddress.Text & "', '" & txtSupplierContact.Text & "')"
                    Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                    myCommand.ExecuteNonQuery()
                    loadData()
                    MessageBox.Show("Data Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message & "Database Error")
                End Try
                CloseCon()
                Me.setFrmDefault()
            End If
        ElseIf btnAddSupplier.Text = "&Update" Then

            Try
                OpenCon()

                Dim strQryTable As String = "UPDATE supplier SET  sup_name = '" & txtSupplierName.Text & "', sup_address = '" &
                    txtSupplierAddress.Text & "', sup_contact = '" & txtSupplierContact.Text & "' WHERE sup_id = '" & txtSupplierId.Text & "'"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                myCommand.ExecuteNonQuery()
                loadData()
                MessageBox.Show("Data Updated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message & "Database Error")
            End Try
            CloseCon()
            Me.setFrmDefault()
        End If
    End Sub


    Private Sub dgvSupplier_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplier.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvSupplier.Rows(e.RowIndex)
            txtSupplierId.Text = row.Cells("sup_id").Value.ToString
            txtSupplierName.Text = row.Cells("sup_name").Value.ToString
            txtSupplierAddress.Text = row.Cells("sup_address").Value.ToString
            txtSupplierContact.Text = row.Cells("sup_contact").Value.ToString
        End If
    End Sub
    Private Sub dgvSupplier_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplier.CellDoubleClick
        If Not dgvSupplier.SelectedCells.Count = 0 Then

            If MessageBox.Show("Do you want to change something is this record?", "Product Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                pnlSupplierData.Enabled = True
                btnAddSupplier.BackColor = Color.RoyalBlue
                btnDelete.Text = "&Cancel"
                btnDelete.BackColor = Color.IndianRed
                btnAddSupplier.Text = "&Update"

                btnAddSupplier.Image = My.Resources.Resources.check_house
            End If
        Else
            Me.setFrmDefault()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Delete" Then
            If Not txtSupplierId.Text = Nothing Then
                If MessageBox.Show("Do You Want to DELETE this Record...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                    modSqlFunction.deleteData("supplier", "sup_id", txtSupplierId.Text)
                    Me.setFrmDefault()
                    loadData()
                End If
            Else
                MsgBox("Please select a record")
            End If
        ElseIf btnDelete.Text = "&Cancel" Then
            Me.setFrmDefault()
        End If

    End Sub


    Private Sub txtSearchSupplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchSupplier.TextChanged
        modSqlFunction.loadData("supplier WHERE sup_name LIKE '%" & txtSearchSupplier.Text & "%' or sup_address LIKE '%" & txtSearchSupplier.Text & "%'", "*", dgvSupplier)
    End Sub

End Class