namespace MaxCoinTrader.ViewModels
{
    internal class MarketViewModel : ObservableObject
    {
        #region Fields

        private string title = "Market";
        private string subtitle = "Buy and Sell Coins Here";

        #endregion Fields

        #region Properties

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;

                OnPropertyChanged(nameof(Title));
            }
        }

        public string Subtitle
        {
            get
            {
                return subtitle;
            }

            set
            {
                subtitle = value;

                OnPropertyChanged(nameof(Subtitle));
            }
        }

        #endregion Properties
    }
}