using Godot;
using System;

public class StateMachine : Node
{
    [Export]
    private NodePath InitialState;
    private State CurrentState = null;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        CurrentState = GetNode<State>(InitialState);
    }
}
