Namespace NJRAT
	' Token: 0x02000026 RID: 38
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class script
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000338 RID: 824 RVA: 0x0001D6BC File Offset: 0x0001B8BC
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

		' Token: 0x06000339 RID: 825 RVA: 0x0001D70C File Offset: 0x0001B90C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Panel1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.ComboBox1)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.Panel1.Location = New Global.System.Drawing.Point(0, 417)
			Me.Panel1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(771, 38)
			Me.Panel1.TabIndex = 0
			Me.Button1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(0, 0)
			Me.Button1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(673, 38)
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Execute"
			Me.Button1.UseVisualStyleBackColor = True
			Me.ComboBox1.BackColor = Global.System.Drawing.SystemColors.InactiveCaptionText
			Me.ComboBox1.Dock = Global.System.Windows.Forms.DockStyle.Right
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "vbs", "bat", "cmd", "txt", "html", "hta" })
			Me.ComboBox1.Location = New Global.System.Drawing.Point(673, 0)
			Me.ComboBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.ComboBox1.Name = "ComboBox1"
			Me.ComboBox1.Size = New Global.System.Drawing.Size(98, 28)
			Me.ComboBox1.TabIndex = 0
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TextBox1.Location = New Global.System.Drawing.Point(0, 0)
			Me.TextBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.Size = New Global.System.Drawing.Size(771, 417)
			Me.TextBox1.TabIndex = 1
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(9F, 20F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			MyBase.ClientSize = New Global.System.Drawing.Size(771, 455)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.Panel1)
			MyBase.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			MyBase.Name = "script"
			MyBase.ShowIcon = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "script"
			Me.Panel1.ResumeLayout(False)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040001CB RID: 459
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
