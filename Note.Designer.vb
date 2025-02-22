Namespace NJRAT
	' Token: 0x0200001F RID: 31
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Note
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000291 RID: 657 RVA: 0x0001823C File Offset: 0x0001643C
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

		' Token: 0x06000292 RID: 658 RVA: 0x0001828C File Offset: 0x0001648C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.MenuStrip1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.MenuStrip1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem1 })
			Me.MenuStrip1.LayoutStyle = Global.System.Windows.Forms.ToolStripLayoutStyle.Flow
			Me.MenuStrip1.Location = New Global.System.Drawing.Point(0, 0)
			Me.MenuStrip1.Name = "MenuStrip1"
			Me.MenuStrip1.Size = New Global.System.Drawing.Size(629, 23)
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.ToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Me.ToolStripMenuItem1.Size = New Global.System.Drawing.Size(97, 18)
			Me.ToolStripMenuItem1.Text = "Save Changes"
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.White
			Me.TextBox1.Location = New Global.System.Drawing.Point(0, 23)
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Me.TextBox1.Size = New Global.System.Drawing.Size(629, 205)
			Me.TextBox1.TabIndex = 1
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(629, 228)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.MenuStrip1)
			MyBase.MainMenuStrip = Me.MenuStrip1
			MyBase.Name = "Note"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Note"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400017B RID: 379
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
