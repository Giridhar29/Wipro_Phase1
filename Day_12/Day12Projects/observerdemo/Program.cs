namespace observerdemo;

class Program
{
    static void Main(string[] args)
    {
        // Create a stock and investors
        Stock appleStock = new Stock("AAPL", 120.00);
        Investor investor1 = new Investor("John Doe");
        Investor investor2 = new Investor("Jane Smith");

        // Register the investors (observers) with the stock (subject)
        appleStock.RegisterObserver(investor1);
        appleStock.RegisterObserver(investor2);

        // Change the stock price (this will notify the observers)
        appleStock.Price = 121.00;
        appleStock.Price = 123.50;

        // Remove one investor and change the price again
        appleStock.RemoveObserver(investor1);
        appleStock.Price = 125.75;
    }
}
