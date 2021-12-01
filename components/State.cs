using Godot;
using System;

public class State : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

    public void PhysicsProcess(float delta) {

    }

    public void Process(float delta) {
        
    }

    public void UnhandledInput(InputEvent @event) {
        
    }
}
