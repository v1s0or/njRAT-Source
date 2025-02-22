Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000014 RID: 20
	<DesignerGenerated()>
	Public Partial Class FURL
		Inherits Form

		' Token: 0x1700006E RID: 110
		' (get) Token: 0x06000136 RID: 310 RVA: 0x0000C283 File Offset: 0x0000A483
		' (set) Token: 0x06000137 RID: 311 RVA: 0x0000C28D File Offset: 0x0000A48D
		Friend Overridable Property Label2 As Label

		' Token: 0x1700006F RID: 111
		' (get) Token: 0x06000138 RID: 312 RVA: 0x0000C296 File Offset: 0x0000A496
		' (set) Token: 0x06000139 RID: 313 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		Friend Overridable Property Label1 As Label

		' Token: 0x17000070 RID: 112
		' (get) Token: 0x0600013A RID: 314 RVA: 0x0000C2A9 File Offset: 0x0000A4A9
		' (set) Token: 0x0600013B RID: 315 RVA: 0x0000C2B3 File Offset: 0x0000A4B3
		Friend Overridable Property TextBox2 As TextBox

		' Token: 0x17000071 RID: 113
		' (get) Token: 0x0600013C RID: 316 RVA: 0x0000C2BC File Offset: 0x0000A4BC
		' (set) Token: 0x0600013D RID: 317 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		Friend Overridable Property TextBox1 As TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextAlignChanged
				Dim value3 As EventHandler = AddressOf Me.TextBox1_TextChanged
				Dim textBox As TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextAlignChanged, value2
					RemoveHandler textBox.TextChanged, value3
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.TextAlignChanged, value2
					AddHandler textBox.TextChanged, value3
				End If
			End Set
		End Property

		' Token: 0x17000072 RID: 114
		' (get) Token: 0x0600013E RID: 318 RVA: 0x0000C326 File Offset: 0x0000A526
		' (set) Token: 0x0600013F RID: 319 RVA: 0x0000C330 File Offset: 0x0000A530
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

		' Token: 0x17000073 RID: 115
		' (get) Token: 0x06000140 RID: 320 RVA: 0x0000C373 File Offset: 0x0000A573
		' (set) Token: 0x06000141 RID: 321 RVA: 0x0000C380 File Offset: 0x0000A580
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

		' Token: 0x06000142 RID: 322 RVA: 0x0000C3C3 File Offset: 0x0000A5C3
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.FURL_KeyDown
			Me.IsOK = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000143 RID: 323 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		Private Sub FURL_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender)), e)
			End If
		End Sub

		' Token: 0x06000144 RID: 324 RVA: 0x0000C421 File Offset: 0x0000A621
		Private Sub TextBox1_TextAlignChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000145 RID: 325 RVA: 0x0000C424 File Offset: 0x0000A624
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.TextBox1.Text.Length > 0 And Me.TextBox1.Text.ToLower().StartsWith("http") And Me.TextBox2.TextLength > 0
			If flag Then
				Me.IsOK = True
				MyBase.Close()
			End If
		End Sub

		' Token: 0x06000146 RID: 326 RVA: 0x0000BCE1 File Offset: 0x00009EE1
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000147 RID: 327 RVA: 0x0000C484 File Offset: 0x0000A684
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Try
				Me.TextBox2.Text = Strings.Split(Me.TextBox1.Text, ".", -1, CompareMethod.Binary)(Strings.Split(Me.TextBox1.Text, ".", -1, CompareMethod.Binary).Length - 1)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x040000AA RID: 170
		Public IsOK As Boolean
	End Class
End Namespace
