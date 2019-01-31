<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.SearchBooksButton = New System.Windows.Forms.Button()
		Me.BrowseBooksButton = New System.Windows.Forms.Button()
		Me.IssueBookButton = New System.Windows.Forms.Button()
		Me.ReturnBookButton = New System.Windows.Forms.Button()
		Me.AccountSummaryButton = New System.Windows.Forms.Button()
		Me.LogoutButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'SearchBooksButton
		'
		Me.SearchBooksButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SearchBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.SearchBooksButton.Location = New System.Drawing.Point(10, 12)
		Me.SearchBooksButton.Name = "SearchBooksButton"
		Me.SearchBooksButton.Size = New System.Drawing.Size(127, 23)
		Me.SearchBooksButton.TabIndex = 0
		Me.SearchBooksButton.Text = "&Search Books"
		Me.SearchBooksButton.UseVisualStyleBackColor = False
		'
		'BrowseBooksButton
		'
		Me.BrowseBooksButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.BrowseBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BrowseBooksButton.Location = New System.Drawing.Point(10, 41)
		Me.BrowseBooksButton.Name = "BrowseBooksButton"
		Me.BrowseBooksButton.Size = New System.Drawing.Size(127, 23)
		Me.BrowseBooksButton.TabIndex = 2
		Me.BrowseBooksButton.Text = "&Browse Books"
		Me.BrowseBooksButton.UseVisualStyleBackColor = False
		'
		'IssueBookButton
		'
		Me.IssueBookButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.IssueBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.IssueBookButton.Location = New System.Drawing.Point(143, 12)
		Me.IssueBookButton.Name = "IssueBookButton"
		Me.IssueBookButton.Size = New System.Drawing.Size(127, 23)
		Me.IssueBookButton.TabIndex = 1
		Me.IssueBookButton.Text = "&Issue Book"
		Me.IssueBookButton.UseVisualStyleBackColor = False
		'
		'ReturnBookButton
		'
		Me.ReturnBookButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.ReturnBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ReturnBookButton.Location = New System.Drawing.Point(144, 41)
		Me.ReturnBookButton.Name = "ReturnBookButton"
		Me.ReturnBookButton.Size = New System.Drawing.Size(127, 23)
		Me.ReturnBookButton.TabIndex = 3
		Me.ReturnBookButton.Text = "&Return Books"
		Me.ReturnBookButton.UseVisualStyleBackColor = False
		'
		'AccountSummaryButton
		'
		Me.AccountSummaryButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.AccountSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AccountSummaryButton.Location = New System.Drawing.Point(10, 70)
		Me.AccountSummaryButton.Name = "AccountSummaryButton"
		Me.AccountSummaryButton.Size = New System.Drawing.Size(127, 23)
		Me.AccountSummaryButton.TabIndex = 4
		Me.AccountSummaryButton.Text = "&Account Summary"
		Me.AccountSummaryButton.UseVisualStyleBackColor = False
		'
		'LogoutButton
		'
		Me.LogoutButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LogoutButton.Location = New System.Drawing.Point(144, 70)
		Me.LogoutButton.Name = "LogoutButton"
		Me.LogoutButton.Size = New System.Drawing.Size(127, 23)
		Me.LogoutButton.TabIndex = 5
		Me.LogoutButton.Text = "&Logout"
		Me.LogoutButton.UseVisualStyleBackColor = False
		'
		'UserForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.ClientSize = New System.Drawing.Size(280, 105)
		Me.Controls.Add(Me.LogoutButton)
		Me.Controls.Add(Me.AccountSummaryButton)
		Me.Controls.Add(Me.ReturnBookButton)
		Me.Controls.Add(Me.IssueBookButton)
		Me.Controls.Add(Me.BrowseBooksButton)
		Me.Controls.Add(Me.SearchBooksButton)
		Me.Name = "UserForm"
		Me.Text = "User Options"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents SearchBooksButton As Button
	Friend WithEvents BrowseBooksButton As Button
	Friend WithEvents IssueBookButton As Button
	Friend WithEvents ReturnBookButton As Button
	Friend WithEvents AccountSummaryButton As Button
	Friend WithEvents LogoutButton As Button
End Class
