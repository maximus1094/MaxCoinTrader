namespace MaxCoinTrader.Models
{
    internal class Coin
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public float PriceUSD { get; private set; }

        public Coin(int id, string name, string symbol, float priceUsd)
        {
            this.Id = id;
            this.Name = name;
            this.Symbol = symbol;
            this.PriceUSD = priceUsd;
        }
    }
}