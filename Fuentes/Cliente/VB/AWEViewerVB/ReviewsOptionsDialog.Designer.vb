<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReviewsOptionsDialog
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
        Me.zoomFactorLabel = New System.Windows.Forms.Label
        Me.zoomNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.OK_Button = New System.Windows.Forms.Button
        Me.cancel_Button = New System.Windows.Forms.Button
        CType(Me.zoomNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'zoomFactorLabel
        '
        Me.zoomFactorLabel.AutoSize = True
        Me.zoomFactorLabel.Location = New System.Drawing.Point(42, 25)
        Me.zoomFactorLabel.Name = "zoomFactorLabel"
        Me.zoomFactorLabel.Size = New System.Drawing.Size(60, 13)
        Me.zoomFactorLabel.TabIndex = 0
        Me.zoomFactorLabel.Text = "Zoom factor"
        '
        'zoomNumericUpDown
        '
        Me.zoomNumericUpDown.Location = New System.Drawing.Point(136, 25)
        Me.zoomNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.zoomNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.zoomNumericUpDown.Name = "zoomNumericUpDown"
        Me.zoomNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.zoomNumericUpDown.TabIndex = 1
        Me.zoomNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'OK_Button
        '
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OK_Button.Location = New System.Drawing.Point(120, 80)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(58, 23)
        Me.OK_Button.TabIndex = 2
        Me.OK_Button.Text = "OK"
        '
        'cancel_Button
        '
        Me.cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel_Button.Location = New System.Drawing.Point(184, 80)
        Me.cancel_Button.Name = "cancel_Button"
        Me.cancel_Button.Size = New System.Drawing.Size(58, 23)
        Me.cancel_Button.TabIndex = 3
        Me.cancel_Button.Text = "Cancel"
        '
        'ReviewsOptionsDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancel_Button
        Me.ClientSize = New System.Drawing.Size(254, 115)
        Me.ControlBox = False
        Me.Controls.Add(Me.cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.zoomNumericUpDown)
        Me.Controls.Add(Me.zoomFactorLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReviewsOptionsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        CType(Me.zoomNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents zoomFactorLabel As System.Windows.Forms.Label
    Friend WithEvents zoomNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents cancel_Button As System.Windows.Forms.Button
End Class
