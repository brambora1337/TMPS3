using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            CryptoNewsPublisher cryptoPublisher = new CryptoNewsPublisher();

            CryptoNewsSubscriber cryptoSubscriber1 = new CryptoNewsSubscriber(cryptoPublisher);
            CryptoNewsSubscriber cryptoSubscriber2 = new CryptoNewsSubscriber(cryptoPublisher);

            cryptoPublisher.SetLastCryptoPrice("Bitcoin BTC - $29209.99");
            cryptoPublisher.SetLastCryptoPrice("Ethereum ETH - $1927.96");
            cryptoPublisher.SetLastCryptoPrice("Solana SOL - $43.61");

            StockNewsPublisher stockPublisher = new StockNewsPublisher();

            StockNewsSubscriber stockSubscriber1 = new StockNewsSubscriber(stockPublisher);
            

            stockPublisher.SetLastStockPrice("Ford Motor Co - $12.37");
            stockPublisher.SetLastStockPrice("Bank of America Corp - $34.60");
            stockPublisher.SetLastStockPrice("Twitter Inc - $45.31");
            stockPublisher.SetLastStockPrice("Walt Disney Co - $102.64");
        }
    }
}
