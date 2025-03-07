namespace observerdemo;

// Step 4: Implement Concrete Observer
public class Investor : IInvestor
{
    private string _name;

    public Investor(string name)
    {
        _name = name;
    }

    public void Update(Stock stock)
    {
        Console.WriteLine($"Notified {_name} of {stock.Symbol}'s price change to {stock.Price:C}");
    }
}
