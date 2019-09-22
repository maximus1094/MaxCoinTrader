using MaxCoinTrader.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaxCoinTrader.Views
{
    /// <summary>
    /// Interaction logic for MarketView.xaml
    /// </summary>
    public partial class MarketView : UserControl
    {
        public MarketView()
        {
            InitializeComponent();
        }

        // TODO: Move Click logic from code-behind to ViewModel
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            int coinID = -1;

            try
            {
                coinID = Convert.ToInt32(SearchTextBox.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"ERROR in MarketView::SearchButton_Click::FormatException::\n{fe.StackTrace}");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show($"ERROR in MarketView::SearchButton_Click::OverflowException::\n{oe.StackTrace}");
            }

            var marketVM = (MarketViewModel)DataContext;

            marketVM.FindCoinById(coinID);
        }
    }
}