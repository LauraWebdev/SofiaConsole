// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole.Commands;

public class ToggleConsoleCommand
{
    [ConsoleCommand("toggleconsole", Description = "Toggles the console")]
    public void ToggleConsole()
    {
        Console.Instance.ToggleConsole();
    }
}