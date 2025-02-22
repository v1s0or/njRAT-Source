Namespace NJRAT
	' Token: 0x0200002E RID: 46
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class up
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000427 RID: 1063 RVA: 0x0002C6D8 File Offset: 0x0002A8D8
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

		' Token: 0x06000428 RID: 1064 RVA: 0x0002C728 File Offset: 0x0002A928
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim listViewItem As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("File")
			Dim listViewItem2 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Size")
			Dim listViewItem3 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Speed")
			Dim listViewItem4 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Uploaded")
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.vmethod_4 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Lv1 = New Global.NJRAT.GClass9()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			MyBase.SuspendLayout()
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.ProgressBar1.Location = New Global.System.Drawing.Point(0, 73)
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.Size = New Global.System.Drawing.Size(581, 23)
			Me.ProgressBar1.TabIndex = 0
			Me.Button1.Dock = Global.System.Windows.Forms.DockStyle.Right
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(506, 0)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(75, 73)
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Satrt"
			Me.Button1.UseVisualStyleBackColor = True
			Me.vmethod_4.Interval = 1000
			Me.Lv1.BackColor = Global.System.Drawing.Color.Black
			Me.Lv1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.Lv1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2 })
			Me.Lv1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Lv1.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Lv1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Lv1.FullRowSelect = True
			Me.Lv1.GridLines = True
			Me.Lv1.HeaderStyle = Global.System.Windows.Forms.ColumnHeaderStyle.None
			Me.Lv1.Items.AddRange(New Global.System.Windows.Forms.ListViewItem() { listViewItem, listViewItem2, listViewItem3, listViewItem4 })
			Me.Lv1.Location = New Global.System.Drawing.Point(0, 0)
			Me.Lv1.Name = "Lv1"
			Me.Lv1.OwnerDraw = True
			Me.Lv1.Size = New Global.System.Drawing.Size(581, 73)
			Me.Lv1.TabIndex = 1
			Me.Lv1.UseCompatibleStateImageBehavior = False
			Me.Lv1.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader2.Width = 435
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(581, 96)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.Lv1)
			MyBase.Controls.Add(Me.ProgressBar1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.MaximizeBox = False
			MyBase.Name = "up"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "up"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000240 RID: 576
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
