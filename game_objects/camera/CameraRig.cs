using Godot;
using System;

public class CameraRig : Spatial
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private Player PlayerOwner = null;
    private Vector3 PositionStart;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        SetAsToplevel(true);
        CallDeferred(nameof(SetPlayerOwner));  
        PositionStart = this.Transform.origin;      
    }

    public Player GetPlayerOwner() {
        return PlayerOwner;
    }

    public Vector3 GetStartingPosition() {
        return PositionStart;
    }

    private void SetPlayerOwner() {
        PlayerOwner = (Player)Owner;
    }
}
