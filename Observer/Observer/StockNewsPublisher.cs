using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class StockNewsPublisher : NewsPublisher
    {
        private string _laststockPrice;

        public void SetLastStockPrice(string price)
        {
            _laststockPrice = price;
            NotifySubscribers();
        }

        public string GetLastStockPrice()
        {
            return _laststockPrice;
        }
        
    }
}
