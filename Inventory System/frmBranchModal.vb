Public Class frmBranchModal
    Public branchModalID = 0
    Public branchModalTask = ""
    Public branchModalRow As DataGridViewRow

    Private Sub frmBranchModal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setCenterModalForm(MDIHome, Me)

        If branchModalTask = "NEW" Then
            btnSave.Text = "Save"
            modFormFuction.setClearAll(Me)
        ElseIf branchModalTask = "EDIT" Then
            btnSave.Text = "Update"
            branchModalID = branchModalRow.Cells("id").Value
            txtName.Text = branchModalRow.Cells("name").Value.ToString
            txtContact.Text = branchModalRow.Cells("contact").Value.ToString
            txtAddress.Text = branchModalRow.Cells("address").Value.ToString
            cmbStatus.Text = branchModalRow.Cells("stat").Value.ToString
        Else
            Me.Close()
        End If

    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If branchModalTask = "NEW" Then
            If modFormFuction.setIsTextEmpty(Me.gbxDetails) = True Then
                MessageBox.Show("Please Fill All Records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim stat As Integer = If(cmbStatus.Text = "Active", 1, 0)
                Dim result As Integer = modBranchCtlr.saveBranch(txtName.Text, txtAddress.Text, txtContact.Text, stat)
                If result <> 0 Then
                    frmBranch.loadDataBranch()
                    Me.Close()
                Else
                    MessageBox.Show("Please try again." & result, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        ElseIf branchModalTask = "EDIT" Then
            If modFormFuction.setIsTextEmpty(Me.gbxDetails) = True Then
                MessageBox.Show("Please Fill All Records.", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim stat As Integer = If(cmbStatus.Text = "Active", 1, 0)
                Dim result As Boolean = modBranchCtlr.updateBranch(branchModalID, txtName.Text, txtAddress.Text, txtContact.Text, stat)
                If result Then
                    frmBranch.loadDataBranch()
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