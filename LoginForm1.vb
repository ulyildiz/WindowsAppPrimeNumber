Public Class LoginForm1

    ' TODO: Sa�lanan kullan�c� ad� ve parolay� kullanarak �zel kimlik do�rulamas� ger�ekle�tirmek i�in kod girin 
    ' (Bkz. https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' �zel ilke o zaman ge�erli i� par�ac���n�n ilkesine asa��daki gibi ili�tirilebilir: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal'�n kimlik do�rulamas� ger�ekle�tirmek i�in IPrincipal uygulamas� oldu�u yerde. 
    ' Ard�ndan My.User, CustomPrincipal nesnesinde yal�t�lm�� kullan�c� ad�, g�r�nen ad, vb.
    ' kimlik bilgileri geri d�nd�r�r

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
