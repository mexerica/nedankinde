extends Area2D

const SPEED = 100.0
var count = 0;

func _process(delta):
	if count <= 50: 
		position.y += delta * SPEED * 3;
		count += 1;
	else :
		position.x += delta * SPEED
		position.y -= delta * (SPEED  / 5);

func _on_area_entered(area):
	queue_free();

func _on_body_entered(body):
	queue_free();
