Public Class Logon
    Private I As Integer = 0


    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        'Close form.
        Me.Close()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' Pass username and password to CustomIIdentity class for validation.
        Dim CheckUser As New CustomIIdentity( _
        Me.usernameTextBox.Text, Me.passwordTextBox.Text)
        Try
            If (Not CheckUser.IsAuthenticated) Then
                ' If username and password incorrect three times, close the form.
                If I >= 2 Then
                    MessageBox.Show("Too many logon attempts. Exiting Application.")
                    Me.Close()
                    Exit Sub
                End If
                ' If username and password incorrect, reset them.
                Me.passwordTextBox.Text = ""
                Me.usernameTextBox.Text = ""
                MessageBox.Show("The username and password pair is incorrect")
                Me.usernameTextBox.Focus()
                ' Increment counter keeping track of number of incorrect attempts.
                I = I + 1
            Else
                ' If user authenticated, set Main form properties appropriately.
                Main.UserAuthenticated = True
                Main.UserName = CheckUser.Name
                Main.UserRole = CheckUser.Role
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class