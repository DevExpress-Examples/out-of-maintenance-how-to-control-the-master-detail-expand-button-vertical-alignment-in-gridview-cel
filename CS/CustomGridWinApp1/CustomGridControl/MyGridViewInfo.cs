using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace CustomGridControl
{
	public class MyGridViewInfo : GridViewInfo
	{
		public MyGridViewInfo(GridView gridView) :
			base(gridView)
		{
		}

		protected override void CalcRowCellDrawInfoCore(GridDataRowInfo ri, GridColumnInfoArgs ci, GridCellInfo cell, GridColumnInfoArgs nextColumn, bool calcEditInfo)
		{
			base.CalcRowCellDrawInfoCore(ri, ci, cell, nextColumn, calcEditInfo);
			if ( cell.CellButtonRect == Rectangle.Empty )
				return;

			MyGridView view = View as MyGridView;
			if ( view == null )
				return;

			if ( view.OptionsView.DetailButtonsVAlignment == VertAlignment.Top )
			{
				cell.CellButtonRect.Y = cell.CellValueRect.Y + CellVertIndent + CellValueVIndent;
				return;
			}

			if ( view.OptionsView.DetailButtonsVAlignment == VertAlignment.Bottom )
			{
				cell.CellButtonRect.Y = cell.CellValueRect.Bottom - cell.CellButtonRect.Height - CellVertIndent - CellValueVIndent;
				return;
			}
		}
	}
}
