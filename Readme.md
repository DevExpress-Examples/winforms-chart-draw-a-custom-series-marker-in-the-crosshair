# How to: draw a custom series marker in the crosshair


This example demonstrates one of possible ways to use the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraChartsChartControl_CustomDrawCrosshairtopic">CustomDrawCrosshair</a> event. In this sample the event is used to modify the legend markers of bar series.


<h3>Description</h3>

To access crosshair element groups, use the&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsCustomDrawCrosshairEventArgs_CrosshairElementGroupstopic">CustomDrawCrosshairEventArgs.CrosshairElementGroups</a>&nbsp;property. Elements&nbsp;are separated into several groups when crosshair labels are displayed for each pane.<br>For each group, it is possible to customize the header using the&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsCrosshairElementGroup_HeaderElementtopic">CrosshairElementGroup.HeaderElement</a>&nbsp;property and elements representing series using the&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsCrosshairElementGroup_CrosshairElementstopic">CrosshairElementGroup.CrosshairElements</a>&nbsp;property.<br>F?or each element representing a series, you can customize its label representation using the&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsCrosshairElement_LabelElementtopic">CrosshairElement.LabelElement</a>&nbsp;property and axis label using the&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsCrosshairElement_AxisLabelElementtopic">CrosshairElement.AxisLabelElement</a>&nbsp;property.<br>For example, to modify the legend marker image, use the&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsCrosshairLabelElement_MarkerImagetopic">CrosshairLabelElement.MarkerImage</a>&nbsp;property.

<br/>


