namespace Prototype;

public class PrototypeRegistry
{
    private readonly List<IPrototype> _items = [];
    private readonly Dictionary<string, IPrototype> _itemsById = new();

    public void AddItem(string id, IPrototype item)
    {
        _itemsById.Add(id, item);
        _items.Add(item);
    }

    public IPrototype? GetById(string id)
    {
        return _itemsById.GetValueOrDefault(id)?.Clone();
    }

    public IPrototype? GetByColor(string color)
    {
        return _items.FirstOrDefault(item => item.GetColor() == color)?.Clone();
    }
}