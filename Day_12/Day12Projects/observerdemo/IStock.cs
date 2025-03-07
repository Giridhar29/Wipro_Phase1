namespace observerdemo;

// Step 2: Define Subject Interface
public interface IStock
{
    void RegisterObserver(IInvestor investor);
    void RemoveObserver(IInvestor investor);
    void NotifyObservers();
}
