Namespace NJRAT
	' Token: 0x0200000E RID: 14
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Chat
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060000D7 RID: 215 RVA: 0x00008718 File Offset: 0x00006918
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

		' Token: 0x060000D8 RID: 216 RVA: 0x00008768 File Offset: 0x00006968
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.T2 = New Global.System.Windows.Forms.TextBox()
			Me.T1 = New Global.System.Windows.Forms.RichTextBox()
			Me.vmethod_8 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Panel1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.T2)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.Panel1.Location = New Global.System.Drawing.Point(0, 152)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(405, 29)
			Me.Panel1.TabIndex = 0
			Me.Button1.Dock = Global.System.Windows.Forms.DockStyle.Right
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(324, 0)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(81, 29)
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Send"
			Me.Button1.UseVisualStyleBackColor = True
			Me.T2.BackColor = Global.System.Drawing.Color.Black
			Me.T2.ForeColor = Global.System.Drawing.Color.Lime
			Me.T2.Location = New Global.System.Drawing.Point(0, 0)
			Me.T2.Multiline = True
			Me.T2.Name = "T2"
			Me.T2.Size = New Global.System.Drawing.Size(324, 29)
			Me.T2.TabIndex = 0
			Me.T1.BackColor = Global.System.Drawing.Color.Black
			Me.T1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.T1.ForeColor = Global.System.Drawing.Color.Lime
			Me.T1.Location = New Global.System.Drawing.Point(0, 0)
			Me.T1.Name = "T1"
			Me.T1.Size = New Global.System.Drawing.Size(405, 152)
			Me.T1.TabIndex = 1
			Me.T1.Text = ""
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(405, 181)
			MyBase.Controls.Add(Me.T1)
			MyBase.Controls.Add(Me.Panel1)
			MyBase.Name = "Chat"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Chat"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000062 RID: 98
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
