namespace DesignPattern.Create.FactoryMethod;

public class SeaLogistics : ILogistics
{
    public ITransport CreateTransport()
    {
        return new Ship();
    }
}