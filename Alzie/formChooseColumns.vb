Option Explicit On
Public Class formChooseColumns
    Private c As New Collection
    Private mFormDirty As Boolean

    Public ReadOnly Property FormIsDirty() As Boolean
        Get
            Return mFormDirty
        End Get
    End Property

    Public Sub SetChkBxText()
        Dim chkBx As CheckBox
        c.Add(Me.chkCol0)
        c.Add(Me.chkCol1)
        c.Add(Me.chkCol2)
        c.Add(Me.chkCol3)
        c.Add(Me.chkCol4)
        c.Add(Me.chkCol5)
        For a As Integer = 1 To c.Count
            chkBx = c.Item(a)
            chkBx.Text = Form1.lstVu.Columns(a - 1).Tag
            If chkBx.Text = "Task" Then chkBx.Checked = True : chkBx.Enabled = False
        Next
        With My.Settings
            Me.chkCol0.Checked = .Col0_Show
            Me.chkCol1.Checked = .Col1_Show
            Me.chkCol2.Checked = .Col3_Show
            Me.chkCol3.Checked = .Col3_Show
            Me.chkCol4.Checked = .Col4_Show
            Me.chkCol5.Checked = .Col5_Show
        End With
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        WriteSettings()
        Me.Hide()
    End Sub

    Private Sub formChooseColumns_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        mFormDirty = False
    End Sub

    Private Sub formChooseColumns_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        WriteSettings()
    End Sub

    Private Sub formChooseColumns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim maxWidth As Integer = 0
        Dim cB As CheckBox
        For a As Integer = 1 To c.Count
            cB = c.Item(a)
            If cB.Width > maxWidth Then maxWidth = cB.Width
        Next
        Me.Width = maxWidth + 20
        With lblClose
            .Location = New Point(Me.Width - .Width - 3, 3)
        End With
        Label2.Location = New Point(0, 0)
        Label2.Size = Me.Size
    End Sub

    Private Sub WriteSettings()
        If Not mFormDirty Then Exit Sub
        With My.Settings
            If Not Me.chkCol0.Checked Then .Col0_Show = False Else .Col0_Show = True
            If Not Me.chkCol1.Checked Then .Col1_Show = False Else .Col1_Show = True
            If Not Me.chkCol2.Checked Then .Col2_Show = False Else .Col2_Show = True
            If Not Me.chkCol3.Checked Then .Col3_Show = False Else .Col3_Show = True
            If Not Me.chkCol4.Checked Then .Col4_Show = False Else .Col4_Show = True
            If Not Me.chkCol5.Checked Then .Col5_Show = False Else .Col5_Show = True
        End With
    End Sub

    Private Sub SetFormDirtyOnCheckboxCheckChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
     chkCol0.CheckedChanged, chkCol1.CheckedChanged, chkCol2.CheckedChanged, _
     chkCol3.CheckedChanged, chkCol4.CheckedChanged, chkCol5.CheckedChanged
        mFormDirty = True
    End Sub
End Class