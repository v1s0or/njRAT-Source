Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200002D RID: 45
	<DesignerGenerated()>
	Public Partial Class STNG
		Inherits Form

		' Token: 0x060003F4 RID: 1012 RVA: 0x0002B04A File Offset: 0x0002924A
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.STNG_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700013E RID: 318
		' (get) Token: 0x060003F7 RID: 1015 RVA: 0x0002C278 File Offset: 0x0002A478
		' (set) Token: 0x060003F8 RID: 1016 RVA: 0x0002C282 File Offset: 0x0002A482
		Friend Overridable Property GroupBox1 As GroupBox

		' Token: 0x1700013F RID: 319
		' (get) Token: 0x060003F9 RID: 1017 RVA: 0x0002C28B File Offset: 0x0002A48B
		' (set) Token: 0x060003FA RID: 1018 RVA: 0x0002C295 File Offset: 0x0002A495
		Friend Overridable Property ShowAlert As CheckBox

		' Token: 0x17000140 RID: 320
		' (get) Token: 0x060003FB RID: 1019 RVA: 0x0002C29E File Offset: 0x0002A49E
		' (set) Token: 0x060003FC RID: 1020 RVA: 0x0002C2A8 File Offset: 0x0002A4A8
		Friend Overridable Property GroupBox2 As GroupBox

		' Token: 0x17000141 RID: 321
		' (get) Token: 0x060003FD RID: 1021 RVA: 0x0002C2B1 File Offset: 0x0002A4B1
		' (set) Token: 0x060003FE RID: 1022 RVA: 0x0002C2BB File Offset: 0x0002A4BB
		Friend Overridable Property LOGMSGS As CheckBox

		' Token: 0x17000142 RID: 322
		' (get) Token: 0x060003FF RID: 1023 RVA: 0x0002C2C4 File Offset: 0x0002A4C4
		' (set) Token: 0x06000400 RID: 1024 RVA: 0x0002C2CE File Offset: 0x0002A4CE
		Friend Overridable Property LOGRERR As CheckBox

		' Token: 0x17000143 RID: 323
		' (get) Token: 0x06000401 RID: 1025 RVA: 0x0002C2D7 File Offset: 0x0002A4D7
		' (set) Token: 0x06000402 RID: 1026 RVA: 0x0002C2E1 File Offset: 0x0002A4E1
		Friend Overridable Property LOGCONNECTIONS As CheckBox

		' Token: 0x17000144 RID: 324
		' (get) Token: 0x06000403 RID: 1027 RVA: 0x0002C2EA File Offset: 0x0002A4EA
		' (set) Token: 0x06000404 RID: 1028 RVA: 0x0002C2F4 File Offset: 0x0002A4F4
		Friend Overridable Property LOGLERR As CheckBox

		' Token: 0x17000145 RID: 325
		' (get) Token: 0x06000405 RID: 1029 RVA: 0x0002C2FD File Offset: 0x0002A4FD
		' (set) Token: 0x06000406 RID: 1030 RVA: 0x0002C307 File Offset: 0x0002A507
		Friend Overridable Property LOGLOGIN As CheckBox

		' Token: 0x17000146 RID: 326
		' (get) Token: 0x06000407 RID: 1031 RVA: 0x0002C310 File Offset: 0x0002A510
		' (set) Token: 0x06000408 RID: 1032 RVA: 0x0002C31A File Offset: 0x0002A51A
		Friend Overridable Property GroupBox3 As GroupBox

		' Token: 0x17000147 RID: 327
		' (get) Token: 0x06000409 RID: 1033 RVA: 0x0002C323 File Offset: 0x0002A523
		' (set) Token: 0x0600040A RID: 1034 RVA: 0x0002C32D File Offset: 0x0002A52D
		Friend Overridable Property SCAUT As CheckBox

		' Token: 0x17000148 RID: 328
		' (get) Token: 0x0600040B RID: 1035 RVA: 0x0002C336 File Offset: 0x0002A536
		' (set) Token: 0x0600040C RID: 1036 RVA: 0x0002C340 File Offset: 0x0002A540
		Friend Overridable Property SCI As ComboBox

		' Token: 0x17000149 RID: 329
		' (get) Token: 0x0600040D RID: 1037 RVA: 0x0002C349 File Offset: 0x0002A549
		' (set) Token: 0x0600040E RID: 1038 RVA: 0x0002C353 File Offset: 0x0002A553
		Friend Overridable Property Label1 As Label

		' Token: 0x1700014A RID: 330
		' (get) Token: 0x0600040F RID: 1039 RVA: 0x0002C35C File Offset: 0x0002A55C
		' (set) Token: 0x06000410 RID: 1040 RVA: 0x0002C366 File Offset: 0x0002A566
		Friend Overridable Property GroupBox4 As GroupBox

		' Token: 0x1700014B RID: 331
		' (get) Token: 0x06000411 RID: 1041 RVA: 0x0002C36F File Offset: 0x0002A56F
		' (set) Token: 0x06000412 RID: 1042 RVA: 0x0002C379 File Offset: 0x0002A579
		Friend Overridable Property Label2 As Label

		' Token: 0x1700014C RID: 332
		' (get) Token: 0x06000413 RID: 1043 RVA: 0x0002C382 File Offset: 0x0002A582
		' (set) Token: 0x06000414 RID: 1044 RVA: 0x0002C38C File Offset: 0x0002A58C
		Friend Overridable Property CAMI As ComboBox

		' Token: 0x1700014D RID: 333
		' (get) Token: 0x06000415 RID: 1045 RVA: 0x0002C395 File Offset: 0x0002A595
		' (set) Token: 0x06000416 RID: 1046 RVA: 0x0002C39F File Offset: 0x0002A59F
		Friend Overridable Property CAMAUT As CheckBox

		' Token: 0x1700014E RID: 334
		' (get) Token: 0x06000417 RID: 1047 RVA: 0x0002C3A8 File Offset: 0x0002A5A8
		' (set) Token: 0x06000418 RID: 1048 RVA: 0x0002C3B2 File Offset: 0x0002A5B2
		Friend Overridable Property GroupBox5 As GroupBox

		' Token: 0x1700014F RID: 335
		' (get) Token: 0x06000419 RID: 1049 RVA: 0x0002C3BB File Offset: 0x0002A5BB
		' (set) Token: 0x0600041A RID: 1050 RVA: 0x0002C3C5 File Offset: 0x0002A5C5
		Friend Overridable Property MICI As ComboBox

		' Token: 0x17000150 RID: 336
		' (get) Token: 0x0600041B RID: 1051 RVA: 0x0002C3CE File Offset: 0x0002A5CE
		' (set) Token: 0x0600041C RID: 1052 RVA: 0x0002C3D8 File Offset: 0x0002A5D8
		Friend Overridable Property MICAUT As CheckBox

		' Token: 0x17000151 RID: 337
		' (get) Token: 0x0600041D RID: 1053 RVA: 0x0002C3E1 File Offset: 0x0002A5E1
		' (set) Token: 0x0600041E RID: 1054 RVA: 0x0002C3EB File Offset: 0x0002A5EB
		Friend Overridable Property GroupBox6 As GroupBox

		' Token: 0x17000152 RID: 338
		' (get) Token: 0x0600041F RID: 1055 RVA: 0x0002C3F4 File Offset: 0x0002A5F4
		' (set) Token: 0x06000420 RID: 1056 RVA: 0x0002C3FE File Offset: 0x0002A5FE
		Friend Overridable Property scrI As ComboBox

		' Token: 0x17000153 RID: 339
		' (get) Token: 0x06000421 RID: 1057 RVA: 0x0002C407 File Offset: 0x0002A607
		' (set) Token: 0x06000422 RID: 1058 RVA: 0x0002C414 File Offset: 0x0002A614
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

		' Token: 0x17000154 RID: 340
		' (get) Token: 0x06000423 RID: 1059 RVA: 0x0002C457 File Offset: 0x0002A657
		' (set) Token: 0x06000424 RID: 1060 RVA: 0x0002C461 File Offset: 0x0002A661
		Friend Overridable Property Label3 As Label

		' Token: 0x06000425 RID: 1061 RVA: 0x0002C46C File Offset: 0x0002A66C
		Private Sub STNG_Load(sender As Object, e As EventArgs)
			Me.SCAUT.Checked = Class7.class8_0.bool_6
			Me.SCI.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0)
			Me.CAMAUT.Checked = Class7.class8_0.bool_7
			Me.CAMI.SelectedIndex = Class7.class8_0.int_0
			Me.MICAUT.Checked = Class7.class8_0.bool_8
			Me.LOGCONNECTIONS.Checked = Class7.class8_0.bool_2
			Me.LOGLERR.Checked = Class7.class8_0.bool_3
			Me.LOGRERR.Checked = Class7.class8_0.bool_4
			Me.LOGMSGS.Checked = Class7.class8_0.bool_5
			Me.LOGLOGIN.Checked = Class7.class8_0.bool_1
			Me.ShowAlert.Checked = Class7.class8_0.bool_0
			Me.MICI.SelectedIndex = Class7.class8_0.int_1
			Me.scrI.SelectedIndex = Class7.class8_0.int_2
		End Sub

		' Token: 0x06000426 RID: 1062 RVA: 0x0002C5A0 File Offset: 0x0002A7A0
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Class7.class8_0.bool_6 = Me.SCAUT.Checked
			Class7.class8_0.string_0 = Conversions.ToString(Me.SCI.SelectedIndex)
			Class7.class8_0.bool_7 = Me.CAMAUT.Checked
			Class7.class8_0.int_0 = Me.CAMI.SelectedIndex
			Class7.class8_0.bool_8 = Me.MICAUT.Checked
			Class7.class8_0.bool_2 = Me.LOGCONNECTIONS.Checked
			Class7.class8_0.bool_3 = Me.LOGLERR.Checked
			Class7.class8_0.bool_4 = Me.LOGRERR.Checked
			Class7.class8_0.bool_5 = Me.LOGMSGS.Checked
			Class7.class8_0.bool_1 = Me.LOGLOGIN.Checked
			Class7.class8_0.bool_0 = Me.ShowAlert.Checked
			Class7.class8_0.int_1 = Me.MICI.SelectedIndex
			Class7.class8_0.int_2 = Me.scrI.SelectedIndex
			Class7.class8_0.method_1()
			MyBase.Close()
		End Sub
	End Class
End Namespace
