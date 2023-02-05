Option Explicit On
''' <summary><para>Created on 5/8/10 by Jason S. Rushing</para></summary>
''' <remarks>Popup when task is due.  Offers disposal of alert or snooze.</remarks>
Public Class formTaskIsDue
	Private mOkToClose As Boolean

	Public ReadOnly Property AlertCanceled() As Boolean
		Get
			Return Me.chkDispose.Checked
		End Get
	End Property
	Public ReadOnly Property Snoozed() As Boolean
		Get
			Return Me.chkSnooze.Checked
		End Get
	End Property
	Public ReadOnly Property SnoozedMinutes() As Integer
		Get
			Select Case Me.cbxSnooze.SelectedIndex
				Case 0	'minutes
					Return Me.txtSnooze.Text
				Case 1	'hrs
					Return Me.txtSnooze.Text * 60
				Case 2	'days
					Return Me.txtSnooze.Text * 1440
			End Select
		End Get
	End Property

	Private Sub form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
		Dim activated As Boolean
		If activated Then Exit Sub Else activated = True
		If Me.lblMore.Text = "" Then
			Me.pnlButton.Top = Me.pnlButton.Top - 10
		End If
		Me.Height = Me.pnlButton.Top + Me.pnlButton.Height + 45
	End Sub

	Private Sub form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		If Not mOkToClose Then
			e.Cancel = True
			Me.Hide()
		End If
	End Sub

	Private Sub form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.Icon = My.Resources.MainIcon
		Me.txtSnooze.Value = 5
		Me.cbxSnooze.Text = "minutes"
	End Sub

	Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		Me.Hide()
	End Sub

	Public Overloads Sub Close()
		mOkToClose = True
		Me.Dispose()
	End Sub

	Private Sub chkSnooze_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSnooze.CheckedChanged
		Me.txtSnooze.Enabled = Me.chkSnooze.Checked
		Me.cbxSnooze.Enabled = Me.chkSnooze.Checked
		If Not Me.chkSnooze.Checked Then Me.cbxSnooze.Text = "" Else Me.cbxSnooze.Text = "minutes"
	End Sub

	Private Sub chkDispose_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDispose.CheckedChanged
		If Me.chkDispose.Checked Then Me.chkSnooze.Checked = False
	End Sub
End Class