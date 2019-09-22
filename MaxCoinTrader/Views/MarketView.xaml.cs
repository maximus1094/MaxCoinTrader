using MaxCoinTrader.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MaxCoinTrader.Views
{
    /// <summary>
    /// Interaction logic for MarketView.xaml
    /// </summary>
    public partial class MarketView : UserControl
    {
        // TODO: Redesign the whole View (UI) ASAP.
        // Unneeded repetition of coin info.

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

        // TODO: Move Click logic from code-behind to ViewModel
        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hey buddy!");
        }
    }
}