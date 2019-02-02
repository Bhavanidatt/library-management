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
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.EditButton = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox1.Location = New System.Drawing.Point(65, 47)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(220, 20)
		Me.TextBox1.TabIndex = 0
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
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox2.Location = New System.Drawing.Point(65, 101)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(220, 20)
		Me.TextBox2.TabIndex = 1
		'
		'TextBox3
		'
		Me.TextBox3.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox3.Location = New System.Drawing.Point(65, 99)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBox3.Size = New System.Drawing.Size(220, 20)
		Me.TextBox3.TabIndex = 2
		Me.TextBox3.UseSystemPasswordChar = True
		'
		'TextBox4
		'
		Me.TextBox4.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox4.Location = New System.Drawing.Point(65, 150)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBox4.Size = New System.Drawing.Size(220, 20)
		Me.TextBox4.TabIndex = 3
		Me.TextBox4.UseSystemPasswordChar = True
		'
		'EditButton
		'
		Me.EditButton.AutoSize = True
		Me.EditButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.EditButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.EditButton.Location = New System.Drawing.Point(123, 176)
		Me.EditButton.Name = "EditButton"
		Me.EditButton.Size = New System.Drawing.Size(105, 25)
		Me.EditButton.TabIndex = 5
		Me.EditButton.Text = "&Edit Profile"
		Me.EditButton.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.AutoSize = True
		Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(183, 494)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(94, 25)
		Me.Button2.TabIndex = 6
		Me.Button2.Text = "&Go Back"
		Me.Button2.UseVisualStyleBackColor = False
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
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Location = New System.Drawing.Point(97, 141)
		Me.Button3.Margin = New System.Windows.Forms.Padding(0)
		Me.Button3.Name = "Button3"
		Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Button3.Size = New System.Drawing.Size(182, 24)
		Me.Button3.TabIndex = 4
		Me.Button3.Text = "»"
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Button3.UseVisualStyleBackColor = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Button3)
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Controls.Add(Me.EditButton)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.TextBox2)
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
		Me.GroupBox2.Controls.Add(Me.Button1)
		Me.GroupBox2.Controls.Add(Me.TextBox4)
		Me.GroupBox2.Controls.Add(Me.TextBox6)
		Me.GroupBox2.Controls.Add(Me.TextBox3)
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
		'Button1
		'
		Me.Button1.AutoSize = True
		Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(123, 179)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(105, 25)
		Me.Button1.TabIndex = 5
		Me.Button1.Text = "&Change Password"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'TextBox6
		'
		Me.TextBox6.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox6.Location = New System.Drawing.Point(65, 45)
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBox6.Size = New System.Drawing.Size(220, 20)
		Me.TextBox6.TabIndex = 2
		Me.TextBox6.UseSystemPasswordChar = True
		'
		'EditProfileForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.ClientSize = New System.Drawing.Size(460, 526)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Button2)
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
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents Button3 As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox6 As TextBox
	Private WithEvents EditButton As Button
End Class
