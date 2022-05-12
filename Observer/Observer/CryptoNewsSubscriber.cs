using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class CryptoNewsSubscriber : INewsSubscriber
    {
        private readonly CryptoNewsPublisher _publisher;

        public CryptoNewsSubscriber(CryptoNewsPublisher publisher)
        {
            _publisher = publisher;
            _publisher.AddSubscriber(this);
        }

        public void Update()
        {
            string cryptoprice = _publisher.GetLastCryptoPrice();
            Console.WriteLine($"Crypto Subscriber {this.GetHashCode()} updated last price:: {cryptoprice}");
        }
    }
}
