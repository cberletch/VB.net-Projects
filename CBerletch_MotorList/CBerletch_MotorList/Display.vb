Public Class Display
    Dim M As New Motor
    Private Sub disp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim tempMotor As Motor

        ' Get each object in the collection and add its data to the list box
        For i = 1 To MotorCollection.Count
            tempMotor = CType(MotorCollection.Item(i), Motor)
            lstMotors.Items.Add("ID: " & tempMotor.strMotorId & " " & "Description: " & tempMotor.strDescription & " " & "RPM: " & tempMotor.strRPM & " " & "Voltage: " & tempMotor.strVoltage & " " & "Status: " & tempMotor.strStatus)
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class