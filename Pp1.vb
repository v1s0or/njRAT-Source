Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000023 RID: 35
	Public NotInheritable Class Pp1
		Inherits PictureBox

		' Token: 0x060002EF RID: 751 RVA: 0x0001AF04 File Offset: 0x00019104
		Public Sub New()
			Me.font = New Font("arial", 8F, FontStyle.Bold)
			Me.Lines = New List(Of Object())()
			Dim t As Timer = New Timer() With { .Interval = 50, .Enabled = False }
			Me.T = t
			MyBase.SizeMode = PictureBoxSizeMode.Normal
		End Sub

		' Token: 0x060002F0 RID: 752 RVA: 0x0001AF64 File Offset: 0x00019164
		<DebuggerStepThrough()>
		<CompilerGenerated()>
		Private Sub ksh__4(a0 As Object, a1 As EventArgs)
			Try
				Me.wrk()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002F1 RID: 753 RVA: 0x0001AF9C File Offset: 0x0001919C
		Public Sub wrk()
			Try
				Me.T.Enabled = False
				SyncLock Me
					Dim image As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
					Me.G = Graphics.FromImage(image)
					Me.G.Clear(Color.Black)
					Dim num As Integer = 3
					Dim height As Integer = TextRenderer.MeasureText("test", Me.font).Height
					Dim color As Color = Color.White
					For i As Integer = Me.Lines.Count - 1 To 0 Step -1
						Dim num2 As Integer = 3
						Dim array As Object() = Me.Lines(i)
						Dim num3 As Integer = array.Length - 1
						For j As Integer = 0 To num3
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array(j)))))
							Dim left As String = objectValue.[GetType]().ToString()
							Dim flag As Boolean = Operators.CompareString(left, GetType(Bitmap).ToString(), False) = 0
							If flag Then
								Dim bitmap As Bitmap = CType(objectValue, Bitmap)
								Dim flag2 As Boolean = bitmap.Height > height
								If flag2 Then
									Dim callbackData As IntPtr
									bitmap = CType(bitmap.GetThumbnailImage(height, height, Nothing, callbackData), Bitmap)
								End If
								Me.G.DrawImage(bitmap, num2, num)
								num2 += bitmap.Width + 3
							Else
								Dim flag3 As Boolean = Operators.CompareString(left, GetType(String).ToString(), False) = 0
								If flag3 Then
									Dim text As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue)))
									Dim size As Size = TextRenderer.MeasureText(text, Me.font)
									Me.G.DrawString(text, Me.font, New Pen(color).Brush, CSng(num2), CSng(num))
									Dim flag4 As Boolean = size.Height - height > 0
									If flag4 Then
										num += size.Height - height
										num2 = 3
									Else
										num2 += size.Width + 3
									End If
								Else
									Dim flag5 As Boolean = Operators.CompareString(left, GetType(Color).ToString(), False) = 0
									If flag5 Then
										color = CType(objectValue, Color)
									End If
								End If
							End If
						Next
						num += height
					Next
					Me.G.Dispose()
					MyBase.Image = image
				End SyncLock
				Me.T.Enabled = True
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060002F2 RID: 754 RVA: 0x0001B264 File Offset: 0x00019464
		Public Sub WRT(ParamArray A As Object())
			SyncLock Me
				Me.Lines.Add(A)
				Dim flag As Boolean = Me.Lines.Count = 100
				If flag Then
					Me.Lines.RemoveAt(0)
				End If
			End SyncLock
		End Sub

		' Token: 0x170000FA RID: 250
		' (get) Token: 0x060002F3 RID: 755 RVA: 0x0001B2CC File Offset: 0x000194CC
		' (set) Token: 0x060002F4 RID: 756 RVA: 0x0001B2E4 File Offset: 0x000194E4
		Public Property T As Timer
			Get
				Return Me._T
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.ksh__4
				Dim flag As Boolean = Me._T IsNot Nothing
				If flag Then
					RemoveHandler Me._T.Tick, value2
				End If
				Me._T = value
				Dim flag2 As Boolean = Me._T IsNot Nothing
				If flag2 Then
					AddHandler Me._T.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x040001A1 RID: 417
		Private _T As Timer

		' Token: 0x040001A2 RID: 418
		Public font As Font

		' Token: 0x040001A3 RID: 419
		Public G As Graphics

		' Token: 0x040001A4 RID: 420
		Public Lines As List(Of Object())
	End Class
End Namespace
