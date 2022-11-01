using Godot;
using System;

public class Component : Node
{
    private int EntityID;
    private ComponentSystem ComponentControl;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    private virtual string ComponentString() {
        return "Component: component, Entity: " + EntityID;
    }

    private void RegisterToSystem() {
        if(ComponentControl) {
            ComponentControl.RegisterComponent(EntityID, this);
        } else {
            // Print some sort of error
            GD.Print("Error: No component system found for " + this.ComponentString());
        }
    }

    private void SetEntityID() {

    }
}
