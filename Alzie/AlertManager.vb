Option Explicit On
'ToDo:
'
'  
'Buglist:
'
'
''' <summary><para>Created on 4/28/10 by Jason S. Rushing</para></summary>
''' <remarks>Manage alerts when due date reached.</remarks>
Public Class AlertManager
	Private mAllTasks As New List(Of Task)
    Private tFM As clsTaskFileManager
    Private mDisplayedTaskModified As Boolean = False
    Private mCurrentlyDisplayedTasklist As String

    Public Sub New(ByVal TaskFileMgr As clsTaskFileManager)
        tFM = TaskFileMgr
        'mAllTasks = New List(Of Task)
        mAllTasks = tFM.AllTasksInSystem
    End Sub
	Public Sub New()
	End Sub

	Public ReadOnly Property DisplayedTaskModified() As Boolean
		Get
			Return mDisplayedTaskModified
		End Get
	End Property
	Public WriteOnly Property CurrentlyDisplayedTasklist() As String
		Set(ByVal value As String)
			mCurrentlyDisplayedTasklist = value
		End Set
	End Property

    Public Sub CheckForAlerts()
        mDisplayedTaskModified = False
        Dim method As Task.AlertMethods
        Dim t As Task
        For a As Integer = 0 To mAllTasks.Count - 1
            t = mAllTasks.Item(a)
            'If t.Text.Contains("No code") Then Stop
            If t.UseDueDate Then Debug.Print(t.Text)
            If t.UseDueDate AndAlso AlertNow(t) Then
                method = t.AlertMethod
                Select Case method
                    Case Task.AlertMethods.email
                        'send email
                    Case Task.AlertMethods.sound
                        'play sound
                    Case Task.AlertMethods.both
                        'send email and play sound
                End Select
                With formTaskIsDue
                    .Text = "Due at " & Format(t.DueDate, "HH:mm") & " on " & Format(t.DueDate, "MM/dd/yy")
                    .lblTask.Text = TruncateString(t.Text, 50)
                    .lblTasklist.Text = TruncateString(t.TaskList, 50)
                    If method = Task.AlertMethods.email Or method = Task.AlertMethods.both Then _
                     .lblMore.Text = "An email was sent to " & "<the email address ... don't have this yet>"

                    If Form1.WindowState = FormWindowState.Minimized Then
                        Form1.WindowState = FormWindowState.Normal
                    Else
                        Form1.WindowState = FormWindowState.Minimized
                        Form1.WindowState = FormWindowState.Normal
                    End If
                    .ShowDialog()
                    If .AlertCanceled Or .Snoozed Then
                        Dim tOld As Task = t
                        Dim tNew As Task = t
                        If .AlertCanceled Then
                            tNew.UseDueDate = False
                        Else
                            t.DueDate = DateAdd(DateInterval.Minute, .SnoozedMinutes, Now) ' t.DueDate)
                        End If
                        tFM.WriteOneTask(tOld, tNew)
                        mAllTasks = tFM.AllTasksInSystem
                        If t.TaskList = mCurrentlyDisplayedTasklist Then mDisplayedTaskModified = True
                    End If
                    .Close()
                End With
            End If
        Next
    End Sub

    Private Function AlertNow(ByVal tsk As Task) As Boolean
        Dim units As Task.AlertUnits = tsk.AlertBeforeUnits
        If tsk.AlertBeforeDuration = 0 Then tsk.AlertBeforeDuration = 1
        Select Case units
            Case Task.AlertUnits.minutes
                If DateDiff(DateInterval.Minute, Now, tsk.DueDate) * tsk.AlertBeforeDuration <= 0 Then Return True
            Case Task.AlertUnits.hours
                If DateDiff(DateInterval.Hour, Now, tsk.DueDate) * tsk.AlertBeforeDuration <= 0 Then Return True
            Case Task.AlertUnits.days
                If DateDiff(DateInterval.Day, Now, tsk.DueDate) * tsk.AlertBeforeDuration <= 0 Then Return True
            Case Task.AlertUnits.none
                If DateDiff(DateInterval.Minute, Now, tsk.DueDate) <= 0 Then Return True
        End Select
        Return False
    End Function

    Private Function TruncateString(ByVal StringToTruncate As String, ByVal MaxLength As Integer) As String
        Dim s As String = StringToTruncate.Trim
        If s.Length > MaxLength Then
            Return s.Substring(0, MaxLength) & "..."
        Else
            Return s
        End If
    End Function
End Class
