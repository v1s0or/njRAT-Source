Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My.Resources
	' Token: 0x02000005 RID: 5
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	<HideModuleName()>
	Friend NotInheritable Module Resources
		' Token: 0x17000006 RID: 6
		' (get) Token: 0x0600000B RID: 11 RVA: 0x00002198 File Offset: 0x00000398
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				Dim flag As Boolean = Object.ReferenceEquals(Resources.resourceMan, Nothing)
				If flag Then
					Dim resourceManager As ResourceManager = New ResourceManager("NJRAT.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x0600000C RID: 12 RVA: 0x000021E0 File Offset: 0x000003E0
		' (set) Token: 0x0600000D RID: 13 RVA: 0x000021F7 File Offset: 0x000003F7
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x0600000E RID: 14 RVA: 0x00002200 File Offset: 0x00000400
		Friend ReadOnly Property bullet_arrow_down As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("bullet_arrow_down", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x0600000F RID: 15 RVA: 0x00002234 File Offset: 0x00000434
		Friend ReadOnly Property bullet_arrow_up As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("bullet_arrow_up", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000010 RID: 16 RVA: 0x00002268 File Offset: 0x00000468
		Friend ReadOnly Property control_pause_blue As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("control_pause_blue", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000011 RID: 17 RVA: 0x0000229C File Offset: 0x0000049C
		Friend ReadOnly Property control_play_blue As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("control_play_blue", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000012 RID: 18 RVA: 0x000022D0 File Offset: 0x000004D0
		Friend ReadOnly Property dotNET_Reactor As Byte()
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("dotNET_Reactor", Resources.resourceCulture))
				Return CType(objectValue, Byte())
			End Get
		End Property

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000013 RID: 19 RVA: 0x00002304 File Offset: 0x00000504
		Friend ReadOnly Property icon As Icon
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("icon", Resources.resourceCulture))
				Return CType(objectValue, Icon)
			End Get
		End Property

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000014 RID: 20 RVA: 0x00002338 File Offset: 0x00000538
		Friend ReadOnly Property JPEG As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("JPEG", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000015 RID: 21 RVA: 0x0000236C File Offset: 0x0000056C
		Friend ReadOnly Property mpress As Byte()
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("mpress", Resources.resourceCulture))
				Return CType(objectValue, Byte())
			End Get
		End Property

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x06000016 RID: 22 RVA: 0x000023A0 File Offset: 0x000005A0
		Friend ReadOnly Property noip_logo As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("noip_logo", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x06000017 RID: 23 RVA: 0x000023D4 File Offset: 0x000005D4
		Friend ReadOnly Property notf As String
			Get
				Return Resources.ResourceManager.GetString("notf", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x06000018 RID: 24 RVA: 0x000023FC File Offset: 0x000005FC
		Friend ReadOnly Property Res As Byte()
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Res", Resources.resourceCulture))
				Return CType(objectValue, Byte())
			End Get
		End Property

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x06000019 RID: 25 RVA: 0x00002430 File Offset: 0x00000630
		Friend ReadOnly Property RHDiscription As String
			Get
				Return Resources.ResourceManager.GetString("RHDiscription", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x0600001A RID: 26 RVA: 0x00002458 File Offset: 0x00000658
		Friend ReadOnly Property RichTextBox1 As String
			Get
				Return Resources.ResourceManager.GetString("RichTextBox1", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x04000006 RID: 6
		Private resourceMan As ResourceManager

		' Token: 0x04000007 RID: 7
		Private resourceCulture As CultureInfo
	End Module
End Namespace
