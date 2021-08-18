

Public Class Form1

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ' Update the display.

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub UpdateListBox()
        lstAddress.Items.Clear()


        For Each a As cAddress In AddressList
            lstAddress.Items.Add(a)
        Next

        If lstAddress.Items.Count > 0 Then
            lstAddress.SelectedIndex = 0

        End If
    End Sub




    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmAdd As New AddNewName

        frmAdd.ShowDialog()

        UpdateListBox()


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If MessageBox.Show("Are you sure?",
                          "Confirm Deletion",
                          MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            AddressList.Remove(DirectCast(lstAddress.SelectedItem, cAddress))
            lstAddress.Items.Remove(lstAddress.SelectedItem)
        End If


    End Sub




    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frmEdit As New EditForm

        frmEdit.ShowDialog()

        UpdateListBox()

    End Sub
End Class
