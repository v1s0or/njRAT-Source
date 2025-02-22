Namespace NJRAT
	' Token: 0x02000025 RID: 37
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class sc
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000308 RID: 776 RVA: 0x0001BBC8 File Offset: 0x00019DC8
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

		' Token: 0x06000309 RID: 777 RVA: 0x0001BC18 File Offset: 0x00019E18
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.CheckBox1 = New Global.System.Windows.Forms.CheckBox()
			Me.CheckBox2 = New Global.System.Windows.Forms.CheckBox()
			Me.CheckBox3 = New Global.System.Windows.Forms.CheckBox()
			Me.vmethod_16 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.vmethod_12 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.p = New Global.System.Windows.Forms.PictureBox()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Panel1.SuspendLayout()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.Label1)
			Me.Panel1.Controls.Add(Me.ComboBox1)
			Me.Panel1.Controls.Add(Me.CheckBox1)
			Me.Panel1.Controls.Add(Me.CheckBox2)
			Me.Panel1.Controls.Add(Me.CheckBox3)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.Panel1.Location = New Global.System.Drawing.Point(0, 0)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(424, 27)
			Me.Panel1.TabIndex = 0
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(2, 1)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(75, 22)
			Me.Button1.TabIndex = 5
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label1.Location = New Global.System.Drawing.Point(82, 5)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(30, 14)
			Me.Label1.TabIndex = 4
			Me.Label1.Text = "Size"
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50" })
			Me.ComboBox1.Location = New Global.System.Drawing.Point(116, 2)
			Me.ComboBox1.Name = "ComboBox1"
			Me.ComboBox1.Size = New Global.System.Drawing.Size(78, 21)
			Me.ComboBox1.TabIndex = 3
			Me.CheckBox1.AutoSize = True
			Me.CheckBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CheckBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CheckBox1.Location = New Global.System.Drawing.Point(197, 2)
			Me.CheckBox1.Name = "CheckBox1"
			Me.CheckBox1.Size = New Global.System.Drawing.Size(54, 17)
			Me.CheckBox1.TabIndex = 2
			Me.CheckBox1.Text = "Mouse"
			Me.CheckBox1.UseVisualStyleBackColor = True
			Me.CheckBox2.AutoSize = True
			Me.CheckBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CheckBox2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CheckBox2.Location = New Global.System.Drawing.Point(255, 2)
			Me.CheckBox2.Name = "CheckBox2"
			Me.CheckBox2.Size = New Global.System.Drawing.Size(69, 17)
			Me.CheckBox2.TabIndex = 1
			Me.CheckBox2.Text = "Keyboard"
			Me.CheckBox2.UseVisualStyleBackColor = True
			Me.CheckBox3.AutoSize = True
			Me.CheckBox3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CheckBox3.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CheckBox3.Location = New Global.System.Drawing.Point(329, 2)
			Me.CheckBox3.Name = "CheckBox3"
			Me.CheckBox3.Size = New Global.System.Drawing.Size(70, 17)
			Me.CheckBox3.TabIndex = 0
			Me.CheckBox3.Text = "AutoSave"
			Me.CheckBox3.UseVisualStyleBackColor = True
			Me.vmethod_16.Enabled = True
			Me.vmethod_16.Interval = 10
			Me.vmethod_12.Enabled = True
			Me.vmethod_12.Interval = 1000
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.ProgressBar1.Location = New Global.System.Drawing.Point(0, 246)
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.Size = New Global.System.Drawing.Size(424, 9)
			Me.ProgressBar1.TabIndex = 1
			Me.p.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.p.Location = New Global.System.Drawing.Point(0, 27)
			Me.p.Name = "p"
			Me.p.Size = New Global.System.Drawing.Size(424, 228)
			Me.p.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.p.TabIndex = 2
			Me.p.TabStop = False
			Me.Button2.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.Button2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.Location = New Global.System.Drawing.Point(209, 27)
			Me.Button2.Name = "Button2"
			Me.Button2.Size = New Global.System.Drawing.Size(10, 12)
			Me.Button2.TabIndex = 3
			Me.Button2.UseVisualStyleBackColor = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(424, 255)
			MyBase.Controls.Add(Me.Button2)
			MyBase.Controls.Add(Me.ProgressBar1)
			MyBase.Controls.Add(Me.p)
			MyBase.Controls.Add(Me.Panel1)
			MyBase.Name = "sc"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "sc"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x040001AF RID: 431
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
