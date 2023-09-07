// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole;

using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ConsoleCommandAttribute : Attribute
{
    public string Command;
    public string Description;
    public string Usage;

    public ConsoleCommandAttribute(string command)
    {
        Command = command;
        Description = "";
        Usage = command;
    }
}