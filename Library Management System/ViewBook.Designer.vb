<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBookForm
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
		Me.BookNameLabel = New System.Windows.Forms.Label()
		Me.IssueButton = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.CopiesInfoLabel = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'BookNameLabel
		'
		Me.BookNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BookNameLabel.Location = New System.Drawing.Point(217, 15)
		Me.BookNameLabel.Name = "BookNameLabel"
		Me.BookNameLabel.Size = New System.Drawing.Size(264, 78)
		Me.BookNameLabel.TabIndex = 1
		Me.BookNameLabel.Text = "BookName"
		'
		'IssueButton
		'
		Me.IssueButton.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.IssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.IssueButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.IssueButton.Location = New System.Drawing.Point(274, 151)
		Me.IssueButton.Name = "IssueButton"
		Me.IssueButton.Size = New System.Drawing.Size(146, 52)
		Me.IssueButton.TabIndex = 2
		Me.IssueButton.Text = "Issue"
		Me.IssueButton.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Library_Management_System.My.Resources.Resources.logo_medium
		Me.PictureBox1.InitialImage = Global.Library_Management_System.My.Resources.Resources.logo_medium
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(196, 192)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'CopiesInfoLabel
		'
		Me.CopiesInfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CopiesInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CopiesInfoLabel.Location = New System.Drawing.Point(214, 105)
		Me.CopiesInfoLabel.Name = "CopiesInfoLabel"
		Me.CopiesInfoLabel.Size = New System.Drawing.Size(267, 43)
		Me.CopiesInfoLabel.TabIndex = 3
		Me.CopiesInfoLabel.Text = "0 Copies Left"
		'
		'ViewBookForm
		'
		Me.AcceptButton = Me.IssueButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.ClientSize = New System.Drawing.Size(500, 216)
		Me.Controls.Add(Me.CopiesInfoLabel)
		Me.Controls.Add(Me.IssueButton)
		Me.Controls.Add(Me.BookNameLabel)
		Me.Controls.Add(Me.PictureBox1)
		Me.Name = "ViewBookForm"
		Me.Text = "ViewBook"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents BookNameLabel As Label
	Friend WithEvents IssueButton As Button
	Friend WithEvents CopiesInfoLabel As Label

End Class
