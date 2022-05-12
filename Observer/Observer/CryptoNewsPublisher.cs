using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class CryptoNewsPublisher : NewsPublisher
    {
        private string _lastCryptoPrice;

        public void SetLastCryptoPrice(string price)
        {
            _lastCryptoPrice = price;
            NotifySubscribers();
        }

        public string GetLastCryptoPrice()
        {
            return _lastCryptoPrice;
        }
    }
}
