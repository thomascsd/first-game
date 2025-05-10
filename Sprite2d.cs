using Godot;
using System;

public partial class Sprite2d : Sprite2D
{
	private int _speed = 400;
	private float _angularSpeed = Mathf.Pi;

	public Sprite2d()
	{
		GD.Print("Hellow World");
	}

	public override void _Process(double delta)
	{
		var velocity = Vector2.Zero;
		// int direction = 0;
		// if (Input.IsActionPressed("ui_right"))
		// {
		// 	direction += 1;
		// }
		// else if (Input.IsActionPressed("ui_left"))
		// {
		// 	direction -= 1;
		// }

		// this.Rotation += _angularSpeed * direction * (float)delta;
		this.Rotation += _angularSpeed *  (float)delta;
		velocity = Vector2.Up.Rotated(this.Rotation) * _speed;

		// if (Input.IsActionPressed("ui_up"))
		// {
		// 	velocity += Vector2.Up.Rotated(this.Rotation) * _speed;
		// }

		this.Position += velocity * (float)delta;

		base._Process(delta);
	}

	private void OnButtonPressed()
	{
		this.SetProcess(!this.IsProcessing());
	}

}
