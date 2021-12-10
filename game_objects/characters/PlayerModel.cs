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
    private AnimationNodeStateMachinePlayback Playback;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        Animator = GetNode<AnimationTree>("AnimationTree");
        Animator.Active = true;
        Playback = (AnimationNodeStateMachinePlayback)Animator.Get("parameters/playback");
    }

    public void TransitionTo(int stateID) {
        switch((States)stateID) {
            case States.Idle:
                Playback.Travel("Idle");
                break;
            case States.Run:
                Playback.Travel("Run");
                break;
            case States.Air:
                break;
            default:
                Playback.Travel("Idle");
                break;
        }
    }
}
