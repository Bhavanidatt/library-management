<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class SignUpForm
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
	Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
	Friend WithEvents UsernameLabel As System.Windows.Forms.Label
	Friend WithEvents PasswordLabel As System.Windows.Forms.Label
	Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
	Friend WithEvents Signup As System.Windows.Forms.Button
	Friend WithEvents Cancel As System.Windows.Forms.Button

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
		Me.UsernameLabel = New System.Windows.Forms.Label()
		Me.PasswordLabel = New System.Windows.Forms.Label()
		Me.UsernameTextBox = New System.Windows.Forms.TextBox()
		Me.PasswordTextBox = New System.Windows.Forms.TextBox()
		Me.Signup = New System.Windows.Forms.Button()
		Me.Cancel = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.FullnameTextBox = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TeacherRadio = New System.Windows.Forms.RadioButton()
		Me.StudentRadio = New System.Windows.Forms.RadioButton()
		Me.AdminRadio = New System.Windows.Forms.RadioButton()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.Image = Global.Library_Management_System.My.Resources.Resources.logo_medium
		Me.LogoPictureBox.Location = New System.Drawing.Point(2, 45)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(162, 165)
		Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.LogoPictureBox.TabIndex = 0
		Me.LogoPictureBox.TabStop = False
		'
		'UsernameLabel
		'
		Me.UsernameLabel.Location = New System.Drawing.Point(165, 11)
		Me.UsernameLabel.Name = "UsernameLabel"
		Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
		Me.UsernameLabel.TabIndex = 0
		Me.UsernameLabel.Text = "&Username"
		Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PasswordLabel
		'
		Me.PasswordLabel.Location = New System.Drawing.Point(165, 99)
		Me.PasswordLabel.Name = "PasswordLabel"
		Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
		Me.PasswordLabel.TabIndex = 2
		Me.PasswordLabel.Text = "&Password"
		Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'UsernameTextBox
		'
		Me.UsernameTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.UsernameTextBox.Location = New System.Drawing.Point(168, 32)
		Me.UsernameTextBox.Name = "UsernameTextBox"
		Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
		Me.UsernameTextBox.TabIndex = 1
		'
		'PasswordTextBox
		'
		Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PasswordTextBox.Location = New System.Drawing.Point(168, 120)
		Me.PasswordTextBox.Name = "PasswordTextBox"
		Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
		Me.PasswordTextBox.TabIndex = 3
		'
		'Signup
		'
		Me.Signup.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Signup.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Signup.Location = New System.Drawing.Point(185, 221)
		Me.Signup.Name = "Signup"
		Me.Signup.Size = New System.Drawing.Size(94, 23)
		Me.Signup.TabIndex = 6
		Me.Signup.Text = "&Signup"
		Me.Signup.UseVisualStyleBackColor = False
		'
		'Cancel
		'
		Me.Cancel.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Cancel.Location = New System.Drawing.Point(285, 221)
		Me.Cancel.Name = "Cancel"
		Me.Cancel.Size = New System.Drawing.Size(94, 23)
		Me.Cancel.TabIndex = 7
		Me.Cancel.Text = "&Cancel"
		Me.Cancel.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(165, 55)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(220, 23)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "&Full Name"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'FullnameTextBox
		'
		Me.FullnameTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.FullnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.FullnameTextBox.Location = New System.Drawing.Point(168, 76)
		Me.FullnameTextBox.Name = "FullnameTextBox"
		Me.FullnameTextBox.Size = New System.Drawing.Size(220, 20)
		Me.FullnameTextBox.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(172, 198)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(25, 16)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "I'm"
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(165, 143)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(220, 23)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "&Confirm Password"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox1.Location = New System.Drawing.Point(168, 164)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBox1.Size = New System.Drawing.Size(220, 20)
		Me.TextBox1.TabIndex = 4
		'
		'TeacherRadio
		'
		Me.TeacherRadio.AutoSize = True
		Me.TeacherRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.TeacherRadio.Location = New System.Drawing.Point(200, 198)
		Me.TeacherRadio.Name = "TeacherRadio"
		Me.TeacherRadio.Size = New System.Drawing.Size(64, 17)
		Me.TeacherRadio.TabIndex = 8
		Me.TeacherRadio.TabStop = True
		Me.TeacherRadio.Text = "&Teacher"
		Me.TeacherRadio.UseVisualStyleBackColor = True
		'
		'StudentRadio
		'
		Me.StudentRadio.AutoSize = True
		Me.StudentRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.StudentRadio.Location = New System.Drawing.Point(271, 198)
		Me.StudentRadio.Name = "StudentRadio"
		Me.StudentRadio.Size = New System.Drawing.Size(61, 17)
		Me.StudentRadio.TabIndex = 8
		Me.StudentRadio.TabStop = True
		Me.StudentRadio.Text = "&Student"
		Me.StudentRadio.UseVisualStyleBackColor = True
		'
		'AdminRadio
		'
		Me.AdminRadio.AutoSize = True
		Me.AdminRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AdminRadio.Location = New System.Drawing.Point(334, 198)
		Me.AdminRadio.Name = "AdminRadio"
		Me.AdminRadio.Size = New System.Drawing.Size(53, 17)
		Me.AdminRadio.TabIndex = 8
		Me.AdminRadio.TabStop = True
		Me.AdminRadio.Text = "&Admin"
		Me.AdminRadio.UseVisualStyleBackColor = True
		'
		'SignUpForm
		'
		Me.AcceptButton = Me.Signup
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDark
		Me.CancelButton = Me.Cancel
		Me.ClientSize = New System.Drawing.Size(401, 254)
		Me.Controls.Add(Me.AdminRadio)
		Me.Controls.Add(Me.StudentRadio)
		Me.Controls.Add(Me.TeacherRadio)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Cancel)
		Me.Controls.Add(Me.Signup)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.PasswordTextBox)
		Me.Controls.Add(Me.FullnameTextBox)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.UsernameTextBox)
		Me.Controls.Add(Me.PasswordLabel)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.UsernameLabel)
		Me.Controls.Add(Me.LogoPictureBox)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "SignUpForm"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Please Enter The Following Info"
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents FullnameTextBox As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TeacherRadio As RadioButton
	Friend WithEvents StudentRadio As RadioButton
	Friend WithEvents AdminRadio As RadioButton
End Class
