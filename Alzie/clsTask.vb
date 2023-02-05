Option Explicit On
'ToDo:
'
'
'Buglist:
'
'
''' <summary><para>Created on 4/20/10 by Jason S. Rushing</para></summary>
''' <remarks>Class.  Task objects.</remarks>
<Serializable()> Public Class Task
	Private mAlertBeforeDuration As Int16
	Private mAlertBeforeUnits As Integer
	Private mAlertMethod As Integer
	Private mCompleted As Boolean
	Private mCreatedOnDate As Date
	Private mDueDate As Date
	Private mPriority As Integer
	Private mText As String
	Private mTextColor As Integer
	Private mUseDueDate As Boolean
	Private mUseAlert As Boolean
	Private mUsePopup As Boolean
	Private mTaskList As String
	Private mFont As Font

	Private mIndentString As String
	Private mItemSplitChar As String = "||"
	Private mTextBeforeDueDate As String = ""
	Private mIndent As String = "   "

	Public Sub New(ByVal RawTask As String)
		Dim taskItemArray() As String
		taskItemArray = Split(RawTask, Me.ItemSplitChar)
		'format is: text||dueDate,dueTime||createdDate,createdTime||Priority||alertBefore-Duration||alertBefore-Units||Completed
		Me.Text = taskItemArray(0)
		Me.DueDate = taskItemArray(1)
		Me.CreatedOnDate = taskItemArray(2)
		Me.Priority = taskItemArray(3)
		Me.AlertBeforeDuration = taskItemArray(4)
		Me.AlertBeforeUnits = taskItemArray(5)
		Me.Completed = taskItemArray(6)
		Me.AlertMethod = taskItemArray(7)
		Me.TextColor = taskItemArray(8)
		Me.UseDueDate = taskItemArray(9)
		Me.UseAlert = taskItemArray(10)
		Me.UsePopup = taskItemArray(11)
		Me.TaskList = taskItemArray(12)
	End Sub
	Public Sub New(ByVal ts As Task)
		Me.AlertBeforeDuration = ts.AlertBeforeDuration
		Me.AlertBeforeUnits = ts.AlertBeforeUnits
		Me.AlertMethod = ts.AlertMethod
		Me.Completed = ts.Completed
		Me.CreatedOnDate = ts.CreatedOnDate
		Me.DueDate = ts.DueDate
		Me.Priority = ts.Priority
		Me.Text = ts.Text
		Me.TextColor = ts.TextColor
		Me.UseDueDate = ts.UseDueDate
		Me.UseAlert = ts.UseAlert
		Me.Font = ts.Font
	End Sub
	Public Sub New()
	End Sub

	Public Enum AlertUnits
		none
		minutes
		hours
		days
	End Enum
	Public Enum AlertMethods
		none
		email
		sound
		both
	End Enum

	Public ReadOnly Property AlertBeforeUnitsAsString(ByVal AlertBeforeUnitsAsInteger As Integer) As String
		Get
			Select Case AlertBeforeUnitsAsInteger
				Case 0
					Return "none"
				Case 1
					Return "minutes"
				Case 2
					Return "hours"
				Case 3
					Return "days"
				Case Else
					Return "none"
			End Select
		End Get
	End Property
	Public ReadOnly Property AlertMethodAsString(ByVal AlertMethodAsInteger As Integer) As String
		Get
			Select Case AlertMethodAsInteger
				Case 0
					Return "none"
				Case 1
					Return "email"
				Case 2
					Return "sound"
				Case 3
					Return "both"
				Case Else
					Return "none"
			End Select
		End Get
	End Property
	Public ReadOnly Property IndentString() As String
		Get
			Dim s As String = Me.Text
			Dim a As Integer = 0
			Do Until s.Substring(a, 1) <> " "
				a += 1
			Loop
			Return Space(a)
		End Get
	End Property
	Public ReadOnly Property ItemSplitChar() As String
		Get
			Return mItemSplitChar
		End Get
	End Property
	Public ReadOnly Property TextBeforeDueDate() As String
		Get
			Return mTextBeforeDueDate
		End Get
	End Property

	Public Property AlertBeforeDuration() As Int16
		Get
			Return mAlertBeforeDuration
		End Get
		Set(ByVal value As Int16)
			mAlertBeforeDuration = value
		End Set
	End Property
	Public Property AlertBeforeUnits() As Integer
		Get
			Return mAlertBeforeUnits
		End Get
		Set(ByVal value As Integer)
			mAlertBeforeUnits = value
		End Set
	End Property
	Public Property AlertMethod() As Integer
		Get
			Return mAlertMethod
		End Get
		Set(ByVal value As Integer)
			mAlertMethod = value
		End Set
	End Property
	Public Property Completed() As Boolean
		Get
			Return mCompleted
		End Get
		Set(ByVal value As Boolean)
			mCompleted = value
		End Set
	End Property
	Public Property CreatedOnDate() As Date
		Get
			Return mCreatedOnDate
		End Get
		Set(ByVal value As Date)
			mCreatedOnDate = value
		End Set
	End Property
	Public Property DueDate() As Date
		Get
			Return mDueDate
		End Get
		Set(ByVal value As Date)
			mDueDate = value
		End Set
	End Property
	Public Property Priority() As Int16
		Get
			Return mPriority
		End Get
		Set(ByVal value As Int16)
			mPriority = value
		End Set
	End Property
	Public Property Text() As String
		Get
			Return mText
		End Get
		Set(ByVal value As String)
			mText = value
		End Set
	End Property
	Public Property TextColor() As Integer
		Get
			Return mTextColor
		End Get
		Set(ByVal value As Integer)
			mTextColor = value
		End Set
	End Property
	Public Property UseDueDate() As Boolean
		Get
			Return mUseDueDate
		End Get
		Set(ByVal value As Boolean)
			mUseDueDate = value
		End Set
	End Property
	Public Property UseAlert() As Boolean
		Get
			Return mUseAlert
		End Get
		Set(ByVal value As Boolean)
			mUseAlert = value
		End Set
	End Property
	Public Property UsePopup() As Boolean
		Get
			Return mUsePopup
		End Get
		Set(ByVal value As Boolean)
			mUsePopup = value
		End Set
	End Property
	Public Property TaskList() As String
		Get
			Return mTaskList
		End Get
		Set(ByVal value As String)
			mTaskList = value
		End Set
	End Property
	Public Property Font() As Font
		Get
			Return mFont
		End Get
		Set(ByVal value As Font)
			mFont = value
		End Set
	End Property

	Public Sub AddIndentToText(Optional ByVal IndentsToAdd As Integer = 0)
		For a As Integer = 0 To IndentsToAdd - 1
			Me.Text = mIndent & Me.Text
		Next
	End Sub

	Public Function GetIndentLevel() As Integer
		Dim a As Integer = 0
		Do Until Me.Text.Substring(a, 1) <> " "
			a += 1
		Loop
		Return a / mIndent.Length
	End Function

	Public Sub RemoveIndentFromText(Optional ByVal IndentsToRemove As Integer = 0)
		For a As Integer = 0 To IndentsToRemove
			Me.Text = Me.Text.Substring(mIndent.Length)
		Next
	End Sub

	Delegate Function GetTaskByTaskList(ByVal Tasklist As String) As Boolean

    Public Function GetTask(ByVal Tasklist As String) As Boolean
        If Me.TaskList = Tasklist Then Return True
        Return False
    End Function
End Class
