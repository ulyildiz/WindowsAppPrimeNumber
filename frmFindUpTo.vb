Public Class frmFindUpTo
    Private Sub btnListPrimeNumbers_Click(sender As Object, e As EventArgs) Handles btnListPrimeNumbers.Click
        Dim nMax As Integer

        If Not IsNumeric(txtNmax.Text) OrElse txtNmax.Text.Contains("-") Then
            lstPrimeNumbers.Items.Clear()
            lblErrorText.Visible = True
            Return
        Else
            lblErrorText.Visible = False
        End If

        nMax = Val(txtNmax.Text)

        lstPrimeNumbers.Items.Clear()
        For i = 2 To nMax
            If frmIsPrime.IsPrime(i) Then lstPrimeNumbers.Items.Add(i)
        Next
    End Sub

End Class