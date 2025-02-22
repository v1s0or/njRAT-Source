Namespace NJRAT
	' Token: 0x0200001D RID: 29
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Manager
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000194 RID: 404 RVA: 0x0000FE78 File Offset: 0x0000E078
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

		' Token: 0x06000195 RID: 405 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Manager))
			Dim listViewItem As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("File Manager", "Icon_5.bmp")
			Dim listViewItem2 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Process Manager", "Icon_8.bmp")
			Dim listViewItem3 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Connections", "Icon_178.bmp")
			Dim listViewItem4 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Registry", "Icon_27.bmp")
			Dim listViewItem5 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Remote Shell", "Icon_1.bmp")
			Dim listViewItem6 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Services", "Icon_274.bmp")
			Me.StatusStrip1 = New Global.System.Windows.Forms.StatusStrip()
			Me.SL = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.pr = New Global.System.Windows.Forms.ToolStripProgressBar()
			Me.M1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.KillToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.KillDeleteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RestartProcessToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.vmethod_26 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.KillConnectionToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.crg = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.EditToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NewValueToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.DeleteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.rimg = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.crgk = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CreateKeyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.DeleteSelectedToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ContextMenuStrip2 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.StopToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PauseToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.StartToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ContextMenuStrip3 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.UPToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RefreshToolStripMenuItem2 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RunToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.DeleteToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.EditToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RenameToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CutToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PasteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.DownloadToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UploadToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NewEmptyFileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NewFolderToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OpenDownloadsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RarToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UnRarToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UploadFromLinkToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ContextMenuStrip4 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshToolStripMenuItem3 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.MG = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.ListView1 = New Global.System.Windows.Forms.ListView()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.vmethod_148 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.vmethod_108 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.FMM = New Global.System.Windows.Forms.Panel()
			Me.LSRV = New Global.NJRAT.GClass9()
			Me.ColumnHeader11 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader12 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader13 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader14 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader15 = New Global.System.Windows.Forms.ColumnHeader()
			Me.LPR = New Global.NJRAT.GClass9()
			Me.ColumnHeader22 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader23 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader24 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader25 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader26 = New Global.System.Windows.Forms.ColumnHeader()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.L1 = New Global.NJRAT.GClass9()
			Me.ColumnHeader6 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader7 = New Global.System.Windows.Forms.ColumnHeader()
			Me.p = New Global.System.Windows.Forms.PictureBox()
			Me.L2 = New Global.NJRAT.GClass9()
			Me.ColumnHeader8 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader9 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader10 = New Global.System.Windows.Forms.ColumnHeader()
			Me.LTCP = New Global.NJRAT.GClass9()
			Me.ColumnHeader16 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader17 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader18 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader19 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader20 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader21 = New Global.System.Windows.Forms.ColumnHeader()
			Me.RG = New Global.System.Windows.Forms.Panel()
			Me.RGLIST = New Global.NJRAT.GClass9()
			Me.ColumnHeader3 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader4 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader5 = New Global.System.Windows.Forms.ColumnHeader()
			Me.RGk = New Global.System.Windows.Forms.TreeView()
			Me.sh = New Global.System.Windows.Forms.Panel()
			Me.T1 = New Global.System.Windows.Forms.RichTextBox()
			Me.T2 = New Global.System.Windows.Forms.TextBox()
			Me.StatusStrip1.SuspendLayout()
			Me.M1.SuspendLayout()
			Me.ContextMenuStrip1.SuspendLayout()
			Me.crg.SuspendLayout()
			Me.crgk.SuspendLayout()
			Me.ContextMenuStrip2.SuspendLayout()
			Me.ContextMenuStrip3.SuspendLayout()
			Me.ContextMenuStrip4.SuspendLayout()
			Me.FMM.SuspendLayout()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.RG.SuspendLayout()
			Me.sh.SuspendLayout()
			MyBase.SuspendLayout()
			Me.StatusStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.StatusStrip1.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.StatusStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.SL, Me.pr })
			Me.StatusStrip1.Location = New Global.System.Drawing.Point(0, 500)
			Me.StatusStrip1.Name = "StatusStrip1"
			Me.StatusStrip1.Padding = New Global.System.Windows.Forms.Padding(2, 0, 21, 0)
			Me.StatusStrip1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.Professional
			Me.StatusStrip1.Size = New Global.System.Drawing.Size(1000, 31)
			Me.StatusStrip1.TabIndex = 0
			Me.StatusStrip1.Text = "StatusStrip1"
			Me.SL.IsLink = True
			Me.SL.Name = "SL"
			Me.SL.Size = New Global.System.Drawing.Size(20, 26)
			Me.SL.Text = ".."
			Me.pr.Name = "pr"
			Me.pr.Size = New Global.System.Drawing.Size(150, 25)
			Me.M1.BackColor = Global.System.Drawing.Color.Black
			Me.M1.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.M1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.KillToolStripMenuItem1, Me.KillDeleteToolStripMenuItem, Me.RestartProcessToolStripMenuItem })
			Me.M1.Name = "M1"
			Me.M1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.M1.Size = New Global.System.Drawing.Size(218, 127)
			Me.KillToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.KillToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("KillToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.KillToolStripMenuItem1.Name = "KillToolStripMenuItem1"
			Me.KillToolStripMenuItem1.Size = New Global.System.Drawing.Size(217, 30)
			Me.KillToolStripMenuItem1.Text = "Kill"
			Me.KillDeleteToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.KillDeleteToolStripMenuItem.Image = CType(componentResourceManager.GetObject("KillDeleteToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.KillDeleteToolStripMenuItem.Name = "KillDeleteToolStripMenuItem"
			Me.KillDeleteToolStripMenuItem.Size = New Global.System.Drawing.Size(217, 30)
			Me.KillDeleteToolStripMenuItem.Text = "Kill + Delete"
			Me.RestartProcessToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RestartProcessToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RestartProcessToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RestartProcessToolStripMenuItem.Name = "RestartProcessToolStripMenuItem"
			Me.RestartProcessToolStripMenuItem.Size = New Global.System.Drawing.Size(217, 30)
			Me.RestartProcessToolStripMenuItem.Text = "Restart Process"
			Me.vmethod_26.Interval = 1000
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList1.Images.SetKeyName(0, "Icon_1.bmp")
			Me.ImageList1.Images.SetKeyName(1, "Icon_5.bmp")
			Me.ImageList1.Images.SetKeyName(2, "Icon_8.bmp")
			Me.ImageList1.Images.SetKeyName(3, "Icon_27.bmp")
			Me.ImageList1.Images.SetKeyName(4, "Icon_178.bmp")
			Me.ImageList1.Images.SetKeyName(5, "Icon_274.bmp")
			Me.ContextMenuStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.ContextMenuStrip1.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.KillConnectionToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Me.ContextMenuStrip1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.ContextMenuStrip1.Size = New Global.System.Drawing.Size(215, 34)
			Me.KillConnectionToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.KillConnectionToolStripMenuItem.Image = CType(componentResourceManager.GetObject("KillConnectionToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.KillConnectionToolStripMenuItem.Name = "KillConnectionToolStripMenuItem"
			Me.KillConnectionToolStripMenuItem.Size = New Global.System.Drawing.Size(214, 30)
			Me.KillConnectionToolStripMenuItem.Text = "Kill Connection"
			Me.crg.BackColor = Global.System.Drawing.Color.Black
			Me.crg.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.crg.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshToolStripMenuItem, Me.EditToolStripMenuItem, Me.NewValueToolStripMenuItem, Me.DeleteToolStripMenuItem })
			Me.crg.Name = "crg"
			Me.crg.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.crg.Size = New Global.System.Drawing.Size(181, 124)
			Me.RefreshToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RefreshToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RefreshToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
			Me.RefreshToolStripMenuItem.Size = New Global.System.Drawing.Size(180, 30)
			Me.RefreshToolStripMenuItem.Text = "Refresh"
			Me.EditToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.EditToolStripMenuItem.Image = CType(componentResourceManager.GetObject("EditToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
			Me.EditToolStripMenuItem.Size = New Global.System.Drawing.Size(180, 30)
			Me.EditToolStripMenuItem.Text = "Edit"
			Me.NewValueToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.NewValueToolStripMenuItem.Image = CType(componentResourceManager.GetObject("NewValueToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.NewValueToolStripMenuItem.Name = "NewValueToolStripMenuItem"
			Me.NewValueToolStripMenuItem.Size = New Global.System.Drawing.Size(180, 30)
			Me.NewValueToolStripMenuItem.Text = "New Value"
			Me.DeleteToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.DeleteToolStripMenuItem.Image = CType(componentResourceManager.GetObject("DeleteToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
			Me.DeleteToolStripMenuItem.Size = New Global.System.Drawing.Size(180, 30)
			Me.DeleteToolStripMenuItem.Text = "Delete"
			Me.rimg.ImageStream = CType(componentResourceManager.GetObject("rimg.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.rimg.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.rimg.Images.SetKeyName(0, "Treetog-Junior-Folder-open.ico")
			Me.rimg.Images.SetKeyName(1, "8.bmp")
			Me.rimg.Images.SetKeyName(2, "9.bmp")
			Me.crgk.BackColor = Global.System.Drawing.Color.Black
			Me.crgk.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.crgk.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshToolStripMenuItem1, Me.CreateKeyToolStripMenuItem, Me.DeleteSelectedToolStripMenuItem })
			Me.crgk.Name = "crgk"
			Me.crgk.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.crgk.Size = New Global.System.Drawing.Size(219, 94)
			Me.RefreshToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RefreshToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("RefreshToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
			Me.RefreshToolStripMenuItem1.Size = New Global.System.Drawing.Size(218, 30)
			Me.RefreshToolStripMenuItem1.Text = "Refresh"
			Me.CreateKeyToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CreateKeyToolStripMenuItem.Image = CType(componentResourceManager.GetObject("CreateKeyToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.CreateKeyToolStripMenuItem.Name = "CreateKeyToolStripMenuItem"
			Me.CreateKeyToolStripMenuItem.Size = New Global.System.Drawing.Size(218, 30)
			Me.CreateKeyToolStripMenuItem.Text = "Create Key"
			Me.DeleteSelectedToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.DeleteSelectedToolStripMenuItem.Image = CType(componentResourceManager.GetObject("DeleteSelectedToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
			Me.DeleteSelectedToolStripMenuItem.Size = New Global.System.Drawing.Size(218, 30)
			Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
			Me.ContextMenuStrip2.BackColor = Global.System.Drawing.Color.Black
			Me.ContextMenuStrip2.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.ContextMenuStrip2.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.StopToolStripMenuItem, Me.PauseToolStripMenuItem, Me.StartToolStripMenuItem })
			Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
			Me.ContextMenuStrip2.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.ContextMenuStrip2.Size = New Global.System.Drawing.Size(144, 94)
			Me.StopToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.StopToolStripMenuItem.Image = CType(componentResourceManager.GetObject("StopToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
			Me.StopToolStripMenuItem.Size = New Global.System.Drawing.Size(143, 30)
			Me.StopToolStripMenuItem.Text = "Stop"
			Me.PauseToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.PauseToolStripMenuItem.Image = CType(componentResourceManager.GetObject("PauseToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
			Me.PauseToolStripMenuItem.Size = New Global.System.Drawing.Size(143, 30)
			Me.PauseToolStripMenuItem.Text = "Pause"
			Me.StartToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.StartToolStripMenuItem.Image = CType(componentResourceManager.GetObject("StartToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
			Me.StartToolStripMenuItem.Size = New Global.System.Drawing.Size(143, 30)
			Me.StartToolStripMenuItem.Text = "Start"
			Me.ContextMenuStrip3.BackColor = Global.System.Drawing.Color.Black
			Me.ContextMenuStrip3.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.ContextMenuStrip3.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.UPToolStripMenuItem, Me.RefreshToolStripMenuItem2, Me.RunToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.EditToolStripMenuItem1, Me.RenameToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DownloadToolStripMenuItem, Me.UploadToolStripMenuItem, Me.NewEmptyFileToolStripMenuItem, Me.NewFolderToolStripMenuItem, Me.OpenDownloadsToolStripMenuItem, Me.RarToolStripMenuItem, Me.UnRarToolStripMenuItem, Me.UploadFromLinkToolStripMenuItem })
			Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
			Me.ContextMenuStrip3.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.ContextMenuStrip3.Size = New Global.System.Drawing.Size(239, 514)
			Me.UPToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.UPToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UPToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UPToolStripMenuItem.Name = "UPToolStripMenuItem"
			Me.UPToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.UPToolStripMenuItem.Text = "UP"
			Me.RefreshToolStripMenuItem2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RefreshToolStripMenuItem2.Image = CType(componentResourceManager.GetObject("RefreshToolStripMenuItem2.Image"), Global.System.Drawing.Image)
			Me.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2"
			Me.RefreshToolStripMenuItem2.Size = New Global.System.Drawing.Size(238, 30)
			Me.RefreshToolStripMenuItem2.Text = "Refresh"
			Me.RunToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RunToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RunToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
			Me.RunToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.RunToolStripMenuItem.Text = "Run"
			Me.DeleteToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.DeleteToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("DeleteToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
			Me.DeleteToolStripMenuItem1.Size = New Global.System.Drawing.Size(238, 30)
			Me.DeleteToolStripMenuItem1.Text = "Delete"
			Me.EditToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.EditToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("EditToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
			Me.EditToolStripMenuItem1.Size = New Global.System.Drawing.Size(238, 30)
			Me.EditToolStripMenuItem1.Text = "Edit"
			Me.RenameToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RenameToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RenameToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
			Me.RenameToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.RenameToolStripMenuItem.Text = "Rename"
			Me.CopyToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CopyToolStripMenuItem.Image = CType(componentResourceManager.GetObject("CopyToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
			Me.CopyToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.CopyToolStripMenuItem.Text = "Copy"
			Me.CutToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CutToolStripMenuItem.Image = CType(componentResourceManager.GetObject("CutToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
			Me.CutToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.CutToolStripMenuItem.Text = "Cut"
			Me.PasteToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.PasteToolStripMenuItem.Image = CType(componentResourceManager.GetObject("PasteToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
			Me.PasteToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.PasteToolStripMenuItem.Text = "Paste"
			Me.DownloadToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.DownloadToolStripMenuItem.Image = CType(componentResourceManager.GetObject("DownloadToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
			Me.DownloadToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.DownloadToolStripMenuItem.Text = "Download"
			Me.UploadToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.UploadToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UploadToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
			Me.UploadToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.UploadToolStripMenuItem.Text = "Upload"
			Me.NewEmptyFileToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.NewEmptyFileToolStripMenuItem.Image = CType(componentResourceManager.GetObject("NewEmptyFileToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.NewEmptyFileToolStripMenuItem.Name = "NewEmptyFileToolStripMenuItem"
			Me.NewEmptyFileToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.NewEmptyFileToolStripMenuItem.Text = "New Empty File"
			Me.NewFolderToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.NewFolderToolStripMenuItem.Image = CType(componentResourceManager.GetObject("NewFolderToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.NewFolderToolStripMenuItem.Name = "NewFolderToolStripMenuItem"
			Me.NewFolderToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.NewFolderToolStripMenuItem.Text = "New Folder"
			Me.OpenDownloadsToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.OpenDownloadsToolStripMenuItem.Image = CType(componentResourceManager.GetObject("OpenDownloadsToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.OpenDownloadsToolStripMenuItem.Name = "OpenDownloadsToolStripMenuItem"
			Me.OpenDownloadsToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.OpenDownloadsToolStripMenuItem.Text = "Open Downloads"
			Me.RarToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RarToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RarToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RarToolStripMenuItem.Name = "RarToolStripMenuItem"
			Me.RarToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.RarToolStripMenuItem.Text = "Rar"
			Me.UnRarToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.UnRarToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UnRarToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UnRarToolStripMenuItem.Name = "UnRarToolStripMenuItem"
			Me.UnRarToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.UnRarToolStripMenuItem.Text = "UnRar"
			Me.UploadFromLinkToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.UploadFromLinkToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UploadFromLinkToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UploadFromLinkToolStripMenuItem.Name = "UploadFromLinkToolStripMenuItem"
			Me.UploadFromLinkToolStripMenuItem.Size = New Global.System.Drawing.Size(238, 30)
			Me.UploadFromLinkToolStripMenuItem.Text = "Upload From Link"
			Me.ContextMenuStrip4.BackColor = Global.System.Drawing.Color.Black
			Me.ContextMenuStrip4.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.ContextMenuStrip4.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshToolStripMenuItem3 })
			Me.ContextMenuStrip4.Name = "ContextMenuStrip4"
			Me.ContextMenuStrip4.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.ContextMenuStrip4.Size = New Global.System.Drawing.Size(157, 34)
			Me.RefreshToolStripMenuItem3.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RefreshToolStripMenuItem3.Image = CType(componentResourceManager.GetObject("RefreshToolStripMenuItem3.Image"), Global.System.Drawing.Image)
			Me.RefreshToolStripMenuItem3.Name = "RefreshToolStripMenuItem3"
			Me.RefreshToolStripMenuItem3.Size = New Global.System.Drawing.Size(156, 30)
			Me.RefreshToolStripMenuItem3.Text = "Refresh"
			Me.MG.ImageStream = CType(componentResourceManager.GetObject("MG.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.MG.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.MG.Images.SetKeyName(0, "Treetog-Junior-Folder-open.ico")
			Me.MG.Images.SetKeyName(1, "Oxygen-Icons.org-Oxygen-Devices-drive-harddisk.ico")
			Me.MG.Images.SetKeyName(2, "Babasse-Bagg-And-Boxs-Lecteur-box-DVD.ico")
			Me.MG.Images.SetKeyName(3, "Aha-Soft-Torrent-Download.ico")
			Me.MG.Images.SetKeyName(4, "6.bmp")
			Me.MG.Images.SetKeyName(5, "Oxygen-Icons.org-Oxygen-Apps-preferences-system-network-sharing.ico")
			Me.ListView1.Activation = Global.System.Windows.Forms.ItemActivation.OneClick
			Me.ListView1.BackColor = Global.System.Drawing.Color.Black
			Me.ListView1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2 })
			Me.ListView1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.ListView1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ListView1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ListView1.HeaderStyle = Global.System.Windows.Forms.ColumnHeaderStyle.None
			Me.ListView1.HotTracking = True
			Me.ListView1.HoverSelection = True
			listViewItem.Tag = ""
			listViewItem2.Tag = "0"
			listViewItem3.Tag = "1"
			listViewItem4.Tag = "2"
			listViewItem5.Tag = "3"
			listViewItem6.Tag = "4"
			Me.ListView1.Items.AddRange(New Global.System.Windows.Forms.ListViewItem() { listViewItem, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 })
			Me.ListView1.LargeImageList = Me.ImageList1
			Me.ListView1.Location = New Global.System.Drawing.Point(0, 0)
			Me.ListView1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.ListView1.MultiSelect = False
			Me.ListView1.Name = "ListView1"
			Me.ListView1.Scrollable = False
			Me.ListView1.Size = New Global.System.Drawing.Size(1000, 78)
			Me.ListView1.SmallImageList = Me.ImageList1
			Me.ListView1.TabIndex = 9
			Me.ListView1.TileSize = New Global.System.Drawing.Size(130, 25)
			Me.ListView1.UseCompatibleStateImageBehavior = False
			Me.ListView1.View = Global.System.Windows.Forms.View.Tile
			Me.vmethod_148.ColorDepth = Global.System.Windows.Forms.ColorDepth.Depth8Bit
			Me.vmethod_148.ImageSize = New Global.System.Drawing.Size(16, 16)
			Me.vmethod_148.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.vmethod_108.ColorDepth = Global.System.Windows.Forms.ColorDepth.Depth32Bit
			Me.vmethod_108.ImageSize = New Global.System.Drawing.Size(20, 20)
			Me.vmethod_108.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.FMM.Controls.Add(Me.LSRV)
			Me.FMM.Controls.Add(Me.LPR)
			Me.FMM.Controls.Add(Me.TextBox1)
			Me.FMM.Controls.Add(Me.L1)
			Me.FMM.Controls.Add(Me.p)
			Me.FMM.Controls.Add(Me.L2)
			Me.FMM.Controls.Add(Me.LTCP)
			Me.FMM.Controls.Add(Me.RG)
			Me.FMM.Controls.Add(Me.sh)
			Me.FMM.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.FMM.Location = New Global.System.Drawing.Point(0, 78)
			Me.FMM.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.FMM.Name = "FMM"
			Me.FMM.Size = New Global.System.Drawing.Size(1000, 422)
			Me.FMM.TabIndex = 49
			Me.LSRV.BackColor = Global.System.Drawing.Color.Black
			Me.LSRV.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15 })
			Me.LSRV.ContextMenuStrip = Me.ContextMenuStrip2
			Me.LSRV.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LSRV.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.LSRV.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.LSRV.FullRowSelect = True
			Me.LSRV.GridLines = True
			Me.LSRV.Location = New Global.System.Drawing.Point(0, 0)
			Me.LSRV.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.LSRV.Name = "LSRV"
			Me.LSRV.OwnerDraw = True
			Me.LSRV.ShowItemToolTips = True
			Me.LSRV.Size = New Global.System.Drawing.Size(1000, 422)
			Me.LSRV.TabIndex = 55
			Me.LSRV.UseCompatibleStateImageBehavior = False
			Me.LSRV.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader11.Text = "Service"
			Me.ColumnHeader12.Text = "Display Name"
			Me.ColumnHeader13.Text = "Type"
			Me.ColumnHeader14.Text = "Status"
			Me.ColumnHeader15.Text = "Can Stop?"
			Me.ColumnHeader15.Width = 756
			Me.LPR.BackColor = Global.System.Drawing.Color.Black
			Me.LPR.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26 })
			Me.LPR.ContextMenuStrip = Me.M1
			Me.LPR.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LPR.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.LPR.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.LPR.FullRowSelect = True
			Me.LPR.GridLines = True
			Me.LPR.Location = New Global.System.Drawing.Point(0, 0)
			Me.LPR.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.LPR.Name = "LPR"
			Me.LPR.OwnerDraw = True
			Me.LPR.ShowItemToolTips = True
			Me.LPR.Size = New Global.System.Drawing.Size(1000, 422)
			Me.LPR.TabIndex = 54
			Me.LPR.UseCompatibleStateImageBehavior = False
			Me.LPR.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader22.Text = "Name"
			Me.ColumnHeader23.Text = "PID"
			Me.ColumnHeader23.Width = 49
			Me.ColumnHeader24.Text = "Directory"
			Me.ColumnHeader24.Width = 116
			Me.ColumnHeader25.Text = "User"
			Me.ColumnHeader26.Text = "CommandLine"
			Me.ColumnHeader26.Width = 711
			Me.TextBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TextBox1.Location = New Global.System.Drawing.Point(291, 0)
			Me.TextBox1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.[ReadOnly] = True
			Me.TextBox1.Size = New Global.System.Drawing.Size(708, 26)
			Me.TextBox1.TabIndex = 32
			Me.L1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.L1.BackColor = Global.System.Drawing.Color.Black
			Me.L1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader6, Me.ColumnHeader7 })
			Me.L1.ContextMenuStrip = Me.ContextMenuStrip4
			Me.L1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.L1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.L1.FullRowSelect = True
			Me.L1.LargeImageList = Me.MG
			Me.L1.Location = New Global.System.Drawing.Point(0, 0)
			Me.L1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.L1.Name = "L1"
			Me.L1.OwnerDraw = True
			Me.L1.Size = New Global.System.Drawing.Size(289, 438)
			Me.L1.SmallImageList = Me.MG
			Me.L1.TabIndex = 21
			Me.L1.UseCompatibleStateImageBehavior = False
			Me.L1.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader6.Text = "Name"
			Me.ColumnHeader6.Width = 106
			Me.ColumnHeader7.Text = "Type"
			Me.ColumnHeader7.Width = 179
			Me.p.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.p.Location = New Global.System.Drawing.Point(585, 175)
			Me.p.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.p.Name = "p"
			Me.p.Size = New Global.System.Drawing.Size(294, 193)
			Me.p.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.p.TabIndex = 31
			Me.p.TabStop = False
			Me.L2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.L2.BackColor = Global.System.Drawing.Color.Black
			Me.L2.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10 })
			Me.L2.ContextMenuStrip = Me.ContextMenuStrip3
			Me.L2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.L2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.L2.FullRowSelect = True
			Me.L2.LargeImageList = Me.vmethod_108
			Me.L2.Location = New Global.System.Drawing.Point(291, 32)
			Me.L2.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.L2.Name = "L2"
			Me.L2.OwnerDraw = True
			Me.L2.ShowItemToolTips = True
			Me.L2.Size = New Global.System.Drawing.Size(708, 387)
			Me.L2.SmallImageList = Me.vmethod_108
			Me.L2.TabIndex = 23
			Me.L2.TileSize = New Global.System.Drawing.Size(60, 40)
			Me.L2.UseCompatibleStateImageBehavior = False
			Me.L2.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader8.Text = "Name"
			Me.ColumnHeader8.Width = 165
			Me.ColumnHeader9.Text = "Size"
			Me.ColumnHeader9.Width = 93
			Me.ColumnHeader10.Text = "Type"
			Me.ColumnHeader10.Width = 446
			Me.LTCP.BackColor = Global.System.Drawing.Color.Black
			Me.LTCP.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21 })
			Me.LTCP.ContextMenuStrip = Me.ContextMenuStrip1
			Me.LTCP.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LTCP.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.LTCP.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.LTCP.FullRowSelect = True
			Me.LTCP.GridLines = True
			Me.LTCP.Location = New Global.System.Drawing.Point(0, 0)
			Me.LTCP.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.LTCP.Name = "LTCP"
			Me.LTCP.OwnerDraw = True
			Me.LTCP.ShowItemToolTips = True
			Me.LTCP.Size = New Global.System.Drawing.Size(1000, 422)
			Me.LTCP.TabIndex = 48
			Me.LTCP.UseCompatibleStateImageBehavior = False
			Me.LTCP.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader16.Text = "LocalIP"
			Me.ColumnHeader17.Text = "LocalPort"
			Me.ColumnHeader18.Text = "RemoteIP"
			Me.ColumnHeader18.Width = 116
			Me.ColumnHeader19.Text = "RemotePort"
			Me.ColumnHeader20.Text = "State"
			Me.ColumnHeader21.Text = "Process"
			Me.ColumnHeader21.Width = 640
			Me.RG.Controls.Add(Me.RGLIST)
			Me.RG.Controls.Add(Me.RGk)
			Me.RG.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.RG.Location = New Global.System.Drawing.Point(0, 0)
			Me.RG.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.RG.Name = "RG"
			Me.RG.Size = New Global.System.Drawing.Size(1000, 422)
			Me.RG.TabIndex = 52
			Me.RGLIST.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.RGLIST.BackColor = Global.System.Drawing.Color.Black
			Me.RGLIST.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5 })
			Me.RGLIST.ContextMenuStrip = Me.crg
			Me.RGLIST.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.RGLIST.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RGLIST.FullRowSelect = True
			Me.RGLIST.LargeImageList = Me.rimg
			Me.RGLIST.Location = New Global.System.Drawing.Point(300, 0)
			Me.RGLIST.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.RGLIST.Name = "RGLIST"
			Me.RGLIST.OwnerDraw = True
			Me.RGLIST.Size = New Global.System.Drawing.Size(698, 420)
			Me.RGLIST.SmallImageList = Me.rimg
			Me.RGLIST.TabIndex = 18
			Me.RGLIST.UseCompatibleStateImageBehavior = False
			Me.RGLIST.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader3.Text = "Name"
			Me.ColumnHeader3.Width = 109
			Me.ColumnHeader4.Text = "Type"
			Me.ColumnHeader4.Width = 109
			Me.ColumnHeader5.Text = "Value"
			Me.ColumnHeader5.Width = 476
			Me.RGk.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.RGk.BackColor = Global.System.Drawing.Color.Black
			Me.RGk.ContextMenuStrip = Me.crgk
			Me.RGk.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RGk.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RGk.ImageIndex = 0
			Me.RGk.ImageList = Me.rimg
			Me.RGk.Location = New Global.System.Drawing.Point(0, 0)
			Me.RGk.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.RGk.Name = "RGk"
			Me.RGk.SelectedImageIndex = 0
			Me.RGk.Size = New Global.System.Drawing.Size(298, 420)
			Me.RGk.TabIndex = 14
			Me.sh.Controls.Add(Me.T1)
			Me.sh.Controls.Add(Me.T2)
			Me.sh.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.sh.Location = New Global.System.Drawing.Point(0, 0)
			Me.sh.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.sh.Name = "sh"
			Me.sh.Size = New Global.System.Drawing.Size(1000, 422)
			Me.sh.TabIndex = 53
			Me.T1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.T1.BackColor = Global.System.Drawing.Color.Black
			Me.T1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.T1.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.T1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.T1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.T1.Location = New Global.System.Drawing.Point(0, 0)
			Me.T1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.T1.Name = "T1"
			Me.T1.[ReadOnly] = True
			Me.T1.Size = New Global.System.Drawing.Size(1000, 386)
			Me.T1.TabIndex = 4
			Me.T1.Text = ""
			Me.T2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.T2.BackColor = Global.System.Drawing.Color.Gray
			Me.T2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.T2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.T2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.T2.Location = New Global.System.Drawing.Point(0, 391)
			Me.T2.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.T2.Name = "T2"
			Me.T2.[ReadOnly] = True
			Me.T2.Size = New Global.System.Drawing.Size(1000, 26)
			Me.T2.TabIndex = 3
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(9F, 20F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(1000, 531)
			MyBase.Controls.Add(Me.FMM)
			MyBase.Controls.Add(Me.ListView1)
			MyBase.Controls.Add(Me.StatusStrip1)
			MyBase.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			MyBase.Name = "Manager"
			MyBase.ShowIcon = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Manager"
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			Me.M1.ResumeLayout(False)
			Me.ContextMenuStrip1.ResumeLayout(False)
			Me.crg.ResumeLayout(False)
			Me.crgk.ResumeLayout(False)
			Me.ContextMenuStrip2.ResumeLayout(False)
			Me.ContextMenuStrip3.ResumeLayout(False)
			Me.ContextMenuStrip4.ResumeLayout(False)
			Me.FMM.ResumeLayout(False)
			Me.FMM.PerformLayout()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.RG.ResumeLayout(False)
			Me.sh.ResumeLayout(False)
			Me.sh.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000103 RID: 259
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
