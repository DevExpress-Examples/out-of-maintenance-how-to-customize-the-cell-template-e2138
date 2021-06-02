using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace HowToCustomizeCellTemplate
{
    public partial class MainWindow : Window {
        public ObservableCollection<MyOrderRow> OrderSourceList { get; set; }

        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            OrderSourceList = DatabaseHelper.CreateData();
            pivotGridControl1.DataSource = OrderSourceList;
            pivotGridControl1.BestFitArea = DevExpress.Xpf.PivotGrid.FieldBestFitArea.FieldHeader;
            pivotGridControl1.BestFit();
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