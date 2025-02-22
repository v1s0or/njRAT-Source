Namespace NJRAT
	' Token: 0x02000008 RID: 8
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class About
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000021 RID: 33 RVA: 0x00002594 File Offset: 0x00000794
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

		' Token: 0x06000022 RID: 34 RVA: 0x000025E4 File Offset: 0x000007E4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.About))
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.PictureBox1.Dock = Global.System.Windows.Forms.DockStyle.Left
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Me.PictureBox1.Location = New Global.System.Drawing.Point(0, 0)
			Me.PictureBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(297, 295)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.RichTextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.RichTextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.RichTextBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.RichTextBox1.ForeColor = Global.System.Drawing.Color.LightSlateGray
			Me.RichTextBox1.Location = New Global.System.Drawing.Point(297, 0)
			Me.RichTextBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.RichTextBox1.Name = "RichTextBox1"
			Me.RichTextBox1.[ReadOnly] = True
			Me.RichTextBox1.Size = New Global.System.Drawing.Size(342, 295)
			Me.RichTextBox1.TabIndex = 1
			Me.RichTextBox1.Text = ""
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(9F, 20F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			MyBase.ClientSize = New Global.System.Drawing.Size(639, 295)
			MyBase.Controls.Add(Me.RichTextBox1)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "About"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "About"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400000B RID: 11
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
