Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x02000008 RID: 8
	<DesignerGenerated()>
	Public Partial Class About
		Inherits Form

		' Token: 0x06000020 RID: 32 RVA: 0x00002573 File Offset: 0x00000773
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.About_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x06000023 RID: 35 RVA: 0x00002850 File Offset: 0x00000A50
		' (set) Token: 0x06000024 RID: 36 RVA: 0x0000285A File Offset: 0x00000A5A
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x06000025 RID: 37 RVA: 0x00002863 File Offset: 0x00000A63
		' (set) Token: 0x06000026 RID: 38 RVA: 0x0000286D File Offset: 0x00000A6D
		Friend Overridable Property RichTextBox1 As RichTextBox

		' Token: 0x06000027 RID: 39 RVA: 0x00002876 File Offset: 0x00000A76
		Private Sub About_Load(sender As Object, e As EventArgs)
			Me.RichTextBox1.Text = Resources.RichTextBox1
		End Sub
	End Class
End Namespace
