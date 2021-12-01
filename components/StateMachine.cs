using Godot;
using System;

public class StateMachine : Node
{
    [Signal]
    public delegate void Transitioned(string statePath);

    [Export]
    private NodePath InitialState;
    private State CurrentState = null;

    public override void _PhysicsProcess(float delta)
    {
        base._PhysicsProcess(delta);
        CurrentState.PhysicsProcess(delta);
    }

    public override void _Process(float delta)
    {
        base._Process(delta);
        CurrentState.Process(delta);
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        CurrentState = GetNode<State>(InitialState);
        CallDeferred(nameof(Setup));
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        base._UnhandledInput(@event);
        CurrentState.UnhandledInput(@event);
    }

    public void SetState(State newState) {
        CurrentState = newState;
    }

    private void Setup() {
        CurrentState.Enter(new Godot.Collections.Dictionary());
    }

    public void TransitionTo(string targetStatePath, Godot.Collections.Dictionary message) {
        if(!HasNode(targetStatePath)) {
            return;
        }
        State targetState = GetNode<State>(targetStatePath);
        CurrentState.Exit();
        CurrentState = targetState;
        CurrentState.Enter(message);
        EmitSignal(nameof(Transitioned), targetStatePath);
    }
}
