namespace Adapter;

public class SquarePegAdapter(SquarePeg peg) : RoundPeg(peg.Width / 2 * Math.Sqrt(2))
{
}