Namespace NJRAT
	' Token: 0x0200000D RID: 13
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Cam
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060000B9 RID: 185 RVA: 0x000077C4 File Offset: 0x000059C4
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

		' Token: 0x060000BA RID: 186 RVA: 0x00007814 File Offset: 0x00005A14
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.ComboBox2 = New Global.System.Windows.Forms.ComboBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.CheckBox3 = New Global.System.Windows.Forms.CheckBox()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.vmethod_6 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Panel1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Panel1.Controls.Add(Me.ComboBox2)
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.CheckBox3)
			Me.Panel1.Controls.Add(Me.ComboBox1)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.Panel1.Location = New Global.System.Drawing.Point(0, 348)
			Me.Panel1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(730, 35)
			Me.Panel1.TabIndex = 0
			Me.ComboBox2.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox2.Dock = Global.System.Windows.Forms.DockStyle.Right
			Me.ComboBox2.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ComboBox2.FormattingEnabled = True
			Me.ComboBox2.Items.AddRange(New Object() { "%100", "%90", "%80", "%70", "%60", "%50" })
			Me.ComboBox2.Location = New Global.System.Drawing.Point(602, 0)
			Me.ComboBox2.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.ComboBox2.Name = "ComboBox2"
			Me.ComboBox2.Size = New Global.System.Drawing.Size(128, 28)
			Me.ComboBox2.TabIndex = 3
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(2, 2)
			Me.Button1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(142, 32)
			Me.Button1.TabIndex = 2
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = True
			Me.CheckBox3.AutoSize = True
			Me.CheckBox3.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CheckBox3.Location = New Global.System.Drawing.Point(146, 5)
			Me.CheckBox3.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.CheckBox3.Name = "CheckBox3"
			Me.CheckBox3.Size = New Global.System.Drawing.Size(105, 24)
			Me.CheckBox3.TabIndex = 1
			Me.CheckBox3.Text = "AutoSave"
			Me.CheckBox3.UseVisualStyleBackColor = True
			Me.ComboBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Location = New Global.System.Drawing.Point(260, 0)
			Me.ComboBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.ComboBox1.Name = "ComboBox1"
			Me.ComboBox1.Size = New Global.System.Drawing.Size(338, 28)
			Me.ComboBox1.TabIndex = 0
			Me.PictureBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox1.Location = New Global.System.Drawing.Point(0, 0)
			Me.PictureBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(730, 329)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.ProgressBar1.Location = New Global.System.Drawing.Point(0, 333)
			Me.ProgressBar1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.Size = New Global.System.Drawing.Size(730, 15)
			Me.ProgressBar1.TabIndex = 2
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(9F, 20F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(730, 383)
			MyBase.Controls.Add(Me.ProgressBar1)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.Controls.Add(Me.Panel1)
			Me.ForeColor = Global.System.Drawing.Color.SlateBlue
			MyBase.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			MyBase.Name = "Cam"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Cam"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000051 RID: 81
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
