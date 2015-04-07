Public Class InheritanceTest
    Inherits AWEViewerVB.BaseForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.titleLabel.Size = New System.Drawing.Size(155, 24)
        Me.titleLabel.Text = "Inheritance Test"
        '
        'InheritanceTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(552, 403)
        Me.Name = "InheritanceTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' Inherited form Closebutton click event.
    Protected Overrides Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Close from inherited form", "Closing form", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

End Class
