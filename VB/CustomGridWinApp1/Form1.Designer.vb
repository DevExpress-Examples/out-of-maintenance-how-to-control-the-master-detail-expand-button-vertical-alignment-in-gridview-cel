Namespace CustomGridWinApp1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
            Me.myGridView2 = New CustomGridControl.MyGridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShippedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.myGridControl1 = New CustomGridControl.MyGridControl()
            Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New CustomGridWinApp1.nwindDataSet()
            Me.myGridView1 = New CustomGridControl.MyGridView()
            Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.employeesTableAdapter = New CustomGridWinApp1.nwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ordersTableAdapter = New CustomGridWinApp1.nwindDataSetTableAdapters.OrdersTableAdapter()
            DirectCast(Me.myGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myGridView2
            ' 
            Me.myGridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colOrderDate, Me.colShippedDate, Me.colShipName, Me.colShipCountry})
            Me.myGridView2.GridControl = Me.myGridControl1
            Me.myGridView2.Name = "myGridView2"
            ' 
            ' colOrderID
            ' 
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.Visible = True
            Me.colOrderID.VisibleIndex = 0
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 1
            ' 
            ' colShippedDate
            ' 
            Me.colShippedDate.FieldName = "ShippedDate"
            Me.colShippedDate.Name = "colShippedDate"
            Me.colShippedDate.Visible = True
            Me.colShippedDate.VisibleIndex = 2
            ' 
            ' colShipName
            ' 
            Me.colShipName.FieldName = "ShipName"
            Me.colShipName.Name = "colShipName"
            Me.colShipName.Visible = True
            Me.colShipName.VisibleIndex = 3
            ' 
            ' colShipCountry
            ' 
            Me.colShipCountry.FieldName = "ShipCountry"
            Me.colShipCountry.Name = "colShipCountry"
            Me.colShipCountry.Visible = True
            Me.colShipCountry.VisibleIndex = 4
            ' 
            ' myGridControl1
            ' 
            Me.myGridControl1.DataSource = Me.employeesBindingSource
            Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            gridLevelNode1.LevelTemplate = Me.myGridView2
            gridLevelNode1.RelationName = "EmployeesOrders"
            Me.myGridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.myGridControl1.MainView = Me.myGridView1
            Me.myGridControl1.Name = "myGridControl1"
            Me.myGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemMemoEdit1})
            Me.myGridControl1.Size = New System.Drawing.Size(934, 411)
            Me.myGridControl1.TabIndex = 0
            Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1, Me.myGridView2})
            ' 
            ' employeesBindingSource
            ' 
            Me.employeesBindingSource.DataMember = "Employees"
            Me.employeesBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' myGridView1
            ' 
            Me.myGridView1.Appearance.Row.Options.UseTextOptions = True
            Me.myGridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colLastName, Me.colFirstName, Me.colBirthDate, Me.colCountry, Me.colPhoto, Me.colNotes})
            Me.myGridView1.GridControl = Me.myGridControl1
            Me.myGridView1.Name = "myGridView1"
            Me.myGridView1.OptionsView.DetailButtonsVAlignment = DevExpress.Utils.VertAlignment.Top
            Me.myGridView1.OptionsView.RowAutoHeight = True
            ' 
            ' colLastName
            ' 
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.Visible = True
            Me.colLastName.VisibleIndex = 0
            Me.colLastName.Width = 152
            ' 
            ' colFirstName
            ' 
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.Visible = True
            Me.colFirstName.VisibleIndex = 1
            Me.colFirstName.Width = 152
            ' 
            ' colBirthDate
            ' 
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.Name = "colBirthDate"
            Me.colBirthDate.Visible = True
            Me.colBirthDate.VisibleIndex = 2
            Me.colBirthDate.Width = 92
            ' 
            ' colCountry
            ' 
            Me.colCountry.FieldName = "Country"
            Me.colCountry.Name = "colCountry"
            Me.colCountry.Visible = True
            Me.colCountry.VisibleIndex = 4
            Me.colCountry.Width = 134
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.Visible = True
            Me.colPhoto.VisibleIndex = 3
            Me.colPhoto.Width = 204
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            ' 
            ' colNotes
            ' 
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 5
            Me.colNotes.Width = 179
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' employeesTableAdapter
            ' 
            Me.employeesTableAdapter.ClearBeforeFill = True
            ' 
            ' ordersBindingSource
            ' 
            Me.ordersBindingSource.DataMember = "Orders"
            Me.ordersBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' ordersTableAdapter
            ' 
            Me.ordersTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(934, 411)
            Me.Controls.Add(Me.myGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.myGridView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private myGridControl1 As CustomGridControl.MyGridControl
        Private myGridView1 As CustomGridControl.MyGridView
        Private nwindDataSet As nwindDataSet
        Private employeesBindingSource As System.Windows.Forms.BindingSource
        Private employeesTableAdapter As CustomGridWinApp1.nwindDataSetTableAdapters.EmployeesTableAdapter
        Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
        Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
        Private colBirthDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
        Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn
        Private colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Private ordersBindingSource As System.Windows.Forms.BindingSource
        Private ordersTableAdapter As CustomGridWinApp1.nwindDataSetTableAdapters.OrdersTableAdapter
        Private myGridView2 As CustomGridControl.MyGridView
        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colShippedDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colShipName As DevExpress.XtraGrid.Columns.GridColumn
        Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit


    End Class
End Namespace

