Imports MySql.Data.MySqlClient

Public Class SignUpForm

    Dim con As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=root; database=library_management")
    'A SET OF COMMAND IN MYSQL
    Dim cmd As New MySqlCommand
    'SET A CLASS THAT SERVES AS THE BRIDGE BETWEEN A DATASET AND DATABASE FOR SAVING AND RETRIEVING DATA.
    Dim da As New MySqlDataAdapter
    'SET A CLASS THAT CONSISTS SPECIFIC TABLE IN THE DATABASE
    Dim dt As New DataTable
    Dim sqlQuery As String
    Dim result As Integer
    Dim usertype As String
    Dim sex As Char



    Private Sub SignupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignupButton.Click
        sex = "M"
        If PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            MessageBox.Show("Passwords do not match!", "Enter password carefully!")
            Exit Sub
        End If
        sqlQuery = "INSERT INTO user( name,email, pass, sex,status)" &
                    "VALUES ('" & FullnameTextBox.Text & "','" & UsernameTextBox.Text & "','" & PasswordTextBox.Text & "','" & sex & "','" & SelectionTextBox.Text & "')"
        Register(sqlQuery)

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

    Private Sub Register(ByVal sqlQuery As String)
        Try
            'OPENING THE CONNECTION
            con.Open()
            'HOLDS THE DATA TO BE EXECUTED
            With cmd
                .Connection = con
                .CommandText = sqlQuery
            End With
            'EXECUTE THE DATA
            result = cmd.ExecuteNonQuery
            'CHECKING IF THE DATA HAS BEEN EXECUTED OR NOT
            If result > 0 Then
                MsgBox("User has been registered.")
            Else
                MsgBox("Failed to register the user.")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
