<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class LoginForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub
	Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
	Friend WithEvents UsernameLabel As System.Windows.Forms.Label
	Friend WithEvents PasswordLabel As System.Windows.Forms.Label
	Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
	Friend WithEvents LoginButton As System.Windows.Forms.Button
	Friend WithEvents CancelButton As System.Windows.Forms.Button

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
		Me.UsernameLabel = New System.Windows.Forms.Label()
		Me.PasswordLabel = New System.Windows.Forms.Label()
		Me.UsernameTextBox = New System.Windows.Forms.TextBox()
		Me.PasswordTextBox = New System.Windows.Forms.TextBox()
		Me.LoginButton = New System.Windows.Forms.Button()
		Me.CancelButton = New System.Windows.Forms.Button()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.Image = Global.Library_Management_System.My.Resources.Resources.logo_medium
		Me.LogoPictureBox.Location = New System.Drawing.Point(5, 10)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(165, 166)
		Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.LogoPictureBox.TabIndex = 0
		Me.LogoPictureBox.TabStop = False
		'
		'UsernameLabel
		'
		Me.UsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.UsernameLabel.Location = New System.Drawing.Point(174, 22)
		Me.UsernameLabel.Name = "UsernameLabel"
		Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
		Me.UsernameLabel.TabIndex = 4
		Me.UsernameLabel.Text = "&User name"
		Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PasswordLabel
		'
		Me.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.PasswordLabel.Location = New System.Drawing.Point(174, 79)
		Me.PasswordLabel.Name = "PasswordLabel"
		Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
		Me.PasswordLabel.TabIndex = 5
		Me.PasswordLabel.Text = "&Password"
		Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'UsernameTextBox
		'
		Me.UsernameTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.UsernameTextBox.Location = New System.Drawing.Point(176, 42)
		Me.UsernameTextBox.Name = "UsernameTextBox"
		Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
		Me.UsernameTextBox.TabIndex = 0
		'
		'PasswordTextBox
		'
		Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PasswordTextBox.Location = New System.Drawing.Point(176, 99)
		Me.PasswordTextBox.Name = "PasswordTextBox"
		Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
		Me.PasswordTextBox.TabIndex = 1
		Me.PasswordTextBox.UseSystemPasswordChar = True
		'
		'LoginButton
		'
		Me.LoginButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LoginButton.Location = New System.Drawing.Point(188, 159)
		Me.LoginButton.Name = "LoginButton"
		Me.LoginButton.Size = New System.Drawing.Size(94, 23)
		Me.LoginButton.TabIndex = 2
		Me.LoginButton.Text = "&Login"
		Me.LoginButton.UseVisualStyleBackColor = False
		'
		'CancelButton
		'
		Me.CancelButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CancelButton.Location = New System.Drawing.Point(288, 159)
		Me.CancelButton.Name = "CancelButton"
		Me.CancelButton.Size = New System.Drawing.Size(94, 23)
		Me.CancelButton.TabIndex = 3
		Me.CancelButton.Text = "&Cancel"
		Me.CancelButton.UseVisualStyleBackColor = False
		'
		'LoginForm
		'
		Me.AcceptButton = Me.LoginButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDark
		Me.ClientSize = New System.Drawing.Size(401, 192)
		Me.Controls.Add(Me.CancelButton)
		Me.Controls.Add(Me.LoginButton)
		Me.Controls.Add(Me.PasswordTextBox)
		Me.Controls.Add(Me.UsernameTextBox)
		Me.Controls.Add(Me.PasswordLabel)
		Me.Controls.Add(Me.UsernameLabel)
		Me.Controls.Add(Me.LogoPictureBox)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "LoginForm"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Please LogIn To Continue"
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
End Class
