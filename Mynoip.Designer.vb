Namespace NJRAT
	' Token: 0x0200000A RID: 10
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Mynoip
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600006A RID: 106 RVA: 0x00004748 File Offset: 0x00002948
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x0600006B RID: 107 RVA: 0x00004798 File Offset: 0x00002998
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox3 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label1.Location = New Global.System.Drawing.Point(1, 130)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(48, 18)
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Email"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label2.Location = New Global.System.Drawing.Point(1, 182)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(78, 18)
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Password"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label3.Location = New Global.System.Drawing.Point(1, 234)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(40, 18)
			Me.Label3.TabIndex = 3
			Me.Label3.Text = "Host"
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TextBox1.Location = New Global.System.Drawing.Point(4, 152)
			Me.TextBox1.Margin = New Global.System.Windows.Forms.Padding(4)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.Size = New Global.System.Drawing.Size(254, 26)
			Me.TextBox1.TabIndex = 11
			Me.TextBox1.Text = "example@gmail.com"
			Me.TextBox2.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox2.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TextBox2.Location = New Global.System.Drawing.Point(4, 204)
			Me.TextBox2.Margin = New Global.System.Windows.Forms.Padding(4)
			Me.TextBox2.Name = "TextBox2"
			Me.TextBox2.Size = New Global.System.Drawing.Size(254, 26)
			Me.TextBox2.TabIndex = 12
			Me.TextBox2.Text = "123456"
			Me.TextBox2.UseSystemPasswordChar = True
			Me.TextBox3.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox3.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox3.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TextBox3.Location = New Global.System.Drawing.Point(4, 256)
			Me.TextBox3.Margin = New Global.System.Windows.Forms.Padding(4)
			Me.TextBox3.Name = "TextBox3"
			Me.TextBox3.Size = New Global.System.Drawing.Size(254, 26)
			Me.TextBox3.TabIndex = 13
			Me.TextBox3.Text = "example.no-ip.com"
			Me.Button1.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(4, 290)
			Me.Button1.Margin = New Global.System.Windows.Forms.Padding(4)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(78, 48)
			Me.Button1.TabIndex = 14
			Me.Button1.Text = "Update"
			Me.Button1.UseVisualStyleBackColor = True
			Me.PictureBox1.Image = Global.NJRAT.My.Resources.Resources.noip_logo
			Me.PictureBox1.InitialImage = Nothing
			Me.PictureBox1.Location = New Global.System.Drawing.Point(77, 3)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(115, 124)
			Me.PictureBox1.TabIndex = 15
			Me.PictureBox1.TabStop = False
			Me.RichTextBox1.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RichTextBox1.Location = New Global.System.Drawing.Point(515, 553)
			Me.RichTextBox1.Name = "RichTextBox1"
			Me.RichTextBox1.Size = New Global.System.Drawing.Size(10, 10)
			Me.RichTextBox1.TabIndex = 7
			Me.RichTextBox1.Text = ""
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(9F, 20F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(263, 344)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.TextBox3)
			MyBase.Controls.Add(Me.TextBox2)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.RichTextBox1)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8F)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "Mynoip"
			MyBase.ShowIcon = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Mynoip"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400002C RID: 44
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
