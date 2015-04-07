Imports System.IO
Public Class ReportGeneratorHelp


    Private Sub ReportGeneratorHelp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sFileLocation As String
        Try
            ' Get the path to the help file.
            sFileLocation = Path.GetFullPath("..\\..\\Supporting Files\HelpFile.htm")
            ' Display the help file in the WebBrowser control.
            helpWebBrowser.Url = New Uri(sFileLocation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class