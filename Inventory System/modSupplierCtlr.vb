Imports MySql.Data.MySqlClient

Module modSupplierCtlr
    Public Function saveSupplier(ByVal name As String,
                                 ByVal address As String,
                                 ByVal contact As String,
                                 ByVal status As String
                                ) As Integer
        saveSupplier = 0
        Try
            OpenCon()
            Dim sql As String = "   INSERT INTO " &
                                "       supplier " &
                                "   SET " &
                                "       name        = '" & name & "', " &
                                "       address     = '" & address & "', " &
                                "       contact     = '" & contact & "', " &
                                "       status      = '" & status & "', " &
                                "       dt_created  = '" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "' "

            Dim myCommand As New MySqlCommand(sql, dbCon)
            myCommand.ExecuteNonQuery()

            Dim cmdLastID As New MySqlCommand("Select @@Identity", dbCon)
            saveSupplier = CInt(cmdLastID.ExecuteScalar())
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & " -- Database Error")
            End Try
        CloseCon()
        Return saveSupplier
    End Function

    Public Function updateSupplier(ByVal id As String,
                                   ByVal name As String,
                                   ByVal address As String,
                                   ByVal contact As String,
                                   ByVal status As String
                                ) As Boolean
        Try
            OpenCon()
            Dim sql As String = "   UPDATE " &
                                "       supplier " &
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


    Public Function deleteSupplier(ByVal id As String) As Boolean
        Try
            OpenCon()
            Dim sql As String = "UPDATE supplier SET delete_flag=1 WHERE id = " & id
            Dim myCommand As New MySqlCommand(sql, dbCon)
            myCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & " -- Database Error")
            Return False
        End Try
        CloseCon()
        Return True
    End Function


    Public Sub loadSupplier(ByVal dgView As DataGridView)
        Try
            OpenCon()
            Dim sql As String = "SELECT id, name, address, contact, status, IF(status = 0, 'Inactive', 'Active') AS stat  FROM supplier WHERE delete_flag=0 "
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
 