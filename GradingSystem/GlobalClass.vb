Public Class GlobalClass
    Private _count As String

    Public Shared Function get_greetings() As String
        Dim date_now As DateTime
        Dim hour As String
        date_now = DateTime.Now.ToString("MMM dd, yyyy H:mm:ss")
        hour = date_now.Hour.ToString

        If hour < 5 Then
            Return "You woke up early"
        ElseIf hour < 10 Then
            Return "Good morning"
        ElseIf hour <= 12 Then
            Return "It's almost lunch"
        ElseIf hour < 18 Then
            Return "Good afternoon"
        ElseIf hour <= 22 Then
            Return "Good evening"
        Else
            Return "You must be working really hard"
        End If
    End Function

    Public Property Number() As String
        Get
            Return _count
        End Get
        Set(ByVal value As String)
            _count = value
        End Set
    End Property

End Class
