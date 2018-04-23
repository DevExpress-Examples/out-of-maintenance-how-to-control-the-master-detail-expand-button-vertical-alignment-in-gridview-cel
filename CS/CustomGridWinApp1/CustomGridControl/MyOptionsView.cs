using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.Utils.Controls;
using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid.Views.Grid;

namespace CustomGridControl
{
	public class MyOptionsView : GridOptionsView
	{
		private VertAlignment detailButtonsVAlignment;

		public MyOptionsView()
		{
			this.detailButtonsVAlignment = VertAlignment.Default;
		}

		public override void Assign(BaseOptions options)
		{
			this.BeginUpdate();
			try
			{
				base.Assign(options);

				MyOptionsView optView = options as MyOptionsView;
				if ( optView == null )
					return;

				this.detailButtonsVAlignment = optView.DetailButtonsVAlignment;
			} finally
			{
				this.EndUpdate();
			}
		}

		[Description("Gets or sets the master-detail expand buttons vertical alignment."), DefaultValue(VertAlignment.Default), XtraSerializableProperty()]
		public VertAlignment DetailButtonsVAlignment
		{
			get { return detailButtonsVAlignment; }
			set
			{
				if ( detailButtonsVAlignment == value )
					return;

				VertAlignment prevValue = DetailButtonsVAlignment;
				detailButtonsVAlignment = value;
				OnChanged(new BaseOptionChangedEventArgs("DetailButtonVAlignment", prevValue, DetailButtonsVAlignment));
			}
		}
	}
}
