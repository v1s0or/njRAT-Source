Namespace NJRAT
	' Token: 0x02000013 RID: 19
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FromLink
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000123 RID: 291 RVA: 0x0000B71C File Offset: 0x0000991C
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

		' Token: 0x06000124 RID: 292 RVA: 0x0000B76C File Offset: 0x0000996C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			MyBase.SuspendLayout()
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Location = New Global.System.Drawing.Point(156, 60)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(82, 23)
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "OK"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.Location = New Global.System.Drawing.Point(244, 60)
			Me.Button2.Name = "Button2"
			Me.Button2.Size = New Global.System.Drawing.Size(82, 23)
			Me.Button2.TabIndex = 1
			Me.Button2.Text = "Cancel"
			Me.Button2.UseVisualStyleBackColor = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TextBox1.Location = New Global.System.Drawing.Point(5, 23)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.Size = New Global.System.Drawing.Size(321, 20)
			Me.TextBox1.TabIndex = 2
			Me.TextBox2.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TextBox2.Location = New Global.System.Drawing.Point(5, 62)
			Me.TextBox2.Name = "TextBox2"
			Me.TextBox2.Size = New Global.System.Drawing.Size(140, 20)
			Me.TextBox2.TabIndex = 3
			Me.TextBox2.Text = "File.txt"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(2, 46)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(52, 13)
			Me.Label1.TabIndex = 4
			Me.Label1.Text = "Save As"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(3, 8)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(30, 13)
			Me.Label2.TabIndex = 5
			Me.Label2.Text = "Link"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(336, 102)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.TextBox2)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.Button2)
			MyBase.Controls.Add(Me.Button1)
			Me.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.MaximizeBox = False
			MyBase.Name = "FromLink"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "FromLink"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400009B RID: 155
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
