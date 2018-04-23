using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace CustomGridControl
{
	public class MyGridControl : GridControl
	{
		protected override BaseView CreateDefaultView()
		{
			return CreateView("MyGridView");
		}
		protected override void RegisterAvailableViewsCore(InfoCollection collection)
		{
			base.RegisterAvailableViewsCore(collection);
			collection.Add(new MyGridViewInfoRegistrator());
		}
	}
}
