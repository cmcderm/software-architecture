using Godot;
using System;

public partial class DragNDrop : Node2D {
	
	public override void _Ready() {
		GD.Print("Hello from Ready!");
	}
	
	public override void _Process(double delta) {
		GD.Print("Hello World!");
		
	}
}
