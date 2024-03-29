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

    public virtual Component FindComponent(int entityID) {
        if(SystemComponents.ContainsKey(entityID)) {
            return SystemComponents[entityID];
        }
        return null;
    }

    public virtual void RegisterComponent(int entityID, Component newComponent) {
        // NOTE: Current implimentation does not allow for more than
        // one component of the same type on an entity.
        SystemComponents.Add(entityID, newComponent);
    }
}
