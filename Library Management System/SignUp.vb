

Public Class SignUpForm
	Private Shared DropDownActive As Boolean = False
	Private Sub SignupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignupButton.Click
		If PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
			MessageBox.Show("Passwords do not match!", "Enter password carefully!")
			Exit Sub
		End If

        'SqlInterface.sqlQuery = "INSERT INTO user( name,email, pass, sex,status,booksissued,due)" &
        '			"VALUES ('" & FullnameTextBox.Text & "','" & UsernameTextBox.Text & "','" & PasswordTextBox.Text & "','" & sex & "','" & SelectionTextBox.Text & "',0,0)"
        'SqlInterface.Register(SqlInterface.sqlQuery)

        SqlInterface.Register()
        Me.Close()
	End Sub

	Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
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
	End Sub

    Private Sub TeacherAcc_Click(sender As Object, e As EventArgs) Handles TeacherAcc.Click
		DropDownButton.Text = "Teacher"
	End Sub

    Private Sub AdminAcc_Click(sender As Object, e As EventArgs) Handles AdminAcc.Click
		DropDownButton.Text = "Admin"
	End Sub


End Class
