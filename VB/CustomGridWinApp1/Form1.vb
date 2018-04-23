Imports System
Imports System.Windows.Forms

Namespace CustomGridWinApp1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)
			Me.employeesTableAdapter.Fill(Me.nwindDataSet.Employees)
		End Sub
	End Class
End Namespace
