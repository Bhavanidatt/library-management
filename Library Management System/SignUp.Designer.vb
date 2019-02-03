<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class SignUpForm
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
		Me.DropDown = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.StudentAcc = New System.Windows.Forms.ToolStripMenuItem()
		Me.TeacherAcc = New System.Windows.Forms.ToolStripMenuItem()
		Me.AdminAcc = New System.Windows.Forms.ToolStripMenuItem()
		Me.DropDownButton = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.CancelBtn = New System.Windows.Forms.Button()
		Me.SignupButton = New System.Windows.Forms.Button()
		Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
		Me.PasswordTextBox = New System.Windows.Forms.TextBox()
		Me.FullnameTextBox = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.UsernameTextBox = New System.Windows.Forms.TextBox()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.DropDown.SuspendLayout()
		Me.SuspendLayout()
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.Image = Global.Library_Management_System.My.Resources.Resources.logo_medium
		Me.LogoPictureBox.Location = New System.Drawing.Point(7, 45)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(162, 165)
		Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.LogoPictureBox.TabIndex = 0
		Me.LogoPictureBox.TabStop = False
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
		Me.StudentAcc.Size = New System.Drawing.Size(115, 22)
		Me.StudentAcc.Text = "&Student"
		'
		'TeacherAcc
		'
		Me.TeacherAcc.Name = "TeacherAcc"
		Me.TeacherAcc.Size = New System.Drawing.Size(115, 22)
		Me.TeacherAcc.Text = "&Teacher"
		'
		'AdminAcc
		'
		Me.AdminAcc.Name = "AdminAcc"
		Me.AdminAcc.Size = New System.Drawing.Size(115, 22)
		Me.AdminAcc.Text = "&Admin"
		'
		'DropDownButton
		'
		Me.DropDownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.DropDownButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.DropDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DropDownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DropDownButton.Location = New System.Drawing.Point(290, 187)
		Me.DropDownButton.Margin = New System.Windows.Forms.Padding(0)
		Me.DropDownButton.Name = "DropDownButton"
		Me.DropDownButton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DropDownButton.Size = New System.Drawing.Size(100, 29)
		Me.DropDownButton.TabIndex = 4
		Me.DropDownButton.Text = "Student"
		Me.DropDownButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.DropDownButton.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(179, 190)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(106, 20)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "Account Type"
		'
		'CancelBtn
		'
		Me.CancelBtn.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CancelBtn.Location = New System.Drawing.Point(290, 221)
		Me.CancelBtn.Name = "CancelBtn"
		Me.CancelBtn.Size = New System.Drawing.Size(94, 23)
		Me.CancelBtn.TabIndex = 6
		Me.CancelBtn.Text = "&Cancel"
		Me.CancelBtn.UseVisualStyleBackColor = False
		'
		'SignupButton
		'
		Me.SignupButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SignupButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.SignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.SignupButton.Location = New System.Drawing.Point(190, 221)
		Me.SignupButton.Name = "SignupButton"
		Me.SignupButton.Size = New System.Drawing.Size(94, 23)
		Me.SignupButton.TabIndex = 5
		Me.SignupButton.Text = "&Signup"
		Me.SignupButton.UseVisualStyleBackColor = False
		'
		'ConfirmPasswordTextBox
		'
		Me.ConfirmPasswordTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(173, 164)
		Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
		Me.ConfirmPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(220, 20)
		Me.ConfirmPasswordTextBox.TabIndex = 3
		Me.ConfirmPasswordTextBox.UseSystemPasswordChar = True
		'
		'PasswordTextBox
		'
		Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PasswordTextBox.Location = New System.Drawing.Point(173, 120)
		Me.PasswordTextBox.Name = "PasswordTextBox"
		Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
		Me.PasswordTextBox.TabIndex = 2
		Me.PasswordTextBox.UseSystemPasswordChar = True
		'
		'FullnameTextBox
		'
		Me.FullnameTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.FullnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.FullnameTextBox.Location = New System.Drawing.Point(173, 76)
		Me.FullnameTextBox.Name = "FullnameTextBox"
		Me.FullnameTextBox.Size = New System.Drawing.Size(220, 20)
		Me.FullnameTextBox.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(170, 143)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(220, 23)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "&Confirm Password"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(170, 99)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(220, 23)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "&Password"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(170, 55)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(220, 23)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "&Full Name"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(170, 11)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(220, 23)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "&Username"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'UsernameTextBox
		'
		Me.UsernameTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.UsernameTextBox.Location = New System.Drawing.Point(173, 32)
		Me.UsernameTextBox.Name = "UsernameTextBox"
		Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
		Me.UsernameTextBox.TabIndex = 0
		'
		'SignUpForm
		'
		Me.AcceptButton = Me.SignupButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDark
		Me.ClientSize = New System.Drawing.Size(401, 254)
		Me.Controls.Add(Me.DropDownButton)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.CancelBtn)
		Me.Controls.Add(Me.SignupButton)
		Me.Controls.Add(Me.ConfirmPasswordTextBox)
		Me.Controls.Add(Me.PasswordTextBox)
		Me.Controls.Add(Me.FullnameTextBox)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.UsernameTextBox)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.LogoPictureBox)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "SignUpForm"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Please Enter The Following Info"
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.DropDown.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents DropDown As ContextMenuStrip
    Friend WithEvents StudentAcc As ToolStripMenuItem
    Friend WithEvents TeacherAcc As ToolStripMenuItem
    Friend WithEvents AdminAcc As ToolStripMenuItem
	Friend WithEvents DropDownButton As Button
	Friend WithEvents Label2 As Label
    Friend WithEvents CancelBtn As Button
    Friend WithEvents SignupButton As Button
	Friend WithEvents ConfirmPasswordTextBox As TextBox
	Friend WithEvents PasswordTextBox As TextBox
	Friend WithEvents FullnameTextBox As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents UsernameTextBox As TextBox
End Class
