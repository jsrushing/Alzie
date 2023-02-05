Option Explicit On
Imports System.Collections
Imports System.Windows.Forms

''' <summary><para>Created on 5/1/10 by Jason S. Rushing</para></summary>
''' <remarks>Class to sort form1 ListView object.</remarks>
Public Class clsListViewColumnSorter
    Implements System.Collections.IComparer

    Private ColumnToSort As Integer
    Private OrderOfSort As SortOrder
    Private ObjectCompare As CaseInsensitiveComparer

    Public Sub New()
        ' Initialize the column to '0'.
        ColumnToSort = 0

        ' Initialize the sort order to 'none'.
        OrderOfSort = SortOrder.None

        ' Initialize the CaseInsensitiveComparer object.
        ObjectCompare = New CaseInsensitiveComparer()
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Dim compareResult As Integer
        Dim listviewX As ListViewItem
        Dim listviewY As ListViewItem

        ' Cast the objects to be compared to ListViewItem objects.
        listviewX = CType(x, ListViewItem)
        listviewY = CType(y, ListViewItem)

        ' Compare the two items.
        On Error Resume Next
        If IsNumeric(listviewX.SubItems(ColumnToSort).Text) Then
            compareResult = ObjectCompare.Compare(Int(listviewX.SubItems(ColumnToSort).Text), Int(listviewY.SubItems(ColumnToSort).Text))
        ElseIf IsDate(listviewX.SubItems(ColumnToSort).Text) Then
            compareResult = ObjectCompare.Compare(CDate(listviewX.SubItems(ColumnToSort).Text), CDate(listviewY.SubItems(ColumnToSort).Text))
        Else
            compareResult = ObjectCompare.Compare(listviewX.SubItems(ColumnToSort).Text.Trim, listviewY.SubItems(ColumnToSort).Text.Trim)
        End If
        If Err.Number <> 0 Then compareResult = 0
        On Error GoTo 0

        ' Calculate the correct return value based on the object 
        ' comparison.
        If (OrderOfSort = SortOrder.Ascending) Then
            ' Ascending sort is selected, return typical result of 
            ' compare operation.
            Return compareResult
        ElseIf (OrderOfSort = SortOrder.Descending) Then
            ' Descending sort is selected, return negative result of 
            ' compare operation.
            Return (-compareResult)
        Else
            ' Return '0' to indicate that they are equal.
            Return 0
        End If
    End Function

    Public Property SortColumn() As Integer
        Set(ByVal Value As Integer)
            ColumnToSort = Value
        End Set

        Get
            Return ColumnToSort
        End Get
    End Property

    Public Property Order() As SortOrder
        Set(ByVal Value As SortOrder)
            OrderOfSort = Value
        End Set

        Get
            Return OrderOfSort
        End Get
    End Property
End Class

