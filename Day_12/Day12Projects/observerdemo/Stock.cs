namespace observerdemo;

// Step 3: Implement Concrete Subject
public class Stock : IStock
{
    private List<IInvestor> _investors = new List<IInvestor>();
    private string _symbol;
    private double _price;

    public Stock(string symbol, double price)
    {
        _symbol = symbol;
        _price = price;
    }

    public string Symbol => _symbol;

    public double Price
    {
        get => _price;
        set
        {
            if (_price != value)
            {
                _price = value;
                NotifyObservers();
            }
        }
    }

    public void NotifyObservers()
    {
        foreach (var investor in _investors)
        {
            investor.Update(this);
        }
    }

    public void RegisterObserver(IInvestor investor)
    {
        _investors.Add(investor);
    }

    public void RemoveObserver(IInvestor investor)
    {
        _investors.Remove(investor);
    }
}
