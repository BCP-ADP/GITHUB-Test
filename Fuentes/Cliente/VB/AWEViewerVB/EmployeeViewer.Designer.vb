<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class EmployeeViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeViewer))
        Me.horizontalSplit = New System.Windows.Forms.SplitContainer
        Me.verticalSplit = New System.Windows.Forms.SplitContainer
        Me.employeesTreeView = New System.Windows.Forms.TreeView
        Me.viewerImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.viewerToolStrip = New System.Windows.Forms.ToolStrip
        Me.loadDataToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.clearDataToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.employeePictureBox = New System.Windows.Forms.PictureBox
        Me.viewerTableLayout = New System.Windows.Forms.TableLayoutPanel
        Me.phoneLabel = New System.Windows.Forms.Label
        Me.phoneTextBox = New System.Windows.Forms.TextBox
        Me.uspEmployeeContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeContactsDataSet = New AWEViewerVB.EmployeeContactsDataSet
        Me.emailLabel = New System.Windows.Forms.Label
        Me.emailTextBox = New System.Windows.Forms.TextBox
        Me.viewAllPanel = New System.Windows.Forms.Panel
        Me.goButton = New System.Windows.Forms.Button
        Me.detailsRadioButton = New System.Windows.Forms.RadioButton
        Me.employeeViewerMenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TreeViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UspEmployeeContactsTableAdapter = New AWEViewerVB.EmployeeContactsDataSetTableAdapters.uspEmployeeContactsTableAdapter
        Me.horizontalSplit.Panel1.SuspendLayout()
        Me.horizontalSplit.Panel2.SuspendLayout()
        Me.horizontalSplit.SuspendLayout()
        Me.verticalSplit.Panel1.SuspendLayout()
        Me.verticalSplit.Panel2.SuspendLayout()
        Me.verticalSplit.SuspendLayout()
        Me.viewerToolStrip.SuspendLayout()
        CType(Me.employeePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.viewerTableLayout.SuspendLayout()
        CType(Me.uspEmployeeContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.viewAllPanel.SuspendLayout()
        Me.employeeViewerMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'horizontalSplit
        '
        Me.horizontalSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.horizontalSplit.Location = New System.Drawing.Point(0, 24)
        Me.horizontalSplit.Name = "horizontalSplit"
        Me.horizontalSplit.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'horizontalSplit.Panel1
        '
        Me.horizontalSplit.Panel1.Controls.Add(Me.verticalSplit)
        '
        'horizontalSplit.Panel2
        '
        Me.horizontalSplit.Panel2.Controls.Add(Me.viewerTableLayout)
        Me.horizontalSplit.Panel2.Controls.Add(Me.viewAllPanel)
        Me.horizontalSplit.Size = New System.Drawing.Size(542, 434)
        Me.horizontalSplit.SplitterDistance = 226
        Me.horizontalSplit.TabIndex = 0
        Me.horizontalSplit.Text = "SplitContainer1"
        '
        'verticalSplit
        '
        Me.verticalSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.verticalSplit.Location = New System.Drawing.Point(0, 0)
        Me.verticalSplit.Name = "verticalSplit"
        '
        'verticalSplit.Panel1
        '
        Me.verticalSplit.Panel1.Controls.Add(Me.employeesTreeView)
        Me.verticalSplit.Panel1.Controls.Add(Me.viewerToolStrip)
        '
        'verticalSplit.Panel2
        '
        Me.verticalSplit.Panel2.Controls.Add(Me.employeePictureBox)
        Me.verticalSplit.Size = New System.Drawing.Size(542, 226)
        Me.verticalSplit.SplitterDistance = 258
        Me.verticalSplit.TabIndex = 0
        Me.verticalSplit.Text = "SplitContainer1"
        '
        'employeesTreeView
        '
        Me.employeesTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.employeesTreeView.ImageIndex = 0
        Me.employeesTreeView.ImageList = Me.viewerImageList
        Me.employeesTreeView.Location = New System.Drawing.Point(0, 25)
        Me.employeesTreeView.Name = "employeesTreeView"
        Me.employeesTreeView.SelectedImageIndex = 0
        Me.employeesTreeView.Size = New System.Drawing.Size(258, 201)
        Me.employeesTreeView.TabIndex = 0
        '
        'viewerImageList
        '
        Me.viewerImageList.ImageStream = CType(resources.GetObject("viewerImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.viewerImageList.Images.SetKeyName(0, "OrgChart.bmp")
        Me.viewerImageList.Images.SetKeyName(1, "user.ico")
        Me.viewerImageList.Images.SetKeyName(2, "Checkbox.bmp")
        '
        'viewerToolStrip
        '
        Me.viewerToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.loadDataToolStripButton, Me.clearDataToolStripButton})
        Me.viewerToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.viewerToolStrip.Name = "viewerToolStrip"
        Me.viewerToolStrip.Size = New System.Drawing.Size(258, 25)
        Me.viewerToolStrip.TabIndex = 1
        Me.viewerToolStrip.Text = "ToolStrip1"
        '
        'loadDataToolStripButton
        '
        Me.loadDataToolStripButton.Image = AWEViewerVB.My.Resources.Resources.database
        Me.loadDataToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.loadDataToolStripButton.Name = "loadDataToolStripButton"
        Me.loadDataToolStripButton.Text = "Load Data"
        '
        'clearDataToolStripButton
        '
        Me.clearDataToolStripButton.Image = AWEViewerVB.My.Resources.Resources.RolledBack
        Me.clearDataToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.clearDataToolStripButton.Name = "clearDataToolStripButton"
        Me.clearDataToolStripButton.Text = "Clear Data"
        '
        'employeePictureBox
        '
        Me.employeePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.employeePictureBox.Location = New System.Drawing.Point(0, 0)
        Me.employeePictureBox.Name = "employeePictureBox"
        Me.employeePictureBox.Size = New System.Drawing.Size(280, 226)
        Me.employeePictureBox.TabIndex = 0
        Me.employeePictureBox.TabStop = False
        '
        'viewerTableLayout
        '
        Me.viewerTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.viewerTableLayout.ColumnCount = 2
        Me.viewerTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.viewerTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.viewerTableLayout.Controls.Add(Me.phoneLabel, 0, 0)
        Me.viewerTableLayout.Controls.Add(Me.phoneTextBox, 1, 0)
        Me.viewerTableLayout.Controls.Add(Me.emailLabel, 0, 1)
        Me.viewerTableLayout.Controls.Add(Me.emailTextBox, 1, 1)
        Me.viewerTableLayout.Location = New System.Drawing.Point(250, 45)
        Me.viewerTableLayout.Name = "viewerTableLayout"
        Me.viewerTableLayout.RowCount = 2
        Me.viewerTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.viewerTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.viewerTableLayout.Size = New System.Drawing.Size(277, 110)
        Me.viewerTableLayout.TabIndex = 1
        '
        'phoneLabel
        '
        Me.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Location = New System.Drawing.Point(4, 21)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(34, 13)
        Me.phoneLabel.TabIndex = 0
        Me.phoneLabel.Text = "Phone"
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.uspEmployeeContactsBindingSource, "Phone", True))
        Me.phoneTextBox.Location = New System.Drawing.Point(79, 17)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(160, 20)
        Me.phoneTextBox.TabIndex = 1
        '
        'uspEmployeeContactsBindingSource
        '
        Me.uspEmployeeContactsBindingSource.DataMember = "uspEmployeeContacts"
        Me.uspEmployeeContactsBindingSource.DataSource = Me.EmployeeContactsDataSet
        '
        'EmployeeContactsDataSet
        '
        Me.EmployeeContactsDataSet.DataSetName = "EmployeeContactsDataSet"
        '
        'emailLabel
        '
        Me.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Location = New System.Drawing.Point(5, 75)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(31, 13)
        Me.emailLabel.TabIndex = 2
        Me.emailLabel.Text = "E-mail"
        '
        'emailTextBox
        '
        Me.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.uspEmployeeContactsBindingSource, "EmailAddress", True))
        Me.emailTextBox.Location = New System.Drawing.Point(79, 72)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(160, 20)
        Me.emailTextBox.TabIndex = 3
        '
        'viewAllPanel
        '
        Me.viewAllPanel.Controls.Add(Me.goButton)
        Me.viewAllPanel.Controls.Add(Me.detailsRadioButton)
        Me.viewAllPanel.Location = New System.Drawing.Point(40, 45)
        Me.viewAllPanel.Name = "viewAllPanel"
        Me.viewAllPanel.Size = New System.Drawing.Size(160, 110)
        Me.viewAllPanel.TabIndex = 0
        '
        'goButton
        '
        Me.goButton.Location = New System.Drawing.Point(30, 70)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(90, 20)
        Me.goButton.TabIndex = 1
        Me.goButton.Text = "Go"
        '
        'detailsRadioButton
        '
        Me.detailsRadioButton.AutoSize = True
        Me.detailsRadioButton.Location = New System.Drawing.Point(30, 30)
        Me.detailsRadioButton.Name = "detailsRadioButton"
        Me.detailsRadioButton.Size = New System.Drawing.Size(92, 17)
        Me.detailsRadioButton.TabIndex = 0
        Me.detailsRadioButton.Text = "View all Details"
        '
        'employeeViewerMenuStrip
        '
        Me.employeeViewerMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TreeViewToolStripMenuItem1})
        Me.employeeViewerMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.employeeViewerMenuStrip.Name = "employeeViewerMenuStrip"
        Me.employeeViewerMenuStrip.Size = New System.Drawing.Size(542, 24)
        Me.employeeViewerMenuStrip.TabIndex = 1
        Me.employeeViewerMenuStrip.Text = "MenuStrip1"
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
        'TreeViewToolStripMenuItem1
        '
        Me.TreeViewToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDataToolStripMenuItem, Me.ClearDataToolStripMenuItem})
        Me.TreeViewToolStripMenuItem1.Name = "TreeViewToolStripMenuItem1"
        Me.TreeViewToolStripMenuItem1.Text = "&Tree View"
        '
        'LoadDataToolStripMenuItem
        '
        Me.LoadDataToolStripMenuItem.Image = AWEViewerVB.My.Resources.Resources.database
        Me.LoadDataToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadDataToolStripMenuItem.Name = "LoadDataToolStripMenuItem"
        Me.LoadDataToolStripMenuItem.Text = "&Load Data"
        '
        'ClearDataToolStripMenuItem
        '
        Me.ClearDataToolStripMenuItem.Image = AWEViewerVB.My.Resources.Resources.RolledBack
        Me.ClearDataToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearDataToolStripMenuItem.Name = "ClearDataToolStripMenuItem"
        Me.ClearDataToolStripMenuItem.Text = "&Clear Data"
        '
        'UspEmployeeContactsTableAdapter
        '
        Me.UspEmployeeContactsTableAdapter.ClearBeforeFill = True
        '
        'EmployeeViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 458)
        Me.Controls.Add(Me.horizontalSplit)
        Me.Controls.Add(Me.employeeViewerMenuStrip)
        Me.MainMenuStrip = Me.employeeViewerMenuStrip
        Me.Name = "EmployeeViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Viewer"
        Me.horizontalSplit.Panel1.ResumeLayout(False)
        Me.horizontalSplit.Panel2.ResumeLayout(False)
        Me.horizontalSplit.ResumeLayout(False)
        Me.verticalSplit.Panel1.ResumeLayout(False)
        Me.verticalSplit.Panel1.PerformLayout()
        Me.verticalSplit.Panel2.ResumeLayout(False)
        Me.verticalSplit.ResumeLayout(False)
        Me.viewerToolStrip.ResumeLayout(False)
        CType(Me.employeePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.viewerTableLayout.ResumeLayout(False)
        Me.viewerTableLayout.PerformLayout()
        CType(Me.uspEmployeeContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.viewAllPanel.ResumeLayout(False)
        Me.viewAllPanel.PerformLayout()
        Me.employeeViewerMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents horizontalSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents verticalSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents employeesTreeView As System.Windows.Forms.TreeView
    Friend WithEvents viewerToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents viewAllPanel As System.Windows.Forms.Panel
    Friend WithEvents detailsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents goButton As System.Windows.Forms.Button
    Friend WithEvents viewerTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents phoneLabel As System.Windows.Forms.Label
    Friend WithEvents phoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents emailLabel As System.Windows.Forms.Label
    Friend WithEvents emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents viewerImageList As System.Windows.Forms.ImageList
    Friend WithEvents employeeViewerMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeViewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents loadDataToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents clearDataToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents employeePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LoadDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uspEmployeeContactsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeContactsDataSet As AWEViewerVB.EmployeeContactsDataSet
    Friend WithEvents UspEmployeeContactsTableAdapter As AWEViewerVB.EmployeeContactsDataSetTableAdapters.uspEmployeeContactsTableAdapter
End Class
