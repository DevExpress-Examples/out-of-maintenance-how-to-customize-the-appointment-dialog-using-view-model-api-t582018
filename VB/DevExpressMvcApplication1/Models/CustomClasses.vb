Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace DevExpressMvcApplication1.Models
	#Region "#customappointment"
	Public Class CustomAppointment
		Private m_Start As DateTime
		Private m_End As DateTime
		Private m_Subject As String
		Private m_Status As Integer
		Private m_Description As String
		Private m_Label As Integer
		Private m_Location As String
		Private m_Allday As Boolean
		Private m_EventType As Integer
		Private m_RecurrenceInfo As String
		Private m_ReminderInfo As String
		Private m_OwnerId As Object
		Private m_Id As Integer


		Public Property StartTime() As DateTime
			Get
				Return m_Start
			End Get
			Set(ByVal value As DateTime)
				m_Start = value
			End Set
		End Property
		Public Property EndTime() As DateTime
			Get
				Return m_End
			End Get
			Set(ByVal value As DateTime)
				m_End = value
			End Set
		End Property
		Public Property Subject() As String
			Get
				Return m_Subject
			End Get
			Set(ByVal value As String)
				m_Subject = value
			End Set
		End Property
		Public Property Status() As Integer
			Get
				Return m_Status
			End Get
			Set(ByVal value As Integer)
				m_Status = value
			End Set
		End Property
		Public Property Description() As String
			Get
				Return m_Description
			End Get
			Set(ByVal value As String)
				m_Description = value
			End Set
		End Property
		Public Property Label() As Integer
			Get
				Return m_Label
			End Get
			Set(ByVal value As Integer)
				m_Label = value
			End Set
		End Property
		Public Property Location() As String
			Get
				Return m_Location
			End Get
			Set(ByVal value As String)
				m_Location = value
			End Set
		End Property
		Public Property AllDay() As Boolean
			Get
				Return m_Allday
			End Get
			Set(ByVal value As Boolean)
				m_Allday = value
			End Set
		End Property
		Public Property EventType() As Integer
			Get
				Return m_EventType
			End Get
			Set(ByVal value As Integer)
				m_EventType = value
			End Set
		End Property
		Public Property RecurrenceInfo() As String
			Get
				Return m_RecurrenceInfo
			End Get
			Set(ByVal value As String)
				m_RecurrenceInfo = value
			End Set
		End Property
		Public Property ReminderInfo() As String
			Get
				Return m_ReminderInfo
			End Get
			Set(ByVal value As String)
				m_ReminderInfo = value
			End Set
		End Property
		Public Property OwnerId() As Object
			Get
				Return m_OwnerId
			End Get
			Set(ByVal value As Object)
				m_OwnerId = value
			End Set
		End Property
		Public Property ID() As Integer
			Get
				Return m_Id
			End Get
			Set(ByVal value As Integer)
				m_Id = value
			End Set
		End Property

		Public Sub New()
		End Sub

'INSTANT VB NOTE: The variable subject was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable status was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable label was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Shared Function CreateCustomAppointment(ByVal subject_Renamed As String, ByVal resourceId As Object, ByVal status_Renamed As Integer, ByVal label_Renamed As Integer, ByVal id_Renamed As Integer) As CustomAppointment
			Dim apt As New CustomAppointment()
			apt.ID = id_Renamed
			apt.Subject = subject_Renamed
			apt.OwnerId = resourceId
			apt.StartTime = DateTime.Now.AddHours(id_Renamed)
			apt.EndTime = apt.StartTime.AddHours(3)
			apt.Status = status_Renamed
			apt.Label = label_Renamed
			apt.Description = "Some detailed information about " & apt.Subject
			Return apt
		End Function
	End Class
	#End Region '  #customappointment

	#Region "#customresource"
	Public Class CustomResource
		Private m_name As String
		Private m_res_id As Integer
		Private m_res_color As Integer

		Public Property Name() As String
			Get
				Return m_name
			End Get
			Set(ByVal value As String)
				m_name = value
			End Set
		End Property
		Public Property ResID() As Integer
			Get
				Return m_res_id
			End Get
			Set(ByVal value As Integer)
				m_res_id = value
			End Set
		End Property
		Public Property Color() As Integer
			Get
				Return m_res_color
			End Get
			Set(ByVal value As Integer)
				m_res_color = value
			End Set
		End Property

		Public Sub New()

		End Sub

		Public Shared Function CreateCustomResource(ByVal res_id As Integer, ByVal caption As String, ByVal ResColor As Integer) As CustomResource
			Dim cr As New CustomResource()
			cr.ResID = res_id
			cr.Name = caption
			cr.Color = ResColor
			Return cr
		End Function

	End Class
	#End Region ' #customresource

	Public Class SchedulerDataObject
		Public Property Appointments() As List(Of CustomAppointment)
		Public Property Resources() As List(Of CustomResource)
	End Class
End Namespace