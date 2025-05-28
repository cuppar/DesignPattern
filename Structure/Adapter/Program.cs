namespace Adapter;

class Program
{
    static void Main(string[] args)
    {
        var roundHole = new RoundHole(5);
        var squarePeg = new SquarePeg(7);
        var squarePegAdapter = new SquarePegAdapter(squarePeg);

        var canFit = roundHole.Fits(squarePegAdapter);
        Console.WriteLine(canFit);
    }
}