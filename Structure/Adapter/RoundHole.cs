namespace Adapter;

public class RoundHole(double radius)
{
    public bool Fits(RoundPeg peg)
    {
        return peg.Radius <= radius;
    }
}