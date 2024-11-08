Public Class frmPanel
    Dim btnExit_Clicked As Boolean

    Private Sub btnPrimeControl_Click(sender As Object, e As EventArgs) Handles btnPrimeControl.Click
        pnlDisplay.Controls.Clear()
        frmIsPrime.TopLevel = False
        pnlDisplay.Controls.Add(frmIsPrime)
        frmIsPrime.Show()
    End Sub

    Private Sub btnPrimefact_Click(sender As Object, e As EventArgs) Handles btnPrimefact.Click
        pnlDisplay.Controls.Clear()
        frmPrimeFact.TopLevel = False
        pnlDisplay.Controls.Add(frmPrimeFact)
        frmPrimeFact.Show()
    End Sub

    Private Sub btnFindUpTo_Click(sender As Object, e As EventArgs) Handles btnFindUpTo.Click
        pnlDisplay.Controls.Clear()
        frmFindUpTo.TopLevel = False
        pnlDisplay.Controls.Add(frmFindUpTo)
        frmFindUpTo.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnExit_Clicked = True
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub frmPanel_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnExit_Clicked Then
            LoginForm1.Close()
        End If
        btnExit_Clicked = False
    End Sub
End Class