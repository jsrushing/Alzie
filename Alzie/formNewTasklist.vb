Option Explicit On
''' <summary><para>Created on 5/10/10 by Jason S. Rushing</para></summary>
''' <remarks>Move tasks to a different tasklist.</remarks>
Public Class formNewTasklist

	Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
		Me.Hide()
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		Me.cbxTLs.Text = ""
		Me.Hide()
	End Sub

	Private Sub formNewTasklist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.Size = Me.lblBack1.Size
	End Sub
End Class