Option Explicit On
''' <summary><para>Created on 5/9/10 by Jason S. Rushing</para></summary>
''' <remarks>Settings options.  Not implemented as of 5/11/10.</remarks>
Public Class formSettings

	Private Sub formSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.Size = Me.lblBack1.Size
		Me.lblBack2.BackColor = Form1.lstVu.BackColor
		Me.lblBGColor.BackColor = Me.lblBack2.BackColor
		Me.chkUseGrid.Checked = My.Settings.ShowGrid
	End Sub

	Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWeekday.CheckedChanged
		Me.optWeekdayLong.Enabled = Me.chkWeekday.Checked
		Me.optWeekdayShort.Enabled = Me.chkWeekday.Checked
		Me.optWeekdayLong.Checked = False
		Me.optWeekdayShort.Checked = False
		If Me.optWeekdayShort.Enabled Then Me.optWeekdayShort.Checked = True
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub
End Class