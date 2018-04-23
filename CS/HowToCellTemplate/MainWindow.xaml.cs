using System.Data;
using System.Data.OleDb;
using System.Windows;
using DevExpress.Xpf.PivotGrid;
using HowToBindToMDB.NwindDataSetTableAdapters;
using System.Windows.Markup;
using System.Windows.Data;
using System;
using System.Windows.Media;

namespace HowToBindToMDB {
    public partial class MainWindow : Window {
        NwindDataSet.SalesPersonDataTable salesPersonDataTable = new NwindDataSet.SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();

        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataTable;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            salesPersonDataAdapter.Fill(salesPersonDataTable);
        }
    }

    public class RoundConverter : MarkupExtension, IValueConverter {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, 
							  System.Globalization.CultureInfo culture) {
            return System.Convert.ToInt32(value);
        }
        public object ConvertBack(object value, Type targetType, object parameter, 
								  System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
        #endregion

        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}