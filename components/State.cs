using Godot;
using System;

public class State : Node
{
    private StateMachine _StateMachine = null;
    private State _Parent = null;

    private StateMachine _GetStateMachine(Node node) {
        return null;
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        CallDeferred(nameof(Setup));
        CallDeferred(nameof(_GetStateMachine), this);
    }

    public void Enter(Godot.Collections.Dictionary message) {
    }

    public void Exit() {
    }

    public void PhysicsProcess(float delta) {
    }

    public void Process(float delta) {
    }

    private void Setup() {
        _Parent = GetParent() as State;
    }

    public void UnhandledInput(InputEvent @event) {
    }
}
