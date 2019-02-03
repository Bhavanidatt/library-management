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
End Class
