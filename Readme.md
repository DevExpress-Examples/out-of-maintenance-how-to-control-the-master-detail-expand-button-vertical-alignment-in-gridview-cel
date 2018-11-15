<!-- default file list -->
*Files to look at*:

* [MyGridControl.cs](./CS/CustomGridWinApp1/CustomGridControl/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/CustomGridWinApp1/CustomGridControl/MyGridControl.vb))
* [MyGridView.cs](./CS/CustomGridWinApp1/CustomGridControl/MyGridView.cs) (VB: [MyGridViewInfo.vb](./VB/CustomGridWinApp1/CustomGridControl/MyGridViewInfo.vb))
* [MyGridViewInfo.cs](./CS/CustomGridWinApp1/CustomGridControl/MyGridViewInfo.cs) (VB: [MyGridViewInfo.vb](./VB/CustomGridWinApp1/CustomGridControl/MyGridViewInfo.vb))
* [MyGridViewInfoRegistrator.cs](./CS/CustomGridWinApp1/CustomGridControl/MyGridViewInfoRegistrator.cs) (VB: [MyGridViewInfoRegistrator.vb](./VB/CustomGridWinApp1/CustomGridControl/MyGridViewInfoRegistrator.vb))
* [MyOptionsView.cs](./CS/CustomGridWinApp1/CustomGridControl/MyOptionsView.cs) (VB: [MyOptionsView.vb](./VB/CustomGridWinApp1/CustomGridControl/MyOptionsView.vb))
* **[Form1.cs](./CS/CustomGridWinApp1/Form1.cs) (VB: [Form1.vb](./VB/CustomGridWinApp1/Form1.vb))**
* [Program.cs](./CS/CustomGridWinApp1/Program.cs) (VB: [Program.vb](./VB/CustomGridWinApp1/Program.vb))
<!-- default file list end -->
# How to control the master-detail expand button vertical alignment in GridView cells


<p>In this sample, we added a new property to the GridView's OptionsView property set. This new option named <strong>DetailButtonsVAlignment</strong> controls the master-detail expand button vertical alignment.<br />
Four alignments are available: Top, Bottom, Center and Default. The "Default" value here is equivalent to the "Center" value, which is used in the initial GridView by default.</p>


<h3>Description</h3>

The signature of GridViewInfo's&nbsp;CalcRowCellDrawInfoCore method was changed. Now it accepts six parameters:&nbsp;CalcRowCellDrawInfoCore(GridDataRowInfo ri, GridColumnInfoArgs ci, GridCellInfo cell, GridColumnInfoArgs nextColumn, bool calcEditInfo, GridRow nextRow)

<br/>


