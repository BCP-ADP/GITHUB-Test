Imports System.Xml
Public Class EmployeeViewer

    Private Sub getData()
        Dim Doc As New XmlDocument()
        Dim node As XmlNode
        Try
            ' Load XML file contents into xmldocument object.
            Doc.Load("..\\..\\Supporting Files\Employees.xml")
            Dim Nodes As XmlNodeList = Doc.SelectNodes("Employees/Dept")
            ' Loop through each dept node.
            For Each node In Nodes
                ' New instance of EmployeeNode class.
                Dim tNode As New EmployeeNode
                ' Set properties of Dept node.
                tNode.ImageIndex = 0
                tNode.SelectedImageIndex = 0
                tNode.Text = node.Attributes("name").Value
                Dim nodes2 As XmlNodeList = node.SelectNodes("Employee")
                Dim node2 As XmlNode
                ' Loop through each employee in department.
                For Each node2 In nodes2
                    Dim tNode2 As New EmployeeNode
                    ' Set properties of employee node.
                    tNode2.ImageIndex = 1
                    tNode2.SelectedImageIndex = 2
                    tNode2.Text = node2.SelectSingleNode("Name").InnerText
                    tNode2.Img = node2.SelectSingleNode("Image").InnerText
                    tNode2.ID = node2.SelectSingleNode("ID").InnerText
                    ' Add current employee node to nodes collection of Dept node.
                    tNode.Nodes.Add(tNode2)
                Next node2
                ' Add Dept node to nodes collection of TreeView control.
                employeesTreeView.Nodes.Add(tNode)
            Next node
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub loadDataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadDataToolStripButton.Click, LoadDataToolStripMenuItem.Click
        Try
            ' Only load data if TreeView is currently empty.
            If employeesTreeView.Nodes.Count = 0 Then
                getData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub clearDataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearDataToolStripButton.Click, ClearDataToolStripMenuItem.Click
        Try
            ' Clear TreeView and remove image from PictureBox.
            If employeesTreeView.Nodes.Count <> 0 Then
                employeesTreeView.Nodes.Clear()
                If Not (employeePictureBox.Image Is Nothing) Then
                    employeePictureBox.Image.Dispose()
                    employeePictureBox.Image = Nothing
                End If
                ' Clear phone and email text boxes.
                phoneTextBox.Text = ""
                emailTextBox.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub employeesTreeView_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles employeesTreeView.AfterSelect
        Dim photoDir As String = "..\..\Photos\"
        Dim photoFileName As String
        Try
            ' Get the currently selected employee in the TreeView.
            Dim bNode As EmployeeNode = employeesTreeView.SelectedNode
            ' Get the photo for the selected employee.
            If Not bNode.Img Is Nothing Then
                photoFileName = photoDir + bNode.Img
                If Not System.IO.File.Exists(photoFileName) Then
                    photoFileName = photoDir + "NA.bmp"
                End If
            Else
                photoFileName = photoDir + "NA.bmp"
            End If
            ' Load the selected photo into the PictureBox.
            employeePictureBox.Image = Image.FromFile(photoFileName)
            employeePictureBox.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub closeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub goButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goButton.Click
        Try
            If detailsRadioButton.Checked Then
                ' Open EmployeeDetails form.
                EmployeeDetails.Show()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class