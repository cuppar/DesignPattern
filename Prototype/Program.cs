namespace Prototype;

class Program
{
    static void Main(string[] args)
    {
        var button1 = new Button(100, 50, "red");
        var button2 = button1.Clone();
        var button3 = new Button(200, 200, "green");

        var registry = new PrototypeRegistry();
        registry.AddItem("1", button1);
        registry.AddItem("2", button2);
        registry.AddItem("3", button3);


        for (int i = 0; i < 10; i++)
        {
            var button = registry.GetById($"{i}");
            Console.WriteLine(button?.GetColor());
        }

        for (int i = 0; i < 10; i++)
        {
            var button = registry.GetByColor("red");
            Console.WriteLine(button?.GetColor());
        }
    }
}