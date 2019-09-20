using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCoinTrader.Models
{
    internal class PortfolioModel
    {
        public float Fiat { get; private set; }
        public Dictionary<Coin, float> CoinAmount { get; private set; }

        public PortfolioModel()
        {
            this.Fiat = 10000;
            this.CoinAmount = new Dictionary<Coin, float>();
        }

        public void AddCoin(Coin coin, float amount, float price)
        {
            if (CoinAmount.ContainsKey(coin))
            {
                CoinAmount[coin] += amount;
            }
            else
            {
                CoinAmount[coin] = amount;
            }

            Fiat -= price;
        }

        // TODO: Temporary method. If keeping repalce with StringBuilder.
        public override string ToString()
        {
            string portfolioStr = $"Fiat: {Fiat} \n";

            foreach (var coin in CoinAmount)
            {
                portfolioStr += $"{coin.Key.Symbol}: {coin.Value}";
            }

            return portfolioStr;
        }
    }
}