Imports System
Imports System.Runtime.InteropServices
Imports System.Security

Namespace NJRAT
	' Token: 0x02000016 RID: 22
	<SuppressUnmanagedCodeSecurity()>
	Public NotInheritable Class GClass2
		' Token: 0x0600014A RID: 330
		Public Declare Function BeginUpdateResource Lib "kernel32" (string_0 As String, <MarshalAs(UnmanagedType.Bool)> bool_0 As Boolean) As IntPtr

		' Token: 0x0600014B RID: 331
		Public Declare Function EndUpdateResource Lib "kernel32" (intptr_0 As IntPtr, <MarshalAs(UnmanagedType.Bool)> bool_0 As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean

		' Token: 0x0600014C RID: 332
		Public Declare Function UpdateResource Lib "kernel32" (intptr_0 As IntPtr, intptr_1 As IntPtr, intptr_2 As IntPtr, short_0 As Short, <MarshalAs(UnmanagedType.LPArray, SizeConst := 0, SizeParamIndex := 5S)> byte_0 As Byte(), int_0 As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Class
End Namespace
