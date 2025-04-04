namespace Builder;

public class ChinaHouseBuilder : IHouseBuilder
{
    private ChinaHouse _house = new ChinaHouse();

    public void Reset()
    {
        _house = new ChinaHouse();
    }

    public void BuildGarden()
    {
        _house.HasGarden = true;
    }

    public void BuildSwimPool()
    {
        _house.HasSwimPool = true;
    }

    public ChinaHouse GetResult()
    {
        var result = _house;
        Reset();
        return result;
    }
}