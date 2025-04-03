namespace AbstractFactory;

public interface IItemFactory
{
    IHead CreateHead();
    IBody CreateBody();
    IFoot CreateFoot();
    IWeapon CreateWeapon();
}