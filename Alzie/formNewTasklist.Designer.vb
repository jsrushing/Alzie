<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formNewTasklist
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
		Me.cbxTLs = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.btnOk = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.SuspendLayout()
		'
		'lblBack2
		'
		Me.lblBack2.BackColor = System.Drawing.Color.AliceBlue
		Me.lblBack2.Location = New System.Drawing.Point(5, 5)
		Me.lblBack2.Name = "lblBack2"
		Me.lblBack2.Size = New System.Drawing.Size(322, 73)
		Me.lblBack2.TabIndex = 25
		'
		'lblBack1
		'
		Me.lblBack1.BackColor = System.Drawing.Color.Goldenrod
		Me.lblBack1.Location = New System.Drawing.Point(0, 0)
		Me.lblBack1.Name = "lblBack1"
		Me.lblBack1.Size = New System.Drawing.Size(332, 83)
		Me.lblBack1.TabIndex = 26
		'
		'cbxTLs
		'
		Me.cbxTLs.FormattingEnabled = True
		Me.cbxTLs.Location = New System.Drawing.Point(125, 12)
		Me.cbxTLs.Name = "cbxTLs"
		Me.cbxTLs.Size = New System.Drawing.Size(190, 21)
		Me.cbxTLs.TabIndex = 27
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.AliceBlue
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(107, 13)
		Me.Label1.TabIndex = 28
		Me.Label1.Text = "Choose New Tasklist"
		'
		'btnOk
		'
		Me.btnOk.Location = New System.Drawing.Point(60, 44)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 29
		Me.btnOk.Text = "&Ok"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(198, 44)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 30
		Me.btnCancel.Text = "&Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'formNewTasklist
		'
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(334, 98)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.cbxTLs)
		Me.Controls.Add(Me.lblBack2)
		Me.Controls.Add(Me.lblBack1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "formNewTasklist"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "formNewTasklist"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblBack2 As System.Windows.Forms.Label
	Friend WithEvents lblBack1 As System.Windows.Forms.Label
	Friend WithEvents cbxTLs As System.Windows.Forms.ComboBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnOk As System.Windows.Forms.Button
	Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
