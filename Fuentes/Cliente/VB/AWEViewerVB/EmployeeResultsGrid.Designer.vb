<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class EmployeeResultsGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeResultsGrid))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.VEmployeeResultsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.VEmployeeResultsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeResultsDataSet = New AWEViewerVB.EmployeeResultsDataSet
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.closeToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.VEmployeeResultsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VEmployeeResultsTableAdapter = New AWEViewerVB.EmployeeResultsDataSetTableAdapters.vEmployeeResultsTableAdapter
        CType(Me.VEmployeeResultsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VEmployeeResultsBindingNavigator.SuspendLayout()
        CType(Me.VEmployeeResultsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeResultsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VEmployeeResultsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VEmployeeResultsBindingNavigator
        '
        Me.VEmployeeResultsBindingNavigator.AddNewItem = Nothing
        Me.VEmployeeResultsBindingNavigator.BindingSource = Me.VEmployeeResultsBindingSource
        Me.VEmployeeResultsBindingNavigator.CountItem = Me.bindingNavigatorCountItem
        Me.VEmployeeResultsBindingNavigator.CountItemFormat = "of {0}"
        Me.VEmployeeResultsBindingNavigator.DeleteItem = Nothing
        Me.VEmployeeResultsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.closeToolStripButton})
        Me.VEmployeeResultsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VEmployeeResultsBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.VEmployeeResultsBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.VEmployeeResultsBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.VEmployeeResultsBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.VEmployeeResultsBindingNavigator.Name = "VEmployeeResultsBindingNavigator"
        Me.VEmployeeResultsBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
        Me.VEmployeeResultsBindingNavigator.Size = New System.Drawing.Size(612, 25)
        Me.VEmployeeResultsBindingNavigator.TabIndex = 0
        Me.VEmployeeResultsBindingNavigator.Text = "BindingNavigator1"
        '
        'VEmployeeResultsBindingSource
        '
        Me.VEmployeeResultsBindingSource.DataMember = "vEmployeeResults"
        Me.VEmployeeResultsBindingSource.DataSource = Me.EmployeeResultsDataSet
        '
        'EmployeeResultsDataSet
        '
        Me.EmployeeResultsDataSet.DataSetName = "EmployeeResultsDataSet"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorMoveFirstItem
        '
        Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'bindingNavigatorMovePreviousItem
        '
        Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'bindingNavigatorSeparator
        '
        Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.bindingNavigatorPositionItem.Text = "0"
        Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'bindingNavigatorSeparator1
        '
        Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
        '
        'bindingNavigatorMoveNextItem
        '
        Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem.Text = "Move next"
        '
        'bindingNavigatorMoveLastItem
        '
        Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem.Text = "Move last"
        '
        'bindingNavigatorSeparator2
        '
        Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
        '
        'closeToolStripButton
        '
        Me.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.closeToolStripButton.Image = CType(resources.GetObject("closeToolStripButton.Image"), System.Drawing.Image)
        Me.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closeToolStripButton.Name = "closeToolStripButton"
        Me.closeToolStripButton.Text = "Close Form"
        '
        'VEmployeeResultsDataGridView
        '
        Me.VEmployeeResultsDataGridView.AllowUserToAddRows = False
        Me.VEmployeeResultsDataGridView.AllowUserToDeleteRows = False
        Me.VEmployeeResultsDataGridView.AutoGenerateColumns = False
        Me.VEmployeeResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.VEmployeeResultsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.VEmployeeResultsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn1)
        Me.VEmployeeResultsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn2)
        Me.VEmployeeResultsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn3)
        Me.VEmployeeResultsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn4)
        Me.VEmployeeResultsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn5)
        Me.VEmployeeResultsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn6)
        Me.VEmployeeResultsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn7)
        Me.VEmployeeResultsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn8)
        Me.VEmployeeResultsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn9)
        Me.VEmployeeResultsDataGridView.DataSource = Me.VEmployeeResultsBindingSource
        Me.VEmployeeResultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VEmployeeResultsDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.VEmployeeResultsDataGridView.Name = "VEmployeeResultsDataGridView"
        Me.VEmployeeResultsDataGridView.ReadOnly = True
        DataGridViewCellStyle1.FormatProvider = New System.Globalization.CultureInfo("en-US")
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue
        Me.VEmployeeResultsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.VEmployeeResultsDataGridView.Size = New System.Drawing.Size(612, 408)
        Me.VEmployeeResultsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn1.Name = "FirstName"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 77
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn2.Name = "LastName"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 78
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn3.Name = "Department"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 82
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Job Title"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Job Title"
        Me.DataGridViewTextBoxColumn4.Name = "Job Title"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 67
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Shift"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Shift"
        Me.DataGridViewTextBoxColumn5.Name = "Shift"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 48
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "HireDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Hire Date"
        Me.DataGridViewTextBoxColumn6.Name = "HireDate"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 72
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SickLeaveHours"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sick Leave Hours"
        Me.DataGridViewTextBoxColumn7.Name = "SickLeaveHours"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 112
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "VacationHours"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Vacation Hours"
        Me.DataGridViewTextBoxColumn8.Name = "VacationHours"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "EmployeeID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn9.Name = "EmployeeID"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 87
        '
        'VEmployeeResultsTableAdapter
        '
        Me.VEmployeeResultsTableAdapter.ClearBeforeFill = True
        '
        'EmployeeResultsGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 433)
        Me.Controls.Add(Me.VEmployeeResultsDataGridView)
        Me.Controls.Add(Me.VEmployeeResultsBindingNavigator)
        Me.Name = "EmployeeResultsGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Results Grid"
        CType(Me.VEmployeeResultsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VEmployeeResultsBindingNavigator.ResumeLayout(False)
        Me.VEmployeeResultsBindingNavigator.PerformLayout()
        CType(Me.VEmployeeResultsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeResultsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VEmployeeResultsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VEmployeeResultsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VEmployeeResultsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VEmployeeResultsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeResultsDataSet As AWEViewerVB.EmployeeResultsDataSet
    Friend WithEvents bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VEmployeeResultsTableAdapter As AWEViewerVB.EmployeeResultsDataSetTableAdapters.vEmployeeResultsTableAdapter
    Friend WithEvents closeToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
