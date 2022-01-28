using Godot;
using System;

public class CameraState : State
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    CameraRig Rig;

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

    public override void Process(float delta) {
        Transform moveTransform = Rig.GlobalTransform;
        moveTransform.origin = Rig.GetPlayerOwner().GlobalTransform.origin + Rig.GetStartingPosition();
        Rig.GlobalTransform = moveTransform;
    }

    protected override void Setup()
    {
        base.Setup();
        Rig = (CameraRig)this.Owner;
    }
}
