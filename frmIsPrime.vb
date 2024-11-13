Public Class frmIsPrime

    Function IsPrime(ByVal intN As Integer) As Boolean
        Dim intSqrrtN As Integer

        If intN < 2 Then
            Return False
        End If

        If Not intN = 2 AndAlso intN Mod 2 = 0 Then
            Return False
        End If

        intSqrrtN = Math.Sqrt(intN)
        For i = 3 To intSqrrtN Step 2
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
            Try
                intUserInput = Val(txtUserInput.Text)
                If IsPrime(intUserInput) Then
                    lblResult.Text = intUserInput & " is a prime number."
                Else
                    lblResult.Text = intUserInput & " is not a prime number."
                End If
            Catch ex As OverflowException
                lblInputError.Text = "Error: Arithmetic operation resulted in an overflow."
                lblResult.Text = "..."
                lblInputError.Visible = True
            End Try
        Else
            lblResult.Text = "..."
            lblInputError.Text = "Error: Please enter a positive integer."
            lblInputError.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblInputError.Visible = False
        txtUserInput.Clear()
        lblResult.Text = "..."
    End Sub

    Private Sub frmIsPrime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
