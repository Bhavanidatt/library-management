Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim con As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=root; database=library_management")
    'A SET OF COMMAND IN MYSQL
    Dim cmd As New MySqlCommand
    'SET A CLASS THAT SERVES AS THE BRIDGE BETWEEN A DATASET AND DATABASE FOR SAVING AND RETRIEVING DATA.
    Dim da As New MySqlDataAdapter
    'SET A CLASS THAT CONSISTS SPECIFIC TABLE IN THE DATABASE
    Dim dt As New DataTable
    Dim sqlQuery As String
    Dim result As Integer
    Dim logined As Boolean = False

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.



    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub


    Private Sub login(ByVal sqlQuery As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sqlQuery
            End With
            'FILLING THE DATA IN A SPICIFIC TABLE OF THE DATABASE
            da.SelectCommand = cmd
            dt = New DataTable
            da.Fill(dt)
            'DECLARING AN INTEGER TO SET THE MAXROWS OF THE TABLE
            Dim maxrow As Integer = dt.Rows.Count
            'CHECKING IF THE DATA IS EXIST IN THE ROW OF THE TABLE
            If maxrow > 0 Then
                MsgBox("Welcome " & dt.Rows(0).Item(1))
                logined = True
            Else
                MsgBox("Account does not exist.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        sqlQuery = "SELECT * FROM user WHERE email ='" & UsernameTextBox.Text & "' AND pass = '" & PasswordTextBox.Text & "'"
        login(sqlQuery)

        Me.Close()

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
End Class
