using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class StockNewsSubscriber : INewsSubscriber
    {
        private readonly StockNewsPublisher _publisher;

        public StockNewsSubscriber(StockNewsPublisher publisher)
        {
            _publisher = publisher;
            _publisher.AddSubscriber(this);
        }

        public void Update()
        {
            string lastPrice = _publisher.GetLastStockPrice();
            Console.WriteLine($"Tech Subscriber {this.GetHashCode()} updated last price: {lastPrice}");
        }
    }
}
