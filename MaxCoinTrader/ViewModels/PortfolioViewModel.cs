using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCoinTrader.ViewModels
{
    internal class PortfolioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string message = "Nothing here yet...";

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

                this.PropertyChanged(this, new PropertyChangedEventArgs(nameof(Message)));
            }
        }
    }
}