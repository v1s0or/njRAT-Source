Namespace NJRAT
	' Token: 0x02000028 RID: 40
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000371 RID: 881 RVA: 0x0002583C File Offset: 0x00023A3C
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

		' Token: 0x06000372 RID: 882 RVA: 0x0002588C File Offset: 0x00023A8C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Form1))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.StatusStrip1 = New Global.System.Windows.Forms.StatusStrip()
			Me.ToolStripStatusLabel1 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel3 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel5 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel2 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel8 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel4 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel6 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel7 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.conz = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.upl = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.dwn = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.ManagerToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RunFileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FromLinkToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FromDiskToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ScriptToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RemoteDesktopToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RemoteCamToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.MicrophoneToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.GetPasswordsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.KeyloggerToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OpenChatToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ServerToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UpdateToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FromDISKToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FromLINKToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UninstallToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RestartToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CloseToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.DisconnectToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RenameToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OpenFolderToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.IMG2 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.NotifyIcon1 = New Global.System.Windows.Forms.NotifyIcon(Me.components)
			Me.ContextMenuStrip2 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.ShowToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RestartToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ExitToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.L1 = New Global.NJRAT.L1()
			Me.Pp1 = New Global.NJRAT.Pp1()
			Me.StatusStrip1.SuspendLayout()
			Me.ContextMenuStrip1.SuspendLayout()
			Me.ContextMenuStrip2.SuspendLayout()
			CType(Me.L1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Pp1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.StatusStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.StatusStrip1.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.StatusStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.conz, Me.upl, Me.dwn })
			Me.StatusStrip1.Location = New Global.System.Drawing.Point(0, 525)
			Me.StatusStrip1.Name = "StatusStrip1"
			Me.StatusStrip1.Padding = New Global.System.Windows.Forms.Padding(2, 0, 21, 0)
			Me.StatusStrip1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.Professional
			Me.StatusStrip1.Size = New Global.System.Drawing.Size(1298, 30)
			Me.StatusStrip1.SizingGrip = False
			Me.StatusStrip1.TabIndex = 0
			Me.StatusStrip1.Tag = "1"
			Me.StatusStrip1.Text = "StatusStrip1"
			Me.ToolStripStatusLabel1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel1.IsLink = True
			Me.ToolStripStatusLabel1.LinkColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
			Me.ToolStripStatusLabel1.Size = New Global.System.Drawing.Size(70, 25)
			Me.ToolStripStatusLabel1.Tag = "1"
			Me.ToolStripStatusLabel1.Text = "[ Logs ]"
			Me.ToolStripStatusLabel3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel3.ForeColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel3.IsLink = True
			Me.ToolStripStatusLabel3.LinkColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
			Me.ToolStripStatusLabel3.Size = New Global.System.Drawing.Size(87, 25)
			Me.ToolStripStatusLabel3.Text = "[ Builder ]"
			Me.ToolStripStatusLabel5.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel5.ForeColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel5.IsLink = True
			Me.ToolStripStatusLabel5.LinkColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
			Me.ToolStripStatusLabel5.Size = New Global.System.Drawing.Size(96, 25)
			Me.ToolStripStatusLabel5.Text = "[ Settings ]"
			Me.ToolStripStatusLabel2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel2.ForeColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel2.IsLink = True
			Me.ToolStripStatusLabel2.LinkColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
			Me.ToolStripStatusLabel2.Size = New Global.System.Drawing.Size(105, 25)
			Me.ToolStripStatusLabel2.Text = "[ Assembly ]"
			Me.ToolStripStatusLabel8.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel8.ForeColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel8.IsLink = True
			Me.ToolStripStatusLabel8.LinkColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
			Me.ToolStripStatusLabel8.Size = New Global.System.Drawing.Size(77, 25)
			Me.ToolStripStatusLabel8.Text = "[ NO-IP ]"
			Me.ToolStripStatusLabel4.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel4.ForeColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel4.IsLink = True
			Me.ToolStripStatusLabel4.LinkColor = Global.System.Drawing.Color.White
			Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
			Me.ToolStripStatusLabel4.Size = New Global.System.Drawing.Size(77, 25)
			Me.ToolStripStatusLabel4.Text = "[ About ]"
			Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
			Me.ToolStripStatusLabel6.Size = New Global.System.Drawing.Size(184, 25)
			Me.ToolStripStatusLabel6.Text = "ToolStripStatusLabel6"
			Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
			Me.ToolStripStatusLabel7.Size = New Global.System.Drawing.Size(184, 25)
			Me.ToolStripStatusLabel7.Text = "ToolStripStatusLabel7"
			Me.conz.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.conz.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.conz.Name = "conz"
			Me.conz.Size = New Global.System.Drawing.Size(134, 25)
			Me.conz.Text = "Connections [0]"
			Me.upl.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.upl.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.upl.Name = "upl"
			Me.upl.Size = New Global.System.Drawing.Size(140, 25)
			Me.upl.Text = "Upload [0 Bytes]"
			Me.dwn.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dwn.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.dwn.Name = "dwn"
			Me.dwn.Size = New Global.System.Drawing.Size(163, 25)
			Me.dwn.Text = "Download [0 Bytes]"
			Me.ContextMenuStrip1.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.ContextMenuStrip1.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ManagerToolStripMenuItem, Me.RunFileToolStripMenuItem, Me.RemoteDesktopToolStripMenuItem, Me.RemoteCamToolStripMenuItem, Me.MicrophoneToolStripMenuItem, Me.GetPasswordsToolStripMenuItem, Me.KeyloggerToolStripMenuItem, Me.OpenChatToolStripMenuItem, Me.ServerToolStripMenuItem, Me.OpenFolderToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Me.ContextMenuStrip1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.Professional
			Me.ContextMenuStrip1.Size = New Global.System.Drawing.Size(225, 304)
			Me.ManagerToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.ManagerToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ManagerToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ManagerToolStripMenuItem.Image = CType(componentResourceManager.GetObject("ManagerToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem"
			Me.ManagerToolStripMenuItem.Size = New Global.System.Drawing.Size(224, 30)
			Me.ManagerToolStripMenuItem.Text = "Manager"
			Me.RunFileToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.RunFileToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.FromLinkToolStripMenuItem, Me.FromDiskToolStripMenuItem, Me.ScriptToolStripMenuItem })
			Me.RunFileToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RunFileToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RunFileToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RunFileToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RunFileToolStripMenuItem.Name = "RunFileToolStripMenuItem"
			Me.RunFileToolStripMenuItem.Size = New Global.System.Drawing.Size(224, 30)
			Me.RunFileToolStripMenuItem.Text = "Run File"
			Me.FromLinkToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.FromLinkToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.FromLinkToolStripMenuItem.Image = CType(componentResourceManager.GetObject("FromLinkToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.FromLinkToolStripMenuItem.Name = "FromLinkToolStripMenuItem"
			Me.FromLinkToolStripMenuItem.Size = New Global.System.Drawing.Size(171, 30)
			Me.FromLinkToolStripMenuItem.Text = "From Link"
			Me.FromDiskToolStripMenuItem.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.FromDiskToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.FromDiskToolStripMenuItem.Image = CType(componentResourceManager.GetObject("FromDiskToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.FromDiskToolStripMenuItem.Name = "FromDiskToolStripMenuItem"
			Me.FromDiskToolStripMenuItem.Size = New Global.System.Drawing.Size(171, 30)
			Me.FromDiskToolStripMenuItem.Text = "From Disk"
			Me.ScriptToolStripMenuItem.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.ScriptToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ScriptToolStripMenuItem.Image = CType(componentResourceManager.GetObject("ScriptToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.ScriptToolStripMenuItem.Name = "ScriptToolStripMenuItem"
			Me.ScriptToolStripMenuItem.Size = New Global.System.Drawing.Size(171, 30)
			Me.ScriptToolStripMenuItem.Text = "Script"
			Me.RemoteDesktopToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.RemoteDesktopToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RemoteDesktopToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RemoteDesktopToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RemoteDesktopToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RemoteDesktopToolStripMenuItem.Name = "RemoteDesktopToolStripMenuItem"
			Me.RemoteDesktopToolStripMenuItem.Size = New Global.System.Drawing.Size(224, 30)
			Me.RemoteDesktopToolStripMenuItem.Text = "Remote Desktop"
			Me.RemoteCamToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.RemoteCamToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RemoteCamToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RemoteCamToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RemoteCamToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RemoteCamToolStripMenuItem.Name = "RemoteCamToolStripMenuItem"
			Me.RemoteCamToolStripMenuItem.Size = New Global.System.Drawing.Size(224, 30)
			Me.RemoteCamToolStripMenuItem.Text = "Remote Cam"
			Me.MicrophoneToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.MicrophoneToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MicrophoneToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.MicrophoneToolStripMenuItem.Image = CType(componentResourceManager.GetObject("MicrophoneToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.MicrophoneToolStripMenuItem.Name = "MicrophoneToolStripMenuItem"
			Me.MicrophoneToolStripMenuItem.Size = New Global.System.Drawing.Size(224, 30)
			Me.MicrophoneToolStripMenuItem.Text = "Microphone"
			Me.GetPasswordsToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.GetPasswordsToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GetPasswordsToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.GetPasswordsToolStripMenuItem.Image = CType(componentResourceManager.GetObject("GetPasswordsToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.GetPasswordsToolStripMenuItem.Name = "GetPasswordsToolStripMenuItem"
			Me.GetPasswordsToolStripMenuItem.Size = New Global.System.Drawing.Size(224, 30)
			Me.GetPasswordsToolStripMenuItem.Text = "Get Passwords"
			Me.KeyloggerToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.KeyloggerToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.KeyloggerToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.KeyloggerToolStripMenuItem.Image = CType(componentResourceManager.GetObject("KeyloggerToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.KeyloggerToolStripMenuItem.Name = "KeyloggerToolStripMenuItem"
			Me.KeyloggerToolStripMenuItem.Size = New Global.System.Drawing.Size(224, 30)
			Me.KeyloggerToolStripMenuItem.Text = "Keylogger"
			Me.OpenChatToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.OpenChatToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.OpenChatToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.OpenChatToolStripMenuItem.Image = CType(componentResourceManager.GetObject("OpenChatToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.OpenChatToolStripMenuItem.Name = "OpenChatToolStripMenuItem"
			Me.OpenChatToolStripMenuItem.Size = New Global.System.Drawing.Size(224, 30)
			Me.OpenChatToolStripMenuItem.Text = "Open Chat"
			Me.ServerToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.ServerToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.UpdateToolStripMenuItem, Me.UninstallToolStripMenuItem, Me.RestartToolStripMenuItem, Me.CloseToolStripMenuItem, Me.DisconnectToolStripMenuItem, Me.RenameToolStripMenuItem })
			Me.ServerToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ServerToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ServerToolStripMenuItem.Image = CType(componentResourceManager.GetObject("ServerToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
			Me.ServerToolStripMenuItem.Size = New Global.System.Drawing.Size(224, 30)
			Me.ServerToolStripMenuItem.Text = "Server"
			Me.UpdateToolStripMenuItem.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.FromDISKToolStripMenuItem1, Me.FromLINKToolStripMenuItem1 })
			Me.UpdateToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.UpdateToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UpdateToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
			Me.UpdateToolStripMenuItem.Size = New Global.System.Drawing.Size(179, 30)
			Me.UpdateToolStripMenuItem.Text = "Update"
			Me.FromDISKToolStripMenuItem1.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.FromDISKToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.FromDISKToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("FromDISKToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.FromDISKToolStripMenuItem1.Name = "FromDISKToolStripMenuItem1"
			Me.FromDISKToolStripMenuItem1.Size = New Global.System.Drawing.Size(176, 30)
			Me.FromDISKToolStripMenuItem1.Text = "From DISK"
			Me.FromLINKToolStripMenuItem1.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.FromLINKToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.FromLINKToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("FromLINKToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.FromLINKToolStripMenuItem1.Name = "FromLINKToolStripMenuItem1"
			Me.FromLINKToolStripMenuItem1.Size = New Global.System.Drawing.Size(176, 30)
			Me.FromLINKToolStripMenuItem1.Text = "From LINK"
			Me.UninstallToolStripMenuItem.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.UninstallToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.UninstallToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UninstallToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UninstallToolStripMenuItem.Name = "UninstallToolStripMenuItem"
			Me.UninstallToolStripMenuItem.Size = New Global.System.Drawing.Size(179, 30)
			Me.UninstallToolStripMenuItem.Text = "Uninstall"
			Me.RestartToolStripMenuItem.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.RestartToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RestartToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RestartToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
			Me.RestartToolStripMenuItem.Size = New Global.System.Drawing.Size(179, 30)
			Me.RestartToolStripMenuItem.Text = "Restart"
			Me.CloseToolStripMenuItem.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.CloseToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.CloseToolStripMenuItem.Image = CType(componentResourceManager.GetObject("CloseToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
			Me.CloseToolStripMenuItem.Size = New Global.System.Drawing.Size(179, 30)
			Me.CloseToolStripMenuItem.Text = "Close"
			Me.DisconnectToolStripMenuItem.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.DisconnectToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.DisconnectToolStripMenuItem.Image = CType(componentResourceManager.GetObject("DisconnectToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
			Me.DisconnectToolStripMenuItem.Size = New Global.System.Drawing.Size(179, 30)
			Me.DisconnectToolStripMenuItem.Text = "Disconnect"
			Me.RenameToolStripMenuItem.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.RenameToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RenameToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RenameToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
			Me.RenameToolStripMenuItem.Size = New Global.System.Drawing.Size(179, 30)
			Me.RenameToolStripMenuItem.Text = "Rename"
			Me.OpenFolderToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.OpenFolderToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.OpenFolderToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.OpenFolderToolStripMenuItem.Image = CType(componentResourceManager.GetObject("OpenFolderToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
			Me.OpenFolderToolStripMenuItem.Size = New Global.System.Drawing.Size(224, 30)
			Me.OpenFolderToolStripMenuItem.Text = "Open Folder"
			Me.IMG2.ImageStream = CType(componentResourceManager.GetObject("IMG2.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.IMG2.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.IMG2.Images.SetKeyName(0, "--.png")
			Me.IMG2.Images.SetKeyName(1, "AD.png")
			Me.IMG2.Images.SetKeyName(2, "AE.png")
			Me.IMG2.Images.SetKeyName(3, "AF.png")
			Me.IMG2.Images.SetKeyName(4, "AG.png")
			Me.IMG2.Images.SetKeyName(5, "AI.png")
			Me.IMG2.Images.SetKeyName(6, "AL.png")
			Me.IMG2.Images.SetKeyName(7, "AM.png")
			Me.IMG2.Images.SetKeyName(8, "AN.png")
			Me.IMG2.Images.SetKeyName(9, "AO.png")
			Me.IMG2.Images.SetKeyName(10, "AQ.png")
			Me.IMG2.Images.SetKeyName(11, "AR.png")
			Me.IMG2.Images.SetKeyName(12, "AS.png")
			Me.IMG2.Images.SetKeyName(13, "AT.png")
			Me.IMG2.Images.SetKeyName(14, "AU.png")
			Me.IMG2.Images.SetKeyName(15, "AW.png")
			Me.IMG2.Images.SetKeyName(16, "AX.png")
			Me.IMG2.Images.SetKeyName(17, "AZ.png")
			Me.IMG2.Images.SetKeyName(18, "BA.png")
			Me.IMG2.Images.SetKeyName(19, "BB.png")
			Me.IMG2.Images.SetKeyName(20, "BD.png")
			Me.IMG2.Images.SetKeyName(21, "BE.png")
			Me.IMG2.Images.SetKeyName(22, "BF.png")
			Me.IMG2.Images.SetKeyName(23, "BG.png")
			Me.IMG2.Images.SetKeyName(24, "BH.png")
			Me.IMG2.Images.SetKeyName(25, "BI.png")
			Me.IMG2.Images.SetKeyName(26, "BJ.png")
			Me.IMG2.Images.SetKeyName(27, "BL.png")
			Me.IMG2.Images.SetKeyName(28, "BM.png")
			Me.IMG2.Images.SetKeyName(29, "BN.png")
			Me.IMG2.Images.SetKeyName(30, "BO.png")
			Me.IMG2.Images.SetKeyName(31, "BR.png")
			Me.IMG2.Images.SetKeyName(32, "BS.png")
			Me.IMG2.Images.SetKeyName(33, "BT.png")
			Me.IMG2.Images.SetKeyName(34, "BW.png")
			Me.IMG2.Images.SetKeyName(35, "BY.png")
			Me.IMG2.Images.SetKeyName(36, "BZ.png")
			Me.IMG2.Images.SetKeyName(37, "CA.png")
			Me.IMG2.Images.SetKeyName(38, "CC.png")
			Me.IMG2.Images.SetKeyName(39, "CD.png")
			Me.IMG2.Images.SetKeyName(40, "CF.png")
			Me.IMG2.Images.SetKeyName(41, "CG.png")
			Me.IMG2.Images.SetKeyName(42, "CH.png")
			Me.IMG2.Images.SetKeyName(43, "CI.png")
			Me.IMG2.Images.SetKeyName(44, "CK.png")
			Me.IMG2.Images.SetKeyName(45, "CL.png")
			Me.IMG2.Images.SetKeyName(46, "CM.png")
			Me.IMG2.Images.SetKeyName(47, "CN.png")
			Me.IMG2.Images.SetKeyName(48, "CO.png")
			Me.IMG2.Images.SetKeyName(49, "CR.png")
			Me.IMG2.Images.SetKeyName(50, "CU.png")
			Me.IMG2.Images.SetKeyName(51, "CV.png")
			Me.IMG2.Images.SetKeyName(52, "CW.png")
			Me.IMG2.Images.SetKeyName(53, "CX.png")
			Me.IMG2.Images.SetKeyName(54, "CY.png")
			Me.IMG2.Images.SetKeyName(55, "CZ.png")
			Me.IMG2.Images.SetKeyName(56, "DE.png")
			Me.IMG2.Images.SetKeyName(57, "DJ.png")
			Me.IMG2.Images.SetKeyName(58, "DK.png")
			Me.IMG2.Images.SetKeyName(59, "DM.png")
			Me.IMG2.Images.SetKeyName(60, "DO.png")
			Me.IMG2.Images.SetKeyName(61, "DZ.png")
			Me.IMG2.Images.SetKeyName(62, "EC.png")
			Me.IMG2.Images.SetKeyName(63, "EE.png")
			Me.IMG2.Images.SetKeyName(64, "EG.png")
			Me.IMG2.Images.SetKeyName(65, "EH.png")
			Me.IMG2.Images.SetKeyName(66, "ER.png")
			Me.IMG2.Images.SetKeyName(67, "ES.png")
			Me.IMG2.Images.SetKeyName(68, "ET.png")
			Me.IMG2.Images.SetKeyName(69, "EU.png")
			Me.IMG2.Images.SetKeyName(70, "FI.png")
			Me.IMG2.Images.SetKeyName(71, "FJ.png")
			Me.IMG2.Images.SetKeyName(72, "FK.png")
			Me.IMG2.Images.SetKeyName(73, "FM.png")
			Me.IMG2.Images.SetKeyName(74, "FO.png")
			Me.IMG2.Images.SetKeyName(75, "FR.png")
			Me.IMG2.Images.SetKeyName(76, "GA.png")
			Me.IMG2.Images.SetKeyName(77, "GB.png")
			Me.IMG2.Images.SetKeyName(78, "GD.png")
			Me.IMG2.Images.SetKeyName(79, "GE.png")
			Me.IMG2.Images.SetKeyName(80, "GG.png")
			Me.IMG2.Images.SetKeyName(81, "GH.png")
			Me.IMG2.Images.SetKeyName(82, "GI.png")
			Me.IMG2.Images.SetKeyName(83, "GL.png")
			Me.IMG2.Images.SetKeyName(84, "GM.png")
			Me.IMG2.Images.SetKeyName(85, "GN.png")
			Me.IMG2.Images.SetKeyName(86, "GQ.png")
			Me.IMG2.Images.SetKeyName(87, "GR.png")
			Me.IMG2.Images.SetKeyName(88, "GS.png")
			Me.IMG2.Images.SetKeyName(89, "GT.png")
			Me.IMG2.Images.SetKeyName(90, "GU.png")
			Me.IMG2.Images.SetKeyName(91, "GW.png")
			Me.IMG2.Images.SetKeyName(92, "GY.png")
			Me.IMG2.Images.SetKeyName(93, "HK.png")
			Me.IMG2.Images.SetKeyName(94, "HN.png")
			Me.IMG2.Images.SetKeyName(95, "HR.png")
			Me.IMG2.Images.SetKeyName(96, "HT.png")
			Me.IMG2.Images.SetKeyName(97, "HU.png")
			Me.IMG2.Images.SetKeyName(98, "IC.png")
			Me.IMG2.Images.SetKeyName(99, "ID.png")
			Me.IMG2.Images.SetKeyName(100, "IE.png")
			Me.IMG2.Images.SetKeyName(101, "IL.png")
			Me.IMG2.Images.SetKeyName(102, "IM.png")
			Me.IMG2.Images.SetKeyName(103, "IN.png")
			Me.IMG2.Images.SetKeyName(104, "IQ.png")
			Me.IMG2.Images.SetKeyName(105, "IR.png")
			Me.IMG2.Images.SetKeyName(106, "IS.png")
			Me.IMG2.Images.SetKeyName(107, "IT.png")
			Me.IMG2.Images.SetKeyName(108, "JE.png")
			Me.IMG2.Images.SetKeyName(109, "JM.png")
			Me.IMG2.Images.SetKeyName(110, "JO.png")
			Me.IMG2.Images.SetKeyName(111, "JP.png")
			Me.IMG2.Images.SetKeyName(112, "KE.png")
			Me.IMG2.Images.SetKeyName(113, "KG.png")
			Me.IMG2.Images.SetKeyName(114, "KH.png")
			Me.IMG2.Images.SetKeyName(115, "KI.png")
			Me.IMG2.Images.SetKeyName(116, "KM.png")
			Me.IMG2.Images.SetKeyName(117, "KN.png")
			Me.IMG2.Images.SetKeyName(118, "KP.png")
			Me.IMG2.Images.SetKeyName(119, "KR.png")
			Me.IMG2.Images.SetKeyName(120, "KW.png")
			Me.IMG2.Images.SetKeyName(121, "KY.png")
			Me.IMG2.Images.SetKeyName(122, "KZ.png")
			Me.IMG2.Images.SetKeyName(123, "LA.png")
			Me.IMG2.Images.SetKeyName(124, "LB.png")
			Me.IMG2.Images.SetKeyName(125, "LC.png")
			Me.IMG2.Images.SetKeyName(126, "LI.png")
			Me.IMG2.Images.SetKeyName(127, "LK.png")
			Me.IMG2.Images.SetKeyName(128, "LR.png")
			Me.IMG2.Images.SetKeyName(129, "LS.png")
			Me.IMG2.Images.SetKeyName(130, "LT.png")
			Me.IMG2.Images.SetKeyName(131, "LU.png")
			Me.IMG2.Images.SetKeyName(132, "LV.png")
			Me.IMG2.Images.SetKeyName(133, "LY.png")
			Me.IMG2.Images.SetKeyName(134, "MA.png")
			Me.IMG2.Images.SetKeyName(135, "MC.png")
			Me.IMG2.Images.SetKeyName(136, "MD.png")
			Me.IMG2.Images.SetKeyName(137, "ME.png")
			Me.IMG2.Images.SetKeyName(138, "MF.png")
			Me.IMG2.Images.SetKeyName(139, "MG.png")
			Me.IMG2.Images.SetKeyName(140, "MH.png")
			Me.IMG2.Images.SetKeyName(141, "MK.png")
			Me.IMG2.Images.SetKeyName(142, "ML.png")
			Me.IMG2.Images.SetKeyName(143, "MM.png")
			Me.IMG2.Images.SetKeyName(144, "MN.png")
			Me.IMG2.Images.SetKeyName(145, "MO.png")
			Me.IMG2.Images.SetKeyName(146, "MP.png")
			Me.IMG2.Images.SetKeyName(147, "MQ.png")
			Me.IMG2.Images.SetKeyName(148, "MR.png")
			Me.IMG2.Images.SetKeyName(149, "MS.png")
			Me.IMG2.Images.SetKeyName(150, "MT.png")
			Me.IMG2.Images.SetKeyName(151, "MU.png")
			Me.IMG2.Images.SetKeyName(152, "MV.png")
			Me.IMG2.Images.SetKeyName(153, "MW.png")
			Me.IMG2.Images.SetKeyName(154, "MX.png")
			Me.IMG2.Images.SetKeyName(155, "MY.png")
			Me.IMG2.Images.SetKeyName(156, "MZ.png")
			Me.IMG2.Images.SetKeyName(157, "NA.png")
			Me.IMG2.Images.SetKeyName(158, "NC.png")
			Me.IMG2.Images.SetKeyName(159, "NE.png")
			Me.IMG2.Images.SetKeyName(160, "NF.png")
			Me.IMG2.Images.SetKeyName(161, "NG.png")
			Me.IMG2.Images.SetKeyName(162, "NI.png")
			Me.IMG2.Images.SetKeyName(163, "NL.png")
			Me.IMG2.Images.SetKeyName(164, "NO.png")
			Me.IMG2.Images.SetKeyName(165, "NP.png")
			Me.IMG2.Images.SetKeyName(166, "NR.png")
			Me.IMG2.Images.SetKeyName(167, "NU.png")
			Me.IMG2.Images.SetKeyName(168, "NZ.png")
			Me.IMG2.Images.SetKeyName(169, "OM.png")
			Me.IMG2.Images.SetKeyName(170, "PA.png")
			Me.IMG2.Images.SetKeyName(171, "PE.png")
			Me.IMG2.Images.SetKeyName(172, "PF.png")
			Me.IMG2.Images.SetKeyName(173, "PG.png")
			Me.IMG2.Images.SetKeyName(174, "PH.png")
			Me.IMG2.Images.SetKeyName(175, "PK.png")
			Me.IMG2.Images.SetKeyName(176, "PL.png")
			Me.IMG2.Images.SetKeyName(177, "PN.png")
			Me.IMG2.Images.SetKeyName(178, "PR.png")
			Me.IMG2.Images.SetKeyName(179, "PS.png")
			Me.IMG2.Images.SetKeyName(180, "PT.png")
			Me.IMG2.Images.SetKeyName(181, "PW.png")
			Me.IMG2.Images.SetKeyName(182, "PY.png")
			Me.IMG2.Images.SetKeyName(183, "QA.png")
			Me.IMG2.Images.SetKeyName(184, "RO.png")
			Me.IMG2.Images.SetKeyName(185, "RS.png")
			Me.IMG2.Images.SetKeyName(186, "RU.png")
			Me.IMG2.Images.SetKeyName(187, "RW.png")
			Me.IMG2.Images.SetKeyName(188, "SA.png")
			Me.IMG2.Images.SetKeyName(189, "SB.png")
			Me.IMG2.Images.SetKeyName(190, "SC.png")
			Me.IMG2.Images.SetKeyName(191, "SD.png")
			Me.IMG2.Images.SetKeyName(192, "SE.png")
			Me.IMG2.Images.SetKeyName(193, "SG.png")
			Me.IMG2.Images.SetKeyName(194, "SH.png")
			Me.IMG2.Images.SetKeyName(195, "SI.png")
			Me.IMG2.Images.SetKeyName(196, "SK.png")
			Me.IMG2.Images.SetKeyName(197, "SL.png")
			Me.IMG2.Images.SetKeyName(198, "SM.png")
			Me.IMG2.Images.SetKeyName(199, "SN.png")
			Me.IMG2.Images.SetKeyName(200, "SO.png")
			Me.IMG2.Images.SetKeyName(201, "SR.png")
			Me.IMG2.Images.SetKeyName(202, "SS.png")
			Me.IMG2.Images.SetKeyName(203, "ST.png")
			Me.IMG2.Images.SetKeyName(204, "SV.png")
			Me.IMG2.Images.SetKeyName(205, "SY.png")
			Me.IMG2.Images.SetKeyName(206, "SZ.png")
			Me.IMG2.Images.SetKeyName(207, "TC.png")
			Me.IMG2.Images.SetKeyName(208, "TD.png")
			Me.IMG2.Images.SetKeyName(209, "TF.png")
			Me.IMG2.Images.SetKeyName(210, "TG.png")
			Me.IMG2.Images.SetKeyName(211, "TH.png")
			Me.IMG2.Images.SetKeyName(212, "TJ.png")
			Me.IMG2.Images.SetKeyName(213, "TK.png")
			Me.IMG2.Images.SetKeyName(214, "TL.png")
			Me.IMG2.Images.SetKeyName(215, "TM.png")
			Me.IMG2.Images.SetKeyName(216, "TN.png")
			Me.IMG2.Images.SetKeyName(217, "TO.png")
			Me.IMG2.Images.SetKeyName(218, "TR.png")
			Me.IMG2.Images.SetKeyName(219, "TT.png")
			Me.IMG2.Images.SetKeyName(220, "TV.png")
			Me.IMG2.Images.SetKeyName(221, "TW.png")
			Me.IMG2.Images.SetKeyName(222, "TZ.png")
			Me.IMG2.Images.SetKeyName(223, "UA.png")
			Me.IMG2.Images.SetKeyName(224, "UG.png")
			Me.IMG2.Images.SetKeyName(225, "UN.png")
			Me.IMG2.Images.SetKeyName(226, "US.png")
			Me.IMG2.Images.SetKeyName(227, "UY.png")
			Me.IMG2.Images.SetKeyName(228, "UZ.png")
			Me.IMG2.Images.SetKeyName(229, "VA.png")
			Me.IMG2.Images.SetKeyName(230, "VC.png")
			Me.IMG2.Images.SetKeyName(231, "VE.png")
			Me.IMG2.Images.SetKeyName(232, "VG.png")
			Me.IMG2.Images.SetKeyName(233, "VI.png")
			Me.IMG2.Images.SetKeyName(234, "VN.png")
			Me.IMG2.Images.SetKeyName(235, "VU.png")
			Me.IMG2.Images.SetKeyName(236, "WF.png")
			Me.IMG2.Images.SetKeyName(237, "WS.png")
			Me.IMG2.Images.SetKeyName(238, "YE.png")
			Me.IMG2.Images.SetKeyName(239, "YT.png")
			Me.IMG2.Images.SetKeyName(240, "ZA.png")
			Me.IMG2.Images.SetKeyName(241, "ZM.png")
			Me.IMG2.Images.SetKeyName(242, "ZW.png")
			Me.NotifyIcon1.BalloonTipIcon = Global.System.Windows.Forms.ToolTipIcon.Info
			Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip2
			Me.NotifyIcon1.Icon = CType(componentResourceManager.GetObject("NotifyIcon1.Icon"), Global.System.Drawing.Icon)
			Me.NotifyIcon1.Text = "NotifyIcon1"
			Me.NotifyIcon1.Visible = True
			Me.ContextMenuStrip2.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.ContextMenuStrip2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ContextMenuStrip2.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.ContextMenuStrip2.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ShowToolStripMenuItem, Me.RestartToolStripMenuItem1, Me.ExitToolStripMenuItem })
			Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
			Me.ContextMenuStrip2.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.ContextMenuStrip2.Size = New Global.System.Drawing.Size(150, 94)
			Me.ShowToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
			Me.ShowToolStripMenuItem.Size = New Global.System.Drawing.Size(149, 30)
			Me.ShowToolStripMenuItem.Text = "Show"
			Me.RestartToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.RestartToolStripMenuItem1.Name = "RestartToolStripMenuItem1"
			Me.RestartToolStripMenuItem1.Size = New Global.System.Drawing.Size(149, 30)
			Me.RestartToolStripMenuItem1.Text = "Restart"
			Me.ExitToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
			Me.ExitToolStripMenuItem.Size = New Global.System.Drawing.Size(149, 30)
			Me.ExitToolStripMenuItem.Text = "Exit"
			Me.Timer1.Enabled = True
			Me.L1.AllowUserToAddRows = False
			Me.L1.AllowUserToDeleteRows = False
			Me.L1.BackgroundColor = Global.System.Drawing.Color.Black
			Me.L1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.L1.ClipboardCopyMode = Global.System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
			Me.L1.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.L1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.L1.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.L1.ContextMenuStrip = Me.ContextMenuStrip1
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.L1.DefaultCellStyle = dataGridViewCellStyle2
			Me.L1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.L1.EnableHeadersVisualStyles = False
			Me.L1.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.L1.GridColor = Global.System.Drawing.Color.LightSteelBlue
			Me.L1.Location = New Global.System.Drawing.Point(0, 0)
			Me.L1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.L1.Name = "L1"
			Me.L1.[ReadOnly] = True
			Me.L1.RowHeadersVisible = False
			Me.L1.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.L1.ShowCellErrors = False
			Me.L1.ShowEditingIcon = False
			Me.L1.ShowRowErrors = False
			Me.L1.Size = New Global.System.Drawing.Size(1298, 525)
			Me.L1.TabIndex = 2
			Me.Pp1.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Pp1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Pp1.Location = New Global.System.Drawing.Point(0, 0)
			Me.Pp1.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Pp1.Name = "Pp1"
			Me.Pp1.Size = New Global.System.Drawing.Size(1298, 555)
			Me.Pp1.TabIndex = 3
			Me.Pp1.TabStop = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(9F, 20F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(1298, 555)
			MyBase.Controls.Add(Me.L1)
			MyBase.Controls.Add(Me.StatusStrip1)
			MyBase.Controls.Add(Me.Pp1)
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			MyBase.Name = "Form1"
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			Me.ContextMenuStrip1.ResumeLayout(False)
			Me.ContextMenuStrip2.ResumeLayout(False)
			CType(Me.L1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Pp1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040001F2 RID: 498
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
