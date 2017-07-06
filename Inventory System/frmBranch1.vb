Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmBranch1
    Dim employee_id As Integer = 110
    Dim currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Private Sub frmBranch1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dvgBranch.Font = New Font("Microsoft Sans Serif", 12)
        loadData()
        Me.setFrmDefault()

    End Sub
    Private Sub loadData()

        modSqlFunction.loadData("branch", " branch_code,branch_name,branch_address,branch_contact", dvgBranch)

    End Sub
    Private Sub setFrmDefault()
        modFormFuction.setClearAll(Me)
        pnlBranchData.Enabled = False
        pnlBrachGrid.Enabled = True
        txtSearchBranch.Select()
        btnDelete.Text = "&Delete"
        btnDelete.BackColor = Color.Coral
        btnAddBranch.Text = "&New"
        btnAddBranch.Image = My.Resources.Resources.plus_house
        btnAddBranch.BackColor = Color.ForestGreen

    End Sub
    Public Sub generateBranchNumber()
        Dim Code = ""
        Dim pool = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim count = 1
        Dim cc As New Random
        Dim strpos = ""
        Try
            OpenCon()
            While count <= 8
                strpos = cc.Next(0, pool.Length)
                Code = Code & pool(strpos)
                count = count + 1
            End While

            Dim strTable As String = "SELECT branch_code FROM branch WHERE branch_code = '" & Code & "'"
            Dim myCommand As New MySqlCommand(strTable, dbCon)
            Dim myReader As MySqlDataReader

            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader

            If myReader.HasRows Then
                ' barcode already exists
                generateBranchNumber()
            Else
                txtBranchCode.Text = Code
            End If
            CloseCon()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Database Update Error")
        End Try

    End Sub

    Private Sub btnAddBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBranch.Click
        If btnAddBranch.Text = "&New" Then
            btnDelete.Text = "&Cancel"
            btnDelete.BackColor = Color.IndianRed
            modFormFuction.setClearAll(Me)
            generateBranchNumber()
            pnlBranchData.Enabled = True
            pnlBrachGrid.Enabled = False
            btnAddBranch.Text = "&Save"
            btnAddBranch.BackColor = Color.FromArgb(51, 122, 183)
            btnAddBranch.Image = My.Resources.Resources.check_house
        ElseIf btnAddBranch.Text = "&Save" Then
            btnAddBranch.BackColor = Color.RoyalBlue
            If modFormFuction.setIsTextEmpty(Me.pnlBranchData) = True Then
                MessageBox.Show("Please fill all records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf modSqlFunction.searchData("branch", "branch_name", txtBranchCode.Text) = True Then
                MessageBox.Show("This Branch already exist...")
            Else
                Try
                    OpenCon()
                    Dim strQryTable As String = "INSERT INTO branch Values('','" & txtBranchCode.Text & "', '" & txtBranchName.Text & "', '" & txtBranchAddress.Text & "',  '" & txtBranchContact.Text & "','" & currentDate & "','','" & employee_id & "')"
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
        ElseIf btnAddBranch.Text = "&Update" Then
            Try
                OpenCon()

                Dim strQryTable As String = "UPDATE branch SET branch_code = '" & txtBranchCode.Text & "', branch_name = '" & txtBranchName.Text & "', branch_address = '" &
                    txtBranchAddress.Text & "', branch_contact = '" & txtBranchContact.Text & "' , date_updated = '" & currentDate & "' WHERE branch_code = '" & txtBranchCode.Text & "'"
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

    Private Sub dvgBranch_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgBranch.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dvgBranch.Rows(e.RowIndex)
            txtBranchCode.Text = row.Cells("branch_code").Value.ToString
            txtBranchName.Text = row.Cells("branch_name").Value.ToString
            txtBranchAddress.Text = row.Cells("branch_address").Value.ToString
            txtBranchContact.Text = row.Cells("branch_contact").Value.ToString
        End If
    End Sub
    Private Sub dvgBranch_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgBranch.CellDoubleClick
        If Not dvgBranch.SelectedCells.Count = 0 Then
            If MessageBox.Show("Do you want to change something is this record?", "Product Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                pnlBranchData.Enabled = True

                btnDelete.Text = "&Cancel"
                btnDelete.BackColor = Color.IndianRed
                btnAddBranch.Text = "&Update"
                btnAddBranch.Image = My.Resources.Resources.check_house

            End If
        Else
            Me.setFrmDefault()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Delete" Then
            If Not txtBranchCode.Text = Nothing Then
                If MessageBox.Show("Do You Want to DELETE this Record...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                    modSqlFunction.deleteData("branch", "branch_code", txtBranchCode.Text)
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

    Private Sub txtSearchBranch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchBranch.TextChanged
        modSqlFunction.loadData("branch WHERE branch_name LIKE '%" & txtSearchBranch.Text & "%' or branch_code LIKE '%" & txtSearchBranch.Text & "%' or branch_address LIKE '%" & txtSearchBranch.Text & "%'", "branch_code,branch_name,branch_address,branch_contact", dvgBranch)

    End Sub
    Private Sub txtBranchContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchContact.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBranchContact_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBranchContact.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtBranchContact.Text = digitsOnly.Replace(txtBranchContact.Text, "")
    End Sub

End Class