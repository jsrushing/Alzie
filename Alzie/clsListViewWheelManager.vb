Option Explicit On
''' <summary><para>Created on 5/23/10 by Jason S. Rushing</para></summary>
''' <remarks>Manage mouse wheel events for ListView control.</remarks>
Public Class clsListViewWheelManager
    Private mListView As ListView

    Public Sub New()

    End Sub

    Public Sub New(ByVal ListViewToManage As ListView)
        mListView = ListViewToManage
    End Sub

    Public Sub RespondToWheel(ByVal wheelDelta As Integer)
        Try
            Dim curTopIndex As Integer = GetVisibleCounts(0)
            Dim visibleItems As Integer = GetVisibleCounts(1)
            Dim delta As Integer = wheelDelta / 120
            If wheelDelta > 0 Then _
              curTopIndex -= delta Else _
              curTopIndex += visibleItems - delta + 1
            If curTopIndex < 0 Then curTopIndex = 0
            If curTopIndex + 3 > mListView.Items.Count Then curTopIndex = mListView.Items.Count - 1
            mListView.EnsureVisible(curTopIndex)
        Catch ex As Exception
        End Try
    End Sub

    Public Function GetVisibleCounts() As Integer()
        With mListView
            'from http://stackoverflow.com/questions/372011/how-do-i-get-the-start-index-and-number-of-visible-items-in-a-listview
            Dim lstVu1 As ListViewItem = .GetItemAt(mListView.ClientRectangle.X + 6, .ClientRectangle.Y + 6)
            Dim lstVu2 As ListViewItem = mListView.GetItemAt(.ClientRectangle.X + 6, .ClientRectangle.Bottom - 5)
            Dim startIndex As Integer = .Items.IndexOf(lstVu1)
            Dim endIndex As Integer = .Items.IndexOf(lstVu2)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If endIndex < 0 Then endIndex = .Items.Count
            Dim visItems As Integer = endIndex - startIndex
            Dim i() As Integer = {startIndex, visItems}
            Return i
        End With
    End Function

End Class