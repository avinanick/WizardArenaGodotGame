using Godot;
using System;

public class EntitySystem : Node
{
    int PreviousID = 0;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

    public int AssignID() {
        PreviousID++;
        return PreviousID;
    }
}
