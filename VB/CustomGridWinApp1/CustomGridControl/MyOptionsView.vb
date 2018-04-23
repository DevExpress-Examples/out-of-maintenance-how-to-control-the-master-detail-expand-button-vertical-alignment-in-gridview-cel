Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.Utils.Controls
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraGrid.Views.Grid

Namespace CustomGridControl
	Public Class MyOptionsView
		Inherits GridOptionsView
		Private detailButtonsVAlignment_Renamed As VertAlignment

		Public Sub New()
			Me.detailButtonsVAlignment_Renamed = VertAlignment.Default
		End Sub

		Public Overrides Sub Assign(ByVal options As BaseOptions)
			Me.BeginUpdate()
			Try
				MyBase.Assign(options)

				Dim optView As MyOptionsView = TryCast(options, MyOptionsView)
				If optView Is Nothing Then
					Return
				End If

				Me.detailButtonsVAlignment_Renamed = optView.DetailButtonsVAlignment
			Finally
				Me.EndUpdate()
			End Try
		End Sub

		<Description("Gets or sets the master-detail expand buttons vertical alignment."), DefaultValue(VertAlignment.Default), XtraSerializableProperty()> _
		Public Property DetailButtonsVAlignment() As VertAlignment
			Get
				Return detailButtonsVAlignment_Renamed
			End Get
			Set(ByVal value As VertAlignment)
				If detailButtonsVAlignment_Renamed = value Then
					Return
				End If

				Dim prevValue As VertAlignment = DetailButtonsVAlignment
				detailButtonsVAlignment_Renamed = value
				OnChanged(New BaseOptionChangedEventArgs("DetailButtonVAlignment", prevValue, DetailButtonsVAlignment))
			End Set
		End Property
	End Class
End Namespace
