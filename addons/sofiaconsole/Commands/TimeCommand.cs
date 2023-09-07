// ReSharper disable once CheckNamespace

using Godot;

namespace media.Laura.SofiaConsole.Commands;

public class TimeCommand
{
    [ConsoleCommand("timescale", Description = "Sets the timescale", Usage = "timescale 1.5")]
    public void DebugSetTimescale(float timescale)
    {
        if (timescale == 0) timescale = 1;
        Engine.TimeScale = timescale;
        Console.Instance.Print($"Set timescale to {timescale}");
    }
}