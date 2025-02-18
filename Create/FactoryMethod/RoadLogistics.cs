namespace DesignPattern.Create.FactoryMethod;

public class RoadLogistics : ILogistics
{
    public ITransport CreateTransport()
    {
        return new Truck();
    }
}