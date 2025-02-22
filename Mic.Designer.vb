Namespace NJRAT
	' Token: 0x0200001E RID: 30
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Mic
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600027D RID: 637 RVA: 0x00017874 File Offset: 0x00015A74
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

		' Token: 0x0600027E RID: 638 RVA: 0x000178C4 File Offset: 0x00015AC4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.vmethod_4 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.ComboBox2 = New Global.System.Windows.Forms.ComboBox()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			MyBase.SuspendLayout()
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Location = New Global.System.Drawing.Point(2, 3)
			Me.ComboBox1.Name = "ComboBox1"
			Me.ComboBox1.Size = New Global.System.Drawing.Size(224, 21)
			Me.ComboBox1.TabIndex = 0
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(232, 3)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(124, 48)
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = True
			Me.vmethod_4.Enabled = True
			Me.vmethod_4.Interval = 50
			Me.Label1.AutoSize = True
			Me.Label1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label1.Location = New Global.System.Drawing.Point(5, 33)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(56, 13)
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "BufferSize"
			Me.ComboBox2.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox2.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ComboBox2.FormattingEnabled = True
			Me.ComboBox2.Items.AddRange(New Object() { "4 kb 8bit", "6 kb 8bit", "8 kb 8bit", "8 kb 16bit", "12 kb 16bit", "16 kb 16bit", "20 kb 16bit", "24 kb 16bit" })
			Me.ComboBox2.Location = New Global.System.Drawing.Point(86, 30)
			Me.ComboBox2.Name = "ComboBox2"
			Me.ComboBox2.Size = New Global.System.Drawing.Size(140, 21)
			Me.ComboBox2.TabIndex = 3
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.ProgressBar1.Location = New Global.System.Drawing.Point(0, 55)
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.Size = New Global.System.Drawing.Size(359, 10)
			Me.ProgressBar1.TabIndex = 4
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(359, 65)
			MyBase.Controls.Add(Me.ProgressBar1)
			MyBase.Controls.Add(Me.ComboBox2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.ComboBox1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.MaximizeBox = False
			MyBase.Name = "Mic"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Mic"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000171 RID: 369
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
