Public Class GLogin

	Public Shared Username As String = ""
	Public Shared Fullname As String = ""
	Public Shared Password As String = ""
	Public Shared AccType As String = ""
	Public Shared Due As String = ""
	Public Shared BooksIssued As Integer = 0
	'Public Shared ParentForm As String = ""
	Public Shared Sub Reset()
		Username = ""
		Fullname = ""
		Password = ""
		AccType = ""
		Due = ""
		BooksIssued = 0
		'ParentForm = ""
	End Sub
	'Public Shared Due As String = ""
End Class