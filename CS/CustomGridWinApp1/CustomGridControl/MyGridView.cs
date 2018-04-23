using System.ComponentModel;
using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace CustomGridControl
{
	public class MyGridView : GridView
	{
		public MyGridView()
			: this(null)
		{
		}

		public MyGridView(GridControl grid)
			: base(grid)
		{
		}

		protected override ColumnViewOptionsView CreateOptionsView()
		{
			return new MyOptionsView();
		}

		[Description("Provides access to the View's display options."), Category("Options"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[XtraSerializableProperty(XtraSerializationVisibility.Content, XtraSerializationFlags.DefaultValue), XtraSerializablePropertyId(LayoutIdOptionsView)]
		public new MyOptionsView OptionsView
		{
			get { return base.OptionsView as MyOptionsView; }
		}

		protected override string ViewName
		{
			get
			{
				return "MyGridView";
			}
		}
	}
}