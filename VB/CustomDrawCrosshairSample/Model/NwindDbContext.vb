Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema

Namespace CustomDrawCrosshairSample.Model

    Public Partial Class NwindDbContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("name=NwindDbContext")
        End Sub

        Public Overridable Property Employees As DbSet(Of Employee)

        Public Overridable Property Orders As DbSet(Of Order)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        End Sub
    End Class
End Namespace
