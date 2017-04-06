Imports MySql.Data.MySqlClient

Module modDb
    Public strCon As String
    Public dbCon As MySql.Data.MySqlClient.MySqlConnection
    Public strServer As String = "localhost"

    Public Sub OpenCon()    'Connect to database
        Try
            strCon = "Server=localhost; database=inventory; uid=root; pwd=; Connect Timeout=30;" 'Passwrod required
            dbCon = New MySqlConnection(strCon)
            dbCon.Open()
            'MessageBox.Show("Database Open")
        Catch ex As MySqlException
            MessageBox.Show("Database Open Connection Error-")
        End Try
    End Sub

    Public Sub CloseCon()   'Close connection to database
        Try
            dbCon.Close()
            'MessageBox.Show("Database Closed")
        Catch exclose As System.NullReferenceException
            MessageBox.Show("Database Closing Connection Error-")
        End Try
    End Sub
End Module