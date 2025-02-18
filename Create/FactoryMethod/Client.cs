namespace DesignPattern.Create.FactoryMethod;

public static class Client
{
    public static void Main()
    {
        Console.WriteLine("请选择您的运输方式：");
        Console.WriteLine("1. 陆地");
        Console.WriteLine("2. 海洋");
        var inputLine = Console.ReadLine();
        var option = Convert.ToInt32(inputLine);
        switch (option)
        {
            case 1:
                Run(new RoadLogistics());
                break;
            case 2:
                Run(new SeaLogistics());
                break;
        }
    }

    static void Run(ILogistics logistics)
    {
        logistics.Run();
    }
}