using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protagonista : MonoBehaviour {

    private Rigidbody2D body;
    private SpriteRenderer imagem;

    float horizontal;
    float vertical;

    [SerializeField] private List<Sprite> sprites;

    [Range(0, 10.0f)][SerializeField] private float velocidade = 3.0f;

    void Start() {
        body = GetComponent<Rigidbody2D>(); 
        imagem = GetComponent<SpriteRenderer>();
        imagem.sprite = sprites[0];
    }

    private void FixedUpdate() {  
        body.velocity = new Vector2(horizontal * velocidade, vertical * velocidade);
        imagem.sprite = sprites[(horizontal == 0) ? 0 : 1];
        imagem.flipX = horizontal == 1;
    }

    void Update() {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); 
    }
}
