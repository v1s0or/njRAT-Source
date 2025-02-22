Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200002A RID: 42
	<DesignerGenerated()>
	Public NotInheritable Class GClass9
		Inherits ListView

		' Token: 0x060003CC RID: 972 RVA: 0x00029698 File Offset: 0x00027898
		Public Sub New()
			AddHandler MyBase.ParentChanged, AddressOf Me.GClass9_ParentChanged
			AddHandler MyBase.MouseMove, AddressOf Me.GClass9_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.GClass9_MouseUp
			AddHandler MyBase.ColumnClick, AddressOf Me.GClass9_ColumnClick
			AddHandler MyBase.KeyDown, AddressOf Me.GClass9_KeyDown
			AddHandler MyBase.MouseDown, AddressOf Me.GClass9_MouseDown
			Me.listViewItem_0 = Nothing
			Me.point_0 = Point.Empty
			Me.point_1 = Point.Empty
			Me.AllowDrop = False
			Me.Font = New Font("arial", 8F, FontStyle.Bold)
			Me.Dock = DockStyle.Fill
			MyBase.FullRowSelect = True
			MyBase.View = View.Details
			MyBase.OwnerDraw = True
			MyBase.SetStyle(ControlStyles.UserPaint, False)
			Me.DoubleBuffered = True
			MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			MyBase.SetStyle(ControlStyles.EnableNotifyMessage, True)
		End Sub

		' Token: 0x060003CD RID: 973 RVA: 0x000297A6 File Offset: 0x000279A6
		<CompilerGenerated()>
		<DebuggerStepThrough()>
		Private Sub lam__3(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x060003CE RID: 974 RVA: 0x000297A6 File Offset: 0x000279A6
		<DebuggerStepThrough()>
		<CompilerGenerated()>
		Private Sub lam__4(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x060003CF RID: 975 RVA: 0x000297B0 File Offset: 0x000279B0
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.icontainer_0 IsNot Nothing
				If flag Then
					Me.icontainer_0.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x060003D0 RID: 976 RVA: 0x00029800 File Offset: 0x00027A00
		Public Sub GClass9_ColumnClick(sender As Object, e As ColumnClickEventArgs)
			SyncLock Me
				Dim flag As Boolean = e.Column <> -1
				If flag Then
					Try
						Dim columnHeader As ColumnHeader = CType(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(sender), Nothing, "Columns", New Object() { e.Column }, Nothing, Nothing, Nothing), ColumnHeader)
						Dim flag2 As Boolean = Me.columnHeader_0 Is Nothing
						Dim sortOrder_ As SortOrder
						If flag2 Then
							sortOrder_ = SortOrder.Ascending
							columnHeader.Tag = "+"
						Else
							Dim flag3 As Boolean = columnHeader.Equals(Me.columnHeader_0)
							If flag3 Then
								Dim flag4 As Boolean = Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(Me.columnHeader_0.Tag), "+", False)
								If flag4 Then
									sortOrder_ = SortOrder.Descending
									Me.columnHeader_0.Tag = "-"
								Else
									Me.columnHeader_0.Tag = "+"
									sortOrder_ = SortOrder.Ascending
								End If
							Else
								sortOrder_ = SortOrder.Ascending
							End If
						End If
						Me.columnHeader_0 = columnHeader
						Dim flag5 As Boolean = Me.columnHeader_0.Tag Is Nothing
						If flag5 Then
							Me.columnHeader_0.Tag = "+"
						End If
						Dim flag6 As Boolean = sender IsNot Nothing
						If flag6 Then
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), Nothing, "ListViewItemSorter", New Object() { New GClass9.GClass10(e.Column, sortOrder_) }, Nothing, Nothing)
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(sender), Nothing, "Sort", New Object(-1) {}, Nothing, Nothing, Nothing, True)
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), Nothing, "ListViewItemSorter", New Object(0) {}, Nothing, Nothing)
						End If
					Catch ex As Exception
					End Try
				End If
			End SyncLock
		End Sub

		' Token: 0x060003D1 RID: 977 RVA: 0x000299E4 File Offset: 0x00027BE4
		Private Sub GClass9_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.Space
			If flag Then
				Me.method_3()
			End If
			Dim flag2 As Boolean = e.KeyCode = Keys.A And e.Control
			If flag2 Then
				Try
					For Each obj As Object In MyBase.Items
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						listViewItem.Selected = True
					Next
				Finally
					Dim enumerator As IEnumerator
					Dim flag3 As Boolean = TypeOf enumerator Is IDisposable
					If flag3 Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060003D2 RID: 978 RVA: 0x00029A84 File Offset: 0x00027C84
		Private Sub GClass9_MouseDown(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Me.listViewItem_0 = MyBase.GetItemAt(e.X, e.Y)
				Me.point_0 = e.Location
			End If
		End Sub

		' Token: 0x060003D3 RID: 979 RVA: 0x00029ACC File Offset: 0x00027CCC
		Private Sub GClass9_MouseMove(sender As Object, e As MouseEventArgs)
			Me.point_1 = e.Location
			Dim flag As Boolean = Me.point_0 <> Point.Empty
			If flag Then
				Dim flag2 As Boolean = Me.listViewItem_0 IsNot Nothing AndAlso Me.listViewItem_0.Index = -1
				If flag2 Then
					Me.listViewItem_0 = Nothing
				End If
				Dim flag3 As Boolean = (e.Button = MouseButtons.Left And Me.listViewItem_0 IsNot Nothing) AndAlso Me.listViewItem_0 IsNot Nothing
				If flag3 Then
					Dim itemAt As ListViewItem = MyBase.GetItemAt(e.X, e.Y)
					Dim flag4 As Boolean = itemAt IsNot Nothing
					If flag4 Then
						Dim flag5 As Boolean = itemAt.Index > Me.listViewItem_0.Index
						If flag5 Then
							Dim index As Integer = itemAt.Index
							For i As Integer = Me.listViewItem_0.Index To index
								Dim flag6 As Boolean = Not MyBase.SelectedIndices.Contains(i)
								If flag6 Then
									MyBase.SelectedIndices.Add(i)
								End If
							Next
							Try
								For Each obj As Object In MyBase.SelectedIndices
									Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj))
									Dim flag7 As Boolean = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue), Me.listViewItem_0.Index, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue), itemAt.Index, False)))))
									If flag7 Then
										MyBase.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue)))
									End If
								Next
								Return
							Finally
								Dim enumerator As IEnumerator
								Dim flag8 As Boolean = TypeOf enumerator Is IDisposable
								If flag8 Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
						End If
						Dim index2 As Integer = Me.listViewItem_0.Index
						For j As Integer = itemAt.Index To index2
							Dim flag9 As Boolean = Not MyBase.SelectedIndices.Contains(j)
							If flag9 Then
								MyBase.SelectedIndices.Add(j)
							End If
						Next
						Try
							For Each obj2 As Object In MyBase.SelectedIndices
								Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj2))
								Dim flag10 As Boolean = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue2), itemAt.Index, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue2), Me.listViewItem_0.Index, False)))))
								If flag10 Then
									MyBase.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue2)))
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							Dim flag11 As Boolean = TypeOf enumerator2 Is IDisposable
							If flag11 Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
				End If
			End If
		End Sub

		' Token: 0x060003D4 RID: 980 RVA: 0x00029DEC File Offset: 0x00027FEC
		Private Sub GClass9_MouseUp(sender As Object, e As MouseEventArgs)
			Me.listViewItem_0 = Nothing
			Me.point_0 = Point.Empty
		End Sub

		' Token: 0x060003D5 RID: 981 RVA: 0x00029E04 File Offset: 0x00028004
		Private Sub GClass9_ParentChanged(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = MyBase.Parent IsNot Nothing
				If flag Then
					RemoveHandler MyBase.Parent.Resize, AddressOf Me.lam__3
				End If
				AddHandler MyBase.Parent.Resize, AddressOf Me.lam__4
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003D6 RID: 982 RVA: 0x00029E84 File Offset: 0x00028084
		<DebuggerStepThrough()>
		Private Sub method_0()
			Me.icontainer_0 = New Container()
		End Sub

		' Token: 0x060003D7 RID: 983 RVA: 0x00029E92 File Offset: 0x00028092
		Public Sub method_1()
			Me.method_3()
		End Sub

		' Token: 0x060003D8 RID: 984 RVA: 0x00029E9C File Offset: 0x0002809C
		Public Function method_2() As ListViewItem()
			Dim result As ListViewItem()
			SyncLock Me
				Dim list As List(Of ListViewItem) = New List(Of ListViewItem)()
				Dim flag As Boolean = MyBase.Items.Count = 0
				If flag Then
					Return list.ToArray()
				End If
				Try
					Dim listViewItem As ListViewItem = MyBase.TopItem
					list.Add(listViewItem)
					Dim num As Integer = MyBase.Items.Count - 1
					For i As Integer = listViewItem.Index + 1 To num
						Try
							listViewItem = MyBase.Items(i)
							Dim flag2 As Boolean = MyBase.Bounds.IntersectsWith(MyBase.Items(i).Bounds)
							If Not flag2 Then
								Exit Try
							End If
							list.Add(listViewItem)
						Catch ex As Exception
							Exit Try
						End Try
					Next
				Catch ex2 As Exception
				End Try
				result = list.ToArray()
			End SyncLock
			Return result
		End Function

		' Token: 0x060003D9 RID: 985 RVA: 0x0002A014 File Offset: 0x00028214
		Public Sub method_3()
			Try
				Dim flag As Boolean = MyBase.Columns.Count <> 0
				If flag Then
					Dim flag2 As Boolean = MyBase.Items.Count = 0
					If flag2 Then
						MyBase.Columns(MyBase.Columns.Count - 1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
					Else
						Dim num As Integer = MyBase.Columns.Count - 1
						For i As Integer = 0 To num
							MyBase.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
						Next
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003DA RID: 986 RVA: 0x0002A0D8 File Offset: 0x000282D8
		Protected Overrides Sub OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0 As DrawListViewColumnHeaderEventArgs)
			Try
				Dim format As StringFormat = New StringFormat() With { .FormatFlags = StringFormatFlags.NoWrap, .Trimming = StringTrimming.EllipsisCharacter, .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near }
				Dim rect As Rectangle = New Rectangle(drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.Width, drawListViewColumnHeaderEventArgs_0.Bounds.Height)
				drawListViewColumnHeaderEventArgs_0.Graphics.FillRectangle(New Pen(ControlPaint.Light(Me.BackColor, 0.1F)).Brush, rect)
				drawListViewColumnHeaderEventArgs_0.Graphics.DrawString(drawListViewColumnHeaderEventArgs_0.Header.Text, Me.Font, New Pen(Me.ForeColor).Brush, drawListViewColumnHeaderEventArgs_0.Bounds, format)
				drawListViewColumnHeaderEventArgs_0.Graphics.DrawLine(New Pen(Me.ForeColor), drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y + drawListViewColumnHeaderEventArgs_0.Bounds.Height)
				drawListViewColumnHeaderEventArgs_0.DrawDefault = False
			Catch ex As Exception
			End Try
			MyBase.OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0)
		End Sub

		' Token: 0x060003DB RID: 987 RVA: 0x0002A258 File Offset: 0x00028458
		Protected Overrides Sub OnDrawItem(drawListViewItemEventArgs_0 As DrawListViewItemEventArgs)
			drawListViewItemEventArgs_0.DrawDefault = True
			MyBase.OnDrawItem(drawListViewItemEventArgs_0)
		End Sub

		' Token: 0x060003DC RID: 988 RVA: 0x0002A26B File Offset: 0x0002846B
		Protected Overrides Sub OnDrawSubItem(drawListViewSubItemEventArgs_0 As DrawListViewSubItemEventArgs)
			drawListViewSubItemEventArgs_0.DrawDefault = True
			MyBase.OnDrawSubItem(drawListViewSubItemEventArgs_0)
		End Sub

		' Token: 0x060003DD RID: 989 RVA: 0x0002A280 File Offset: 0x00028480
		Protected Overrides Sub OnNotifyMessage(message_0 As Message)
			Dim flag As Boolean = message_0.Msg <> 20
			If flag Then
				MyBase.OnNotifyMessage(message_0)
			End If
		End Sub

		' Token: 0x0400021E RID: 542
		Public columnHeader_0 As ColumnHeader

		' Token: 0x0400021F RID: 543
		Private icontainer_0 As IContainer

		' Token: 0x04000220 RID: 544
		Private listViewItem_0 As ListViewItem

		' Token: 0x04000221 RID: 545
		Private point_0 As Point

		' Token: 0x04000222 RID: 546
		Private point_1 As Point

		' Token: 0x02000046 RID: 70
		Public NotInheritable Class GClass10
			Implements IComparer

			' Token: 0x06000493 RID: 1171 RVA: 0x0002E167 File Offset: 0x0002C367
			Public Sub New(int_1 As Integer, sortOrder_1 As SortOrder)
				Me.int_0 = int_1
				Me.sortOrder_0 = sortOrder_1
			End Sub

			' Token: 0x06000494 RID: 1172 RVA: 0x0002E180 File Offset: 0x0002C380
			Public Function Compare(object_0 As Object, object_1 As Object) As Integer
				Dim listViewItem As ListViewItem = CType(object_0, ListViewItem)
				Dim listViewItem2 As ListViewItem = CType(object_1, ListViewItem)
				Dim flag As Boolean = listViewItem.SubItems.Count <= Me.int_0
				Dim text As String
				If flag Then
					text = String.Empty
				Else
					text = listViewItem.SubItems(Me.int_0).Text
				End If
				Dim flag2 As Boolean = listViewItem2.SubItems.Count <= Me.int_0
				Dim text2 As String
				If flag2 Then
					text2 = String.Empty
				Else
					text2 = listViewItem2.SubItems(Me.int_0).Text
				End If
				Dim flag3 As Boolean = Me.sortOrder_0 = SortOrder.Ascending
				Dim result As Integer
				If flag3 Then
					Dim flag4 As Boolean = Versioned.IsNumeric(text) And Versioned.IsNumeric(text2)
					If flag4 Then
						result = Conversion.Val(text).CompareTo(Conversion.Val(text2))
					Else
						Dim flag5 As Boolean = Information.IsDate(text) And Information.IsDate(text2)
						If flag5 Then
							result = DateTime.Parse(text).CompareTo(DateTime.Parse(text2))
						Else
							result = String.Compare(text, text2)
						End If
					End If
				Else
					Dim flag6 As Boolean = Versioned.IsNumeric(text) And Versioned.IsNumeric(text2)
					If flag6 Then
						result = Conversion.Val(text2).CompareTo(Conversion.Val(text))
					Else
						Dim flag7 As Boolean = Information.IsDate(text) And Information.IsDate(text2)
						If flag7 Then
							result = DateTime.Parse(text2).CompareTo(DateTime.Parse(text))
						Else
							result = String.Compare(text2, text)
						End If
					End If
				End If
				Return result
			End Function

			' Token: 0x06000495 RID: 1173 RVA: 0x0002E2F4 File Offset: 0x0002C4F4
			Public Function Compare1(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
				Dim result As Integer
				Return result
			End Function

			' Token: 0x040002CC RID: 716
			Private int_0 As Integer

			' Token: 0x040002CD RID: 717
			Private sortOrder_0 As SortOrder
		End Class
	End Class
End Namespace
