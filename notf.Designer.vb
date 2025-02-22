Namespace NJRAT
	' Token: 0x02000020 RID: 32
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class notf
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600029B RID: 667 RVA: 0x0001868C File Offset: 0x0001688C
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

		' Token: 0x0600029C RID: 668 RVA: 0x000186DC File Offset: 0x000168DC
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.p = New Global.System.Windows.Forms.PictureBox()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.p.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.p.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.p.Location = New Global.System.Drawing.Point(0, 0)
			Me.p.Name = "p"
			Me.p.Size = New Global.System.Drawing.Size(267, 109)
			Me.p.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.p.TabIndex = 0
			Me.p.TabStop = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(267, 109)
			MyBase.Controls.Add(Me.p)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Name = "notf"
			MyBase.Opacity = 0.8
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "notf"
			MyBase.TopMost = True
			MyBase.TransparencyKey = Global.System.Drawing.Color.Transparent
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000181 RID: 385
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
