// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole.Commands;

public class ClearCommand
{
    [ConsoleCommand("clear", Description = "Clears the console history")]
    public void ClearConsole()
    {
        Console.Instance.ClearConsole();
    }
}