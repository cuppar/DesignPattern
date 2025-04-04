namespace Builder;

class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("请选择您的房子：");
            Console.WriteLine("1. 普通房子");
            Console.WriteLine("2. 带泳池的房子");
            Console.WriteLine("3. 带花园的房子");
            Console.WriteLine("4. 带泳池和花园的房子");

            var type = Console.ReadLine();

            int typeOption;

            const string msg = "请输入1或2或3或4.";
            try
            {
                typeOption = Convert.ToInt32(type);
            }
            catch (Exception e)
            {
                Console.WriteLine(msg);
                Console.WriteLine(e);
                throw new ArgumentException(msg);
            }

            Console.WriteLine("请选择您的风格：");
            Console.WriteLine("1. 中式");
            Console.WriteLine("2. 西式");

            var style = Console.ReadLine();

            int styleOption;

            const string msg2 = "请输入1或2.";
            try
            {
                styleOption = Convert.ToInt32(style);
            }
            catch (Exception e)
            {
                Console.WriteLine(msg2);
                Console.WriteLine(e);
                throw new ArgumentException(msg2);
            }

            IHouseBuilder builder;
            switch (styleOption)
            {
                case 1:
                    builder = new ChinaHouseBuilder();
                    break;
                case 2:
                    builder = new WestHouseBuilder();
                    break;
                default:
                    throw new ArgumentException(msg2);
            }

            var director = new HouseDirector(builder);
            switch (typeOption)
            {
                case 1:
                    director.BuildNormalHouse();
                    break;
                case 2:
                    director.BuildHouseWithSwimPool();
                    break;
                case 3:
                    director.BuildHouseWithGarden();
                    break;
                case 4:
                    director.BuildHouseWithGardenAndSwimPool();
                    break;
                default:
                    throw new ArgumentException(msg);
            }

            House house = null!;
            if (builder is ChinaHouseBuilder chinaHouseBuilder)
                house = chinaHouseBuilder.GetResult();
            else if (builder is WestHouseBuilder westHouseBuilder)
                house = westHouseBuilder.GetResult();

            Console.WriteLine($"你得到了: {house}");
            Console.WriteLine();
        }
    }
}