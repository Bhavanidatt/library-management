<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Button1.Location = New System.Drawing.Point(12, 12)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(150, 42)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Login Form"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button2.Location = New System.Drawing.Point(164, 12)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(150, 42)
		Me.Button2.TabIndex = 0
		Me.Button2.Text = "Signup Form"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(164, 253)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(150, 42)
		Me.Button3.TabIndex = 0
		Me.Button3.Text = "Exit"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DarkRed
		Me.Label1.Location = New System.Drawing.Point(30, 311)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(266, 16)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "This is a temp form to test other forms"
		'
		'Button4
		'
		Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Button4.Location = New System.Drawing.Point(12, 60)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(150, 42)
		Me.Button4.TabIndex = 0
		Me.Button4.Text = "Normal Form"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(326, 344)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Button4 As Button
End Class
