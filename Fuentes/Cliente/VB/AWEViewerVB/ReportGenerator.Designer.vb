<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReportGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Day", "7:00am - 3:00pm"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Evening", "3:00pm - 11:00pm"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Night", "11:00pm - 7:00am"}, -1)
        Me.reportToolStrip = New System.Windows.Forms.ToolStrip
        Me.viewResultsToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.reportLabel = New System.Windows.Forms.Label
        Me.reportTableLayout = New System.Windows.Forms.TableLayoutPanel
        Me.tableContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewResultsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.optionsLabel = New System.Windows.Forms.Label
        Me.operatorsLabel = New System.Windows.Forms.Label
        Me.criteriaLabel = New System.Windows.Forms.Label
        Me.sickLeaveRadioButton = New System.Windows.Forms.RadioButton
        Me.sickLeaveComboBox = New System.Windows.Forms.ComboBox
        Me.sickLeaveNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.shiftRadioButton = New System.Windows.Forms.RadioButton
        Me.shiftListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.deptRadioButton = New System.Windows.Forms.RadioButton
        Me.deptCheckedListBox = New System.Windows.Forms.CheckedListBox
        Me.departmentContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.hireDateRadioButton = New System.Windows.Forms.RadioButton
        Me.hireDateComboBox = New System.Windows.Forms.ComboBox
        Me.hireDateMonthCalendar = New System.Windows.Forms.MonthCalendar
        Me.reportGeneratorMenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SickLeaveReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.reportStatusStrip = New System.Windows.Forms.StatusStrip
        Me.reportToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.reportToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.reportGeneratorToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.reportErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.reportToolStrip.SuspendLayout()
        Me.reportTableLayout.SuspendLayout()
        Me.tableContextMenuStrip.SuspendLayout()
        CType(Me.sickLeaveNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.departmentContextMenuStrip.SuspendLayout()
        Me.reportGeneratorMenuStrip.SuspendLayout()
        Me.reportStatusStrip.SuspendLayout()
        CType(Me.reportErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportToolStrip
        '
        Me.reportToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewResultsToolStripButton, Me.helpToolStripButton})
        Me.reportToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.reportToolStrip.Name = "reportToolStrip"
        Me.reportToolStrip.Size = New System.Drawing.Size(472, 25)
        Me.reportToolStrip.TabIndex = 0
        Me.reportToolStrip.Text = "ToolStrip1"
        '
        'viewResultsToolStripButton
        '
        Me.viewResultsToolStripButton.Image = AWEViewerVB.My.Resources.Resources.GoLtr
        Me.viewResultsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.viewResultsToolStripButton.Name = "viewResultsToolStripButton"
        Me.viewResultsToolStripButton.Text = "View Results"
        '
        'helpToolStripButton
        '
        Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.helpToolStripButton.Image = AWEViewerVB.My.Resources.Resources.Help
        Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.helpToolStripButton.Name = "helpToolStripButton"
        Me.helpToolStripButton.Text = "Help"
        '
        'reportLabel
        '
        Me.reportLabel.AutoSize = True
        Me.reportLabel.Location = New System.Drawing.Point(21, 58)
        Me.reportLabel.Name = "reportLabel"
        Me.reportLabel.Size = New System.Drawing.Size(298, 13)
        Me.reportLabel.TabIndex = 1
        Me.reportLabel.Text = "Select one option, fill in the criteria and then click View Results"
        '
        'reportTableLayout
        '
        Me.reportTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.reportTableLayout.ColumnCount = 3
        Me.reportTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.reportTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.reportTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.reportTableLayout.ContextMenuStrip = Me.tableContextMenuStrip
        Me.reportTableLayout.Controls.Add(Me.optionsLabel, 0, 0)
        Me.reportTableLayout.Controls.Add(Me.operatorsLabel, 1, 0)
        Me.reportTableLayout.Controls.Add(Me.criteriaLabel, 2, 0)
        Me.reportTableLayout.Controls.Add(Me.sickLeaveRadioButton, 0, 1)
        Me.reportTableLayout.Controls.Add(Me.sickLeaveComboBox, 1, 1)
        Me.reportTableLayout.Controls.Add(Me.sickLeaveNumericUpDown, 2, 1)
        Me.reportTableLayout.Controls.Add(Me.shiftRadioButton, 0, 2)
        Me.reportTableLayout.Controls.Add(Me.shiftListView, 2, 2)
        Me.reportTableLayout.Controls.Add(Me.deptRadioButton, 0, 3)
        Me.reportTableLayout.Controls.Add(Me.deptCheckedListBox, 2, 3)
        Me.reportTableLayout.Controls.Add(Me.hireDateRadioButton, 0, 4)
        Me.reportTableLayout.Controls.Add(Me.hireDateComboBox, 1, 4)
        Me.reportTableLayout.Controls.Add(Me.hireDateMonthCalendar, 2, 4)
        Me.reportTableLayout.Location = New System.Drawing.Point(22, 74)
        Me.reportTableLayout.Name = "reportTableLayout"
        Me.reportTableLayout.RowCount = 5
        Me.reportTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.reportTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.reportTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.reportTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.reportTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.reportTableLayout.Size = New System.Drawing.Size(430, 390)
        Me.reportTableLayout.TabIndex = 2
        '
        'tableContextMenuStrip
        '
        Me.tableContextMenuStrip.Enabled = True
        Me.tableContextMenuStrip.GripMargin = New System.Windows.Forms.Padding(2)
        Me.tableContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewResultsToolStripMenuItem1, Me.ResetAllToolStripMenuItem})
        Me.tableContextMenuStrip.Location = New System.Drawing.Point(25, 108)
        Me.tableContextMenuStrip.Name = "TableContextMenuStrip"
        Me.tableContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tableContextMenuStrip.Size = New System.Drawing.Size(131, 48)
        '
        'ViewResultsToolStripMenuItem1
        '
        Me.ViewResultsToolStripMenuItem1.Image = AWEViewerVB.My.Resources.Resources.GoLtr
        Me.ViewResultsToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewResultsToolStripMenuItem1.Name = "ViewResultsToolStripMenuItem1"
        Me.ViewResultsToolStripMenuItem1.Text = "&View Results"
        '
        'ResetAllToolStripMenuItem
        '
        Me.ResetAllToolStripMenuItem.Image = AWEViewerVB.My.Resources.Resources.Restart
        Me.ResetAllToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ResetAllToolStripMenuItem.Name = "ResetAllToolStripMenuItem"
        Me.ResetAllToolStripMenuItem.Text = "&Reset All"
        '
        'optionsLabel
        '
        Me.optionsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.optionsLabel.AutoSize = True
        Me.optionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionsLabel.Location = New System.Drawing.Point(5, 2)
        Me.optionsLabel.Name = "optionsLabel"
        Me.optionsLabel.Size = New System.Drawing.Size(46, 13)
        Me.optionsLabel.TabIndex = 0
        Me.optionsLabel.Text = "Options"
        '
        'operatorsLabel
        '
        Me.operatorsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.operatorsLabel.AutoSize = True
        Me.operatorsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operatorsLabel.Location = New System.Drawing.Point(138, 2)
        Me.operatorsLabel.Name = "operatorsLabel"
        Me.operatorsLabel.Size = New System.Drawing.Size(58, 13)
        Me.operatorsLabel.TabIndex = 1
        Me.operatorsLabel.Text = "Operators"
        '
        'criteriaLabel
        '
        Me.criteriaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.criteriaLabel.AutoSize = True
        Me.criteriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.criteriaLabel.Location = New System.Drawing.Point(213, 2)
        Me.criteriaLabel.Name = "criteriaLabel"
        Me.criteriaLabel.Size = New System.Drawing.Size(43, 13)
        Me.criteriaLabel.TabIndex = 2
        Me.criteriaLabel.Text = "Criteria"
        '
        'sickLeaveRadioButton
        '
        Me.sickLeaveRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.sickLeaveRadioButton.AutoSize = True
        Me.sickLeaveRadioButton.Location = New System.Drawing.Point(5, 22)
        Me.sickLeaveRadioButton.Name = "sickLeaveRadioButton"
        Me.sickLeaveRadioButton.Size = New System.Drawing.Size(125, 17)
        Me.sickLeaveRadioButton.TabIndex = 3
        Me.sickLeaveRadioButton.Text = "By Sick Leave (hours)"
        '
        'sickLeaveComboBox
        '
        Me.sickLeaveComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.sickLeaveComboBox.FormattingEnabled = True
        Me.sickLeaveComboBox.Items.AddRange(New Object() {"<=", ">="})
        Me.sickLeaveComboBox.Location = New System.Drawing.Point(138, 20)
        Me.sickLeaveComboBox.Name = "sickLeaveComboBox"
        Me.sickLeaveComboBox.Size = New System.Drawing.Size(67, 21)
        Me.sickLeaveComboBox.TabIndex = 4
        Me.sickLeaveComboBox.Text = "<="
        '
        'sickLeaveNumericUpDown
        '
        Me.sickLeaveNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.sickLeaveNumericUpDown.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.sickLeaveNumericUpDown.Location = New System.Drawing.Point(213, 20)
        Me.sickLeaveNumericUpDown.Name = "sickLeaveNumericUpDown"
        Me.sickLeaveNumericUpDown.Size = New System.Drawing.Size(41, 20)
        Me.sickLeaveNumericUpDown.TabIndex = 5
        Me.reportGeneratorToolTip.SetToolTip(Me.sickLeaveNumericUpDown, "Select the number of hours")
        '
        'shiftRadioButton
        '
        Me.shiftRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.shiftRadioButton.AutoSize = True
        Me.shiftRadioButton.Location = New System.Drawing.Point(5, 72)
        Me.shiftRadioButton.Name = "shiftRadioButton"
        Me.shiftRadioButton.Size = New System.Drawing.Size(57, 17)
        Me.shiftRadioButton.TabIndex = 6
        Me.shiftRadioButton.Text = "By Shift"
        '
        'shiftListView
        '
        Me.shiftListView.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.shiftListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.shiftListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6})
        Me.shiftListView.Location = New System.Drawing.Point(213, 49)
        Me.shiftListView.Name = "shiftListView"
        Me.shiftListView.Size = New System.Drawing.Size(166, 63)
        Me.shiftListView.TabIndex = 7
        Me.reportGeneratorToolTip.SetToolTip(Me.shiftListView, "Select a shift")
        Me.shiftListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Shift"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Times"
        Me.ColumnHeader2.Width = 100
        '
        'deptRadioButton
        '
        Me.deptRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deptRadioButton.AutoSize = True
        Me.deptRadioButton.Location = New System.Drawing.Point(5, 147)
        Me.deptRadioButton.Name = "deptRadioButton"
        Me.deptRadioButton.Size = New System.Drawing.Size(91, 17)
        Me.deptRadioButton.TabIndex = 8
        Me.deptRadioButton.Text = "By Department"
        '
        'deptCheckedListBox
        '
        Me.deptCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deptCheckedListBox.ContextMenuStrip = Me.departmentContextMenuStrip
        Me.deptCheckedListBox.FormattingEnabled = True
        Me.deptCheckedListBox.Items.AddRange(New Object() {"Engineering", "Marketing", "Production", "Tool Design"})
        Me.deptCheckedListBox.Location = New System.Drawing.Point(213, 120)
        Me.deptCheckedListBox.Name = "deptCheckedListBox"
        Me.deptCheckedListBox.Size = New System.Drawing.Size(105, 72)
        Me.deptCheckedListBox.TabIndex = 9
        Me.reportGeneratorToolTip.SetToolTip(Me.deptCheckedListBox, "Select one or more departments")
        '
        'departmentContextMenuStrip
        '
        Me.departmentContextMenuStrip.Enabled = True
        Me.departmentContextMenuStrip.GripMargin = New System.Windows.Forms.Padding(2)
        Me.departmentContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.departmentContextMenuStrip.Location = New System.Drawing.Point(25, 108)
        Me.departmentContextMenuStrip.Name = "DepartmentContextMenuStrip"
        Me.departmentContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.departmentContextMenuStrip.Size = New System.Drawing.Size(114, 48)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Text = "&Select All"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Text = "&Clear All"
        '
        'hireDateRadioButton
        '
        Me.hireDateRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.hireDateRadioButton.AutoSize = True
        Me.hireDateRadioButton.Location = New System.Drawing.Point(5, 284)
        Me.hireDateRadioButton.Name = "hireDateRadioButton"
        Me.hireDateRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.hireDateRadioButton.TabIndex = 10
        Me.hireDateRadioButton.Text = "By Hire Date"
        '
        'hireDateComboBox
        '
        Me.hireDateComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.hireDateComboBox.FormattingEnabled = True
        Me.hireDateComboBox.Items.AddRange(New Object() {"<=", ">="})
        Me.hireDateComboBox.Location = New System.Drawing.Point(138, 282)
        Me.hireDateComboBox.Name = "hireDateComboBox"
        Me.hireDateComboBox.Size = New System.Drawing.Size(67, 21)
        Me.hireDateComboBox.TabIndex = 11
        Me.hireDateComboBox.Text = "<="
        '
        'hireDateMonthCalendar
        '
        Me.hireDateMonthCalendar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.hireDateMonthCalendar.Location = New System.Drawing.Point(219, 215)
        Me.hireDateMonthCalendar.Name = "hireDateMonthCalendar"
        Me.hireDateMonthCalendar.Size = New System.Drawing.Size(178, 155)
        Me.hireDateMonthCalendar.TabIndex = 12
        Me.reportGeneratorToolTip.SetToolTip(Me.hireDateMonthCalendar, "Select a hire date")
        '
        'reportGeneratorMenuStrip
        '
        Me.reportGeneratorMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.reportGeneratorMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.reportGeneratorMenuStrip.Name = "reportGeneratorMenuStrip"
        Me.reportGeneratorMenuStrip.Size = New System.Drawing.Size(472, 24)
        Me.reportGeneratorMenuStrip.TabIndex = 3
        Me.reportGeneratorMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewResultsToolStripMenuItem, Me.ToolStripSeparator1, Me.SickLeaveReportToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ViewResultsToolStripMenuItem
        '
        Me.ViewResultsToolStripMenuItem.Image = AWEViewerVB.My.Resources.Resources.GoLtr
        Me.ViewResultsToolStripMenuItem.Name = "ViewResultsToolStripMenuItem"
        Me.ViewResultsToolStripMenuItem.Text = "View &Results"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        '
        'SickLeaveReportToolStripMenuItem
        '
        Me.SickLeaveReportToolStripMenuItem.Name = "SickLeaveReportToolStripMenuItem"
        Me.SickLeaveReportToolStripMenuItem.Text = "&Sick Leave Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowHelpToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ShowHelpToolStripMenuItem
        '
        Me.ShowHelpToolStripMenuItem.Image = AWEViewerVB.My.Resources.Resources.Help
        Me.ShowHelpToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowHelpToolStripMenuItem.Name = "ShowHelpToolStripMenuItem"
        Me.ShowHelpToolStripMenuItem.Text = "&Show Help"
        '
        'reportStatusStrip
        '
        Me.reportStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.reportToolStripStatusLabel, Me.reportToolStripProgressBar})
        Me.reportStatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.reportStatusStrip.Location = New System.Drawing.Point(0, 478)
        Me.reportStatusStrip.Name = "reportStatusStrip"
        Me.reportStatusStrip.Size = New System.Drawing.Size(472, 23)
        Me.reportStatusStrip.TabIndex = 4
        Me.reportStatusStrip.Text = "StatusStrip1"
        '
        'reportToolStripStatusLabel
        '
        Me.reportToolStripStatusLabel.Name = "reportToolStripStatusLabel"
        Me.reportToolStripStatusLabel.Text = "Ready..."
        '
        'reportToolStripProgressBar
        '
        Me.reportToolStripProgressBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
        Me.reportToolStripProgressBar.Name = "reportToolStripProgressBar"
        Me.reportToolStripProgressBar.Size = New System.Drawing.Size(150, 16)
        Me.reportToolStripProgressBar.Step = 25
        Me.reportToolStripProgressBar.Text = "ToolStripProgressBar1"
        '
        'reportErrorProvider
        '
        Me.reportErrorProvider.ContainerControl = Me
        '
        'ReportGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 501)
        Me.Controls.Add(Me.reportStatusStrip)
        Me.Controls.Add(Me.reportTableLayout)
        Me.Controls.Add(Me.reportLabel)
        Me.Controls.Add(Me.reportToolStrip)
        Me.Controls.Add(Me.reportGeneratorMenuStrip)
        Me.MainMenuStrip = Me.reportGeneratorMenuStrip
        Me.Name = "ReportGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees Report Generator"
        Me.reportToolStrip.ResumeLayout(False)
        Me.reportTableLayout.ResumeLayout(False)
        Me.reportTableLayout.PerformLayout()
        Me.tableContextMenuStrip.ResumeLayout(False)
        CType(Me.sickLeaveNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.departmentContextMenuStrip.ResumeLayout(False)
        Me.reportGeneratorMenuStrip.ResumeLayout(False)
        Me.reportStatusStrip.ResumeLayout(False)
        CType(Me.reportErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reportToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents reportLabel As System.Windows.Forms.Label
    Friend WithEvents reportTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents optionsLabel As System.Windows.Forms.Label
    Friend WithEvents operatorsLabel As System.Windows.Forms.Label
    Friend WithEvents criteriaLabel As System.Windows.Forms.Label
    Friend WithEvents sickLeaveRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents sickLeaveComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents sickLeaveNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents shiftRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents shiftListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents deptRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents deptCheckedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents hireDateRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hireDateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents hireDateMonthCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents reportGeneratorMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents departmentContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tableContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents viewResultsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents helpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ViewResultsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents reportStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents reportToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents reportToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents reportGeneratorToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents reportErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SickLeaveReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
