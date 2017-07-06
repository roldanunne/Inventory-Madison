Public Class frmSupplierModal
    Public supModalID = 0
    Public supModalTask = ""
    Public supModalRow As DataGridViewRow

    Private Sub frmSupplierModal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setCenterModalForm(MDIHome, Me)

        If supModalTask = "NEW" Then
            btnSave.Text = "Save"
            modFormFuction.setClearAll(Me)
        ElseIf supModalTask = "EDIT" Then
            btnSave.Text = "Update"
            supModalID = supModalRow.Cells("id").Value
            txtName.Text = supModalRow.Cells("name").Value.ToString
            txtContact.Text = supModalRow.Cells("contact").Value.ToString
            txtAddress.Text = supModalRow.Cells("address").Value.ToString
            cmbStatus.Text = supModalRow.Cells("stat").Value.ToString
        Else
            Me.Close()
        End If

    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If supModalTask = "NEW" Then
            If modFormFuction.setIsTextEmpty(Me.gbxDetails) = True Then
                MessageBox.Show("Please Fill All Records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim stat As Integer = If(cmbStatus.Text = "Active", 1, 0)
                Dim result As Integer = modSupplierCtlr.saveSupplier(txtName.Text, txtAddress.Text, txtContact.Text, stat)
                If result <> 0 Then
                    frmSupplier.loadDataSupplier()
                    Me.Close()
                Else
                    MessageBox.Show("Please try again." & result, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        ElseIf supModalTask = "EDIT" Then
            If modFormFuction.setIsTextEmpty(Me.gbxDetails) = True Then
                MessageBox.Show("Please Fill All Records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim stat As Integer = If(cmbStatus.Text = "Active", 1, 0)
                Dim result As Boolean = modSupplierCtlr.updateSupplier(supModalID, txtName.Text, txtAddress.Text, txtContact.Text, stat)
                If result Then
                    frmSupplier.loadDataSupplier()
                    Me.Close()
                Else
                    MessageBox.Show("Please try again.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class