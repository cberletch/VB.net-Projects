
Public Class Motor

    Public strMotorId As String
    Public strDescription As String
    Public strRPM As String
    Public strVoltage As String
    Public strStatus As String


    Public Property MotorId() As String
        Get
            Return strMotorId
        End Get
        Set(value As String)
            strMotorId = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return strDescription
        End Get
        Set(value As String)
            strDescription = value
        End Set
    End Property
    Public Property RPM() As String
        Get
            Return strRPM
        End Get
        Set(value As String)
            strRPM = value
        End Set
    End Property
    Public Property Voltage() As String
        Get
            Return strVoltage
        End Get
        Set(value As String)
            strVoltage = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return strStatus
        End Get
        Set(value As String)
            strStatus = value
        End Set
    End Property

End Class
