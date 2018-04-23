Imports System.ComponentModel
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace CustomGridControl
	Public Class MyGridView
		Inherits GridView

		Public Sub New()
			Me.New(Nothing)
		End Sub

		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub

		Protected Overrides Function CreateOptionsView() As ColumnViewOptionsView
			Return New MyOptionsView()
		End Function

		<Description("Provides access to the View's display options."), Category("Options"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), XtraSerializableProperty(XtraSerializationVisibility.Content, XtraSerializationFlags.DefaultValue), XtraSerializablePropertyId(LayoutIdOptionsView)>
		Public Shadows ReadOnly Property OptionsView() As MyOptionsView
			Get
				Return TryCast(MyBase.OptionsView, MyOptionsView)
			End Get
		End Property

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property
	End Class
End Namespace