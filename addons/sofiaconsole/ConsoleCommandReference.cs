// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole;

using System.Reflection;

public class ConsoleCommandReference
{
    public string Command { get; init; }
    public string Description { get; init; }
    public string Usage { get; init; }
    public MethodInfo Method { get; init; }
}