// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole.Commands;

public class ReloadCommand
{
    [ConsoleCommand("reload", Description = "Reloads the current scene")]
    public void DebugReloadScene()
    {
        Console.Instance.GetTree().ReloadCurrentScene();
    }
}