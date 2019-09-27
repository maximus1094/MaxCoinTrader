using MaxCoinTrader.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace MaxCoinTrader.ViewModels
{
    internal class MarketViewModel : ObservableObject
    {
        #region Fields

        private readonly Coin defaultCoin = new Coin(-1, "-", "-", 0, 0, 0);

        private Coin selectedCoinToBuy;
        private Coin selectedCoinToSell;
        private ObservableCollection<string> myCoins = new ObservableCollection<string>();

        #endregion Fields

        #region Properties

        public Coin SelectedCoinToBuy
        {
            get
            {
                return selectedCoinToBuy;
            }

            set
            {
                selectedCoinToBuy = value;

                OnPropertyChanged(nameof(SelectedCoinToBuy));
            }
        }

        public ObservableCollection<string> MyCoins
        {
            get
            {
                return myCoins;
            }

            private set { }
        }

        #endregion Properties

        public MarketViewModel()
        {
            //coinsList.Add(new Coin(1, "Bitcoin", "BTC", 1, 10000));
            //coinsList.Add(new Coin(2, "Etherium", "ETH", 7.5f, 250));

            selectedCoinToBuy = defaultCoin;

            myCoins.Add("Bitcoin, Owned: 1.0");
            myCoins.Add("Etherium, Owned: 7.5");
        }

        public void FindCoinById(int id)
        {
            // TODO: Implement caching strategy to save requests.

            /*
             * Check if id is correct.
             * Call async function to fetch coin info using CoinMarketcap API. (needs to be setup)
             * Parse response.
             * (Cache response).
             * Update View with response.
             */

            if (id == -1)
            {
                return;
            }

            string response =
                "{" +
                "\"data\": {" +
                "\"1\": {" +
                "\"id\": 1," +
                "\"name\": \"Bitcoin\"," +
                "\"symbol\": \"BTC\"," +
                "\"slug\": \"bitcoin\"," +
                "\"circulating_supply\": 17199862," +
                "\"total_supply\": 17199862," +
                "\"max_supply\": 21000000," +
                "\"date_added\": \"2013-04-28T00:00:00.000Z\"," +
                "\"num_market_pairs\": 331," +
                "\"cmc_rank\": 1," +
                "\"last_updated\": \"2018-08-09T21:56:28.000Z\"," +
                "\"tags\": [" +
                "\"mineable\"" +
                "]," +
                "\"platform\": null," +
                "\"quote\": {" +
                "\"USD\": {" +
                "\"price\": 6602.60701122," +
                "\"volume_24h\": 4314444687.5194," +
                "\"percent_change_1h\": 0.988615," +
                "\"percent_change_24h\": 4.37185," +
                "\"percent_change_7d\": -12.1352," +
                "\"market_cap\": 113563929433.21645," +
                "\"last_updated\": \"2018-08-09T21:56:28.000Z\"" +
                "}" +
                "}" +
                "}" +
                "}," +
                "\"status\": {" +
                "\"timestamp\": \"2019-09-22T09:06:48.610Z\"," +
                "\"error_code\": 0," +
                "\"error_message\": \"\"," +
                "\"elapsed\": 10," +
                "\"credit_count\": 1" +
                "}" +
                "}";

            JObject jsonResponse = JObject.Parse(response);
            JToken data = jsonResponse["data"]["1"];

            SelectedCoinToBuy = new Coin(
                Convert.ToInt32(data["id"]),
                Convert.ToString(data["name"]),
                Convert.ToString(data["symbol"]),
                Convert.ToSingle(data["quote"]["USD"]["percent_change_24h"]),
                0,
                Convert.ToSingle(data["quote"]["USD"]["price"])
                );
        }

        public void BuySelectedCoin(float amount)
        {
            if (selectedCoinToBuy.Id != -1 && amount > 0)
            {
                MessageBox.Show($"Buying {amount} of {selectedCoinToBuy.Name} for {selectedCoinToBuy.PriceUSD * amount}.");
            }
        }
    }
}