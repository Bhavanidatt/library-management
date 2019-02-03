

Public Class SignUpForm
	Private Shared DropDownActive As Boolean = False
	Private Sub SignupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignupButton.Click
		If PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
			MessageBox.Show("Passwords do not match!", "Enter passwords again carefully!")
			PasswordTextBox.Text = ""
			ConfirmPasswordTextBox.Text = ""
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
		GLogin.Fullname = FullnameTextBox.Text
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
		GLogin.Password = PasswordTextBox.Text
		GLogin.AccType = DropDownButton.Text
		SqlInterface.Register()
		Me.Close()
	End Sub

	Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
		GLogin.LogOut()
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

	Private Sub StudentAcc_Click(sender As Object, e As EventArgs) Handles StudentAcc.Click
		DropDownButton.Text = "Student"
		StudentAcc.Checked = True
		TeacherAcc.Checked = False
		AdminAcc.Checked = False
	End Sub

    Private Sub TeacherAcc_Click(sender As Object, e As EventArgs) Handles TeacherAcc.Click
		DropDownButton.Text = "Teacher"
		StudentAcc.Checked = False
		TeacherAcc.Checked = True
		AdminAcc.Checked = False
	End Sub

    Private Sub AdminAcc_Click(sender As Object, e As EventArgs) Handles AdminAcc.Click
		DropDownButton.Text = "Admin"
		StudentAcc.Checked = False
		TeacherAcc.Checked = False
		AdminAcc.Checked = True
	End Sub

	Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UsernameTextBox.Text = ""
		PasswordTextBox.Text = ""
		FullnameTextBox.Text = ""
		ConfirmPasswordTextBox.Text = ""
		If GLogin.LoggedIn = True Then
			MessageBox.Show("Already Logged In", "You are already Logged in! Logic error in form", MessageBoxButtons.OK, MessageBoxIcon.Information)
			MyBase.Close()
		End If
	End Sub
End Class
