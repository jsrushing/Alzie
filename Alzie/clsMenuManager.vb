Option Explicit On
Imports System.IO
''' <summary><para>Created on 5/11/10 by Jason S. Rushing</para></summary>
''' <remarks>All Form1 menu functions.</remarks>
Public Class clsMenuManager
    Private mCbxTaskLists As ComboBox
    Private mListView As ListView
    Private tFM As clsTaskFileManager

    Public Sub New(ByVal ListView As ListView, ByVal TaskListNameCombo As ComboBox, ByVal TaskFileManager As clsTaskFileManager)
        Me.mCbxTaskLists = TaskListNameCombo
        mListView = ListView
        tFM = TaskFileManager
    End Sub

    Public Sub BackupTaskLists()
        Dim fName As String = tFM.BackupAllTasks
        If fName <> "" Then
            MessageBox.Show("Tasks were backed up as " & Chr(34) & fName & Chr(34) & "." & vbCrLf & _
             "If you care to use this backup, rename it to 'tasks.ini' and restart CRS.", My.Application.Info.ProductName, MessageBoxButtons.OK)
        Else
            MessageBox.Show("The backup operation failed.", My.Application.Info.ProductName, MessageBoxButtons.OK)
        End If

    End Sub

    Public Sub ConfigureMenus(ByVal ListDirty As Boolean)
        Try
            Dim state As Integer = 0
            ResetAllMenus()
            'Exit Sub
            If mListView.Items.Count <> 0 Then state = 1
            If mListView.SelectedItems.Count <> 0 Then state = 2
            If mListView.SelectedItems.Count > 1 Then state = 3

            With Form1
                If state > -1 Then          'No items are in list.
                    .mnuMainAddAbove.Enabled = True
                    .mnuAddAbove.Enabled = True
                End If

                If state > 0 Then           'Items are in list but nothing is selected.
                    .mnuMainDelete.Enabled = True
                    .mnuRename.Enabled = True
                    .mnuDelete.Enabled = True
                    .mnuDeleteThisTasklist.Enabled = True
                End If

                If state > 1 Then           'Something is selected.
                    .mnuMainAddAbove.Text = "+ &Above"
                    .mnuAddAbove.Text = "Add &Above"
                    .mnuMainAddBelow.Enabled = True
                    .mnuAddBelow.Enabled = True
                    .mnuDeleteSelectedTask.Enabled = True
                    .mnuEdit.Enabled = True
                    .mnuMove.Enabled = True
                    .mnuMoveUp.Enabled = True
                    .mnuMoveDown.Enabled = True
                    .mnuMoveIncreaseIndent.Enabled = True
                    .mnuMoveDecreaseIndent.Enabled = True
                    .mnuColor.Enabled = True
                    .mnuComplete.Enabled = True
                End If

                If state = 3 Then           'Multiple items are selected.
                    'ResetAllMenus()
                    .mnuMainDelete.Enabled = True
                    .mnuRename.Enabled = True
                    .mnuDelete.Enabled = True
                    .mnuDeleteThisTasklist.Enabled = True
                    .mnuDelete.Enabled = True
                    .mnuDeleteSelectedTask.Enabled = True
                    .mnuDeleteSelectedTask.Text = .mnuDeleteSelectedTask.Text & "s"
                    .mnuDeleteThisTasklist.Enabled = True
                    .mnuMove.Enabled = True
                    '.mnuMove.Text = .mnuMove.Text & "s"
                    .mnuMoveUp.Enabled = True
                    .mnuMoveDown.Enabled = True
                    .mnuMoveIncreaseIndent.Enabled = True
                    .mnuMoveDecreaseIndent.Enabled = True
                    .mnuComplete.Enabled = True
                    'Exit Sub
                End If
                .mnuMainSave.Enabled = ListDirty
                .mnuSaveList.Enabled = ListDirty
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ConfigureMnuAlertsText()
        Try
            With Form1.mnuAlerts
                .Text = "Turn Alerts "
                If Form1.tmrCheckAlerts.Enabled Then
                    .Text = .Text & "OFF"
                Else
                    .Text = .Text & "ON"
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DeleteAllBackups() As Integer
        Try
            Dim counter As Integer = 0
            Dim p As String = Application.ExecutablePath
            p = p.Substring(0, p.LastIndexOf("\") + 1)
            For Each fil As String In Directory.GetFiles(p, "*.*")
                If fil.Contains("tasks.ini_bak") Then
                    File.Delete(fil)
                    counter += 1
                End If
            Next
            Return counter
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function DeleteTaskList(ByVal CurrentTaskList As clsTaskList) As Boolean
        Try
            With CurrentTaskList
                .DeleteTaskList()
                If Not .OperationCanceled Then _
                  ConfigureMenus(False)
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function MarkTasksComplete(ByVal CurrentTaskList As clsTaskList) As Boolean
        Try
            With CurrentTaskList
                Dim b As Boolean
                If Form1.mnuComplete.Text.ToLower.Contains("not") Then b = False Else b = True
                'mLastSelectedIndex = lstVu.SelectedItems(0).Index
                .MarkTasksComplete(Form1.GetAllSelectedIndicies, b)
                'mListDirty = True
                mListView.SelectedIndices.Clear()
                'ConfigureMenus(True)
                'lstVu.Items(mLastSelectedIndex).Selected = False
                'Me.tmrLstVuSelection.Enabled = True
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function MoveToTasklist() As Boolean
        Try
            With mCbxTaskLists
                For a As Integer = 0 To .Items.Count - 1
                    If .Items(a) <> "" And .Items(a) <> .Text Then
                        formNewTasklist.cbxTLs.Items.Add(.Items(a))
                    End If
                Next
            End With
            With formNewTasklist
                .ShowDialog()
                If .cbxTLs.Text <> "" Then
                    tFM.ChangeTasklist(Form1.GetAllSelectedTasks, .cbxTLs.Text)
                    Dim s As String = mCbxTaskLists.Text
                    mCbxTaskLists.Text = ""
                    mCbxTaskLists.Text = s
                End If
                .Dispose()
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function RenameTaskList() As Boolean
        Try
            With Form1.CurrentTaskList
                Dim newName As String = InputBox("What is the new task list name?" & vbCrLf & _
                  "(Please note that this operation will save the current task list.)", My.Application.Info.ProductName, mCbxTaskLists.Text)
                If newName = "" Then Exit Function
                .DeleteTaskList(False)                                        'Delete original.
                .TaskListName = newName
                .SaveTaskList()                                             'Save with new name.
                .GetTaskListNamesAndFillControl(mCbxTaskLists, True)                             'Re-populate task list names.
                mCbxTaskLists.Text = newName                                                    'Select newly named list.
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Private Sub ResetAllMenus()
        Try
            With Form1
                .mnuMainAddAbove.Text = "&Add Task"
                .mnuAddAbove.Text = "&Add Task"
                .mnuDeleteSelectedTask.Text = "Selected &Task"

                .mnuMainAddAbove.Enabled = False
                .mnuMainAddBelow.Enabled = False
                .mnuMainDelete.Enabled = False
                .mnuMainSave.Enabled = False
                .mnuRename.Enabled = False

                .mnuAddAbove.Enabled = False
                .mnuAddBelow.Enabled = False
                .mnuEdit.Enabled = False

                .mnuDelete.Enabled = False
                .mnuDeleteSelectedTask.Enabled = False
                .mnuDeleteThisTasklist.Enabled = False

                .mnuMove.Enabled = False
                '.mnuMove.Text = "&Move Selected Item"
                .mnuMoveUp.Enabled = False
                .mnuMoveDown.Enabled = False
                .mnuMoveIncreaseIndent.Enabled = False
                .mnuMoveDecreaseIndent.Enabled = False

                .mnuColor.Enabled = False
                .mnuComplete.Enabled = False
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function SaveAllTasks(ByVal ListDirty As Boolean, ByVal CurrentTaskList As clsTaskList) As Boolean
        Try
            If Not tFM.WriteAllTasksToDisk Then MessageBox.Show("Task list was not written to disk.") Else Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function SaveTaskList(ByVal CurrentTaskList As clsTaskList) As Boolean
        Try
            With CurrentTaskList
                .SaveTaskList()
                .GetTaskListNamesAndFillControl(mCbxTaskLists)
                ConfigureMenus(False)
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function SaveTaskListAs(ByVal CurrentTaskList As clsTaskList) As Boolean
        Try
            Dim newName As String = InputBox("What is the new task list name?", My.Application.Info.ProductName, mCbxTaskLists.Text)
            If newName = "" Then Exit Function
            Dim t As Task
            With CurrentTaskList
                For a As Integer = 0 To .TaskListList.Count - 1
                    t = New Task(.TaskListList.Item(a))
                    t.TaskList = newName
                    tFM.AddTaskToArray(t)
                Next
                .GetTaskListNamesAndFillControl(mCbxTaskLists)
                ConfigureMenus(False)
                mCbxTaskLists.Text = newName
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
End Class
