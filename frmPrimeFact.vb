Public Class frmPrimeFact
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFindPrimeFact.Click
        Dim tmp As Integer
        Dim sqrtTmp As Integer

        If Not IsNumeric(txtUserInput.Text) OrElse txtUserInput.Text.Contains("-") Then
            lblErrorInput.Text = "Error: Please enter a positive integer."
            lblErrorInput.Visible = True
            lstFactors.Items.Clear()
            lblFactorCount.Text = "..."
            Return
        End If
        lblErrorInput.Visible = False

        lstFactors.Items.Clear()
        Try
            tmp = Val(txtUserInput.Text)
            While (tmp Mod 2 = 0)
                lstFactors.Items.Add(2)
                tmp = tmp / 2
            End While
            sqrtTmp = Math.Sqrt(tmp) + 1
            For i As Integer = 3 To sqrtTmp Step 2
                While tmp Mod i = 0
                    lstFactors.Items.Add(i)
                    tmp \= i
                End While
            Next
            If tmp > 2 Then
                lstFactors.Items.Add(tmp)
            End If
            lblFactorCount.Text = lstFactors.Items.Count().ToString() + " factors found"
        Catch ex As OverflowException
            lstFactors.Items.Clear()
            lblFactorCount.Text = "..."
            lblErrorInput.Text = "Error: Arithmetic operation resulted in an overflow."
            lblErrorInput.Visible = True
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstFactors.Items.Clear()
        txtUserInput.Clear()
        lblErrorInput.Visible = False
        lblFactorCount.Text = "..."
    End Sub

End Class