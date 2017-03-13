Imports MySql.Data.MySqlClient

Public Class frmProductProperties
    Public Property BarCode As String

    Private Sub frmProductProperties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
        btnAdd.Text = "&SAVE"
        btnAdd.Image = My.Resources.Resources._1487710265_floppy

    End Sub
    Private Sub loadData()
        modSqlFunction.loadData("prod_properties WHERE barcode = '" & BarCode & "'", "prop_id, prop_name, prop_value", dgvProperties)
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "&SAVE" Then
            If modFormFuction.setIsTextEmpty(Me.pnlData) = True Then
                MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf modSqlFunction.searchData("prod_properties", "prop_name = '" & txtName.Text & "' and prop_value", txtValue.Text) = True Then
                MessageBox.Show("This Product is already exist...")
            Else
                Try
                    OpenCon()

                    Dim strQryTable As String = "INSERT INTO prod_properties Values('', '" & txtName.Text & "', '" & txtValue.Text & "','" & BarCode & "')"
                    Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                    myCommand.ExecuteNonQuery()
                    loadData()
                    MessageBox.Show("Data Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message & "Database Error")
                End Try
                CloseCon()
                modFormFuction.setClearAll(Me)
            End If
        ElseIf btnAdd.Text = "&UPDATE" Then
            Try
                OpenCon()
                Dim strQryTable As String = "UPDATE prod_properties SET prop_name = '" & txtName.Text & "', prop_value = '" & txtValue.Text & "' WHERE barcode = '" & BarCode & "'"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                myCommand.ExecuteNonQuery()
                loadData()
                MessageBox.Show("Data Updated..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message & "Database Error")
            End Try
            CloseCon()
            modFormFuction.setClearAll(Me)
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    
   
    Private Sub dgvProperties_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProperties.CellDoubleClick
        If Not dgvProperties.SelectedCells.Count = 0 Then
            If MessageBox.Show("Do you want to change something is this record?", "Product Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.dgvProperties.Rows(e.RowIndex)
                    txtPropId.Text = row.Cells("prop_id").Value.ToString
                    txtName.Text = row.Cells("prop_name").Value.ToString
                    txtValue.Text = row.Cells("prop_value").Value.ToString

                End If
                btnAdd.Text = "&UPDATE"
                btnAdd.Image = My.Resources.Resources._1487715899_box_in

            End If
        Else
            modFormFuction.setClearAll(Me)
        End If
    End Sub

    Private Sub dgvProperties_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProperties.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvProperties.Rows(e.RowIndex)

            txtPropId.Text = row.Cells("prop_id").Value.ToString

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not txtPropId.Text = Nothing Then
            modSqlFunction.deleteData("prod_properties", "prop_id", txtPropId.Text)
            loadData()
        Else
            MsgBox("You must select an item first!")
        End If
        modFormFuction.setClearAll(Me)
    End Sub
End Class