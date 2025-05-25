namespace ChainOfResponsibility;

public class Dialog : Container
{
    public string? DialogHelp { get; set; }

    public override void ShowHelp()
    {
        if (DialogHelp != null)
        {
            Console.WriteLine("DialogHelp: " + DialogHelp);
        }
        else
        {
            base.ShowHelp();
        }
    }
}