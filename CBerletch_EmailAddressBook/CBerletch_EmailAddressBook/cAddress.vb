
Public Class cAddress
    'member variables
    Public strName As String 'holds Name
    Public strEmail As String 'holds Email
    Public strPhone As String 'holds phone number
    Public strComment As String 'holds comment

    Public Overrides Function ToString() As String
        Return $"{strName}, {strEmail}, {strPhone}, {strComment}"
    End Function

End Class


