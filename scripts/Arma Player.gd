extends Area2D

const SPEED = 300.0

func _process(delta):
	position.y -= delta * SPEED	
