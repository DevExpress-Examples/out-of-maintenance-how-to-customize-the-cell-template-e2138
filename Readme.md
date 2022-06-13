<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2138)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# 	Pivot Grid for WPF - How to Customize the Cell Template

This example demonstrates how to use the [PivotGridControl.FieldCellTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.FieldCellTemplate) property to customize the cell appearance.

The cell displays its value in a [ProgressBar](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.progressbar) control with the [Maximum](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.rangebase.maximum) value bound to the [CellElementData.RowTotalValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.CellElementData.RowTotalValue) property.

![screenshot](/images/screenshot.png)

## Files to Look At
- [MainWindow.xaml](./CS/HowToCustomizeCellTemplate/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/HowToCustomizeCellTemplate/MainWindow.xaml))
- [MainWindow.xaml.cs](./CS/HowToCustomizeCellTemplate/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/HowToCustomizeCellTemplate/MainWindow.xaml.vb))

## Documentation

- [Pivot Grid Elements that Support Templates](https://docs.devexpress.com/WPF/8400)

## More Examples

- [Pivot Grid for WPF - Customize CellTemplate with Different Colors](https://github.com/DevExpress-Examples/pivot-grid-for-wpf-customize-cell-template)
- [Pivot Grid for WPF - How to Edit a Cell with the Cell Editing Template](https://github.com/DevExpress-Examples/how-to-define-a-custom-cell-template-that-allows-performing-data-editing-t410760/tree/pollyndos-patch-1)
