namespace Builder;

public class HouseDirector(IHouseBuilder builder)
{
    public void BuildNormalHouse()
    {
        builder.Reset();
    }

    public void BuildHouseWithGarden()
    {
        builder.Reset();
        builder.BuildGarden();
    }

    public void BuildHouseWithSwimPool()
    {
        builder.Reset();
        builder.BuildSwimPool();
    }

    public void BuildHouseWithGardenAndSwimPool()
    {
        builder.Reset();
        builder.BuildGarden();
        builder.BuildSwimPool();
    }
}