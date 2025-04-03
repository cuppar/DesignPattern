namespace AbstractFactory;

internal abstract class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("请选择您的英雄：");
            Console.WriteLine("1. 战士");
            Console.WriteLine("2. 法师");
            Console.WriteLine("3. 游侠");

            var inputLine = Console.ReadLine();

            int option;

            const string msg = "请输入1或2或3.";
            try
            {
                option = Convert.ToInt32(inputLine);
            }
            catch (Exception e)
            {
                Console.WriteLine(msg);
                Console.WriteLine(e);
                throw new ArgumentException(msg);
            }

            switch (option)
            {
                case 1:
                    Run(new 战士工厂());
                    break;
                case 2:
                    Run(new 法师工厂());
                    break;
                case 3:
                    Run(new 游侠工厂());
                    break;
                default:
                    throw new ArgumentException(msg);
            }
        }
    }


    private static void Run(IItemFactory factory)
    {
        var head = factory.CreateHead().GetDescription();
        var body = factory.CreateBody().GetDescription();
        var foot = factory.CreateFoot().GetDescription();
        var weapon = factory.CreateWeapon().GetDescription();

        var msg = $"他手里拿着{weapon},头戴{head},身穿{body},脚踩{foot}。";
        Console.WriteLine(msg);
        Console.WriteLine();
    }
}