using Godot;
using System;
using System.Collections.Generic;

public class ComponentSystem : Node
{
    private Dictionary<int, Component> Components = new Dictionary<int, Component>();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void RegisterComponent(int entityID, Component newComponent) {

    }
}
