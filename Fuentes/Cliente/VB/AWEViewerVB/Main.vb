Imports System.Globalization
Imports System.Threading

Public Class Main
    Private userAdminButton As New Button
    Private _userAuthenticated As Boolean = False
    Private _userName As String = ""
    Private _userRole As String = ""

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click, ExitToolStripMenuItem.Click
        ' Exit application.
        System.Environment.Exit(0)
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Display the Logon form as a modal dialog box.
        My.Forms.Logon.ShowDialog()
        Try
            ' If user authenticated, display name of user in Currentuser textbox.
            If UserAuthenticated Then
                currentUserTextBox.Text = UserName
                ' If user is an administrator, add User Admin button to flowlayoutpanel.
                If UserRole = "Administrator" Then
                    userAdminButton.Name = "UserAdminButton"
                    userAdminButton.Size = New System.Drawing.Size(113, 24)
                    userAdminButton.Text = "User Admin"
                    navigationFlowLayout.Controls.Add(userAdminButton)
                    ' Add event handler for UserAdmin button.
                    AddHandler userAdminButton.Click, AddressOf userAdminButton_Click
                    ' Add event handler for UserAdmin menu item.
                    AddHandler UserAdminToolStripMenuItem.Click, AddressOf userAdminButton_Click
                    ' Display and enable Tools menu.
                    ToolsToolStripMenuItem.Visible = True
                    ToolsToolStripMenuItem.Enabled = True
                End If
                ' If user not authenticated, end the application
            Else
                Me.Close()
                End
            End If
            ' Load the Copyright.rtf file into the RichTextBox on the Main form.
            copyrightRichText.LoadFile("..\..\Supporting Files\Copyright.rtf")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub userAdminButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("User Admin form")
    End Sub

    Private Sub websiteLinkLabel_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles websiteLinkLabel.LinkClicked
        Try
            ' Navigate to Adventure Works web site.
            websiteLinkLabel.LinkVisited = True
            System.Diagnostics.Process.Start("http://www.adventure-works.com")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    ' Public properties used to set and retrieve
    ' private variables
    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            _userName = value
        End Set
    End Property
    Public Property UserRole() As String
        Get
            Return _userRole
        End Get
        Set(ByVal value As String)
            _userRole = value
        End Set
    End Property
    Public Property UserAuthenticated() As Boolean
        Get
            Return _userAuthenticated
        End Get
        Set(ByVal value As Boolean)
            _userAuthenticated = value
        End Set
    End Property






    Private Sub EmployeeViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeViewerToolStripMenuItem.Click
        Try
            ' Open the EmployeeViewer form
            EmployeeViewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ReportGeneratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportGeneratorToolStripMenuItem.Click
        Try
            ' Open the ReportGenerator form
            ReportGenerator.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub DepartmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentsToolStripMenuItem.Click
        Try
            ' Open DepartmentDetails form.
            DepartmentDetails.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub setColorScheme()
        Try
            ' If HighContrast is enabled, 
            ' modify properties of label and textbox on form to use
            ' System colors.
            If SystemInformation.HighContrast Then
                appTitleLabel.BackColor = SystemColors.Window
                appTitleLabel.ForeColor = SystemColors.WindowText
                currentUserTextBox.BackColor = SystemColors.Window
                currentUserTextBox.ForeColor = SystemColors.WindowText
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Protected Sub userPreferenceChanged(ByVal sender As Object, ByVal e As Microsoft.Win32.UserPreferenceChangedEventArgs)
        ' Call SetColorScheme method.
        setColorScheme()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Call SetColorScheme method.
        setColorScheme()
        ' Add handler for the userpreferencechanged event.
        AddHandler Microsoft.Win32.SystemEvents.UserPreferenceChanged, AddressOf Me.userPreferenceChanged

    End Sub

    Private Sub EnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishToolStripMenuItem.Click
        ' Set culture to en-US.
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        ' Open LocalizationTest form.
        LocalizationTest.Show()
    End Sub

    Private Sub FrenchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrenchToolStripMenuItem.Click
        ' Set culture to fr-FR.
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
        ' Open LocalizationTest form.
        LocalizationTest.Show()
    End Sub

    Private Sub EmployeeReviewsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeReviewsToolStripMenuItem.Click
        ' Open EmployeeReviews form.
        Dim newEmployeeReviews As EmployeeReviews = New EmployeeReviews()
        newEmployeeReviews.Show()
    End Sub

    Private Sub InheritanceTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InheritanceTestToolStripMenuItem.Click
        ' Open InheritanceText form.
        Dim newInheritanceTest As InheritanceTest = New InheritanceTest()
        newInheritanceTest.Show()
    End Sub
End Class
