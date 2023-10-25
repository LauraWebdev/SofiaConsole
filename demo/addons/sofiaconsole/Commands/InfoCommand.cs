// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole.Commands;

using Godot;

public class InfoCommand
{
    [ConsoleCommand("info", Description = "Prints general information")]
    private void DebugPrintInfo()
    {
        Console.Instance.Print("Versioning:");
        Console.Instance.Print($"Godot Version: {Engine.GetVersionInfo()["string"]}", Console.PrintType.Hint);
        Console.Instance.Print("SofiaConsole Version: 1.2.0", Console.PrintType.Hint);
        Console.Instance.Print($"CPU Architecture: {Engine.GetArchitectureName()}", Console.PrintType.Hint);
        Console.Instance.Space();
        Console.Instance.Print("Operating System:");
        Console.Instance.Print($"Host: {OS.GetName()}", Console.PrintType.Hint);
        Console.Instance.Print($"Version: {OS.GetVersion()}", Console.PrintType.Hint);
        Console.Instance.Print($"Language: {OS.GetLocaleLanguage()}", Console.PrintType.Hint);
        Console.Instance.Print($"Locale: {OS.GetLocale()}", Console.PrintType.Hint);
        Console.Instance.Space();
        Console.Instance.Print("Hardware:");
        Console.Instance.Print($"Processor Name: {OS.GetProcessorName()}", Console.PrintType.Hint);
        Console.Instance.Print($"Processor Cores: {OS.GetProcessorCount()}", Console.PrintType.Hint);
        Console.Instance.Print($"Video Driver Name: {OS.GetVideoAdapterDriverInfo()[0]}", Console.PrintType.Hint);
        Console.Instance.Print($"Video Driver Version: {OS.GetVideoAdapterDriverInfo()[1]}", Console.PrintType.Hint);
        Console.Instance.Print($"Memory (physical): {OS.GetMemoryInfo()["physical"].AsInt64() / 1024 / 1024}MB", Console.PrintType.Hint);
        Console.Instance.Print($"Memory (available): {OS.GetMemoryInfo()["available"].AsInt64() / 1024 / 1024}MB", Console.PrintType.Hint);
        Console.Instance.Print($"Memory (free): {OS.GetMemoryInfo()["free"].AsInt64() / 1024 / 1024}MB", Console.PrintType.Hint);
    }
}