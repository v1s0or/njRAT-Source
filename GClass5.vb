Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000019 RID: 25
	Public NotInheritable Class GClass5
		' Token: 0x0600016C RID: 364 RVA: 0x0000F1B1 File Offset: 0x0000D3B1
		Public Sub New(string_1 As String)
			Me.string_0 = string_1
		End Sub

		' Token: 0x0600016D RID: 365 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		Public Function method_0() As Integer
			Dim flag As Boolean = Me.string_0 = Nothing Or Operators.CompareString(Me.string_0, String.Empty, False) = 0
			Dim result As Integer
			If flag Then
				result = GClass5.int_0
			Else
				result = Convert.ToInt32(Me.string_0.Substring(4, 3)) - 105
			End If
			Return result
		End Function

		' Token: 0x0600016E RID: 366 RVA: 0x0000F218 File Offset: 0x0000D418
		Public Function method_1() As Boolean
			Return Me.string_0.IndexOf("FREE") < 0
		End Function

		' Token: 0x0600016F RID: 367 RVA: 0x0000F240 File Offset: 0x0000D440
		Public Function method_2() As DateTime
			Dim num As Integer = Me.string_0.Length - 10
			For i As Integer = 0 To num
				Dim flag As Boolean = Char.IsWhiteSpace(Me.string_0(i))
				If flag Then
					Dim s As String = Me.string_0.Substring(i + 1, 8)
					Try
						Return DateTime.ParseExact(s, "yyyyMMdd", Nothing)
					Catch ex As Exception
						Dim ex2 As Exception = ex
						Console.Write(ex2.Message)
						Exit Try
					End Try
				End If
			Next
			Return DateTime.Now
		End Function

		' Token: 0x06000170 RID: 368 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		Public Function method_3() As String
			Return Me.string_0
		End Function

		' Token: 0x040000D3 RID: 211
		Public Shared int_0 As Integer = 1

		' Token: 0x040000D4 RID: 212
		Public Shared int_1 As Integer = 7

		' Token: 0x040000D5 RID: 213
		Public Shared int_10 As Integer = 11

		' Token: 0x040000D6 RID: 214
		Public Shared int_11 As Integer = 12

		' Token: 0x040000D7 RID: 215
		Public Shared int_12 As Integer = 21

		' Token: 0x040000D8 RID: 216
		Public Shared int_13 As Integer = 22

		' Token: 0x040000D9 RID: 217
		Public Shared int_14 As Integer = 23

		' Token: 0x040000DA RID: 218
		Public Shared int_15 As Integer = 24

		' Token: 0x040000DB RID: 219
		Public Shared int_16 As Integer = 30

		' Token: 0x040000DC RID: 220
		Public Shared int_17 As Integer = 31

		' Token: 0x040000DD RID: 221
		Public Shared int_18 As Integer = 32

		' Token: 0x040000DE RID: 222
		Public Shared int_19 As Integer = 33

		' Token: 0x040000DF RID: 223
		Public Shared int_2 As Integer = 3

		' Token: 0x040000E0 RID: 224
		Public Shared int_3 As Integer = 6

		' Token: 0x040000E1 RID: 225
		Public Shared int_4 As Integer = 2

		' Token: 0x040000E2 RID: 226
		Public Shared int_5 As Integer = 5

		' Token: 0x040000E3 RID: 227
		Public Shared int_6 As Integer = 4

		' Token: 0x040000E4 RID: 228
		Public Shared int_7 As Integer = 8

		' Token: 0x040000E5 RID: 229
		Public Shared int_8 As Integer = 9

		' Token: 0x040000E6 RID: 230
		Public Shared int_9 As Integer = 10

		' Token: 0x040000E7 RID: 231
		Private string_0 As String
	End Class
End Namespace
