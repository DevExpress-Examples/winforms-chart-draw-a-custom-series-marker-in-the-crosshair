Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace CustomDrawCrosshairSample.Model

	Partial Public Class Order
		Public Property OrderID() As Integer

		<Column("EmployeeId")>
		Public Property EmployeeId() As Integer?

		<Column(TypeName := "datetime")>
		Public Property OrderDate() As DateTime

		Public Property Freight() As Decimal?

		<ForeignKey("EmployeeId")>
		Public Overridable Property Employee() As Employee
	End Class
End Namespace
