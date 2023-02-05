<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mnuPop = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuMove = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveDecreaseIndent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveIncreaseIndent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveToTasklist = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddAbove = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddBelow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuComplete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteSelectedTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteThisTasklist = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbxTaskLists = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMainAddAbove = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainAddBelow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTasklist = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSaveToDisk = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackupTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeletePreviousBackups = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeletePreviousAndBackupAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMainDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportToText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportToWord = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportToExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrinterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAlerts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCRSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.clr = New System.Windows.Forms.ColorDialog()
        Me.lstVu = New System.Windows.Forms.ListView()
        Me.colLineNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPriority = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTaskText = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCreatedOn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNotification = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tmrLstVuSelection = New System.Windows.Forms.Timer(Me.components)
        Me.txtDummy = New System.Windows.Forms.TextBox()
        Me.tmrDeselector = New System.Windows.Forms.Timer(Me.components)
        Me.statBar = New System.Windows.Forms.StatusStrip()
        Me.toolShowGrid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolSetBackcolor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolShowHideColumns = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolResetFromSort = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrDeselectCbx = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCheckAlerts = New System.Windows.Forms.Timer(Me.components)
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnuTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuTrayClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCol0 = New System.Windows.Forms.Label()
        Me.lblCol2 = New System.Windows.Forms.Label()
        Me.lblCol3 = New System.Windows.Forms.Label()
        Me.lblCol4 = New System.Windows.Forms.Label()
        Me.lblCol5 = New System.Windows.Forms.Label()
        Me.tmrTriggerColumnLabelReorder = New System.Windows.Forms.Timer(Me.components)
        Me.lblCol1 = New System.Windows.Forms.Label()
        Me.SaveDlg = New System.Windows.Forms.SaveFileDialog()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch_ThisTasklist = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch_AllTasklists = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPop.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.statBar.SuspendLayout()
        Me.mnuTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPop
        '
        Me.mnuPop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMove, Me.mnuEdit, Me.mnuAddAbove, Me.mnuAddBelow, Me.mnuComplete, Me.mnuSaveList, Me.mnuDelete, Me.mnuColor})
        Me.mnuPop.Name = "mnuPop"
        Me.mnuPop.Size = New System.Drawing.Size(157, 180)
        '
        'mnuMove
        '
        Me.mnuMove.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMoveUp, Me.mnuMoveDown, Me.mnuMoveDecreaseIndent, Me.mnuMoveIncreaseIndent, Me.mnuMoveToTasklist})
        Me.mnuMove.Name = "mnuMove"
        Me.mnuMove.Size = New System.Drawing.Size(156, 22)
        Me.mnuMove.Text = "&Move"
        '
        'mnuMoveUp
        '
        Me.mnuMoveUp.Name = "mnuMoveUp"
        Me.mnuMoveUp.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.mnuMoveUp.Size = New System.Drawing.Size(170, 22)
        Me.mnuMoveUp.Tag = "up"
        Me.mnuMoveUp.Text = "&Up"
        '
        'mnuMoveDown
        '
        Me.mnuMoveDown.Name = "mnuMoveDown"
        Me.mnuMoveDown.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.mnuMoveDown.Size = New System.Drawing.Size(170, 22)
        Me.mnuMoveDown.Text = "&Down"
        '
        'mnuMoveDecreaseIndent
        '
        Me.mnuMoveDecreaseIndent.Name = "mnuMoveDecreaseIndent"
        Me.mnuMoveDecreaseIndent.Size = New System.Drawing.Size(170, 22)
        Me.mnuMoveDecreaseIndent.Text = "&Left"
        '
        'mnuMoveIncreaseIndent
        '
        Me.mnuMoveIncreaseIndent.Name = "mnuMoveIncreaseIndent"
        Me.mnuMoveIncreaseIndent.Size = New System.Drawing.Size(170, 22)
        Me.mnuMoveIncreaseIndent.Tag = "r"
        Me.mnuMoveIncreaseIndent.Text = "&Right"
        '
        'mnuMoveToTasklist
        '
        Me.mnuMoveToTasklist.Name = "mnuMoveToTasklist"
        Me.mnuMoveToTasklist.Size = New System.Drawing.Size(170, 22)
        Me.mnuMoveToTasklist.Text = "To Tasklist ..."
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(156, 22)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuAddAbove
        '
        Me.mnuAddAbove.Name = "mnuAddAbove"
        Me.mnuAddAbove.Size = New System.Drawing.Size(156, 22)
        Me.mnuAddAbove.Text = "Add &Above"
        '
        'mnuAddBelow
        '
        Me.mnuAddBelow.Name = "mnuAddBelow"
        Me.mnuAddBelow.Size = New System.Drawing.Size(156, 22)
        Me.mnuAddBelow.Tag = "below"
        Me.mnuAddBelow.Text = "Add &Below"
        '
        'mnuComplete
        '
        Me.mnuComplete.Name = "mnuComplete"
        Me.mnuComplete.Size = New System.Drawing.Size(156, 22)
        Me.mnuComplete.Text = "Mark &Complete"
        '
        'mnuSaveList
        '
        Me.mnuSaveList.Name = "mnuSaveList"
        Me.mnuSaveList.Size = New System.Drawing.Size(156, 22)
        Me.mnuSaveList.Text = "&Save List"
        '
        'mnuDelete
        '
        Me.mnuDelete.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDeleteSelectedTask, Me.mnuDeleteThisTasklist})
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(156, 22)
        Me.mnuDelete.Text = "&Delete"
        '
        'mnuDeleteSelectedTask
        '
        Me.mnuDeleteSelectedTask.Name = "mnuDeleteSelectedTask"
        Me.mnuDeleteSelectedTask.Size = New System.Drawing.Size(145, 22)
        Me.mnuDeleteSelectedTask.Text = "Selected &Task"
        '
        'mnuDeleteThisTasklist
        '
        Me.mnuDeleteThisTasklist.Name = "mnuDeleteThisTasklist"
        Me.mnuDeleteThisTasklist.Size = New System.Drawing.Size(145, 22)
        Me.mnuDeleteThisTasklist.Text = "This Task&list"
        '
        'mnuColor
        '
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(156, 22)
        Me.mnuColor.Text = "Item &Color"
        Me.mnuColor.Visible = False
        '
        'cbxTaskLists
        '
        Me.cbxTaskLists.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxTaskLists.BackColor = System.Drawing.Color.GhostWhite
        Me.cbxTaskLists.FormattingEnabled = True
        Me.cbxTaskLists.Location = New System.Drawing.Point(387, 2)
        Me.cbxTaskLists.Name = "cbxTaskLists"
        Me.cbxTaskLists.Size = New System.Drawing.Size(678, 21)
        Me.cbxTaskLists.Sorted = True
        Me.cbxTaskLists.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainAddAbove, Me.mnuMainAddBelow, Me.mnuMainSave, Me.mnuMore})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1063, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMainAddAbove
        '
        Me.mnuMainAddAbove.Name = "mnuMainAddAbove"
        Me.mnuMainAddAbove.Size = New System.Drawing.Size(64, 20)
        Me.mnuMainAddAbove.Tag = "above"
        Me.mnuMainAddAbove.Text = "+ Above"
        '
        'mnuMainAddBelow
        '
        Me.mnuMainAddBelow.Name = "mnuMainAddBelow"
        Me.mnuMainAddBelow.Size = New System.Drawing.Size(62, 20)
        Me.mnuMainAddBelow.Tag = "below"
        Me.mnuMainAddBelow.Text = "+ &Below"
        '
        'mnuMainSave
        '
        Me.mnuMainSave.ForeColor = System.Drawing.Color.Red
        Me.mnuMainSave.Name = "mnuMainSave"
        Me.mnuMainSave.Size = New System.Drawing.Size(64, 20)
        Me.mnuMainSave.Text = "&Save List"
        '
        'mnuMore
        '
        Me.mnuMore.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTasklist, Me.mnuSettings, Me.mnuAlerts, Me.mnuHelp, Me.SearchToolStripMenuItem})
        Me.mnuMore.Name = "mnuMore"
        Me.mnuMore.Size = New System.Drawing.Size(59, 20)
        Me.mnuMore.Text = "&More ..."
        '
        'mnuTasklist
        '
        Me.mnuTasklist.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRename, Me.mnuSaveAs, Me.ToolStripSeparator1, Me.mnuSaveToDisk, Me.mnuBackupTop, Me.ToolStripSeparator2, Me.mnuMainDelete, Me.ExportToToolStripMenuItem})
        Me.mnuTasklist.Name = "mnuTasklist"
        Me.mnuTasklist.Size = New System.Drawing.Size(156, 22)
        Me.mnuTasklist.Text = "&Tasklist(s) ..."
        '
        'mnuRename
        '
        Me.mnuRename.Name = "mnuRename"
        Me.mnuRename.Size = New System.Drawing.Size(211, 22)
        Me.mnuRename.Text = "&Rename Current Tasklist"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(211, 22)
        Me.mnuSaveAs.Text = "Save Current Tasklist &As ..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(208, 6)
        '
        'mnuSaveToDisk
        '
        Me.mnuSaveToDisk.Name = "mnuSaveToDisk"
        Me.mnuSaveToDisk.Size = New System.Drawing.Size(211, 22)
        Me.mnuSaveToDisk.Text = "&Save All Tasklists Now"
        '
        'mnuBackupTop
        '
        Me.mnuBackupTop.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBackup, Me.mnuDeletePreviousBackups, Me.mnuDeletePreviousAndBackupAll})
        Me.mnuBackupTop.Name = "mnuBackupTop"
        Me.mnuBackupTop.Size = New System.Drawing.Size(211, 22)
        Me.mnuBackupTop.Text = "&Backup ..."
        '
        'mnuBackup
        '
        Me.mnuBackup.Name = "mnuBackup"
        Me.mnuBackup.Size = New System.Drawing.Size(219, 22)
        Me.mnuBackup.Text = "&Backup All Tasklists Now"
        '
        'mnuDeletePreviousBackups
        '
        Me.mnuDeletePreviousBackups.Name = "mnuDeletePreviousBackups"
        Me.mnuDeletePreviousBackups.Size = New System.Drawing.Size(219, 22)
        Me.mnuDeletePreviousBackups.Text = "&Delete All Previous Backups"
        '
        'mnuDeletePreviousAndBackupAll
        '
        Me.mnuDeletePreviousAndBackupAll.Name = "mnuDeletePreviousAndBackupAll"
        Me.mnuDeletePreviousAndBackupAll.Size = New System.Drawing.Size(219, 22)
        Me.mnuDeletePreviousAndBackupAll.Text = "Delete Previous, Backup All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(208, 6)
        '
        'mnuMainDelete
        '
        Me.mnuMainDelete.Name = "mnuMainDelete"
        Me.mnuMainDelete.Size = New System.Drawing.Size(211, 22)
        Me.mnuMainDelete.Text = "&Delete"
        '
        'ExportToToolStripMenuItem
        '
        Me.ExportToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExportToText, Me.mnuExportToWord, Me.mnuExportToExcel, Me.PrinterToolStripMenuItem})
        Me.ExportToToolStripMenuItem.Name = "ExportToToolStripMenuItem"
        Me.ExportToToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ExportToToolStripMenuItem.Text = "Export to"
        '
        'mnuExportToText
        '
        Me.mnuExportToText.Name = "mnuExportToText"
        Me.mnuExportToText.Size = New System.Drawing.Size(109, 22)
        Me.mnuExportToText.Text = "Text"
        '
        'mnuExportToWord
        '
        Me.mnuExportToWord.Name = "mnuExportToWord"
        Me.mnuExportToWord.Size = New System.Drawing.Size(109, 22)
        Me.mnuExportToWord.Text = "Word"
        '
        'mnuExportToExcel
        '
        Me.mnuExportToExcel.Name = "mnuExportToExcel"
        Me.mnuExportToExcel.Size = New System.Drawing.Size(109, 22)
        Me.mnuExportToExcel.Text = "Excel"
        '
        'PrinterToolStripMenuItem
        '
        Me.PrinterToolStripMenuItem.Name = "PrinterToolStripMenuItem"
        Me.PrinterToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.PrinterToolStripMenuItem.Text = "Printer"
        '
        'mnuSettings
        '
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(156, 22)
        Me.mnuSettings.Text = "&Settings"
        '
        'mnuAlerts
        '
        Me.mnuAlerts.Name = "mnuAlerts"
        Me.mnuAlerts.Size = New System.Drawing.Size(156, 22)
        Me.mnuAlerts.Text = "Turn &Alerts OFF"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutCRSToolStripMenuItem, Me.HelpTopicsToolStripMenuItem})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(156, 22)
        Me.mnuHelp.Text = "&Help"
        '
        'AboutCRSToolStripMenuItem
        '
        Me.AboutCRSToolStripMenuItem.Name = "AboutCRSToolStripMenuItem"
        Me.AboutCRSToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AboutCRSToolStripMenuItem.Text = "&About CRS"
        '
        'HelpTopicsToolStripMenuItem
        '
        Me.HelpTopicsToolStripMenuItem.Name = "HelpTopicsToolStripMenuItem"
        Me.HelpTopicsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.HelpTopicsToolStripMenuItem.Text = "Help &Topics"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(333, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Task lists:"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(15, 15)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lstVu
        '
        Me.lstVu.AllowColumnReorder = True
        Me.lstVu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstVu.BackColor = System.Drawing.Color.AliceBlue
        Me.lstVu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colLineNum, Me.colPriority, Me.colTaskText, Me.colDueDate, Me.colCreatedOn, Me.colNotification})
        Me.lstVu.ContextMenuStrip = Me.mnuPop
        Me.lstVu.FullRowSelect = True
        Me.lstVu.GridLines = True
        Me.lstVu.HideSelection = False
        Me.lstVu.Location = New System.Drawing.Point(0, 24)
        Me.lstVu.Name = "lstVu"
        Me.lstVu.Size = New System.Drawing.Size(1038, 429)
        Me.lstVu.SmallImageList = Me.ImageList1
        Me.lstVu.TabIndex = 20
        Me.lstVu.TabStop = False
        Me.lstVu.UseCompatibleStateImageBehavior = False
        Me.lstVu.View = System.Windows.Forms.View.Details
        '
        'colLineNum
        '
        Me.colLineNum.Tag = "line #"
        Me.colLineNum.Text = "line #"
        Me.colLineNum.Width = 43
        '
        'colPriority
        '
        Me.colPriority.Tag = "Priority"
        Me.colPriority.Text = "Priority"
        Me.colPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPriority.Width = 46
        '
        'colTaskText
        '
        Me.colTaskText.Tag = "Task"
        Me.colTaskText.Text = "Task"
        '
        'colDueDate
        '
        Me.colDueDate.Tag = "Due Date"
        Me.colDueDate.Text = "Due Date"
        Me.colDueDate.Width = 100
        '
        'colCreatedOn
        '
        Me.colCreatedOn.Tag = "Created On"
        Me.colCreatedOn.Text = "Created On"
        Me.colCreatedOn.Width = 100
        '
        'colNotification
        '
        Me.colNotification.Tag = "Notification"
        Me.colNotification.Text = "Notification"
        Me.colNotification.Width = 100
        '
        'tmrLstVuSelection
        '
        Me.tmrLstVuSelection.Interval = 2000
        '
        'txtDummy
        '
        Me.txtDummy.Location = New System.Drawing.Point(219, 216)
        Me.txtDummy.Name = "txtDummy"
        Me.txtDummy.Size = New System.Drawing.Size(100, 20)
        Me.txtDummy.TabIndex = 21
        '
        'tmrDeselector
        '
        Me.tmrDeselector.Interval = 250
        '
        'statBar
        '
        Me.statBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolShowGrid, Me.toolSetBackcolor, Me.toolShowHideColumns, Me.toolResetFromSort})
        Me.statBar.Location = New System.Drawing.Point(0, 484)
        Me.statBar.Name = "statBar"
        Me.statBar.Size = New System.Drawing.Size(1063, 22)
        Me.statBar.TabIndex = 23
        Me.statBar.Text = "StatusStrip1"
        '
        'toolShowGrid
        '
        Me.toolShowGrid.AutoSize = False
        Me.toolShowGrid.Name = "toolShowGrid"
        Me.toolShowGrid.Size = New System.Drawing.Size(60, 17)
        Me.toolShowGrid.Text = "show grid"
        '
        'toolSetBackcolor
        '
        Me.toolSetBackcolor.AutoSize = False
        Me.toolSetBackcolor.Name = "toolSetBackcolor"
        Me.toolSetBackcolor.Size = New System.Drawing.Size(80, 17)
        Me.toolSetBackcolor.Text = "set back color"
        '
        'toolShowHideColumns
        '
        Me.toolShowHideColumns.AutoSize = False
        Me.toolShowHideColumns.Name = "toolShowHideColumns"
        Me.toolShowHideColumns.Size = New System.Drawing.Size(105, 17)
        Me.toolShowHideColumns.Text = "show/hide columns"
        '
        'toolResetFromSort
        '
        Me.toolResetFromSort.AutoSize = False
        Me.toolResetFromSort.Name = "toolResetFromSort"
        Me.toolResetFromSort.Size = New System.Drawing.Size(85, 17)
        Me.toolResetFromSort.Text = "reset from sort"
        Me.toolResetFromSort.Visible = False
        '
        'tmrDeselectCbx
        '
        Me.tmrDeselectCbx.Enabled = True
        Me.tmrDeselectCbx.Interval = 200
        '
        'tmrCheckAlerts
        '
        Me.tmrCheckAlerts.Enabled = True
        Me.tmrCheckAlerts.Interval = 30000
        '
        'trayIcon
        '
        Me.trayIcon.ContextMenuStrip = Me.mnuTray
        Me.trayIcon.Text = "CRS"
        '
        'mnuTray
        '
        Me.mnuTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTrayClose})
        Me.mnuTray.Name = "mnuTray"
        Me.mnuTray.Size = New System.Drawing.Size(104, 26)
        '
        'mnuTrayClose
        '
        Me.mnuTrayClose.Name = "mnuTrayClose"
        Me.mnuTrayClose.Size = New System.Drawing.Size(103, 22)
        Me.mnuTrayClose.Text = "Close"
        '
        'lblCol0
        '
        Me.lblCol0.AutoSize = True
        Me.lblCol0.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblCol0.Location = New System.Drawing.Point(595, 462)
        Me.lblCol0.Name = "lblCol0"
        Me.lblCol0.Size = New System.Drawing.Size(39, 13)
        Me.lblCol0.TabIndex = 25
        Me.lblCol0.Text = "Label1"
        '
        'lblCol2
        '
        Me.lblCol2.AutoSize = True
        Me.lblCol2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblCol2.Location = New System.Drawing.Point(685, 462)
        Me.lblCol2.Name = "lblCol2"
        Me.lblCol2.Size = New System.Drawing.Size(39, 13)
        Me.lblCol2.TabIndex = 27
        Me.lblCol2.Text = "Label1"
        '
        'lblCol3
        '
        Me.lblCol3.AutoSize = True
        Me.lblCol3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblCol3.Location = New System.Drawing.Point(730, 462)
        Me.lblCol3.Name = "lblCol3"
        Me.lblCol3.Size = New System.Drawing.Size(39, 13)
        Me.lblCol3.TabIndex = 28
        Me.lblCol3.Text = "Label1"
        '
        'lblCol4
        '
        Me.lblCol4.AutoSize = True
        Me.lblCol4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblCol4.Location = New System.Drawing.Point(775, 462)
        Me.lblCol4.Name = "lblCol4"
        Me.lblCol4.Size = New System.Drawing.Size(39, 13)
        Me.lblCol4.TabIndex = 29
        Me.lblCol4.Text = "Label1"
        '
        'lblCol5
        '
        Me.lblCol5.AutoSize = True
        Me.lblCol5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblCol5.Location = New System.Drawing.Point(820, 462)
        Me.lblCol5.Name = "lblCol5"
        Me.lblCol5.Size = New System.Drawing.Size(39, 13)
        Me.lblCol5.TabIndex = 30
        Me.lblCol5.Text = "Label1"
        '
        'tmrTriggerColumnLabelReorder
        '
        Me.tmrTriggerColumnLabelReorder.Interval = 25
        '
        'lblCol1
        '
        Me.lblCol1.AutoSize = True
        Me.lblCol1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblCol1.Location = New System.Drawing.Point(640, 462)
        Me.lblCol1.Name = "lblCol1"
        Me.lblCol1.Size = New System.Drawing.Size(39, 13)
        Me.lblCol1.TabIndex = 31
        Me.lblCol1.Text = "Label1"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSearch_ThisTasklist, Me.mnuSearch_AllTasklists})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'mnuSearch_ThisTasklist
        '
        Me.mnuSearch_ThisTasklist.Name = "mnuSearch_ThisTasklist"
        Me.mnuSearch_ThisTasklist.Size = New System.Drawing.Size(152, 22)
        Me.mnuSearch_ThisTasklist.Text = "This Tasklist"
        '
        'mnuSearch_AllTasklists
        '
        Me.mnuSearch_AllTasklists.Name = "mnuSearch_AllTasklists"
        Me.mnuSearch_AllTasklists.Size = New System.Drawing.Size(152, 22)
        Me.mnuSearch_AllTasklists.Text = "All"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 506)
        Me.Controls.Add(Me.lblCol1)
        Me.Controls.Add(Me.lblCol5)
        Me.Controls.Add(Me.lblCol4)
        Me.Controls.Add(Me.lblCol3)
        Me.Controls.Add(Me.lblCol2)
        Me.Controls.Add(Me.lblCol0)
        Me.Controls.Add(Me.lstVu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxTaskLists)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtDummy)
        Me.Controls.Add(Me.statBar)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(620, 140)
        Me.Name = "Form1"
        Me.Text = "Alzie"
        Me.mnuPop.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.statBar.ResumeLayout(False)
        Me.statBar.PerformLayout()
        Me.mnuTray.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents cbxTaskLists As System.Windows.Forms.ComboBox
	Friend WithEvents mnuPop As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuDeleteSelectedTask As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuDeleteThisTasklist As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuAddAbove As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuAddBelow As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuSaveList As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuMove As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuMoveUp As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuMoveDown As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuMoveIncreaseIndent As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuMoveDecreaseIndent As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
	Friend WithEvents mnuMainAddAbove As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuMainAddBelow As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuMainSave As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents mnuColor As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents clr As System.Windows.Forms.ColorDialog
	Friend WithEvents lstVu As System.Windows.Forms.ListView
	Friend WithEvents colPriority As System.Windows.Forms.ColumnHeader
	Friend WithEvents colTaskText As System.Windows.Forms.ColumnHeader
	Friend WithEvents colDueDate As System.Windows.Forms.ColumnHeader
	Friend WithEvents tmrLstVuSelection As System.Windows.Forms.Timer
	Friend WithEvents txtDummy As System.Windows.Forms.TextBox
	Friend WithEvents tmrDeselector As System.Windows.Forms.Timer
	Friend WithEvents colLineNum As System.Windows.Forms.ColumnHeader
	Friend WithEvents statBar As System.Windows.Forms.StatusStrip
	Friend WithEvents toolShowGrid As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents toolSetBackcolor As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents mnuComplete As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents colCreatedOn As System.Windows.Forms.ColumnHeader
	Friend WithEvents toolShowHideColumns As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents colNotification As System.Windows.Forms.ColumnHeader
	Friend WithEvents tmrDeselectCbx As System.Windows.Forms.Timer
	Friend WithEvents tmrCheckAlerts As System.Windows.Forms.Timer
	Friend WithEvents mnuMore As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuAlerts As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents trayIcon As System.Windows.Forms.NotifyIcon
	Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents AboutCRSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents HelpTopicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolResetFromSort As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents mnuTasklist As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents mnuMainDelete As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuRename As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuTray As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents mnuTrayClose As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents lblCol0 As System.Windows.Forms.Label
	Friend WithEvents lblCol2 As System.Windows.Forms.Label
	Friend WithEvents lblCol3 As System.Windows.Forms.Label
	Friend WithEvents lblCol4 As System.Windows.Forms.Label
	Friend WithEvents lblCol5 As System.Windows.Forms.Label
	Friend WithEvents tmrTriggerColumnLabelReorder As System.Windows.Forms.Timer
	Friend WithEvents lblCol1 As System.Windows.Forms.Label
	Friend WithEvents mnuMoveToTasklist As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuSaveToDisk As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuBackupTop As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuBackup As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuDeletePreviousBackups As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDeletePreviousAndBackupAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportToText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportToWord As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportToExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrinterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSearch_ThisTasklist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSearch_AllTasklists As System.Windows.Forms.ToolStripMenuItem

End Class
