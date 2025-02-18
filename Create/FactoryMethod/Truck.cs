namespace DesignPattern.Create.FactoryMethod;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Use truck");
    }
}