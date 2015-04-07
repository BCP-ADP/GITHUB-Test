Imports System.IO
Public Class EmployeeReviews

    ' Get path to Reviews folder.
    Private sFileLocation As String = Path.GetFullPath("..\..\Reviews\")

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click, openToolStripButton.Click
        ' Set properties of Open dialog.
        With reviewsOpenFileDialog
            .InitialDirectory = sFileLocation
            .Filter = "Rich Text Files (*.rtf)|*.rtf"
            .Title = "Select the file you require"
            .FileName = ""
        End With
        ' Show Open dialog and save result.
        Dim result As DialogResult = reviewsOpenFileDialog.ShowDialog
        ' If user clicked OK, load selected review into RichTextBox.
        If result = Windows.Forms.DialogResult.OK Then
            filesRichTextBox.LoadFile(reviewsOpenFileDialog.FileName)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click, saveToolStripButton.Click
        ' Set properties of Save dialog.
        With reviewsSaveFileDialog
            .CreatePrompt = True
            .OverwritePrompt = True
            .DefaultExt = "*.rtf"
            .InitialDirectory = sFileLocation
            .Filter = "Rich Text Files (*.rtf)|*.rtf"
        End With
        ' Show Save dialog and save result.
        Dim result As DialogResult = reviewsSaveFileDialog.ShowDialog
        ' If user clicked OK, save current review.
        If result = Windows.Forms.DialogResult.OK Then
            filesRichTextBox.SaveFile(reviewsSaveFileDialog.FileName)
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click, fontToolStripButton.Click
        ' Show font dialog and save result.
        Dim result As DialogResult = reviewsFontDialog.ShowDialog
        ' If user clicked OK, set font of selected text in RichTextBox.
        If result = Windows.Forms.DialogResult.OK Then
            filesRichTextBox.SelectionFont = reviewsFontDialog.Font
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click, colorToolStripButton.Click
        ' Show color dialog and save result.
        Dim result As DialogResult = reviewsColorDialog.ShowDialog
        ' If user clicked OK, set color of selected text in RichTextBox.
        If result = Windows.Forms.DialogResult.OK Then
            filesRichTextBox.SelectionColor = reviewsColorDialog.Color
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        ' Display message box to check if user wants to continue.
        Dim Result As DialogResult = MessageBox.Show("Any changes will be lost. Continue?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Try
            ' If user clicked Yes, clear RichTextBox.
            If Result = Windows.Forms.DialogResult.Yes Then
                filesRichTextBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        ' Show ReviewsOptionsDialog and save result.
        Dim result As DialogResult = ReviewsOptionsDialog.ShowDialog
        ' If user clicked OK, set zoomfactor of RichTextBox to value selected on options dialog.
        If (result = Windows.Forms.DialogResult.OK) Then
            filesRichTextBox.ZoomFactor = ReviewsOptionsDialog.ZoomFactor
        End If
    End Sub

    Private Sub reviewsPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles reviewsPrintDocument.PrintPage
        Try
            ' Specify the content to be printed.
            e.Graphics.DrawString(filesRichTextBox.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 125)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click, previewToolStripButton.Click
        Try
            ' Specify the printdocument object.
            reviewsPrintPreviewDialog.Document = reviewsPrintDocument
            ' Set properties of PrintPreviewDialog.
            reviewsPrintPreviewDialog.PrintPreviewControl.Zoom = 0.5
            reviewsPrintPreviewDialog.Width = 500
            reviewsPrintPreviewDialog.Height = 650
            ' Show PrintPreviewDialog.
            reviewsPrintPreviewDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub CloseFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseFormToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click
        Try
            ' Specify PrintDocument object.
            reviewsPageSetupDialog.Document = reviewsPrintDocument
            ' Show PageSetupDialog and save result.
            Dim result As DialogResult = reviewsPageSetupDialog.ShowDialog()
            ' If user clicked ok, display options chosen on PageSetupDialog.
            If (result = Windows.Forms.DialogResult.OK) Then
                MessageBox.Show(reviewsPrintDocument.DefaultPageSettings.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub printToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printToolStripButton.Click
        Try
            ' Print the document.
            reviewsPrintDocument.Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Try
            ' Specify PrintDocument object.
            reviewsPrintDialog.Document = reviewsPrintDocument
            ' Display PrintDialog and save result.
            Dim result As DialogResult = reviewsPrintDialog.ShowDialog()
            ' If user clicked ok, display setting chosen and print document.
            If (result = Windows.Forms.DialogResult.OK) Then
                MessageBox.Show("Printer Name: " & reviewsPrintDocument.PrinterSettings.PrinterName _
                & vbCrLf & "Copies: " & reviewsPrintDocument.PrinterSettings.Copies)
                reviewsPrintDocument.Print()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
