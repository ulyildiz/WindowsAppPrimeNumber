Public Class frmIsPrime
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
            If IsPrime(intUserInput) Then
                lblResult.Text = intUserInput & " is a prime number."
            Else
                lblResult.Text = intUserInput & " is not a prime number."
            End If
        Else
            lblInputError.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblInputError.Visible = False
        txtUserInput.Clear()
        lblResult.Text = "..."
    End Sub

    Private Sub lblIsPrime_Click(sender As Object, e As EventArgs) Handles lblIsPrime.Click

    End Sub
End Class
