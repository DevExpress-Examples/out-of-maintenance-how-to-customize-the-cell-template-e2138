<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/HowToCustomizeCellTemplate/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/HowToCustomizeCellTemplate/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/HowToCustomizeCellTemplate/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/HowToCustomizeCellTemplate/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Customize the Cell Template


This example demonstrates how to use the [PivotGridControl.FieldCellTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.FieldCellTemplate) property to customize the cell appearance.

The cell displays its value in a [ProgressBar](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.progressbar) control with the [Maximum](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.rangebase.maximum) value bound to the [CellElementData.RowTotalValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.CellElementData.RowTotalValue) property.



![screenshot](/images/screenshot.png)

See also:

* [Pivot Grid Elements that Support Templates](https://docs.devexpress.com/WPF/8400)
