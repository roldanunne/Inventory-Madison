Imports MySql.Data.MySqlClient

Module modBranchCtlr
    Public Function saveBranch(ByVal name As String,
                                 ByVal address As String,
                                 ByVal contact As String,
                                 ByVal status As String
                                ) As Integer
        saveBranch = 0
        Try
            OpenCon()
            Dim sql As String = "   INSERT INTO " &
                                "       branch " &
                                "   SET " &
                                "       name        = '" & name & "', " &
                                "       address     = '" & address & "', " &
                                "       contact     = '" & contact & "', " &
                                "       status      = '" & status & "', " &
                                "       created_by  = '" & USER_ID & "', " &
                                "       dt_created  = '" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "' "

            Dim myCommand As New MySqlCommand(sql, dbCon)
            myCommand.ExecuteNonQuery()

            Dim cmdLastID As New MySqlCommand("Select @@Identity", dbCon)
            saveBranch = CInt(cmdLastID.ExecuteScalar())
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & " -- Database Error")
        End Try
        CloseCon()
        Return saveBranch
    End Function

    Public Function updateBranch(ByVal id As String,
                                   ByVal name As String,
                                   ByVal address As String,
                                   ByVal contact As String,
                                   ByVal status As String
                                ) As Boolean
        Try
            OpenCon()
            Dim sql As String = "   UPDATE " &
                                "       branch " &
                                "   SET " &
                                "       name        = '" & name & "', " &
                                "       address     = '" & address & "', " &
                                "       contact     = '" & contact & "', " &
                                "       status      = '" & status & "', " &
                                "       dt_updated  = '" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "' " &
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


    Public Function deleteBranch(ByVal id As String) As Boolean
        Try
            OpenCon()
            Dim sql As String = "UPDATE branch SET delete_flag=1 WHERE id = " & id
            Dim myCommand As New MySqlCommand(sql, dbCon)
            myCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & " -- Database Error")
            Return False
        End Try
        CloseCon()
        Return True
    End Function


    Public Sub loadBranch(ByVal dgView As DataGridView)
        Try
            OpenCon()
            Dim sql As String = "SELECT id, name, address, contact, status, IF(status = 0, 'Inactive', 'Active') AS stat  FROM branch WHERE delete_flag=0 "
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
 