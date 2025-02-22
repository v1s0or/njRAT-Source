Namespace NJRAT
	' Token: 0x02000022 RID: 34
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class port
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060002DE RID: 734 RVA: 0x0001A81C File Offset: 0x00018A1C
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

		' Token: 0x060002DF RID: 735 RVA: 0x0001A86C File Offset: 0x00018A6C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			MyBase.SuspendLayout()
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.Font = New Global.System.Drawing.Font("Arial", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TextBox1.Location = New Global.System.Drawing.Point(92, 9)
			Me.TextBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.Size = New Global.System.Drawing.Size(175, 33)
			Me.TextBox1.TabIndex = 0
			Me.TextBox1.Text = "6522"
			Me.TextBox1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.Location = New Global.System.Drawing.Point(12, 57)
			Me.Button1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(256, 51)
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(9, 11)
			Me.Label1.Margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(75, 29)
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Port :"
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button2.Location = New Global.System.Drawing.Point(12, 117)
			Me.Button2.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Button2.Name = "Button2"
			Me.Button2.Size = New Global.System.Drawing.Size(256, 51)
			Me.Button2.TabIndex = 3
			Me.Button2.Text = "Exit"
			Me.Button2.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(9F, 20F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			MyBase.ClientSize = New Global.System.Drawing.Size(286, 178)
			MyBase.Controls.Add(Me.Button2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.TextBox1)
			Me.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			MyBase.MaximizeBox = False
			MyBase.Name = "port"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "port"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400019B RID: 411
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
