using MaxCoinTrader.Models;
using System;
using System.Collections.Generic;

namespace MaxCoinTrader.ViewModels
{
    internal class PortfolioViewModel : ObservableObject
    {
        #region Fields

        private string title = "Portfolio.";
        private string date = "09.10.1994";
        private float usdAmount = 150000f;
        private float totalPortfolioValue;
        private List<Coin> coinsList = new List<Coin>();

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
                if (title == value)
                {
                    return;
                }

                title = value;

                OnPropertyChanged(nameof(Title));
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
        }

        public string USDAmount
        {
            get
            {
                return $"USD Amount: {FormatMoney(usdAmount)}";
            }
        }

        public string TotalPortfolioValue
        {
            get
            {
                return $"Total Portfolio Value (USD): {FormatMoney(totalPortfolioValue)}";
            }
        }

        public List<Coin> CoinsList
        {
            get
            {
                return coinsList;
            }
        }

        #endregion Properties

        public PortfolioViewModel()
        {
            date = DateTime.Today.ToShortDateString().Replace("/", ".");

            // TODO: Later fetch info from DB.
            coinsList.Add(new Coin(1, "Bitcoin", "BTC", 1, 10000));
            coinsList.Add(new Coin(2, "Etherium", "ETH", 7.5f, 250));

            totalPortfolioValue = usdAmount;
            totalPortfolioValue += AllCoinsToUSDValue(coinsList);
        }

        #region Helpers

        private float AllCoinsToUSDValue(List<Coin> coins)
        {
            var totalAmount = 0f;

            foreach (var coin in coins)
            {
                totalAmount += coin.Value;
            }

            return totalAmount;
        }

        private string FormatMoney(float value)
        {
            return String.Format("{0:0,0.0}", value);
        }

        #endregion Helpers
    }
}