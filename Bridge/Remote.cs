namespace Bridge;

public class Remote
{
    public required IDevice Device { get; set; }

    public void TogglePower()
    {
        if (Device.IsOn)
        {
            Device.TurnOff();
        }
        else
        {
            Device.TurnOn();
        }
    }

    public void VolumeDown()
    {
        Device.Volume--;
    }

    public void VolumeUp()
    {
        Device.Volume++;
    }

    public void ChannelDown()
    {
        Device.Channel--;
    }

    public void ChannelUp()
    {
        Device.Channel++;
    }
}

public class AdvancedRemote : Remote
{
    public void Mute()
    {
        Device.Volume = 0;
    }
}

public interface IDevice
{
    bool IsOn { get; set; }
    void TurnOn();
    void TurnOff();

    int Volume { get; set; }
    int Channel { get; set; }
}

public class TV : IDevice
{
    public bool IsOn { get; set; }

    public void TurnOn()
    {
        IsOn = true;
    }

    public void TurnOff()
    {
        IsOn = false;
    }

    public int Volume { get; set; }
    public int Channel { get; set; }
}

public class Radio : IDevice
{
    public bool IsOn { get; set; }

    public void TurnOn()
    {
        IsOn = true;
    }

    public void TurnOff()
    {
        IsOn = false;
    }

    public int Volume { get; set; }
    public int Channel { get; set; }
}