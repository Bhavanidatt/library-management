Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		LoginForm.ShowDialog()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		SignUpForm.Show()
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Application.Exit()
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		UserForm.Show()
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		AccountSummaryForm.Show()
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		AdminForm.Show()
	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		StartupForm.Show()
	End Sub

	Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
		EditProfileForm.Show()
	End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		ViewBookForm.Show()
	End Sub
End Class