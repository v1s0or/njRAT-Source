Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000013 RID: 19
	<DesignerGenerated()>
	Public Partial Class FromLink
		Inherits Form

		' Token: 0x06000122 RID: 290 RVA: 0x0000B70E File Offset: 0x0000990E
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000068 RID: 104
		' (get) Token: 0x06000125 RID: 293 RVA: 0x0000BBA7 File Offset: 0x00009DA7
		' (set) Token: 0x06000126 RID: 294 RVA: 0x0000BBB4 File Offset: 0x00009DB4
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

		' Token: 0x17000069 RID: 105
		' (get) Token: 0x06000127 RID: 295 RVA: 0x0000BBF7 File Offset: 0x00009DF7
		' (set) Token: 0x06000128 RID: 296 RVA: 0x0000BC04 File Offset: 0x00009E04
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

		' Token: 0x1700006A RID: 106
		' (get) Token: 0x06000129 RID: 297 RVA: 0x0000BC47 File Offset: 0x00009E47
		' (set) Token: 0x0600012A RID: 298 RVA: 0x0000BC54 File Offset: 0x00009E54
		Friend Overridable Property TextBox1 As TextBox
			<CompilerGenerated()>
			Get
				Return Me._TextBox1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextAlignChanged
				Dim textBox As TextBox = Me._TextBox1
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextAlignChanged, value2
				End If
				Me._TextBox1 = value
				textBox = Me._TextBox1
				If textBox IsNot Nothing Then
					AddHandler textBox.TextAlignChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700006B RID: 107
		' (get) Token: 0x0600012B RID: 299 RVA: 0x0000BC97 File Offset: 0x00009E97
		' (set) Token: 0x0600012C RID: 300 RVA: 0x0000BCA1 File Offset: 0x00009EA1
		Friend Overridable Property TextBox2 As TextBox

		' Token: 0x1700006C RID: 108
		' (get) Token: 0x0600012D RID: 301 RVA: 0x0000BCAA File Offset: 0x00009EAA
		' (set) Token: 0x0600012E RID: 302 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		Friend Overridable Property Label1 As Label

		' Token: 0x1700006D RID: 109
		' (get) Token: 0x0600012F RID: 303 RVA: 0x0000BCBD File Offset: 0x00009EBD
		' (set) Token: 0x06000130 RID: 304 RVA: 0x0000BCC7 File Offset: 0x00009EC7
		Friend Overridable Property Label2 As Label

		' Token: 0x06000131 RID: 305 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.IsOK = True
			MyBase.Close()
		End Sub

		' Token: 0x06000132 RID: 306 RVA: 0x0000BCE1 File Offset: 0x00009EE1
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000133 RID: 307 RVA: 0x0000BCEC File Offset: 0x00009EEC
		Private Sub TextBox1_TextAlignChanged(sender As Object, e As EventArgs)
			Try
				Me.TextBox2.Text = Strings.Split(Me.TextBox1.Text, "\", -1, CompareMethod.Binary)(Strings.Split(Me.TextBox1.Text, "\", -1, CompareMethod.Binary).Length - 1)
			Catch ex As Exception
				Me.TextBox2.Text = "File.txt"
			End Try
		End Sub

		' Token: 0x040000A2 RID: 162
		Public IsOK As Boolean
	End Class
End Namespace
