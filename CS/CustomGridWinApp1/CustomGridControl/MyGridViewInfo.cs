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
			if (result.CellButtonRect == Rectangle.Empty )
				return result;

			MyGridView view = View as MyGridView;
			if ( view == null )
				return result;
            

			if ( view.OptionsView.DetailButtonsVAlignment == VertAlignment.Top )
			{
				result.CellButtonRect.Y = result.CellValueRect.Y + CellVertIndent + CellValueVIndent;
				return result;
			}

			if ( view.OptionsView.DetailButtonsVAlignment == VertAlignment.Bottom )
			{
				result.CellButtonRect.Y = result.CellValueRect.Bottom - result.CellButtonRect.Height - CellVertIndent - CellValueVIndent;
				return result;
			}
            return result;
		}
	}
}
