Namespace NJRAT
	' Token: 0x0200001B RID: 27
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class kl
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000174 RID: 372 RVA: 0x0000F358 File Offset: 0x0000D558
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

		' Token: 0x06000175 RID: 373 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem2 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.TFind = New Global.System.Windows.Forms.ToolStripTextBox()
			Me.ToolStripMenuItem3 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.T1 = New Global.System.Windows.Forms.RichTextBox()
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.CopyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SelectAllToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.MenuStrip1.SuspendLayout()
			Me.ContextMenuStrip1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.ProgressBar1.Location = New Global.System.Drawing.Point(0, 309)
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.Size = New Global.System.Drawing.Size(641, 23)
			Me.ProgressBar1.TabIndex = 0
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.TFind, Me.ToolStripMenuItem3 })
			Me.MenuStrip1.Location = New Global.System.Drawing.Point(0, 0)
			Me.MenuStrip1.Name = "MenuStrip1"
			Me.MenuStrip1.Size = New Global.System.Drawing.Size(641, 27)
			Me.MenuStrip1.TabIndex = 1
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.ToolStripMenuItem1.BackColor = Global.System.Drawing.Color.Black
			Me.ToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Me.ToolStripMenuItem1.Size = New Global.System.Drawing.Size(58, 23)
			Me.ToolStripMenuItem1.Text = "Refresh"
			Me.ToolStripMenuItem2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
			Me.ToolStripMenuItem2.Size = New Global.System.Drawing.Size(42, 23)
			Me.ToolStripMenuItem2.Text = "Find"
			Me.TFind.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TFind.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TFind.Name = "TFind"
			Me.TFind.Size = New Global.System.Drawing.Size(100, 23)
			Me.TFind.Text = ".."
			Me.ToolStripMenuItem3.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
			Me.ToolStripMenuItem3.Size = New Global.System.Drawing.Size(100, 23)
			Me.ToolStripMenuItem3.Text = "Fix [BackSpace]"
			Me.T1.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.T1.ContextMenuStrip = Me.ContextMenuStrip1
			Me.T1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.T1.Location = New Global.System.Drawing.Point(0, 27)
			Me.T1.Name = "T1"
			Me.T1.Size = New Global.System.Drawing.Size(641, 282)
			Me.T1.TabIndex = 2
			Me.T1.Text = ""
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CopyToolStripMenuItem, Me.SelectAllToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Me.ContextMenuStrip1.Size = New Global.System.Drawing.Size(123, 48)
			Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
			Me.CopyToolStripMenuItem.Size = New Global.System.Drawing.Size(122, 22)
			Me.CopyToolStripMenuItem.Text = "Copy"
			Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
			Me.SelectAllToolStripMenuItem.Size = New Global.System.Drawing.Size(122, 22)
			Me.SelectAllToolStripMenuItem.Text = "Select All"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(641, 332)
			MyBase.Controls.Add(Me.T1)
			MyBase.Controls.Add(Me.ProgressBar1)
			MyBase.Controls.Add(Me.MenuStrip1)
			MyBase.MainMenuStrip = Me.MenuStrip1
			MyBase.Name = "kl"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "kl"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ContextMenuStrip1.ResumeLayout(False)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040000E8 RID: 232
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
