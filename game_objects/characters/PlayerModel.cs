using Godot;
using System;

public class PlayerModel : Spatial
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private enum States {
        Idle,
        Run,
        Air
    }
    private AnimationTree Animator;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        Animator = GetNode<AnimationTree>("AnimationTree");
        Animator.Active = true;
    }
}
