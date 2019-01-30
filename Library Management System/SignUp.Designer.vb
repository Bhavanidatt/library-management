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
	Friend WithEvents OK As System.Windows.Forms.Button
	Friend WithEvents Cancel As System.Windows.Forms.Button

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
		Me.UsernameLabel = New System.Windows.Forms.Label()
		Me.PasswordLabel = New System.Windows.Forms.Label()
		Me.UsernameTextBox = New System.Windows.Forms.TextBox()
		Me.PasswordTextBox = New System.Windows.Forms.TextBox()
		Me.OK = New System.Windows.Forms.Button()
		Me.Cancel = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.FullnameTextBox = New System.Windows.Forms.TextBox()
		Me.TeacherRadio = New System.Windows.Forms.RadioButton()
		Me.AdminRadio = New System.Windows.Forms.RadioButton()
		Me.StudentRadio = New System.Windows.Forms.RadioButton()
		Me.Label2 = New System.Windows.Forms.Label()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
		Me.LogoPictureBox.Location = New System.Drawing.Point(1, 30)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(165, 194)
		Me.LogoPictureBox.TabIndex = 0
		Me.LogoPictureBox.TabStop = False
		'
		'UsernameLabel
		'
		Me.UsernameLabel.Location = New System.Drawing.Point(165, 9)
		Me.UsernameLabel.Name = "UsernameLabel"
		Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
		Me.UsernameLabel.TabIndex = 0
		Me.UsernameLabel.Text = "&Username"
		Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PasswordLabel
		'
		Me.PasswordLabel.Location = New System.Drawing.Point(165, 97)
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
		Me.UsernameTextBox.Location = New System.Drawing.Point(168, 30)
		Me.UsernameTextBox.Name = "UsernameTextBox"
		Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
		Me.UsernameTextBox.TabIndex = 1
		'
		'PasswordTextBox
		'
		Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PasswordTextBox.Location = New System.Drawing.Point(168, 118)
		Me.PasswordTextBox.Name = "PasswordTextBox"
		Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
		Me.PasswordTextBox.TabIndex = 3
		'
		'OK
		'
		Me.OK.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.OK.Cursor = System.Windows.Forms.Cursors.Hand
		Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.OK.Location = New System.Drawing.Point(193, 217)
		Me.OK.Name = "OK"
		Me.OK.Size = New System.Drawing.Size(94, 23)
		Me.OK.TabIndex = 5
		Me.OK.Text = "&OK"
		Me.OK.UseVisualStyleBackColor = False
		'
		'Cancel
		'
		Me.Cancel.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Cancel.Location = New System.Drawing.Point(296, 217)
		Me.Cancel.Name = "Cancel"
		Me.Cancel.Size = New System.Drawing.Size(94, 23)
		Me.Cancel.TabIndex = 6
		Me.Cancel.Text = "&Cancel"
		Me.Cancel.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(165, 53)
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
		Me.FullnameTextBox.Location = New System.Drawing.Point(168, 74)
		Me.FullnameTextBox.Name = "FullnameTextBox"
		Me.FullnameTextBox.Size = New System.Drawing.Size(220, 20)
		Me.FullnameTextBox.TabIndex = 2
		'
		'TeacherRadio
		'
		Me.TeacherRadio.AutoSize = True
		Me.TeacherRadio.Cursor = System.Windows.Forms.Cursors.Hand
		Me.TeacherRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.TeacherRadio.Location = New System.Drawing.Point(273, 144)
		Me.TeacherRadio.Name = "TeacherRadio"
		Me.TeacherRadio.Size = New System.Drawing.Size(64, 17)
		Me.TeacherRadio.TabIndex = 4
		Me.TeacherRadio.TabStop = True
		Me.TeacherRadio.Text = "&Teacher"
		Me.TeacherRadio.UseVisualStyleBackColor = True
		'
		'AdminRadio
		'
		Me.AdminRadio.AutoSize = True
		Me.AdminRadio.Cursor = System.Windows.Forms.Cursors.Hand
		Me.AdminRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AdminRadio.Location = New System.Drawing.Point(273, 190)
		Me.AdminRadio.Name = "AdminRadio"
		Me.AdminRadio.Size = New System.Drawing.Size(53, 17)
		Me.AdminRadio.TabIndex = 4
		Me.AdminRadio.TabStop = True
		Me.AdminRadio.Text = "&Admin"
		Me.AdminRadio.UseVisualStyleBackColor = True
		'
		'StudentRadio
		'
		Me.StudentRadio.AutoSize = True
		Me.StudentRadio.Cursor = System.Windows.Forms.Cursors.Hand
		Me.StudentRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.StudentRadio.Location = New System.Drawing.Point(273, 167)
		Me.StudentRadio.Name = "StudentRadio"
		Me.StudentRadio.Size = New System.Drawing.Size(61, 17)
		Me.StudentRadio.TabIndex = 4
		Me.StudentRadio.TabStop = True
		Me.StudentRadio.Text = "&Student"
		Me.StudentRadio.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(209, 164)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(43, 20)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "I'm a"
		'
		'SignUpForm
		'
		Me.AcceptButton = Me.OK
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDark
		Me.CancelButton = Me.Cancel
		Me.ClientSize = New System.Drawing.Size(401, 254)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.AdminRadio)
		Me.Controls.Add(Me.StudentRadio)
		Me.Controls.Add(Me.TeacherRadio)
		Me.Controls.Add(Me.Cancel)
		Me.Controls.Add(Me.OK)
		Me.Controls.Add(Me.PasswordTextBox)
		Me.Controls.Add(Me.FullnameTextBox)
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
	Friend WithEvents TeacherRadio As RadioButton
	Friend WithEvents AdminRadio As RadioButton
	Friend WithEvents StudentRadio As RadioButton
	Friend WithEvents Label2 As Label
End Class
