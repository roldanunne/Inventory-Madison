Imports MySql.Data.MySqlClient

Public Class popLogFiles
    Dim result As String
    Dim id As String = 1
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If txtReason.Text = "" Or txtCancelqty.Text = "" Then
            MsgBox("Required Fields")
        Else
            Try
                OpenCon()
                Dim strQryTable As String = "UPDATE stock_out SET quantity = '" & Me.txtCancelqty.Text & "' ,status = 'Canceled' WHERE stock_out_id = '" & frmCancelationDelivery.txtStockId.Text & "'"
                Dim myCommand As New MySqlCommand(strQryTable, dbCon)
                myCommand.ExecuteNonQuery()
                Me.logfiles()
                'MessageBox.Show("Data Canceled..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message & "Database Error")
            End Try
            CloseCon()
        End If
    End Sub
    Public Sub logfiles()
        Try
            OpenCon()
            Dim strQryTable As String = "INSERT INTO logfile (log_file,user_id) VALUES ('" & Me.txtReason.Text & "', '" & id & "')"
            Dim myCommand As New MySqlCommand(strQryTable, dbCon)
            result = myCommand.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Cancel Record.")
            Else
                MsgBox("Successful of Canceling Delivery.")
                Exit Sub
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "Database Error")
        End Try
        CloseCon()
    End Sub
End Class