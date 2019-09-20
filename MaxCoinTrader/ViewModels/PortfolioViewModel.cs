using System;
using System.ComponentModel;

namespace MaxCoinTrader.ViewModels
{
    internal class PortfolioViewModel : ObservableObject
    {
        private string message = "Portfolio.";

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                if (message == value)
                {
                    return;
                }

                message = value;

                OnPropertyChanged(nameof(Message));
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

        public PortfolioViewModel()
        {
            date = DateTime.Today.ToShortDateString().Replace("/", ".");
        }
    }
}