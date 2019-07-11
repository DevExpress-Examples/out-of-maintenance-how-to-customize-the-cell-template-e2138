Imports System
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace HowToCustomizeCellTemplate
	Partial Public Class MainWindow
		Inherits Window

		Public Property OrderSourceList() As ObservableCollection(Of MyOrderRow)

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			OrderSourceList = DatabaseHelper.CreateData()
			pivotGridControl1.DataSource = OrderSourceList
			pivotGridControl1.BestFitArea = DevExpress.Xpf.PivotGrid.FieldBestFitArea.FieldHeader
			pivotGridControl1.BestFit()
		End Sub
	End Class

	Public Class RoundConverter
		Inherits MarkupExtension
		Implements IValueConverter

		#Region "IValueConverter Members"
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Return System.Convert.ToInt32(value)
		End Function
		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
		#End Region

		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
	End Class
End Namespace