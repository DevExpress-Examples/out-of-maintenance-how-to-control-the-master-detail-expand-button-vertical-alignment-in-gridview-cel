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

		Protected Overrides Sub CalcRowCellDrawInfoCore(ByVal ri As GridDataRowInfo, ByVal ci As GridColumnInfoArgs, ByVal cell As GridCellInfo, ByVal nextColumn As GridColumnInfoArgs, ByVal calcEditInfo As Boolean)
			MyBase.CalcRowCellDrawInfoCore(ri, ci, cell, nextColumn, calcEditInfo)
			If cell.CellButtonRect = Rectangle.Empty Then
				Return
			End If

			Dim view As MyGridView = TryCast(Me.View, MyGridView)
			If view Is Nothing Then
				Return
			End If

			If view.OptionsView.DetailButtonsVAlignment = VertAlignment.Top Then
				cell.CellButtonRect.Y = cell.CellValueRect.Y + CellVertIndent + CellValueVIndent
				Return
			End If

			If view.OptionsView.DetailButtonsVAlignment = VertAlignment.Bottom Then
				cell.CellButtonRect.Y = cell.CellValueRect.Bottom - cell.CellButtonRect.Height - CellVertIndent - CellValueVIndent
				Return
			End If
		End Sub
	End Class
End Namespace
