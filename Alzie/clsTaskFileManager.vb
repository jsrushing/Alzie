'5/1/10
' Finished cutover to full use of List(Of Task) for all operations.  This List(Of Task) is also used throughout the program.
' Disk I/O only occurs on program open and close (or as commanded).
'
'ToDo:
'5/1/10
' Could probably speed things up some by using List(Of T) methods (FindAll, etc.), but can't make them work yet :(.
'
'
'Buglist:
' 4/27/10 - Resolved.  Put rdr.close() in several locations, works as expected.
' 4/23/10 - Can't save task list.
'  Trying to save after multiple changes since last save throws error in SwapTmpIniFile() "cannot access file, in use by other process".
'
'
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Imports System.IO
''' <summary><para>Created on 4/20/10 by Jason S. Rushing</para></summary>
''' <remarks>Class.  Manages file I/O for task list persistence.</remarks>
Public Class clsTaskFileManager
    Private IniName As String = ""
    Private mAllTasks As List(Of Task)
    Private useSerial As Boolean = True
    Private mListDirty As Boolean = False

    Public ReadOnly Property AllTasksInSystem() As List(Of Task)
        Get
            Return mAllTasks
        End Get
    End Property

    Public Sub New()
        mAllTasks = New List(Of Task)

        Try
            IniName = Application.ExecutablePath
            IniName = IniName.Substring(0, IniName.LastIndexOf("\") + 1)
            IniName &= "tasks.ini"
        Catch ex As Exception
        End Try

        Try
            If useSerial Then
                mAllTasks = pGetAllTasks_AsBinary()
            Else
                Dim rdr As StreamReader
                Try
                    rdr = File.OpenText(IniName)
                Catch ex As Exception
                    Dim wrtr As StreamWriter
                    wrtr = File.CreateText(IniName)
                    wrtr.Close()
                    rdr = File.OpenText(IniName)
                End Try
                mAllTasks = pGetAllTasks_AsText(rdr)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Function AddTaskToArray(ByVal TaskToAdd As Task) As Boolean
        mAllTasks.Add(TaskToAdd)
        mListDirty = True
    End Function

    Public Function BackupAllTasks() As String
        Try
            Dim taskIn As New Task
            Dim formatter As BinaryFormatter = New BinaryFormatter()
            Dim fName As String = IniName & "_bak_" & Format(Now, "MM-dd-yy_HH.mm.ss")
            Dim output As New FileStream(fName, FileMode.Create, FileAccess.Write)
            Dim t As Task
            With mAllTasks
                For a As Integer = 0 To .Count - 1
                    t = ConfigureForDueDateUsage(.Item(a))
                    formatter.Serialize(output, t)
                Next
            End With
            output.Close()
            Return fName
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function ChangeTasklist(ByVal TasksToChange As List(Of Task), ByVal NewTaskListName As String) As Boolean
        Dim lT As List(Of Task) = TasksToChange
        Dim t As Task
        With mAllTasks
            For a As Integer = 0 To lT.Count - 1
                t = lT.Item(a)
                For b As Integer = 0 To .Count - 1
                    If .Item(b).Equals(lT.Item(a)) Then
                        .Item(b).TaskList = NewTaskListName
                        Exit For
                    End If
                Next
            Next
        End With
        mListDirty = True
    End Function

    Private Function ConfigureForDueDateUsage(ByVal tk As Task) As Task
        With tk
            If Not .UseDueDate Then
                .UseAlert = False
                .AlertBeforeDuration = 0
                .AlertBeforeUnits = 0
                .AlertMethod = 0
            End If
        End With
        Return tk
    End Function

    Public Function DeleteTaskListFromArray(ByVal TaskListToDelete As clsTaskList) As Boolean
        Dim t As Task = Nothing
        Dim a As Integer = 0
        With mAllTasks
            Do Until a = .Count
                t = .Item(a)
                If t.TaskList = TaskListToDelete.TaskListName Then
                    .RemoveAt(a)
                Else
                    a += 1
                End If
            Loop
        End With
        mListDirty = True
    End Function

    Private Function pGetAllTasks_AsText(ByVal rdr As StreamReader) As List(Of Task)
        Dim listTemp As New List(Of Task)
        Dim t As Task
        Dim lineIn As String = ""
        While rdr.Peek <> -1
            lineIn = rdr.ReadLine
            t = New Task(lineIn)
            listTemp.Add(ConfigureForDueDateUsage(t))
        End While
        rdr.Close()
        Return listTemp
    End Function

    Private Function pGetAllTasks_AsBinary() As List(Of Task)
        Dim formatter As BinaryFormatter = New BinaryFormatter()
        Dim input As New FileStream(IniName, FileMode.Open, FileAccess.Read)
        Dim listTemp As New List(Of Task)
        Dim o As Object = Nothing
        Dim taskIn As Task = Nothing
        Do
            o = formatter.Deserialize(input)
            If o.GetType Is GetType(Task) Then
                taskIn = CType(o, Task)
                If taskIn.Text IsNot Nothing Then _
                  listTemp.Add(taskIn)
            End If
        Loop While input.Position < input.Length - 1
        input.Close()
        Return listTemp
    End Function

    Public Function GetTaskListNames() As ArrayList
        Dim al As New ArrayList
        Dim b As Integer
        Try
            Dim lineIn As String = ""
            For a As Integer = 0 To mAllTasks.Count - 1
                For b = 0 To al.Count - 1
                    If al(b) = mAllTasks.Item(a).TaskList Then Exit For
                Next
                If b = al.Count Then al.Add(mAllTasks.Item(a).TaskList)
            Next
        Catch ex As Exception
            Return Nothing
        End Try
        Return al
    End Function

    Public Function GetTaskListByName(ByVal TaskListName As String) As List(Of Task)
        Dim al As New List(Of Task)
        Try
            For a As Integer = 0 To mAllTasks.Count - 1
                If mAllTasks.Item(a).TaskList = TaskListName Then
                    al.Add(mAllTasks.Item(a))
                End If
            Next
            Return al
        Catch ex As Exception
            Return al
        End Try
        Return al
    End Function

    Public Function WriteOneTask(ByVal OldTask As Task, ByVal NewTask As Task) As Boolean
        Try
            Dim t As Task
            With mAllTasks
                For a As Integer = 0 To .Count - 1
                    t = .Item(a)
                    If t.Equals(OldTask) Then
                        .RemoveAt(a)
                        .Insert(a, ConfigureForDueDateUsage(NewTask))
                        Return True
                    End If
                Next
            End With
            mListDirty = True
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function WriteTaskListInArray(ByVal TaskListToWrite As clsTaskList) As Boolean
        Dim t As Task = Nothing
        Dim a As Integer = 0
        With mAllTasks
            Do Until a = .Count
                t = .Item(a)
                If t.TaskList = TaskListToWrite.TaskListName Then
                    .RemoveAt(a)
                Else
                    a += 1
                End If
            Loop
        End With

        If TaskListToWrite.TaskListName Is Nothing Then _
          TaskListToWrite.TaskListName = TaskListToWrite.TaskListList.Item(0).TaskList

        With TaskListToWrite.TaskListList
            For a = 0 To .Count - 1
                t = .Item(a)
                t.TaskList = TaskListToWrite.TaskListName
                mAllTasks.Add(ConfigureForDueDateUsage(t))
            Next
        End With
        mListDirty = True
    End Function

    Public Function WriteAllTasksToDisk() As Boolean
        If Not mListDirty Then Return True
        If useSerial Then
            Dim taskIn As New Task
            Dim formatter As BinaryFormatter = New BinaryFormatter()
            Dim output As New FileStream(IniName, FileMode.Create, FileAccess.Write)
            Dim t As Task
            With mAllTasks
                For a As Integer = 0 To .Count - 1
                    t = ConfigureForDueDateUsage(.Item(a))
                    formatter.Serialize(output, t)
                Next
            End With
            output.Close()
            mListDirty = False
            Return True
        Else
            Dim wrtr As New StreamWriter(IniName, False)
            Dim t As Task
            With mAllTasks
                For a As Integer = 0 To .Count - 1
                    t = ConfigureForDueDateUsage(.Item(a))
                    wrtr.WriteLine(t.Text & t.ItemSplitChar & t.DueDate & t.ItemSplitChar & t.CreatedOnDate & t.ItemSplitChar & _
                      t.Priority & t.ItemSplitChar & t.AlertBeforeDuration & t.ItemSplitChar & t.AlertBeforeUnits & t.ItemSplitChar & t.Completed & _
                     t.ItemSplitChar & t.AlertMethod & t.ItemSplitChar & t.TextColor & t.ItemSplitChar & t.UseDueDate & t.ItemSplitChar & t.UseAlert & _
                     t.ItemSplitChar & t.UsePopup & t.ItemSplitChar & t.TaskList)
                Next
                wrtr.Close()
                Return True
            End With
        End If
        Return False
    End Function

End Class
