Namespace NJRAT
	' Token: 0x02000012 RID: 18
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class DW
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600010F RID: 271 RVA: 0x0000ADF8 File Offset: 0x00008FF8
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

		' Token: 0x06000110 RID: 272 RVA: 0x0000AE48 File Offset: 0x00009048
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim listViewItem As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("File")
			Dim listViewItem2 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Size")
			Dim listViewItem3 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Speed")
			Dim listViewItem4 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Downloaded")
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Lv1 = New Global.NJRAT.GClass9()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			MyBase.SuspendLayout()
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.ProgressBar1.Location = New Global.System.Drawing.Point(0, 83)
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.Size = New Global.System.Drawing.Size(546, 23)
			Me.ProgressBar1.TabIndex = 0
			Me.Lv1.BackColor = Global.System.Drawing.Color.Black
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
			Me.Lv1.Size = New Global.System.Drawing.Size(546, 83)
			Me.Lv1.TabIndex = 1
			Me.Lv1.UseCompatibleStateImageBehavior = False
			Me.Lv1.View = Global.System.Windows.Forms.View.Details
			Me.Button1.BackColor = Global.System.Drawing.Color.Black
			Me.Button1.Dock = Global.System.Windows.Forms.DockStyle.Right
			Me.Button1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Button1.Location = New Global.System.Drawing.Point(469, 0)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Global.System.Drawing.Size(77, 83)
			Me.Button1.TabIndex = 2
			Me.Button1.Text = "Stop"
			Me.Button1.UseVisualStyleBackColor = False
			Me.Timer1.Interval = 1000
			Me.ColumnHeader1.Width = 79
			Me.ColumnHeader2.Width = 435
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(546, 106)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Controls.Add(Me.Lv1)
			MyBase.Controls.Add(Me.ProgressBar1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.MaximizeBox = False
			MyBase.Name = "DW"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = True
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "DW"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400008C RID: 140
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
