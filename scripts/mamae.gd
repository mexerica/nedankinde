extends CharacterBody2D

var arma_mae = preload("res://cenas/arma_mae.tscn"); 
@onready var Tiro_pos = $Tiro_pos;
var atire = true;

func _process(delta):
	if atire :
		atirar();
		atire = false;

func atirar():
	var bala = arma_mae.instantiate();
	get_parent().get_parent().add_child(bala);
	bala.global_position = Tiro_pos.global_position;
