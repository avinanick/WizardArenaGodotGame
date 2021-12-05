using Godot;
using System;

public class State : Node
{
    protected StateMachine _StateMachine = null;
    protected State _Parent = null;

    private StateMachine _GetStateMachine(Node node) {
        // This function will cause a crash if there is no state machine
        // in the heirarchy above the calling state
        if(node is StateMachine machine) {
            return machine;
        }
        return _GetStateMachine(node.GetParent());
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        CallDeferred(nameof(Setup));
        CallDeferred(nameof(AssignStateMachine));
    }

    private void AssignStateMachine() {
        _StateMachine = _GetStateMachine(this);
    }

    public void Enter(Godot.Collections.Dictionary message) {
    }

    public void Exit() {
    }

    public virtual void PhysicsProcess(float delta) {
    }

    public virtual void Process(float delta) {
    }

    protected virtual void Setup() {
        _Parent = GetParent() as State;
    }

    public virtual void UnhandledInput(InputEvent @event) {
    }
}
