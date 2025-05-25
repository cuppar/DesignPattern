namespace ChainOfResponsibility;

public abstract class Component : IHelp
{
    public string? ToolTipHelp { get; set; }
    public Container? Container { get; set; }

    public virtual void ShowHelp()
    {
        if (ToolTipHelp != null)
        {
            Console.WriteLine("ToolTip: " + ToolTipHelp);
        }
        else
        {
            Container?.ShowHelp();
        }
    }
}