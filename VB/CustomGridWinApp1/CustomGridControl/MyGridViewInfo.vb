Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace CustomGridControl
	Public Class MyGridViewInfo
		Inherits GridViewInfo

		Public Sub New(ByVal gridView As GridView)
			MyBase.New(gridView)
		End Sub

		Protected Overrides Function CalcRowCellDrawInfoCore(ByVal ri As GridDataRowInfo, ByVal ci As GridColumnInfoArgs, ByVal cell As GridCellInfo, ByVal nextColumn As GridColumnInfoArgs, ByVal calcEditInfo As Boolean, ByVal nextRow As GridRow, ByVal allowCache As Boolean) As GridCellInfo
			Dim result As GridCellInfo
			result = MyBase.CalcRowCellDrawInfoCore(ri, ci, cell, nextColumn, calcEditInfo, nextRow, allowCache)
			If result.CellButtonRect = Rectangle.Empty Then
				Return result
			End If

            Dim aView As MyGridView = TryCast(View, MyGridView)
            If aView Is Nothing Then
                Return result
            End If


            If aView.OptionsView.DetailButtonsVAlignment = VertAlignment.Top Then
                result.CellButtonRect.Y = result.CellValueRect.Y + CellVertIndent + CellValueVIndent
                Return result
            End If

            If aView.OptionsView.DetailButtonsVAlignment = VertAlignment.Bottom Then
                result.CellButtonRect.Y = result.CellValueRect.Bottom - result.CellButtonRect.Height - CellVertIndent - CellValueVIndent
                Return result
            End If
            Return result
		End Function
	End Class
End Namespace
