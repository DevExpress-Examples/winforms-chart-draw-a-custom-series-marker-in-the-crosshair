Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace CustomDrawCrosshairSample.Model

    Partial Public Class Order
        Public Property OrderID() As Integer

        <Column("EmployeeId")> _
        Public Property EmployeeId() As Integer?

        <Column(TypeName := "datetime")> _
        Public Property OrderDate() As Date

        Public Property Freight() As Decimal?

        <ForeignKey("EmployeeId")> _
        Public Overridable Property Employee() As Employee
    End Class
End Namespace
