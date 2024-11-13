Public Class frmFindUpTo
    Private Sub btnListPrimeNumbers_Click(sender As Object, e As EventArgs) Handles btnListPrimeNumbers.Click
        Dim nMax As Integer

        If Not IsNumeric(txtNmax.Text) OrElse txtNmax.Text.Contains("-") Then
            lstPrimeNumbers.Items.Clear()
            lblErrorText.Text = "Error: Please enter a positive integer."
            lblErrorText.Visible = True
            Return
        Else
            lblErrorText.Visible = False
        End If

        Try
            nMax = Val(txtNmax.Text)

            lstPrimeNumbers.Items.Clear()

            If nMax >= 2 Then lstPrimeNumbers.Items.Add(2)

            For i = 3 To nMax Step 2
                If frmIsPrime.IsPrime(i) Then lstPrimeNumbers.Items.Add(i)
            Next
        Catch ex As OverflowException
            lstPrimeNumbers.Items.Clear()
            lblErrorText.Text = "Error: Arithmetic operation resulted in an overflow."
            lblErrorText.Visible = True
        End Try
    End Sub

End Class