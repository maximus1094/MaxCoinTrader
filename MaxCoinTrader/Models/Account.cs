using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCoinTrader.Models
{
    internal class Account
    {
        private int id;

        public string Name { get; private set; }
        public PortfolioModel Portfolio { get; private set; }
        public TradingHistoryModel TradingHistory { get; private set; }

        public Account(int id, string name)
        {
            this.id = id;
            this.Name = name;
            this.Portfolio = new PortfolioModel();
            this.TradingHistory = new TradingHistoryModel();
        }

        public void BoughtCoin(Coin coin, float amount)
        {
            float price = coin.PriceUSD * amount;

            Portfolio.AddCoin(coin, amount, price);
        }

        public void SoldCoin(Coin coin, float amount)
        {
        }

        public string GetPortfolioString()
        {
            return $"{Name}, this is your portfolio. \n {Portfolio.ToString()}";
        }
    }
}