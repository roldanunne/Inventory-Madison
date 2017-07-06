Imports MySql.Data.MySqlClient

Module modStocksCtlr
   

    Public Function updateEmployee(ByVal id As String,
                                   ByVal fname As String,
                                   ByVal lname As String,
                                   ByVal gender As String,
                                   ByVal address As String,
                                   ByVal status As String,
                                   ByVal menus As String,
                                   ByVal username As String,
                                   ByVal password As String
                                ) As Boolean
        Try
            OpenCon()
            Dim sql As String = "   UPDATE " &
                                "       employee " &
                                "   SET " &
                                "       fname       = '" & fname & "', " &
                                "       lname       = '" & lname & "', " &
                                "       gender      = '" & gender & "', " &
                                "       address     = '" & address & "', " &
                                "       user_access = '" & menus & "', " &
                                "       username    = '" & username & "', " &
                                "       password    = '" & password & "', " &
                                "       status      = '" & status & "'  " &
                                "   WHERE " &
                                "       id      = " & id & " "

            Dim myCommand As New MySqlCommand(sql, dbCon)
            myCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & " -- Database Error")
            Return False
        End Try
        CloseCon()
        Return True
    End Function


    Public Function deleteEmployee(ByVal id As String) As Boolean
        Try
            OpenCon()
            Dim sql As String = "UPDATE employee SET delete_flag=1 WHERE id = " & id
            Dim myCommand As New MySqlCommand(sql, dbCon)
            myCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & " -- Database Error")
            Return False
        End Try
        CloseCon()
        Return True
    End Function


    Public Sub loadEmployee(ByVal dgView As DataGridView)
        Try
            OpenCon()
            Dim sql As String = "SELECT id, fname, lname, gender, address, user_access, username, password, status, IF(status = 0, 'Inactive', 'Active') AS stat FROM employee WHERE delete_flag=0 "
            Dim mydataAdapter As New MySqlDataAdapter(sql, dbCon)
            Dim myDataTable As New DataTable
            mydataAdapter.Fill(myDataTable)
            dgView.DataSource = myDataTable
        Catch ex As Exception
            MessageBox.Show(ex.ToString & "Database Error")
        End Try
        CloseCon()
    End Sub
End Module
 