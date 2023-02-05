Option Explicit On
''' <summary><para>Created on 5/5/10 by Jason S. Rushing</para></summary>
''' <remarks>Consolidation of methods for Form1 ListView control (task list display).</remarks>
Public Class clsListViewManager
    Private lstVu As ListView
    Private mHeaderLabels As List(Of Label)
    Private mColumnsWidthsAreSet As Boolean

    Public Property ColumnsWidthsAreSet() As Boolean
        Set(ByVal value As Boolean)
            mColumnsWidthsAreSet = value
        End Set
        Get
            Return mColumnsWidthsAreSet
        End Get
    End Property
    Public ReadOnly Property ListView() As ListView
        Get
            Return lstVu
        End Get
    End Property
    Public WriteOnly Property HeaderLabelCollection() As List(Of Label)
        Set(ByVal value As List(Of Label))
            mHeaderLabels = value
            ConfigureHeaderLabels()
        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(ByVal ListViewControl As ListView)
        Me.lstVu = ListViewControl
    End Sub

    Public Sub ColumnWidthChanged()
        If lstVu.Columns(0).Width <> 0 Then
            If lstVu.Columns(0).Width <> My.Settings.Col0_Width Then
                My.Settings.Col0_Width = lstVu.Columns(0).Width
            End If
        End If
        If lstVu.Columns(1).Width <> 0 Then
            If lstVu.Columns(1).Width <> My.Settings.Col1_Width Then
                My.Settings.Col1_Width = lstVu.Columns(1).Width
            End If
        End If
        If lstVu.Columns(2).Width <> 0 Then
            If lstVu.Columns(2).Width <> My.Settings.Col2_Width Then
                My.Settings.Col2_Width = lstVu.Columns(2).Width
            End If
        End If
        If lstVu.Columns(3).Width <> 0 Then
            If lstVu.Columns(3).Width <> My.Settings.Col3_Width Then
                My.Settings.Col3_Width = lstVu.Columns(3).Width
            End If
        End If
        If lstVu.Columns(4).Width <> 0 Then
            If lstVu.Columns(4).Width <> My.Settings.Col4_Width Then
                My.Settings.Col4_Width = lstVu.Columns(4).Width
            End If
        End If
        If lstVu.Columns(5).Width <> 0 Then
            If lstVu.Columns(5).Width <> My.Settings.Col5_Width Then
                My.Settings.Col5_Width = lstVu.Columns(5).Width
            End If
        End If
        RepositionColumns()
        RepositionHeaderLabels()
    End Sub

    Private Sub ConfigureHeaderLabels()
        With mHeaderLabels
            For a As Integer = 0 To .Count - 1
                .Item(a).Text = lstVu.Columns(a).Tag
                lstVu.Columns(a).Text = ""
                '.Item(a).Visible = False
            Next
        End With
    End Sub

    Public Sub ConfigureItemCompleteMenu(ByVal TaskListWithItems As clsTaskList, ByVal MenuToModify As ToolStripMenuItem, ByVal e As System.Windows.Forms.MouseEventArgs)

        Dim multiSelectCorrect As Integer = 0

        If lstVu.SelectedIndices.Count < 2 Then
            Dim p As New Point(lstVu.SmallImageList.ImageSize)
            Dim itm As Integer = Int((e.Y / p.Y)) - 1
            If itm <= 0 Then itm = 1
            If itm > lstVu.Items.Count Then Exit Sub
            lstVu.SelectedIndices.Clear()
            lstVu.Items(itm).Selected = True
            multiSelectCorrect = -1
        End If

        Dim showMnuComplete As Boolean = True
        Dim itemIsComplete As Boolean = False

        With TaskListWithItems
            For a As Integer = 0 To lstVu.SelectedIndices.Count - 1
                Select Case a
                    Case 0
                        If .TaskListList.Item(lstVu.SelectedItems(a).Index + multiSelectCorrect).Completed Then _
                         itemIsComplete = True Else _
                          itemIsComplete = False
                    Case Else
                        If .TaskListList.Item(lstVu.SelectedItems(a).Index + multiSelectCorrect).Completed <> itemIsComplete Then
                            showMnuComplete = False
                            Exit For
                        End If
                End Select
            Next
        End With

        With MenuToModify
            If showMnuComplete Then
                .Visible = True
                If itemIsComplete Then
                    .Text = "Mark Not &Complete"
                Else
                    .Text = "Mark &Complete"
                End If
            Else
                .Visible = False
            End If
        End With
    End Sub

    Private Function GetWidthOfColumnDisplayedAt(ByVal DisplayIndex As Integer) As Integer
        With lstVu
            For a As Integer = 0 To .Columns.Count - 1
                If .Columns(a).DisplayIndex = DisplayIndex Then Return .Columns(a).Width
            Next
        End With
        Return "no name found"
    End Function

    Public Sub RepositionColumns()
        If mColumnsWidthsAreSet Then
            mColumnsWidthsAreSet = False
            Exit Sub
        End If
        With lstVu
            Dim i As Integer = 0
            For a As Integer = 0 To .Columns.Count - 1
                If mHeaderLabels.Item(a).Text <> "Task" Then i += .Columns(a).Width
            Next
            i += 10
            If .Columns(2).Width = .Width - i Then
                RepositionHeaderLabels()
                mColumnsWidthsAreSet = True
            Else
                .Columns(2).Width = .Width - i
            End If
        End With
    End Sub

    Public Sub RepositionHeaderLabels()
        Dim colLeft As Integer = 0
        Dim b As Integer = 0
        With lstVu.Columns
            For a As Integer = 0 To .Count - 1

                If .Item(a).Width = 0 Then
                    mHeaderLabels.Item(a).Visible = False
                Else
                    mHeaderLabels.Item(a).Visible = True

                    For b = 0 To .Item(a).DisplayIndex - 1
                        colLeft += GetWidthOfColumnDisplayedAt(b)
                    Next

                    mHeaderLabels.Item(a).Location = New Point(colLeft + 10, lstVu.Top + 5)

                    If mHeaderLabels.Item(a).Width > GetWidthOfColumnDisplayedAt(b) Then _
                      mHeaderLabels.Item(a).Location = New Point(colLeft, lstVu.Top + 5)

                    colLeft = 0
                End If


            Next
        End With
    End Sub

    Public Sub ShowHideColumns()
        Dim w As Integer
        With My.Settings
            For a As Integer = 0 To lstVu.Columns.Count - 1
                Select Case a
                    Case 0
                        If .Col0_Show Then w = .Col0_Width Else w = 0
                    Case 1
                        If .Col1_Show Then w = .Col1_Width Else w = 0
                    Case 2
                        If .Col2_Show Then w = .Col2_Width Else w = 0
                    Case 3
                        If .Col3_Show Then w = .Col3_Width Else w = 0
                    Case 4
                        If .Col4_Show Then w = .Col4_Width Else w = 0
                    Case 5
                        If .Col5_Show Then w = .Col5_Width Else w = 0
                End Select
                lstVu.Columns(a).Width = w
            Next
            If .Col0_Show Then lstVu.Columns(0).Width = .Col0_Width Else lstVu.Columns(0).Width = 0
        End With
        RepositionColumns()
    End Sub
End Class
