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

        protected override GridCellInfo CalcRowCellDrawInfoCore(GridDataRowInfo ri, GridColumnInfoArgs ci, GridCellInfo cell, GridColumnInfoArgs nextColumn, bool calcEditInfo, GridRow nextRow, bool allowCache)
		{
            GridCellInfo result;
            result = base.CalcRowCellDrawInfoCore(ri, ci, cell, nextColumn, calcEditInfo, nextRow, allowCache);
			if (cell.CellButtonRect == Rectangle.Empty )
				return cell;

			MyGridView view = View as MyGridView;
			if ( view == null )
				return cell;
            

			if ( view.OptionsView.DetailButtonsVAlignment == VertAlignment.Top )
			{
				cell.CellButtonRect.Y = cell.CellValueRect.Y + CellVertIndent + CellValueVIndent;
				return cell;
			}

			if ( view.OptionsView.DetailButtonsVAlignment == VertAlignment.Bottom )
			{
				cell.CellButtonRect.Y = cell.CellValueRect.Bottom - cell.CellButtonRect.Height - CellVertIndent - CellValueVIndent;
				return cell;
			}
            return cell;
		}
	}
}
