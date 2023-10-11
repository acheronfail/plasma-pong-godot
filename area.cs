using Godot;
using System;

public partial class area : Node2D
{
	public Vector2[] particles;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var x = new Vector2(0, 2);
		GD.Print(x);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
