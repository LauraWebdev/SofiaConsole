// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole.Commands;

using System.Linq;

public class HelpCommand
{
    [ConsoleCommand("help", Description = "Shows this help", Usage = "help [command?]")]
    public void PrintHelp(string command = null)
    {
        if (command == null)
        {
            Console.Instance.Print("Commands:", Console.PrintType.Hint);

            Console.Instance.Commands.ForEach(commandItem =>
            {
                Console.Instance.Print($"{commandItem.Command} - {commandItem.Description}");
            });
        }
        else
        {
            var commandAttribute = Console.Instance.Commands.FirstOrDefault(x => x.Command == command);
            if (commandAttribute == null)
            {
                Console.Instance.Print($"The command '{command}' does not exist.", Console.PrintType.Error);
                return;
            }
            
            Console.Instance.Print($"{commandAttribute.Command}");
            Console.Instance.Print($"{commandAttribute.Description}", Console.PrintType.Hint);
            Console.Instance.Print($"Usage: {commandAttribute.Usage}");
        }
    }
}