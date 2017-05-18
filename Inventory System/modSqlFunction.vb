Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

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
            Dim strQry As String = "SELECT * FROM " & tblName & " WHERE " & fieldName & " = '" & valueOfField & "'"
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
    'newly added
    Public Sub loadLocation(ByVal txtId As String, ByVal lbLocation As ListBox)

        Try
            OpenCon()
            Dim strQry As String = "SELECT id,rack_name FROM rack WHERE prod_id = '" & txtId & "'"
            Dim myCommand As New MySqlCommand(strQry, dbCon)
            Dim myReader As MySqlDataReader


            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader

            If myReader.HasRows Then
                While myReader.Read()
                    Dim rackId As String = myReader("id")
                    lbLocation.Items.Add(myReader("rack_name"))
                    loadLevel(rackId, lbLocation)
                End While
            End If
            myReader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Retrieving Error")
        End Try
        CloseCon()
    End Sub
    Public Sub loadLevel(ByVal rackId As String, ByVal lbLocation As ListBox)

        Try
            OpenCon()
            Dim strQry As String = "SELECT level_name FROM rack_level WHERE rack_id = '" & rackId & "'"
            Dim myCommand As New MySqlCommand(strQry, dbCon)
            Dim myReader As MySqlDataReader

            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader

            If myReader.HasRows Then
                While myReader.Read()
                    lbLocation.Items.Add("     " & myReader("level_name"))
                End While
                lbLocation.Items.Add("- - - - - - - - - - - - - - - -")
            End If
            myReader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Retrieving Error")
        End Try
        CloseCon()
    End Sub
    Public Sub loadReport(ByVal columnName As String, ByVal tableName As String, ByVal rptReport As String, ByVal datasetName As String, ByVal rvReport As ReportViewer)
        Try
            OpenCon()
            Dim myDataAdapter As New MySqlDataAdapter
            Dim myDataset As New madisonData
            Dim strQry As String = "SELECT " & columnName & " FROM " & tableName & ""
            myDataAdapter.SelectCommand = New MySqlCommand(strQry, dbCon)
            myDataAdapter.Fill(myDataset.Tables(0))

            rvReport.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            rvReport.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\" & rptReport & ""
            rvReport.LocalReport.DataSources.Clear()
            rvReport.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(datasetName, myDataset.Tables(0)))
            rvReport.DocumentMapCollapsed = True
            rvReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rvReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            rvReport.ZoomPercent = 25
            rvReport.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseCon()
    End Sub
    Public Sub loadReportRange(ByVal columnName As String, ByVal tableName As String, ByVal columnDate As String, ByVal dateFrom As String, ByVal dateTo As String, ByVal rptReport As String, ByVal datasetName As String, ByVal rvReport As ReportViewer)
        Try
            OpenCon()
            Dim myDataAdapter As New MySqlDataAdapter
            Dim myDataset As New madisonData
            Dim strQry As String = "SELECT " & columnName & " FROM " & tableName & " WHERE " & columnDate & " >= '" & dateFrom & "' And " & columnDate & " < '" & dateTo & "'"
            'WHERE " & columnDate & " >= CONVERT(datetime,'" & dateFrom & "')  AND   " & columnDate & " < CONVERT(datetime,'" & dateTo & "') ORDER BY " & columnOrder & " " & arrAscDesc & ""
            myDataAdapter.SelectCommand = New MySqlCommand(strQry, dbCon)
            myDataAdapter.Fill(myDataset.Tables(0))

            rvReport.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            rvReport.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\" & rptReport & ""
            rvReport.LocalReport.DataSources.Clear()
            rvReport.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(datasetName, myDataset.Tables(0)))
            rvReport.DocumentMapCollapsed = True
            rvReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rvReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            rvReport.ZoomPercent = 25
            'rvReport.LocalReport.ReleaseSandboxAppDomain()
            rvReport.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseCon()
    End Sub
End Module
