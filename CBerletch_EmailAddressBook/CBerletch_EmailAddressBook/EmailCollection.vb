
Module EmailCollection
    Public AddressList As New List(Of cAddress)

    Public Sub AddRecord(ByVal a As cAddress)
        Try
            AddressList.Add(a)
        Catch ex As Exception
            MessageBox.Show("Error: inputs must be characters valid in string format")
        End Try
    End Sub

End Module
