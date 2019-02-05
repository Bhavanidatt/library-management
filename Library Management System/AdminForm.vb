Public Class AdminForm
	Private Sub AccountSummaryButton_Click(sender As Object, e As EventArgs) Handles AccountSummaryButton.Click
		AccountSummaryForm.Show()
		Me.Hide()
	End Sub
End Class