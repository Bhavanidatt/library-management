Public Class GLogin

	Public Shared Username As String = ""
	Public Shared Fullname As String = ""
	Public Shared Password As String = ""
	Public Shared AccType As String = ""
	Public Shared Due As Integer = 0
	Public Shared BooksIssued As Integer = 0
	Public Shared lib_id As Integer = 0
	Public Shared LoggedIn As Boolean = False
	'Public Shared ParentForm As String = ""
	Public Shared Sub LogOut()
		Username = ""
		Fullname = ""
		Password = ""
		AccType = ""
		Due = 0
		BooksIssued = 0
		lib_id = 0
		LoggedIn = False
		'ParentForm = ""
	End Sub
End Class