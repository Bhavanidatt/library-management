<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class EditProfileForm
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.UsernameTextBox = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.FullnameTextBox = New System.Windows.Forms.TextBox()
		Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
		Me.ConfirmPasswordTextPassword = New System.Windows.Forms.TextBox()
		Me.EditProfileButton = New System.Windows.Forms.Button()
		Me.CancelButton = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.DropDownButton = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.ChangePasswordButton = New System.Windows.Forms.Button()
		Me.OldPasswordTextBox = New System.Windows.Forms.TextBox()
		Me.DropDown = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.StudentAcc = New System.Windows.Forms.ToolStripMenuItem()
		Me.TeacherAcc = New System.Windows.Forms.ToolStripMenuItem()
		Me.AdminAcc = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.DropDown.SuspendLayout()
		Me.SuspendLayout()
		'
		'UsernameTextBox
		'
		Me.UsernameTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.UsernameTextBox.Location = New System.Drawing.Point(65, 47)
		Me.UsernameTextBox.Name = "UsernameTextBox"
		Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
		Me.UsernameTextBox.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(65, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(220, 23)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "&Username"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(65, 71)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(220, 23)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "&Full Name"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(65, 72)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(220, 23)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "&New Password"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(65, 127)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(220, 23)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "&Retype New Password"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'FullnameTextBox
		'
		Me.FullnameTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.FullnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.FullnameTextBox.Location = New System.Drawing.Point(65, 101)
		Me.FullnameTextBox.Name = "FullnameTextBox"
		Me.FullnameTextBox.Size = New System.Drawing.Size(220, 20)
		Me.FullnameTextBox.TabIndex = 1
		'
		'NewPasswordTextBox
		'
		Me.NewPasswordTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.NewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.NewPasswordTextBox.Location = New System.Drawing.Point(65, 99)
		Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
		Me.NewPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.NewPasswordTextBox.Size = New System.Drawing.Size(220, 20)
		Me.NewPasswordTextBox.TabIndex = 2
		Me.NewPasswordTextBox.UseSystemPasswordChar = True
		'
		'ConfirmPasswordTextPassword
		'
		Me.ConfirmPasswordTextPassword.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.ConfirmPasswordTextPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ConfirmPasswordTextPassword.Location = New System.Drawing.Point(65, 150)
		Me.ConfirmPasswordTextPassword.Name = "ConfirmPasswordTextPassword"
		Me.ConfirmPasswordTextPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.ConfirmPasswordTextPassword.Size = New System.Drawing.Size(220, 20)
		Me.ConfirmPasswordTextPassword.TabIndex = 3
		Me.ConfirmPasswordTextPassword.UseSystemPasswordChar = True
		'
		'EditProfileButton
		'
		Me.EditProfileButton.AutoSize = True
		Me.EditProfileButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.EditProfileButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.EditProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.EditProfileButton.Location = New System.Drawing.Point(123, 176)
		Me.EditProfileButton.Name = "EditProfileButton"
		Me.EditProfileButton.Size = New System.Drawing.Size(105, 25)
		Me.EditProfileButton.TabIndex = 5
		Me.EditProfileButton.Text = "&Edit Profile"
		Me.EditProfileButton.UseVisualStyleBackColor = False
		'
		'CancelButton
		'
		Me.CancelButton.AutoSize = True
		Me.CancelButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CancelButton.Location = New System.Drawing.Point(183, 494)
		Me.CancelButton.Name = "CancelButton"
		Me.CancelButton.Size = New System.Drawing.Size(94, 25)
		Me.CancelButton.TabIndex = 6
		Me.CancelButton.Text = "&Go Back"
		Me.CancelButton.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(64, 143)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(30, 20)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "I'm"
		'
		'DropDownButton
		'
		Me.DropDownButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.DropDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DropDownButton.Location = New System.Drawing.Point(97, 141)
		Me.DropDownButton.Margin = New System.Windows.Forms.Padding(0)
		Me.DropDownButton.Name = "DropDownButton"
		Me.DropDownButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DropDownButton.Size = New System.Drawing.Size(182, 24)
		Me.DropDownButton.TabIndex = 4
		Me.DropDownButton.Text = "AccType"
		Me.DropDownButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.DropDownButton.UseVisualStyleBackColor = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.DropDownButton)
		Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
		Me.GroupBox1.Controls.Add(Me.EditProfileButton)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.FullnameTextBox)
		Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBox1.Location = New System.Drawing.Point(55, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(350, 219)
		Me.GroupBox1.TabIndex = 13
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Profile"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.ChangePasswordButton)
		Me.GroupBox2.Controls.Add(Me.ConfirmPasswordTextPassword)
		Me.GroupBox2.Controls.Add(Me.OldPasswordTextBox)
		Me.GroupBox2.Controls.Add(Me.NewPasswordTextBox)
		Me.GroupBox2.Location = New System.Drawing.Point(55, 266)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(350, 222)
		Me.GroupBox2.TabIndex = 14
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Password"
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(65, 18)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(220, 23)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "&Old Password"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ChangePasswordButton
		'
		Me.ChangePasswordButton.AutoSize = True
		Me.ChangePasswordButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.ChangePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ChangePasswordButton.Location = New System.Drawing.Point(123, 179)
		Me.ChangePasswordButton.Name = "ChangePasswordButton"
		Me.ChangePasswordButton.Size = New System.Drawing.Size(105, 25)
		Me.ChangePasswordButton.TabIndex = 5
		Me.ChangePasswordButton.Text = "&Change Password"
		Me.ChangePasswordButton.UseVisualStyleBackColor = False
		'
		'OldPasswordTextBox
		'
		Me.OldPasswordTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.OldPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.OldPasswordTextBox.Location = New System.Drawing.Point(65, 45)
		Me.OldPasswordTextBox.Name = "OldPasswordTextBox"
		Me.OldPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.OldPasswordTextBox.Size = New System.Drawing.Size(220, 20)
		Me.OldPasswordTextBox.TabIndex = 2
		Me.OldPasswordTextBox.UseSystemPasswordChar = True
		'
		'DropDown
		'
		Me.DropDown.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.DropDown.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentAcc, Me.TeacherAcc, Me.AdminAcc})
		Me.DropDown.Name = "ContextMenuStrip1"
		Me.DropDown.Size = New System.Drawing.Size(116, 70)
		'
		'StudentAcc
		'
		Me.StudentAcc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.StudentAcc.Name = "StudentAcc"
		Me.StudentAcc.Size = New System.Drawing.Size(180, 22)
		Me.StudentAcc.Text = "&Student"
		'
		'TeacherAcc
		'
		Me.TeacherAcc.Name = "TeacherAcc"
		Me.TeacherAcc.Size = New System.Drawing.Size(180, 22)
		Me.TeacherAcc.Text = "&Teacher"
		'
		'AdminAcc
		'
		Me.AdminAcc.Name = "AdminAcc"
		Me.AdminAcc.Size = New System.Drawing.Size(180, 22)
		Me.AdminAcc.Text = "&Admin"
		'
		'EditProfileForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.ClientSize = New System.Drawing.Size(460, 526)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.CancelButton)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "EditProfileForm"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "EditProfile"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.DropDown.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents UsernameTextBox As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents FullnameTextBox As TextBox
	Friend WithEvents NewPasswordTextBox As TextBox
	Friend WithEvents ConfirmPasswordTextPassword As TextBox
	Friend WithEvents CancelButton As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents DropDownButton As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label6 As Label
	Friend WithEvents ChangePasswordButton As Button
	Friend WithEvents OldPasswordTextBox As TextBox
	Private WithEvents EditProfileButton As Button
	Friend WithEvents DropDown As ContextMenuStrip
	Friend WithEvents StudentAcc As ToolStripMenuItem
	Friend WithEvents TeacherAcc As ToolStripMenuItem
	Friend WithEvents AdminAcc As ToolStripMenuItem
End Class
