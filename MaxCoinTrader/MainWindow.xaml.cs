using MaxCoinTrader.Models;
using MaxCoinTrader.ViewModels;
using System.Windows;

namespace MaxCoinTrader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PortfolioViewModel _portfolioVM = new PortfolioViewModel();
        private MarketViewModel _marketVM = new MarketViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = _portfolioVM;
        }

        private void PortfolioButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = _portfolioVM;
        }

        private void MarketButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = _marketVM;
        }
    }
}