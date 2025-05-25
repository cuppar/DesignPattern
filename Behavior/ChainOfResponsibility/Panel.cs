namespace ChainOfResponsibility;

public class Panel : Container
{
    public string? PanelHelp { get; set; }

    public override void ShowHelp()
    {
        if (PanelHelp != null)
        {
            Console.WriteLine("PanelHelp: " + PanelHelp);
        }
        else
        {
            base.ShowHelp();
        }
    }
}