<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReportGeneratorHelp
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
        Me.helpWebBrowser = New System.Windows.Forms.WebBrowser
        Me.SuspendLayout()
        '
        'helpWebBrowser
        '
        Me.helpWebBrowser.AllowWebBrowserDrop = False
        Me.helpWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.helpWebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.helpWebBrowser.Name = "helpWebBrowser"
        Me.helpWebBrowser.Size = New System.Drawing.Size(522, 423)
        '
        'ReportGeneratorHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 423)
        Me.Controls.Add(Me.helpWebBrowser)
        Me.Name = "ReportGeneratorHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Generator Help"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents helpWebBrowser As System.Windows.Forms.WebBrowser
End Class
