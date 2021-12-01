using Godot;
using System;

public class State : Node
{
    private State _Parent = null;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        CallDeferred(nameof(Setup));
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

    public void Enter(Godot.Collections.Dictionary message) {
    }

    public void Exit() {
    }

    public void PhysicsProcess(float delta) {
    }

    public void Process(float delta) {
    }

    public void UnhandledInput(InputEvent @event) {
    }

    private void Setup() {
        _Parent = GetParent() as State;
    }
}
