namespace Builder;

public abstract class House
{
    public bool HasGarden { get; set; }
    public bool HasSwimPool { get; set; }

    protected virtual string Name => "房子";
    protected virtual string GardenName => "花园";
    protected virtual string SwimName => "泳池";

    public override string ToString()
    {
        var str = Name;
        if (HasGarden)
            str += $", 有{GardenName}";
        if (HasSwimPool)
            str += $", 有{SwimName}";
        str += "。";
        return str;
    }
}