namespace ChainOfResponsibility;

public abstract class Container : Component
{
    private readonly List<Component> _childrens = new();

    public void Add(Component component)
    {
        _childrens.Add(component);
        component.Container = this;
    }
}