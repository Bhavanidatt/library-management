Public Class AccountSummaryForm
	Private Sub AccountSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UsernameLabel.Text = GLogin.Username
	End Sub
End Class