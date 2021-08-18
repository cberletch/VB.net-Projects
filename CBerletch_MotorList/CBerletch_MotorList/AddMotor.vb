Public Class AddMotor
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    ' The Get Data procedure assigns values from the form to a motor object's properties
    Private Sub getData(ByVal M As Motor)

        Try
            ' Get all Information
            M.MotorId = IdNumber.Text
            M.Description = txtDescription.Text
            M.RPM = txtRPM.Text
            M.Voltage = txtVoltage.Text
            M.Status = cmbStatus.Text

        Catch ex As Exception
            MessageBox.Show("Enter proper values for all entries")
        End Try
    End Sub

    ' ClearForm procedure
    Private Sub clearForm()
        txtDescription.Clear()
        IdNumber.Value = 10000
        txtRPM.Value = 10
        cmbStatus.SelectedItem.Equals(0)
        txtVoltage.Value = 1
        ' Set focus
        IdNumber.Focus()
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Create an instance of the motor class.
        Dim objmotor As New Motor
        ' Get data from the form.
        getData(objmotor)
        ' Add the motor object to the collection
        newMotor(objmotor)
        ' Display a confirmation message.
        MessageBox.Show("Motor record added successfully")

        clearForm()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Create an instance of the display form
        Dim frmDisplay As New Display
        ' Display the form
        frmDisplay.ShowDialog()
    End Sub

End Class