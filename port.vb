Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x02000022 RID: 34
	<DesignerGenerated()>
	Public Partial Class port
		Inherits Form

		' Token: 0x170000F6 RID: 246
		' (get) Token: 0x060002E0 RID: 736 RVA: 0x0001AC4D File Offset: 0x00018E4D
		' (set) Token: 0x060002E1 RID: 737 RVA: 0x0001AC58 File Offset: 0x00018E58
		Friend Overridable Property TextBox1 As TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextChanged
				Dim textBox As TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, value2
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000F7 RID: 247
		' (get) Token: 0x060002E2 RID: 738 RVA: 0x0001AC9B File Offset: 0x00018E9B
		' (set) Token: 0x060002E3 RID: 739 RVA: 0x0001ACA8 File Offset: 0x00018EA8
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

		' Token: 0x170000F8 RID: 248
		' (get) Token: 0x060002E4 RID: 740 RVA: 0x0001ACEB File Offset: 0x00018EEB
		' (set) Token: 0x060002E5 RID: 741 RVA: 0x0001ACF5 File Offset: 0x00018EF5
		Friend Overridable Property Label1 As Label

		' Token: 0x170000F9 RID: 249
		' (get) Token: 0x060002E6 RID: 742 RVA: 0x0001ACFE File Offset: 0x00018EFE
		' (set) Token: 0x060002E7 RID: 743 RVA: 0x0001AD08 File Offset: 0x00018F08
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

		' Token: 0x060002E8 RID: 744 RVA: 0x0001AD4C File Offset: 0x00018F4C
		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.port_Activated
			AddHandler MyBase.KeyDown, AddressOf Me.port_KeyDown
			AddHandler MyBase.Load, AddressOf Me.port_Load
			Me.port = -1
			Me.InitializeComponent()
		End Sub

		' Token: 0x060002E9 RID: 745 RVA: 0x0001ADA8 File Offset: 0x00018FA8
		Private Sub port_Activated(sender As Object, e As EventArgs)
			Me.TextBox1.Focus()
		End Sub

		' Token: 0x060002EA RID: 746 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		Private Sub port_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				e.SuppressKeyPress = True
				Dim enabled As Boolean = Me.Button1.Enabled
				If enabled Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender)), New EventArgs())
				End If
			Else
				Dim flag2 As Boolean = e.KeyCode = Keys.Escape
				If flag2 Then
					Me.port = -1
					MyBase.Close()
				End If
			End If
		End Sub

		' Token: 0x060002EB RID: 747 RVA: 0x0001AE24 File Offset: 0x00019024
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.port = Conversions.ToInteger(Me.TextBox1.Text)
			MyBase.Close()
		End Sub

		' Token: 0x060002EC RID: 748 RVA: 0x0001AE44 File Offset: 0x00019044
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.port = -1
			MyBase.Close()
		End Sub

		' Token: 0x060002ED RID: 749 RVA: 0x0001AE55 File Offset: 0x00019055
		Private Sub port_Load(sender As Object, e As EventArgs)
			MyBase.Icon = Resources.icon
		End Sub

		' Token: 0x060002EE RID: 750 RVA: 0x0001AE64 File Offset: 0x00019064
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Try
				Dim num As Integer = Conversions.ToInteger(Me.TextBox1.Text)
				Dim flag As Boolean = Conversions.ToInteger(Me.TextBox1.Text) > 65534 Or Conversions.ToInteger(Me.TextBox1.Text) < 1
				If flag Then
					Me.Button1.Enabled = False
				Else
					Me.Button1.Enabled = True
				End If
			Catch ex As Exception
				Me.Button1.Enabled = False
			End Try
		End Sub

		' Token: 0x040001A0 RID: 416
		Public port As Integer
	End Class
End Namespace
