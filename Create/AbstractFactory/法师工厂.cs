using AbstractFactory.items;

namespace AbstractFactory;

public class 法师工厂 : IItemFactory
{
    public IHead CreateHead()
    {
        return new 魔法帽();
    }

    public IBody CreateBody()
    {
        return new 法袍();
    }

    public IFoot CreateFoot()
    {
        return new 布鞋();
    }

    public IWeapon CreateWeapon()
    {
        return new 法杖();
    }
}