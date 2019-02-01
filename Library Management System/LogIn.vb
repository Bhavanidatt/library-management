Public Class LoginForm

	Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
		If GLogin.Username <> "" Then
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
				MessageBox.Show("Invalid Characters in Username", "Use only alphanumerics or underscores( _ )", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		Next
		' TODO: Validate User Here
		' ValidateLogin()
		Dim ValidationSuccess As Boolean = True
		If ValidationSuccess = True Then
			' TODO: Get these values from db
			GLogin.Username = "Avneet"
			GLogin.Fullname = "Avneet Singh Channa"
			GLogin.Password = "Not So Secure Password"
			GLogin.AccType = "Admin"
			GLogin.BooksIssued = 0
			Me.Close()
			Return
		End If
	End Sub

	Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
		GLogin.Reset()
		Me.Close()
	End Sub
End Class

