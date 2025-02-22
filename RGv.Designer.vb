Namespace NJRAT
	' Token: 0x02000024 RID: 36
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class RGv
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060002F6 RID: 758 RVA: 0x0001B34C File Offset: 0x0001954C
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

		' Token: 0x060002F7 RID: 759 RVA: 0x0001B39C File Offset: 0x0001959C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox3 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			MyBase.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label1.Location = New Global.System.Drawing.Point(4, 3)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(34, 13)
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Name"
			Me.Label2.AutoSize = True
			Me.Label2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label2.Location = New Global.System.Drawing.Point(257, 3)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(31, 13)
			Me.Label2.TabIndex = 1
			Me.Label2.Text = "Type"
			Me.Label3.AutoSize = True
			Me.Label3.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label3.Location = New Global.System.Drawing.Point(5, 41)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(33, 13)
			Me.Label3.TabIndex = 2
			Me.Label3.Text = "Value"
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TextBox1.Location = New Global.System.Drawing.Point(7, 18)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.Size = New Global.System.Drawing.Size(246, 20)
			Me.TextBox1.TabIndex = 3
			Me.TextBox3.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox3.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TextBox3.Location = New Global.System.Drawing.Point(7, 57)
			Me.TextBox3.Multiline = True
			Me.TextBox3.Name = "TextBox3"
			Me.TextBox3.Size = New Global.System.Drawing.Size(472, 88)
			Me.TextBox3.TabIndex = 4
			Me.Button1.BackColor = Global.System.Drawing.Color.Black
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(7, 146)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(472, 32)
			Me.Button1.TabIndex = 5
			Me.Button1.Text = "Save"
			Me.Button1.UseVisualStyleBackColor = False
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "Binary", "DWord", "ExpandString", "MultiString", "QWord", "String" })
			Me.ComboBox1.Location = New Global.System.Drawing.Point(259, 17)
			Me.ComboBox1.Name = "ComboBox1"
			Me.ComboBox1.Size = New Global.System.Drawing.Size(220, 21)
			Me.ComboBox1.TabIndex = 6
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(486, 187)
			MyBase.Controls.Add(Me.ComboBox1)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.TextBox3)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			Me.ForeColor = Global.System.Drawing.Color.White
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.MaximizeBox = False
			MyBase.Name = "RGv"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "RGv"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040001A5 RID: 421
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
