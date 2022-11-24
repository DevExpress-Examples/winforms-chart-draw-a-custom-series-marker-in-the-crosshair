Imports CustomDrawCrosshairSample.Model
Imports DevExpress.Drawing
Imports DevExpress.XtraCharts
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq

Namespace CustomDrawCrosshairSample

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private photoCache As Dictionary(Of String, DXImage) = New Dictionary(Of String, DXImage)()

        Private bitmapCache As Dictionary(Of String, DXBitmap) = New Dictionary(Of String, DXBitmap)()

#Region "#Constants"
        Const borderSize As Integer = 2

        Const scaledPhotoWidth As Integer = 32

        Const scaledPhotoHeight As Integer = 34

        ' Width and height of scaled photo with border.
        Const totalWidth As Integer = 36

        Const totalHeight As Integer = 38

        ' Rects required to create a custom legend series marker.
        Private Shared ReadOnly photoRect As Rectangle = New Rectangle(borderSize, borderSize, scaledPhotoWidth, scaledPhotoHeight)

        Private Shared ReadOnly totalRect As Rectangle = New Rectangle(0, 0, totalWidth, totalHeight)

#End Region
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Using context = New NwindDbContext()
                InitPhotoCache(context.Employees)
                chart.DataSource = context.Orders.ToList()
            End Using

            chart.SeriesDataMember = "Employee.FullName"
            chart.SeriesTemplate.ArgumentDataMember = "OrderDate"
            chart.SeriesTemplate.ValueDataMembers.AddRange("Freight")
            Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
            If diagram IsNot Nothing Then
                diagram.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Sum
                diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Year
            End If

            AddHandler chart.CustomDrawCrosshair, AddressOf OnCustomDrawCrosshair
        End Sub

        Private Sub InitPhotoCache(ByVal employees As IEnumerable(Of Employee))
            photoCache.Clear()
            For Each employee In employees
                Using stream As MemoryStream = New MemoryStream(employee.Photo)
                    If Not photoCache.ContainsKey(employee.FullName) Then photoCache.Add(employee.FullName, DXImage.FromStream(stream))
                End Using
            Next
        End Sub

#Region "#CustomDrawCrosshairHandler"
        Private Sub OnCustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs)
            For Each group As CrosshairElementGroup In e.CrosshairElementGroups
                If group.CrosshairElements(0) IsNot Nothing Then group.HeaderElement.Text = String.Format("Sales in {0:yyyy}", group.CrosshairElements(0).SeriesPoint.DateTimeArgument)
                For Each element As CrosshairElement In group.CrosshairElements
                    Dim image As DXBitmap
                    If Not bitmapCache.TryGetValue(element.Series.Name, image) Then
                        image = New DXBitmap(totalWidth, totalHeight)
                        Using graphics As DXGraphics = DXGraphics.FromImage(image)
                            Using brush As DXSolidBrush = New DXSolidBrush(element.LabelElement.MarkerColor)
                                graphics.FillRectangle(brush, totalRect)
                            End Using

                            Dim photo As DXImage
                            If photoCache.TryGetValue(element.Series.Name, photo) Then graphics.DrawImage(photo, photoRect)
                        End Using

                        bitmapCache.Add(element.Series.Name, image)
                    End If

                    element.LabelElement.DXMarkerImage = image
                    element.LabelElement.MarkerSize = New Size(totalWidth, totalHeight)
                Next
            Next
        End Sub
#End Region
    End Class
End Namespace
