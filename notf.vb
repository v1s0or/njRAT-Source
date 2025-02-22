Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x02000020 RID: 32
	<DesignerGenerated()>
	Public Partial Class notf
		Inherits Form

		' Token: 0x170000E1 RID: 225
		' (get) Token: 0x0600029D RID: 669 RVA: 0x00018841 File Offset: 0x00016A41
		' (set) Token: 0x0600029E RID: 670 RVA: 0x0001884C File Offset: 0x00016A4C
		Friend Overridable Property p As PictureBox
			<CompilerGenerated()>
			Get
				Return Me._p
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.p_Click
				Dim p As PictureBox = Me._p
				If p IsNot Nothing Then
					RemoveHandler p.Click, value2
				End If
				Me._p = value
				p = Me._p
				If p IsNot Nothing Then
					AddHandler p.Click, value2
				End If
			End Set
		End Property

		' Token: 0x0600029F RID: 671 RVA: 0x00018890 File Offset: 0x00016A90
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.notf_Load
			AddHandler MyBase.Load, AddressOf Me.notf_Load
			Me.bool_0 = True
			Me.Items = New List(Of notf.GClass15)()
			Me.InitializeComponent()
		End Sub

		' Token: 0x060002A0 RID: 672 RVA: 0x000188E4 File Offset: 0x00016AE4
		Public Sub AddItem(img As Bitmap, Text As String)
			Dim items As List(Of notf.GClass15) = Me.Items
			Dim obj As Object = items
			SyncLock obj
				Dim flag As Boolean = Me.Items.Count > 50
				If flag Then
					Me.Items.RemoveAt(0)
				End If
				Dim item As notf.GClass15 = New notf.GClass15() With { .bitmap_0 = CType(img.Clone(), Bitmap), .string_0 = Text }
				Me.Items.Add(item)
			End SyncLock
		End Sub

		' Token: 0x060002A1 RID: 673 RVA: 0x00018974 File Offset: 0x00016B74
		Public Sub back()
			Me.bool_0 = True
			Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
			MyBase.Left = workingArea.Width - MyBase.Width - 5
			MyBase.Top = workingArea.Height - MyBase.Height - 5
		End Sub

		' Token: 0x060002A2 RID: 674 RVA: 0x000189C4 File Offset: 0x00016BC4
		Public Sub go()
			Me.bool_0 = False
			Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
			MyBase.Left = workingArea.Width
			MyBase.Top = workingArea.Height
		End Sub

		' Token: 0x060002A3 RID: 675 RVA: 0x00018A00 File Offset: 0x00016C00
		Private Sub p_Click(sender As Object, e As EventArgs)
			Dim items As List(Of notf.GClass15) = Me.Items
			Dim obj As Object = items
			SyncLock obj
				Me.Items.Clear()
			End SyncLock
		End Sub

		' Token: 0x060002A4 RID: 676 RVA: 0x00018A48 File Offset: 0x00016C48
		Private Sub notf_Load(sender As Object, e As EventArgs)
			Me.p.BackColor = Color.Pink
			MyBase.TransparencyKey = Color.Pink
			Me.back()
			Control.CheckForIllegalCrossThreadCalls = False
			Dim thread As Thread = AddressOf Me.wrk
			thread.Start()
		End Sub

		' Token: 0x060002A5 RID: 677 RVA: 0x00018A9C File Offset: 0x00016C9C
		Public Sub wrk()
			While True
				Thread.Sleep(50)
				Dim flag As Boolean = Me.Items.Count = 0
				If flag Then
					Me.go()
				Else
					Try
						Dim bitmap As Bitmap = New Bitmap(Me.p.Width, Me.p.Height)
						Dim graphics As Graphics = Graphics.FromImage(bitmap)
						graphics.Clear(Me.p.BackColor)
						Dim items As List(Of notf.GClass15) = Me.Items
						Dim obj As Object = items
						SyncLock obj
							Try
								For Each gclass As notf.GClass15 In Me.Items
									Dim flag2 As Boolean = gclass.int_0 <= 2
									If flag2 Then
										gclass.int_0 = 2
										Dim gclass2 As notf.GClass15 = gclass
										Dim gclass3 As notf.GClass15 = gclass2
										Dim ptr As Integer = gclass3.int_1
										gclass3.int_1 = ptr + 1
									Else
										Dim count As Integer = Me.Items.Count
										Dim flag3 As Boolean = count > 30
										If flag3 Then
											gclass.int_0 = 2
										Else
											Dim flag4 As Boolean = count > 20
											If flag4 Then
												Dim gclass2 As notf.GClass15 = gclass
												gclass2.int_0 += -20
											Else
												Dim flag5 As Boolean = count > 10
												If flag5 Then
													Dim gclass2 As notf.GClass15 = gclass
													gclass2.int_0 += -10
												Else
													Dim gclass2 As notf.GClass15 = gclass
													gclass2.int_0 += -2
												End If
											End If
										End If
										Dim flag6 As Boolean = gclass.int_0 < 2
										If flag6 Then
											gclass.int_0 = 2
										End If
									End If
									Dim size As Size = TextRenderer.MeasureText(gclass.string_0, Me.Font)
									size.Width = bitmap.Width
									size.Height += 5
									Dim rectangle As Rectangle = New Rectangle(0, gclass.int_0 - 2, MyBase.Width, size.Height)
									graphics.FillRectangle(Brushes.Black, rectangle)
									rectangle = New Rectangle(0, gclass.int_0 - 2, MyBase.Width, size.Height)
									ControlPaint.DrawLockedFrame(graphics, rectangle, False)
									Dim array As Object() = New Object(1) {}
									array(0) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(gclass.bitmap_0.Clone()))
									Dim point As Point = New Point(5, gclass.int_0 - 2)
									array(1) = point
									NewLateBinding.LateCall(graphics, Nothing, "DrawImage", array, Nothing, Nothing, Nothing, True)
									graphics.DrawString(gclass.string_0, Me.Font, Brushes.LightSteelBlue, 5F, CSng(gclass.int_0))
									Dim flag7 As Boolean = gclass.int_0 > MyBase.Height - 50
									If flag7 Then
										Exit For
									End If
								Next
							Finally
								Dim enumerator As List(Of notf.GClass15).Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
							While True
								IL_2A1:
								Try
									For Each gclass4 As notf.GClass15 In Me.Items
										Dim flag8 As Boolean = gclass4.int_1 = 40
										If flag8 Then
											Me.Items.Remove(gclass4)
											GoTo IL_2A1
										End If
									Next
								Finally
									Dim enumerator2 As List(Of notf.GClass15).Enumerator
									CType(enumerator2, IDisposable).Dispose()
								End Try
								Exit For
							End While
							Dim flag9 As Boolean = Me.Items.Count = 0 And Me.bool_0
							If flag9 Then
								Me.go()
							End If
							Dim flag10 As Boolean = Me.Items.Count > 0 And Not Me.bool_0
							If flag10 Then
								Me.back()
							End If
						End SyncLock
						graphics.Flush(FlushIntention.Sync)
						graphics.Dispose()
						Me.p.Image = bitmap
					Catch ex As Exception
					End Try
				End If
			End While
		End Sub

		' Token: 0x04000183 RID: 387
		Private bool_0 As Boolean

		' Token: 0x04000184 RID: 388
		Public Items As List(Of notf.GClass15)

		' Token: 0x0200003C RID: 60
		Public NotInheritable Class GClass15
			' Token: 0x06000481 RID: 1153 RVA: 0x0002DAFD File Offset: 0x0002BCFD
			Public Sub New()
				Me.int_0 = MyProject.Forms.notf.Height
				Me.int_1 = 0
			End Sub

			' Token: 0x04000297 RID: 663
			Public bitmap_0 As Bitmap

			' Token: 0x04000298 RID: 664
			Public int_0 As Integer

			' Token: 0x04000299 RID: 665
			Public int_1 As Integer

			' Token: 0x0400029A RID: 666
			Public string_0 As String
		End Class
	End Class
End Namespace
