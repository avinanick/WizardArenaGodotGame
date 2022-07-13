using Godot;
using System;

public class Hitpoints : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export]
    private int MaxHealth = 10;
    private int CurrentHealth = 0;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        CurrentHealth = MaxHealth;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

    public void TakeDamage(int amount) {
        
    }
}
