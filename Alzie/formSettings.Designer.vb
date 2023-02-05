<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSettings
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
		Me.lblBack2 = New System.Windows.Forms.Label
		Me.lblBack1 = New System.Windows.Forms.Label
		Me.Panel1 = New System.Windows.Forms.Panel
		Me.Panel3 = New System.Windows.Forms.Panel
		Me.chkWeekday = New System.Windows.Forms.CheckBox
		Me.optWeekdayShort = New System.Windows.Forms.RadioButton
		Me.optWeekdayLong = New System.Windows.Forms.RadioButton
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.Panel2 = New System.Windows.Forms.Panel
		Me.CheckBox1 = New System.Windows.Forms.CheckBox
		Me.RadioButton5 = New System.Windows.Forms.RadioButton
		Me.RadioButton6 = New System.Windows.Forms.RadioButton
		Me.RadioButton4 = New System.Windows.Forms.RadioButton
		Me.RadioButton3 = New System.Windows.Forms.RadioButton
		Me.RadioButton2 = New System.Windows.Forms.RadioButton
		Me.RadioButton1 = New System.Windows.Forms.RadioButton
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblBGColor = New System.Windows.Forms.Label
		Me.Button1 = New System.Windows.Forms.Button
		Me.chkUseGrid = New System.Windows.Forms.CheckBox
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.GroupBox2 = New System.Windows.Forms.GroupBox
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblBack2
		'
		Me.lblBack2.BackColor = System.Drawing.Color.AliceBlue
		Me.lblBack2.Location = New System.Drawing.Point(5, 5)
		Me.lblBack2.Name = "lblBack2"
		Me.lblBack2.Size = New System.Drawing.Size(252, 371)
		Me.lblBack2.TabIndex = 23
		'
		'lblBack1
		'
		Me.lblBack1.BackColor = System.Drawing.Color.Goldenrod
		Me.lblBack1.Location = New System.Drawing.Point(0, 0)
		Me.lblBack1.Name = "lblBack1"
		Me.lblBack1.Size = New System.Drawing.Size(262, 381)
		Me.lblBack1.TabIndex = 24
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.GroupBox2)
		Me.Panel1.Controls.Add(Me.btnCancel)
		Me.Panel1.Controls.Add(Me.btnOk)
		Me.Panel1.Controls.Add(Me.GroupBox1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.lblBGColor)
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Controls.Add(Me.chkUseGrid)
		Me.Panel1.Location = New System.Drawing.Point(10, 10)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(242, 361)
		Me.Panel1.TabIndex = 25
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.chkWeekday)
		Me.Panel3.Controls.Add(Me.optWeekdayShort)
		Me.Panel3.Controls.Add(Me.optWeekdayLong)
		Me.Panel3.Location = New System.Drawing.Point(6, 65)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(200, 23)
		Me.Panel3.TabIndex = 9
		'
		'chkWeekday
		'
		Me.chkWeekday.AutoSize = True
		Me.chkWeekday.Location = New System.Drawing.Point(0, 3)
		Me.chkWeekday.Name = "chkWeekday"
		Me.chkWeekday.Size = New System.Drawing.Size(69, 17)
		Me.chkWeekday.TabIndex = 6
		Me.chkWeekday.Text = "weekday"
		Me.chkWeekday.UseVisualStyleBackColor = True
		'
		'optWeekdayShort
		'
		Me.optWeekdayShort.AutoSize = True
		Me.optWeekdayShort.Enabled = False
		Me.optWeekdayShort.Location = New System.Drawing.Point(144, 3)
		Me.optWeekdayShort.Name = "optWeekdayShort"
		Me.optWeekdayShort.Size = New System.Drawing.Size(54, 17)
		Me.optWeekdayShort.TabIndex = 5
		Me.optWeekdayShort.Text = """Sun"""
		Me.optWeekdayShort.UseVisualStyleBackColor = True
		'
		'optWeekdayLong
		'
		Me.optWeekdayLong.AutoSize = True
		Me.optWeekdayLong.Enabled = False
		Me.optWeekdayLong.Location = New System.Drawing.Point(71, 3)
		Me.optWeekdayLong.Name = "optWeekdayLong"
		Me.optWeekdayLong.Size = New System.Drawing.Size(71, 17)
		Me.optWeekdayLong.TabIndex = 4
		Me.optWeekdayLong.Text = """Sunday"""
		Me.optWeekdayLong.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Panel3)
		Me.GroupBox1.Controls.Add(Me.Panel2)
		Me.GroupBox1.Controls.Add(Me.RadioButton4)
		Me.GroupBox1.Controls.Add(Me.RadioButton3)
		Me.GroupBox1.Controls.Add(Me.RadioButton2)
		Me.GroupBox1.Controls.Add(Me.RadioButton1)
		Me.GroupBox1.Location = New System.Drawing.Point(11, 56)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(220, 127)
		Me.GroupBox1.TabIndex = 4
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Time/Date format"
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.CheckBox1)
		Me.Panel2.Controls.Add(Me.RadioButton5)
		Me.Panel2.Controls.Add(Me.RadioButton6)
		Me.Panel2.Location = New System.Drawing.Point(6, 94)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(207, 24)
		Me.Panel2.TabIndex = 9
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(129, 3)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(64, 17)
		Me.CheckBox1.TabIndex = 6
		Me.CheckBox1.Text = "xx:xx:12"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'RadioButton5
		'
		Me.RadioButton5.AutoSize = True
		Me.RadioButton5.Location = New System.Drawing.Point(0, 3)
		Me.RadioButton5.Name = "RadioButton5"
		Me.RadioButton5.Size = New System.Drawing.Size(65, 17)
		Me.RadioButton5.TabIndex = 4
		Me.RadioButton5.Text = "2:15 PM"
		Me.RadioButton5.UseVisualStyleBackColor = True
		'
		'RadioButton6
		'
		Me.RadioButton6.AutoSize = True
		Me.RadioButton6.Checked = True
		Me.RadioButton6.Location = New System.Drawing.Point(71, 3)
		Me.RadioButton6.Name = "RadioButton6"
		Me.RadioButton6.Size = New System.Drawing.Size(52, 17)
		Me.RadioButton6.TabIndex = 5
		Me.RadioButton6.TabStop = True
		Me.RadioButton6.Text = "14:15"
		Me.RadioButton6.UseVisualStyleBackColor = True
		'
		'RadioButton4
		'
		Me.RadioButton4.AutoSize = True
		Me.RadioButton4.Location = New System.Drawing.Point(6, 19)
		Me.RadioButton4.Name = "RadioButton4"
		Me.RadioButton4.Size = New System.Drawing.Size(119, 17)
		Me.RadioButton4.TabIndex = 6
		Me.RadioButton4.Text = "December 12, 2012"
		Me.RadioButton4.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Checked = True
		Me.RadioButton3.Location = New System.Drawing.Point(131, 42)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(71, 17)
		Me.RadioButton3.TabIndex = 2
		Me.RadioButton3.TabStop = True
		Me.RadioButton3.Text = "12/12/12"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(131, 19)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(83, 17)
		Me.RadioButton2.TabIndex = 1
		Me.RadioButton2.Text = "12/12/2012"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(6, 42)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
		Me.RadioButton1.TabIndex = 0
		Me.RadioButton1.Text = "Dec 12, 2012"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 7)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(68, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Display Color"
		'
		'lblBGColor
		'
		Me.lblBGColor.BackColor = System.Drawing.Color.LightCoral
		Me.lblBGColor.Location = New System.Drawing.Point(15, 23)
		Me.lblBGColor.Name = "lblBGColor"
		Me.lblBGColor.Size = New System.Drawing.Size(48, 23)
		Me.lblBGColor.TabIndex = 2
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(69, 23)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Change"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'chkUseGrid
		'
		Me.chkUseGrid.AutoSize = True
		Me.chkUseGrid.Location = New System.Drawing.Point(164, 22)
		Me.chkUseGrid.Name = "chkUseGrid"
		Me.chkUseGrid.Size = New System.Drawing.Size(67, 17)
		Me.chkUseGrid.TabIndex = 0
		Me.chkUseGrid.Text = "Use Grid"
		Me.chkUseGrid.UseVisualStyleBackColor = True
		'
		'btnOk
		'
		Me.btnOk.Location = New System.Drawing.Point(18, 307)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 5
		Me.btnOk.Text = "&Ok"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(142, 307)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 6
		Me.btnCancel.Text = "&Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Location = New System.Drawing.Point(11, 189)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(220, 100)
		Me.GroupBox2.TabIndex = 7
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Alerts"
		'
		'formSettings
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(261, 398)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.lblBack2)
		Me.Controls.Add(Me.lblBack1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "formSettings"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "formSettings"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lblBack2 As System.Windows.Forms.Label
	Friend WithEvents lblBack1 As System.Windows.Forms.Label
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents lblBGColor As System.Windows.Forms.Label
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents chkUseGrid As System.Windows.Forms.CheckBox
	Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
	Friend WithEvents optWeekdayShort As System.Windows.Forms.RadioButton
	Friend WithEvents optWeekdayLong As System.Windows.Forms.RadioButton
	Friend WithEvents Panel3 As System.Windows.Forms.Panel
	Friend WithEvents chkWeekday As System.Windows.Forms.CheckBox
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
