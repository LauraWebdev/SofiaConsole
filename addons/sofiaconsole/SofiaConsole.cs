// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole;

#if TOOLS
using Godot;
using System;

[Tool]
public partial class SofiaConsole : EditorPlugin
{
	public override void _EnterTree()
	{
		var script = GD.Load<Script>("res://addons/sofiaconsole/Console.cs");
		var icon = GD.Load<Texture2D>("res://addons/sofiaconsole/icon.svg");
		AddCustomType("Console", "Node", script, icon);
	}

	public override void _ExitTree()
	{
		RemoveCustomType("Console");
	}
}
#endif
