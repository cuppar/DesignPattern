namespace Bridge;

class Program
{
    static void Main(string[] args)
    {
        var device = new TV();
        var remote = new Remote { Device = device };

        remote.TogglePower();
    }
}