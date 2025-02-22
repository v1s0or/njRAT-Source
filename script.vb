Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000026 RID: 38
	<DesignerGenerated()>
	Public Partial Class script
		Inherits Form

		' Token: 0x1700010E RID: 270
		' (get) Token: 0x0600033A RID: 826 RVA: 0x0001DB10 File Offset: 0x0001BD10
		' (set) Token: 0x0600033B RID: 827 RVA: 0x0001DB1A File Offset: 0x0001BD1A
		Friend Overridable Property Panel1 As Panel

		' Token: 0x1700010F RID: 271
		' (get) Token: 0x0600033C RID: 828 RVA: 0x0001DB23 File Offset: 0x0001BD23
		' (set) Token: 0x0600033D RID: 829 RVA: 0x0001DB2D File Offset: 0x0001BD2D
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x17000110 RID: 272
		' (get) Token: 0x0600033E RID: 830 RVA: 0x0001DB36 File Offset: 0x0001BD36
		' (set) Token: 0x0600033F RID: 831 RVA: 0x0001DB40 File Offset: 0x0001BD40
		Friend Overridable Property ComboBox1 As ComboBox

		' Token: 0x17000111 RID: 273
		' (get) Token: 0x06000340 RID: 832 RVA: 0x0001DB49 File Offset: 0x0001BD49
		' (set) Token: 0x06000341 RID: 833 RVA: 0x0001DB54 File Offset: 0x0001BD54
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

		' Token: 0x06000342 RID: 834 RVA: 0x0001DB97 File Offset: 0x0001BD97
		Public Sub New()
			Me.RunAs = "vbs"
			Me.Code = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000343 RID: 835 RVA: 0x0001DBBE File Offset: 0x0001BDBE
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Code = Me.TextBox1.Text
			Me.RunAs = Me.ComboBox1.Text
			MyBase.Close()
		End Sub

		' Token: 0x040001D0 RID: 464
		Public Code As String

		' Token: 0x040001D1 RID: 465
		Public F As Form1

		' Token: 0x040001D2 RID: 466
		Public RunAs As String
	End Class
End Namespace
