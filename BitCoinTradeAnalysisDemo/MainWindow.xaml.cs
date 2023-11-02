using Syncfusion.UI.Xaml.Charts;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BitCoinTradeAnalysisDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DateTimeAxis_LabelCreated(object sender, LabelCreatedEventArgs e)
        {
            var axis = sender as DateTimeAxis;

            if (axis != null)
            {
                if (DateTime.TryParse(e.AxisLabel.LabelContent.ToString(), out var axisValue))
                {
                    e.AxisLabel.LabelContent = axisValue.ToString("MMM-yy", CultureInfo.InvariantCulture);
                }
            }
        }
    }
}