Public Class ReviewsOptionsDialog

    Private _zoomFactor As Integer

    ' Create ZoomFactor property.
    Public Property ZoomFactor() As Integer
        Get
            Return _zoomFactor
        End Get
        Set(ByVal value As Integer)
            _zoomFactor = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ' Store selected zoom factor value in ZoomFactor property.
        Me.ZoomFactor = zoomNumericUpDown.Value
    End Sub

End Class