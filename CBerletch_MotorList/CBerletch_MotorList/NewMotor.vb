Module MotorModule
    Public MotorCollection As New Collection


    Public Sub newMotor(ByVal M As Motor)
        Try
            MotorCollection.Add(M)
        Catch ex As Exception
            MessageBox.Show("Motor could not be added.")
        End Try
    End Sub
End Module
