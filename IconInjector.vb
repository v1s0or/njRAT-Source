Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security

Namespace NJRAT
	' Token: 0x0200000B RID: 11
	Public Class IconInjector
		' Token: 0x06000080 RID: 128 RVA: 0x000053B0 File Offset: 0x000035B0
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String)
			IconInjector.InjectIcon(exeFileName, iconFileName, 1UI, 1UI)
		End Sub

		' Token: 0x06000081 RID: 129 RVA: 0x000053C0 File Offset: 0x000035C0
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String, iconGroupID As UInteger, iconBaseID As UInteger)
			Dim iconFile As IconInjector.IconFile = IconInjector.IconFile.FromFile(iconFileName)
			Dim hUpdate As IntPtr = IconInjector.NativeMethods.BeginUpdateResource(exeFileName, False)
			Dim array As Byte() = iconFile.CreateIconGroupData(iconBaseID)
			IconInjector.NativeMethods.UpdateResource(hUpdate, New IntPtr(14L), New IntPtr(CLng(CULng(iconGroupID))), 0S, array, array.Length)
			Dim num As Integer = iconFile.ImageCount - 1
			For i As Integer = 0 To num
				Dim array2 As Byte() = iconFile.get_ImageData(i)
				IconInjector.NativeMethods.UpdateResource(hUpdate, New IntPtr(3L), New IntPtr(CLng((CULng(iconBaseID) + CULng(CLng(i))))), 0S, array2, array2.Length)
			Next
			IconInjector.NativeMethods.EndUpdateResource(hUpdate, False)
		End Sub

		' Token: 0x02000032 RID: 50
		<SuppressUnmanagedCodeSecurity()>
		Private Class NativeMethods
			' Token: 0x06000477 RID: 1143
			Public Declare Function BeginUpdateResource Lib "kernel32" (fileName As String, <MarshalAs(UnmanagedType.Bool)> deleteExistingResources As Boolean) As IntPtr

			' Token: 0x06000478 RID: 1144
			Public Declare Function UpdateResource Lib "kernel32" (hUpdate As IntPtr, type As IntPtr, name As IntPtr, language As Short, <MarshalAs(UnmanagedType.LPArray, SizeParamIndex := 5S)> data As Byte(), dataSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean

			' Token: 0x06000479 RID: 1145
			Public Declare Function EndUpdateResource Lib "kernel32" (hUpdate As IntPtr, <MarshalAs(UnmanagedType.Bool)> discard As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Class

		' Token: 0x02000033 RID: 51
		Private Structure ICONDIR
			' Token: 0x04000267 RID: 615
			Public Reserved As UShort

			' Token: 0x04000268 RID: 616
			Public Type As UShort

			' Token: 0x04000269 RID: 617
			Public Count As UShort
		End Structure

		' Token: 0x02000034 RID: 52
		Private Structure ICONDIRENTRY
			' Token: 0x0400026A RID: 618
			Public Width As Byte

			' Token: 0x0400026B RID: 619
			Public Height As Byte

			' Token: 0x0400026C RID: 620
			Public ColorCount As Byte

			' Token: 0x0400026D RID: 621
			Public Reserved As Byte

			' Token: 0x0400026E RID: 622
			Public Planes As UShort

			' Token: 0x0400026F RID: 623
			Public BitCount As UShort

			' Token: 0x04000270 RID: 624
			Public BytesInRes As Integer

			' Token: 0x04000271 RID: 625
			Public ImageOffset As Integer
		End Structure

		' Token: 0x02000035 RID: 53
		Private Structure BITMAPINFOHEADER
			' Token: 0x04000272 RID: 626
			Public Size As UInteger

			' Token: 0x04000273 RID: 627
			Public Width As Integer

			' Token: 0x04000274 RID: 628
			Public Height As Integer

			' Token: 0x04000275 RID: 629
			Public Planes As UShort

			' Token: 0x04000276 RID: 630
			Public BitCount As UShort

			' Token: 0x04000277 RID: 631
			Public Compression As UInteger

			' Token: 0x04000278 RID: 632
			Public SizeImage As UInteger

			' Token: 0x04000279 RID: 633
			Public XPelsPerMeter As Integer

			' Token: 0x0400027A RID: 634
			Public YPelsPerMeter As Integer

			' Token: 0x0400027B RID: 635
			Public ClrUsed As UInteger

			' Token: 0x0400027C RID: 636
			Public ClrImportant As UInteger
		End Structure

		' Token: 0x02000036 RID: 54
		<StructLayout(LayoutKind.Sequential, Pack := 2)>
		Private Structure GRPICONDIRENTRY
			' Token: 0x0400027D RID: 637
			Public Width As Byte

			' Token: 0x0400027E RID: 638
			Public Height As Byte

			' Token: 0x0400027F RID: 639
			Public ColorCount As Byte

			' Token: 0x04000280 RID: 640
			Public Reserved As Byte

			' Token: 0x04000281 RID: 641
			Public Planes As UShort

			' Token: 0x04000282 RID: 642
			Public BitCount As UShort

			' Token: 0x04000283 RID: 643
			Public BytesInRes As Integer

			' Token: 0x04000284 RID: 644
			Public ID As UShort
		End Structure

		' Token: 0x02000037 RID: 55
		Private Class IconFile
			' Token: 0x17000172 RID: 370
			' (get) Token: 0x0600047A RID: 1146 RVA: 0x0002D75C File Offset: 0x0002B95C
			Public ReadOnly Property ImageCount As Integer
				Get
					Return CInt(Me.iconDir.Count)
				End Get
			End Property

			' Token: 0x17000173 RID: 371
			' (get) Token: 0x0600047B RID: 1147 RVA: 0x0002D77C File Offset: 0x0002B97C
			Public ReadOnly Property ImageData(index As Integer) As Byte()
				Get
					Return Me.iconImage(index)
				End Get
			End Property

			' Token: 0x0600047C RID: 1148 RVA: 0x0002D796 File Offset: 0x0002B996
			Private Sub New()
				Me.iconDir = Nothing
			End Sub

			' Token: 0x0600047D RID: 1149 RVA: 0x0002D7AC File Offset: 0x0002B9AC
			Public Shared Function FromFile(filename As String) As IconInjector.IconFile
				Dim iconFile As IconInjector.IconFile = New IconInjector.IconFile()
				Dim array As Byte() = File.ReadAllBytes(filename)
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				iconFile.iconDir = CType(Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), GetType(IconInjector.ICONDIR)), IconInjector.ICONDIR)
				iconFile.iconEntry = New IconInjector.ICONDIRENTRY(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1) {}
				iconFile.iconImage = New Byte(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1)() {}
				Dim num As Integer = Marshal.SizeOf(iconFile.iconDir)
				Dim typeFromHandle As Type = GetType(IconInjector.ICONDIRENTRY)
				Dim num2 As Integer = Marshal.SizeOf(typeFromHandle)
				Dim num3 As Integer = CInt((iconFile.iconDir.Count - 1US))
				For i As Integer = 0 To num3
					Dim icondirentry As IconInjector.ICONDIRENTRY = CType(Marshal.PtrToStructure(New IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + CLng(num)), typeFromHandle), IconInjector.ICONDIRENTRY)
					iconFile.iconEntry(i) = icondirentry
					iconFile.iconImage(i) = New Byte(icondirentry.BytesInRes - 1 + 1 - 1) {}
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage(i), 0, icondirentry.BytesInRes)
					num += num2
				Next
				gchandle.Free()
				Return iconFile
			End Function

			' Token: 0x0600047E RID: 1150 RVA: 0x0002D8F0 File Offset: 0x0002BAF0
			Public Function CreateIconGroupData(iconBaseID As UInteger) As Byte()
				Dim num As Integer = Marshal.SizeOf(GetType(IconInjector.ICONDIR)) + Marshal.SizeOf(GetType(IconInjector.GRPICONDIRENTRY)) * Me.ImageCount
				Dim array As Byte() = New Byte(num - 1 + 1 - 1) {}
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				Marshal.StructureToPtr(Me.iconDir, gchandle.AddrOfPinnedObject(), False)
				Dim num2 As Integer = Marshal.SizeOf(Me.iconDir)
				Dim num3 As Integer = Me.ImageCount - 1
				For i As Integer = 0 To num3
					Dim grpicondirentry As IconInjector.GRPICONDIRENTRY = Nothing
					Dim bitmapinfoheader As IconInjector.BITMAPINFOHEADER = Nothing
					Dim gchandle2 As GCHandle = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned)
					Marshal.Copy(Me.get_ImageData(i), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(GetType(IconInjector.BITMAPINFOHEADER)))
					gchandle2.Free()
					grpicondirentry.Width = Me.iconEntry(i).Width
					grpicondirentry.Height = Me.iconEntry(i).Height
					grpicondirentry.ColorCount = Me.iconEntry(i).ColorCount
					grpicondirentry.Reserved = Me.iconEntry(i).Reserved
					grpicondirentry.Planes = bitmapinfoheader.Planes
					grpicondirentry.BitCount = bitmapinfoheader.BitCount
					grpicondirentry.BytesInRes = Me.iconEntry(i).BytesInRes
					grpicondirentry.ID = CUShort((CULng(iconBaseID) + CULng(CLng(i))))
					Marshal.StructureToPtr(grpicondirentry, New IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + CLng(num2)), False)
					num2 += Marshal.SizeOf(GetType(IconInjector.GRPICONDIRENTRY))
				Next
				gchandle.Free()
				Return array
			End Function

			' Token: 0x04000285 RID: 645
			Private iconDir As IconInjector.ICONDIR

			' Token: 0x04000286 RID: 646
			Private iconEntry As IconInjector.ICONDIRENTRY()

			' Token: 0x04000287 RID: 647
			Private iconImage As Byte()()
		End Class
	End Class
End Namespace
