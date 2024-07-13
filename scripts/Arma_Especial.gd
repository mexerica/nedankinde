extends Area2D

const SPEED = 200.0
var count = 0;

func _process(delta):
	if count <= 80: 
		position.y -= delta * SPEED;
		count += 1;
	else :
		position.y += delta * SPEED
	rotation += 1 * delta;

func _on_area_entered(area):
	queue_free();

func _on_body_entered(body):
	queue_free();
