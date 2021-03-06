using Godot;
using System;

public class PlayerState : State
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    protected Player PlayerOwner;
    protected PlayerModel PlayerSkin;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
    }

    protected override void Setup()
    {
        base.Setup();
        PlayerOwner = (Player)Owner;
        PlayerSkin = PlayerOwner.GetSkin();
    }
}
