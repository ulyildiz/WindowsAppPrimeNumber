Public Class frmIsPrime
    Function IsPrime(ByVal intN As Integer) As Boolean
        Dim intSqrrtN As Integer

        intSqrrtN = Math.Sqrt(intN)
        For i = 2 To intSqrrtN
            If intN Mod i = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intUserInput As Integer

        If Not txtUserInput.Text.Contains("-") AndAlso IsNumeric(txtUserInput.Text) Then
            lblInputError.Visible = False
            intUserInput = Val(txtUserInput.Text)
            If IsPrime(intUserInput) Then
                lblResult.Text = intUserInput & " is a prime number."
            Else
                lblResult.Text = intUserInput & " is not a prime number."
            End If
        Else
            lblResult.Text = "..."
            lblInputError.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblInputError.Visible = False
        txtUserInput.Clear()
        lblResult.Text = "..."
    End Sub

End Class
