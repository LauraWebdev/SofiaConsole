// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole.Commands;

public class HelloWorldCommand
{
    [ConsoleCommand("helloworld", Description = "Prints 'Hello World!' in the console")]
    public void PrintHelloWorld()
    {
        Console.Instance.Print("Hello World!");
        Console.Instance.Print("Hello World!", Console.PrintType.Default);
        Console.Instance.Print("Hello World!", Console.PrintType.Hint);
        Console.Instance.Print("Hello World!", Console.PrintType.Warning);
        Console.Instance.Print("Hello World!", Console.PrintType.Error);
        Console.Instance.Print("Hello World!", Console.PrintType.Success);
    }
}