'ToDo:
'4/26/10
'		Need 'canceled' variable in CRUD operations so mListDirty isn't set every time.
' **RESOLVED 4/27/10 - Added variable where necessary. ** 
'
'		Enable multiple/block deletes.
' **RESOLVED 4/27/10 - Multiple deletes are available.** 
'
'		Multiple moves (left/right).
' **RESOLVED 4/27/10 - Multiple moves (left/right) are available.** 
'
'		lstVu won't re-select after edit?  Selection is working (selection count is 1) but row isn't highlighted.
' **RESOLVED 4/27/10 - lstVu needed to be re-focused. ** 
'
'		What to do about completed items?
' **RESOLVED 4/27/10 - Completed items are displayed with Grey forecolor. **
'
'		pics/icons on buttons on pnlActions
' **RESOLVED 4/27/10 **
'
'		Batch completions?
' **RESOLVED 4/28/10 ** 
'
'Settings:
' ** DONE 4/28 ** Use grid lines
' ** DONE 4/28 ** Date/time formats
' STILL NO SETTINGS FORM !!!!!!!!!! <<<<<<<<<
'
'
' Colors?
'  4/28/10 - Added task forecolor setting on formTaskDetails.
'		   - Added list backcolor setting.
' STILL NO SETTINGS FORM !!!!!!!!!! <<<<<<<<<
'
' Fonts?
'  4/28 - Don't think so as messing with line height would throw off action panel alignment.
'  5/1 -  Tentatively have action panel disabled.  Hate to do away with it but with indentation being set on task creation and all 
'			action panel function available on context menu it might not be necessary.
'		  So if I decide to leave it disabled font settings would be ok.
' **RESOLVED 5/5/10 - Full task font support is finished.  See formTaskDetails.  Action panel is deleted and column header labels are fully operational.
'
' 4/28
'  Added full column show/hide and custom width persistence.
'  Added form size and location persistence.
' STILL NO SETTINGS FORM !!!!!!!!!! <<<<<<<<<
'
'		'Snooze' button on formTaskIsDue?
' **RESOLVED 5/1/10 - Added snooze capability.  Only changes DueDate in AlertManager.  The task object on disk (or in memory
'						in TaskFileManager) is not changed.  Since AlertManager is only instantiated once this should not be a problem.
' When saving a tasklist the instantiation of a new AlertManager will wipe out all snoozed tasks.
' Probably should not say 'snooze' but 'reset due date to ...' and change the due date of that task.
' **RESOLVED 5/1/10 - AlertManager and TaskFileManager interaction is already changeing due date in TFM when changed in AM.  No further action necessary.
'
'		Marking complete doesn't reselect item?
' **RESOLVED 5/1/10 - Added re-select capability.  Also wrote 'Mark Complete' menu configuration depending on .Completed property of selected item(s). **
'
'		How about a color for task text on creation?  It'd be useful and a way to fill the lower left form corner (which is too empty right now).
' **RESOLVED 5/1/10 - Added controls on formTaskDetails to set .TextColor for new tasks (color setting  
'						plus 'same as item above' option), and also when editing existing tasks. **
'
'		Define menu shortcuts and accelerator keys.
' **RESOLVED 5/1/10 **
'
'		Column reordering?
' **RESOLVED 5/1/10 - Was amazingly simple.  Took 5 minutes.  ListView AllowColReorder took care of everything.  Also created Settings so column order is persistent. **
'
'
' Multiple selection operations:
'	Change color & font.
' **RESOLVED 5/11/10 - Added formEditMultiple which will edit font & color on all selected tasks. **
'
'/|\ /|\ /|\ /|\ /|\ /|\ /|\ /|\  DONE /|\ /|\ /|\ /|\ /|\ /|\ /|\ /|\ 
'
'\|/ \|/ \|/ \|/ \|/ \|/ \|/ \|/  PENDING \|/ \|/ \|/ \|/ \|/ \|/ \|/ \|/ 
'
'
' SETTINGS
'  Tray icon - use, minimize to, popup alert from (if/when tray icon is added), show in taskbar when minimized
'  Time format.
'  Display completed items?  For how long?  How many?
'
' Tray icon?  See settings (above).
'  5/1/10: Have tray icon.  Only re-opens window right now but at least allows hiding from taskbar.
'
' Alerts.
'	5/1/10: Alert system works re: scanning for due date and raising alarm.
'			THERE IS STILL NO SOUND OR EMAIL CONFIGURATION !!
'
' ConfigureMenusAndActionsPanel needs work.  Looks like huge redundancy.
'
' A treeview would be nice, instead of listview, so one could collapse parent tasks and save space.
'  How to display task details?  
'  Can have columns in a tree view?  
'  Need to have things lined up, like due date, even if on different nodes.
' BETTER IDEA BELOW ...
' Alternately, can I hide (virtually 'collapse' sections) lstVu lines?
'  Maybe remove lines from display and put '+' box in that line, or something like that?
'  This might be a good way to display info about the collapsed section, like item count, etc.
'
' Change lstVu width when scrollbar not displayed.  Make full form width instead of having ~10px. area to right.
'
'
' Try..Catch EVERWHERE !!!  NO UNHANDLED ERRORS !!!!!!!!!!!
' Also put code in catch blocks as necessary !!!!!!
'	Form1 				done 5/1/10
'	formTaskDetails
'	formTaskIsDue
'	TaskList
'	TaskFileManager
'	Task
'	AlertManager
'
'
'Buglist:
'5/2/10
'
'
'
''' <summary><para>Created on 4/20/10 by Jason S. Rushing</para></summary>
''' <remarks>ToDo list.</remarks>
''' 
Public Class Form1
    Private mCurrentTaskList As clsTaskList
    Private mCurrentListTopIndex As Integer

    Private mListDirty As Boolean = False
    Private tList As New clsTaskList
    Private tListForSort As clsTaskList
    Private mLastSelectedIndex As Integer
    Private mFormActivated As Boolean

    Private mAlertMgr As New AlertManager()
    Private tFM As New clsTaskFileManager
    Private lVM As New clsListViewManager
    Private mM As clsMenuManager
    Private lvWheelMgr As clsListViewWheelManager

    Private mTitleText As String = My.Application.Info.ProductName
    Private mLastWindowState As FormWindowState
    Private lvwColumnSorter As clsListViewColumnSorter
    Private mTaskListForSortHasBeenCreated As Boolean
    Public LstVuDefaultFont As Font = New Font("MS Sans Serif", 8.25)

    Public ReadOnly Property CurrentTaskList() As clsTaskList
        Get
            Return mCurrentTaskList
        End Get
    End Property

    Public ReadOnly Property CurrentListTopIndex() As Integer
        Get
            Return mCurrentListTopIndex
        End Get
    End Property

    Private Sub AddTask(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
       mnuMainAddAbove.Click, mnuMainAddBelow.Click, mnuAddAbove.Click, mnuAddBelow.Click
        Try
            If lstVu.Items.Count = 0 Then                                                                   'Items.Count = 0 means this is a new task list. 

                If Me.cbxTaskLists.Text = "" Then                                                               ' If no name is in the (empty item) of the dropdown, 
                    MessageBox.Show("Please type a name for the new task list in " & _
                    "the 'Task lists' dropdown.", My.Application.Info.ProductName, MessageBoxButtons.OK)        '  prompt user and exit.
                    Exit Sub
                Else
                    mCurrentTaskList = New clsTaskList(lstVu, Me.tFM)                                           'Create a new tasklist.
                    mCurrentTaskList.AddTask(Me.cbxTaskLists.Text, 0)                                           'Use the .AddTask method to construct and add a task.

                    If mCurrentTaskList.OperationCanceled Then                                                  ' Must handle canceled task addition and enforce min. 1 task policy.

                        Do Until Not mCurrentTaskList.OperationCanceled

                            MessageBox.Show("You must add at least one task to create a new tasklist.  " &
                                                           "Would you like to try again?", "Must Add One Task", _
                                                           MessageBoxButtons.YesNo)

                            If DialogResult = DialogResult.Yes Then
                                mCurrentTaskList.AddTask(cbxTaskLists.Text, 0)
                            Else
                                cbxTaskLists.Text = ""
                                Exit Sub
                            End If

                        Loop

                    End If

                    lstVu.Items(0).Selected = True
                    mCurrentTaskList.DisplayTaskList()                                                          'Configure the UI.
                    mListDirty = True
                    mnuConfiguration_ConfigureMenus()
                    Exit Sub

                End If

            End If

            With mCurrentTaskList
                Dim newIndex As Integer = 0

                If lstVu.SelectedItems.Count <> 0 Then _
                  newIndex = lstVu.SelectedItems(0).Index '													'Get the index for the new task,

                Dim mnu As ToolStripMenuItem = sender

                If mnu.Tag = "below" Then newIndex += 1 '														' decide if adding above or below,

                .AddTask(Me.cbxTaskLists.Text, newIndex)                                                        ' and add the task.

                If Not .OperationCanceled Then
                    mListDirty = True
                    mnuConfiguration_ConfigureMenus()
                End If

                If lstVu.SelectedItems.Count <> 0 Then
                    mLastSelectedIndex = lstVu.SelectedItems(0).Index
                    lstVu.Items(mLastSelectedIndex).Selected = False
                    Me.tmrLstVuSelection.Enabled = True
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message & " in Form1.AddTask")
        End Try
    End Sub

    Private Sub DeleteTasks(Optional ByVal ShowPrompt As Boolean = True)
        Try
            With mCurrentTaskList
                .DeleteTasks(GetAllSelectedIndicies, ShowPrompt)
                If Not .OperationCanceled Then _
                 mListDirty = True _
                : mnuConfiguration_ConfigureMenus()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DeleteTasks_MenuClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteSelectedTask.Click
        DeleteTasks()
    End Sub

    Private Sub DeleteTasks_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DeleteTasks()
    End Sub

    Private Sub EditTask()
        Try
            With mCurrentTaskList
                .EditTask(lstVu.SelectedItems(0).Index)
                If Not .OperationCanceled Then
                    mListDirty = True
                    mnuConfiguration_ConfigureMenus()
                End If
                mLastSelectedIndex = lstVu.SelectedItems(0).Index
                lstVu.Items(mLastSelectedIndex).Selected = False
                Me.tmrLstVuSelection.Enabled = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditTask_MenuClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If lstVu.SelectedIndices.Count = 1 Then
            EditTask()
        Else
            With formEditMultiple
                .Tasks = Me.mCurrentTaskList
                .SelectedTasks = GetAllSelectedTasks()
                .ShowDialog()
                If Not .Canceled Then
                    CurrentTaskList.DisplayTaskList()
                    mListDirty = True
                End If
                .Dispose()
                mnuConfiguration_ConfigureMenus()
            End With
        End If
    End Sub

    Private Sub EditTask_ListDblClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstVu.MouseDoubleClick
        EditTask()
    End Sub

    Private Sub MoveTasks_LeftRight(Optional ByVal AddIndent As Boolean = False)
        Try
            With mCurrentTaskList
                .MoveTasks_LeftRight(GetAllSelectedIndicies, AddIndent)
                If Not .OperationCanceled Then _
                 mListDirty = True _
                  : mnuConfiguration_ConfigureMenus()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MoveTasks_LeftRight_MenuClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
      mnuMoveIncreaseIndent.Click, mnuMoveDecreaseIndent.Click
        Dim btn As ToolStripMenuItem = sender
        If btn.Tag = "r" Then _
         MoveTasks_LeftRight(True) Else _
         MoveTasks_LeftRight()
    End Sub

    Private Sub MoveTasks_LeftRight_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As Button = sender
        If btn.Tag = "r" Then _
         MoveTasks_LeftRight(True) Else _
         MoveTasks_LeftRight()
    End Sub

    Private Sub MoveTasks_UpDown(Optional ByVal MoveUp As Boolean = False)
        Try
            With mCurrentTaskList
                lstVu.Focus()

                If (MoveUp And lstVu.SelectedItems(0).Index = 0) Or _
                  (Not MoveUp And lstVu.SelectedItems(lstVu.SelectedIndices.Count - 1).Index = _
                 lstVu.Items.Count - 1) Then Exit Sub

                .MoveTask_UpDown(Me.GetAllSelectedIndicies, MoveUp)
                If Not .OperationCanceled Then
                    mListDirty = True
                    mnuConfiguration_ConfigureMenus()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MoveTasks_UpDown_MenuClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoveUp.Click, mnuMoveDown.Click
        Dim btn As ToolStripMenuItem = sender
        If btn.Tag = "up" Then _
         MoveTasks_UpDown(True) Else _
         MoveTasks_UpDown()
    End Sub

    Private Sub MoveTasks_UpDown_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As Button = sender
        If btn.Tag = "up" Then _
         MoveTasks_UpDown(True) Else _
         MoveTasks_UpDown()
    End Sub

    Private Sub CheckForAlerts_Timed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckAlerts.Tick
        'See Form1_KeyboardInput for manual check.
        Try
            Me.tmrCheckAlerts.Interval = 30000
            If Not formTaskIsDue.Visible Then
                With mAlertMgr
                    .CurrentlyDisplayedTasklist = Me.cbxTaskLists.Text
                    .CheckForAlerts()
                    If .DisplayedTaskModified Then
                        Dim i As Integer = -1
                        If lstVu.SelectedItems.Count = 1 Then i = lstVu.SelectedItems(0).Index
                        GetAllTasksInSelectedTasklist(Me, System.EventArgs.Empty)
                        If i <> -1 Then lstVu.Items(i).Selected = True
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            If mFormActivated Then Exit Sub Else mFormActivated = True
            Me.tmrCheckAlerts.Interval = 30000
            Me.tmrCheckAlerts.Enabled = My.Settings.AlertsOn
            SetTitleText()
            Me.Width = Me.Width + 1
            If Me.cbxTaskLists.Text = "" Then Me.cbxTaskLists.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'Note : There is no user setting for this as of 5/24/10.
            If My.Settings.PromptToClose And e.CloseReason <> CloseReason.WindowsShutDown Then
                If MessageBox.Show("Do you want to close CRS?", My.Application.Info.ProductName, _
                  MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    e.Cancel = True
                    Exit Sub
                End If
            End If
            If mListDirty Then
                Dim m As Windows.Forms.DialogResult = MessageBox.Show("Do you want to save the changes to this task list?", "Save Changes ?", _
                  MessageBoxButtons.YesNoCancel)
                If m = Windows.Forms.DialogResult.Yes Then
                    mnu_SaveTaskList(Me, System.EventArgs.Empty)
                ElseIf m = Windows.Forms.DialogResult.Cancel Then
                    e.Cancel = True
                    Exit Sub
                End If
            End If
            For a As Integer = 0 To lstVu.Columns.Count - 1
                modUtil.WriteColumnSettings(a, lstVu.Columns(a).Width)
            Next
            My.Settings.StartupSize = Me.Size
            My.Settings.StartupLocation = Me.Location
            My.Settings.LastTasklist = Me.cbxTaskLists.Text
            My.Settings.ShowGrid = lstVu.GridLines
            My.Settings.Backcolor = lstVu.BackColor
            My.Settings.AlertsOn = Me.tmrCheckAlerts.Enabled
            My.Settings.Col0_DisplayIndex = lstVu.Columns(0).DisplayIndex
            My.Settings.Col1_DisplayIndex = lstVu.Columns(1).DisplayIndex
            My.Settings.Col2_DisplayIndex = lstVu.Columns(2).DisplayIndex
            My.Settings.Col3_DisplayIndex = lstVu.Columns(3).DisplayIndex
            My.Settings.Col4_DisplayIndex = lstVu.Columns(4).DisplayIndex
            My.Settings.Col5_DisplayIndex = lstVu.Columns(5).DisplayIndex
            If Not tFM.WriteAllTasksToDisk Then MessageBox.Show("Task list was not written to disk.")
            Me.trayIcon.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_KeyboardInput(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Dim indx As Integer = 0

            If lstVu.SelectedItems.Count <> 0 Then _
               indx = lstVu.SelectedItems(0).Index

            If e.Alt And e.Control And e.KeyCode = Keys.A Then _
              CheckForAlerts_Timed(Me, System.EventArgs.Empty)

            If indx <> 0 Then
                If e.KeyCode = Keys.Right Then MoveTasks_LeftRight(True)
                If e.KeyCode = Keys.Left Then MoveTasks_LeftRight()

                If e.KeyCode = Keys.Up Then
                    If e.Control Then MoveTasks_UpDown(True) Else lstVu.SelectedIndices.Clear() : lstVu.Items(indx - 1).Selected = True
                End If
                If e.KeyCode = Keys.Down Then
                    If e.Control Then MoveTasks_UpDown() Else lstVu.SelectedIndices.Clear() : lstVu.Items(indx + 1).Selected = True
                End If
                If e.KeyCode = Keys.Delete Then DeleteTasks()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lvwColumnSorter = New clsListViewColumnSorter()
            Me.lstVu.ListViewItemSorter = lvwColumnSorter
            Me.Icon = My.Resources.MainIcon
            Me.trayIcon.Icon = Me.Icon
            lstVu.Width = Me.Width - 7
            lstVu.Height = Me.Height - statBar.Height - 57

            tList = New clsTaskList(Me.lstVu, Me.tFM)
            mCurrentTaskList = tList

            mAlertMgr = New AlertManager(tFM)
            mM = New clsMenuManager(lstVu, Me.cbxTaskLists, tFM)
            lvWheelMgr = New clsListViewWheelManager(Me.lstVu)

            mCurrentTaskList.GetTaskListNamesAndFillControl(Me.cbxTaskLists)
            mnuConfiguration_ConfigureMenus()

            If Application.ExecutablePath.ToLower.Contains("debug") Then Me.Text = Me.Text & " (Debug)"
            If Application.ExecutablePath.ToLower.Contains("release") Then Me.Text = Me.Text & " (Release)"

            lstVu.Columns(0).DisplayIndex = My.Settings.Col0_DisplayIndex
            lstVu.Columns(1).DisplayIndex = My.Settings.Col1_DisplayIndex
            lstVu.Columns(2).DisplayIndex = My.Settings.Col2_DisplayIndex
            lstVu.Columns(3).DisplayIndex = My.Settings.Col3_DisplayIndex
            lstVu.Columns(4).DisplayIndex = My.Settings.Col4_DisplayIndex
            lstVu.Columns(5).DisplayIndex = My.Settings.Col5_DisplayIndex

            Dim tL As New List(Of Label)
            tL.Add(Me.lblCol0)
            tL.Add(Me.lblCol1)
            tL.Add(Me.lblCol2)
            tL.Add(Me.lblCol3)
            tL.Add(Me.lblCol4)
            tL.Add(Me.lblCol5)
            lVM.HeaderLabelCollection = tL

            formChooseColumns.SetChkBxText()
            lstVu_ColumnManagement_ShowHideLstVuColumns()

            lstVu.GridLines = My.Settings.ShowGrid

            If My.Settings.ShowGrid Then _
             Me.toolShowGrid.Text = "hide grid" Else _
             Me.toolShowGrid.Text = "show grid"

            Me.Location = My.Settings.StartupLocation
            Me.Size = My.Settings.StartupSize

            With Me.cbxTaskLists
                For a As Integer = 1 To .Items.Count - 1
                    If .Items(a) = My.Settings.LastTasklist Then
                        .Text = My.Settings.LastTasklist
                        Exit For
                    End If
                Next
            End With

            Me.lstVu.BackColor = My.Settings.Backcolor
            Me.cbxTaskLists.BackColor = lstVu.BackColor
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        lvWheelMgr.RespondToWheel(e.Delta)
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.ShowInTaskbar = False
                Me.trayIcon.Visible = True
            Else
                Me.ShowInTaskbar = True
                Me.trayIcon.Visible = False
                If mFormActivated Then lstVu_ColumnManagement_ShowHideLstVuColumns()
                Me.mLastWindowState = Me.WindowState
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbxTaskLists_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbxTaskLists.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbxTaskLists.Text = "" Then
                MessageBox.Show("Please enter a new tasklist name in the dropdown, then press 'Enter'.")
            Else
                AddTask(Nothing, Nothing)
            End If
        End If

    End Sub

    Private Sub GetAllTasksInSelectedTasklist(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTaskLists.SelectedIndexChanged
        Try
            Static lastIndex As Integer
            Static autoSaving As Boolean
            Static curIndex As Integer
            If autoSaving Then
                autoSaving = False
                Exit Sub
            End If
            mTaskListForSortHasBeenCreated = False
            lvwColumnSorter.SortColumn = 0
            lvwColumnSorter.Order = SortOrder.None
            toolResetFromSort.Visible = False
            If mListDirty Then
                Dim answer As Windows.Forms.DialogResult = _
                MessageBox.Show("Do you want to save the changes to this task list?", "Save Changes ?", _
                  MessageBoxButtons.YesNoCancel)
                If answer = Windows.Forms.DialogResult.Yes Then
                    curIndex = Me.cbxTaskLists.SelectedIndex
                    autoSaving = True
                    Me.cbxTaskLists.SelectedIndex = lastIndex
                    mnu_SaveTaskList(Me, System.EventArgs.Empty)
                    Me.cbxTaskLists.SelectedIndex = curIndex
                ElseIf answer = Windows.Forms.DialogResult.Cancel Then
                    autoSaving = True
                    Me.cbxTaskLists.SelectedIndex = lastIndex
                    Exit Sub
                End If
            End If
            mCurrentTaskList.GetTaskListByName(Me.cbxTaskLists.Text)
            mListDirty = False
            lastIndex = cbxTaskLists.SelectedIndex
            mnuConfiguration_ConfigureMenus()
            mCurrentTaskList = tList
            If Me.cbxTaskLists.Text = "" Then Me.cbxTaskLists.Focus()
            If Me.cbxTaskLists.Text <> "" Then lstVu.EnsureVisible(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function GetAllSelectedIndicies() As ArrayList
        Dim al As New ArrayList
        For a As Integer = 0 To lstVu.SelectedIndices.Count - 1
            al.Add(lstVu.SelectedItems(a).Index)
        Next
        Return al
    End Function

    Public Function GetAllSelectedTasks() As List(Of Task)
        Try
            Dim lT As New List(Of Task)
            Dim al As ArrayList = GetAllSelectedIndicies()
            For a As Integer = 0 To al.Count - 1
                lT.Add(mCurrentTaskList.TaskListList.Item(al.Item(a)))
            Next
            Return lT
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub GetListVuDisplayIndicies()
        mCurrentListTopIndex = lvWheelMgr.GetVisibleCounts(0) + lvWheelMgr.GetVisibleCounts(1)
        If mCurrentListTopIndex < 0 Then mCurrentListTopIndex = 0
        If mCurrentListTopIndex >= lstVu.Items.Count Then mCurrentListTopIndex = lstVu.Items.Count - 1
    End Sub

    Private Sub lstVu_ColumnReordered(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnReorderedEventArgs) Handles lstVu.ColumnReordered
        Me.tmrTriggerColumnLabelReorder.Enabled = True
    End Sub

    Private Sub lstVu_ColumnReordered_TriggerColumnLabelReorder(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTriggerColumnLabelReorder.Tick
        Me.tmrTriggerColumnLabelReorder.Enabled = False
        lVM.RepositionHeaderLabels()
    End Sub

    Private Sub lstVu_ColumnManagement_RepositionLstVuColumns()
        Try
            lVM.RepositionColumns()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lstVu_ColumnManagement_ShowHideLstVuColumns()
        Try
            lVM.ColumnsWidthsAreSet = False
            lVM.ShowHideColumns()
            lVM.ColumnWidthChanged()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lstVu_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles lstVu.ColumnWidthChanged
        Try
            If lVM.ListView Is Nothing Then lVM = New clsListViewManager(lstVu)
            If mFormActivated And Not lVM.ColumnsWidthsAreSet Then lVM.ColumnWidthChanged()
            Me.tmrTriggerColumnLabelReorder.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If lVM.ListView Is Nothing Then lVM = New clsListViewManager(lstVu)
    End Sub

    Private Sub lstVu_MouseDown_RightClickHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstVu.MouseDown
        If e.X < 50 AndAlso lstVu.SelectedItems.Count = 1 Then tmrDeselector.Enabled = True
        If e.Button = Windows.Forms.MouseButtons.Right Then
            mnuConfiguration_ConfigureMenus()
        Else
            Exit Sub
        End If
        Try
            lVM.ConfigureItemCompleteMenu(mCurrentTaskList, Me.mnuComplete, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lstVu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstVu.GotFocus
        txtDummy.Focus()
    End Sub

    Private Sub lstVu_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVu.SelectedIndexChanged
        mnuConfiguration_ConfigureMenus()
    End Sub

    Private Sub mnu_Alerts_OnOff(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAlerts.Click
        Try
            If Me.mnuAlerts.Text.ToLower.Contains("off") Then _
              Me.tmrCheckAlerts.Enabled = False Else _
              Me.tmrCheckAlerts.Enabled = True
            SetTitleText()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBackup.Click
        mM.BackupTaskLists()
    End Sub

    Private Sub mnuConfiguration_ConfigureMenus()
        mM.ConfigureMenus(mListDirty)
    End Sub

    Private Sub mnuDeletePreviousBackups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeletePreviousBackups.Click
        If MessageBox.Show("Do you want to delete all tasklist backups?", _
          My.Application.Info.ProductName, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub
        Dim s As String = ""
        Dim rslt As Integer = mM.DeleteAllBackups
        If rslt = -1 Then
            s = "An error occurred."
        Else
            If rslt = 1 Then _
              s = rslt & " backup was " Else _
              s = rslt & " backups were "
            s &= "deleted."
        End If
        MessageBox.Show(s, My.Application.Info.ProductName, MessageBoxButtons.OK)
    End Sub

    Private Sub mnuDeletePreviousAndBackupAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeletePreviousAndBackupAll.Click
        mnuDeletePreviousBackups_Click(Me, System.EventArgs.Empty)
        mnuBackup_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub mnu_DeleteTaskList(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainDelete.Click, mnuDeleteThisTasklist.Click
        mListDirty = Not mM.DeleteTaskList(mCurrentTaskList)
    End Sub

    Private Sub mnu_MarkTaskComplete(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuComplete.Click
        GetListVuDisplayIndicies()
        mListDirty = mM.MarkTasksComplete(Me.mCurrentTaskList)
    End Sub

    Private Sub mnuMore_ConfigureMnuAlertsText(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMore.Click
        mM.ConfigureMnuAlertsText()
    End Sub

    Private Sub mnuMoveToTasklist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoveToTasklist.Click
        mM.MoveToTasklist()
    End Sub

    Private Sub mnu_RenameTaskList(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRename.Click
        mM.RenameTaskList()
    End Sub

    Private Sub mnu_SaveAllTasks(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveToDisk.Click
        Try
            If mListDirty Then
                Dim m As Windows.Forms.DialogResult = MessageBox.Show("Do you want to save the changes to this task list?", "Save Changes ?", _
                  MessageBoxButtons.YesNoCancel)
                If m = Windows.Forms.DialogResult.Yes Then
                    mnu_SaveTaskList(Me, System.EventArgs.Empty)
                ElseIf m = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                End If
            End If
            mListDirty = Not mM.SaveAllTasks(mListDirty, Me.mCurrentTaskList)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnu_SaveTaskList(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainSave.Click
        If mM.SaveTaskList(Me.CurrentTaskList) Then mAlertMgr = New AlertManager(tFM) : mListDirty = False
    End Sub

    Private Sub mnu_SaveTasklistAs(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveAs.Click
        If mM.SaveTaskListAs(Me.mCurrentTaskList) Then
            mAlertMgr = New AlertManager(Me.tFM)
            mListDirty = False
        End If
    End Sub

    Private Sub mnuSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSettings.Click
        formSettings.ShowDialog()
    End Sub

    Private Sub SetTitleText()
        Try
            If Application.ExecutablePath.ToLower.Contains("debug") Then Me.Text = mTitleText & " (Debug)"
            If Application.ExecutablePath.ToLower.Contains("release") Then Me.Text = mTitleText & " (Release)"
            If Me.tmrCheckAlerts.Enabled Then _
              Me.Text = Me.Text & " - Alerts ON" Else _
              Me.Text = Me.Text & " - Alerts OFF"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function SortFunctions_CreateOneTaskFromDisplay(ByVal DisplayIndex As Integer) As Task
        Dim t As New Task
        'Dim lstMaster As List(Of Task) = tFM.AllTasksInSystem
        With tListForSort
            For b As Integer = 0 To .TaskListList.Count - 1
                'Debug.Print(lstVu.Items(DisplayIndex).SubItems(2).Text)
                'Debug.Print(.TaskListList.Item(b).Text)
                If .TaskListList.Item(b).Text = lstVu.Items(DisplayIndex).SubItems(2).Text And _
                  Format(.TaskListList.Item(b).CreatedOnDate, "MM/dd/yy HH:mm") = lstVu.Items(DisplayIndex).SubItems(4).Text Then
                    Return .TaskListList.Item(b)
                End If
            Next
            Return Nothing
        End With
    End Function

    Private Function SortFunctions_CreateTaskListFromDisplay() As clsTaskList
        Dim tL As New clsTaskList(lstVu, tFM)
        Dim t As Task
        For a As Integer = 0 To lstVu.Items.Count - 1
            t = New Task(SortFunctions_CreateOneTaskFromDisplay(a))
            t.TaskList = Me.cbxTaskLists.Text
            tL.TaskListList.Add(t)
        Next
        Return tL
    End Function

    Private Sub SortFunctions_lstVu_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstVu.ColumnClick
        If Not mTaskListForSortHasBeenCreated Then
            mTaskListForSortHasBeenCreated = True
            tListForSort = New clsTaskList(lstVu, tFM)
            Dim t As Task
            For a As Integer = 0 To tList.TaskListList.Count - 1
                t = New Task(tList.TaskListList.Item(a))
                tListForSort.TaskListList.Add(t)
            Next
            tListForSort.RemoveBlanksAndIndents()
            tListForSort.DisplayTaskList()
        End If
        ' Determine if the clicked column is already the column that is 
        ' being sorted.
        If (e.Column = lvwColumnSorter.SortColumn) Then
            ' Reverse the current sort direction for this column.
            If (lvwColumnSorter.Order = SortOrder.Ascending) Then
                lvwColumnSorter.Order = SortOrder.Descending
            Else
                lvwColumnSorter.Order = SortOrder.Ascending
            End If
        Else
            ' Set the column number that is to be sorted; default to ascending.
            lvwColumnSorter.SortColumn = e.Column
            lvwColumnSorter.Order = SortOrder.Ascending
        End If

        ' Perform the sort with these new sort options.
        Me.lstVu.Sort()
        mCurrentTaskList = New clsTaskList(lstVu, tFM)
        mCurrentTaskList = SortFunctions_CreateTaskListFromDisplay()
        mCurrentTaskList.TaskListName = Me.cbxTaskLists.Text
        Me.toolResetFromSort.Visible = True
        mListDirty = True
        mnuConfiguration_ConfigureMenus()
    End Sub

    Private Sub StatBar_MouseEntersLabel(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
      toolShowGrid.MouseEnter, toolSetBackcolor.MouseEnter, toolShowHideColumns.MouseEnter, toolResetFromSort.MouseEnter
        Try
            Dim tl As ToolStripLabel = sender
            tl.ForeColor = Color.Red
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StatBar_MouseLeavesLabel(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
    toolShowGrid.MouseLeave, toolSetBackcolor.MouseLeave, toolShowHideColumns.MouseLeave, toolResetFromSort.MouseLeave
        Try
            Dim tl As ToolStripLabel = sender
            tl.ForeColor = Color.Black
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StatBarLabel_ResetFromSort(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolResetFromSort.Click
        tListForSort = Nothing
        Dim s As String = tList.TaskListName
        mListDirty = False
        If Me.cbxTaskLists.Text.Equals(s) Then Me.cbxTaskLists.SelectedIndex = 0
        Me.cbxTaskLists.SelectedIndex = Me.cbxTaskLists.FindString(s)
        StatBar_MouseLeavesLabel(sender, System.EventArgs.Empty)
    End Sub

    Private Sub StatBarLabel_SetBackcolor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolSetBackcolor.Click
        Try
            Static CustomColors() As Integer = {RGB(lstVu.BackColor.R, lstVu.BackColor.G, lstVu.BackColor.B)}
            Dim CustomColors2() As Integer = {RGB(lstVu.BackColor.R, lstVu.BackColor.G, lstVu.BackColor.B)}
            clr.Reset()
            clr.Color = lstVu.BackColor
            'CustomColors = CustomColors2
            clr.CustomColors = CustomColors
            clr.FullOpen = True
            If clr.ShowDialog() = Windows.Forms.DialogResult.OK Then
                lstVu.BackColor = clr.Color
                Me.cbxTaskLists.BackColor = clr.Color
                CustomColors = clr.CustomColors
            End If
            Me.cbxTaskLists.Focus()
            txtDummy.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StatBarLabel_ShowHideGrid(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolShowGrid.Click
        Try
            Dim s As String = "grid"
            With toolShowGrid
                If .Text = "show " & s Then
                    lstVu.GridLines = True
                    .Text = "hide " & s
                Else
                    lstVu.GridLines = False
                    .Text = "show " & s
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StatBarLabel_ShowHideColumns(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolShowHideColumns.Click
        Try
            With formChooseColumns
                .Location = New Point(Me.Left + 250, Me.Top + Me.Height - statBar.Height - .Height + 10)
                .ShowDialog()

                If .FormIsDirty Then _
                lstVu_ColumnManagement_ShowHideLstVuColumns() _
                : Me.tmrTriggerColumnLabelReorder.Enabled = True

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tmrDeselectCbxTasks_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDeselectCbx.Tick
        Try
            tmrDeselectCbx.Enabled = False
            Me.cbxTaskLists.Focus()
            txtDummy.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tmrLstVuDeselector_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDeselector.Tick
        Try
            tmrDeselector.Enabled = False
            If lstVu.SelectedItems.Count = 1 Then lstVu.SelectedItems(0).Selected = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tmrLstVuSelection_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLstVuSelection.Tick
        Try
            Me.tmrLstVuSelection.Enabled = False
            If lstVu.SelectedItems.Count = 0 Then _
              lstVu.Items(mLastSelectedIndex).Selected = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuTrayClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrayClose.Click
        Me.WindowState = Me.mLastWindowState
        Me.Close()
    End Sub

    Private Sub trayIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trayIcon.MouseClick
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then Exit Sub
            Me.WindowState = mLastWindowState
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuExportToText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExportToText.Click
        With SaveDlg
            .OverwritePrompt = False
            .Title = "Please provide a file name for the export."
            .ShowDialog()
        End With
        Dim fName As String = SaveDlg.FileName
        If fName.Substring(fName.Length - 4, 4) <> ".txt" Then fName &= ".txt"
        If fName = "" Then Exit Sub
        Dim sUsrMsg As String = "The tasklist was exported successfully to " & fName
        Dim exporter As New clsExportManager(clsExportManager.ExportType.Text, fName, Me.CurrentTaskList)
        If exporter.Result <> "" Then sUsrMsg = exporter.Result
        MessageBox.Show(sUsrMsg)
    End Sub

    Private Sub mnuSearch_ThisTasklist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSearch_ThisTasklist.Click
        Dim sSearchTerm As String = InputBox("Find:")
        If sSearchTerm.Equals(String.Empty) Then Exit Sub
        'Dim t As Task = mCurrentTaskList.Search(sSearchTerm)
        lstVu.SelectedIndices.Clear()
        For i As Int16 = 0 To lstVu.Items.Count - 1
            With lstVu.Items(i)
                If .SubItems.Count > 2 AndAlso .SubItems(2).ToString.Contains(sSearchTerm) Then
                    lstVu.SelectedIndices.Add(i)
                End If
            End With
        Next
    End Sub
End Class