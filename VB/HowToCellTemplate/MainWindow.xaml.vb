Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports HowToBindToMDB.NwindDataSetTableAdapters
Imports System.Windows.Markup
Imports System.Windows.Data
Imports System
Imports System.Windows.Media

Namespace HowToBindToMDB
    Partial Public Class MainWindow
        Inherits Window
        Private salesPersonDataTable As New NwindDataSet.SalesPersonDataTable()
        Private salesPersonDataAdapter As New SalesPersonTableAdapter()

        Public Sub New()
            InitializeComponent()
            pivotGridControl1.DataSource = salesPersonDataTable
        End Sub 

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
        End Sub 
    End Class 

    Public Class RoundConverter
        Inherits MarkupExtension
        Implements IValueConverter
        #Region "IValueConverter Members" 
        Public Function Convert(ByVal value As Object, _
								ByVal targetType As Type, _
								ByVal parameter As Object, _
								ByVal culture As System.Globalization.CultureInfo) _
								As Object Implements IValueConverter.Convert
            Return System.Convert.ToInt32(value)
        End Function 
        Public Function ConvertBack(ByVal value As Object, _
								    ByVal targetType As Type, _
									ByVal parameter As Object, _
									ByVal culture As System.Globalization.CultureInfo) _
									As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function 
        #End Region

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object 
            Return Me 
        End Function 
    End Class 
End Namespace 
