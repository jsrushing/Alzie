<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTaskIsDue
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
		Me.Label1 = New System.Windows.Forms.Label
		Me.chkDispose = New System.Windows.Forms.CheckBox
		Me.Button1 = New System.Windows.Forms.Button
		Me.Label2 = New System.Windows.Forms.Label
		Me.lblTask = New System.Windows.Forms.Label
		Me.lblTasklist = New System.Windows.Forms.Label
		Me.lblMore = New System.Windows.Forms.Label
		Me.pnlButton = New System.Windows.Forms.Panel
		Me.pnlSnooze = New System.Windows.Forms.Panel
		Me.Label3 = New System.Windows.Forms.Label
		Me.txtSnooze = New System.Windows.Forms.NumericUpDown
		Me.chkSnooze = New System.Windows.Forms.CheckBox
		Me.cbxSnooze = New System.Windows.Forms.ComboBox
		Me.pnlButton.SuspendLayout()
		Me.pnlSnooze.SuspendLayout()
		CType(Me.txtSnooze, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(39, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(37, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Task: "
		'
		'chkDispose
		'
		Me.chkDispose.AutoSize = True
		Me.chkDispose.Location = New System.Drawing.Point(12, 3)
		Me.chkDispose.Name = "chkDispose"
		Me.chkDispose.Size = New System.Drawing.Size(195, 17)
		Me.chkDispose.TabIndex = 1
		Me.chkDispose.Text = "don't notify me about this task again"
		Me.chkDispose.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(307, 57)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "&Ok"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(27, 23)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(49, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Tasklist: "
		'
		'lblTask
		'
		Me.lblTask.ForeColor = System.Drawing.Color.Red
		Me.lblTask.Location = New System.Drawing.Point(72, 6)
		Me.lblTask.Name = "lblTask"
		Me.lblTask.Size = New System.Drawing.Size(310, 17)
		Me.lblTask.TabIndex = 4
		Me.lblTask.Text = "<task goes here>"
		'
		'lblTasklist
		'
		Me.lblTasklist.ForeColor = System.Drawing.Color.Red
		Me.lblTasklist.Location = New System.Drawing.Point(72, 23)
		Me.lblTasklist.Name = "lblTasklist"
		Me.lblTasklist.Size = New System.Drawing.Size(310, 13)
		Me.lblTasklist.TabIndex = 5
		Me.lblTasklist.Text = "<tasklist goes here>"
		'
		'lblMore
		'
		Me.lblMore.Location = New System.Drawing.Point(8, 41)
		Me.lblMore.Name = "lblMore"
		Me.lblMore.Size = New System.Drawing.Size(374, 20)
		Me.lblMore.TabIndex = 6
		Me.lblMore.Text = "An email was sent to <email address>"
		'
		'pnlButton
		'
		Me.pnlButton.Controls.Add(Me.pnlSnooze)
		Me.pnlButton.Controls.Add(Me.chkDispose)
		Me.pnlButton.Location = New System.Drawing.Point(18, 64)
		Me.pnlButton.Name = "pnlButton"
		Me.pnlButton.Size = New System.Drawing.Size(364, 60)
		Me.pnlButton.TabIndex = 7
		'
		'pnlSnooze
		'
		Me.pnlSnooze.Controls.Add(Me.Label3)
		Me.pnlSnooze.Controls.Add(Me.txtSnooze)
		Me.pnlSnooze.Controls.Add(Me.chkSnooze)
		Me.pnlSnooze.Controls.Add(Me.cbxSnooze)
		Me.pnlSnooze.Location = New System.Drawing.Point(9, 25)
		Me.pnlSnooze.Name = "pnlSnooze"
		Me.pnlSnooze.Size = New System.Drawing.Size(342, 31)
		Me.pnlSnooze.TabIndex = 11
		'
		'Label3
		'
		Me.Label3.ForeColor = System.Drawing.Color.DimGray
		Me.Label3.Location = New System.Drawing.Point(189, 2)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(104, 29)
		Me.Label3.TabIndex = 15
		Me.Label3.Text = "(reset due date to now + snooze time)"
		'
		'txtSnooze
		'
		Me.txtSnooze.Enabled = False
		Me.txtSnooze.Location = New System.Drawing.Point(79, 6)
		Me.txtSnooze.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
		Me.txtSnooze.Name = "txtSnooze"
		Me.txtSnooze.Size = New System.Drawing.Size(37, 20)
		Me.txtSnooze.TabIndex = 12
		Me.txtSnooze.Value = New Decimal(New Integer() {5, 0, 0, 0})
		'
		'chkSnooze
		'
		Me.chkSnooze.AutoSize = True
		Me.chkSnooze.Location = New System.Drawing.Point(3, 7)
		Me.chkSnooze.Name = "chkSnooze"
		Me.chkSnooze.Size = New System.Drawing.Size(77, 17)
		Me.chkSnooze.TabIndex = 14
		Me.chkSnooze.Text = "Snooze for"
		Me.chkSnooze.UseVisualStyleBackColor = True
		'
		'cbxSnooze
		'
		Me.cbxSnooze.Enabled = False
		Me.cbxSnooze.FormattingEnabled = True
		Me.cbxSnooze.Items.AddRange(New Object() {"minutes", "hrs", "days"})
		Me.cbxSnooze.Location = New System.Drawing.Point(118, 5)
		Me.cbxSnooze.Name = "cbxSnooze"
		Me.cbxSnooze.Size = New System.Drawing.Size(60, 21)
		Me.cbxSnooze.TabIndex = 13
		Me.cbxSnooze.Text = "minutes"
		'
		'formTaskIsDue
		'
		Me.AcceptButton = Me.Button1
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(394, 128)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.pnlButton)
		Me.Controls.Add(Me.lblTasklist)
		Me.Controls.Add(Me.lblTask)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lblMore)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "formTaskIsDue"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Just letting you know.  Don't hit me."
		Me.pnlButton.ResumeLayout(False)
		Me.pnlButton.PerformLayout()
		Me.pnlSnooze.ResumeLayout(False)
		Me.pnlSnooze.PerformLayout()
		CType(Me.txtSnooze, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents chkDispose As System.Windows.Forms.CheckBox
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents lblTask As System.Windows.Forms.Label
	Friend WithEvents lblTasklist As System.Windows.Forms.Label
	Friend WithEvents lblMore As System.Windows.Forms.Label
	Friend WithEvents pnlButton As System.Windows.Forms.Panel
	Friend WithEvents pnlSnooze As System.Windows.Forms.Panel
	Friend WithEvents cbxSnooze As System.Windows.Forms.ComboBox
	Friend WithEvents txtSnooze As System.Windows.Forms.NumericUpDown
	Friend WithEvents chkSnooze As System.Windows.Forms.CheckBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
