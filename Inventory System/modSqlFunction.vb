Imports MySql.Data.MySqlClient

Module modSqlFunction
    Public Function searchData(ByVal tblName As String, ByVal fieldName As String, ByVal fieldName1 As String) As Boolean
        searchData = False
        Try
            OpenCon()
            Dim strQry As String = "SELECT * FROM " & tblName & " WHERE " & fieldName & " LIKE '" & fieldName1 & "'"
            Dim myCommand As New MySqlCommand(strQry, dbCon)
            Dim myReader As MySqlDataReader
            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                searchData = True
            End If
            myReader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "-- Database Error")
        End Try
        CloseCon()
        Return searchData
    End Function
    Public Sub deleteData(ByVal tblName As String, ByVal fieldname As String, ByVal data_id As String)
        Try
            OpenCon()
            Dim strQryTable As String = "Delete From " & tblName & " Where " & fieldname & " = '" & data_id & "'"
            Dim myCommand As New MySqlCommand(strQryTable, dbCon)
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Data Deleted Successfuly.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Deletion Error")
        End Try
        CloseCon()
    End Sub
    Public Sub getPictureData(ByVal tblName As String, ByVal fieldName As String, ByVal valueOfField As String,
                                   ByVal fieldToRetrieve As String, ByRef objectName As PictureBox)
        Try
            OpenCon()
            Dim strQry As String = "SELECT * FROM " & tblName & " WHERE " & fieldname & " = '" & valueOfField & "'"
            Dim myCommand As New MySqlCommand(strQry, dbCon)
            Dim myReader As MySqlDataReader

            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader

            If myReader.HasRows Then
                myReader.Read()
                objectName.Image = BytesToImage(myReader(fieldToRetrieve))
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Update Error")
        End Try
    End Sub
    Public Sub retrieveSingleData(ByVal tblName As String, ByVal fieldName As String, ByVal valueOfField As String,
                           ByVal fieldToRetrieve As String, ByRef objectName As String)

        Try
            OpenCon()
            Dim strQry As String = "SELECT * FROM " & tblName & " WHERE " & fieldName & " = '" & valueOfField & "'"
            Dim myCommand As New MySqlCommand(strQry, dbCon)
            Dim myReader As MySqlDataReader

            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                myReader.Read()
                objectName = myReader(fieldToRetrieve)
            End If
            myReader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Retrieving Error")
        End Try
        CloseCon()
    End Sub
   
    Public Sub cmbViewData(ByVal tblName As String, ByVal strIndex As Integer, ByVal cmb_data As ComboBox)
        Dim ctr As Integer
        Dim i As Integer
        Dim lv As New ListViewItem
        Try
            OpenCon()
            Dim strQry As String = "SELECT * FROM " & tblName & ""
            Dim myCommand As New MySqlCommand(strQry, dbCon)
            Dim myReader As MySqlDataReader = myCommand.ExecuteReader()

            'cmb_data.Items.Clear()
            i = Val(myReader.FieldCount.ToString)
            While myReader.Read()
                For ctr = 0 To i
                    cmb_data.Items.Add(myReader(strIndex).ToString)
                Next ctr
            End While
            myReader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Set Error")
        End Try
        cboDup(cmb_data)
        CloseCon()
    End Sub

    'newly added
    Public Sub loadData(ByVal tblName As String, ByVal ColumnName As String, ByVal dgView As DataGridView)
        Try
            OpenCon()
            Dim mydataAdapter As New MySqlDataAdapter("SELECT " & ColumnName & " FROM " & tblName & "", dbCon)
            Dim myDataTable As New DataTable
            mydataAdapter.Fill(myDataTable)
            dgView.DataSource = myDataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Database Update Error")
        End Try
    End Sub


    'newly added
    Public Sub loadDataGrid(ByVal strQuery As String, ByVal dgView As DataGridView)
        Try
            OpenCon()
            Dim mydataAdapter As New MySqlDataAdapter(strQuery, dbCon)
            Dim myDataTable As New DataTable
            mydataAdapter.Fill(myDataTable)
            dgView.DataSource = myDataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Database Update Error")
        End Try
    End Sub

End Module
