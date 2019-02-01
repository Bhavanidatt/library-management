Imports MySql.Data.MySqlClient
Public Class GLogin

    Public Shared con As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=root; database=library_management")
    'A SET OF COMMAND IN MYSQL
    Public Shared cmd As New MySqlCommand
    'SET A CLASS THAT SERVES AS THE BRIDGE BETWEEN A DATASET AND DATABASE FOR SAVING AND RETRIEVING DATA.
    Public Shared da As New MySqlDataAdapter
    'SET A CLASS THAT CONSISTS SPECIFIC TABLE IN THE DATABASE
    Public Shared dt As New DataTable
    Public Shared sqlQuery As String
    Public Shared result As Integer
    Public Shared logined As Boolean = False




    Public Shared Username As String = ""
    Public Shared Fullname As String = ""
    Public Shared Password As String = ""
    Public Shared AccType As String = ""
    Public Shared Due As Decimal = 0
    Public Shared BooksIssued As Integer = 0
    Public Shared sex As Char = ""
    Public Shared dob As String = ""
    Public Shared lib_id As Integer = Nothing
    'Public Shared ParentForm As String = ""
    Public Shared Sub Reset()
        Username = ""
        Fullname = ""
        Password = ""
        AccType = ""
        Due = 0
        BooksIssued = 0
        dob = ""
        lib_id = Nothing
        sex = Nothing


        'ParentForm = ""
    End Sub



    'Public Shared Due As String = ""


    Public Shared Sub login(ByVal sqlQuery As String)
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
                MsgBox("Welcome " & dt.Rows(0).Item(1).ToString())
                logined = True
                Username = dt.Rows(0).Item(2).ToString()
                Fullname = dt.Rows(0).Item(1).ToString()
                Password = dt.Rows(0).Item(3).ToString()
                AccType = dt.Rows(0).Item(6).ToString()
                sex = Char.Parse(dt.Rows(0).Item(5).ToString())
                dob = dt.Rows(0).Item(4).ToString()
                lib_id = Integer.Parse(dt.Rows(0).Item(0).ToString())
                BooksIssued = Integer.Parse(dt.Rows(0).Item(7).ToString())
                Due = Decimal.Parse(dt.Rows(0).Item(8).ToString())

            Else
                MsgBox("Account does not exist.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub


    Public Shared Sub Register(ByVal sqlQuery As String)
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