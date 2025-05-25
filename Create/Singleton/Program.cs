namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        var a1 = Game.GetInstance();
        var a2 = Game.GetInstance();
        Console.WriteLine(a1 == a2);
    }
}