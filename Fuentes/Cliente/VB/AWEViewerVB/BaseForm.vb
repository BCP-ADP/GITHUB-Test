Public Class BaseForm

    ' Base form closebutton click event handler.
    Protected Overridable Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        MessageBox.Show("Close from base form", "Closing form", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class