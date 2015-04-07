<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class EmployeeReviews
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeReviews))
        Me.reviewsMenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.reviewsToolStrip = New System.Windows.Forms.ToolStrip
        Me.openToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.fontToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.colorToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.previewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.filesRichTextBox = New System.Windows.Forms.RichTextBox
        Me.reviewsOpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.reviewsSaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.reviewsFontDialog = New System.Windows.Forms.FontDialog
        Me.reviewsColorDialog = New System.Windows.Forms.ColorDialog
        Me.reviewsPrintDocument = New System.Drawing.Printing.PrintDocument
        Me.reviewsPrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog
        Me.reviewsPageSetupDialog = New System.Windows.Forms.PageSetupDialog
        Me.reviewsPrintDialog = New System.Windows.Forms.PrintDialog
        Me.reviewsMenuStrip.SuspendLayout()
        Me.reviewsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'reviewsMenuStrip
        '
        Me.reviewsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.reviewsMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.reviewsMenuStrip.Name = "reviewsMenuStrip"
        Me.reviewsMenuStrip.Size = New System.Drawing.Size(516, 24)
        Me.reviewsMenuStrip.TabIndex = 0
        Me.reviewsMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ToolStripSeparator1, Me.PageSetupToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseFormToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenToolStripMenuItem.Text = "&Open Review..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SaveToolStripMenuItem.Text = "&Save Review..."
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CloseToolStripMenuItem.Text = "C&lose Review"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page Set&up..."
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PrintToolStripMenuItem.Text = "&Print..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(158, 6)
        '
        'CloseFormToolStripMenuItem
        '
        Me.CloseFormToolStripMenuItem.Name = "CloseFormToolStripMenuItem"
        Me.CloseFormToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CloseFormToolStripMenuItem.Text = "&Close Form"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FormatToolStripMenuItem.Text = "F&ormat"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.FontToolStripMenuItem.Text = "&Font..."
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ColorToolStripMenuItem.Text = "&Color..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options..."
        '
        'reviewsToolStrip
        '
        Me.reviewsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripButton, Me.saveToolStripButton, Me.fontToolStripButton, Me.colorToolStripButton, Me.previewToolStripButton, Me.printToolStripButton})
        Me.reviewsToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.reviewsToolStrip.Name = "reviewsToolStrip"
        Me.reviewsToolStrip.Size = New System.Drawing.Size(516, 25)
        Me.reviewsToolStrip.TabIndex = 1
        Me.reviewsToolStrip.Text = "ToolStrip1"
        '
        'openToolStripButton
        '
        Me.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openToolStripButton.Image = Global.AWEViewerVB.My.Resources.Resources.OpenFolder
        Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripButton.Name = "openToolStripButton"
        Me.openToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.openToolStripButton.Text = "Open"
        '
        'saveToolStripButton
        '
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = Global.AWEViewerVB.My.Resources.Resources.Save
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.saveToolStripButton.Text = "Save"
        '
        'fontToolStripButton
        '
        Me.fontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.fontToolStripButton.Image = Global.AWEViewerVB.My.Resources.Resources.Font
        Me.fontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.fontToolStripButton.Name = "fontToolStripButton"
        Me.fontToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.fontToolStripButton.Text = "Font"
        '
        'colorToolStripButton
        '
        Me.colorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.colorToolStripButton.Image = Global.AWEViewerVB.My.Resources.Resources.ChooseColor
        Me.colorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.colorToolStripButton.Name = "colorToolStripButton"
        Me.colorToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.colorToolStripButton.Text = "Color"
        '
        'previewToolStripButton
        '
        Me.previewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.previewToolStripButton.Image = Global.AWEViewerVB.My.Resources.Resources.PrintPreview
        Me.previewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.previewToolStripButton.Name = "previewToolStripButton"
        Me.previewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.previewToolStripButton.Text = "Print Preview"
        '
        'printToolStripButton
        '
        Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printToolStripButton.Image = Global.AWEViewerVB.My.Resources.Resources.Print
        Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripButton.Name = "printToolStripButton"
        Me.printToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.printToolStripButton.Text = "Print"
        '
        'filesRichTextBox
        '
        Me.filesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.filesRichTextBox.Location = New System.Drawing.Point(0, 49)
        Me.filesRichTextBox.Name = "filesRichTextBox"
        Me.filesRichTextBox.Size = New System.Drawing.Size(516, 383)
        Me.filesRichTextBox.TabIndex = 2
        Me.filesRichTextBox.Text = ""
        '
        'reviewsOpenFileDialog
        '
        Me.reviewsOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'reviewsPrintDocument
        '
        '
        'reviewsPrintPreviewDialog
        '
        Me.reviewsPrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.reviewsPrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.reviewsPrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.reviewsPrintPreviewDialog.Enabled = True
        Me.reviewsPrintPreviewDialog.Icon = CType(resources.GetObject("reviewsPrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.reviewsPrintPreviewDialog.Name = "ReviewsPrintPreviewDialog"
        Me.reviewsPrintPreviewDialog.Visible = False
        '
        'EmployeeReviews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 432)
        Me.Controls.Add(Me.filesRichTextBox)
        Me.Controls.Add(Me.reviewsToolStrip)
        Me.Controls.Add(Me.reviewsMenuStrip)
        Me.MainMenuStrip = Me.reviewsMenuStrip
        Me.Name = "EmployeeReviews"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Reviews"
        Me.reviewsMenuStrip.ResumeLayout(False)
        Me.reviewsMenuStrip.PerformLayout()
        Me.reviewsToolStrip.ResumeLayout(False)
        Me.reviewsToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reviewsMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents reviewsToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents fontToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents colorToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents previewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents filesRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents reviewsOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents reviewsSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents reviewsFontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents reviewsColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents reviewsPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents reviewsPrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents reviewsPageSetupDialog As System.Windows.Forms.PageSetupDialog
    Friend WithEvents reviewsPrintDialog As System.Windows.Forms.PrintDialog

End Class
