Public Class LoginForm1

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' txtUsernameBox.Text = My.User.Name
        txtUsernameBox.Text = "admin"
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If PasswordTextBox.Text = "1234" AndAlso txtUsernameBox.Text = "admin" Then
            Dim frmPanelForm As New frmPanel
            frmPanelForm.Show()
            Me.Hide()
        Else
            lblPasswordError.Visible = True
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
