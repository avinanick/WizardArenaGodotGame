using Godot;
using System;

public class Entity : KinematicBody
{
    private int EntityID;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        CallDeferred("SetID");
    }

    public int GetID() {
        return EntityID;
    }

    private void SetID() {
        EntityID = GetNode<EntitySystem>("/root/EntitySystem").AssignID();
        Godot.Collections.Array<Component> components = GetChildren<Component>();
        foreach (Component childComponent in components) {
            childComponent.RegisterToSystem();
        }
    }
}
