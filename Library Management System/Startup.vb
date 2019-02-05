Public Class StartupForm
	Private Sub SearchBooksButton_Click(sender As Object, e As EventArgs) Handles SearchBooksButton.Click

	End Sub

	Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
		LoginForm.ShowDialog()
		If GLogin.LoggedIn = True Then
			If GLogin.AccType = "Admin" Then
				AdminForm.Show()
			Else
				UserForm.Show()
			End If
			Me.Close()
		End If
	End Sub
End Class