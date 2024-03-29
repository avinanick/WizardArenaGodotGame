using Godot;
using System;

public abstract class Component : Node
{
    private int EntityID;
    protected ComponentSystem ComponentControl = null;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
    }

    protected virtual string ComponentString() {
        return "Component: component, Entity: " + EntityID;
    }

    public virtual void RegisterToSystem() {
        SetEntityID();
        if(ComponentControl != null) {
            ComponentControl.RegisterComponent(EntityID, this);
        } else {
            // Print some sort of error
            GD.Print("Error: No component system found for " + this.ComponentString());
        }
    }

    private void SetEntityID() {
        EntityID = GetParent<Entity>().GetID();
    }
}
