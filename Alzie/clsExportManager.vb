Option Explicit On
Imports System.IO

''' <summary><para>Created on 8/30/13 by Jason S. Rushing</para></summary>
''' <remarks>Handle tasklist export.</remarks>
''' 
Public Class clsExportManager
    Private mExportType As ExportType
    Private mFileName As String
    Private mTaskList As clsTaskList
    Private mResult As String
    Private mOriginalFile As FileStream

    Public ReadOnly Property Result As String
        Get
            Return mResult
        End Get
    End Property
    Public Property TypeOfExport As ExportType
        Get
            Return mExportType
        End Get
        Set(ByVal value As ExportType)
            mExportType = value
        End Set
    End Property

    Public Property FileName() As String
        Get
            Return mFileName
        End Get
        Set(ByVal value As String)
            mFileName = value
        End Set
    End Property

    Public Enum ExportType
        Text
        Word
        Excel
        Printer
    End Enum

    Public Sub New(ByVal ExportType As ExportType, ByVal FileName As String, ByVal TasklistToExport As clsTaskList)
        Me.TypeOfExport = ExportType
        Me.mFileName = FileName
        If Not FileNameIsOk() Then Exit Sub
        Me.mTaskList = TasklistToExport
        mResult = DoExport()
    End Sub

    Public Sub New(ByVal ExportType As ExportType, ByVal TasklistToExport As clsTaskList)
        Me.TypeOfExport = ExportType
        Me.mTaskList = TasklistToExport
        mResult = DoExport()
    End Sub

    Public Sub New()

    End Sub

    Private Function FileNameIsOk() As Boolean
        If File.Exists(mFileName) Then
            If MessageBox.Show("Do you want to overwrite the existing file?", "Overwrite File ?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                mOriginalFile = File.Create(mFileName & "backupfromCRSSystem")
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function

    Private Function DoExport() As String
        Select Case mExportType
            Case ExportType.Text
                Return TextExport()
            Case ExportType.Word
            Case ExportType.Excel
            Case ExportType.Printer
            Case Else
                Return "improper ExportType given"
        End Select
        Return "error"
    End Function

    Private Function TextExport() As String
        Try
            Dim sOut As String = ""
            Using wrtr As New StreamWriter(mFileName, False)
                For Each Task As Task In mTaskList.TaskListList
                    If Task.Text = "" Then
                        sOut = " "
                    Else
                        If Task.Completed Then sOut = Chr(167)
                        sOut &= Space(Task.GetIndentLevel) & Task.Text
                    End If
                    wrtr.WriteLine(sOut)
                    sOut = ""
                Next
            End Using
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function


End Class
