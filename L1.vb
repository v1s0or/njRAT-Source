Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200002B RID: 43
	Public NotInheritable Class L1
		Inherits DataGridView

		' Token: 0x060003DE RID: 990 RVA: 0x0002A2AC File Offset: 0x000284AC
		Public Sub New()
			Me.collection_0 = New Collection()
			MyBase.SelectionMode = DataGridViewSelectionMode.FullRowSelect
			MyBase.DefaultCellStyle.WrapMode = DataGridViewTriState.[False]
			MyBase.RowHeadersVisible = False
			Me.DoubleBuffered = True
			MyBase.ShowCellErrors = True
			MyBase.ShowEditingIcon = True
			MyBase.ShowRowErrors = True
			Me.Font = New Font("arial", 8F, FontStyle.Bold)
			MyBase.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.EnableNotifyMessage Or ControlStyles.OptimizedDoubleBuffer, True)
		End Sub

		' Token: 0x060003DF RID: 991 RVA: 0x0002A338 File Offset: 0x00028538
		Public Function method_0(int_0 As Integer) As DataGridViewRow
			Return CType(Me.collection_0(int_0 + 1), DataGridViewRow)
		End Function

		' Token: 0x060003E0 RID: 992 RVA: 0x0002A360 File Offset: 0x00028560
		Public Function method_1(string_0 As String) As DataGridViewRow
			Return CType(Me.collection_0(string_0), DataGridViewRow)
		End Function

		' Token: 0x060003E1 RID: 993 RVA: 0x0002A384 File Offset: 0x00028584
		Public Sub method_10(int_0 As Integer)
			Dim invokeRequired As Boolean = MyBase.InvokeRequired
			If invokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Object = collection
				SyncLock obj
					MyBase.Invoke(AddressOf Me.method_10, New Object() { int_0 })
					Return
				End SyncLock
			End If
			MyBase.Rows.RemoveAt(int_0)
		End Sub

		' Token: 0x060003E2 RID: 994 RVA: 0x0002A3F8 File Offset: 0x000285F8
		Public Sub method_11(string_0 As String, genum0_0 As L1.GEnum0, dataGridViewAutoSizeColumnMode_0 As DataGridViewAutoSizeColumnMode)
			Dim collection As Collection = Me.collection_0
			Dim obj As Object = collection
			SyncLock obj
				Dim dataGridViewColumn As DataGridViewColumn = Nothing
				Select Case genum0_0
					Case L1.GEnum0.Text
						dataGridViewColumn = New DataGridViewTextBoxColumn()
					Case L1.GEnum0.Link
						dataGridViewColumn = New DataGridViewLinkColumn()
					Case L1.GEnum0.Image
						Dim dataGridViewImageColumn As DataGridViewImageColumn = New DataGridViewImageColumn() With { .ImageLayout = DataGridViewImageCellLayout.Zoom }
						dataGridViewColumn = dataGridViewImageColumn
					Case L1.GEnum0.StretchImage
						Dim dataGridViewImageColumn As DataGridViewImageColumn = New DataGridViewImageColumn() With { .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewColumn = dataGridViewImageColumn
				End Select
				dataGridViewColumn.AutoSizeMode = dataGridViewAutoSizeColumnMode_0
				dataGridViewColumn.Tag = genum0_0
				dataGridViewColumn.HeaderText = string_0
				MyBase.Columns.Add(dataGridViewColumn)
			End SyncLock
		End Sub

		' Token: 0x060003E3 RID: 995 RVA: 0x0002A4B8 File Offset: 0x000286B8
		Public Function method_2(string_0 As String) As Boolean
			Return Me.collection_0.Contains(string_0)
		End Function

		' Token: 0x060003E4 RID: 996 RVA: 0x0002A4D8 File Offset: 0x000286D8
		Public Function method_3() As DataGridViewRow()
			Dim list As List(Of DataGridViewRow) = New List(Of DataGridViewRow)()
			Dim flag As Boolean = MyBase.RowCount = 0
			Dim result As DataGridViewRow()
			If flag Then
				result = list.ToArray()
			Else
				Try
					Dim num As Integer = MyBase.FirstDisplayedScrollingRowIndex + MyBase.DisplayedRowCount(False)
					For i As Integer = MyBase.FirstDisplayedScrollingRowIndex To num
						Dim flag2 As Boolean = i > MyBase.RowCount - 1
						If flag2 Then
							Exit For
						End If
						Try
							list.Add(MyBase.Rows(i))
						Catch ex As Exception
							Exit Try
						End Try
					Next
				Catch ex2 As Exception
				End Try
				result = list.ToArray()
			End If
			Return result
		End Function

		' Token: 0x060003E5 RID: 997 RVA: 0x0002A5C8 File Offset: 0x000287C8
		Public Sub method_4()
			Dim collection As Collection = Me.collection_0
			Dim obj As Object = collection
			SyncLock obj
				MyBase.Rows.Clear()
				Me.collection_0.Clear()
			End SyncLock
		End Sub

		' Token: 0x060003E6 RID: 998 RVA: 0x0002A61C File Offset: 0x0002881C
		Public Function method_5(object_0 As Object()) As DataGridViewRow
			Dim invokeRequired As Boolean = MyBase.InvokeRequired
			If invokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Object = collection
				SyncLock obj
					Return CType(MyBase.Invoke(AddressOf Me.method_5, object_0), DataGridViewRow)
				End SyncLock
			End If
			Dim dataGridViewRow As DataGridViewRow = New DataGridViewRow()
			Dim num As Integer = MyBase.ColumnCount - 1
			For i As Integer = 0 To num
				Select Case Conversions.ToInteger(RuntimeHelpers.GetObjectValue(MyBase.Columns(i).Tag))
					Case 0
						Dim dataGridViewCell As DataGridViewTextBoxCell = New DataGridViewTextBoxCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i))) }
						dataGridViewRow.Cells.Add(dataGridViewCell)
					Case 1
						Dim dataGridViewCell2 As DataGridViewLinkCell = New DataGridViewLinkCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i))) }
						dataGridViewRow.Cells.Add(dataGridViewCell2)
					Case 2
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i))), .ImageLayout = DataGridViewImageCellLayout.Normal }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
					Case 3
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i))), .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
				End Select
			Next
			dataGridViewRow.Resizable = DataGridViewTriState.[False]
			Me.collection_0.Add(dataGridViewRow, Nothing, Nothing, Nothing)
			MyBase.Rows.Add(dataGridViewRow)
			Return dataGridViewRow
		End Function

		' Token: 0x060003E7 RID: 999 RVA: 0x0002A7D8 File Offset: 0x000289D8
		Public Function method_6() As Integer
			Return MyBase.RowTemplate.Height
		End Function

		' Token: 0x060003E8 RID: 1000 RVA: 0x0002A7F5 File Offset: 0x000289F5
		Public Sub method_7(int_0 As Integer)
			MyBase.RowTemplate.Height = int_0
		End Sub

		' Token: 0x060003E9 RID: 1001 RVA: 0x0002A808 File Offset: 0x00028A08
		Public Function method_8(string_0 As String, object_0 As Object()) As DataGridViewRow
			Dim invokeRequired As Boolean = MyBase.InvokeRequired
			If invokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Object = collection
				SyncLock obj
					Return CType(MyBase.Invoke(AddressOf Me.method_8, New Object() { string_0, object_0 }), DataGridViewRow)
				End SyncLock
			End If
			Dim dataGridViewRow As DataGridViewRow = New DataGridViewRow() With { .Height = Me.method_6() }
			Dim num As Integer = MyBase.ColumnCount - 1
			For i As Integer = 0 To num
				Select Case Conversions.ToInteger(RuntimeHelpers.GetObjectValue(MyBase.Columns(i).Tag))
					Case 0
						Dim dataGridViewCell As DataGridViewTextBoxCell = New DataGridViewTextBoxCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i))) }
						dataGridViewRow.Cells.Add(dataGridViewCell)
					Case 1
						Dim dataGridViewCell2 As DataGridViewLinkCell = New DataGridViewLinkCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i))) }
						dataGridViewRow.Cells.Add(dataGridViewCell2)
					Case 2
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i))), .ImageLayout = DataGridViewImageCellLayout.Zoom }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
					Case 3
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i))), .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
				End Select
			Next
			dataGridViewRow.Resizable = DataGridViewTriState.[False]
			Me.collection_0.Add(dataGridViewRow, string_0, Nothing, Nothing)
			MyBase.Rows.Add(dataGridViewRow)
			Return dataGridViewRow
		End Function

		' Token: 0x060003EA RID: 1002 RVA: 0x0002A9E0 File Offset: 0x00028BE0
		Public Sub method_9(dataGridViewRow_0 As DataGridViewRow)
			Dim invokeRequired As Boolean = MyBase.InvokeRequired
			If invokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Object = collection
				SyncLock obj
					MyBase.Invoke(AddressOf Me.method_9, New Object() { dataGridViewRow_0 })
					Return
				End SyncLock
			End If
			MyBase.Rows.Remove(dataGridViewRow_0)
		End Sub

		' Token: 0x060003EB RID: 1003 RVA: 0x0002AA50 File Offset: 0x00028C50
		Protected Overrides Sub OnMouseUp(mouseEventArgs_0 As MouseEventArgs)
			Dim flag As Boolean = mouseEventArgs_0.Button = MouseButtons.Right
			If flag Then
				Try
					Dim hitTestInfo As DataGridView.HitTestInfo = MyBase.HitTest(mouseEventArgs_0.X, mouseEventArgs_0.Y)
					Dim flag2 As Boolean = hitTestInfo.RowIndex <> -1
					If flag2 Then
						Dim dataGridViewRow As DataGridViewRow = MyBase.Rows(hitTestInfo.RowIndex)
						Dim flag3 As Boolean = Not dataGridViewRow.Selected
						If flag3 Then
							MyBase.ClearSelection()
							dataGridViewRow.Selected = True
						End If
					End If
				Catch ex As Exception
				End Try
			End If
			MyBase.OnMouseUp(mouseEventArgs_0)
		End Sub

		' Token: 0x060003EC RID: 1004 RVA: 0x0002AB04 File Offset: 0x00028D04
		Protected Overrides Sub OnMouseWheel(mouseEventArgs_0 As MouseEventArgs)
			MyBase.OnMouseWheel(mouseEventArgs_0)
			Try
				Dim delta As Integer = mouseEventArgs_0.Delta
				If delta <> -120 Then
					If delta = 120 Then
						MyBase.FirstDisplayedScrollingRowIndex = Math.Max(0, MyBase.FirstDisplayedScrollingRowIndex - SystemInformation.MouseWheelScrollLines)
					End If
				Else
					MyBase.FirstDisplayedScrollingRowIndex += SystemInformation.MouseWheelScrollLines
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003ED RID: 1005 RVA: 0x0002AB94 File Offset: 0x00028D94
		Protected Overrides Sub OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0 As DataGridViewRowPostPaintEventArgs)
			Try
				Dim dataGridViewRow As DataGridViewRow = MyBase.Rows(dataGridViewRowPostPaintEventArgs_0.RowIndex)
				Dim flag As Boolean = dataGridViewRow.Height <> Me.method_6()
				If flag Then
					dataGridViewRow.Height = Me.method_6()
				End If
			Catch ex As Exception
			End Try
			MyBase.OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0)
		End Sub

		' Token: 0x04000223 RID: 547
		Private collection_0 As Collection

		' Token: 0x02000047 RID: 71
		' (Invoke) Token: 0x06000499 RID: 1177
		Private Delegate Function Delegate1(object_0 As Object()) As DataGridViewRow

		' Token: 0x02000048 RID: 72
		' (Invoke) Token: 0x0600049D RID: 1181
		Private Delegate Function Delegate2(string_0 As String, object_0 As Object()) As DataGridViewRow

		' Token: 0x02000049 RID: 73
		' (Invoke) Token: 0x060004A1 RID: 1185
		Private Delegate Sub Delegate3(dataGridViewRow_0 As DataGridViewRow)

		' Token: 0x0200004A RID: 74
		' (Invoke) Token: 0x060004A5 RID: 1189
		Private Delegate Sub Delegate4(int_0 As Integer)

		' Token: 0x0200004B RID: 75
		Public Enum GEnum0
			' Token: 0x040002CF RID: 719
			Image = 2
			' Token: 0x040002D0 RID: 720
			Link = 1
			' Token: 0x040002D1 RID: 721
			StretchImage = 3
			' Token: 0x040002D2 RID: 722
			Text = 0
		End Enum
	End Class
End Namespace
