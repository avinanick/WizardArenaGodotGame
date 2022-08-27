using Godot;
using System;
using System.Collections.Generic;

public class ComponentSystem : Node
{
    
    private Dictionary<int, Component> SystemComponents = new Dictionary<int, Component>();

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

    public virtual void RegisterComponent(Component newComponent, int entityID) {
        
    }
}
