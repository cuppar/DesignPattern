namespace DesignPattern.Create.FactoryMethod;

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Use ship");
    }
}