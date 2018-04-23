Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace CustomDrawCrosshairSample.Model

    Partial Public Class Employee
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")> _
        Public Sub New()
            Orders = New HashSet(Of Order)()
        End Sub

        <Key, Column("EmployeeId")> _
        Public Property EmployeeId() As Integer

        <Required, StringLength(20)> _
        Public Property LastName() As String

        <Required, StringLength(10)> _
        Public Property FirstName() As String

        <Column(TypeName := "image")> _
        Public Property Photo() As Byte()


        Public ReadOnly Property FullName() As String
            Get
                Return String.Format("{0} {1}", FirstName, LastName)
            End Get
        End Property
        Public Overridable Property Orders() As ICollection(Of Order)
    End Class
End Namespace
