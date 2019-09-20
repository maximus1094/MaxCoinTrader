using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCoinTrader.ViewModels
{
    internal class MarketViewModel : ObservableObject
    {
        private string message = "Market";

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;

                OnPropertyChanged(nameof(Message));
            }
        }
    }
}