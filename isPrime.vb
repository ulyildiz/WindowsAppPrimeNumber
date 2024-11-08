Public Class isPrime
    Function IsPrime(ByVal intN As Integer) As Boolean
        Dim intSqrrtN As Integer
        Dim blnPrime As Boolean = True

        intSqrrtN = Math.Sqrt(intN)
        For i = 2 To intSqrrtN
            Dim intRslt As Integer = intN Mod i
            If intRslt = 0 Then
                blnPrime = False
                Exit For
            End If
        Next
        Return blnPrime
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intUserInput As Integer


        If IsNumeric(txtUserInput.Text) Then
            intUserInput = Val(txtUserInput.Text)
            lblResult.Text = IsPrime(intUserInput)
        Else
            lblResult.Text = "Invalid input"
        End If
    End Sub

    Private Sub btnListPrimeNumbers_Click(sender As Object, e As EventArgs) Handles btnListPrimeNumbers.Click
        Dim nMax As Integer = Val(txtNmax.Text)

        lstPrimeNumbers.Items.Clear()
        For i = 2 To nMax
            If IsPrime(i) Then lstPrimeNumbers.Items.Add(i)
        Next
    End Sub

End Class
