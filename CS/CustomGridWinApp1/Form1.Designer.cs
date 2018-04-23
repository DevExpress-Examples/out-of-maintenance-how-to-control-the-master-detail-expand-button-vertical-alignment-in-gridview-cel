namespace CustomGridWinApp1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			this.myGridView2 = new CustomGridControl.MyGridView();
			this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipCountry = new DevExpress.XtraGrid.Columns.GridColumn();
			this.myGridControl1 = new CustomGridControl.MyGridControl();
			this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nwindDataSet = new CustomGridWinApp1.nwindDataSet();
			this.myGridView1 = new CustomGridControl.MyGridView();
			this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			this.employeesTableAdapter = new CustomGridWinApp1.nwindDataSetTableAdapters.EmployeesTableAdapter();
			this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ordersTableAdapter = new CustomGridWinApp1.nwindDataSetTableAdapters.OrdersTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.myGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// myGridView2
			// 
			this.myGridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderID,
            this.colOrderDate,
            this.colShippedDate,
            this.colShipName,
            this.colShipCountry});
			this.myGridView2.GridControl = this.myGridControl1;
			this.myGridView2.Name = "myGridView2";
			// 
			// colOrderID
			// 
			this.colOrderID.FieldName = "OrderID";
			this.colOrderID.Name = "colOrderID";
			this.colOrderID.Visible = true;
			this.colOrderID.VisibleIndex = 0;
			// 
			// colOrderDate
			// 
			this.colOrderDate.FieldName = "OrderDate";
			this.colOrderDate.Name = "colOrderDate";
			this.colOrderDate.Visible = true;
			this.colOrderDate.VisibleIndex = 1;
			// 
			// colShippedDate
			// 
			this.colShippedDate.FieldName = "ShippedDate";
			this.colShippedDate.Name = "colShippedDate";
			this.colShippedDate.Visible = true;
			this.colShippedDate.VisibleIndex = 2;
			// 
			// colShipName
			// 
			this.colShipName.FieldName = "ShipName";
			this.colShipName.Name = "colShipName";
			this.colShipName.Visible = true;
			this.colShipName.VisibleIndex = 3;
			// 
			// colShipCountry
			// 
			this.colShipCountry.FieldName = "ShipCountry";
			this.colShipCountry.Name = "colShipCountry";
			this.colShipCountry.Visible = true;
			this.colShipCountry.VisibleIndex = 4;
			// 
			// myGridControl1
			// 
			this.myGridControl1.DataSource = this.employeesBindingSource;
			this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			gridLevelNode1.LevelTemplate = this.myGridView2;
			gridLevelNode1.RelationName = "EmployeesOrders";
			this.myGridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.myGridControl1.Location = new System.Drawing.Point(0, 0);
			this.myGridControl1.MainView = this.myGridView1;
			this.myGridControl1.Name = "myGridControl1";
			this.myGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemMemoEdit1});
			this.myGridControl1.Size = new System.Drawing.Size(934, 411);
			this.myGridControl1.TabIndex = 0;
			this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1,
            this.myGridView2});
			// 
			// employeesBindingSource
			// 
			this.employeesBindingSource.DataMember = "Employees";
			this.employeesBindingSource.DataSource = this.nwindDataSet;
			// 
			// nwindDataSet
			// 
			this.nwindDataSet.DataSetName = "nwindDataSet";
			this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// myGridView1
			// 
			this.myGridView1.Appearance.Row.Options.UseTextOptions = true;
			this.myGridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLastName,
            this.colFirstName,
            this.colBirthDate,
            this.colCountry,
            this.colPhoto,
            this.colNotes});
			this.myGridView1.GridControl = this.myGridControl1;
			this.myGridView1.Name = "myGridView1";
			this.myGridView1.OptionsView.DetailButtonsVAlignment = DevExpress.Utils.VertAlignment.Top;
			this.myGridView1.OptionsView.RowAutoHeight = true;
			// 
			// colLastName
			// 
			this.colLastName.FieldName = "LastName";
			this.colLastName.Name = "colLastName";
			this.colLastName.Visible = true;
			this.colLastName.VisibleIndex = 0;
			this.colLastName.Width = 152;
			// 
			// colFirstName
			// 
			this.colFirstName.FieldName = "FirstName";
			this.colFirstName.Name = "colFirstName";
			this.colFirstName.Visible = true;
			this.colFirstName.VisibleIndex = 1;
			this.colFirstName.Width = 152;
			// 
			// colBirthDate
			// 
			this.colBirthDate.FieldName = "BirthDate";
			this.colBirthDate.Name = "colBirthDate";
			this.colBirthDate.Visible = true;
			this.colBirthDate.VisibleIndex = 2;
			this.colBirthDate.Width = 92;
			// 
			// colCountry
			// 
			this.colCountry.FieldName = "Country";
			this.colCountry.Name = "colCountry";
			this.colCountry.Visible = true;
			this.colCountry.VisibleIndex = 4;
			this.colCountry.Width = 134;
			// 
			// colPhoto
			// 
			this.colPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
			this.colPhoto.FieldName = "Photo";
			this.colPhoto.Name = "colPhoto";
			this.colPhoto.Visible = true;
			this.colPhoto.VisibleIndex = 3;
			this.colPhoto.Width = 204;
			// 
			// repositoryItemPictureEdit1
			// 
			this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
			// 
			// colNotes
			// 
			this.colNotes.ColumnEdit = this.repositoryItemMemoEdit1;
			this.colNotes.FieldName = "Notes";
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 5;
			this.colNotes.Width = 179;
			// 
			// repositoryItemMemoEdit1
			// 
			this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
			// 
			// employeesTableAdapter
			// 
			this.employeesTableAdapter.ClearBeforeFill = true;
			// 
			// ordersBindingSource
			// 
			this.ordersBindingSource.DataMember = "Orders";
			this.ordersBindingSource.DataSource = this.nwindDataSet;
			// 
			// ordersTableAdapter
			// 
			this.ordersTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 411);
			this.Controls.Add(this.myGridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.myGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CustomGridControl.MyGridControl myGridControl1;
		private CustomGridControl.MyGridView myGridView1;
		private nwindDataSet nwindDataSet;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private CustomGridWinApp1.nwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
		private DevExpress.XtraGrid.Columns.GridColumn colLastName;
		private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
		private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
		private DevExpress.XtraGrid.Columns.GridColumn colCountry;
		private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private System.Windows.Forms.BindingSource ordersBindingSource;
		private CustomGridWinApp1.nwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
		private CustomGridControl.MyGridView myGridView2;
		private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
		private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
		private DevExpress.XtraGrid.Columns.GridColumn colShippedDate;
		private DevExpress.XtraGrid.Columns.GridColumn colShipName;
		private DevExpress.XtraGrid.Columns.GridColumn colShipCountry;
		private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;


	}
}

