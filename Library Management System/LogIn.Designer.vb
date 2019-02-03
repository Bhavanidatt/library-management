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
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.UsernameTextBox = New System.Windows.Forms.TextBox()
		Me.PasswordTextBox = New System.Windows.Forms.TextBox()
		Me.LoginButton = New System.Windows.Forms.Button()
		Me.CancelBtn = New System.Windows.Forms.Button()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.Image = Global.Library_Management_System.My.Resources.Resources.logo_medium
		Me.LogoPictureBox.Location = New System.Drawing.Point(4, 13)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(165, 166)
		Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.LogoPictureBox.TabIndex = 0
		Me.LogoPictureBox.TabStop = False
		'
		'Label1
		'
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Location = New System.Drawing.Point(171, 25)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(220, 23)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "&User name"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Location = New System.Drawing.Point(171, 74)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(220, 23)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "&Password"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'UsernameTextBox
		'
		Me.UsernameTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.UsernameTextBox.Location = New System.Drawing.Point(174, 51)
		Me.UsernameTextBox.Name = "UsernameTextBox"
		Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
		Me.UsernameTextBox.TabIndex = 0
		'
		'PasswordTextBox
		'
		Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PasswordTextBox.Location = New System.Drawing.Point(174, 100)
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
		Me.LoginButton.Location = New System.Drawing.Point(187, 145)
		Me.LoginButton.Name = "LoginButton"
		Me.LoginButton.Size = New System.Drawing.Size(94, 23)
		Me.LoginButton.TabIndex = 2
		Me.LoginButton.Text = "&Login"
		Me.LoginButton.UseVisualStyleBackColor = False
		'
		'CancelBtn
		'
		Me.CancelBtn.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CancelBtn.Location = New System.Drawing.Point(287, 145)
		Me.CancelBtn.Name = "CancelBtn"
		Me.CancelBtn.Size = New System.Drawing.Size(94, 23)
		Me.CancelBtn.TabIndex = 3
		Me.CancelBtn.Text = "&Cancel"
		Me.CancelBtn.UseVisualStyleBackColor = False
		'
		'LoginForm
		'
		Me.AcceptButton = Me.LoginButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDark
		Me.ClientSize = New System.Drawing.Size(401, 192)
		Me.Controls.Add(Me.CancelBtn)
		Me.Controls.Add(Me.LoginButton)
		Me.Controls.Add(Me.PasswordTextBox)
		Me.Controls.Add(Me.UsernameTextBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
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
