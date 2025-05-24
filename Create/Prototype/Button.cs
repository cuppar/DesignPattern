namespace Prototype;

public class Button : IPrototype
{
    private readonly int _width;
    private readonly int _height;
    private readonly string _color;

    public Button(int width, int height, string color)
    {
        _width = width;
        _height = height;
        _color = color;
    }

    public Button(Button button)
    {
        _width = button._width;
        _height = button._height;
        _color = button._color;
    }


    public string GetColor()
    {
        return _color;
    }

    public IPrototype Clone()
    {
        return new Button(this);
    }
}