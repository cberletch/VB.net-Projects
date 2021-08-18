
Public Class AddNewName
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub clearform()
        txtComments.Text = String.Empty
        txtEmail.Text = String.Empty
        txtPhone.Text = String.Empty
        txtName.Text = String.Empty
    End Sub
    Private Sub GetData(ByVal a As cAddress)
        a.strName = txtName.Text
        a.strEmail = txtEmail.Text
        a.strPhone = txtPhone.Text
        a.strComment = txtComments.Text
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Dim objaddress As New cAddress

        GetData(objaddress)

        AddRecord(objaddress)

        MessageBox.Show("Record was added")

        clearform()




    End Sub
End Class