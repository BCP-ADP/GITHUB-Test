Public Class DepartmentDetails

    ' Update database with changes made.
    Private Sub bindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bindingNavigatorSaveItem.Click
        If Me.Validate Then
            Me.DepartmentBindingSource.EndEdit()
            Me.DepartmentTableAdapter.Update(Me.DepartmentsDataSet.Department)
        Else
            System.Windows.Forms.MessageBox.Show(Me, "Validation errors occurred.", "Save", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub DepartmentDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DepartmentsDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.DepartmentsDataSet.Department)

    End Sub

    Private Sub closeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeToolStripButton.Click
        Me.Close()
    End Sub

    
End Class