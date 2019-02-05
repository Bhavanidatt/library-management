'Imports System.Security.Cryptography.SHA512

' This class can never see password
Module SHA512
	Public Function Encrypt_Sha512(ByVal StrToHash As String) As String
		Dim SHA512Obj As System.Security.Cryptography.SHA512 = New System.Security.Cryptography.SHA512Managed()

		Dim BytesToHash() As Byte = System.Text.Encoding.UTF8.GetBytes(StrToHash)
		BytesToHash = SHA512Obj.ComputeHash(BytesToHash)

		Dim EncodedString As String = ""

		For Each ByteWord As Byte In BytesToHash
			EncodedString += ByteWord.ToString("x2")
		Next
		Return EncodedString
	End Function

	Public Function EncryptNewPassword(ByVal PasswordHash As String) As String
		Dim Charset As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMOPQRSTUVWXYZ0123456789+-"
		Dim Chars() As Char = Charset.ToCharArray
		Dim bytes() As Byte
		ReDim bytes(10)
		Dim RNGObj As Security.Cryptography.RNGCryptoServiceProvider = New Security.Cryptography.RNGCryptoServiceProvider()
		RNGObj.GetBytes(bytes)
		For Each b As Byte In bytes
			GLogin.Salt = GLogin.Salt + Chars.ElementAt(b Mod 64).ToString
		Next
        Return Encrypt_Sha512(GLogin.Salt + PasswordHash + "d5eba9b008f69bd56e")
    End Function

	Public Function CheckOldPassword(ByVal PasswordHash As String) As String
		If GLogin.LoggedIn = True Then
			MessageBox.Show("Already logged in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return ""
		End If
		If GLogin.Salt = "" Then
			MessageBox.Show("Salt not generated ealier. Maybe there is error in sql query", "Salt not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return ""
		End If
		Return Encrypt_Sha512(GLogin.Salt + PasswordHash + "d5eba9b008f69bd56e")
	End Function

End Module
