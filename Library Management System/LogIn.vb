Imports MySql.Data.MySqlClient

Public Class LoginForm
    ' Dim con As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=root; database=library_management")
    ' 'A SET OF COMMAND IN MYSQL
    ' Dim cmd As New MySqlCommand
    ' 'SET A CLASS THAT SERVES AS THE BRIDGE BETWEEN A DATASET AND DATABASE FOR SAVING AND RETRIEVING DATA.
    ' Dim da As New MySqlDataAdapter
    ' 'SET A CLASS THAT CONSISTS SPECIFIC TABLE IN THE DATABASE
    ' Dim dt As New DataTable
    ' Dim sqlQuery As String
    ' Dim result As Integer
    ' Dim logined As Boolean = False


    ' Private Sub login(ByVal sqlQuery As String)
    '     Try
    '         con.Open()
    '         With cmd
    '             .Connection = con
    '             .CommandText = sqlQuery
    '         End With
    '         'FILLING THE DATA IN A SPICIFIC TABLE OF THE DATABASE
    '         da.SelectCommand = cmd
    '         dt = New DataTable
    '         da.Fill(dt)
    '         'DECLARING AN INTEGER TO SET THE MAXROWS OF THE TABLE
    '         Dim maxrow As Integer = dt.Rows.Count
    '         'CHECKING IF THE DATA IS EXIST IN THE ROW OF THE TABLE
    '         If maxrow > 0 Then
    '             MsgBox("Welcome " & dt.Rows(0).Item(1))
    '             logined = True
    '         Else
    '             MsgBox("Account does not exist.")
    '         End If
    '     Catch ex As Exception
    '         MsgBox(ex.Message)
    '     End Try
    '     con.Close()
    ' End Sub

    ' Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
    '     sqlQuery = "SELECT * FROM user WHERE email ='" & UsernameTextBox.Text & "' AND pass = '" & PasswordTextBox.Text & "'"
    '     login(sqlQuery)

	Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
		If GLogin.Username <> "" Then
			Return
		End If

		If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
			MessageBox.Show("Empty Inputs Found", "Username/Password fields can not be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If
		For Each C As Char In UsernameTextBox.Text
			If AscW(C) >= AscW("a") AndAlso AscW("z") >= AscW(C) Then
				Continue For
			ElseIf AscW(C) >= AscW("Z") AndAlso AscW("Z") >= AscW(C) Then
				Continue For
			ElseIf AscW(C) >= AscW("0") AndAlso AscW("9") >= AscW(C) Then
				Continue For
			ElseIf AscW(C) = AscW("_") Then
				Continue For
			Else
				MessageBox.Show("Invalid Characters in Username", "Use only alphanumerics or underscores( _ )", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		Next
		' TODO: Validate User Here
		' ValidateLogin()
		Dim ValidationSuccess As Boolean = True
		If ValidationSuccess = True Then
			' TODO: Get these values from db
			GLogin.Username = "Avneet"
			GLogin.Fullname = "Avneet Singh Channa"
			GLogin.Password = "Not So Secure Password"
			GLogin.AccType = "Admin"
			GLogin.BooksIssued = 0
			Me.Close()
			Return
		End If
	End Sub

	Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
		GLogin.Reset()
		Me.Close()
	End Sub
End Class

