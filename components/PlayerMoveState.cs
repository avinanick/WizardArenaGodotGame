using Godot;
using System;

public class PlayerMoveState : PlayerState
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private Vector3 Velocity = Vector3.Zero;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
    }

    private Vector3 CalculateVelocity() {
        return Vector3.Zero;
    }

    private static Vector3 GetInputDirection() {
        return Vector3.Zero;
    }

    public override void PhysicsProcess(float delta)
    {
        base.PhysicsProcess(delta);
        Vector3 inputDirection = GetInputDirection();
        Vector3 moveDirection = inputDirection;
        if(moveDirection.Length() > 1) {
            moveDirection = moveDirection.Normalized();
        }
        moveDirection.y = 0;
        Velocity = CalculateVelocity();
    }
}
