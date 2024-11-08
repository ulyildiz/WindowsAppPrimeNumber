Public Class frmFindUpTo
    Private Sub btnListPrimeNumbers_Click(sender As Object, e As EventArgs)
        Dim nMax As Integer = Val(txtNmax.Text)

        lstPrimeNumbers.Items.Clear()
        For i = 2 To nMax
            If frmIsPrime.IsPrime(i) Then lstPrimeNumbers.Items.Add(i)
        Next
    End Sub
End Class