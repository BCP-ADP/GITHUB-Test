<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DepartmentDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartmentDetails))
        Me.DepartmentsDataSet = New AWEViewerVB.DepartmentsDataSet
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New AWEViewerVB.DepartmentsDataSetTableAdapters.DepartmentTableAdapter
        Me.DepartmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.closeToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.departmentDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DepartmentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DepartmentBindingNavigator.SuspendLayout()
        CType(Me.departmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentsDataSet
        '
        Me.DepartmentsDataSet.DataSetName = "DepartmentsDataSet"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentsDataSet
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'DepartmentBindingNavigator
        '
        Me.DepartmentBindingNavigator.AddNewItem = Me.bindingNavigatorAddNewItem
        Me.DepartmentBindingNavigator.BindingSource = Me.DepartmentBindingSource
        Me.DepartmentBindingNavigator.CountItem = Me.bindingNavigatorCountItem
        Me.DepartmentBindingNavigator.CountItemFormat = "of {0}"
        Me.DepartmentBindingNavigator.DeleteItem = Me.bindingNavigatorDeleteItem
        Me.DepartmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem, Me.bindingNavigatorSaveItem, Me.closeToolStripButton})
        Me.DepartmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DepartmentBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.DepartmentBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.DepartmentBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.DepartmentBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.DepartmentBindingNavigator.Name = "DepartmentBindingNavigator"
        Me.DepartmentBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
        Me.DepartmentBindingNavigator.Size = New System.Drawing.Size(518, 25)
        Me.DepartmentBindingNavigator.TabIndex = 0
        Me.DepartmentBindingNavigator.Text = "BindingNavigator1"
        '
        'bindingNavigatorAddNewItem
        '
        Me.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorAddNewItem.Image = CType(resources.GetObject("bindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
        Me.bindingNavigatorAddNewItem.Text = "Add new"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorDeleteItem
        '
        Me.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorDeleteItem.Image = CType(resources.GetObject("bindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
        Me.bindingNavigatorDeleteItem.Text = "Delete"
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
        'bindingNavigatorSaveItem
        '
        Me.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorSaveItem.Image = CType(resources.GetObject("bindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem"
        Me.bindingNavigatorSaveItem.Text = "Save Data"
        '
        'closeToolStripButton
        '
        Me.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.closeToolStripButton.Image = CType(resources.GetObject("closeToolStripButton.Image"), System.Drawing.Image)
        Me.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closeToolStripButton.Name = "closeToolStripButton"
        Me.closeToolStripButton.Text = "Close Form"
        '
        'departmentDataGridView
        '
        Me.departmentDataGridView.AutoGenerateColumns = False
        Me.departmentDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn1)
        Me.departmentDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn2)
        Me.departmentDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn3)
        Me.departmentDataGridView.DataSource = Me.DepartmentBindingSource
        Me.departmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.departmentDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.departmentDataGridView.Name = "departmentDataGridView"
        Me.departmentDataGridView.Size = New System.Drawing.Size(518, 428)
        Me.departmentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DepartmentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Dept ID"
        Me.DataGridViewTextBoxColumn1.Name = "DepartmentID"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "Name"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GroupName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GroupName"
        Me.DataGridViewTextBoxColumn3.Name = "GroupName"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DepartmentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 453)
        Me.Controls.Add(Me.departmentDataGridView)
        Me.Controls.Add(Me.DepartmentBindingNavigator)
        Me.Name = "DepartmentDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department Details"
        CType(Me.DepartmentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DepartmentBindingNavigator.ResumeLayout(False)
        Me.DepartmentBindingNavigator.PerformLayout()
        CType(Me.departmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DepartmentsDataSet As AWEViewerVB.DepartmentsDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As AWEViewerVB.DepartmentsDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents DepartmentBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents departmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents closeToolStripButton As System.Windows.Forms.ToolStripButton
End Class
