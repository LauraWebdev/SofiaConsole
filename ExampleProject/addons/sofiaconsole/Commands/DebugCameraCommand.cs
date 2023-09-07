// ReSharper disable once CheckNamespace
namespace media.Laura.SofiaConsole.Commands;

using Godot;

public partial class DebugCameraCommand : Node
{
	private Camera3D _currentCamera;
	private Camera3D _debugCamera;
	private bool _active = false;

	public override void _EnterTree()
	{
		base._EnterTree();

		_debugCamera = GetNode<Camera3D>("DebugCamera");
	}

	[ConsoleCommand("devcam", Description = "Toggles between the current camera and a free-flying camera")]
	public void ToggleDebugCamera()
	{
		_active = !_active;

		if (_active)
		{
			_currentCamera = GetViewport().GetCamera3D();
			
			_debugCamera.Fov = _currentCamera.Fov;
			_debugCamera.Position = _currentCamera.Position;
			_debugCamera.Rotation = _currentCamera.Rotation;
			_debugCamera.Visible = true;
			_debugCamera.MakeCurrent();
				
			Console.Instance.Print("Dev camera on");
		}
		else
		{
			_currentCamera.MakeCurrent();
			_debugCamera.Visible = false;
			
			Console.Instance.Print("Dev camera off");
		}
	}
}
