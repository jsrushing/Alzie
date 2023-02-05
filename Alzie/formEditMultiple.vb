Option Explicit On
''' <summary><para>Created on 5/11/10 by Jason S. Rushing</para></summary>
''' <remarks>Edit font and color on multiple tasks.</remarks>
Public Class formEditMultiple
    Private mTasks As clsTaskList
    Private mSelectedTasks As List(Of Task)
    Private mCanceled As Boolean = False

    Public ReadOnly Property Canceled() As Boolean
        Get
            Return mCanceled
        End Get
    End Property
    Public WriteOnly Property SelectedTasks() As List(Of Task)
        Set(ByVal value As List(Of Task))
            mSelectedTasks = value
        End Set
    End Property
    Public WriteOnly Property Tasks() As clsTaskList
        Set(ByVal value As clsTaskList)
            mTasks = value
        End Set
    End Property

    Private Sub formEditMultiple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iRightMargin As Integer = 10
        Dim iTopMargin As Integer = 10
        grp1.Location = New Point(iRightMargin, iTopMargin)
        lblBack1.Size = New Point((iRightMargin * 2) + grp1.Width, (iTopMargin * 2) + grp1.Height)
        Me.Size = Me.lblBack1.Size
        Dim fonts As New System.Drawing.Text.InstalledFontCollection
        Dim fontFams() As FontFamily = fonts.Families
        For Each f As FontFamily In fontFams
            cbxFonts.Items.Add(f.Name)
        Next
        Dim dFntSize As Double = 0
        Dim iFntColor As Int64 = 0
        Dim sFntName As String = ""
        Dim sFntColor As String = ""
        Dim sFntStyle As String = ""
        Dim bColorsAreMixed As Boolean = False
        Dim iAllItemsAreComplete As Int16 = -2
        Dim fntTmp As Font = Nothing

        For Each t As Task In mSelectedTasks                    ' Set up controls based on common attributes of selected items.
            fntTmp = t.Font
            If dFntSize <> -1 Then
                If dFntSize = 0 Then
                    dFntSize = fntTmp.Size
                Else
                    If fntTmp.Size <> dFntSize Then dFntSize = -1
                End If
            End If
            If sFntName <> "mixed" Then
                If sFntName = "" Then
                    sFntName = fntTmp.FontFamily.Name
                Else
                    If fntTmp.FontFamily.Name <> sFntName Then sFntName = "mixed"
                End If
            End If
            If iAllItemsAreComplete <> -1 Then
                If iAllItemsAreComplete = -2 Then
                    If t.Completed Then iAllItemsAreComplete = 1
                Else
                    If t.Completed <> CBool(iAllItemsAreComplete) Then iAllItemsAreComplete = -1
                End If
            End If
            If sFntStyle <> "mixed" Then
                If sFntStyle = "" Then
                    sFntStyle = fntTmp.Style.ToString
                Else
                    If fntTmp.Style.ToString <> sFntStyle Then sFntStyle = "mixed"
                End If
            End If
            If iFntColor <> -1 Then
                If iFntColor = 0 Then
                    iFntColor = t.TextColor
                Else
                    If t.TextColor <> iFntColor Then iFntColor = -1
                End If
            End If
        Next

        If dFntSize <> -1 Then txtFontSize.Value = dFntSize.ToString
        If sFntName <> "mixed" Then cbxFonts.Text = sFntName
        If sFntStyle <> "mixed" Then
            If sFntStyle = "Regular" Then sFntStyle = "Normal"
            cbxStyle.Text = sFntStyle
        End If
        If iFntColor <> -1 Then lblItemColor.BackColor = Color.FromArgb(iFntColor)
        If iAllItemsAreComplete = -2 Then iAllItemsAreComplete = 0
        If iAllItemsAreComplete > -1 Then chkMarkComplete.Checked = CBool(iAllItemsAreComplete)

    End Sub

	Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
		Dim t As Task
		Dim fnt As Font = Font_GetCurrentSettings()
		For a As Integer = 0 To mSelectedTasks.Count - 1
			For b As Integer = 0 To mTasks.TaskListList.Count - 1
				If mTasks.TaskListList.Item(b).Equals(mSelectedTasks.Item(a)) Then
					t = mTasks.TaskListList.Item(b)
					t.Font = fnt
                    t.TextColor = Me.lblItemColor.BackColor.ToArgb
                    t.Completed = chkMarkComplete.Checked
					Exit For
				End If
			Next
		Next
		Me.Hide()
	End Sub

	Private Function Font_GetCurrentSettings() As Font
		Dim f As New Font(Me.cbxFonts.Text, Me.txtFontSize.Value)
		Dim BoldItalicStyle As System.Drawing.FontStyle = FontStyle.Italic + FontStyle.Bold
		Select Case Me.cbxStyle.Text
			Case "Normal"
				f = New Font(Me.cbxFonts.Text, Me.txtFontSize.Value)
			Case "Bold"
				f = New Font(Me.cbxFonts.Text, Me.txtFontSize.Value, FontStyle.Bold)
			Case "Italic"
				f = New Font(Me.cbxFonts.Text, Me.txtFontSize.Value, FontStyle.Italic)
			Case "Bold Italic"
				f = New Font(Me.cbxFonts.Text, Me.txtFontSize.Value, BoldItalicStyle)
		End Select
		Return f
	End Function

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		mCanceled = True
		Me.Hide()
	End Sub

	Private Sub SelectItemTextColor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeColor.Click
		With clr
			.Color = Me.lblItemColor.BackColor
			Dim rslt As DialogResult = .ShowDialog()
			If rslt = Windows.Forms.DialogResult.Cancel Then Exit Sub
			Me.lblItemColor.BackColor = .Color
		End With
	End Sub

End Class