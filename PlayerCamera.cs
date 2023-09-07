using Godot;
using System;

public partial class PlayerCamera : Camera3D
{
	[Export] public Node3D FollowTarget;
	[Export] public Vector3 Offset;

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		Position = FollowTarget.Position + Offset;
	}
}
