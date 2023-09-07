using Godot;
using System;

public partial class DebugCamera : Camera3D
{
    private Vector3 _input;

    public override void _Process(double delta)
    {
        _input = Vector3.Zero;
        
        // Forward/Backward/Left/Right
        if (Input.IsKeyPressed(Key.Kp8)) _input.Z -= 1f;
        if (Input.IsKeyPressed(Key.Kp2)) _input.Z += 1f;
        if (Input.IsKeyPressed(Key.Kp4)) _input.X -= 1f;
        if (Input.IsKeyPressed(Key.Kp6)) _input.X += 1f;
            
        // Up/Down
        if (Input.IsKeyPressed(Key.Kp7)) _input.Y += 1f;
        if (Input.IsKeyPressed(Key.Kp9)) _input.Y -= 1f;
            
        // Rotate Left/Right
        if (Input.IsKeyPressed(Key.Kp1)) RotateY(5f * (float)delta);
        if (Input.IsKeyPressed(Key.Kp3)) RotateY(-5f * (float)delta);
        
        Translate(_input * 5f * (float)delta);
    }
}
