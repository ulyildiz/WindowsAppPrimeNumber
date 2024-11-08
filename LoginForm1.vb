Public Class LoginForm1

    ' TODO: Saðlanan kullanýcý adý ve parolayý kullanarak özel kimlik doðrulamasý gerçekleþtirmek için kod girin 
    ' (Bkz. https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Özel ilke o zaman geçerli iþ parçacýðýnýn ilkesine asaðýdaki gibi iliþtirilebilir: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal'ýn kimlik doðrulamasý gerçekleþtirmek için IPrincipal uygulamasý olduðu yerde. 
    ' Ardýndan My.User, CustomPrincipal nesnesinde yalýtýlmýþ kullanýcý adý, görünen ad, vb.
    ' kimlik bilgileri geri döndürür

    Dim admin_password As String = "1234"
    Private Sub txtUsernameBox_TextChanged(sender As Object, e As EventArgs) Handles txtUsernameBox.TextChanged
        txtUsernameBox.Text = My.User.Name

    End Sub


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If PasswordTextBox.Text = "1234" Then
            Dim isPrimeForm As New isPrime
            isPrimeForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
