namespace DesignPattern.Create.FactoryMethod;

public static class Client
{
    public static void Main()
    {
        Console.WriteLine("请选择您的运输方式：");
        Console.WriteLine("1. 陆地");
        Console.WriteLine("2. 海洋");

        var inputLine = Console.ReadLine();

        int option;

        try
        {
            option = Convert.ToInt32(inputLine);
        }
        catch (Exception e)
        {
            Console.WriteLine("请输入1或2.");
            Console.WriteLine(e);
            throw new ArgumentException("请输入1或2.");
        }

        switch (option)
        {
            case 1:
                Run(new RoadLogistics());
                break;
            case 2:
                Run(new SeaLogistics());
                break;
            default:
                throw new ArgumentException("请输入1或2.");
        }
    }

    private static void Run(ILogistics logistics)
    {
        logistics.Run();
    }
}