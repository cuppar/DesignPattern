namespace Builder;

public class WestHouseBuilder : IHouseBuilder
{
    private WestHouse _house = new();

    public void Reset()
    {
        _house = new WestHouse();
    }

    public void BuildGarden()
    {
        _house.HasGarden = true;
    }

    public void BuildSwimPool()
    {
        _house.HasSwimPool = true;
    }

    public WestHouse GetResult()
    {
        var result = _house;
        Reset();
        return result;
    }
}