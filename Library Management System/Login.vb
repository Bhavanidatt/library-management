Public Class LoginForm

	Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click


		If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
			MessageBox.Show("Empty Inputs Found", "Username/Password fields can not be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			GLogin.LogOut()
			Exit Sub
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
				GLogin.LogOut()
				Exit Sub
			End If
		Next
		If Len(UsernameTextBox.Text.Trim) < 6 Then
			MessageBox.Show("Username too short", "Use atleast 6 digit username", MessageBoxButtons.OK, MessageBoxIcon.Error)
			GLogin.LogOut()
			Exit Sub
		End If

		GLogin.LogOut()
		GLogin.Username = UsernameTextBox.Text
		GLogin.Password = PasswordTextBox.Text


		If SqlInterface.Login() = True Then
			MessageBox.Show("Logged In", "You have successfully logged in as" + GLogin.Fullname, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

