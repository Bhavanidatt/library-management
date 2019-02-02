Public Class AccountSummaryForm
	Private Sub AccountSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UsernameLabel.Text = GLogin.Username
		NameLabel.Text = GLogin.Fullname
		AccountTypeLabel.Text = GLogin.AccType
		DueLabel.Text = GLogin.Due.ToString
		BooksIssuedLabel.Text = GLogin.BooksIssued.ToString
	End Sub
End Class