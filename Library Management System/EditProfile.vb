Public Class EditProfileForm
	Private Shared DropDownActive As Boolean = False

	Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Me.Close()
	End Sub

	Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Me.Close()
	End Sub

	Private Sub DropDownButton_Click(sender As Object, e As EventArgs) Handles DropDownButton.Click
		If DropDownActive = False Then
			DropDown.Show(DropDownButton, New Point(0, 0), ToolStripDropDownDirection.AboveRight)
			DropDownActive = True
		Else
			DropDownActive = False
			DropDown.Hide()
		End If
	End Sub

	Private Sub EditProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UsernameTextBox.Text = ""
		FullnameTextBox.Text = ""
		OldPasswordTextBox.Text = ""
		NewPasswordTextBox.Text = ""
		ConfirmPasswordTextPassword.Text = ""
		DropDownButton.Text = ""
		If GLogin.LoggedIn = False Then
			MessageBox.Show("Already Logged In", "You are already Logged in! Logic error in form", MessageBoxButtons.OK, MessageBoxIcon.Information)
			MyBase.Close()
		End If
		UsernameTextBox.Text = GLogin.Username
		FullnameTextBox.Text = GLogin.Fullname
		DropDownButton.Text = GLogin.AccType
	End Sub

	Private Sub EditProfileButton_Click(sender As Object, e As EventArgs) Handles EditProfileButton.Click
		' TODO: Update row to reflect change in profile
		If UsernameTextBox.Text <> GLogin.Username Then
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
					Exit Sub
				End If
			Next
			' change username here
		End If
		If FullnameTextBox.Text <> GLogin.Fullname Then
			For Each C As Char In FullnameTextBox.Text
				If AscW(C) >= AscW("a") AndAlso AscW("z") >= AscW(C) Then
					Continue For
				ElseIf AscW(C) >= AscW("Z") AndAlso AscW("Z") >= AscW(C) Then
					Continue For
				ElseIf AscW(C) = AscW(" ") Then
					Continue For
				Else
					MessageBox.Show("Invalid Characters in Name", "Use only alphanumerics( a-z or A-Z ) or Space", MessageBoxButtons.OK, MessageBoxIcon.Error)
					GLogin.LogOut()
					Exit Sub
				End If
			Next
			' change fulllname here
		End If
		If DropDownButton.Text <> GLogin.AccType Then
			' change acc type here
		End If
	End Sub

	Private Sub ChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordButton.Click
		If True Then ' check old password here
			If NewPasswordTextBox.Text = ConfirmPasswordTextPassword.Text Then
				' change pass word here
			Else
				MessageBox.Show("New Passwords do not match. Try Again", "Passwords Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
				NewPasswordTextBox.Text = ""
				ConfirmPasswordTextPassword.Text = ""
			End If
		Else
			MessageBox.Show("Old Passwordis incorrect. Try Again", "Passwords Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
			OldPasswordTextBox.Text = ""
			NewPasswordTextBox.Text = ""
			ConfirmPasswordTextPassword.Text = ""

		End If
	End Sub

	Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
		MyBase.Close()
		AccountSummaryForm.Show()
	End Sub
End Class
