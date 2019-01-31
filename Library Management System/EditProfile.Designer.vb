<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class EditProfile
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
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox1.Location = New System.Drawing.Point(15, 38)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(220, 20)
		Me.TextBox1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(12, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(220, 23)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "&Username"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(12, 61)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(220, 23)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "&Full Name"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(12, 105)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(220, 23)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "&Password"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(12, 149)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(220, 23)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "&Confirm Password"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox2.Location = New System.Drawing.Point(15, 82)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(220, 20)
		Me.TextBox2.TabIndex = 1
		'
		'TextBox3
		'
		Me.TextBox3.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox3.Location = New System.Drawing.Point(15, 126)
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
		Me.TextBox4.Location = New System.Drawing.Point(15, 170)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBox4.Size = New System.Drawing.Size(220, 20)
		Me.TextBox4.TabIndex = 3
		Me.TextBox4.UseSystemPasswordChar = True
		'
		'EditButton
		'
		Me.EditButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.EditButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.EditButton.Location = New System.Drawing.Point(32, 227)
		Me.EditButton.Name = "EditButton"
		Me.EditButton.Size = New System.Drawing.Size(94, 23)
		Me.EditButton.TabIndex = 5
		Me.EditButton.Text = "&Edit"
		Me.EditButton.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(132, 227)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(94, 23)
		Me.Button2.TabIndex = 6
		Me.Button2.Text = "&Cancel"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(19, 200)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(25, 16)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "I'm"
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Location = New System.Drawing.Point(202, 196)
		Me.Button3.Margin = New System.Windows.Forms.Padding(0)
		Me.Button3.Name = "Button3"
		Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Button3.Size = New System.Drawing.Size(30, 25)
		Me.Button3.TabIndex = 4
		Me.Button3.Text = "»"
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Button3.UseVisualStyleBackColor = False
		'
		'TextBox5
		'
		Me.TextBox5.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox5.ForeColor = System.Drawing.Color.Black
		Me.TextBox5.Location = New System.Drawing.Point(52, 196)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(149, 24)
		Me.TextBox5.TabIndex = 12
		Me.TextBox5.TabStop = False
		Me.TextBox5.Text = "Student"
		Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'EditProfile
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.ClientSize = New System.Drawing.Size(247, 267)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.EditButton)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.TextBox3)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "EditProfile"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "EditProfile"
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
	Friend WithEvents EditButton As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents Button3 As Button
	Friend WithEvents TextBox5 As TextBox
End Class
