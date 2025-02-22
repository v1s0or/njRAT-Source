Imports System
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000017 RID: 23
	Public NotInheritable Class GClass3
		' Token: 0x0600014E RID: 334 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		Public Sub New(string_3 As String)
			Me.New(string_3, GClass3.int_20)
		End Sub

		' Token: 0x0600014F RID: 335 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		Public Sub New(string_3 As String, int_26 As Integer)
			Me.fileStream_0 = Nothing
			Me.gclass5_0 = Nothing
			Me.object_0 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(New Object()))
			Me.byte_0 = Convert.ToByte(GClass5.int_0)
			Me.int_3 = 0
			Try
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0 = New FileStream(string_3, FileMode.Open, FileAccess.Read)
				End SyncLock
				Me.int_2 = int_26
				Me.method_0()
			Catch ex As SystemException
				Console.Write("cannot open file " + string_3 + vbLf)
			End Try
		End Sub

		' Token: 0x06000150 RID: 336 RVA: 0x0000DBEC File Offset: 0x0000BDEC
		Private Sub method_0()
			Dim array As Byte() = New Byte(2) {}
			Dim array2 As Byte() = New Byte(GClass3.int_9 - 1 + 1 - 1 + 1 - 1) {}
			Me.byte_0 = CByte(GClass5.int_0)
			Me.int_1 = GClass3.int_10
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
			ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
			Dim obj As Object = objectValue
			ObjectFlowControl.CheckForSyncLockOnValueType(obj)
			SyncLock obj
				Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
				Dim num As Integer = GClass3.int_6 - 1
				For i As Integer = 0 To num
					Me.fileStream_0.Read(array, 0, 3)
					Dim flag As Boolean = array(0) = Byte.MaxValue AndAlso array(1) = Byte.MaxValue AndAlso array(2) = Byte.MaxValue
					If flag Then
						Me.byte_0 = Convert.ToByte(Me.fileStream_0.ReadByte())
						Dim flag2 As Boolean = Me.byte_0 >= 106
						If flag2 Then
							Me.byte_0 -= 105
						End If
						Dim flag3 As Boolean = CInt(Me.byte_0) = GClass5.int_1
						If flag3 Then
							Me.int_0 = New Integer() { GClass3.int_15 }
							Me.int_1 = GClass3.int_10
						Else
							Dim flag4 As Boolean = CInt(Me.byte_0) = GClass5.int_2
							If flag4 Then
								Me.int_0 = New Integer() { GClass3.int_16 }
								Me.int_1 = GClass3.int_10
							Else
								Dim flag5 As Boolean = CInt(Me.byte_0) = GClass5.int_3 OrElse CInt(Me.byte_0) = GClass5.int_4 OrElse CInt(Me.byte_0) = GClass5.int_5 OrElse CInt(Me.byte_0) = GClass5.int_14 OrElse CInt(Me.byte_0) = GClass5.int_6 OrElse CInt(Me.byte_0) = GClass5.int_13 OrElse CInt(Me.byte_0) = GClass5.int_8 OrElse CInt(Me.byte_0) = GClass5.int_12 OrElse CInt(Me.byte_0) = GClass5.int_18 OrElse CInt(Me.byte_0) = GClass5.int_19 OrElse CInt(Me.byte_0) = GClass5.int_17 OrElse CInt(Me.byte_0) = GClass5.int_16
								If flag5 Then
									Me.int_0 = New Integer(0) {}
									Dim flag6 As Boolean = CInt(Me.byte_0) = GClass5.int_3 OrElse CInt(Me.byte_0) = GClass5.int_4 OrElse CInt(Me.byte_0) = GClass5.int_12 OrElse CInt(Me.byte_0) = GClass5.int_18 OrElse CInt(Me.byte_0) = GClass5.int_19 OrElse CInt(Me.byte_0) = GClass5.int_17 OrElse CInt(Me.byte_0) = GClass5.int_16 OrElse CInt(Me.byte_0) = GClass5.int_8
									If flag6 Then
										Me.int_1 = GClass3.int_10
									Else
										Me.int_1 = GClass3.int_11
									End If
									Me.fileStream_0.Read(array2, 0, GClass3.int_9)
									Dim num2 As Integer = GClass3.int_9 - 1
									For j As Integer = 0 To num2
										Dim num3 As Integer = 0
										Me.int_0(num3) = Me.int_0(num3) + (GClass3.smethod_2(array2(j)) << j * 8)
									Next
								End If
							End If
						End If
						Exit For
					End If
					Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
				Next
				Dim flag7 As Boolean = CInt(Me.byte_0) = GClass5.int_0 OrElse CInt(Me.byte_0) = GClass5.int_11 OrElse CInt(Me.byte_0) = GClass5.int_7 OrElse CInt(Me.byte_0) = GClass5.int_9
				If flag7 Then
					Me.int_0 = New Integer() { GClass3.int_4 }
					Me.int_1 = GClass3.int_10
				End If
				Dim flag8 As Boolean = (Me.int_2 And GClass3.int_21) = 1
				If flag8 Then
					Dim num4 As Integer = CInt(Me.fileStream_0.Length)
					Me.byte_1 = New Byte(num4 - 1 + 1 - 1 + 1 - 1) {}
					Me.fileStream_0.Seek(0L, SeekOrigin.Begin)
					Me.fileStream_0.Read(Me.byte_1, 0, num4)
				End If
			End SyncLock
		End Sub

		' Token: 0x06000151 RID: 337 RVA: 0x0000E020 File Offset: 0x0000C220
		Public Sub method_1()
			Try
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0.Close()
				End SyncLock
				Me.fileStream_0 = Nothing
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000152 RID: 338 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		Public Function method_10() As GClass5
			Dim flag As Boolean = Me.gclass5_0 IsNot Nothing
			Dim result As GClass5
			If flag Then
				result = Me.gclass5_0
			Else
				Try
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
					Dim obj As Object = objectValue
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						Dim flag2 As Boolean = False
						Dim array As Byte() = New Byte(2) {}
						Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
						Dim num As Integer = GClass3.int_6 - 1
						For i As Integer = 0 To num
							Me.fileStream_0.Read(array, 0, 3)
							Dim flag3 As Boolean = array(0) = Byte.MaxValue AndAlso array(1) = Byte.MaxValue AndAlso array(2) = Byte.MaxValue
							If flag3 Then
								flag2 = True
								Exit For
							End If
							Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
						Next
						Dim flag4 As Boolean = flag2
						If flag4 Then
							Me.fileStream_0.Seek(-6L, SeekOrigin.Current)
						Else
							Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
						End If
						Dim num2 As Integer = GClass3.int_7 - 1
						For j As Integer = 0 To num2
							Me.fileStream_0.Read(array, 0, 3)
							Dim flag5 As Boolean = array(0) = 0 AndAlso array(1) = 0 AndAlso array(2) = 0
							If flag5 Then
								Dim array2 As Byte() = New Byte(j - 1 + 1 - 1 + 1 - 1) {}
								Dim array3 As Char() = New Char(j - 1 + 1 - 1 + 1 - 1) {}
								Me.fileStream_0.Read(array2, 0, j)
								Dim num3 As Integer = j - 1
								For k As Integer = 0 To num3
									array3(k) = Convert.ToChar(array2(k))
								Next
								Me.gclass5_0 = New GClass5(New String(array3))
								Return Me.gclass5_0
							End If
							Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
						Next
					End SyncLock
				Catch ex As Exception
					Dim ex2 As Exception = ex
					Console.Write(ex2.Message)
				End Try
				result = New GClass5(String.Empty)
			End If
			Return result
		End Function

		' Token: 0x06000153 RID: 339 RVA: 0x0000E328 File Offset: 0x0000C528
		Public Function method_11(ipaddress_0 As IPAddress) As GClass6
			Return Me.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress_0.GetAddressBytes())))
		End Function

		' Token: 0x06000154 RID: 340 RVA: 0x0000E350 File Offset: 0x0000C550
		Public Function method_12(string_3 As String) As GClass6
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress.GetAddressBytes())))
		End Function

		' Token: 0x06000155 RID: 341 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		Public Function method_13(ipaddress_0 As IPAddress) As String
			Return Me.method_17(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x06000156 RID: 342 RVA: 0x0000E3E4 File Offset: 0x0000C5E4
		Public Function method_14(string_3 As String) As String
			Dim ipaddress_ As IPAddress
			Try
				ipaddress_ = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_16(ipaddress_)
		End Function

		' Token: 0x06000157 RID: 343 RVA: 0x0000E444 File Offset: 0x0000C644
		Public Function method_15(string_3 As String) As String
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_17(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x06000158 RID: 344 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Function method_16(ipaddress_0 As IPAddress) As String
			Dim num As Integer = 0
			Dim array As Byte() = New Byte(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Char() = New Char(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim result As String
			Try
				Dim num2 As Integer = Me.method_18(ipaddress_0)
				Dim flag As Boolean = num2 = Me.int_0(0)
				If flag Then
					Return Nothing
				End If
				Dim num3 As Integer = num2 + (2 * Me.int_1 - 1) * Me.int_0(0)
				Dim flag2 As Boolean = (Me.int_2 And GClass3.int_21) = 1
				If flag2 Then
					Array.Copy(Me.byte_1, num3, array, 0, Math.Min(Me.byte_1.Length - num3, GClass3.int_13))
				Else
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
					Dim obj As Object = objectValue
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						Me.fileStream_0.Seek(CLng(num3), SeekOrigin.Begin)
						Me.fileStream_0.Read(array, 0, GClass3.int_13)
					End SyncLock
				End If
				While array(num) > 0
					array2(num) = Convert.ToChar(array(num))
					num += 1
				End While
				array2(num) = vbNullChar
				result = New String(array2, 0, num)
			Catch ex As IOException
				Console.Write("IO Exception")
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x06000159 RID: 345 RVA: 0x0000E65C File Offset: 0x0000C85C
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Function method_17(long_0 As Long) As String
			Dim num As Integer = 0
			Dim array As Byte() = New Byte(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Char() = New Char(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim result As String
			Try
				Dim num2 As Integer = Me.method_19(long_0)
				Dim flag As Boolean = num2 = Me.int_0(0)
				If flag Then
					Return Nothing
				End If
				Dim num3 As Integer = num2 + (2 * Me.int_1 - 1) * Me.int_0(0)
				Dim flag2 As Boolean = (Me.int_2 And GClass3.int_21) = 1
				If flag2 Then
					Array.Copy(Me.byte_1, num3, array, 0, Math.Min(Me.byte_1.Length - num3, GClass3.int_13))
				Else
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
					Dim obj As Object = objectValue
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						Me.fileStream_0.Seek(CLng(num3), SeekOrigin.Begin)
						Me.fileStream_0.Read(array, 0, GClass3.int_13)
					End SyncLock
				End If
				While array(num) > 0
					array2(num) = Convert.ToChar(array(num))
					num += 1
				End While
				array2(num) = vbNullChar
				result = New String(array2, 0, num)
			Catch ex As IOException
				Console.Write("IO Exception")
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x0600015A RID: 346 RVA: 0x0000E808 File Offset: 0x0000CA08
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Function method_18(ipaddress_0 As IPAddress) As Integer
			Dim addressBytes As Byte() = ipaddress_0.GetAddressBytes()
			Dim array As Byte() = New Byte(2 * GClass3.int_12 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Integer() = New Integer(1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = 127
			While True
				Try
					Dim flag As Boolean = (Me.int_2 And GClass3.int_21) = 1
					If flag Then
						Dim num3 As Integer = 2 * GClass3.int_12 - 1
						For i As Integer = 0 To num3
							array(i) = Me.byte_1(i + 2 * Me.int_1 * num)
						Next
					Else
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
						Dim obj As Object = objectValue
						ObjectFlowControl.CheckForSyncLockOnValueType(obj)
						SyncLock obj
							Me.fileStream_0.Seek(CLng((2 * Me.int_1 * num)), SeekOrigin.Begin)
							Me.fileStream_0.Read(array, 0, 2 * GClass3.int_12)
						End SyncLock
					End If
				Catch ex As IOException
					Console.Write("IO Exception")
				End Try
				Dim num4 As Integer = 0
				Do
					array2(num4) = 0
					Dim num5 As Integer = Me.int_1 - 1
					For j As Integer = 0 To num5
						Dim num6 As Integer = CInt(array(num4 * Me.int_1 + j))
						Dim flag2 As Boolean = num6 < 0
						If flag2 Then
							num6 += 256
						End If
						Dim num7 As Integer = num4
						array2(num7) += num6 << j * 8
					Next
					num4 += 1
				Loop While num4 <= 1
				Dim num8 As Integer = 127 - num2
				Dim num9 As Integer = num8 >> 3
				Dim num10 As Integer = 1 << ((num8 And 7) Xor 7)
				Dim flag3 As Boolean = (CInt(addressBytes(num9)) And num10) > 0
				If flag3 Then
					Dim flag4 As Boolean = array2(1) >= Me.int_0(0)
					If flag4 Then
						Exit For
					End If
					num = array2(1)
				Else
					Dim flag5 As Boolean = array2(0) >= Me.int_0(0)
					If flag5 Then
						GoTo Block_7
					End If
					num = array2(0)
				End If
				num2 += -1
				If num2 < 0 Then
					GoTo Block_8
				End If
			End While
			Return array2(1)
			Block_7:
			Return array2(0)
			Block_8:
			Console.Write("Error Seeking country while Seeking " + Convert.ToString(ipaddress_0))
			Return 0
		End Function

		' Token: 0x0600015B RID: 347 RVA: 0x0000EA78 File Offset: 0x0000CC78
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Function method_19(long_0 As Long) As Integer
			Dim array As Byte() = New Byte(2 * GClass3.int_12 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Integer() = New Integer(1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = 31
			While True
				Try
					Dim flag As Boolean = (Me.int_2 And GClass3.int_21) = 1
					If flag Then
						Dim num3 As Integer = 2 * GClass3.int_12 - 1
						For i As Integer = 0 To num3
							array(i) = Me.byte_1(i + 2 * Me.int_1 * num)
						Next
					Else
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
						Dim obj As Object = objectValue
						ObjectFlowControl.CheckForSyncLockOnValueType(obj)
						SyncLock obj
							Me.fileStream_0.Seek(CLng((2 * Me.int_1 * num)), SeekOrigin.Begin)
							Me.fileStream_0.Read(array, 0, 2 * GClass3.int_12)
						End SyncLock
					End If
				Catch ex As IOException
					Console.Write("IO Exception")
				End Try
				Dim num4 As Integer = 0
				Do
					array2(num4) = 0
					Dim num5 As Integer = Me.int_1 - 1
					For j As Integer = 0 To num5
						Dim num6 As Integer = CInt(array(num4 * Me.int_1 + j))
						Dim flag2 As Boolean = num6 < 0
						If flag2 Then
							num6 += 256
						End If
						Dim num7 As Integer = num4
						array2(num7) += num6 << j * 8
					Next
					num4 += 1
				Loop While num4 <= 1
				Dim flag3 As Boolean = (long_0 And 1L << (num2 And 31)) > 0L
				If flag3 Then
					Dim flag4 As Boolean = array2(1) >= Me.int_0(0)
					If flag4 Then
						Exit For
					End If
					num = array2(1)
				Else
					Dim flag5 As Boolean = array2(0) >= Me.int_0(0)
					If flag5 Then
						GoTo Block_7
					End If
					num = array2(0)
				End If
				num2 += -1
				If num2 < 0 Then
					GoTo Block_8
				End If
			End While
			Return array2(1)
			Block_7:
			Return array2(0)
			Block_8:
			Console.Write("Error Seeking country while Seeking " + Conversions.ToString(long_0))
			Return 0
		End Function

		' Token: 0x0600015C RID: 348 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
		Public Function method_2(ipaddress_0 As IPAddress) As GClass4
			Return Me.method_6(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x0600015D RID: 349 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		Public Function method_3(string_3 As String) As GClass4
			Dim ipaddress_ As IPAddress
			Try
				ipaddress_ = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return GClass3.gclass4_0
			End Try
			Return Me.method_5(ipaddress_)
		End Function

		' Token: 0x0600015E RID: 350 RVA: 0x0000ED54 File Offset: 0x0000CF54
		Public Function method_4(string_3 As String) As GClass4
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return GClass3.gclass4_0
			End Try
			Return Me.method_6(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x0600015F RID: 351 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
		Public Function method_5(ipaddress_0 As IPAddress) As GClass4
			Dim flag As Boolean = Me.fileStream_0 Is Nothing
			If flag Then
				Throw New Exception("Database has been closed.")
			End If
			Dim flag2 As Boolean = CInt(Me.byte_0) = GClass5.int_4 Or CInt(Me.byte_0) = GClass5.int_3
			Dim result As GClass4
			If flag2 Then
				Dim gclass As GClass6 = Me.method_11(ipaddress_0)
				Dim flag3 As Boolean = gclass Is Nothing
				If flag3 Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(gclass.string_0, gclass.string_1)
				End If
			Else
				Dim num As Integer = Me.method_18(ipaddress_0) - GClass3.int_4
				Dim flag4 As Boolean = num = 0
				If flag4 Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(GClass3.string_1(num), GClass3.string_2(num))
				End If
			End If
			Return result
		End Function

		' Token: 0x06000160 RID: 352 RVA: 0x0000EE7C File Offset: 0x0000D07C
		Public Function method_6(long_0 As Long) As GClass4
			Dim flag As Boolean = Me.fileStream_0 Is Nothing
			If flag Then
				Throw New Exception("Database has been closed.")
			End If
			Dim flag2 As Boolean = CInt(Me.byte_0) = GClass5.int_4 Or CInt(Me.byte_0) = GClass5.int_3
			Dim result As GClass4
			If flag2 Then
				Dim gclass As GClass6 = Me.method_12(Conversions.ToString(long_0))
				Dim flag3 As Boolean = gclass Is Nothing
				If flag3 Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(gclass.string_0, gclass.string_1)
				End If
			Else
				Dim num As Integer = Me.method_19(long_0) - GClass3.int_4
				Dim flag4 As Boolean = num = 0
				If flag4 Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(GClass3.string_1(num), GClass3.string_2(num))
				End If
			End If
			Return result
		End Function

		' Token: 0x06000161 RID: 353 RVA: 0x0000EF34 File Offset: 0x0000D134
		Public Function method_7(string_3 As String) As Integer
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return 0
			End Try
			Return Me.method_9(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x06000162 RID: 354 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		Public Function method_8(ipaddress_0 As IPAddress) As Integer
			Return Me.method_9(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x06000163 RID: 355 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		Public Function method_9(long_0 As Long) As Integer
			Dim flag As Boolean = Me.fileStream_0 Is Nothing
			If flag Then
				Throw New Exception("Database has been closed.")
			End If
			Return Me.method_19(long_0) - Me.int_0(0)
		End Function

		' Token: 0x06000164 RID: 356 RVA: 0x0000F000 File Offset: 0x0000D200
		Private Shared Function smethod_0(long_0 As Long) As Long
			Return(long_0 >> 0 And 255L) << 24 Or (long_0 >> 8 And 255L) << 16 Or (long_0 >> 16 And 255L) << 8 Or (long_0 >> 24 And 255L) << 0
		End Function

		' Token: 0x06000165 RID: 357 RVA: 0x0000F04C File Offset: 0x0000D24C
		Private Shared Function smethod_1(byte_2 As Byte()) As Long
			Dim num As Long = 0L
			Dim num2 As Integer = 0
			Do
				Dim num3 As Long = CLng(CULng(byte_2(num2)))
				Dim flag As Boolean = num3 < 0L
				If flag Then
					num3 += 256L
				End If
				num += num3 << (3 - num2) * 8
				num2 += 1
			Loop While num2 <= 3
			Return num
		End Function

		' Token: 0x06000166 RID: 358 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
		Private Shared Function smethod_2(byte_2 As Byte) As Integer
			Return CInt((byte_2 And Byte.MaxValue))
		End Function

		' Token: 0x06000167 RID: 359 RVA: 0x0000F0BC File Offset: 0x0000D2BC
		Private Shared Function smethod_3(Of T)(ByRef gparam_0 As T, gparam_1 As T) As T
			gparam_0 = gparam_1
			Return gparam_1
		End Function

		' Token: 0x040000AE RID: 174
		Private byte_0 As Byte

		' Token: 0x040000AF RID: 175
		Private byte_1 As Byte()

		' Token: 0x040000B0 RID: 176
		Private fileStream_0 As FileStream

		' Token: 0x040000B1 RID: 177
		Private Shared gclass4_0 As GClass4 = New GClass4("--", "N/A")

		' Token: 0x040000B2 RID: 178
		Private gclass5_0 As GClass5

		' Token: 0x040000B3 RID: 179
		Private int_0 As Integer()

		' Token: 0x040000B4 RID: 180
		Private int_1 As Integer

		' Token: 0x040000B5 RID: 181
		Private Shared int_10 As Integer = 3

		' Token: 0x040000B6 RID: 182
		Private Shared int_11 As Integer = 4

		' Token: 0x040000B7 RID: 183
		Private Shared int_12 As Integer = 4

		' Token: 0x040000B8 RID: 184
		Private Shared int_13 As Integer = 1000

		' Token: 0x040000B9 RID: 185
		Private Shared int_14 As Integer = 360

		' Token: 0x040000BA RID: 186
		Private Shared int_15 As Integer = 16700000

		' Token: 0x040000BB RID: 187
		Private Shared int_16 As Integer = 16000000

		' Token: 0x040000BC RID: 188
		Private Shared int_17 As Integer = 1

		' Token: 0x040000BD RID: 189
		Private Shared int_18 As Integer = 677

		' Token: 0x040000BE RID: 190
		Private Shared int_19 As Integer = 1353

		' Token: 0x040000BF RID: 191
		Private int_2 As Integer

		' Token: 0x040000C0 RID: 192
		Public Shared int_20 As Integer = 0

		' Token: 0x040000C1 RID: 193
		Public Shared int_21 As Integer = 1

		' Token: 0x040000C2 RID: 194
		Public Shared int_22 As Integer = 0

		' Token: 0x040000C3 RID: 195
		Public Shared int_23 As Integer = 1

		' Token: 0x040000C4 RID: 196
		Public Shared int_24 As Integer = 2

		' Token: 0x040000C5 RID: 197
		Public Shared int_25 As Integer = 3

		' Token: 0x040000C6 RID: 198
		Private int_3 As Integer

		' Token: 0x040000C7 RID: 199
		Private Shared int_4 As Integer = 16776960

		' Token: 0x040000C8 RID: 200
		Private Shared int_5 As Integer = 16700000

		' Token: 0x040000C9 RID: 201
		Private Shared int_6 As Integer = 20

		' Token: 0x040000CA RID: 202
		Private Shared int_7 As Integer = 100

		' Token: 0x040000CB RID: 203
		Private Shared int_8 As Integer = 100

		' Token: 0x040000CC RID: 204
		Private Shared int_9 As Integer = 3

		' Token: 0x040000CD RID: 205
		Private object_0 As Object

		' Token: 0x040000CE RID: 206
		Private string_0 As String

		' Token: 0x040000CF RID: 207
		Public Shared string_1 As String() = New String() { "--", "AP", "EU", "AD", "AE", "AF", "AG", "AI", "AL", "AM", "CW", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "SX", "GA", "GB", "GD", "GE", "GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IN", "IO", "IQ", "IR", "IS", "IT", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "TO", "TL", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "RS", "ZA", "ZM", "ME", "ZW", "A1", "A2", "O1", "AX", "GG", "IM", "JE", "BL", "MF", "BQ", "SS", "O1" }

		' Token: 0x040000D0 RID: 208
		Private Shared string_2 As String() = New String() { "N/A", "Asia/Pacific Region", "Europe", "Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia", "Curacao", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Azerbaijan", "Bosnia and Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Bermuda", "Brunei Darussalam", "Bolivia", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands", "Congo, The Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Cote D'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cape Verde", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands (Malvinas)", "Micronesia, Federated States of", "Faroe Islands", "France", "Sint Maarten (Dutch part)", "Gabon", "United Kingdom", "Grenada", "Georgia", "French Guiana", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Israel", "India", "British Indian Ocean Territory", "Iraq", "Iran, Islamic Republic of", "Iceland", "Italy", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea, Democratic People's Republic of", "Korea, Republic of", "Kuwait", "Cayman Islands", "Kazakhstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova, Republic of", "Madagascar", "Marshall Islands", "Macedonia", "Mali", "Myanmar", "Mongolia", "Macau", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn Islands", "Puerto Rico", "Palestinian Territory", "Portugal", "Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "Sao Tome and Principe", "El Salvador", "Syrian Arab Republic", "Swaziland", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Turkmenistan", "Tunisia", "Tonga", "Timor-Leste", "Turkey", "Trinidad and Tobago", "Tuvalu", "Taiwan", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States", "Uruguay", "Uzbekistan", "Holy See (Vatican City State)", "Saint Vincent and the Grenadines", "Venezuela", "Virgin Islands, British", "Virgin Islands, U.S.", "Vietnam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "Serbia", "South Africa", "Zambia", "Montenegro", "Zimbabwe", "Anonymous Proxy", "Satellite Provider", "Other", "Aland Islands", "Guernsey", "Isle of Man", "Jersey", "Saint Barthelemy", "Saint Martin", "Bonaire, Saint Eustatius and Saba", "South Sudan", "Other" }
	End Class
End Namespace
