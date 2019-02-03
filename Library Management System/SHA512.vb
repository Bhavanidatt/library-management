Imports System.Security.Cryptography.SHA512
Module SHA512
	Public Function Encrypt(ByVal StrToHash As String) As String
		Dim SHA512Obj As System.Security.Cryptography.SHA512 = New System.Security.Cryptography.SHA512Managed()

		Dim BytesToHash() As Byte = System.Text.Encoding.UTF8.GetBytes(StrToHash)
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
		BytesToHash = SHA512Obj.ComputeHash(BytesToHash)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value

		Dim EncodedString As String = ""

		For Each ByteWord As Byte In BytesToHash
			EncodedString += ByteWord.ToString("x2")
		Next
		Return EncodedString
	End Function
End Module
