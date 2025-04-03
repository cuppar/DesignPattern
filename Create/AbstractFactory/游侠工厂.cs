using AbstractFactory.items;

namespace AbstractFactory;

public class 游侠工厂 : IItemFactory
{
    public IHead CreateHead()
    {
        return new 皮帽();
    }

    public IBody CreateBody()
    {
        return new 皮衣();
    }

    public IFoot CreateFoot()
    {
        return new 皮鞋();
    }

    public IWeapon CreateWeapon()
    {
        return new 弓箭();
    }
}