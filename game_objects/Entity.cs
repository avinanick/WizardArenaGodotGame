using Godot;
using System;

public class Entity : KinematicBody
{
    private int EntityID;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public int GetID() {
        return EntityID;
    }

    private void SetID() {

    }
}
