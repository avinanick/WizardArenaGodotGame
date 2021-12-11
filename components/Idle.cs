using Godot;
using Godot.Collections;
using System;

public class Idle : PlayerState
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
    }

    public override void Enter(Dictionary message)
    {
        base.Enter(message);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void PhysicsProcess(float delta)
    {
        base.PhysicsProcess(delta);
    }

    public override void UnhandledInput(InputEvent @event)
    {
        base.UnhandledInput(@event);
    }
}
