using Godot;
using System;

public class PlayerMoveState : PlayerState
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export]
    private float MaxSpeed = 50.0f;
    [Export]
    private float MoveSpeed = 10f;
    [Export]
    private float Gravity = -80f;
    [Export]
    private float JumpImpulse = 25;
    public Vector3 Velocity = Vector3.Zero;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
    }

    private Vector3 CalculateVelocity(Vector3 velocityCurrent, Vector3 moveDirection, float delta) {
        Vector3 velocityNew = moveDirection * MoveSpeed;
        if(velocityNew.Length() > MaxSpeed) {
            velocityNew = velocityNew.Normalized() * MaxSpeed;
        }
        velocityNew.y = velocityCurrent.y + (Gravity * delta);
        return velocityNew;
    }

    private static Vector3 GetInputDirection() {
        return new Vector3(
            Input.GetActionRawStrength("move_right") - Input.GetActionStrength("move_left"),
            0,
            Input.GetActionStrength("move_back") - Input.GetActionStrength("move_forward")
        );
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
        if(moveDirection.Length() > 0.001 & PlayerOwner != null) {
            PlayerOwner.LookAt(PlayerOwner.GlobalTransform.origin + moveDirection, Vector3.Up);
        }
        Velocity = CalculateVelocity(Velocity, moveDirection, delta);
        if(PlayerOwner != null) {
            Velocity = PlayerOwner.MoveAndSlide(Velocity, Vector3.Up);
        }
    }
}
