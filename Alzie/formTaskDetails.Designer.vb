<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTaskDetails
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
        Me.components = New System.ComponentModel.Container
        Me.txtText = New System.Windows.Forms.TextBox
        Me.cbxAlertUnit = New System.Windows.Forms.ComboBox
        Me.chkCompleted = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCreatedOn = New System.Windows.Forms.Label
        Me.due_Date = New System.Windows.Forms.DateTimePicker
        Me.due_Time = New System.Windows.Forms.DateTimePicker
        Me.txtAlarmBefore = New System.Windows.Forms.NumericUpDown
        Me.cbxAlertMethod = New System.Windows.Forms.ComboBox
        Me.lblBy = New System.Windows.Forms.Label
        Me.chkUseDueDate = New System.Windows.Forms.CheckBox
        Me.chkUseAlert = New System.Windows.Forms.CheckBox
        Me.btnNow = New System.Windows.Forms.Button
        Me.clr = New System.Windows.Forms.ColorDialog
        Me.btnChangeColor = New System.Windows.Forms.Button
        Me.lblItemColor = New System.Windows.Forms.Label
        Me.grpClr = New System.Windows.Forms.GroupBox
        Me.btnSameColor = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbxFonts = New System.Windows.Forms.ComboBox
        Me.txtFontSize = New System.Windows.Forms.NumericUpDown
        Me.cbxStyle = New System.Windows.Forms.ComboBox
        Me.btnSameFont = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnResetFont = New System.Windows.Forms.Button
        Me.grpFont = New System.Windows.Forms.GroupBox
        Me.optSameLevelAsAbove = New System.Windows.Forms.RadioButton
        Me.optChildItem = New System.Windows.Forms.RadioButton
        Me.optDivider = New System.Windows.Forms.RadioButton
        Me.grpIndent = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.pnlButtons = New System.Windows.Forms.Panel
        Me.cbxPriority = New System.Windows.Forms.ComboBox
        Me.lblBack2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        CType(Me.txtAlarmBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClr.SuspendLayout()
        CType(Me.txtFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFont.SuspendLayout()
        Me.grpIndent.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(12, 32)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtText.Size = New System.Drawing.Size(255, 48)
        Me.txtText.TabIndex = 0
        '
        'cbxAlertUnit
        '
        Me.cbxAlertUnit.Enabled = False
        Me.cbxAlertUnit.FormattingEnabled = True
        Me.cbxAlertUnit.Items.AddRange(New Object() {"", "minutes", "hrs", "days"})
        Me.cbxAlertUnit.Location = New System.Drawing.Point(120, 113)
        Me.cbxAlertUnit.Name = "cbxAlertUnit"
        Me.cbxAlertUnit.Size = New System.Drawing.Size(68, 21)
        Me.cbxAlertUnit.TabIndex = 7
        '
        'chkCompleted
        '
        Me.chkCompleted.AutoSize = True
        Me.chkCompleted.Location = New System.Drawing.Point(173, 11)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Size = New System.Drawing.Size(97, 17)
        Me.chkCompleted.TabIndex = 14
        Me.chkCompleted.Text = "Mark Complete"
        Me.chkCompleted.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(10, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Created on"
        '
        'lblCreatedOn
        '
        Me.lblCreatedOn.AutoSize = True
        Me.lblCreatedOn.ForeColor = System.Drawing.Color.Gray
        Me.lblCreatedOn.Location = New System.Drawing.Point(67, 11)
        Me.lblCreatedOn.Name = "lblCreatedOn"
        Me.lblCreatedOn.Size = New System.Drawing.Size(0, 13)
        Me.lblCreatedOn.TabIndex = 20
        '
        'due_Date
        '
        Me.due_Date.Enabled = False
        Me.due_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.due_Date.Location = New System.Drawing.Point(84, 87)
        Me.due_Date.Name = "due_Date"
        Me.due_Date.Size = New System.Drawing.Size(75, 20)
        Me.due_Date.TabIndex = 2
        '
        'due_Time
        '
        Me.due_Time.Enabled = False
        Me.due_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.due_Time.Location = New System.Drawing.Point(164, 87)
        Me.due_Time.Name = "due_Time"
        Me.due_Time.ShowUpDown = True
        Me.due_Time.Size = New System.Drawing.Size(56, 20)
        Me.due_Time.TabIndex = 3
        Me.due_Time.Value = New Date(2010, 4, 26, 12, 0, 0, 0)
        '
        'txtAlarmBefore
        '
        Me.txtAlarmBefore.Enabled = False
        Me.txtAlarmBefore.Location = New System.Drawing.Point(81, 114)
        Me.txtAlarmBefore.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.txtAlarmBefore.Name = "txtAlarmBefore"
        Me.txtAlarmBefore.Size = New System.Drawing.Size(37, 20)
        Me.txtAlarmBefore.TabIndex = 6
        '
        'cbxAlertMethod
        '
        Me.cbxAlertMethod.Enabled = False
        Me.cbxAlertMethod.FormattingEnabled = True
        Me.cbxAlertMethod.Items.AddRange(New Object() {"", "email", "sound", "both"})
        Me.cbxAlertMethod.Location = New System.Drawing.Point(208, 113)
        Me.cbxAlertMethod.Name = "cbxAlertMethod"
        Me.cbxAlertMethod.Size = New System.Drawing.Size(58, 21)
        Me.cbxAlertMethod.TabIndex = 8
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Enabled = False
        Me.lblBy.Location = New System.Drawing.Point(190, 118)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(18, 13)
        Me.lblBy.TabIndex = 7
        Me.lblBy.Text = "by"
        '
        'chkUseDueDate
        '
        Me.chkUseDueDate.AutoSize = True
        Me.chkUseDueDate.Location = New System.Drawing.Point(14, 89)
        Me.chkUseDueDate.Name = "chkUseDueDate"
        Me.chkUseDueDate.Size = New System.Drawing.Size(72, 17)
        Me.chkUseDueDate.TabIndex = 1
        Me.chkUseDueDate.Text = "Due Date"
        Me.chkUseDueDate.UseVisualStyleBackColor = True
        '
        'chkUseAlert
        '
        Me.chkUseAlert.AutoSize = True
        Me.chkUseAlert.Enabled = False
        Me.chkUseAlert.Location = New System.Drawing.Point(14, 116)
        Me.chkUseAlert.Name = "chkUseAlert"
        Me.chkUseAlert.Size = New System.Drawing.Size(67, 17)
        Me.chkUseAlert.TabIndex = 5
        Me.chkUseAlert.Text = "Notify @"
        Me.chkUseAlert.UseVisualStyleBackColor = True
        '
        'btnNow
        '
        Me.btnNow.Enabled = False
        Me.btnNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNow.Location = New System.Drawing.Point(225, 87)
        Me.btnNow.Name = "btnNow"
        Me.btnNow.Size = New System.Drawing.Size(37, 20)
        Me.btnNow.TabIndex = 4
        Me.btnNow.Text = "(now)"
        Me.btnNow.UseVisualStyleBackColor = True
        '
        'btnChangeColor
        '
        Me.btnChangeColor.Location = New System.Drawing.Point(5, 16)
        Me.btnChangeColor.Name = "btnChangeColor"
        Me.btnChangeColor.Size = New System.Drawing.Size(59, 21)
        Me.btnChangeColor.TabIndex = 1
        Me.btnChangeColor.Text = "(change)"
        Me.btnChangeColor.UseVisualStyleBackColor = True
        '
        'lblItemColor
        '
        Me.lblItemColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemColor.Location = New System.Drawing.Point(70, 16)
        Me.lblItemColor.Name = "lblItemColor"
        Me.lblItemColor.Size = New System.Drawing.Size(26, 20)
        Me.lblItemColor.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.lblItemColor, "current color")
        '
        'grpClr
        '
        Me.grpClr.Controls.Add(Me.btnSameColor)
        Me.grpClr.Controls.Add(Me.lblItemColor)
        Me.grpClr.Controls.Add(Me.btnChangeColor)
        Me.grpClr.Location = New System.Drawing.Point(165, 145)
        Me.grpClr.Name = "grpClr"
        Me.grpClr.Size = New System.Drawing.Size(102, 82)
        Me.grpClr.TabIndex = 10
        Me.grpClr.TabStop = False
        Me.grpClr.Text = "Text color"
        '
        'btnSameColor
        '
        Me.btnSameColor.Enabled = False
        Me.btnSameColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSameColor.Location = New System.Drawing.Point(8, 43)
        Me.btnSameColor.Name = "btnSameColor"
        Me.btnSameColor.Size = New System.Drawing.Size(89, 33)
        Me.btnSameColor.TabIndex = 3
        Me.btnSameColor.Text = "same as item above"
        Me.btnSameColor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Size"
        '
        'cbxFonts
        '
        Me.cbxFonts.DropDownWidth = 225
        Me.cbxFonts.FormattingEnabled = True
        Me.cbxFonts.Location = New System.Drawing.Point(38, 19)
        Me.cbxFonts.Name = "cbxFonts"
        Me.cbxFonts.Size = New System.Drawing.Size(168, 21)
        Me.cbxFonts.TabIndex = 14
        '
        'txtFontSize
        '
        Me.txtFontSize.Location = New System.Drawing.Point(15, 61)
        Me.txtFontSize.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.txtFontSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.txtFontSize.Name = "txtFontSize"
        Me.txtFontSize.Size = New System.Drawing.Size(33, 20)
        Me.txtFontSize.TabIndex = 21
        Me.txtFontSize.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'cbxStyle
        '
        Me.cbxStyle.FormattingEnabled = True
        Me.cbxStyle.Items.AddRange(New Object() {"Normal", "Bold", "Italic", "Bold Italic"})
        Me.cbxStyle.Location = New System.Drawing.Point(60, 60)
        Me.cbxStyle.Name = "cbxStyle"
        Me.cbxStyle.Size = New System.Drawing.Size(81, 21)
        Me.cbxStyle.TabIndex = 22
        Me.cbxStyle.Text = "Normal"
        '
        'btnSameFont
        '
        Me.btnSameFont.Enabled = False
        Me.btnSameFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSameFont.Location = New System.Drawing.Point(164, 46)
        Me.btnSameFont.Name = "btnSameFont"
        Me.btnSameFont.Size = New System.Drawing.Size(88, 39)
        Me.btnSameFont.TabIndex = 23
        Me.btnSameFont.Text = "same as item above"
        Me.btnSameFont.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Style"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Name"
        '
        'btnResetFont
        '
        Me.btnResetFont.Location = New System.Drawing.Point(211, 11)
        Me.btnResetFont.Name = "btnResetFont"
        Me.btnResetFont.Size = New System.Drawing.Size(40, 24)
        Me.btnResetFont.TabIndex = 26
        Me.btnResetFont.Text = "reset"
        Me.btnResetFont.UseVisualStyleBackColor = True
        '
        'grpFont
        '
        Me.grpFont.Controls.Add(Me.btnResetFont)
        Me.grpFont.Controls.Add(Me.Label5)
        Me.grpFont.Controls.Add(Me.Label1)
        Me.grpFont.Controls.Add(Me.btnSameFont)
        Me.grpFont.Controls.Add(Me.cbxStyle)
        Me.grpFont.Controls.Add(Me.txtFontSize)
        Me.grpFont.Controls.Add(Me.cbxFonts)
        Me.grpFont.Controls.Add(Me.Label3)
        Me.grpFont.Location = New System.Drawing.Point(14, 239)
        Me.grpFont.Name = "grpFont"
        Me.grpFont.Size = New System.Drawing.Size(255, 90)
        Me.grpFont.TabIndex = 12
        Me.grpFont.TabStop = False
        Me.grpFont.Text = "Font"
        '
        'optSameLevelAsAbove
        '
        Me.optSameLevelAsAbove.AutoSize = True
        Me.optSameLevelAsAbove.Location = New System.Drawing.Point(6, 44)
        Me.optSameLevelAsAbove.Name = "optSameLevelAsAbove"
        Me.optSameLevelAsAbove.Size = New System.Drawing.Size(106, 17)
        Me.optSameLevelAsAbove.TabIndex = 21
        Me.optSameLevelAsAbove.TabStop = True
        Me.optSameLevelAsAbove.Text = "Peer (same level)"
        Me.optSameLevelAsAbove.UseVisualStyleBackColor = True
        '
        'optChildItem
        '
        Me.optChildItem.AutoSize = True
        Me.optChildItem.Location = New System.Drawing.Point(6, 19)
        Me.optChildItem.Name = "optChildItem"
        Me.optChildItem.Size = New System.Drawing.Size(98, 17)
        Me.optChildItem.TabIndex = 20
        Me.optChildItem.TabStop = True
        Me.optChildItem.Text = "Child (indented)"
        Me.optChildItem.UseVisualStyleBackColor = True
        '
        'optDivider
        '
        Me.optDivider.AutoSize = True
        Me.optDivider.Location = New System.Drawing.Point(7, 83)
        Me.optDivider.Name = "optDivider"
        Me.optDivider.Size = New System.Drawing.Size(111, 17)
        Me.optDivider.TabIndex = 22
        Me.optDivider.TabStop = True
        Me.optDivider.Text = "blank (divider) row"
        Me.optDivider.UseVisualStyleBackColor = True
        Me.optDivider.Visible = False
        '
        'grpIndent
        '
        Me.grpIndent.Controls.Add(Me.optDivider)
        Me.grpIndent.Controls.Add(Me.optChildItem)
        Me.grpIndent.Controls.Add(Me.optSameLevelAsAbove)
        Me.grpIndent.Enabled = False
        Me.grpIndent.Location = New System.Drawing.Point(14, 150)
        Me.grpIndent.Name = "grpIndent"
        Me.grpIndent.Size = New System.Drawing.Size(145, 72)
        Me.grpIndent.TabIndex = 9
        Me.grpIndent.TabStop = False
        Me.grpIndent.Text = "Relation to previous item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Priority"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(82, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 22)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(2, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(74, 22)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnOk)
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Location = New System.Drawing.Point(113, 333)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(156, 33)
        Me.pnlButtons.TabIndex = 13
        '
        'cbxPriority
        '
        Me.cbxPriority.FormattingEnabled = True
        Me.cbxPriority.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbxPriority.Location = New System.Drawing.Point(55, 339)
        Me.cbxPriority.Name = "cbxPriority"
        Me.cbxPriority.Size = New System.Drawing.Size(40, 21)
        Me.cbxPriority.TabIndex = 11
        '
        'lblBack2
        '
        Me.lblBack2.BackColor = System.Drawing.Color.AliceBlue
        Me.lblBack2.Location = New System.Drawing.Point(5, 5)
        Me.lblBack2.Name = "lblBack2"
        Me.lblBack2.Size = New System.Drawing.Size(289, 382)
        Me.lblBack2.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(299, 392)
        Me.Label7.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblCreatedOn)
        Me.Panel1.Controls.Add(Me.chkCompleted)
        Me.Panel1.Controls.Add(Me.cbxPriority)
        Me.Panel1.Controls.Add(Me.due_Time)
        Me.Panel1.Controls.Add(Me.grpIndent)
        Me.Panel1.Controls.Add(Me.txtText)
        Me.Panel1.Controls.Add(Me.grpFont)
        Me.Panel1.Controls.Add(Me.cbxAlertUnit)
        Me.Panel1.Controls.Add(Me.pnlButtons)
        Me.Panel1.Controls.Add(Me.lblBy)
        Me.Panel1.Controls.Add(Me.grpClr)
        Me.Panel1.Controls.Add(Me.cbxAlertMethod)
        Me.Panel1.Controls.Add(Me.due_Date)
        Me.Panel1.Controls.Add(Me.chkUseDueDate)
        Me.Panel1.Controls.Add(Me.btnNow)
        Me.Panel1.Controls.Add(Me.chkUseAlert)
        Me.Panel1.Controls.Add(Me.txtAlarmBefore)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 372)
        Me.Panel1.TabIndex = 23
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FloralWhite
        Me.lblTitle.Location = New System.Drawing.Point(96, -2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(106, 13)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "Task Details"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formTaskDetails
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(298, 401)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblBack2)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formTaskDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Task Details"
        CType(Me.txtAlarmBefore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClr.ResumeLayout(False)
        CType(Me.txtFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFont.ResumeLayout(False)
        Me.grpFont.PerformLayout()
        Me.grpIndent.ResumeLayout(False)
        Me.grpIndent.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
	Friend WithEvents txtText As System.Windows.Forms.TextBox
	Friend WithEvents cbxAlertUnit As System.Windows.Forms.ComboBox
	Friend WithEvents chkCompleted As System.Windows.Forms.CheckBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents lblCreatedOn As System.Windows.Forms.Label
	Friend WithEvents due_Date As System.Windows.Forms.DateTimePicker
	Friend WithEvents due_Time As System.Windows.Forms.DateTimePicker
	Friend WithEvents txtAlarmBefore As System.Windows.Forms.NumericUpDown
	Friend WithEvents cbxAlertMethod As System.Windows.Forms.ComboBox
	Friend WithEvents lblBy As System.Windows.Forms.Label
	Friend WithEvents chkUseDueDate As System.Windows.Forms.CheckBox
	Friend WithEvents chkUseAlert As System.Windows.Forms.CheckBox
	Friend WithEvents btnNow As System.Windows.Forms.Button
	Friend WithEvents clr As System.Windows.Forms.ColorDialog
	Friend WithEvents btnChangeColor As System.Windows.Forms.Button
	Friend WithEvents lblItemColor As System.Windows.Forms.Label
	Friend WithEvents grpClr As System.Windows.Forms.GroupBox
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents btnSameColor As System.Windows.Forms.Button
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents cbxFonts As System.Windows.Forms.ComboBox
	Friend WithEvents txtFontSize As System.Windows.Forms.NumericUpDown
	Friend WithEvents cbxStyle As System.Windows.Forms.ComboBox
	Friend WithEvents btnSameFont As System.Windows.Forms.Button
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents btnResetFont As System.Windows.Forms.Button
	Friend WithEvents grpFont As System.Windows.Forms.GroupBox
	Friend WithEvents optSameLevelAsAbove As System.Windows.Forms.RadioButton
	Friend WithEvents optChildItem As System.Windows.Forms.RadioButton
	Friend WithEvents optDivider As System.Windows.Forms.RadioButton
	Friend WithEvents grpIndent As System.Windows.Forms.GroupBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents btnOk As System.Windows.Forms.Button
	Friend WithEvents pnlButtons As System.Windows.Forms.Panel
	Friend WithEvents cbxPriority As System.Windows.Forms.ComboBox
	Friend WithEvents lblBack2 As System.Windows.Forms.Label
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
