Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.IO.Compression
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x0200000F RID: 15
	Friend NotInheritable Class Class6
		' Token: 0x060000EC RID: 236
		Public Declare Function memcpy Lib "msvcrt.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, int_0 As Integer) As IntPtr

		' Token: 0x060000ED RID: 237 RVA: 0x000091BC File Offset: 0x000073BC
		Public Shared Function smethod_0(int_0 As Integer, int_1 As Integer) As String
			Dim flag As Boolean = int_1 = 0
			Dim result As String
			If flag Then
				result = "%00.0"
			Else
				result = (Double.Parse(Conversions.ToString(int_0)) / Double.Parse(Conversions.ToString(int_1)) * 100.0 / 100.0).ToString("%00.0").Replace("100.0", "100")
			End If
			Return result
		End Function

		' Token: 0x060000EE RID: 238 RVA: 0x00009228 File Offset: 0x00007428
		Public Shared Function smethod_1(int_0 As Integer, int_1 As Integer) As Integer
			Dim flag As Boolean = int_1 = 0
			Dim result As Integer
			If flag Then
				result = 0
			Else
				result = CInt(Math.Round(Math.Round(CDbl(int_0) / CDbl(int_1) * 100.0)))
			End If
			Return result
		End Function

		' Token: 0x060000EF RID: 239 RVA: 0x00009264 File Offset: 0x00007464
		Public Shared Function smethod_10(string_0 As String) As Form
			Return MyProject.Application.OpenForms(string_0)
		End Function

		' Token: 0x060000F0 RID: 240 RVA: 0x00009288 File Offset: 0x00007488
		Public Shared Function smethod_11(ByRef string_0 As String) As Byte()
			Return Encoding.[Default].GetBytes(string_0)
		End Function

		' Token: 0x060000F1 RID: 241 RVA: 0x000092A8 File Offset: 0x000074A8
		Public Shared Function smethod_12(ByRef byte_0 As Byte()) As String
			Return Encoding.[Default].GetString(byte_0)
		End Function

		' Token: 0x060000F2 RID: 242 RVA: 0x000092C8 File Offset: 0x000074C8
		Public Shared Function smethod_13() As String
			Return MyProject.Computer.Clock.LocalTime.ToString("[hh:mm:ss]")
		End Function

		' Token: 0x060000F3 RID: 243 RVA: 0x000092F8 File Offset: 0x000074F8
		Public Shared Function smethod_14(ByRef string_0 As String) As String
			Return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0))
		End Function

		' Token: 0x060000F4 RID: 244 RVA: 0x0000931C File Offset: 0x0000751C
		Public Shared Function smethod_15(int_0 As Integer, int_1 As Integer, bool_0 As Boolean) As Integer
			Class6.long_0 = CLng(Math.Round(Math.Round(CDbl(Class6.long_0) + 333.33)))
			Dim random As Random = New Random(CInt(Class6.long_0))
			Return random.[Next](int_0, int_1 + 1)
		End Function

		' Token: 0x060000F5 RID: 245 RVA: 0x00009364 File Offset: 0x00007564
		Public Shared Function smethod_16(string_0 As String) As String
			Dim num As Integer = 0
			Dim result As String
			While True
				Try
					Dim bytes As Byte() = Convert.FromBase64String(string_0)
					result = Encoding.UTF8.GetString(bytes)
					Exit Try
				Catch ex As Exception
					num += 1
					Dim flag As Boolean = num = 3
					If flag Then
						result = Nothing
						Exit Try
					End If
					string_0 += "="
				End Try
			End While
			Return result
		End Function

		' Token: 0x060000F6 RID: 246 RVA: 0x000093EC File Offset: 0x000075EC
		Public Shared Function smethod_17(long_1 As Long) As String
			Dim flag As Boolean = long_1.ToString().Length < 4
			Dim result As String
			If flag Then
				result = Conversions.ToString(long_1) + " Bytes"
			Else
				Dim str As String = String.Empty
				Dim num As Double = CDbl(long_1) / 1024.0
				Dim flag2 As Boolean = num < 1024.0
				If flag2 Then
					str = "KB"
				Else
					num /= 1024.0
					Dim flag3 As Boolean = num < 1024.0
					If flag3 Then
						str = "MB"
					Else
						num /= 1024.0
						str = "GB"
					End If
				End If
				result = num.ToString(".0") + " " + str
			End If
			Return result
		End Function

		' Token: 0x060000F7 RID: 247 RVA: 0x000094AC File Offset: 0x000076AC
		Public Shared Function smethod_2(string_0 As String, string_1 As String) As String
			Dim result As String
			Try
				result = Conversions.ToString(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.CurrentUser.OpenSubKey("Software\" + Class7.string_0).GetValue(string_0, string_1)))
			Catch ex As Exception
				result = string_1
			End Try
			Return result
		End Function

		' Token: 0x060000F8 RID: 248 RVA: 0x00009528 File Offset: 0x00007728
		Public Shared Sub smethod_3(string_0 As String, string_1 As String)
			Dim flag As Boolean = string_1 = Nothing
			If flag Then
				string_1 = String.Empty
			End If
			Try
				MyProject.Computer.Registry.CurrentUser.CreateSubKey("Software\" + Class7.string_0).SetValue(string_0, string_1)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000F9 RID: 249 RVA: 0x000095A4 File Offset: 0x000077A4
		Public Shared Function smethod_4(string_0 As String) As String
			Return Class6.smethod_5(Class6.smethod_11(string_0))
		End Function

		' Token: 0x060000FA RID: 250 RVA: 0x000095C4 File Offset: 0x000077C4
		Public Shared Function smethod_5(byte_0 As Byte()) As String
			byte_0 = New MD5CryptoServiceProvider().ComputeHash(byte_0)
			Dim text As String = String.Empty
			For Each b As Byte In byte_0
				text += b.ToString("x2")
			Next
			Return text
		End Function

		' Token: 0x060000FB RID: 251 RVA: 0x00009620 File Offset: 0x00007820
		Public Shared Function smethod_6(int_0 As Integer) As String
			Dim random As Random = New Random()
			Dim text As String = String.Empty
			Dim text2 As String = "abcdefghijklmnopqrstuvwxyz"
			For i As Integer = 1 To int_0
				text += Conversions.ToString(text2(random.[Next](0, text2.Length)))
			Next
			Return text
		End Function

		' Token: 0x060000FC RID: 252 RVA: 0x00009684 File Offset: 0x00007884
		Public Shared Function smethod_7(string_0 As String, treeNodeCollection_0 As TreeNodeCollection) As TreeNode
			Dim flag As Boolean = string_0.EndsWith("\")
			If flag Then
				string_0 = string_0.Remove(string_0.Length - 1, 1)
			End If
			Dim treeNode As TreeNode = Nothing
			For Each key As String In Strings.Split(string_0, "\", -1, CompareMethod.Binary)
				treeNode = treeNodeCollection_0(key)
				treeNodeCollection_0 = treeNode.Nodes
			Next
			Return treeNode
		End Function

		' Token: 0x060000FD RID: 253 RVA: 0x000096FC File Offset: 0x000078FC
		Public Shared Function smethod_8(byte_0 As Byte(), ByRef bool_0 As Boolean) As Byte()
			Dim flag As Boolean = bool_0
			Dim result As Byte()
			If flag Then
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim gzipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Compress, True)
				gzipStream.Write(byte_0, 0, byte_0.Length)
				gzipStream.Dispose()
				memoryStream.Position = 0L
				Dim array As Byte() = New Byte(CInt(memoryStream.Length) + 1 - 1 + 1 - 1) {}
				memoryStream.Read(array, 0, array.Length)
				memoryStream.Dispose()
				result = array
			Else
				Dim memoryStream2 As MemoryStream = New MemoryStream(byte_0)
				Dim gzipStream2 As GZipStream = New GZipStream(memoryStream2, CompressionMode.Decompress)
				Dim array2 As Byte() = New Byte(3) {}
				memoryStream2.Position = memoryStream2.Length - 5L
				memoryStream2.Read(array2, 0, 4)
				Dim num As Integer = BitConverter.ToInt32(array2, 0)
				memoryStream2.Position = 0L
				Dim array3 As Byte() = New Byte(num - 1 + 1 - 1 + 1 - 1) {}
				gzipStream2.Read(array3, 0, num)
				gzipStream2.Dispose()
				memoryStream2.Dispose()
				result = array3
			End If
			Return result
		End Function

		' Token: 0x060000FE RID: 254 RVA: 0x000097E8 File Offset: 0x000079E8
		Public Shared Function smethod_9(byte_0 As Byte(), string_0 As String) As Array
			Dim list As List(Of Byte()) = New List(Of Byte())()
			Dim num As Integer = Array.IndexOf(Of Byte)(byte_0, CByte(Strings.Asc(string_0(0))))
			While True
				Dim flag As Boolean = Not(num > -1 And num + string_0.Length <= byte_0.Length)
				If flag Then
					Exit For
				End If
				Dim array As Byte() = New Byte(string_0.Length - 1 + 1 - 1 + 1 - 1) {}
				Dim num2 As Integer = 0
				Dim num3 As Integer = num + string_0.Length - 1
				For i As Integer = num To num3
					array(num2) = byte_0(i)
					num2 += 1
				Next
				Dim flag2 As Boolean = Operators.CompareString(Class6.smethod_12(array), string_0, False) = 0
				If flag2 Then
					GoTo Block_3
				End If
				num = Array.IndexOf(Of Byte)(byte_0, CByte(Strings.Asc(string_0(0))), num + 1)
			End While
			GoTo IL_12E
			Block_3:
			Dim memoryStream As MemoryStream = New MemoryStream()
			memoryStream.Write(byte_0, 0, num)
			list.Add(memoryStream.ToArray())
			memoryStream.Dispose()
			memoryStream = New MemoryStream()
			memoryStream.Write(byte_0, num + string_0.Length, byte_0.Length - (num + string_0.Length))
			list.Add(memoryStream.ToArray())
			memoryStream.Dispose()
			IL_12E:
			Dim flag3 As Boolean = list.Count = 0
			If flag3 Then
				list.Add(byte_0)
			End If
			Return list.ToArray()
		End Function

		' Token: 0x0400006B RID: 107
		Public Shared long_0 As Long = 0L
	End Class
End Namespace
