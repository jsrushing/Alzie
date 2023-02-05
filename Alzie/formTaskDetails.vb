Option Explicit On
'ToDo:
'
'
'Buglist:
'
'
'Imports CRS.Task
''' <summary><para>Created on 4/20/10 by Jason S. Rushing</para></summary>
''' <remarks>Windows form.  Create new tasks or edit existing.</remarks>
Public Class formTaskDetails
	Private mCanceled As Boolean = False
	Private mTaskTextColor As Integer
	Private mCreatedOn As Date
	Private mTask As Task
	Private mPreceedingTask As Task
	Private mDefaultFont As Font

	Public Sub New()
		InitializeComponent()
	End Sub
	Public Sub New(ByVal Task As Task, Optional ByVal PreceedingTask As Task = Nothing)
		InitializeComponent()
		mTask = Task
		mPreceedingTask = PreceedingTask
	End Sub

	Public ReadOnly Property Canceled()
		Get
			Return mCanceled
		End Get
	End Property
	Public WriteOnly Property DefaultTaskFont() As Font
		Set(ByVal value As Font)
			mDefaultFont = value
		End Set
	End Property
	Public WriteOnly Property PreceedingTask() As Task
		Set(ByVal value As Task)
			mPreceedingTask = value
		End Set
	End Property
	Public WriteOnly Property Task() As Task
		Set(ByVal value As Task)
			mTask = value
		End Set
	End Property

	Public Sub PostTask()
		With mTask
			Me.txtText.Text = .Text.Trim
			Me.due_Date.Value = .DueDate
			Me.due_Time.Value = .DueDate
			Me.txtAlarmBefore.Text = .AlertBeforeDuration
			Me.cbxAlertUnit.SelectedIndex = .AlertBeforeUnits
			Me.cbxAlertMethod.SelectedIndex = .AlertMethod
			Me.cbxPriority.SelectedIndex = .Priority
			Me.chkCompleted.Checked = .Completed
			Me.lblCreatedOn.Text = Format(.CreatedOnDate, "MM/dd/yy @ HH:mm ")
			mCreatedOn = .CreatedOnDate
			'Me.mTaskTextColor = .TextColor
			Me.lblItemColor.BackColor = Color.FromArgb(.TextColor)
			Me.chkUseDueDate.Checked = .UseDueDate
			Me.chkUseAlert.Checked = .UseAlert
			'Me.chkUsePopup.Checked = t.UsePopup
		End With
		Font_ShowDetails(mTask)
		FormatDateBoxes()
		If Me.lblItemColor.BackColor.ToArgb = 0 Then Me.lblItemColor.BackColor = Color.Black
	End Sub

	Public Function ReturnTask(Optional ByVal OriginalTask As Task = Nothing) As Task
		Dim t As New Task
		Dim indent As String = ""
		If OriginalTask IsNot Nothing Then
			indent = OriginalTask.IndentString
		End If
		Me.cbxFonts.Text = Me.txtText.Font.FontFamily.Name
		Try
            If txtText.Text <> "" Then txtText.Text = indent & txtText.Text
			t.Text = txtText.Text
			If t.Text = "" Then
				t.Font = Me.mDefaultFont
				Return t
			End If
			t.DueDate = Me.due_Date.Text & " " & Me.due_Time.Text
			t.AlertBeforeDuration = txtAlarmBefore.Text
			t.AlertBeforeUnits = cbxAlertUnit.SelectedIndex
			t.AlertMethod = Me.cbxAlertMethod.SelectedIndex
			t.Priority = cbxPriority.Text
			t.CreatedOnDate = mCreatedOn
			t.Completed = Me.chkCompleted.Checked
			t.TextColor = Me.lblItemColor.BackColor.ToArgb '  Me.mTaskTextColor
			t.UseDueDate = Me.chkUseDueDate.Checked
			t.UseAlert = Me.chkUseAlert.Checked
            't.UsePopup = False ' Me.chkUsePopup.Checked		'Is obsolete property.  Retained only to avoid re-writing I/O methods.
			t.TextColor = Me.lblItemColor.BackColor.ToArgb
			t.Font = Font_GetCurrentSettings()
			If t.Text = "" Then t.Font = Me.mDefaultFont

			If (Me.optChildItem.Checked Or Me.optSameLevelAsAbove.Checked) Then
				Dim indentNum As Integer = 1
				If Not Me.mPreceedingTask.Text.Equals("") Then indentNum = Me.mPreceedingTask.GetIndentLevel
				If Me.optChildItem.Checked Then indentNum += 1
				t.AddIndentToText(indentNum)
			End If

		Catch ex As Exception
			Return Nothing
		End Try
		Return t
	End Function
	'********************************************************
	Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
		Try
			If mTask Is Nothing Then mCreatedOn = Now
			If Me.optDivider.Checked Then ClearAllControls()
			Me.Hide()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		mCanceled = True
		Me.Hide()
	End Sub

	Private Sub btnResetFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetFont.Click
		Font_ShowDetails(mTask)
		Font_ShowSample()
	End Sub

	Private Sub btnSameFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSameFont.Click
		Font_ShowDetails(mPreceedingTask)
		Font_ShowSample()
	End Sub

	Private Sub ClearAllControls()
		Me.txtAlarmBefore.Text = ""
		Me.txtText.Text = ""
		Me.due_Time.Text = ""
		Me.due_Date.Text = ""
		Me.cbxPriority.Text = ""
	End Sub

	Private Function ContinueColorChangeIfItemIsComplete() As Boolean
		If Me.chkCompleted.Checked Then
			Dim rslt As DialogResult = MessageBox.Show("This item is marked as Completed and will always be displayed " & _
			"with a light gray color regardless of its underlying text color.  Do you want to mark the item as Not Completed so it will be displayed with the chosen color?", _
			My.Application.Info.ProductName, MessageBoxButtons.YesNoCancel)
			If rslt = Windows.Forms.DialogResult.Yes Then
				Me.chkCompleted.Checked = False
			ElseIf rslt = Windows.Forms.DialogResult.Cancel Then
				Return False ' Exit Function
			End If
		End If
		Return True
	End Function

	Private Sub DisableEnable_DueDateControls(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseDueDate.CheckedChanged
		Me.due_Date.Enabled = Me.chkUseDueDate.Checked
		Me.due_Time.Enabled = Me.chkUseDueDate.Checked
		Me.chkUseAlert.Enabled = Me.chkUseDueDate.Checked
		Me.btnNow.Enabled = Me.chkUseDueDate.Checked
		If Not Me.chkUseDueDate.Checked Then
			Me.chkUseAlert.Checked = True
			Me.chkUseAlert.Checked = False
		End If
	End Sub

	Private Sub DisableEnable_AlertControls(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseAlert.CheckedChanged
		Me.txtAlarmBefore.Enabled = Me.chkUseAlert.Checked
		Me.cbxAlertUnit.Enabled = Me.chkUseAlert.Checked
		Me.cbxAlertMethod.Enabled = Me.chkUseAlert.Checked
		'Me.chkUsePopup.Enabled = Me.chkUseAlert.Checked
		Me.lblBy.Enabled = Me.chkUseAlert.Checked
		If Not Me.chkUseAlert.Checked Then
			Me.txtAlarmBefore.Text = "0"
			Me.cbxAlertMethod.Text = ""
			Me.cbxAlertUnit.Text = ""
		Else
			If Me.cbxAlertMethod.SelectedIndex = 0 Then _
			  Me.cbxAlertMethod.SelectedIndex = 2
			If Me.cbxAlertUnit.SelectedIndex = 0 Then _
			  Me.cbxAlertUnit.SelectedIndex = 1
		End If
	End Sub

	Private Function Font_GetCurrentSettings() As Font
		Dim f As New Font(Me.cbxFonts.Text, Me.txtFontSize.Value)
		Dim BoldItalicStyle As System.Drawing.FontStyle = FontStyle.Italic + FontStyle.Bold
		Select Case Me.cbxStyle.Text
			Case "Normal"
				f = New Font(Me.cbxFonts.Text, Me.txtFontSize.Value)
			Case "Bold"
				f = New Font(Me.cbxFonts.Text, Me.txtFontSize.Value, FontStyle.Bold)
			Case "Italic"
				f = New Font(Me.cbxFonts.Text, Me.txtFontSize.Value, FontStyle.Italic)
			Case "Bold Italic"
				f = New Font(Me.cbxFonts.Text, Me.txtFontSize.Value, BoldItalicStyle)
		End Select
		Return f
	End Function

	Private Sub Font_ShowDetails(ByVal TaskFontToShow As Task)
		With TaskFontToShow
			Me.cbxFonts.Text = .Font.FontFamily.Name
			Me.txtFontSize.Value = .Font.Size
			Me.cbxStyle.Text = "Normal"
			If .Font.Bold Then Me.cbxStyle.Text = "Bold"
			If .Font.Italic Then Me.cbxStyle.Text = "Italic"
			If .Font.Bold And .Font.Italic Then Me.cbxStyle.Text = "Bold Italic"
		End With
	End Sub

	Private Sub Font_ShowSample()
		If Not Me.Visible Then Exit Sub
		Try
			With Me.txtText
				Dim f As Font = Font_GetCurrentSettings()
				f = New Font(f.FontFamily, 8)
				.Font = Font_GetCurrentSettings()
				.ForeColor = Me.lblItemColor.BackColor
			End With
		Catch ex As Exception
			'MessageBox.Show("Sorry, that font is not supported.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Try
	End Sub

	Private Sub formTaskDetails_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
		Me.txtText.SelectionLength = 0
	End Sub

	Private Sub formTaskDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Try
			Dim fonts As New System.Drawing.Text.InstalledFontCollection
			Dim fontFams() As FontFamily = fonts.Families
			For Each f As FontFamily In fontFams
				cbxFonts.Items.Add(f.Name)
			Next

			Me.Size = Label7.Size
			lblBack2.BackColor = Form1.lstVu.BackColor
			lblTitle.BackColor = Me.lblBack2.BackColor
			FormatDateBoxes()
			Dim dateCheckForEditAdd As Date = Now
			Me.lblCreatedOn.Text = Format(Now, "MM/dd/yy @ HH:mm")
			Me.mCreatedOn = Now
			If Me.cbxPriority.Text = "" Then Me.cbxPriority.Text = "0"

			If Me.mPreceedingTask IsNot Nothing AndAlso Me.mPreceedingTask.Text <> "" Then
				Me.btnSameColor.Enabled = True
				Me.btnSameColor.ForeColor = Color.FromArgb(mPreceedingTask.TextColor)
				If Me.mPreceedingTask.Font IsNot Nothing Then
					btnSameFont.Enabled = True
					Me.btnSameFont.Font = New Font(Me.mPreceedingTask.Font.FontFamily, Me.btnSameFont.Font.Size)
				End If
				Me.grpIndent.Enabled = True
			End If

			If mTask IsNot Nothing Then
				PostTask()
				dateCheckForEditAdd = mTask.CreatedOnDate
			Else
				mTask = New Task
				mTask.Font = Me.mDefaultFont
				Font_ShowDetails(mTask)
				Me.lblTitle.Text = "Add Task"
			End If

			If Me.mPreceedingTask IsNot Nothing Then
				Me.grpIndent.Enabled = True
			Else
				Me.grpIndent.Enabled = False
			End If

			If DateDiff(DateInterval.Second, dateCheckForEditAdd, Now) < 2 Then		'Adding
				Me.lblTitle.Text = "Add Task"
				If Me.mPreceedingTask IsNot Nothing AndAlso _
				  Me.mPreceedingTask.Text Is Nothing Then '								'If Adding to the top of the list, either with 'Add Task' or '+ Above', then
					Me.grpIndent.Enabled = True											' an empty task was passed as mPreceedingTask.  Set option to add as blank row visible.
					Me.optChildItem.Enabled = False
					Me.optSameLevelAsAbove.Enabled = False
				End If
			Else
				Me.lblTitle.Text = "Edit Task"
				Me.grpIndent.Enabled = False
			End If

			Font_ShowSample()

		Catch ex As Exception
			MessageBox.Show(ex.Message & " in formTaskDetails.formTaskDetails_Load")
		End Try
	End Sub

	Private Sub FormatDateBoxes()
		With due_Time
			.Format = DateTimePickerFormat.Custom
			.CustomFormat = "HH:mm"
			'.Value = Now
		End With
		With due_Date
			.Format = DateTimePickerFormat.Custom
			.CustomFormat = "MM/dd/yy"
			'.Value = Now
		End With
	End Sub

	Private Sub SetDueDateToNow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNow.Click
		Me.due_Date.Value = Now
		Me.due_Time.Value = Now
		Me.chkUseDueDate.Focus()
	End Sub

	Private Sub SelectItemTextColor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeColor.Click
		If Not ContinueColorChangeIfItemIsComplete() Then Exit Sub
		With clr
			.Color = Me.lblItemColor.BackColor
			Dim rslt As DialogResult = .ShowDialog()
			If rslt = Windows.Forms.DialogResult.Cancel Then Exit Sub
			Me.lblItemColor.BackColor = .Color
			Font_ShowSample()
		End With
	End Sub

	Private Sub txtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtText.TextChanged
		Font_ShowSample()
	End Sub

	Private Sub cbxFonts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFonts.SelectedIndexChanged
		Font_ShowSample()
	End Sub

	Private Sub txtFontSize_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFontSize.ValueChanged
		Font_ShowSample()
	End Sub

	Private Sub cbxStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxStyle.SelectedIndexChanged
		Font_ShowSample()
	End Sub

	Private Sub btnSameColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSameColor.Click
		ContinueColorChangeIfItemIsComplete()
		Me.lblItemColor.BackColor = Me.btnSameColor.ForeColor
		Font_ShowSample()
	End Sub
End Class