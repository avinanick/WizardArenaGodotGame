using Godot;
using Godot.Collections;
using System;

public class PlayerRunState : PlayerState
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
        PlayerSkin.TransitionTo(PlayerModel.States.Run);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void PhysicsProcess(float delta)
    {
        base.PhysicsProcess(delta);
        if(_Parent is PlayerMoveState moveState) {
            if(moveState.Velocity.Length() < 0.01) {
                _StateMachine.TransitionTo("Move/Idle", new Godot.Collections.Dictionary());
            }
        }
    }
}
