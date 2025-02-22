Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public Partial Class Mynoip
		Inherits Form

		' Token: 0x06000069 RID: 105 RVA: 0x0000471F File Offset: 0x0000291F
		Public Sub New()
			Me.wc = New WebClient()
			Me.utf8 = New UTF8Encoding()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x0600006C RID: 108 RVA: 0x00004F2C File Offset: 0x0000312C
		' (set) Token: 0x0600006D RID: 109 RVA: 0x00004F36 File Offset: 0x00003136
		Friend Overridable Property Label1 As Label

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x0600006E RID: 110 RVA: 0x00004F3F File Offset: 0x0000313F
		' (set) Token: 0x0600006F RID: 111 RVA: 0x00004F49 File Offset: 0x00003149
		Friend Overridable Property Label2 As Label

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x06000070 RID: 112 RVA: 0x00004F52 File Offset: 0x00003152
		' (set) Token: 0x06000071 RID: 113 RVA: 0x00004F5C File Offset: 0x0000315C
		Friend Overridable Property Label3 As Label

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x06000072 RID: 114 RVA: 0x00004F65 File Offset: 0x00003165
		' (set) Token: 0x06000073 RID: 115 RVA: 0x00004F6F File Offset: 0x0000316F
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x06000074 RID: 116 RVA: 0x00004F78 File Offset: 0x00003178
		' (set) Token: 0x06000075 RID: 117 RVA: 0x00004F82 File Offset: 0x00003182
		Friend Overridable Property TextBox2 As TextBox

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x06000076 RID: 118 RVA: 0x00004F8B File Offset: 0x0000318B
		' (set) Token: 0x06000077 RID: 119 RVA: 0x00004F95 File Offset: 0x00003195
		Friend Overridable Property TextBox3 As TextBox

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x06000078 RID: 120 RVA: 0x00004F9E File Offset: 0x0000319E
		' (set) Token: 0x06000079 RID: 121 RVA: 0x00004FA8 File Offset: 0x000031A8
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

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x0600007A RID: 122 RVA: 0x00004FEB File Offset: 0x000031EB
		' (set) Token: 0x0600007B RID: 123 RVA: 0x00004FF5 File Offset: 0x000031F5
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x0600007C RID: 124 RVA: 0x00004FFE File Offset: 0x000031FE
		' (set) Token: 0x0600007D RID: 125 RVA: 0x00005008 File Offset: 0x00003208
		Friend Overridable Property RichTextBox1 As RichTextBox

		' Token: 0x0600007E RID: 126 RVA: 0x00005014 File Offset: 0x00003214
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Try
				Dim instance As Object = Me.utf8
				Dim type As Type = Nothing
				Dim memberName As String = "GetString"
				Dim array As Object() = New Object(0) {}
				Dim num As Integer = 0
				Dim obj As Object = Me.wc
				Dim instance2 As Object = obj
				Dim type2 As Type = Nothing
				Dim memberName2 As String = "DownloadData"
				Dim array2 As Object() = New Object(0) {}
				Dim num2 As Integer = 0
				Dim text As String = String.Concat(New String() { "http://dynupdate.no-ip.com/dns?username=", Me.TextBox1.Text, "&password=", Me.TextBox2.Text, "&hostname=", Me.TextBox3.Text })
				Dim obj2 As Object = text
				array2(num2) = text
				array(num) = NewLateBinding.LateGet(instance2, type2, memberName2, array2, Nothing, Nothing, Nothing)
				Dim array3 As Object() = array
				Dim argumentNames As String() = Nothing
				Dim typeArguments As Type() = Nothing
				Dim array4 As Boolean() = New Boolean() { True }
				Dim array5 As Boolean() = array4
				Dim value As Object = NewLateBinding.LateGet(instance, type, memberName, array, argumentNames, typeArguments, array4)
				If array5(0) Then
					NewLateBinding.LateSetComplex(obj, Nothing, "DownloadData", New Object() { obj2, array3(0) }, Nothing, Nothing, True, False)
				End If
				Dim text2 As String = Conversions.ToString(value)
				Dim array6 As String() = text2.Split(New Char() { ":"c })
				Me.RichTextBox1.Text = array6(1)
				Dim flag As Boolean = array6(1).Contains("0")
				If flag Then
					Interaction.MsgBox("Success - IP address is current, no update performed", MsgBoxStyle.Information, Nothing)
				End If
				Dim flag2 As Boolean = array6(1).Contains("1")
				If flag2 Then
					Interaction.MsgBox("Success - DNS hostname update successful", MsgBoxStyle.Information, Nothing)
				End If
				Dim flag3 As Boolean = array6(1).Contains("2")
				If flag3 Then
					Interaction.MsgBox("Error - Hostname supplied does not exist", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag4 As Boolean = array6(1).Contains("3")
				If flag4 Then
					Interaction.MsgBox("Error - Invalid username", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag5 As Boolean = array6(1).Contains("4")
				If flag5 Then
					Interaction.MsgBox("Error - Invalid password", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag6 As Boolean = array6(1).Contains("5")
				If flag6 Then
					Interaction.MsgBox("Error - Too many updates sent. Updates are blocked   until 1 hour passes since last status of 5 returned.", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag7 As Boolean = array6(1).Contains("6")
				If flag7 Then
					Interaction.MsgBox("Error - Account disabled due to violation of No-IP   terms of service. Our terms of service can be viewed at   http://www.no-ip.com/legal/tos", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag8 As Boolean = array6(1).Contains("7")
				If flag8 Then
					Interaction.MsgBox("Error - Invalid IP. Invalid IP submitted is   improperly formated, is a private LAN RFC 1918 address, or an abuse   blacklisted address.", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag9 As Boolean = array6(1).Contains("8")
				If flag9 Then
					Interaction.MsgBox("Error - Disabled / Locked hostname", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag10 As Boolean = array6(1).Contains("9")
				If flag10 Then
					Interaction.MsgBox("Host updated is configured as a web redirect and no update was performed.", MsgBoxStyle.Information, Nothing)
				End If
				Dim flag11 As Boolean = array6(1).Contains("10")
				If flag11 Then
					Interaction.MsgBox("Error - Group supplied does not exist", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag12 As Boolean = array6(1).Contains("11")
				If flag12 Then
					Interaction.MsgBox("Success - DNS group update is successful", MsgBoxStyle.Information, Nothing)
				End If
				Dim flag13 As Boolean = array6(1).Contains("12")
				If flag13 Then
					Interaction.MsgBox("Success - DNS group is current, no update performed.", MsgBoxStyle.Information, Nothing)
				End If
				Dim flag14 As Boolean = array6(1).Contains("13")
				If flag14 Then
					Interaction.MsgBox("Error - Update client support not available for supplied hostname or group", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag15 As Boolean = array6(1).Contains("14")
				If flag15 Then
					Interaction.MsgBox("Error - Hostname supplied does not have offline   settings configured. Returned if sending offline=YES on a host that  does  not have any offline actions configured.", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag16 As Boolean = array6(1).Contains("99")
				If flag16 Then
					Interaction.MsgBox("Error - Client disabled. Client should exit and not   perform any more updates without user intervention.", MsgBoxStyle.Critical, Nothing)
				End If
				Dim flag17 As Boolean = array6(1).Contains("100")
				If flag17 Then
					Interaction.MsgBox("Error - User input error usually returned if missing required request parameters", MsgBoxStyle.Critical, Nothing)
				End If
			Catch ex As Exception
				Interaction.MsgBox("Check your Internet Connection", MsgBoxStyle.Exclamation, "NO-IP Updater")
			End Try
		End Sub

		' Token: 0x04000036 RID: 54
		Private wc As Object

		' Token: 0x04000037 RID: 55
		Private utf8 As Object
	End Class
End Namespace
