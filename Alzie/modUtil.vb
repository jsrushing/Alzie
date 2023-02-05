Module modUtil

	Public Sub WriteColumnSettings(ByVal ColumnNumber As Integer, ByVal ColumnWidth As Integer)
		Select Case ColumnNumber
			Case 0
				If My.Settings.Col0_Show Then _
				 My.Settings.Col0_Width = ColumnWidth
			Case 1
				If My.Settings.Col1_Show Then _
				 My.Settings.Col1_Width = ColumnWidth
			Case 2
				If My.Settings.Col2_Show Then _
				 My.Settings.Col2_Width = ColumnWidth
			Case 3
				If My.Settings.Col3_Show Then _
				  My.Settings.Col3_Width = ColumnWidth
			Case 4
				If My.Settings.Col4_Show Then _
				My.Settings.Col4_Width = ColumnWidth
			Case 5
				If My.Settings.Col5_Show Then _
				My.Settings.Col5_Width = ColumnWidth
		End Select
	End Sub

End Module
