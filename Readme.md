<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574516/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T333191)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Chart for WinForms - Draw a Custom Series Marker in the Crosshair

This example demonstrates how to use the [CustomDrawCrosshair](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawCrosshair?v=22.2&p=netframework) event to modify the legend markers of bar series.

![Chart](./image/Chart.png)

To access crosshair element groups, use the&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsCustomDrawCrosshairEventArgs_CrosshairElementGroupstopic">CustomDrawCrosshairEventArgs.CrosshairElementGroups</a>&nbsp;property. Elements&nbsp;are divided into several groups when crosshair labels are displayed for each pane. Use the following properties to access crosshair elements and customize them:

- [HeaderElement](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairElementGroup.HeaderElement) 
- [CrosshairElements](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairElementGroup.CrosshairElements)
- [MarkerImage](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairLabelElement.MarkerImage)

## Files to Review

* **[Form1.cs](./CS/CustomDrawCrosshairSample/Form1.cs) (VB: [Form1.vb](./VB/CustomDrawCrosshairSample/Form1.vb))**
* [Employee.cs](./CS/CustomDrawCrosshairSample/Model/Employee.cs) (VB: [Employee.vb](./VB/CustomDrawCrosshairSample/Model/Employee.vb))
* [NwindDbContext.cs](./CS/CustomDrawCrosshairSample/Model/NwindDbContext.cs) (VB: [NwindDbContext.vb](./VB/CustomDrawCrosshairSample/Model/NwindDbContext.vb))
* [Order.cs](./CS/CustomDrawCrosshairSample/Model/Order.cs) (VB: [Order.vb](./VB/CustomDrawCrosshairSample/Model/Order.vb))

## Documentation

[Tooltip and Crosshair Cursor](https://docs.devexpress.com/WindowsForms/11976/controls-and-libraries/chart-control/end-user-features/tooltip-and-crosshair-cursor?p=netframework)



