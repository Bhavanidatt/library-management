Public Class UserForm
	Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
		GLogin.LogOut()
		StartupForm.Show()
		Me.Close()
	End Sub

	Private Sub AccountSummaryButton_Click(sender As Object, e As EventArgs) Handles AccountSummaryButton.Click
		AccountSummaryForm.Show()
		Me.Close()
	End Sub

	Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If GLogin.LoggedIn = False Then
			MessageBox.Show("Not Logged in", "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub
End Class