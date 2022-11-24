Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace CustomDrawCrosshairSample.Model

    Public Partial Class Employee

        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")>
        Public Sub New()
            Orders = New HashSet(Of Order)()
        End Sub

        <Key>
        <Column("EmployeeId")>
        Public Property EmployeeId As Integer

        <Required>
        <StringLength(20)>
        Public Property LastName As String

        <Required>
        <StringLength(10)>
        Public Property FirstName As String

        <Column(TypeName:="image")>
        Public Property Photo As Byte()

        Public ReadOnly Property FullName As String
            Get
                Return String.Format("{0} {1}", FirstName, LastName)
            End Get
        End Property

        Public Overridable Property Orders As ICollection(Of Order)
    End Class
End Namespace
