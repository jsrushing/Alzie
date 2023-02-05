<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditMultiple
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
        Me.lblBack1 = New System.Windows.Forms.Label()
        Me.grpClr = New System.Windows.Forms.GroupBox()
        Me.lblItemColor = New System.Windows.Forms.Label()
        Me.btnChangeColor = New System.Windows.Forms.Button()
        Me.grpFont = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxStyle = New System.Windows.Forms.ComboBox()
        Me.txtFontSize = New System.Windows.Forms.NumericUpDown()
        Me.cbxFonts = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.clr = New System.Windows.Forms.ColorDialog()
        Me.chkMarkComplete = New System.Windows.Forms.CheckBox()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.grpClr.SuspendLayout()
        Me.grpFont.SuspendLayout()
        CType(Me.txtFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBack1
        '
        Me.lblBack1.BackColor = System.Drawing.Color.Goldenrod
        Me.lblBack1.Location = New System.Drawing.Point(0, 0)
        Me.lblBack1.Name = "lblBack1"
        Me.lblBack1.Size = New System.Drawing.Size(356, 190)
        Me.lblBack1.TabIndex = 28
        '
        'grpClr
        '
        Me.grpClr.BackColor = System.Drawing.Color.AliceBlue
        Me.grpClr.Controls.Add(Me.lblItemColor)
        Me.grpClr.Controls.Add(Me.btnChangeColor)
        Me.grpClr.Location = New System.Drawing.Point(211, 9)
        Me.grpClr.Name = "grpClr"
        Me.grpClr.Size = New System.Drawing.Size(102, 48)
        Me.grpClr.TabIndex = 29
        Me.grpClr.TabStop = False
        Me.grpClr.Text = "Text color"
        '
        'lblItemColor
        '
        Me.lblItemColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemColor.Location = New System.Drawing.Point(70, 16)
        Me.lblItemColor.Name = "lblItemColor"
        Me.lblItemColor.Size = New System.Drawing.Size(26, 20)
        Me.lblItemColor.TabIndex = 2
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
        'grpFont
        '
        Me.grpFont.BackColor = System.Drawing.Color.AliceBlue
        Me.grpFont.Controls.Add(Me.Label5)
        Me.grpFont.Controls.Add(Me.Label1)
        Me.grpFont.Controls.Add(Me.cbxStyle)
        Me.grpFont.Controls.Add(Me.txtFontSize)
        Me.grpFont.Controls.Add(Me.cbxFonts)
        Me.grpFont.Controls.Add(Me.Label3)
        Me.grpFont.Location = New System.Drawing.Point(9, 9)
        Me.grpFont.Name = "grpFont"
        Me.grpFont.Size = New System.Drawing.Size(196, 103)
        Me.grpFont.TabIndex = 30
        Me.grpFont.TabStop = False
        Me.grpFont.Text = "Font"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Style"
        '
        'cbxStyle
        '
        Me.cbxStyle.FormattingEnabled = True
        Me.cbxStyle.Items.AddRange(New Object() {"Normal", "Bold", "Italic", "Bold Italic"})
        Me.cbxStyle.Location = New System.Drawing.Point(106, 71)
        Me.cbxStyle.Name = "cbxStyle"
        Me.cbxStyle.Size = New System.Drawing.Size(81, 21)
        Me.cbxStyle.TabIndex = 22
        Me.cbxStyle.Text = "Normal"
        '
        'txtFontSize
        '
        Me.txtFontSize.Location = New System.Drawing.Point(35, 72)
        Me.txtFontSize.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.txtFontSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.txtFontSize.Name = "txtFontSize"
        Me.txtFontSize.Size = New System.Drawing.Size(33, 20)
        Me.txtFontSize.TabIndex = 21
        Me.txtFontSize.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'cbxFonts
        '
        Me.cbxFonts.DropDownWidth = 225
        Me.cbxFonts.FormattingEnabled = True
        Me.cbxFonts.Location = New System.Drawing.Point(9, 32)
        Me.cbxFonts.Name = "cbxFonts"
        Me.cbxFonts.Size = New System.Drawing.Size(178, 21)
        Me.cbxFonts.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Size"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(180, 124)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(72, 124)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 31
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'chkMarkComplete
        '
        Me.chkMarkComplete.AutoSize = True
        Me.chkMarkComplete.BackColor = System.Drawing.Color.AliceBlue
        Me.chkMarkComplete.Location = New System.Drawing.Point(214, 76)
        Me.chkMarkComplete.Name = "chkMarkComplete"
        Me.chkMarkComplete.Size = New System.Drawing.Size(97, 17)
        Me.chkMarkComplete.TabIndex = 33
        Me.chkMarkComplete.Text = "Mark Complete"
        Me.chkMarkComplete.UseVisualStyleBackColor = False
        '
        'grp1
        '
        Me.grp1.BackColor = System.Drawing.Color.AliceBlue
        Me.grp1.Controls.Add(Me.btnOk)
        Me.grp1.Controls.Add(Me.chkMarkComplete)
        Me.grp1.Controls.Add(Me.grpClr)
        Me.grp1.Controls.Add(Me.btnCancel)
        Me.grp1.Controls.Add(Me.grpFont)
        Me.grp1.Location = New System.Drawing.Point(12, 12)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(325, 159)
        Me.grp1.TabIndex = 34
        Me.grp1.TabStop = False
        '
        'formEditMultiple
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(357, 216)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.lblBack1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formEditMultiple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "formEditMultiple"
        Me.grpClr.ResumeLayout(False)
        Me.grpFont.ResumeLayout(False)
        Me.grpFont.PerformLayout()
        CType(Me.txtFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBack1 As System.Windows.Forms.Label
    Friend WithEvents grpClr As System.Windows.Forms.GroupBox
    Friend WithEvents lblItemColor As System.Windows.Forms.Label
    Friend WithEvents btnChangeColor As System.Windows.Forms.Button
    Friend WithEvents grpFont As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxStyle As System.Windows.Forms.ComboBox
    Friend WithEvents txtFontSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxFonts As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents clr As System.Windows.Forms.ColorDialog
    Friend WithEvents chkMarkComplete As System.Windows.Forms.CheckBox
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
End Class
