using Godot;
using System;

public class Player : KinematicBody
{
    private PlayerModel Skin;
    private StateMachine Machine;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        Skin = GetNode<PlayerModel>("PlayerModel");
        Machine = GetNode<StateMachine>("StateMachine");
    }
}
