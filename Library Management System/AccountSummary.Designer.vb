<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountSummaryForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.AccountTypeLabel = New System.Windows.Forms.Label()
        Me.DueLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BooksIssuedLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Type Of Account"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 29)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Due (If Any)"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 189)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "View Issued Books"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(278, 189)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 49)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit Profile"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(438, 189)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 49)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Issue History"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(260, 23)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(351, 31)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "UsernameLabel"
        '
        'AccountTypeLabel
        '
        Me.AccountTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountTypeLabel.Location = New System.Drawing.Point(260, 85)
        Me.AccountTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AccountTypeLabel.Name = "AccountTypeLabel"
        Me.AccountTypeLabel.Size = New System.Drawing.Size(351, 31)
        Me.AccountTypeLabel.TabIndex = 8
        Me.AccountTypeLabel.Text = "AccType"
        '
        'DueLabel
        '
        Me.DueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueLabel.Location = New System.Drawing.Point(260, 115)
        Me.DueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DueLabel.Name = "DueLabel"
        Me.DueLabel.Size = New System.Drawing.Size(351, 31)
        Me.DueLabel.TabIndex = 10
        Me.DueLabel.Text = "DueLabel"
        '
        'NameLabel
        '
        Me.NameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(260, 54)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(351, 31)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "NameLabel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Books Issued"
        '
        'BooksIssuedLabel
        '
        Me.BooksIssuedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BooksIssuedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BooksIssuedLabel.Location = New System.Drawing.Point(260, 146)
        Me.BooksIssuedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BooksIssuedLabel.Name = "BooksIssuedLabel"
        Me.BooksIssuedLabel.Size = New System.Drawing.Size(351, 31)
        Me.BooksIssuedLabel.TabIndex = 13
        Me.BooksIssuedLabel.Text = "BooksIssuedLabel"
        '
        'AccountSummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(634, 263)
        Me.Controls.Add(Me.BooksIssuedLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.DueLabel)
        Me.Controls.Add(Me.AccountTypeLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AccountSummaryForm"
        Me.Text = "Account Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents UsernameLabel As Label
	Friend WithEvents AccountTypeLabel As Label
	Friend WithEvents DueLabel As Label
	Friend WithEvents NameLabel As Label
    Friend WithEvents Label5 As Label
	Friend WithEvents BooksIssuedLabel As Label
End Class
