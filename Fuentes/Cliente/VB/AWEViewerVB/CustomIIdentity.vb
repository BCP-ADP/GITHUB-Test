' This class checks for valid user names and passwords.
' Values are stored in private variables and
' retrieved using public readonly properties
Public Class CustomIIdentity
    Private nameValue As String
    Private authenticatedValue As Boolean
    Private roleValue As String

    Public ReadOnly Property IsAuthenticated() As Boolean
        Get
            Return authenticatedValue

        End Get
    End Property

    Public ReadOnly Property Name() As String
        Get
            Return nameValue

        End Get
    End Property
    Public ReadOnly Property Role() As String
        Get
            Return roleValue
        End Get
    End Property
    ' Class constructor.
    ' Check whether provided username and password is valid.
    ' Set private variables to appropriate values.
    Public Sub New(ByVal name As String, ByVal password As String)
        Try
            If IsValidNameAndPassword(name, password) Then
                If name.ToLower = "user1" Then
                    nameValue = name
                    authenticatedValue = True
                    roleValue = "Administrator"
                Else
                    nameValue = name
                    authenticatedValue = True
                    roleValue = "User"
                End If
            Else
                nameValue = ""
                authenticatedValue = False
                roleValue = "Guest"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            nameValue = ""
            authenticatedValue = False
            roleValue = "Guest"
        End Try
    End Sub
    ' Check for valid username and password.
    Private Function IsValidNameAndPassword( _
    ByVal username As String, _
    ByVal password As String _
    ) As Boolean
        Try
            Select Case username.ToLower
                Case "user1"
                    If password = "User1" Then
                        Return True
                    Else
                        Return False
                    End If
                Case "user2"
                    If password = "User2" Then
                        Return True
                    Else
                        Return False
                    End If
                Case Else
                    Return False
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function
End Class
