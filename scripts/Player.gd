extends CharacterBody2D

const SPEED = 300.0
var arma_player = preload("res://cenas/arma_player.tscn"); 
var arma_especial = preload("res://cenas/arma_especial.tscn");
@onready var Tiro_pos = $Tiro_pos;

func _physics_process(delta):
	var directionX = Input.get_axis("ui_left", "ui_right")
	var directionY = Input.get_axis("ui_up", "ui_down")
	if directionX: velocity.x = directionX * SPEED
	else: velocity.x = move_toward(velocity.x, 0, SPEED)
	if directionY: velocity.y = directionY * SPEED
	else: velocity.y = move_toward(velocity.y, 0, SPEED)
	move_and_slide()
	
	if Input.is_action_just_pressed("shoot"): atirar("normal");
	if Input.is_action_just_pressed("especial"): atirar("especial");

func atirar(type):
	var bala = null; 
	if type == "normal": bala = arma_player.instantiate();
	else: bala = arma_especial.instantiate();
	add_child(bala);
	bala.global_position = Tiro_pos.global_position;
