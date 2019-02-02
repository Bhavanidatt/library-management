Imports MySql.Data.MySqlClient
Public Class SqlInterface

	Public Shared con As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=root; database=library_management")
	'A SET OF COMMAND IN MYSQL
	Public Shared cmd As New MySqlCommand
	'SET A CLASS THAT SERVES AS THE BRIDGE BETWEEN A DATASET AND DATABASE FOR SAVING AND RETRIEVING DATA.
	Public Shared da As New MySqlDataAdapter
	'SET A CLASS THAT CONSISTS SPECIFIC TABLE IN THE DATABASE
	Public Shared dt As New DataTable
	Public Shared result As Integer
	Public Shared LoggedIn As Boolean = False

	Public Shared Sub Login()
		Try
			con.Open()
			With cmd
				.Connection = con
				.CommandText = "SELECT * FROM user WHERE email ='" & GLogin.Username & "' AND pass = '" & GLogin.Password & "'"
			End With
			'FILLING THE DATA IN A SPICIFIC TABLE OF THE DATABASE
			da.SelectCommand = cmd
			dt = New DataTable
			da.Fill(dt)
			'DECLARING AN INTEGER TO SET THE MAXROWS OF THE TABLE
			Dim maxrow As Integer = dt.Rows.Count
			'CHECKING IF THE DATA IS EXIST IN THE ROW OF THE TABLE
			If maxrow > 0 Then
				MsgBox("Welcome " & dt.Rows(0).Item(1).ToString())
				LoggedIn = True
				GLogin.Fullname = dt.Rows(0).Item(1).ToString()
				GLogin.AccType = dt.Rows(0).Item(6).ToString()
				GLogin.lib_id = Integer.Parse(dt.Rows(0).Item(0).ToString())
				GLogin.BooksIssued = Integer.Parse(dt.Rows(0).Item(7).ToString())
				GLogin.Due = Integer.Parse(dt.Rows(0).Item(8).ToString())

				'''''''''''''''''''''''''''''''' Do not edit form controls directly.''''''''''''''''''''''''''''''
				'''''''''''''''''' Use GLogin to send info and do things inside form_load functions ''''''''''''''
				'''''' Removed sqlQuery string, we do not need it because we are sending params using glogin '''
				''''''' Use the same idea in register '''''''
				'AccountSummaryForm.UsernameLabel.Text = Username
				'AccountSummaryForm.NameLabel.Text = Fullname
				'AccountSummaryForm.AccountTypeLabel.Text = AccType
				'AccountSummaryForm.DueLabel.Text = Due.ToString()
				'AccountSummaryForm.BooksIssuedLabel.Text = BooksIssued.ToString()

			Else
				MsgBox("Account does not exist.")
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
		con.Close()
	End Sub


	Public Shared Sub Register()
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
