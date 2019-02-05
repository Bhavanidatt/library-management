Public Class LoginForm

	Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click


		If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
			MessageBox.Show("Username/Password fields can not be empty", "Empty Inputs Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			GLogin.LogOut()
			Exit Sub
		End If
		For Each C As Char In UsernameTextBox.Text
			If AscW(C) >= AscW("a") AndAlso AscW("z") >= AscW(C) Then
				Continue For
			ElseIf AscW(C) >= AscW("A") AndAlso AscW("Z") >= AscW(C) Then
				Continue For
			ElseIf AscW(C) >= AscW("0") AndAlso AscW("9") >= AscW(C) Then
				Continue For
			ElseIf AscW(C) = AscW("_") Then
				Continue For
			Else
				MessageBox.Show("Use only alphanumerics( a-z or A-Z ) or underscores( _ )", "Invalid Characters in Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
				GLogin.LogOut()
				Exit Sub
			End If
		Next
        If Len(UsernameTextBox.Text.Trim) < 5 Then
            MessageBox.Show("Use atleast 5 digit username", "Username too short", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GLogin.LogOut()
            Exit Sub
        End If

        GLogin.LogOut()
		GLogin.Username = UsernameTextBox.Text
		GLogin.UnhashedPassword = PasswordTextBox.Text 'CheckOldPassword(PasswordTextBox.Text)


		If SqlInterface.Login() = True Then
			MessageBox.Show("You have successfully logged in as" + GLogin.Fullname, "Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.Close()
		Else
			MessageBox.Show("Incorrect Username/Password", "Username and Password do not match", MessageBoxButtons.OK, MessageBoxIcon.Error)
			GLogin.LogOut()
		End If

    End Sub

	Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
		GLogin.LogOut()
		Me.Close()
	End Sub

	Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UsernameTextBox.Text = ""
		PasswordTextBox.Text = ""
		If GLogin.LoggedIn = True Then
			MessageBox.Show("Already Logged In", "You are already Logged in! Logic error in form", MessageBoxButtons.OK, MessageBoxIcon.Information)
			MyBase.Close()
		End If
	End Sub
End Class

