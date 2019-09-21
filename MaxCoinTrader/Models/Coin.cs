namespace MaxCoinTrader.Models
{
    internal class Coin
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public float Holding { get; private set; }
        public float PriceUSD { get; private set; }
        public float Value { get; private set; }
        public float GainLoss { get; private set; }

        public Coin(int id, string name, string symbol, float holding, float priceUsd)
        {
            this.Id = id;
            this.Name = name;
            this.Symbol = symbol;
            this.Holding = holding;
            this.PriceUSD = priceUsd;

            this.Value = holding * priceUsd;

            // TODO: Calculate Gain/Loss based on original purchase price.
            this.GainLoss = 0;
        }
    }
}