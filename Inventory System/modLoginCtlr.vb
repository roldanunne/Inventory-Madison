Imports MySql.Data.MySqlClient

Module modLoginCtlr
    Public user_id = ""
    Public user_access = ""
    Public imgPath = "C:\ProgramData\Madison"


    Public Function getLogin(ByVal username As String, ByVal password As String) As Boolean
        getLogin = False
        Try
            OpenCon()
            Dim strQry As String = "SELECT * FROM employee WHERE username='" & username & "' AND password='" & password & "' AND status=1 AND delete_flag=0 "
            Dim myCommand As New MySqlCommand(strQry, modDb.dbCon)
            Dim myReader As MySqlDataReader
            myCommand.ExecuteNonQuery()
            myReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                myReader.Read()
                user_id = myReader("id")
                user_access = myReader("user_access")
                getLogin = True
            End If
            myReader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "-- Database Error")
        End Try
        CloseCon()
        Return getLogin
    End Function

End Module
 