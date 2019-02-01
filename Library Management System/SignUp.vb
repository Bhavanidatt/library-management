

Public Class SignUpForm

    Dim sex As Char
    Private Sub SignupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignupButton.Click
        sex = "M"
        If PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            MessageBox.Show("Passwords do not match!", "Enter password carefully!")
            Exit Sub
        End If

        GLogin.sqlQuery = "INSERT INTO user( name,email, pass, sex,status,booksissued,due)" &
                    "VALUES ('" & FullnameTextBox.Text & "','" & UsernameTextBox.Text & "','" & PasswordTextBox.Text & "','" & sex & "','" & SelectionTextBox.Text & "',0,0)"
        GLogin.Register(GLogin.sqlQuery)

        Me.Close()
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub DropDownButton_Click(sender As Object, e As EventArgs) Handles DropDownButton.Click
        DropDown.Show(DropDownButton, -151, 25)
    End Sub

    Private Sub StudentAcc_Click(sender As Object, e As EventArgs) Handles StudentAcc.Click
        SelectionTextBox.Text = "Student"
    End Sub

    Private Sub TeacherAcc_Click(sender As Object, e As EventArgs) Handles TeacherAcc.Click
        SelectionTextBox.Text = "Teacher"
    End Sub

    Private Sub AdminAcc_Click(sender As Object, e As EventArgs) Handles AdminAcc.Click
        SelectionTextBox.Text = "Admin"
    End Sub


End Class
