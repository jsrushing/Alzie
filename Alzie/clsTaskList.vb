'ToDo:
'
'Buglist:
'
'
Imports System.IO
''' <summary><para>Created on 4/20/10 by Jason S. Rushing</para></summary>
''' <remarks>Main class.  Maintains a list of tasks.</remarks>
Public Class clsTaskList
    Private mTaskList As New List(Of Task)
    Private mDisplayControl As ListView
    Private mDisplayControlForNames As ComboBox
    Private mOperationCanceled As Boolean = False
    Private mTaskListName As String
    Private tFM As clsTaskFileManager

    Public ReadOnly Property OperationCanceled() As Boolean
        Get
            Return mOperationCanceled
        End Get
    End Property

    Public Property TaskListName() As String
        Get
            Return mTaskListName
        End Get
        Set(ByVal value As String)
            mTaskListName = value
        End Set
    End Property

    Public ReadOnly Property TaskPriority(ByVal TaskIndex As Integer) As Int16
        Get
            Return mTaskList.Item(TaskIndex).Priority
        End Get
    End Property

    Public Property TaskTextColor(ByVal TaskIndex As Integer) As Integer
        Get
            Return mTaskList.Item(TaskIndex).TextColor
        End Get
        Set(ByVal value As Integer)
            mTaskList.Item(TaskIndex).TextColor = value
        End Set
    End Property

    Public ReadOnly Property TaskListList() As List(Of Task)
        Get
            Return mTaskList
        End Get
    End Property

    Public Sub New(ByVal DisplayControl As ListView)
        mDisplayControl = DisplayControl
    End Sub

    Public Sub New(ByVal DisplayControl As ListView, ByVal TaskFileManager As clsTaskFileManager)
        mDisplayControl = DisplayControl
        Me.tFM = TaskFileManager
        mDisplayControlForNames = Form1.cbxTaskLists
    End Sub

    Public Sub New()
    End Sub

    Public Sub AddTask(ByVal TaskListName As String, Optional ByVal TaskIndex As Integer = -1, Optional ByVal TaskToAdd As Task = Nothing)
        'Try..Catch in calling procedure?
        Try
            mOperationCanceled = False
            Dim t As Task
            If TaskToAdd Is Nothing Then
                With formTaskDetails
                    If TaskIndex = 0 Then
                        .PreceedingTask = New Task
                    Else
                        .PreceedingTask = mTaskList.Item(TaskIndex - 1)
                    End If
                    .DefaultTaskFont = Form1.LstVuDefaultFont ' Me.mDisplayControl.Font
                    .ShowDialog()
                    If Not .Canceled Then
                        t = .ReturnTask
                        t.TaskList = TaskListName
                        If TaskIndex <> mDisplayControl.Items.Count Then
                            mTaskList.Insert(TaskIndex, t)
                        Else
                            mTaskList.Add(t)
                        End If
                        If TaskIndex = -1 Then TaskIndex = mTaskList.Count - 1
                        DisplayTaskList(TaskIndex)
                    Else
                        mOperationCanceled = True
                    End If
                    .Dispose()
                End With
            Else
                mTaskList.Add(TaskToAdd)
                DisplayTaskList(TaskIndex)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & " in TaskList.AddTask")
        End Try
    End Sub

    Public Sub AddConfiguredTask(ByVal TaskToAdd As Task)
        mTaskList.Add(TaskToAdd)
    End Sub

    Public Sub ClearTasks()
        mTaskList.Clear()
    End Sub

    Public Sub DeleteTasks(ByVal ItemsToDelete As ArrayList, ByVal ShowPrompt As Boolean)
        'Try..Catch in calling procedure?
        Dim s As String = ""
        Dim tL As New List(Of Task)
        mOperationCanceled = False
        For a As Integer = 0 To ItemsToDelete.Count - 1
            tL.Add(mTaskList.Item(ItemsToDelete(a)))
            If tL(a).Text = "" Then _
              s &= "(blank item)" Else _
              s &= tL(a).Text.Trim
            s &= vbCrLf
        Next

        Dim DeleteConfirmed As DialogResult = DialogResult.OK

        If ShowPrompt Then DeleteConfirmed = MessageBox.Show( _
        "Please confirm removal of the following tasks" & vbCrLf & s, _
          "Confirm Task Removal", MessageBoxButtons.OKCancel)

        If DeleteConfirmed = DialogResult.OK Then                                                               'User confirmation.
            If tL.Count = mTaskList.Count Then                                                                      'Deleting all tasks.
                Dim DeleteTasklistConfirmed As DialogResult = DialogResult.Yes

                If ShowPrompt Then DeleteTasklistConfirmed = _
                  MessageBox.Show("Do you want to delete the tasklist as well?  " & _
                  "If you answer 'No' a placeholder task will be created.", _
                  My.Application.Info.ProductName, _
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) '						'Prompt user if ShowPrompt = True.

                Select Case DeleteTasklistConfirmed
                    Case DialogResult.Yes                   'Delete tasklist.
                        DeleteTaskList(False)
                        mOperationCanceled = True
                    Case DialogResult.No                        'Not deleting tasklist (still deleting all tasks).
                        For a As Integer = 0 To tL.Count - 1                                                            'Delete tasks,
                            mTaskList.Remove(tL(a))
                        Next
                        Dim t As New Task                                                                                   ' then create and add a placeholder task.
                        t.TaskList = Me.mDisplayControlForNames.Text
                        t.Text = "... insert task text here ..."
                        t.Font = Form1.LstVuDefaultFont
                        AddTask(t.TaskList, , t)
                    Case DialogResult.Cancel
                        Exit Sub
                End Select
            Else                                                                                                                    'Not deleting all tasks.
                For a As Integer = 0 To tL.Count - 1
                    mTaskList.Remove(tL(a))
                Next
                DisplayTaskList()
            End If
        Else
            mOperationCanceled = True
        End If
    End Sub

    Public Sub DeleteTaskList(Optional ByVal ShowPrompt As Boolean = True)
        'Try..Catch in calling procedure?
        Try
            mOperationCanceled = False
            If ShowPrompt Then
                If MessageBox.Show("Do you want to delete the task list '" & Me.TaskListName & _
                 "'?", "Confirm Task List Removal", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Err.Raise(1)
            End If
            tFM.DeleteTaskListFromArray(Me)
            GetTaskListNamesAndFillControl(mDisplayControlForNames, True)
            Me.mDisplayControl.Items.Clear()
            Me.mDisplayControlForNames.Text = ""
        Catch ex As Exception
            mOperationCanceled = True
        End Try
    End Sub

    Public Sub DisplayTaskList(Optional ByVal ReselectListIndex As Integer = -1, Optional ByVal ReselectListIndicies As ArrayList = Nothing)
        'Try..Catch in calling procedures?
        With mDisplayControl
            Dim defaultFont As New Font("MS Sans Serif", 8)
            Dim maxSizedFont As Font = defaultFont
            '.Visible = False
            .Items.Clear()
            Dim l As List(Of Task) = mTaskList
            Dim ts As Task = Nothing
            Dim msg As String = ""
            'Dim f As String = My.Settings.DateTimeFormat
            'f = f.Substring(1)
            'f = f.Substring(0, f.Length - 1)
            For a As Integer = 0 To l.Count - 1
                ts = l.Item(a)
                If ts.Text <> "" Then
                    .Items.Add(a + 1)
                    .Items(a).SubItems.Add(ts.Priority)                                         '0
                    .Items(a).SubItems.Add(ts.Text)                                             '1

                    'If ts.UseDueDate Then _
                    '  .Items(a).SubItems.Add(Format(ts.DueDate, f)) Else _
                    '  .Items(a).SubItems.Add("") '												'2

                    If ts.UseDueDate Then _
                     .Items(a).SubItems.Add(Format(ts.DueDate, "MM/dd/yy HH:mm")) Else _
                     .Items(a).SubItems.Add("") '												'2

                    .Items(a).ForeColor = Color.FromArgb(ts.TextColor)                          '3

                    If ts.Completed Then .Items(a).ForeColor = Color.Gray '						'4

                    '.Items(a).SubItems.Add(Format(ts.CreatedOnDate, My.Settings.DateTimeFormat))			'5

                    .Items(a).SubItems.Add(Format(ts.CreatedOnDate, "MM/dd/yy HH:mm"))          '5

                    If ts.UseDueDate AndAlso ts.UseAlert Then
                        msg = ts.AlertBeforeDuration & " " & _
                         ts.AlertBeforeUnitsAsString(ts.AlertBeforeUnits) & " by " & _
                         ts.AlertMethodAsString(ts.AlertMethod)
                        'If ts.UsePopup Then msg &= " + msg."
                        .Items(a).SubItems.Add(msg)
                    Else
                        .Items(a).SubItems.Add("")
                    End If

                Else
                    .Items.Add(a + 1)
                    .Items(a).SubItems.Add(" ")
                End If

                If ts.Font IsNot Nothing Then
                    .Items(a).Font = ts.Font
                End If

                If l.Item(a).Font IsNot Nothing AndAlso l.Item(a).Font.Size > maxSizedFont.Size Then maxSizedFont = l.Item(a).Font

            Next

            With mDisplayControl
                If maxSizedFont.Size <> .Font.Size Then
                    If maxSizedFont.Size > .Font.Size Then
                        maxSizedFont = New Font(maxSizedFont.FontFamily, maxSizedFont.Size + 1) ' maxFontSize.Size
                    End If
                    .Font = New Font(defaultFont.FontFamily, maxSizedFont.Size)
                    For a As Integer = 0 To l.Count - 1
                        .Items(a).Font = l.Item(a).Font
                    Next
                End If
            End With


            If ReselectListIndex > mDisplayControl.Items.Count Then ReselectListIndex = mDisplayControl.Items.Count - 1
            If ReselectListIndex <> -1 And ReselectListIndex < .Items.Count Then .Items(ReselectListIndex).Selected = True

            If ReselectListIndicies IsNot Nothing Then
                For a As Integer = 0 To ReselectListIndicies.Count - 1
                    .Items(ReselectListIndicies.Item(a)).Selected = True
                Next
            End If
            .Visible = True
            On Error Resume Next
            .EnsureVisible(Form1.CurrentListTopIndex)
            On Error GoTo 0
            .Focus()
        End With
    End Sub

    Public Sub EditTask(ByVal TaskIndex As Integer)
        'Try..Catch in calling procedure?
        mOperationCanceled = False
        With formTaskDetails
            .Task = mTaskList.Item(TaskIndex)
            If TaskIndex <> 0 AndAlso _
            mTaskList.Item(TaskIndex - 1).Text <> "" Then _
             .PreceedingTask = mTaskList.Item(TaskIndex - 1)
            .ShowDialog()
            If Not .Canceled Then
                Dim t As Task = mTaskList.Item(TaskIndex)
                Dim t2 As Task = .ReturnTask(t)
                mTaskList.RemoveAt(TaskIndex)
                mTaskList.Insert(TaskIndex, t2)
                DisplayTaskList(TaskIndex)
            Else
                mOperationCanceled = True
            End If
            .Dispose()
        End With
    End Sub

    Public Sub GetTaskListByName(ByVal TaskListName As String)
        'Try..Catch in calling procedure?
        mTaskList = tFM.GetTaskListByName(TaskListName)
        mTaskListName = TaskListName
        DisplayTaskList()
    End Sub

    Private Function GetTaskListNames(ByVal RefreshList As Boolean) As ArrayList
        'Try..Catch in calling procedure?
        Return tFM.GetTaskListNames
    End Function

    Public Sub GetTaskListNamesAndFillControl(ByVal comboBoxToFill As ComboBox, Optional ByVal RefreshList As Boolean = False)
        'Try..Catch in calling procedure?
        comboBoxToFill.Items.Clear()
        Dim al As ArrayList = GetTaskListNames(RefreshList)
        For a As Integer = 0 To al.Count - 1
            comboBoxToFill.Items.Add(al.Item(a).ToString)
        Next
        comboBoxToFill.Items.Add("")
    End Sub

    Public Sub MarkTasksComplete(ByVal ItemsToMarkComplete As ArrayList, ByVal MarkComplete As Boolean)
        'Try..Catch in calling procedure?
        For a As Integer = 0 To ItemsToMarkComplete.Count - 1
            mTaskList.Item(ItemsToMarkComplete.Item(a)).Completed = MarkComplete
        Next
        DisplayTaskList(, ItemsToMarkComplete)
    End Sub

    Private Sub MoveTask_LeftRight(ByVal TaskIndex As Integer, ByVal AddIndent As Boolean, Optional ByVal ReSelectItem As Boolean = True)
        'Try..Catch in calling procedure?
        Try
            mOperationCanceled = False
            Dim t As Task = mTaskList.Item(TaskIndex)
            If AddIndent Then
                t.AddIndentToText(1)
            Else
                If t.Text.Substring(0, 1) <> " " Then Exit Sub
                t.RemoveIndentFromText()
            End If
            If ReSelectItem Then _
            DisplayTaskList(TaskIndex)
        Catch ex As Exception
            mOperationCanceled = True
        End Try
    End Sub

    Public Sub MoveTasks_LeftRight(ByVal ItemsToMove As ArrayList, ByVal AddIndent As Boolean)
        'Try..Catch in calling procedure?
        For a As Integer = 0 To ItemsToMove.Count - 1
            MoveTask_LeftRight(ItemsToMove(a), AddIndent, False)
        Next
        DisplayTaskList()
        For a As Integer = 0 To ItemsToMove.Count - 1
            mDisplayControl.SelectedIndices.Add(ItemsToMove(a))
        Next
    End Sub

    Public Sub MoveTask_UpDown(ByVal ItemsToMove As ArrayList, ByVal MoveUp As Boolean)
        Dim al As New ArrayList
        For a As Integer = 0 To ItemsToMove.Count - 1
            al.Add(ItemsToMove.Item(a))
        Next
        Dim t As Task
        mOperationCanceled = False
        If MoveUp Then
            For a As Integer = 0 To al.Count - 1
                t = mTaskList.Item(al.Item(a))
                mTaskList.RemoveAt(al.Item(a))
                mTaskList.Insert(al.Item(a) - 1, t)
            Next
        Else
            For a As Integer = al.Count - 1 To 0 Step -1
                t = mTaskList.Item(al.Item(a))
                mTaskList.RemoveAt(al.Item(a))
                mTaskList.Insert(al.Item(a) + 1, t)
            Next
        End If
        ItemsToMove.Clear()
        If MoveUp Then
            For a As Integer = 0 To al.Count - 1
                ItemsToMove.Add(al.Item(a) - 1)
            Next
        Else
            For a As Integer = 0 To al.Count - 1
                ItemsToMove.Add(al.Item(a) + 1)
            Next
        End If
        DisplayTaskList(, ItemsToMove)
    End Sub

    Public Sub RemoveBlanksAndIndents()
        Dim a As Integer
        With Me.TaskListList
            Do Until a = .Count
                If .Item(a).Text = "" Then
                    .RemoveAt(a)
                Else
                    a += 1
                End If
            Loop
            For a = 0 To .Count - 1
                .Item(a).Text = .Item(a).Text.Trim
            Next
        End With
    End Sub

    Public Sub SaveTaskList()
        tFM.WriteTaskListInArray(Me)
    End Sub

#Region "Search"
    Private m_sSearchTerm As String

    Public Function Search(ByVal sStringToFind As String) As Task
        m_sSearchTerm = sStringToFind
        Dim t As Task = Me.TaskListList.Find(AddressOf FindString)
        Return t
    End Function

    Private Function FindString(ByVal t As Task) As Boolean
        If t.Text.Contains(m_sSearchTerm) Then Return True
        Return False
    End Function
#End Region


End Class
