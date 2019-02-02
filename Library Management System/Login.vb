Public Class LoginForm

	Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
		If GLogin.LoggedIn = True Then
			Return
		End If

		If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
			MessageBox.Show("Empty Inputs Found", "Username/Password fields can not be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If
		For Each C As Char In UsernameTextBox.Text
			If AscW(C) >= AscW("a") AndAlso AscW("z") >= AscW(C) Then
				Continue For
			ElseIf AscW(C) >= AscW("Z") AndAlso AscW("Z") >= AscW(C) Then
				Continue For
			ElseIf AscW(C) >= AscW("0") AndAlso AscW("9") >= AscW(C) Then
				Continue For
			ElseIf AscW(C) = AscW("_") Then
				Continue For
			Else
				MessageBox.Show("Invalid Characters in Username", "Use only alphanumerics( a-z or A-Z ) or underscores( _ )", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		Next
        GLogin.Username = UsernameTextBox.Text
        GLogin.Password = PasswordTextBox.Text
        SqlInterface.Login(GLogin.Username, GLogin.Password)

        If GLogin.LoggedIn = True Then
            Me.Close()
        ElseIf GLogin.LoggedIn = False Then
            GLogin.Reset()
        End If

    End Sub

	Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
		GLogin.Reset()
		Me.Close()
	End Sub
End Class

