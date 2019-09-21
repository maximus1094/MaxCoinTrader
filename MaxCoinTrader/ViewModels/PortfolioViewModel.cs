using MaxCoinTrader.Models;
using System;
using System.Collections.Generic;

namespace MaxCoinTrader.ViewModels
{
    internal class PortfolioViewModel : ObservableObject
    {
        private string title = "Portfolio.";

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

        private string date = "09.10.1994";

        public string Date
        {
            get
            {
                return date;
            }
        }

        private float usdAmount = 150000f;

        public string USDAmount
        {
            get
            {
                return $"USD Amount: {usdAmount}";
            }
        }

        private float totalPortfolioValue;

        public string TotalPortfolioValue
        {
            get
            {
                return $"Total Portfolio Value: {totalPortfolioValue}";
            }
        }

        private List<Coin> coinsList = new List<Coin>();

        public List<Coin> CoinsList
        {
            get
            {
                return coinsList;
            }
        }

        public PortfolioViewModel()
        {
            date = DateTime.Today.ToShortDateString().Replace("/", ".");

            coinsList.Add(new Coin(1, "Bitcoin", "BTC", 1, 10000));
            coinsList.Add(new Coin(2, "Etherium", "ETH", 7.5f, 250));

            totalPortfolioValue = usdAmount;
            totalPortfolioValue += AllCoinsToUSDValue(coinsList);
        }

        private float AllCoinsToUSDValue(List<Coin> coins)
        {
            var totalAmount = 0f;

            foreach (var coin in coins)
            {
                totalAmount += coin.Value;
            }

            return totalAmount;
        }
    }
}