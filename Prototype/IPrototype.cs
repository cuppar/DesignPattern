namespace Prototype;

public interface IPrototype
{
    string GetColor();
    IPrototype Clone();
}