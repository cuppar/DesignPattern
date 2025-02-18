namespace DesignPattern.Create.FactoryMethod;

public abstract class Logistics
{
    private int _a = 1;
    private int _b { get; set; } = 1;

    public void Run()
    {
        var transport = CreateTransport();
        transport.Deliver();
    }

    protected abstract ITransport CreateTransport();
}