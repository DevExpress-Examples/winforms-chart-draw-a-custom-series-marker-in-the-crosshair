Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace CustomDrawCrosshairSample.Model

    Public Partial Class Order

        Public Property OrderID As Integer

        <Column("EmployeeId")>
        Public Property EmployeeId As Integer?

        <Column(TypeName:="datetime")>
        Public Property OrderDate As Date

        Public Property Freight As Decimal?

        <ForeignKey("EmployeeId")>
        Public Overridable Property Employee As Employee
    End Class
End Namespace
