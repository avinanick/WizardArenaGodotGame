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
        // This doesn't work, will need a different way to get component children.
        Godot.Collections.Array children = GetChildren();
        foreach (Node child in children) {
            if(child is Component childComponent) {
                childComponent.RegisterToSystem();
            }
        }
    }
}
