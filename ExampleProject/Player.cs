using Godot;
using media.Laura.SofiaConsole;

public partial class Player : RigidBody3D
{
	private Vector3 _input;
	private bool _noclipOn = false;
	private Node3D _gdBotSkin;

	public override void _EnterTree()
	{
		base._EnterTree();
        
		_gdBotSkin = GetNode<Node3D>("GDbotSkin");
	}

	public override void _Process(double delta)
	{
		_input = Vector3.Zero;

		if (!Console.Instance.Open)
		{
			if (Input.IsActionPressed("move_left")) _input.X -= 5f;
			if (Input.IsActionPressed("move_right")) _input.X += 5f;
			if (Input.IsActionPressed("move_forward")) _input.Z -= 5f;
			if (Input.IsActionPressed("move_backward")) _input.Z += 5f;

			if (_noclipOn)
			{
				if (Input.IsActionPressed("move_up")) _input.Y += 5f;
				if (Input.IsActionPressed("move_down")) _input.Y -= 5f;
			}

			if (Input.IsActionJustPressed("jump"))
			{
				_gdBotSkin.Call("jump");
				ApplyImpulse(Vector3.Up * 10f);
			}
		}

		if (_input != Vector3.Zero)
		{
			_gdBotSkin.Call("walk");
		}
		if (_input == Vector3.Zero)
		{
			_gdBotSkin.Call("idle");
		}

		if (_noclipOn)
		{
			Position += _input * 2f * (float)delta;

			_gdBotSkin.Call("fall");
		}
	}

	public override void _IntegrateForces(PhysicsDirectBodyState3D state)
	{
		base._IntegrateForces(state);
		
		if(!_noclipOn)
			state.LinearVelocity = new Vector3(_input.X, LinearVelocity.Y, _input.Z);
	}

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		var lookDirection = new Vector3(Position.X + _input.X * 2f, Position.Y, Position.Z + _input.Z * 2f);

		if (lookDirection != Position)
		{
			LookAt(lookDirection, Vector3.Up);
		}
	}

	[ConsoleCommand("noclip", Description = "Allows you to move the player without physics")]
	public void DebugToggleNoclip()
	{
		_noclipOn = !_noclipOn;
		
		if (_noclipOn)
		{
			Freeze = true;
			Console.Instance.Print("Noclip on");
		}
		else
		{
			Freeze = false;
			Console.Instance.Print("Noclip off");
		}
	}
}
