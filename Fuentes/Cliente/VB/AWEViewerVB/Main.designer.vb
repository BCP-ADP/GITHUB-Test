<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        RemoveHandler Microsoft.Win32.SystemEvents.UserPreferenceChanged, AddressOf Me.userPreferenceChanged
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.navigationFlowLayout = New System.Windows.Forms.FlowLayoutPanel
        Me.appTitleLabel = New System.Windows.Forms.Label
        Me.copyrightRichText = New System.Windows.Forms.RichTextBox
        Me.websiteLinkLabel = New System.Windows.Forms.LinkLabel
        Me.exitLabel = New System.Windows.Forms.Label
        Me.exitButton = New System.Windows.Forms.Button
        Me.currentUserLabel = New System.Windows.Forms.Label
        Me.currentUserTextBox = New System.Windows.Forms.TextBox
        Me.mainFormMenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportGeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeReviewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TestFormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LocalizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FrenchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InheritanceTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mainFormMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'navigationFlowLayout
        '
        Me.navigationFlowLayout.Location = New System.Drawing.Point(80, 100)
        Me.navigationFlowLayout.Name = "navigationFlowLayout"
        Me.navigationFlowLayout.Size = New System.Drawing.Size(122, 186)
        Me.navigationFlowLayout.TabIndex = 0
        '
        'appTitleLabel
        '
        Me.appTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.appTitleLabel.AutoSize = True
        Me.appTitleLabel.BackColor = System.Drawing.SystemColors.Control
        Me.appTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.appTitleLabel.Location = New System.Drawing.Point(80, 64)
        Me.appTitleLabel.Name = "appTitleLabel"
        Me.appTitleLabel.Size = New System.Drawing.Size(336, 24)
        Me.appTitleLabel.TabIndex = 7
        Me.appTitleLabel.Text = "Adventure Works Employee Viewer"
        '
        'copyrightRichText
        '
        Me.copyrightRichText.AccessibleDescription = "Displays copyright information for the application"
        Me.copyrightRichText.AccessibleName = "Copyright information"
        Me.copyrightRichText.BackColor = System.Drawing.SystemColors.Info
        Me.copyrightRichText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.copyrightRichText.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.copyrightRichText.Location = New System.Drawing.Point(0, 362)
        Me.copyrightRichText.Name = "copyrightRichText"
        Me.copyrightRichText.ReadOnly = True
        Me.copyrightRichText.Size = New System.Drawing.Size(542, 51)
        Me.copyrightRichText.TabIndex = 4
        Me.copyrightRichText.Text = ""
        '
        'websiteLinkLabel
        '
        Me.websiteLinkLabel.AccessibleDescription = "Provides a link to the Adventure Works Web site"
        Me.websiteLinkLabel.AccessibleName = "Adventure Works Web site"
        Me.websiteLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.websiteLinkLabel.AutoSize = True
        Me.websiteLinkLabel.Location = New System.Drawing.Point(12, 322)
        Me.websiteLinkLabel.Name = "websiteLinkLabel"
        Me.websiteLinkLabel.Size = New System.Drawing.Size(131, 13)
        Me.websiteLinkLabel.TabIndex = 1
        Me.websiteLinkLabel.TabStop = True
        Me.websiteLinkLabel.Text = "Adventure Works Web site"
        '
        'exitLabel
        '
        Me.exitLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitLabel.AutoSize = True
        Me.exitLabel.Location = New System.Drawing.Point(297, 322)
        Me.exitLabel.Name = "exitLabel"
        Me.exitLabel.Size = New System.Drawing.Size(135, 13)
        Me.exitLabel.TabIndex = 2
        Me.exitLabel.Text = "Click here to e&xit application"
        '
        'exitButton
        '
        Me.exitButton.AccessibleDescription = "Exits the applicationExits the application"
        Me.exitButton.AccessibleName = "Exit button"
        Me.exitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.Location = New System.Drawing.Point(438, 313)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(92, 30)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        '
        'currentUserLabel
        '
        Me.currentUserLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentUserLabel.AutoSize = True
        Me.currentUserLabel.Location = New System.Drawing.Point(377, 29)
        Me.currentUserLabel.Name = "currentUserLabel"
        Me.currentUserLabel.Size = New System.Drawing.Size(65, 13)
        Me.currentUserLabel.TabIndex = 5
        Me.currentUserLabel.Text = "Current User:"
        '
        'currentUserTextBox
        '
        Me.currentUserTextBox.AccessibleDescription = "Displays the name of the current user"
        Me.currentUserTextBox.AccessibleName = "Current user"
        Me.currentUserTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentUserTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.currentUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currentUserTextBox.Location = New System.Drawing.Point(448, 27)
        Me.currentUserTextBox.Name = "currentUserTextBox"
        Me.currentUserTextBox.ReadOnly = True
        Me.currentUserTextBox.Size = New System.Drawing.Size(63, 20)
        Me.currentUserTextBox.TabIndex = 6
        '
        'mainFormMenuStrip
        '
        Me.mainFormMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.TestFormsToolStripMenuItem})
        Me.mainFormMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainFormMenuStrip.Name = "mainFormMenuStrip"
        Me.mainFormMenuStrip.Size = New System.Drawing.Size(542, 24)
        Me.mainFormMenuStrip.TabIndex = 8
        Me.mainFormMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeViewerToolStripMenuItem, Me.ReportGeneratorToolStripMenuItem, Me.EmployeeReviewsToolStripMenuItem})
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Text = "&Go To"
        '
        'EmployeeViewerToolStripMenuItem
        '
        Me.EmployeeViewerToolStripMenuItem.Image = AWEViewerVB.My.Resources.Resources.camera
        Me.EmployeeViewerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EmployeeViewerToolStripMenuItem.Name = "EmployeeViewerToolStripMenuItem"
        Me.EmployeeViewerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EmployeeViewerToolStripMenuItem.Text = "&Employee Viewer"
        '
        'ReportGeneratorToolStripMenuItem
        '
        Me.ReportGeneratorToolStripMenuItem.Image = AWEViewerVB.My.Resources.Resources.VSProject_report
        Me.ReportGeneratorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReportGeneratorToolStripMenuItem.Name = "ReportGeneratorToolStripMenuItem"
        Me.ReportGeneratorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReportGeneratorToolStripMenuItem.Text = "&Report Generator"
        '
        'EmployeeReviewsToolStripMenuItem
        '
        Me.EmployeeReviewsToolStripMenuItem.Name = "EmployeeReviewsToolStripMenuItem"
        Me.EmployeeReviewsToolStripMenuItem.Text = "E&mployee Reviews"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'DepartmentsToolStripMenuItem
        '
        Me.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        Me.DepartmentsToolStripMenuItem.Text = "&Departments"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAdminToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Enabled = False
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        Me.ToolsToolStripMenuItem.Visible = False
        '
        'UserAdminToolStripMenuItem
        '
        Me.UserAdminToolStripMenuItem.Name = "UserAdminToolStripMenuItem"
        Me.UserAdminToolStripMenuItem.Text = "&User Admin"
        '
        'TestFormsToolStripMenuItem
        '
        Me.TestFormsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalizationToolStripMenuItem, Me.InheritanceTestToolStripMenuItem})
        Me.TestFormsToolStripMenuItem.Name = "TestFormsToolStripMenuItem"
        Me.TestFormsToolStripMenuItem.Text = "Te&st Forms"
        '
        'LocalizationToolStripMenuItem
        '
        Me.LocalizationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.FrenchToolStripMenuItem})
        Me.LocalizationToolStripMenuItem.Name = "LocalizationToolStripMenuItem"
        Me.LocalizationToolStripMenuItem.Text = "&Localization"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Text = "E&nglish"
        '
        'FrenchToolStripMenuItem
        '
        Me.FrenchToolStripMenuItem.Name = "FrenchToolStripMenuItem"
        Me.FrenchToolStripMenuItem.Text = "Fren&ch"
        '
        'InheritanceTestToolStripMenuItem
        '
        Me.InheritanceTestToolStripMenuItem.Name = "InheritanceTestToolStripMenuItem"
        Me.InheritanceTestToolStripMenuItem.Text = "Inheritance Test"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 413)
        Me.Controls.Add(Me.currentUserTextBox)
        Me.Controls.Add(Me.currentUserLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.exitLabel)
        Me.Controls.Add(Me.websiteLinkLabel)
        Me.Controls.Add(Me.copyrightRichText)
        Me.Controls.Add(Me.appTitleLabel)
        Me.Controls.Add(Me.navigationFlowLayout)
        Me.Controls.Add(Me.mainFormMenuStrip)
        Me.MainMenuStrip = Me.mainFormMenuStrip
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AWE Viewer Main Form"
        Me.mainFormMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents navigationFlowLayout As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents appTitleLabel As System.Windows.Forms.Label
    Friend WithEvents copyrightRichText As System.Windows.Forms.RichTextBox
    Friend WithEvents websiteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents exitLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents currentUserLabel As System.Windows.Forms.Label
    Friend WithEvents currentUserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents mainFormMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeViewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportGeneratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestFormsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalizationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrenchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeReviewsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InheritanceTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
