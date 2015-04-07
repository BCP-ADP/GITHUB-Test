<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class BaseForm
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
        Me.titleLabel = New System.Windows.Forms.Label
        Me.logoPictureBox = New System.Windows.Forms.PictureBox
        Me.closeButton = New System.Windows.Forms.Button
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.titleLabel.AutoSize = True
        Me.titleLabel.BackColor = System.Drawing.Color.LightGray
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.Blue
        Me.titleLabel.Location = New System.Drawing.Point(195, 76)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(100, 24)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Form Title"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logoPictureBox.Image = AWEViewerVB.My.Resources.Resources.Logo
        Me.logoPictureBox.Location = New System.Drawing.Point(343, 12)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(200, 60)
        Me.logoPictureBox.TabIndex = 1
        Me.logoPictureBox.TabStop = False
        '
        'closeButton
        '
        Me.closeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeButton.Location = New System.Drawing.Point(442, 360)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 2
        Me.closeButton.Text = "Close Form"
        '
        'BaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 403)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.logoPictureBox)
        Me.Controls.Add(Me.titleLabel)
        Me.Name = "BaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adventure Works Employee Viewer"
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents titleLabel As System.Windows.Forms.Label
    Protected WithEvents closeButton As System.Windows.Forms.Button
    Private WithEvents logoPictureBox As System.Windows.Forms.PictureBox
End Class
