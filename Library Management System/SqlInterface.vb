Imports MySql.Data.MySqlClient
' I (Avneet) don't have mysql installed. So, Parvindar and Sachin have to do all backend testing.
' Currently, one of the bugs I could find was SQL Injection in password.
' To solve this vulnerability, I am thinking of hashing the password.
' This will also safeguard user pass against thefts.
Public Class SqlInterface

	Public Shared con As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=root; database=library_management")
	'A SET OF COMMAND IN MYSQL
	Public Shared cmd As New MySqlCommand
	'SET A CLASS THAT SERVES AS THE BRIDGE BETWEEN A DATASET AND DATABASE FOR SAVING AND RETRIEVING DATA.
	Public Shared da As New MySqlDataAdapter
	'SET A CLASS THAT CONSISTS SPECIFIC TABLE IN THE DATABASE
	Public Shared dt As New DataTable
	Public Shared result As Integer

	Public Shared Function Login() As Boolean
		' Function will return status of query ( because we may need it in our parent form)
		If GLogin.LoggedIn = True Then
			Return True
		End If
		Try
			con.Open()
			With cmd
				.Connection = con
				.CommandText = "SELECT * FROM user WHERE email ='" & GLogin.Username & "'"
			End With
			'FILLING THE DATA IN A SPICIFIC TABLE OF THE DATABASE
			da.SelectCommand = cmd
			dt = New DataTable
			da.Fill(dt)
			'DECLARING AN INTEGER TO SET THE MAXROWS OF THE TABLE
			Dim maxrow As Integer = dt.Rows.Count
			'CHECKING IF THE DATA IS EXIST IN THE ROW OF THE TABLE
			If maxrow > 0 Then
                'GLogin.LoggedIn = True
                GLogin.Fullname = dt.Rows(0).Item(1).ToString()
				GLogin.PasswordHash = dt.Rows(0).Item(3).ToString()
				GLogin.AccType = dt.Rows(0).Item(4).ToString()
				GLogin.lib_id = Integer.Parse(dt.Rows(0).Item(0).ToString())
				GLogin.BooksIssued = Integer.Parse(dt.Rows(0).Item(5).ToString())
				GLogin.Due = Integer.Parse(dt.Rows(0).Item(6).ToString())
                GLogin.Salt = dt.Rows(0).Item(7).ToString()
            Else
				GLogin.LogOut()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
		con.Close()
        Dim temp As String = CheckOldPassword(GLogin.UnhashedPassword)
        Console.WriteLine(temp)
        Console.WriteLine(GLogin.PasswordHash)
        If temp = GLogin.PasswordHash Then
            GLogin.LoggedIn = True
        Else
            GLogin.LogOut()
		End If
		Return GLogin.LoggedIn
	End Function


	Public Shared Function Register() As Boolean
		' Function will return status of query ( because we may need it in our parent form)
		Try
			'OPENING THE CONNECTION
			con.Open()
			'HOLDS THE DATA TO BE EXECUTED


			cmd.Connection = con
			cmd.CommandText = "INSERT INTO user( name,email, pass,status,booksissued,due, salt)" & "VALUES ('" & GLogin.Fullname & "','" & GLogin.Username & "','" & GLogin.PasswordHash & "','" & GLogin.AccType & "',0,0,'" & GLogin.Salt & "')"

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
		If result > 0 Then
			Return True
		Else
			Return False
		End If
	End Function
End Class
