using AbstractFactory.items;

namespace AbstractFactory;

public class 战士工厂 : IItemFactory
{
    public IHead CreateHead()
    {
        return new 头盔();
    }

    public IBody CreateBody()
    {
        return new 铠甲();
    }

    public IFoot CreateFoot()
    {
        return new 铁靴();
    }

    public IWeapon CreateWeapon()
    {
        return new 剑();
    }
}