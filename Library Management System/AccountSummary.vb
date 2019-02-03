Public Class AccountSummaryForm
	Private Sub AccountSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If GLogin.LoggedIn = True Then
			UsernameLabel.Text = GLogin.Username
			NameLabel.Text = GLogin.Fullname
			AccountTypeLabel.Text = GLogin.AccType
			DueLabel.Text = GLogin.Due.ToString
			BooksIssuedLabel.Text = GLogin.BooksIssued.ToString
		Else
			MessageBox.Show("Not Logged In", "You are not Logged in! Logic error in form", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			MyBase.Close()
		End If
	End Sub
End Class