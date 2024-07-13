extends Area2D

const SPEED = 300.0

func _process(delta):
	position.y -= delta * SPEED;

func _on_area_entered(area):
	queue_free();

func _on_body_entered(body):
	queue_free();
