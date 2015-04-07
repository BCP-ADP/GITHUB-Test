Public Class EmployeeDetails

    Private Sub EmployeeDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDetailsDataSet.vEmployeeDetails' table. You can move, or remove it, as needed.
        Me.VEmployeeDetailsTableAdapter.Fill(Me.EmployeeDetailsDataSet.vEmployeeDetails)

    End Sub

    Private Sub closeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeToolStripButton.Click
        Me.Close()
    End Sub

   
    
End Class