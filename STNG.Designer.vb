Namespace NJRAT
	' Token: 0x0200002D RID: 45
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class STNG
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060003F5 RID: 1013 RVA: 0x0002B06C File Offset: 0x0002926C
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

		' Token: 0x060003F6 RID: 1014 RVA: 0x0002B0BC File Offset: 0x000292BC
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.ShowAlert = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.LOGLOGIN = New Global.System.Windows.Forms.CheckBox()
			Me.LOGCONNECTIONS = New Global.System.Windows.Forms.CheckBox()
			Me.LOGLERR = New Global.System.Windows.Forms.CheckBox()
			Me.LOGRERR = New Global.System.Windows.Forms.CheckBox()
			Me.LOGMSGS = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.SCI = New Global.System.Windows.Forms.ComboBox()
			Me.SCAUT = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.CAMI = New Global.System.Windows.Forms.ComboBox()
			Me.CAMAUT = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.MICI = New Global.System.Windows.Forms.ComboBox()
			Me.MICAUT = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.scrI = New Global.System.Windows.Forms.ComboBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.GroupBox6.SuspendLayout()
			MyBase.SuspendLayout()
			Me.GroupBox1.Controls.Add(Me.ShowAlert)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.GroupBox1.Location = New Global.System.Drawing.Point(124, 104)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.GroupBox1.Size = New Global.System.Drawing.Size(117, 31)
			Me.GroupBox1.TabIndex = 0
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "OnLogin"
			Me.ShowAlert.AutoSize = True
			Me.ShowAlert.Location = New Global.System.Drawing.Point(6, 11)
			Me.ShowAlert.Name = "ShowAlert"
			Me.ShowAlert.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.ShowAlert.Size = New Global.System.Drawing.Size(78, 17)
			Me.ShowAlert.TabIndex = 0
			Me.ShowAlert.Text = "Show Alert"
			Me.ShowAlert.UseVisualStyleBackColor = True
			Me.GroupBox2.Controls.Add(Me.LOGLOGIN)
			Me.GroupBox2.Controls.Add(Me.LOGCONNECTIONS)
			Me.GroupBox2.Controls.Add(Me.LOGLERR)
			Me.GroupBox2.Controls.Add(Me.LOGRERR)
			Me.GroupBox2.Controls.Add(Me.LOGMSGS)
			Me.GroupBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.GroupBox2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.GroupBox2.Location = New Global.System.Drawing.Point(124, 1)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.GroupBox2.Size = New Global.System.Drawing.Size(117, 101)
			Me.GroupBox2.TabIndex = 1
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Logs"
			Me.LOGLOGIN.AutoSize = True
			Me.LOGLOGIN.Location = New Global.System.Drawing.Point(5, 14)
			Me.LOGLOGIN.Name = "LOGLOGIN"
			Me.LOGLOGIN.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.LOGLOGIN.Size = New Global.System.Drawing.Size(73, 17)
			Me.LOGLOGIN.TabIndex = 5
			Me.LOGLOGIN.Text = "Login/Out"
			Me.LOGLOGIN.UseVisualStyleBackColor = True
			Me.LOGCONNECTIONS.AutoSize = True
			Me.LOGCONNECTIONS.Location = New Global.System.Drawing.Point(5, 30)
			Me.LOGCONNECTIONS.Name = "LOGCONNECTIONS"
			Me.LOGCONNECTIONS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.LOGCONNECTIONS.Size = New Global.System.Drawing.Size(85, 17)
			Me.LOGCONNECTIONS.TabIndex = 4
			Me.LOGCONNECTIONS.Text = "Connections"
			Me.LOGCONNECTIONS.UseVisualStyleBackColor = True
			Me.LOGLERR.AutoSize = True
			Me.LOGLERR.Location = New Global.System.Drawing.Point(5, 46)
			Me.LOGLERR.Name = "LOGLERR"
			Me.LOGLERR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.LOGLERR.Size = New Global.System.Drawing.Size(90, 17)
			Me.LOGLERR.TabIndex = 3
			Me.LOGLERR.Text = "Listner Errors"
			Me.LOGLERR.UseVisualStyleBackColor = True
			Me.LOGRERR.AutoSize = True
			Me.LOGRERR.Location = New Global.System.Drawing.Point(5, 63)
			Me.LOGRERR.Name = "LOGRERR"
			Me.LOGRERR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.LOGRERR.Size = New Global.System.Drawing.Size(95, 17)
			Me.LOGRERR.TabIndex = 2
			Me.LOGRERR.Text = "Remote Errors"
			Me.LOGRERR.UseVisualStyleBackColor = True
			Me.LOGMSGS.AutoSize = True
			Me.LOGMSGS.Location = New Global.System.Drawing.Point(5, 80)
			Me.LOGMSGS.Name = "LOGMSGS"
			Me.LOGMSGS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.LOGMSGS.Size = New Global.System.Drawing.Size(73, 17)
			Me.LOGMSGS.TabIndex = 1
			Me.LOGMSGS.Text = "Messages"
			Me.LOGMSGS.UseVisualStyleBackColor = True
			Me.GroupBox3.Controls.Add(Me.Label1)
			Me.GroupBox3.Controls.Add(Me.SCI)
			Me.GroupBox3.Controls.Add(Me.SCAUT)
			Me.GroupBox3.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.GroupBox3.Location = New Global.System.Drawing.Point(3, 1)
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.Size = New Global.System.Drawing.Size(115, 64)
			Me.GroupBox3.TabIndex = 2
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Remote Desktop"
			Me.Label1.AutoSize = True
			Me.Label1.Location = New Global.System.Drawing.Point(6, 39)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(26, 13)
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "Size"
			Me.SCI.BackColor = Global.System.Drawing.Color.Black
			Me.SCI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.SCI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.SCI.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.SCI.FormattingEnabled = True
			Me.SCI.Items.AddRange(New Object() { "%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50" })
			Me.SCI.Location = New Global.System.Drawing.Point(38, 36)
			Me.SCI.Name = "SCI"
			Me.SCI.Size = New Global.System.Drawing.Size(71, 21)
			Me.SCI.TabIndex = 2
			Me.SCAUT.AutoSize = True
			Me.SCAUT.Location = New Global.System.Drawing.Point(6, 19)
			Me.SCAUT.Name = "SCAUT"
			Me.SCAUT.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.SCAUT.Size = New Global.System.Drawing.Size(73, 17)
			Me.SCAUT.TabIndex = 1
			Me.SCAUT.Text = "AutoStart"
			Me.SCAUT.UseVisualStyleBackColor = True
			Me.GroupBox4.Controls.Add(Me.Label2)
			Me.GroupBox4.Controls.Add(Me.CAMI)
			Me.GroupBox4.Controls.Add(Me.CAMAUT)
			Me.GroupBox4.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.GroupBox4.Location = New Global.System.Drawing.Point(3, 68)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.Size = New Global.System.Drawing.Size(115, 64)
			Me.GroupBox4.TabIndex = 3
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Remote Cam"
			Me.Label2.AutoSize = True
			Me.Label2.Location = New Global.System.Drawing.Point(6, 39)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(26, 13)
			Me.Label2.TabIndex = 3
			Me.Label2.Text = "Size"
			Me.CAMI.BackColor = Global.System.Drawing.Color.Black
			Me.CAMI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.CAMI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CAMI.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CAMI.FormattingEnabled = True
			Me.CAMI.Items.AddRange(New Object() { "%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50" })
			Me.CAMI.Location = New Global.System.Drawing.Point(38, 36)
			Me.CAMI.Name = "CAMI"
			Me.CAMI.Size = New Global.System.Drawing.Size(71, 21)
			Me.CAMI.TabIndex = 2
			Me.CAMAUT.AutoSize = True
			Me.CAMAUT.Location = New Global.System.Drawing.Point(6, 19)
			Me.CAMAUT.Name = "CAMAUT"
			Me.CAMAUT.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.CAMAUT.Size = New Global.System.Drawing.Size(73, 17)
			Me.CAMAUT.TabIndex = 1
			Me.CAMAUT.Text = "AutoStart"
			Me.CAMAUT.UseVisualStyleBackColor = True
			Me.GroupBox5.Controls.Add(Me.MICI)
			Me.GroupBox5.Controls.Add(Me.MICAUT)
			Me.GroupBox5.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.GroupBox5.Location = New Global.System.Drawing.Point(3, 137)
			Me.GroupBox5.Name = "GroupBox5"
			Me.GroupBox5.Size = New Global.System.Drawing.Size(115, 64)
			Me.GroupBox5.TabIndex = 4
			Me.GroupBox5.TabStop = False
			Me.GroupBox5.Text = "Remote MIC"
			Me.MICI.BackColor = Global.System.Drawing.Color.Black
			Me.MICI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.MICI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.MICI.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.MICI.FormattingEnabled = True
			Me.MICI.Items.AddRange(New Object() { "4 kb 8bit", "6 kb 8bit", "8 kb 8bit", "8 kb 16bit", "12 kb 16bit", "16 kb 16bit", "20 kb 16bit", "24 kb 16bit" })
			Me.MICI.Location = New Global.System.Drawing.Point(6, 36)
			Me.MICI.Name = "MICI"
			Me.MICI.Size = New Global.System.Drawing.Size(103, 21)
			Me.MICI.TabIndex = 2
			Me.MICAUT.AutoSize = True
			Me.MICAUT.Location = New Global.System.Drawing.Point(6, 19)
			Me.MICAUT.Name = "MICAUT"
			Me.MICAUT.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.MICAUT.Size = New Global.System.Drawing.Size(73, 17)
			Me.MICAUT.TabIndex = 1
			Me.MICAUT.Text = "AutoStart"
			Me.MICAUT.UseVisualStyleBackColor = True
			Me.GroupBox6.Controls.Add(Me.Label3)
			Me.GroupBox6.Controls.Add(Me.scrI)
			Me.GroupBox6.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.GroupBox6.Location = New Global.System.Drawing.Point(124, 138)
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.GroupBox6.Size = New Global.System.Drawing.Size(117, 64)
			Me.GroupBox6.TabIndex = 5
			Me.GroupBox6.TabStop = False
			Me.GroupBox6.Text = "Screen"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(5, 14)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(89, 14)
			Me.Label3.TabIndex = 3
			Me.Label3.Text = "Refresh Speed"
			Me.scrI.BackColor = Global.System.Drawing.Color.Black
			Me.scrI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.scrI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.scrI.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.scrI.FormattingEnabled = True
			Me.scrI.Items.AddRange(New Object() { "Ultra", "Fast", "Good", "Slow", "Slower" })
			Me.scrI.Location = New Global.System.Drawing.Point(6, 36)
			Me.scrI.Name = "scrI"
			Me.scrI.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.scrI.Size = New Global.System.Drawing.Size(105, 21)
			Me.scrI.TabIndex = 2
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(3, 200)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(238, 25)
			Me.Button1.TabIndex = 6
			Me.Button1.Text = "Save"
			Me.Button1.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			MyBase.ClientSize = New Global.System.Drawing.Size(244, 231)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.GroupBox6)
			MyBase.Controls.Add(Me.GroupBox5)
			MyBase.Controls.Add(Me.GroupBox4)
			MyBase.Controls.Add(Me.GroupBox3)
			MyBase.Controls.Add(Me.GroupBox2)
			MyBase.Controls.Add(Me.GroupBox1)
			Me.ForeColor = Global.System.Drawing.Color.White
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.MaximizeBox = False
			MyBase.Name = "STNG"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Settings"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.GroupBox4.ResumeLayout(False)
			Me.GroupBox4.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000228 RID: 552
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
