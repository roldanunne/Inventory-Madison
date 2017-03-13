Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmBranch
    Dim employee_id As Integer = 110
    Dim currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Private Sub frmNewProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dvgBranch.Font = New Font("Microsoft Sans Serif", 12)
        loadData()
        Me.setFrmDefault()

    End Sub
    Private Sub loadData()

        modSqlFunction.loadData("branch", " branch_code,branch_name,branch_address,branch_contact", dvgBranch)
        With dvgBranch
            .Columns(0).DataPropertyName = "branch_code"
            .Columns(1).DataPropertyName = "branch_name"
            .Columns(2).DataPropertyName = "branch_address"
            .Columns(3).DataPropertyName = "branch_contact"
            .DataSource = dvgBranch.DataSource
        End With
    End Sub
    Private Sub setFrmDefault()
        modFormFunction.setClearAll(Me)
        pnlBranchData.Enabled = False
        pnlBrachGrid.Enabled = True
        txtSearchBranch.Select()
        btnAddBranch.Text = "&NEW"
        btnAddBranch.Image = My.Resources.Resources._1487714481_plus

    End Sub
    Public Sub generateBranchNumber()
        Dim Code = ""
        Dim pool = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim count = 1
        Dim cc As New Random
        Dim strpos = ""
        Try
            OpenCon()
            While count <= 10
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
        If btnAddBranch.Text = "&NEW" Then
            modFormFunction.setClearAll(Me)
            generateBranchNumber()
            pnlBranchData.Enabled = True
            pnlBrachGrid.Enabled = False
            btnAddBranch.Text = "&SAVE"
            btnAddBranch.Image = My.Resources.Resources._1487710265_floppy
        ElseIf btnAddBranch.Text = "&SAVE" Then
            If modFormFunction.setIsTextEmpty(Me.pnlBranchData) = True Then
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
        ElseIf btnAddBranch.Text = "&UPDATE" Then
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

                btnAddBranch.Text = "&UPDATE"
                btnAddBranch.Image = My.Resources.Resources.update
            End If
        Else
            Me.setFrmDefault()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.setFrmDefault()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do You Want to DELETE this Record...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            modSqlFunction.deleteData("branch", "branch_code", txtBranchCode.Text)
            Me.setFrmDefault()
            loadData()
        End If
    End Sub

    Private Sub txtSearchBranch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchBranch.TextChanged
        modSqlFunction.loadData("branch WHERE branch_name LIKE '%" & txtSearchBranch.Text & "%' or branch_code LIKE '%" & txtSearchBranch.Text & "%'", "branch_code,branch_name,branch_address,branch_contact", dvgBranch)
        With dvgBranch
            .Columns(0).DataPropertyName = "branch_code"
            .Columns(1).DataPropertyName = "branch_name"
            .Columns(2).DataPropertyName = "branch_address"
            .Columns(3).DataPropertyName = "branch_contact"
            .DataSource = dvgBranch.DataSource
        End With
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


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class