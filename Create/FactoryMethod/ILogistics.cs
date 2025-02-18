namespace DesignPattern.Create.FactoryMethod;

public interface ILogistics
{
    public void Run()
    {
        var transport = CreateTransport();
        transport.Deliver();
    }

    protected ITransport CreateTransport();
}