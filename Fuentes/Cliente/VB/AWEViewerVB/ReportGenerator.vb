Public Class ReportGenerator
    ' Private variables to store values selected on form.
    Private _selectedOption As String
    Private _depts As New ArrayList
    Private _shift As String
    Private _hireDate As Date
    Private _sickLeave As Integer

    ' Public properties to get and set values stored in private variables.
    Property Depts() As ArrayList
        Get
            Return _depts
        End Get
        Set(ByVal value As ArrayList)
            _depts = value
        End Set
    End Property

    Property SelectedOption() As String
        Get
            Return _selectedOption
        End Get
        Set(ByVal value As String)
            _selectedOption = value
        End Set
    End Property
    Property Shift() As String
        Get
            Return _shift
        End Get
        Set(ByVal value As String)
            _shift = value
        End Set
    End Property
    Property HireDate() As Date
        Get
            Return _hireDate
        End Get
        Set(ByVal value As Date)
            _hireDate = value
        End Set
    End Property
    Property SickLeave() As Integer
        Get
            Return _sickLeave
        End Get
        Set(ByVal value As Integer)
            _sickLeave = value
        End Set
    End Property

    Private Sub viewResultsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewResultsToolStripButton.Click, ViewResultsToolStripMenuItem.Click, ViewResultsToolStripMenuItem1.Click
        Try
            ' Initialize properties.
            reportErrorProvider.Clear()
            Depts.Clear()
            HireDate = System.DateTime.MinValue
            SickLeave = 0
            Shift = ""
            SelectedOption = ""
            reportToolStripProgressBar.Value = reportToolStripProgressBar.Minimum
            Me.Cursor = Cursors.WaitCursor
            reportToolStripStatusLabel.Text = "Creating results..."
            Application.DoEvents()
            Select Case True
                ' Dept option selected.
                Case deptRadioButton.Checked
                    ' Set SelectedOption propert to Dept.
                    Me.SelectedOption = "Dept"
                    ' Store the selected departments.
                    Dim clb As CheckedListBox.CheckedItemCollection = Me.deptCheckedListBox.CheckedItems
                    Dim I As Integer
                    If clb.Count > 0 Then
                        ' Initialize Depts ArrayList with empty strings.
                        For I = 1 To 4
                            Depts.Add("")
                        Next I
                        ' Insert each selected department into Depts ArrayList.
                        For I = 0 To clb.Count - 1
                            Depts.Insert(I, clb.Item(I))
                        Next
                        ' Store the selected options.
                        Dim Options(5) As Object
                        Options(0) = SelectedOption
                        Options(1) = Depts(0)
                        Options(2) = Depts(1)
                        Options(3) = Depts(2)
                        Options(4) = Depts(3)
                        UpdateProgressBar()
                        ' Open EmployeeResultsGrid form and provide selected options.
                        Dim newEmployeeResultsGrid As New EmployeeResultsGrid()
                        newEmployeeResultsGrid.DisplayResults(Options)
                    End If
                    ' HireDate option selected.
                Case hireDateRadioButton.Checked
                    ' Set SelectedOption property to correct value.
                    If hireDateComboBox.Text = ">=" Then
                        Me.SelectedOption = "HireGreaterThan"
                    ElseIf hireDateComboBox.Text = "<=" Then
                        Me.SelectedOption = "HireLessThan"
                    End If
                    ' Set HireDate property to value selected in MonthCalendar.
                    HireDate = hireDateMonthCalendar.SelectionStart
                    ' Store the selected options.
                    Dim Options(2) As Object
                    Options(0) = SelectedOption
                    Options(1) = HireDate
                    reportToolStripProgressBar.Increment(reportToolStripProgressBar.Step)
                    Application.DoEvents()
                    UpdateProgressBar()
                    ' Open EmployeeResultsGrid form and provide selected options.
                    Dim newEmployeeResultsGrid As New EmployeeResultsGrid()
                    newEmployeeResultsGrid.DisplayResults(Options)
                    ' Shift option selected.
                Case shiftRadioButton.Checked
                    ' Set SelectedOption property to Shift.
                    Me.SelectedOption = "Shift"
                    ' Set Shift property to the selected shift.
                    Dim lv As ListView.SelectedListViewItemCollection = Me.shiftListView.SelectedItems
                    ' Write ErrorProvider code here
                    If lv.Count = 0 Then
                        reportErrorProvider.SetError(shiftListView, "You must select a shift")
                        Me.Cursor = Cursors.Default
                        reportToolStripStatusLabel.Text = "Error..."
                        reportToolStripProgressBar.Value = reportToolStripProgressBar.Minimum
                    Else
                        Dim I As Integer
                        For I = 0 To lv.Count - 1
                            Shift = lv.Item(I).Text
                        Next
                        ' Store the selected options.
                        Dim Options(2) As Object
                        Options(0) = SelectedOption
                        Options(1) = Shift
                        UpdateProgressBar()
                        ' Open EmployeeResultsGrid form and provide selected options.
                        Dim newEmployeeResultsGrid As New EmployeeResultsGrid()
                        newEmployeeResultsGrid.DisplayResults(Options)
                    End If
                    ' SickLeave option selected.
                Case sickLeaveRadioButton.Checked
                    ' Set SelectedOption property to appropriate value.
                    If sickLeaveComboBox.Text = ">=" Then
                        Me.SelectedOption = "SickGreaterThan"
                    ElseIf sickLeaveComboBox.Text = "<=" Then
                        Me.SelectedOption = "SickLessThan"
                    End If
                    ' Set SickLeave property to value selected in NumericUpDown control.
                    SickLeave = sickLeaveNumericUpDown.Value
                    ' Store the selected options.
                    Dim Options(2) As Object
                    Options(0) = SelectedOption
                    Options(1) = SickLeave
                    UpdateProgressBar()
                    ' Open EmployeeResultsGrid form and provide selected options.
                    Dim newEmployeeResultsGrid As New EmployeeResultsGrid()
                    newEmployeeResultsGrid.DisplayResults(Options)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub UpdateProgressBar()
        ' Increment the progressbar value.
        reportToolStripProgressBar.Increment(reportToolStripProgressBar.Step)
        Application.DoEvents()
    End Sub

    Private Sub helpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles helpToolStripButton.Click, ShowHelpToolStripMenuItem.Click
        Try
            ' Open the ReportGeneratorHelp form.
            ReportGeneratorHelp.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        Dim I As Integer = 0
        ' Select all items in DeptCheckedListBox.
        For I = 0 To 3
            deptCheckedListBox.SetItemCheckState(I, CheckState.Checked)
        Next I

    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        Dim I As Integer = 0
        ' Clear all items in DeptCheckedListBox.
        For I = 0 To 3
            deptCheckedListBox.SetItemCheckState(I, CheckState.Unchecked)
        Next I
    End Sub



    Private Sub ResetAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetAllToolStripMenuItem.Click
        ' Reset all controls on form.
        sickLeaveRadioButton.Checked = True
        sickLeaveComboBox.Text = "<="
        sickLeaveNumericUpDown.Value = 0
        shiftRadioButton.Checked = False
        shiftListView.SelectedItems.Clear()
        deptRadioButton.Checked = False
        Dim I As Integer = 0
        For I = 0 To 3
            deptCheckedListBox.SetItemCheckState(I, CheckState.Unchecked)
        Next I
        hireDateRadioButton.Checked = False
        hireDateComboBox.Text = "<="
        hireDateMonthCalendar.SetSelectionRange(Today, Today)
    End Sub

    Private Sub ReportGenerator_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        ' Call UpdateProgressBar.
        UpdateProgressBar()
        Me.Cursor = Cursors.Default
        ' Reset controls on StatusStrip.
        reportToolStripStatusLabel.Text = "Ready..."
        reportToolStripProgressBar.Value = reportToolStripProgressBar.Minimum
    End Sub

    Private Sub SickLeaveReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SickLeaveReportToolStripMenuItem.Click
        Try
            ' Open SickLeaveReport form.
            SickLeaveReport.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

End Class