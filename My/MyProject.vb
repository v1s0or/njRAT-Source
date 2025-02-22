Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My
	' Token: 0x02000004 RID: 4
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000210C File Offset: 0x0000030C
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x00002128 File Offset: 0x00000328
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002144 File Offset: 0x00000344
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002160 File Offset: 0x00000360
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000217C File Offset: 0x0000037C
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000001 RID: 1
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000002 RID: 2
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000003 RID: 3
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000004 RID: 4
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000005 RID: 5
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x0200002F RID: 47
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			' Token: 0x0600043A RID: 1082 RVA: 0x0002CEB4 File Offset: 0x0002B0B4
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim flag As Boolean = Instance Is Nothing OrElse Instance.IsDisposed
				If flag Then
					Dim flag2 As Boolean = MyProject.MyForms.m_FormBeingCreated IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))
						If flag3 Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return Instance
			End Function

			' Token: 0x0600043B RID: 1083 RVA: 0x0002CFDC File Offset: 0x0002B1DC
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x0600043C RID: 1084 RVA: 0x0002CFF3 File Offset: 0x0002B1F3
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x0600043D RID: 1085 RVA: 0x0002D000 File Offset: 0x0002B200
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x0600043E RID: 1086 RVA: 0x0002D020 File Offset: 0x0002B220
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600043F RID: 1087 RVA: 0x0002D038 File Offset: 0x0002B238
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x06000440 RID: 1088 RVA: 0x0002D054 File Offset: 0x0002B254
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x1700015B RID: 347
			' (get) Token: 0x06000441 RID: 1089 RVA: 0x0002D06C File Offset: 0x0002B26C
			' (set) Token: 0x06000457 RID: 1111 RVA: 0x0002D2BE File Offset: 0x0002B4BE
			Public Property About As About
				<DebuggerHidden()>
				Get
					Me.m_About = MyProject.MyForms.Create__Instance__(Of About)(Me.m_About)
					Return Me.m_About
				End Get
				<DebuggerHidden()>
				Set(value As About)
					If value IsNot Me.m_About Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of About)(Me.m_About)
					End If
				End Set
			End Property

			' Token: 0x1700015C RID: 348
			' (get) Token: 0x06000442 RID: 1090 RVA: 0x0002D087 File Offset: 0x0002B287
			' (set) Token: 0x06000458 RID: 1112 RVA: 0x0002D2EA File Offset: 0x0002B4EA
			Public Property Asemb As Asemb
				<DebuggerHidden()>
				Get
					Me.m_Asemb = MyProject.MyForms.Create__Instance__(Of Asemb)(Me.m_Asemb)
					Return Me.m_Asemb
				End Get
				<DebuggerHidden()>
				Set(value As Asemb)
					If value IsNot Me.m_Asemb Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Asemb)(Me.m_Asemb)
					End If
				End Set
			End Property

			' Token: 0x1700015D RID: 349
			' (get) Token: 0x06000443 RID: 1091 RVA: 0x0002D0A2 File Offset: 0x0002B2A2
			' (set) Token: 0x06000459 RID: 1113 RVA: 0x0002D316 File Offset: 0x0002B516
			Public Property Builder As Builder
				<DebuggerHidden()>
				Get
					Me.m_Builder = MyProject.MyForms.Create__Instance__(Of Builder)(Me.m_Builder)
					Return Me.m_Builder
				End Get
				<DebuggerHidden()>
				Set(value As Builder)
					If value IsNot Me.m_Builder Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Builder)(Me.m_Builder)
					End If
				End Set
			End Property

			' Token: 0x1700015E RID: 350
			' (get) Token: 0x06000444 RID: 1092 RVA: 0x0002D0BD File Offset: 0x0002B2BD
			' (set) Token: 0x0600045A RID: 1114 RVA: 0x0002D342 File Offset: 0x0002B542
			Public Property Cam As Cam
				<DebuggerHidden()>
				Get
					Me.m_Cam = MyProject.MyForms.Create__Instance__(Of Cam)(Me.m_Cam)
					Return Me.m_Cam
				End Get
				<DebuggerHidden()>
				Set(value As Cam)
					If value IsNot Me.m_Cam Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Cam)(Me.m_Cam)
					End If
				End Set
			End Property

			' Token: 0x1700015F RID: 351
			' (get) Token: 0x06000445 RID: 1093 RVA: 0x0002D0D8 File Offset: 0x0002B2D8
			' (set) Token: 0x0600045B RID: 1115 RVA: 0x0002D36E File Offset: 0x0002B56E
			Public Property Chat As Chat
				<DebuggerHidden()>
				Get
					Me.m_Chat = MyProject.MyForms.Create__Instance__(Of Chat)(Me.m_Chat)
					Return Me.m_Chat
				End Get
				<DebuggerHidden()>
				Set(value As Chat)
					If value IsNot Me.m_Chat Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Chat)(Me.m_Chat)
					End If
				End Set
			End Property

			' Token: 0x17000160 RID: 352
			' (get) Token: 0x06000446 RID: 1094 RVA: 0x0002D0F3 File Offset: 0x0002B2F3
			' (set) Token: 0x0600045C RID: 1116 RVA: 0x0002D39A File Offset: 0x0002B59A
			Public Property DW As DW
				<DebuggerHidden()>
				Get
					Me.m_DW = MyProject.MyForms.Create__Instance__(Of DW)(Me.m_DW)
					Return Me.m_DW
				End Get
				<DebuggerHidden()>
				Set(value As DW)
					If value IsNot Me.m_DW Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of DW)(Me.m_DW)
					End If
				End Set
			End Property

			' Token: 0x17000161 RID: 353
			' (get) Token: 0x06000447 RID: 1095 RVA: 0x0002D10E File Offset: 0x0002B30E
			' (set) Token: 0x0600045D RID: 1117 RVA: 0x0002D3C6 File Offset: 0x0002B5C6
			Public Property Form1 As Form1
				<DebuggerHidden()>
				Get
					Me.m_Form1 = MyProject.MyForms.Create__Instance__(Of Form1)(Me.m_Form1)
					Return Me.m_Form1
				End Get
				<DebuggerHidden()>
				Set(value As Form1)
					If value IsNot Me.m_Form1 Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form1)(Me.m_Form1)
					End If
				End Set
			End Property

			' Token: 0x17000162 RID: 354
			' (get) Token: 0x06000448 RID: 1096 RVA: 0x0002D129 File Offset: 0x0002B329
			' (set) Token: 0x0600045E RID: 1118 RVA: 0x0002D3F2 File Offset: 0x0002B5F2
			Public Property FromLink As FromLink
				<DebuggerHidden()>
				Get
					Me.m_FromLink = MyProject.MyForms.Create__Instance__(Of FromLink)(Me.m_FromLink)
					Return Me.m_FromLink
				End Get
				<DebuggerHidden()>
				Set(value As FromLink)
					If value IsNot Me.m_FromLink Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FromLink)(Me.m_FromLink)
					End If
				End Set
			End Property

			' Token: 0x17000163 RID: 355
			' (get) Token: 0x06000449 RID: 1097 RVA: 0x0002D144 File Offset: 0x0002B344
			' (set) Token: 0x0600045F RID: 1119 RVA: 0x0002D41E File Offset: 0x0002B61E
			Public Property FURL As FURL
				<DebuggerHidden()>
				Get
					Me.m_FURL = MyProject.MyForms.Create__Instance__(Of FURL)(Me.m_FURL)
					Return Me.m_FURL
				End Get
				<DebuggerHidden()>
				Set(value As FURL)
					If value IsNot Me.m_FURL Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FURL)(Me.m_FURL)
					End If
				End Set
			End Property

			' Token: 0x17000164 RID: 356
			' (get) Token: 0x0600044A RID: 1098 RVA: 0x0002D15F File Offset: 0x0002B35F
			' (set) Token: 0x06000460 RID: 1120 RVA: 0x0002D44A File Offset: 0x0002B64A
			Public Property kl As kl
				<DebuggerHidden()>
				Get
					Me.m_kl = MyProject.MyForms.Create__Instance__(Of kl)(Me.m_kl)
					Return Me.m_kl
				End Get
				<DebuggerHidden()>
				Set(value As kl)
					If value IsNot Me.m_kl Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of kl)(Me.m_kl)
					End If
				End Set
			End Property

			' Token: 0x17000165 RID: 357
			' (get) Token: 0x0600044B RID: 1099 RVA: 0x0002D17A File Offset: 0x0002B37A
			' (set) Token: 0x06000461 RID: 1121 RVA: 0x0002D476 File Offset: 0x0002B676
			Public Property Manager As Manager
				<DebuggerHidden()>
				Get
					Me.m_Manager = MyProject.MyForms.Create__Instance__(Of Manager)(Me.m_Manager)
					Return Me.m_Manager
				End Get
				<DebuggerHidden()>
				Set(value As Manager)
					If value IsNot Me.m_Manager Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Manager)(Me.m_Manager)
					End If
				End Set
			End Property

			' Token: 0x17000166 RID: 358
			' (get) Token: 0x0600044C RID: 1100 RVA: 0x0002D195 File Offset: 0x0002B395
			' (set) Token: 0x06000462 RID: 1122 RVA: 0x0002D4A2 File Offset: 0x0002B6A2
			Public Property Mic As Mic
				<DebuggerHidden()>
				Get
					Me.m_Mic = MyProject.MyForms.Create__Instance__(Of Mic)(Me.m_Mic)
					Return Me.m_Mic
				End Get
				<DebuggerHidden()>
				Set(value As Mic)
					If value IsNot Me.m_Mic Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Mic)(Me.m_Mic)
					End If
				End Set
			End Property

			' Token: 0x17000167 RID: 359
			' (get) Token: 0x0600044D RID: 1101 RVA: 0x0002D1B0 File Offset: 0x0002B3B0
			' (set) Token: 0x06000463 RID: 1123 RVA: 0x0002D4CE File Offset: 0x0002B6CE
			Public Property Mynoip As Mynoip
				<DebuggerHidden()>
				Get
					Me.m_Mynoip = MyProject.MyForms.Create__Instance__(Of Mynoip)(Me.m_Mynoip)
					Return Me.m_Mynoip
				End Get
				<DebuggerHidden()>
				Set(value As Mynoip)
					If value IsNot Me.m_Mynoip Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Mynoip)(Me.m_Mynoip)
					End If
				End Set
			End Property

			' Token: 0x17000168 RID: 360
			' (get) Token: 0x0600044E RID: 1102 RVA: 0x0002D1CB File Offset: 0x0002B3CB
			' (set) Token: 0x06000464 RID: 1124 RVA: 0x0002D4FA File Offset: 0x0002B6FA
			Public Property Note As Note
				<DebuggerHidden()>
				Get
					Me.m_Note = MyProject.MyForms.Create__Instance__(Of Note)(Me.m_Note)
					Return Me.m_Note
				End Get
				<DebuggerHidden()>
				Set(value As Note)
					If value IsNot Me.m_Note Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Note)(Me.m_Note)
					End If
				End Set
			End Property

			' Token: 0x17000169 RID: 361
			' (get) Token: 0x0600044F RID: 1103 RVA: 0x0002D1E6 File Offset: 0x0002B3E6
			' (set) Token: 0x06000465 RID: 1125 RVA: 0x0002D526 File Offset: 0x0002B726
			Public Property notf As notf
				<DebuggerHidden()>
				Get
					Me.m_notf = MyProject.MyForms.Create__Instance__(Of notf)(Me.m_notf)
					Return Me.m_notf
				End Get
				<DebuggerHidden()>
				Set(value As notf)
					If value IsNot Me.m_notf Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of notf)(Me.m_notf)
					End If
				End Set
			End Property

			' Token: 0x1700016A RID: 362
			' (get) Token: 0x06000450 RID: 1104 RVA: 0x0002D201 File Offset: 0x0002B401
			' (set) Token: 0x06000466 RID: 1126 RVA: 0x0002D552 File Offset: 0x0002B752
			Public Property Pass As Pass
				<DebuggerHidden()>
				Get
					Me.m_Pass = MyProject.MyForms.Create__Instance__(Of Pass)(Me.m_Pass)
					Return Me.m_Pass
				End Get
				<DebuggerHidden()>
				Set(value As Pass)
					If value IsNot Me.m_Pass Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Pass)(Me.m_Pass)
					End If
				End Set
			End Property

			' Token: 0x1700016B RID: 363
			' (get) Token: 0x06000451 RID: 1105 RVA: 0x0002D21C File Offset: 0x0002B41C
			' (set) Token: 0x06000467 RID: 1127 RVA: 0x0002D57E File Offset: 0x0002B77E
			Public Property port As port
				<DebuggerHidden()>
				Get
					Me.m_port = MyProject.MyForms.Create__Instance__(Of port)(Me.m_port)
					Return Me.m_port
				End Get
				<DebuggerHidden()>
				Set(value As port)
					If value IsNot Me.m_port Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of port)(Me.m_port)
					End If
				End Set
			End Property

			' Token: 0x1700016C RID: 364
			' (get) Token: 0x06000452 RID: 1106 RVA: 0x0002D237 File Offset: 0x0002B437
			' (set) Token: 0x06000468 RID: 1128 RVA: 0x0002D5AA File Offset: 0x0002B7AA
			Public Property RGv As RGv
				<DebuggerHidden()>
				Get
					Me.m_RGv = MyProject.MyForms.Create__Instance__(Of RGv)(Me.m_RGv)
					Return Me.m_RGv
				End Get
				<DebuggerHidden()>
				Set(value As RGv)
					If value IsNot Me.m_RGv Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of RGv)(Me.m_RGv)
					End If
				End Set
			End Property

			' Token: 0x1700016D RID: 365
			' (get) Token: 0x06000453 RID: 1107 RVA: 0x0002D252 File Offset: 0x0002B452
			' (set) Token: 0x06000469 RID: 1129 RVA: 0x0002D5D6 File Offset: 0x0002B7D6
			Public Property sc As sc
				<DebuggerHidden()>
				Get
					Me.m_sc = MyProject.MyForms.Create__Instance__(Of sc)(Me.m_sc)
					Return Me.m_sc
				End Get
				<DebuggerHidden()>
				Set(value As sc)
					If value IsNot Me.m_sc Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of sc)(Me.m_sc)
					End If
				End Set
			End Property

			' Token: 0x1700016E RID: 366
			' (get) Token: 0x06000454 RID: 1108 RVA: 0x0002D26D File Offset: 0x0002B46D
			' (set) Token: 0x0600046A RID: 1130 RVA: 0x0002D602 File Offset: 0x0002B802
			Public Property script As script
				<DebuggerHidden()>
				Get
					Me.m_script = MyProject.MyForms.Create__Instance__(Of script)(Me.m_script)
					Return Me.m_script
				End Get
				<DebuggerHidden()>
				Set(value As script)
					If value IsNot Me.m_script Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of script)(Me.m_script)
					End If
				End Set
			End Property

			' Token: 0x1700016F RID: 367
			' (get) Token: 0x06000455 RID: 1109 RVA: 0x0002D288 File Offset: 0x0002B488
			' (set) Token: 0x0600046B RID: 1131 RVA: 0x0002D62E File Offset: 0x0002B82E
			Public Property STNG As STNG
				<DebuggerHidden()>
				Get
					Me.m_STNG = MyProject.MyForms.Create__Instance__(Of STNG)(Me.m_STNG)
					Return Me.m_STNG
				End Get
				<DebuggerHidden()>
				Set(value As STNG)
					If value IsNot Me.m_STNG Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of STNG)(Me.m_STNG)
					End If
				End Set
			End Property

			' Token: 0x17000170 RID: 368
			' (get) Token: 0x06000456 RID: 1110 RVA: 0x0002D2A3 File Offset: 0x0002B4A3
			' (set) Token: 0x0600046C RID: 1132 RVA: 0x0002D65A File Offset: 0x0002B85A
			Public Property up As up
				<DebuggerHidden()>
				Get
					Me.m_up = MyProject.MyForms.Create__Instance__(Of up)(Me.m_up)
					Return Me.m_up
				End Get
				<DebuggerHidden()>
				Set(value As up)
					If value IsNot Me.m_up Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of up)(Me.m_up)
					End If
				End Set
			End Property

			' Token: 0x0400024F RID: 591
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable

			' Token: 0x04000250 RID: 592
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_About As About

			' Token: 0x04000251 RID: 593
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Asemb As Asemb

			' Token: 0x04000252 RID: 594
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Builder As Builder

			' Token: 0x04000253 RID: 595
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Cam As Cam

			' Token: 0x04000254 RID: 596
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Chat As Chat

			' Token: 0x04000255 RID: 597
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_DW As DW

			' Token: 0x04000256 RID: 598
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Form1 As Form1

			' Token: 0x04000257 RID: 599
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FromLink As FromLink

			' Token: 0x04000258 RID: 600
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FURL As FURL

			' Token: 0x04000259 RID: 601
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_kl As kl

			' Token: 0x0400025A RID: 602
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Manager As Manager

			' Token: 0x0400025B RID: 603
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Mic As Mic

			' Token: 0x0400025C RID: 604
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Mynoip As Mynoip

			' Token: 0x0400025D RID: 605
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Note As Note

			' Token: 0x0400025E RID: 606
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_notf As notf

			' Token: 0x0400025F RID: 607
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Pass As Pass

			' Token: 0x04000260 RID: 608
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_port As port

			' Token: 0x04000261 RID: 609
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_RGv As RGv

			' Token: 0x04000262 RID: 610
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_sc As sc

			' Token: 0x04000263 RID: 611
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_script As script

			' Token: 0x04000264 RID: 612
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_STNG As STNG

			' Token: 0x04000265 RID: 613
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_up As up
		End Class

		' Token: 0x02000030 RID: 48
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			' Token: 0x0600046D RID: 1133 RVA: 0x0002D688 File Offset: 0x0002B888
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x0600046E RID: 1134 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600046F RID: 1135 RVA: 0x0002D6C0 File Offset: 0x0002B8C0
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x06000470 RID: 1136 RVA: 0x0002D6DC File Offset: 0x0002B8DC
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x06000471 RID: 1137 RVA: 0x0002D6F4 File Offset: 0x0002B8F4
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim flag As Boolean = instance Is Nothing
				Dim result As T
				If flag Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

			' Token: 0x06000472 RID: 1138 RVA: 0x0002D71D File Offset: 0x0002B91D
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x06000473 RID: 1139 RVA: 0x0002CFF3 File Offset: 0x0002B1F3
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000031 RID: 49
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x17000171 RID: 369
			' (get) Token: 0x06000474 RID: 1140 RVA: 0x0002D728 File Offset: 0x0002B928
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					Dim flag As Boolean = MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing
					If flag Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x06000475 RID: 1141 RVA: 0x0002CFF3 File Offset: 0x0002B1F3
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x04000266 RID: 614
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
