using Godot;
using System;

public class TestComponentSystem : ComponentSystem
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

    public override void RegisterComponent(int entityID, Component newComponent) {
        base.RegisterComponent(entityID, newComponent);
        GD.Print("Registering component for entity " + entityID);
    }
}
