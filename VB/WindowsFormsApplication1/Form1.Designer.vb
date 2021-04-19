Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.button1 = New System.Windows.Forms.Button()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(110, 57)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(148, 49)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Show Print Preview"
			Me.button1.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button1.Click += new System.EventHandler(this.button1_Click);
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Location = New System.Drawing.Point(14, 12)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(337, 21)
			Me.comboBox1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(363, 136)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "DevExpress Reporting - Bar Codes"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private comboBox1 As System.Windows.Forms.ComboBox
	End Class
End Namespace

