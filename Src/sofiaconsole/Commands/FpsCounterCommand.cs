// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole.Commands;

using Godot;

public partial class FpsCounterCommand : Node
{
	private CanvasLayer _canvas;
	private Label _label;

	public override void _EnterTree()
	{
		base._EnterTree();

		_canvas = GetNode<CanvasLayer>("CounterCanvas");
		_label = GetNode<Label>("CounterCanvas/PanelContainer/Label");
	}

	public override void _Process(double delta)
	{
		if(_canvas.Visible)
			_label.Text = $"{Engine.GetFramesPerSecond()}";
	}

	[ConsoleCommand("fps", Description = "Toggles the FPS counter")]
	[ConsoleCommand("togglefps", Description = "Toggles the FPS counter")]
	private void DebugToggleCounter()
	{
		_canvas.Visible = !_canvas.Visible;

		if (_canvas.Visible)
		{
			Console.Instance.Print("Fps counter on");
		}
		else
		{
			Console.Instance.Print("Fps counter off");
		}
	}

	[ConsoleCommand("maxfps", Description = "Adds an fps limit, 0 disables the limiter", Usage = "maxfps [fps]")]
	private void DebugToggleFpsLimiter(int maxFps)
	{
		Engine.MaxFps = maxFps;

		Console.Instance.Print($"Set max fps to: {maxFps}");
	}
}
