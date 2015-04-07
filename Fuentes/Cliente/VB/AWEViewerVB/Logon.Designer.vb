<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Logon
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
        Me.usernameLabel = New System.Windows.Forms.Label
        Me.usernameTextBox = New System.Windows.Forms.TextBox
        Me.passwordLabel = New System.Windows.Forms.Label
        Me.passwordTextBox = New System.Windows.Forms.TextBox
        Me.OK = New System.Windows.Forms.Button
        Me.cancel = New System.Windows.Forms.Button
        Me.logonHelpProvider = New System.Windows.Forms.HelpProvider
        Me.SuspendLayout()
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(39, 24)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(54, 13)
        Me.usernameLabel.TabIndex = 0
        Me.usernameLabel.Text = "&User name"
        '
        'usernameTextBox
        '
        Me.logonHelpProvider.SetHelpString(Me.usernameTextBox, "Enter your user name")
        Me.usernameTextBox.Location = New System.Drawing.Point(40, 40)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.logonHelpProvider.SetShowHelp(Me.usernameTextBox, True)
        Me.usernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.usernameTextBox.TabIndex = 1
        Me.usernameTextBox.Text = "User1"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(39, 81)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(49, 13)
        Me.passwordLabel.TabIndex = 2
        Me.passwordLabel.Text = "&Password"
        '
        'passwordTextBox
        '
        Me.logonHelpProvider.SetHelpString(Me.passwordTextBox, "Enter your password")
        Me.passwordTextBox.Location = New System.Drawing.Point(40, 97)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.logonHelpProvider.SetShowHelp(Me.passwordTextBox, True)
        Me.passwordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.passwordTextBox.TabIndex = 3
        Me.passwordTextBox.Text = "User1"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(40, 142)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'cancel
        '
        Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel.Location = New System.Drawing.Point(166, 142)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(94, 23)
        Me.cancel.TabIndex = 5
        Me.cancel.Text = "&Cancel"
        '
        'Logon
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancel
        Me.ClientSize = New System.Drawing.Size(292, 173)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.usernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Logon"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter your user name and password"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usernameLabel As System.Windows.Forms.Label
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents passwordLabel As System.Windows.Forms.Label
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents logonHelpProvider As System.Windows.Forms.HelpProvider
End Class
