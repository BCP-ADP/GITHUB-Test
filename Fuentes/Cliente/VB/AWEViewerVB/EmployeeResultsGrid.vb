Public Class EmployeeResultsGrid

    

    Private Sub EmployeeResultsGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Load, MyBase.Load, MyBase.Load, MyBase.Load, MyBase.Load, MyBase.Load

    End Sub

    Private Sub closeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeToolStripButton.Click
        Me.Close()
    End Sub

    ' Fill table adapter with data based on selected option.
    Public Sub DisplayResults(ByVal Options() As Object)
        Try
            Select Case Options(0)
                Case "Dept"
                    ReportGenerator.UpdateProgressBar()
                    Me.VEmployeeResultsTableAdapter.Dept(Me.EmployeeResultsDataSet.vEmployeeResults, Options(1).ToString(), Options(2).ToString(), Options(3).ToString(), Options(4).ToString())
                Case "HireGreaterThan"
                    ReportGenerator.UpdateProgressBar()
                    Me.VEmployeeResultsTableAdapter.HireGreaterThan(Me.EmployeeResultsDataSet.vEmployeeResults, CType(System.Convert.ChangeType(Options(1), GetType(Date)), Date))
                Case "HireLessThan"
                    ReportGenerator.UpdateProgressBar()
                    Me.VEmployeeResultsTableAdapter.HireLessThan(Me.EmployeeResultsDataSet.vEmployeeResults, CType(System.Convert.ChangeType(Options(1), GetType(Date)), Date))
                Case "Shift"
                    ReportGenerator.UpdateProgressBar()
                    Me.VEmployeeResultsTableAdapter.Shift(Me.EmployeeResultsDataSet.vEmployeeResults, Options(1).ToString())
                Case "SickGreaterThan"
                    ReportGenerator.UpdateProgressBar()
                    Me.VEmployeeResultsTableAdapter.SickGreaterThan(Me.EmployeeResultsDataSet.vEmployeeResults, CType(System.Convert.ChangeType(Options(1), GetType(Integer)), Integer))
                Case "SickLessThan"
                    ReportGenerator.UpdateProgressBar()
                    Me.VEmployeeResultsTableAdapter.SickLessThan(Me.EmployeeResultsDataSet.vEmployeeResults, CType(System.Convert.ChangeType(Options(1), GetType(Integer)), Integer))
            End Select
            ' Update progressbar.
            ReportGenerator.UpdateProgressBar()
            Me.Show()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class



