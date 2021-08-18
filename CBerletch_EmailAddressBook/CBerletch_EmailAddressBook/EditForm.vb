Public Class EditForm
    ' Class-level object variable.
    Dim addressObject As cAddress

    Private Sub EditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Display the selected record.

        ' Get a reference to the selected object.
        addressObject = DirectCast(Form1.lstAddress.SelectedItem, cAddress)

        ' Display the object's data.
        displayRecord(addressObject)
    End Sub

    Private Sub btnSaveChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChanges.Click
        ' Save any changes.
        updateData(addressObject)
        MessageBox.Show("Record updated.", "Confirmation")

        ' Close the EditForm form.
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ' Close the EditForm form.
        Me.Close()
    End Sub

    Sub displayRecord(ByVal a As cAddress)

        ' Display a record.
        txtName.Text = a.strName
        txtEmail.Text = a.strEmail
        txtPhone.Text = a.strPhone
        txtComments.Text = a.strComment

        ' Set the focus.
        txtName.Focus()

    End Sub

    Sub updateData(ByRef a As cAddress)

        ' Store the data on the form in the Address object
        ' passed as the argument.
        a.strName = txtName.Text
        a.strEmail = txtEmail.Text
        a.strPhone = txtPhone.Text
        a.strComment = txtComments.Text

    End Sub

End Class