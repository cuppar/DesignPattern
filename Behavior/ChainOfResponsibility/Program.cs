namespace ChainOfResponsibility;

class Program
{
    static void Main(string[] args)
    {
        var button = new Button();
        // button.ToolTipHelp = "Button tool tip help";
        var panel = new Panel();
        panel.ToolTipHelp = "Panel tool tip help";
        // panel.PanelHelp = "Panel help";
        panel.Add(button);
        var dialog = new Dialog();
        dialog.ToolTipHelp = "Dialog tool tip help";
        // dialog.DialogHelp = "Dialog help";
        dialog.Add(panel);
        
        button.ShowHelp();
    }
}