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
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

    public Player GetPlayerOwner() {
        return PlayerOwner;
    }

    private void SetPlayerOwner() {
        PlayerOwner = (Player)Owner;
    }
}
